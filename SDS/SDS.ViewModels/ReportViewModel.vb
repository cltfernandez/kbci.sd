Public Class ReportViewModel

    Private _ReportTitle As String
    Public Property ReportTitle() As String
        Get
            Return _ReportTitle
        End Get
        Set(ByVal value As String)
            _ReportTitle = value
        End Set
    End Property


    Private _SubHeader As String
    Public Property SubHeader() As String
        Get
            Return _SubHeader
        End Get
        Set(ByVal value As String)
            _SubHeader = value
        End Set
    End Property

    Private _Data As DataTable
    Public Property Data() As DataTable
        Get
            Return _Data
        End Get
        Set(ByVal value As DataTable)
            _Data = value
        End Set
    End Property
End Class
