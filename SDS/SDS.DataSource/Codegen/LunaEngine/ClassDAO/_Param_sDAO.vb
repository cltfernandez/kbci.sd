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
'''This class manage persistency on db of Param_s object
''' </summary>
''' <remarks>
'''
''' </remarks>

Public MustInherit Class _Param_sDAO
Inherits LUNA.LunaBaseClassDAO(Of Param_s)

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
'''Read from DB table Param_s
''' </summary>
''' <returns>
'''Return a Param_s object
''' </returns>
Public Overrides Function Read(Id as integer) as Param_s
    Dim cls as new Param_s

    Try
        Using myCommand As DbCommand = _cn.CreateCommand
        
            myCommand.CommandText = "SELECT * FROM Param_s where OTCOUNTER = " & Id
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
'''Save on DB table Param_s
''' </summary>
''' <returns>
'''Return ID insert in DB
''' </returns>
Public Overrides Function Save(byRef cls as Param_s) as Integer

    Dim Ris as integer=0 'in Ris return Insert Id

    If cls.IsValid Then
        If cls.IsChanged Then
            Using myCommand As DbCommand = _Cn.CreateCommand()
	            Try
		            Dim sql As String = String.Empty
		            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
		            If cls.OTCOUNTER = 0 Then
                        sql = "INSERT INTO Param_s ("
                            sql &= " OTCOUNTER,"
                            sql &= " ENDOFDAY,"
                            sql &= " INTACCR,"
                            sql &= " INTPOST,"
                            sql &= " LPDATE,"
                            sql &= " LPAMT,"
                            sql &= " LPPOST,"
                            sql &= " LDAMT,"
                            sql &= " LDPOST"
                      sql &= ") VALUES ("
                      sql &= " @OTCOUNTER,"
                      sql &= " @ENDOFDAY,"
                      sql &= " @INTACCR,"
                      sql &= " @INTPOST,"
                      sql &= " @LPDATE,"
                      sql &= " @LPAMT,"
                      sql &= " @LPPOST,"
                      sql &= " @LDAMT,"
                      sql &= " @LDPOST"
                      sql &= ")"
		            Else
			            sql = "UPDATE Param_s SET "
                  sql &= "OTCOUNTER = @OTCOUNTER,"
                  sql &= "ENDOFDAY = @ENDOFDAY,"
                  sql &= "INTACCR = @INTACCR,"
                  sql &= "INTPOST = @INTPOST,"
                  sql &= "LPDATE = @LPDATE,"
                  sql &= "LPAMT = @LPAMT,"
                  sql &= "LPPOST = @LPPOST,"
                  sql &= "LDAMT = @LDAMT,"
                  sql &= "LDPOST = @LDPOST"
			            sql &= " WHERE OTCOUNTER= " & cls.OTCOUNTER
		            End if
					
					Dim p As DbParameter = Nothing 
					p = myCommand.CreateParameter
					p.ParameterName = "@OTCOUNTER"
					p.Value = cls.OTCOUNTER
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ENDOFDAY"
					p.Value = cls.ENDOFDAY
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@INTACCR"
					p.Value = cls.INTACCR
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@INTPOST"
					p.Value = cls.INTPOST
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@LPDATE"
					p.Value = cls.LPDATE
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@LPAMT"
					p.Value = cls.LPAMT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@LPPOST"
					p.DbType = DbType.DateTime
					if cls.LPPOST <> Date.MinValue then
			            p.Value = cls.LPPOST
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@LDAMT"
					p.Value = cls.LDAMT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@LDPOST"
					p.DbType = DbType.DateTime
					if cls.LDPOST <> Date.MinValue then
			            p.Value = cls.LDPOST
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

                    myCommand.CommandType = CommandType.Text
		            myCommand.CommandText = sql
		            myCommand.ExecuteNonQuery()

                    Ris  =  cls.OTCOUNTER
		            

	            Catch ex As Exception
		            ManageError(ex)
	            End Try
            End Using
        else
	        Ris  =  cls.OTCOUNTER
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
        'Dim Sql As String = "UPDATE Param_s SET DELETED=True "
        Dim Sql As String = "DELETE FROM Param_s"
        Sql &= " Where OTCOUNTER = " & Id 

        myCommand.CommandText = Sql
        If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
        myCommand.ExecuteNonQuery()
    
    End Using
    Catch ex As Exception
	    ManageError(ex)
    End Try
End Sub

''' <summary>
'''Delete from DB table Param_s. Accept id of object to delete.
''' </summary>
Public Overrides Sub Delete(Id as integer) 
        DestroyPermanently (Id)
    End Sub

''' <summary>
'''Delete from DB table Param_s. Accept object to delete and optional a List to remove the object from.
''' </summary>
Public Overrides Sub Delete(byref obj as Param_s, Optional ByRef ListaObj as List (of Param_s) = Nothing)
        DestroyPermanently (obj.OTCOUNTER)
    If Not ListaObj Is Nothing Then ListaObj.Remove(obj)
     
End Sub

''' <summary>
'''Find on DB table Param_s
''' </summary>
''' <returns>
'''Return first of Param_s
''' </returns>
Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Param_s
    Dim ris As Param_s = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1}
    Dim l As IEnumerable(Of Param_s) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function

''' <summary>
'''Find on DB table Param_s
''' </summary>
''' <returns>
'''Return first of Param_s
''' </returns>
Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Param_s
    Dim ris As Param_s = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1, .OrderBy = OrderBy}
    Dim l As IEnumerable(Of Param_s) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function
''' <summary>
'''Find on DB table Param_s
''' </summary>
''' <returns>
'''Return a list of Param_s
''' </returns>
Public Overrides Function FindAll(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Param_s)
    Dim So As New Luna.LunaSearchOption
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Param_s
''' </summary>
''' <returns>
'''Return a list of Param_s
''' </returns>
Public Overloads Function FindAll(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Param_s)
    Dim So As New Luna.LunaSearchOption With {.OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Param_s
''' </summary>
''' <returns>
'''Return a list of Param_s
''' </returns>
Public Overloads Function FindAll(byVal Top as integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Param_s)
    Dim So As New Luna.LunaSearchOption With {.Top = Top, .OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Param_s
''' </summary>
''' <returns>
'''Return a list of Param_s
''' </returns>
Public Overloads Function FindAll(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Param_s)
    Return FindReal(SearchOption, Parameter)
End Function

Private Function FindReal(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as iEnumerable(Of Param_s)
    Dim Ls As New List(Of Param_s)
    Try

    Dim sql As String = ""
    sql ="SELECT "   
		if SearchOption.Top then sql &= " TOP " & SearchOption.Top
		sql &=" * from Param_s" 
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

Public Overrides Function GetAll(Optional OrderByField as string = "", Optional ByVal AddEmptyItem As Boolean = False) as iEnumerable(Of Param_s)
    Dim Ls As New List(Of Param_s)
    Try

    Dim sql As String = ""
    sql ="SELECT * from Param_s" 
    If OrderByField.Length Then
	    Sql &= " ORDER BY " & OrderByField
    End If

    Ls = GetData(Sql,AddEmptyItem)

    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ls
End Function



    Protected Function GetData(ByVal sql As String, Optional ByVal AddEmptyItem As Boolean = False) As iEnumerable(Of Param_s)
        Dim Ls As New List(Of Param_s)
        Try
            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = sql
                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                Using myReader As DbDataReader = myCommand.ExecuteReader()
                    If AddEmptyItem Then Ls.Add(New Param_s() With {.OTCOUNTER = False, .ENDOFDAY = False, .INTACCR = False, .INTPOST = False, .LPDATE = 0, .LPAMT = 0, .LPPOST = Nothing, .LDAMT = 0, .LDPOST = Nothing})
                    While myReader.Read
                        Dim classe As New Param_s(CType(myReader, IDataRecord))
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
