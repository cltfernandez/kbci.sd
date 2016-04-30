Public Class ent_spuser
    Private _SPUSER_ID As Integer
    Private _SPUSERID As String
    Private _SPUSERPASS As String
    Private _SPUSERNAME As String
    Private _SPUSERPOS As String
    Private _SPLOGSTAT As Boolean
    Private _SPLOGNO As Integer
    Private _SPTELLER As Boolean
    Private _SPTAG As String
    Private _USER As String

    Public Property SPUSER_ID() As Integer
        Get
            Return _SPUSER_ID
        End Get
        Set(ByVal value As Integer)
            _SPUSER_ID = value
        End Set
    End Property

    Public Property SPUSERID() As String
        Get
            Return _SPUSERID
        End Get
        Set(ByVal value As String)
            _SPUSERID = value
        End Set
    End Property
    Public Property SPUSERPASS() As String
        Get
            Return _SPUSERPASS
        End Get
        Set(ByVal value As String)
            _SPUSERPASS = value
        End Set
    End Property
    Public Property SPUSERNAME() As String
        Get
            Return _SPUSERNAME
        End Get
        Set(ByVal value As String)
            _SPUSERNAME = value
        End Set
    End Property
    Public Property SPUSERPOS() As String
        Get
            Return _SPUSERPOS
        End Get
        Set(ByVal value As String)
            _SPUSERPoS = value
        End Set
    End Property

    Public Property SPLOGSTAT() As Boolean
        Get
            Return _SPLOGSTAT
        End Get
        Set(ByVal value As Boolean)
            _SPLOGSTAT = value
        End Set
    End Property

    Public Property SPLOGNO() As Integer
        Get
            Return _SPLOGNO
        End Get
        Set(ByVal value As Integer)
            _SPLOGNO = value
        End Set
    End Property
    Public Property SPTELLER() As Boolean
        Get
            Return _SPTELLER
        End Get
        Set(ByVal value As Boolean)
            _SPTELLER = value
        End Set
    End Property
    Public Property SPTAG() As String
        Get
            Return _SPTAG
        End Get
        Set(ByVal value As String)
            _SPTAG = value
        End Set
    End Property
    Public Property USER() As String
        Get
            Return _USER
        End Get
        Set(ByVal value As String)
            _USER = value
        End Set
    End Property

    Public Sub getData()
        Dim _Binder As New Binder
        _Binder.bind_SPUSER(Me)
        _Binder = Nothing
    End Sub
    Public Sub getData(ByVal GetFilter As String)
        Dim _Binder As New Binder
        _Binder.bind_SPUSER(Me, GetFilter)
        _Binder = Nothing
    End Sub
    Public Sub updData()
        Dim _Binder As New Binder
        '_Binder.update_CTRL_S(Me)
        _Binder = Nothing
    End Sub
End Class
Public Class ent_spuser_list
    Inherits List(Of ent_spuser)
    Public Sub New()
    End Sub

    Public Overridable Shadows Sub Add(ByVal thisList As ent_spuser)
        MyBase.Add(thisList)
    End Sub
End Class