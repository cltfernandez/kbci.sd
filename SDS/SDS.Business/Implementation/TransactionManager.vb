Imports SDS.Entities

Public Class TransactionManager
#Region "SDMasterEntity"
    Public Sub AddTransaction(ByVal sdme As SDMasterEntity)
        Dim _Binder As New ObjectBinder
        '_Binder.insert_SDOTHERS(Me)
        _Binder = Nothing

    End Sub
    'Public Sub get(Optional ByVal filterStr As String = Nothing, Optional ByVal orderStr As String = Nothing)
    '    Dim _Binder As New ObjectBinder
    '    '_Binder.bind_SDOTHERS(Me, filterStr, orderStr)        
    '    _Binder = Nothing
    'End Sub
    'Public Sub updData()
    '    Dim _Binder As New ObjectBinder
    '    '_Binder.update_SDOTHERS(Me)
    '    _Binder = Nothing
    'End Sub
    Public Function GetUserTransactions(Optional ByVal filterStr As String = Nothing, Optional ByVal orderStr As String = Nothing) As SDMasterList
        Dim _Binder As New ObjectBinder
        Return _Binder.bind_SDMASTER_List(filterStr, orderStr)
    End Function
#End Region
#Region "SDOthersEntity"
    'Public Sub addData()
    '    Dim _Binder As New ObjectBinder
    '    _Binder.insert_SDOTHERS(Me)
    '    _Binder = Nothing
    'End Sub
    'Public Sub getData()
    '    Dim _Binder As New ObjectBinder
    '    _Binder.bind_SDOTHERS(Me)
    '    _Binder = Nothing
    'End Sub
    'Public Sub updData()
    '    Dim _Binder As New ObjectBinder
    '    _Binder.update_SDOTHERS(Me)
    '    _Binder = Nothing
    'End Sub

    'Public Sub delData()
    '    Dim _Binder As New ObjectBinder
    '    _Binder.delete_SDOTHERS(Me)
    '    _Binder = Nothing
    'End Sub

    Public Function getDataList(Optional ByVal filterStr As String = Nothing, Optional ByVal orderStr As String = Nothing) As SDOthersList
        Dim _Binder As New ObjectBinder
        Return _Binder.bind_SDOTHERS_List(filterStr, orderStr)
    End Function
#End Region
End Class