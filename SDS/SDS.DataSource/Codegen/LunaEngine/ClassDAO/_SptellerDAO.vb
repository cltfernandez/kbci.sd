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
'''This class manage persistency on db of Spteller object
''' </summary>
''' <remarks>
'''
''' </remarks>

Public MustInherit Class _SptellerDAO
Inherits LUNA.LunaBaseClassDAO(Of Spteller)

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
'''Read from DB table Spteller
''' </summary>
''' <returns>
'''Return a Spteller object
''' </returns>
Public Overrides Function Read(Id as integer) as Spteller
    Dim cls as new Spteller

    Try
        Using myCommand As DbCommand = _cn.CreateCommand
        
            myCommand.CommandText = "SELECT * FROM Spteller where SPTELLER_ID = " & Id
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
'''Save on DB table Spteller
''' </summary>
''' <returns>
'''Return ID insert in DB
''' </returns>
Public Overrides Function Save(byRef cls as Spteller) as Integer

    Dim Ris as integer=0 'in Ris return Insert Id

    If cls.IsValid Then
        If cls.IsChanged Then
            Using myCommand As DbCommand = _Cn.CreateCommand()
	            Try
		            Dim sql As String = String.Empty
		            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
		            If cls.SPTELLER_ID = 0 Then
                        sql = "INSERT INTO Spteller ("
                            sql &= " TNAME,"
                            sql &= " TDATE,"
                            sql &= " CASHB,"
                            sql &= " COCIB,"
                            sql &= " ADDLREQ,"
                            sql &= " ADDMREQ,"
                            sql &= " CASHSAV,"
                            sql &= " CASHOR,"
                            sql &= " ADDLTD,"
                            sql &= " CTFNAME1,"
                            sql &= " CTFAMT1,"
                            sql &= " CTFNAME2,"
                            sql &= " CTFAMT2,"
                            sql &= " CTFNAME3,"
                            sql &= " CTFAMT3,"
                            sql &= " ADDCASH,"
                            sql &= " CRSAV,"
                            sql &= " CRORO,"
                            sql &= " CRACC,"
                            sql &= " CRCR,"
                            sql &= " ADDCHECKS,"
                            sql &= " ADDTOTAL,"
                            sql &= " DIB,"
                            sql &= " REF,"
                            sql &= " [WITH],"
                            sql &= " CHKENC,"
                            sql &= " COCI,"
                            sql &= " CHKDEP,"
                            sql &= " EMER,"
                            sql &= " CTTNAME1,"
                            sql &= " CTTAMT1,"
                            sql &= " CTTNAME2,"
                            sql &= " CTTAMT2,"
                            sql &= " CTTNAME3,"
                            sql &= " CTTAMT3,"
                            sql &= " TOTDISB,"
                            sql &= " CBALEND,"
                            sql &= " CTTCEND,"
                            sql &= " [OVER],"
                            sql &= " B_1000,"
                            sql &= " B_500,"
                            sql &= " B_200,"
                            sql &= " B_100,"
                            sql &= " B_50,"
                            sql &= " B_20,"
                            sql &= " B_10,"
                            sql &= " B_5,"
                            sql &= " B_1,"
                            sql &= " B_P50,"
                            sql &= " B_P25,"
                            sql &= " B_P10,"
                            sql &= " B_P05,"
                            sql &= " B_P01,"
                            sql &= " TCCOUNT"
                      sql &= ") VALUES ("
                      sql &= " @TNAME,"
                      sql &= " @TDATE,"
                      sql &= " @CASHB,"
                      sql &= " @COCIB,"
                      sql &= " @ADDLREQ,"
                      sql &= " @ADDMREQ,"
                      sql &= " @CASHSAV,"
                      sql &= " @CASHOR,"
                      sql &= " @ADDLTD,"
                      sql &= " @CTFNAME1,"
                      sql &= " @CTFAMT1,"
                      sql &= " @CTFNAME2,"
                      sql &= " @CTFAMT2,"
                      sql &= " @CTFNAME3,"
                      sql &= " @CTFAMT3,"
                      sql &= " @ADDCASH,"
                      sql &= " @CRSAV,"
                      sql &= " @CRORO,"
                      sql &= " @CRACC,"
                      sql &= " @CRCR,"
                      sql &= " @ADDCHECKS,"
                      sql &= " @ADDTOTAL,"
                      sql &= " @DIB,"
                      sql &= " @REF,"
                      sql &= " @WITH,"
                      sql &= " @CHKENC,"
                      sql &= " @COCI,"
                      sql &= " @CHKDEP,"
                      sql &= " @EMER,"
                      sql &= " @CTTNAME1,"
                      sql &= " @CTTAMT1,"
                      sql &= " @CTTNAME2,"
                      sql &= " @CTTAMT2,"
                      sql &= " @CTTNAME3,"
                      sql &= " @CTTAMT3,"
                      sql &= " @TOTDISB,"
                      sql &= " @CBALEND,"
                      sql &= " @CTTCEND,"
                      sql &= " @OVER,"
                      sql &= " @B_1000,"
                      sql &= " @B_500,"
                      sql &= " @B_200,"
                      sql &= " @B_100,"
                      sql &= " @B_50,"
                      sql &= " @B_20,"
                      sql &= " @B_10,"
                      sql &= " @B_5,"
                      sql &= " @B_1,"
                      sql &= " @B_P50,"
                      sql &= " @B_P25,"
                      sql &= " @B_P10,"
                      sql &= " @B_P05,"
                      sql &= " @B_P01,"
                      sql &= " @TCCOUNT"
                      sql &= ")"
		            Else
			            sql = "UPDATE Spteller SET "
                  sql &= "TNAME = @TNAME,"
                  sql &= "TDATE = @TDATE,"
                  sql &= "CASHB = @CASHB,"
                  sql &= "COCIB = @COCIB,"
                  sql &= "ADDLREQ = @ADDLREQ,"
                  sql &= "ADDMREQ = @ADDMREQ,"
                  sql &= "CASHSAV = @CASHSAV,"
                  sql &= "CASHOR = @CASHOR,"
                  sql &= "ADDLTD = @ADDLTD,"
                  sql &= "CTFNAME1 = @CTFNAME1,"
                  sql &= "CTFAMT1 = @CTFAMT1,"
                  sql &= "CTFNAME2 = @CTFNAME2,"
                  sql &= "CTFAMT2 = @CTFAMT2,"
                  sql &= "CTFNAME3 = @CTFNAME3,"
                  sql &= "CTFAMT3 = @CTFAMT3,"
                  sql &= "ADDCASH = @ADDCASH,"
                  sql &= "CRSAV = @CRSAV,"
                  sql &= "CRORO = @CRORO,"
                  sql &= "CRACC = @CRACC,"
                  sql &= "CRCR = @CRCR,"
                  sql &= "ADDCHECKS = @ADDCHECKS,"
                  sql &= "ADDTOTAL = @ADDTOTAL,"
                  sql &= "DIB = @DIB,"
                  sql &= "REF = @REF,"
                  sql &= "WITH = @WITH,"
                  sql &= "CHKENC = @CHKENC,"
                  sql &= "COCI = @COCI,"
                  sql &= "CHKDEP = @CHKDEP,"
                  sql &= "EMER = @EMER,"
                  sql &= "CTTNAME1 = @CTTNAME1,"
                  sql &= "CTTAMT1 = @CTTAMT1,"
                  sql &= "CTTNAME2 = @CTTNAME2,"
                  sql &= "CTTAMT2 = @CTTAMT2,"
                  sql &= "CTTNAME3 = @CTTNAME3,"
                  sql &= "CTTAMT3 = @CTTAMT3,"
                  sql &= "TOTDISB = @TOTDISB,"
                  sql &= "CBALEND = @CBALEND,"
                  sql &= "CTTCEND = @CTTCEND,"
                  sql &= "OVER = @OVER,"
                  sql &= "B_1000 = @B_1000,"
                  sql &= "B_500 = @B_500,"
                  sql &= "B_200 = @B_200,"
                  sql &= "B_100 = @B_100,"
                  sql &= "B_50 = @B_50,"
                  sql &= "B_20 = @B_20,"
                  sql &= "B_10 = @B_10,"
                  sql &= "B_5 = @B_5,"
                  sql &= "B_1 = @B_1,"
                  sql &= "B_P50 = @B_P50,"
                  sql &= "B_P25 = @B_P25,"
                  sql &= "B_P10 = @B_P10,"
                  sql &= "B_P05 = @B_P05,"
                  sql &= "B_P01 = @B_P01,"
                  sql &= "TCCOUNT = @TCCOUNT"
			            sql &= " WHERE SPTELLER_ID= " & cls.SPTELLER_ID
		            End if
					
					Dim p As DbParameter = Nothing 
					p = myCommand.CreateParameter
					p.ParameterName = "@TNAME"
					p.Value = cls.TNAME
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
					p.ParameterName = "@CASHB"
					p.Value = cls.CASHB
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@COCIB"
					p.Value = cls.COCIB
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ADDLREQ"
					p.Value = cls.ADDLREQ
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ADDMREQ"
					p.Value = cls.ADDMREQ
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CASHSAV"
					p.Value = cls.CASHSAV
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CASHOR"
					p.Value = cls.CASHOR
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ADDLTD"
					p.Value = cls.ADDLTD
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CTFNAME1"
					p.Value = cls.CTFNAME1
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CTFAMT1"
					p.Value = cls.CTFAMT1
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CTFNAME2"
					p.Value = cls.CTFNAME2
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CTFAMT2"
					p.Value = cls.CTFAMT2
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CTFNAME3"
					p.Value = cls.CTFNAME3
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CTFAMT3"
					p.Value = cls.CTFAMT3
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ADDCASH"
					p.Value = cls.ADDCASH
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CRSAV"
					p.Value = cls.CRSAV
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CRORO"
					p.Value = cls.CRORO
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CRACC"
					p.Value = cls.CRACC
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CRCR"
					p.Value = cls.CRCR
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ADDCHECKS"
					p.Value = cls.ADDCHECKS
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ADDTOTAL"
					p.Value = cls.ADDTOTAL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@DIB"
					p.Value = cls.DIB
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@REF"
					p.Value = cls.REF
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
                        p.ParameterName = "@WITH"
                        p.Value = cls.SDWITH
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CHKENC"
					p.Value = cls.CHKENC
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@COCI"
					p.Value = cls.COCI
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CHKDEP"
					p.Value = cls.CHKDEP
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@EMER"
					p.Value = cls.EMER
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CTTNAME1"
					p.Value = cls.CTTNAME1
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CTTAMT1"
					p.Value = cls.CTTAMT1
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CTTNAME2"
					p.Value = cls.CTTNAME2
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CTTAMT2"
					p.Value = cls.CTTAMT2
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CTTNAME3"
					p.Value = cls.CTTNAME3
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CTTAMT3"
					p.Value = cls.CTTAMT3
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@TOTDISB"
					p.Value = cls.TOTDISB
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CBALEND"
					p.Value = cls.CBALEND
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@CTTCEND"
					p.Value = cls.CTTCEND
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@OVER"
					p.Value = cls.OVER
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@B_1000"
					p.Value = cls.B_1000
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@B_500"
					p.Value = cls.B_500
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@B_200"
					p.Value = cls.B_200
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@B_100"
					p.Value = cls.B_100
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@B_50"
					p.Value = cls.B_50
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@B_20"
					p.Value = cls.B_20
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@B_10"
					p.Value = cls.B_10
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@B_5"
					p.Value = cls.B_5
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@B_1"
					p.Value = cls.B_1
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@B_P50"
					p.Value = cls.B_P50
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@B_P25"
					p.Value = cls.B_P25
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@B_P10"
					p.Value = cls.B_P10
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@B_P05"
					p.Value = cls.B_P05
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@B_P01"
					p.Value = cls.B_P01
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@TCCOUNT"
					p.Value = cls.TCCOUNT
  					myCommand.Parameters.Add(p)

                    myCommand.CommandType = CommandType.Text
		            myCommand.CommandText = sql
		            myCommand.ExecuteNonQuery()

		            
					If cls.SPTELLER_ID=0 Then
			            Dim IdInserito as integer = 0
			            Sql = "select @@identity"
			            myCommand.CommandText = Sql
			            Idinserito = myCommand.ExecuteScalar()
			            cls.SPTELLER_ID = Idinserito
			            Ris = Idinserito
		            else
			            Ris  =  cls.SPTELLER_ID
		            End If
		            

	            Catch ex As Exception
		            ManageError(ex)
	            End Try
            End Using
        else
	        Ris  =  cls.SPTELLER_ID
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
        'Dim Sql As String = "UPDATE Spteller SET DELETED=True "
        Dim Sql As String = "DELETE FROM Spteller"
        Sql &= " Where SPTELLER_ID = " & Id 

        myCommand.CommandText = Sql
        If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
        myCommand.ExecuteNonQuery()
    
    End Using
    Catch ex As Exception
	    ManageError(ex)
    End Try
End Sub

''' <summary>
'''Delete from DB table Spteller. Accept id of object to delete.
''' </summary>
Public Overrides Sub Delete(Id as integer) 
        DestroyPermanently (Id)
    End Sub

''' <summary>
'''Delete from DB table Spteller. Accept object to delete and optional a List to remove the object from.
''' </summary>
Public Overrides Sub Delete(byref obj as Spteller, Optional ByRef ListaObj as List (of Spteller) = Nothing)
        DestroyPermanently (obj.SPTELLER_ID)
    If Not ListaObj Is Nothing Then ListaObj.Remove(obj)
     
End Sub

''' <summary>
'''Find on DB table Spteller
''' </summary>
''' <returns>
'''Return first of Spteller
''' </returns>
Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Spteller
    Dim ris As Spteller = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1}
    Dim l As IEnumerable(Of Spteller) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function

''' <summary>
'''Find on DB table Spteller
''' </summary>
''' <returns>
'''Return first of Spteller
''' </returns>
Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Spteller
    Dim ris As Spteller = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1, .OrderBy = OrderBy}
    Dim l As IEnumerable(Of Spteller) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function
''' <summary>
'''Find on DB table Spteller
''' </summary>
''' <returns>
'''Return a list of Spteller
''' </returns>
Public Overrides Function FindAll(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Spteller)
    Dim So As New Luna.LunaSearchOption
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Spteller
''' </summary>
''' <returns>
'''Return a list of Spteller
''' </returns>
Public Overloads Function FindAll(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Spteller)
    Dim So As New Luna.LunaSearchOption With {.OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Spteller
''' </summary>
''' <returns>
'''Return a list of Spteller
''' </returns>
Public Overloads Function FindAll(byVal Top as integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Spteller)
    Dim So As New Luna.LunaSearchOption With {.Top = Top, .OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Spteller
''' </summary>
''' <returns>
'''Return a list of Spteller
''' </returns>
Public Overloads Function FindAll(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Spteller)
    Return FindReal(SearchOption, Parameter)
End Function

Private Function FindReal(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as iEnumerable(Of Spteller)
    Dim Ls As New List(Of Spteller)
    Try

    Dim sql As String = ""
    sql ="SELECT "   
		if SearchOption.Top then sql &= " TOP " & SearchOption.Top
		sql &=" * from Spteller" 
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

    If Not SearchOption.OrderBy is Nothing Then Sql &= " ORDER BY " & SearchOption.OrderBy

	
    Ls = GetData(sql, SearchOption.AddEmptyItem)

    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ls
End Function

Public Overrides Function GetAll(Optional OrderByField as string = "", Optional ByVal AddEmptyItem As Boolean = False) as iEnumerable(Of Spteller)
    Dim Ls As New List(Of Spteller)
    Try

    Dim sql As String = ""
    sql ="SELECT * from Spteller" 
    If OrderByField.Length Then
	    Sql &= " ORDER BY " & OrderByField
    End If

    Ls = GetData(Sql,AddEmptyItem)

    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ls
End Function



    Protected Function GetData(ByVal sql As String, Optional ByVal AddEmptyItem As Boolean = False) As iEnumerable(Of Spteller)
        Dim Ls As New List(Of Spteller)
        Try
            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = sql
                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                Using myReader As DbDataReader = myCommand.ExecuteReader()
                    If AddEmptyItem Then Ls.Add(New Spteller() With {.SPTELLER_ID = Nothing, .TNAME = "", .TDATE = Nothing, .CASHB = 0, .COCIB = 0, .ADDLREQ = 0, .ADDMREQ = 0, .CASHSAV = 0, .CASHOR = 0, .ADDLTD = 0, .CTFNAME1 = "", .CTFAMT1 = 0, .CTFNAME2 = "", .CTFAMT2 = 0, .CTFNAME3 = "", .CTFAMT3 = 0, .ADDCASH = 0, .CRSAV = 0, .CRORO = 0, .CRACC = 0, .CRCR = 0, .ADDCHECKS = 0, .ADDTOTAL = 0, .DIB = 0, .REF = 0, .SDWITH = 0, .CHKENC = 0, .COCI = 0, .CHKDEP = 0, .EMER = 0, .CTTNAME1 = "", .CTTAMT1 = 0, .CTTNAME2 = "", .CTTAMT2 = 0, .CTTNAME3 = "", .CTTAMT3 = 0, .TOTDISB = 0, .CBALEND = 0, .CTTCEND = 0, .OVER = 0, .B_1000 = 0, .B_500 = 0, .B_200 = 0, .B_100 = 0, .B_50 = 0, .B_20 = 0, .B_10 = 0, .B_5 = 0, .B_1 = 0, .B_P50 = 0, .B_P25 = 0, .B_P10 = 0, .B_P05 = 0, .B_P01 = 0, .TCCOUNT = 0})
                    While myReader.Read
                        Dim classe As New Spteller(CType(myReader, IDataRecord))
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
