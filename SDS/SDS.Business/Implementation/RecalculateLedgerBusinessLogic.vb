Imports SDS.DataAccessObject
Imports SDS.Common

Public Class RecalculateLedgerBusinessLogic : Implements IRecalculateLedgerBusinessLogic

    Private _accountNumber As String
    Private _startDate As Date
    Sub New(ByVal accountNumber As String, ByVal startDate As Date)
        _accountNumber = accountNumber
        _startDate = startDate
    End Sub

    Public Function Calculate() As RecalculateLedgerResult Implements IRecalculateLedgerBusinessLogic.Calculate
        Dim result As RecalculateLedgerResult
        Using CmdSdtran As New SdtranDAO
            result = CmdSdtran.RecalculateLedger(_accountNumber, _startDate)
        End Using
        Return result
    End Function
End Class
