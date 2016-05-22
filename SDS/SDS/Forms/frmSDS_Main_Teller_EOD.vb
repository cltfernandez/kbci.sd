Public Class frmSDS_Main_Teller_EOD
    Dim frmFD_Member As frmReportViewer
    Private Sub frmSDS_Main_Teller_EOD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmpEOD()
        FillCtrl()
    End Sub
    Sub cmpEOD()
        Dim x As Integer
        Try
            rExec("UPDATE SPTELLER SET CASHSAV=SD.AMT FROM (SELECT [USER],ISNULL(SUM(TRANCRE),0) AMT FROM SDTRAN " & _
                  "WHERE TRANDATE='" & CTRL_S.SYSDATE & "' AND REVERSED='False' AND [USER]='" & SPUSER.SPUSERID & "' AND (TRANCODE='NCD' OR TRANCODE='CSD') " & _
                  "GROUP BY	[USER]) SD WHERE SD.[USER] = SPTELLER.TNAME")
            rExec("UPDATE SPTELLER SET  CRSAV=SD.AMT FROM (SELECT [USER],ISNULL(SUM(TRANCRE),0) AMT FROM SDTRAN " & _
                  "WHERE TRANDATE='" & CTRL_S.SYSDATE & "' AND REVERSED='False' AND [USER]='" & SPUSER.SPUSERID & "' AND (TRANCODE='LCD' OR TRANCODE='NLD' OR TRANCODE='OUS') " & _
                  "GROUP BY	[USER]) SD  WHERE SD.[USER] = SPTELLER.TNAME")
            rExec("UPDATE SPTELLER SET [WITH]=SD.AMT FROM (SELECT [USER],ISNULL(SUM(TRANDEB),0) AMT FROM SDTRAN " & _
                  "WHERE TRANDATE='" & CTRL_S.SYSDATE & "' AND REVERSED='False' AND [USER]='" & SPUSER.SPUSERID & "' AND (TRANCODE='WD' OR TRANCODE='NWD') " & _
                  "GROUP BY	[USER]) SD WHERE SD.[USER] = SPTELLER.TNAME")
            rExec("UPDATE SPTELLER SET ADDLTD=SD.AMT FROM (SELECT OTHUSER,ISNULL(SUM(OTHAMOUNT),0) AMT FROM SDOTHERS " & _
                  "WHERE OTHDATE='" & CTRL_S.SYSDATE & "' AND OTHUSER='" & SPUSER.SPUSERID & "' AND OTHTYPE='A' GROUP BY OTHUSER) SD WHERE SD.OTHUSER = SPTELLER.TNAME")
            rExec("UPDATE SPTELLER SET CRCR=SD.AMT FROM (SELECT OTHUSER,ISNULL(SUM(OTHAMOUNT),0) AMT FROM SDOTHERS " & _
                  "WHERE OTHDATE='" & CTRL_S.SYSDATE & "' AND OTHUSER='" & SPUSER.SPUSERID & "' AND OTHTYPE='B' GROUP BY OTHUSER) SD WHERE SD.OTHUSER = SPTELLER.TNAME")
            rExec("UPDATE SPTELLER SET CRACC=SD.AMT,CHKENC=SD.AMT FROM (SELECT OTHUSER,SUM(ISNULL(OTHAMOUNT,0)) AMT FROM SDOTHERS " & _
                  "WHERE OTHDATE='" & CTRL_S.SYSDATE & "' AND OTHUSER='" & SPUSER.SPUSERID & "' AND OTHTYPE='C' GROUP BY OTHUSER) SD WHERE SD.OTHUSER = SPTELLER.TNAME")
            rExec("UPDATE SPTELLER SET REF=SD.AMT FROM (SELECT OTHUSER,SUM(ISNULL(OTHAMOUNT,0)) AMT FROM SDOTHERS " & _
                  "WHERE OTHDATE='" & CTRL_S.SYSDATE & "' AND OTHUSER='" & SPUSER.SPUSERID & "' AND OTHTYPE='D' GROUP BY OTHUSER) SD WHERE SD.OTHUSER = SPTELLER.TNAME")
            rExec("UPDATE SPTELLER SET EMER=SD.AMT FROM (SELECT OTHUSER,SUM(ISNULL(OTHAMOUNT,0)) AMT FROM SDOTHERS " & _
                  "WHERE OTHDATE='" & CTRL_S.SYSDATE & "' AND OTHUSER='" & SPUSER.SPUSERID & "' AND OTHTYPE='E' GROUP BY OTHUSER) SD WHERE SD.OTHUSER = SPTELLER.TNAME")
            rExec("UPDATE SPTELLER SET CTFNAME1='',CTFNAME2='',CTFNAME3='',CTFAMT1=0,CTFAMT2=0,CTFAMT3=0," & _
                  "CTTNAME1='',CTTNAME2='',CTTNAME3='',CTTAMT1=0,CTTAMT2=0,CTTAMT3=0 WHERE TNAME='" & SPUSER.SPUSERID & "'")
            rExec("UPDATE SPTELLER SET ADDMREQ = X.ADDMREQ FROM (SELECT ADDLREQ + (SELECT ISNULL(SUM(REQAMT),0) FROM CASHREQ WHERE REQNAME='" & SPUSER.SPUSERID & "') ADDMREQ " & _
                  "FROM SPTELLER WHERE TNAME='" & SPUSER.SPUSERID & "') X  WHERE TNAME='" & SPUSER.SPUSERID & "'")
            rExec("UPDATE SPTELLER SET ADDCASH=X.ADDCASH,ADDCHECKS=X.ADDCHECKS,CTTCEND=X.CTTCEND,TCCOUNT=X.CTTCEND,CHKDEP=X.CHKDEP " & _
                  "FROM (SELECT (ISNULL(CASHB,0)+ISNULL(COCIB,0)+ISNULL(ADDMREQ,0)+ISNULL(CASHSAV,0)+ ISNULL(CASHOR,0)+ISNULL(ADDLTD,0)+ISNULL(CTFAMT1,0)+ISNULL(CTFAMT2,0)+ISNULL(CTFAMT3,0)) ADDCASH," & _
                  "(ISNULL(CRSAV,0)+ISNULL(CRORO,0)+ISNULL(CRACC,0)+ISNULL(CRCR,0)) ADDCHECKS,((B_1000 * 1000) + (B_500 * 500) + (B_200 * 200) + (B_100 * 100) + " & _
                  "(B_50 * 50) + (B_20 * 20) + (B_10 * 10) + (B_5 * 5) + B_1 + (B_P50 * 0.5) + (B_P25 * 0.25) + (B_P10 * 0.1) + (B_P05 * 0.05) + (B_P01 * 0.01)) AS CTTCEND," & _
                  "(COCIB+CRSAV+CRORO+CRACC+CRCR-COCI) CHKDEP FROM SPTELLER WHERE	TNAME='" & SPUSER.SPUSERID & "') X WHERE TNAME='" & SPUSER.SPUSERID & "'")
            rExec("UPDATE SPTELLER SET ADDTOTAL=X.ADDTOTAL " & _
                  "FROM (SELECT ADDCHECKS+ADDCASH ADDTOTAL FROM SPTELLER WHERE TNAME='" & SPUSER.SPUSERID & "') X WHERE TNAME='" & SPUSER.SPUSERID & "'")
            rExec("UPDATE SPTELLER SET TOTDISB=X.XTOTDISB,CBALEND=(ADDTOTAL - X.XTOTDISB) " & _
                  "FROM (SELECT TNAME TN,(DIB+REF+[WITH]+CHKENC+CTTAMT1+CTTAMT2+CTTAMT3+COCI+CHKDEP+EMER) XTOTDISB " & _
                  "FROM SPTELLER WHERE TNAME='" & SPUSER.SPUSERID & "') X WHERE TNAME = X.TN")
            rExec("UPDATE SPTELLER SET [OVER] = X.OVR FROM (SELECT TNAME TN,(CTTCEND-CBALEND) OVR FROM SPTELLER WHERE TNAME='" & SPUSER.SPUSERID & "') X WHERE TNAME = X.TN")

            GetData("SELECT TRANAME,SUM(TRAAMT)AMT FROM CASHTRA WHERE TRANAMETO='" & SPUSER.SPUSERID & "' GROUP BY TRANAME", "", DataGridView1)
            With DataGridView1
                If .RowCount > 0 Then
                    For x = 0 To .RowCount - 1
                        rExec("UPDATE SPTELLER SET CTFNAME" & x + 1 & "='" & .Rows(x).Cells("TRANAME").Value & "'," & _
                              "CTFAMT" & x + 1 & "=" & CDbl(.Rows(x).Cells("AMT").Value) & " WHERE TNAME='" & SPUSER.SPUSERID & "'")
                    Next
                End If
            End With

            GetData("SELECT TRANAMETO,SUM(TRAAMT)AMT FROM CASHTRA WHERE TRANAME='" & SPUSER.SPUSERID & "' GROUP BY TRANAMETO", "", DataGridView1)
            With DataGridView1
                If .RowCount > 0 Then
                    For x = 0 To .RowCount - 1
                        rExec("UPDATE SPTELLER SET CTTNAME" & x + 1 & "='" & .Rows(x).Cells("TRANAMETO").Value & "'," & _
                              "CTTAMT" & x + 1 & "=" & CDbl(.Rows(x).Cells("AMT").Value) & " WHERE TNAME='" & SPUSER.SPUSERID & "'")
                    Next
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub FillCtrl()
        EnDs(False)
        GetData("SELECT [CASHB] ,[COCIB] ,[ADDMREQ] ,[CASHSAV] ,[CASHOR] ,[ADDLTD]," & _
                "[CTFNAME1] ,[CTFAMT1], [ADDTOTAL] ,[CTFNAME2] ,[CTFAMT2] ,[CTFNAME3] ,[CTFAMT3],[CRSAV] ,[CRORO] ," & _
                "[CRACC] ,[CRCR] ,[DIB] ,[REF] ,[WITH] ,[CHKENC] ,[COCI] ,[CHKDEP] ,[EMER]," & _
                "[CTTNAME1] ,[CTTAMT1] ,[CTTNAME2] ,[CTTAMT2] ,[CTTNAME3] ,[CTTAMT3] ,[TOTDISB] ,[CBALEND] ,[CTTCEND]," & _
                "[OVER] ,[B_1000] ,[B_500] ,[B_200] ,[B_100] ,[B_50] ,[B_20] ,[B_10] ,[B_5] ,[B_1] ,[B_P50] ,[B_P25]," & _
                "[B_P10] ,[B_P05] ,[B_P01] ,[TCCOUNT]  FROM [SPTELLER] WHERE TNAME='" & SPUSER.SPUSERID & "'", "", DataGridView1)
        With DataGridView1
            If .RowCount > 0 Then
                txtcashb.Text = FormatNumber(.Rows(0).Cells("cashb").Value)
                txtcocib.Text = FormatNumber(.Rows(0).Cells("cocib").Value)
                txtaddmreq.Text = FormatNumber(.Rows(0).Cells("addmreq").Value)
                txtcashsav.Text = FormatNumber(.Rows(0).Cells("cashsav").Value)
                txtcashor.Text = FormatNumber(.Rows(0).Cells("cashor").Value)
                txtaddltd.Text = FormatNumber(.Rows(0).Cells("addltd").Value)

                cmbctfname1.Text = .Rows(0).Cells("ctfname1").Value
                cmbctfname2.Text = .Rows(0).Cells("ctfname2").Value
                cmbctfname3.Text = .Rows(0).Cells("ctfname3").Value
                txtctfamt1.Text = FormatNumber(.Rows(0).Cells("ctfamt1").Value)
                txtctfamt2.Text = FormatNumber(.Rows(0).Cells("ctfamt2").Value)
                txtctfamt3.Text = FormatNumber(.Rows(0).Cells("ctfamt3").Value)

                cmbcttname1.Text = .Rows(0).Cells("cttname1").Value
                cmbcttname2.Text = .Rows(0).Cells("cttname2").Value
                cmbcttname3.Text = .Rows(0).Cells("cttname3").Value
                txtcttamt1.Text = FormatNumber(.Rows(0).Cells("cttamt1").Value)
                txtcttamt2.Text = FormatNumber(.Rows(0).Cells("cttamt2").Value)
                txtcttamt3.Text = FormatNumber(.Rows(0).Cells("cttamt3").Value)
                txtcrsav.Text = FormatNumber(.Rows(0).Cells("crsav").Value)
                txtcroro.Text = FormatNumber(.Rows(0).Cells("croro").Value)
                txtcracc.Text = FormatNumber(.Rows(0).Cells("cracc").Value)
                txtcrcr.Text = FormatNumber(.Rows(0).Cells("crcr").Value)
                txtdib.Text = FormatNumber(.Rows(0).Cells("dib").Value)
                txtref.Text = FormatNumber(.Rows(0).Cells("ref").Value)
                txtwith.Text = FormatNumber(.Rows(0).Cells("with").Value)
                txtchkenc.Text = FormatNumber(.Rows(0).Cells("chkenc").Value)
                txtcoci.Text = FormatNumber(.Rows(0).Cells("coci").Value)
                txtchkdep.Text = FormatNumber(.Rows(0).Cells("chkdep").Value)
                txtemer.Text = FormatNumber(.Rows(0).Cells("emer").Value)
                lblover.Text = FormatNumber(.Rows(0).Cells("over").Value)
                lbltotdisb.Text = FormatNumber(.Rows(0).Cells("totdisb").Value)
                lblcbalend.Text = FormatNumber(.Rows(0).Cells("cbalend").Value)
                lblcttcend.Text = FormatNumber(.Rows(0).Cells("cttcend").Value)
                lbladdtotal.Text = FormatNumber(.Rows(0).Cells("addtotal").Value)
                NumericUpDown1.Value = CInt(.Rows(0).Cells("b_1000").Value)
                NumericUpDown3.Value = CInt(.Rows(0).Cells("b_500").Value)
                NumericUpDown2.Value = CInt(.Rows(0).Cells("b_200").Value)
                NumericUpDown4.Value = CInt(.Rows(0).Cells("b_100").Value)
                NumericUpDown5.Value = CInt(.Rows(0).Cells("b_50").Value)
                NumericUpDown6.Value = CInt(.Rows(0).Cells("b_20").Value)
                NumericUpDown7.Value = CInt(.Rows(0).Cells("b_10").Value)
                NumericUpDown9.Value = CInt(.Rows(0).Cells("b_5").Value)
                NumericUpDown8.Value = CInt(.Rows(0).Cells("b_1").Value)
                NumericUpDown10.Value = CInt(.Rows(0).Cells("b_p50").Value)
                NumericUpDown11.Value = CInt(.Rows(0).Cells("b_p25").Value)
                NumericUpDown12.Value = CInt(.Rows(0).Cells("b_p10").Value)
                NumericUpDown13.Value = CInt(.Rows(0).Cells("b_p05").Value)
                NumericUpDown14.Value = CInt(.Rows(0).Cells("b_p01").Value)
            End If
        End With
        lbltccount.Text = FormatNumber(CDbl(Label65.Text) + CDbl(Label64.Text) + CDbl(Label66.Text) + _
                                       CDbl(Label69.Text) + CDbl(Label67.Text) + CDbl(Label68.Text) + _
                                       CDbl(Label74.Text) + CDbl(Label70.Text) + CDbl(Label72.Text) + _
                                       CDbl(Label75.Text) + CDbl(Label71.Text) + CDbl(Label73.Text) + _
                                       CDbl(Label76.Text) + CDbl(Label77.Text))
    End Sub
    Sub EnDs(ByVal flag As Boolean)
        Dim control As Control
        For Each control In GroupBox2.Controls
            If TypeOf control Is TextBox Or TypeOf control Is ComboBox Or TypeOf control Is NumericUpDown Then
                control.Enabled = flag
            End If
        Next
        txtaddmreq.Enabled = False

        cmbctfname1.Enabled = False
        cmbctfname2.Enabled = False
        cmbctfname3.Enabled = False
        txtctfamt1.Enabled = False
        txtctfamt2.Enabled = False
        txtctfamt3.Enabled = False

        cmbcttname1.Enabled = False
        cmbcttname2.Enabled = False
        cmbcttname3.Enabled = False
        txtcttamt1.Enabled = False
        txtcttamt2.Enabled = False
        txtcttamt3.Enabled = False
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        Label65.Text = FormatNumber(CDbl(NumericUpDown1.Value * 1000))
    End Sub

    Private Sub NumericUpDown3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown3.ValueChanged
        Label64.Text = FormatNumber(CDbl(NumericUpDown3.Value * 500))
    End Sub

    Private Sub NumericUpDown2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown2.ValueChanged
        Label66.Text = FormatNumber(CDbl(NumericUpDown2.Value * 200))
    End Sub

    Private Sub NumericUpDown4_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown4.ValueChanged
        Label69.Text = FormatNumber(CDbl(NumericUpDown4.Value * 100))
    End Sub

    Private Sub NumericUpDown5_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown5.ValueChanged
        Label67.Text = FormatNumber(CDbl(NumericUpDown5.Value * 50))
    End Sub

    Private Sub NumericUpDown6_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown6.ValueChanged
        Label68.Text = FormatNumber(CDbl(NumericUpDown6.Value * 20))
    End Sub

    Private Sub NumericUpDown7_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown7.ValueChanged
        Label74.Text = FormatNumber(CDbl(NumericUpDown7.Value * 10))
    End Sub

    Private Sub NumericUpDown9_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown9.ValueChanged
        Label70.Text = FormatNumber(CDbl(NumericUpDown9.Value * 5))
    End Sub

    Private Sub NumericUpDown8_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown8.ValueChanged
        Label72.Text = FormatNumber(CDbl(NumericUpDown8.Value))
    End Sub

    Private Sub NumericUpDown10_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown10.ValueChanged
        Label75.Text = FormatNumber(CDbl(NumericUpDown10.Value * 0.5))
    End Sub

    Private Sub NumericUpDown11_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown11.ValueChanged
        Label71.Text = FormatNumber(CDbl(NumericUpDown11.Value * 0.25))
    End Sub

    Private Sub NumericUpDown12_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown12.ValueChanged
        Label73.Text = FormatNumber(CDbl(NumericUpDown12.Value * 0.1))
    End Sub

    Private Sub NumericUpDown13_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown13.ValueChanged
        Label76.Text = FormatNumber(CDbl(NumericUpDown13.Value * 0.05))
    End Sub

    Private Sub NumericUpDown14_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown14.ValueChanged
        Label77.Text = FormatNumber(CDbl(NumericUpDown14.Value * 0.01))
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Button4.Text = "E&dit" Then
            Button4.Text = "Sa&ve" : Button1.Enabled = False
            EnDs(True)
        Else
            rExec("UPDATE [SPTELLER]  SET [CASHB] = " & CDbl(txtcashb.Text) & _
                  ",[COCIB] = " & CDbl(txtcocib.Text) & _
                  ",[ADDMREQ] = " & CDbl(txtaddmreq.Text) & ",[CASHSAV] = " & CDbl(txtcashsav.Text) & _
                  ",[CASHOR] = " & CDbl(txtcashor.Text) & ",[ADDLTD] = " & CDbl(txtaddltd.Text) & _
                  ",[CTFNAME1] = '" & cmbctfname1.Text & "',[CTFAMT1] = " & CDbl(txtctfamt1.Text) & _
                  ",[CTFNAME2] = '" & cmbctfname2.Text & "',[CTFAMT2] = " & CDbl(txtctfamt2.Text) & _
                  ",[CTFNAME3] = '" & cmbctfname3.Text & "',[CTFAMT3] = " & CDbl(txtctfamt3.Text) & _
                  ",[CRSAV] = " & CDbl(txtcrsav.Text) & _
                  ",[CRORO] = " & CDbl(txtcroro.Text) & ",[CRACC] = " & CDbl(txtcracc.Text) & _
                  ",[CRCR] = " & CDbl(txtcrcr.Text) & _
                  ",[DIB] = " & CDbl(txtdib.Text) & ",[REF] = " & CDbl(txtref.Text) & _
                  ",[WITH] = " & CDbl(txtwith.Text) & ",[CHKENC] = " & CDbl(txtchkenc.Text) & _
                  ",[COCI] = " & CDbl(txtcoci.Text) & ",[CHKDEP] = " & CDbl(txtchkdep.Text) & _
                  ",[EMER] = " & CDbl(txtemer.Text) & ",[CTTNAME1] = '" & cmbcttname1.Text & "'" & _
                  ",[CTTAMT1] = " & CDbl(txtcttamt1.Text) & ",[CTTNAME2] = '" & cmbcttname2.Text & "'" & _
                  ",[CTTAMT2] = " & CDbl(txtcttamt2.Text) & ",[CTTNAME3] = '" & cmbcttname3.Text & "'" & _
                  ",[CTTAMT3] = " & CDbl(txtcttamt3.Text) & _
                  ",[B_1000] = " & NumericUpDown1.Value & _
                  ",[B_500] = " & NumericUpDown3.Value & ",[B_200] = " & NumericUpDown2.Value & _
                  ",[B_100] = " & NumericUpDown4.Value & ",[B_50] = " & NumericUpDown5.Value & _
                  ",[B_20] = " & NumericUpDown6.Value & ",[B_10] = " & NumericUpDown7.Value & _
                  ",[B_5] = " & NumericUpDown9.Value & ",[B_1] = " & NumericUpDown8.Value & _
                  ",[B_P50] = " & NumericUpDown10.Value & ",[B_P25] = " & NumericUpDown11.Value & _
                  ",[B_P10] = " & NumericUpDown12.Value & ",[B_P05] = " & NumericUpDown13.Value & _
                  ",[B_P01] = " & NumericUpDown14.Value & _
                  "WHERE TNAME='" & SPUSER.SPUSERID & "'")
            cmpEOD()
            FillCtrl()
            Button4.Text = "E&dit" : Button1.Enabled = True
            EnDs(False)
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptTel_Tran
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True

        frmFD_Member = New frmReportViewer
        'frmFD_Member.MdiParent = frmSDS_Main
        sQRY = "SELECT SU.SPUSERNAME, ST.[CASHB],ST.[COCIB],ST.[ADDMREQ],ST.[CASHSAV],ST.[CASHOR],ST.[ADDCHECKS],ST.[ADDLTD]," & _
            "ST.[CTFNAME1],ST.[CTFAMT1],ST.[CTFNAME2],ST.[CTFAMT2],ST.[CTFNAME3],ST.[CTFAMT3],ST.[ADDCASH],ST.[CRSAV],ST.[CRORO],ST.[CRACC],ST.[CRCR]," & _
            "ST.[ADDTOTAL],ST.[DIB],ST.[REF],ST.[WITH],ST.[CHKENC],ST.[COCI],ST.[CHKDEP],ST.[EMER],ST.[CTTNAME1],ST.[CTTAMT1],ST.[CTTNAME2],ST.[CTTAMT2],ST.[CTTNAME3],ST.[CTTAMT3]," & _
            "ST.[TOTDISB],ST.[CBALEND],ST.[CTTCEND],ST.[OVER],ST.[B_1000],ST.[B_500],ST.[B_200],ST.[B_100],ST.[B_50],ST.[B_20],ST.[B_10],ST.[B_5],ST.[B_1],ST.[B_P50],ST.[B_P25],ST.[B_P10]," & _
            "ST.[B_P05], ST.[B_P01], ST.[TCCOUNT] FROM SPTELLER ST INNER JOIN SPUSER SU ON ST.TNAME=SU.SPUSERID WHERE ST.TNAME='" & SPUSER.SPUSERID & "'"
        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "3:2:2:2:2:2:2:2:3:2:3:2:3:2:2:2:2:2:2:2:2:2:2:2:2:2:2:3:2:3:2:3:2:2:2:2:2:3:3:3:3:3:3:3:3:3:3:3:3:3:3:2")
            frmFD_Member.Show()
        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        SW = False
        DT.Dispose()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Dispose()
    End Sub
End Class