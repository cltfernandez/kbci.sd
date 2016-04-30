Public Class frmSDS_Main_Log
    Private closeform As Boolean
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            SW = False
            If TextBox6.Text.Trim <> "" And TextBox1.Text.Trim <> "" Then
                SPUSER.getData(" WHERE SPUSERID='" & TextBox6.Text.Trim & "'")                
                If Business.IsAuth(TextBox6.Text, TextBox1.Text, SPUSER) Then
                    MsgBox("Successfully Logged In!", MsgBoxStyle.Information, "Welcome")
                    SPTAG = SPUSER.SPTAG.ToCharArray
                    SW = True
                    closeform = True
                    Me.Close()
                Else
                    MsgBox("Incorrect Credentials", MsgBoxStyle.Information, "Log In")
                End If
            Else
                MsgBox("Incorrect Credentials", MsgBoxStyle.Information, "Log In")
            End If
        Catch ex As Exception
            If Err.Number = 9 Then
                MsgBox("Incorrect Credentials", MsgBoxStyle.Information, "Log In")
            Else
                MsgBox(ex.Message)
            End If
        End Try
    End Sub

    Private Sub TextBox6_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.Enter
        TextBox6.SelectAll()
    End Sub

    Private Sub TextBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Enter
        TextBox1.SelectAll()
    End Sub

    Private Sub frmSDS_Main_Log_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Not closeform Then e.Cancel = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim msg As String
        msg = MsgBox("Do you want to exit the application?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Exit")
        If msg = vbYes Then
            closeform = True
        End If
    End Sub
End Class