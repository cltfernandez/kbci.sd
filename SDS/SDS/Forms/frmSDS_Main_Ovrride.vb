Public Class frmSDS_Main_Ovrride
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            Dim Crypt As New Crpyt(PasswordTextBox.Text, System.Configuration.ConfigurationManager.AppSettings("32"))
            Dim rsPass As String

            SW = False
            If PasswordTextBox.Text.Trim <> "" And UsernameTextBox.Text.Trim <> "" Then
                rsPass = GetRStr(CleanSTR("SELECT SPUSERPASS FROM SPUSER WHERE SPUSERID='" & UsernameTextBox.Text.Trim & "'"), "SPUSERPASS", 0)
                If Not rsPass Is Nothing Then
                    If Microsoft.VisualBasic.Left(Crypt.Encrypt, 8) = rsPass Then
                        If CInt(GetRStr(CleanSTR("SELECT SPUSERPOS FROM SPUSER WHERE SPUSERID='" & UsernameTextBox.Text.Trim & "'"), "SPUSERPOS", 0)) = 3 Then
                            MsgBox("Transaction Authorized", MsgBoxStyle.Information, "Override Successful")
                            OVRUSER = UsernameTextBox.Text.ToUpper
                            SW = True
                        Else
                            MsgBox("User not authorized to override", MsgBoxStyle.Information, "Override Failed")
                            SW = False
                        End If
                        Me.Close()
                    Else
                        MsgBox("Incorrect Credentials", MsgBoxStyle.Information, "Log In")
                    End If
                End If
            End If
        Catch ex As Exception
            If Err.Number = 9 Then
                MsgBox("Incorrect Credentials", MsgBoxStyle.Information, "Log In")
            Else
                MsgBox(ex.Message)
            End If
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SW = False
        Me.Dispose()
    End Sub
End Class
