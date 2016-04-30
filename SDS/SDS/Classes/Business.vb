
Public Class Business
    Public Shared Function IsAuth(ByVal username As String, ByVal password As String, ByRef _SPUSER As ent_spuser) As Boolean
        Dim Crypt As New Crpyt(password, System.Configuration.ConfigurationManager.AppSettings("32"))
        If _SPUSER.SPUSER_ID > 0 And (Microsoft.VisualBasic.Left(Crypt.Encrypt, 8) = _SPUSER.SPUSERPASS) Then
            Return True
        End If
        Return False
    End Function

    Public Shared Function FormatSDAcctNo(ByVal AcctNo As String) As String
        Dim rString As String = ""
        If Len(AcctNo.Trim) = 10 Then rString = Mid(AcctNo, 1, 4) & "-" & Mid(AcctNo, 5, 5) & "-" & Mid(AcctNo, 10, 1)
        Return rString
    End Function
    Public Shared Function FormatSDKBCINo(ByVal KBCINo As String) As String
        Dim rString As String = ""
        If Len(KBCINo.Trim) = 7 Then rString = Mid(KBCINo, 1, 2) & "-" & Mid(KBCINo, 3, 4) & "-" & Mid(KBCINo, 7, 1)
        Return rString
    End Function

End Class
