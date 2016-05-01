#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 20/06/2015 
#End Region


Imports System.Data.Common
Imports SDS.Common

''' <summary>
'''DAO Class for table Sdtran
''' </summary>
''' <remarks>
'''Write your DATABASE custom method here
''' </remarks>
Public Class SdtranDAO
	Inherits _SdtranDAO

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal Connection As DbConnection)
        MyBase.New(Connection)
    End Sub

    Public Function RecalculateLedger(ByVal AccountNo As String, ByVal StartDate As Date) As RecalculateLedgerResult
        Dim StoredProcedureName As String = "s_RecalculateLedger"

        Try

            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = StoredProcedureName
                myCommand.CommandType = CommandType.StoredProcedure


                Dim paramAccountNo = myCommand.CreateParameter
                With paramAccountNo
                    .ParameterName = "@AcctNo"
                    .Value = AccountNo
                End With

                Dim paramStartDate = myCommand.CreateParameter
                With paramStartDate
                    .ParameterName = "@StartDate"
                    .Value = StartDate
                End With

                Dim paramResult = myCommand.CreateParameter
                With paramResult
                    .ParameterName = "@Result"
                    .Value = RecalculateLedgerResult.Successful
                    .Direction = ParameterDirection.Output
                End With

                myCommand.Parameters.Add(paramAccountNo)
                myCommand.Parameters.Add(paramStartDate)
                myCommand.Parameters.Add(paramResult)

                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                myCommand.ExecuteNonQuery()

                Return myCommand.Parameters("@Result").Value()
            End Using

        Catch ex As Exception
            ManageError(ex)
        End Try
    End Function

End Class