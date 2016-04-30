Public Class frmSDS_Main_TEntry_Tran
    Private Sub frmSDS_Main_TEntry_Tran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label9.Text = (FormatNumber(CTRL_S.MINBAL, 2))
        Label10.Text = (FormatNumber(HOLDOUT, 2))
        Label11.Text = (FormatNumber(LHOLDOUT, 2))
        ComboBox2.Focus()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Label3.Visible = False : ComboBox2.Visible = False
            Select Case ComboBox1.SelectedIndex
                Case 0
                    TRANCODE = "CSD"
                Case 1
                    TRANCODE = "NCD"
                Case 2
                    TRANCODE = "WD"
                Case 3
                    TRANCODE = "NWD"
                Case 4
                    TRANCODE = "OUS"
                    CHKCODE = "OUS"
                Case 5
                    TRANCODE = "NLD"
                    Label3.Visible = True : ComboBox2.Visible = True
                Case 6
                    TRANCODE = "LCD"
                    CHKCODE = "LOC"
                Case 7
                    TRANCODE = "DM"
                Case 8
                    TRANCODE = "CM"
            End Select
            TextBox7.Text = "" : TextBox8.Text = "" : TextBox5.Text = "0.00"
            If ComboBox1.SelectedIndex > 3 And ComboBox1.SelectedIndex < 7 Then
                TextBox7.Enabled = True : TextBox8.Enabled = True
            Else
                TextBox7.Enabled = False : TextBox8.Enabled = False
                CHKCODE = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub TextBox5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.LostFocus
        If IsNumeric(TextBox5.Text) Then TextBox5.Text = FormatNumber(TextBox5.Text, 2) Else MsgBox("Please input numeric characters", MsgBoxStyle.Information, "Invalid Amount") : TextBox5.Text = "0.00"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim msg As String = ""
        Dim msg2 As String = ""
        Dim CLSACCT As Boolean = False
        Dim TCRED, TDEB, AABAL As Decimal
        Try

            msg2 = MsgBox("Post this transaction.", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Transaction")
            If msg2 = vbNo Then Exit Sub
            TCRED = 0 : TDEB = 0 : AABAL = HOLDOUT + ACCTABAL : CHKCDAYS = 0 : CHKCDATE = ""
            USROVRIDE = ""
            If TextBox7.Enabled = True And TextBox8.Enabled = True And (TextBox7.Text.Trim = "" Or TextBox8.Text.Trim = "") Then MsgBox("Please fill-out all fields") : Exit Sub
            If Not CDbl(TextBox5.Text) > 0 Then MsgBox("Please, input correct amount.") : Exit Sub
            If ComboBox1.Text.Trim = "" Then MsgBox("Please select a transaction type") : Exit Sub
            If TRANCODE = "NLD" And ComboBox2.Text.Trim = "" Then MsgBox("Please select a check-type.") : Exit Sub

            If TRANCODE = "WD" Or TRANCODE = "NWD" Or TRANCODE = "DM" Then
                TDEB = CDbl(TextBox5.Text)
                If TDEB <= AABAL Then

                    If TDEB = AABAL Then
                        msg = MsgBox("Would you like to close this account?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "CLOSE ACCOUNT")
                        If msg = vbYes Then
                            If ACCTFLOATS < 1 Then
                                If CInt(SPUSER.SPUSERPOS) <> 3 Then
                                    USROVRIDE = SPUSER.USER
                                Else
                                    USROVRIDE = OVRRIDE()
                                End If
                                If USROVRIDE = "" Then Exit Sub Else MsgBox("Account is tagged closed!") : CLSACCT = True
                            Else
                                MsgBox("ERROR: Account still has floats") : Exit Sub
                            End If
                        Else
                            Exit Sub
                        End If
                    ElseIf (AABAL - TDEB) < CTRL_S.MINBAL Then
                        MsgBox("Insufficient Funds. THe balance after withdrawal will be less than the minimum balance required.") : Exit Sub
                    Else
                        If TDEB > (AABAL + LHOLDOUT) Then MsgBox("Insufficient Funds Hold [" & FormatNumber(LHOLDOUT, 2) & "] Pls inquire on Loans.") : Exit Sub
                    End If
                Else
                    MsgBox("Insufficient funds.") : Exit Sub
                End If
            Else
                TCRED = CDbl(TextBox5.Text)
            End If
            LSEQ += 1
            If LSEQ > 999 Then LSEQ = 1
            TRANEBAL = (ACCTOBAL + (TCRED - TDEB))
            rExec("INSERT INTO [SDTRAN]([ACCTNUM],[TRANDATE],[TRANSEQ],[TRANCODE],[TRANBBAL],[TRANDEB],[TRANCRE],[TRANEBAL],[CHKNUM],[CHKBANK],[CHKCODE],[ADD_DATE],[ADD_TIME],[USER],[OVERRIDE],[PPOSTED],[LPOSTED],[TRANOLD],[REVERSED]) " & _
                                         "Values('" & ACCTNUM.Trim & "','" & CTRL_S.SYSDATE & "'," & LSEQ & ",'" & TRANCODE & "'," & ACCTOBAL & "," & TDEB & "," & TCRED & "," & TRANEBAL & ",'" & TextBox8.Text.Trim.ToUpper & "'," & _
                                                  "'" & TextBox7.Text.Trim.ToUpper & "','" & CHKCODE.ToUpper & "','" & CTRL_S.SYSDATE & "','" & Format(TimeOfDay, "HH:mm:ss") & "','" & SPUSER.SPUSERID.Trim.ToUpper & "','" & USROVRIDE & "',0,0,1,0)")

            If TRANCODE = "LCD" Or TRANCODE = "NLD" Or TRANCODE = "OUS" Then
                CHKAMT = TCRED + TDEB
                Select Case CHKCODE.Trim.ToUpper
                    Case "OUS"
                        CHKCDAYS = GetRStr("SELECT CLR_ONUS AS CDAY FROM CTRL_S", "CDAY", 0)
                    Case "LOC"
                        CHKCDAYS = GetRStr("SELECT CLR_LOCAL AS CDAY FROM CTRL_S", "CDAY", 0)
                    Case "REG"
                        CHKCDAYS = GetRStr("SELECT CLR_REG AS CDAY FROM CTRL_S", "CDAY", 0)
                End Select
                CHKNDAYS = CInt(CHKCDAYS) - 1
                If CHKNDAYS <= 0 Then
                    CHKCDATE = CTRL_S.SYSDATE
                Else
                    ACCTFLOATS = ACCTFLOATS + CHKAMT
                    CHKCDATE = DateAdd(DateInterval.Day, CDbl(CHKNDAYS), CTRL_S.SYSDATE)
                End If

            End If
            If TRANCODE = "LCD" Or TRANCODE = "NLD" Or TRANCODE = "OUS" Then
                DBG = "INSERT INTO [SDCHECK]([ACCTNUM],[TRANDATE],[TRANSEQ],[CHKCODE],[CHKAMT],[CHKNUM],[CHKBANK]," & _
                                            "[CHKCDATE],[CHKCDAYS],[CHKNDAYS],[CHKSTAT],[ADD_DATE],[ADD_TIME],[USER]) " & _
                                     "VALUES('" & ACCTNUM & "','" & CTRL_S.SYSDATE & "'," & LSEQ & ",'" & CHKCODE & "'," & _
                                                  CDbl(TextBox5.Text.Trim) & ",'" & TextBox8.Text.Trim.ToUpper & _
                                          "','" & TextBox7.Text.Trim.ToUpper & "','" & CHKCDATE & "'," & CHKCDAYS & "," & CHKNDAYS & _
                                        ",'','" & CTRL_S.SYSDATE & "','" & Format(TimeOfDay, "HH:mm:ss") & "','" & SPUSER.SPUSERID & "')"
                rExec("INSERT INTO [SDCHECK]([ACCTNUM],[TRANDATE],[TRANSEQ],[CHKCODE],[CHKAMT],[CHKNUM],[CHKBANK]," & _
                            "[CHKCDATE],[CHKCDAYS],[CHKNDAYS],[CHKSTAT],[ADD_DATE],[ADD_TIME],[USER]) " & _
                     "VALUES('" & ACCTNUM & "','" & CTRL_S.SYSDATE & "'," & LSEQ & ",'" & CHKCODE & "'," & _
                                  CDbl(TextBox5.Text.Trim) & ",'" & TextBox8.Text.Trim.ToUpper & _
                          "','" & TextBox7.Text.Trim.ToUpper & "','" & CHKCDATE & "'," & CHKCDAYS & "," & CHKNDAYS & _
                        ",'','" & CTRL_S.SYSDATE & "','" & Format(TimeOfDay, "HH:mm:ss") & "','" & SPUSER.SPUSERID & "')")
            End If

            If CLSACCT Then ACCTSTAT = "C"

            ACCTOBAL = (ACCTOBAL + (TCRED - TDEB))
            rExec("UPDATE SDMASTER SET LTRANDATE='" & CTRL_S.SYSDATE & "', ACCTOBAL=" & ACCTOBAL & ",ACCTABAL=" & ACCTOBAL - ACCTFLOATS & _
                  ",ACCTLBAL=" & ACCTOBAL & ",ACCTFLOATS=" & ACCTFLOATS & ",ACCTSTAT='" & ACCTSTAT & "',LSEQ=" & LSEQ & " WHERE ACCTNO='" & ACCTNUM & "'")

            If TRANCODE <> "DM" And TRANCODE <> "CM" Then MsgBox("Insert form in printer for validation.", MsgBoxStyle.Exclamation, "Transaction Validation") : PrtValid()

            SW = True
            Me.Dispose()
        Catch ex As Exception
            SW = False
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SW = False
        Me.Dispose()
    End Sub
    Sub PrtValid()
        Try
            Dim printStr As String = ""
            Dim ValdForm As New System.Drawing.Printing.PaperSize("ValidForm", 660, 250)
            printStr = AddLine(13) & Chr(27) & Chr(77) & Chr(15) & "     " & Business.FormatSDAcctNo(ACCTNUM) & "  " & _
                       TRANCODE.PadRight(2, " ") & "***" & FormatNumber(TextBox5.Text, 2) & "***  Bal.:***" & FormatNumber(TRANEBAL, 2) & "***" & _
                       vbCrLf & "Posted by: " & SPUSER.SPUSERID.ToUpper & " (" & CTRL_S.SYSDATE & " " & TimeValue(Now) & ")" & Chr(12)
            'Dim prtOBJ As New TextPrint(printStr, DEFPRINTER, ValdForm)
            'prtOBJ.Print()
            'prtOBJ.Dispose()
            RawPrinter.SendStringToPrinter(DEFPRINTER, printStr)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "," Or e.KeyChar = ChrW(8) Then e.Handled = False Else e.Handled = True
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.SelectedIndex
            Case 0
                CHKCODE = "OUS"
            Case 1
                CHKCODE = "LOC"
            Case 2
                CHKCODE = "REG"
        End Select
    End Sub
End Class