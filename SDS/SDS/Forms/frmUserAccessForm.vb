Imports SDS.BusinessLogic
Imports SDS.ViewModels
Imports SDS.Common.Utilities
Imports SDS.Common
Public Class frmUserAccessForm
    Dim MYSPTAG() As Char
    Dim EDIT As Boolean
    Dim SPUSER_ID As String
    Private viewModel As New UserAccessViewModel
    Private svc As IFormOperations
    Private MessageService As IMessagePromptBusinessLogic
    Private SelectedUser As UserViewModel

    Private Sub frmSDS_Main_Access_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Try

            If ListView1.SelectedIndices.Count > 0 Then
                btnResetPassword.Enabled = True
                SelectedUser = viewModel.UserList.Find(Function(x) x.Id.Equals(Integer.Parse(ListView1.Items(ListView1.SelectedIndices(0)).SubItems(0).Text)))
                With SelectedUser
                    SPUSER_ID = .Id
                    txtUsername.Text = .UserId
                    txtPassword.Text = .Password
                    txtFullName.Text = .FullName
                    MYSPTAG = .UserPermission.ToCharArray
                    ddlPosition.Text = ddlPosition.Items.Item(CInt(.Position) - 1)
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Critical Error")
        End Try
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If btnClose.Text = GetGlobalResourceString("Close") Then
            Me.Dispose()
        Else
            InitializeControls()
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        EDIT = True
        GroupBox3.Visible = False
        EnableContainerControls(GroupBox1, True)
        LorN()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewUser.Click
        Dim ctrl As Control
        EDIT = False
        MYSPTAG = (New String("0", 31)).ToCharArray
        GroupBox3.Visible = False
        EnableContainerControls(GroupBox1, True)
        For Each ctrl In GroupBox1.Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then ctrl.Text = ""
        Next
        LorN()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GroupBox3.Visible = True
        EnableContainerControls(GroupBox1, False)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim upd As New CLTF.DB.SQLDBConnection
        Dim ACC As String = ""
        Dim CTRL5 As Control
        Dim X As Integer

        For Each CTRL5 In GroupBox1.Controls
            If TypeOf CTRL5 Is TextBox Or TypeOf CTRL5 Is ComboBox Then
                If Trim(CTRL5.Text) = "" And CTRL5.Name <> "txtConfirmPassword" Then MsgBox(GetGlobalResourceString("FillOutAllFields"), MsgBoxStyle.Exclamation, GetGlobalResourceString("SavingsDepositUserAccess")) : Exit Sub
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

        Dim Crypt As New Crpyt(txtPassword.Text, System.Configuration.ConfigurationManager.AppSettings("32"))
        MessageService = New DataOperationPrompt

        If EDIT Then
            With SelectedUser
                .UserId = txtUsername.Text.ToUpper
                .FullName = txtFullName.Text.ToUpper
                .Password = txtPassword.Text
                .Position = ddlPosition.SelectedIndex + 1
                .UserPermission = ACC
                .DateUpdated = CTRL_S.SYSDATE
                .ChangedByUser = SPUSER.SPUSERID
            End With
        Else
            If txtPassword.Text <> txtConfirmPassword.Text Then MsgBox(GetGlobalResourceString("ConfirmPasswordNotMatch"), MsgBoxStyle.Exclamation, GetGlobalResourceString("SavingsDepositUserAccess")) : Exit Sub

            Dim newUser As New UserViewModel With { _
                            .UserId = txtUsername.Text.ToUpper, _
                            .FullName = txtFullName.Text.ToUpper, _
                            .Password = Microsoft.VisualBasic.Left(Crypt.Encrypt, 8), _
                            .Position = ddlPosition.SelectedIndex + 1, _
                            .IsLocked = False, _
                            .LockOutCount = 0, _
                            .IsTeller = ddlPosition.SelectedIndex + 1 = Position.Teller, _
                            .UserPermission = ACC, _
                            .DateAdded = CTRL_S.SYSDATE, _
                            .DateUpdated = CTRL_S.SYSDATE, _
                            .ChangedByUser = SPUSER.SPUSERID}
            SelectedUser = newUser
        End If
        Dim result = svc.SaveData(SelectedUser)
        MessageService.GetMessageFromResult(result)
        If Not result = RecordUpdateResult.RecordExists And Not result = RecordUpdateResult.Unsuccessful Then
            LoadData()
            Button3.PerformClick()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetPassword.Click
        If btnResetPassword.Text = GetGlobalResourceString("ResetPassword") Then
            btnResetPassword.Text = GetGlobalResourceString("Save")
            btnClose.Text = GetGlobalResourceString("Cancel")
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
            btnNewUser.Enabled = False
            txtPassword.Enabled = True : txtPassword.Text = ""
            txtConfirmPassword.Enabled = True : txtConfirmPassword.Text = ""
        Else            
            MessageService = New ChangePasswordPrompts
            Dim resetPasswordVm As New ChangePasswordViewModel With {.Id = SelectedUser.Id, _
                                                                     .UserName = SelectedUser.UserId, _
                                                                     .OldPassword = txtPassword.Text, _
                                                                     .NewPassword = txtPassword.Text, _
                                                                     .ConfirmPassword = txtConfirmPassword.Text}

            svc = New ChangePasswordService(True)
            Dim result = svc.SaveData(resetPasswordVm)
            MessageService.GetMessageFromResult(result)
            If result = ChangePasswordResult.Successful Then
                InitializeControls()
            End If

        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim msg As String
        msg = MsgBox(GetGlobalResourceString("ConfirmDelete"), MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, GetGlobalResourceString("SavingsDepositUserAccess"))
        If msg = vbYes Then
            Dim result = svc.DeleteData(SelectedUser)
            MessageService = New DataOperationPrompt()
            MessageService.GetMessageFromResult(result)
            LoadData()
        End If
    End Sub

#Region "Private Methods"
    Private Sub InitializeControls()
        btnUpdate.Enabled = True
        btnNewUser.Enabled = True
        btnDelete.Enabled = True

        btnClose.Text = GetGlobalResourceString("Close")
        btnResetPassword.Text = GetGlobalResourceString("ResetPassword")
        txtPassword.Enabled = False : txtPassword.Text = ""
        txtConfirmPassword.Enabled = False : txtConfirmPassword.Text = ""
    End Sub
    Sub EnableContainerControls(ByRef GB As GroupBox, ByVal SWT As Boolean)
        Dim ctrl As Control
        For Each ctrl In GroupBox1.Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then ctrl.Enabled = SWT
        Next
    End Sub
    Sub LorN()
        Dim X, ACCS As Integer
        PopulateListView(ListView2, GetGridViewDataFromObject(viewModel.PermissionList, DataGridView2), ColumnWidthDefinition.PermissionList, ColumnAlignmentDefinition.PermissionList)
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
    Sub RESET()
        Dim CTRL5 As Control
        For Each CTRL5 In GroupBox1.Controls
            If TypeOf CTRL5 Is TextBox Or TypeOf CTRL5 Is ComboBox Then CTRL5.Text = ""
        Next
    End Sub
    Private Sub LoadData()
        svc = New UserSecurityService(SPUSER.SPUSER_ID)
        viewModel = svc.GetData
        PopulateListView(ListView1, GetGridViewDataFromObject(viewModel.UserList, DataGridView2), ColumnWidthDefinition.UserAccessList, ColumnAlignmentDefinition.UserAccessList)
    End Sub
#End Region

End Class