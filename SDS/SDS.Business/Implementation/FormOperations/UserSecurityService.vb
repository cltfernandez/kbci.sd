Imports AutoMapper
Imports SDS.DataAccessObject
Imports SDS.ViewModels
Imports SDS.Common


Public Class UserSecurityService : Implements IFormOperations
    Private _Id As Integer

    Sub New(ByVal Id As Integer)
        _Id = Id
    End Sub

    Sub New()

    End Sub
    Public Function GetData() As Object Implements IFormOperations.GetData

        Using sdOptDao As New SdoptionDAO
            Dim sdOptionList = sdOptDao.GetAll()            

            Using dao As New SpuserDAO

                Dim param As New LUNA.LunaSearchParameter("SPUSER_ID", _Id, "<>")
                Dim spUserList = dao.FindAll(param)
                Dim viewModel As New UserAccessViewModel With { _
                    .UserList = spUserList.Select(Function(x) New UserViewModel() With {.Id = x.SPUSER_ID, _
                                                                                     .UserId = x.SPUSERID, _
                                                                                     .Password = x.SPUSERPASS, _
                                                                                     .FullName = x.SPUSERNAME, _
                                                                                     .Position = x.SPUSERPOS, _
                                                                                     .IsLocked = x.SPLOGSTAT, _
                                                                                     .LockOutCount = x.SPLOGNO, _
                                                                                     .IsTeller = x.SPTELLER, _
                                                                                     .UserPermission = x.SPTAG, _
                                                                                     .DateAdded = x.ADD_DATE, _
                                                                                     .DateUpdated = x.CHG_DATE, _
                                                                                     .ChangedByUser = x.USER}).ToList, _
                .PermissionList = sdOptionList.Select(Function(y) New UserPermissionViewModel() With {.Title = y.SDTITL, .Description = y.SDDESC}).ToList}
                Return viewModel
            End Using
        End Using
    End Function


    Public Function SaveData(ByVal data As Object) As Integer Implements IFormOperations.SaveData
        Dim userViewModel = DirectCast(data, [UserViewModel])
        Dim businessObject As New Spuser
        Dim result
        Using dao As New SpuserDAO            
            Dim param1 As New LUNA.LunaSearchParameter("SPUSERID", userViewModel.UserId)

            businessObject = dao.Find(param1)

            If Not businessObject Is Nothing And userViewModel.Id = 0 Then Return RecordUpdateResult.RecordExists

            If Not businessObject Is Nothing Then
                With businessObject
                    .SPUSERID = userViewModel.UserId
                    .SPUSERNAME = userViewModel.FullName
                    .SPUSERPASS = userViewModel.Password
                    .SPUSERPOS = userViewModel.Position
                    .SPTAG = userViewModel.UserPermission
                    .CHG_DATE = userViewModel.DateUpdated
                    .USER = userViewModel.ChangedByUser
                End With
                result = RecordUpdateResult.UpdateSuccessful
            Else
                businessObject = New Spuser With { _
                .SPUSERID = userViewModel.UserId, _
                .SPUSERNAME = userViewModel.FullName, _
                .SPUSERPASS = userViewModel.Password, _
                .SPUSERPOS = userViewModel.Position, _
                .SPLOGSTAT = userViewModel.IsLocked, _
                .SPLOGNO = userViewModel.LockOutCount, _
                .SPTELLER = userViewModel.IsTeller, _
                .SPTAG = userViewModel.UserPermission, _
                .ADD_DATE = userViewModel.DateAdded, _
                .CHG_DATE = userViewModel.DateUpdated, _
                .USER = userViewModel.ChangedByUser _
                }
                result = RecordUpdateResult.AddSuccessful
            End If
            Dim recordId = dao.Save(businessObject)
            If recordId > 0 Then
                If userViewModel.Id = 0 And DirectCast(Integer.Parse(userViewModel.Position), Position) = Position.Teller Then
                    Using tellerDao As New SptellerDAO
                        Dim spTellerBo As New Spteller With { _
                        .TNAME = userViewModel.UserId, _
                        .TDATE = userViewModel.DateAdded}
                        tellerDao.Save(spTellerBo)
                    End Using
                End If
                Return result
            End If
            Return RecordUpdateResult.Unsuccessful
        End Using
    End Function


    Public Function DeleteData(ByVal data As Object) As Integer Implements IFormOperations.DeleteData
        Dim userViewModel = DirectCast(data, [UserViewModel])
        Using dao As New SpuserDAO
            Dim param1 As New LUNA.LunaSearchParameter("SPUSER_ID", userViewModel.Id)
            Dim businessObject = dao.Find(param1)

            If Not businessObject Is Nothing Then
                dao.Delete(businessObject.SPUSER_ID)
                If DirectCast(Integer.Parse(userViewModel.Position), Position) = Position.Teller Then
                    Using tellerDao As New SptellerDAO
                        Dim param2 As New LUNA.LunaSearchParameter("TNAME", businessObject.SPUSERID)
                        Dim tellerBusinessObject = tellerDao.Find(param2)
                        If Not tellerBusinessObject Is Nothing Then
                            tellerDao.Delete(tellerBusinessObject.SPTELLER_ID)
                        End If
                    End Using
                End If
                Return RecordUpdateResult.DeletedSuccessful
            End If
            Return RecordUpdateResult.Unsuccessful
        End Using
    End Function
End Class
