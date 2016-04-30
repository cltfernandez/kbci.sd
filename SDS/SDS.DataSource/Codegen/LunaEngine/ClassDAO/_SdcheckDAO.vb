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
'''This class manage persistency on db of Sdcheck object
''' </summary>
''' <remarks>
'''
''' </remarks>

Public MustInherit Class _SdcheckDAO
Inherits LUNA.LunaBaseClassDAO(Of Sdcheck)

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
'''Read from DB table Sdcheck
''' </summary>
''' <returns>
'''Return a Sdcheck object
''' </returns>
Public Overrides Function Read(Id as integer) as Sdcheck
    Dim cls as new Sdcheck

    Try
        Using myCommand As DbCommand = _cn.CreateCommand
        
            myCommand.CommandText = "SELECT * FROM Sdcheck where SDCHECK_ID = " & Id
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
'''Save on DB table Sdcheck
''' </summary>
''' <returns>
'''Return ID insert in DB
''' </returns>
Public Overrides Function Save(byRef cls as Sdcheck) as Integer

    Dim Ris as integer=0 'in Ris return Insert Id

    If cls.IsValid Then
        If cls.IsChanged Then
            Using myCommand As DbCommand = _Cn.CreateCommand()
	            Try
		            Dim sql As String = String.Empty
		            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
		            If cls.SDCHECK_ID = 0 Then
                        sql = "INSERT INTO Sdcheck ("
                            sql &= " ACCTNUM,"
                            sql &= " TRANDATE,"
                            sql &= " TRANSEQ,"
                            sql &= " CHKCODE,"
                            sql &= " CHKAMT,"
                            sql &= " CHKNUM,"
                            sql &= " CHKBANK,"
                            sql &= " CHKCDATE,"
                            sql &= " CHKCDAYS,"
                            sql &= " CHKNDAYS,"
                            sql &= " CHKSTAT,"
                            sql &= " ADD_DATE,"
                            sql &= " ADD_TIME,"
                            sql &= " USER"
                      sql &= ") VALUES ("
                      sql &= " @ACCTNUM,"
                      sql &= " @TRANDATE,"
                      sql &= " @TRANSEQ,"
                      sql &= " @CHKCODE,"
                      sql &= " @CHKAMT,"
                      sql &= " @CHKNUM,"
                      sql &= " @CHKBANK,"
                      sql &= " @CHKCDATE,"
                      sql &= " @CHKCDAYS,"
                      sql &= " @CHKNDAYS,"
                      sql &= " @CHKSTAT,"
                      sql &= " @ADD_DATE,"
                      sql &= " @ADD_TIME,"
                      sql &= " @USER"
                      sql &= ")"
		            Else
			            sql = "UPDATE Sdcheck SET "
                  sql &= "ACCTNUM = @ACCTNUM,"
                  sql &= "TRANDATE = @TRANDATE,"
                  sql &= "TRANSEQ = @TRANSEQ,"
                  sql &= "CHKCODE = @CHKCODE,"
                  sql &= "CHKAMT = @CHKAMT,"
                  sql &= "CHKNUM = @CHKNUM,"
                  sql &= "CHKBANK = @CHKBANK,"
                  sql &= "CHKCDATE = @CHKCDATE,"
                  sql &= "CHKCDAYS = @CHKCDAYS,"
                  sql &= "CHKNDAYS = @CHKNDAYS,"
                  sql &= "CHKSTAT = @CHKSTAT,"
                  sql &= "ADD_DATE = @ADD_DATE,"
                  sql &= "ADD_TIME = @ADD_TIME,"
                  sql &= "USER = @USER"
			            sql &= " WHERE SDCHECK_ID= " & cls.SDCHECK_ID
		            End if
					
					Dim p As DbParameter = Nothing 
					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTNUM"
					p.Value = cls.ACCTNUM
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@TRANDATE"
					p.DbType = DbType.DateTime
					if cls.TRANDATE <> Date.MinValue then
			            p.Value = cls.TRANDATE
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@TRANSEQ"
					p.Value = cls.TRANSEQ
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CHKCODE"
					p.Value = cls.CHKCODE
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CHKAMT"
					p.Value = cls.CHKAMT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CHKNUM"
					p.Value = cls.CHKNUM
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CHKBANK"
					p.Value = cls.CHKBANK
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CHKCDATE"
					p.DbType = DbType.DateTime
					if cls.CHKCDATE <> Date.MinValue then
			            p.Value = cls.CHKCDATE
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CHKCDAYS"
					p.Value = cls.CHKCDAYS
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CHKNDAYS"
					p.Value = cls.CHKNDAYS
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CHKSTAT"
					p.Value = cls.CHKSTAT
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
					p.ParameterName = "@ADD_TIME"
					p.Value = cls.ADD_TIME
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@USER"
					p.Value = cls.USER
  					myCommand.Parameters.Add(p)

                    myCommand.CommandType = CommandType.Text
		            myCommand.CommandText = sql
		            myCommand.ExecuteNonQuery()

		            
					If cls.SDCHECK_ID=0 Then
			            Dim IdInserito as integer = 0
			            Sql = "select @@identity"
			            myCommand.CommandText = Sql
			            Idinserito = myCommand.ExecuteScalar()
			            cls.SDCHECK_ID = Idinserito
			            Ris = Idinserito
		            else
			            Ris  =  cls.SDCHECK_ID
		            End If
		            

	            Catch ex As Exception
		            ManageError(ex)
	            End Try
            End Using
        else
	        Ris  =  cls.SDCHECK_ID
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
        'Dim Sql As String = "UPDATE Sdcheck SET DELETED=True "
        Dim Sql As String = "DELETE FROM Sdcheck"
        Sql &= " Where SDCHECK_ID = " & Id 

        myCommand.CommandText = Sql
        If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
        myCommand.ExecuteNonQuery()
    
    End Using
    Catch ex As Exception
	    ManageError(ex)
    End Try
End Sub

''' <summary>
'''Delete from DB table Sdcheck. Accept id of object to delete.
''' </summary>
Public Overrides Sub Delete(Id as integer) 
        DestroyPermanently (Id)
    End Sub

''' <summary>
'''Delete from DB table Sdcheck. Accept object to delete and optional a List to remove the object from.
''' </summary>
Public Overrides Sub Delete(byref obj as Sdcheck, Optional ByRef ListaObj as List (of Sdcheck) = Nothing)
        DestroyPermanently (obj.SDCHECK_ID)
    If Not ListaObj Is Nothing Then ListaObj.Remove(obj)
     
End Sub

''' <summary>
'''Find on DB table Sdcheck
''' </summary>
''' <returns>
'''Return first of Sdcheck
''' </returns>
Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Sdcheck
    Dim ris As Sdcheck = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1}
    Dim l As IEnumerable(Of Sdcheck) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function

''' <summary>
'''Find on DB table Sdcheck
''' </summary>
''' <returns>
'''Return first of Sdcheck
''' </returns>
Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Sdcheck
    Dim ris As Sdcheck = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1, .OrderBy = OrderBy}
    Dim l As IEnumerable(Of Sdcheck) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function
''' <summary>
'''Find on DB table Sdcheck
''' </summary>
''' <returns>
'''Return a list of Sdcheck
''' </returns>
Public Overrides Function FindAll(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Sdcheck)
    Dim So As New Luna.LunaSearchOption
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Sdcheck
''' </summary>
''' <returns>
'''Return a list of Sdcheck
''' </returns>
Public Overloads Function FindAll(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Sdcheck)
    Dim So As New Luna.LunaSearchOption With {.OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Sdcheck
''' </summary>
''' <returns>
'''Return a list of Sdcheck
''' </returns>
Public Overloads Function FindAll(byVal Top as integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Sdcheck)
    Dim So As New Luna.LunaSearchOption With {.Top = Top, .OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Sdcheck
''' </summary>
''' <returns>
'''Return a list of Sdcheck
''' </returns>
Public Overloads Function FindAll(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Sdcheck)
    Return FindReal(SearchOption, Parameter)
End Function

Private Function FindReal(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as iEnumerable(Of Sdcheck)
    Dim Ls As New List(Of Sdcheck)
    Try

    Dim sql As String = ""
    sql ="SELECT "   
		if SearchOption.Top then sql &= " TOP " & SearchOption.Top
		sql &=" * from Sdcheck" 
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

Public Overrides Function GetAll(Optional OrderByField as string = "", Optional ByVal AddEmptyItem As Boolean = False) as iEnumerable(Of Sdcheck)
    Dim Ls As New List(Of Sdcheck)
    Try

    Dim sql As String = ""
    sql ="SELECT * from Sdcheck" 
    If OrderByField.Length Then
	    Sql &= " ORDER BY " & OrderByField
    End If

    Ls = GetData(Sql,AddEmptyItem)

    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ls
End Function



    Protected Function GetData(ByVal sql As String, Optional ByVal AddEmptyItem As Boolean = False) As iEnumerable(Of Sdcheck)
        Dim Ls As New List(Of Sdcheck)
        Try
            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = sql
                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                Using myReader As DbDataReader = myCommand.ExecuteReader()
                    If AddEmptyItem Then Ls.Add(New Sdcheck() With {.SDCHECK_ID = Nothing, .ACCTNUM = "", .TRANDATE = Nothing, .TRANSEQ = 0, .CHKCODE = "", .CHKAMT = 0, .CHKNUM = "", .CHKBANK = "", .CHKCDATE = Nothing, .CHKCDAYS = 0, .CHKNDAYS = 0, .CHKSTAT = "", .ADD_DATE = Nothing, .ADD_TIME = "", .USER = ""})
                    While myReader.Read
                        Dim classe As New Sdcheck(CType(myReader, IDataRecord))
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
