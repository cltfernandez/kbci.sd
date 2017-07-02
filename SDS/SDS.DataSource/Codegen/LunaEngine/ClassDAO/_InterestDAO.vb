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
'''This class manage persistency on db of Interest object
''' </summary>
''' <remarks>
'''
''' </remarks>

Public MustInherit Class _InterestDAO
Inherits LUNA.LunaBaseClassDAO(Of Interest)

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
'''Read from DB table Interest
''' </summary>
''' <returns>
'''Return a Interest object
''' </returns>
Public Overrides Function Read(Id as integer) as Interest
    Dim cls as new Interest

    Try
        Using myCommand As DbCommand = _cn.CreateCommand
        
            myCommand.CommandText = "SELECT * FROM Interest where INTEREST_ID = " & Id
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
'''Save on DB table Interest
''' </summary>
''' <returns>
'''Return ID insert in DB
''' </returns>
Public Overrides Function Save(byRef cls as Interest) as Integer

    Dim Ris as integer=0 'in Ris return Insert Id

    If cls.IsValid Then
        If cls.IsChanged Then
            Using myCommand As DbCommand = _Cn.CreateCommand()
	            Try
		            Dim sql As String = String.Empty
		            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
		            If cls.INTEREST_ID = 0 Then
                        sql = "INSERT INTO Interest ("
                            sql &= " ACCTNO,"
                            sql &= " APLINT,"
                            sql &= " EDLINT,"
                            sql &= " EMLINT,"
                            sql &= " RGLINT,"
                            sql &= " RSLINT,"
                            sql &= " SPLINT,"
                            sql &= " LHLINT,"
                            sql &= " STLINT,"
                            sql &= " CMLINT,"
                            sql &= " FALINT,"
                            sql &= " MPLINT,"
                            sql &= " XMAINT,"
                            sql &= " REC_STAT"
                      sql &= ") VALUES ("
                      sql &= " @ACCTNO,"
                      sql &= " @APLINT,"
                      sql &= " @EDLINT,"
                      sql &= " @EMLINT,"
                      sql &= " @RGLINT,"
                      sql &= " @RSLINT,"
                      sql &= " @SPLINT,"
                      sql &= " @LHLINT,"
                      sql &= " @STLINT,"
                      sql &= " @CMLINT,"
                      sql &= " @FALINT,"
                      sql &= " @MPLINT,"
                      sql &= " @XMAINT,"
                      sql &= " @REC_STAT"
                      sql &= ")"
		            Else
			            sql = "UPDATE Interest SET "
                  sql &= "ACCTNO = @ACCTNO,"
                  sql &= "APLINT = @APLINT,"
                  sql &= "EDLINT = @EDLINT,"
                  sql &= "EMLINT = @EMLINT,"
                  sql &= "RGLINT = @RGLINT,"
                  sql &= "RSLINT = @RSLINT,"
                  sql &= "SPLINT = @SPLINT,"
                  sql &= "LHLINT = @LHLINT,"
                  sql &= "STLINT = @STLINT,"
                  sql &= "CMLINT = @CMLINT,"
                  sql &= "FALINT = @FALINT,"
                  sql &= "MPLINT = @MPLINT,"
                  sql &= "XMAINT = @XMAINT,"
                  sql &= "REC_STAT = @REC_STAT"
			            sql &= " WHERE INTEREST_ID= " & cls.INTEREST_ID
		            End if
					
					Dim p As DbParameter = Nothing 
					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTNO"
					p.Value = cls.ACCTNO
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@APLINT"
					p.Value = cls.APLINT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@EDLINT"
					p.Value = cls.EDLINT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@EMLINT"
					p.Value = cls.EMLINT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@RGLINT"
					p.Value = cls.RGLINT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@RSLINT"
					p.Value = cls.RSLINT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@SPLINT"
					p.Value = cls.SPLINT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@LHLINT"
					p.Value = cls.LHLINT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@STLINT"
					p.Value = cls.STLINT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CMLINT"
					p.Value = cls.CMLINT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@FALINT"
					p.Value = cls.FALINT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@MPLINT"
					p.Value = cls.MPLINT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@XMAINT"
					p.Value = cls.XMAINT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@REC_STAT"
					p.Value = cls.REC_STAT
  					myCommand.Parameters.Add(p)

                    myCommand.CommandType = CommandType.Text
		            myCommand.CommandText = sql
		            myCommand.ExecuteNonQuery()

		            
					If cls.INTEREST_ID=0 Then
			            Dim IdInserito as integer = 0
			            Sql = "select @@identity"
			            myCommand.CommandText = Sql
			            Idinserito = myCommand.ExecuteScalar()
			            cls.INTEREST_ID = Idinserito
			            Ris = Idinserito
		            else
			            Ris  =  cls.INTEREST_ID
		            End If
		            

	            Catch ex As Exception
		            ManageError(ex)
	            End Try
            End Using
        else
	        Ris  =  cls.INTEREST_ID
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
        'Dim Sql As String = "UPDATE Interest SET DELETED=True "
        Dim Sql As String = "DELETE FROM Interest"
        Sql &= " Where INTEREST_ID = " & Id 

        myCommand.CommandText = Sql
        If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
        myCommand.ExecuteNonQuery()
    
    End Using
    Catch ex As Exception
	    ManageError(ex)
    End Try
End Sub

''' <summary>
'''Delete from DB table Interest. Accept id of object to delete.
''' </summary>
Public Overrides Sub Delete(Id as integer) 
        DestroyPermanently (Id)
    End Sub

''' <summary>
'''Delete from DB table Interest. Accept object to delete and optional a List to remove the object from.
''' </summary>
Public Overrides Sub Delete(byref obj as Interest, Optional ByRef ListaObj as List (of Interest) = Nothing)
        DestroyPermanently (obj.INTEREST_ID)
    If Not ListaObj Is Nothing Then ListaObj.Remove(obj)
     
End Sub

''' <summary>
'''Find on DB table Interest
''' </summary>
''' <returns>
'''Return first of Interest
''' </returns>
Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Interest
    Dim ris As Interest = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1}
    Dim l As IEnumerable(Of Interest) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function

''' <summary>
'''Find on DB table Interest
''' </summary>
''' <returns>
'''Return first of Interest
''' </returns>
Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Interest
    Dim ris As Interest = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1, .OrderBy = OrderBy}
    Dim l As IEnumerable(Of Interest) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function
''' <summary>
'''Find on DB table Interest
''' </summary>
''' <returns>
'''Return a list of Interest
''' </returns>
Public Overrides Function FindAll(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Interest)
    Dim So As New Luna.LunaSearchOption
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Interest
''' </summary>
''' <returns>
'''Return a list of Interest
''' </returns>
Public Overloads Function FindAll(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Interest)
    Dim So As New Luna.LunaSearchOption With {.OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Interest
''' </summary>
''' <returns>
'''Return a list of Interest
''' </returns>
Public Overloads Function FindAll(byVal Top as integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Interest)
    Dim So As New Luna.LunaSearchOption With {.Top = Top, .OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Interest
''' </summary>
''' <returns>
'''Return a list of Interest
''' </returns>
Public Overloads Function FindAll(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Interest)
    Return FindReal(SearchOption, Parameter)
End Function

Private Function FindReal(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as iEnumerable(Of Interest)
    Dim Ls As New List(Of Interest)
    Try

    Dim sql As String = ""
    sql ="SELECT "   
		if SearchOption.Top then sql &= " TOP " & SearchOption.Top
		sql &=" * from Interest" 
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

Public Overrides Function GetAll(Optional OrderByField as string = "", Optional ByVal AddEmptyItem As Boolean = False) as iEnumerable(Of Interest)
    Dim Ls As New List(Of Interest)
    Try

    Dim sql As String = ""
    sql ="SELECT * from Interest" 
    If OrderByField.Length Then
	    Sql &= " ORDER BY " & OrderByField
    End If

    Ls = GetData(Sql,AddEmptyItem)

    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ls
End Function



    Protected Function GetData(ByVal sql As String, Optional ByVal AddEmptyItem As Boolean = False) As iEnumerable(Of Interest)
        Dim Ls As New List(Of Interest)
        Try
            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = sql
                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                Using myReader As DbDataReader = myCommand.ExecuteReader()
                    If AddEmptyItem Then Ls.Add(New Interest() With {.INTEREST_ID = Nothing, .ACCTNO = "", .APLINT = 0, .EDLINT = 0, .EMLINT = 0, .RGLINT = 0, .RSLINT = 0, .SPLINT = 0, .LHLINT = 0, .STLINT = 0, .CMLINT = 0, .FALINT = 0, .MPLINT = 0, .XMAINT = 0, .REC_STAT = False})
                    While myReader.Read
                        Dim classe As New Interest(CType(myReader, IDataRecord))
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
