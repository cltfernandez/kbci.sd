Imports SDS.BusinessLogic
Imports SDS.ViewModels
Public Class ChangePasswordForm

    Private PasswordService As IFormOperations
    Private MessageService As IMessagePromptBusinessLogic
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub UsernameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim chPassViewModel = New ChangePasswordViewModel
        PasswordService = New ChangePasswordService(False)
        MessageService = New ChangePasswordPrompts

        chPassViewModel.Id = SPUSER.SPUSER_ID
        chPassViewModel.UserName = SPUSER.SPUSERID
        chPassViewModel.OldPassword = txtOldPW.Text
        chPassViewModel.NewPassword = txtNewPW.Text
        chPassViewModel.ConfirmPassword = txtCNewPW.Text

        Dim result = PasswordService.SaveData(chPassViewModel)
        MessageService.GetMessageFromResult(result)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub frmSDS_Change_Password_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
End Class
