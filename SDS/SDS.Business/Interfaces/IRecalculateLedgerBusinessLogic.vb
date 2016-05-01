Imports SDS.DataAccessObject
Imports SDS.Common

Public Interface IRecalculateLedgerBusinessLogic
    Function Calculate(ByVal AccountNo As String, ByVal StartDate As Date) As RecalculateLedgerResult
End Interface
