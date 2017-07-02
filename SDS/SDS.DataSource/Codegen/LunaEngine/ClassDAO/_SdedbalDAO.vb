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
'''This class manage persistency on db of Sdedbal object
''' </summary>
''' <remarks>
'''
''' </remarks>

Public MustInherit Class _SdedbalDAO
Inherits LUNA.LunaBaseClassDAO(Of Sdedbal)

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
'''Read from DB table Sdedbal
''' </summary>
''' <returns>
'''Return a Sdedbal object
''' </returns>
Public Overrides Function Read(Id as integer) as Sdedbal
    Dim cls as new Sdedbal

    Try
        Using myCommand As DbCommand = _cn.CreateCommand
        
            myCommand.CommandText = "SELECT * FROM Sdedbal where SDEDBAL_ID = " & Id
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
'''Save on DB table Sdedbal
''' </summary>
''' <returns>
'''Return ID insert in DB
''' </returns>
Public Overrides Function Save(byRef cls as Sdedbal) as Integer

    Dim Ris as integer=0 'in Ris return Insert Id

    If cls.IsValid Then
        If cls.IsChanged Then
            Using myCommand As DbCommand = _Cn.CreateCommand()
	            Try
		            Dim sql As String = String.Empty
		            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
		            If cls.SDEDBAL_ID = 0 Then
                        sql = "INSERT INTO Sdedbal ("
                            sql &= " ID,"
                            sql &= " PN_TAG,"
                            sql &= " PN_NO,"
                            sql &= " LOAN_TYPE,"
                            sql &= " LOAN_STAT,"
                            sql &= " DATE_GRANT,"
                            sql &= " DATE_DUE,"
                            sql &= " KBCI_NO,"
                            sql &= " PRINCIPAL,"
                            sql &= " OUTSBAL,"
                            sql &= " RENEW,"
                            sql &= " ARREARS,"
                            sql &= " PAY_TAG,"
                            sql &= " PAY_AMT,"
                            sql &= " LRI_DUE,"
                            sql &= " YEARLY_LRI"
                      sql &= ") VALUES ("
                      sql &= " @ID,"
                      sql &= " @PN_TAG,"
                      sql &= " @PN_NO,"
                      sql &= " @LOAN_TYPE,"
                      sql &= " @LOAN_STAT,"
                      sql &= " @DATE_GRANT,"
                      sql &= " @DATE_DUE,"
                      sql &= " @KBCI_NO,"
                      sql &= " @PRINCIPAL,"
                      sql &= " @OUTSBAL,"
                      sql &= " @RENEW,"
                      sql &= " @ARREARS,"
                      sql &= " @PAY_TAG,"
                      sql &= " @PAY_AMT,"
                      sql &= " @LRI_DUE,"
                      sql &= " @YEARLY_LRI"
                      sql &= ")"
		            Else
			            sql = "UPDATE Sdedbal SET "
                  sql &= "ID = @ID,"
                  sql &= "PN_TAG = @PN_TAG,"
                  sql &= "PN_NO = @PN_NO,"
                  sql &= "LOAN_TYPE = @LOAN_TYPE,"
                  sql &= "LOAN_STAT = @LOAN_STAT,"
                  sql &= "DATE_GRANT = @DATE_GRANT,"
                  sql &= "DATE_DUE = @DATE_DUE,"
                  sql &= "KBCI_NO = @KBCI_NO,"
                  sql &= "PRINCIPAL = @PRINCIPAL,"
                  sql &= "OUTSBAL = @OUTSBAL,"
                  sql &= "RENEW = @RENEW,"
                  sql &= "ARREARS = @ARREARS,"
                  sql &= "PAY_TAG = @PAY_TAG,"
                  sql &= "PAY_AMT = @PAY_AMT,"
                  sql &= "LRI_DUE = @LRI_DUE,"
                  sql &= "YEARLY_LRI = @YEARLY_LRI"
			            sql &= " WHERE SDEDBAL_ID= " & cls.SDEDBAL_ID
		            End if
					
					Dim p As DbParameter = Nothing 
					p = myCommand.CreateParameter
					p.ParameterName = "@ID"
					p.Value = cls.ID
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@PN_TAG"
					p.Value = cls.PN_TAG
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@PN_NO"
					p.Value = cls.PN_NO
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
					p.ParameterName = "@DATE_GRANT"
					p.DbType = DbType.DateTime
					if cls.DATE_GRANT <> Date.MinValue then
			            p.Value = cls.DATE_GRANT
                    else
                        p.Value = DBNull.Value
                    end if  
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
					p.ParameterName = "@KBCI_NO"
					p.Value = cls.KBCI_NO
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@PRINCIPAL"
					p.Value = cls.PRINCIPAL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@OUTSBAL"
					p.Value = cls.OUTSBAL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@RENEW"
					p.Value = cls.RENEW
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ARREARS"
					p.Value = cls.ARREARS
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@PAY_TAG"
					p.Value = cls.PAY_TAG
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@PAY_AMT"
					p.Value = cls.PAY_AMT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@LRI_DUE"
					p.Value = cls.LRI_DUE
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@YEARLY_LRI"
					p.Value = cls.YEARLY_LRI
  					myCommand.Parameters.Add(p)

                    myCommand.CommandType = CommandType.Text
		            myCommand.CommandText = sql
		            myCommand.ExecuteNonQuery()

		            
					If cls.SDEDBAL_ID=0 Then
			            Dim IdInserito as integer = 0
			            Sql = "select @@identity"
			            myCommand.CommandText = Sql
			            Idinserito = myCommand.ExecuteScalar()
			            cls.SDEDBAL_ID = Idinserito
			            Ris = Idinserito
		            else
			            Ris  =  cls.SDEDBAL_ID
		            End If
		            

	            Catch ex As Exception
		            ManageError(ex)
	            End Try
            End Using
        else
	        Ris  =  cls.SDEDBAL_ID
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
        'Dim Sql As String = "UPDATE Sdedbal SET DELETED=True "
        Dim Sql As String = "DELETE FROM Sdedbal"
        Sql &= " Where SDEDBAL_ID = " & Id 

        myCommand.CommandText = Sql
        If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
        myCommand.ExecuteNonQuery()
    
    End Using
    Catch ex As Exception
	    ManageError(ex)
    End Try
End Sub

''' <summary>
'''Delete from DB table Sdedbal. Accept id of object to delete.
''' </summary>
Public Overrides Sub Delete(Id as integer) 
        DestroyPermanently (Id)
    End Sub

''' <summary>
'''Delete from DB table Sdedbal. Accept object to delete and optional a List to remove the object from.
''' </summary>
Public Overrides Sub Delete(byref obj as Sdedbal, Optional ByRef ListaObj as List (of Sdedbal) = Nothing)
        DestroyPermanently (obj.SDEDBAL_ID)
    If Not ListaObj Is Nothing Then ListaObj.Remove(obj)
     
End Sub

''' <summary>
'''Find on DB table Sdedbal
''' </summary>
''' <returns>
'''Return first of Sdedbal
''' </returns>
Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Sdedbal
    Dim ris As Sdedbal = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1}
    Dim l As IEnumerable(Of Sdedbal) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function

''' <summary>
'''Find on DB table Sdedbal
''' </summary>
''' <returns>
'''Return first of Sdedbal
''' </returns>
Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Sdedbal
    Dim ris As Sdedbal = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1, .OrderBy = OrderBy}
    Dim l As IEnumerable(Of Sdedbal) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function
''' <summary>
'''Find on DB table Sdedbal
''' </summary>
''' <returns>
'''Return a list of Sdedbal
''' </returns>
Public Overrides Function FindAll(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Sdedbal)
    Dim So As New Luna.LunaSearchOption
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Sdedbal
''' </summary>
''' <returns>
'''Return a list of Sdedbal
''' </returns>
Public Overloads Function FindAll(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Sdedbal)
    Dim So As New Luna.LunaSearchOption With {.OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Sdedbal
''' </summary>
''' <returns>
'''Return a list of Sdedbal
''' </returns>
Public Overloads Function FindAll(byVal Top as integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Sdedbal)
    Dim So As New Luna.LunaSearchOption With {.Top = Top, .OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Sdedbal
''' </summary>
''' <returns>
'''Return a list of Sdedbal
''' </returns>
Public Overloads Function FindAll(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Sdedbal)
    Return FindReal(SearchOption, Parameter)
End Function

Private Function FindReal(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as iEnumerable(Of Sdedbal)
    Dim Ls As New List(Of Sdedbal)
    Try

    Dim sql As String = ""
    sql ="SELECT "   
		if SearchOption.Top then sql &= " TOP " & SearchOption.Top
		sql &=" * from Sdedbal" 
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

Public Overrides Function GetAll(Optional OrderByField as string = "", Optional ByVal AddEmptyItem As Boolean = False) as iEnumerable(Of Sdedbal)
    Dim Ls As New List(Of Sdedbal)
    Try

    Dim sql As String = ""
    sql ="SELECT * from Sdedbal" 
    If OrderByField.Length Then
	    Sql &= " ORDER BY " & OrderByField
    End If

    Ls = GetData(Sql,AddEmptyItem)

    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ls
End Function



    Protected Function GetData(ByVal sql As String, Optional ByVal AddEmptyItem As Boolean = False) As iEnumerable(Of Sdedbal)
        Dim Ls As New List(Of Sdedbal)
        Try
            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = sql
                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                Using myReader As DbDataReader = myCommand.ExecuteReader()
                    If AddEmptyItem Then Ls.Add(New Sdedbal() With {.SDEDBAL_ID = Nothing, .ID = "", .PN_TAG = False, .PN_NO = "", .LOAN_TYPE = "", .LOAN_STAT = "", .DATE_GRANT = Nothing, .DATE_DUE = Nothing, .KBCI_NO = "", .PRINCIPAL = 0, .OUTSBAL = 0, .RENEW = False, .ARREARS = 0, .PAY_TAG = "", .PAY_AMT = 0, .LRI_DUE = 0, .YEARLY_LRI = 0})
                    While myReader.Read
                        Dim classe As New Sdedbal(CType(myReader, IDataRecord))
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
