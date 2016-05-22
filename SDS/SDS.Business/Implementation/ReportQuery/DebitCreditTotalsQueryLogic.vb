Imports SDS.ViewModels
Imports SDS.DataAccessObject
Imports SDS.Common.Utilities

Public Class DebitCreditTotalsQueryLogic : Implements IReportQueryBusinessLogic

    Public Function GenerateModel(ByVal SystemDate As Date) As ReportViewModel Implements IReportQueryBusinessLogic.GenerateModel
        Dim vm As New ReportViewModel
        Dim dataList As List(Of Sdtran)
        Dim modelList As New List(Of DebitCreditTotalsReportViewModel)
        vm.ReportTitle = GetGlobalResourceString("DebitCreditTotalsTitle")
        vm.SubHeader = GetGlobalResourceString("DebitCreditTotalsSubHeader")

        Using rsSdTran As New SdtranDAO
            dataList = rsSdTran.GetDebitCreditTotals(SystemDate)
            For Each Data As Sdtran In dataList
                Dim model As New DebitCreditTotalsReportViewModel
                With model
                    .CTRLNO = Data.ACCTNUM
                    .TRANBBAL = Data.TRANBBAL
                    .TRANCRE = Data.TRANCRE
                    .TRANDEB = Data.TRANDEB
                    .TRANEBAL = Data.TRANEBAL
                End With
                modelList.Add(model)
            Next
        End Using

        vm.Data = ConvertToDataTable(modelList)
        Return vm
    End Function
End Class

