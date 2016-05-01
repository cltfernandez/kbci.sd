Imports SDS.DataAccessObject
Imports SDS.Common

Public Class RecalculateLedgerBusinessLogic : Implements IRecalculateLedgerBusinessLogic

    Public Function Calculate(ByVal AccountNo As String, ByVal StartDate As Date) As RecalculateLedgerResult Implements IRecalculateLedgerBusinessLogic.Calculate
        Dim result As RecalculateLedgerResult
        Using CmdSdtran As New SdtranDAO
            result = CmdSdtran.RecalculateLedger(AccountNo, StartDate)
        End Using
        Return result
    End Function
End Class
