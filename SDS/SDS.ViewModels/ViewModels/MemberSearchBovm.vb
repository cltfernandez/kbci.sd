
Public Class MemberSearchBovm

    Private _KBCI_ID As Int64
    Public Property KBCI_ID() As Int64
        Get
            Return _KBCI_ID
        End Get
        Set(ByVal value As Int64)
            _KBCI_ID = value
        End Set
    End Property


    Private _KBCI_NO As String
    Public Property KBCI_NO() As String
        Get
            Return _KBCI_NO
        End Get
        Set(ByVal value As String)
            _KBCI_NO = value
        End Set
    End Property

    Private _LNAME As String
    Public Property LNAME() As String
        Get
            Return _LNAME
        End Get
        Set(ByVal value As String)
            _LNAME = value
        End Set
    End Property

    Private _FNAME As String
    Public Property FNAME() As String
        Get
            Return _FNAME
        End Get
        Set(ByVal value As String)
            _FNAME = value
        End Set
    End Property

    Private _MI As String
    Public Property MI() As String
        Get
            Return _MI
        End Get
        Set(ByVal value As String)
            _MI = value
        End Set
    End Property
    Private _FEBTC_SA As String
    Public Property FEBTC_SA() As String
        Get
            Return _FEBTC_SA
        End Get
        Set(ByVal value As String)
            _FEBTC_SA = value
        End Set
    End Property

    Private _FEBTC_CA As String
    Public Property FEBTC_CA() As String
        Get
            Return _FEBTC_CA
        End Get
        Set(ByVal value As String)
            _FEBTC_CA = value
        End Set
    End Property
End Class
