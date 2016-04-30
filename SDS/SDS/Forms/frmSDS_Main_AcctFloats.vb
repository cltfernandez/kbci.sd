Public Class frmSDS_Main_AcctFloats
    Dim TB As New CLTF.DB.SQLDBConnection
    Dim LVF As New CLTF.ListViewFiller
    Private Sub frmSDS_Main_AcctFloats_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TB.OpenCmdDataTable(rCN, "SELECT TRANDATE [DATE],TRANSEQ SEQ,ACCTNUM ACCT_NO,CHKNUM CHECK_NO,CHKCDATE,ISNULL(CHKSTAT,'') [STATUS],CHKCDAYS," & _
                                 "CHKNDAYS,ADD_DATE,[USER],CHKAMT [AMOUNT],SDCHECK_ID FROM SDCHECK")
        LVF.ColWidthSettings = "100:100:100:100:0:100:0:0:0:0:100:0"
        LVF.ColTextFormat = "1:2:1:1:1:2:1:1:1:1:3:1"
        TB.GetGrid(DataGridView3, "STATUS<>'CLE'")

        LVF.FillListView(ListView2, DataGridView3, False)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub ListView2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView2.SelectedIndexChanged
        Try
            If ListView2.SelectedIndices.Count > 0 Then
                Label12.Text = Ckbacctno(ListView2.Items(ListView2.SelectedIndices(0)).SubItems(2).Text)
                TextBox2.Text = Ckbacctno(ListView2.Items(ListView2.SelectedIndices(0)).SubItems(3).Text)
                Label14.Text = ListView2.Items(ListView2.SelectedIndices(0)).SubItems(0).Text
                Label13.Text = ListView2.Items(ListView2.SelectedIndices(0)).SubItems(1).Text
                Label11.Text = ListView2.Items(ListView2.SelectedIndices(0)).SubItems(4).Text
                Label10.Text = ListView2.Items(ListView2.SelectedIndices(0)).SubItems(6).Text
                Label16.Text = ListView2.Items(ListView2.SelectedIndices(0)).SubItems(5).Text
                Label20.Text = ListView2.Items(ListView2.SelectedIndices(0)).SubItems(7).Text
                Label21.Text = ListView2.Items(ListView2.SelectedIndices(0)).SubItems(8).Text
                Label22.Text = ListView2.Items(ListView2.SelectedIndices(0)).SubItems(9).Text
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Trim(TextBox2.Text) <> "" Then
            TB.GetGrid(DataGridView3, "CHECK_NO LIKE '%" & TextBox2.Text & "%' AND STATUS<>'CLE'")
        Else
            CheckBox1.Checked = False
        End If
        LVF.FillListView(ListView2, DataGridView3, False)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TB.GetGrid(DataGridView3, "")
        Else
            TB.GetGrid(DataGridView3, "STATUS<>'CLE'")
        End If
        LVF.FillListView(ListView2, DataGridView3, False)
    End Sub

    Private Sub TextBox2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyUp
        Me.AcceptButton = Button7
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim upd As New CLTF.DB.SQLDBConnection
        Dim MSG As String
        upd.OpenCommand(rCN)

        If ListView2.SelectedIndices.Count > 0 Then

            MSG = MsgBox("Do you want to clear this check?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "RELEASE FLOATS")
            If MSG = vbYes Then
                upd.Execute("UPDATE SDCHECK SET CHKSTAT='CLE',CHKCDATE='" & CTRL_S.SYSDATE & _
                            "',CHKNDAYS=0 WHERE SDCHECK_ID=" & ListView2.Items(ListView2.SelectedIndices(0)).SubItems(11).Text)
                upd.Execute("UPDATE SDMASTER SET ACCTABAL=XX.ACCTABAL,ACCTFLOATS=XX.ACCTFLOATS " & _
                            "FROM (SELECT (ACCTFLOATS-" & CDbl(ListView2.Items(ListView2.SelectedIndices(0)).SubItems(10).Text) & _
                            ") ACCTFLOATS,(ACCTOBAL-(ACCTFLOATS-" & CDbl(ListView2.Items(ListView2.SelectedIndices(0)).SubItems(10).Text) & _
                            ")) ACCTABAL FROM SDMASTER WHERE ACCTNO='" & ListView2.Items(ListView2.SelectedIndices(0)).SubItems(2).Text & "') XX " & _
                            "WHERE ACCTNO='" & ListView2.Items(ListView2.SelectedIndices(0)).SubItems(2).Text & "'")
                TB.Requery()
                TB.GetGrid(DataGridView3, "STATUS<>'CLE'")
                LVF.FillListView(ListView2, DataGridView3, False)
                MsgBox("Updated successfully!", MsgBoxStyle.Information, "RELEASE FLOATS")

            End If
        End If
    End Sub
End Class