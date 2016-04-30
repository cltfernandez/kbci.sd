﻿Imports System.Windows.Forms

Public Class frmSDS_Close_OTC
    Dim batch_Ran As Boolean
    Private Sub frmSDS_Close_OTC_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If Not batch_Ran Then bgwOTCProcess.RunWorkerAsync()
    End Sub
    Sub CompADB()
        Dim x, y, dayPTR, No_days, R1, R2, Range As Integer
        Dim ACC As New CLTF.DB.SQLDBConnection
        Dim AC2BAL As New CLTF.DB.SQLDBConnection
        Dim upd As New CLTF.DB.SQLDBConnection
        Dim DTA As New DataTable
        Dim currADB, accADB, SDRATE, accINT As Decimal
        Dim qryStr As String = "SELECT ACCTNO FROM SDMASTER WHERE ACCTSTAT<>'C'"
        Dim qryStr2 As String
        Dim StrDay, EndDay As String
        StrDay = DateValue(Month(CTRL_S.SYSDATE) & "/01/" & Year(CTRL_S.SYSDATE))
        EndDay = DateValue(Month(CTRL_S.SYSDATE) & "/" & DateTime.DaysInMonth(Year(CTRL_S.SYSDATE), Month(CTRL_S.SYSDATE)) & "/" & Year(CTRL_S.SYSDATE))
        No_days = DateTime.DaysInMonth(Year(CTRL_S.SYSDATE), Month(CTRL_S.SYSDATE))
        ACC.OpenCmdDataTable(rCN, "SELECT SDRATE FROM CTRL_S") : SDRATE = CDbl(ACC.GetValue("SDRATE")) : ACC.CloseDataTable()
        ACC.OpenCmdDataTable(rCN, qryStr)
        DTA = ACC.GetTable()
        ACC.CloseDataTable()
        qryStr2 = "SELECT SM.ACCTNUM,SM.TRANBBAL,SX.TRANEBAL,SM.TRANDATE " & _
                  "FROM (SELECT ACCTNUM,TRANBBAL,TRANDATE " & _
                  "FROM SDTRAN " & _
                  "WHERE SDTRAN_ID IN (SELECT MIN(SDTRAN_ID) SDTRAN_ID " & _
                  "FROM SDTRAN " & _
                  "WHERE TRANDATE BETWEEN '" & StrDay & "' AND '" & EndDay & "' " & _
                  "GROUP BY	ACCTNUM,TRANDATE)) SM " & _
                  "INNER JOIN (SELECT ACCTNUM,TRANEBAL,TRANDATE " & _
                  "FROM SDTRAN " & _
                  "WHERE SDTRAN_ID IN (SELECT MAX(SDTRAN_ID) SDTRAN_ID " & _
                  "FROM SDTRAN " & _
                  "WHERE TRANDATE BETWEEN '" & StrDay & "' AND '" & EndDay & "' " & _
                  "GROUP BY	ACCTNUM,TRANDATE)) SX " & _
                  "ON SM.ACCTNUM+CONVERT(VARCHAR(8),SM.TRANDATE,112)=SX.ACCTNUM+CONVERT(VARCHAR(8),SX.TRANDATE,112)"
        upd.ConnString = rCN
        upd.OpenCommand()
        ACC.OpenCmdDataTable(rCN, qryStr2)

        For x = 0 To DTA.Rows.Count - 1
            ACC.GetGrid(DataGridView1, "ACCTNUM='" & DTA.Rows(x).Item("ACCTNO") & "'")
            dayPTR = 0
            With DataGridView1
                If .RowCount > 0 Then
                    accADB = 0
                    For y = 0 To DataGridView1.RowCount - 1
                        If dayPTR = 0 Then
                            currADB = CDbl(.Rows(dayPTR).Cells("TRANBBAL").Value)
                            R1 = 1
                            R2 = Microsoft.VisualBasic.Day(DateValue(.Rows(dayPTR).Cells("TRANDATE").Value))
                            'If R2 = R1 Then
                            '    R2 = 2
                            '    currADB = CDbl(.Rows(dayPTR).Cells("TRANEBAL").Value)
                            'End If
                        Else
                            currADB = CDbl(.Rows(dayPTR - 1).Cells("TRANEBAL").Value)
                            R1 = Microsoft.VisualBasic.Day(DateValue(.Rows(dayPTR - 1).Cells("TRANDATE").Value))
                            R2 = Microsoft.VisualBasic.Day(DateValue(.Rows(dayPTR).Cells("TRANDATE").Value))
                        End If
                        Range = R2 - R1
                        accADB = accADB + (currADB * Range)
                        'accADB = accADB + currADB = CDbl(.Rows(dayPTR).Cells("TRANEBAL").Value)
                        dayPTR += 1
                    Next
                    currADB = CDbl(.Rows(dayPTR - 1).Cells("TRANEBAL").Value)
                    Range = (No_days + 1) - R2
                    accADB = accADB + (currADB * Range)
                    '2012.10.27 accADB = accADB / No_days
                    accADB = Round(accADB / No_days, 2)
                Else
                    AC2BAL.OpenCmdDataTable(rCN, "SELECT ACCTOBAL FROM SDMASTER WHERE ACCTNO='" & DTA.Rows(x).Item("ACCTNO") & "'")
                    accADB = CDbl(AC2BAL.GetValue("ACCTOBAL")) : AC2BAL.CloseDataTable()
                End If
            End With
            If accADB < CTRL_S.MINBAL Then
                accINT = 0
            Else
                'accINT = accADB * (Math.Truncate((SDRATE / 1200) * 100000) / 100000)
                '2012.10.27 accINT = Math.Truncate(Decimal.Multiply(accADB, (SDRATE / 1200)) * 100) / 100
                accINT = Round(accADB * (SDRATE / 1200), 2)
            End If
            If Month(DateValue(CTRL_S.SYSDATE)) = 1 Or Month(DateValue(CTRL_S.SYSDATE)) = 4 Or Month(DateValue(CTRL_S.SYSDATE)) = 7 _
               Or Month(DateValue(CTRL_S.SYSDATE)) = 10 Then
                y = 1
            ElseIf Month(DateValue(CTRL_S.SYSDATE)) = 2 Or Month(DateValue(CTRL_S.SYSDATE)) = 5 Or Month(DateValue(CTRL_S.SYSDATE)) = 8 _
               Or Month(DateValue(CTRL_S.SYSDATE)) = 11 Then
                y = 2
            ElseIf Month(DateValue(CTRL_S.SYSDATE)) = 3 Or Month(DateValue(CTRL_S.SYSDATE)) = 6 Or Month(DateValue(CTRL_S.SYSDATE)) = 9 _
               Or Month(DateValue(CTRL_S.SYSDATE)) = 12 Then
                y = 3
            End If
            '2012.10.27 accADB = Math.Truncate(accADB * 100) / 100
            upd.Execute("UPDATE INTRST_S SET ADB=" & accADB & " ,MONTH" & y & "=" & accINT & " WHERE ACCTNO='" & DTA.Rows(x).Item("ACCTNO") & "'")
        Next
        upd.CloseCommand()
        ACC.CloseDataTable()
        If CTRL_S.EOQF Then
            Dim mssg As String
            mssg = MsgBox("Post interest for quarter ending. [" & CTRL_S.SYSDATE & "] Would you like to continue?", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "End-of-Day")
            If mssg = vbCancel Then Exit Sub : Me.Close()
            Dim updts As New CLTF.DB.SQLDBConnection
            updts.OpenCommand(rCN)
            updts.Execute("UPDATE INTRST_S SET INTRST_S.QTD=UPINS.CQTD " & _
                          "FROM (SELECT ACCTNO ACCTNM,(MONTH1+MONTH2+MONTH3) CQTD FROM INTRST_S) UPINS " & _
                          "WHERE(INTRST_S.ACCTNO = UPINS.ACCTNM)")
            updts.CloseCommand()
        End If

    End Sub
    Sub pstSDTRAN()
        Dim msg As String
        If CTRL_S.EOQF Then
            msg = MsgBox("Post interest for quarter ending " & CTRL_S.SYSDATE & ".", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "End-of-Day")
            If msg = vbCancel Then
                Exit Sub
            Else



                Dim UPD As New db_Database

                Dim Params = New List(Of SqlParameter)
                UPD.Connectionstring = rCN
                UPD.Open()

                Params.Add(New SqlParameter("@SYSDATE", CTRL_S.SYSDATE.ToString()))
                Params.Add(New SqlParameter("@USERID", SPUSER.SPUSERID))

                UPD.ExecSP("s_PostQuarterlyInterset", Params)

                'UPD.Execute("INSERT INTO SDTRAN(ACCTNUM,TRANDATE,TRANSEQ,TRANCODE,TRANBBAL,TRANDEB,TRANCRE,TRANEBAL,CHKNUM,CHKBANK,CHKCODE,ADD_DATE,ADD_TIME,[USER],OVERRIDE,PPOSTED,LPOSTED,TRANOLD,REVERSED) " & _
                '            "SELECT SM.ACCTNO,'" & CTRL_S.SYSDATE & "',CASE WHEN SM.LSEQ+1 < 1000 THEN SM.LSEQ+1 ELSE 1 END,'INT',SM.ACCTOBAL,0,INS.QTD,SM.ACCTOBAL+INS.QTD,'INTEREST','','','" & CTRL_S.SYSDATE & "','" & _
                '             Format(TimeOfDay, "HH:mm:ss") & "','" & SPUSER.SPUSERID & "','',0,0,0,0 " & _
                '            "FROM SDMASTER SM RIGHT JOIN INTRST_S INS ON SM.ACCTNO=INS.ACCTNO WHERE SM.ACCTSTAT IN ('A','D')")
                'UPD.CloseCommand()

                'UPD.OpenCommand()
                'UPD.Execute("UPDATE SDMASTER SET SDMASTER.ACCTOBAL=SP.ACCTOBAL, SDMASTER.ACCTABAL=(SP.ACCTOBAL-SDMASTER.ACCTFLOATS),SDMASTER.LSEQ=SP.LSEQ " & _
                '            "FROM (SELECT SM.ACCTNO,(SM.ACCTOBAL+(EX.MONTH1+EX.MONTH2+EX.MONTH3)) ACCTOBAL,(CASE WHEN SM.LSEQ+1 < 1000 THEN SM.LSEQ+1 ELSE 1 END) LSEQ " & _
                '            "FROM INTRST_S EX LEFT JOIN SDMASTER SM ON SM.ACCTNO=EX.ACCTNO) SP WHERE SDMASTER.ACCTNO=SP.ACCTNO AND SDMASTER.ACCTSTAT IN ('A','D')")
                'UPD.CloseCommand()
                UPD.Close()
                setFlags()
            End If
        End If
    End Sub
    Sub setFlags()

        Dim UPD As New CLTF.DB.SQLDBConnection
        UPD.ConnString = rCN
        UPD.OpenCommand()
        UPD.Execute("UPDATE CHKLIST SET CLAPP='False'")
        UPD.Execute("UPDATE CHKLIST SET CLACT='False',CLAPP='True' WHERE CLTYP='EOD'")
        If CTRL_S.EOMF Then
            UPD.Execute("UPDATE CHKLIST SET CLACT='False',CLAPP='True' WHERE CLTYP='EOM'")
        Else
            UPD.Execute("UPDATE CHKLIST SET CLACT='True' WHERE CLTYP='EOM'")
        End If
        If CTRL_S.EOQF Then
            UPD.Execute("UPDATE CHKLIST SET CLACT='False',CLAPP='True' WHERE CLTYP='EOQ'")
        Else
            UPD.Execute("UPDATE CHKLIST SET CLACT='True' WHERE CLTYP='EOQ'")
        End If
        If CTRL_S.EOYF Then
            UPD.Execute("UPDATE CHKLIST SET CLACT='False',CLAPP='True' WHERE CLTYP='EOY'")
        Else
            UPD.Execute("UPDATE CHKLIST SET CLACT='True' WHERE CLTYP='EOY'")
        End If
        rExec("UPDATE CTRL_S SET OTC_FLAG='True'")

        SW = True
        MsgBox("Over the counter transactions closed !!! ")
    End Sub

    Private Sub frmSDS_Close_OTC_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
