﻿
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[s_RecalculateLedger]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[s_RecalculateLedger]
GO

CREATE PROCEDURE [dbo].[s_RecalculateLedger]
		@AcctNo VARCHAR(10)
		,@StartDate DATE
		,@Result INT OUTPUT
AS
BEGIN
	DECLARE  @CURRENTACCT VARCHAR(10) = ''
			,@NEWTRANBBAL NUMERIC(11,2)		
			,@NEWTRANEBAL NUMERIC(11,2)
			,@SDTRAN_ID BIGINT
			,@ACCTNUM VARCHAR(10)
			,@TRANBBAL NUMERIC(11,2)
			,@TRANDEB NUMERIC(11,2)
			,@TRANCRE NUMERIC(11,2)
			,@TRANEBAL NUMERIC(11,2)

	BEGIN TRAN
		BEGIN TRY
			DECLARE db_cursor CURSOR FOR  	
			SELECT 
				 SDTRAN_ID
				,ACCTNUM
				,TRANBBAL
				,TRANDEB
				,TRANCRE
				,TRANEBAL			
			FROM SDTRAN TXN
			WHERE (@AcctNo = '' OR
					(@AcctNo !='' AND @AcctNo = ACCTNUM)) AND				
				   (@StartDate IS NULL OR
				   (@StartDate IS NOT NULL AND TRANDATE >= @StartDate ))				
					AND (TRANDEB > 0 OR TRANCRE > 0)
					AND ACCTNUM IS NOT NULL	
					AND EXISTS (SELECT 1 FROM SDMASTER SDM WHERE SDM.ACCTNO = TXN.ACCTNUM AND SDM.ACCTSTAT='A')			
					
			ORDER BY
				 ACCTNUM
				,TRANDATE
				,SDTRAN_ID			
			OPEN db_cursor   
			FETCH NEXT FROM db_cursor INTO @SDTRAN_ID,@ACCTNUM ,@TRANBBAL ,@TRANDEB ,@TRANCRE ,@TRANEBAL

			WHILE @@FETCH_STATUS = 0   
			BEGIN   
					IF @CURRENTACCT != @ACCTNUM
						BEGIN							
							PRINT 'SDM:' +  @CURRENTACCT + ',' + ISNULL(CAST(@NEWTRANBBAL AS VARCHAR(20)),'') + ',' + ISNULL(CAST(@TRANDEB AS VARCHAR(20)),'') + ',' + ISNULL(CAST(@TRANCRE AS VARCHAR(20)),'') + ',' + ISNULL(CAST(@NEWTRANEBAL AS VARCHAR(20)),'')
								UPDATE SDMASTER SET ACCTABAL =  @NEWTRANEBAL - (ACCTFLOATS),ACCTOBAL = @NEWTRANEBAL  where ACCTNO = @CURRENTACCT
								
							SET @CURRENTACCT = @ACCTNUM
							SET @NEWTRANBBAL = @TRANBBAL
						END
					ELSE					
						BEGIN												
							SET @NEWTRANBBAL = @NEWTRANEBAL
						END
					
					
					
					SET @NEWTRANEBAL = (@TRANCRE - @TRANDEB) + @NEWTRANBBAL 
					PRINT '---:' +  CAST(@SDTRAN_ID AS VARCHAR(20)) + ',' + @ACCTNUM + ',' + ISNULL(CAST(@NEWTRANBBAL AS VARCHAR(20)),'') + ',' + ISNULL(CAST(@TRANDEB AS VARCHAR(20)),'') + ',' + ISNULL(CAST(@TRANCRE AS VARCHAR(20)),'') + ',' + ISNULL(CAST(@NEWTRANEBAL AS VARCHAR(20)),'')								
					UPDATE SDTRAN SET
						 TRANBBAL =  @NEWTRANBBAL			 					
						,TRANEBAL =  @NEWTRANEBAL				
					WHERE SDTRAN_ID=@SDTRAN_ID				
			
					FETCH NEXT FROM db_cursor INTO @SDTRAN_ID,@ACCTNUM ,@TRANBBAL ,@TRANDEB ,@TRANCRE ,@TRANEBAL
			END		
			CLOSE db_cursor   
			DEALLOCATE db_cursor
				PRINT 'SDM:' +  @CURRENTACCT + ',' + ISNULL(CAST(@NEWTRANBBAL AS VARCHAR(20)),'') + ',' + ISNULL(CAST(@TRANDEB AS VARCHAR(20)),'') + ',' + ISNULL(CAST(@TRANCRE AS VARCHAR(20)),'') + ',' + ISNULL(CAST(@NEWTRANEBAL AS VARCHAR(20)),'')
				UPDATE SDMASTER SET ACCTABAL =  @NEWTRANEBAL - (ACCTFLOATS),ACCTOBAL = @NEWTRANEBAL  where ACCTNO = @CURRENTACCT

		END TRY
		BEGIN CATCH

		IF @@TRANCOUNT > 0
			SET @Result = 0
			ROLLBACK TRANSACTION;
			 
		END CATCH;

		IF @@TRANCOUNT > 0
			SET @Result = 1
			COMMIT TRANSACTION;


END		
GO		