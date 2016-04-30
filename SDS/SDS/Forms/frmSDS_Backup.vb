Imports System.Windows.Forms
Imports System.IO.FileInfo

Public Class frmSDS_Backup
    Private bck As New CLTF.DB.SQLDBConnection()

    Private Sub bgwBackup_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwBackup.RunWorkerCompleted
        bck.CloseCommand()
        MsgBox("Back up, Successful!", MsgBoxStyle.Information, "Database Backup")
        ProgressBar1.Hide()
        Button2.Enabled = True
        Button1.Enabled = True
    End Sub

    Private Sub bgwBackup_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwBackup.DoWork

        Dim dt As New DateTime
        Dim fInfo As String

        fInfo = System.Configuration.ConfigurationManager.AppSettings("BK") & GetConfig("DB").ToUpper() & "." & _
            CTRL_S.SYSDATE.Year & CTRL_S.SYSDATE.Month & CTRL_S.SYSDATE.Day

        bck.OpenCommand(rCN)
        bck.Execute("BACKUP DATABASE " & GetConfig("DB").ToUpper() & " TO DISK ='" & _
                    fInfo & ".bak'")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Button2.Enabled = False
        Button1.Enabled = False
        ProgressBar1.Show()
        bgwBackup.RunWorkerAsync()
    End Sub

    Private Sub frmSDS_Backup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
