Imports System.Windows.Forms

Public Class frmSDS_DormancyCharges

    Private frmFD_Member As frmFD_Member

    Private Sub bgwInsertTransaction_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwInsertTransaction.DoWork
        CTRL_S.getData()

        Dim sQuery As String = "DECLARE @DC NUMERIC(6,2)=" & CTRL_S.DormancyCharge & "DECLARE @DATE AS DATE='" & CTRL_S.SYSDATE & "'INSERT INTO SDTRAN(ACCTNUM,TRANDATE,TRANSEQ,TRANCODE," & _
                                "TRANBBAL,TRANDEB,TRANCRE,TRANEBAL,CHKNUM,CHKBANK,CHKCODE,ADD_DATE,ADD_TIME," & _
                                "[USER],OVERRIDE,PPOSTED,LPOSTED,TRANOLD,REVERSED)select B.ACCTNO,@DATE,CASE WHEN C." & _
                                "TRANSEQ+1<1000THEN C.TRANSEQ+1 ELSE 1 END,'DM',C.TRANEBAL,CASE WHEN C.TRANEBAL-@DC<0" & _
                                "THEN C.TRANEBAL ELSE @DC END,0,CASE WHEN C.TRANEBAL-@DC<0THEN 0 ELSE C.TRANEBAL-@DC END," & _
                                "'DORMANCY FEE','','',@DATE,'" & Format(TimeOfDay, "HH:mm:ss") & "'," & _
                                "'" & SPUSER.SPUSERID & "','',0,0,0,0from MEMBERS A JOIN SDMASTER B on A.KBCI_NO=B." & _
                                "KBCI_NO JOIN(select ACCTNUM,TRANDATE,TRANEBAL,TRANSEQ,CHKNUM from SDTRAN where " & _
                                "SDTRAN_ID in(select MAX(sdtran_id)id from SDTRAN group by ACCTNUM))C on B.ACCTNO=C." & _
                                "ACCTNUM LEFT JOIN CTD D on A.KBCI_NO=D.KBCI_NO where A.MEM_STAT='R' AND B.ACCTSTAT='A'and " & _
                                "d.KBCI_NO is null and DATEDIFF(""D"",C.trandate,@DATE)>=" & CTRL_S.DBDRM
        rExec(sQuery)

    End Sub

    Private Sub frmSDS_DormancyCharges_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bgwInsertTransaction.RunWorkerAsync()
    End Sub

    Private Sub bgwInsertTransaction_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwInsertTransaction.RunWorkerCompleted
        bgwUpdateSDMaster.RunWorkerAsync()
    End Sub

    Private Sub bgwUpdateSDMaster_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwUpdateSDMaster.DoWork
        CTRL_S.getData()
        Dim sQuery As String = "DECLARE @DC NUMERIC(6,2)=" & CTRL_S.DormancyCharge & "DECLARE @DATE AS DATE=" & _
        "'" & CTRL_S.SYSDATE & "'UPDATE SDMASTER SET ACCTOBAL=C.TRANEBAL,ACCTABAL=C.TRANEBAL" & _
        "-ACCTFLOATS,SDMASTER.LSEQ=C.TRANSEQ,SDMASTER.LTRANDATE=@DATE,SDMASTER.ACCTSTAT=" & _
        "CASE WHEN C.TRANEBAL<=0THEN'C'ELSE ACCTSTAT END from MEMBERS A JOIN SDMASTER B on A.KBCI_NO=" & _
        "B.KBCI_NO JOIN(select ACCTNUM,TRANDATE,TRANEBAL,TRANSEQ,CHKNUM from SDTRAN where " & _
        "SDTRAN_ID in(select MAX(sdtran_id)id from SDTRAN group by ACCTNUM))C on B.ACCTNO=C." & _
        "ACCTNUM LEFT JOIN CTD D on A.KBCI_NO=D.KBCI_NO where A.MEM_STAT='R'AND B.ACCTSTAT='A'and " & _
        "d.KBCI_NO is null AND C.CHKNUM='DORMANCY FEE'AND DATEDIFF(""D"",C.trandate,@DATE)=0"
        rExec(sQuery, 300)
    End Sub

    Private Sub bgwUpdateSDMaster_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwUpdateSDMaster.RunWorkerCompleted
        Dim MSGB = MsgBox("Posting Complete! Would you like to print a Dormancy Charges Report?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Print Dormancy Charges Report")
        If MSGB = vbYes Then
            PrintChargesReport()
        End If
        Me.Close()
    End Sub

    Private Sub PrintChargesReport()
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptEOM_DormantAccounts
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me

        sQRY = "DECLARE @DC NUMERIC(6,2)=" & CTRL_S.DormancyCharge & " DECLARE @DATE AS DATE='" & CTRL_S.SYSDATE & "' SELECT ACCTNO,ACCTSNAME,C." & _
                "TRANDEB DORMANCYFEE,C.TRANEBAL FROM MEMBERS A INNER JOIN SDMASTER B ON A.KBCI_NO=B." & _
                "KBCI_NO INNER JOIN(SELECT ACCTNUM,TRANDATE,TRANDEB,TRANEBAL,TRANSEQ,CHKNUM FROM " & _
                "SDTRAN WHERE SDTRAN_ID IN(SELECT MAX(sdtran_id)id FROM SDTRAN GROUP BY ACCTNUM))C ON B." & _
                "ACCTNO=C.ACCTNUM LEFT JOIN CTD D ON A.KBCI_NO=D.KBCI_NO WHERE A.MEM_STAT='R'AND B." & _
                "ACCTSTAT='A'AND d.KBCI_NO IS NULL AND C.CHKNUM='DORMANCY FEE'AND DATEDIFF(""D"",C." & _
                "trandate,@DATE)=0"


        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandTimeout = 300
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text2")
            DDATE.Text = "FOR THE MONTH OF " & MonthName(Month(CTRL_S.SYSDATE)) & ", " & Year(CTRL_S.SYSDATE)
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "3:3:2:2")
            frmFD_Member.Show()

        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        SW = False
        DT.Dispose()
    End Sub
End Class
