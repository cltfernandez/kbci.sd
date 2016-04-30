Public Class frmSDS_Change_Password

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub UsernameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim OldPass As New Crpyt(txtOldPW.Text, System.Configuration.ConfigurationManager.AppSettings("32"))
        If Microsoft.VisualBasic.Left(OldPass.Encrypt, 8) <> SPUSER.SPUSERPASS Then _
            MsgBox("Old Password is incorrect!", MsgBoxStyle.Exclamation, "Change Password") : Exit Sub

        If txtNewPW.Text <> txtCNewPW.Text Then _
            MsgBox("The confirmed password does not match the new password", MsgBoxStyle.Exclamation, "Change Password") : Exit Sub

        Dim upd As New CLTF.DB.SQLDBConnection()
        Dim NewPass As New Crpyt(txtNewPW.Text, System.Configuration.ConfigurationManager.AppSettings("32"))
        upd.OpenCommand(rCN)
        MsgBox("Changed [" & upd.Execute("UPDATE SPUSER SET " & _
                    " SPUSERPASS='" & Microsoft.VisualBasic.Left(NewPass.Encrypt, 8) & "'" & _
                    ",CHG_DATE='" & CTRL_S.SYSDATE & "'" & _
                    ",[USER]='" & SPUSER.SPUSERID & "'" & _
                    " WHERE SPUSER_ID='" & SPUSER.SPUSER_ID & "'") & "] Password. Successful!", MsgBoxStyle.Information, "Change Password")
        upd.CloseCommand()
        OldPass = Nothing
        NewPass = Nothing
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub frmSDS_Change_Password_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load        
    End Sub
End Class
