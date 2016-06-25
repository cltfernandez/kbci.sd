Imports AutoMapper
Imports SDS.DataAccessObject
Imports SDS.ViewModels
Imports SDS.Common


Public Class PolicyDefinitionsService : Implements IFormOperations
    Private _id As String
    Sub New()
        Mapper.CreateMap(Of Ctrl_s, PolicyDefinitionsViewModel)()
        Mapper.CreateMap(Of PolicyDefinitionsViewModel, Ctrl_s)()
            
    End Sub
    Public Function GetData() As Object Implements IFormOperations.GetData
        Dim ctrlViewModel As New PolicyDefinitionsViewModel
        Using dao As New Ctrl_sDAO
            Dim ctrl = dao.Read(1)
            Mapper.Map(ctrl, ctrlViewModel)
        End Using
        Return ctrlViewModel
    End Function


    Public Function SaveData(ByVal data As Object) As RecordUpdateResult Implements IFormOperations.SaveData
        Dim ctrlViewModel = DirectCast(data, [PolicyDefinitionsViewModel])
        Dim businessObject As New Ctrl_s
        Using dao As New Ctrl_sDAO
            businessObject = dao.Read(1)
            ctrlViewModel.IsBatchInitialized = businessObject.BINIT
            ctrlViewModel.IsBatchPosted = businessObject.BPOST
            ctrlViewModel.Id = businessObject.CTRL_S_ID
            ctrlViewModel.SystemDate = businessObject.SYSDATE
            ctrlViewModel.DateAdded = businessObject.ADD_DATE
            ctrlViewModel.AdminDate = businessObject.ADMDATE
            ctrlViewModel.PassbookMaximumLine = businessObject.PMAXL
            ctrlViewModel.LedgerMaxLine = businessObject.LMAXL
            ctrlViewModel.PrinterComm = businessObject.R_PRINT
            ctrlViewModel.PrinterPort = businessObject.P_PRINT
            Mapper.Map(ctrlViewModel, businessObject)
            If dao.Save(businessObject) = 1 Then
                Return RecordUpdateResult.UpdateSuccessful
            End If
            Return RecordUpdateResult.Unsuccessful
        End Using
    End Function
End Class
