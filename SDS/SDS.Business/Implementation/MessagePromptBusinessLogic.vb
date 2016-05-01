Imports SDS.Common
Imports SDS.Common.Utilities
Public Class MessagePromptBusinessLogic : Implements IMessagePromptBusinessLogic

    Public Sub GetMessageFromResult(ByVal result As RecalculateLedgerResult) Implements IMessagePromptBusinessLogic.GetMessageFromResult
        Select Case result
            Case RecalculateLedgerResult.Failed
                MsgBox(GetGlobalResourceString("RecalculationFailed"), MsgBoxStyle.Critical, GetGlobalResourceString("RecalculateLedger"))
            Case RecalculateLedgerResult.Successful
                MsgBox(GetGlobalResourceString("RecalculationSuccessful"), MsgBoxStyle.Information, GetGlobalResourceString("RecalculateLedger"))
        End Select
    End Sub
End Class
