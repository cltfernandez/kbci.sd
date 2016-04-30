Public Class ent_sdothers
    Private _OthDate As Date
    Private _OthTime As String
    Private _OthName As String
    Private _OthAmount As Double
    Private _OthType As String
    Private _OthBank As String
    Private _OthChkNo As String
    Private _OthUser As String
    Private _sdothers_id As Integer

    Public Property sdothers_id() As Integer
        Get
            Return _sdothers_id
        End Get
        Set(ByVal value As Integer)
            _sdothers_id = value
        End Set
    End Property
    Public Property OthDate() As Date
        Get
            Return _OthDate
        End Get
        Set(ByVal value As Date)
            _OthDate = value
        End Set
    End Property

    Public Property OthTime() As String
        Get
            Return _OthTime
        End Get
        Set(ByVal value As String)
            _OthTime = value
        End Set
    End Property
 
    Public Property OthName() As String
        Get
            Return _OthName
        End Get
        Set(ByVal value As String)
            _OthName = value
        End Set
    End Property
    Public Property OthAmount() As Double
        Get
            Return _OthAmount
        End Get
        Set(ByVal value As Double)
            _OthAmount = value
        End Set
    End Property
    Public Property OthType() As String
        Get
            Return _OthType
        End Get
        Set(ByVal value As String)
            _OthType = value
        End Set
    End Property

    Public Property OthBank() As String
        Get
            Return _OthBank
        End Get
        Set(ByVal value As String)
            _OthBank = value
        End Set
    End Property

    Public Property OthChkNo() As String
        Get
            Return _OthChkNo
        End Get
        Set(ByVal value As String)
            _OthChkNo = value
        End Set
    End Property

    Public Property OthUser() As String
        Get
            Return _OthUser
        End Get
        Set(ByVal value As String)
            _OthUser = value
        End Set
    End Property
    Public Sub addData()
        Dim _Binder As New Binder
        _Binder.insert_SDOTHERS(Me)
        _Binder = Nothing
    End Sub
    Public Sub getData()
        Dim _Binder As New Binder
        _Binder.bind_SDOTHERS(Me)
        _Binder = Nothing
    End Sub
    Public Sub updData()
        Dim _Binder As New Binder
        _Binder.update_SDOTHERS(Me)
        _Binder = Nothing
    End Sub

    Public Sub delData()
        Dim _Binder As New Binder
        _Binder.delete_SDOTHERS(Me)
        _Binder = Nothing
    End Sub

End Class
Public Class ent_sdothers_list
    Inherits List(Of ent_sdothers)
    Public Sub New()
    End Sub
    Public Sub getDataList(Optional ByVal filterStr As String = Nothing, Optional ByVal orderStr As String = Nothing)
        Dim _Binder As New Binder

        _Binder.bind_SDOTHERS_List(Me, filterStr, orderStr)
        _Binder = Nothing
    End Sub
    Public Overridable Shadows Sub Add(ByVal thisList As ent_sdothers)
        MyBase.Add(thisList)
    End Sub
End Class
