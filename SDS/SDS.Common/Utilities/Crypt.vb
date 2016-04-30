Imports System
Imports System.IO
Imports System.Text

Public Class Crypt
    Public Function EncTDES(ByVal value As String, ByVal key As String) As String

        Dim des As New Security.Cryptography.TripleDESCryptoServiceProvider
        Dim myIV() As Byte = NormalizeIVBytes(Encoding.UTF8.GetBytes("@/d*$?5.31"))
        des.IV = myIV
        Dim pdb As New Security.Cryptography.PasswordDeriveBytes(key, New Byte(-1) {})
        des.Key = pdb.CryptDeriveKey("RC2", "MD5", 128, myIV)
        Dim ms As New IO.MemoryStream((value.Length * 2) - 1)
        Dim encStream As New Security.Cryptography.CryptoStream(ms, des.CreateEncryptor(), Security.Cryptography.CryptoStreamMode.Write)
        Dim plainBytes As Byte() = Text.Encoding.UTF8.GetBytes(value)
        encStream.Write(plainBytes, 0, plainBytes.Length)
        encStream.FlushFinalBlock()
        Dim encryptedBytes(CInt(ms.Length - 1)) As Byte
        ms.Position = 0
        ms.Read(encryptedBytes, 0, CInt(ms.Length))
        encStream.Close()
        Return Convert.ToBase64String(encryptedBytes)

    End Function



    Public Function DecTDES(ByVal value As String, ByVal key As String) As String

        Dim des As New Security.Cryptography.TripleDESCryptoServiceProvider
        Dim myIV() As Byte = NormalizeIVBytes(Encoding.UTF8.GetBytes("@/d*$?5.31"))
        des.IV = myIV
        Dim pdb As New Security.Cryptography.PasswordDeriveBytes(key, New Byte(-1) {})
        des.Key = pdb.CryptDeriveKey("RC2", "MD5", 128, myIV)
        Dim encryptedBytes As Byte() = Convert.FromBase64String(value)
        Dim ms As New IO.MemoryStream(value.Length)
        Dim decStream As New Security.Cryptography.CryptoStream(ms, des.CreateDecryptor(), Security.Cryptography.CryptoStreamMode.Write)
        decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
        decStream.FlushFinalBlock()
        Dim plainBytes(CInt(ms.Length - 1)) As Byte
        ms.Position = 0
        ms.Read(plainBytes, 0, CInt(ms.Length))
        decStream.Close()
        Return Text.Encoding.UTF8.GetString(plainBytes)
    End Function
    Private Function NormalizeKeyBytes(ByVal b As Byte()) As Byte()
        Dim crypto As New Security.Cryptography.TripleDESCryptoServiceProvider
        Dim iMaxBytes As Integer = crypto.LegalKeySizes(0).MaxSize \ 8
        Dim iMinBytes As Integer = crypto.LegalKeySizes(0).MinSize \ 8
        'Dim iStepBytes As Integer = crypto.LegalKeySizes(0).SkipSize \ 8

        Return Bytes(b, iMaxBytes, iMinBytes)
    End Function

    Private Function NormalizeIVBytes(ByVal b As Byte()) As Byte()
        Dim crypto As New Security.Cryptography.TripleDESCryptoServiceProvider
        Dim iMaxBytes As Integer = crypto.BlockSize \ 8
        Dim iMinBytes As Integer = crypto.BlockSize \ 8

        Return Bytes(b, iMaxBytes, iMinBytes)
    End Function

    Private Function Bytes(ByVal b As Byte(), ByVal MaxBytes As Integer, ByVal MinBytes As Integer) As Byte()
        If MaxBytes > 0 Then
            If b.Length > MaxBytes Then
                Dim newB(MaxBytes - 1) As Byte
                Array.Copy(b, newB, newB.Length)
                b = newB
            End If
        End If

        If MinBytes > 0 Then
            If b.Length < MinBytes Then
                Dim newB(MinBytes - 1) As Byte
                Array.Copy(b, newb, b.Length)
                b = newB
            End If
        End If

        Return b
    End Function
End Class
