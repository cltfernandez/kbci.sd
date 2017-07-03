Public Class frmSDS_Main_Memlist
    Dim EDIT As Boolean
    Dim qryMem, ffield, srchstr As String    
    Private closeform As Boolean = False
    Sub ApplyAcc()
        If CBool(CInt(CStr(SPTAG(11)))) = False Then
            Button2.Enabled = False
            Button3.Enabled = False
        Else
            Button2.Enabled = True
            Button3.Enabled = True
        End If
        If CBool(CInt(CStr(SPTAG(12)))) = False Then Button9.Enabled = False Else Button9.Enabled = True
    End Sub

    Private Sub Initialize()
        qryMem = "select sdmaster_id,acctno ACCT_NO,isnull(kbci_no,'') KBCI_NO,isnull(acctname,'') NAME," & _
                 "ISNULL(CBEMPNO,'') CBEMPNO,ISNULL(ACCTSNAME,'') ACCTSNAME," & _
                 "ISNULL(ACCTADDR1,'') ACCTADDR1,ISNULL(ACCTADDR2,'') ACCTADDR2," & _
                 "ISNULL(ACCTSTAT,'') ACCTSTAT,(CASE WHEN ACCTTEX='Y' THEN 1 ELSE 0 END) ACCTTEX,(CASE WHEN ACCTACLO='Y' THEN 1 ELSE 0 END) ACCTACLO," & _
                 "(CASE WHEN ACCTWMIN='Y' THEN 1 ELSE 0 END) ACCTWMIN,(CASE WHEN ACCTWSC='Y' THEN 1 ELSE 0 END) ACCTWSC,(CASE WHEN ACCTWINT='Y' THEN 1 ELSE 0 END) ACCTWINT," & _
                 "ACCTIDEP,acctphone1,acctphone2,ACCTDTYPE,ACCTICODE,ACCTATX,ACCTOBAL FROM SDMASTER "
        FillLV(ListView1, GetData(qryMem, "", DataGridView1), "0:109:77:548:0:0:0:0:102:0:0:0:0:0:0:0:0:0:0:0:0", "1:2:2:1:1:1:1:2:1:1:1:1:1:1:1:1:1:1:1:1:3", False)
        ApplyAcc()
    End Sub
    Private Sub frmSDS_Main_Memlist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Initialize()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        closeform = True
        Me.Close()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            If ListView1.SelectedIndices.Count > 0 Then
                TextBox4.Text = Ckbacctno(ListView1.Items(ListView1.SelectedIndices(0)).SubItems(1).Text)
                TextBox2.Text = Ckbcino(ListView1.Items(ListView1.SelectedIndices(0)).SubItems(2).Text)
                TextBox1.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(3).Text
                If ListView1.Items(ListView1.SelectedIndices(0)).SubItems(8).Text.ToUpper.Trim = "C" Then Button9.Enabled = False Else Button9.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Critical Error")
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ListView1.SelectedIndices.Count > 0 Then
            If ListView1.Items(ListView1.SelectedIndices(0)).SubItems(8).Text.ToUpper.Trim = "C" Then btnReactivate.Enabled = True Else btnReactivate.Enabled = False
            GroupBox3.Visible = True
            Button4.Text = "E&dit"
            Set2ndBtn()
            EorD(False)
            EDIT = True
            Call LoadData()
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Using MemberSearchForm As New MemberSearchDialog(Common.MemberSearchType.MembersData)
            If MemberSearchForm.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                TextBox2.Text = Ckbcino(SEL_KBCI_NO)
                TextBox1.Text = SEL_FNAME
                loadFDInfo()
            End If
        End Using
    End Sub
    Sub loadFDInfo()
        Dim tb As New CLTF.DB.SQLDBConnection
        tb.OpenCmdDataTable(rCN, "SELECT isnull(CB_EMPNO,'') CB_EMPNO,isnull(MEM_ADDR,'') MEM_ADDR,isnull(DEPT,'') DEPT,isnull(OFF_TEL,'') OFF_TEL,isnull(RES_TEL,'') RES_TEL FROM MEMBERS WHERE KBCI_NO='" & SEL_KBCI_NO & "'")
        With tb
            If .DataCount > 0 Then
                TextBox5.Text = .GetValue("CB_EMPNO")
                TextBox8.Text = .GetValue("MEM_ADDR")
                TextBox7.Text = .GetValue("DEPT")
                TextBox9.Text = .GetValue("RES_TEL")
                TextBox10.Text = .GetValue("OFF_TEL")
            End If
        End With
        tb.CloseDataTable()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Button8.Visible = False
        GroupBox3.Visible = False
        SetDefBtn()
        EorD(True)
    End Sub
    Private Sub LoadData()
        Label18.Text = FormatNumber(CTRL_S.MINBAL)
        With ListView1
            TextBox5.Text = .Items(.SelectedIndices(0)).SubItems(4).Text
            TextBox6.Text = .Items(.SelectedIndices(0)).SubItems(5).Text
            TextBox8.Text = .Items(.SelectedIndices(0)).SubItems(6).Text
            TextBox7.Text = .Items(.SelectedIndices(0)).SubItems(7).Text
            TextBox3.Text = FormatNumber(.Items(.SelectedIndices(0)).SubItems(14).Text)
            Label19.Text = .Items(.SelectedIndices(0)).SubItems(8).Text
            CheckBox1.Checked = CBool(.Items(.SelectedIndices(0)).SubItems(9).Text)
            CheckBox2.Checked = CBool(.Items(.SelectedIndices(0)).SubItems(10).Text)
            CheckBox3.Checked = CBool(.Items(.SelectedIndices(0)).SubItems(11).Text)
            CheckBox4.Checked = CBool(.Items(.SelectedIndices(0)).SubItems(12).Text)
            CheckBox5.Checked = CBool(.Items(.SelectedIndices(0)).SubItems(13).Text)
            TextBox9.Text = Cphone(.Items(.SelectedIndices(0)).SubItems(15).Text)
            TextBox10.Text = Cphone(.Items(.SelectedIndices(0)).SubItems(16).Text)
            Label21.Text = .Items(.SelectedIndices(0)).SubItems(17).Text
            Label23.Text = .Items(.SelectedIndices(0)).SubItems(18).Text
            Label24.Text = .Items(.SelectedIndices(0)).SubItems(19).Text
        End With
    End Sub

    Sub EorD(ByVal Swtch As Boolean)
        Dim CTRL5 As Control
        For Each CTRL5 In GroupBox6.Controls
            If TypeOf CTRL5 Is TextBox Or TypeOf CTRL5 Is MaskedTextBox Then CTRL5.Enabled = Swtch
        Next
        For Each CTRL5 In GroupBox2.Controls
            If TypeOf CTRL5 Is TextBox Or TypeOf CTRL5 Is Button Then CTRL5.Enabled = Swtch
        Next
        For Each CTRL5 In GroupBox5.Controls
            If TypeOf CTRL5 Is Button Or TypeOf CTRL5 Is CheckBox Then CTRL5.Enabled = Swtch
        Next
        For Each CTRL5 In GroupBox4.Controls
            If TypeOf CTRL5 Is TextBox Then CTRL5.Enabled = Swtch
        Next
    End Sub
    Sub RESET()
        Dim CTRL5 As Control
        Dim ctrlx As CheckBox
        For Each CTRL5 In GroupBox2.Controls
            If TypeOf CTRL5 Is TextBox Then CTRL5.Text = ""
        Next
        For Each CTRL5 In GroupBox6.Controls
            If TypeOf CTRL5 Is TextBox Or TypeOf CTRL5 Is MaskedTextBox Then CTRL5.Text = ""
        Next
        For Each CTRL5 In GroupBox5.Controls
            If TypeOf CTRL5 Is CheckBox Then
                ctrlx = CTRL5
                ctrlx.Checked = False
            ElseIf TypeOf CTRL5 Is Label And CTRL5.Tag = "*" Then
                CTRL5.Text = ""
            End If
        Next
        For Each CTRL5 In GroupBox4.Controls
            If TypeOf CTRL5 Is TextBox Then CTRL5.Text = ""
        Next
        TextBox3.Text = "0.00"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim upd As New CLTF.DB.SQLDBConnection
        Dim upd2 As New CLTF.DB.SQLDBConnection
        Dim qrey, accntno As String
        If Button4.Text = "E&dit" Then
            Button8.Visible = True
            For Each CTRL5 In GroupBox6.Controls
                If TypeOf CTRL5 Is TextBox Or TypeOf CTRL5 Is MaskedTextBox Then CTRL5.Enabled = True
            Next
            EDIT = True
            Button4.Text = "Sa&ve"
        Else
            Dim sdMaster As New SdMaster()

            If EDIT Then
                upd.OpenCommand(rCN)
                MsgBox("Updated [" & upd.Execute("UPDATE SDMASTER SET " & _
                            "CBEMPNO='" & TextBox5.Text.ToUpper.Replace("'", "''") & "'" & _
                            ",ACCTSNAME='" & TextBox6.Text.ToUpper.Replace("'", "''") & "'" & _
                            ",ACCTPHONE1='" & TextBox9.Text.Replace("-", "").ToUpper.Replace("'", "''") & "'" & _
                            ",ACCTPHONE2='" & TextBox10.Text.Replace("-", "").ToUpper.Replace("'", "''") & "'" & _
                            ",ACCTADDR1='" & TextBox8.Text.ToUpper.Replace("'", "''") & "'" & _
                            ",ACCTADDR2='" & TextBox7.Text.ToUpper.Replace("'", "''") & "'" & _
                            " WHERE ACCTNO='" & TextBox4.Text.Replace("-", "") & "'") & "] record.", MsgBoxStyle.Information, "Member Maintenance")
                EorD(False)
                FillLV(ListView1, GetData(qryMem, "", DataGridView1), "0:109:77:548:0:0:0:0:102:0:0:0:0:0:0:0:0:0:0:0:0", "1:2:2:1:1:1:1:2:1:1:1:1:1:1:1:1:1:1:1:1:3", False)
                Button8.Visible = False
                Button4.Text = "E&dit"
            Else
                lblValidInitDep.Visible = False
                If CDbl(TextBox3.Text) > 0 Then
                    If isPageValid() Then
                        upd.OpenCommand(rCN)
                        upd2.OpenCommand(rCN)
                        accntno = NEWACCTNO()

                        qrey = "INSERT INTO [SDMASTER]([ACCTNO],[KBCI_NO],[CBEMPNO],[ACCTNAME],[ACCTADDR1],[ACCTADDR2],[ACCTSNAME]" & _
                                    ",[ACCTPHONE1],[ACCTPHONE2],[ACCTDTYPE],[ACCTCCODE],[ACCTICODE],[ACCTATX],[ACCTOTH1],[ACCTOTH2],[ACCTMAINT]" & _
                                    ",[ACCTIDEP],[ACCTPBAL],[ACCTLBAL],[ACCTOBAL],[ACCTABAL],[ACCTFLOATS],[ACCTTEX],[ACCTACLO],[ACCTWMIN]" & _
                                    ",[ACCTWSC],[ACCTWINT],[ACCTSTAT],[PLINE],[LLINE],[UNPOSTED],[HOLDOUT],[LSEQ],[ADD_DATE],[CHG_DATE]" & _
                                    ",[UPD_USER],[REC_STAT]) VALUES('" & accntno & "','" & TextBox2.Text.Replace("-", "").ToUpper & "','" & TextBox5.Text.ToUpper & _
                                    "','" & TextBox1.Text.ToUpper & "','" & TextBox8.Text.ToUpper & "','" & TextBox7.Text.ToUpper & "','" & TextBox6.Text.ToUpper & _
                                    "','" & TextBox9.Text.ToUpper & "','" & TextBox10.Text.ToUpper & "','','','','','',''," & CTRL_S.MINBAL & "," & CDbl(TextBox3.Text) & _
                                    ",0,0,0,0,0,'" & YoN(CheckBox1.Checked) & "','" & YoN(CheckBox2.Checked) & "','" & YoN(CheckBox3.Checked) & _
                                    "','" & YoN(CheckBox4.Checked) & "','" & YoN(CheckBox5.Checked) & "','A',0,0,0,0,0,'" & CTRL_S.SYSDATE & _
                                    "','" & CTRL_S.SYSDATE & "','','')"
                        MsgBox("Added [" & upd.Execute(CleanSTR(qrey)) & "] record/s to database. ", MsgBoxStyle.Information, "ACCOUNT NO: " & accntno)

                        qrey = String.Format("UPDATE MEMBERS SET FEBTC_SA = '{0}' WHERE KBCI_NO = '{1}'", accntno, TextBox2.Text.Replace("-", ""))
                        MsgBox("Updated [" & upd2.Execute(qrey) & "] record/s. ", MsgBoxStyle.Information, "KBCI NO: " & TextBox2.Text.Replace("-", ""))

                        SetDefBtn()
                        TextBox4.Text = Ckbacctno(accntno)
                        EorD(False)
                        FillLV(ListView1, GetData(qryMem, "", DataGridView1), "0:109:77:548:0:0:0:0:102:0:0:0:0:0:0:0:0:0:0:0:0", "1:2:2:1:1:1:1:2:1:1:1:1:1:1:1:1:1:1:1:1:3", False)
                        Button8.Visible = False
                        Button4.Text = "E&dit"
                        Dim msg = MsgBox("Would you like to add another account?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ADD ACCOUNT")
                        If msg = MsgBoxResult.Yes Then
                            Label19.Text = "A"
                            Button8.Visible = True
                            Set2ndBtn()
                            EorD(True)
                            EDIT = False
                            RESET()
                            Button4.Text = "Sa&ve"
                            GroupBox3.Visible = True
                        End If
                    End If
                Else
                    lblValidInitDep.Visible = True
                    MsgBox("Please type-in the Initial Deposit Amount.", MsgBoxStyle.Information, "NEW ACCOUNTS")
                End If
            End If
        End If
    End Sub
    Function YoN(ByVal swt As Boolean) As String
        If swt = True Then Return "Y" Else Return "N"
    End Function
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Label19.Text = "A"
        Button8.Visible = True
        Set2ndBtn()
        EorD(True)
        EDIT = False
        RESET()
        Button4.Text = "Sa&ve"
        TextBox2.Enabled = False
        GroupBox3.Visible = True
    End Sub

    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
        If IsNumeric(TextBox3.Text) Then TextBox3.Text = FormatNumber(TextBox3.Text, 2) Else MsgBox("Please input numeric characters", MsgBoxStyle.Information, "Invalid Amount") : TextBox3.Text = "0.00"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Using MemberSearchForm As New MemberSearchDialog
            If MemberSearchForm.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Label16.Text = Ckbacctno(SEL_KBCI_NO)
            End If
        End Using
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Using MemberSearchForm As New MemberSearchDialog
            If MemberSearchForm.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Label17.Text = Ckbacctno(SEL_KBCI_NO)
            End If
        End Using
    End Sub


    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If srchSTR <> "" Then
            FillLV(ListView1, GetData(qryMem, ffield & " like '%" & srchstr & "%'", DataGridView1), "0:109:77:548:0:0:0:0:102:0:0:0:0:0:0:0:0:0:0:0:0", "1:2:2:1:1:1:1:2:1:1:1:1:1:1:1:1:1:1:1:1:3", False)
        Else
            FillLV(ListView1, GetData(qryMem, "", DataGridView1), "0:109:77:548:0:0:0:0:102:0:0:0:0:0:0:0:0:0:0:0:0", "1:2:2:1:1:1:1:2:1:1:1:1:1:1:1:1:1:1:1:1:3", False)
        End If
    End Sub

    Private Sub TextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
        ffield = "NAME" : srchstr = TextBox1.Text.Trim
        Me.AcceptButton = Button10
    End Sub
    Private Sub TextBox2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyUp
        ffield = "kbci_no" : srchstr = TextBox2.Text.Trim
        Me.AcceptButton = Button10
    End Sub
    Private Sub TextBox4_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox4.KeyUp
        ffield = "ACCT_NO" : srchstr = TextBox4.Text.Trim
        Me.AcceptButton = Button10
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim msg As String
        Dim UP As New CLTF.DB.SQLDBConnection
        If Convert.ToDecimal(ListView1.Items(ListView1.SelectedIndices(0)).SubItems(20).Text.Trim) > 0 Then
            MsgBox("This account has an outstanding balance, kindly settle it first before closing the account.", MsgBoxStyle.Information, "ACCOUNT CLOSURE")
        Else
            msg = MsgBox("Would you like to close this account?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ACCOUNT CLOSURE")
            If msg = vbYes Then
                UP.OpenCommand(rCN)
                MsgBox("UPDATED [" & UP.Execute("UPDATE SDMASTER SET ACCTSTAT='C' WHERE ACCTNO='" & TextBox4.Text.Trim.Replace("-", "") & "'") & "] Record.", MsgBoxStyle.Information, "ACCOUNT CLOSURE")
                FillLV(ListView1, GetData(qryMem, "", DataGridView1), "0:109:77:548:0:0:0:0:102:0:0:0:0:0:0:0:0:0:0:0:0", "1:2:2:1:1:1:1:2:1:1:1:1:1:1:1:1:1:1:1:1:1", False)
            End If
        End If

    End Sub
    Private Sub frmSDS_Main_Memlist_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Not closeform Then e.Cancel = True
    End Sub
    Private Sub SetDefBtn()
        Me.AcceptButton = Button2
        Me.CancelButton = Button1
    End Sub
    Private Sub Set2ndBtn()
        Me.AcceptButton = Button4
        Me.CancelButton = Button5
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Button2_Click(Button2, MouseEventArgs.Empty)
    End Sub

    Private Sub btnReactivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReactivate.Click
        Dim upd As New CLTF.DB.SQLDBConnection
        Dim index = ListView1.SelectedItems(0).Index
        Dim msg = MsgBox("Would you like to reactivate this account?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Reactivate Account")
        If msg = vbYes Then
            upd.OpenCommand(rCN)
            MsgBox("Updated [" & upd.Execute("UPDATE SDMASTER SET " & _
                            "ACCTSTAT='A'" & _
                            " WHERE ACCTNO='" & ListView1.Items(ListView1.SelectedIndices(0)).SubItems(1).Text & "'") & "] record.", MsgBoxStyle.Information, "Member Maintenance")                        
            Initialize()
            ListView1.Items(index).Selected = True
            LoadData()
        End If
    End Sub

    Private Function isPageValid() As Boolean
        lblValidSName.Visible = False
        If Trim(TextBox6.Text) = String.Empty Then
            lblValidSName.Visible = True
            MsgBox("Please fill out all required fields.", MsgBoxStyle.Critical, "Invalid Entry")
            Return False
        End If
        Return True
    End Function
End Class