#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 20/06/2015 
#End Region


Imports System.Data.Common
Imports System.Data.SqlClient

''' <summary>
'''DAO Class for table Divref
''' </summary>
''' <remarks>
'''Write your DATABASE custom method here
''' </remarks>
Public Class DivrefDAO
    Inherits _DivrefDAO

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal Connection As DbConnection)
        MyBase.New(Connection)
    End Sub

    Public Sub ImportDividendsAndRefund(ByVal ImportData As DataTable)

        Using myCommand As DbCommand = _Cn.CreateCommand
            myCommand.CommandText = "TRUNCATE TABLE DIVREF"
            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
            myCommand.ExecuteNonQuery()
        End Using
        Using bcopy As New SqlBulkCopy(_Cn.ConnectionString)
            bcopy.DestinationTableName = "DIVREF"
            bcopy.WriteToServer(ImportData)
        End Using
    End Sub

End Class