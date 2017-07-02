Imports System.Windows.Forms
Imports SDS.BusinessLogic
Imports SDS.Common
Imports SDS.Common.Utilities

Public Class frmRecalculateLedger
    Dim batch_Ran As Boolean

    Public Sub New(ByVal MsgSvc As IMessagePromptBusinessLogic)

        _IMessageService = MsgSvc        
        InitializeComponent()
    End Sub

    Private _IMessageService As IMessagePromptBusinessLogic
    Private CalculatorService As IRecalculateLedgerBusinessLogic

    Private _StartDate As Date
    Public Property StartDate() As Date
        Get
            Return _StartDate
        End Get
        Set(ByVal value As Date)
            _StartDate = value
        End Set
    End Property


    Private _AccountNo As String
    Public Property AccountNo() As String
        Get
            Return _AccountNo
        End Get
        Set(ByVal value As String)
            _AccountNo = value
        End Set
    End Property



    Private Result As RecalculateLedgerResult
    Private Sub bgwOTCProcess_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwOTCProcess.DoWork
        CalculatorService = New RecalculateLedgerBusinessLogic(AccountNo, StartDate)
        Result = CalculatorService.Calculate()
    End Sub

    Private Sub bgwOTCProcess_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwOTCProcess.RunWorkerCompleted
        _IMessageService.GetMessageFromResult(Result)
        lblStatus.Text = String.Empty
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        If rbRecalculateAll.Checked Or rbRecalculateIndividual.Checked Then            
            StartDate = dtpStartDate.Value
            lblStatus.Text = GetGlobalResourceString("Calculating")
            bgwOTCProcess.RunWorkerAsync()
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnSearchMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchMember.Click
        Using MemberSearchForm As New frmMemberSearchDialog(MemberSearchType.SavingsMasterData)
            If MemberSearchForm.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                AccountNo = SEL_KBCI_NO
                txtSelectedMember.Text = SEL_FNAME
            End If
        End Using
    End Sub

    Private Sub rbRecalculateIndividual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRecalculateIndividual.CheckedChanged
        btnSearchMember.Enabled = rbRecalculateIndividual.Checked

        If Not rbRecalculateIndividual.Checked Then
            txtSelectedMember.Text = String.Empty
        End If
    End Sub

    Private Sub rbRecalculateAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRecalculateAll.CheckedChanged
        If rbRecalculateAll.Checked Then
            AccountNo = String.Empty
        End If
    End Sub

    Private Sub frmRecalculateLedger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpStartDate.Value = Now
    End Sub
End Class
