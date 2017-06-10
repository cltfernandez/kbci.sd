Imports AutoMapper
Imports SDS.DataAccessObject
Imports SDS.ViewModels
Imports SDS.Common

Public Class ChangePasswordService : Implements IFormOperations


    Sub New()

    End Sub

    Public Function GetData() As Object Implements IFormOperations.GetData
        Throw New NotImplementedException
    End Function

    Public Function SaveData(ByVal data As Object) As Integer Implements IFormOperations.SaveData
        Dim chPasswordViewModel = DirectCast(data, [ChangePasswordViewModel])
        Dim EncryptedOldPassword As New Crpyt(chPasswordViewModel.OldPassword, System.Configuration.ConfigurationManager.AppSettings("32"))
        Dim EncryptedNewPassword As New Crpyt(chPasswordViewModel.NewPassword, System.Configuration.ConfigurationManager.AppSettings("32"))


        Using cmdSpUserDao As New SpuserDAO
            Dim param As New LUNA.LunaSearchParameter("SPUSER_ID", chPasswordViewModel.Id)
            Dim spUser = cmdSpUserDao.Find(param)

            If Microsoft.VisualBasic.Left(EncryptedOldPassword.Encrypt, 8) <> spUser.SPUSERPASS Then _
                Return ChangePasswordResult.IncorrectPassword

            If chPasswordViewModel.NewPassword <> chPasswordViewModel.ConfirmPassword Then _
                 Return ChangePasswordResult.ConfirmPasswordMismatch

            spUser.SPUSERPASS = Microsoft.VisualBasic.Left(EncryptedNewPassword.Encrypt, 8)
            If cmdSpUserDao.Save(spUser) = 1 Then
                Return ChangePasswordResult.Successful
            End If

            Return ChangePasswordResult.Unsuccessful
        End Using
    End Function

End Class
