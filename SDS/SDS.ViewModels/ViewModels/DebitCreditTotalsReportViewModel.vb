Public Class DebitCreditTotalsReportViewModel


    Private _CTRLNO As String
    Public Property CTRLNO() As String
        Get
            Return _CTRLNO
        End Get
        Set(ByVal value As String)
            _CTRLNO = value
        End Set
    End Property


    Private _TRANBBAL As Decimal
    Public Property TRANBBAL() As Decimal
        Get
            Return _TRANBBAL
        End Get
        Set(ByVal value As Decimal)
            _TRANBBAL = value
        End Set
    End Property

    Private _TRANDEB As String
    Public Property TRANDEB() As Decimal
        Get
            Return _TRANDEB
        End Get
        Set(ByVal value As Decimal)
            _TRANDEB = value
        End Set
    End Property

    Private _TRANCRE As Decimal
    Public Property TRANCRE() As Decimal
        Get
            Return _TRANCRE
        End Get
        Set(ByVal value As Decimal)
            _TRANCRE = value
        End Set
    End Property

    Private _TRANEBAL As Decimal
    Public Property TRANEBAL() As Decimal
        Get
            Return _TRANEBAL
        End Get
        Set(ByVal value As Decimal)
            _TRANEBAL = value
        End Set
    End Property

End Class
