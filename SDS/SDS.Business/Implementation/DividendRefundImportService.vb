Imports SDS.DataAccessObject
Imports SDS.Common
Public Class DividendRefundImportService
    Private _databaseName As String
    Private _dbfFilePath As String
    Sub New(ByVal databaseName As String, ByVal dbfFilePath As String)
        _databaseName = databaseName
        _dbfFilePath = dbfFilePath
    End Sub

    Public Sub ImportData()
        Dim x = New db_Database
        Dim sqlQuery As String
        Dim localData As DataTable

        sqlQuery = String.Format("SELECT KBCI_NO,KBCI_NO, LNAME, FNAME, MI, FEBTC_SA," & _
                   " VAL(STR(DIVIDEND)), VAL(STR(REFUND)), VAL(STR(DEDUCTIONS)), DETAILS," & _
                   " LNDETAIL FROM {0}", _databaseName)

        localData = x.GetLocData(sqlQuery, String.Format("Provider=VFPOLEDB.1;Data Source={0}", _dbfFilePath))

        Using cmdDivref As New DivrefDAO
            cmdDivref.ImportDividendsAndRefund(localData)
        End Using
    End Sub

End Class
