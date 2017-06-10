Imports SDS.Common
Imports SDS.Common.Utilities

Public Class ChangePasswordPrompts : Implements IMessagePromptBusinessLogic

    Public Sub GetMessageFromResult(ByVal result As Integer) Implements IMessagePromptBusinessLogic.GetMessageFromResult
        Select Case result
            Case ChangePasswordResult.ConfirmPasswordMismatch
                MsgBox("The confirmed password does not match the new password", MsgBoxStyle.Exclamation, "Change Password")
            Case ChangePasswordResult.IncorrectPassword
                MsgBox("Old Password is incorrect!", MsgBoxStyle.Exclamation, "Change Password")
            Case ChangePasswordResult.Successful
                MsgBox(GetGlobalResourceString("ChangePasswordSuccess"), MsgBoxStyle.Information, GetGlobalResourceString("SavingsDepositSystem"))
            Case ChangePasswordResult.Unsuccessful
                MsgBox(GetGlobalResourceString("ChangePasswordFailed"), MsgBoxStyle.Information, GetGlobalResourceString("SavingsDepositSystem"))
        End Select
    End Sub
End Class
