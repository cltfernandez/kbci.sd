Public Class frmPayrollExtract

    Private DBF, DBF2 As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim LPAmt As Decimal
        Dim msg, LPDate, lcnstr As String
        If openFile("Payroll File (EXTKBC.DBF) |*.DBF", TextBox1) Then
            DBF = Path.GetFileName(TextBox1.Text).Replace(Path.GetExtension(TextBox1.Text), "")
            'lcnstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Path.GetDirectoryName(TextBox1.Text) & "\;Extended Properties=dBASE 5.0"
            lcnstr = "Provider=VFPOLEDB.1;Data Source=" & Path.GetDirectoryName(TextBox1.Text)

            If CInt(GetLStr("SELECT COUNT(EMPNO1)AS CNT FROM " & DBF & "", "CNT", 0, lcnstr)) > 0 Then
                C7Amt = CDbl(GetLStr("SELECT SUM(amt7c) as AMT FROM " & DBF, "AMT", 0, lcnstr))
                LPAmt = CDbl(GetRStr("SELECT LPAMT FROM PARAM_S", "LPAMT", 0))
                DATE7 = GetLStr("SELECT TOP 1 DATE7 FROM " & DBF & " ORDER BY DATE7", "DATE7", 0, lcnstr)
                LPDate = CInt(GetRStr("SELECT LPDATE FROM PARAM_S WITH (NOLOCK) ", "LPDATE", 0))
                If C7Amt = LPAmt And DATE7 = LPDate Then MsgBox("This batch was already processed.", MsgBoxStyle.Critical, "Payroll Processing") : TextBox1.Text = "" : Exit Sub
                msg = MsgBox("[[ IMPORTANT ]]" & vbCrLf & "      This will process  Payroll Transactions for the  month." & vbCrLf & _
                             "Please make sure all users are logged-off and execute back-up" & vbCrLf & "before executing this option.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Payroll Processing")
                If msg = vbCancel Then TextBox1.Text = ""
            Else                
                MsgBox("No items to post for this batch.", MsgBoxStyle.Information, "Payroll Processing")
                CheckBox1.Checked = False
            End If
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Button6.Enabled = False
        bgwPayroll.RunWorkerAsync()        
    End Sub

    Private Sub bgwPayroll_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwPayroll.DoWork
        Dim cnn As New SqlConnection(rCN)
        Dim sqlQuery As String
        cnn.Open()
        If CheckBox1.Checked Then
            sqlQuery = "SELECT EMPNO1,ACTYPE,ACTCD1,ACTCD2," & _
                       "ctod(substr(allt(str(date7)),5,2)+'/'+right(allt(str(date7)),2)+'/'+left(allt(str(date7)),4))" & _
                       ",AMT7C,CODE5 FROM " & DBF
            rExec("TRUNCATE TABLE EXTKBC")
            Using bcopy As New SqlBulkCopy(rCN)
                bcopy.DestinationTableName = "EXTKBC"
                bcopy.WriteToServer(GetLocData(sqlQuery, "Provider=VFPOLEDB.1;Data Source=" & Path.GetDirectoryName(TextBox1.Text)))
            End Using
        End If
        If CheckBox2.Checked Then
            Dim dt As DataTable
            sqlQuery = "SELECT PN_NO,KBCI_NO,LOAN_TYPE,ADD_DATE,CHG_DATE,USER,AMOUNT," & _
                       "REMARKS,SAVINGS,ACCTNO,STATUS FROM " & DBF2 & " WHERE STATUS='1'"
            rExec("TRUNCATE TABLE EXTRACT")
            Using bcopy As New SqlBulkCopy(rCN)
                dt = GetLocData(sqlQuery, "Provider=VFPOLEDB.1;Data Source=" & Path.GetDirectoryName(TextBox2.Text))
                bcopy.DestinationTableName = "EXTRACT"
                bcopy.WriteToServer(dt)
            End Using
        End If

    End Sub

    Private Sub bgwPayroll_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwPayroll.RunWorkerCompleted
        Button6.Enabled = True
        MsgBox("Payroll extraction Done. You can now execute Payroll Posting.", MsgBoxStyle.Information, "PAYROLL EXTRACT")
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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click        
        Dim lcnstr As String
        If openFile("Advance Payment File (EXTRACT.DBF) |*.DBF", TextBox2) Then
            DBF2 = Path.GetFileName(TextBox2.Text).Replace(Path.GetExtension(TextBox2.Text), "")
            'lcnstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Path.GetDirectoryName(TextBox1.Text) & "\;Extended Properties=dBASE 5.0"
            lcnstr = "Provider=VFPOLEDB.1;Data Source=" & Path.GetDirectoryName(TextBox2.Text)

            If CInt(GetLStr("SELECT COUNT(PN_NO)AS CNT FROM " & DBF2 & "", "CNT", 0, lcnstr)) < 1 Then
                MsgBox("No items to post for this batch.", MsgBoxStyle.Information, "Advance Payment Processing")
                CheckBox2.Checked = False
            End If
        End If
    End Sub

End Class