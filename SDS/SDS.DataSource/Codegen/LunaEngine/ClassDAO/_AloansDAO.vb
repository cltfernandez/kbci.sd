#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 20/06/2015 
#End Region


Imports System.Data.Common
''' <summary>
'''This class manage persistency on db of Aloans object
''' </summary>
''' <remarks>
'''
''' </remarks>

Public MustInherit Class _AloansDAO
Inherits LUNA.LunaBaseClassDAO(Of Aloans)

''' <summary>
'''New() create an istance of this class. Use default DB Connection
''' </summary>
''' <returns>
'''
''' </returns>
Public Sub New()
	MyBase.New()
End Sub

''' <summary>
'''New() create an istance of this class and specify an OPENED DB connection
''' </summary>
''' <returns>
'''
''' </returns>
Public Sub New(ByVal Connection As DbConnection)
	MyBase.New(Connection)
End Sub

''' <summary>
'''Read from DB table Aloans
''' </summary>
''' <returns>
'''Return a Aloans object
''' </returns>
Public Overrides Function Read(Id as integer) as Aloans
    Dim cls as new Aloans

    Try
        Using myCommand As DbCommand = _cn.CreateCommand
        
            myCommand.CommandText = "SELECT * FROM Aloans where ALOANS_ID = " & Id
            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
            Using myReader As DbDataReader = myCommand.ExecuteReader

                myReader.Read()
                if myReader.HasRows then
                    cls.FillFromDataRecord(CType(myReader, IDataRecord))	
                End If
                myReader.Close()
            End Using
        End Using
    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return cls
End Function

''' <summary>
'''Save on DB table Aloans
''' </summary>
''' <returns>
'''Return ID insert in DB
''' </returns>
Public Overrides Function Save(byRef cls as Aloans) as Integer

    Dim Ris as integer=0 'in Ris return Insert Id

    If cls.IsValid Then
        If cls.IsChanged Then
            Using myCommand As DbCommand = _Cn.CreateCommand()
	            Try
		            Dim sql As String = String.Empty
		            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
		            If cls.ALOANS_ID = 0 Then
                        sql = "INSERT INTO Aloans ("
                            sql &= " PN_NO,"
                            sql &= " KBCI_NO,"
                            sql &= " APP_DATE,"
                            sql &= " APP_NO,"
                            sql &= " DATE_GRANT,"
                            sql &= " BY_WHOM,"
                            sql &= " DATE_DUE,"
                            sql &= " CHKNO_BANK,"
                            sql &= " CHKNO,"
                            sql &= " CHKNO_AMT,"
                            sql &= " CHKNO_DATE,"
                            sql &= " CHKNO_RELS,"
                            sql &= " CHKNO_ACK,"
                            sql &= " MOD_PAY,"
                            sql &= " AMORT_AMT,"
                            sql &= " PAY_START,"
                            sql &= " RATE,"
                            sql &= " TERM,"
                            sql &= " FREQ,"
                            sql &= " PRINCIPAL,"
                            sql &= " LED_TYPE,"
                            sql &= " ADV_INTE,"
                            sql &= " AFT_INTE,"
                            sql &= " ACCU_PAYP,"
                            sql &= " YTD_I,"
                            sql &= " LOAN_TYPE,"
                            sql &= " LOAN_STAT,"
                            sql &= " ARREAR_I,"
                            sql &= " ARREAR_P,"
                            sql &= " ARREAR_OTH,"
                            sql &= " ARREAR_AS,"
                            sql &= " COLLATERAL,"
                            sql &= " DED_BAL,"
                            sql &= " ADD_DATE,"
                            sql &= " CHG_DATE,"
                            sql &= " USER,"
                            sql &= " P_BAL,"
                            sql &= " I_BAL,"
                            sql &= " O_BAL,"
                            sql &= " REC_STAT,"
                            sql &= " RENEW,"
                            sql &= " ADVANCE,"
                            sql &= " LRI_IND,"
                            sql &= " NDUE"
                      sql &= ") VALUES ("
                      sql &= " @PN_NO,"
                      sql &= " @KBCI_NO,"
                      sql &= " @APP_DATE,"
                      sql &= " @APP_NO,"
                      sql &= " @DATE_GRANT,"
                      sql &= " @BY_WHOM,"
                      sql &= " @DATE_DUE,"
                      sql &= " @CHKNO_BANK,"
                      sql &= " @CHKNO,"
                      sql &= " @CHKNO_AMT,"
                      sql &= " @CHKNO_DATE,"
                      sql &= " @CHKNO_RELS,"
                      sql &= " @CHKNO_ACK,"
                      sql &= " @MOD_PAY,"
                      sql &= " @AMORT_AMT,"
                      sql &= " @PAY_START,"
                      sql &= " @RATE,"
                      sql &= " @TERM,"
                      sql &= " @FREQ,"
                      sql &= " @PRINCIPAL,"
                      sql &= " @LED_TYPE,"
                      sql &= " @ADV_INTE,"
                      sql &= " @AFT_INTE,"
                      sql &= " @ACCU_PAYP,"
                      sql &= " @YTD_I,"
                      sql &= " @LOAN_TYPE,"
                      sql &= " @LOAN_STAT,"
                      sql &= " @ARREAR_I,"
                      sql &= " @ARREAR_P,"
                      sql &= " @ARREAR_OTH,"
                      sql &= " @ARREAR_AS,"
                      sql &= " @COLLATERAL,"
                      sql &= " @DED_BAL,"
                      sql &= " @ADD_DATE,"
                      sql &= " @CHG_DATE,"
                      sql &= " @USER,"
                      sql &= " @P_BAL,"
                      sql &= " @I_BAL,"
                      sql &= " @O_BAL,"
                      sql &= " @REC_STAT,"
                      sql &= " @RENEW,"
                      sql &= " @ADVANCE,"
                      sql &= " @LRI_IND,"
                      sql &= " @NDUE"
                      sql &= ")"
		            Else
			            sql = "UPDATE Aloans SET "
                  sql &= "PN_NO = @PN_NO,"
                  sql &= "KBCI_NO = @KBCI_NO,"
                  sql &= "APP_DATE = @APP_DATE,"
                  sql &= "APP_NO = @APP_NO,"
                  sql &= "DATE_GRANT = @DATE_GRANT,"
                  sql &= "BY_WHOM = @BY_WHOM,"
                  sql &= "DATE_DUE = @DATE_DUE,"
                  sql &= "CHKNO_BANK = @CHKNO_BANK,"
                  sql &= "CHKNO = @CHKNO,"
                  sql &= "CHKNO_AMT = @CHKNO_AMT,"
                  sql &= "CHKNO_DATE = @CHKNO_DATE,"
                  sql &= "CHKNO_RELS = @CHKNO_RELS,"
                  sql &= "CHKNO_ACK = @CHKNO_ACK,"
                  sql &= "MOD_PAY = @MOD_PAY,"
                  sql &= "AMORT_AMT = @AMORT_AMT,"
                  sql &= "PAY_START = @PAY_START,"
                  sql &= "RATE = @RATE,"
                  sql &= "TERM = @TERM,"
                  sql &= "FREQ = @FREQ,"
                  sql &= "PRINCIPAL = @PRINCIPAL,"
                  sql &= "LED_TYPE = @LED_TYPE,"
                  sql &= "ADV_INTE = @ADV_INTE,"
                  sql &= "AFT_INTE = @AFT_INTE,"
                  sql &= "ACCU_PAYP = @ACCU_PAYP,"
                  sql &= "YTD_I = @YTD_I,"
                  sql &= "LOAN_TYPE = @LOAN_TYPE,"
                  sql &= "LOAN_STAT = @LOAN_STAT,"
                  sql &= "ARREAR_I = @ARREAR_I,"
                  sql &= "ARREAR_P = @ARREAR_P,"
                  sql &= "ARREAR_OTH = @ARREAR_OTH,"
                  sql &= "ARREAR_AS = @ARREAR_AS,"
                  sql &= "COLLATERAL = @COLLATERAL,"
                  sql &= "DED_BAL = @DED_BAL,"
                  sql &= "ADD_DATE = @ADD_DATE,"
                  sql &= "CHG_DATE = @CHG_DATE,"
                  sql &= "USER = @USER,"
                  sql &= "P_BAL = @P_BAL,"
                  sql &= "I_BAL = @I_BAL,"
                  sql &= "O_BAL = @O_BAL,"
                  sql &= "REC_STAT = @REC_STAT,"
                  sql &= "RENEW = @RENEW,"
                  sql &= "ADVANCE = @ADVANCE,"
                  sql &= "LRI_IND = @LRI_IND,"
                  sql &= "NDUE = @NDUE"
			            sql &= " WHERE ALOANS_ID= " & cls.ALOANS_ID
		            End if
					
					Dim p As DbParameter = Nothing 
					p = myCommand.CreateParameter
					p.ParameterName = "@PN_NO"
					p.Value = cls.PN_NO
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@KBCI_NO"
					p.Value = cls.KBCI_NO
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@APP_DATE"
					p.DbType = DbType.DateTime
					if cls.APP_DATE <> Date.MinValue then
			            p.Value = cls.APP_DATE
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@APP_NO"
					p.Value = cls.APP_NO
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@DATE_GRANT"
					p.DbType = DbType.DateTime
					if cls.DATE_GRANT <> Date.MinValue then
			            p.Value = cls.DATE_GRANT
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@BY_WHOM"
					p.Value = cls.BY_WHOM
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@DATE_DUE"
					p.DbType = DbType.DateTime
					if cls.DATE_DUE <> Date.MinValue then
			            p.Value = cls.DATE_DUE
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CHKNO_BANK"
					p.Value = cls.CHKNO_BANK
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CHKNO"
					p.Value = cls.CHKNO
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CHKNO_AMT"
					p.Value = cls.CHKNO_AMT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CHKNO_DATE"
					p.DbType = DbType.DateTime
					if cls.CHKNO_DATE <> Date.MinValue then
			            p.Value = cls.CHKNO_DATE
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CHKNO_RELS"
					p.Value = cls.CHKNO_RELS
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CHKNO_ACK"
					p.DbType = DbType.DateTime
					if cls.CHKNO_ACK <> Date.MinValue then
			            p.Value = cls.CHKNO_ACK
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@MOD_PAY"
					p.Value = cls.MOD_PAY
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@AMORT_AMT"
					p.Value = cls.AMORT_AMT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@PAY_START"
					p.DbType = DbType.DateTime
					if cls.PAY_START <> Date.MinValue then
			            p.Value = cls.PAY_START
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@RATE"
					p.Value = cls.RATE
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@TERM"
					p.Value = cls.TERM
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@FREQ"
					p.Value = cls.FREQ
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@PRINCIPAL"
					p.Value = cls.PRINCIPAL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@LED_TYPE"
					p.Value = cls.LED_TYPE
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ADV_INTE"
					p.Value = cls.ADV_INTE
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@AFT_INTE"
					p.Value = cls.AFT_INTE
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCU_PAYP"
					p.Value = cls.ACCU_PAYP
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@YTD_I"
					p.Value = cls.YTD_I
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@LOAN_TYPE"
					p.Value = cls.LOAN_TYPE
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@LOAN_STAT"
					p.Value = cls.LOAN_STAT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ARREAR_I"
					p.Value = cls.ARREAR_I
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ARREAR_P"
					p.Value = cls.ARREAR_P
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ARREAR_OTH"
					p.Value = cls.ARREAR_OTH
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ARREAR_AS"
					p.DbType = DbType.DateTime
					if cls.ARREAR_AS <> Date.MinValue then
			            p.Value = cls.ARREAR_AS
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@COLLATERAL"
					p.Value = cls.COLLATERAL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@DED_BAL"
					p.Value = cls.DED_BAL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ADD_DATE"
					p.DbType = DbType.DateTime
					if cls.ADD_DATE <> Date.MinValue then
			            p.Value = cls.ADD_DATE
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CHG_DATE"
					p.DbType = DbType.DateTime
					if cls.CHG_DATE <> Date.MinValue then
			            p.Value = cls.CHG_DATE
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@USER"
					p.Value = cls.USER
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@P_BAL"
					p.Value = cls.P_BAL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@I_BAL"
					p.Value = cls.I_BAL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@O_BAL"
					p.Value = cls.O_BAL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@REC_STAT"
					p.Value = cls.REC_STAT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@RENEW"
					p.Value = cls.RENEW
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ADVANCE"
					p.Value = cls.ADVANCE
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@LRI_IND"
					p.Value = cls.LRI_IND
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@NDUE"
					p.DbType = DbType.DateTime
					if cls.NDUE <> Date.MinValue then
			            p.Value = cls.NDUE
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

                    myCommand.CommandType = CommandType.Text
		            myCommand.CommandText = sql
		            myCommand.ExecuteNonQuery()

		            
					If cls.ALOANS_ID=0 Then
			            Dim IdInserito as integer = 0
			            Sql = "select @@identity"
			            myCommand.CommandText = Sql
			            Idinserito = myCommand.ExecuteScalar()
			            cls.ALOANS_ID = Idinserito
			            Ris = Idinserito
		            else
			            Ris  =  cls.ALOANS_ID
		            End If
		            

	            Catch ex As Exception
		            ManageError(ex)
	            End Try
            End Using
        else
	        Ris  =  cls.ALOANS_ID
        End If

    Else
	    throw new ApplicationException("Object data is not valid")
    End If
    Return Ris
End Function

Private Sub DestroyPermanently(Id as integer) 
    Try

    Using myCommand As DbCommand = _Cn.CreateCommand
        myCommand.Connection = _cn

        '******IMPORTANT: You can use this commented instruction to make a logical delete .
        '******Replace DELETED Field with your logic deleted field name.
        'Dim Sql As String = "UPDATE Aloans SET DELETED=True "
        Dim Sql As String = "DELETE FROM Aloans"
        Sql &= " Where ALOANS_ID = " & Id 

        myCommand.CommandText = Sql
        If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
        myCommand.ExecuteNonQuery()
    
    End Using
    Catch ex As Exception
	    ManageError(ex)
    End Try
End Sub

''' <summary>
'''Delete from DB table Aloans. Accept id of object to delete.
''' </summary>
Public Overrides Sub Delete(Id as integer) 
        DestroyPermanently (Id)
    End Sub

''' <summary>
'''Delete from DB table Aloans. Accept object to delete and optional a List to remove the object from.
''' </summary>
Public Overrides Sub Delete(byref obj as Aloans, Optional ByRef ListaObj as List (of Aloans) = Nothing)
        DestroyPermanently (obj.ALOANS_ID)
    If Not ListaObj Is Nothing Then ListaObj.Remove(obj)
     
End Sub

''' <summary>
'''Find on DB table Aloans
''' </summary>
''' <returns>
'''Return first of Aloans
''' </returns>
Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Aloans
    Dim ris As Aloans = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1}
    Dim l As IEnumerable(Of Aloans) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function

''' <summary>
'''Find on DB table Aloans
''' </summary>
''' <returns>
'''Return first of Aloans
''' </returns>
Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Aloans
    Dim ris As Aloans = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1, .OrderBy = OrderBy}
    Dim l As IEnumerable(Of Aloans) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function
''' <summary>
'''Find on DB table Aloans
''' </summary>
''' <returns>
'''Return a list of Aloans
''' </returns>
Public Overrides Function FindAll(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Aloans)
    Dim So As New Luna.LunaSearchOption
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Aloans
''' </summary>
''' <returns>
'''Return a list of Aloans
''' </returns>
Public Overloads Function FindAll(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Aloans)
    Dim So As New Luna.LunaSearchOption With {.OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Aloans
''' </summary>
''' <returns>
'''Return a list of Aloans
''' </returns>
Public Overloads Function FindAll(byVal Top as integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Aloans)
    Dim So As New Luna.LunaSearchOption With {.Top = Top, .OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Aloans
''' </summary>
''' <returns>
'''Return a list of Aloans
''' </returns>
Public Overloads Function FindAll(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Aloans)
    Return FindReal(SearchOption, Parameter)
End Function

Private Function FindReal(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as iEnumerable(Of Aloans)
    Dim Ls As New List(Of Aloans)
    Try

    Dim sql As String = ""
    sql ="SELECT "   
		if SearchOption.Top then sql &= " TOP " & SearchOption.Top
		sql &=" * from Aloans" 
    For Each Par As LUNA.LunaSearchParameter In Parameter
	    If Not Par Is Nothing Then
		    If Sql.IndexOf("WHERE") = -1 Then Sql &= " WHERE " Else Sql &=  " " & Par.LogicOperatorStr & " "
		        sql &= Par.FieldName & " " & Par.SqlOperator
                If Par.SqlOperator.IndexOf("IN") <> -1 Then
                    sql &= " " & ApIn(Par.Value)
                Else
                    sql &= " " & Ap(Par.Value)
                End If
	    End if
    Next

    If SearchOption.OrderBy.Length Then Sql &= " ORDER BY " & SearchOption.OrderBy

	
    Ls = GetData(sql, SearchOption.AddEmptyItem)

    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ls
End Function

Public Overrides Function GetAll(Optional OrderByField as string = "", Optional ByVal AddEmptyItem As Boolean = False) as iEnumerable(Of Aloans)
    Dim Ls As New List(Of Aloans)
    Try

    Dim sql As String = ""
    sql ="SELECT * from Aloans" 
    If OrderByField.Length Then
	    Sql &= " ORDER BY " & OrderByField
    End If

    Ls = GetData(Sql,AddEmptyItem)

    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ls
End Function



    Protected Function GetData(ByVal sql As String, Optional ByVal AddEmptyItem As Boolean = False) As iEnumerable(Of Aloans)
        Dim Ls As New List(Of Aloans)
        Try
            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = sql
                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                Using myReader As DbDataReader = myCommand.ExecuteReader()
                    If AddEmptyItem Then Ls.Add(New Aloans() With {.ALOANS_ID = Nothing, .PN_NO = "", .KBCI_NO = "", .APP_DATE = Nothing, .APP_NO = 0, .DATE_GRANT = Nothing, .BY_WHOM = "", .DATE_DUE = Nothing, .CHKNO_BANK = "", .CHKNO = "", .CHKNO_AMT = 0, .CHKNO_DATE = Nothing, .CHKNO_RELS = "", .CHKNO_ACK = Nothing, .MOD_PAY = "", .AMORT_AMT = 0, .PAY_START = Nothing, .RATE = 0, .TERM = 0, .FREQ = "", .PRINCIPAL = 0, .LED_TYPE = 0, .ADV_INTE = 0, .AFT_INTE = 0, .ACCU_PAYP = 0, .YTD_I = 0, .LOAN_TYPE = "", .LOAN_STAT = "", .ARREAR_I = 0, .ARREAR_P = 0, .ARREAR_OTH = 0, .ARREAR_AS = Nothing, .COLLATERAL = False, .DED_BAL = "", .ADD_DATE = Nothing, .CHG_DATE = Nothing, .USER = "", .P_BAL = 0, .I_BAL = 0, .O_BAL = 0, .REC_STAT = False, .RENEW = False, .ADVANCE = 0, .LRI_IND = False, .NDUE = Nothing})
                    While myReader.Read
                        Dim classe As New Aloans(CType(myReader, IDataRecord))
                        Ls.Add(classe)
                    End While
                    myReader.Close()
                End Using
            End Using

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ls
    End Function
End Class
