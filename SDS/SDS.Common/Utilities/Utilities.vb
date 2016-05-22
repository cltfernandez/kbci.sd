Imports System.Reflection

Public Class Utilities
    Public Shared Function GetConfig(ByVal KEY As String) As String
        Dim crypto As New Crpyto(System.Configuration.ConfigurationManager.AppSettings(KEY), System.Configuration.ConfigurationManager.AppSettings("32"))
        Return crypto.Decrypt
    End Function

    Public Shared Function GetGlobalResourceString(ByVal resourceKey As String) As String
        Dim myResource As New My.Resources.GlobalResource
        Return myResource.ResourceManager.GetString(resourceKey)
    End Function

    Public Shared Function ConvertToDataTable(Of T)(ByVal list As IList(Of T)) As DataTable
        Dim table As New DataTable()
        Dim fields() As PropertyInfo = GetType(T).GetProperties()
        For Each field As PropertyInfo In fields
            table.Columns.Add(field.Name, field.PropertyType)
        Next
        For Each item As T In list
            Dim row As DataRow = table.NewRow()
            For Each field As PropertyInfo In fields
                row(field.Name) = field.GetValue(item, Nothing)
            Next
            table.Rows.Add(row)
        Next
        Return table
    End Function
End Class
