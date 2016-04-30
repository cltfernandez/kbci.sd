Imports Jc.Scripts.Cryptography
Imports System.Configuration
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO

Public Class Crpyto
    Private Const DEFAULT_INTIALIZATION_VECTOR As String = "@/d*$?5.31"

    Private sTarget As String
    Private byTarget As Byte()
    Private bySecret As Byte()

    Private encoder As Encoding
    Private initVector As Byte()

    Private crypto As TripleDESCryptoServiceProvider

    <System.Diagnostics.DebuggerStepThrough()> _
    Public Sub New(ByVal Target As String, ByVal Secret As String)
        'set default encoding
        encoder = New UTF8Encoding
        crypto = New TripleDESCryptoServiceProvider
        initVector = NormalizeIVBytes(encoder.GetBytes(DEFAULT_INTIALIZATION_VECTOR))
        bySecret = NormalizeKeyBytes(encoder.GetBytes(Secret))
        sTarget = Target
    End Sub

    Private Function Transform(ByVal input() As Byte, ByVal CryptoTransform As ICryptoTransform) As Byte()
        ' create the necessary streams
        Dim memStream As MemoryStream = New MemoryStream
        Dim cryptStream As CryptoStream = New CryptoStream(memStream, CryptoTransform, CryptoStreamMode.Write)

        ' transform the bytes as requested
        cryptStream.Write(input, 0, input.Length)
        cryptStream.FlushFinalBlock()

        ' Read the memory stream and convert it back into byte array
        memStream.Position = 0

        Dim result(CType(memStream.Length - 1, System.Int32)) As Byte
        memStream.Read(result, 0, CType(result.Length, System.Int32))

        ' close and release the streams
        memStream.Close()
        cryptStream.Close()

        'hand back the encrypted buffer
        Return result
    End Function

    Public Function Encrypt() As String
        Dim enc As Byte()
        Try
            byTarget = encoder.GetBytes(sTarget)
            enc = Transform(byTarget, crypto.CreateEncryptor(bySecret, initVector))
            Return Convert.ToBase64String(enc)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Decrypt() As String
        Dim dec As Byte()
        Try
            byTarget = Convert.FromBase64String(sTarget)
            dec = Transform(byTarget, crypto.CreateDecryptor(bySecret, initVector))
            Return encoder.GetString(dec)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetDecryptedText(ByVal cipherText As String) As String

        Dim key As String = ConfigurationManager.AppSettings.Get("Key")
        Dim iv As String = Base64.Encrypt(key)
        Return Symmetric.Decrypt(Symmetric.Algorithms.Aes, cipherText, key, iv)
    End Function

    Public Function GetEncryptedText(ByVal plainText As String) As String
        Dim key As String = ConfigurationManager.AppSettings.Get("Key")
        Dim iv As String = Base64.Encrypt(key)
        Return Symmetric.Encrypt(Symmetric.Algorithms.Aes, plainText, key, iv)
    End Function


    Private Function NormalizeKeyBytes(ByVal b As Byte()) As Byte()
        Dim iMaxBytes As Integer = crypto.LegalKeySizes(0).MaxSize \ 8
        Dim iMinBytes As Integer = crypto.LegalKeySizes(0).MinSize \ 8
        'Dim iStepBytes As Integer = crypto.LegalKeySizes(0).SkipSize \ 8

        Return Bytes(b, iMaxBytes, iMinBytes)
    End Function

    Private Function NormalizeIVBytes(ByVal b As Byte()) As Byte()
        Dim iMaxBytes As Integer = crypto.BlockSize \ 8
        Dim iMinBytes As Integer = crypto.BlockSize \ 8

        Return Bytes(b, iMaxBytes, iMinBytes)
    End Function

    Private Function Bytes(ByVal b As Byte(), ByVal MaxBytes As Integer, ByVal MinBytes As Integer) As Byte()
        If MaxBytes > 0 Then
            If b.Length > MaxBytes Then
                Dim newB(MaxBytes - 1) As Byte
                b.Copy(b, newB, newB.Length)
                b = newB
            End If
        End If

        If MinBytes > 0 Then
            If b.Length < MinBytes Then
                Dim newB(MinBytes - 1) As Byte
                Array.Copy(b, newB, b.Length)
                b = newB
            End If
        End If

        Return b
    End Function


End Class
