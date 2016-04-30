Public Class frmSDS_Main_Teller

    Private Sub frmSDS_Main_Teller_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand("SELECT ISNULL(CASHB,0) CASHB,ISNULL(COCIB,0) COCIB,ISNULL(ADDLREQ,0) ADDLREQ FROM SPTELLER WHERE TNAME='" & SPUSER.SPUSERID & "'", cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        Try

            sqlCMD.CommandType = CommandType.Text
            cnn.Open()
            ad.Fill(DT)
            cnn.Close()
            Label9.Text = "USER : " & SPUSER.SPUSERID
            rExec("UPDATE SPTELLER SET TDATE='" & CTRL_S.SYSDATE & "' WHERE TNAME='" & SPUSER.SPUSERID & "'")
            If DT.Rows.Count > 0 Then
                TextBox5.Text = FormatNumber(CDbl(DT.Rows(0).Item("CASHB")))
                TextBox1.Text = FormatNumber(CDbl(DT.Rows(0).Item("COCIB")))
                TextBox2.Text = FormatNumber(CDbl(DT.Rows(0).Item("ADDLREQ")))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim msg As String
        msg = MsgBox("Would you like to continue with this initial balance?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Tellering: Start-of-day")
        If msg = vbYes Then
            rExec("UPDATE SPTELLER SET CASHB=" & CDbl(TextBox5.Text) & ",COCIB=" & CDbl(TextBox1.Text) & "," & _
                  "ADDLREQ=" & CDbl(TextBox2.Text) & " WHERE TNAME='" & SPUSER.SPUSERID & "'")
            rExec("UPDATE SPUSER SET SPLOGNO=1 WHERE SPUSERID='" & SPUSER.SPUSERID & "'")
            Me.Dispose()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose() : SW = False
    End Sub

    Private Sub TextBox5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.LostFocus
        If IsNumeric(TextBox5.Text) Then TextBox5.Text = FormatNumber(TextBox5.Text, 2) Else MsgBox("Please input numeric characters", MsgBoxStyle.Information, "Invalid Amount") : TextBox5.Text = "0.00"
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        If IsNumeric(TextBox1.Text) Then TextBox1.Text = FormatNumber(TextBox1.Text, 2) Else MsgBox("Please input numeric characters", MsgBoxStyle.Information, "Invalid Amount") : TextBox1.Text = "0.00"
    End Sub

    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        If IsNumeric(TextBox2.Text) Then TextBox2.Text = FormatNumber(TextBox2.Text, 2) Else MsgBox("Please input numeric characters", MsgBoxStyle.Information, "Invalid Amount") : TextBox2.Text = "0.00"
    End Sub
End Class