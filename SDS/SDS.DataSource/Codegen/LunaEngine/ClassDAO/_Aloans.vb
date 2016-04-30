#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 20/06/2015 
#End Region


Imports System.Xml.Serialization

''' <summary>
'''DAO Class for table Aloans
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Aloans
	Inherits LUNA.LunaBaseClassEntity
    Implements _IAloans
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _IAloans.FillFromDataRecord
     ALOANS_ID = myRecord("ALOANS_ID")
    		if not myRecord("PN_NO") is DBNull.Value then PN_NO = myRecord("PN_NO")
    		if not myRecord("KBCI_NO") is DBNull.Value then KBCI_NO = myRecord("KBCI_NO")
    		if not myRecord("APP_DATE") is DBNull.Value then APP_DATE = myRecord("APP_DATE")
    		if not myRecord("APP_NO") is DBNull.Value then APP_NO = myRecord("APP_NO")
    		if not myRecord("DATE_GRANT") is DBNull.Value then DATE_GRANT = myRecord("DATE_GRANT")
    		if not myRecord("BY_WHOM") is DBNull.Value then BY_WHOM = myRecord("BY_WHOM")
    		if not myRecord("DATE_DUE") is DBNull.Value then DATE_DUE = myRecord("DATE_DUE")
    		if not myRecord("CHKNO_BANK") is DBNull.Value then CHKNO_BANK = myRecord("CHKNO_BANK")
    		if not myRecord("CHKNO") is DBNull.Value then CHKNO = myRecord("CHKNO")
    		if not myRecord("CHKNO_AMT") is DBNull.Value then CHKNO_AMT = myRecord("CHKNO_AMT")
    		if not myRecord("CHKNO_DATE") is DBNull.Value then CHKNO_DATE = myRecord("CHKNO_DATE")
    		if not myRecord("CHKNO_RELS") is DBNull.Value then CHKNO_RELS = myRecord("CHKNO_RELS")
    		if not myRecord("CHKNO_ACK") is DBNull.Value then CHKNO_ACK = myRecord("CHKNO_ACK")
    		if not myRecord("MOD_PAY") is DBNull.Value then MOD_PAY = myRecord("MOD_PAY")
    		if not myRecord("AMORT_AMT") is DBNull.Value then AMORT_AMT = myRecord("AMORT_AMT")
    		if not myRecord("PAY_START") is DBNull.Value then PAY_START = myRecord("PAY_START")
    		if not myRecord("RATE") is DBNull.Value then RATE = myRecord("RATE")
    		if not myRecord("TERM") is DBNull.Value then TERM = myRecord("TERM")
    		if not myRecord("FREQ") is DBNull.Value then FREQ = myRecord("FREQ")
    		if not myRecord("PRINCIPAL") is DBNull.Value then PRINCIPAL = myRecord("PRINCIPAL")
    		if not myRecord("LED_TYPE") is DBNull.Value then LED_TYPE = myRecord("LED_TYPE")
    		if not myRecord("ADV_INTE") is DBNull.Value then ADV_INTE = myRecord("ADV_INTE")
    		if not myRecord("AFT_INTE") is DBNull.Value then AFT_INTE = myRecord("AFT_INTE")
    		if not myRecord("ACCU_PAYP") is DBNull.Value then ACCU_PAYP = myRecord("ACCU_PAYP")
    		if not myRecord("YTD_I") is DBNull.Value then YTD_I = myRecord("YTD_I")
    		if not myRecord("LOAN_TYPE") is DBNull.Value then LOAN_TYPE = myRecord("LOAN_TYPE")
    		if not myRecord("LOAN_STAT") is DBNull.Value then LOAN_STAT = myRecord("LOAN_STAT")
    		if not myRecord("ARREAR_I") is DBNull.Value then ARREAR_I = myRecord("ARREAR_I")
    		if not myRecord("ARREAR_P") is DBNull.Value then ARREAR_P = myRecord("ARREAR_P")
    		if not myRecord("ARREAR_OTH") is DBNull.Value then ARREAR_OTH = myRecord("ARREAR_OTH")
    		if not myRecord("ARREAR_AS") is DBNull.Value then ARREAR_AS = myRecord("ARREAR_AS")
    		if not myRecord("COLLATERAL") is DBNull.Value then COLLATERAL = myRecord("COLLATERAL")
    		if not myRecord("DED_BAL") is DBNull.Value then DED_BAL = myRecord("DED_BAL")
    		if not myRecord("ADD_DATE") is DBNull.Value then ADD_DATE = myRecord("ADD_DATE")
    		if not myRecord("CHG_DATE") is DBNull.Value then CHG_DATE = myRecord("CHG_DATE")
    		if not myRecord("USER") is DBNull.Value then USER = myRecord("USER")
    		if not myRecord("P_BAL") is DBNull.Value then P_BAL = myRecord("P_BAL")
    		if not myRecord("I_BAL") is DBNull.Value then I_BAL = myRecord("I_BAL")
    		if not myRecord("O_BAL") is DBNull.Value then O_BAL = myRecord("O_BAL")
    		if not myRecord("REC_STAT") is DBNull.Value then REC_STAT = myRecord("REC_STAT")
    		if not myRecord("RENEW") is DBNull.Value then RENEW = myRecord("RENEW")
    		if not myRecord("ADVANCE") is DBNull.Value then ADVANCE = myRecord("ADVANCE")
    		if not myRecord("LRI_IND") is DBNull.Value then LRI_IND = myRecord("LRI_IND")
    		if not myRecord("NDUE") is DBNull.Value then NDUE = myRecord("NDUE")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Aloans)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(AloansDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Aloans))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _ALOANS_ID as Int64  = Nothing 
Public Overridable Property ALOANS_ID() as Int64  Implements _IAloans.ALOANS_ID
    Get
	    Return _ALOANS_ID
    End Get
    Set (byval value as Int64)
	    If _ALOANS_ID <> value Then
	        IsChanged = True
	        _ALOANS_ID= value
	    End If
    End Set
End property 

Protected _PN_NO as string  = "" 
Public Overridable Property PN_NO() as string  Implements _IAloans.PN_NO
    Get
	    Return _PN_NO
    End Get
    Set (byval value as string)
	    If _PN_NO <> value Then
	        IsChanged = True
	        _PN_NO= value
	    End If
    End Set
End property 

Protected _KBCI_NO as string  = "" 
Public Overridable Property KBCI_NO() as string  Implements _IAloans.KBCI_NO
    Get
	    Return _KBCI_NO
    End Get
    Set (byval value as string)
	    If _KBCI_NO <> value Then
	        IsChanged = True
	        _KBCI_NO= value
	    End If
    End Set
End property 

Protected _APP_DATE as DateTime  = Nothing 
Public Overridable Property APP_DATE() as DateTime  Implements _IAloans.APP_DATE
    Get
	    Return _APP_DATE
    End Get
    Set (byval value as DateTime)
	    If _APP_DATE <> value Then
	        IsChanged = True
	        _APP_DATE= value
	    End If
    End Set
End property 

Protected _APP_NO as single  = 0 
Public Overridable Property APP_NO() as single  Implements _IAloans.APP_NO
    Get
	    Return _APP_NO
    End Get
    Set (byval value as single)
	    If _APP_NO <> value Then
	        IsChanged = True
	        _APP_NO= value
	    End If
    End Set
End property 

Protected _DATE_GRANT as DateTime  = Nothing 
Public Overridable Property DATE_GRANT() as DateTime  Implements _IAloans.DATE_GRANT
    Get
	    Return _DATE_GRANT
    End Get
    Set (byval value as DateTime)
	    If _DATE_GRANT <> value Then
	        IsChanged = True
	        _DATE_GRANT= value
	    End If
    End Set
End property 

Protected _BY_WHOM as string  = "" 
Public Overridable Property BY_WHOM() as string  Implements _IAloans.BY_WHOM
    Get
	    Return _BY_WHOM
    End Get
    Set (byval value as string)
	    If _BY_WHOM <> value Then
	        IsChanged = True
	        _BY_WHOM= value
	    End If
    End Set
End property 

Protected _DATE_DUE as DateTime  = Nothing 
Public Overridable Property DATE_DUE() as DateTime  Implements _IAloans.DATE_DUE
    Get
	    Return _DATE_DUE
    End Get
    Set (byval value as DateTime)
	    If _DATE_DUE <> value Then
	        IsChanged = True
	        _DATE_DUE= value
	    End If
    End Set
End property 

Protected _CHKNO_BANK as string  = "" 
Public Overridable Property CHKNO_BANK() as string  Implements _IAloans.CHKNO_BANK
    Get
	    Return _CHKNO_BANK
    End Get
    Set (byval value as string)
	    If _CHKNO_BANK <> value Then
	        IsChanged = True
	        _CHKNO_BANK= value
	    End If
    End Set
End property 

Protected _CHKNO as string  = "" 
Public Overridable Property CHKNO() as string  Implements _IAloans.CHKNO
    Get
	    Return _CHKNO
    End Get
    Set (byval value as string)
	    If _CHKNO <> value Then
	        IsChanged = True
	        _CHKNO= value
	    End If
    End Set
End property 

Protected _CHKNO_AMT as single  = 0 
Public Overridable Property CHKNO_AMT() as single  Implements _IAloans.CHKNO_AMT
    Get
	    Return _CHKNO_AMT
    End Get
    Set (byval value as single)
	    If _CHKNO_AMT <> value Then
	        IsChanged = True
	        _CHKNO_AMT= value
	    End If
    End Set
End property 

Protected _CHKNO_DATE as DateTime  = Nothing 
Public Overridable Property CHKNO_DATE() as DateTime  Implements _IAloans.CHKNO_DATE
    Get
	    Return _CHKNO_DATE
    End Get
    Set (byval value as DateTime)
	    If _CHKNO_DATE <> value Then
	        IsChanged = True
	        _CHKNO_DATE= value
	    End If
    End Set
End property 

Protected _CHKNO_RELS as string  = "" 
Public Overridable Property CHKNO_RELS() as string  Implements _IAloans.CHKNO_RELS
    Get
	    Return _CHKNO_RELS
    End Get
    Set (byval value as string)
	    If _CHKNO_RELS <> value Then
	        IsChanged = True
	        _CHKNO_RELS= value
	    End If
    End Set
End property 

Protected _CHKNO_ACK as DateTime  = Nothing 
Public Overridable Property CHKNO_ACK() as DateTime  Implements _IAloans.CHKNO_ACK
    Get
	    Return _CHKNO_ACK
    End Get
    Set (byval value as DateTime)
	    If _CHKNO_ACK <> value Then
	        IsChanged = True
	        _CHKNO_ACK= value
	    End If
    End Set
End property 

Protected _MOD_PAY as string  = "" 
Public Overridable Property MOD_PAY() as string  Implements _IAloans.MOD_PAY
    Get
	    Return _MOD_PAY
    End Get
    Set (byval value as string)
	    If _MOD_PAY <> value Then
	        IsChanged = True
	        _MOD_PAY= value
	    End If
    End Set
End property 

Protected _AMORT_AMT as single  = 0 
Public Overridable Property AMORT_AMT() as single  Implements _IAloans.AMORT_AMT
    Get
	    Return _AMORT_AMT
    End Get
    Set (byval value as single)
	    If _AMORT_AMT <> value Then
	        IsChanged = True
	        _AMORT_AMT= value
	    End If
    End Set
End property 

Protected _PAY_START as DateTime  = Nothing 
Public Overridable Property PAY_START() as DateTime  Implements _IAloans.PAY_START
    Get
	    Return _PAY_START
    End Get
    Set (byval value as DateTime)
	    If _PAY_START <> value Then
	        IsChanged = True
	        _PAY_START= value
	    End If
    End Set
End property 

Protected _RATE as single  = 0 
Public Overridable Property RATE() as single  Implements _IAloans.RATE
    Get
	    Return _RATE
    End Get
    Set (byval value as single)
	    If _RATE <> value Then
	        IsChanged = True
	        _RATE= value
	    End If
    End Set
End property 

Protected _TERM as single  = 0 
Public Overridable Property TERM() as single  Implements _IAloans.TERM
    Get
	    Return _TERM
    End Get
    Set (byval value as single)
	    If _TERM <> value Then
	        IsChanged = True
	        _TERM= value
	    End If
    End Set
End property 

Protected _FREQ as string  = "" 
Public Overridable Property FREQ() as string  Implements _IAloans.FREQ
    Get
	    Return _FREQ
    End Get
    Set (byval value as string)
	    If _FREQ <> value Then
	        IsChanged = True
	        _FREQ= value
	    End If
    End Set
End property 

Protected _PRINCIPAL as single  = 0 
Public Overridable Property PRINCIPAL() as single  Implements _IAloans.PRINCIPAL
    Get
	    Return _PRINCIPAL
    End Get
    Set (byval value as single)
	    If _PRINCIPAL <> value Then
	        IsChanged = True
	        _PRINCIPAL= value
	    End If
    End Set
End property 

Protected _LED_TYPE as single  = 0 
Public Overridable Property LED_TYPE() as single  Implements _IAloans.LED_TYPE
    Get
	    Return _LED_TYPE
    End Get
    Set (byval value as single)
	    If _LED_TYPE <> value Then
	        IsChanged = True
	        _LED_TYPE= value
	    End If
    End Set
End property 

Protected _ADV_INTE as single  = 0 
Public Overridable Property ADV_INTE() as single  Implements _IAloans.ADV_INTE
    Get
	    Return _ADV_INTE
    End Get
    Set (byval value as single)
	    If _ADV_INTE <> value Then
	        IsChanged = True
	        _ADV_INTE= value
	    End If
    End Set
End property 

Protected _AFT_INTE as single  = 0 
Public Overridable Property AFT_INTE() as single  Implements _IAloans.AFT_INTE
    Get
	    Return _AFT_INTE
    End Get
    Set (byval value as single)
	    If _AFT_INTE <> value Then
	        IsChanged = True
	        _AFT_INTE= value
	    End If
    End Set
End property 

Protected _ACCU_PAYP as single  = 0 
Public Overridable Property ACCU_PAYP() as single  Implements _IAloans.ACCU_PAYP
    Get
	    Return _ACCU_PAYP
    End Get
    Set (byval value as single)
	    If _ACCU_PAYP <> value Then
	        IsChanged = True
	        _ACCU_PAYP= value
	    End If
    End Set
End property 

Protected _YTD_I as single  = 0 
Public Overridable Property YTD_I() as single  Implements _IAloans.YTD_I
    Get
	    Return _YTD_I
    End Get
    Set (byval value as single)
	    If _YTD_I <> value Then
	        IsChanged = True
	        _YTD_I= value
	    End If
    End Set
End property 

Protected _LOAN_TYPE as string  = "" 
Public Overridable Property LOAN_TYPE() as string  Implements _IAloans.LOAN_TYPE
    Get
	    Return _LOAN_TYPE
    End Get
    Set (byval value as string)
	    If _LOAN_TYPE <> value Then
	        IsChanged = True
	        _LOAN_TYPE= value
	    End If
    End Set
End property 

Protected _LOAN_STAT as string  = "" 
Public Overridable Property LOAN_STAT() as string  Implements _IAloans.LOAN_STAT
    Get
	    Return _LOAN_STAT
    End Get
    Set (byval value as string)
	    If _LOAN_STAT <> value Then
	        IsChanged = True
	        _LOAN_STAT= value
	    End If
    End Set
End property 

Protected _ARREAR_I as single  = 0 
Public Overridable Property ARREAR_I() as single  Implements _IAloans.ARREAR_I
    Get
	    Return _ARREAR_I
    End Get
    Set (byval value as single)
	    If _ARREAR_I <> value Then
	        IsChanged = True
	        _ARREAR_I= value
	    End If
    End Set
End property 

Protected _ARREAR_P as single  = 0 
Public Overridable Property ARREAR_P() as single  Implements _IAloans.ARREAR_P
    Get
	    Return _ARREAR_P
    End Get
    Set (byval value as single)
	    If _ARREAR_P <> value Then
	        IsChanged = True
	        _ARREAR_P= value
	    End If
    End Set
End property 

Protected _ARREAR_OTH as single  = 0 
Public Overridable Property ARREAR_OTH() as single  Implements _IAloans.ARREAR_OTH
    Get
	    Return _ARREAR_OTH
    End Get
    Set (byval value as single)
	    If _ARREAR_OTH <> value Then
	        IsChanged = True
	        _ARREAR_OTH= value
	    End If
    End Set
End property 

Protected _ARREAR_AS as DateTime  = Nothing 
Public Overridable Property ARREAR_AS() as DateTime  Implements _IAloans.ARREAR_AS
    Get
	    Return _ARREAR_AS
    End Get
    Set (byval value as DateTime)
	    If _ARREAR_AS <> value Then
	        IsChanged = True
	        _ARREAR_AS= value
	    End If
    End Set
End property 

Protected _COLLATERAL as Boolean  = False 
Public Overridable Property COLLATERAL() as Boolean  Implements _IAloans.COLLATERAL
    Get
	    Return _COLLATERAL
    End Get
    Set (byval value as Boolean)
	    If _COLLATERAL <> value Then
	        IsChanged = True
	        _COLLATERAL= value
	    End If
    End Set
End property 

Protected _DED_BAL as string  = "" 
Public Overridable Property DED_BAL() as string  Implements _IAloans.DED_BAL
    Get
	    Return _DED_BAL
    End Get
    Set (byval value as string)
	    If _DED_BAL <> value Then
	        IsChanged = True
	        _DED_BAL= value
	    End If
    End Set
End property 

Protected _ADD_DATE as DateTime  = Nothing 
Public Overridable Property ADD_DATE() as DateTime  Implements _IAloans.ADD_DATE
    Get
	    Return _ADD_DATE
    End Get
    Set (byval value as DateTime)
	    If _ADD_DATE <> value Then
	        IsChanged = True
	        _ADD_DATE= value
	    End If
    End Set
End property 

Protected _CHG_DATE as DateTime  = Nothing 
Public Overridable Property CHG_DATE() as DateTime  Implements _IAloans.CHG_DATE
    Get
	    Return _CHG_DATE
    End Get
    Set (byval value as DateTime)
	    If _CHG_DATE <> value Then
	        IsChanged = True
	        _CHG_DATE= value
	    End If
    End Set
End property 

Protected _USER as string  = "" 
Public Overridable Property USER() as string  Implements _IAloans.USER
    Get
	    Return _USER
    End Get
    Set (byval value as string)
	    If _USER <> value Then
	        IsChanged = True
	        _USER= value
	    End If
    End Set
End property 

Protected _P_BAL as single  = 0 
Public Overridable Property P_BAL() as single  Implements _IAloans.P_BAL
    Get
	    Return _P_BAL
    End Get
    Set (byval value as single)
	    If _P_BAL <> value Then
	        IsChanged = True
	        _P_BAL= value
	    End If
    End Set
End property 

Protected _I_BAL as single  = 0 
Public Overridable Property I_BAL() as single  Implements _IAloans.I_BAL
    Get
	    Return _I_BAL
    End Get
    Set (byval value as single)
	    If _I_BAL <> value Then
	        IsChanged = True
	        _I_BAL= value
	    End If
    End Set
End property 

Protected _O_BAL as single  = 0 
Public Overridable Property O_BAL() as single  Implements _IAloans.O_BAL
    Get
	    Return _O_BAL
    End Get
    Set (byval value as single)
	    If _O_BAL <> value Then
	        IsChanged = True
	        _O_BAL= value
	    End If
    End Set
End property 

Protected _REC_STAT as Boolean  = False 
Public Overridable Property REC_STAT() as Boolean  Implements _IAloans.REC_STAT
    Get
	    Return _REC_STAT
    End Get
    Set (byval value as Boolean)
	    If _REC_STAT <> value Then
	        IsChanged = True
	        _REC_STAT= value
	    End If
    End Set
End property 

Protected _RENEW as Boolean  = False 
Public Overridable Property RENEW() as Boolean  Implements _IAloans.RENEW
    Get
	    Return _RENEW
    End Get
    Set (byval value as Boolean)
	    If _RENEW <> value Then
	        IsChanged = True
	        _RENEW= value
	    End If
    End Set
End property 

Protected _ADVANCE as single  = 0 
Public Overridable Property ADVANCE() as single  Implements _IAloans.ADVANCE
    Get
	    Return _ADVANCE
    End Get
    Set (byval value as single)
	    If _ADVANCE <> value Then
	        IsChanged = True
	        _ADVANCE= value
	    End If
    End Set
End property 

Protected _LRI_IND as Boolean  = False 
Public Overridable Property LRI_IND() as Boolean  Implements _IAloans.LRI_IND
    Get
	    Return _LRI_IND
    End Get
    Set (byval value as Boolean)
	    If _LRI_IND <> value Then
	        IsChanged = True
	        _LRI_IND= value
	    End If
    End Set
End property 

Protected _NDUE as DateTime  = Nothing 
Public Overridable Property NDUE() as DateTime  Implements _IAloans.NDUE
    Get
	    Return _NDUE
    End Get
    Set (byval value as DateTime)
	    If _NDUE <> value Then
	        IsChanged = True
	        _NDUE= value
	    End If
    End Set
End property 


#End Region

#Region "Method"
''' <summary>
'''This method read an Aloans from DB.
''' </summary>
''' <returns>
'''Return 0 if all ok, 1 if error
''' </returns>
Public Overridable Function Read(Id As Integer) As Integer
    'Return 0 if all ok
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Dim int As Aloans = Manager.Read(Id)
                    _ALOANS_ID = int.ALOANS_ID
                    _PN_NO = int.PN_NO
                    _KBCI_NO = int.KBCI_NO
                    _APP_DATE = int.APP_DATE
                    _APP_NO = int.APP_NO
                    _DATE_GRANT = int.DATE_GRANT
                    _BY_WHOM = int.BY_WHOM
                    _DATE_DUE = int.DATE_DUE
                    _CHKNO_BANK = int.CHKNO_BANK
                    _CHKNO = int.CHKNO
                    _CHKNO_AMT = int.CHKNO_AMT
                    _CHKNO_DATE = int.CHKNO_DATE
                    _CHKNO_RELS = int.CHKNO_RELS
                    _CHKNO_ACK = int.CHKNO_ACK
                    _MOD_PAY = int.MOD_PAY
                    _AMORT_AMT = int.AMORT_AMT
                    _PAY_START = int.PAY_START
                    _RATE = int.RATE
                    _TERM = int.TERM
                    _FREQ = int.FREQ
                    _PRINCIPAL = int.PRINCIPAL
                    _LED_TYPE = int.LED_TYPE
                    _ADV_INTE = int.ADV_INTE
                    _AFT_INTE = int.AFT_INTE
                    _ACCU_PAYP = int.ACCU_PAYP
                    _YTD_I = int.YTD_I
                    _LOAN_TYPE = int.LOAN_TYPE
                    _LOAN_STAT = int.LOAN_STAT
                    _ARREAR_I = int.ARREAR_I
                    _ARREAR_P = int.ARREAR_P
                    _ARREAR_OTH = int.ARREAR_OTH
                    _ARREAR_AS = int.ARREAR_AS
                    _COLLATERAL = int.COLLATERAL
                    _DED_BAL = int.DED_BAL
                    _ADD_DATE = int.ADD_DATE
                    _CHG_DATE = int.CHG_DATE
                    _USER = int.USER
                    _P_BAL = int.P_BAL
                    _I_BAL = int.I_BAL
                    _O_BAL = int.O_BAL
                    _REC_STAT = int.REC_STAT
                    _RENEW = int.RENEW
                    _ADVANCE = int.ADVANCE
                    _LRI_IND = int.LRI_IND
                    _NDUE = int.NDUE
        	    End Using
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
	    Ris = 1
    End Try
    Return Ris
End Function

''' <summary>
'''This method save an Aloans on DB.
''' </summary>
''' <returns>
'''Return Id insert in DB if all ok, 0 if error
''' </returns>
Public Overridable Function Save() As Integer
    'Return the id Inserted
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Ris = Manager.Save(Me)
	    End Using
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ris
End Function

Protected Function InternalIsValid() As Boolean
	Dim Ris As Boolean = True
	  if _PN_NO.Length > 7 then Ris = False
  if _KBCI_NO.Length > 7 then Ris = False
  if _BY_WHOM.Length > 15 then Ris = False
  if _CHKNO_BANK.Length > 8 then Ris = False
  if _CHKNO.Length > 6 then Ris = False
  if _CHKNO_RELS.Length > 6 then Ris = False
  if _MOD_PAY.Length > 3 then Ris = False
  if _FREQ.Length > 1 then Ris = False
  if _LOAN_TYPE.Length > 3 then Ris = False
  if _LOAN_STAT.Length > 1 then Ris = False
  if _DED_BAL.Length > 7 then Ris = False
  if _USER.Length > 8 then Ris = False

	Return Ris
End Function

#End Region

#Region "Embedded Class"


#End Region

End Class 

''' <summary>
'''Interface for table Aloans
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _IAloans

Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

    
    Property ALOANS_ID() as Int64

    
    Property PN_NO() as string

    
    Property KBCI_NO() as string

    
    Property APP_DATE() as DateTime

    
    Property APP_NO() as single

    
    Property DATE_GRANT() as DateTime

    
    Property BY_WHOM() as string

    
    Property DATE_DUE() as DateTime

    
    Property CHKNO_BANK() as string

    
    Property CHKNO() as string

    
    Property CHKNO_AMT() as single

    
    Property CHKNO_DATE() as DateTime

    
    Property CHKNO_RELS() as string

    
    Property CHKNO_ACK() as DateTime

    
    Property MOD_PAY() as string

    
    Property AMORT_AMT() as single

    
    Property PAY_START() as DateTime

    
    Property RATE() as single

    
    Property TERM() as single

    
    Property FREQ() as string

    
    Property PRINCIPAL() as single

    
    Property LED_TYPE() as single

    
    Property ADV_INTE() as single

    
    Property AFT_INTE() as single

    
    Property ACCU_PAYP() as single

    
    Property YTD_I() as single

    
    Property LOAN_TYPE() as string

    
    Property LOAN_STAT() as string

    
    Property ARREAR_I() as single

    
    Property ARREAR_P() as single

    
    Property ARREAR_OTH() as single

    
    Property ARREAR_AS() as DateTime

    
    Property COLLATERAL() as Boolean

    
    Property DED_BAL() as string

    
    Property ADD_DATE() as DateTime

    
    Property CHG_DATE() as DateTime

    
    Property USER() as string

    
    Property P_BAL() as single

    
    Property I_BAL() as single

    
    Property O_BAL() as single

    
    Property REC_STAT() as Boolean

    
    Property RENEW() as Boolean

    
    Property ADVANCE() as single

    
    Property LRI_IND() as Boolean

    
    Property NDUE() as DateTime

    
#End Region

End Interface