Public Class PolicyDefinitionsViewModel

    Public CTRL_S_ID As Integer
    Public Property Id() As Integer
        Get
            Return CTRL_S_ID
        End Get
        Set(ByVal value As Integer)
            CTRL_S_ID = value
        End Set
    End Property

    Public SYSDATE As DateTime
    Public Property SystemDate() As DateTime
        Get
            Return SYSDATE
        End Get
        Set(ByVal value As DateTime)
            SYSDATE = value
        End Set
    End Property

    Public ADMDATE As DateTime
    Public Property AdminDate() As DateTime
        Get
            Return ADMDATE
        End Get
        Set(ByVal value As DateTime)
            ADMDATE = value
        End Set
    End Property

    Public ADD_DATE As DateTime
    Public Property DateAdded() As DateTime
        Get
            Return ADD_DATE
        End Get
        Set(ByVal value As DateTime)
            ADD_DATE = value
        End Set
    End Property

    Public CHG_DATE As DateTime
    Public Property DateChanged() As DateTime
        Get
            Return CHG_DATE
        End Get
        Set(ByVal value As DateTime)
            CHG_DATE = value
        End Set
    End Property

    Public USER As String
    Public Property UserName() As String
        Get
            Return USER
        End Get
        Set(ByVal value As String)
            USER = value
        End Set
    End Property

    Public SDRATE As Single
    Public Property InterestRate() As Single
        Get
            Return SDRATE
        End Get
        Set(ByVal value As Single)
            SDRATE = value
        End Set
    End Property

    Public ACCTBR As String
    Public Property AccountBranch() As String
        Get
            Return ACCTBR
        End Get
        Set(ByVal value As String)
            ACCTBR = value
        End Set
    End Property

    Public ACCTSEQ As Single
    Public Property AccountSequence() As Single
        Get
            Return ACCTSEQ
        End Get
        Set(ByVal value As Single)
            ACCTSEQ = value
        End Set
    End Property

    Public PMAXL As Single
    Public Property PassbookMaximumLine() As Single
        Get
            Return PMAXL
        End Get
        Set(ByVal value As Single)
            PMAXL = value
        End Set
    End Property

    Public LMAXL As Single
    Public Property LedgerMaxLine() As Single
        Get
            Return LMAXL
        End Get
        Set(ByVal value As Single)
            LMAXL = value
        End Set
    End Property

    Public BINIT As Boolean
    Public Property IsBatchInitialized() As Boolean
        Get
            Return BINIT
        End Get
        Set(ByVal value As Boolean)
            BINIT = value
        End Set
    End Property

    Public BPOST As Boolean
    Public Property IsBatchPosted() As Boolean
        Get
            Return BPOST
        End Get
        Set(ByVal value As Boolean)
            BPOST = value
        End Set
    End Property

    Public CLR_ONUS As Single
    Public Property IssuedCheckClearingDays() As Single
        Get
            Return CLR_ONUS
        End Get
        Set(ByVal value As Single)
            CLR_ONUS = value
        End Set
    End Property

    Public CLR_LOCAL As Single
    Public Property LocalCheckClearingDays() As Single
        Get
            Return CLR_LOCAL
        End Get
        Set(ByVal value As Single)
            CLR_LOCAL = value
        End Set
    End Property

    Public CLR_REG As Single
    Public Property RegularCheckClearingDays() As Single
        Get
            Return CLR_REG
        End Get
        Set(ByVal value As Single)
            CLR_REG = value
        End Set
    End Property

    Public MINBAL As Single
    Public Property MinimumBalance() As Single
        Get
            Return MINBAL
        End Get
        Set(ByVal value As Single)
            MINBAL = value
        End Set
    End Property

    Public DBDORMANT As Single
    Public Property AccountDormancyDays() As Single
        Get
            Return DBDORMANT
        End Get
        Set(ByVal value As Single)
            DBDORMANT = value
        End Set
    End Property

    Public EOM_FLAG As Boolean
    Public Property IsEndOfMonth() As Boolean
        Get
            Return EOM_FLAG
        End Get
        Set(ByVal value As Boolean)
            EOM_FLAG = value
        End Set
    End Property

    Public EOQ_FLAG As Boolean
    Public Property IsEndOfQuarter() As Boolean
        Get
            Return EOQ_FLAG
        End Get
        Set(ByVal value As Boolean)
            EOQ_FLAG = value
        End Set
    End Property

    Public EOY_FLAG As Boolean
    Public Property IsEndOfYear() As Boolean
        Get
            Return EOY_FLAG
        End Get
        Set(ByVal value As Boolean)
            EOY_FLAG = value
        End Set
    End Property

    Public OTC_FLAG As Boolean
    Public Property IsOverTheCounterClosed() As Boolean
        Get
            Return OTC_FLAG
        End Get
        Set(ByVal value As Boolean)
            OTC_FLAG = value
        End Set
    End Property

    Public EOD_FLAG As Boolean
    Public Property IsEndOfDay() As Boolean
        Get
            Return EOD_FLAG
        End Get
        Set(ByVal value As Boolean)
            EOD_FLAG = value
        End Set
    End Property

    Public P_PRINT As String
    Public Property PrinterPort() As String
        Get
            Return P_PRINT
        End Get
        Set(ByVal value As String)
            P_PRINT = value
        End Set
    End Property

    Public R_PRINT As String
    Public Property PrinterComm() As String
        Get
            Return R_PRINT
        End Get
        Set(ByVal value As String)
            R_PRINT = value
        End Set
    End Property

    Private _dormancyCharge As Single
    Public Property DormancyCharge() As Single
        Get
            Return _dormancyCharge
        End Get
        Set(ByVal value As Single)
            _dormancyCharge = value
        End Set
    End Property

    Private _minimumInterestEarningBalance As Single
    Public Property MinimumInterestEarningBalance() As Single
        Get
            Return _minimumInterestEarningBalance
        End Get
        Set(ByVal value As Single)
            _minimumInterestEarningBalance = value
        End Set
    End Property
End Class
