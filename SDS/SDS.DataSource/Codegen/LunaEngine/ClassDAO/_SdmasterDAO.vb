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
'''This class manage persistency on db of Sdmaster object
''' </summary>
''' <remarks>
'''
''' </remarks>

Public MustInherit Class _SdmasterDAO
Inherits LUNA.LunaBaseClassDAO(Of Sdmaster)

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
'''Read from DB table Sdmaster
''' </summary>
''' <returns>
'''Return a Sdmaster object
''' </returns>
Public Overrides Function Read(Id as integer) as Sdmaster
    Dim cls as new Sdmaster

    Try
        Using myCommand As DbCommand = _cn.CreateCommand
        
            myCommand.CommandText = "SELECT * FROM Sdmaster where SDMASTER_ID = " & Id
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
'''Save on DB table Sdmaster
''' </summary>
''' <returns>
'''Return ID insert in DB
''' </returns>
Public Overrides Function Save(byRef cls as Sdmaster) as Integer

    Dim Ris as integer=0 'in Ris return Insert Id

    If cls.IsValid Then
        If cls.IsChanged Then
            Using myCommand As DbCommand = _Cn.CreateCommand()
	            Try
		            Dim sql As String = String.Empty
		            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
		            If cls.SDMASTER_ID = 0 Then
                        sql = "INSERT INTO Sdmaster ("
                            sql &= " ACCTNO,"
                            sql &= " KBCI_NO,"
                            sql &= " CBEMPNO,"
                            sql &= " ACCTNAME,"
                            sql &= " ACCTADDR1,"
                            sql &= " ACCTADDR2,"
                            sql &= " ACCTSNAME,"
                            sql &= " ACCTPHONE1,"
                            sql &= " ACCTPHONE2,"
                            sql &= " ACCTDTYPE,"
                            sql &= " ACCTCCODE,"
                            sql &= " ACCTICODE,"
                            sql &= " ACCTATX,"
                            sql &= " ACCTOTH1,"
                            sql &= " ACCTOTH2,"
                            sql &= " ACCTMAINT,"
                            sql &= " ACCTIDEP,"
                            sql &= " ACCTPBAL,"
                            sql &= " ACCTLBAL,"
                            sql &= " ACCTOBAL,"
                            sql &= " ACCTABAL,"
                            sql &= " ACCTFLOATS,"
                            sql &= " ACCTTEX,"
                            sql &= " ACCTACLO,"
                            sql &= " ACCTWMIN,"
                            sql &= " ACCTWSC,"
                            sql &= " ACCTWINT,"
                            sql &= " ACCTSTAT,"
                            sql &= " PLINE,"
                            sql &= " LLINE,"
                            sql &= " UNPOSTED,"
                            sql &= " HOLDOUT,"
                            sql &= " LSEQ,"
                            sql &= " LTRANDATE,"
                            sql &= " ADD_DATE,"
                            sql &= " CHG_DATE,"
                            sql &= " UPD_USER,"
                            sql &= " REC_STAT"
                      sql &= ") VALUES ("
                      sql &= " @ACCTNO,"
                      sql &= " @KBCI_NO,"
                      sql &= " @CBEMPNO,"
                      sql &= " @ACCTNAME,"
                      sql &= " @ACCTADDR1,"
                      sql &= " @ACCTADDR2,"
                      sql &= " @ACCTSNAME,"
                      sql &= " @ACCTPHONE1,"
                      sql &= " @ACCTPHONE2,"
                      sql &= " @ACCTDTYPE,"
                      sql &= " @ACCTCCODE,"
                      sql &= " @ACCTICODE,"
                      sql &= " @ACCTATX,"
                      sql &= " @ACCTOTH1,"
                      sql &= " @ACCTOTH2,"
                      sql &= " @ACCTMAINT,"
                      sql &= " @ACCTIDEP,"
                      sql &= " @ACCTPBAL,"
                      sql &= " @ACCTLBAL,"
                      sql &= " @ACCTOBAL,"
                      sql &= " @ACCTABAL,"
                      sql &= " @ACCTFLOATS,"
                      sql &= " @ACCTTEX,"
                      sql &= " @ACCTACLO,"
                      sql &= " @ACCTWMIN,"
                      sql &= " @ACCTWSC,"
                      sql &= " @ACCTWINT,"
                      sql &= " @ACCTSTAT,"
                      sql &= " @PLINE,"
                      sql &= " @LLINE,"
                      sql &= " @UNPOSTED,"
                      sql &= " @HOLDOUT,"
                      sql &= " @LSEQ,"
                      sql &= " @LTRANDATE,"
                      sql &= " @ADD_DATE,"
                      sql &= " @CHG_DATE,"
                      sql &= " @UPD_USER,"
                      sql &= " @REC_STAT"
                      sql &= ")"
		            Else
			            sql = "UPDATE Sdmaster SET "
                  sql &= "ACCTNO = @ACCTNO,"
                  sql &= "KBCI_NO = @KBCI_NO,"
                  sql &= "CBEMPNO = @CBEMPNO,"
                  sql &= "ACCTNAME = @ACCTNAME,"
                  sql &= "ACCTADDR1 = @ACCTADDR1,"
                  sql &= "ACCTADDR2 = @ACCTADDR2,"
                  sql &= "ACCTSNAME = @ACCTSNAME,"
                  sql &= "ACCTPHONE1 = @ACCTPHONE1,"
                  sql &= "ACCTPHONE2 = @ACCTPHONE2,"
                  sql &= "ACCTDTYPE = @ACCTDTYPE,"
                  sql &= "ACCTCCODE = @ACCTCCODE,"
                  sql &= "ACCTICODE = @ACCTICODE,"
                  sql &= "ACCTATX = @ACCTATX,"
                  sql &= "ACCTOTH1 = @ACCTOTH1,"
                  sql &= "ACCTOTH2 = @ACCTOTH2,"
                  sql &= "ACCTMAINT = @ACCTMAINT,"
                  sql &= "ACCTIDEP = @ACCTIDEP,"
                  sql &= "ACCTPBAL = @ACCTPBAL,"
                  sql &= "ACCTLBAL = @ACCTLBAL,"
                  sql &= "ACCTOBAL = @ACCTOBAL,"
                  sql &= "ACCTABAL = @ACCTABAL,"
                  sql &= "ACCTFLOATS = @ACCTFLOATS,"
                  sql &= "ACCTTEX = @ACCTTEX,"
                  sql &= "ACCTACLO = @ACCTACLO,"
                  sql &= "ACCTWMIN = @ACCTWMIN,"
                  sql &= "ACCTWSC = @ACCTWSC,"
                  sql &= "ACCTWINT = @ACCTWINT,"
                  sql &= "ACCTSTAT = @ACCTSTAT,"
                  sql &= "PLINE = @PLINE,"
                  sql &= "LLINE = @LLINE,"
                  sql &= "UNPOSTED = @UNPOSTED,"
                  sql &= "HOLDOUT = @HOLDOUT,"
                  sql &= "LSEQ = @LSEQ,"
                  sql &= "LTRANDATE = @LTRANDATE,"
                  sql &= "ADD_DATE = @ADD_DATE,"
                  sql &= "CHG_DATE = @CHG_DATE,"
                  sql &= "UPD_USER = @UPD_USER,"
                  sql &= "REC_STAT = @REC_STAT"
			            sql &= " WHERE SDMASTER_ID= " & cls.SDMASTER_ID
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
					p.ParameterName = "@CBEMPNO"
					p.Value = cls.CBEMPNO
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTNAME"
					p.Value = cls.ACCTNAME
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTADDR1"
					p.Value = cls.ACCTADDR1
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTADDR2"
					p.Value = cls.ACCTADDR2
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTSNAME"
					p.Value = cls.ACCTSNAME
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTPHONE1"
					p.Value = cls.ACCTPHONE1
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTPHONE2"
					p.Value = cls.ACCTPHONE2
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTDTYPE"
					p.Value = cls.ACCTDTYPE
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTCCODE"
					p.Value = cls.ACCTCCODE
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTICODE"
					p.Value = cls.ACCTICODE
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTATX"
					p.Value = cls.ACCTATX
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTOTH1"
					p.Value = cls.ACCTOTH1
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTOTH2"
					p.Value = cls.ACCTOTH2
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTMAINT"
					p.Value = cls.ACCTMAINT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTIDEP"
					p.Value = cls.ACCTIDEP
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTPBAL"
					p.Value = cls.ACCTPBAL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTLBAL"
					p.Value = cls.ACCTLBAL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTOBAL"
					p.Value = cls.ACCTOBAL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTABAL"
					p.Value = cls.ACCTABAL
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTFLOATS"
					p.Value = cls.ACCTFLOATS
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTTEX"
					p.Value = cls.ACCTTEX
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTACLO"
					p.Value = cls.ACCTACLO
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTWMIN"
					p.Value = cls.ACCTWMIN
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTWSC"
					p.Value = cls.ACCTWSC
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTWINT"
					p.Value = cls.ACCTWINT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@ACCTSTAT"
					p.Value = cls.ACCTSTAT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@PLINE"
					p.Value = cls.PLINE
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@LLINE"
					p.Value = cls.LLINE
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@UNPOSTED"
					p.Value = cls.UNPOSTED
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@HOLDOUT"
					p.Value = cls.HOLDOUT
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@LSEQ"
					p.Value = cls.LSEQ
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@LTRANDATE"
					p.DbType = DbType.DateTime
					if cls.LTRANDATE <> Date.MinValue then
			            p.Value = cls.LTRANDATE
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
					p.ParameterName = "@UPD_USER"
					p.Value = cls.UPD_USER
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@REC_STAT"
					p.Value = cls.REC_STAT
  					myCommand.Parameters.Add(p)

                    myCommand.CommandType = CommandType.Text
		            myCommand.CommandText = sql
		            myCommand.ExecuteNonQuery()

		            
					If cls.SDMASTER_ID=0 Then
			            Dim IdInserito as integer = 0
			            Sql = "select @@identity"
			            myCommand.CommandText = Sql
			            Idinserito = myCommand.ExecuteScalar()
			            cls.SDMASTER_ID = Idinserito
			            Ris = Idinserito
		            else
			            Ris  =  cls.SDMASTER_ID
		            End If
		            

	            Catch ex As Exception
		            ManageError(ex)
	            End Try
            End Using
        else
	        Ris  =  cls.SDMASTER_ID
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
        'Dim Sql As String = "UPDATE Sdmaster SET DELETED=True "
        Dim Sql As String = "DELETE FROM Sdmaster"
        Sql &= " Where SDMASTER_ID = " & Id 

        myCommand.CommandText = Sql
        If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
        myCommand.ExecuteNonQuery()
    
    End Using
    Catch ex As Exception
	    ManageError(ex)
    End Try
End Sub

''' <summary>
'''Delete from DB table Sdmaster. Accept id of object to delete.
''' </summary>
Public Overrides Sub Delete(Id as integer) 
        DestroyPermanently (Id)
    End Sub

''' <summary>
'''Delete from DB table Sdmaster. Accept object to delete and optional a List to remove the object from.
''' </summary>
Public Overrides Sub Delete(byref obj as Sdmaster, Optional ByRef ListaObj as List (of Sdmaster) = Nothing)
        DestroyPermanently (obj.SDMASTER_ID)
    If Not ListaObj Is Nothing Then ListaObj.Remove(obj)
     
End Sub

''' <summary>
'''Find on DB table Sdmaster
''' </summary>
''' <returns>
'''Return first of Sdmaster
''' </returns>
Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Sdmaster
    Dim ris As Sdmaster = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1}
    Dim l As IEnumerable(Of Sdmaster) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function

''' <summary>
'''Find on DB table Sdmaster
''' </summary>
''' <returns>
'''Return first of Sdmaster
''' </returns>
Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Sdmaster
    Dim ris As Sdmaster = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1, .OrderBy = OrderBy}
    Dim l As IEnumerable(Of Sdmaster) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function
''' <summary>
'''Find on DB table Sdmaster
''' </summary>
''' <returns>
'''Return a list of Sdmaster
''' </returns>
Public Overrides Function FindAll(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Sdmaster)
    Dim So As New Luna.LunaSearchOption
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Sdmaster
''' </summary>
''' <returns>
'''Return a list of Sdmaster
''' </returns>
Public Overloads Function FindAll(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Sdmaster)
    Dim So As New Luna.LunaSearchOption With {.OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Sdmaster
''' </summary>
''' <returns>
'''Return a list of Sdmaster
''' </returns>
Public Overloads Function FindAll(byVal Top as integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Sdmaster)
    Dim So As New Luna.LunaSearchOption With {.Top = Top, .OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Sdmaster
''' </summary>
''' <returns>
'''Return a list of Sdmaster
''' </returns>
Public Overloads Function FindAll(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Sdmaster)
    Return FindReal(SearchOption, Parameter)
End Function

Private Function FindReal(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as iEnumerable(Of Sdmaster)
    Dim Ls As New List(Of Sdmaster)
    Try

    Dim sql As String = ""
    sql ="SELECT "   
		if SearchOption.Top then sql &= " TOP " & SearchOption.Top
		sql &=" * from Sdmaster" 
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

Public Overrides Function GetAll(Optional OrderByField as string = "", Optional ByVal AddEmptyItem As Boolean = False) as iEnumerable(Of Sdmaster)
    Dim Ls As New List(Of Sdmaster)
    Try

    Dim sql As String = ""
    sql ="SELECT * from Sdmaster" 
    If OrderByField.Length Then
	    Sql &= " ORDER BY " & OrderByField
    End If

    Ls = GetData(Sql,AddEmptyItem)

    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ls
End Function



    Protected Function GetData(ByVal sql As String, Optional ByVal AddEmptyItem As Boolean = False) As iEnumerable(Of Sdmaster)
        Dim Ls As New List(Of Sdmaster)
        Try
            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = sql
                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                Using myReader As DbDataReader = myCommand.ExecuteReader()
                    If AddEmptyItem Then Ls.Add(New Sdmaster() With {.SDMASTER_ID = Nothing, .ACCTNO = "", .KBCI_NO = "", .CBEMPNO = "", .ACCTNAME = "", .ACCTADDR1 = "", .ACCTADDR2 = "", .ACCTSNAME = "", .ACCTPHONE1 = "", .ACCTPHONE2 = "", .ACCTDTYPE = "", .ACCTCCODE = "", .ACCTICODE = "", .ACCTATX = "", .ACCTOTH1 = "", .ACCTOTH2 = "", .ACCTMAINT = 0, .ACCTIDEP = 0, .ACCTPBAL = 0, .ACCTLBAL = 0, .ACCTOBAL = 0, .ACCTABAL = 0, .ACCTFLOATS = 0, .ACCTTEX = "", .ACCTACLO = "", .ACCTWMIN = "", .ACCTWSC = "", .ACCTWINT = "", .ACCTSTAT = "", .PLINE = 0, .LLINE = 0, .UNPOSTED = 0, .HOLDOUT = 0, .LSEQ = 0, .LTRANDATE = Nothing, .ADD_DATE = Nothing, .CHG_DATE = Nothing, .UPD_USER = "", .REC_STAT = False})
                    While myReader.Read
                        Dim classe As New Sdmaster(CType(myReader, IDataRecord))
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
