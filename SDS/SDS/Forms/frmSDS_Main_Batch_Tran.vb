Public Class frmSDS_Main_Batch_Tran

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
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
                Select Case ComboBox2.SelectedIndex
                    Case 0
                        CHKCODE = "OUS"
                    Case 1
                        CHKCODE = "LOC"
                    Case 2
                        CHKCODE = "REG"
                End Select
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
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim msg As String = ""
        Dim msg2 As String = ""
        Dim CLSACCT As Boolean = False
        Dim TCRED, TDEB, AABAL As Decimal
        Try
            msg2 = MsgBox("Post this transaction.", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Transaction")
            If msg2 = vbNo Then Exit Sub
            If TextBox7.Enabled = True And TextBox8.Enabled = True And (TextBox7.Text.Trim = "" Or TextBox8.Text.Trim = "") Then MsgBox("Please fill-out all fields") : Exit Sub
            If CDbl(TextBox5.Text) < 1 Then MsgBox("Please, input correct amount.") : Exit Sub
            If ComboBox1.Text.Trim = "" Then MsgBox("Please select a transaction type") : Exit Sub
            If TRANCODE = "NLD" And ComboBox2.Text.Trim = "" Then MsgBox("Please select a check-type.") : Exit Sub
            TCRED = 0 : TDEB = 0 : AABAL = HOLDOUT + ACCTABAL : CHKCDAYS = 0 : CHKCDATE = ""
            USROVRIDE = ""

            If TRANCODE = "WD" Or TRANCODE = "NWD" Or TRANCODE = "DM" Then
                TDEB = CDbl(TextBox5.Text)
                If TDEB <= AABAL Then
                    If TDEB = AABAL Then
                        msg = MsgBox("Warning: After Batch Posting this account will be on Zero-Balance, Would you like to continue on posting this entry?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "CLOSE ACCOUNT")
                        If vbNo Then Exit Sub
                    Else
                        If TDEB > (AABAL + LHOLDOUT) Then MsgBox("Posting this entry will result to over-withdrawal. " & vbCrLf & "  LOAN-HOLDOUT:[" & FormatNumber(LHOLDOUT, 2) & "]. Please inquire on Loans.", MsgBoxStyle.Critical, "Insufficient Funds") : Exit Sub
                    End If
                Else
                    MsgBox("Posting this entry will result to over-withdrawal.", MsgBoxStyle.Critical, "Insufficient funds") : Exit Sub
                End If
            Else
                TCRED = CDbl(TextBox5.Text)
            End If
            LSEQ += 1
            If LSEQ > 999 Then LSEQ = 1
            TRANEBAL = CDbl((ACCTOBAL + (TCRED - TDEB)))
            rExec("INSERT INTO [SDTRANB]([ACCTNUM],[TRANDATE],[TRANSEQ],[TRANCODE],[TRANBBAL],[TRANDEB],[TRANCRE],[TRANEBAL],[CHKNUM],[CHKBANK],[CHKCODE],[ADD_DATE],[ADD_TIME],[USER],[OVERRIDE],[PPOSTED],[LPOSTED],[TRANOLD],[REVERSED]) " & _
                                         "Values('" & ACCTNUM.Trim & "','" & CTRL_S.SYSDATE & "'," & LSEQ & ",'" & TRANCODE & "'," & CDbl(ACCTOBAL) & "," & CDbl(TDEB) & "," & CDbl(TCRED) & "," & TRANEBAL & ",'" & TextBox8.Text.Trim.ToUpper & "'," & _
                                                  "'" & TextBox7.Text.Trim.ToUpper & "','" & CHKCODE.ToUpper & "','" & CTRL_S.SYSDATE & "','" & Format(TimeOfDay, "HH:mm:ss") & "','" & SPUSER.SPUSERID.Trim.ToUpper & "','" & USROVRIDE & "',0,0,1,0)")
            SW = True
            Me.Dispose()
        Catch ex As Exception
            SW = False
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmSDS_Main_Batch_Tran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label9.Text = FormatNumber(CTRL_S.MINBAL, 2)
        Label10.Text = FormatNumber(HOLDOUT, 2)
        Label11.Text = FormatNumber(LHOLDOUT, 2)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SW = False
        Me.Dispose()
    End Sub
End Class