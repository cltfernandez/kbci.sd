
Public Class MemberSearchBovm

    Private _Id As Integer
    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property


    Private _KbciNumber As String
    Public Property KbciNumber() As String
        Get
            Return _KbciNumber
        End Get
        Set(ByVal value As String)
            _KbciNumber = value
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

    Private _AccountNumber As String
    Public Property AccountNumber() As String
        Get
            Return _AccountNumber
        End Get
        Set(ByVal value As String)
            _AccountNumber = value
        End Set
    End Property

    Private _AccountStatus As String
    Public Property AccountStatus() As String
        Get
            Return _AccountStatus
        End Get
        Set(ByVal value As String)
            _AccountStatus = value
        End Set
    End Property


End Class
