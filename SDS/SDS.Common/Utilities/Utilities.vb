Public Class Utilities
    Public Shared Function GetConfig(ByVal KEY As String) As String
        Dim crypto As New Crpyto(System.Configuration.ConfigurationManager.AppSettings(KEY), System.Configuration.ConfigurationManager.AppSettings("32"))
        Return crypto.Decrypt
    End Function

    Public Shared Function GetGlobalResourceString(ByVal resourceKey As String) As String
        Dim myResource As New My.Resources.GlobalResource
        Return myResource.ResourceManager.GetString(resourceKey)
    End Function

End Class
