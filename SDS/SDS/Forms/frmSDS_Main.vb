Public Class frmSDS_Main
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem46 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem47 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem48 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem49 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem50 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem51 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuItem52 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem53 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem54 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem55 As System.Windows.Forms.MenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem56 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem57 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem58 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem59 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem60 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem61 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem62 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem63 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem64 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem65 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem66 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem68 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem69 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem70 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem71 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem72 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem73 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem74 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem75 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem76 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem77 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem78 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem79 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem80 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem81 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolStripStatusLabel9 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel10 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel11 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel12 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel13 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuItem82 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem83 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem84 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem85 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem86 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem87 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem88 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem89 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem67 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem90 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem91 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem97 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem96 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem98 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem92 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem93 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem94 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem95 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem99 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSDS_Main))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem80 = New System.Windows.Forms.MenuItem
        Me.MenuItem86 = New System.Windows.Forms.MenuItem
        Me.MenuItem87 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem82 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem31 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem32 = New System.Windows.Forms.MenuItem
        Me.MenuItem83 = New System.Windows.Forms.MenuItem
        Me.MenuItem33 = New System.Windows.Forms.MenuItem
        Me.MenuItem34 = New System.Windows.Forms.MenuItem
        Me.MenuItem47 = New System.Windows.Forms.MenuItem
        Me.MenuItem48 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem49 = New System.Windows.Forms.MenuItem
        Me.MenuItem85 = New System.Windows.Forms.MenuItem
        Me.MenuItem50 = New System.Windows.Forms.MenuItem
        Me.MenuItem51 = New System.Windows.Forms.MenuItem
        Me.MenuItem89 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem92 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem52 = New System.Windows.Forms.MenuItem
        Me.MenuItem53 = New System.Windows.Forms.MenuItem
        Me.MenuItem54 = New System.Windows.Forms.MenuItem
        Me.MenuItem55 = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.MenuItem84 = New System.Windows.Forms.MenuItem
        Me.MenuItem26 = New System.Windows.Forms.MenuItem
        Me.MenuItem28 = New System.Windows.Forms.MenuItem
        Me.MenuItem29 = New System.Windows.Forms.MenuItem
        Me.MenuItem30 = New System.Windows.Forms.MenuItem
        Me.MenuItem35 = New System.Windows.Forms.MenuItem
        Me.MenuItem36 = New System.Windows.Forms.MenuItem
        Me.MenuItem37 = New System.Windows.Forms.MenuItem
        Me.MenuItem38 = New System.Windows.Forms.MenuItem
        Me.MenuItem39 = New System.Windows.Forms.MenuItem
        Me.MenuItem94 = New System.Windows.Forms.MenuItem
        Me.MenuItem95 = New System.Windows.Forms.MenuItem
        Me.MenuItem99 = New System.Windows.Forms.MenuItem
        Me.MenuItem81 = New System.Windows.Forms.MenuItem
        Me.MenuItem88 = New System.Windows.Forms.MenuItem
        Me.MenuItem67 = New System.Windows.Forms.MenuItem
        Me.MenuItem90 = New System.Windows.Forms.MenuItem
        Me.MenuItem91 = New System.Windows.Forms.MenuItem
        Me.MenuItem97 = New System.Windows.Forms.MenuItem
        Me.MenuItem96 = New System.Windows.Forms.MenuItem
        Me.MenuItem98 = New System.Windows.Forms.MenuItem
        Me.MenuItem40 = New System.Windows.Forms.MenuItem
        Me.MenuItem41 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem56 = New System.Windows.Forms.MenuItem
        Me.MenuItem57 = New System.Windows.Forms.MenuItem
        Me.MenuItem58 = New System.Windows.Forms.MenuItem
        Me.MenuItem59 = New System.Windows.Forms.MenuItem
        Me.MenuItem60 = New System.Windows.Forms.MenuItem
        Me.MenuItem61 = New System.Windows.Forms.MenuItem
        Me.MenuItem62 = New System.Windows.Forms.MenuItem
        Me.MenuItem63 = New System.Windows.Forms.MenuItem
        Me.MenuItem64 = New System.Windows.Forms.MenuItem
        Me.MenuItem65 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem66 = New System.Windows.Forms.MenuItem
        Me.MenuItem68 = New System.Windows.Forms.MenuItem
        Me.MenuItem69 = New System.Windows.Forms.MenuItem
        Me.MenuItem70 = New System.Windows.Forms.MenuItem
        Me.MenuItem71 = New System.Windows.Forms.MenuItem
        Me.MenuItem72 = New System.Windows.Forms.MenuItem
        Me.MenuItem73 = New System.Windows.Forms.MenuItem
        Me.MenuItem74 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem75 = New System.Windows.Forms.MenuItem
        Me.MenuItem93 = New System.Windows.Forms.MenuItem
        Me.MenuItem42 = New System.Windows.Forms.MenuItem
        Me.MenuItem43 = New System.Windows.Forms.MenuItem
        Me.MenuItem76 = New System.Windows.Forms.MenuItem
        Me.MenuItem44 = New System.Windows.Forms.MenuItem
        Me.MenuItem45 = New System.Windows.Forms.MenuItem
        Me.MenuItem46 = New System.Windows.Forms.MenuItem
        Me.MenuItem27 = New System.Windows.Forms.MenuItem
        Me.MenuItem77 = New System.Windows.Forms.MenuItem
        Me.MenuItem78 = New System.Windows.Forms.MenuItem
        Me.MenuItem79 = New System.Windows.Forms.MenuItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel10 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel12 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel13 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel9 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel11 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem5, Me.MenuItem16, Me.MenuItem25, Me.MenuItem40, Me.MenuItem44, Me.MenuItem27})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem3, Me.MenuItem80, Me.MenuItem86, Me.MenuItem87, Me.MenuItem4})
        resources.ApplyResources(Me.MenuItem1, "MenuItem1")
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        resources.ApplyResources(Me.MenuItem2, "MenuItem2")
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        resources.ApplyResources(Me.MenuItem3, "MenuItem3")
        '
        'MenuItem80
        '
        Me.MenuItem80.Index = 2
        resources.ApplyResources(Me.MenuItem80, "MenuItem80")
        '
        'MenuItem86
        '
        Me.MenuItem86.Index = 3
        resources.ApplyResources(Me.MenuItem86, "MenuItem86")
        '
        'MenuItem87
        '
        Me.MenuItem87.Index = 4
        resources.ApplyResources(Me.MenuItem87, "MenuItem87")
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 5
        resources.ApplyResources(Me.MenuItem4, "MenuItem4")
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 1
        Me.MenuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6, Me.MenuItem82, Me.MenuItem11, Me.MenuItem20, Me.MenuItem31, Me.MenuItem12, Me.MenuItem13, Me.MenuItem14, Me.MenuItem15})
        resources.ApplyResources(Me.MenuItem5, "MenuItem5")
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 0
        resources.ApplyResources(Me.MenuItem6, "MenuItem6")
        '
        'MenuItem82
        '
        Me.MenuItem82.Index = 1
        resources.ApplyResources(Me.MenuItem82, "MenuItem82")
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 2
        resources.ApplyResources(Me.MenuItem11, "MenuItem11")
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 3
        resources.ApplyResources(Me.MenuItem20, "MenuItem20")
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 4
        resources.ApplyResources(Me.MenuItem31, "MenuItem31")
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 5
        resources.ApplyResources(Me.MenuItem12, "MenuItem12")
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 6
        Me.MenuItem13.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem32, Me.MenuItem83, Me.MenuItem33, Me.MenuItem34, Me.MenuItem47, Me.MenuItem48})
        resources.ApplyResources(Me.MenuItem13, "MenuItem13")
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 0
        resources.ApplyResources(Me.MenuItem32, "MenuItem32")
        '
        'MenuItem83
        '
        Me.MenuItem83.Index = 1
        resources.ApplyResources(Me.MenuItem83, "MenuItem83")
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 2
        resources.ApplyResources(Me.MenuItem33, "MenuItem33")
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 3
        resources.ApplyResources(Me.MenuItem34, "MenuItem34")
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = 4
        resources.ApplyResources(Me.MenuItem47, "MenuItem47")
        '
        'MenuItem48
        '
        Me.MenuItem48.Index = 5
        resources.ApplyResources(Me.MenuItem48, "MenuItem48")
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 7
        resources.ApplyResources(Me.MenuItem14, "MenuItem14")
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 8
        Me.MenuItem15.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem49, Me.MenuItem85, Me.MenuItem50, Me.MenuItem51, Me.MenuItem89})
        resources.ApplyResources(Me.MenuItem15, "MenuItem15")
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = 0
        resources.ApplyResources(Me.MenuItem49, "MenuItem49")
        '
        'MenuItem85
        '
        Me.MenuItem85.Index = 1
        resources.ApplyResources(Me.MenuItem85, "MenuItem85")
        '
        'MenuItem50
        '
        Me.MenuItem50.Index = 2
        resources.ApplyResources(Me.MenuItem50, "MenuItem50")
        '
        'MenuItem51
        '
        Me.MenuItem51.Index = 3
        resources.ApplyResources(Me.MenuItem51, "MenuItem51")
        '
        'MenuItem89
        '
        Me.MenuItem89.Index = 4
        resources.ApplyResources(Me.MenuItem89, "MenuItem89")
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 2
        Me.MenuItem16.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem17, Me.MenuItem19, Me.MenuItem21, Me.MenuItem22, Me.MenuItem92, Me.MenuItem23, Me.MenuItem24})
        resources.ApplyResources(Me.MenuItem16, "MenuItem16")
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 0
        resources.ApplyResources(Me.MenuItem17, "MenuItem17")
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 1
        resources.ApplyResources(Me.MenuItem19, "MenuItem19")
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 2
        resources.ApplyResources(Me.MenuItem21, "MenuItem21")
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 3
        resources.ApplyResources(Me.MenuItem22, "MenuItem22")
        '
        'MenuItem92
        '
        Me.MenuItem92.Index = 4
        resources.ApplyResources(Me.MenuItem92, "MenuItem92")
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 5
        resources.ApplyResources(Me.MenuItem23, "MenuItem23")
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 6
        Me.MenuItem24.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem52, Me.MenuItem53, Me.MenuItem54, Me.MenuItem55})
        resources.ApplyResources(Me.MenuItem24, "MenuItem24")
        '
        'MenuItem52
        '
        Me.MenuItem52.Index = 0
        resources.ApplyResources(Me.MenuItem52, "MenuItem52")
        '
        'MenuItem53
        '
        Me.MenuItem53.Index = 1
        resources.ApplyResources(Me.MenuItem53, "MenuItem53")
        '
        'MenuItem54
        '
        Me.MenuItem54.Index = 2
        resources.ApplyResources(Me.MenuItem54, "MenuItem54")
        '
        'MenuItem55
        '
        Me.MenuItem55.Index = 3
        resources.ApplyResources(Me.MenuItem55, "MenuItem55")
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 3
        Me.MenuItem25.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem84, Me.MenuItem26, Me.MenuItem28, Me.MenuItem29, Me.MenuItem30, Me.MenuItem35, Me.MenuItem36, Me.MenuItem37, Me.MenuItem38, Me.MenuItem39, Me.MenuItem94, Me.MenuItem81, Me.MenuItem88, Me.MenuItem67, Me.MenuItem90})
        resources.ApplyResources(Me.MenuItem25, "MenuItem25")
        '
        'MenuItem84
        '
        Me.MenuItem84.Index = 0
        resources.ApplyResources(Me.MenuItem84, "MenuItem84")
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 1
        resources.ApplyResources(Me.MenuItem26, "MenuItem26")
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 2
        resources.ApplyResources(Me.MenuItem28, "MenuItem28")
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 3
        resources.ApplyResources(Me.MenuItem29, "MenuItem29")
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 4
        resources.ApplyResources(Me.MenuItem30, "MenuItem30")
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 5
        resources.ApplyResources(Me.MenuItem35, "MenuItem35")
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 6
        resources.ApplyResources(Me.MenuItem36, "MenuItem36")
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 7
        resources.ApplyResources(Me.MenuItem37, "MenuItem37")
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 8
        resources.ApplyResources(Me.MenuItem38, "MenuItem38")
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 9
        resources.ApplyResources(Me.MenuItem39, "MenuItem39")
        '
        'MenuItem94
        '
        Me.MenuItem94.Index = 10
        Me.MenuItem94.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem95, Me.MenuItem99})
        resources.ApplyResources(Me.MenuItem94, "MenuItem94")
        '
        'MenuItem95
        '
        Me.MenuItem95.Index = 0
        resources.ApplyResources(Me.MenuItem95, "MenuItem95")
        '
        'MenuItem99
        '
        Me.MenuItem99.Index = 1
        resources.ApplyResources(Me.MenuItem99, "MenuItem99")
        '
        'MenuItem81
        '
        Me.MenuItem81.Index = 11
        resources.ApplyResources(Me.MenuItem81, "MenuItem81")
        '
        'MenuItem88
        '
        Me.MenuItem88.Index = 12
        resources.ApplyResources(Me.MenuItem88, "MenuItem88")
        '
        'MenuItem67
        '
        Me.MenuItem67.Index = 13
        resources.ApplyResources(Me.MenuItem67, "MenuItem67")
        '
        'MenuItem90
        '
        Me.MenuItem90.Index = 14
        Me.MenuItem90.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem91, Me.MenuItem97, Me.MenuItem96, Me.MenuItem98})
        resources.ApplyResources(Me.MenuItem90, "MenuItem90")
        '
        'MenuItem91
        '
        Me.MenuItem91.Index = 0
        resources.ApplyResources(Me.MenuItem91, "MenuItem91")
        '
        'MenuItem97
        '
        Me.MenuItem97.Index = 1
        resources.ApplyResources(Me.MenuItem97, "MenuItem97")
        '
        'MenuItem96
        '
        Me.MenuItem96.Index = 2
        resources.ApplyResources(Me.MenuItem96, "MenuItem96")
        '
        'MenuItem98
        '
        Me.MenuItem98.Index = 3
        resources.ApplyResources(Me.MenuItem98, "MenuItem98")
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = 4
        Me.MenuItem40.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem41, Me.MenuItem8, Me.MenuItem9, Me.MenuItem10, Me.MenuItem18, Me.MenuItem42, Me.MenuItem43})
        resources.ApplyResources(Me.MenuItem40, "MenuItem40")
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 0
        Me.MenuItem41.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem7, Me.MenuItem56, Me.MenuItem57, Me.MenuItem58, Me.MenuItem59, Me.MenuItem60, Me.MenuItem61, Me.MenuItem62, Me.MenuItem63, Me.MenuItem64, Me.MenuItem65})
        resources.ApplyResources(Me.MenuItem41, "MenuItem41")
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 0
        resources.ApplyResources(Me.MenuItem7, "MenuItem7")
        '
        'MenuItem56
        '
        Me.MenuItem56.Index = 1
        resources.ApplyResources(Me.MenuItem56, "MenuItem56")
        '
        'MenuItem57
        '
        Me.MenuItem57.Index = 2
        resources.ApplyResources(Me.MenuItem57, "MenuItem57")
        '
        'MenuItem58
        '
        Me.MenuItem58.Index = 3
        resources.ApplyResources(Me.MenuItem58, "MenuItem58")
        '
        'MenuItem59
        '
        Me.MenuItem59.Index = 4
        resources.ApplyResources(Me.MenuItem59, "MenuItem59")
        '
        'MenuItem60
        '
        Me.MenuItem60.Index = 5
        resources.ApplyResources(Me.MenuItem60, "MenuItem60")
        '
        'MenuItem61
        '
        Me.MenuItem61.Index = 6
        resources.ApplyResources(Me.MenuItem61, "MenuItem61")
        '
        'MenuItem62
        '
        Me.MenuItem62.Index = 7
        resources.ApplyResources(Me.MenuItem62, "MenuItem62")
        '
        'MenuItem63
        '
        Me.MenuItem63.Index = 8
        resources.ApplyResources(Me.MenuItem63, "MenuItem63")
        '
        'MenuItem64
        '
        Me.MenuItem64.Index = 9
        resources.ApplyResources(Me.MenuItem64, "MenuItem64")
        '
        'MenuItem65
        '
        Me.MenuItem65.Index = 10
        resources.ApplyResources(Me.MenuItem65, "MenuItem65")
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 1
        resources.ApplyResources(Me.MenuItem8, "MenuItem8")
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 2
        Me.MenuItem9.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem66})
        resources.ApplyResources(Me.MenuItem9, "MenuItem9")
        '
        'MenuItem66
        '
        Me.MenuItem66.Index = 0
        Me.MenuItem66.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem68, Me.MenuItem69, Me.MenuItem70, Me.MenuItem71, Me.MenuItem72, Me.MenuItem73, Me.MenuItem74})
        resources.ApplyResources(Me.MenuItem66, "MenuItem66")
        '
        'MenuItem68
        '
        Me.MenuItem68.Index = 0
        resources.ApplyResources(Me.MenuItem68, "MenuItem68")
        '
        'MenuItem69
        '
        Me.MenuItem69.Index = 1
        resources.ApplyResources(Me.MenuItem69, "MenuItem69")
        '
        'MenuItem70
        '
        Me.MenuItem70.Index = 2
        resources.ApplyResources(Me.MenuItem70, "MenuItem70")
        '
        'MenuItem71
        '
        Me.MenuItem71.Index = 3
        resources.ApplyResources(Me.MenuItem71, "MenuItem71")
        '
        'MenuItem72
        '
        Me.MenuItem72.Index = 4
        resources.ApplyResources(Me.MenuItem72, "MenuItem72")
        '
        'MenuItem73
        '
        Me.MenuItem73.Index = 5
        resources.ApplyResources(Me.MenuItem73, "MenuItem73")
        '
        'MenuItem74
        '
        Me.MenuItem74.Index = 6
        resources.ApplyResources(Me.MenuItem74, "MenuItem74")
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 3
        resources.ApplyResources(Me.MenuItem10, "MenuItem10")
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 4
        Me.MenuItem18.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem75, Me.MenuItem93})
        resources.ApplyResources(Me.MenuItem18, "MenuItem18")
        '
        'MenuItem75
        '
        Me.MenuItem75.Index = 0
        resources.ApplyResources(Me.MenuItem75, "MenuItem75")
        '
        'MenuItem93
        '
        Me.MenuItem93.Index = 1
        resources.ApplyResources(Me.MenuItem93, "MenuItem93")
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = 5
        resources.ApplyResources(Me.MenuItem42, "MenuItem42")
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 6
        Me.MenuItem43.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem76})
        resources.ApplyResources(Me.MenuItem43, "MenuItem43")
        '
        'MenuItem76
        '
        Me.MenuItem76.Index = 0
        resources.ApplyResources(Me.MenuItem76, "MenuItem76")
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 5
        Me.MenuItem44.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem45, Me.MenuItem46})
        resources.ApplyResources(Me.MenuItem44, "MenuItem44")
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 0
        resources.ApplyResources(Me.MenuItem45, "MenuItem45")
        '
        'MenuItem46
        '
        Me.MenuItem46.Index = 1
        resources.ApplyResources(Me.MenuItem46, "MenuItem46")
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 6
        Me.MenuItem27.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem77, Me.MenuItem78, Me.MenuItem79})
        resources.ApplyResources(Me.MenuItem27, "MenuItem27")
        '
        'MenuItem77
        '
        Me.MenuItem77.Index = 0
        resources.ApplyResources(Me.MenuItem77, "MenuItem77")
        '
        'MenuItem78
        '
        Me.MenuItem78.Index = 1
        resources.ApplyResources(Me.MenuItem78, "MenuItem78")
        '
        'MenuItem79
        '
        Me.MenuItem79.Index = 2
        resources.ApplyResources(Me.MenuItem79, "MenuItem79")
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ToolStripStatusLabel1
        '
        resources.ApplyResources(Me.ToolStripStatusLabel1, "ToolStripStatusLabel1")
        Me.ToolStripStatusLabel1.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        resources.ApplyResources(Me.ToolStripStatusLabel2, "ToolStripStatusLabel2")
        '
        'ToolStripStatusLabel3
        '
        resources.ApplyResources(Me.ToolStripStatusLabel3, "ToolStripStatusLabel3")
        Me.ToolStripStatusLabel3.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        '
        'ToolStripStatusLabel4
        '
        resources.ApplyResources(Me.ToolStripStatusLabel4, "ToolStripStatusLabel4")
        Me.ToolStripStatusLabel4.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel4.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        '
        'StatusStrip1
        '
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel10, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel12, Me.ToolStripStatusLabel13, Me.ToolStripStatusLabel9, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel11, Me.ToolStripStatusLabel7, Me.ToolStripStatusLabel8})
        Me.StatusStrip1.Name = "StatusStrip1"
        '
        'ToolStripStatusLabel10
        '
        Me.ToolStripStatusLabel10.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripStatusLabel10.Name = "ToolStripStatusLabel10"
        resources.ApplyResources(Me.ToolStripStatusLabel10, "ToolStripStatusLabel10")
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        resources.ApplyResources(Me.ToolStripStatusLabel5, "ToolStripStatusLabel5")
        Me.ToolStripStatusLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        '
        'ToolStripStatusLabel12
        '
        resources.ApplyResources(Me.ToolStripStatusLabel12, "ToolStripStatusLabel12")
        Me.ToolStripStatusLabel12.Name = "ToolStripStatusLabel12"
        '
        'ToolStripStatusLabel13
        '
        Me.ToolStripStatusLabel13.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripStatusLabel13.Name = "ToolStripStatusLabel13"
        resources.ApplyResources(Me.ToolStripStatusLabel13, "ToolStripStatusLabel13")
        '
        'ToolStripStatusLabel9
        '
        Me.ToolStripStatusLabel9.ForeColor = System.Drawing.Color.Red
        Me.ToolStripStatusLabel9.Name = "ToolStripStatusLabel9"
        resources.ApplyResources(Me.ToolStripStatusLabel9, "ToolStripStatusLabel9")
        '
        'ToolStripStatusLabel6
        '
        resources.ApplyResources(Me.ToolStripStatusLabel6, "ToolStripStatusLabel6")
        Me.ToolStripStatusLabel6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Spring = True
        '
        'ToolStripStatusLabel11
        '
        Me.ToolStripStatusLabel11.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripStatusLabel11.Name = "ToolStripStatusLabel11"
        resources.ApplyResources(Me.ToolStripStatusLabel11, "ToolStripStatusLabel11")
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        resources.ApplyResources(Me.ToolStripStatusLabel7, "ToolStripStatusLabel7")
        '
        'ToolStripStatusLabel8
        '
        Me.ToolStripStatusLabel8.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        resources.ApplyResources(Me.ToolStripStatusLabel8, "ToolStripStatusLabel8")
        '
        'frmSDS_Main
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.StatusStrip1)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Menu = Me.MainMenu1
        Me.Name = "frmSDS_Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private frmSDS_Main_TEntry As frmSDS_Main_TEntry
    Private frmFDS_Main_PrntFDL_Srch As frmFDS_Main_PrntFDL_Srch
    Private frmFD_Member As frmFD_Member
    Private frmFDS_Main_PrntFDL As frmFDS_Main_PrntFDL
    Private frmSDS_Main_Batch As frmSDS_Main_Batch
    Private frmSDS_Main_Payroll As frmSDS_Main_Payroll
    Private frmSDS_Main_Log As frmSDS_Main_Log
    Private frmSDS_Main_SetDate As frmSDS_Main_SetDate
    Private frmSDS_Main_Divref As frmSDS_Main_Divref
    Private frmSDS_Main_Memlist As frmSDS_Main_Memlist
    Private frmSDS_Main_Teller As frmSDS_Main_Teller
    Private frmSDS_Main_Teller_Cash As frmSDS_Main_Teller_Cash
    Private frmSDS_Main_Teller_EOD As frmSDS_Main_Teller_EOD
    Private frmSDS_Close_Table As frmSDS_Close_Table
    Private frmSDS_Close_otc As frmSDS_Close_OTC
    Private frmMain_Ctrl As frmSDS_Main_Ctrl
    Private Form1 As Form1
    Private frmSDS_Main_Access As frmSDS_Main_Access
    Private frmSDS_Main_AcctFloats As frmSDS_Main_AcctFloats
    Private frmSDS_Main_TEntry_Oth As frmSDS_Main_TEntry_Oth
    Private frmPayrollExtract As frmPayrollExtract
    Private frmDIVREFExtract As frmDIVREFExtract
    Private frmSDS_Change_Password As frmSDS_Change_Password
    Private frmSDS_DormancyCharges As frmSDS_DormancyCharges
    Private AboutBox1 As AboutBox1
    Private frmSDS_Backup As frmSDS_Backup
    Dim LDAMT, DR As Decimal
    Private Sub frmSDS_Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim x As MenuItem
        For Each x In MainMenu1.MenuItems
            x.Enabled = True
        Next
        RunStartup()
    End Sub
    Sub RunStartup()
        Dim mnt As Integer
        SW = False
        frmSDS_Main_Log = New frmSDS_Main_Log
        frmSDS_Main_Log.ShowDialog()
        If SW = True Then SW = False Else End : Exit Sub

        If DateValue(CTRL_S.SYSDATE) = DateValue(CTRL_S.ADMDATE) Then
            MsgBox("SYSTEM START-UP: Please Enter next Banking Date.", MsgBoxStyle.Information, "Banking Date")
            frmSDS_Main_SetDate = New frmSDS_Main_SetDate
            frmSDS_Main_SetDate.ShowDialog()
        End If
        If Month(DateValue(CTRL_S.ADMDATE)) > Month(DateValue(CTRL_S.SYSDATE)) Or _
            (Month(DateValue(CTRL_S.ADMDATE)) = 1 And Month(DateValue(CTRL_S.SYSDATE)) = 12) Then
            CTRL_S.EOMF = True
            mnt = Month(DateValue(CTRL_S.SYSDATE))
            If mnt = 3 Or mnt = 6 Or mnt = 9 Or mnt = 12 Then
                CTRL_S.EOQF = True
            End If
            If mnt = 12 Then CTRL_S.EOYF = True
        End If
        CTRL_S.updData()

        With SPUSER
            .SPLOGNO = 0
            .SPLOGSTAT = False
            .updData()
            If .SPUSERPOS = 1 And .SPLOGNO = 0 Then
                frmSDS_Main_Teller = New frmSDS_Main_Teller
                frmSDS_Main_Teller.ShowDialog()
                If SW = False Then

                End If
            End If

        End With
        DEFPRINTER = GetConfig("PT")
        ApplyAcc()
        fillStatbar()

    End Sub

    Sub fillStatbar()
        With StatusStrip1
            .Items(1).Text = SPUSER.SPUSERID
            .Items(4).Text = GetConfig("DB").ToUpper()
            .Items(7).Text = CTRL_S.SYSDATE
            .Items(8).Text = TimeOfDay
        End With

    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        If IsFormLoaded("frmSDS_Main_TEntry") Then Exit Sub
        frmSDS_Main_TEntry = New frmSDS_Main_TEntry
        frmSDS_Main_TEntry.MdiParent = Me
        frmSDS_Main_TEntry.Show()
    End Sub

    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptMem_Ledger
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFDS_Main_PrntFDL_Srch = New frmFDS_Main_PrntFDL_Srch
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        frmFDS_Main_PrntFDL_Srch.ShowDialog()

        If SW = True Then
            frmFDS_Main_PrntFDL = New frmFDS_Main_PrntFDL
            frmFDS_Main_PrntFDL.ShowDialog()
            If SW = True Then
                sQRY = "SELECT ST.TRANDATE TRAN_DATE,ST.ADD_TIME [TIME],ST.TRANCODE COD,ST.CHKBANK BANK," & _
                                 "ST.CHKNUM CHECK_NUM,ST.TRANDEB DEBIT,ST.TRANCRE CREDIT,ST.TRANEBAL BALANCE " & _
                                 "FROM SDTRAN ST WITH (NOLOCK) WHERE ST.ACCTNUM='" & SEL_KBCI_NO & "' AND ST.TRANDATE BETWEEN '" & sDate & "' " & _
                                 "ORDER BY ST.TRANDATE,SDTRAN_ID"
                Dim DT As New DataTable
                Dim cnn As New SqlConnection(rCN)
                Dim sqlCMD As New SqlCommand(sQRY, cnn)
                Dim ad As New SqlDataAdapter(sqlCMD)
                sqlCMD.CommandType = CommandType.Text
                cnn.Open()
                ad.Fill(DT)
                cnn.Close()

                If DT.Rows.Count > 0 Then
                    Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text2")
                    Dim rptAcctNo As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text5")
                    Dim rptName As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text6")
                    DDATE.Text = "AS OF " & DateValue(TODATE).ToString("MMM dd,yyyy")
                    rptAcctNo.Text = Mid(SEL_KBCI_NO, 1, 4) & "-" & Mid(SEL_KBCI_NO, 5, 5) & "-" & Mid(SEL_KBCI_NO, 10, 1)
                    rptName.Text = SEL_FNAME
                    GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "1:3:3:3:3:2:2:2")
                    frmFD_Member.Show()
                Else
                    MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Member's Transaction Ledger")
                End If
                SW = False
                DT.Dispose()
            End If
        End If
    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        If IsFormLoaded("frmSDS_Main_Batch") Then Exit Sub

        frmSDS_Main_Batch = New frmSDS_Main_Batch
        frmSDS_Main_Batch.MdiParent = Me
        frmSDS_Main_Batch.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        StatusStrip1.Items(8).Text = TimeValue(Now)
    End Sub

    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        frmSDS_Main_Payroll = New frmSDS_Main_Payroll
        frmSDS_Main_Payroll.ShowDialog()
    End Sub

    Private Sub MenuItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem49.Click
        Dim msg As String
        DR = CDbl(GetRStr("select ((isnull(sum(dividend),0) + isnull(sum(refund),0)) - isnull(sum(deductions),0)) hash from divref WITH (NOLOCK) ", "hash", 0))
        LDAMT = CDbl(GetRStr("SELECT LDAMT FROM PARAM_S WITH (NOLOCK) ", "LDAMT", 0))
        If LDAMT <> DR Then
            msg = MsgBox("[[ IMPORTANT ]]" & vbCrLf & "    This will process the Dividend/Refund file from the Loans" & vbCrLf & _
                         "Please make sure all users are logged-off and execute back-up" & vbCrLf & "before executing this option.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Advance Payment Processing")

            If msg = vbOK Then
                rExec("UPDATE PARAM_S SET LDAMT=" & DR)
                frmSDS_Main_Divref = New frmSDS_Main_Divref
                frmSDS_Main_Divref.ShowDialog()
            End If
        Else
            MsgBox("This batch may have already been processed !!!", MsgBoxStyle.Information, "DIV/REF Posting")
        End If
    End Sub

    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem34.Click

        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptMem_Payroll
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFDS_Main_PrntFDL_Srch = New frmFDS_Main_PrntFDL_Srch
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        sQRY = "SELECT 'S-' + SUBSTRING(SP.ACCTNO,5,5) + '-' + SUBSTRING(SP.ACCTNO,10,1) ACCTNO," & _
               "SM.ACCTSNAME, SP.SDBBAL, SP.PAMT, SP.SDEBAL, SP.SDSEQ FROM SDMASTER SM WITH (NOLOCK) RIGHT JOIN SDPOST SP WITH (NOLOCK) ON SM.ACCTNO=SP.ACCTNO"
        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text8")
            DDATE.Text = "POSTING DATE : " & CTRL_S.SYSDATE
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "3:3:2:2:2:3")
            frmFD_Member.Show()
        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Payroll Transaction")
        End If
        SW = False
        DT.Dispose()
    End Sub

    Private Sub MenuItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem48.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptMem_Loanhold
        Dim ds As New DataSet
        Dim sQRY As String
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        frmFDS_Main_PrntFDL = New frmFDS_Main_PrntFDL
        frmFDS_Main_PrntFDL.ShowDialog()
        If SW = True Then
            sQRY = "SELECT LH.ACCTNO,SM.ACCTNAME,LH.HOLDCD,LH.HOLDTYPE,LH.HOLDAMT, " & _
                   "LH.HOLDDATE,LH.HOLDUSER,LH.HOLDRMKS,LH.POSTSTAT,LH.POSTDATE,LH.POSTUSER " & _
                   "FROM SDMASTER SM WITH (NOLOCK) RIGHT JOIN  LNHOLD LH WITH (NOLOCK) ON LH.ACCTNO=SM.ACCTNO " & _
                   "WHERE LH.HOLDDATE BETWEEN '" & sDate & "'"
            Dim DT As New DataTable
            Dim cnn As New SqlConnection(rCN)
            Dim sqlCMD As New SqlCommand(sQRY, cnn)
            Dim ad As New SqlDataAdapter(sqlCMD)
            sqlCMD.CommandType = CommandType.Text
            cnn.Open()
            ad.Fill(DT)
            cnn.Close()

            If DT.Rows.Count > 0 Then
                Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text16")
                Dim TDBT As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section4.ReportObjects("Text20")
                Dim TCDT As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section4.ReportObjects("Text21")
                DDATE.Text = "FROM " & FRDATE & " TO " & TODATE
                TDBT.Text = FormatNumber(CDbl(GetRStr("SELECT isnull(SUM(HOLDAMT),0) DBT FROM LNHOLD WITH (NOLOCK) WHERE HOLDDATE BETWEEN '" & sDate & "' AND HOLDTYPE='DM'", "DBT", 0)))
                TCDT.Text = FormatNumber(CDbl(GetRStr("SELECT isnull(SUM(HOLDAMT),0) DBT FROM LNHOLD WITH (NOLOCK) WHERE HOLDDATE BETWEEN '" & sDate & "' AND HOLDTYPE='CM'", "DBT", 0)))
                GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "5:3:3:3:2:1:3:3:3:1:3")
                frmFD_Member.Show()
            Else
                MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "S/A Transaction Register")
            End If
            SW = False
            DT.Dispose()
        End If
    End Sub

    Private Sub MenuItem51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem51.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptMem_Divref
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFDS_Main_PrntFDL_Srch = New frmFDS_Main_PrntFDL_Srch
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        sQRY = "SELECT 'S-' + SUBSTRING(SP.FEBTC_SA,5,5) + '-' + SUBSTRING(SP.FEBTC_SA,10,1) ACCTNO," & _
               "SM.ACCTSNAME,ISNULL(SP.SDBBAL,0) SDBBAL,((ISNULL(SP.DIVIDEND,0) + ISNULL(SP.REFUND,0)) - ISNULL(SP.DEDUCTIONS,0)) PAMT,ISNULL(SP.SDEBAL,0) SDEBAL,SP.SDSEQ " & _
               "FROM SDMASTER SM WITH (NOLOCK) RIGHT JOIN DIVREF_S SP WITH (NOLOCK) ON  SM.ACCTNO=SP.FEBTC_SA WHERE SM.ACCTSTAT='A'"
        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text8")
            DDATE.Text = "POSTING DATE : " & CTRL_S.SYSDATE
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "3:3:2:2:2:3")
            frmFD_Member.Show()
        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Dividend/Refund Transaction")
        End If
        SW = False
        DT.Dispose()
    End Sub

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        If IsFormLoaded("frmSDS_Main_Memlist") Then Exit Sub
        frmSDS_Main_Memlist = New frmSDS_Main_Memlist
        frmSDS_Main_Memlist.MdiParent = Me
        frmSDS_Main_Memlist.Show()
    End Sub

    Private Sub MenuItem47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem47.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptMem_APayment
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFDS_Main_PrntFDL_Srch = New frmFDS_Main_PrntFDL_Srch
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        sQRY = "SELECT SUBSTRING(EX.ACCTNO,1,4) + '-' + SUBSTRING(EX.ACCTNO,5,5) + '-' +SUBSTRING(EX.ACCTNO,10,1) ACCTNO ,EX.KBCI_NO,EX.PN_NO,EX.LOAN_TYPE,SM.ACCTNAME,EX.AMOUNT,EX.ADD_DATE,EX.REMARKS," & _
               "(CASE WHEN EX.STATUS='1' THEN 'EXTRACTED' ELSE (CASE WHEN EX.STATUS='2' THEN 'POSTED' ELSE '' END) END) STATUS," & _
               "EX.EXSEQ,EX.EXTIME,EX.EXBBAL,EX.EXEBAL FROM EXTRACT EX WITH (NOLOCK) LEFT JOIN SDMASTER SM WITH (NOLOCK) ON EX.ACCTNO=SM.ACCTNO ORDER BY EX.LOAN_TYPE"
        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)

        'cnn.Close()


        If DT.Rows.Count > 0 Then
            'Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text8")
            'DDATE.Text = "POSTING DATE : " & SYSDATE
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "3:3:3:3:3:2:1:3:3:3:3:2:2")
            frmFD_Member.Show()
        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "File Proof List")
        End If
        SW = False
        'DT.Dispose()
    End Sub
    Private Sub MenuItem52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem52.Click
        frmSDS_Main_Teller_Cash = New frmSDS_Main_Teller_Cash
        frmSDS_Main_Teller_Cash.ShowDialog()
    End Sub

    Private Sub MenuItem55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem55.Click
        If IsFormLoaded("frmSDS_Main_Teller_EOD") Then Exit Sub
        frmSDS_Main_Teller_EOD = New frmSDS_Main_Teller_EOD
        frmSDS_Main_Teller_EOD.MdiParent = Me
        frmSDS_Main_Teller_EOD.Show()
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Dim msg As String
        msg = MsgBox("Do you want to log-off?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "[" & SPUSER.SPUSERID & "] Logout")
        If msg = vbYes Then
            For Each child As Form In Me.MdiChildren
                child.Dispose()
            Next child
            RunStartup()
        End If
    End Sub

    Private Sub MenuItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem46.Click
        Dim msg As String
        Dim upd As New CLTF.DB.SQLDBConnection
        upd.ConnString = rCN
        upd.OpenCommand()
        CTRL_S.getData()
        If Not CTRL_S.OTCF Then MsgBox("Please execute over the counter close first !!! ") : Exit Sub
        frmSDS_Close_Table = New frmSDS_Close_Table
        frmSDS_Close_Table.ShowDialog()
        If SW = True Then
            msg = MsgBox("[[ IMPORTANT ]]" & vbCrLf & "      This process will close the system and increment the system" & vbCrLf & _
                         "Please make sure that all EOD routines are completed." & vbCrLf & _
                         "Please make sure all users are logged-out of the system !", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "End-of-Day")
            If msg = vbCancel Then Exit Sub
            With CTRL_S
                .EODF = False
                .EOMF = False
                .EOQF = False
                .EOYF = False
                .OTCF = False
                .SYSDATE = .ADMDATE
                .updData()
            End With

            upd.Execute("UPDATE CHKLIST SET clact='false',clapp='False'")
            upd.Execute("UPDATE [SPTELLER]  SET [CASHB] = UPD.CTTCEND FROM " & _
                        "(SELECT SPTELLER_ID, CTTCEND FROM SPTELLER) UPD " & _
                        "WHERE SPTELLER.SPTELLER_ID=UPD.SPTELLER_ID")
            upd.Execute("UPDATE [SPTELLER]  SET [TDATE] ='" & CTRL_S.SYSDATE & "',[COCIB] = 0,[ADDLREQ] = 0" & _
                        ",[ADDMREQ] = 0,[CASHSAV] = 0,[CASHOR] = 0,[ADDLTD] = 0" & _
                        ",[CTFNAME1] = '',[CTFAMT1] = 0,[CTFNAME2] = '',[CTFAMT2] = 0" & _
                        ",[CTFNAME3] = '',[CTFAMT3] = 0,[ADDCASH] = 0,[CRSAV] = 0" & _
                        ",[CRORO] = 0,[CRACC] = 0,[CRCR] = 0,[ADDCHECKS] = 0" & _
                        ",[ADDTOTAL] = 0,[DIB] = 0,[REF] = 0,[WITH] = 0" & _
                        ",[CHKENC] = 0,[COCI] = 0,[CHKDEP] = 0,[EMER] = 0" & _
                        ",[CTTNAME1] = '',[CTTAMT1] = 0,[CTTNAME2] = '',[CTTAMT2] = 0" & _
                        ",[CTTNAME3] = '',[CTTAMT3] = 0,[TOTDISB] = 0,[CBALEND] = 0" & _
                        ",[CTTCEND] = 0,[OVER] = 0,[B_1000] = 0,[B_500] = 0" & _
                        ",[B_200] = 0,[B_100] = 0,[B_50] = 0,[B_20] = 0" & _
                        ",[B_10] = 0,[B_5] = 0,[B_1] = 0,[B_P50] = 0" & _
                        ",[B_P25] = 0,[B_P10] = 0,[B_P05] = 0,[B_P01] = 0" & _
                        ",[TCCOUNT] = 0")
            upd.Execute("TRUNCATE TABLE CASHTRA")
            upd.Execute("TRUNCATE TABLE CASHREQ")
            upd.Execute("TRUNCATE TABLE SDOTHERS")
            upd.Execute("UPDATE SDMASTER SET ACCTFLOATS=SC.ACCTFLOATS,ACCTABAL=SC.ACCTABAL FROM (SELECT DISTINCT SK.ACCTNUM,(CASE WHEN (SK.CHKNDAYS-1)<1 THEN  SM.ACCTFLOATS-DAMT.AMT ELSE SM.ACCTFLOATS END) ACCTFLOATS,ACCTABAL + DAMT.AMT ACCTABAL " & _
                        "FROM SDCHECK SK WITH (NOLOCK) INNER JOIN SDMASTER SM WITH (NOLOCK) ON SK.ACCTNUM=SM.ACCTNO RIGHT JOIN  (SELECT ACCTNUM,SUM(CHKAMT) AMT FROM	SDCHECK SK WITH (NOLOCK) WHERE SK.CHKNDAYS > 0 AND (SK.CHKNDAYS-1)=0 GROUP BY ACCTNUM) DAMT " & _
                        "ON  SK.ACCTNUM=DAMT.ACCTNUM WHERE SK.CHKNDAYS > 0) SC WHERE(SDMASTER.ACCTNO = SC.ACCTNUM)")
            upd.Execute("UPDATE SDCHECK SET  CHKNDAYS=SC.CHKNDAYS,CHKSTAT=SC.CHKSTAT,CHKCDATE=SC.CHKCDATE FROM (SELECT SDCHECK_ID,(CHKNDAYS -1) CHKNDAYS,(CASE WHEN (CHKNDAYS-1)<1 THEN 'CLE' ELSE CHKSTAT END) CHKSTAT," & _
                        "(CASE WHEN (CHKNDAYS-1)<1 THEN '" & CTRL_S.SYSDATE & "' ELSE CHKCDATE END) CHKCDATE FROM SDCHECK WITH (NOLOCK) WHERE CHKNDAYS > 0) SC " & _
                        "WHERE(SDCHECK.SDCHECK_ID = SC.SDCHECK_ID)")
            upd.CloseCommand()
            MsgBox("Processing Done! Kindly login again to start banking day.", MsgBoxStyle.Exclamation, "KBCI Savings and Deposit System 1.0")
            RunStartup()
        End If

    End Sub

    Private Sub MenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem45.Click
        SW = False
        Application.EnableVisualStyles()
        frmSDS_Close_otc = New frmSDS_Close_OTC
        frmSDS_Close_otc.ShowDialog()
        If SW = True Then
            CTRL_S.getData()
            ApplyAcc()

        End If
    End Sub

    Private Sub MenuItem54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem54.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptTel_Blotter
        Dim ds As New DataSet
        Dim sQRY As String
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        sQRY = "SELECT X.OTHNAME NAME,(CASE WHEN X.OTHTYPE='X' OR X.OTHTYPE='Y' THEN 'S' ELSE '' END) TCODE,(CASE WHEN X.OTHTYPE='A' OR X.OTHTYPE='X' THEN X.OTHAMOUNT ELSE 0 END) CASH," & _
               "(CASE WHEN X.OTHTYPE='B' OR X.OTHTYPE='Y' THEN X.OTHAMOUNT ELSE 0 END) [CHECK],(CASE WHEN X.OTHTYPE='W' THEN X.OTHAMOUNT ELSE 0 END) WITHD," & _
               "(CASE WHEN X.OTHTYPE='E' THEN X.OTHAMOUNT ELSE 0 END) ELOAN,(CASE WHEN X.OTHTYPE='D' THEN X.OTHAMOUNT ELSE 0 END) REFUND," & _
               "(CASE WHEN X.OTHTYPE='C' THEN X.OTHAMOUNT ELSE 0 END) CHKACC FROM " & _
               "(SELECT ST.TRANDATE OTHDATE, '" & Format(TimeOfDay, "HH:mm:ss") & "' OTHTIME,SM.ACCTNAME OTHNAME,(CASE WHEN ST.TRANCRE > 0 THEN ST.TRANCRE ELSE ST.TRANDEB END) OTHAMOUNT," & _
               "(CASE WHEN ST.TRANCODE='NCD' OR TRANCODE='CSD' THEN 'X' ELSE (CASE WHEN ST.TRANCODE='WD' OR ST.TRANCODE='NWD'THEN 'W' ELSE " & _
               "(CASE WHEN TRANCODE='LCD' OR TRANCODE='NLD' OR TRANCODE='OUS' THEN 'Y' END) END) END) OTHTYPE,ST.CHKBANK OTHBANK," & _
               "ST.CHKNUM OTHCHKNO,ST.[USER] OTHUSER FROM SDTRAN ST WITH (NOLOCK) LEFT JOIN SDMASTER SM WITH (NOLOCK) ON ST.ACCTNUM=SM.ACCTNO " & _
               "WHERE TRANDATE='" & CTRL_S.SYSDATE & "'AND [USER]='" & SPUSER.SPUSERID & "'  AND REVERSED='False' AND (TRANCODE !='DM' AND TRANCODE !='CM' AND TRANCODE !='ECD' AND TRANCODE !='ECC') " & _
               "UNION ALL SELECT OTHDATE,OTHTIME,OTHNAME,OTHAMOUNT,OTHTYPE,OTHBANK,OTHCHKNO,OTHUSER FROM SDOTHERS WITH (NOLOCK) " & _
               "WHERE OTHDATE='" & CTRL_S.SYSDATE & "' AND OTHUSER='" & SPUSER.SPUSERID & "') X"
        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            Dim TELLER As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text2")
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text3")
            DDATE.Text = "FOR THE DAY " & CTRL_S.ADMDATE
            TELLER.Text = "TELLERS BLOTTER - " & SPUSER.SPUSERID
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "3:3:2:2:2:2:2:2")
            frmFD_Member.Show()
        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        SW = False
        DT.Dispose()
    End Sub

    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        If IsFormLoaded("frmMain_Ctrl") Then Exit Sub
        frmMain_Ctrl = New frmSDS_Main_Ctrl
        frmMain_Ctrl.ShowDialog()
    End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        If IsFormLoaded("frmSDS_Main_Access") Then Exit Sub
        frmSDS_Main_Access = New frmSDS_Main_Access
        frmSDS_Main_Access.ShowDialog()

    End Sub

    Private Sub MenuItem68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem68.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptEOM_NAccts
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        sQRY = "SELECT 'S-' + SUBSTRING(ACCTNO,5,5) + '-' + SUBSTRING(ACCTNO,10,1) ACCTNO," & _
               "ACCTSNAME,LEFT(ACCTADDR1,40) ACCTADDR1,ADD_DATE,ACCTIDEP FROM SDMASTER WITH (NOLOCK) " & _
               "WHERE MONTH(ADD_DATE)=MONTH('" & CTRL_S.SYSDATE & "') AND YEAR(ADD_DATE)=YEAR('" & CTRL_S.SYSDATE & "')"
        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text2")
            DDATE.Text = "FOR THE MONTH OF " & MonthName(Month(CTRL_S.SYSDATE)) & ", " & Year(CTRL_S.SYSDATE)
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "3:3:3:1:2")
            frmFD_Member.Show()
        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        closeRPT("9")
        SW = False
        DT.Dispose()
    End Sub

    Private Sub MenuItem69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem69.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptEOM_CAccts
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        sQRY = "SELECT 'S-' + SUBSTRING(ACCTNO,5,5) + '-' + SUBSTRING(ACCTNO,10,1) ACCTNO,ACCTNAME ACCTSNAME,CHG_DATE ADD_DATE,ISNULL(ACCTIDEP,0) ACCTIDEP FROM SDMASTER WITH (NOLOCK) " & _
               "WHERE MONTH(CHG_DATE)=MONTH('" & CTRL_S.SYSDATE & "') AND YEAR(CHG_DATE)=YEAR('" & CTRL_S.SYSDATE & "') AND ACCTSTAT='C'"

        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text2")
            DDATE.Text = "FOR THE MONTH OF " & MonthName(Month(CTRL_S.SYSDATE)) & ", " & Year(CTRL_S.SYSDATE)
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "3:3:1:2")
            frmFD_Member.Show()

        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        closeRPT("10")
        SW = False
        DT.Dispose()
    End Sub

    Private Sub MenuItem70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem70.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptEOM_RAccts
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        sQRY = "SELECT 'S-' + SUBSTRING(ACCTNO,5,5) + '-' + SUBSTRING(ACCTNO,10,1) ACCTNO," & _
               "ACCTSNAME,LEFT(ACCTADDR1,40) ACCTADDR1,CHG_DATE,ACCTIDEP FROM SDMASTER WITH (NOLOCK) " & _
               "WHERE MONTH(CHG_DATE)=MONTH('" & CTRL_S.SYSDATE & "') AND YEAR(CHG_DATE)=YEAR('" & CTRL_S.SYSDATE & "') AND ACCTSTAT='R'"
        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text2")
            DDATE.Text = "FOR THE MONTH OF " & MonthName(Month(CTRL_S.SYSDATE)) & ", " & Year(CTRL_S.SYSDATE)
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "3:3:1:2")
            frmFD_Member.Show()
        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        closeRPT("11")
        SW = False
        DT.Dispose()
    End Sub

    Private Sub MenuItem71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem71.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptEOM_BMin
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        sQRY = "SELECT 'S-' + SUBSTRING(ACCTNO,5,5) + '-' + SUBSTRING(ACCTNO,10,1) ACCTNO,ACCTSNAME," & _
               "(CASE WHEN ACCTSTAT='A' THEN 'ACTIVE' ELSE (CASE WHEN ACCTSTAT='C' THEN 'CLOSED' ELSE " & _
               "(CASE WHEN ACCTSTAT='D' THEN 'DORMANT' ELSE (CASE WHEN ACCTSTAT='R' THEN 'REACTIVED' END) END) END) END) ACCTSTAT," & _
               "ACCTOBAL FROM SDMASTER WITH (NOLOCK) WHERE MONTH(ADD_DATE)=MONTH('" & CTRL_S.SYSDATE & "') AND YEAR(ADD_DATE)=YEAR('" & CTRL_S.SYSDATE & "') AND ACCTOBAL<" & CTRL_S.MINBAL
        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text2")
            DDATE.Text = "FOR THE MONTH OF " & MonthName(Month(CTRL_S.SYSDATE)) & ", " & Year(CTRL_S.SYSDATE)
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "3:3:3:2")
            frmFD_Member.Show()

        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        closeRPT("12")
        SW = False
        DT.Dispose()
    End Sub

    Private Sub MenuItem72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem72.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptEOM_AccInt
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        sQRY = "DECLARE @DATE VARCHAR(MAX)='" & CTRL_S.SYSDATE & "' SELECT'S-'+SUBSTRING(MM.ACCTNO,5,5)+'-'+" & _
                "SUBSTRING(MM.ACCTNO,10,1)ACCTNO,MM.ACCTNAME NAME,ISNULL(IT.ADB,0)ADB,ISNULL((CASE " & _
                "WHEN MONTH(@DATE)=1OR MONTH(@DATE)=4OR MONTH(@DATE)=7OR MONTH(@DATE)=10THEN IT.MONTH1 " & _
                "ELSE(CASE WHEN MONTH(@DATE)=2OR MONTH(@DATE)=5OR MONTH(@DATE)=8OR MONTH(@DATE)=11THEN " & _
                "IT.MONTH2 ELSE(CASE WHEN MONTH(@DATE)=3OR MONTH(@DATE)=6OR MONTH(@DATE)=9OR MONTH(" & _
                "@DATE)=12THEN IT.MONTH3 END)END)END),0)MTD,ISNULL(QTD,0)QTD FROM SDMASTER MM WITH(" & _
                "NOLOCK)INNER JOIN INTRST_S IT WITH(NOLOCK)ON IT.ACCTNO=MM.ACCTNO WHERE MM.ACCTSTAT IN(" & _
                "'A','D')ORDER BY MM.ACCTNO"
        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text2")
            DDATE.Text = "FOR THE MONTH OF " & MonthName(Month(CTRL_S.SYSDATE)) & ", " & Year(CTRL_S.SYSDATE)
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "3:3:2:2:2")
            frmFD_Member.Show()
        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        closeRPT("13")
        SW = False
        DT.Dispose()
    End Sub

    Private Sub MenuItem73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem73.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptEOM_DAccts
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        sQRY = "SELECT 'S-' + SUBSTRING(ACCTNO,5,5) + '-' + SUBSTRING(ACCTNO,10,1) ACCTNO,ACCTSNAME,LTRANDATE,ACCTOBAL " & _
               "FROM SDMASTER WITH (NOLOCK) WHERE DATEDIFF(D,LTRANDATE,'" & CTRL_S.SYSDATE & "')>=" & CTRL_S.DBDRM
        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text2")
            DDATE.Text = "FOR THE MONTH OF " & MonthName(Month(CTRL_S.SYSDATE)) & ", " & Year(CTRL_S.SYSDATE)
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "3:3:1:2")
            frmFD_Member.Show()

        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        closeRPT("14")
        SW = False
        DT.Dispose()
    End Sub

    Private Sub MenuItem74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem74.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptEOM_BRunup
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        sQRY = "SELECT 'S-' + SUBSTRING(ACCTNO,5,5) + '-' + SUBSTRING(ACCTNO,10,1) ACCTNO,ACCTSNAME," & _
               "(CASE WHEN ACCTSTAT='A' THEN 'ACTIVE' ELSE (CASE WHEN ACCTSTAT='C' THEN 'CLOSED' ELSE " & _
               "(CASE WHEN ACCTSTAT='D' THEN 'DORMANT' ELSE (CASE WHEN ACCTSTAT='R' THEN 'REACTIVED' END) END) END) END) ACCTSTAT,LTRANDATE,ACCTOBAL FROM SDMASTER WITH (NOLOCK) ORDER BY ACCTNO"

        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text2")
            DDATE.Text = "FOR THE MONTH OF " & MonthName(Month(CTRL_S.SYSDATE)) & ", " & Year(CTRL_S.SYSDATE)
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "3:3:3:3:2")
            frmFD_Member.Show()
        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        closeRPT("15")
        SW = False
        DT.Dispose()
    End Sub

    Private Sub MenuItem75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem75.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptEOQ_IntPaid
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        sQRY = "SELECT 'S-' + SUBSTRING(SM.ACCTNO,5,5) + '-' + SUBSTRING(SM.ACCTNO,10,1) ACCTNO,SM.ACCTSNAME," & _
               "(SM.ACCTOBAL - ISNULL(IT.QTD,0)) OLDBAL, ISNULL(IT.QTD,0) QTD, '0.00' WTAX, SM.ACCTOBAL " & _
               "FROM INTRST_S IT WITH (NOLOCK) INNER JOIN SDMASTER SM WITH (NOLOCK) ON IT.ACCTNO=SM.ACCTNO WHERE SM.ACCTSTAT IN ('A','D') ORDER BY SM.ACCTNO"
        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text2")
            DDATE.Text = "FOR THE QUARTER ENDING " & MonthName(Month(CTRL_S.SYSDATE)) & ", " & Year(CTRL_S.SYSDATE)
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "3:3:2:2:2:2")
            frmFD_Member.Show()

        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        closeRPT("2")
        SW = False
        DT.Dispose()
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptEOD_BTotals
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        sQRY = "SELECT ISNULL(SUM((CASE WHEN  TTL.TRANCODE='WD' THEN TRANAMT ELSE 0 END))+SUM((CASE WHEN  TTL.TRANCODE='NWD' THEN TRANAMT ELSE 0 END)),0) SAW," & _
               "ISNULL(SUM((CASE WHEN  TTL.TRANCODE='DM' THEN TRANAMT ELSE 0 END)),0) SADM," & _
               "ISNULL(ABS(SUM((CASE WHEN  TTL.TRANCODE='NCD' THEN TRANAMT ELSE 0 END))+SUM((CASE WHEN  TTL.TRANCODE='CSD' THEN TRANAMT ELSE 0 END))),0) SACD," & _
               "ISNULL(ABS(SUM((CASE WHEN  TTL.TRANCODE='LCD' THEN TRANAMT ELSE 0 END))+SUM((CASE WHEN  TTL.TRANCODE='NLD' THEN TRANAMT ELSE 0 END))+" & _
               "SUM((CASE WHEN  TTL.TRANCODE='OUS' THEN TRANAMT ELSE 0 END))),0) SAHD," & _
               "ISNULL(ABS(SUM((CASE WHEN  TTL.TRANCODE='CM' THEN TRANAMT ELSE 0 END))),0) SACM," & _
               "ISNULL(SUM((CASE WHEN  TTL.TRANCODE='WD' THEN CNT ELSE 0 END))+SUM((CASE WHEN  TTL.TRANCODE='NWD' THEN CNT ELSE 0 END)),0) CSAW," & _
               "ISNULL(SUM((CASE WHEN  TTL.TRANCODE='DM' THEN CNT ELSE 0 END)),0) CSADM," & _
               "ISNULL(SUM((CASE WHEN  TTL.TRANCODE='NCD' THEN CNT ELSE 0 END))+SUM((CASE WHEN  TTL.TRANCODE='CSD' THEN CNT ELSE 0 END)),0) CSACD," & _
               "ISNULL(SUM((CASE WHEN  TTL.TRANCODE='LCD' THEN CNT ELSE 0 END))+SUM((CASE WHEN  TTL.TRANCODE='NLD' THEN CNT ELSE 0 END))+" & _
               "SUM((CASE WHEN  TTL.TRANCODE='OUS' THEN CNT ELSE 0 END)),0) CSAHD," & _
               "ISNULL(SUM((CASE WHEN  TTL.TRANCODE='CM' THEN CNT ELSE 0 END)),0) CSACM," & _
               "ISNULL(SUM((CASE WHEN  TTL.TRANCODE='XLOC' THEN TRANAMT ELSE 0 END)),0) LOC," & _
               "ISNULL(SUM((CASE WHEN  TTL.TRANCODE='XREG' THEN TRANAMT ELSE 0 END)),0) REG," & _
               "ISNULL(SUM((CASE WHEN  TTL.TRANCODE='XOUS' THEN TRANAMT ELSE 0 END)),0) OUS," & _
               "ISNULL(SUM((CASE WHEN  TTL.TRANCODE='XLOC' THEN CNT ELSE 0 END)),0) CLOC," & _
               "ISNULL(SUM((CASE WHEN  TTL.TRANCODE='XREG' THEN CNT ELSE 0 END)),0) CREG," & _
               "ISNULL(SUM((CASE WHEN  TTL.TRANCODE='XOUS' THEN CNT ELSE 0 END)),0) COUS " & _
               "FROM ((SELECT TRANCODE,ISNULL(SUM(TRANDEB-TRANCRE),0) TRANAMT,COUNT(ACCTNUM) CNT " & _
               "FROM SDTRAN WITH (NOLOCK) WHERE TRANDATE='" & CTRL_S.SYSDATE & "' AND [REVERSED]=0 GROUP BY TRANCODE) UNION ALL " & _
               "(SELECT 'X'+CHKCODE,ISNULL(SUM(CHKAMT),0) CHKAMT,COUNT(ACCTNUM) CNT2 " & _
               "FROM SDCHECK WITH (NOLOCK) WHERE TRANDATE='" & CTRL_S.SYSDATE & "' GROUP BY CHKCODE)) TTL"

        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text2")
            DDATE.Text = "FOR THE DAY " & CTRL_S.SYSDATE
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "2:2:2:2:2:6:6:6:6:6:2:2:2:6:6:6")
            frmFD_Member.Show()

        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        SW = False
        DT.Dispose()
    End Sub

    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        frmSDS_Main_AcctFloats = New frmSDS_Main_AcctFloats
        frmSDS_Main_AcctFloats.ShowDialog()
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Me.Close()
        End
    End Sub

    Private Sub MenuItem79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem79.Click
        AboutBox1 = New AboutBox1
        AboutBox1.ShowDialog()
    End Sub

    Private Sub MenuItem56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem56.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptEOD_CDepo
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        sQRY = "SELECT 'S-' + SUBSTRING(SM.ACCTNO,5,5) + '-' + SUBSTRING(SM.ACCTNO,10,1) ACCTNO,SM.ACCTSNAME,ISNULL(SC.CHKAMT,0) CHKAMT," & _
                "SC.CHKCODE,SC.TRANDATE,SC.CHKNUM,SC.CHKBANK,SC.ADD_TIME,SC.[USER] FROM SDMASTER SM WITH (NOLOCK) RIGHT JOIN SDCHECK SC WITH (NOLOCK) " & _
                "ON SM.ACCTNO=SC.ACCTNUM WHERE SC.TRANDATE='" & CTRL_S.SYSDATE & "'"
        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            Dim tb As New CLTF.DB.SQLDBConnection
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text2")
            Dim AOUS As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text3")
            Dim ALOC As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text4")
            Dim AREG As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text6")
            Dim COUS As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text7")
            Dim CLOC As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text9")
            Dim CREG As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text12")

            With tb
                .OpenCmdDataTable(rCN, "SELECT ISNULL(SUM((CASE WHEN CHKCODE='REG' THEN CHKAMT ELSE 0 END)),0) REG,ISNULL(SUM((CASE WHEN CHKCODE='REG' THEN CNT ELSE 0 END)),0) RCNT," & _
                                        "ISNULL(SUM((CASE WHEN CHKCODE='LOC' THEN CHKAMT ELSE 0 END)),0) LOC,ISNULL(SUM((CASE WHEN CHKCODE='LOC' THEN CNT ELSE 0 END)),0) LCNT," & _
                                        "ISNULL(SUM((CASE WHEN CHKCODE='OUS' THEN CHKAMT ELSE 0 END)),0) OUS,ISNULL(SUM((CASE WHEN CHKCODE='OUS' THEN CNT ELSE 0 END)),0) OCNT " & _
                                        "FROM (SELECT COUNT(SDCHECK_ID) CNT,SUM(CHKAMT) CHKAMT,CHKCODE FROM SDCHECK WITH (NOLOCK) WHERE TRANDATE='" & CTRL_S.SYSDATE & "' GROUP BY CHKCODE) XX")
                AOUS.Text = FormatNumber(.GetValue("OUS"), 2)
                ALOC.Text = FormatNumber(.GetValue("LOC"), 2)
                AREG.Text = FormatNumber(.GetValue("REG"), 2)
                COUS.Text = .GetValue("OCNT")
                CLOC.Text = .GetValue("LCNT")
                CREG.Text = .GetValue("RCNT")
            End With
            tb.CloseDataTable()
            DDATE.Text = "FOR THE DAY " & CTRL_S.SYSDATE
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "3:3:2:3:1:3:3:3:3")
            frmFD_Member.Show()
        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        closeRPT("2")
        SW = False
        DT.Dispose()
    End Sub

    Private Sub MenuItem57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem57.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptEOD_TRegister
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        sQRY = "SELECT 'S-' + SUBSTRING(SM.ACCTNO,5,5) + '-' + SUBSTRING(SM.ACCTNO,10,1) ACCTNO,SM.ACCTSNAME,ST.TRANBBAL," & _
               "(CASE WHEN ST.TRANDEB > 0 THEN ST.TRANDEB ELSE 0 END) TRANDEB,(CASE WHEN ST.TRANCRE > 0 THEN ST.TRANCRE ELSE 0 END) TRANCRE," & _
               "ST.TRANEBAL,ST.TRANCODE,ST.CHKNUM,ST.ADD_TIME,ST.TRANSEQ,ST.[USER] FROM SDMASTER SM WITH (NOLOCK) INNER JOIN SDTRAN ST WITH (NOLOCK) ON SM.ACCTNO=ST.ACCTNUM " & _
               "WHERE ST.TRANDATE='" & CTRL_S.SYSDATE & "' ORDER BY ACCTNO,TRANSEQ"
        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text2")
            DDATE.Text = "FOR THE DAY " & CTRL_S.SYSDATE
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "3:3:2:2:2:2:3:3:3:3:3")
            frmFD_Member.Show()

        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        closeRPT("3")
        SW = False
        DT.Dispose()
    End Sub
    Sub ApplyAcc()
        'Dim CHK As New CLTF.DB.SQLDBConnection
        'CHK.OpenCmdDataTable(rCN, "SELECT OTC_FLAG FROM CTRL_S WITH (NOLOCK) ")
        If CBool(CInt(CStr(SPTAG(0)))) = False Or CTRL_S.OTCF Then _
        MenuItem6.Enabled = False : MenuItem82.Enabled = False Else MenuItem6.Enabled = True : MenuItem82.Enabled = True

        If CInt(SPUSER.SPUSERPOS) <> 1 Then MenuItem24.Enabled = False Else MenuItem24.Enabled = True

        If CBool(CInt(CStr(SPTAG(3)))) = False Then MenuItem20.Enabled = False Else MenuItem20.Enabled = True
        If CBool(CInt(CStr(SPTAG(7)))) = False Then MenuItem32.Enabled = False Else MenuItem32.Enabled = True
        If CBool(CInt(CStr(SPTAG(8)))) = False Then
            MenuItem34.Enabled = False
            MenuItem47.Enabled = False
            MenuItem48.Enabled = False
        Else
            MenuItem34.Enabled = True
            MenuItem47.Enabled = True
            MenuItem48.Enabled = True
        End If
        If CBool(CInt(CStr(SPTAG(9)))) = False Then MenuItem49.Enabled = False Else MenuItem49.Enabled = True
        If CBool(CInt(CStr(SPTAG(10)))) = False Then MenuItem51.Enabled = False Else MenuItem51.Enabled = True
        If CBool(CInt(CStr(SPTAG(14)))) = False Then MenuItem21.Enabled = False Else MenuItem21.Enabled = True
        If CBool(CInt(CStr(SPTAG(15)))) = False Then MenuItem22.Enabled = False Else MenuItem22.Enabled = True
        If CBool(CInt(CStr(SPTAG(16)))) = False Then MenuItem26.Enabled = False Else MenuItem26.Enabled = True
        If CBool(CInt(CStr(SPTAG(23)))) = False Then MenuItem41.Enabled = False Else MenuItem41.Enabled = True
        If CBool(CInt(CStr(SPTAG(25)))) = False Then MenuItem66.Enabled = False Else MenuItem66.Enabled = True
        If CBool(CInt(CStr(SPTAG(26)))) = False Then MenuItem67.Enabled = False Else MenuItem67.Enabled = True
        If CBool(CInt(CStr(SPTAG(27)))) = False Then MenuItem75.Enabled = False Else MenuItem75.Enabled = True
        If CBool(CInt(CStr(SPTAG(28)))) = False Then MenuItem76.Enabled = False Else MenuItem76.Enabled = True
        If CBool(CInt(CStr(SPTAG(29)))) = False Then MenuItem45.Enabled = False : MenuItem84.Enabled = False Else MenuItem45.Enabled = True : MenuItem84.Enabled = True
        If CBool(CInt(CStr(SPTAG(30)))) = False Then MenuItem46.Enabled = False Else MenuItem46.Enabled = True

        If CBool(CTRL_S.OTCF) Then MenuItem40.Enabled = True Else MenuItem40.Enabled = False
        If CBool(CTRL_S.OTCF) Then MenuItem29.Enabled = True Else MenuItem29.Enabled = False

        'If Not CBool(Month(CTRL_S.SYSDATE) Mod 3) Then MenuItem18.Enabled = True Else MenuItem18.Enabled = False

        'If Month(CTRL_S.SYSDATE) = 12 Then MenuItem43.Enabled = True Else MenuItem43.Enabled = False
        'If GetLastBusinessDay(Year(CTRL_S.SYSDATE), Month(CTRL_S.SYSDATE)) = CTRL_S.SYSDATE Then _


        If CTRL_S.EOMF = True Then MenuItem9.Enabled = True Else MenuItem9.Enabled = False
        If CTRL_S.EOQF = True Then MenuItem18.Enabled = True Else MenuItem18.Enabled = False
        If CTRL_S.EOYF = True Then MenuItem43.Enabled = True Else MenuItem43.Enabled = False
        'CHK.CloseDataTable()
    End Sub

    Private Sub MenuItem58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem58.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptEOD_RItems
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        sQRY = "SELECT 'S-' + SUBSTRING(SM.ACCTNO,5,5) + '-' + SUBSTRING(SM.ACCTNO,10,1) ACCTNO,SM.ACCTSNAME," & _
               "SC.CHKAMT, SC.CHKCODE, SC.TRANDATE, SC.CHKNUM, SC.ADD_TIME " & _
               "FROM SDCHECK SC WITH (NOLOCK) INNER JOIN SDMASTER SM WITH (NOLOCK) ON SC.ACCTNUM=SM.ACCTNO " & _
               "WHERE SC.TRANDATE='" & CTRL_S.SYSDATE & "' AND SC.CHKSTAT='RET'"
        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            Dim tb As New CLTF.DB.SQLDBConnection
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text2")
            Dim AOUS As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text3")
            Dim ALOC As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text4")
            Dim AREG As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text6")
            Dim COUS As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text7")
            Dim CLOC As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text9")
            Dim CREG As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text12")

            With tb
                .OpenCmdDataTable(rCN, "SELECT ISNULL(SUM((CASE WHEN CHKCODE='REG' THEN CHKAMT ELSE 0 END)),0) REG,ISNULL(SUM((CASE WHEN CHKCODE='REG' THEN CNT ELSE 0 END)),0) RCNT," & _
                                        "ISNULL(SUM((CASE WHEN CHKCODE='LOC' THEN CHKAMT ELSE 0 END)),0) LOC,ISNULL(SUM((CASE WHEN CHKCODE='LOC' THEN CNT ELSE 0 END)),0) LCNT," & _
                                        "ISNULL(SUM((CASE WHEN CHKCODE='OUS' THEN CHKAMT ELSE 0 END)),0) OUS,ISNULL(SUM((CASE WHEN CHKCODE='OUS' THEN CNT ELSE 0 END)),0) OCNT " & _
                                        "FROM (SELECT COUNT(SDCHECK_ID) CNT,SUM(CHKAMT) CHKAMT,CHKCODE FROM SDCHECK WITH (NOLOCK) WHERE TRANDATE='" & CTRL_S.SYSDATE & "' AND CHKSTAT='RET' GROUP BY CHKCODE) XX")
                AOUS.Text = FormatNumber(.GetValue("OUS"), 2)
                ALOC.Text = FormatNumber(.GetValue("LOC"), 2)
                AREG.Text = FormatNumber(.GetValue("REG"), 2)
                COUS.Text = .GetValue("OCNT")
                CLOC.Text = .GetValue("LCNT")
                CREG.Text = .GetValue("RCNT")
            End With
            tb.CloseDataTable()
            DDATE.Text = "FOR THE DAY " & CTRL_S.SYSDATE
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "3:3:2:3:3:3:3")
            frmFD_Member.Show()

        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        closeRPT("4")
        SW = False
        DT.Dispose()
    End Sub

    Private Sub MenuItem59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem59.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptEOD_ECorrect
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        sQRY = "SELECT 'S-' + SUBSTRING(SM.ACCTNO,5,5) + '-' + SUBSTRING(SM.ACCTNO,10,1) ACCTNO,SM.ACCTSNAME," & _
               "(CASE WHEN ST.TRANDEB > 0 THEN ST.TRANDEB ELSE 0 END) TRANDEB,(CASE WHEN ST.TRANCRE > 0 THEN ST.TRANCRE ELSE 0 END) TRANCRE," & _
               "ST.TRANCODE,ST.[USER],ST.TRANSEQ,ST.ADD_TIME FROM SDMASTER SM WITH (NOLOCK) INNER JOIN SDTRAN ST WITH (NOLOCK) ON SM.ACCTNO=ST.ACCTNUM " & _
               "WHERE ST.TRANDATE='" & CTRL_S.SYSDATE & "' AND ST.REVERSED='TRUE'"
        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text2")
            Dim txtTITLE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text1")
            DDATE.Text = "FOR THE DAY " & CTRL_S.SYSDATE
            txtTITLE.Text = "ERROR CORRECTION REPORT"
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "3:3:2:2:3:3:3:3")
            frmFD_Member.Show()

        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        closeRPT("5")
        SW = False
        DT.Dispose()

    End Sub

    Private Sub MenuItem60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem60.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptEOD_DCTotals
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        'sQRY = "SELECT	'001' CTRLNO,SUM(TRANBBAL) TRANBBAL,SUM(TRANDEB) TRANDEB," & _
        '       "SUM(TRANCRE) TRANCRE,SUM(TRANEBAL) TRANEBAL FROM SDTRAN WITH (NOLOCK) WHERE TRANDATE='" & CTRL_S.SYSDATE & "'"

        sQRY = "DECLARE @TRANDEB AS MONEY DECLARE @TRANCRE AS MONEY DECLARE @TRANBBAL AS MONEY " & _
                "DECLARE @TRANEBAL AS MONEY DECLARE @CTRLNO AS CHAR(3) " & _
                "SELECT @CTRLNO='001',@TRANBBAL=SUM(X.TRANBBAL),@TRANDEB=SUM(X.TRANDEB) " & _
                ",@TRANCRE=SUM(X.TRANCRE),@TRANEBAL=SUM(X.TRANEBAL)  " & _
                "FROM (SELECT A.ACCTNUM,(SELECT TRANBBAL FROM SDTRAN WHERE SDTRAN_ID= MIN(A.SDTRAN_ID)) TRANBBAL " & _
                ",SUM(A.TRANDEB) TRANDEB	,SUM(A.TRANCRE) TRANCRE  " & _
                ",(SELECT TRANEBAL FROM SDTRAN WHERE SDTRAN_ID= MAX(A.SDTRAN_ID)) TRANEBAL " & _
                "FROM SDTRAN A INNER JOIN (SELECT ACCTNUM , MAX(TRANDATE) COMP FROM SDTRAN WITH (NOLOCK) GROUP BY ACCTNUM HAVING MAX(TRANDATE) IS NOT NULL) B " & _
                "ON A.ACCTNUM+CAST(A.TRANDATE AS VARCHAR(11))=B.ACCTNUM+CAST(B.COMP AS VARCHAR(11)) WHERE TRANDATE='" & CTRL_S.SYSDATE & "' AND REVERSED=0 " & _
                "GROUP BY A.ACCTNUM) X " & _
                "SELECT @CTRLNO CTRLNO,@TRANBBAL TRANBBAL,@TRANDEB TRANDEB,@TRANCRE TRANCRE,@TRANEBAL TRANEBAL  " & _
                "UNION ALL  " & _
                "SELECT @CTRLNO CTRLNO, SUM(Y.TRANBBAL),@TRANDEB,@TRANCRE,(SUM(Y.TRANBBAL) - @TRANDEB)+ @TRANCRE TRANEBAL " & _
                "FROM (SELECT A.ACCTNUM,CASE WHEN MAX(TRANDATE)='" & CTRL_S.SYSDATE & "' THEN " & _
                "(SELECT TRANBBAL FROM SDTRAN WHERE SDTRAN_ID= MIN(A.SDTRAN_ID)) ELSE " & _
                "(SELECT TRANEBAL FROM SDTRAN WHERE SDTRAN_ID= MAX(A.SDTRAN_ID)) END TRANBBAL " & _
                "FROM SDTRAN A INNER JOIN (SELECT ACCTNUM ,MAX(TRANDATE) COMP FROM SDTRAN WITH (NOLOCK)  " & _
                "GROUP BY ACCTNUM HAVING MAX(TRANDATE) IS NOT NULL) B " & _
                "ON A.ACCTNUM+CAST(A.TRANDATE AS VARCHAR(11))=B.ACCTNUM+CAST(B.COMP AS VARCHAR(11)) GROUP BY A.ACCTNUM) Y"

        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text2")
            Dim txtTITLE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text1")
            DDATE.Text = "FOR THE DAY " & CTRL_S.SYSDATE
            txtTITLE.Text = "DEBIT/CREDIT TOTALS"
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "3:2:2:2:2")
            frmFD_Member.Show()


        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        closeRPT("6")
        SW = False
        DT.Dispose()
    End Sub

    Private Sub MenuItem61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem61.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptEOD_TListing
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        sQRY = "SELECT ACCTNUM,TRANBBAL,TRANDEB,TRANCRE,TRANCODE,TRANEBAL,ADD_TIME," & _
               "CHKNUM,CHKCODE,[OVERRIDE],[USER] FROM SDTRAN WITH (NOLOCK) WHERE TRANDATE='" & CTRL_S.SYSDATE & "'"
        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text2")
            DDATE.Text = "FOR THE DAY " & CTRL_S.SYSDATE
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "3:2:2:2:3:2:3:3:3:3:3")
            frmFD_Member.Show()

        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        closeRPT("7")
        SW = False
        DT.Dispose()
    End Sub

    Private Sub MenuItem62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem62.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptEOD_CDRegister
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        sQRY = "SELECT 'S-' + SUBSTRING(SM.ACCTNO,5,5) + '-' + SUBSTRING(SM.ACCTNO,10,1) ACCTNO,SM.ACCTSNAME,ST.TRANCRE AMOUNT,ST.ADD_TIME,ST.[USER]" & _
               "FROM SDMASTER SM WITH (NOLOCK) INNER JOIN SDTRAN ST WITH (NOLOCK) ON SM.ACCTNO=ST.ACCTNUM WHERE (ST.TRANCODE='CSD' OR ST.TRANCODE='NCD') AND TRANDATE='" & CTRL_S.SYSDATE & "' AND ST.REVERSED='FALSE'"
        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text2")
            DDATE.Text = "FOR THE DAY " & CTRL_S.SYSDATE
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "3:3:2:3:3")
            frmFD_Member.Show()

        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        closeRPT("8")
        SW = False
        DT.Dispose()
    End Sub

    Private Sub MenuItem63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem63.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptEOD_CWRegister
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        sQRY = "SELECT 'S-' + SUBSTRING(SM.ACCTNO,5,5) + '-' + SUBSTRING(SM.ACCTNO,10,1) ACCTNO,SM.ACCTSNAME,ST.TRANDEB AMOUNT,ST.ADD_TIME,ST.[USER]" & _
               "FROM SDMASTER SM WITH (NOLOCK) INNER JOIN SDTRAN ST WITH (NOLOCK) ON SM.ACCTNO=ST.ACCTNUM WHERE (ST.TRANCODE='NWD' OR ST.TRANCODE='WD') AND TRANDATE='" & CTRL_S.SYSDATE & "' AND ST.REVERSED='FALSE'"
        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text2")
            DDATE.Text = "FOR THE DAY " & CTRL_S.SYSDATE
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "3:3:2:3:3")
            frmFD_Member.Show()
        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        SW = False
        DT.Dispose()
    End Sub

    Private Sub MenuItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem64.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptEOD_CMRegister
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        sQRY = "SELECT 'S-' + SUBSTRING(SM.ACCTNO,5,5) + '-' + SUBSTRING(SM.ACCTNO,10,1) ACCTNO,SM.ACCTSNAME,ST.TRANCRE AMOUNT,ST.ADD_TIME,ST.[USER]" & _
               "FROM SDMASTER SM WITH (NOLOCK) INNER JOIN SDTRAN ST WITH (NOLOCK) ON SM.ACCTNO=ST.ACCTNUM WHERE ST.TRANCODE='CM' AND  (ISNULL(CHKNUM,'') != 'PAYROLL' AND ISNULL(CHKNUM,'') !='DIVIDEND' AND ISNULL(CHKNUM,'') !='REFUND' AND ISNULL(CHKNUM,'') NOT LIKE 'ADV-%') AND TRANDATE='" & CTRL_S.SYSDATE & "' AND REVERSED='FALSE'"
        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text2")
            DDATE.Text = "FOR THE DAY " & CTRL_S.SYSDATE
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "3:3:2:3:3")
            frmFD_Member.Show()
        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        SW = False
        DT.Dispose()
    End Sub

    Private Sub MenuItem65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem65.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptEOD_DMRegister
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        sQRY = "SELECT 'S-' + SUBSTRING(SM.ACCTNO,5,5) + '-' + SUBSTRING(SM.ACCTNO,10,1) ACCTNO,SM.ACCTSNAME,ST.TRANDEB AMOUNT,ST.ADD_TIME,ST.[USER]" & _
               "FROM SDMASTER SM WITH (NOLOCK) INNER JOIN SDTRAN ST WITH (NOLOCK) ON SM.ACCTNO=ST.ACCTNUM WHERE ST.TRANCODE='DM' AND TRANDATE='" & CTRL_S.SYSDATE & "' AND REVERSED='FALSE'"
        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text2")
            DDATE.Text = "FOR THE DAY " & CTRL_S.SYSDATE
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "3:3:2:3:3")
            frmFD_Member.Show()
        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        SW = False
        DT.Dispose()
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        frmSDS_Main_Log = New frmSDS_Main_Log
        With frmSDS_Main_Log
            .TextBox6.Text = SPUSER.SPUSERID
            .Button3.Text = "Unlock"
            .Button2.Enabled = False
            .TextBox6.Enabled = False
            .ShowDialog()
        End With
    End Sub

    Private Sub MenuItem77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem77.Click
        'HELP
    End Sub

    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        Dim upd As New CLTF.DB.SQLDBConnection
        SDDB = True
        frmFDS_Main_PrntFDL_Srch = New frmFDS_Main_PrntFDL_Srch
        frmFDS_Main_PrntFDL_Srch.ShowDialog()
        If SW = True Then
            upd.OpenCommand(rCN)
            MsgBox("Updated [" & upd.Execute("UPDATE SDMASTER SET " & _
                            "ACCTSTAT='A'" & _
                            " WHERE ACCTNO='" & SEL_KBCI_NO & "'") & "] record.", MsgBoxStyle.Information, "Member Maintenance")
        End If

    End Sub

    Private Sub MenuItem82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem82.Click
        frmSDS_Main_TEntry_Oth = New frmSDS_Main_TEntry_Oth
        frmSDS_Main_TEntry_Oth.ShowDialog()

    End Sub

    Private Sub MenuItem76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem76.Click
        closeRPT("17")
    End Sub

    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptMaster_Prooflist
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFDS_Main_PrntFDL_Srch = New frmFDS_Main_PrntFDL_Srch
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        sQRY = "SELECT  [ACCTNO],[ACCTSTAT],[ACCTSNAME],[ACCTADDR1],[ACCTNAME],[ADD_DATE],[LTRANDATE],[ACCTOBAL],[ACCTFLOATS] FROM [SDMASTER] WITH (NOLOCK) ORDER BY ACCTNO"
        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text2")
            DDATE.Text = "AS OF " & CTRL_S.SYSDATE
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "5:3:3:3:3:1:1:2:2")
            frmFD_Member.Show()
        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Dividend/Refund Transaction")
        End If
        SW = False
        DT.Dispose()
    End Sub

    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem36.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptActivity_Log
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFDS_Main_PrntFDL_Srch = New frmFDS_Main_PrntFDL_Srch
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        sQRY = "SELECT [ADATE],[ATIME],[AUSER],[AOVER],[AACTI]  FROM [ACTIVITY] WITH (NOLOCK)"
        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text2")
            DDATE.Text = "AS OF " & CTRL_S.SYSDATE
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "1:3:3:3:3")
            frmFD_Member.Show()
        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Dividend/Refund Transaction")
        End If
        SW = False
        DT.Dispose()
    End Sub

    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        frmSDS_Close_Table = New frmSDS_Close_Table
        frmSDS_Close_Table.btnApply.Visible = True
        frmSDS_Close_Table.ShowDialog()
    End Sub

    Private Sub MenuItem83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem83.Click
        frmPayrollExtract = New frmPayrollExtract
        frmPayrollExtract.ShowDialog()
    End Sub
    Private Sub closeRPT(ByVal reportID As String)
        Dim UPD As New CLTF.DB.SQLDBConnection
        UPD.ConnString = rCN
        UPD.OpenCommand()
        UPD.Execute("UPDATE CHKLIST SET CLACT='True' WHERE CHKLIST_ID=" & reportID)
        UPD.CloseCommand()
    End Sub

    Private Sub MenuItem84_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem84.Click
        'reopen otc
        CTRL_S.getData()
        If Not CTRL_S.EOQF Then
            If Not CTRL_S.OTCF Then MsgBox("ERROR: Over-the-Counter is still open.") : Exit Sub
            Dim msg = MsgBox("[[ IMPORTANT ]]" & vbCrLf & "      This process will re-open over-the-counter transactions" & vbCrLf & _
                         "for today [ " & CTRL_S.SYSDATE & " ]. Do you want to proceed?", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Re-open Over-the-Counter")
            If msg = vbCancel Then Exit Sub
            rExec("UPDATE CTRL_S SET OTC_FLAG='False'")
            CTRL_S.getData()
            ApplyAcc()
            MsgBox("Over-the-counter transactions is now open.", MsgBoxStyle.Information, "Re-open Over-the-Counter")
        Else
            MsgBox("Reopening of Over-the-counter transaction is not allowed this time. due to interests that are posted on accounts.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Re-open Over-the-Counter")
        End If
    End Sub

    Private Sub MenuItem85_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem85.Click
        frmDIVREFExtract = New frmDIVREFExtract
        frmDIVREFExtract.ShowDialog()
    End Sub

    Private Sub frmSDS_Main_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If SDMASTERID <> String.Empty Then LockREC(SDMASTERID, False)
    End Sub

    Private Sub MenuItem86_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem86.Click
        frmSDS_Change_Password = New frmSDS_Change_Password
        frmSDS_Change_Password.ShowDialog()
    End Sub

    Private Sub MenuItem88_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem88.Click
        Application.EnableVisualStyles()
        frmSDS_Backup = New frmSDS_Backup
        frmSDS_Backup.ShowDialog()
    End Sub

    Private Sub MenuItem89_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem89.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptMem_Divref_Unposted
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFDS_Main_PrntFDL_Srch = New frmFDS_Main_PrntFDL_Srch
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        sQRY = "SELECT 'S-' + SUBSTRING(SP.FEBTC_SA,5,5) + '-' + SUBSTRING(SP.FEBTC_SA,10,1) ACCTNO," & _
               "SM.ACCTSNAME,ISNULL(SP.SDBBAL,0) SDBBAL,((ISNULL(SP.DIVIDEND,0) + ISNULL(SP.REFUND,0)) - ISNULL(SP.DEDUCTIONS,0)) PAMT,ISNULL(SP.SDEBAL,0) SDEBAL,SP.SDSEQ " & _
               "FROM SDMASTER SM WITH (NOLOCK) RIGHT JOIN DIVREF_S SP WITH (NOLOCK) ON  SM.ACCTNO=SP.FEBTC_SA JOIN MEMBERS MM ON SM.KBCI_NO= MM.KBCI_NO WHERE MM.MEM_STAT='R'"
        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text8")
            DDATE.Text = "POSTING DATE : " & CTRL_S.SYSDATE
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "3:3:2:2:2:3")
            frmFD_Member.Show()
        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Dividend/Refund Transaction")
        End If
        SW = False
        DT.Dispose()
    End Sub

    Private Sub MenuItem90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptEOM_DAccts
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        sQRY = "select A.KBCI_NO,B.ACCTNO,B.ACCTNAME ACCTSNAME,A.MEM_STAT,B.ACCTSTAT,B.ACCTABAL,C.TRANDATE LTRANDATE," & _
                "C.TRANEBAL ACCTOBAL from MEMBERS A JOIN SDMASTER B on A.KBCI_NO=B.KBCI_NO JOIN(select ACCTNUM," & _
                "TRANDATE,TRANEBAL from SDTRAN where SDTRAN_ID in(select MAX(sdtran_id)id from SDTRAN " & _
                "group by ACCTNUM))C on B.ACCTNO=C.ACCTNUM LEFT JOIN CTD D on A.KBCI_NO=D.KBCI_NO where A." & _
                "MEM_STAT='R'AND B.ACCTSTAT='A'and d.KBCI_NO is null and DATEDIFF(""D"",C.trandate,'" & CTRL_S.SYSDATE & "')>= " & CTRL_S.DBDRM
        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text2")
            DDATE.Text = "FOR THE MONTH OF " & MonthName(Month(CTRL_S.SYSDATE)) & ", " & Year(CTRL_S.SYSDATE)
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "3:3:1:2")
            frmFD_Member.Show()

        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        closeRPT("14")
        SW = False
        DT.Dispose()
    End Sub

    Private Sub MenuItem98_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem98.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptEOM_DormantAccounts
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me

        sQRY = "DECLARE @DC NUMERIC(6,2)=" & CTRL_S.DormancyCharge & " DECLARE @DATE AS DATE='" & CTRL_S.SYSDATE & "' SELECT ACCTNO, B.ACCTNAME ACCTSNAME,C." & _
                "TRANDEB DORMANCYFEE,C.TRANEBAL ACCTEBAL FROM MEMBERS A INNER JOIN SDMASTER B ON A.KBCI_NO=B." & _
                "KBCI_NO INNER JOIN(SELECT ACCTNUM,TRANDATE,TRANDEB,TRANEBAL,TRANSEQ,CHKNUM FROM " & _
                "SDTRAN WHERE SDTRAN_ID IN(SELECT MAX(sdtran_id)id FROM SDTRAN GROUP BY ACCTNUM))C ON B." & _
                "ACCTNO=C.ACCTNUM LEFT JOIN CTD D ON A.KBCI_NO=D.KBCI_NO WHERE A.MEM_STAT='R'AND B." & _
                "ACCTSTAT='A'AND d.KBCI_NO IS NULL AND C.CHKNUM='DORMANCY FEE'AND DATEDIFF(""D"",C." & _
                "trandate,@DATE)=0 ORDER BY B.ACCTNAME"




        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandTimeout = 300
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text2")
            DDATE.Text = "FOR THE MONTH OF " & MonthName(Month(CTRL_S.SYSDATE)) & ", " & Year(CTRL_S.SYSDATE)
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "3:3:2:2")
            frmFD_Member.Show()

        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        SW = False
        DT.Dispose()
    End Sub

    Private Sub MenuItem96_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem96.Click
        Application.EnableVisualStyles()
        frmSDS_DormancyCharges = New frmSDS_DormancyCharges
        frmSDS_DormancyCharges.ShowDialog()
    End Sub

    Private Sub MenuItem91_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem91.Click
        Dim dst As New DataTable("dtsSD_Main")
        Dim rpt As New rptEOM_DAccts
        Dim ds As New DataSet
        Dim sQRY As String
        SDDB = True
        frmFD_Member = New frmFD_Member
        frmFD_Member.MdiParent = Me
        sQRY = "select B.ACCTNO,B.ACCTNAME ACCTSNAME,C.TRANDATE LTRANDATE," & _
                "C.TRANEBAL ACCTOBAL from MEMBERS A JOIN SDMASTER B on A.KBCI_NO=B.KBCI_NO JOIN(select ACCTNUM," & _
                "TRANDATE,TRANEBAL from SDTRAN where SDTRAN_ID in(select MAX(sdtran_id)id from SDTRAN " & _
                "group by ACCTNUM))C on B.ACCTNO=C.ACCTNUM LEFT JOIN CTD D on A.KBCI_NO=D.KBCI_NO where A." & _
                "MEM_STAT='R'AND B.ACCTSTAT='A'and d.KBCI_NO is null and DATEDIFF(""D"",C.trandate,'" & CTRL_S.SYSDATE & "')>= " & CTRL_S.DBDRM & " ORDER BY B.ACCTNAME"

        Dim DT As New DataTable
        Dim cnn As New SqlConnection(rCN)
        Dim sqlCMD As New SqlCommand(sQRY, cnn)
        Dim ad As New SqlDataAdapter(sqlCMD)
        sqlCMD.CommandType = CommandType.Text
        cnn.Open()
        ad.Fill(DT)
        cnn.Close()
        If DT.Rows.Count > 0 Then
            Dim DDATE As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("Text2")
            DDATE.Text = "FOR THE MONTH OF " & MonthName(Month(CTRL_S.SYSDATE)) & ", " & Year(CTRL_S.SYSDATE)
            GenRPT(DT, dst, frmFD_Member.CrystalReportViewer1, rpt, 0, "3:3:1:2")
            frmFD_Member.Show()

        Else
            MsgBox("No transactions found on the specified date.", MsgBoxStyle.Information, "Daily Transaction Register")
        End If
        SW = False
        DT.Dispose()
    End Sub

    Private Sub MenuItem92_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem92.Click
        If IsFormLoaded("Form1") Then Exit Sub
        Form1 = New Form1
        Form1.ShowDialog()
    End Sub

    Private Sub MenuItem93_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem93.Click

    End Sub

End Class
