Public Class frmSDS_Memlist_inq
    Dim frmFDS_Main_PrntFDL_Srch As frmFDS_Main_PrntFDL_Srch
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        SDDB = False
        frmFDS_Main_PrntFDL_Srch = New frmFDS_Main_PrntFDL_Srch
        frmFDS_Main_PrntFDL_Srch.ShowDialog()
        If SW = True Then
            Label15.Text = STRToKBCINO(SEL_KBCI_NO)
            TextBox1.Text = SEL_FNAME
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Dispose()
    End Sub

    Private Sub frmSDS_Memlist_inq_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label18.Text = FormatNumber(MINBAL)
    End Sub

End Class