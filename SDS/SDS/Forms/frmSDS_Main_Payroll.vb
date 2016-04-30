Imports SDS.Entities.SDS.Entities
Public Class frmSDS_Main_Payroll
    Dim DATE7 As String
    Dim C7Amt As Decimal
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Dim rcnt As Integer
        If CheckBox2.Checked = True Then GroupBox3.Enabled = True Else GroupBox3.Enabled = False
        Dim msg As String
        If CheckBox2.Checked = True Then
            rcnt = CInt(GetRStr("SELECT COUNT(PN_NO) AS CNT FROM EXTRACT WITH (NOLOCK) WHERE STATUS='1'", "CNT", 0))
            If rcnt > 0 Then
                msg = MsgBox("[[ IMPORTANT ]]" & vbCrLf & "    This will process payroll advance payments for the month." & vbCrLf & _
                             "Please make sure all users are logged-off and execute back-up" & vbCrLf & "before executing this option.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Advance Payment Processing")
                If msg = vbCancel Then TextBox2.Text = "" : CheckBox2.Checked = False
            Else
                CheckBox2.CheckState = CheckState.Unchecked
                MsgBox("No items to post for this batch.", MsgBoxStyle.Information, "Advance Payment Processing")
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Dim LPAmt As Decimal
        Dim msg, LPDate, lcnstr As String
        If CheckBox1.Checked = True Then GroupBox2.Enabled = True Else GroupBox2.Enabled = False
        If CheckBox1.Checked = True Then
            If CInt(GetRStr("SELECT COUNT(EMPNO1)AS CNT FROM EXTKBC", "CNT", 0)) > 0 Then
                C7Amt = CDbl(GetRStr("SELECT SUM(amt7c) as AMT FROM EXTKBC", "AMT", 0))
                LPAmt = CDbl(GetRStr("SELECT LPAMT FROM PARAM_S", "LPAMT", 0))
                DATE7 = GetRStr("SELECT TOP 1 DATE7 FROM EXTKBC ORDER BY DATE7", "DATE7", 0)
                LPDate = CInt(GetRStr("SELECT LPDATE FROM PARAM_S WITH (NOLOCK) ", "LPDATE", 0))
                If C7Amt = LPAmt And Format(DateValue(DATE7), "yyyyMMdd") = LPDate Then MsgBox("This batch was already processed.", MsgBoxStyle.Critical, "Payroll Processing") : CheckBox1.Checked = False : Exit Sub
                msg = MsgBox("[[ IMPORTANT ]]" & vbCrLf & "      This will process  Payroll Transactions for the  month." & vbCrLf & _
                             "Please make sure all users are logged-off and execute back-up" & vbCrLf & "before executing this option.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Payroll Processing")
                If msg = vbCancel Then CheckBox1.Checked = False
            Else
                CheckBox1.CheckState = CheckState.Unchecked
                MsgBox("No items to post for this batch.", MsgBoxStyle.Information, "Payroll Processing")
            End If

        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim LPAmt As Decimal
        Dim DBF, msg, LPDate, lcnstr As String
        If openFile("Payroll File (EXTKBC.DBF) |*.DBF", TextBox1) Then
            DBF = Path.GetFileName(TextBox1.Text).Replace(Path.GetExtension(TextBox1.Text), "")
            'lcnstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Path.GetDirectoryName(TextBox1.Text) & "\;Extended Properties=dBASE 5.0"
            lcnstr = "Provider=VFPOLEDB.1;Data Source=" & Path.GetDirectoryName(TextBox1.Text)

            If CInt(GetLStr("SELECT COUNT(EMPNO1)AS CNT FROM " & DBF & "", "CNT", 0, lcnstr)) > 0 Then
                C7Amt = CDbl(GetLStr("SELECT SUM(amt7c) as AMT FROM " & DBF, "AMT", 0, lcnstr))
                LPAmt = CDbl(GetRStr("SELECT LPAMT FROM PARAM_S", "LPAMT", 0))
                DATE7 = GetLStr("SELECT TOP 1 DATE7 FROM " & DBF & " ORDER BY DATE7", "DATE7", 0, lcnstr)
                LPDate = CInt(GetRStr("SELECT LPDATE FROM PARAM_S WITH (NOLOCK) ", "LPDATE", 0))
                If C7Amt = LPAmt And Format(DateValue(DATE7), "yyyyMMdd") = LPDate Then MsgBox("This batch was already processed.", MsgBoxStyle.Critical, "Payroll Processing") : TextBox1.Text = "" : Exit Sub
                msg = MsgBox("[[ IMPORTANT ]]" & vbCrLf & "      This will process  Payroll Transactions for the  month." & vbCrLf & _
                             "Please make sure all users are logged-off and execute back-up" & vbCrLf & "before executing this option.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Payroll Processing")
                If msg = vbCancel Then TextBox1.Text = "" : CheckBox1.Checked = False
            Else
                TextBox1.Text = ""
                MsgBox("No items to post for this batch.", MsgBoxStyle.Information, "Payroll Processing")
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

    Private Sub frmSDS_Main_Payroll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox3.Text = GetConfig("SV").ToUpper
        TextBox2.Text = GetConfig("SV").ToUpper
        TextBox1.Text = GetConfig("SV").ToUpper
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Dispose()
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        Dim msg As String
        If CheckBox3.Checked = True Then
            If CInt(GetRStr("SELECT COUNT(ACCTNO) CNT FROM LNHOLD WITH (NOLOCK) WHERE HOLDDATE='" & CTRL_S.SYSDATE & "' AND (POSTSTAT='' OR POSTSTAT IS NULL)", "CNT", 0)) > 0 Then
                msg = MsgBox("[[ IMPORTANT ]]" & vbCrLf & "    This will process loan onhold transactions for the day." & vbCrLf & _
                             "Please make sure all users are logged-off and execute back-up" & vbCrLf & "before executing this option.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Advance Payment Processing")
                If msg = vbCancel Then CheckBox3.Checked = False
            Else
                CheckBox3.CheckState = CheckState.Unchecked
                MsgBox("No items to post for this batch.", MsgBoxStyle.Information, "Loan Hold Processing")
            End If
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Label4.Visible = True
        Button6.Enabled = False
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim cnn As New SqlConnection(rCN)
        Dim param_date(3) As String
        'Dim sqlCMD As SqlCommand
        Dim x As Integer
        'Dim qString As String
        SW = False
        If CheckBox1.Checked = True And Not TextBox1.Text.Trim = "" Then
            SW = True
            'Label4.Visible = True : Label4.Text = "Processing Payroll..." : Application.DoEvents()
            'GetLocData("SELECT EMPNO1,ACTYPE,ACTCD1,ACTCD2,DATE7,AMT7C,CODE5 FROM EXTKBC ", "", DataGridView1, "Provider=VFPOLEDB.1;Data Source=" & Path.GetDirectoryName(TextBox1.Text))
            param_date = DateValue(DATE7).ToString().Split(" ")
            param_date = param_date(0).Split("/")
            rExec("UPDATE PARAM_S SET LPDATE=" & param_date(2) & param_date(0).PadLeft(2, "0") & param_date(1).PadLeft(2, "0") & ",LPPOST='" & CTRL_S.SYSDATE & "',LPAMT=" & C7Amt)
            rExec("TRUNCATE TABLE SDPAY")
            'cnn.Open()
            'With DataGridView1
            '    For x = 0 To .RowCount - 1
            '        qString = "INSERT INTO SDPAY(EMPNO1,ACTYPE,ACTCD1,ACTCD2,DATE7,AMT7C, CODE5) " & _
            '                  "VALUES(" & CInt(.Rows(x).Cells("EMPNO1").Value) & "," & CInt(.Rows(x).Cells("ACTYPE").Value) & "," & CInt(.Rows(x).Cells("ACTCD1").Value) & "," & _
            '                              CInt(.Rows(x).Cells("ACTCD2").Value) & ",CAST('" & Mid(.Rows(x).Cells("DATE7").Value, 1, 8) & "' AS DATETIME)," & .Rows(x).Cells("AMT7C").Value & "," & _
            '                              CInt(.Rows(x).Cells("CODE5").Value) & ")"

            '        sqlCMD = New SqlCommand(qString, cnn)
            '        sqlCMD.ExecuteNonQuery()
            '        'sqlCMD.Dispose()
            '    Next
            'End With
            rExec("INSERT INTO SDPAY(EMPNO1,ACTYPE,ACTCD1,ACTCD2,DATE7,AMT7C, CODE5) " & _
                  "SELECT EMPNO1,ACTYPE,ACTCD1,ACTCD2,DATE7,AMT7C,CODE5 FROM EXTKBC ")
            rExec("TRUNCATE TABLE SDPOST")
            rExec("INSERT INTO SDPOST(ACCTNO,KBCI_NO,SDNAME,CBEMPNO,TDATE,PAMT,SDSEQ,SDTIME,SDBBAL,SDEBAL) " & _
                  "SELECT SM.ACCTNO,SM.KBCI_NO,SM.ACCTNAME,SM.CBEMPNO,SP.DATE7 TDATE,SP.AMT7C PAMT," & _
                  "(CASE WHEN SM.LSEQ+1 < 1000 THEN SM.LSEQ+1 ELSE 1 END) SDSEQ,'" & Format(TimeOfDay, "HH:mm:ss") & "' SDTIME,SM.ACCTOBAL SDBBAL, " & _
                  "(SP.AMT7C+SM.ACCTOBAL) SDEBAL FROM SDPAY SP WITH (NOLOCK) LEFT JOIN  SDMASTER SM WITH (NOLOCK) ON RIGHT('00000'+CAST(SP.EMPNO1 AS VARCHAR),6) = SM.CBEMPNO AND SM.ACCTSTAT='A' " & _
                  " WHERE SP.ACTCD2=7635")

            rExec("INSERT INTO SDTRAN(ACCTNUM,TRANDATE,TRANSEQ,TRANCODE,TRANBBAL,TRANDEB,TRANCRE,TRANEBAL,CHKNUM,CHKBANK,CHKCODE,ADD_DATE,ADD_TIME,[USER],OVERRIDE,PPOSTED,LPOSTED,TRANOLD,REVERSED) " & _
                  "SELECT SM.ACCTNO,'" & CTRL_S.SYSDATE & "',CASE WHEN SM.LSEQ+1 < 1000 THEN SM.LSEQ+1 ELSE 1 END,'CM',SM.ACCTOBAL,'0.00'," & _
                  "SP.AMT7C,SP.AMT7C+SM.ACCTOBAL,'PAYROLL','','',SP.DATE7,'" & Format(TimeOfDay, "HH:mm:ss") & "','" & SPUSER.SPUSERID & "','',0,0,0,0 " & _
                  "FROM SDPAY SP WITH (NOLOCK) LEFT JOIN  SDMASTER SM WITH (NOLOCK) ON RIGHT('00000'+CAST(SP.EMPNO1 AS VARCHAR),6) = SM.CBEMPNO AND SM.ACCTSTAT='A' WHERE SP.ACTCD2=7635")

            rExec("UPDATE  SDMASTER SET  SDMASTER.ACCTOBAL=SP.SDEBAL, SDMASTER.ACCTABAL=(SP.SDEBAL-SDMASTER.ACCTFLOATS),SDMASTER.LSEQ=SP.SDSEQ " & _
                  "FROM (SELECT ACCTNO,SDSEQ,SDEBAL FROM SDPOST WITH (NOLOCK)) AS SP WHERE SDMASTER.ACCTNO=SP.ACCTNO")
        End If

        If CheckBox2.Checked = True Then
            SW = True

            Dim dtExtract As New DataTable
            Dim dtSDTRAN As New DataTable
            Dim dtSDMASTER As New DataTable


            dtExtract = GetData("SELECT PN_NO,KBCI_NO,LOAN_TYPE,ADD_DATE,CHG_DATE,USER AS USERNAME,AMOUNT,REMARKS,SAVINGS,ACCTNO,STATUS,EXSEQ,EXTIME,EXBBAL,EXEBAL FROM EXTRACT WHERE STATUS='1'", "")
            dtSDMASTER = GetData("SELECT ACCTNO,LSEQ,ACCTOBAL,ACCTFLOATS,ACCTSTAT from SDMASTER where ACCTNO IN (SELECT ACCTNO FROM EXTRACT)", "")
            cnn.Open()
            For Each dtRow As DataRow In dtExtract.Rows                
                Dim qryStr As String
                Dim sqlCMD As SqlCommand
                Dim chkNum As String
                Dim tranSeq As Integer
                Dim sdmRow As DataRow = dtSDMASTER.Select("ACCTNO = '" & dtRow("ACCTNO") & "'").FirstOrDefault()

                If dtRow("PN_NO") = "" Then chkNum = "ADV-NO LOAN" Else chkNum = "ADV-" & dtRow("PN_NO")
                If Integer.Parse(sdmRow("LSEQ")) + 1 < 1000 Then tranSeq = Integer.Parse(sdmRow("LSEQ")) + 1 Else tranSeq = 1

                'If dtRow("ACCTNO") = "0101047150" Then
                '    Dim xx As String
                '    xx = ""
                'End If


                qryStr = "INSERT INTO SDTRAN VALUES(" & _
                          "'" & dtRow("ACCTNO") & "'" & _
                         ",'" & CTRL_S.SYSDATE & "'" & _
                         "," & tranSeq & _
                         ",'CM'" & _
                         "," & Decimal.Parse(sdmRow("ACCTOBAL")) & _
                         ",0" & _
                         "," & Decimal.Parse(dtRow("AMOUNT")) & _
                         "," & Decimal.Parse(sdmRow("ACCTOBAL")) + Decimal.Parse(dtRow("AMOUNT")) & _
                         ",'" & chkNum & "'" & _
                         ",'',''" & _
                         ",'" & CTRL_S.SYSDATE & "'" & _
                         ",'" & Format(TimeOfDay, "HH:mm:ss") & "'" & _
                         ",'" & SPUSER.USER & "'" & _
                         ",'',0,0,0,0)"
                sdmRow.Item("LSEQ") = tranSeq
                sdmRow.Item("ACCTOBAL") = Decimal.Parse(sdmRow("ACCTOBAL")) + Decimal.Parse(dtRow("AMOUNT"))

                'dtRow.Item("EXSEQ") = tranSeq
                'dtRow.Item("EXTIME") = Format(TimeOfDay, "HH:mm:ss")
                'dtRow.Item("EXBBAL") = Decimal.Parse(sdmRow("ACCTOBAL"))
                'dtRow.Item("EXEBAL") = Decimal.Parse(sdmRow("ACCTOBAL")) + Decimal.Parse(dtRow("AMOUNT"

                dtSDMASTER.AcceptChanges()

                sqlCMD = New SqlCommand(qryStr, cnn)
                sqlCMD.ExecuteNonQuery()
                sqlCMD.Dispose()
            Next
            For Each dtRow As DataRow In dtSDMASTER.Rows
                Dim qryStr As String
                Dim sqlCMD As SqlCommand
                Dim AcctStat As String = dtRow("ACCTSTAT")
                If dtRow("ACCTSTAT") = "C" Then AcctStat = "A"

                qryStr = "UPDATE SDMASTER SET " & _
                         "ACCTOBAL=" & Decimal.Parse(dtRow("ACCTOBAL")) & _
                         ",ACCTABAL=" & Decimal.Parse(dtRow("ACCTOBAL")) - Decimal.Parse(dtRow("ACCTFLOATS")) & _
                         ",LSEQ=" & Integer.Parse(dtRow("LSEQ")) & _
                         ",ACCTSTAT='" & AcctStat & "'" & _
                         "WHERE ACCTNO = '" & dtRow("ACCTNO") & "'"
                sqlCMD = New SqlCommand(qryStr, cnn)
                sqlCMD.ExecuteNonQuery()
                sqlCMD.Dispose()
            Next
            cnn.Close()

            'rExec("UPDATE EXTRACT SET EXSEQ=SP.LSEQ, EXTIME= SP.EXTIME,EXBBAL = SP.ACCTOBAL, EXEBAL = SP.ACCTOBAL + AMOUNT " & _
            '      "FROM (SELECT SM.ACCTNO,(SM.ACCTOBAL) ACCTOBAL,(CASE WHEN SM.LSEQ+1 < 1000 THEN SM.LSEQ+1 ELSE 1 END) LSEQ, '" & Format(TimeOfDay, "HH:mm:ss") & "' EXTIME " & _
            '      "FROM EXTRACT EX WITH (NOLOCK) LEFT JOIN SDMASTER SM WITH (NOLOCK) ON SM.ACCTNO=EX.ACCTNO WHERE EX.STATUS='1') SP WHERE SP.ACCTNO = EXTRACT.ACCTNO")
            '"FROM (SELECT SM.ACCTNO,(SM.ACCTOBAL+EX.AMOUNT) ACCTOBAL,(CASE WHEN SM.LSEQ+1 < 1000 THEN SM.LSEQ+1 ELSE 1 END) LSEQ, '" & Format(TimeOfDay, "HH:mm:ss") & "' EXTIME " & _

            rExec("UPDATE ADVANCE SET STATUS='2' FROM (SELECT EX.KBCI_NO,EX.LOAN_TYPE,EX.ADD_DATE " & _
                  "FROM EXTRACT EX WITH (NOLOCK) WHERE EX.STATUS='1') EX WHERE ADVANCE.KBCI_NO=EX.KBCI_NO and " & _
                  " EX.LOAN_TYPE=ADVANCE.LOAN_TYPE and EX.ADD_DATE=ADVANCE.ADD_DATE")
            rExec("UPDATE EXTRACT SET STATUS='2' WHERE  STATUS='1'")

        End If

        If CheckBox3.Checked = True Then
            SW = True
            Dim dtLoanHold As New DataTable
            Dim dtSDTRAN As New DataTable
            Dim dtSDMASTER As New DataTable


            dtLoanHold = GetData("SELECT * FROM LNHOLD WITH (NOLOCK) WHERE HOLDDATE='" & CTRL_S.SYSDATE & "' AND (POSTSTAT='' OR POSTSTAT IS NULL)", "")
            dtSDMASTER = GetData("SELECT ACCTNO,LSEQ,ACCTOBAL,ACCTFLOATS,ACCTSTAT from SDMASTER where ACCTNO IN (SELECT ACCTNO FROM LNHOLD WITH (NOLOCK) WHERE HOLDDATE='" & CTRL_S.SYSDATE & "' AND (POSTSTAT='' OR POSTSTAT IS NULL))", "")
            cnn.Open()
            For Each dtRow As DataRow In dtLoanHold.Rows
                Dim qryStr As String
                Dim sqlCMD As SqlCommand
                Dim holdType As String
                Dim tranSeq As Integer
                Dim tranCred As Decimal = 0
                Dim tranDeb As Decimal = 0
                Dim tranEndBal As Decimal = 0
                Dim sdmRow As DataRow = dtSDMASTER.Select("ACCTNO = '" & dtRow("ACCTNO") & "'").FirstOrDefault()

                If sdmRow("ACCTSTAT") = "C" Then Continue For

                If Integer.Parse(sdmRow("LSEQ")) + 1 < 1000 Then tranSeq = Integer.Parse(sdmRow("LSEQ")) + 1 Else tranSeq = 1

                'If dtRow("ACCTNO") = "0101047150" Then
                '    Dim xx As String
                '    xx = ""
                'End If

                If dtRow("HOLDTYPE") = "CM" Then
                    tranCred = Decimal.Parse(dtRow("HOLDAMT"))
                    tranEndBal = Decimal.Parse(sdmRow("ACCTOBAL")) + Decimal.Parse(dtRow("HOLDAMT"))
                ElseIf dtRow("HOLDTYPE") = "DM" Then
                    tranDeb = Decimal.Parse(dtRow("HOLDAMT"))
                    tranEndBal = Decimal.Parse(sdmRow("ACCTOBAL")) - Decimal.Parse(dtRow("HOLDAMT"))
                End If
                qryStr = "INSERT INTO SDTRAN VALUES(" & _
                         "'" & dtRow("ACCTNO") & "'" & _
                         ",'" & CTRL_S.SYSDATE & "'" & _
                         "," & tranSeq & _
                         ",'" & dtRow("HOLDTYPE") & "'" & _
                         "," & Decimal.Parse(sdmRow("ACCTOBAL")) & _
                         "," & tranDeb & _
                         "," & tranCred & _
                         "," & tranEndBal & _
                         ",'" & dtRow("HOLDRMKS") & "'" & _
                         ",'',''" & _
                         ",'" & CTRL_S.SYSDATE & "'" & _
                         ",'" & Format(TimeOfDay, "HH:mm:ss") & "'" & _
                         ",'" & SPUSER.USER & "'" & _
                         ",'',0,0,0,0)"
                sdmRow.Item("LSEQ") = tranSeq
                sdmRow.Item("ACCTOBAL") = tranEndBal

                'dtRow.Item("EXSEQ") = tranSeq
                'dtRow.Item("EXTIME") = Format(TimeOfDay, "HH:mm:ss")
                'dtRow.Item("EXBBAL") = Decimal.Parse(sdmRow("ACCTOBAL"))
                'dtRow.Item("EXEBAL") = Decimal.Parse(sdmRow("ACCTOBAL")) + Decimal.Parse(dtRow("AMOUNT"

                dtSDMASTER.AcceptChanges()

                sqlCMD = New SqlCommand(qryStr, cnn)
                sqlCMD.ExecuteNonQuery()
                sqlCMD.Dispose()
            Next
            For Each dtRow As DataRow In dtSDMASTER.Rows
                Dim qryStr As String
                Dim sqlCMD As SqlCommand
                qryStr = "UPDATE SDMASTER SET " & _
                         "ACCTOBAL=" & Decimal.Parse(dtRow("ACCTOBAL")) & _
                         ",ACCTABAL=" & Decimal.Parse(dtRow("ACCTOBAL")) - Decimal.Parse(dtRow("ACCTFLOATS")) & _
                         ",LSEQ=" & Integer.Parse(dtRow("LSEQ")) & _
                         "WHERE ACCTNO = '" & dtRow("ACCTNO") & "'"
                sqlCMD = New SqlCommand(qryStr, cnn)
                sqlCMD.ExecuteNonQuery()
                sqlCMD.Dispose()
            Next
            cnn.Close()


            'rExec("INSERT INTO SDTRAN(ACCTNUM,TRANDATE,TRANSEQ,TRANCODE,TRANBBAL,TRANDEB,TRANCRE,TRANEBAL,CHKNUM,CHKBANK,CHKCODE,ADD_DATE,ADD_TIME,[USER],OVERRIDE,PPOSTED,LPOSTED,TRANOLD,REVERSED) " & _
            '      "SELECT SM.ACCTNO,'" & CTRL_S.SYSDATE & "',CASE WHEN SM.LSEQ+1 < 1000 THEN SM.LSEQ+1 ELSE 1 END,LH.HOLDTYPE,SM.ACCTOBAL," & _
            '      "(CASE WHEN RTRIM(LH.HOLDTYPE)='DM' THEN LH.HOLDAMT ELSE 0 END) DEB,(CASE WHEN RTRIM(LH.HOLDTYPE)='CM' THEN LH.HOLDAMT ELSE 0 END) CRED," & _
            '      "CASE WHEN RTRIM(LH.HOLDTYPE)='CM' THEN SM.ACCTOBAL+LH.HOLDAMT ELSE SM.ACCTOBAL-LH.HOLDAMT  END,CASE WHEN LH.HOLDRMKS LIKE '%:%' THEN SUBSTRING(LH.HOLDRMKS,10,11) ELSE 'HOLD-OUT' END,'','','" & CTRL_S.SYSDATE & "','" & Format(TimeOfDay, "HH:mm:ss") & "','" & SPUSER.SPUSERID & "','',0,0,0,0 " & _
            '      "FROM LNHOLD LH WITH (NOLOCK) LEFT JOIN  SDMASTER SM WITH (NOLOCK) ON SM.ACCTNO = LH.ACCTNO WHERE LH.HOLDDATE='" & CTRL_S.SYSDATE & "' AND (LH.POSTSTAT='' OR LH.POSTSTAT IS NULL)")

            'rExec("UPDATE SDMASTER SET SDMASTER.ACCTOBAL=SP.ACCTOBAL, SDMASTER.ACCTABAL=(SP.ACCTOBAL-SDMASTER.ACCTFLOATS),SDMASTER.LSEQ=SP.LSEQ " & _
            '      "FROM (SELECT SM.ACCTNO,(CASE WHEN RTRIM(LH.HOLDTYPE)='CM' THEN SM.ACCTOBAL+LH.HOLDAMT ELSE SM.ACCTOBAL-LH.HOLDAMT  END) ACCTOBAL," & _
            '      "(CASE WHEN SM.LSEQ+1 < 1000 THEN SM.LSEQ+1 ELSE 1 END) LSEQ FROM LNHOLD LH WITH (NOLOCK) LEFT JOIN  SDMASTER SM WITH (NOLOCK) ON SM.ACCTNO = LH.ACCTNO " & _
            '      "WHERE LH.HOLDDATE='" & CTRL_S.SYSDATE & "' AND (LH.POSTSTAT='' OR LH.POSTSTAT IS NULL)) SP WHERE SDMASTER.ACCTNO=SP.ACCTNO")

            rExec("UPDATE LNHOLD SET LNHOLD.POSTSTAT='Y',LNHOLD.POSTDATE='" & CTRL_S.SYSDATE & "',LNHOLD.POSTUSER='" & SPUSER.SPUSERID & "'" & _
                  "FROM (SELECT LH.LNHOLD_ID FROM LNHOLD LH WITH (NOLOCK) LEFT JOIN  SDMASTER SM WITH (NOLOCK) ON SM.ACCTNO = LH.ACCTNO WHERE LH.HOLDDATE='" & CTRL_S.SYSDATE & "' AND (LH.POSTSTAT='' OR LH.POSTSTAT IS NULL)) SP " & _
                  "WHERE LNHOLD.LNHOLD_ID=SP.LNHOLD_ID")

        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Label4.Visible = False : Button6.Enabled = True

        If SW Then
            CheckBox1.Checked = CheckBox2.Checked = CheckBox3.Checked = False
            MsgBox("Transaction Processed!")

        End If


    End Sub
End Class