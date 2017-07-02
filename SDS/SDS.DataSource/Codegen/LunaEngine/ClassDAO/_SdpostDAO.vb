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
'''This class manage persistency on db of Sdpost object
''' </summary>
''' <remarks>
'''
''' </remarks>

Public MustInherit Class _SdpostDAO
Inherits LUNA.LunaBaseClassDAO(Of Sdpost)

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
'''Read from DB table Sdpost
''' </summary>
''' <returns>
'''Return a Sdpost object
''' </returns>
Public Overrides Function Read(Id as integer) as Sdpost
    Dim cls as new Sdpost

    Try
        Using myCommand As DbCommand = _cn.CreateCommand
        
            myCommand.CommandText = "SELECT * FROM Sdpost where ACCTNO = " & Id
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
'''Save on DB table Sdpost
''' </summary>
''' <returns>
'''Return ID insert in DB
''' </returns>
Public Overrides Function Save(byRef cls as Sdpost) as Integer

    Dim Ris as integer=0 'in Ris return Insert Id

    If cls.IsValid Then
        If cls.IsChanged Then
            Using myCommand As DbCommand = _Cn.CreateCommand()
	            Try
		            Dim sql As String = String.Empty
		            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
		            If cls.ACCTNO = 0 Then
                        sql = "INSERT INTO Sdpost ("
                            sql &= " ACCTNO,"
                            sql &= " KBCI_NO,"
                            sql &= " SDNAME,"
                            sql &= " CBEMPNO,"
                            sql &= " TDATE,"
                            sql &= " PAMT,"
                            sql &= " SDSEQ,"
                            sql &= " SDTIME,"
                            sql &= " SDBBAL,"
                            sql &= " SDEBAL"
                      sql &= ") VALUES ("
                      sql &= " @ACCTNO,"
                      sql &= " @KBCI_NO,"
                      sql &= " @SDNAME,"
                      sql &= " @CBEMPNO,"
                      sql &= " @TDATE,"
                      sql &= " @PAMT,"
                      sql &= " @SDSEQ,"
                      sql &= " @SDTIME,"
                      sql &= " @SDBBAL,"
                      sql &= " @SDEBAL"
                      sql &= ")"
		            Else
			            sql = "UPDATE Sdpost SET "
                  sql &= "ACCTNO = @ACCTNO,"
                  sql &= "KBCI_NO = @KBCI_NO,"
                  sql &= "SDNAME = @SDNAME,"
                  sql &= "CBEMPNO = @CBEMPNO,"
                  sql &= "TDATE = @TDATE,"
                  sql &= "PAMT = @PAMT,"
                  sql &= "SDSEQ = @SDSEQ,"
                  sql &= "SDTIME = @SDTIME,"
                  sql &= "SDBBAL = @SDBBAL,"
                  sql &= "SDEBAL = @SDEBAL"
			            sql &= " WHERE ACCTNO= " & cls.ACCTNO
		            End if
					
					Dim p As DbParameter = Nothing 
					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTNO"
					p.Value = cls.ACCTNO
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@KBCI_NO"
					p.Value = cls.KBCI_NO
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@SDNAME"
					p.Value = cls.SDNAME
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CBEMPNO"
					p.Value = cls.CBEMPNO
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@TDATE"
					p.DbType = DbType.DateTime
					if cls.TDATE <> Date.MinValue then
			            p.Value = cls.TDATE
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@PAMT"
					p.Value = cls.PAMT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@SDSEQ"
					p.Value = cls.SDSEQ
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@SDTIME"
					p.Value = cls.SDTIME
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@SDBBAL"
					p.Value = cls.SDBBAL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@SDEBAL"
					p.Value = cls.SDEBAL
  					myCommand.Parameters.Add(p)

                    myCommand.CommandType = CommandType.Text
		            myCommand.CommandText = sql
		            myCommand.ExecuteNonQuery()

                    Ris  =  cls.ACCTNO
		            

	            Catch ex As Exception
		            ManageError(ex)
	            End Try
            End Using
        else
	        Ris  =  cls.ACCTNO
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
        'Dim Sql As String = "UPDATE Sdpost SET DELETED=True "
        Dim Sql As String = "DELETE FROM Sdpost"
        Sql &= " Where ACCTNO = " & Id 

        myCommand.CommandText = Sql
        If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
        myCommand.ExecuteNonQuery()
    
    End Using
    Catch ex As Exception
	    ManageError(ex)
    End Try
End Sub

''' <summary>
'''Delete from DB table Sdpost. Accept id of object to delete.
''' </summary>
Public Overrides Sub Delete(Id as integer) 
        DestroyPermanently (Id)
    End Sub

''' <summary>
'''Delete from DB table Sdpost. Accept object to delete and optional a List to remove the object from.
''' </summary>
Public Overrides Sub Delete(byref obj as Sdpost, Optional ByRef ListaObj as List (of Sdpost) = Nothing)
        DestroyPermanently (obj.ACCTNO)
    If Not ListaObj Is Nothing Then ListaObj.Remove(obj)
     
End Sub

''' <summary>
'''Find on DB table Sdpost
''' </summary>
''' <returns>
'''Return first of Sdpost
''' </returns>
Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Sdpost
    Dim ris As Sdpost = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1}
    Dim l As IEnumerable(Of Sdpost) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function

''' <summary>
'''Find on DB table Sdpost
''' </summary>
''' <returns>
'''Return first of Sdpost
''' </returns>
Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Sdpost
    Dim ris As Sdpost = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1, .OrderBy = OrderBy}
    Dim l As IEnumerable(Of Sdpost) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function
''' <summary>
'''Find on DB table Sdpost
''' </summary>
''' <returns>
'''Return a list of Sdpost
''' </returns>
Public Overrides Function FindAll(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Sdpost)
    Dim So As New Luna.LunaSearchOption
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Sdpost
''' </summary>
''' <returns>
'''Return a list of Sdpost
''' </returns>
Public Overloads Function FindAll(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Sdpost)
    Dim So As New Luna.LunaSearchOption With {.OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Sdpost
''' </summary>
''' <returns>
'''Return a list of Sdpost
''' </returns>
Public Overloads Function FindAll(byVal Top as integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Sdpost)
    Dim So As New Luna.LunaSearchOption With {.Top = Top, .OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Sdpost
''' </summary>
''' <returns>
'''Return a list of Sdpost
''' </returns>
Public Overloads Function FindAll(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Sdpost)
    Return FindReal(SearchOption, Parameter)
End Function

Private Function FindReal(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as iEnumerable(Of Sdpost)
    Dim Ls As New List(Of Sdpost)
    Try

    Dim sql As String = ""
    sql ="SELECT "   
		if SearchOption.Top then sql &= " TOP " & SearchOption.Top
		sql &=" * from Sdpost" 
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

Public Overrides Function GetAll(Optional OrderByField as string = "", Optional ByVal AddEmptyItem As Boolean = False) as iEnumerable(Of Sdpost)
    Dim Ls As New List(Of Sdpost)
    Try

    Dim sql As String = ""
    sql ="SELECT * from Sdpost" 
    If OrderByField.Length Then
	    Sql &= " ORDER BY " & OrderByField
    End If

    Ls = GetData(Sql,AddEmptyItem)

    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ls
End Function



    Protected Function GetData(ByVal sql As String, Optional ByVal AddEmptyItem As Boolean = False) As iEnumerable(Of Sdpost)
        Dim Ls As New List(Of Sdpost)
        Try
            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = sql
                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                Using myReader As DbDataReader = myCommand.ExecuteReader()
                    If AddEmptyItem Then Ls.Add(New Sdpost() With {.ACCTNO = "", .KBCI_NO = "", .SDNAME = "", .CBEMPNO = "", .TDATE = Nothing, .PAMT = 0, .SDSEQ = 0, .SDTIME = "", .SDBBAL = 0, .SDEBAL = 0})
                    While myReader.Read
                        Dim classe As New Sdpost(CType(myReader, IDataRecord))
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
