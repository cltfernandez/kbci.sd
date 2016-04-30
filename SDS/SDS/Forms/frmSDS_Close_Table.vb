Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class frmSDS_Close_Table
    Private Sub frmSDS_Close_Table_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        FillLV(ListView2, GetData("SELECT CHKLIST.CHKLIST_ID, CHKLIST.CLACT AS DONE, CHKLIST.CLTYP AS FREQ, CHKLIST.CLCOD AS TYPE, CHKLIST.CLDES AS [DESC] FROM CHKLIST WHERE CHKLIST.CLTAG='True' AND CHKLIST.CLAPP='True' AND CHKLIST.CLACT='False'", "", DataGridView1), "0:42:46:95:436", "1:1:1:1:1", False)
        If DataGridView1.RowCount < 1 Then
            SW = True
            Me.Dispose()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        SW = False
        Me.Dispose()
    End Sub

    Private Sub ListView2_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView2.DoubleClick
        If ListView2.SelectedItems.Count > 0 Then
            If ListView2.SelectedItems(0).SubItems(1).Text.ToLower = "true" Then ListView2.SelectedItems(0).SubItems(1).Text = "False" Else ListView2.SelectedItems(0).SubItems(1).Text = "True"
        End If
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        Dim lvrow As ListViewItem
        Dim dt As New DataTable

        dt.Columns.Add("CHKLIST_ID")
        dt.Columns.Add("CLACT")
        For Each lvrow In ListView2.Items
            Dim dr As DataRow = dt.NewRow()
            dr("CHKLIST_ID") = lvrow.SubItems(0).Text
            dr("CLACT") = lvrow.SubItems(1).Text
            dt.Rows.Add(dr)
        Next

        Dim Conn = New SqlConnection(rCN)
        Conn.Open()
        Dim scmd As New SqlCommand("CREATE TABLE #TEMPCHKLIST(CHKLIST_ID  INT, CLACT BIT)", Conn)
        scmd.ExecuteNonQuery()

        Using s As New SqlBulkCopy(Conn)
            s.DestinationTableName = "#TEMPCHKLIST"
            s.WriteToServer(dt)
            s.Close()
        End Using

        scmd = New SqlCommand("usp_UpdateChklist", Conn)
        scmd.CommandType = CommandType.StoredProcedure
        scmd.ExecuteNonQuery()
        MsgBox("Updated Successfully", MsgBoxStyle.Information, "CHECK LIST UPDATE")
        Conn.Close()
        Me.Dispose()
    End Sub

End Class
