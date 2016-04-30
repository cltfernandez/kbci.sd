Public Class frmSDS_Main_Ctrl

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim UP As New CLTF.DB.SQLDBConnection
        If Button6.Text = "E&dit" Then
            Button6.Text = "Sa&ve"
            EorD(True, GroupBox1)
        Else
            UP.OpenCommand(rCN)
            UP.Execute("UPDATE CTRL_S SET CLR_ONUS=" & NumericUpDown1.Value & ",CLR_LOCAL=" & NumericUpDown2.Value & ",CLR_REG=" & NumericUpDown3.Value & ",SDRATE=" & NumericUpDown4.Value & ",DBDORMANT=" & NumericUpDown5.Value & ",ACCTBR='" & TextBox2.Text & "',MINBAL=" & CDbl(TextBox5.Text) & ",DormancyCharge=" & CDbl(txtDormancyFee.Text))
            UP.CloseCommand()
            Button6.Text = "E&dit"
            EorD(False, GroupBox1)
            CTRL_S.getData()
            MsgBox("Updated Successfully!", MsgBoxStyle.Information, "Control File")
        End If
    End Sub

    Private Sub frmSDS_Main_Ctrl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CTRL_S.getData()
        Dim X As New CLTF.DB.SQLDBConnection
        With X
            .OpenCmdDataTable(rCN, "SELECT CLR_ONUS,CLR_LOCAL,CLR_REG,SDRATE,DBDORMANT,ACCTBR,ACCTSEQ,DormancyCharge FROM CTRL_S")
            NumericUpDown1.Value = CInt(.GetValue("CLR_ONUS"))
            NumericUpDown2.Value = CInt(.GetValue("CLR_LOCAL"))
            NumericUpDown3.Value = CInt(.GetValue("CLR_REG"))
            TextBox5.Text = FormatNumber(CTRL_S.MINBAL)
            NumericUpDown4.Value = CDbl(.GetValue("SDRATE"))
            NumericUpDown5.Value = CInt(.GetValue("DBDORMANT"))
            TextBox2.Text = CInt(.GetValue("ACCTBR"))
            TextBox1.Text = CInt(.GetValue("ACCTSEQ"))
            txtDormancyFee.Text = FormatNumber(CTRL_S.DormancyCharge)
            CheckBox2.Checked = CTRL_S.EOMF
            CheckBox1.Checked = CTRL_S.EOQF
            CheckBox4.Checked = CTRL_S.EOYF
            CheckBox3.Checked = CTRL_S.OTCF
            .CloseDataTable()
        End With

    End Sub
    Sub EorD(ByVal sw As Boolean, ByRef grp As GroupBox)
        Dim CTRLS As Control
        For Each CTRLS In grp.Controls
            If Not TypeOf CTRLS Is CheckBox Then CTRLS.Enabled = sw
        Next
    End Sub

    Private Sub TextBox5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.LostFocus
        If IsNumeric(TextBox5.Text) Then TextBox5.Text = FormatNumber(TextBox5.Text, 2) Else MsgBox("Please input numeric characters", MsgBoxStyle.Information, "Invalid Amount") : TextBox5.Text = "0.00"
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class