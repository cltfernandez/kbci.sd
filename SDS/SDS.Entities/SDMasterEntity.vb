
Public Class SDMasterEntity
    Private _SDMASTER_ID As Integer
    Private _ACCTNO As String
    Private _KBCINO As String
    Private _ACCTPBAL As Double
    Private _ACCTLBAL As Double
    Private _ACCTOBAL As Double
    Private _ACCTFLOATS As Double
    Private _ACCTABAL As Double
    Private _ACCTSTAT As String
    Private _HOLDOUT As Double
    Private _LSEQ As Integer
    Private _PLINE As Integer
    Private _ACCTNAME As String
    Private _REC_STAT As Boolean

    Public Property SDMASTER_ID() As Integer
        Get
            Return _SDMASTER_ID
        End Get
        Set(ByVal value As Integer)
            _SDMASTER_ID = value
        End Set
    End Property
    Public Property ACCTNO() As String
        Get
            Return _ACCTNO
        End Get
        Set(ByVal value As String)
            _ACCTNO = value
        End Set
    End Property

    Public Property KBCINO() As String
        Get
            Return _KBCINO
        End Get
        Set(ByVal value As String)
            _KBCINO = value
        End Set
    End Property
    Public Property ACCTNAME() As String
        Get
            Return _ACCTNAME
        End Get
        Set(ByVal value As String)
            _ACCTNAME = value
        End Set
    End Property
    Public Property ACCTPBAL() As Double
        Get
            Return _ACCTPBAL
        End Get
        Set(ByVal value As Double)
            _ACCTPBAL = value
        End Set
    End Property
    Public Property ACCTLBAL() As Double
        Get
            Return _ACCTLBAL
        End Get
        Set(ByVal value As Double)
            _ACCTLBAL = value
        End Set
    End Property
    Public Property ACCTOBAL() As Double
        Get
            Return _ACCTOBAL
        End Get
        Set(ByVal value As Double)
            _ACCTOBAL = value
        End Set
    End Property
    Public Property ACCTFLOATS() As Double
        Get
            Return _ACCTFLOATS
        End Get
        Set(ByVal value As Double)
            _ACCTFLOATS = value
        End Set
    End Property
    Public Property ACCTABAL() As Double
        Get
            Return _ACCTABAL
        End Get
        Set(ByVal value As Double)
            _ACCTABAL = value
        End Set
    End Property

    Public Property ACCTSTAT() As String
        Get
            Return _ACCTSTAT
        End Get
        Set(ByVal value As String)
            _ACCTSTAT = value
        End Set
    End Property
    Public Property HOLDOUT() As Double
        Get
            Return _HOLDOUT
        End Get
        Set(ByVal value As Double)
            _HOLDOUT = value
        End Set
    End Property

    Public Property LSEQ() As Integer
        Get
            Return _LSEQ
        End Get
        Set(ByVal value As Integer)
            _LSEQ = value
        End Set
    End Property
    Public Property REC_STAT() As Boolean
        Get
            Return _REC_STAT
        End Get
        Set(ByVal value As Boolean)
            _REC_STAT = value
        End Set
    End Property


End Class
Public Class SDMasterList
    Inherits List(Of SDMasterEntity)
    Public Sub New()
    End Sub

    Public Overridable Shadows Sub Add(ByVal thisList As SDMasterEntity)
        MyBase.Add(thisList)
    End Sub
End Class

