Public Class frmSDS_Main_Teller_Cash
    Dim qry1, qry2 As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub frmSDS_Main_Teller_Cash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        qry1 = "SELECT CASHREQ_ID,REQDATE DATE,REQTIME TIME,REQAMT AMOUNT FROM CASHREQ WHERE REQNAME='" & SPUSER.SPUSERID & "'"
        qry2 = "SELECT CASHTRA_ID,TRANAMETO CTF_TO, TRADATE DATE, TRATIME TIME,TRAAMT AMOUNT FROM CASHTRA WHERE TRANAME='" & SPUSER.SPUSERID & "'"
        FillLV(ListView2, GetData(qry1, "", DataGridView2), "0:143:147:335", "1:2:2:3", False)
        FillLV(ListView1, GetData(qry2, "", DataGridView1), "0:150:143:147:185", "1:1:2:2:3", False)
        fillcmb()
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If CDbl(TextBox5.Text) > 0 Then
            rExec("INSERT INTO CASHREQ(REQNAME,REQAMT,REQDATE,REQTIME) VALUES('" & _
                  SPUSER.SPUSERID & "'," & CDbl(TextBox5.Text) & ",'" & CTRL_S.SYSDATE & "','" & Format(TimeOfDay, "HH:mm:ss") & "')")
            FillLV(ListView2, GetData(qry1, "", DataGridView2), "0:143:147:335", "1:2:2:3", False)
            TextBox5.Text = "0.00"
        Else
            TextBox5.Text = "0.00"
            MsgBox("Please input correct amount.", MsgBoxStyle.Information, "Cash Request")
        End If
    End Sub

    Private Sub TextBox5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.LostFocus
        If IsNumeric(TextBox5.Text) Then TextBox5.Text = FormatNumber(TextBox5.Text, 2) Else MsgBox("Please input numeric characters", MsgBoxStyle.Information, "Invalid Amount") : TextBox5.Text = "0.00"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ListView2.SelectedIndices.Count > 0 Then
            rExec("DELETE FROM CASHREQ WHERE CASHREQ_ID=" & ListView2.Items(0).Text)
            FillLV(ListView2, GetData(qry1, "", DataGridView2), "0:143:147:335", "1:2:2:3", False)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If CDbl(TextBox1.Text) > 0 And ComboBox1.Text.Trim <> "" Then
            rExec("INSERT INTO CASHTRA(TRANAME,TRANAMETO,TRADATE,TRATIME,TRAAMT) VALUES('" & _
                  SPUSER.SPUSERID & "','" & ComboBox1.Text.Trim & "','" & CTRL_S.SYSDATE & "','" & Format(TimeOfDay, "HH:mm:ss") & "'," & CDbl(TextBox1.Text) & ")")
            FillLV(ListView1, GetData(qry2, "", DataGridView1), "0:150:143:147:185", "1:1:2:2:3", False)
            TextBox1.Text = "0.00"
        Else
            TextBox1.Text = "0.00"
            MsgBox("Please input correct amount.", MsgBoxStyle.Information, "Cash Transfer")
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If ListView1.SelectedIndices.Count > 0 Then
            rExec("DELETE FROM CASHTRA WHERE CASHTRA_ID=" & ListView1.Items(0).Text)
            FillLV(ListView1, GetData(qry2, "", DataGridView1), "0:150:143:147:185", "1:1:2:2:3", False)
        End If
    End Sub
    Sub fillcmb()
        Dim x As Integer
        Dim cm As String = "SELECT SPUSERID FROM SPUSER WHERE SPUSERPOS=1 AND SPUSERID!='" & SPUSER.SPUSERID & "'"
        GetData(cm, "", DataGridView1)
        ComboBox1.Items.Clear()
        With DataGridView1
            For x = 0 To .RowCount - 1
                ComboBox1.Items.Add(.Rows(x).Cells("SPUSERID").Value)
            Next x
        End With
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        fillcmb()
    End Sub
End Class