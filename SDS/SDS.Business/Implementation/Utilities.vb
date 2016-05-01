Imports System.Configuration
Public Class Utilities
    Public Shared Function GetConfig(ByVal KEY As String) As String
        Dim crypto As New Crpyt(ConfigurationManager.AppSettings(KEY), ConfigurationManager.AppSettings("32"))
        Return crypto.Decrypt()
    End Function
End Class
