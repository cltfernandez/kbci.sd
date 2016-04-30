Public Class frmSDS_Main_SetDate

    Private Sub frmSDS_Main_SetDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = DateValue(CTRL_S.SYSDATE)
        DateTimePicker2.Value = DateValue(CTRL_S.SYSDATE)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ovuser As String        
        Try
            If DateValue(DateTimePicker2.Value) <= DateValue(CTRL_S.SYSDATE) Then MsgBox("Banking Date should be not less than or equal to Current Sysdate.", MsgBoxStyle.Critical, "Error") : Exit Sub
            If DateTimePicker2.Value.DayOfWeek = DayOfWeek.Saturday Or DateTimePicker2.Value.DayOfWeek = DayOfWeek.Sunday Then MsgBox("Date entered is a " & DateTimePicker2.Value.ToString("dddd")) : Exit Sub

            If CInt(SPUSER.SPUSERPOS) <> 3 Then
                MsgBox("You are not allowed to Set the Banking Date.", MsgBoxStyle.Information, "Set Banking Date")
                ovuser = OVRRIDE()
                If Trim(ovuser) = "" Then
                    MsgBox("User is not allowed to override.", MsgBoxStyle.Critical, "Set Banking Date") : Exit Sub
                Else
                    CTRL_S.ADMDATE = DateValue(DateTimePicker2.Value)
                    MsgBox("Banking Date was set successfully!", MsgBoxStyle.Information, "Set Banking Date")
                    Me.Dispose()
                End If
            Else

                CTRL_S.ADMDATE = DateValue(DateTimePicker2.Value)
                MsgBox("Banking Date was set successfully!", MsgBoxStyle.Information, "Set Banking Date")
                Me.Dispose()
            End If
        Catch ex As Exception
            If Err.Number = 9 Then
                MsgBox("User is not allowed to override.", MsgBoxStyle.Critical, "Set Banking Date") : ovuser = OVRRIDE()
                If Trim(ovuser) = "" Then
                    MsgBox("User is not allowed to override.", MsgBoxStyle.Critical, "Set Banking Date") : Exit Sub
                Else
                    CTRL_S.ADMDATE = DateValue(DateTimePicker2.Value)
                    MsgBox("Banking Date was set successfully!", MsgBoxStyle.Information, "Set Banking Date")
                    Me.Dispose()
                End If
            Else
                MsgBox(ex.Message)
            End If
        Finally
            CTRL_S.updData()
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim msg As String
        msg = MsgBox("Application will exit now, would you like to proceed?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Exit Application")
        If msg = vbYes Then
            Application.Exit()
            Me.Close()
        End If
    End Sub
End Class