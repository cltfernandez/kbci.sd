Public Class frmSDS_Main_Access
    Dim DB As New CLTF.DB.SQLDBConnection
    Dim FL As New CLTF.ListViewFiller
    Dim MYSPTAG() As Char
    Dim EDIT As Boolean
    Dim SPUSER_ID As String
    Private Sub frmSDS_Main_Access_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DB.OpenCmdDataTable(rCN, "SELECT SPUSER_ID,SPUSERID,SPUSERPASS,SPUSERNAME,SPUSERPOS,SPLOGSTAT,SPLOGNO,SPTELLER,SPTAG,ADD_DATE,CHG_DATE,[USER] FROM SPUSER WHERE SPUSERID<>'" & SPUSER.SPUSERID & "'")
        FL.ColTextFormat = "1:1:1:1:2:2:2:2:1:1:1:1"
        FL.ColWidthSettings = "0:100:0:167:79:78:65:68:297:83:83:51"
        FL.FillListView(ListView1, DB.GetTable, False)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            If ListView1.SelectedIndices.Count > 0 Then
                SPUSER_ID = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(0).Text
                TextBox6.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(1).Text
                TextBox1.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(2).Text
                TextBox2.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(3).Text
                MYSPTAG = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(8).Text.ToCharArray
                ComboBox1.Text = ComboBox1.Items.Item(CInt(ListView1.Items(ListView1.SelectedIndices(0)).SubItems(4).Text) - 1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Critical Error")
        End Try
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Button5.Text = "Close" Then
            Me.Dispose()
        Else
            Button4.Enabled = True
            Button7.Enabled = True
            Button5.Text = "Close"
            Button2.Text = "Reset Password"
            TextBox1.Enabled = False : TextBox1.Text = ""
            TextBox3.Enabled = False : TextBox3.Text = ""
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        EDIT = True
        GroupBox3.Visible = False
        EorD(GroupBox1, True)
        LorN()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim ctrl As Control
        EDIT = False
        GroupBox3.Visible = False
        EorD(GroupBox1, True)
        For Each ctrl In GroupBox1.Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then ctrl.Text = ""
        Next
        LorN()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GroupBox3.Visible = True
        EorD(GroupBox1, False)
    End Sub
    Sub EorD(ByRef GB As GroupBox, ByVal SWT As Boolean)
        Dim ctrl As Control
        For Each ctrl In GroupBox1.Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then ctrl.Enabled = SWT
        Next
    End Sub
    Sub LorN()
        Dim X, ACCS As Integer

        Dim DB As New CLTF.DB.SQLDBConnection
        Dim FL As New CLTF.ListViewFiller
        DB.OpenCmdDataTable(rCN, "SELECT SDDESC DESCRIPTION,SDTITL FROM SDOPTION ")
        FL.ColTextFormat = "1:1"
        FL.ColWidthSettings = "500:0"
        FL.FillListView(ListView2, DB.GetTable, False)
        ACCS = 0
        With ListView2
            For X = 0 To .Items.Count - 1
                If CBool(.Items(X).SubItems(1).Text) = False Then
                    .Items(X).Checked = CBool(CInt(CStr(MYSPTAG(ACCS))))
                    ACCS += 1
                End If
            Next
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim upd As New CLTF.DB.SQLDBConnection
        Dim ACC As String = ""
        Dim CTRL5 As Control
        Dim X As Integer

        For Each CTRL5 In GroupBox1.Controls
            If TypeOf CTRL5 Is TextBox Or TypeOf CTRL5 Is ComboBox Then
                If Trim(CTRL5.Text) = "" Then MsgBox("Please fill-out all fields.", MsgBoxStyle.Exclamation, "USER ACCESS") : Exit Sub
            End If
        Next        
        With ListView2
            ACC = ""
            For X = 0 To .Items.Count - 1
                If CBool(.Items(X).SubItems(1).Text) = False Then
                    ACC = ACC & Abs(CInt(.Items(X).Checked))
                End If
            Next
        End With

        Dim Crypt As New Crpyt(TextBox1.Text, System.Configuration.ConfigurationManager.AppSettings("32"))
        If EDIT Then
            upd.OpenCommand(rCN)
            MsgBox("Updated [" & upd.Execute("UPDATE SPUSER SET " & _
                        "SPUSERID='" & TextBox6.Text.ToUpper & "'" & _
                        ",SPUSERNAME='" & TextBox2.Text.ToUpper & "'" & _
                        ",SPUSERPASS='" & Microsoft.VisualBasic.Left(Crypt.Encrypt, 8) & "'" & _
                        ",SPUSERPOS='" & ComboBox1.SelectedIndex + 1 & "'" & _
                        ",SPTAG='" & ACC & "'" & _
                        ",CHG_DATE='" & CTRL_S.SYSDATE & "'" & _
                        ",[USER]='" & SPUSER.SPUSERID & "'" & _
                        " WHERE SPUSER_ID='" & SPUSER_ID & "'") & "] record.", MsgBoxStyle.Information, "USER ACCESS")
        Else
            If TextBox1.Text <> TextBox3.Text Then MsgBox("Confirm password incorrect!", MsgBoxStyle.Exclamation, "USER ACCESS") : Exit Sub
            If USERExist(TextBox6.Text) Then MsgBox("Username is already existing on the database, please choose another.", MsgBoxStyle.Exclamation, "USER ACCESS") : Exit Sub
            Dim qrey As String

            upd.OpenCommand(rCN)
            qrey = "INSERT INTO [kbci].[dbo].[SPUSER]" & _
                   "([SPUSERID]" & _
                   ",[SPUSERPASS]" & _
                   ",[SPUSERNAME]" & _
                   ",[SPUSERPOS]" & _
                   ",[SPLOGSTAT]" & _
                   ",[SPLOGNO]" & _
                   ",[SPTELLER]" & _
                   ",[SPTAG]" & _
                   ",[ADD_DATE]" & _
                   ",[CHG_DATE]" & _
                   ",[USER]) VALUES(" & _
                   "'" & TextBox6.Text.ToUpper & "'" & _
                   ",'" & Microsoft.VisualBasic.Left(Crypt.Encrypt, 8) & "'" & _
                   ",'" & TextBox2.Text.ToUpper & "'" & _
                   ",'" & ComboBox1.SelectedIndex + 1 & "'" & _
                   ",'0'" & _
                   ",'0'" & _
                   ",'0'" & _
                   ",'" & ACC & "'" & _
                   ",'" & CTRL_S.SYSDATE & "'" & _
                   ",'" & CTRL_S.SYSDATE & "'" & _
                   ",'" & SPUSER.SPUSERID & "')"
            MsgBox("Added [" & upd.Execute(qrey) & "] record/s to database. ", MsgBoxStyle.Information, "USER ACCESS")
        End If
        DB.Requery()
        FL.FillListView(ListView1, DB.GetTable, False)
        Button3.PerformClick()
    End Sub
    Sub RESET()
        Dim CTRL5 As Control
        For Each CTRL5 In GroupBox1.Controls
            If TypeOf CTRL5 Is TextBox Or TypeOf CTRL5 Is ComboBox Then CTRL5.Text = ""
        Next
    End Sub
    Function USERExist(ByVal USRE As String) As Boolean
        Dim DBB As New CLTF.DB.SQLDBConnection
        DBB.OpenCmdDataTable(rCN, "SELECT SPUSER_ID FROM SPUSER WHERE SPUSERID='" & USRE.Trim & "'")
        If DBB.DataCount > 0 Then Return True Else Return False
        DBB.CloseDataTable()
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "Reset Password" Then
            Button2.Text = "Save"
            Button5.Text = "Cancel"
            Button4.Enabled = False
            Button7.Enabled = False
            TextBox1.Enabled = True : TextBox1.Text = ""
            TextBox3.Enabled = True : TextBox3.Text = ""
        Else
            If TextBox1.Text <> TextBox3.Text Then MsgBox("Confirm password incorrect!", MsgBoxStyle.Exclamation, "USER ACCESS") : Exit Sub
            Dim upd As New CLTF.DB.SQLDBConnection
            Dim Crypt As New Crpyt(TextBox1.Text, System.Configuration.ConfigurationManager.AppSettings("32"))
            upd.OpenCommand(rCN)
            MsgBox("Updated [" & upd.Execute("UPDATE SPUSER SET " & _
                        "SPUSERPASS='" & Microsoft.VisualBasic.Left(Crypt.Encrypt, 8) & "'" & _
                        " WHERE SPUSER_ID='" & SPUSER_ID & "'") & "] record.", MsgBoxStyle.Information, "USER ACCESS")
            Button5.PerformClick()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim msg As String
        Dim UP As New CLTF.DB.SQLDBConnection
        msg = MsgBox("Would you like to delete this User Account?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "USER ACCESS")
        If msg = vbYes Then
            UP.OpenCommand(rCN)
            MsgBox("UPDATED [" & UP.Execute("DELETE FROM SPUSER WHERE SPUSER_ID='" & SPUSER_ID & "'") & "] record.", MsgBoxStyle.Information, "USER ACCESS")
            DB.Requery()
            FL.FillListView(ListView1, DB.GetTable, False)
        End If
    End Sub
End Class