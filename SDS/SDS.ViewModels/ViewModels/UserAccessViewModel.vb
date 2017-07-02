Public Class UserAccessViewModel


    Private _UserList As List(Of UserViewModel)
    Public Property UserList() As List(Of UserViewModel)
        Get
            Return _UserList
        End Get
        Set(ByVal value As List(Of UserViewModel))
            _UserList = value
        End Set
    End Property

    Private _PermissionList As List(Of UserPermissionViewModel)
    Public Property PermissionList() As List(Of UserPermissionViewModel)
        Get
            Return _PermissionList
        End Get
        Set(ByVal value As List(Of UserPermissionViewModel))
            _PermissionList = value
        End Set
    End Property



End Class
