#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 25/06/2016 
#End Region


Imports System.Data.Common
''' <summary>
'''This class manage persistency on db of Ctrl_s object
''' </summary>
''' <remarks>
'''
''' </remarks>

Public MustInherit Class _Ctrl_sDAO
Inherits LUNA.LunaBaseClassDAO(Of Ctrl_s)

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
'''Read from DB table Ctrl_s
''' </summary>
''' <returns>
'''Return a Ctrl_s object
''' </returns>
Public Overrides Function Read(Id as integer) as Ctrl_s
    Dim cls as new Ctrl_s

    Try
        Using myCommand As DbCommand = _cn.CreateCommand
        
            myCommand.CommandText = "SELECT * FROM Ctrl_s where CTRL_S_ID = " & Id
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
'''Save on DB table Ctrl_s
''' </summary>
''' <returns>
'''Return ID insert in DB
''' </returns>
Public Overrides Function Save(byRef cls as Ctrl_s) as Integer

    Dim Ris as integer=0 'in Ris return Insert Id

    If cls.IsValid Then
        If cls.IsChanged Then
            Using myCommand As DbCommand = _Cn.CreateCommand()
	            Try
		            Dim sql As String = String.Empty
		            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
		            If cls.CTRL_S_ID = 0 Then
                        sql = "INSERT INTO Ctrl_s ("
                            sql &= " SYSDATE,"
                            sql &= " ADMDATE,"
                            sql &= " ADD_DATE,"
                            sql &= " CHG_DATE,"
                            sql &= " [USER],"
                            sql &= " SDRATE,"
                            sql &= " ACCTBR,"
                            sql &= " ACCTSEQ,"
                            sql &= " PMAXL,"
                            sql &= " LMAXL,"
                            sql &= " BINIT,"
                            sql &= " BPOST,"
                            sql &= " CLR_ONUS,"
                            sql &= " CLR_LOCAL,"
                            sql &= " CLR_REG,"
                            sql &= " MINBAL,"
                            sql &= " DBDORMANT,"
                            sql &= " EOM_FLAG,"
                            sql &= " EOQ_FLAG,"
                            sql &= " EOY_FLAG,"
                            sql &= " OTC_FLAG,"
                            sql &= " EOD_FLAG,"
                            sql &= " P_PRINT,"
                            sql &= " R_PRINT,"
                            sql &= " DormancyCharge,"
                            sql &= " MinimumInterestEarningBalance"
                      sql &= ") VALUES ("
                      sql &= " @SYSDATE,"
                      sql &= " @ADMDATE,"
                      sql &= " @ADD_DATE,"
                      sql &= " @CHG_DATE,"
                      sql &= " @USER,"
                      sql &= " @SDRATE,"
                      sql &= " @ACCTBR,"
                      sql &= " @ACCTSEQ,"
                      sql &= " @PMAXL,"
                      sql &= " @LMAXL,"
                      sql &= " @BINIT,"
                      sql &= " @BPOST,"
                      sql &= " @CLR_ONUS,"
                      sql &= " @CLR_LOCAL,"
                      sql &= " @CLR_REG,"
                      sql &= " @MINBAL,"
                      sql &= " @DBDORMANT,"
                      sql &= " @EOM_FLAG,"
                      sql &= " @EOQ_FLAG,"
                      sql &= " @EOY_FLAG,"
                      sql &= " @OTC_FLAG,"
                      sql &= " @EOD_FLAG,"
                      sql &= " @P_PRINT,"
                      sql &= " @R_PRINT,"
                      sql &= " @DormancyCharge,"
                      sql &= " @MinimumInterestEarningBalance"
                      sql &= ")"
		            Else
			            sql = "UPDATE Ctrl_s SET "
                  sql &= "SYSDATE = @SYSDATE,"
                  sql &= "ADMDATE = @ADMDATE,"
                  sql &= "ADD_DATE = @ADD_DATE,"
                  sql &= "CHG_DATE = @CHG_DATE,"
                  sql &= "[USER] = @USER,"
                  sql &= "SDRATE = @SDRATE,"
                  sql &= "ACCTBR = @ACCTBR,"
                  sql &= "ACCTSEQ = @ACCTSEQ,"
                  sql &= "PMAXL = @PMAXL,"
                  sql &= "LMAXL = @LMAXL,"
                  sql &= "BINIT = @BINIT,"
                  sql &= "BPOST = @BPOST,"
                  sql &= "CLR_ONUS = @CLR_ONUS,"
                  sql &= "CLR_LOCAL = @CLR_LOCAL,"
                  sql &= "CLR_REG = @CLR_REG,"
                  sql &= "MINBAL = @MINBAL,"
                  sql &= "DBDORMANT = @DBDORMANT,"
                  sql &= "EOM_FLAG = @EOM_FLAG,"
                  sql &= "EOQ_FLAG = @EOQ_FLAG,"
                  sql &= "EOY_FLAG = @EOY_FLAG,"
                  sql &= "OTC_FLAG = @OTC_FLAG,"
                  sql &= "EOD_FLAG = @EOD_FLAG,"
                  sql &= "P_PRINT = @P_PRINT,"
                  sql &= "R_PRINT = @R_PRINT,"
                  sql &= "DormancyCharge = @DormancyCharge,"
                  sql &= "MinimumInterestEarningBalance = @MinimumInterestEarningBalance"
			            sql &= " WHERE CTRL_S_ID= " & cls.CTRL_S_ID
		            End if
					
					Dim p As DbParameter = Nothing 
					p = myCommand.CreateParameter
					p.ParameterName = "@SYSDATE"
					p.DbType = DbType.DateTime
					if cls.SYSDATE <> Date.MinValue then
			            p.Value = cls.SYSDATE
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ADMDATE"
					p.DbType = DbType.DateTime
					if cls.ADMDATE <> Date.MinValue then
			            p.Value = cls.ADMDATE
                    else
                        p.Value = DBNull.Value
                    end if  
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
					p.ParameterName = "@SDRATE"
					p.Value = cls.SDRATE
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTBR"
					p.Value = cls.ACCTBR
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTSEQ"
					p.Value = cls.ACCTSEQ
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@PMAXL"
					p.Value = cls.PMAXL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@LMAXL"
					p.Value = cls.LMAXL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@BINIT"
					p.Value = cls.BINIT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@BPOST"
					p.Value = cls.BPOST
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CLR_ONUS"
					p.Value = cls.CLR_ONUS
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CLR_LOCAL"
					p.Value = cls.CLR_LOCAL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CLR_REG"
					p.Value = cls.CLR_REG
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@MINBAL"
					p.Value = cls.MINBAL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@DBDORMANT"
					p.Value = cls.DBDORMANT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@EOM_FLAG"
					p.Value = cls.EOM_FLAG
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@EOQ_FLAG"
					p.Value = cls.EOQ_FLAG
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@EOY_FLAG"
					p.Value = cls.EOY_FLAG
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@OTC_FLAG"
					p.Value = cls.OTC_FLAG
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@EOD_FLAG"
					p.Value = cls.EOD_FLAG
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@P_PRINT"
					p.Value = cls.P_PRINT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@R_PRINT"
					p.Value = cls.R_PRINT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@DormancyCharge"
					p.Value = cls.DormancyCharge
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@MinimumInterestEarningBalance"
					p.Value = cls.MinimumInterestEarningBalance
  					myCommand.Parameters.Add(p)

                    myCommand.CommandType = CommandType.Text
		            myCommand.CommandText = sql
		            myCommand.ExecuteNonQuery()

		            
					If cls.CTRL_S_ID=0 Then
			            Dim IdInserito as integer = 0
			            Sql = "select @@identity"
			            myCommand.CommandText = Sql
			            Idinserito = myCommand.ExecuteScalar()
			            cls.CTRL_S_ID = Idinserito
			            Ris = Idinserito
		            else
			            Ris  =  cls.CTRL_S_ID
		            End If
		            

	            Catch ex As Exception
		            ManageError(ex)
	            End Try
            End Using
        else
	        Ris  =  cls.CTRL_S_ID
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
        'Dim Sql As String = "UPDATE Ctrl_s SET DELETED=True "
        Dim Sql As String = "DELETE FROM Ctrl_s"
        Sql &= " Where CTRL_S_ID = " & Id 

        myCommand.CommandText = Sql
        If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
        myCommand.ExecuteNonQuery()
    
    End Using
    Catch ex As Exception
	    ManageError(ex)
    End Try
End Sub

''' <summary>
'''Delete from DB table Ctrl_s. Accept id of object to delete.
''' </summary>
Public Overrides Sub Delete(Id as integer) 
        DestroyPermanently (Id)
    End Sub

''' <summary>
'''Delete from DB table Ctrl_s. Accept object to delete and optional a List to remove the object from.
''' </summary>
Public Overrides Sub Delete(byref obj as Ctrl_s, Optional ByRef ListaObj as List (of Ctrl_s) = Nothing)
        DestroyPermanently (obj.CTRL_S_ID)
    If Not ListaObj Is Nothing Then ListaObj.Remove(obj)
     
End Sub

''' <summary>
'''Find on DB table Ctrl_s
''' </summary>
''' <returns>
'''Return first of Ctrl_s
''' </returns>
Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Ctrl_s
    Dim ris As Ctrl_s = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1}
    Dim l As IEnumerable(Of Ctrl_s) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function

''' <summary>
'''Find on DB table Ctrl_s
''' </summary>
''' <returns>
'''Return first of Ctrl_s
''' </returns>
Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Ctrl_s
    Dim ris As Ctrl_s = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1, .OrderBy = OrderBy}
    Dim l As IEnumerable(Of Ctrl_s) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function
''' <summary>
'''Find on DB table Ctrl_s
''' </summary>
''' <returns>
'''Return a list of Ctrl_s
''' </returns>
Public Overrides Function FindAll(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Ctrl_s)
    Dim So As New Luna.LunaSearchOption
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Ctrl_s
''' </summary>
''' <returns>
'''Return a list of Ctrl_s
''' </returns>
Public Overloads Function FindAll(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Ctrl_s)
    Dim So As New Luna.LunaSearchOption With {.OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Ctrl_s
''' </summary>
''' <returns>
'''Return a list of Ctrl_s
''' </returns>
Public Overloads Function FindAll(byVal Top as integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Ctrl_s)
    Dim So As New Luna.LunaSearchOption With {.Top = Top, .OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Ctrl_s
''' </summary>
''' <returns>
'''Return a list of Ctrl_s
''' </returns>
Public Overloads Function FindAll(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Ctrl_s)
    Return FindReal(SearchOption, Parameter)
End Function

Private Function FindReal(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as iEnumerable(Of Ctrl_s)
    Dim Ls As New List(Of Ctrl_s)
    Try

    Dim sql As String = ""
    sql ="SELECT "   
		if SearchOption.Top then sql &= " TOP " & SearchOption.Top
		sql &=" * from Ctrl_s" 
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

Public Overrides Function GetAll(Optional OrderByField as string = "", Optional ByVal AddEmptyItem As Boolean = False) as iEnumerable(Of Ctrl_s)
    Dim Ls As New List(Of Ctrl_s)
    Try

    Dim sql As String = ""
    sql ="SELECT * from Ctrl_s" 
    If OrderByField.Length Then
	    Sql &= " ORDER BY " & OrderByField
    End If

    Ls = GetData(Sql,AddEmptyItem)

    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ls
End Function

Protected Function GetData(sql as string, Optional ByVal AddEmptyItem As Boolean = False) as iEnumerable(Of Ctrl_s)
    Dim Ls As New List(Of Ctrl_s)
    Try
        Using myCommand As DbCommand = _Cn.CreateCommand
            myCommand.CommandText = sql
            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
            Using myReader As DbDataReader = myCommand.ExecuteReader()
                If AddEmptyItem Then Ls.Add(New  Ctrl_s() With {.CTRL_S_ID = Nothing ,.SYSDATE = Nothing ,.ADMDATE = Nothing ,.ADD_DATE = Nothing ,.CHG_DATE = Nothing ,.USER = "" ,.SDRATE = 0 ,.ACCTBR = "" ,.ACCTSEQ = 0 ,.PMAXL = 0 ,.LMAXL = 0 ,.BINIT = False ,.BPOST = False ,.CLR_ONUS = 0 ,.CLR_LOCAL = 0 ,.CLR_REG = 0 ,.MINBAL = 0 ,.DBDORMANT = 0 ,.EOM_FLAG = False ,.EOQ_FLAG = False ,.EOY_FLAG = False ,.OTC_FLAG = False ,.EOD_FLAG = False ,.P_PRINT = "" ,.R_PRINT = "" ,.DormancyCharge = 0 ,.MinimumInterestEarningBalance = 0  })
                while myReader.Read
	                Dim classe as new Ctrl_s(CType(myReader, IDataRecord))
	                Ls.Add(classe)
                end while
                myReader.Close()
            End Using
        End Using

    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ls
End Function
End Class
