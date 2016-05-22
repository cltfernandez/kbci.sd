Public Class frmReportViewer
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(828, 561)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'frmFD_Member
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(828, 561)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmFD_Member"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORTS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmFD_Member_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'dst.Columns.Add("DATE", Type.GetType("System.String"))
        'dst.Columns.Add("REF", Type.GetType("System.String"))
        'dst.Columns.Add("DEBIT", Type.GetType("System.Decimal"))
        'dst.Columns.Add("CREDIT", Type.GetType("System.Decimal"))
        'dst.Columns.Add("BALANCE", Type.GetType("System.Decimal"))
        'dst.Columns.Add("CODE", Type.GetType("System.String"))
        'dst.Columns.Add("REMARKS", Type.GetType("System.String"))
        'With rsFD_Mem
        '    .Open("SELECT FD.DATE,TC.TR_CODE,FD.AMOUNT,FD.BALANCE,FD.REF,FD.RMK,FD.DRCR FROM FD INNER JOIN TRANCODE AS TC ON FD.TRAN_CODE=TC.TR_ID where kbci_no='9130381'", cn, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic)
        '    .MoveFirst()
        '    Do Until .EOF
        '        Dim dr As DataRow = dst.NewRow
        '        dr.Item("DATE") = DateValue(.Fields("DATE").Value).ToString("MM/dd/yyyy")
        '        dr.Item("REF") = .Fields("REF").Value
        '        If CStr(.Fields("DRCR").Value) = "CR" Then
        '            dr.Item("DEBIT") = "0.00"
        '            dr.Item("CREDIT") = .Fields("AMOUNT").Value
        '        Else
        '            dr.Item("DEBIT") = .Fields("AMOUNT").Value
        '            dr.Item("CREDIT") = "0.00"
        '        End If
        '        dr.Item("BALANCE") = .Fields("BALANCE").Value
        '        dr.Item("CODE") = .Fields("TR_CODE").Value
        '        dr.Item("REMARKS") = .Fields("RMK").Value
        '        dst.Rows.Add(dr)
        '        .MoveNext()
        '    Loop


        'End With
        'ds.Tables.Add(dst)
        'rpt.SetDataSource(ds.Tables(0))

        'Me.CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class
