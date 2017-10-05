
Imports AutoMapper
Imports SDS.DataAccessObject
Imports SDS.ViewModels
Imports SDS.Common

Public Class MemberService : Implements IFormOperations


    Sub New()

    End Sub

    Public Function GetData() As Object Implements IFormOperations.GetData

        Using sdmDao As New SdmasterDAO
            Dim sdmList = sdmDao.GetAll("ACCTNAME")
            Return sdmList.Select(Function(x) New MemberViewModel() With {.SDMASTER_ID = x.SDMASTER_ID, _
                                                                          .ACCTABAL = x.ACCTABAL, _
                                                                          .ACCTFLOATS = x.ACCTFLOATS, _
                                                                          .ACCTLBAL = x.ACCTLBAL, _
                                                                          .ACCTNAME = x.ACCTNAME, _
                                                                          .ACCTNO = x.ACCTNO, _
                                                                          .ACCTOBAL = x.ACCTOBAL, _
                                                                          .ACCTPBAL = x.ACCTPBAL, _
                                                                          .ACCTSTAT = x.ACCTSTAT, _
                                                                          .HOLDOUT = x.HOLDOUT, _
                                                                          .KBCINO = x.KBCI_NO, _
                                                                          .LSEQ = x.LSEQ, _
                                                                          .REC_STAT = x.REC_STAT}).ToList
        End Using
    End Function

    Public Function SaveData(ByVal data As Object) As Integer Implements IFormOperations.SaveData
        Throw New NotImplementedException
    End Function


    Public Function DeleteData(ByVal data As Object) As Integer Implements IFormOperations.DeleteData
        Throw New NotImplementedException
    End Function
End Class
