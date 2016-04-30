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
'''DAO Class for table Spteller
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Spteller
	Inherits LUNA.LunaBaseClassEntity
    Implements _ISpteller
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _ISpteller.FillFromDataRecord
     SPTELLER_ID = myRecord("SPTELLER_ID")
    		if not myRecord("TNAME") is DBNull.Value then TNAME = myRecord("TNAME")
    		if not myRecord("TDATE") is DBNull.Value then TDATE = myRecord("TDATE")
    		if not myRecord("CASHB") is DBNull.Value then CASHB = myRecord("CASHB")
    		if not myRecord("COCIB") is DBNull.Value then COCIB = myRecord("COCIB")
    		if not myRecord("ADDLREQ") is DBNull.Value then ADDLREQ = myRecord("ADDLREQ")
    		if not myRecord("ADDMREQ") is DBNull.Value then ADDMREQ = myRecord("ADDMREQ")
    		if not myRecord("CASHSAV") is DBNull.Value then CASHSAV = myRecord("CASHSAV")
    		if not myRecord("CASHOR") is DBNull.Value then CASHOR = myRecord("CASHOR")
    		if not myRecord("ADDLTD") is DBNull.Value then ADDLTD = myRecord("ADDLTD")
    		if not myRecord("CTFNAME1") is DBNull.Value then CTFNAME1 = myRecord("CTFNAME1")
    		if not myRecord("CTFAMT1") is DBNull.Value then CTFAMT1 = myRecord("CTFAMT1")
    		if not myRecord("CTFNAME2") is DBNull.Value then CTFNAME2 = myRecord("CTFNAME2")
    		if not myRecord("CTFAMT2") is DBNull.Value then CTFAMT2 = myRecord("CTFAMT2")
    		if not myRecord("CTFNAME3") is DBNull.Value then CTFNAME3 = myRecord("CTFNAME3")
    		if not myRecord("CTFAMT3") is DBNull.Value then CTFAMT3 = myRecord("CTFAMT3")
    		if not myRecord("ADDCASH") is DBNull.Value then ADDCASH = myRecord("ADDCASH")
    		if not myRecord("CRSAV") is DBNull.Value then CRSAV = myRecord("CRSAV")
    		if not myRecord("CRORO") is DBNull.Value then CRORO = myRecord("CRORO")
    		if not myRecord("CRACC") is DBNull.Value then CRACC = myRecord("CRACC")
    		if not myRecord("CRCR") is DBNull.Value then CRCR = myRecord("CRCR")
    		if not myRecord("ADDCHECKS") is DBNull.Value then ADDCHECKS = myRecord("ADDCHECKS")
    		if not myRecord("ADDTOTAL") is DBNull.Value then ADDTOTAL = myRecord("ADDTOTAL")
    		if not myRecord("DIB") is DBNull.Value then DIB = myRecord("DIB")
    		if not myRecord("REF") is DBNull.Value then REF = myRecord("REF")
    		if not myRecord("WITH") is DBNull.Value then SDWITH = myRecord("WITH")
    		if not myRecord("CHKENC") is DBNull.Value then CHKENC = myRecord("CHKENC")
    		if not myRecord("COCI") is DBNull.Value then COCI = myRecord("COCI")
    		if not myRecord("CHKDEP") is DBNull.Value then CHKDEP = myRecord("CHKDEP")
    		if not myRecord("EMER") is DBNull.Value then EMER = myRecord("EMER")
    		if not myRecord("CTTNAME1") is DBNull.Value then CTTNAME1 = myRecord("CTTNAME1")
    		if not myRecord("CTTAMT1") is DBNull.Value then CTTAMT1 = myRecord("CTTAMT1")
    		if not myRecord("CTTNAME2") is DBNull.Value then CTTNAME2 = myRecord("CTTNAME2")
    		if not myRecord("CTTAMT2") is DBNull.Value then CTTAMT2 = myRecord("CTTAMT2")
    		if not myRecord("CTTNAME3") is DBNull.Value then CTTNAME3 = myRecord("CTTNAME3")
    		if not myRecord("CTTAMT3") is DBNull.Value then CTTAMT3 = myRecord("CTTAMT3")
    		if not myRecord("TOTDISB") is DBNull.Value then TOTDISB = myRecord("TOTDISB")
    		if not myRecord("CBALEND") is DBNull.Value then CBALEND = myRecord("CBALEND")
    		if not myRecord("CTTCEND") is DBNull.Value then CTTCEND = myRecord("CTTCEND")
    		if not myRecord("OVER") is DBNull.Value then OVER = myRecord("OVER")
    		if not myRecord("B_1000") is DBNull.Value then B_1000 = myRecord("B_1000")
    		if not myRecord("B_500") is DBNull.Value then B_500 = myRecord("B_500")
    		if not myRecord("B_200") is DBNull.Value then B_200 = myRecord("B_200")
    		if not myRecord("B_100") is DBNull.Value then B_100 = myRecord("B_100")
    		if not myRecord("B_50") is DBNull.Value then B_50 = myRecord("B_50")
    		if not myRecord("B_20") is DBNull.Value then B_20 = myRecord("B_20")
    		if not myRecord("B_10") is DBNull.Value then B_10 = myRecord("B_10")
    		if not myRecord("B_5") is DBNull.Value then B_5 = myRecord("B_5")
    		if not myRecord("B_1") is DBNull.Value then B_1 = myRecord("B_1")
    		if not myRecord("B_P50") is DBNull.Value then B_P50 = myRecord("B_P50")
    		if not myRecord("B_P25") is DBNull.Value then B_P25 = myRecord("B_P25")
    		if not myRecord("B_P10") is DBNull.Value then B_P10 = myRecord("B_P10")
    		if not myRecord("B_P05") is DBNull.Value then B_P05 = myRecord("B_P05")
    		if not myRecord("B_P01") is DBNull.Value then B_P01 = myRecord("B_P01")
    		if not myRecord("TCCOUNT") is DBNull.Value then TCCOUNT = myRecord("TCCOUNT")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Spteller)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(SptellerDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Spteller))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _SPTELLER_ID as Int64  = Nothing 
Public Overridable Property SPTELLER_ID() as Int64  Implements _ISpteller.SPTELLER_ID
    Get
	    Return _SPTELLER_ID
    End Get
    Set (byval value as Int64)
	    If _SPTELLER_ID <> value Then
	        IsChanged = True
	        _SPTELLER_ID= value
	    End If
    End Set
End property 

Protected _TNAME as string  = "" 
Public Overridable Property TNAME() as string  Implements _ISpteller.TNAME
    Get
	    Return _TNAME
    End Get
    Set (byval value as string)
	    If _TNAME <> value Then
	        IsChanged = True
	        _TNAME= value
	    End If
    End Set
End property 

Protected _TDATE as DateTime  = Nothing 
Public Overridable Property TDATE() as DateTime  Implements _ISpteller.TDATE
    Get
	    Return _TDATE
    End Get
    Set (byval value as DateTime)
	    If _TDATE <> value Then
	        IsChanged = True
	        _TDATE= value
	    End If
    End Set
End property 

Protected _CASHB as single  = 0 
Public Overridable Property CASHB() as single  Implements _ISpteller.CASHB
    Get
	    Return _CASHB
    End Get
    Set (byval value as single)
	    If _CASHB <> value Then
	        IsChanged = True
	        _CASHB= value
	    End If
    End Set
End property 

Protected _COCIB as single  = 0 
Public Overridable Property COCIB() as single  Implements _ISpteller.COCIB
    Get
	    Return _COCIB
    End Get
    Set (byval value as single)
	    If _COCIB <> value Then
	        IsChanged = True
	        _COCIB= value
	    End If
    End Set
End property 

Protected _ADDLREQ as single  = 0 
Public Overridable Property ADDLREQ() as single  Implements _ISpteller.ADDLREQ
    Get
	    Return _ADDLREQ
    End Get
    Set (byval value as single)
	    If _ADDLREQ <> value Then
	        IsChanged = True
	        _ADDLREQ= value
	    End If
    End Set
End property 

Protected _ADDMREQ as single  = 0 
Public Overridable Property ADDMREQ() as single  Implements _ISpteller.ADDMREQ
    Get
	    Return _ADDMREQ
    End Get
    Set (byval value as single)
	    If _ADDMREQ <> value Then
	        IsChanged = True
	        _ADDMREQ= value
	    End If
    End Set
End property 

Protected _CASHSAV as single  = 0 
Public Overridable Property CASHSAV() as single  Implements _ISpteller.CASHSAV
    Get
	    Return _CASHSAV
    End Get
    Set (byval value as single)
	    If _CASHSAV <> value Then
	        IsChanged = True
	        _CASHSAV= value
	    End If
    End Set
End property 

Protected _CASHOR as single  = 0 
Public Overridable Property CASHOR() as single  Implements _ISpteller.CASHOR
    Get
	    Return _CASHOR
    End Get
    Set (byval value as single)
	    If _CASHOR <> value Then
	        IsChanged = True
	        _CASHOR= value
	    End If
    End Set
End property 

Protected _ADDLTD as single  = 0 
Public Overridable Property ADDLTD() as single  Implements _ISpteller.ADDLTD
    Get
	    Return _ADDLTD
    End Get
    Set (byval value as single)
	    If _ADDLTD <> value Then
	        IsChanged = True
	        _ADDLTD= value
	    End If
    End Set
End property 

Protected _CTFNAME1 as string  = "" 
Public Overridable Property CTFNAME1() as string  Implements _ISpteller.CTFNAME1
    Get
	    Return _CTFNAME1
    End Get
    Set (byval value as string)
	    If _CTFNAME1 <> value Then
	        IsChanged = True
	        _CTFNAME1= value
	    End If
    End Set
End property 

Protected _CTFAMT1 as single  = 0 
Public Overridable Property CTFAMT1() as single  Implements _ISpteller.CTFAMT1
    Get
	    Return _CTFAMT1
    End Get
    Set (byval value as single)
	    If _CTFAMT1 <> value Then
	        IsChanged = True
	        _CTFAMT1= value
	    End If
    End Set
End property 

Protected _CTFNAME2 as string  = "" 
Public Overridable Property CTFNAME2() as string  Implements _ISpteller.CTFNAME2
    Get
	    Return _CTFNAME2
    End Get
    Set (byval value as string)
	    If _CTFNAME2 <> value Then
	        IsChanged = True
	        _CTFNAME2= value
	    End If
    End Set
End property 

Protected _CTFAMT2 as single  = 0 
Public Overridable Property CTFAMT2() as single  Implements _ISpteller.CTFAMT2
    Get
	    Return _CTFAMT2
    End Get
    Set (byval value as single)
	    If _CTFAMT2 <> value Then
	        IsChanged = True
	        _CTFAMT2= value
	    End If
    End Set
End property 

Protected _CTFNAME3 as string  = "" 
Public Overridable Property CTFNAME3() as string  Implements _ISpteller.CTFNAME3
    Get
	    Return _CTFNAME3
    End Get
    Set (byval value as string)
	    If _CTFNAME3 <> value Then
	        IsChanged = True
	        _CTFNAME3= value
	    End If
    End Set
End property 

Protected _CTFAMT3 as single  = 0 
Public Overridable Property CTFAMT3() as single  Implements _ISpteller.CTFAMT3
    Get
	    Return _CTFAMT3
    End Get
    Set (byval value as single)
	    If _CTFAMT3 <> value Then
	        IsChanged = True
	        _CTFAMT3= value
	    End If
    End Set
End property 

Protected _ADDCASH as single  = 0 
Public Overridable Property ADDCASH() as single  Implements _ISpteller.ADDCASH
    Get
	    Return _ADDCASH
    End Get
    Set (byval value as single)
	    If _ADDCASH <> value Then
	        IsChanged = True
	        _ADDCASH= value
	    End If
    End Set
End property 

Protected _CRSAV as single  = 0 
Public Overridable Property CRSAV() as single  Implements _ISpteller.CRSAV
    Get
	    Return _CRSAV
    End Get
    Set (byval value as single)
	    If _CRSAV <> value Then
	        IsChanged = True
	        _CRSAV= value
	    End If
    End Set
End property 

Protected _CRORO as single  = 0 
Public Overridable Property CRORO() as single  Implements _ISpteller.CRORO
    Get
	    Return _CRORO
    End Get
    Set (byval value as single)
	    If _CRORO <> value Then
	        IsChanged = True
	        _CRORO= value
	    End If
    End Set
End property 

Protected _CRACC as single  = 0 
Public Overridable Property CRACC() as single  Implements _ISpteller.CRACC
    Get
	    Return _CRACC
    End Get
    Set (byval value as single)
	    If _CRACC <> value Then
	        IsChanged = True
	        _CRACC= value
	    End If
    End Set
End property 

Protected _CRCR as single  = 0 
Public Overridable Property CRCR() as single  Implements _ISpteller.CRCR
    Get
	    Return _CRCR
    End Get
    Set (byval value as single)
	    If _CRCR <> value Then
	        IsChanged = True
	        _CRCR= value
	    End If
    End Set
End property 

Protected _ADDCHECKS as single  = 0 
Public Overridable Property ADDCHECKS() as single  Implements _ISpteller.ADDCHECKS
    Get
	    Return _ADDCHECKS
    End Get
    Set (byval value as single)
	    If _ADDCHECKS <> value Then
	        IsChanged = True
	        _ADDCHECKS= value
	    End If
    End Set
End property 

Protected _ADDTOTAL as single  = 0 
Public Overridable Property ADDTOTAL() as single  Implements _ISpteller.ADDTOTAL
    Get
	    Return _ADDTOTAL
    End Get
    Set (byval value as single)
	    If _ADDTOTAL <> value Then
	        IsChanged = True
	        _ADDTOTAL= value
	    End If
    End Set
End property 

Protected _DIB as single  = 0 
Public Overridable Property DIB() as single  Implements _ISpteller.DIB
    Get
	    Return _DIB
    End Get
    Set (byval value as single)
	    If _DIB <> value Then
	        IsChanged = True
	        _DIB= value
	    End If
    End Set
End property 

Protected _REF as single  = 0 
Public Overridable Property REF() as single  Implements _ISpteller.REF
    Get
	    Return _REF
    End Get
    Set (byval value as single)
	    If _REF <> value Then
	        IsChanged = True
	        _REF= value
	    End If
    End Set
End property 

Protected _WITH as single  = 0 
    Public Overridable Property SDWITH() As Single Implements _ISpteller.SDWITH
        Get
            Return _WITH
        End Get
        Set(ByVal value As Single)
            If _WITH <> value Then
                IsChanged = True
                _WITH = value
            End If
        End Set
    End Property

Protected _CHKENC as single  = 0 
Public Overridable Property CHKENC() as single  Implements _ISpteller.CHKENC
    Get
	    Return _CHKENC
    End Get
    Set (byval value as single)
	    If _CHKENC <> value Then
	        IsChanged = True
	        _CHKENC= value
	    End If
    End Set
End property 

Protected _COCI as single  = 0 
Public Overridable Property COCI() as single  Implements _ISpteller.COCI
    Get
	    Return _COCI
    End Get
    Set (byval value as single)
	    If _COCI <> value Then
	        IsChanged = True
	        _COCI= value
	    End If
    End Set
End property 

Protected _CHKDEP as single  = 0 
Public Overridable Property CHKDEP() as single  Implements _ISpteller.CHKDEP
    Get
	    Return _CHKDEP
    End Get
    Set (byval value as single)
	    If _CHKDEP <> value Then
	        IsChanged = True
	        _CHKDEP= value
	    End If
    End Set
End property 

Protected _EMER as single  = 0 
Public Overridable Property EMER() as single  Implements _ISpteller.EMER
    Get
	    Return _EMER
    End Get
    Set (byval value as single)
	    If _EMER <> value Then
	        IsChanged = True
	        _EMER= value
	    End If
    End Set
End property 

Protected _CTTNAME1 as string  = "" 
Public Overridable Property CTTNAME1() as string  Implements _ISpteller.CTTNAME1
    Get
	    Return _CTTNAME1
    End Get
    Set (byval value as string)
	    If _CTTNAME1 <> value Then
	        IsChanged = True
	        _CTTNAME1= value
	    End If
    End Set
End property 

Protected _CTTAMT1 as single  = 0 
Public Overridable Property CTTAMT1() as single  Implements _ISpteller.CTTAMT1
    Get
	    Return _CTTAMT1
    End Get
    Set (byval value as single)
	    If _CTTAMT1 <> value Then
	        IsChanged = True
	        _CTTAMT1= value
	    End If
    End Set
End property 

Protected _CTTNAME2 as string  = "" 
Public Overridable Property CTTNAME2() as string  Implements _ISpteller.CTTNAME2
    Get
	    Return _CTTNAME2
    End Get
    Set (byval value as string)
	    If _CTTNAME2 <> value Then
	        IsChanged = True
	        _CTTNAME2= value
	    End If
    End Set
End property 

Protected _CTTAMT2 as single  = 0 
Public Overridable Property CTTAMT2() as single  Implements _ISpteller.CTTAMT2
    Get
	    Return _CTTAMT2
    End Get
    Set (byval value as single)
	    If _CTTAMT2 <> value Then
	        IsChanged = True
	        _CTTAMT2= value
	    End If
    End Set
End property 

Protected _CTTNAME3 as string  = "" 
Public Overridable Property CTTNAME3() as string  Implements _ISpteller.CTTNAME3
    Get
	    Return _CTTNAME3
    End Get
    Set (byval value as string)
	    If _CTTNAME3 <> value Then
	        IsChanged = True
	        _CTTNAME3= value
	    End If
    End Set
End property 

Protected _CTTAMT3 as single  = 0 
Public Overridable Property CTTAMT3() as single  Implements _ISpteller.CTTAMT3
    Get
	    Return _CTTAMT3
    End Get
    Set (byval value as single)
	    If _CTTAMT3 <> value Then
	        IsChanged = True
	        _CTTAMT3= value
	    End If
    End Set
End property 

Protected _TOTDISB as single  = 0 
Public Overridable Property TOTDISB() as single  Implements _ISpteller.TOTDISB
    Get
	    Return _TOTDISB
    End Get
    Set (byval value as single)
	    If _TOTDISB <> value Then
	        IsChanged = True
	        _TOTDISB= value
	    End If
    End Set
End property 

Protected _CBALEND as single  = 0 
Public Overridable Property CBALEND() as single  Implements _ISpteller.CBALEND
    Get
	    Return _CBALEND
    End Get
    Set (byval value as single)
	    If _CBALEND <> value Then
	        IsChanged = True
	        _CBALEND= value
	    End If
    End Set
End property 

Protected _CTTCEND as single  = 0 
Public Overridable Property CTTCEND() as single  Implements _ISpteller.CTTCEND
    Get
	    Return _CTTCEND
    End Get
    Set (byval value as single)
	    If _CTTCEND <> value Then
	        IsChanged = True
	        _CTTCEND= value
	    End If
    End Set
End property 

Protected _OVER as single  = 0 
Public Overridable Property OVER() as single  Implements _ISpteller.OVER
    Get
	    Return _OVER
    End Get
    Set (byval value as single)
	    If _OVER <> value Then
	        IsChanged = True
	        _OVER= value
	    End If
    End Set
End property 

Protected _B_1000 as single  = 0 
Public Overridable Property B_1000() as single  Implements _ISpteller.B_1000
    Get
	    Return _B_1000
    End Get
    Set (byval value as single)
	    If _B_1000 <> value Then
	        IsChanged = True
	        _B_1000= value
	    End If
    End Set
End property 

Protected _B_500 as single  = 0 
Public Overridable Property B_500() as single  Implements _ISpteller.B_500
    Get
	    Return _B_500
    End Get
    Set (byval value as single)
	    If _B_500 <> value Then
	        IsChanged = True
	        _B_500= value
	    End If
    End Set
End property 

Protected _B_200 as single  = 0 
Public Overridable Property B_200() as single  Implements _ISpteller.B_200
    Get
	    Return _B_200
    End Get
    Set (byval value as single)
	    If _B_200 <> value Then
	        IsChanged = True
	        _B_200= value
	    End If
    End Set
End property 

Protected _B_100 as single  = 0 
Public Overridable Property B_100() as single  Implements _ISpteller.B_100
    Get
	    Return _B_100
    End Get
    Set (byval value as single)
	    If _B_100 <> value Then
	        IsChanged = True
	        _B_100= value
	    End If
    End Set
End property 

Protected _B_50 as single  = 0 
Public Overridable Property B_50() as single  Implements _ISpteller.B_50
    Get
	    Return _B_50
    End Get
    Set (byval value as single)
	    If _B_50 <> value Then
	        IsChanged = True
	        _B_50= value
	    End If
    End Set
End property 

Protected _B_20 as single  = 0 
Public Overridable Property B_20() as single  Implements _ISpteller.B_20
    Get
	    Return _B_20
    End Get
    Set (byval value as single)
	    If _B_20 <> value Then
	        IsChanged = True
	        _B_20= value
	    End If
    End Set
End property 

Protected _B_10 as single  = 0 
Public Overridable Property B_10() as single  Implements _ISpteller.B_10
    Get
	    Return _B_10
    End Get
    Set (byval value as single)
	    If _B_10 <> value Then
	        IsChanged = True
	        _B_10= value
	    End If
    End Set
End property 

Protected _B_5 as single  = 0 
Public Overridable Property B_5() as single  Implements _ISpteller.B_5
    Get
	    Return _B_5
    End Get
    Set (byval value as single)
	    If _B_5 <> value Then
	        IsChanged = True
	        _B_5= value
	    End If
    End Set
End property 

Protected _B_1 as single  = 0 
Public Overridable Property B_1() as single  Implements _ISpteller.B_1
    Get
	    Return _B_1
    End Get
    Set (byval value as single)
	    If _B_1 <> value Then
	        IsChanged = True
	        _B_1= value
	    End If
    End Set
End property 

Protected _B_P50 as single  = 0 
Public Overridable Property B_P50() as single  Implements _ISpteller.B_P50
    Get
	    Return _B_P50
    End Get
    Set (byval value as single)
	    If _B_P50 <> value Then
	        IsChanged = True
	        _B_P50= value
	    End If
    End Set
End property 

Protected _B_P25 as single  = 0 
Public Overridable Property B_P25() as single  Implements _ISpteller.B_P25
    Get
	    Return _B_P25
    End Get
    Set (byval value as single)
	    If _B_P25 <> value Then
	        IsChanged = True
	        _B_P25= value
	    End If
    End Set
End property 

Protected _B_P10 as single  = 0 
Public Overridable Property B_P10() as single  Implements _ISpteller.B_P10
    Get
	    Return _B_P10
    End Get
    Set (byval value as single)
	    If _B_P10 <> value Then
	        IsChanged = True
	        _B_P10= value
	    End If
    End Set
End property 

Protected _B_P05 as single  = 0 
Public Overridable Property B_P05() as single  Implements _ISpteller.B_P05
    Get
	    Return _B_P05
    End Get
    Set (byval value as single)
	    If _B_P05 <> value Then
	        IsChanged = True
	        _B_P05= value
	    End If
    End Set
End property 

Protected _B_P01 as single  = 0 
Public Overridable Property B_P01() as single  Implements _ISpteller.B_P01
    Get
	    Return _B_P01
    End Get
    Set (byval value as single)
	    If _B_P01 <> value Then
	        IsChanged = True
	        _B_P01= value
	    End If
    End Set
End property 

Protected _TCCOUNT as single  = 0 
Public Overridable Property TCCOUNT() as single  Implements _ISpteller.TCCOUNT
    Get
	    Return _TCCOUNT
    End Get
    Set (byval value as single)
	    If _TCCOUNT <> value Then
	        IsChanged = True
	        _TCCOUNT= value
	    End If
    End Set
End property 


#End Region

#Region "Method"
''' <summary>
'''This method read an Spteller from DB.
''' </summary>
''' <returns>
'''Return 0 if all ok, 1 if error
''' </returns>
Public Overridable Function Read(Id As Integer) As Integer
    'Return 0 if all ok
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Dim int As Spteller = Manager.Read(Id)
                    _SPTELLER_ID = int.SPTELLER_ID
                    _TNAME = int.TNAME
                    _TDATE = int.TDATE
                    _CASHB = int.CASHB
                    _COCIB = int.COCIB
                    _ADDLREQ = int.ADDLREQ
                    _ADDMREQ = int.ADDMREQ
                    _CASHSAV = int.CASHSAV
                    _CASHOR = int.CASHOR
                    _ADDLTD = int.ADDLTD
                    _CTFNAME1 = int.CTFNAME1
                    _CTFAMT1 = int.CTFAMT1
                    _CTFNAME2 = int.CTFNAME2
                    _CTFAMT2 = int.CTFAMT2
                    _CTFNAME3 = int.CTFNAME3
                    _CTFAMT3 = int.CTFAMT3
                    _ADDCASH = int.ADDCASH
                    _CRSAV = int.CRSAV
                    _CRORO = int.CRORO
                    _CRACC = int.CRACC
                    _CRCR = int.CRCR
                    _ADDCHECKS = int.ADDCHECKS
                    _ADDTOTAL = int.ADDTOTAL
                    _DIB = int.DIB
                    _REF = int.REF
                _WITH = int.SDWITH
                    _CHKENC = int.CHKENC
                    _COCI = int.COCI
                    _CHKDEP = int.CHKDEP
                    _EMER = int.EMER
                    _CTTNAME1 = int.CTTNAME1
                    _CTTAMT1 = int.CTTAMT1
                    _CTTNAME2 = int.CTTNAME2
                    _CTTAMT2 = int.CTTAMT2
                    _CTTNAME3 = int.CTTNAME3
                    _CTTAMT3 = int.CTTAMT3
                    _TOTDISB = int.TOTDISB
                    _CBALEND = int.CBALEND
                    _CTTCEND = int.CTTCEND
                    _OVER = int.OVER
                    _B_1000 = int.B_1000
                    _B_500 = int.B_500
                    _B_200 = int.B_200
                    _B_100 = int.B_100
                    _B_50 = int.B_50
                    _B_20 = int.B_20
                    _B_10 = int.B_10
                    _B_5 = int.B_5
                    _B_1 = int.B_1
                    _B_P50 = int.B_P50
                    _B_P25 = int.B_P25
                    _B_P10 = int.B_P10
                    _B_P05 = int.B_P05
                    _B_P01 = int.B_P01
                    _TCCOUNT = int.TCCOUNT
        	    End Using
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
	    Ris = 1
    End Try
    Return Ris
End Function

''' <summary>
'''This method save an Spteller on DB.
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
	  if _TNAME.Length > 8 then Ris = False
  if _CTFNAME1.Length > 8 then Ris = False
  if _CTFNAME2.Length > 8 then Ris = False
  if _CTFNAME3.Length > 8 then Ris = False
  if _CTTNAME1.Length > 8 then Ris = False
  if _CTTNAME2.Length > 8 then Ris = False
  if _CTTNAME3.Length > 8 then Ris = False

	Return Ris
End Function

#End Region

#Region "Embedded Class"


#End Region

End Class 

''' <summary>
'''Interface for table Spteller
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _ISpteller

Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

    
    Property SPTELLER_ID() as Int64

    
    Property TNAME() as string

    
    Property TDATE() as DateTime

    
    Property CASHB() as single

    
    Property COCIB() as single

    
    Property ADDLREQ() as single

    
    Property ADDMREQ() as single

    
    Property CASHSAV() as single

    
    Property CASHOR() as single

    
    Property ADDLTD() as single

    
    Property CTFNAME1() as string

    
    Property CTFAMT1() as single

    
    Property CTFNAME2() as string

    
    Property CTFAMT2() as single

    
    Property CTFNAME3() as string

    
    Property CTFAMT3() as single

    
    Property ADDCASH() as single

    
    Property CRSAV() as single

    
    Property CRORO() as single

    
    Property CRACC() as single

    
    Property CRCR() as single

    
    Property ADDCHECKS() as single

    
    Property ADDTOTAL() as single

    
    Property DIB() as single

    
    Property REF() as single

    
    Property SDWITH() As Single

    
    Property CHKENC() as single

    
    Property COCI() as single

    
    Property CHKDEP() as single

    
    Property EMER() as single

    
    Property CTTNAME1() as string

    
    Property CTTAMT1() as single

    
    Property CTTNAME2() as string

    
    Property CTTAMT2() as single

    
    Property CTTNAME3() as string

    
    Property CTTAMT3() as single

    
    Property TOTDISB() as single

    
    Property CBALEND() as single

    
    Property CTTCEND() as single

    
    Property OVER() as single

    
    Property B_1000() as single

    
    Property B_500() as single

    
    Property B_200() as single

    
    Property B_100() as single

    
    Property B_50() as single

    
    Property B_20() as single

    
    Property B_10() as single

    
    Property B_5() as single

    
    Property B_1() as single

    
    Property B_P50() as single

    
    Property B_P25() as single

    
    Property B_P10() as single

    
    Property B_P05() as single

    
    Property B_P01() as single

    
    Property TCCOUNT() as single

    
#End Region

End Interface