Public Class ent_ctrl_s
    Private _CTRL_S_ID As Integer
    Private _MINBAL As Double
    Private _dormancyCharge As Double
    Private _SYSDATE As Date
    Private _ADMDATE As Date
    Private _DBDRM As String
    Private _OTCF As Boolean
    Private _EODF As Boolean
    Private _EOMF As Boolean
    Private _EOQF As Boolean
    Private _EOYF As Boolean

    Public Property CTRL_S_ID() As Integer
        Get
            Return _CTRL_S_ID
        End Get
        Set(ByVal value As Integer)
            _CTRL_S_ID = value
        End Set
    End Property

    Public Property MINBAL() As Double
        Get
            Return _MINBAL
        End Get
        Set(ByVal value As Double)
            _MINBAL = value
        End Set
    End Property

    Public Property DormancyCharge() As Double
        Get
            Return _dormancyCharge
        End Get
        Set(ByVal value As Double)
            _dormancyCharge = value
        End Set
    End Property
    Public Property SYSDATE() As Date
        Get
            Return _SYSDATE
        End Get
        Set(ByVal value As Date)
            _SYSDATE = value
        End Set
    End Property

    Public Property ADMDATE() As Date
        Get
            Return _ADMDATE
        End Get
        Set(ByVal value As Date)
            _ADMDATE = value
        End Set
    End Property

    Public Property DBDRM() As Integer
        Get
            Return _DBDRM
        End Get
        Set(ByVal value As Integer)
            _DBDRM = value
        End Set
    End Property
    Public Property OTCF() As Boolean
        Get
            Return _OTCF
        End Get
        Set(ByVal value As Boolean)
            _OTCF = value
        End Set
    End Property
    Public Property EODF() As Boolean
        Get
            Return _EODF
        End Get
        Set(ByVal value As Boolean)
            _EODF = value
        End Set
    End Property
    Public Property EOMF() As Boolean
        Get
            Return _EOMF
        End Get
        Set(ByVal value As Boolean)
            _EOMF = value
        End Set
    End Property
    Public Property EOQF() As Boolean
        Get
            Return _EOQF
        End Get
        Set(ByVal value As Boolean)
            _EOQF = value
        End Set
    End Property
    Public Property EOYF() As Boolean
        Get
            Return _EOYF
        End Get
        Set(ByVal value As Boolean)
            _EOYF = value
        End Set
    End Property

    Public Sub getData()
        Dim _Binder As New Binder
        _Binder.bind_CTRL_S(Me)
        _Binder = Nothing
    End Sub
    Public Sub updData()
        Dim _Binder As New Binder
        _Binder.update_CTRL_S(Me)
        _Binder = Nothing
    End Sub
End Class
Public Class ent_ctrl_s_list
    Inherits List(Of ent_ctrl_s)
    Public Sub New()
    End Sub

    Public Overridable Shadows Sub Add(ByVal thisList As ent_ctrl_s)
        MyBase.Add(thisList)
    End Sub
End Class