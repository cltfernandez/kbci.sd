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
'''DAO Class for table Members
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Members
	Inherits LUNA.LunaBaseClassEntity
    Implements _IMembers
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _IMembers.FillFromDataRecord
     KBCI_ID = myRecord("KBCI_ID")
    KBCI_NO = myRecord("KBCI_NO")
    		if not myRecord("LNAME") is DBNull.Value then LNAME = myRecord("LNAME")
    		if not myRecord("FNAME") is DBNull.Value then FNAME = myRecord("FNAME")
    		if not myRecord("MI") is DBNull.Value then MI = myRecord("MI")
    		if not myRecord("MEM_CODE") is DBNull.Value then MEM_CODE = myRecord("MEM_CODE")
    		if not myRecord("MEM_STAT") is DBNull.Value then MEM_STAT = myRecord("MEM_STAT")
    		if not myRecord("MEM_DATE") is DBNull.Value then MEM_DATE = myRecord("MEM_DATE")
    		if not myRecord("BY_WHOM") is DBNull.Value then BY_WHOM = myRecord("BY_WHOM")
    		if not myRecord("CB_EMPNO") is DBNull.Value then CB_EMPNO = myRecord("CB_EMPNO")
    		if not myRecord("CB_HIRE") is DBNull.Value then CB_HIRE = myRecord("CB_HIRE")
    		if not myRecord("DEPT") is DBNull.Value then DEPT = myRecord("DEPT")
    		if not myRecord("REGION") is DBNull.Value then REGION = myRecord("REGION")
    		if not myRecord("OFF_TEL") is DBNull.Value then OFF_TEL = myRecord("OFF_TEL")
    		if not myRecord("DORI") is DBNull.Value then DORI = myRecord("DORI")
    		if not myRecord("REA_DORI") is DBNull.Value then REA_DORI = myRecord("REA_DORI")
    		if not myRecord("SEX") is DBNull.Value then SEX = myRecord("SEX")
    		if not myRecord("B_DATE") is DBNull.Value then B_DATE = myRecord("B_DATE")
    		if not myRecord("CIV_STAT") is DBNull.Value then CIV_STAT = myRecord("CIV_STAT")
    		if not myRecord("MEM_ADDR") is DBNull.Value then MEM_ADDR = myRecord("MEM_ADDR")
    		if not myRecord("RES_TEL") is DBNull.Value then RES_TEL = myRecord("RES_TEL")
    		if not myRecord("POSITION") is DBNull.Value then POSITION = myRecord("POSITION")
    		if not myRecord("SAL_BAS") is DBNull.Value then SAL_BAS = myRecord("SAL_BAS")
    		if not myRecord("SAL_ALL") is DBNull.Value then SAL_ALL = myRecord("SAL_ALL")
    		if not myRecord("OTH_INC") is DBNull.Value then OTH_INC = myRecord("OTH_INC")
    		if not myRecord("FEBTC_SA") is DBNull.Value then FEBTC_SA = myRecord("FEBTC_SA")
    		if not myRecord("FEBTC_CA") is DBNull.Value then FEBTC_CA = myRecord("FEBTC_CA")
    		if not myRecord("FD_CERTNO") is DBNull.Value then FD_CERTNO = myRecord("FD_CERTNO")
    		if not myRecord("FD_DATE") is DBNull.Value then FD_DATE = myRecord("FD_DATE")
    		if not myRecord("AP_AMOUNT") is DBNull.Value then AP_AMOUNT = myRecord("AP_AMOUNT")
    		if not myRecord("AR_AMOUNT") is DBNull.Value then AR_AMOUNT = myRecord("AR_AMOUNT")
    		if not myRecord("FD_AMOUNT") is DBNull.Value then FD_AMOUNT = myRecord("FD_AMOUNT")
    		if not myRecord("SD_AMOUNT") is DBNull.Value then SD_AMOUNT = myRecord("SD_AMOUNT")
    		if not myRecord("TD_AMOUNT") is DBNull.Value then TD_AMOUNT = myRecord("TD_AMOUNT")
    		if not myRecord("OTH_AMOUNT") is DBNull.Value then OTH_AMOUNT = myRecord("OTH_AMOUNT")
    		if not myRecord("YTD_DIVAMT") is DBNull.Value then YTD_DIVAMT = myRecord("YTD_DIVAMT")
    		if not myRecord("YTD_LRI") is DBNull.Value then YTD_LRI = myRecord("YTD_LRI")
    		if not myRecord("REM_PROP") is DBNull.Value then REM_PROP = myRecord("REM_PROP")
    		if not myRecord("REM_VALUE") is DBNull.Value then REM_VALUE = myRecord("REM_VALUE")
    		if not myRecord("NO_DEPEND") is DBNull.Value then NO_DEPEND = myRecord("NO_DEPEND")
    		if not myRecord("SP_NAME") is DBNull.Value then SP_NAME = myRecord("SP_NAME")
    		if not myRecord("SP_EMPLOY") is DBNull.Value then SP_EMPLOY = myRecord("SP_EMPLOY")
    		if not myRecord("SP_OFFTEL") is DBNull.Value then SP_OFFTEL = myRecord("SP_OFFTEL")
    		if not myRecord("SP_CBEMPNO") is DBNull.Value then SP_CBEMPNO = myRecord("SP_CBEMPNO")
    		if not myRecord("SP_KBCINO") is DBNull.Value then SP_KBCINO = myRecord("SP_KBCINO")
    		if not myRecord("SP_SALARY") is DBNull.Value then SP_SALARY = myRecord("SP_SALARY")
    		if not myRecord("APRUN_AMT") is DBNull.Value then APRUN_AMT = myRecord("APRUN_AMT")
    		if not myRecord("ARRUN_AMT") is DBNull.Value then ARRUN_AMT = myRecord("ARRUN_AMT")
    		if not myRecord("RUN_AMT") is DBNull.Value then RUN_AMT = myRecord("RUN_AMT")
    		if not myRecord("ADD_DATE") is DBNull.Value then ADD_DATE = myRecord("ADD_DATE")
    		if not myRecord("CHG_DATE") is DBNull.Value then CHG_DATE = myRecord("CHG_DATE")
    		if not myRecord("USER") is DBNull.Value then USER = myRecord("USER")
    		if not myRecord("REC_STAT") is DBNull.Value then REC_STAT = myRecord("REC_STAT")
    		if not myRecord("FD_CNTR") is DBNull.Value then FD_CNTR = myRecord("FD_CNTR")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Members)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(MembersDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Members))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _KBCI_ID as Int64  = Nothing 
Public Overridable Property KBCI_ID() as Int64  Implements _IMembers.KBCI_ID
    Get
	    Return _KBCI_ID
    End Get
    Set (byval value as Int64)
	    If _KBCI_ID <> value Then
	        IsChanged = True
	        _KBCI_ID= value
	    End If
    End Set
End property 

Protected _KBCI_NO as string  = "" 
Public Overridable Property KBCI_NO() as string  Implements _IMembers.KBCI_NO
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

Protected _LNAME as string  = "" 
Public Overridable Property LNAME() as string  Implements _IMembers.LNAME
    Get
	    Return _LNAME
    End Get
    Set (byval value as string)
	    If _LNAME <> value Then
	        IsChanged = True
	        _LNAME= value
	    End If
    End Set
End property 

Protected _FNAME as string  = "" 
Public Overridable Property FNAME() as string  Implements _IMembers.FNAME
    Get
	    Return _FNAME
    End Get
    Set (byval value as string)
	    If _FNAME <> value Then
	        IsChanged = True
	        _FNAME= value
	    End If
    End Set
End property 

Protected _MI as string  = "" 
Public Overridable Property MI() as string  Implements _IMembers.MI
    Get
	    Return _MI
    End Get
    Set (byval value as string)
	    If _MI <> value Then
	        IsChanged = True
	        _MI= value
	    End If
    End Set
End property 

Protected _MEM_CODE as string  = "" 
Public Overridable Property MEM_CODE() as string  Implements _IMembers.MEM_CODE
    Get
	    Return _MEM_CODE
    End Get
    Set (byval value as string)
	    If _MEM_CODE <> value Then
	        IsChanged = True
	        _MEM_CODE= value
	    End If
    End Set
End property 

Protected _MEM_STAT as string  = "" 
Public Overridable Property MEM_STAT() as string  Implements _IMembers.MEM_STAT
    Get
	    Return _MEM_STAT
    End Get
    Set (byval value as string)
	    If _MEM_STAT <> value Then
	        IsChanged = True
	        _MEM_STAT= value
	    End If
    End Set
End property 

Protected _MEM_DATE as DateTime  = Nothing 
Public Overridable Property MEM_DATE() as DateTime  Implements _IMembers.MEM_DATE
    Get
	    Return _MEM_DATE
    End Get
    Set (byval value as DateTime)
	    If _MEM_DATE <> value Then
	        IsChanged = True
	        _MEM_DATE= value
	    End If
    End Set
End property 

Protected _BY_WHOM as string  = "" 
Public Overridable Property BY_WHOM() as string  Implements _IMembers.BY_WHOM
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

Protected _CB_EMPNO as string  = "" 
Public Overridable Property CB_EMPNO() as string  Implements _IMembers.CB_EMPNO
    Get
	    Return _CB_EMPNO
    End Get
    Set (byval value as string)
	    If _CB_EMPNO <> value Then
	        IsChanged = True
	        _CB_EMPNO= value
	    End If
    End Set
End property 

Protected _CB_HIRE as DateTime  = Nothing 
Public Overridable Property CB_HIRE() as DateTime  Implements _IMembers.CB_HIRE
    Get
	    Return _CB_HIRE
    End Get
    Set (byval value as DateTime)
	    If _CB_HIRE <> value Then
	        IsChanged = True
	        _CB_HIRE= value
	    End If
    End Set
End property 

Protected _DEPT as string  = "" 
Public Overridable Property DEPT() as string  Implements _IMembers.DEPT
    Get
	    Return _DEPT
    End Get
    Set (byval value as string)
	    If _DEPT <> value Then
	        IsChanged = True
	        _DEPT= value
	    End If
    End Set
End property 

Protected _REGION as string  = "" 
Public Overridable Property REGION() as string  Implements _IMembers.REGION
    Get
	    Return _REGION
    End Get
    Set (byval value as string)
	    If _REGION <> value Then
	        IsChanged = True
	        _REGION= value
	    End If
    End Set
End property 

Protected _OFF_TEL as string  = "" 
Public Overridable Property OFF_TEL() as string  Implements _IMembers.OFF_TEL
    Get
	    Return _OFF_TEL
    End Get
    Set (byval value as string)
	    If _OFF_TEL <> value Then
	        IsChanged = True
	        _OFF_TEL= value
	    End If
    End Set
End property 

Protected _DORI as Boolean  = False 
Public Overridable Property DORI() as Boolean  Implements _IMembers.DORI
    Get
	    Return _DORI
    End Get
    Set (byval value as Boolean)
	    If _DORI <> value Then
	        IsChanged = True
	        _DORI= value
	    End If
    End Set
End property 

Protected _REA_DORI as string  = "" 
Public Overridable Property REA_DORI() as string  Implements _IMembers.REA_DORI
    Get
	    Return _REA_DORI
    End Get
    Set (byval value as string)
	    If _REA_DORI <> value Then
	        IsChanged = True
	        _REA_DORI= value
	    End If
    End Set
End property 

Protected _SEX as string  = "" 
Public Overridable Property SEX() as string  Implements _IMembers.SEX
    Get
	    Return _SEX
    End Get
    Set (byval value as string)
	    If _SEX <> value Then
	        IsChanged = True
	        _SEX= value
	    End If
    End Set
End property 

Protected _B_DATE as DateTime  = Nothing 
Public Overridable Property B_DATE() as DateTime  Implements _IMembers.B_DATE
    Get
	    Return _B_DATE
    End Get
    Set (byval value as DateTime)
	    If _B_DATE <> value Then
	        IsChanged = True
	        _B_DATE= value
	    End If
    End Set
End property 

Protected _CIV_STAT as string  = "" 
Public Overridable Property CIV_STAT() as string  Implements _IMembers.CIV_STAT
    Get
	    Return _CIV_STAT
    End Get
    Set (byval value as string)
	    If _CIV_STAT <> value Then
	        IsChanged = True
	        _CIV_STAT= value
	    End If
    End Set
End property 

Protected _MEM_ADDR as string  = "" 
Public Overridable Property MEM_ADDR() as string  Implements _IMembers.MEM_ADDR
    Get
	    Return _MEM_ADDR
    End Get
    Set (byval value as string)
	    If _MEM_ADDR <> value Then
	        IsChanged = True
	        _MEM_ADDR= value
	    End If
    End Set
End property 

Protected _RES_TEL as string  = "" 
Public Overridable Property RES_TEL() as string  Implements _IMembers.RES_TEL
    Get
	    Return _RES_TEL
    End Get
    Set (byval value as string)
	    If _RES_TEL <> value Then
	        IsChanged = True
	        _RES_TEL= value
	    End If
    End Set
End property 

Protected _POSITION as string  = "" 
Public Overridable Property POSITION() as string  Implements _IMembers.POSITION
    Get
	    Return _POSITION
    End Get
    Set (byval value as string)
	    If _POSITION <> value Then
	        IsChanged = True
	        _POSITION= value
	    End If
    End Set
End property 

Protected _SAL_BAS as single  = 0 
Public Overridable Property SAL_BAS() as single  Implements _IMembers.SAL_BAS
    Get
	    Return _SAL_BAS
    End Get
    Set (byval value as single)
	    If _SAL_BAS <> value Then
	        IsChanged = True
	        _SAL_BAS= value
	    End If
    End Set
End property 

Protected _SAL_ALL as single  = 0 
Public Overridable Property SAL_ALL() as single  Implements _IMembers.SAL_ALL
    Get
	    Return _SAL_ALL
    End Get
    Set (byval value as single)
	    If _SAL_ALL <> value Then
	        IsChanged = True
	        _SAL_ALL= value
	    End If
    End Set
End property 

Protected _OTH_INC as single  = 0 
Public Overridable Property OTH_INC() as single  Implements _IMembers.OTH_INC
    Get
	    Return _OTH_INC
    End Get
    Set (byval value as single)
	    If _OTH_INC <> value Then
	        IsChanged = True
	        _OTH_INC= value
	    End If
    End Set
End property 

Protected _FEBTC_SA as string  = "" 
Public Overridable Property FEBTC_SA() as string  Implements _IMembers.FEBTC_SA
    Get
	    Return _FEBTC_SA
    End Get
    Set (byval value as string)
	    If _FEBTC_SA <> value Then
	        IsChanged = True
	        _FEBTC_SA= value
	    End If
    End Set
End property 

Protected _FEBTC_CA as string  = "" 
Public Overridable Property FEBTC_CA() as string  Implements _IMembers.FEBTC_CA
    Get
	    Return _FEBTC_CA
    End Get
    Set (byval value as string)
	    If _FEBTC_CA <> value Then
	        IsChanged = True
	        _FEBTC_CA= value
	    End If
    End Set
End property 

Protected _FD_CERTNO as string  = "" 
Public Overridable Property FD_CERTNO() as string  Implements _IMembers.FD_CERTNO
    Get
	    Return _FD_CERTNO
    End Get
    Set (byval value as string)
	    If _FD_CERTNO <> value Then
	        IsChanged = True
	        _FD_CERTNO= value
	    End If
    End Set
End property 

Protected _FD_DATE as DateTime  = Nothing 
Public Overridable Property FD_DATE() as DateTime  Implements _IMembers.FD_DATE
    Get
	    Return _FD_DATE
    End Get
    Set (byval value as DateTime)
	    If _FD_DATE <> value Then
	        IsChanged = True
	        _FD_DATE= value
	    End If
    End Set
End property 

Protected _AP_AMOUNT as single  = 0 
Public Overridable Property AP_AMOUNT() as single  Implements _IMembers.AP_AMOUNT
    Get
	    Return _AP_AMOUNT
    End Get
    Set (byval value as single)
	    If _AP_AMOUNT <> value Then
	        IsChanged = True
	        _AP_AMOUNT= value
	    End If
    End Set
End property 

Protected _AR_AMOUNT as single  = 0 
Public Overridable Property AR_AMOUNT() as single  Implements _IMembers.AR_AMOUNT
    Get
	    Return _AR_AMOUNT
    End Get
    Set (byval value as single)
	    If _AR_AMOUNT <> value Then
	        IsChanged = True
	        _AR_AMOUNT= value
	    End If
    End Set
End property 

Protected _FD_AMOUNT as single  = 0 
Public Overridable Property FD_AMOUNT() as single  Implements _IMembers.FD_AMOUNT
    Get
	    Return _FD_AMOUNT
    End Get
    Set (byval value as single)
	    If _FD_AMOUNT <> value Then
	        IsChanged = True
	        _FD_AMOUNT= value
	    End If
    End Set
End property 

Protected _SD_AMOUNT as single  = 0 
Public Overridable Property SD_AMOUNT() as single  Implements _IMembers.SD_AMOUNT
    Get
	    Return _SD_AMOUNT
    End Get
    Set (byval value as single)
	    If _SD_AMOUNT <> value Then
	        IsChanged = True
	        _SD_AMOUNT= value
	    End If
    End Set
End property 

Protected _TD_AMOUNT as single  = 0 
Public Overridable Property TD_AMOUNT() as single  Implements _IMembers.TD_AMOUNT
    Get
	    Return _TD_AMOUNT
    End Get
    Set (byval value as single)
	    If _TD_AMOUNT <> value Then
	        IsChanged = True
	        _TD_AMOUNT= value
	    End If
    End Set
End property 

Protected _OTH_AMOUNT as single  = 0 
Public Overridable Property OTH_AMOUNT() as single  Implements _IMembers.OTH_AMOUNT
    Get
	    Return _OTH_AMOUNT
    End Get
    Set (byval value as single)
	    If _OTH_AMOUNT <> value Then
	        IsChanged = True
	        _OTH_AMOUNT= value
	    End If
    End Set
End property 

Protected _YTD_DIVAMT as single  = 0 
Public Overridable Property YTD_DIVAMT() as single  Implements _IMembers.YTD_DIVAMT
    Get
	    Return _YTD_DIVAMT
    End Get
    Set (byval value as single)
	    If _YTD_DIVAMT <> value Then
	        IsChanged = True
	        _YTD_DIVAMT= value
	    End If
    End Set
End property 

Protected _YTD_LRI as single  = 0 
Public Overridable Property YTD_LRI() as single  Implements _IMembers.YTD_LRI
    Get
	    Return _YTD_LRI
    End Get
    Set (byval value as single)
	    If _YTD_LRI <> value Then
	        IsChanged = True
	        _YTD_LRI= value
	    End If
    End Set
End property 

Protected _REM_PROP as string  = "" 
Public Overridable Property REM_PROP() as string  Implements _IMembers.REM_PROP
    Get
	    Return _REM_PROP
    End Get
    Set (byval value as string)
	    If _REM_PROP <> value Then
	        IsChanged = True
	        _REM_PROP= value
	    End If
    End Set
End property 

Protected _REM_VALUE as single  = 0 
Public Overridable Property REM_VALUE() as single  Implements _IMembers.REM_VALUE
    Get
	    Return _REM_VALUE
    End Get
    Set (byval value as single)
	    If _REM_VALUE <> value Then
	        IsChanged = True
	        _REM_VALUE= value
	    End If
    End Set
End property 

Protected _NO_DEPEND as single  = 0 
Public Overridable Property NO_DEPEND() as single  Implements _IMembers.NO_DEPEND
    Get
	    Return _NO_DEPEND
    End Get
    Set (byval value as single)
	    If _NO_DEPEND <> value Then
	        IsChanged = True
	        _NO_DEPEND= value
	    End If
    End Set
End property 

Protected _SP_NAME as string  = "" 
Public Overridable Property SP_NAME() as string  Implements _IMembers.SP_NAME
    Get
	    Return _SP_NAME
    End Get
    Set (byval value as string)
	    If _SP_NAME <> value Then
	        IsChanged = True
	        _SP_NAME= value
	    End If
    End Set
End property 

Protected _SP_EMPLOY as string  = "" 
Public Overridable Property SP_EMPLOY() as string  Implements _IMembers.SP_EMPLOY
    Get
	    Return _SP_EMPLOY
    End Get
    Set (byval value as string)
	    If _SP_EMPLOY <> value Then
	        IsChanged = True
	        _SP_EMPLOY= value
	    End If
    End Set
End property 

Protected _SP_OFFTEL as string  = "" 
Public Overridable Property SP_OFFTEL() as string  Implements _IMembers.SP_OFFTEL
    Get
	    Return _SP_OFFTEL
    End Get
    Set (byval value as string)
	    If _SP_OFFTEL <> value Then
	        IsChanged = True
	        _SP_OFFTEL= value
	    End If
    End Set
End property 

Protected _SP_CBEMPNO as string  = "" 
Public Overridable Property SP_CBEMPNO() as string  Implements _IMembers.SP_CBEMPNO
    Get
	    Return _SP_CBEMPNO
    End Get
    Set (byval value as string)
	    If _SP_CBEMPNO <> value Then
	        IsChanged = True
	        _SP_CBEMPNO= value
	    End If
    End Set
End property 

Protected _SP_KBCINO as string  = "" 
Public Overridable Property SP_KBCINO() as string  Implements _IMembers.SP_KBCINO
    Get
	    Return _SP_KBCINO
    End Get
    Set (byval value as string)
	    If _SP_KBCINO <> value Then
	        IsChanged = True
	        _SP_KBCINO= value
	    End If
    End Set
End property 

Protected _SP_SALARY as single  = 0 
Public Overridable Property SP_SALARY() as single  Implements _IMembers.SP_SALARY
    Get
	    Return _SP_SALARY
    End Get
    Set (byval value as single)
	    If _SP_SALARY <> value Then
	        IsChanged = True
	        _SP_SALARY= value
	    End If
    End Set
End property 

Protected _APRUN_AMT as single  = 0 
Public Overridable Property APRUN_AMT() as single  Implements _IMembers.APRUN_AMT
    Get
	    Return _APRUN_AMT
    End Get
    Set (byval value as single)
	    If _APRUN_AMT <> value Then
	        IsChanged = True
	        _APRUN_AMT= value
	    End If
    End Set
End property 

Protected _ARRUN_AMT as single  = 0 
Public Overridable Property ARRUN_AMT() as single  Implements _IMembers.ARRUN_AMT
    Get
	    Return _ARRUN_AMT
    End Get
    Set (byval value as single)
	    If _ARRUN_AMT <> value Then
	        IsChanged = True
	        _ARRUN_AMT= value
	    End If
    End Set
End property 

Protected _RUN_AMT as single  = 0 
Public Overridable Property RUN_AMT() as single  Implements _IMembers.RUN_AMT
    Get
	    Return _RUN_AMT
    End Get
    Set (byval value as single)
	    If _RUN_AMT <> value Then
	        IsChanged = True
	        _RUN_AMT= value
	    End If
    End Set
End property 

Protected _ADD_DATE as DateTime  = Nothing 
Public Overridable Property ADD_DATE() as DateTime  Implements _IMembers.ADD_DATE
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
Public Overridable Property CHG_DATE() as DateTime  Implements _IMembers.CHG_DATE
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
Public Overridable Property USER() as string  Implements _IMembers.USER
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

Protected _REC_STAT as Boolean  = False 
Public Overridable Property REC_STAT() as Boolean  Implements _IMembers.REC_STAT
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

Protected _FD_CNTR as single  = 0 
Public Overridable Property FD_CNTR() as single  Implements _IMembers.FD_CNTR
    Get
	    Return _FD_CNTR
    End Get
    Set (byval value as single)
	    If _FD_CNTR <> value Then
	        IsChanged = True
	        _FD_CNTR= value
	    End If
    End Set
End property 


#End Region

#Region "Method"
''' <summary>
'''This method read an Members from DB.
''' </summary>
''' <returns>
'''Return 0 if all ok, 1 if error
''' </returns>
Public Overridable Function Read(Id As Integer) As Integer
    'Return 0 if all ok
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Dim int As Members = Manager.Read(Id)
                    _KBCI_ID = int.KBCI_ID
                    _KBCI_NO = int.KBCI_NO
                    _LNAME = int.LNAME
                    _FNAME = int.FNAME
                    _MI = int.MI
                    _MEM_CODE = int.MEM_CODE
                    _MEM_STAT = int.MEM_STAT
                    _MEM_DATE = int.MEM_DATE
                    _BY_WHOM = int.BY_WHOM
                    _CB_EMPNO = int.CB_EMPNO
                    _CB_HIRE = int.CB_HIRE
                    _DEPT = int.DEPT
                    _REGION = int.REGION
                    _OFF_TEL = int.OFF_TEL
                    _DORI = int.DORI
                    _REA_DORI = int.REA_DORI
                    _SEX = int.SEX
                    _B_DATE = int.B_DATE
                    _CIV_STAT = int.CIV_STAT
                    _MEM_ADDR = int.MEM_ADDR
                    _RES_TEL = int.RES_TEL
                    _POSITION = int.POSITION
                    _SAL_BAS = int.SAL_BAS
                    _SAL_ALL = int.SAL_ALL
                    _OTH_INC = int.OTH_INC
                    _FEBTC_SA = int.FEBTC_SA
                    _FEBTC_CA = int.FEBTC_CA
                    _FD_CERTNO = int.FD_CERTNO
                    _FD_DATE = int.FD_DATE
                    _AP_AMOUNT = int.AP_AMOUNT
                    _AR_AMOUNT = int.AR_AMOUNT
                    _FD_AMOUNT = int.FD_AMOUNT
                    _SD_AMOUNT = int.SD_AMOUNT
                    _TD_AMOUNT = int.TD_AMOUNT
                    _OTH_AMOUNT = int.OTH_AMOUNT
                    _YTD_DIVAMT = int.YTD_DIVAMT
                    _YTD_LRI = int.YTD_LRI
                    _REM_PROP = int.REM_PROP
                    _REM_VALUE = int.REM_VALUE
                    _NO_DEPEND = int.NO_DEPEND
                    _SP_NAME = int.SP_NAME
                    _SP_EMPLOY = int.SP_EMPLOY
                    _SP_OFFTEL = int.SP_OFFTEL
                    _SP_CBEMPNO = int.SP_CBEMPNO
                    _SP_KBCINO = int.SP_KBCINO
                    _SP_SALARY = int.SP_SALARY
                    _APRUN_AMT = int.APRUN_AMT
                    _ARRUN_AMT = int.ARRUN_AMT
                    _RUN_AMT = int.RUN_AMT
                    _ADD_DATE = int.ADD_DATE
                    _CHG_DATE = int.CHG_DATE
                    _USER = int.USER
                    _REC_STAT = int.REC_STAT
                    _FD_CNTR = int.FD_CNTR
        	    End Using
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
	    Ris = 1
    End Try
    Return Ris
End Function

''' <summary>
'''This method save an Members on DB.
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
	  if _KBCI_NO.Length = 0 then Ris = False
  if _KBCI_NO.Length > 7 then Ris = False
  if _LNAME.Length > 20 then Ris = False
  if _FNAME.Length > 20 then Ris = False
  if _MI.Length > 1 then Ris = False
  if _MEM_CODE.Length > 1 then Ris = False
  if _MEM_STAT.Length > 1 then Ris = False
  if _BY_WHOM.Length > 15 then Ris = False
  if _CB_EMPNO.Length > 6 then Ris = False
  if _DEPT.Length > 15 then Ris = False
  if _REGION.Length > 15 then Ris = False
  if _OFF_TEL.Length > 11 then Ris = False
  if _REA_DORI.Length > 15 then Ris = False
  if _SEX.Length > 1 then Ris = False
  if _CIV_STAT.Length > 1 then Ris = False
  if _MEM_ADDR.Length > 100 then Ris = False
  if _RES_TEL.Length > 7 then Ris = False
  if _POSITION.Length > 15 then Ris = False
  if _FEBTC_SA.Length > 10 then Ris = False
  if _FEBTC_CA.Length > 10 then Ris = False
  if _FD_CERTNO.Length > 6 then Ris = False
  if _REM_PROP.Length > 500 then Ris = False
  if _SP_NAME.Length > 30 then Ris = False
  if _SP_EMPLOY.Length > 40 then Ris = False
  if _SP_OFFTEL.Length > 11 then Ris = False
  if _SP_CBEMPNO.Length > 6 then Ris = False
  if _SP_KBCINO.Length > 7 then Ris = False
  if _USER.Length > 8 then Ris = False

	Return Ris
End Function

#End Region

#Region "Embedded Class"


#End Region

End Class 

''' <summary>
'''Interface for table Members
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _IMembers

Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

    
    Property KBCI_ID() as Int64

    
    Property KBCI_NO() as string

    
    Property LNAME() as string

    
    Property FNAME() as string

    
    Property MI() as string

    
    Property MEM_CODE() as string

    
    Property MEM_STAT() as string

    
    Property MEM_DATE() as DateTime

    
    Property BY_WHOM() as string

    
    Property CB_EMPNO() as string

    
    Property CB_HIRE() as DateTime

    
    Property DEPT() as string

    
    Property REGION() as string

    
    Property OFF_TEL() as string

    
    Property DORI() as Boolean

    
    Property REA_DORI() as string

    
    Property SEX() as string

    
    Property B_DATE() as DateTime

    
    Property CIV_STAT() as string

    
    Property MEM_ADDR() as string

    
    Property RES_TEL() as string

    
    Property POSITION() as string

    
    Property SAL_BAS() as single

    
    Property SAL_ALL() as single

    
    Property OTH_INC() as single

    
    Property FEBTC_SA() as string

    
    Property FEBTC_CA() as string

    
    Property FD_CERTNO() as string

    
    Property FD_DATE() as DateTime

    
    Property AP_AMOUNT() as single

    
    Property AR_AMOUNT() as single

    
    Property FD_AMOUNT() as single

    
    Property SD_AMOUNT() as single

    
    Property TD_AMOUNT() as single

    
    Property OTH_AMOUNT() as single

    
    Property YTD_DIVAMT() as single

    
    Property YTD_LRI() as single

    
    Property REM_PROP() as string

    
    Property REM_VALUE() as single

    
    Property NO_DEPEND() as single

    
    Property SP_NAME() as string

    
    Property SP_EMPLOY() as string

    
    Property SP_OFFTEL() as string

    
    Property SP_CBEMPNO() as string

    
    Property SP_KBCINO() as string

    
    Property SP_SALARY() as single

    
    Property APRUN_AMT() as single

    
    Property ARRUN_AMT() as single

    
    Property RUN_AMT() as single

    
    Property ADD_DATE() as DateTime

    
    Property CHG_DATE() as DateTime

    
    Property USER() as string

    
    Property REC_STAT() as Boolean

    
    Property FD_CNTR() as single

    
#End Region

End Interface