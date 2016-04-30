Public Class SdMaster


    Private _AcctNo As String
    Public Property AcctNo() As String
        Get
            Return _AcctNo
        End Get
        Set(ByVal value As String)
            _AcctNo = value
        End Set
    End Property

    Private _KbciNo As String
    Public Property KbciNo() As String
        Get
            Return _KbciNo
        End Get
        Set(ByVal value As String)
            _KbciNo = value
        End Set
    End Property

    Private _CbEmpNo As String
    Public Property CbEmpNo() As String
        Get
            Return _CbEmpNo
        End Get
        Set(ByVal value As String)
            _CbEmpNo = value
        End Set
    End Property

    Private _AcctName As String
    Public Property AcctName() As String
        Get
            Return _AcctName
        End Get
        Set(ByVal value As String)
            _AcctName = value
        End Set
    End Property

    Private _AcctAddr1 As String
    Public Property AcctAddr1() As String
        Get
            Return _AcctAddr1
        End Get
        Set(ByVal value As String)
            _AcctAddr1 = value
        End Set
    End Property

    Private _AcctAddr2 As String
    Public Property AcctAddr2() As String
        Get
            Return _AcctAddr2
        End Get
        Set(ByVal value As String)
            _AcctAddr2 = value
        End Set
    End Property


    Private _AcctsName As String
    Public Property AcctsName() As String
        Get
            Return _AcctsName
        End Get
        Set(ByVal value As String)
            _AcctsName = value
        End Set
    End Property


    Private _AcctPhone1 As String
    Public Property AcctPhone1() As String
        Get
            Return _AcctPhone1
        End Get
        Set(ByVal value As String)
            _AcctPhone1 = value
        End Set
    End Property

    Private _AcctPhone2 As String
    Public Property AcctPhone2() As String
        Get
            Return _AcctPhone2
        End Get
        Set(ByVal value As String)
            _AcctPhone2 = value
        End Set
    End Property

    Private _AcctdType As String
    Public Property AcctdType() As String
        Get
            Return _AcctdType
        End Get
        Set(ByVal value As String)
            _AcctdType = value
        End Set
    End Property


    Private _AcctcCode As String
    Public Property AcctcCode() As String
        Get
            Return _AcctcCode
        End Get
        Set(ByVal value As String)
            _AcctcCode = value
        End Set
    End Property


    Private _AcctiCode As String
    Public Property AcctiCode() As String
        Get
            Return _AcctiCode
        End Get
        Set(ByVal value As String)
            _AcctiCode = value
        End Set
    End Property


    Private _AcctATX As String
    Public Property AcctATX() As String
        Get
            Return _AcctATX
        End Get
        Set(ByVal value As String)
            _AcctATX = value
        End Set
    End Property


    Private _AcctOth1 As String
    Public Property AcctOth1() As String
        Get
            Return _AcctOth1
        End Get
        Set(ByVal value As String)
            _AcctOth1 = value
        End Set
    End Property

    Private _AcctOth2 As String
    Public Property AcctOth2() As String
        Get
            Return _AcctOth2
        End Get
        Set(ByVal value As String)
            _AcctOth2 = value
        End Set
    End Property


    Private _AcctMaint As Double
    Public Property AcctMaint() As Double
        Get
            Return _AcctMaint
        End Get
        Set(ByVal value As Double)
            _AcctMaint = value
        End Set
    End Property

    Private _AcctiDep As Double
    Public Property AcctiDep() As Double
        Get
            Return _AcctiDep
        End Get
        Set(ByVal value As Double)
            _AcctiDep = value
        End Set
    End Property


    Private _AcctpBal As Double
    Public Property AcctpBal() As Double
        Get
            Return _AcctpBal
        End Get
        Set(ByVal value As Double)
            _AcctpBal = value
        End Set
    End Property


    Private _AcctlBal As Double
    Public Property AcctlBal() As Double
        Get
            Return _AcctlBal
        End Get
        Set(ByVal value As Double)
            _AcctlBal = value
        End Set
    End Property


    Private _AcctoBal As Double
    Public Property AcctoBal() As Double
        Get
            Return _AcctoBal
        End Get
        Set(ByVal value As Double)
            _AcctoBal = value
        End Set
    End Property

    Private _AcctaBal As Double
    Public Property AcctaBal() As Double
        Get
            Return _AcctaBal
        End Get
        Set(ByVal value As Double)
            _AcctaBal = value
        End Set
    End Property

    Private _AcctFloats As Double
    Public Property AcctFloats() As Double
        Get
            Return _AcctFloats
        End Get
        Set(ByVal value As Double)
            _AcctFloats = value
        End Set
    End Property


    Private _AcctTex As String
    Public Property AcctTex() As String
        Get
            Return _AcctTex
        End Get
        Set(ByVal value As String)
            _AcctTex = value
        End Set
    End Property


    Private _AcctaClo As String
    Public Property AcctaClo() As String
        Get
            Return _AcctaClo
        End Get
        Set(ByVal value As String)
            _AcctaClo = value
        End Set
    End Property



    Private _AcctwMin As String
    Public Property AcctwMin() As String
        Get
            Return _AcctwMin
        End Get
        Set(ByVal value As String)
            _AcctwMin = value
        End Set
    End Property


    Private _AcctWsc As String
    Public Property AcctWsc() As String
        Get
            Return _AcctWsc
        End Get
        Set(ByVal value As String)
            _AcctWsc = value
        End Set
    End Property


    Private _AcctwInt As String
    Public Property AcctwInt() As String
        Get
            Return _AcctwInt
        End Get
        Set(ByVal value As String)
            _AcctwInt = value
        End Set
    End Property


    Private _AcctStat As String
    Public Property AcctStat() As String
        Get
            Return _AcctStat
        End Get
        Set(ByVal value As String)
            _AcctStat = value
        End Set
    End Property


    Private _PLine As Integer
    Public Property PLine() As Integer
        Get
            Return _PLine
        End Get
        Set(ByVal value As Integer)
            _PLine = value
        End Set
    End Property

    Private _LLine As Integer
    Public Property LLine() As Integer
        Get
            Return _LLine
        End Get
        Set(ByVal value As Integer)
            _LLine = value
        End Set
    End Property

    Private _Unposted As Integer
    Public Property Unposted() As Integer
        Get
            Return _Unposted
        End Get
        Set(ByVal value As Integer)
            _Unposted = value
        End Set
    End Property

    Private _HoldOut As Integer
    Public Property HoldOut() As Integer
        Get
            Return _HoldOut
        End Get
        Set(ByVal value As Integer)
            _HoldOut = value
        End Set
    End Property

    Private _LSeq As Integer
    Public Property LSeq() As Integer
        Get
            Return _LSeq
        End Get
        Set(ByVal value As Integer)
            _LSeq = value
        End Set
    End Property


    Private _AddDate As Date
    Public Property AddDate() As Date
        Get
            Return _AddDate
        End Get
        Set(ByVal value As Date)
            _AddDate = value
        End Set
    End Property

    Private _ChgDate As Date
    Public Property ChgDate() As Date
        Get
            Return _ChgDate
        End Get
        Set(ByVal value As Date)
            _ChgDate = value
        End Set
    End Property


    Private _UpdUser As String
    Public Property UpdUser() As String
        Get
            Return _UpdUser
        End Get
        Set(ByVal value As String)
            _UpdUser = value
        End Set
    End Property

    Private _RecStat As String
    Public Property RecStat() As String
        Get
            Return _RecStat
        End Get
        Set(ByVal value As String)
            _RecStat = value
        End Set
    End Property















End Class
