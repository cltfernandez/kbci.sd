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
'''This class manage persistency on db of Extract object
''' </summary>
''' <remarks>
'''
''' </remarks>

Public MustInherit Class _ExtractDAO
Inherits LUNA.LunaBaseClassDAO(Of Extract)

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
'''Read from DB table Extract
''' </summary>
''' <returns>
'''Return a Extract object
''' </returns>
Public Overrides Function Read(Id as integer) as Extract
    Dim cls as new Extract

    Try
        Using myCommand As DbCommand = _cn.CreateCommand
        
            myCommand.CommandText = "SELECT * FROM Extract where PN_NO = " & Id
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
'''Save on DB table Extract
''' </summary>
''' <returns>
'''Return ID insert in DB
''' </returns>
Public Overrides Function Save(byRef cls as Extract) as Integer

    Dim Ris as integer=0 'in Ris return Insert Id

    If cls.IsValid Then
        If cls.IsChanged Then
            Using myCommand As DbCommand = _Cn.CreateCommand()
	            Try
		            Dim sql As String = String.Empty
		            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
		            If cls.PN_NO = 0 Then
                        sql = "INSERT INTO Extract ("
                            sql &= " PN_NO,"
                            sql &= " KBCI_NO,"
                            sql &= " LOAN_TYPE,"
                            sql &= " ADD_DATE,"
                            sql &= " CHG_DATE,"
                            sql &= " USER,"
                            sql &= " AMOUNT,"
                            sql &= " REMARKS,"
                            sql &= " SAVINGS,"
                            sql &= " ACCTNO,"
                            sql &= " STATUS,"
                            sql &= " EXSEQ,"
                            sql &= " EXTIME,"
                            sql &= " EXBBAL,"
                            sql &= " EXEBAL"
                      sql &= ") VALUES ("
                      sql &= " @PN_NO,"
                      sql &= " @KBCI_NO,"
                      sql &= " @LOAN_TYPE,"
                      sql &= " @ADD_DATE,"
                      sql &= " @CHG_DATE,"
                      sql &= " @USER,"
                      sql &= " @AMOUNT,"
                      sql &= " @REMARKS,"
                      sql &= " @SAVINGS,"
                      sql &= " @ACCTNO,"
                      sql &= " @STATUS,"
                      sql &= " @EXSEQ,"
                      sql &= " @EXTIME,"
                      sql &= " @EXBBAL,"
                      sql &= " @EXEBAL"
                      sql &= ")"
		            Else
			            sql = "UPDATE Extract SET "
                  sql &= "PN_NO = @PN_NO,"
                  sql &= "KBCI_NO = @KBCI_NO,"
                  sql &= "LOAN_TYPE = @LOAN_TYPE,"
                  sql &= "ADD_DATE = @ADD_DATE,"
                  sql &= "CHG_DATE = @CHG_DATE,"
                  sql &= "USER = @USER,"
                  sql &= "AMOUNT = @AMOUNT,"
                  sql &= "REMARKS = @REMARKS,"
                  sql &= "SAVINGS = @SAVINGS,"
                  sql &= "ACCTNO = @ACCTNO,"
                  sql &= "STATUS = @STATUS,"
                  sql &= "EXSEQ = @EXSEQ,"
                  sql &= "EXTIME = @EXTIME,"
                  sql &= "EXBBAL = @EXBBAL,"
                  sql &= "EXEBAL = @EXEBAL"
			            sql &= " WHERE PN_NO= " & cls.PN_NO
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
					p.ParameterName = "@LOAN_TYPE"
					p.Value = cls.LOAN_TYPE
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
					p.ParameterName = "@AMOUNT"
					p.Value = cls.AMOUNT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@REMARKS"
					p.Value = cls.REMARKS
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@SAVINGS"
					p.Value = cls.SAVINGS
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTNO"
					p.Value = cls.ACCTNO
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@STATUS"
					p.Value = cls.STATUS
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@EXSEQ"
					p.Value = cls.EXSEQ
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@EXTIME"
					p.Value = cls.EXTIME
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@EXBBAL"
					p.Value = cls.EXBBAL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@EXEBAL"
					p.Value = cls.EXEBAL
  					myCommand.Parameters.Add(p)

                    myCommand.CommandType = CommandType.Text
		            myCommand.CommandText = sql
		            myCommand.ExecuteNonQuery()

                    Ris  =  cls.PN_NO
		            

	            Catch ex As Exception
		            ManageError(ex)
	            End Try
            End Using
        else
	        Ris  =  cls.PN_NO
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
        'Dim Sql As String = "UPDATE Extract SET DELETED=True "
        Dim Sql As String = "DELETE FROM Extract"
        Sql &= " Where PN_NO = " & Id 

        myCommand.CommandText = Sql
        If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
        myCommand.ExecuteNonQuery()
    
    End Using
    Catch ex As Exception
	    ManageError(ex)
    End Try
End Sub

''' <summary>
'''Delete from DB table Extract. Accept id of object to delete.
''' </summary>
Public Overrides Sub Delete(Id as integer) 
        DestroyPermanently (Id)
    End Sub

''' <summary>
'''Delete from DB table Extract. Accept object to delete and optional a List to remove the object from.
''' </summary>
Public Overrides Sub Delete(byref obj as Extract, Optional ByRef ListaObj as List (of Extract) = Nothing)
        DestroyPermanently (obj.PN_NO)
    If Not ListaObj Is Nothing Then ListaObj.Remove(obj)
     
End Sub

''' <summary>
'''Find on DB table Extract
''' </summary>
''' <returns>
'''Return first of Extract
''' </returns>
Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Extract
    Dim ris As Extract = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1}
    Dim l As IEnumerable(Of Extract) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function

''' <summary>
'''Find on DB table Extract
''' </summary>
''' <returns>
'''Return first of Extract
''' </returns>
Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Extract
    Dim ris As Extract = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1, .OrderBy = OrderBy}
    Dim l As IEnumerable(Of Extract) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function
''' <summary>
'''Find on DB table Extract
''' </summary>
''' <returns>
'''Return a list of Extract
''' </returns>
Public Overrides Function FindAll(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Extract)
    Dim So As New Luna.LunaSearchOption
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Extract
''' </summary>
''' <returns>
'''Return a list of Extract
''' </returns>
Public Overloads Function FindAll(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Extract)
    Dim So As New Luna.LunaSearchOption With {.OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Extract
''' </summary>
''' <returns>
'''Return a list of Extract
''' </returns>
Public Overloads Function FindAll(byVal Top as integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Extract)
    Dim So As New Luna.LunaSearchOption With {.Top = Top, .OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Extract
''' </summary>
''' <returns>
'''Return a list of Extract
''' </returns>
Public Overloads Function FindAll(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Extract)
    Return FindReal(SearchOption, Parameter)
End Function

Private Function FindReal(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as iEnumerable(Of Extract)
    Dim Ls As New List(Of Extract)
    Try

    Dim sql As String = ""
    sql ="SELECT "   
		if SearchOption.Top then sql &= " TOP " & SearchOption.Top
		sql &=" * from Extract" 
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

Public Overrides Function GetAll(Optional OrderByField as string = "", Optional ByVal AddEmptyItem As Boolean = False) as iEnumerable(Of Extract)
    Dim Ls As New List(Of Extract)
    Try

    Dim sql As String = ""
    sql ="SELECT * from Extract" 
    If OrderByField.Length Then
	    Sql &= " ORDER BY " & OrderByField
    End If

    Ls = GetData(Sql,AddEmptyItem)

    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ls
End Function



    Protected Function GetData(ByVal sql As String, Optional ByVal AddEmptyItem As Boolean = False) As iEnumerable(Of Extract)
        Dim Ls As New List(Of Extract)
        Try
            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = sql
                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                Using myReader As DbDataReader = myCommand.ExecuteReader()
                    If AddEmptyItem Then Ls.Add(New Extract() With {.PN_NO = "", .KBCI_NO = "", .LOAN_TYPE = "", .ADD_DATE = Nothing, .CHG_DATE = Nothing, .USER = "", .AMOUNT = 0, .REMARKS = "", .SAVINGS = False, .ACCTNO = "", .STATUS = "", .EXSEQ = 0, .EXTIME = "", .EXBBAL = 0, .EXEBAL = 0})
                    While myReader.Read
                        Dim classe As New Extract(CType(myReader, IDataRecord))
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
