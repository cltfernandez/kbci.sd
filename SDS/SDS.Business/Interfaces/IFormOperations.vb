Imports SDS.Common
Public Interface IFormOperations

    Function GetData() As Object

    Function SaveData(ByVal data As Object) As RecordUpdateResult

End Interface
