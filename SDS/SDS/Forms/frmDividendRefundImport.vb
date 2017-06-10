Imports SDS.Common.Utilities
Imports SDS.BusinessLogic
Imports System.IO
Public Class frmDividendRefundImport
    Private DBF2 As String
    Private ImportService As IImportExportService
    Private Sub bgwDVIREF_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwDVIREF.DoWork

        If CheckBox2.Checked And TextBox2.Text <> String.Empty And File.Exists(TextBox2.Text) Then
            ImportService = New DividendRefundImportService(DBF2, Path.GetDirectoryName(TextBox2.Text))
            ImportService.ImportData()
        End If
    End Sub

    Private Sub bgwDVIREF_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwDVIREF.RunWorkerCompleted
        Button6.Enabled = True
        MsgBox(GetGlobalResourceString("DivrefImportSuccess"), MsgBoxStyle.Information, GetGlobalResourceString("DividendRefundImport"))
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Button6.Enabled = False
        bgwDVIREF.RunWorkerAsync()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim lcnstr As String
        If openFile("Dividend/Refund File (DIVREF.DBF) |*.DBF", TextBox2) Then
            DBF2 = Path.GetFileName(TextBox2.Text).Replace(Path.GetExtension(TextBox2.Text), "")
            lcnstr = "Provider=VFPOLEDB.1;Data Source=" & Path.GetDirectoryName(TextBox2.Text)

            If CInt(GetLStr("SELECT COUNT(KBCI_NO)AS CNT FROM " & DBF2 & "", "CNT", 0, lcnstr)) < 1 Then
                MsgBox("No items to post for this batch.", MsgBoxStyle.Information, "Dividend/Refund Processing")
                CheckBox2.Checked = False
            End If
        End If
    End Sub
    Function openFile(ByVal filter As String, ByRef tbox As TextBox) As Boolean

        With OpenFileDialog1
            .InitialDirectory = App_Path()
            .Filter = filter
            If .ShowDialog() = DialogResult.OK Then
                tbox.Text = .FileName.ToUpper
                Return True
            Else
                Return False
            End If
        End With
    End Function
End Class