Public Class frmSDS_Main_TEntry
    Inherits System.Windows.Forms.Form

    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Button5 As System.Windows.Forms.Button

    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Dim frmSDS_Main_TEntry_Tran As frmSDS_Main_TEntry_Tran
    Dim frmSDS_Main_TEntry_TranUpdate As frmSDS_Main_TEntry_TranUpdate
    Dim qryMEM, qryTRAN, fField, srchSTR As String
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Dim eload As Boolean

    Private acctslist As ent_sdmaster_list
    Private selectedacct As ent_sdmaster
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnUpdateTransaction As System.Windows.Forms.Button
    Private closeform As Boolean = False

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblacctabal As System.Windows.Forms.Label
    Friend WithEvents lblacctfloats As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblacctobal As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblacctlbal As System.Windows.Forms.Label
    Friend WithEvents lblacctpbal As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSDS_Main_TEntry))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.NumericUpDown
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnUpdateTransaction = New System.Windows.Forms.Button
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.lblacctabal = New System.Windows.Forms.Label
        Me.lblacctfloats = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.lblacctobal = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.lblacctlbal = New System.Windows.Forms.Label
        Me.lblacctpbal = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.DataGridView3 = New System.Windows.Forms.DataGridView
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label6 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button11 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.DataGridView3)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(896, 585)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox5.Controls.Add(Me.Button8)
        Me.GroupBox5.Controls.Add(Me.Button9)
        Me.GroupBox5.Controls.Add(Me.TextBox5)
        Me.GroupBox5.Location = New System.Drawing.Point(339, 303)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(252, 37)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Visible = False
        '
        'Button8
        '
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(190, 10)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(58, 21)
        Me.Button8.TabIndex = 0
        Me.Button8.Text = "CANCEL"
        '
        'Button9
        '
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(147, 10)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(37, 21)
        Me.Button9.TabIndex = 43
        Me.Button9.Text = "OK"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(5, 10)
        Me.TextBox5.MaxLength = 20
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(136, 21)
        Me.TextBox5.TabIndex = 42
        Me.TextBox5.Text = "0.00"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox4.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.TextBox3)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(394, 321)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(132, 59)
        Me.GroupBox4.TabIndex = 33
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-2, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Press <ENTER> to confirm"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(43, 20)
        Me.TextBox3.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.TextBox3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(47, 21)
        Me.TextBox3.TabIndex = 5
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox3.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Print Line"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.btnUpdateTransaction)
        Me.GroupBox3.Controls.Add(Me.CheckBox2)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.DataGridView2)
        Me.GroupBox3.Controls.Add(Me.lblacctabal)
        Me.GroupBox3.Controls.Add(Me.lblacctfloats)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.lblacctobal)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.lblacctlbal)
        Me.GroupBox3.Controls.Add(Me.lblacctpbal)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Controls.Add(Me.ListView2)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 151)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(864, 423)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'btnUpdateTransaction
        '
        Me.btnUpdateTransaction.BackgroundImage = CType(resources.GetObject("btnUpdateTransaction.BackgroundImage"), System.Drawing.Image)
        Me.btnUpdateTransaction.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateTransaction.Location = New System.Drawing.Point(204, 385)
        Me.btnUpdateTransaction.Name = "btnUpdateTransaction"
        Me.btnUpdateTransaction.Size = New System.Drawing.Size(113, 23)
        Me.btnUpdateTransaction.TabIndex = 30
        Me.btnUpdateTransaction.Text = "&Update"
        Me.btnUpdateTransaction.Visible = False
        '
        'CheckBox2
        '
        Me.CheckBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(608, 73)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(112, 16)
        Me.CheckBox2.TabIndex = 7
        Me.CheckBox2.Text = "Error Correct"
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(720, 385)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(128, 23)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Close"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView2.Location = New System.Drawing.Point(17, 379)
        Me.DataGridView2.Name = "DataGridView2"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView2.Size = New System.Drawing.Size(173, 18)
        Me.DataGridView2.TabIndex = 29
        Me.DataGridView2.Visible = False
        '
        'lblacctabal
        '
        Me.lblacctabal.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.lblacctabal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacctabal.ForeColor = System.Drawing.Color.DimGray
        Me.lblacctabal.Location = New System.Drawing.Point(715, 43)
        Me.lblacctabal.Name = "lblacctabal"
        Me.lblacctabal.Size = New System.Drawing.Size(128, 20)
        Me.lblacctabal.TabIndex = 27
        Me.lblacctabal.Text = "0.00"
        Me.lblacctabal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblacctfloats
        '
        Me.lblacctfloats.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.lblacctfloats.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacctfloats.ForeColor = System.Drawing.Color.DimGray
        Me.lblacctfloats.Location = New System.Drawing.Point(434, 43)
        Me.lblacctfloats.Name = "lblacctfloats"
        Me.lblacctfloats.Size = New System.Drawing.Size(128, 20)
        Me.lblacctfloats.TabIndex = 27
        Me.lblacctfloats.Text = "0.00"
        Me.lblacctfloats.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(583, 43)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(124, 16)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "Available :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblacctobal
        '
        Me.lblacctobal.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.lblacctobal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacctobal.ForeColor = System.Drawing.Color.DimGray
        Me.lblacctobal.Location = New System.Drawing.Point(437, 21)
        Me.lblacctobal.Name = "lblacctobal"
        Me.lblacctobal.Size = New System.Drawing.Size(125, 20)
        Me.lblacctobal.TabIndex = 26
        Me.lblacctobal.Text = "0.00"
        Me.lblacctobal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(302, 43)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(124, 16)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Float Balance :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(302, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(124, 20)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "O/S Balance :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblacctlbal
        '
        Me.lblacctlbal.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.lblacctlbal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacctlbal.ForeColor = System.Drawing.Color.DimGray
        Me.lblacctlbal.Location = New System.Drawing.Point(149, 43)
        Me.lblacctlbal.Name = "lblacctlbal"
        Me.lblacctlbal.Size = New System.Drawing.Size(128, 20)
        Me.lblacctlbal.TabIndex = 23
        Me.lblacctlbal.Text = "0.00"
        Me.lblacctlbal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblacctpbal
        '
        Me.lblacctpbal.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.lblacctpbal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacctpbal.ForeColor = System.Drawing.Color.DimGray
        Me.lblacctpbal.Location = New System.Drawing.Point(152, 21)
        Me.lblacctpbal.Name = "lblacctpbal"
        Me.lblacctpbal.Size = New System.Drawing.Size(125, 20)
        Me.lblacctpbal.TabIndex = 22
        Me.lblacctpbal.Text = "0.00"
        Me.lblacctpbal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(17, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(124, 16)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Ledger Balance :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(142, 20)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Passbook Balance :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CheckBox1
        '
        Me.CheckBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(736, 73)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(112, 16)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Show History"
        '
        'ListView2
        '
        Me.ListView2.CheckBoxes = True
        Me.ListView2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.Location = New System.Drawing.Point(11, 92)
        Me.ListView2.MultiSelect = False
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(836, 276)
        Me.ListView2.TabIndex = 1
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 403)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Loading..."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Visible = False
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(455, 385)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "E&rror Correct"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 73)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(152, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Transaction Listing"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(323, 385)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(128, 23)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "A&dd Transaction"
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(589, 385)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(128, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Passbook &Update"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(11, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(836, 57)
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'Button7
        '
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(16, 551)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(132, 23)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = "Amend Hold-out"
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AllowUserToResizeColumns = False
        Me.DataGridView3.AllowUserToResizeRows = False
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView3.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridView3.Location = New System.Drawing.Point(707, 19)
        Me.DataGridView3.Name = "DataGridView3"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridView3.Size = New System.Drawing.Size(173, 18)
        Me.DataGridView3.TabIndex = 31
        Me.DataGridView3.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridView1.Location = New System.Drawing.Point(707, 43)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridView1.Size = New System.Drawing.Size(173, 18)
        Me.DataGridView1.TabIndex = 26
        Me.DataGridView1.Visible = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(78, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(384, 32)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "MEMBER INQUIRY/TRANSACTION"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(528, 50)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.Button11)
        Me.GroupBox2.Controls.Add(Me.Button10)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.DataGrid1)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(16, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(864, 80)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Button11
        '
        Me.Button11.BackgroundImage = CType(resources.GetObject("Button11.BackgroundImage"), System.Drawing.Image)
        Me.Button11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(771, 45)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(76, 21)
        Me.Button11.TabIndex = 4
        Me.Button11.Text = "Refresh"
        '
        'Button10
        '
        Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
        Me.Button10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(689, 45)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(76, 21)
        Me.Button10.TabIndex = 3
        Me.Button10.Text = "Find"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(333, 20)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(143, 21)
        Me.TextBox2.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Acct. No :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(88, 20)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(143, 21)
        Me.TextBox4.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(259, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KBCI No :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(88, 45)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(577, 21)
        Me.TextBox1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "NAME :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(32, 152)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(688, 24)
        Me.DataGrid1.TabIndex = 3
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(16, 173)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(864, 368)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(768, 551)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Close"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(648, 551)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Se&lect"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "MEMBERS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmSDS_Main_TEntry
        '
        Me.AcceptButton = Me.Button2
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(914, 605)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmSDS_Main_TEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Data Entry"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Sub ApplyAcc()
        If CBool(CInt(CStr(SPTAG(1)))) = False Then Button3.Enabled = False Else Button3.Enabled = True
        If CBool(CInt(CStr(SPTAG(2)))) = False Then Button4.Enabled = False Else Button4.Enabled = True
        If CBool(CInt(CStr(SPTAG(17)))) = False Then Button7.Enabled = False Else Button7.Enabled = True
    End Sub

    Private Sub frmSDS_Main_TEntry_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        getWID(ListView1, TextBox1)
    End Sub

    Private Sub frmSDS_Main_TEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            qryMEM = "select sdmaster_id,acctno ACCT_NO,isnull(kbci_no,'') KBCI_NO,isnull(acctname,'') NAME," & _
                    "isnull(acctpbal,'0.00') acctpbal,isnull(acctlbal,'0.00') acctlbal," & _
                    "isnull(acctobal,'0.00') acctobal,isnull(acctfloats,'0.00') acctfloats," & _
                    "isnull(acctabal,'0.00') acctabal,acctstat STATUS,holdout,lseq from sdmaster"
            'FillLV(ListView1, GetData(qryMEM, "", DataGridView1), "0:109:77:548:0:0:0:0:0:102:0:0", "1:2:2:1:1:1:1:1:1:2:1:1", False)
            LoadAcctsList()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ApplyAcc()
    End Sub


    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedIndices.Count > 0 Then Button2.PerformClick()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Dim acctbal As Decimal
        Try
            If ListView1.SelectedIndices.Count > 0 Then
                selectedacct = acctslist.Find(AddressOf FindID)
                With selectedacct
                    LSEQ = .LSEQ
                    ACCTOBAL = .ACCTOBAL
                    LHOLDOUT = CDbl(GetRStr("select isnull(sum(holdamt),'0') holdamt from lnhold where acctno='" & TextBox2.Text.Trim.Replace("-", "") & "' and holddate='" & CTRL_S.SYSDATE & "' and poststat=null", "holdamt", 0))
                    HOLDOUT = .HOLDOUT
                    ACCTABAL = .ACCTABAL
                    acctbal = ACCTABAL - (HOLDOUT + CDbl(CTRL_S.MINBAL) + LHOLDOUT)
                    ACCTSTAT = .ACCTSTAT
                    ACCTFLOATS = .ACCTFLOATS
                    ACCTPBAL = .ACCTPBAL
                    ACCTNUM = .ACCTNO
                    TextBox4.Text = Business.FormatSDAcctNo(.ACCTNO)
                    TextBox2.Text = Business.FormatSDKBCINo(.KBCINO)
                    TextBox1.Text = .ACCTNAME
                    lblacctpbal.Text = FormatNumber(.ACCTPBAL, 2)
                    lblacctlbal.Text = FormatNumber(.ACCTLBAL, 2)
                    lblacctobal.Text = FormatNumber(.ACCTOBAL, 2)
                    lblacctfloats.Text = FormatNumber(.ACCTFLOATS, 2)
                    If acctbal < 0 Then acctbal = 0
                    'lblacctabal.Text = FormatNumber(acctbal)
                    lblacctabal.Text = FormatNumber(acctbal, 2)
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Critical Error")
        End Try
    End Sub

    Private Sub TextBox4_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox4.KeyUp
        fField = "ACCTNO" : srchSTR = TextBox4.Text.Trim
    End Sub



    Private Sub TextBox2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyUp
        fField = "KBCI_NO" : srchSTR = TextBox2.Text.Trim
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try

            If ListView1.SelectedItems.Count > 0 Then
                SDMASTERID = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(0).Text.Trim                
                If recIsUsed(SDMASTERID) Then
                    If CInt(SPUSER.SPUSERPOS) <> 3 Then
                        MsgBox("This record is currently being modified by [" & ModifierID & "].", MsgBoxStyle.Information, "Transaction Entry") : Exit Sub
                    Else
                        If MsgBox("This record is currently being modified by [" & ModifierID & "]. Do you want to unlock the record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Transaction Entry") = MsgBoxResult.Yes Then
                            Dim UP As New CLTF.DB.SQLDBConnection
                            UP.OpenCommand(rCN)
                            UP.Execute("UPDATE SDMASTER SET UPD_USER='" & Microsoft.VisualBasic.Left(SPUSER.SPUSERID, 8) & "', REC_STAT='" & 0 & "' WHERE SDMASTER_ID='" & SDMASTERID & "'")
                            UP.CloseCommand()
                        End If
                        Exit Sub
                    End If
                End If


                If ListView1.Items(ListView1.SelectedIndices(0)).SubItems(9).Text.Trim.ToUpper <> "A" Then MsgBox("This Account is INACTIVE.", MsgBoxStyle.Information, "Member Transaction / Inquiry") : Exit Sub
                GroupBox3.Visible = True
                GroupBox2.Enabled = False
                CheckBox1.Checked = False
                Me.AcceptButton = Button6
                Me.CancelButton = Button5
                TextBox4.Enabled = False : TextBox2.Enabled = False : TextBox1.Enabled = False
                qryTRAN = "SELECT SDTRAN_ID,TRANSEQ AS SEQ,TRANCODE AS CODE,TRANDEB AS DEBIT,TRANCRE AS CREDIT,CHKNUM AS CHECK_NO," & _
                          "CHKBANK AS BANK,TRANDATE,PPOSTED PRINTED FROM SDTRAN WHERE ACCTNUM='" & TextBox4.Text.Trim.Replace("-", "") & _
                          "' ORDER BY SDTRAN_ID, SEQ, TRANDATE"
                FillLV(ListView2, GetData(qryTRAN, "TRANDATE = '" & CTRL_S.SYSDATE & "'", DataGridView2), "0:54:54:136:134:100:252:0:80", "1:2:2:3:3:1:1:0:4", True)
                LockREC(SDMASTERID, True)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            FillLV(ListView2, GetData(qryTRAN, "", DataGridView2), "0:54:54:134:134:100:232:0:80", "1:2:2:3:3:1:1:0:4", True)
        Else
            FillLV(ListView2, GetData(qryTRAN, "TRANDATE='" & CTRL_S.SYSDATE & "'", DataGridView2), "0:54:54:136:134:100:232:0:80", "1:2:2:3:3:1:1:0:4", True)
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try

            Dim lstLN As Integer
            frmSDS_Main_TEntry_Tran = New frmSDS_Main_TEntry_Tran
            frmSDS_Main_TEntry_Tran.ShowDialog()
            If SW = True Then
                If TRANCODE <> "NCD" And TRANCODE <> "NLD" And TRANCODE <> "NWD" Then
                    lstLN = CInt(GetRStr("SELECT ISNULL(PLINE,'1') PLINE FROM [SDMASTER] WHERE ACCTNO='" & ACCTNUM & "'", "PLINE", 0)) + 1
                    GetData("select sdtran_id,trandate,trancode,trandeb,trancre,tranbbal,tranebal from sdtran with (nolock) where acctnum='" & ACCTNUM & "' and pposted='False' order by trandate,sdtran_id", "", DataGridView3)
                    Me.CancelButton = Nothing
                    Me.AcceptButton = Nothing
                    GroupBox4.Visible = True
                    GroupBox3.Enabled = False
                    GroupBox4.BringToFront()
                    TextBox3.Text = lstLN
                    TextBox3.Focus()
                End If
                lblacctlbal.Text = FormatNumber(ACCTOBAL, 2)
                lblacctobal.Text = FormatNumber(ACCTOBAL, 2)
                lblacctfloats.Text = FormatNumber(ACCTFLOATS, 2)
                If FormatNumber((ACCTOBAL - ACCTFLOATS) - (HOLDOUT + CDbl(CTRL_S.MINBAL) + LHOLDOUT), 2) < 0 Then
                    lblacctabal.Text = "0.00"
                Else
                    ACCTABAL = (ACCTOBAL - ACCTFLOATS) - (HOLDOUT + CDbl(CTRL_S.MINBAL) + LHOLDOUT)
                    lblacctabal.Text = FormatNumber(ACCTABAL, 2)
                End If

                FillLV(ListView2, GetData(qryTRAN, "TRANDATE='" & CTRL_S.SYSDATE & "'", DataGridView2), "0:54:54:136:134:100:232:0:80", "1:2:2:3:3:1:1:0:4", True)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If CheckBox2.Checked Then
            CheckBox2.Checked = False
            FillLV(ListView2, GetData(qryTRAN, "TRANDATE='" & CTRL_S.SYSDATE & "'", DataGridView2), "0:54:54:136:134:100:232:0:80", "1:2:2:3:3:1:1:0:4", True)
        End If

        GroupBox3.Visible = False
        GroupBox2.Enabled = True
        TextBox4.Enabled = True : TextBox2.Enabled = True : TextBox1.Enabled = True
        If SW = True Then LoadAcctsList() : SW = False
        LockREC(SDMASTERID, False)
        Me.CancelButton = Button1
        Me.AcceptButton = Button2

    End Sub
    Sub print(ByVal str As String, Optional ByVal pSize As System.Drawing.Printing.PaperSize = Nothing)
        'Dim prtobj As New TextPrint(str, DEFPRINTER, pSize)
        RawPrinter.SendStringToPrinter(DEFPRINTER, Chr(27) & Chr(77) & Chr(15) & str & Chr(12))
        'prtobj.Print()
        'prtobj.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try

            Dim msg As String = ""
            Dim msg2 As String
            Dim x, prtLN As Integer
            Dim TCRED, TDEB As Decimal
            Dim CTRANCODE As String
            Dim IsPosted As Integer = 0



            If CheckBox2.Checked = True Then

                If ListView2.CheckedItems.Count > 0 And SPUSER.SPUSERPOS <> 3 Then
                    Dim frmSDS_Main_Ovrride As frmSDS_Main_Ovrride = New frmSDS_Main_Ovrride
                    frmSDS_Main_Ovrride.ShowDialog()
                    If SW = False Then
                        Exit Sub
                    End If
                End If

                msg = MsgBox("Would you like to reverse [" & ListView2.CheckedItems.Count & "] transactions?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Error Correction")
                msg2 = MsgBox("Would you like to post this on the passbook?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Passbook Print")
                If msg = vbYes Then
                    With ListView2
                        For x = 0 To ListView2.CheckedItems.Count - 1
                            LSEQ += 1
                            If LSEQ > 999 Then LSEQ = 1
                            CTRANCODE = .CheckedItems(x).SubItems(2).Text
                            If CDbl(.CheckedItems(x).SubItems(4).Text) > 0 And CDbl(.CheckedItems(x).SubItems(3).Text) < 1 Then
                                TRANCODE = "ECC"
                                TDEB = CDbl(.CheckedItems(x).SubItems(4).Text)
                                TCRED = 0
                            ElseIf CDbl(.CheckedItems(x).SubItems(4).Text) < 1 And CDbl(.CheckedItems(x).SubItems(3).Text) > 0 Then
                                TRANCODE = "ECD"
                                TDEB = 0
                                TCRED = CDbl(.CheckedItems(x).SubItems(3).Text)
                            End If

                            If msg2 = vbYes Then ACCTPBAL = TRANEBAL : IsPosted = 1

                            TRANEBAL = CDbl(ACCTOBAL + (TCRED - TDEB))
                            rExec("UPDATE SDTRAN SET REVERSED='TRUE' WHERE SDTRAN_ID=" & .CheckedItems(x).Text)
                            rExec("INSERT INTO [SDTRAN]([ACCTNUM],[TRANDATE],[TRANSEQ],[TRANCODE],[TRANBBAL],[TRANDEB],[TRANCRE],[TRANEBAL],[CHKNUM],[CHKBANK],[CHKCODE],[ADD_DATE],[ADD_TIME],[USER],[OVERRIDE],[PPOSTED],[LPOSTED],[TRANOLD],[REVERSED]) " & _
                                                         "Values('" & ACCTNUM.Trim & "','" & CTRL_S.SYSDATE & "'," & LSEQ & ",'" & TRANCODE & "'," & CDbl(ACCTOBAL) & "," & CDbl(TDEB) & "," & CDbl(TCRED) & "," & TRANEBAL & ",''," & _
                                                                  "'','','" & CTRL_S.SYSDATE & "','" & Format(TimeOfDay, "HH:mm:ss") & "','" & SPUSER.SPUSERID.Trim.ToUpper & "','',0,0," & IsPosted & ",1)")
                            If CTRANCODE = "LCD" Or CTRANCODE = "NLD" Or CTRANCODE = "OUS" Then
                                If GetRStr("SELECT CHKSTAT FROM SDCHECK WHERE CHKNUM='" & .CheckedItems(x).SubItems(5).Text.Trim & _
                                           "'", "CHKSTAT", 0).ToString.Trim = "" And CInt(GetRStr("SELECT CHKNDAYS FROM SDCHECK WHERE CHKNUM='" & _
                                            .CheckedItems(x).SubItems(5).Text.Trim & "'", "CHKNDAYS", 0).ToString.Trim) > 0 Then
                                    ACCTFLOATS = ACCTFLOATS - TDEB
                                End If
                                rExec("DELETE FROM SDCHECK WHERE TRANDATE='" & .CheckedItems(x).SubItems(7).Text.Trim & "' AND TRANSEQ=" & .CheckedItems(x).SubItems(1).Text.Trim)
                            End If
                            ACCTOBAL = CDbl((ACCTOBAL + (TCRED - TDEB)))
                            rExec("UPDATE SDMASTER SET ACCTOBAL=" & ACCTOBAL & ",ACCTABAL=" & CDbl(ACCTOBAL - ACCTFLOATS) & _
                                 ",ACCTLBAL=" & ACCTOBAL & ",ACCTPBAL=" & CDbl(ACCTPBAL) & ",ACCTFLOATS=" & CDbl(ACCTFLOATS) & ",ACCTSTAT='" & ACCTSTAT & "' WHERE ACCTNO='" & ACCTNUM & "'")
                        Next
                    End With
                    GetData("select sdtran_id,trandate,trancode,trandeb,trancre,tranbbal,tranebal from sdtran where acctnum='" & ACCTNUM & "' and pposted='False'", "", DataGridView3)
                    If msg2 = vbYes Then
                        prtLN = CInt(GetRStr("SELECT ISNULL(PLINE,'1') PLINE FROM [SDMASTER] WHERE ACCTNO='" & ACCTNUM & "'", "PLINE", 0))
                        GroupBox4.Visible = True
                        GroupBox3.Enabled = False
                        GroupBox4.BringToFront()
                        TextBox3.Text = prtLN
                        TextBox3.Focus()
                    End If
                    lblacctpbal.Text = FormatNumber(ACCTPBAL, 2)
                    lblacctlbal.Text = FormatNumber(ACCTOBAL, 2)
                    lblacctobal.Text = FormatNumber(ACCTOBAL, 2)
                    lblacctfloats.Text = FormatNumber(ACCTFLOATS, 2)
                    If FormatNumber((ACCTOBAL - ACCTFLOATS) - (HOLDOUT + CDbl(CTRL_S.MINBAL) + LHOLDOUT), 2) < 0 Then
                        ACCTABAL = 0
                        lblacctabal.Text = "0.00"
                    Else
                        ACCTABAL = (ACCTOBAL - ACCTFLOATS) - (HOLDOUT + CDbl(CTRL_S.MINBAL) + LHOLDOUT)
                        lblacctabal.Text = FormatNumber((ACCTOBAL - ACCTFLOATS) - (HOLDOUT + CDbl(CTRL_S.MINBAL) + LHOLDOUT), 2)
                    End If

                    FillLV(ListView2, GetData(qryTRAN, "TRANDATE='" & CTRL_S.SYSDATE & "'", DataGridView2), "0:54:54:136:134:100:232:0:80", "1:2:2:3:3:1:1:0:4", True)


                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Dim QRY As String = "SELECT SDTRAN_ID,TRANSEQ AS SEQ,TRANCODE AS CODE,TRANDEB AS DEBIT,TRANCRE AS CREDIT,CHKNUM AS CHECK_NO," & _
                            "CHKBANK AS BANK,TRANDATE,PPOSTED PRINTED FROM SDTRAN WHERE ACCTNUM='" & TextBox4.Text.Trim.Replace("-", "") & _
                            "' AND TRANDATE='" & CTRL_S.SYSDATE & "' AND TRANCODE !='ECC' AND TRANCODE !='ECD' AND REVERSED='False'  ORDER BY SDTRAN_ID, SEQ, TRANDATE"
        If CheckBox2.Checked = True Then
            CheckBox1.Checked = False
            CheckBox1.Enabled = False
            FillLV(ListView2, GetData(QRY, "", DataGridView2), "20:54:54:136:134:100:232:0:80", "1:2:2:3:3:1:1:0:4", True)
        Else
            CheckBox1.Enabled = True
            FillLV(ListView2, GetData(qryTRAN, "TRANDATE='" & CTRL_S.SYSDATE & "'", DataGridView2), "0:54:54:136:134:100:232:0:80", "1:2:2:3:3:1:1:0:4", True)
        End If
    End Sub

    Private Sub TextBox3_KeyUp1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox3.KeyUp
        Try

            Dim strng As String = String.Empty
            Dim CRDR As String = String.Empty
            Dim NameCRLF As String = AddLine(4) 'vbCrLf & " " & vbCrLf & " " & vbCrLf & " " & vbCrLf & " "
            Dim MidCRLF As String = AddLine(5) 'vbCrLf & " " & vbCrLf & " " & vbCrLf & " " & vbCrLf & " " '& vbCrLf & " "
            Dim jump As Boolean = False
            Dim x, lctr As Integer
            Dim PBAL As Decimal = 0
            'Dim PassbookPS As New System.Drawing.Printing.PaperSize("Passbook", 600, 600)
            If e.KeyValue = Keys.Enter Then
                MsgBox("Please Insert Passbook, and Press OK.", MsgBoxStyle.Exclamation, "PASSBOOK UPDATE")
                GroupBox4.Visible = False
                GroupBox3.Enabled = True

                lctr = CInt(TextBox3.Text)
                If lctr > 1 Then strng &= AddLine(3)
                For x = 1 To lctr
                    If x = 12 And lctr > 12 Then
                        strng &= AddLine(6)
                        jump = True
                    Else
                        strng &= AddLine(1)
                    End If
                Next


                With DataGridView3
                    For x = 0 To .RowCount - 1
                        If CDbl(.Rows(x).Cells("TRANDEB").Value) > 0 And CDbl(.Rows(x).Cells("TRANCRE").Value) < 1 Then
                            CRDR = DateValue(.Rows(x).Cells("TRANDATE").Value).ToString("ddMMMyyyy").ToUpper.PadLeft(15, " ") & "      " & .Rows(x).Cells("TRANCODE").Value.ToString.PadRight(4, " ") & _
                                    "      " & FormatNumber(.Rows(x).Cells("TRANDEB").Value, 2).PadLeft(14, " ") & "".PadRight(27, " ") & FormatNumber(.Rows(x).Cells("TRANEBAL").Value, 2).PadLeft(14, " ")
                        ElseIf CDbl(.Rows(x).Cells("TRANDEB").Value) < 1 And CDbl(.Rows(x).Cells("TRANCRE").Value) > 0 Then
                            CRDR = DateValue(.Rows(x).Cells("TRANDATE").Value).ToString("ddMMMyyyy").ToUpper.PadLeft(15, " ") & "      " & .Rows(x).Cells("TRANCODE").Value.ToString.PadRight(4, " ") & _
                                        "".PadRight(27, " ") & FormatNumber(.Rows(x).Cells("TRANCRE").Value, 2).PadLeft(14, " ") & "      " & FormatNumber(.Rows(x).Cells("TRANEBAL").Value, 2).PadLeft(14, " ")
                        End If

                        Select Case lctr
                            Case 1
                                If strng <> String.Empty Then strng = String.Empty
                                strng &= "                      " & TextBox4.Text & "    " & TextBox1.Text & _
                                         AddLine(4) & _
                                         vbCrLf & "      BALANCE FORWARDED" & "".PadRight(49, " ") & FormatNumber(CDbl(.Rows(x).Cells("TRANBBAL").Value)).ToString.PadLeft(14, " ")
                                '"BALANCE FORWARDED" & "".PadRight(37, " ") & FormatNumber(CDbl(.Rows(x).Cells("TRANBBAL").Value)).ToString.PadLeft(14, " ") & vbCrLf & CRDR
                                rExec("UPDATE SDTRAN SET PPOSTED='TRUE' WHERE SDTRAN_ID=" & .Rows(x).Cells("SDTRAN_ID").Value)
                                'rsFD_Mem.MoveNext()
                                lctr += 1
                            Case 13
                                If Not jump Then strng &= MidCRLF
                        End Select

                        strng &= vbCrLf & CRDR
                        rExec("UPDATE SDTRAN SET PPOSTED='TRUE' WHERE SDTRAN_ID=" & .Rows(x).Cells("SDTRAN_ID").Value)
                        lctr += 1
                        If lctr > 24 And (x < .RowCount - 1) Then

                            'print(strng, PassbookPS)
                            print(strng)
                            lctr = 1
                            strng = String.Empty
                            jump = False
                            MsgBox("Please turn to next page, and Press OK.", MsgBoxStyle.Exclamation, "PASSBOOK UPDATE")
                        End If
                    Next x
                End With
                If lctr > 1 Then lctr -= 1

                If strng <> "" Then print(strng) : strng = ""

                PBAL = CDbl(GetRStr("SELECT TOP 1 TRANEBAL FROM SDTRAN WHERE ACCTNUM='" & ACCTNUM & "' ORDER BY SDTRAN_ID DESC", "TRANEBAL", 0))
                lblacctpbal.Text = FormatNumber(PBAL, 2)
                MsgBox("Printing Done.", MsgBoxStyle.Exclamation, "PASSBOOK UPDATE")
                rExec("UPDATE SDMASTER SET PLINE=" & lctr & ",ACCTPBAL=" & PBAL & " WHERE ACCTNO='" & ACCTNUM & "'")
                FillLV(ListView2, GetData(qryTRAN, "TRANDATE='" & CTRL_S.SYSDATE & "'", DataGridView2), "0:54:54:136:134:100:232:0:80", "1:2:2:3:3:1:1:0:4", True)
                SW = True

            ElseIf e.KeyValue = Keys.Escape Then
                GroupBox4.Visible = False
                GroupBox3.Enabled = True
                TextBox3.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.CancelButton = Button5
            Me.AcceptButton = Button6
        End Try
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try

            Dim msg As String
            Dim prtln As Integer
            GetData("select sdtran_id,trandate,trancode,trandeb,trancre,tranbbal,tranebal from sdtran with (nolock) where acctnum='" & ACCTNUM & "' and pposted='False' order by trandate,sdtran_id", "", DataGridView3)
            If DataGridView3.RowCount > 0 Then
                msg = MsgBox("There are [" & DataGridView3.RowCount & "] entries, to be updated to passbook. Would you like to continue?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Passbook Update")
                If msg = vbYes Then
                    prtln = CInt(GetRStr("SELECT ISNULL(PLINE,'1') PLINE FROM [SDMASTER] WHERE ACCTNO='" & ACCTNUM & "'", "PLINE", 0)) + 1
                    GroupBox4.Visible = True
                    GroupBox3.Enabled = False
                    GroupBox4.BringToFront()
                    TextBox3.Text = prtln
                    TextBox3.Focus()
                End If
            Else
                MsgBox("There's nothing to update to Passbook.", MsgBoxStyle.Information, "Passbook Update")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        closeform = True
        Me.Close()
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ListView1.Enabled = False : GroupBox5.Visible = True : GroupBox2.Enabled = False
        TextBox5.Text = FormatNumber(HOLDOUT)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim upd As New CLTF.DB.SQLDBConnection
        Dim msssg As String
        msssg = MsgBox("Do you want to proceed?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "AMEND HOLDOUT")
        If msssg = vbYes Then
            upd.OpenCommand(rCN)
            upd.Execute("UPDATE SDMASTER SET HOLDOUT=" & CDbl(TextBox5.Text) & " WHERE ACCTNO='" & ACCTNUM & "'")
            MsgBox("Updated Successfully!", MsgBoxStyle.Information, "AMEND HOLDOUT")
            upd.CloseCommand()
            GroupBox5.Visible = False : ListView1.Enabled = True : GroupBox2.Enabled = True
        End If
    End Sub

    Private Sub TextBox5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.LostFocus
        If IsNumeric(TextBox5.Text) Then TextBox5.Text = FormatNumber(TextBox5.Text, 2) Else MsgBox("Please input numeric characters", MsgBoxStyle.Information, "Invalid Amount") : TextBox5.Text = "0.00"
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        GroupBox5.Visible = False : ListView1.Enabled = True : GroupBox2.Enabled = True
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If srchSTR <> "" Then
            Dim bindSDMaster As New BindingSource
            acctslist = New ent_sdmaster_list
            acctslist.getDataList("WHERE " & fField & " like '%" & srchSTR & "%'", "ORDER BY ACCTNAME")
            bindSDMaster.DataSource = acctslist
            DataGridView1.DataSource = bindSDMaster
            FillLV(ListView1, DataGridView1, "0:109:77:548:0:0:0:0:0:102:0:0:0", "1:2:2:1:1:1:1:1:1:2:1:1:1", False)
            bindSDMaster = Nothing
        Else
            LoadAcctsList()
        End If
        If ListView2.Items.Count > 0 Then ListView2.Items.Item(0).Selected = True
    End Sub

    Private Sub LoadAcctsList()
        Dim bindSDMaster As New BindingSource
        acctslist = New ent_sdmaster_list
        acctslist.getDataList(, "ORDER BY ACCTNAME")
        bindSDMaster.DataSource = acctslist
        DataGridView1.DataSource = bindSDMaster
        FillLV(ListView1, DataGridView1, "0:109:77:548:0:0:0:0:0:102:0:0:0", "1:2:2:1:1:1:1:1:1:2:1:1:1", False)
        bindSDMaster = Nothing
    End Sub
    Private Function FindID(ByVal sdm As ent_sdmaster) As Boolean
        If sdm.SDMASTER_ID = Integer.Parse(ListView1.Items(ListView1.SelectedIndices(0)).SubItems(0).Text.ToString()) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub frmSDS_Main_TEntry_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Not closeform Then e.Cancel = True

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        LoadAcctsList()
    End Sub

    Private Sub TextBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Enter
        SetFindDefBut()
    End Sub

    Private Sub TextBox1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
        fField = "ACCTNAME" : srchSTR = TextBox1.Text.Trim
    End Sub

    Private Sub SetFindDefBut()
        Me.AcceptButton = Button10
        Me.CancelButton = Button11
    End Sub

    Private Sub TextBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.Enter
        SetFindDefBut()
    End Sub

    Private Sub TextBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.Enter
        SetFindDefBut()
    End Sub


    Private Sub TextBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = "-" Or e.KeyChar = ChrW(8) Then e.Handled = False Else e.Handled = True
    End Sub

    Private Sub btnUpdateTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateTransaction.Click
        frmSDS_Main_TEntry_TranUpdate = New frmSDS_Main_TEntry_TranUpdate
        frmSDS_Main_TEntry_TranUpdate.ShowDialog()
        If SW = True Then

        End If
    End Sub


    Private Sub ListView2_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView2.MouseUp
        If ListView2.Items.Count > 0 Then
            Dim cellLoc As MyCell
            cellLoc = WhichCell(sender, e.X, e.Y)

            If sender.Items(cellLoc.Row).SubItems(cellLoc.Col - 1).Text = Chr(168) Or _
                sender.Items(cellLoc.Row).SubItems(cellLoc.Col - 1).Text = Chr(254) Then
                If bOWCheck(cellLoc.Row) = True Or _
                    sender.Items(cellLoc.Row).SubItems(cellLoc.Col - 1).Text = Chr(CheckboxEnum.Checked) Then
                    sender.Items(cellLoc.Row).SubItems(cellLoc.Col - 1).Text = Chr(CheckboxEnum.Unchecked)
                    rExec("UPDATE SDTRAN SET PPOSTED='False' WHERE SDTRAN_ID=" & sender.Items(cellLoc.Row).SubItems(0).Text)
                    bOWCheck(cellLoc.Row) = False
                Else
                    sender.Items(cellLoc.Row).SubItems(cellLoc.Col - 1).Text = Chr(CheckboxEnum.Checked)
                    rExec("UPDATE SDTRAN SET PPOSTED='True' WHERE SDTRAN_ID=" & sender.Items(cellLoc.Row).SubItems(0).Text)
                    bOWCheck(cellLoc.Row) = True
                End If
            End If
            sender.Select()

        End If
    End Sub
End Class
