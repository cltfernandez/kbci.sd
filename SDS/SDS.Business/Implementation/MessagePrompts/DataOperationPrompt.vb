Imports SDS.Common
Imports SDS.Common.Utilities
Public Class DataOperationPrompt : Implements IMessagePromptBusinessLogic

    Public Sub GetMessageFromResult(ByVal result As Integer) Implements IMessagePromptBusinessLogic.GetMessageFromResult
        Select Case result
            Case RecordUpdateResult.AddSuccessful
                MsgBox(GetGlobalResourceString("AddSuccessful"), MsgBoxStyle.Information, GetGlobalResourceString("SavingsDepositSystem"))
            Case RecordUpdateResult.UpdateSuccessful
                MsgBox(GetGlobalResourceString("UpdateSuccessful"), MsgBoxStyle.Information, GetGlobalResourceString("SavingsDepositSystem"))
            Case RecordUpdateResult.Unsuccessful
                MsgBox(GetGlobalResourceString("Unsuccessful"), MsgBoxStyle.Critical, GetGlobalResourceString("SavingsDepositSystem"))

        End Select
    End Sub

End Class
