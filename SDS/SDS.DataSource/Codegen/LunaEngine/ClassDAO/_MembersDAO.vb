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
'''This class manage persistency on db of Members object
''' </summary>
''' <remarks>
'''
''' </remarks>

Public MustInherit Class _MembersDAO
Inherits LUNA.LunaBaseClassDAO(Of Members)

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
'''Read from DB table Members
''' </summary>
''' <returns>
'''Return a Members object
''' </returns>
Public Overrides Function Read(Id as integer) as Members
    Dim cls as new Members

    Try
        Using myCommand As DbCommand = _cn.CreateCommand
        
            myCommand.CommandText = "SELECT * FROM Members where KBCI_ID = " & Id
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
'''Save on DB table Members
''' </summary>
''' <returns>
'''Return ID insert in DB
''' </returns>
Public Overrides Function Save(byRef cls as Members) as Integer

    Dim Ris as integer=0 'in Ris return Insert Id

    If cls.IsValid Then
        If cls.IsChanged Then
            Using myCommand As DbCommand = _Cn.CreateCommand()
	            Try
		            Dim sql As String = String.Empty
		            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
		            If cls.KBCI_ID = 0 Then
                        sql = "INSERT INTO Members ("
                            sql &= " KBCI_NO,"
                            sql &= " LNAME,"
                            sql &= " FNAME,"
                            sql &= " MI,"
                            sql &= " MEM_CODE,"
                            sql &= " MEM_STAT,"
                            sql &= " MEM_DATE,"
                            sql &= " BY_WHOM,"
                            sql &= " CB_EMPNO,"
                            sql &= " CB_HIRE,"
                            sql &= " DEPT,"
                            sql &= " REGION,"
                            sql &= " OFF_TEL,"
                            sql &= " DORI,"
                            sql &= " REA_DORI,"
                            sql &= " SEX,"
                            sql &= " B_DATE,"
                            sql &= " CIV_STAT,"
                            sql &= " MEM_ADDR,"
                            sql &= " RES_TEL,"
                            sql &= " POSITION,"
                            sql &= " SAL_BAS,"
                            sql &= " SAL_ALL,"
                            sql &= " OTH_INC,"
                            sql &= " FEBTC_SA,"
                            sql &= " FEBTC_CA,"
                            sql &= " FD_CERTNO,"
                            sql &= " FD_DATE,"
                            sql &= " AP_AMOUNT,"
                            sql &= " AR_AMOUNT,"
                            sql &= " FD_AMOUNT,"
                            sql &= " SD_AMOUNT,"
                            sql &= " TD_AMOUNT,"
                            sql &= " OTH_AMOUNT,"
                            sql &= " YTD_DIVAMT,"
                            sql &= " YTD_LRI,"
                            sql &= " REM_PROP,"
                            sql &= " REM_VALUE,"
                            sql &= " NO_DEPEND,"
                            sql &= " SP_NAME,"
                            sql &= " SP_EMPLOY,"
                            sql &= " SP_OFFTEL,"
                            sql &= " SP_CBEMPNO,"
                            sql &= " SP_KBCINO,"
                            sql &= " SP_SALARY,"
                            sql &= " APRUN_AMT,"
                            sql &= " ARRUN_AMT,"
                            sql &= " RUN_AMT,"
                            sql &= " ADD_DATE,"
                            sql &= " CHG_DATE,"
                            sql &= " USER,"
                            sql &= " REC_STAT,"
                            sql &= " FD_CNTR"
                      sql &= ") VALUES ("
                      sql &= " @KBCI_NO,"
                      sql &= " @LNAME,"
                      sql &= " @FNAME,"
                      sql &= " @MI,"
                      sql &= " @MEM_CODE,"
                      sql &= " @MEM_STAT,"
                      sql &= " @MEM_DATE,"
                      sql &= " @BY_WHOM,"
                      sql &= " @CB_EMPNO,"
                      sql &= " @CB_HIRE,"
                      sql &= " @DEPT,"
                      sql &= " @REGION,"
                      sql &= " @OFF_TEL,"
                      sql &= " @DORI,"
                      sql &= " @REA_DORI,"
                      sql &= " @SEX,"
                      sql &= " @B_DATE,"
                      sql &= " @CIV_STAT,"
                      sql &= " @MEM_ADDR,"
                      sql &= " @RES_TEL,"
                      sql &= " @POSITION,"
                      sql &= " @SAL_BAS,"
                      sql &= " @SAL_ALL,"
                      sql &= " @OTH_INC,"
                      sql &= " @FEBTC_SA,"
                      sql &= " @FEBTC_CA,"
                      sql &= " @FD_CERTNO,"
                      sql &= " @FD_DATE,"
                      sql &= " @AP_AMOUNT,"
                      sql &= " @AR_AMOUNT,"
                      sql &= " @FD_AMOUNT,"
                      sql &= " @SD_AMOUNT,"
                      sql &= " @TD_AMOUNT,"
                      sql &= " @OTH_AMOUNT,"
                      sql &= " @YTD_DIVAMT,"
                      sql &= " @YTD_LRI,"
                      sql &= " @REM_PROP,"
                      sql &= " @REM_VALUE,"
                      sql &= " @NO_DEPEND,"
                      sql &= " @SP_NAME,"
                      sql &= " @SP_EMPLOY,"
                      sql &= " @SP_OFFTEL,"
                      sql &= " @SP_CBEMPNO,"
                      sql &= " @SP_KBCINO,"
                      sql &= " @SP_SALARY,"
                      sql &= " @APRUN_AMT,"
                      sql &= " @ARRUN_AMT,"
                      sql &= " @RUN_AMT,"
                      sql &= " @ADD_DATE,"
                      sql &= " @CHG_DATE,"
                      sql &= " @USER,"
                      sql &= " @REC_STAT,"
                      sql &= " @FD_CNTR"
                      sql &= ")"
		            Else
			            sql = "UPDATE Members SET "
                  sql &= "KBCI_NO = @KBCI_NO,"
                  sql &= "LNAME = @LNAME,"
                  sql &= "FNAME = @FNAME,"
                  sql &= "MI = @MI,"
                  sql &= "MEM_CODE = @MEM_CODE,"
                  sql &= "MEM_STAT = @MEM_STAT,"
                  sql &= "MEM_DATE = @MEM_DATE,"
                  sql &= "BY_WHOM = @BY_WHOM,"
                  sql &= "CB_EMPNO = @CB_EMPNO,"
                  sql &= "CB_HIRE = @CB_HIRE,"
                  sql &= "DEPT = @DEPT,"
                  sql &= "REGION = @REGION,"
                  sql &= "OFF_TEL = @OFF_TEL,"
                  sql &= "DORI = @DORI,"
                  sql &= "REA_DORI = @REA_DORI,"
                  sql &= "SEX = @SEX,"
                  sql &= "B_DATE = @B_DATE,"
                  sql &= "CIV_STAT = @CIV_STAT,"
                  sql &= "MEM_ADDR = @MEM_ADDR,"
                  sql &= "RES_TEL = @RES_TEL,"
                  sql &= "POSITION = @POSITION,"
                  sql &= "SAL_BAS = @SAL_BAS,"
                  sql &= "SAL_ALL = @SAL_ALL,"
                  sql &= "OTH_INC = @OTH_INC,"
                  sql &= "FEBTC_SA = @FEBTC_SA,"
                  sql &= "FEBTC_CA = @FEBTC_CA,"
                  sql &= "FD_CERTNO = @FD_CERTNO,"
                  sql &= "FD_DATE = @FD_DATE,"
                  sql &= "AP_AMOUNT = @AP_AMOUNT,"
                  sql &= "AR_AMOUNT = @AR_AMOUNT,"
                  sql &= "FD_AMOUNT = @FD_AMOUNT,"
                  sql &= "SD_AMOUNT = @SD_AMOUNT,"
                  sql &= "TD_AMOUNT = @TD_AMOUNT,"
                  sql &= "OTH_AMOUNT = @OTH_AMOUNT,"
                  sql &= "YTD_DIVAMT = @YTD_DIVAMT,"
                  sql &= "YTD_LRI = @YTD_LRI,"
                  sql &= "REM_PROP = @REM_PROP,"
                  sql &= "REM_VALUE = @REM_VALUE,"
                  sql &= "NO_DEPEND = @NO_DEPEND,"
                  sql &= "SP_NAME = @SP_NAME,"
                  sql &= "SP_EMPLOY = @SP_EMPLOY,"
                  sql &= "SP_OFFTEL = @SP_OFFTEL,"
                  sql &= "SP_CBEMPNO = @SP_CBEMPNO,"
                  sql &= "SP_KBCINO = @SP_KBCINO,"
                  sql &= "SP_SALARY = @SP_SALARY,"
                  sql &= "APRUN_AMT = @APRUN_AMT,"
                  sql &= "ARRUN_AMT = @ARRUN_AMT,"
                  sql &= "RUN_AMT = @RUN_AMT,"
                  sql &= "ADD_DATE = @ADD_DATE,"
                  sql &= "CHG_DATE = @CHG_DATE,"
                  sql &= "USER = @USER,"
                  sql &= "REC_STAT = @REC_STAT,"
                  sql &= "FD_CNTR = @FD_CNTR"
			            sql &= " WHERE KBCI_ID= " & cls.KBCI_ID
		            End if
					
					Dim p As DbParameter = Nothing 
					p = myCommand.CreateParameter
					p.ParameterName = "@KBCI_NO"
					p.Value = cls.KBCI_NO
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@LNAME"
					p.Value = cls.LNAME
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@FNAME"
					p.Value = cls.FNAME
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@MI"
					p.Value = cls.MI
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@MEM_CODE"
					p.Value = cls.MEM_CODE
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@MEM_STAT"
					p.Value = cls.MEM_STAT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@MEM_DATE"
					p.DbType = DbType.DateTime
					if cls.MEM_DATE <> Date.MinValue then
			            p.Value = cls.MEM_DATE
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@BY_WHOM"
					p.Value = cls.BY_WHOM
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CB_EMPNO"
					p.Value = cls.CB_EMPNO
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CB_HIRE"
					p.DbType = DbType.DateTime
					if cls.CB_HIRE <> Date.MinValue then
			            p.Value = cls.CB_HIRE
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@DEPT"
					p.Value = cls.DEPT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@REGION"
					p.Value = cls.REGION
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@OFF_TEL"
					p.Value = cls.OFF_TEL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@DORI"
					p.Value = cls.DORI
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@REA_DORI"
					p.Value = cls.REA_DORI
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@SEX"
					p.Value = cls.SEX
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@B_DATE"
					p.DbType = DbType.DateTime
					if cls.B_DATE <> Date.MinValue then
			            p.Value = cls.B_DATE
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CIV_STAT"
					p.Value = cls.CIV_STAT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@MEM_ADDR"
					p.Value = cls.MEM_ADDR
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@RES_TEL"
					p.Value = cls.RES_TEL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@POSITION"
					p.Value = cls.POSITION
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@SAL_BAS"
					p.Value = cls.SAL_BAS
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@SAL_ALL"
					p.Value = cls.SAL_ALL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@OTH_INC"
					p.Value = cls.OTH_INC
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@FEBTC_SA"
					p.Value = cls.FEBTC_SA
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@FEBTC_CA"
					p.Value = cls.FEBTC_CA
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@FD_CERTNO"
					p.Value = cls.FD_CERTNO
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@FD_DATE"
					p.DbType = DbType.DateTime
					if cls.FD_DATE <> Date.MinValue then
			            p.Value = cls.FD_DATE
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@AP_AMOUNT"
					p.Value = cls.AP_AMOUNT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@AR_AMOUNT"
					p.Value = cls.AR_AMOUNT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@FD_AMOUNT"
					p.Value = cls.FD_AMOUNT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@SD_AMOUNT"
					p.Value = cls.SD_AMOUNT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@TD_AMOUNT"
					p.Value = cls.TD_AMOUNT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@OTH_AMOUNT"
					p.Value = cls.OTH_AMOUNT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@YTD_DIVAMT"
					p.Value = cls.YTD_DIVAMT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@YTD_LRI"
					p.Value = cls.YTD_LRI
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@REM_PROP"
					p.Value = cls.REM_PROP
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@REM_VALUE"
					p.Value = cls.REM_VALUE
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@NO_DEPEND"
					p.Value = cls.NO_DEPEND
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@SP_NAME"
					p.Value = cls.SP_NAME
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@SP_EMPLOY"
					p.Value = cls.SP_EMPLOY
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@SP_OFFTEL"
					p.Value = cls.SP_OFFTEL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@SP_CBEMPNO"
					p.Value = cls.SP_CBEMPNO
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@SP_KBCINO"
					p.Value = cls.SP_KBCINO
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@SP_SALARY"
					p.Value = cls.SP_SALARY
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@APRUN_AMT"
					p.Value = cls.APRUN_AMT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ARRUN_AMT"
					p.Value = cls.ARRUN_AMT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@RUN_AMT"
					p.Value = cls.RUN_AMT
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
					p.ParameterName = "@REC_STAT"
					p.Value = cls.REC_STAT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@FD_CNTR"
					p.Value = cls.FD_CNTR
  					myCommand.Parameters.Add(p)

                    myCommand.CommandType = CommandType.Text
		            myCommand.CommandText = sql
		            myCommand.ExecuteNonQuery()

		            
					If cls.KBCI_ID=0 Then
			            Dim IdInserito as integer = 0
			            Sql = "select @@identity"
			            myCommand.CommandText = Sql
			            Idinserito = myCommand.ExecuteScalar()
			            cls.KBCI_ID = Idinserito
			            Ris = Idinserito
		            else
			            Ris  =  cls.KBCI_ID
		            End If
		            

	            Catch ex As Exception
		            ManageError(ex)
	            End Try
            End Using
        else
	        Ris  =  cls.KBCI_ID
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
        'Dim Sql As String = "UPDATE Members SET DELETED=True "
        Dim Sql As String = "DELETE FROM Members"
        Sql &= " Where KBCI_ID = " & Id 

        myCommand.CommandText = Sql
        If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
        myCommand.ExecuteNonQuery()
    
    End Using
    Catch ex As Exception
	    ManageError(ex)
    End Try
End Sub

''' <summary>
'''Delete from DB table Members. Accept id of object to delete.
''' </summary>
Public Overrides Sub Delete(Id as integer) 
        DestroyPermanently (Id)
    End Sub

''' <summary>
'''Delete from DB table Members. Accept object to delete and optional a List to remove the object from.
''' </summary>
Public Overrides Sub Delete(byref obj as Members, Optional ByRef ListaObj as List (of Members) = Nothing)
        DestroyPermanently (obj.KBCI_ID)
    If Not ListaObj Is Nothing Then ListaObj.Remove(obj)
     
End Sub

''' <summary>
'''Find on DB table Members
''' </summary>
''' <returns>
'''Return first of Members
''' </returns>
Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Members
    Dim ris As Members = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1}
    Dim l As IEnumerable(Of Members) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function

''' <summary>
'''Find on DB table Members
''' </summary>
''' <returns>
'''Return first of Members
''' </returns>
Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Members
    Dim ris As Members = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1, .OrderBy = OrderBy}
    Dim l As IEnumerable(Of Members) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function
''' <summary>
'''Find on DB table Members
''' </summary>
''' <returns>
'''Return a list of Members
''' </returns>
Public Overrides Function FindAll(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Members)
    Dim So As New Luna.LunaSearchOption
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Members
''' </summary>
''' <returns>
'''Return a list of Members
''' </returns>
Public Overloads Function FindAll(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Members)
    Dim So As New Luna.LunaSearchOption With {.OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Members
''' </summary>
''' <returns>
'''Return a list of Members
''' </returns>
Public Overloads Function FindAll(byVal Top as integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Members)
    Dim So As New Luna.LunaSearchOption With {.Top = Top, .OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Members
''' </summary>
''' <returns>
'''Return a list of Members
''' </returns>
Public Overloads Function FindAll(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Members)
    Return FindReal(SearchOption, Parameter)
End Function

Private Function FindReal(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as iEnumerable(Of Members)
    Dim Ls As New List(Of Members)
    Try

    Dim sql As String = ""
    sql ="SELECT "   
		if SearchOption.Top then sql &= " TOP " & SearchOption.Top
		sql &=" * from Members" 
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

            If Not SearchOption.OrderBy Is Nothing Then sql &= " ORDER BY " & SearchOption.OrderBy

	
    Ls = GetData(sql, SearchOption.AddEmptyItem)

    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ls
End Function

Public Overrides Function GetAll(Optional OrderByField as string = "", Optional ByVal AddEmptyItem As Boolean = False) as iEnumerable(Of Members)
    Dim Ls As New List(Of Members)
    Try

    Dim sql As String = ""
    sql ="SELECT * from Members" 
    If OrderByField.Length Then
	    Sql &= " ORDER BY " & OrderByField
    End If

    Ls = GetData(Sql,AddEmptyItem)

    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ls
End Function



    Protected Function GetData(ByVal sql As String, Optional ByVal AddEmptyItem As Boolean = False) As iEnumerable(Of Members)
        Dim Ls As New List(Of Members)
        Try
            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = sql
                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                Using myReader As DbDataReader = myCommand.ExecuteReader()
                    If AddEmptyItem Then Ls.Add(New Members() With {.KBCI_ID = Nothing, .KBCI_NO = "", .LNAME = "", .FNAME = "", .MI = "", .MEM_CODE = "", .MEM_STAT = "", .MEM_DATE = Nothing, .BY_WHOM = "", .CB_EMPNO = "", .CB_HIRE = Nothing, .DEPT = "", .REGION = "", .OFF_TEL = "", .DORI = False, .REA_DORI = "", .SEX = "", .B_DATE = Nothing, .CIV_STAT = "", .MEM_ADDR = "", .RES_TEL = "", .POSITION = "", .SAL_BAS = 0, .SAL_ALL = 0, .OTH_INC = 0, .FEBTC_SA = "", .FEBTC_CA = "", .FD_CERTNO = "", .FD_DATE = Nothing, .AP_AMOUNT = 0, .AR_AMOUNT = 0, .FD_AMOUNT = 0, .SD_AMOUNT = 0, .TD_AMOUNT = 0, .OTH_AMOUNT = 0, .YTD_DIVAMT = 0, .YTD_LRI = 0, .REM_PROP = "", .REM_VALUE = 0, .NO_DEPEND = 0, .SP_NAME = "", .SP_EMPLOY = "", .SP_OFFTEL = "", .SP_CBEMPNO = "", .SP_KBCINO = "", .SP_SALARY = 0, .APRUN_AMT = 0, .ARRUN_AMT = 0, .RUN_AMT = 0, .ADD_DATE = Nothing, .CHG_DATE = Nothing, .USER = "", .REC_STAT = False, .FD_CNTR = 0})
                    While myReader.Read
                        Dim classe As New Members(CType(myReader, IDataRecord))
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
