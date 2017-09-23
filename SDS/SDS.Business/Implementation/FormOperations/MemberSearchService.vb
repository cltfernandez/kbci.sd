Imports AutoMapper
Imports SDS.DataAccessObject
Imports SDS.ViewModels
Imports SDS.Common

Public Class MemberSearchService : Implements IFormOperations

    Private _SearchType As Integer
    Sub New(ByVal SearchType As Integer)
        _SearchType = SearchType
    End Sub

    Public Function GetData() As Object Implements IFormOperations.GetData
        If DirectCast(_SearchType, MemberSearchType) = MemberSearchType.MembersData Then
            Using rsMemberSearchDao As New MembersDAO
                Dim param As New LUNA.LunaSearchParameter("MEM_STAT", "R", "<>")
                Dim rsMembersList = rsMemberSearchDao.FindAll(param)
                Return rsMembersList.Select(Function(x) New MemberSearchBovm() With {.Id = x.KBCI_ID, _
                                                                                      .KbciNumber = x.KBCI_NO, _
                                                                                      .FullName = String.Format("{0}, {1} {2}", x.LNAME, x.FNAME, x.MI), _
                                                                                      .AccountNumber = x.FEBTC_SA, _
                                                                                      .AccountStatus = String.Empty}).ToList
            End Using

        Else
            Using rsMemberSearchDao As New SdmasterDAO
                Dim param As New LUNA.LunaSearchParameter("ACCTSTAT", "A", "=")
                Dim rsMemberList = rsMemberSearchDao.FindAll(param)
                Return rsMemberList.Select(Function(x) New MemberSearchBovm() With {.Id = x.SDMASTER_ID, _
                                                                                      .KbciNumber = x.KBCI_NO, _
                                                                                      .FullName = x.ACCTNAME, _
                                                                                      .AccountNumber = x.ACCTNO, _
                                                                                      .AccountStatus = x.ACCTSTAT}).ToList
            End Using
        End If
    End Function

    Public Function SaveData(ByVal data As Object) As Integer Implements IFormOperations.SaveData
        Throw New NotImplementedException
    End Function


    Public Function DeleteData(ByVal data As Object) As Integer Implements IFormOperations.DeleteData
        Throw New NotImplementedException
    End Function
End Class
