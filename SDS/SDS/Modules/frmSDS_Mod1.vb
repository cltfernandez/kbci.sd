Imports System.Text.RegularExpressions

Module frmFDS_Mod1
    Public BALANCE As Integer
    Public SW As Boolean = False
    Public frmSDS_Main As frmSDS_Main
    Public SEL_KBCI_NO, SEL_FNAME, SELFIELD, SELREGION, SEL_FEBTC As String
    Public sDate, FRDATE, TODATE, DBG, OVRUSER As String
    Public SELYR, SELQTR, TRANCODE, CHKCODE, CHKCDAYS, CHKCDATE, USROVRIDE, ACCTNUM, ACCTSTAT, DEFPRINTER As String
    Public SUMMRY, CURSW, SDDB As Boolean
    'Public HOLDOUT, FLOATS, LHOLDOUT, ACCTABAL, ACCTOBAL, ACCTFLOATS, CHKAMT, TRANEBAL As Decimal
    Public CHKAMT, TRANEBAL, LHOLDOUT, ACCTABAL, ACCTOBAL, HOLDOUT, ACCTFLOATS, ACCTPBAL As Decimal
    Public OPTIO, CHKNDAYS, CLRO, CLRL, LSEQ, CLRR As Integer
    Public CTRL_S As New ent_ctrl_s
    Public DBConn As New db_Database
    'Public Binder As New Binder
    Public SPUSER As New ent_spuser
    Public rCN As String
    Public lCN As String
    Public SDMASTERID As String
    Public ModifierID As String
    Public DTSDTMASTER As New DataTable
    Public SPTAG() As Char
    Public DATE7 As String
    Public C7Amt As Decimal
    Public bOWCheck() As Boolean
    Public Forms As System.Windows.Forms.FormCollection = Application.OpenForms
    Enum DataType
        [String] = 1
        [ID] = 2
        [Decimal] = 3
        [Boolean] = 4
    End Enum
    Enum CheckboxEnum
        [Checked] = 254
        [Unchecked] = 168
    End Enum
    Public Structure MyCell
        Dim Row As Integer
        Dim Col As Integer
    End Structure
    Sub MySub()
        Dim crypto As New Crpyt("Letter Gothic:10", System.Configuration.ConfigurationManager.AppSettings("32"))

        Dim x As String
        x = crypto.Encrypt

    End Sub
    Sub Main()
        'MySub()
        'Try
        rCN = "Password=" & GetConfig("WP") & ";User ID=" & GetConfig("CL") & ";Initial Catalog=" & GetConfig("DB") & ";Data Source=" & GetConfig("SV")
        lCN = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & App_Path() & "\KBCILocal_S.mdb" & ";Persist Security Info=False;Jet OLEDB:Database Password=password123"
        CTRL_S.getData()
        frmSDS_Main = New frmSDS_Main
        frmSDS_Main.ShowDialog()
        'Catch ex As Exception
        '    MsgBox(ex.Message & vbCrLf & "Please contact your System Administrator.", MsgBoxStyle.Critical, "Critcal Error")
        '    frmSDS_Main = Nothing
        '    CTRL_S = Nothing
        'End Try
    End Sub

    Public Sub FillLV(ByRef LV As ListView, ByRef DT As DataGridView, ByVal wSET As String, ByVal fSET As String, ByVal ScrollToLast As Boolean)
        Dim sLvw As New ListViewItem
        Dim colCTR, wdsCTR As Integer
        Dim wdSET() As String
        Dim frSet() As String
        Dim TempStr() As String
        Dim TempNode As ListViewItem
        Dim TempArr() As ListViewItem
        Dim i As Integer
        Dim ad As OleDbDataAdapter = New OleDbDataAdapter
        Dim ds As New DataSet
        Dim myCheckFont As New System.Drawing.Font("Wingdings", 12, FontStyle.Regular)
        Dim myRegFont As New System.Drawing.Font("Tahoma", 8.25, FontStyle.Bold)


        LV.Items.Clear()
        If DT.Rows.Count > 0 Then
            'StartTime = System.DateTime.Now           
            wdsCTR = 0
            LV.Columns.Clear()
            wdSET = Split(wSET, ":")
            frSet = Split(fSET, ":")
            For colCTR = 0 To DT.Columns.Count - 1
                Select Case frSet(colCTR)
                    Case 1
                        LV.Columns.Add(DT.Columns(colCTR).Name, CInt(wdSET(colCTR)), HorizontalAlignment.Left)
                    Case 2
                        LV.Columns.Add(DT.Columns(colCTR).Name, CInt(wdSET(colCTR)), HorizontalAlignment.Center)
                    Case 3
                        LV.Columns.Add(DT.Columns(colCTR).Name, CInt(wdSET(colCTR)), HorizontalAlignment.Right)
                    Case Else
                        LV.Columns.Add(DT.Columns(colCTR).Name, CInt(wdSET(colCTR)), HorizontalAlignment.Center)
                End Select

            Next
            ReDim TempStr(0)
            ReDim TempArr(DT.Rows.Count - 1)
            For i = 0 To DT.Rows.Count - 1
                TempStr(0) = CStr(DT.Rows(i).Cells(DT.Columns(0).Name).Value)
                TempNode = New ListViewItem(TempStr)
                For colCTR = 1 To DT.Columns.Count - 1
                    If Not IsDBNull(DT.Rows(i).Cells(DT.Columns(colCTR).Name).Value) Then
                        Select Case CInt(frSet(colCTR))
                            Case DataType.Decimal
                                TempNode.SubItems.Add(FormatNumber(CStr(DT.Rows(i).Cells(DT.Columns(colCTR).Name).Value), 2))
                                TempNode.Font = myRegFont
                            Case DataType.Boolean
                                Dim checked = CBool(DT.Rows(i).Cells(DT.Columns(colCTR).Name).Value)
                                Dim checkStatus
                                With TempNode
                                    If checked Then checkStatus = CheckboxEnum.Checked Else checkStatus = CheckboxEnum.Unchecked
                                    .UseItemStyleForSubItems = False
                                    .SubItems.Add(Chr(checkStatus))
                                    .SubItems.Item(colCTR).ForeColor = Color.Black
                                    .SubItems.Item(colCTR).Font = myCheckFont
                                End With
                                ReDim bOWCheck(i)
                            Case Else
                                TempNode.SubItems.Add(CStr(DT.Rows(i).Cells(DT.Columns(colCTR).Name).Value))
                                TempNode.Font = myRegFont
                        End Select
                    Else
                        TempNode.SubItems.Add("NULL")
                        TempNode.Font = myRegFont
                    End If
                Next
                TempNode.Tag = i.ToString
                TempArr(i) = TempNode
            Next i
            LV.Items.AddRange(TempArr)
            If ScrollToLast Then TempNode.EnsureVisible()
            'Elapsed = System.DateTime.Now.Subtract(StartTime).TotalMilliseconds
            'MessageBox.Show("Elapsed time " & Elapsed.ToString & " ms with ListView.Add", _
            '  "Elapsed Time", _
            '  MessageBoxButtons.OK, _
            '  MessageBoxIcon.Information)
        End If
        'odb.Fill(ds, recSET, "Table")
        'dt = ds.Tables(0)  
    End Sub
    Public Sub getWID(ByRef LVW As ListView, ByRef TXT As TextBox)
        Dim x As Integer
        Dim s As String
        s = ""
        For x = 0 To LVW.Columns.Count - 1
            s = s & LVW.Columns(x).Width & ":"
        Next
        TXT.Text = s
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", SPUSER.SPUSERID)
        End If
    End Sub
    Public Function App_Path() As String
        Return System.AppDomain.CurrentDomain.BaseDirectory()
    End Function
    Public Sub WLOG(ByVal LogMsg As String, ByVal LogPTH As String)
        On Error GoTo err1
        Dim logWrite As StreamWriter = File.AppendText(LogPTH)
        logWrite.WriteLine(LogMsg) : logWrite.Flush() : logWrite.Close()
err1:
        If Err.Number <> 0 Then
            WLOG("**RUNTIME ERROR** " & Err.Description & "  Module: 'WLOG'" & Now, LogPTH) : Resume err1
        End If
    End Sub
    Public Sub clrTXT(ByRef Mee As Form)
        Dim Control As Control
        Dim gControl As Control

        For Each Control In Mee.Controls
            If TypeOf Control Is GroupBox Then
                For Each gControl In Control.Controls
                    If TypeOf gControl Is TextBox Then
                        Dim txt As TextBox = gControl
                        txt.Text = ""
                    End If
                Next
                If TypeOf Control Is TextBox Then
                    Dim txt As TextBox = Control
                    txt.Text = ""
                End If
            End If
        Next Control
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", SPUSER.SPUSERID)
        End If
    End Sub
    Public Sub GenRPT(ByVal rptRS As DataTable, ByRef rptDT As DataTable, ByRef RepViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer, ByVal CrysRep As CrystalDecisions.CrystalReports.Engine.ReportClass, ByVal TBL As Integer, ByVal FString As String)
        Dim colCTR, rowCTR As Integer
        Dim rptDS As New DataSet
        Dim wdSET(50) As String

        wdSET = Split(FString, ":")
        For colCTR = 0 To rptRS.Columns.Count - 1
            Select Case wdSET(colCTR)
                Case 2 'decimal
                    rptDT.Columns.Add(rptRS.Columns(colCTR).ColumnName, Type.GetType("System.Decimal"))
                Case 6 'integer
                    rptDT.Columns.Add(rptRS.Columns(colCTR).ColumnName, Type.GetType("System.Int64"))
                Case Else
                    rptDT.Columns.Add(rptRS.Columns(colCTR).ColumnName, Type.GetType("System.String"))
            End Select
        Next

        For rowCTR = 0 To rptRS.Rows.Count - 1
            Dim dtr As DataRow = rptDT.NewRow
            For colCTR = 0 To rptRS.Columns.Count - 1
                Select Case wdSET(colCTR)
                    Case 1 'date
                        If Not IsDBNull(rptRS.Rows(rowCTR).Item(rptRS.Columns(colCTR).ColumnName)) Then dtr.Item(rptRS.Columns(colCTR).ColumnName) = DateValue(rptRS.Rows(rowCTR).Item(rptRS.Columns(colCTR).ColumnName)).ToString("MM/dd/yyy")
                    Case 2 'decimal
                        If Not IsDBNull(rptRS.Rows(rowCTR).Item(rptRS.Columns(colCTR).ColumnName)) Then
                            'If rptRS.Columns(colCTR).ColumnName = "DEBIT" Then
                            '    If rptRS.Rows(rowCTR).Item("DRCR").Value = "DR" Then
                            '        If Not IsDBNull(rptRS.Rows(rowCTR).Item(rptRS.Columns(colCTR).ColumnName).Value) Then dtr.Item(rptRS.Columns(colCTR).ColumnName) = rptRS.Rows(rowCTR).Item(rptRS.Columns(colCTR).ColumnName).Value
                            '    End If
                            'ElseIf rptRS.Columns(colCTR).ColumnName = "CREDIT" Then
                            '    If rptRS.Rows(rowCTR).Item("DRCR").Value = "CR" Then
                            '        If Not IsDBNull(rptRS.Rows(rowCTR).Item(rptRS.Columns(colCTR).ColumnName).Value) Then dtr.Item(rptRS.Columns(colCTR).ColumnName) = rptRS.Rows(rowCTR).Item(rptRS.Columns(colCTR).ColumnName).Value
                            '    End If
                            'Else
                            '    If Not IsDBNull(rptRS.Rows(rowCTR).Item(rptRS.Columns(colCTR).ColumnName).Value) Then dtr.Item(rptRS.Columns(colCTR).ColumnName) = rptRS.Rows(rowCTR).Item(rptRS.Columns(colCTR).ColumnName).Value
                            'End If
                            If Not IsDBNull(rptRS.Rows(rowCTR).Item(rptRS.Columns(colCTR).ColumnName)) Then dtr.Item(rptRS.Columns(colCTR).ColumnName) = rptRS.Rows(rowCTR).Item(rptRS.Columns(colCTR).ColumnName)
                        End If
                    Case 4 'boolean
                        If Not IsDBNull(rptRS.Rows(rowCTR).Item(rptRS.Columns(colCTR).ColumnName)) Then dtr.Item(rptRS.Columns(colCTR).ColumnName) = Mid(rptRS.Rows(rowCTR).Item(rptRS.Columns(colCTR).ColumnName), 1, 1)
                    Case 5 'kbci format
                        If Not IsDBNull(rptRS.Rows(rowCTR).Item(rptRS.Columns(colCTR).ColumnName)) Then dtr.Item(rptRS.Columns(colCTR).ColumnName) = Mid(rptRS.Rows(rowCTR).Item(rptRS.Columns(colCTR).ColumnName), 1, 4) & _
                         "-" & Mid(rptRS.Rows(rowCTR).Item(rptRS.Columns(colCTR).ColumnName), 5, 5) & "-" & Mid(rptRS.Rows(rowCTR).Item(rptRS.Columns(colCTR).ColumnName), 10, 1)
                    Case Else
                        If Not IsDBNull(rptRS.Rows(rowCTR).Item(rptRS.Columns(colCTR).ColumnName)) Then dtr.Item(rptRS.Columns(colCTR).ColumnName) = rptRS.Rows(rowCTR).Item(rptRS.Columns(colCTR).ColumnName)
                End Select
            Next
            rptDT.Rows.Add(dtr)
        Next
        rptRS.Dispose()
        rptDS.Tables.Add(rptDT)
        CrysRep.SetDataSource(rptDS.Tables(TBL))
        RepViewer.ReportSource = CrysRep
errHand:
        If Err.Number <> 0 Then
            LogError(Err.Number, Err.Description, "frmDIVPAT_Load", SPUSER.SPUSERID)
        End If
    End Sub
    Public Function CleanSTR(ByVal SQLStr As String) As String
        Dim x As Integer
        Dim rStr As String = ""
        For x = 1 To Len(SQLStr)
            If Mid(SQLStr, x, 1) = "'" Then
                If Mid(SQLStr, x - 1, 1) <> "," And Mid(SQLStr, x + 1, 1) <> "," And Mid(SQLStr, x + 1, 1) <> ")" And Mid(SQLStr, x - 1, 1) <> "(" And Mid(SQLStr, x - 1, 1) <> "=" And Mid(SQLStr, x + 1, 1) <> "" Then
                    rStr = rStr & "'"
                End If
            End If
            rStr = rStr & Mid(SQLStr, x, 1)
        Next
        Return rStr
    End Function
    Public Function GetData(ByVal QRYStr As String, ByVal FLTR As String, ByRef DG As DataGridView) As DataGridView
        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        'Dim cnn As New SqlConnection("Password=+kbci+;User ID=kbciuser;Initial Catalog=kbci;Data Source=10.0.6.127\SQLEXPRESS,1433")
        Dim sqlCMD As New SqlCommand(QRYStr, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        Dim DV As New DataView(DT)
        If FLTR.Trim <> "" Then DV.RowFilter = FLTR
        DG.DataSource = DV
        Return DG
    End Function
    Public Function GetData(ByVal QRYStr As String, ByVal FLTR As String) As DataTable
        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(QRYStr, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        Return DT
    End Function
    Public Function GetLocData(ByVal QRYStr As String, ByVal FLTR As String, ByRef DG As DataGridView, ByVal lcnStr As String) As DataGridView
        Dim DT As New DataTable
        Dim cnn As New OleDbConnection(lcnStr)
        Dim sqlCMD As New OleDbCommand(QRYStr, cnn)
        Dim ad As New OleDbDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        Dim DV As New DataView(DT)
        If FLTR.Trim <> "" Then DV.RowFilter = FLTR
        DG.DataSource = DV
        Return DG
    End Function


    Public Function GetLocData(ByVal QRYStr As String, ByVal lcnStr As String) As DataTable
        Dim DT As New DataTable
        Dim cnn As New OleDbConnection(lcnStr)
        Dim sqlCMD As New OleDbCommand(QRYStr, cnn)
        Dim ad As New OleDbDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        Return DT
    End Function
    Public Sub lExec(ByVal QRY As String)
        Dim cnn As New OleDbConnection(lCN)
        Dim odbCMD As New OleDbCommand(QRY, cnn)
        Try

            cnn.Open()
            odbCMD.ExecuteNonQuery()
            odbCMD.Dispose()
            cnn.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub rExec(ByVal QRY As String, Optional ByVal Timeout As Integer = 30)
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(QRY, cnn)
        sqlCMD.CommandTimeout = Timeout
        Try

            cnn.Open()
            sqlCMD.ExecuteNonQuery()
            sqlCMD.Dispose()
            cnn.Close()
            cnn.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function GetRStr(ByVal qrySTR As String, ByVal ColName As String, ByVal rowNum As Integer) As String
        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(qrySTR, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        Try
            sqlCMD.CommandType = CommandType.Text
            cnn.Open()
            ad.Fill(DT)
            cnn.Close()
            Return DT.Rows(rowNum).Item(ColName).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
            Return ""
        End Try
    End Function
    Public Function GetLStr(ByVal qrySTR As String, ByVal ColName As String, ByVal rowNum As Integer, ByVal lcnStr As String) As String
        Dim DT As New DataTable
        Dim cnn As New OleDbConnection(lcnStr)
        Dim sqlCMD As New OleDbCommand(qrySTR, cnn)
        Dim ad As New OleDbDataAdapter(sqlCMD)
        Try
            sqlCMD.CommandType = CommandType.Text
            cnn.Open()
            ad.Fill(DT)
            cnn.Close()
            Return DT.Rows(rowNum).Item(ColName).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
            Return ""
        End Try
    End Function

    Public Function IsDBExist(ByVal CnStr As String, ByVal TBL As String) As Boolean
        Dim AccessConnection As New System.Data.OleDb.OleDbConnection
        Dim SchemaTable As DataTable
        AccessConnection.ConnectionString = CnStr
        AccessConnection.Open()
        SchemaTable = AccessConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, New Object() {Nothing, Nothing, TBL})

        If SchemaTable.Rows.Count <> 0 Then
            Return True
        Else
            Return False
        End If
        AccessConnection.Close()
    End Function
    Public Function GetConfig(ByVal KEY As String) As String
        Dim crypto As New Crpyt(System.Configuration.ConfigurationManager.AppSettings(KEY), System.Configuration.ConfigurationManager.AppSettings("32"))

        Return crypto.Decrypt()
    End Function

    Public Function LogError(ByVal lngErrNumber As Long, ByVal strErrDescription As String, ByVal strCallingProc As String, ByVal currUser As String, Optional ByVal bShowUser As Boolean = True) As Boolean
        On Error GoTo ErrorHandler

        Dim strMsg As String
        Dim strUser As String
        Dim strSQL As String
        ' Case on type of error generated by Access
        Select Case lngErrNumber
            Case 2501
                ' Do nothing - error code corresponds to cancellation
            Case 3314, 2101, 2115
                ' Can't save records - logger will not function
                If bShowUser Then
                    ' Display dialog if user specified non-silent logging
                    strMsg = "Record cannot be saved at this time." & vbCrLf & _
                        "Complete the entry, or press <Esc> to undo."
                    MsgBox(strMsg, vbExclamation, strCallingProc)
                End If
            Case Else
                If bShowUser Then
                    ' Display dialog if user specified non-silent logging
                    strMsg = "Error " & lngErrNumber & ": " & strErrDescription
                    MsgBox(strMsg, vbExclamation, strCallingProc)
                End If

                LogError = True
        End Select

ExitHandler:
        Exit Function
ErrorHandler:
        ' Display dialog for error in error logger
        strMsg = "An unexpected situation arose in your program." & vbCrLf & _
            "Please write down the following details:" & vbCrLf & vbCrLf & _
            "Calling Proc: " & strCallingProc & vbCrLf & _
            "Error Number " & lngErrNumber & vbCrLf & strErrDescription & vbCrLf & vbCrLf & _
            "Unable to record because Error " & Err.Number & vbCrLf & Err.Description
        MsgBox(strMsg, vbCritical, "LogError()")
        Resume ExitHandler

    End Function
    Public Function OVRRIDE() As String
        Dim frmSDS_Main_Ovrride As frmSDS_Main_Ovrride = New frmSDS_Main_Ovrride
        frmSDS_Main_Ovrride.ShowDialog()
        If SW = True Then
            Return OVRUSER
        Else
            Return ""
        End If
    End Function
    Public Sub MSGB(ByVal mess As String)
        Dim AboutBox1 As AboutBox1 = New AboutBox1
        AboutBox1.TextBoxDescription.Text = mess
        AboutBox1.ShowDialog()
        AboutBox1.Dispose()
    End Sub
    Public Function IsFormLoaded(ByVal FormName As String) As Boolean
        Dim i As Integer, fnamelc As String

        fnamelc = LCase$(FormName)
        IsFormLoaded = False

        For i = 0 To Forms.Count - 1
            If LCase$(Forms(i).Name) = fnamelc Then
                IsFormLoaded = True
                Exit Function
            End If

        Next

    End Function
    Public Function GPer(ByVal CVal As Integer, ByVal MVal As Integer) As String
        Return Int((CVal / MVal) * 100 + 0.5) & "%"
    End Function

    Public Function NEWACCTNO() As String
        Dim I, TOT, CHK As Integer
        Dim ACCT As String
        Dim TB As New CLTF.DB.SQLDBConnection
        Dim UP As New CLTF.DB.SQLDBConnection
        TB.OpenCmdDataTable(rCN, "SELECT ACCTSEQ,ACCTBR FROM CTRL_S WITH (NOLOCK)")
        ACCT = TB.GetValue("ACCTBR").PadLeft(4, "0") & Trim(Str(Val(TB.GetValue("ACCTSEQ")) + 1)).PadLeft(5, "0")
        For I = 10 To 1 Step -1
            TOT += Val(Mid(ACCT, (11 - I), 1)) * I
        Next
        CHK = 11 - (TOT Mod 11)
        If CHK > 9 Then
            CHK = 0
        End If
        ACCT = Mid(ACCT, 1, 9) & Trim(Str(CHK))
        TB.CloseDataTable()
        UP.OpenCommand(rCN)
        UP.Execute("UPDATE CTRL_S SET ACCTSEQ=" & Val(TB.GetValue("ACCTSEQ")) + 1) : UP.CloseCommand()
        Return ACCT
    End Function
    Public Function recIsUsed(ByVal RECID As String) As Boolean
        Dim VL As New CLTF.DB.SQLDBConnection
        VL.OpenCmdDataTable(rCN, "SELECT REC_STAT,ISNULL(UPD_USER,'') UPD_USER FROM SDMASTER WITH (NOLOCK) WHERE SDMASTER_ID=" & RECID)
        ModifierID = VL.GetValue("UPD_USER")
        If VL.GetValue("UPD_USER").Trim.ToUpper = SPUSER.SPUSERID Then Return False
        Return VL.GetValue("REC_STAT")
        VL.CloseDataTable()
    End Function
    Public Sub LockREC(ByVal RECID As String, ByVal SW As Boolean)
        Dim UP As New CLTF.DB.SQLDBConnection
        UP.OpenCommand(rCN)
        UP.OpenCmdDataTable(rCN, "SELECT REC_STAT,ISNULL(UPD_USER,'') UPD_USER FROM SDMASTER WITH (NOLOCK) WHERE SDMASTER_ID=" & RECID)
        ModifierID = UP.GetValue("UPD_USER")
        If SW Or (SW = False And ModifierID = SPUSER.SPUSERID) Then
            UP.OpenCommand(rCN)
            UP.Execute("UPDATE SDMASTER SET UPD_USER='" & Microsoft.VisualBasic.Left(SPUSER.SPUSERID, 8) & "', REC_STAT='" & SW & "' WHERE SDMASTER_ID='" & RECID & "'")
            UP.CloseCommand()
        End If

    End Sub
    Function GetLastBusinessDay(ByVal Year As Integer, ByVal Month As Integer) As DateTime
        Dim LastOfMonth As DateTime
        Dim LastBusinessDay As DateTime

        LastOfMonth = New DateTime(Year, Month, DateTime.DaysInMonth(Year, Month))

        If LastOfMonth.DayOfWeek = DayOfWeek.Sunday Then
            LastBusinessDay = LastOfMonth.AddDays(-2)
        ElseIf LastOfMonth.DayOfWeek = DayOfWeek.Saturday Then
            LastBusinessDay = LastOfMonth.AddDays(-1)
        Else
            LastBusinessDay = LastOfMonth
        End If

        Return LastBusinessDay

    End Function
    Public Function AddLine(ByVal LineNo As Integer) As String
        Dim lineStr As String = String.Empty
        For ctr = 1 To LineNo
            lineStr &= vbCrLf & " "
        Next
        Return lineStr
    End Function

    Public Function WhichCell(ByVal lvw As ListView, ByVal X As Integer, ByVal Y As Integer) As MyCell

        Dim colstart As Integer = 0
        Dim colend As Integer = 0
        Dim xCol As Integer

        For xCol = 0 To (lvw.Columns.Count - 1)
            colend = colend + lvw.Columns(xCol).Width
            If colstart <= X And X <= colend Then
                WhichCell.Col = xCol + 1
                Exit For
            End If
            colstart = colstart + lvw.Columns(xCol).Width
        Next

        WhichCell.Row = lvw.FocusedItem.Index
        Return WhichCell

    End Function
    Public Sub DecimalValidator(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        Dim decimalRex As Regex = New Regex("^[0-9]*[.]{0,1}[0-9]*$")
        If e.KeyChar = Microsoft.VisualBasic.Strings.ChrW(Keys.Back) Then
            Exit Sub
        End If

        If Not decimalRex.IsMatch(e.KeyChar.ToString()) Then
            e.Handled = True
        End If
    End Sub
    'INSERT * TO MEMBERS
    'WLOG("INSERT INTO MEMBERS([KBCI_NO],[LNAME],[FNAME],[MI],[MEM_CODE],[MEM_STAT],[MEM_DATE],[BY_WHOM],[CB_EMPNO],[CB_HIRE],[DEPT],[REGION],[OFF_TEL],[DORI],[REA_DORI],[SEX],[B_DATE],[CIV_STAT],[MEM_ADDR],[RES_TEL],[POSITION],[SAL_BAS],[SAL_ALL],[OTH_INC],[FEBTC_SA],[FEBTC_CA],[FD_CERTNO],[FD_DATE],[AP_AMOUNT],[AR_AMOUNT],[FD_AMOUNT],[SD_AMOUNT],[TD_AMOUNT],[OTH_AMOUNT],[YTD_DIVAMT],[YTD_LRI],[REM_PROP],[REM_VALUE],[NO_DEPEND],[SP_NAME],[SP_EMPLOY],[SP_OFFTEL],[SP_CBEMPNO],[SP_KBCINO],[SP_SALARY],[APRUN_AMT],[ARRUN_AMT],[RUN_AMT],[ADD_DATE],[CHG_DATE],[USER],[REC_STAT],[FD_CNTR]) " & _
    '"VALUES    ('" & .Fields("KBCI_NO").Value & "','" & .Fields("LNAME").Value & "','" & .Fields("FNAME").Value & "','" & .Fields("MI").Value & "','" & .Fields("MEM_CODE").Value & "','" & .Fields("MEM_STAT").Value & "','" & .Fields("MEM_DATE").Value & "','" & .Fields("BY_WHOM").Value & "','" & .Fields("CB_EMPNO").Value & "','" & .Fields("CB_HIRE").Value & "','" & .Fields("DEPT").Value & "','" & .Fields("REGION").Value & "','" & .Fields("OFF_TEL").Value & "'," & .Fields("DORI").Value & ",'" & .Fields("REA_DORI").Value & "','" & .Fields("SEX").Value & "','" & .Fields("B_DATE").Value & _
    '         "','" & .Fields("CIV_STAT").Value & "','" & .Fields("MEM_ADDR").Value & "','" & .Fields("RES_TEL").Value & "','" & .Fields("POSITION").Value & "'," & .Fields("SAL_BAS").Value & "," & .Fields("SAL_ALL").Value & "," & .Fields("OTH_INC").Value & ",'" & .Fields("FEBTC_SA").Value & "','" & .Fields("FEBTC_CA").Value & "','" & .Fields("FD_CERTNO").Value & "','" & .Fields("FD_DATE").Value & "'," & .Fields("AP_AMOUNT").Value & "," & .Fields("AR_AMOUNT").Value & "," & .Fields("FD_AMOUNT").Value & "," & .Fields("SD_AMOUNT").Value & "," & .Fields("TD_AMOUNT").Value & "," & .Fields("OTH_AMOUNT").Value & _
    '           "," & .Fields("YTD_DIVAMT").Value & "," & .Fields("YTD_LRI").Value & ",'" & .Fields("REM_PROP").Value & "'," & .Fields("REM_VALUE").Value & "," & .Fields("NO_DEPEND").Value & ",'" & .Fields("SP_NAME").Value & "','" & .Fields("SP_EMPLOY").Value & "','" & .Fields("SP_OFFTEL").Value & "','" & .Fields("SP_CBEMPNO").Value & "','" & .Fields("SP_KBCINO").Value & "'," & .Fields("SP_SALARY").Value & "," & .Fields("APRUN_AMT").Value & "," & .Fields("ARRUN_AMT").Value & "," & .Fields("RUN_AMT").Value & ",'" & .Fields("ADD_DATE").Value & "','" & .Fields("CHG_DATE").Value & "','" & .Fields("USER").Value & "'," & .Fields("REC_STAT").Value & "," & .Fields("FD_CNTR").Value & ")", App_Path() & "INSERT.log")

End Module
