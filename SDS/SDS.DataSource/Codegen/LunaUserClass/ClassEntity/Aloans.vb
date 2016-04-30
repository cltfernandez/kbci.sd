#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 20/06/2015 
#End Region



''' <summary>
'''Entity Class for table Aloans
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Aloans
	Inherits _Aloans
    Implements IAloans

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property ALOANS_ID() as Int64
    Get
	    Return MyBase.ALOANS_ID
    End Get
    Set (byval value as Int64)
        MyBase.ALOANS_ID= value
    End Set
End property 


Public Overrides Property PN_NO() as string
    Get
	    Return MyBase.PN_NO
    End Get
    Set (byval value as string)
        MyBase.PN_NO= value
    End Set
End property 


Public Overrides Property KBCI_NO() as string
    Get
	    Return MyBase.KBCI_NO
    End Get
    Set (byval value as string)
        MyBase.KBCI_NO= value
    End Set
End property 


Public Overrides Property APP_DATE() as DateTime
    Get
	    Return MyBase.APP_DATE
    End Get
    Set (byval value as DateTime)
        MyBase.APP_DATE= value
    End Set
End property 


Public Overrides Property APP_NO() as single
    Get
	    Return MyBase.APP_NO
    End Get
    Set (byval value as single)
        MyBase.APP_NO= value
    End Set
End property 


Public Overrides Property DATE_GRANT() as DateTime
    Get
	    Return MyBase.DATE_GRANT
    End Get
    Set (byval value as DateTime)
        MyBase.DATE_GRANT= value
    End Set
End property 


Public Overrides Property BY_WHOM() as string
    Get
	    Return MyBase.BY_WHOM
    End Get
    Set (byval value as string)
        MyBase.BY_WHOM= value
    End Set
End property 


Public Overrides Property DATE_DUE() as DateTime
    Get
	    Return MyBase.DATE_DUE
    End Get
    Set (byval value as DateTime)
        MyBase.DATE_DUE= value
    End Set
End property 


Public Overrides Property CHKNO_BANK() as string
    Get
	    Return MyBase.CHKNO_BANK
    End Get
    Set (byval value as string)
        MyBase.CHKNO_BANK= value
    End Set
End property 


Public Overrides Property CHKNO() as string
    Get
	    Return MyBase.CHKNO
    End Get
    Set (byval value as string)
        MyBase.CHKNO= value
    End Set
End property 


Public Overrides Property CHKNO_AMT() as single
    Get
	    Return MyBase.CHKNO_AMT
    End Get
    Set (byval value as single)
        MyBase.CHKNO_AMT= value
    End Set
End property 


Public Overrides Property CHKNO_DATE() as DateTime
    Get
	    Return MyBase.CHKNO_DATE
    End Get
    Set (byval value as DateTime)
        MyBase.CHKNO_DATE= value
    End Set
End property 


Public Overrides Property CHKNO_RELS() as string
    Get
	    Return MyBase.CHKNO_RELS
    End Get
    Set (byval value as string)
        MyBase.CHKNO_RELS= value
    End Set
End property 


Public Overrides Property CHKNO_ACK() as DateTime
    Get
	    Return MyBase.CHKNO_ACK
    End Get
    Set (byval value as DateTime)
        MyBase.CHKNO_ACK= value
    End Set
End property 


Public Overrides Property MOD_PAY() as string
    Get
	    Return MyBase.MOD_PAY
    End Get
    Set (byval value as string)
        MyBase.MOD_PAY= value
    End Set
End property 


Public Overrides Property AMORT_AMT() as single
    Get
	    Return MyBase.AMORT_AMT
    End Get
    Set (byval value as single)
        MyBase.AMORT_AMT= value
    End Set
End property 


Public Overrides Property PAY_START() as DateTime
    Get
	    Return MyBase.PAY_START
    End Get
    Set (byval value as DateTime)
        MyBase.PAY_START= value
    End Set
End property 


Public Overrides Property RATE() as single
    Get
	    Return MyBase.RATE
    End Get
    Set (byval value as single)
        MyBase.RATE= value
    End Set
End property 


Public Overrides Property TERM() as single
    Get
	    Return MyBase.TERM
    End Get
    Set (byval value as single)
        MyBase.TERM= value
    End Set
End property 


Public Overrides Property FREQ() as string
    Get
	    Return MyBase.FREQ
    End Get
    Set (byval value as string)
        MyBase.FREQ= value
    End Set
End property 


Public Overrides Property PRINCIPAL() as single
    Get
	    Return MyBase.PRINCIPAL
    End Get
    Set (byval value as single)
        MyBase.PRINCIPAL= value
    End Set
End property 


Public Overrides Property LED_TYPE() as single
    Get
	    Return MyBase.LED_TYPE
    End Get
    Set (byval value as single)
        MyBase.LED_TYPE= value
    End Set
End property 


Public Overrides Property ADV_INTE() as single
    Get
	    Return MyBase.ADV_INTE
    End Get
    Set (byval value as single)
        MyBase.ADV_INTE= value
    End Set
End property 


Public Overrides Property AFT_INTE() as single
    Get
	    Return MyBase.AFT_INTE
    End Get
    Set (byval value as single)
        MyBase.AFT_INTE= value
    End Set
End property 


Public Overrides Property ACCU_PAYP() as single
    Get
	    Return MyBase.ACCU_PAYP
    End Get
    Set (byval value as single)
        MyBase.ACCU_PAYP= value
    End Set
End property 


Public Overrides Property YTD_I() as single
    Get
	    Return MyBase.YTD_I
    End Get
    Set (byval value as single)
        MyBase.YTD_I= value
    End Set
End property 


Public Overrides Property LOAN_TYPE() as string
    Get
	    Return MyBase.LOAN_TYPE
    End Get
    Set (byval value as string)
        MyBase.LOAN_TYPE= value
    End Set
End property 


Public Overrides Property LOAN_STAT() as string
    Get
	    Return MyBase.LOAN_STAT
    End Get
    Set (byval value as string)
        MyBase.LOAN_STAT= value
    End Set
End property 


Public Overrides Property ARREAR_I() as single
    Get
	    Return MyBase.ARREAR_I
    End Get
    Set (byval value as single)
        MyBase.ARREAR_I= value
    End Set
End property 


Public Overrides Property ARREAR_P() as single
    Get
	    Return MyBase.ARREAR_P
    End Get
    Set (byval value as single)
        MyBase.ARREAR_P= value
    End Set
End property 


Public Overrides Property ARREAR_OTH() as single
    Get
	    Return MyBase.ARREAR_OTH
    End Get
    Set (byval value as single)
        MyBase.ARREAR_OTH= value
    End Set
End property 


Public Overrides Property ARREAR_AS() as DateTime
    Get
	    Return MyBase.ARREAR_AS
    End Get
    Set (byval value as DateTime)
        MyBase.ARREAR_AS= value
    End Set
End property 


Public Overrides Property COLLATERAL() as Boolean
    Get
	    Return MyBase.COLLATERAL
    End Get
    Set (byval value as Boolean)
        MyBase.COLLATERAL= value
    End Set
End property 


Public Overrides Property DED_BAL() as string
    Get
	    Return MyBase.DED_BAL
    End Get
    Set (byval value as string)
        MyBase.DED_BAL= value
    End Set
End property 


Public Overrides Property ADD_DATE() as DateTime
    Get
	    Return MyBase.ADD_DATE
    End Get
    Set (byval value as DateTime)
        MyBase.ADD_DATE= value
    End Set
End property 


Public Overrides Property CHG_DATE() as DateTime
    Get
	    Return MyBase.CHG_DATE
    End Get
    Set (byval value as DateTime)
        MyBase.CHG_DATE= value
    End Set
End property 


Public Overrides Property USER() as string
    Get
	    Return MyBase.USER
    End Get
    Set (byval value as string)
        MyBase.USER= value
    End Set
End property 


Public Overrides Property P_BAL() as single
    Get
	    Return MyBase.P_BAL
    End Get
    Set (byval value as single)
        MyBase.P_BAL= value
    End Set
End property 


Public Overrides Property I_BAL() as single
    Get
	    Return MyBase.I_BAL
    End Get
    Set (byval value as single)
        MyBase.I_BAL= value
    End Set
End property 


Public Overrides Property O_BAL() as single
    Get
	    Return MyBase.O_BAL
    End Get
    Set (byval value as single)
        MyBase.O_BAL= value
    End Set
End property 


Public Overrides Property REC_STAT() as Boolean
    Get
	    Return MyBase.REC_STAT
    End Get
    Set (byval value as Boolean)
        MyBase.REC_STAT= value
    End Set
End property 


Public Overrides Property RENEW() as Boolean
    Get
	    Return MyBase.RENEW
    End Get
    Set (byval value as Boolean)
        MyBase.RENEW= value
    End Set
End property 


Public Overrides Property ADVANCE() as single
    Get
	    Return MyBase.ADVANCE
    End Get
    Set (byval value as single)
        MyBase.ADVANCE= value
    End Set
End property 


Public Overrides Property LRI_IND() as Boolean
    Get
	    Return MyBase.LRI_IND
    End Get
    Set (byval value as Boolean)
        MyBase.LRI_IND= value
    End Set
End property 


Public Overrides Property NDUE() as DateTime
    Get
	    Return MyBase.NDUE
    End Get
    Set (byval value as DateTime)
        MyBase.NDUE= value
    End Set
End property 


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements IAloans.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements IAloans.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements IAloans.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Aloans
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface IAloans
        Inherits _IAloans

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface