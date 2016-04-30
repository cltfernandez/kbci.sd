Public Class frmSDS_Main_Batch
    Dim qryMEM, qryTRAN As String
    Dim frmSDS_Main_Batch_Tran As frmSDS_Main_Batch_Tran
    Dim X, CHKCDAY, CHKNDAY As Integer
    Dim TRNCDE, ACCTNM, srchstr, fField As String
    Dim CHCKAMOUNT, AFLOATS As Decimal
    Sub ApplyAcc()
        If CBool(CInt(CStr(SPTAG(4)))) = False Then Button3.Enabled = False Else Button3.Enabled = True
        If CBool(CInt(CStr(SPTAG(5)))) = False Then Button2.Enabled = False Else Button2.Enabled = True
        If CBool(CInt(CStr(SPTAG(7)))) = False Then Button4.Enabled = False Else Button4.Enabled = True
    End Sub
    Private Sub frmSDS_Main_Batch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim BPOST As Boolean = CBool(GetRStr("SELECT BPOST FROM CTRL_S", "BPOST", 0))
        Dim BINIT As Boolean = CBool(GetRStr("SELECT BINIT FROM CTRL_S", "BINIT", 0))
        qryMEM = "select sdmaster_id,acctno ACCT_NO,isnull(kbci_no,'') KBCI_NO,isnull(acctname,'') NAME," & _
        "isnull(acctpbal,'0.00') acctpbal,isnull(acctlbal,'0.00') acctlbal," & _
        "isnull(acctobal,'0.00') acctobal,isnull(acctfloats,'0.00') acctfloats," & _
        "isnull(acctabal,'0.00') acctabal,acctstat STATUS,holdout,lseq from sdmaster"
        FillLV(ListView1, GetData(qryMEM, "", DataGridView1), "0:109:77:548:0:0:0:0:0:102:0:0", "1:2:2:1:1:1:1:1:1:2:1:1", False)
        If BINIT And BPOST Then
            Dim msg As String
            msg = MsgBox("Batch is already posted, would you like to initialize the database for new batch?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Batch Processing")
            If msg = vbYes Then rExec("UPDATE CTRL_S SET BINIT=0") : Button3.Enabled = True
        End If
        If Not BINIT And Not BPOST Then Button3.Enabled = True : MsgBox("Please Initialize before posting the batch.", MsgBoxStyle.Information, "Batch Processing")
        If BINIT And Not BPOST Then Button2.Enabled = True : Button4.Enabled = True : MsgBox("Batch entries not yet posted.", MsgBoxStyle.Information, "Batch Processing")
        ApplyAcc()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim msg As String
        msg = MsgBox("Would you like to initialize the Batch Database?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Batch Processing")
        If msg = vbYes Then
            rExec("TRUNCATE TABLE SDTRANB")
            rExec("UPDATE CTRL_S SET BPOST=0")
            rExec("UPDATE CTRL_S SET BINIT=1")
            Button3.Enabled = False
            msg = MsgBox("File successfully initialized... Would you like to post transaction for Batch Processing?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Batch Processing")
            If msg = vbYes Then Button2.Enabled = True : Button4.Enabled = True
        End If
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try

            If ListView1.SelectedItems.Count > 0 Then
                SDMASTERID = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(0).Text
                If recIsUsed(SDMASTERID) Then _
                        MsgBox("This Record is currently being modified by [" & ModifierID & "], Please try again later", MsgBoxStyle.Information, "Record Locked") : Exit Sub
                If ListView1.Items(ListView1.SelectedIndices(0)).SubItems(9).Text.Trim.ToUpper <> "A" Then MsgBox("This Account is INACTIVE.", MsgBoxStyle.Information, "Member Transaction / Inquiry") : Exit Sub
                GroupBox3.Visible = True
                GroupBox2.Enabled = False
                TextBox4.Enabled = False : TextBox2.Enabled = False : TextBox1.Enabled = False
                qryTRAN = "SELECT SDTRANB_ID,TRANSEQ AS SEQ,TRANCODE AS CODE,TRANDEB AS DEBIT,TRANCRE AS CREDIT,CHKNUM AS CHECK_NO," & _
                          "CHKBANK AS BANK,TRANDATE,TRANEBAL FROM SDTRANB WHERE ACCTNUM='" & TextBox4.Text.Trim.Replace("-", "") & _
                          "' ORDER BY SDTRANB_ID, SEQ, TRANDATE"
                FillLV(ListView2, GetData(qryTRAN, "", DataGridView2), "0:54:54:136:134:100:332:0:0", "1:2:2:3:3:1:1:0:0", True)
                With DataGridView2
                    If .RowCount > 0 Then
                        ACCTABAL = CDbl(.Rows(.RowCount - 1).Cells("TRANEBAL").Value)
                        ACCTOBAL = ACCTABAL
                        LSEQ = CInt(.Rows(.RowCount - 1).Cells("SEQ").Value)
                    End If
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Dim acctbal As Decimal
        Try
            If ListView1.SelectedIndices.Count > 0 Then
                LSEQ = CInt((ListView1.Items(ListView1.SelectedIndices(0)).SubItems(11).Text))
                ACCTOBAL = CDbl((ListView1.Items(ListView1.SelectedIndices(0)).SubItems(6).Text))
                ACCTABAL = CDbl(ListView1.Items(ListView1.SelectedIndices(0)).SubItems(8).Text)
                LHOLDOUT = CDbl(GetRStr("select isnull(sum(holdamt),'0') holdamt from lnhold where acctno='" & TextBox2.Text.Trim.Replace("-", "") & "' and holddate='" & CTRL_S.SYSDATE & "' and poststat=null", "holdamt", 0))                
                HOLDOUT = CDbl((ListView1.Items(ListView1.SelectedIndices(0)).SubItems(10).Text))

                acctbal = CDbl(ACCTABAL - (HOLDOUT + CDbl(CTRL_S.MINBAL)) + LHOLDOUT)
                ACCTSTAT = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(9).Text.ToUpper
                ACCTFLOATS = CDbl(ListView1.Items(ListView1.SelectedIndices(0)).SubItems(7).Text)
                ACCTNUM = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(1).Text
                TextBox4.Text = Mid(ACCTNUM, 1, 4) & "-" & Mid(ACCTNUM, 5, 5) & "-" & Mid(ACCTNUM, 10, 1)
                TextBox2.Text = Mid(ListView1.Items(ListView1.SelectedIndices(0)).SubItems(2).Text, 1, 2) & "-" & _
                                Mid(ListView1.Items(ListView1.SelectedIndices(0)).SubItems(2).Text, 3, 4) & "-" & _
                                Mid(ListView1.Items(ListView1.SelectedIndices(0)).SubItems(2).Text, 7, 1)
                TextBox1.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(3).Text
                lblacctpbal.Text = FormatNumber(ListView1.Items(ListView1.SelectedIndices(0)).SubItems(4).Text, 2)
                lblacctlbal.Text = FormatNumber(ListView1.Items(ListView1.SelectedIndices(0)).SubItems(5).Text, 2)
                lblacctobal.Text = FormatNumber(ACCTOBAL, 2)
                lblacctfloats.Text = FormatNumber(ACCTFLOATS, 2)
                If acctbal < 0 Then acctbal = 0
                lblacctabal.Text = FormatNumber(acctbal, 2)

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Critical Error")
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        frmSDS_Main_Batch_Tran = New frmSDS_Main_Batch_Tran
        frmSDS_Main_Batch_Tran.ShowDialog()
        If SW = True Then
            SW = False
            FillLV(ListView2, GetData(qryTRAN, "TRANDATE='" & CTRL_S.SYSDATE & "'", DataGridView2), "0:54:54:136:134:100:312:0:0", "1:2:2:3:3:1:1:0:0", True)
            ACCTABAL = CDbl(DataGridView2.Rows(DataGridView2.RowCount - 1).Cells("TRANEBAL").Value)
            ACCTOBAL = ACCTABAL
            LSEQ = CInt(DataGridView2.Rows(DataGridView2.RowCount - 1).Cells("SEQ").Value)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click


        Dim bQRY As String = "SELECT [ACCTNUM],[TRANDATE],[TRANSEQ],[TRANCODE],[TRANBBAL],[TRANDEB],[TRANCRE]," & _
                             "[TRANEBAL],[CHKNUM],[CHKBANK],[CHKCODE],[ADD_DATE],[ADD_TIME],[USER],[OVERRIDE]," & _
                             "[PPOSTED],[LPOSTED],[TRANOLD],[REVERSED] FROM SDTRANB " & _
                             "ORDER BY ACCTNUM, SDTRANB_ID, TRANSEQ, TRANDATE"
        GetData(bQRY, "", DataGridView3)
        X = 0
        With DataGridView3
            If .RowCount > 0 Then
                ProgressBar1.Visible = True : ProgressBar1.Maximum = .RowCount : ProgressBar1.Value = 0
                Do While X < .RowCount
                    ACCTNM = .Rows(X).Cells("ACCTNUM").Value
                    AFLOATS = CDbl(GetRStr("SELECT ACCTFLOATS FROM SDMASTER WHERE ACCTNO='" & ACCTNM & "'", "ACCTFLOATS", 0))
                    UPDTRAN()
                    ACCTOBAL = CDbl(.Rows(X).Cells("TRANEBAL").Value)
                    rExec("UPDATE SDMASTER SET LTRANDATE='" & CTRL_S.SYSDATE & "', ACCTOBAL=" & ACCTOBAL & ",ACCTABAL=" & CDbl(ACCTOBAL - AFLOATS) & _
                          ",ACCTLBAL=" & ACCTOBAL & ",ACCTFLOATS=" & AFLOATS & " WHERE ACCTNO='" & ACCTNUM & "'")
                    X += 1
                    ProgressBar1.PerformStep()
                Loop
                rExec("UPDATE CTRL_S SET BPOST=1")
                MsgBox("Transactions posted successfully!", MsgBoxStyle.Information, "Batch Processing")
                Button4.Enabled = False
                ProgressBar1.Visible = False
            End If
        End With


    End Sub
    Sub UPDTRAN()
        With DataGridView3


            rExec("INSERT INTO [SDTRAN]([ACCTNUM],[TRANDATE],[TRANSEQ],[TRANCODE],[TRANBBAL],[TRANDEB],[TRANCRE],[TRANEBAL]," & _
          "[CHKNUM],[CHKBANK],[CHKCODE],[ADD_DATE],[ADD_TIME],[USER],[OVERRIDE],[PPOSTED],[LPOSTED],[TRANOLD],[REVERSED]) " & _
    "Values('" & .Rows(X).Cells("ACCTNUM").Value & "','" & .Rows(X).Cells("TRANDATE").Value & "'," & .Rows(X).Cells("TRANSEQ").Value & ",'" & .Rows(X).Cells("TRANCODE").Value & "'," & .Rows(X).Cells("TRANBBAL").Value & "," & .Rows(X).Cells("TRANDEB").Value & "," & .Rows(X).Cells("TRANCRE").Value & "," & .Rows(X).Cells("TRANEBAL").Value & ",'" & _
           .Rows(X).Cells("CHKNUM").Value & "','" & .Rows(X).Cells("CHKBANK").Value & "','" & .Rows(X).Cells("CHKCODE").Value & "','" & .Rows(X).Cells("ADD_DATE").Value & "','" & .Rows(X).Cells("ADD_TIME").Value & "','" & .Rows(X).Cells("USER").Value & "','" & .Rows(X).Cells("OVERRIDE").Value & "',0,0,1,0)")
            TRNCDE = .Rows(X).Cells("TRANCODE").Value
            If TRNCDE = "LCD" Or TRNCDE = "NLD" Or TRNCDE = "OUS" Then
                CHCKAMOUNT = CDbl(.Rows(X).Cells("TRANCRE").Value) + CDbl(.Rows(X).Cells("TRANDEB").Value)
                Select Case CStr(.Rows(X).Cells("CHKCODE").Value)
                    Case "OUS"
                        CHKCDAY = GetRStr("SELECT CLR_ONUS AS CDAY FROM CTRL_S", "CDAY", 0)
                    Case "LOC"
                        CHKCDAY = GetRStr("SELECT CLR_LOCAL AS CDAY FROM CTRL_S", "CDAY", 0)
                    Case "REG"
                        CHKCDAY = GetRStr("SELECT CLR_REG AS CDAY FROM CTRL_S", "CDAY", 0)
                End Select
                CHKNDAY = CInt(CHKCDAY) - 1
                If CHKNDAY = 0 Then
                    CHKCDATE = CTRL_S.SYSDATE
                Else
                    AFLOATS = AFLOATS + CHCKAMOUNT
                End If
            End If
            If TRANCODE = "LCD" Or TRANCODE = "NLD" Or TRANCODE = "OUS" Then
                rExec("INSERT INTO [SDCHECK]([ACCTNUM],[TRANDATE],[TRANSEQ],[CHKCODE],[CHKAMT],[CHKNUM],[CHKBANK]," & _
                                            "[CHKCDATE],[CHKCDAYS],[CHKNDAYS],[CHKSTAT],[ADD_DATE],[ADD_TIME],[USER]) " & _
                     "VALUES('" & .Rows(X).Cells("ACCTNUM").Value & "','" & .Rows(X).Cells("TRANDATE").Value & "'," & _
                                  .Rows(X).Cells("TRANSEQ").Value & ",'" & .Rows(X).Cells("CHKCODE").Value & "'," & _
                                  CDbl(Abs(CHCKAMOUNT)) & ",'" & .Rows(X).Cells("CHKNUM").Value & "','" & _
                                  .Rows(X).Cells("CHKBANK").Value & "','" & CHKCDATE & "'," & CHKCDAY & "," & CHKNDAY & _
                                  ",'','" & .Rows(X).Cells("ADD_DATE").Value & "','" & .Rows(X).Cells("ADD_TIME").Value & "','" & _
                                  .Rows(X).Cells("USER").Value & "')")
            End If
        End With
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        GroupBox2.Enabled = True
        GroupBox3.Visible = False
        TextBox4.Enabled = True : TextBox2.Enabled = True : TextBox1.Enabled = True
        If SDMASTERID <> String.Empty Then LockREC(SDMASTERID, False)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If srchSTR <> "" Then
            FillLV(ListView1, GetData(qryMEM, fField & " like '%" & srchstr & "%'", DataGridView1), "0:109:77:548:0:0:0:0:0:102:0:0", "1:2:2:1:1:1:1:1:1:2:1:1", False)
        Else
            FillLV(ListView1, GetData(qryMEM, "", DataGridView1), "0:109:77:548:0:0:0:0:0:102:0:0", "1:2:2:1:1:1:1:1:1:2:1:1", False)
        End If
    End Sub

    Private Sub TextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
        fField = "NAME" : srchstr = TextBox1.Text.Trim
        Me.AcceptButton = Button10
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyUp
        fField = "KBCI_NO" : srchstr = TextBox2.Text.Trim
        Me.AcceptButton = Button10
    End Sub

    Private Sub TextBox4_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox4.KeyUp
        fField = "ACCT_NO" : srchstr = TextBox4.Text.Trim
        Me.AcceptButton = Button10
    End Sub

    Private Sub frmSDS_Main_Batch_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If SDMASTERID <> String.Empty Then LockREC(SDMASTERID, False)
    End Sub
End Class