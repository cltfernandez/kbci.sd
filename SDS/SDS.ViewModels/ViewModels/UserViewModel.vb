Public Class UserViewModel
    Private _Id As Integer
    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property


    Private _UserId As String
    Public Property UserId() As String
        Get
            Return _UserId
        End Get
        Set(ByVal value As String)
            _UserId = value
        End Set
    End Property

    Private _Password As String
    Public Property Password() As String
        Get
            Return _Password
        End Get
        Set(ByVal value As String)
            _Password = value
        End Set
    End Property
    Private _FullName As String
    Public Property FullName() As String
        Get
            Return _FullName
        End Get
        Set(ByVal value As String)
            _FullName = value
        End Set
    End Property

    Private _Position As String
    Public Property Position() As String
        Get
            Return _Position
        End Get
        Set(ByVal value As String)
            _Position = value
        End Set
    End Property

    Private _IsLocked As Boolean
    Public Property IsLocked() As Boolean
        Get
            Return _IsLocked
        End Get
        Set(ByVal value As Boolean)
            _IsLocked = value
        End Set
    End Property

    Private _LockOutCount As Integer
    Public Property LockOutCount() As Integer
        Get
            Return _LockOutCount
        End Get
        Set(ByVal value As Integer)
            _LockOutCount = value
        End Set
    End Property

    Private _IsTeller As Boolean
    Public Property IsTeller() As Boolean
        Get
            Return _IsTeller
        End Get
        Set(ByVal value As Boolean)
            _IsTeller = value
        End Set
    End Property

    Private _UserPermission As String
    Public Property UserPermission() As String
        Get
            Return _UserPermission
        End Get
        Set(ByVal value As String)
            _UserPermission = value
        End Set
    End Property

    Private _DateAdded As Date
    Public Property DateAdded() As Date
        Get
            Return _DateAdded
        End Get
        Set(ByVal value As Date)
            _DateAdded = value
        End Set
    End Property

    Private _DateUpdated As Date
    Public Property DateUpdated() As Date
        Get
            Return _DateUpdated
        End Get
        Set(ByVal value As Date)
            _DateUpdated = value
        End Set
    End Property

    Private _ChangedByUser As String
    Public Property ChangedByUser() As String
        Get
            Return _ChangedByUser
        End Get
        Set(ByVal value As String)
            _ChangedByUser = value
        End Set
    End Property
End Class
