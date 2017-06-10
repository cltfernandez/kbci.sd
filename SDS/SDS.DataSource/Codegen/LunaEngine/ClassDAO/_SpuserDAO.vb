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
'''This class manage persistency on db of Spuser object
''' </summary>
''' <remarks>
'''
''' </remarks>

Public MustInherit Class _SpuserDAO
Inherits LUNA.LunaBaseClassDAO(Of Spuser)

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
'''Read from DB table Spuser
''' </summary>
''' <returns>
'''Return a Spuser object
''' </returns>
Public Overrides Function Read(Id as integer) as Spuser
    Dim cls as new Spuser

    Try
        Using myCommand As DbCommand = _cn.CreateCommand
        
            myCommand.CommandText = "SELECT * FROM Spuser where SPUSER_ID = " & Id
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
'''Save on DB table Spuser
''' </summary>
''' <returns>
'''Return ID insert in DB
''' </returns>
Public Overrides Function Save(byRef cls as Spuser) as Integer

    Dim Ris as integer=0 'in Ris return Insert Id

    If cls.IsValid Then
        If cls.IsChanged Then
            Using myCommand As DbCommand = _Cn.CreateCommand()
	            Try
		            Dim sql As String = String.Empty
		            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
		            If cls.SPUSER_ID = 0 Then
                        sql = "INSERT INTO Spuser ("
                            sql &= " SPUSERID,"
                            sql &= " SPUSERPASS,"
                            sql &= " SPUSERNAME,"
                            sql &= " SPUSERPOS,"
                            sql &= " SPLOGSTAT,"
                            sql &= " SPLOGNO,"
                            sql &= " SPTELLER,"
                            sql &= " SPTAG,"
                            sql &= " ADD_DATE,"
                            sql &= " CHG_DATE,"
                            sql &= " USER"
                      sql &= ") VALUES ("
                      sql &= " @SPUSERID,"
                      sql &= " @SPUSERPASS,"
                      sql &= " @SPUSERNAME,"
                      sql &= " @SPUSERPOS,"
                      sql &= " @SPLOGSTAT,"
                      sql &= " @SPLOGNO,"
                      sql &= " @SPTELLER,"
                      sql &= " @SPTAG,"
                      sql &= " @ADD_DATE,"
                      sql &= " @CHG_DATE,"
                      sql &= " @USER"
                      sql &= ")"
		            Else
			            sql = "UPDATE Spuser SET "
                  sql &= "SPUSERID = @SPUSERID,"
                  sql &= "SPUSERPASS = @SPUSERPASS,"
                  sql &= "SPUSERNAME = @SPUSERNAME,"
                  sql &= "SPUSERPOS = @SPUSERPOS,"
                  sql &= "SPLOGSTAT = @SPLOGSTAT,"
                  sql &= "SPLOGNO = @SPLOGNO,"
                  sql &= "SPTELLER = @SPTELLER,"
                  sql &= "SPTAG = @SPTAG,"
                  sql &= "ADD_DATE = @ADD_DATE,"
                  sql &= "CHG_DATE = @CHG_DATE,"
                            sql &= "[USER] = @USER"
			            sql &= " WHERE SPUSER_ID= " & cls.SPUSER_ID
		            End if
					
					Dim p As DbParameter = Nothing 
					p = myCommand.CreateParameter
					p.ParameterName = "@SPUSERID"
					p.Value = cls.SPUSERID
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@SPUSERPASS"
					p.Value = cls.SPUSERPASS
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@SPUSERNAME"
					p.Value = cls.SPUSERNAME
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@SPUSERPOS"
					p.Value = cls.SPUSERPOS
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@SPLOGSTAT"
					p.Value = cls.SPLOGSTAT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@SPLOGNO"
					p.Value = cls.SPLOGNO
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@SPTELLER"
					p.Value = cls.SPTELLER
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@SPTAG"
					p.Value = cls.SPTAG
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

                    myCommand.CommandType = CommandType.Text
		            myCommand.CommandText = sql
		            myCommand.ExecuteNonQuery()

		            
					If cls.SPUSER_ID=0 Then
			            Dim IdInserito as integer = 0
			            Sql = "select @@identity"
			            myCommand.CommandText = Sql
			            Idinserito = myCommand.ExecuteScalar()
			            cls.SPUSER_ID = Idinserito
			            Ris = Idinserito
		            else
			            Ris  =  cls.SPUSER_ID
		            End If
		            

	            Catch ex As Exception
		            ManageError(ex)
	            End Try
            End Using
        else
	        Ris  =  cls.SPUSER_ID
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
        'Dim Sql As String = "UPDATE Spuser SET DELETED=True "
        Dim Sql As String = "DELETE FROM Spuser"
        Sql &= " Where SPUSER_ID = " & Id 

        myCommand.CommandText = Sql
        If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
        myCommand.ExecuteNonQuery()
    
    End Using
    Catch ex As Exception
	    ManageError(ex)
    End Try
End Sub

''' <summary>
'''Delete from DB table Spuser. Accept id of object to delete.
''' </summary>
Public Overrides Sub Delete(Id as integer) 
        DestroyPermanently (Id)
    End Sub

''' <summary>
'''Delete from DB table Spuser. Accept object to delete and optional a List to remove the object from.
''' </summary>
Public Overrides Sub Delete(byref obj as Spuser, Optional ByRef ListaObj as List (of Spuser) = Nothing)
        DestroyPermanently (obj.SPUSER_ID)
    If Not ListaObj Is Nothing Then ListaObj.Remove(obj)
     
End Sub

''' <summary>
'''Find on DB table Spuser
''' </summary>
''' <returns>
'''Return first of Spuser
''' </returns>
Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Spuser
    Dim ris As Spuser = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1}
    Dim l As IEnumerable(Of Spuser) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function

''' <summary>
'''Find on DB table Spuser
''' </summary>
''' <returns>
'''Return first of Spuser
''' </returns>
Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Spuser
    Dim ris As Spuser = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1, .OrderBy = OrderBy}
    Dim l As IEnumerable(Of Spuser) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function
''' <summary>
'''Find on DB table Spuser
''' </summary>
''' <returns>
'''Return a list of Spuser
''' </returns>
Public Overrides Function FindAll(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Spuser)
    Dim So As New Luna.LunaSearchOption
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Spuser
''' </summary>
''' <returns>
'''Return a list of Spuser
''' </returns>
Public Overloads Function FindAll(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Spuser)
    Dim So As New Luna.LunaSearchOption With {.OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Spuser
''' </summary>
''' <returns>
'''Return a list of Spuser
''' </returns>
Public Overloads Function FindAll(byVal Top as integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Spuser)
    Dim So As New Luna.LunaSearchOption With {.Top = Top, .OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Spuser
''' </summary>
''' <returns>
'''Return a list of Spuser
''' </returns>
Public Overloads Function FindAll(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Spuser)
    Return FindReal(SearchOption, Parameter)
End Function

Private Function FindReal(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as iEnumerable(Of Spuser)
    Dim Ls As New List(Of Spuser)
    Try

    Dim sql As String = ""
    sql ="SELECT "   
		if SearchOption.Top then sql &= " TOP " & SearchOption.Top
		sql &=" * from Spuser" 
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

            If Not SearchOption.OrderBy = Nothing Then
                sql &= " ORDER BY " & SearchOption.OrderBy
            End If



            Ls = GetData(sql, SearchOption.AddEmptyItem)

    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ls
End Function

Public Overrides Function GetAll(Optional OrderByField as string = "", Optional ByVal AddEmptyItem As Boolean = False) as iEnumerable(Of Spuser)
    Dim Ls As New List(Of Spuser)
    Try

    Dim sql As String = ""
    sql ="SELECT * from Spuser" 
    If OrderByField.Length Then
	    Sql &= " ORDER BY " & OrderByField
    End If

    Ls = GetData(Sql,AddEmptyItem)

    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ls
End Function



    Protected Function GetData(ByVal sql As String, Optional ByVal AddEmptyItem As Boolean = False) As iEnumerable(Of Spuser)
        Dim Ls As New List(Of Spuser)
        Try
            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = sql
                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                Using myReader As DbDataReader = myCommand.ExecuteReader()
                    If AddEmptyItem Then Ls.Add(New Spuser() With {.SPUSER_ID = Nothing, .SPUSERID = "", .SPUSERPASS = "", .SPUSERNAME = "", .SPUSERPOS = "", .SPLOGSTAT = False, .SPLOGNO = 0, .SPTELLER = False, .SPTAG = "", .ADD_DATE = Nothing, .CHG_DATE = Nothing, .USER = ""})
                    While myReader.Read
                        Dim classe As New Spuser(CType(myReader, IDataRecord))
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
