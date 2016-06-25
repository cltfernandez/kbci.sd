Imports SDS.BusinessLogic
Imports SDS.ViewModels
Imports System.Text.RegularExpressions

Public Class PolicyDefinitionsForm

    Private _formService As IFormOperations

    Sub New()
        _formService = New PolicyDefinitionsService()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click        
        If Button6.Text = "E&dit" Then
            Button6.Text = "Sa&ve"
            EorD(True, GroupBox1)
        Else
            Dim model = CreateModel()
            _formService.SaveData(model)
            Button6.Text = "E&dit"
            EorD(False, GroupBox1)
            MsgBox("Updated Successfully!", MsgBoxStyle.Information, "Control File")
        End If
    End Sub

    Private Sub frmSDS_Main_Ctrl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ctrlViewModel = DirectCast(_formService.GetData(), [PolicyDefinitionsViewModel])
        LoadData(ctrlViewModel)
    End Sub
    Sub EorD(ByVal sw As Boolean, ByRef grp As GroupBox)
        Dim CTRLS As Control
        For Each CTRLS In grp.Controls
            If Not TypeOf CTRLS Is CheckBox Then CTRLS.Enabled = sw
        Next
    End Sub

    Private Sub txtDormancyFee_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDormancyFee.LostFocus
        If IsNumeric(txtDormancyFee.Text) Then txtDormancyFee.Text = FormatNumber(txtDormancyFee.Text, 2) Else MsgBox("Please input numeric characters", MsgBoxStyle.Information, "Invalid Amount") : txtDormancyFee.Text = "0.00"
    End Sub

    Private Sub TextBox5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.LostFocus
        If IsNumeric(TextBox5.Text) Then TextBox5.Text = FormatNumber(TextBox5.Text, 2) Else MsgBox("Please input numeric characters", MsgBoxStyle.Information, "Invalid Amount") : TextBox5.Text = "0.00"
    End Sub
    Private Sub txtMinimumInterestEarningBalance_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMinimumInterestEarningBalance.LostFocus
        If IsNumeric(txtMinimumInterestEarningBalance.Text) Then txtMinimumInterestEarningBalance.Text = FormatNumber(txtMinimumInterestEarningBalance.Text, 2) Else MsgBox("Please input numeric characters", MsgBoxStyle.Information, "Invalid Amount") : txtMinimumInterestEarningBalance.Text = "0.00"
    End Sub
    Private Sub LoadData(ByVal model As PolicyDefinitionsViewModel)
        With model
            NumericUpDown1.Value = .IssuedCheckClearingDays
            NumericUpDown2.Value = .LocalCheckClearingDays
            NumericUpDown3.Value = .RegularCheckClearingDays
            TextBox5.Text = FormatNumber(.MinimumBalance)
            NumericUpDown4.Value = FormatNumber(.InterestRate)
            NumericUpDown5.Value = .AccountDormancyDays
            TextBox2.Text = .AccountBranch
            TextBox1.Text = .AccountSequence
            txtDormancyFee.Text = FormatNumber(.DormancyCharge)
            txtMinimumInterestEarningBalance.Text = FormatNumber(.MinimumInterestEarningBalance)
            CheckBox2.Checked = .IsEndOfMonth
            CheckBox1.Checked = .IsEndOfQuarter
            CheckBox4.Checked = .IsEndOfYear
            CheckBox3.Checked = .IsOverTheCounterClosed
        End With
    End Sub
    Private Function CreateModel() As PolicyDefinitionsViewModel
        Dim model As New PolicyDefinitionsViewModel
        With model
            .IssuedCheckClearingDays = NumericUpDown1.Value
            .LocalCheckClearingDays = NumericUpDown2.Value
            .RegularCheckClearingDays = NumericUpDown3.Value
            .MinimumBalance = TextBox5.Text
            .InterestRate = NumericUpDown4.Value
            .AccountDormancyDays = NumericUpDown5.Value
            .AccountBranch = TextBox2.Text
            .AccountSequence = TextBox1.Text
            .DormancyCharge = txtDormancyFee.Text
            .MinimumInterestEarningBalance = txtMinimumInterestEarningBalance.Text
            .IsEndOfMonth = CheckBox2.Checked
            .IsEndOfQuarter = CheckBox1.Checked
            .IsEndOfYear = CheckBox4.Checked
            .IsOverTheCounterClosed = CheckBox3.Checked
            .CHG_DATE = CTRL_S.SYSDATE
            .UserName = SPUSER.USER
        End With
        Return model
    End Function

    Private Sub TextBox5_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        DecimalValidator(e)
    End Sub

    Private Sub txtDormancyFee_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDormancyFee.KeyPress
        DecimalValidator(e)
    End Sub

    Private Sub txtMinimumInterestEarningBalance_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMinimumInterestEarningBalance.KeyPress
        DecimalValidator(e)
    End Sub
End Class