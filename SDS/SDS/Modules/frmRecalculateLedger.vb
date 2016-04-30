Imports System.Windows.Forms

Public Class frmRecalculateLedger
    Dim batch_Ran As Boolean
    Private Sub frmRecalculateLedger_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If Not batch_Ran Then bgwOTCProcess.RunWorkerAsync()
    End Sub
    
    
    Private Sub frmRecalculateLedger_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        batch_Ran = False
    End Sub

    Private Sub bgwOTCProcess_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwOTCProcess.DoWork
        If Not batch_Ran Then
            Dim msg As String
            Dim X As Integer
            batch_Ran = True
            CTRL_S.getData()
            If CTRL_S.OTCF Then MsgBox("ERROR: Already closed !!!") : Exit Sub
            msg = MsgBox("[[ IMPORTANT ]]" & vbCrLf & "      This process will disable all over-the-counter transactions" & vbCrLf & _
                         "for today [ " & CTRL_S.SYSDATE & " ] in preparation for EOD processing" & vbCrLf & _
                         "Please make sure all users are logged-out of the system ! ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "End-of-Day")
            If msg = vbCancel Then Exit Sub
            If CTRL_S.EOMF Then
                'If CBool(GetRStr("SELECT LNTACCR FROM PARAM_S", "LNTACCR", 0)) Then
                If CBool(GetRStr("SELECT INTACCR FROM PARAM_S", "INTACCR", 0)) Then
                    msg = MsgBox("Interest for [" & CTRL_S.SYSDATE & "] is already accrued.", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Over-the-counter")
                    If msg = vbCancel Then Exit Sub
                End If
                msg = MsgBox("Accrue Interest for " & CTRL_S.SYSDATE & ".", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "End-of-Day")
                If msg = vbCancel Then Exit Sub

                If Month(DateValue(CTRL_S.SYSDATE)) = 1 Or Month(DateValue(CTRL_S.SYSDATE)) = 4 Or Month(DateValue(CTRL_S.SYSDATE)) = 7 _
                   Or Month(DateValue(CTRL_S.SYSDATE)) = 10 Then
                    X = 1
                ElseIf Month(DateValue(CTRL_S.SYSDATE)) = 2 Or Month(DateValue(CTRL_S.SYSDATE)) = 5 Or Month(DateValue(CTRL_S.SYSDATE)) = 8 _
                   Or Month(DateValue(CTRL_S.SYSDATE)) = 11 Then
                    X = 2
                ElseIf Month(DateValue(CTRL_S.SYSDATE)) = 3 Or Month(DateValue(CTRL_S.SYSDATE)) = 6 Or Month(DateValue(CTRL_S.SYSDATE)) = 9 _
                   Or Month(DateValue(CTRL_S.SYSDATE)) = 12 Then
                    X = 3
                End If
                rExec("INSERT INTO INTRST_S(ACCTNO,ADB,MONTH1,MONTH2,MONTH3,QTD) " & _
                      "SELECT ACCTNO,0,0,0,0,0 FROM SDMASTER WHERE ACCTNO NOT IN " & _
                      "(SELECT ACCTNO FROM INTRST_S) AND (ACCTSTAT='A' OR ACCTSTAT='D')")
                rExec("DELETE FROM INTRST_S WHERE ACCTNO NOT IN (SELECT ACCTNO FROM SDMASTER WHERE ACCTSTAT<>'C')")
                rExec("UPDATE INTRST_S SET ADB=0,MONTH" & X & "=0 FROM  (SELECT IT.ACCTNO FROM INTRST_S IT " & _
                      "INNER JOIN SDMASTER SM ON SM.ACCTNO=IT.ACCTNO WHERE SM.ACCTSTAT='A' OR SM.ACCTSTAT='D') INT " & _
                      "WHERE(INTRST_S.ACCTNO = Int.ACCTNO)")
                CompADB()
            End If
            pstSDTRAN()
            setFlags()
        End If
    End Sub

    Private Sub bgwOTCProcess_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwOTCProcess.RunWorkerCompleted
        Me.Close()
    End Sub
End Class
