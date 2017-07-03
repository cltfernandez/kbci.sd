<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LedgerRecalculationDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LedgerRecalculationDialog))
        Me.bgwOTCProcess = New System.ComponentModel.BackgroundWorker
        Me.rbRecalculateAll = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnSearchMember = New System.Windows.Forms.Button
        Me.txtSelectedMember = New System.Windows.Forms.TextBox
        Me.rbRecalculateIndividual = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.lblStatus = New System.Windows.Forms.Label
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bgwOTCProcess
        '
        Me.bgwOTCProcess.WorkerReportsProgress = True
        Me.bgwOTCProcess.WorkerSupportsCancellation = True
        '
        'rbRecalculateAll
        '
        Me.rbRecalculateAll.AutoSize = True
        Me.rbRecalculateAll.Checked = True
        Me.rbRecalculateAll.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rbRecalculateAll.Location = New System.Drawing.Point(6, 20)
        Me.rbRecalculateAll.Name = "rbRecalculateAll"
        Me.rbRecalculateAll.Size = New System.Drawing.Size(42, 17)
        Me.rbRecalculateAll.TabIndex = 0
        Me.rbRecalculateAll.TabStop = True
        Me.rbRecalculateAll.Text = "All"
        Me.rbRecalculateAll.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearchMember)
        Me.GroupBox1.Controls.Add(Me.txtSelectedMember)
        Me.GroupBox1.Controls.Add(Me.rbRecalculateIndividual)
        Me.GroupBox1.Controls.Add(Me.rbRecalculateAll)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 74)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calculation Type"
        '
        'btnSearchMember
        '
        Me.btnSearchMember.BackgroundImage = CType(resources.GetObject("btnSearchMember.BackgroundImage"), System.Drawing.Image)
        Me.btnSearchMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSearchMember.Enabled = False
        Me.btnSearchMember.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchMember.Location = New System.Drawing.Point(331, 41)
        Me.btnSearchMember.Name = "btnSearchMember"
        Me.btnSearchMember.Size = New System.Drawing.Size(31, 22)
        Me.btnSearchMember.TabIndex = 7
        '
        'txtSelectedMember
        '
        Me.txtSelectedMember.Enabled = False
        Me.txtSelectedMember.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelectedMember.Location = New System.Drawing.Point(103, 42)
        Me.txtSelectedMember.Name = "txtSelectedMember"
        Me.txtSelectedMember.Size = New System.Drawing.Size(213, 21)
        Me.txtSelectedMember.TabIndex = 6
        '
        'rbRecalculateIndividual
        '
        Me.rbRecalculateIndividual.AutoSize = True
        Me.rbRecalculateIndividual.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rbRecalculateIndividual.Location = New System.Drawing.Point(6, 43)
        Me.rbRecalculateIndividual.Name = "rbRecalculateIndividual"
        Me.rbRecalculateIndividual.Size = New System.Drawing.Size(91, 17)
        Me.rbRecalculateIndividual.TabIndex = 1
        Me.rbRecalculateIndividual.Text = "Individual"
        Me.rbRecalculateIndividual.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 21)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Start Date:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCalculate
        '
        Me.btnCalculate.BackgroundImage = CType(resources.GetObject("btnCalculate.BackgroundImage"), System.Drawing.Image)
        Me.btnCalculate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(152, 136)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(111, 23)
        Me.btnCalculate.TabIndex = 50
        Me.btnCalculate.Text = "&Calculate"
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(269, 136)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(111, 23)
        Me.btnClose.TabIndex = 51
        Me.btnClose.Text = "C&lose"
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(15, 136)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(94, 21)
        Me.lblStatus.TabIndex = 52
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(115, 92)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(148, 21)
        Me.dtpStartDate.TabIndex = 53
        '
        'frmRecalculateLedger
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(393, 171)
        Me.ControlBox = False
        Me.Controls.Add(Me.dtpStartDate)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRecalculateLedger"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bgwOTCProcess As System.ComponentModel.BackgroundWorker
    Friend WithEvents rbRecalculateAll As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbRecalculateIndividual As System.Windows.Forms.RadioButton
    Friend WithEvents btnSearchMember As System.Windows.Forms.Button
    Friend WithEvents txtSelectedMember As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker

End Class
