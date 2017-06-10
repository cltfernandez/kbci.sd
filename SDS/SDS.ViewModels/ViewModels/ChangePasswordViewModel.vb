Public Class ChangePasswordViewModel
    Private _Id As Integer
    Private _UserName As String
    Private _OldPassword As String
    Private _NewPassword As String
    Private _ConfirmPassword As String
    
    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property

    Public Property UserName() As String
        Get
            Return _UserName
        End Get
        Set(ByVal value As String)
            _UserName = value
        End Set
    End Property
    Public Property OldPassword() As String
        Get
            Return _OldPassword
        End Get
        Set(ByVal value As String)
            _OldPassword = value
        End Set
    End Property
    Public Property NewPassword() As String
        Get
            Return _NewPassword
        End Get
        Set(ByVal value As String)
            _NewPassword = value
        End Set
    End Property
    Public Property ConfirmPassword() As String
        Get
            Return _ConfirmPassword
        End Get
        Set(ByVal value As String)
            _ConfirmPassword = value
        End Set
    End Property
   End Class
