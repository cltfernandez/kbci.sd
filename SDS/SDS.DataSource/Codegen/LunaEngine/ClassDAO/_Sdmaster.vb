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
'''DAO Class for table Sdmaster
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Sdmaster
	Inherits LUNA.LunaBaseClassEntity
    Implements _ISdmaster
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _ISdmaster.FillFromDataRecord
     SDMASTER_ID = myRecord("SDMASTER_ID")
    		if not myRecord("ACCTNO") is DBNull.Value then ACCTNO = myRecord("ACCTNO")
    		if not myRecord("KBCI_NO") is DBNull.Value then KBCI_NO = myRecord("KBCI_NO")
    		if not myRecord("CBEMPNO") is DBNull.Value then CBEMPNO = myRecord("CBEMPNO")
    		if not myRecord("ACCTNAME") is DBNull.Value then ACCTNAME = myRecord("ACCTNAME")
    		if not myRecord("ACCTADDR1") is DBNull.Value then ACCTADDR1 = myRecord("ACCTADDR1")
    		if not myRecord("ACCTADDR2") is DBNull.Value then ACCTADDR2 = myRecord("ACCTADDR2")
    		if not myRecord("ACCTSNAME") is DBNull.Value then ACCTSNAME = myRecord("ACCTSNAME")
    		if not myRecord("ACCTPHONE1") is DBNull.Value then ACCTPHONE1 = myRecord("ACCTPHONE1")
    		if not myRecord("ACCTPHONE2") is DBNull.Value then ACCTPHONE2 = myRecord("ACCTPHONE2")
    		if not myRecord("ACCTDTYPE") is DBNull.Value then ACCTDTYPE = myRecord("ACCTDTYPE")
    		if not myRecord("ACCTCCODE") is DBNull.Value then ACCTCCODE = myRecord("ACCTCCODE")
    		if not myRecord("ACCTICODE") is DBNull.Value then ACCTICODE = myRecord("ACCTICODE")
    		if not myRecord("ACCTATX") is DBNull.Value then ACCTATX = myRecord("ACCTATX")
    		if not myRecord("ACCTOTH1") is DBNull.Value then ACCTOTH1 = myRecord("ACCTOTH1")
    		if not myRecord("ACCTOTH2") is DBNull.Value then ACCTOTH2 = myRecord("ACCTOTH2")
    		if not myRecord("ACCTMAINT") is DBNull.Value then ACCTMAINT = myRecord("ACCTMAINT")
    		if not myRecord("ACCTIDEP") is DBNull.Value then ACCTIDEP = myRecord("ACCTIDEP")
    		if not myRecord("ACCTPBAL") is DBNull.Value then ACCTPBAL = myRecord("ACCTPBAL")
    		if not myRecord("ACCTLBAL") is DBNull.Value then ACCTLBAL = myRecord("ACCTLBAL")
    		if not myRecord("ACCTOBAL") is DBNull.Value then ACCTOBAL = myRecord("ACCTOBAL")
    		if not myRecord("ACCTABAL") is DBNull.Value then ACCTABAL = myRecord("ACCTABAL")
    		if not myRecord("ACCTFLOATS") is DBNull.Value then ACCTFLOATS = myRecord("ACCTFLOATS")
    		if not myRecord("ACCTTEX") is DBNull.Value then ACCTTEX = myRecord("ACCTTEX")
    		if not myRecord("ACCTACLO") is DBNull.Value then ACCTACLO = myRecord("ACCTACLO")
    		if not myRecord("ACCTWMIN") is DBNull.Value then ACCTWMIN = myRecord("ACCTWMIN")
    		if not myRecord("ACCTWSC") is DBNull.Value then ACCTWSC = myRecord("ACCTWSC")
    		if not myRecord("ACCTWINT") is DBNull.Value then ACCTWINT = myRecord("ACCTWINT")
    		if not myRecord("ACCTSTAT") is DBNull.Value then ACCTSTAT = myRecord("ACCTSTAT")
    		if not myRecord("PLINE") is DBNull.Value then PLINE = myRecord("PLINE")
    		if not myRecord("LLINE") is DBNull.Value then LLINE = myRecord("LLINE")
    		if not myRecord("UNPOSTED") is DBNull.Value then UNPOSTED = myRecord("UNPOSTED")
    		if not myRecord("HOLDOUT") is DBNull.Value then HOLDOUT = myRecord("HOLDOUT")
    		if not myRecord("LSEQ") is DBNull.Value then LSEQ = myRecord("LSEQ")
    		if not myRecord("LTRANDATE") is DBNull.Value then LTRANDATE = myRecord("LTRANDATE")
    		if not myRecord("ADD_DATE") is DBNull.Value then ADD_DATE = myRecord("ADD_DATE")
    		if not myRecord("CHG_DATE") is DBNull.Value then CHG_DATE = myRecord("CHG_DATE")
    		if not myRecord("UPD_USER") is DBNull.Value then UPD_USER = myRecord("UPD_USER")
    		if not myRecord("REC_STAT") is DBNull.Value then REC_STAT = myRecord("REC_STAT")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Sdmaster)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(SdmasterDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Sdmaster))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _SDMASTER_ID as Int64  = Nothing 
Public Overridable Property SDMASTER_ID() as Int64  Implements _ISdmaster.SDMASTER_ID
    Get
	    Return _SDMASTER_ID
    End Get
    Set (byval value as Int64)
	    If _SDMASTER_ID <> value Then
	        IsChanged = True
	        _SDMASTER_ID= value
	    End If
    End Set
End property 

Protected _ACCTNO as string  = "" 
Public Overridable Property ACCTNO() as string  Implements _ISdmaster.ACCTNO
    Get
	    Return _ACCTNO
    End Get
    Set (byval value as string)
	    If _ACCTNO <> value Then
	        IsChanged = True
	        _ACCTNO= value
	    End If
    End Set
End property 

Protected _KBCI_NO as string  = "" 
Public Overridable Property KBCI_NO() as string  Implements _ISdmaster.KBCI_NO
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

Protected _CBEMPNO as string  = "" 
Public Overridable Property CBEMPNO() as string  Implements _ISdmaster.CBEMPNO
    Get
	    Return _CBEMPNO
    End Get
    Set (byval value as string)
	    If _CBEMPNO <> value Then
	        IsChanged = True
	        _CBEMPNO= value
	    End If
    End Set
End property 

Protected _ACCTNAME as string  = "" 
Public Overridable Property ACCTNAME() as string  Implements _ISdmaster.ACCTNAME
    Get
	    Return _ACCTNAME
    End Get
    Set (byval value as string)
	    If _ACCTNAME <> value Then
	        IsChanged = True
	        _ACCTNAME= value
	    End If
    End Set
End property 

Protected _ACCTADDR1 as string  = "" 
Public Overridable Property ACCTADDR1() as string  Implements _ISdmaster.ACCTADDR1
    Get
	    Return _ACCTADDR1
    End Get
    Set (byval value as string)
	    If _ACCTADDR1 <> value Then
	        IsChanged = True
	        _ACCTADDR1= value
	    End If
    End Set
End property 

Protected _ACCTADDR2 as string  = "" 
Public Overridable Property ACCTADDR2() as string  Implements _ISdmaster.ACCTADDR2
    Get
	    Return _ACCTADDR2
    End Get
    Set (byval value as string)
	    If _ACCTADDR2 <> value Then
	        IsChanged = True
	        _ACCTADDR2= value
	    End If
    End Set
End property 

Protected _ACCTSNAME as string  = "" 
Public Overridable Property ACCTSNAME() as string  Implements _ISdmaster.ACCTSNAME
    Get
	    Return _ACCTSNAME
    End Get
    Set (byval value as string)
	    If _ACCTSNAME <> value Then
	        IsChanged = True
	        _ACCTSNAME= value
	    End If
    End Set
End property 

Protected _ACCTPHONE1 as string  = "" 
Public Overridable Property ACCTPHONE1() as string  Implements _ISdmaster.ACCTPHONE1
    Get
	    Return _ACCTPHONE1
    End Get
    Set (byval value as string)
	    If _ACCTPHONE1 <> value Then
	        IsChanged = True
	        _ACCTPHONE1= value
	    End If
    End Set
End property 

Protected _ACCTPHONE2 as string  = "" 
Public Overridable Property ACCTPHONE2() as string  Implements _ISdmaster.ACCTPHONE2
    Get
	    Return _ACCTPHONE2
    End Get
    Set (byval value as string)
	    If _ACCTPHONE2 <> value Then
	        IsChanged = True
	        _ACCTPHONE2= value
	    End If
    End Set
End property 

Protected _ACCTDTYPE as string  = "" 
Public Overridable Property ACCTDTYPE() as string  Implements _ISdmaster.ACCTDTYPE
    Get
	    Return _ACCTDTYPE
    End Get
    Set (byval value as string)
	    If _ACCTDTYPE <> value Then
	        IsChanged = True
	        _ACCTDTYPE= value
	    End If
    End Set
End property 

Protected _ACCTCCODE as string  = "" 
Public Overridable Property ACCTCCODE() as string  Implements _ISdmaster.ACCTCCODE
    Get
	    Return _ACCTCCODE
    End Get
    Set (byval value as string)
	    If _ACCTCCODE <> value Then
	        IsChanged = True
	        _ACCTCCODE= value
	    End If
    End Set
End property 

Protected _ACCTICODE as string  = "" 
Public Overridable Property ACCTICODE() as string  Implements _ISdmaster.ACCTICODE
    Get
	    Return _ACCTICODE
    End Get
    Set (byval value as string)
	    If _ACCTICODE <> value Then
	        IsChanged = True
	        _ACCTICODE= value
	    End If
    End Set
End property 

Protected _ACCTATX as string  = "" 
Public Overridable Property ACCTATX() as string  Implements _ISdmaster.ACCTATX
    Get
	    Return _ACCTATX
    End Get
    Set (byval value as string)
	    If _ACCTATX <> value Then
	        IsChanged = True
	        _ACCTATX= value
	    End If
    End Set
End property 

Protected _ACCTOTH1 as string  = "" 
Public Overridable Property ACCTOTH1() as string  Implements _ISdmaster.ACCTOTH1
    Get
	    Return _ACCTOTH1
    End Get
    Set (byval value as string)
	    If _ACCTOTH1 <> value Then
	        IsChanged = True
	        _ACCTOTH1= value
	    End If
    End Set
End property 

Protected _ACCTOTH2 as string  = "" 
Public Overridable Property ACCTOTH2() as string  Implements _ISdmaster.ACCTOTH2
    Get
	    Return _ACCTOTH2
    End Get
    Set (byval value as string)
	    If _ACCTOTH2 <> value Then
	        IsChanged = True
	        _ACCTOTH2= value
	    End If
    End Set
End property 

Protected _ACCTMAINT as single  = 0 
Public Overridable Property ACCTMAINT() as single  Implements _ISdmaster.ACCTMAINT
    Get
	    Return _ACCTMAINT
    End Get
    Set (byval value as single)
	    If _ACCTMAINT <> value Then
	        IsChanged = True
	        _ACCTMAINT= value
	    End If
    End Set
End property 

Protected _ACCTIDEP as single  = 0 
Public Overridable Property ACCTIDEP() as single  Implements _ISdmaster.ACCTIDEP
    Get
	    Return _ACCTIDEP
    End Get
    Set (byval value as single)
	    If _ACCTIDEP <> value Then
	        IsChanged = True
	        _ACCTIDEP= value
	    End If
    End Set
End property 

Protected _ACCTPBAL as single  = 0 
Public Overridable Property ACCTPBAL() as single  Implements _ISdmaster.ACCTPBAL
    Get
	    Return _ACCTPBAL
    End Get
    Set (byval value as single)
	    If _ACCTPBAL <> value Then
	        IsChanged = True
	        _ACCTPBAL= value
	    End If
    End Set
End property 

Protected _ACCTLBAL as single  = 0 
Public Overridable Property ACCTLBAL() as single  Implements _ISdmaster.ACCTLBAL
    Get
	    Return _ACCTLBAL
    End Get
    Set (byval value as single)
	    If _ACCTLBAL <> value Then
	        IsChanged = True
	        _ACCTLBAL= value
	    End If
    End Set
End property 

Protected _ACCTOBAL as single  = 0 
Public Overridable Property ACCTOBAL() as single  Implements _ISdmaster.ACCTOBAL
    Get
	    Return _ACCTOBAL
    End Get
    Set (byval value as single)
	    If _ACCTOBAL <> value Then
	        IsChanged = True
	        _ACCTOBAL= value
	    End If
    End Set
End property 

Protected _ACCTABAL as single  = 0 
Public Overridable Property ACCTABAL() as single  Implements _ISdmaster.ACCTABAL
    Get
	    Return _ACCTABAL
    End Get
    Set (byval value as single)
	    If _ACCTABAL <> value Then
	        IsChanged = True
	        _ACCTABAL= value
	    End If
    End Set
End property 

Protected _ACCTFLOATS as single  = 0 
Public Overridable Property ACCTFLOATS() as single  Implements _ISdmaster.ACCTFLOATS
    Get
	    Return _ACCTFLOATS
    End Get
    Set (byval value as single)
	    If _ACCTFLOATS <> value Then
	        IsChanged = True
	        _ACCTFLOATS= value
	    End If
    End Set
End property 

Protected _ACCTTEX as string  = "" 
Public Overridable Property ACCTTEX() as string  Implements _ISdmaster.ACCTTEX
    Get
	    Return _ACCTTEX
    End Get
    Set (byval value as string)
	    If _ACCTTEX <> value Then
	        IsChanged = True
	        _ACCTTEX= value
	    End If
    End Set
End property 

Protected _ACCTACLO as string  = "" 
Public Overridable Property ACCTACLO() as string  Implements _ISdmaster.ACCTACLO
    Get
	    Return _ACCTACLO
    End Get
    Set (byval value as string)
	    If _ACCTACLO <> value Then
	        IsChanged = True
	        _ACCTACLO= value
	    End If
    End Set
End property 

Protected _ACCTWMIN as string  = "" 
Public Overridable Property ACCTWMIN() as string  Implements _ISdmaster.ACCTWMIN
    Get
	    Return _ACCTWMIN
    End Get
    Set (byval value as string)
	    If _ACCTWMIN <> value Then
	        IsChanged = True
	        _ACCTWMIN= value
	    End If
    End Set
End property 

Protected _ACCTWSC as string  = "" 
Public Overridable Property ACCTWSC() as string  Implements _ISdmaster.ACCTWSC
    Get
	    Return _ACCTWSC
    End Get
    Set (byval value as string)
	    If _ACCTWSC <> value Then
	        IsChanged = True
	        _ACCTWSC= value
	    End If
    End Set
End property 

Protected _ACCTWINT as string  = "" 
Public Overridable Property ACCTWINT() as string  Implements _ISdmaster.ACCTWINT
    Get
	    Return _ACCTWINT
    End Get
    Set (byval value as string)
	    If _ACCTWINT <> value Then
	        IsChanged = True
	        _ACCTWINT= value
	    End If
    End Set
End property 

Protected _ACCTSTAT as string  = "" 
Public Overridable Property ACCTSTAT() as string  Implements _ISdmaster.ACCTSTAT
    Get
	    Return _ACCTSTAT
    End Get
    Set (byval value as string)
	    If _ACCTSTAT <> value Then
	        IsChanged = True
	        _ACCTSTAT= value
	    End If
    End Set
End property 

Protected _PLINE as single  = 0 
Public Overridable Property PLINE() as single  Implements _ISdmaster.PLINE
    Get
	    Return _PLINE
    End Get
    Set (byval value as single)
	    If _PLINE <> value Then
	        IsChanged = True
	        _PLINE= value
	    End If
    End Set
End property 

Protected _LLINE as single  = 0 
Public Overridable Property LLINE() as single  Implements _ISdmaster.LLINE
    Get
	    Return _LLINE
    End Get
    Set (byval value as single)
	    If _LLINE <> value Then
	        IsChanged = True
	        _LLINE= value
	    End If
    End Set
End property 

Protected _UNPOSTED as single  = 0 
Public Overridable Property UNPOSTED() as single  Implements _ISdmaster.UNPOSTED
    Get
	    Return _UNPOSTED
    End Get
    Set (byval value as single)
	    If _UNPOSTED <> value Then
	        IsChanged = True
	        _UNPOSTED= value
	    End If
    End Set
End property 

Protected _HOLDOUT as single  = 0 
Public Overridable Property HOLDOUT() as single  Implements _ISdmaster.HOLDOUT
    Get
	    Return _HOLDOUT
    End Get
    Set (byval value as single)
	    If _HOLDOUT <> value Then
	        IsChanged = True
	        _HOLDOUT= value
	    End If
    End Set
End property 

Protected _LSEQ as single  = 0 
Public Overridable Property LSEQ() as single  Implements _ISdmaster.LSEQ
    Get
	    Return _LSEQ
    End Get
    Set (byval value as single)
	    If _LSEQ <> value Then
	        IsChanged = True
	        _LSEQ= value
	    End If
    End Set
End property 

Protected _LTRANDATE as DateTime  = Nothing 
Public Overridable Property LTRANDATE() as DateTime  Implements _ISdmaster.LTRANDATE
    Get
	    Return _LTRANDATE
    End Get
    Set (byval value as DateTime)
	    If _LTRANDATE <> value Then
	        IsChanged = True
	        _LTRANDATE= value
	    End If
    End Set
End property 

Protected _ADD_DATE as DateTime  = Nothing 
Public Overridable Property ADD_DATE() as DateTime  Implements _ISdmaster.ADD_DATE
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
Public Overridable Property CHG_DATE() as DateTime  Implements _ISdmaster.CHG_DATE
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

Protected _UPD_USER as string  = "" 
Public Overridable Property UPD_USER() as string  Implements _ISdmaster.UPD_USER
    Get
	    Return _UPD_USER
    End Get
    Set (byval value as string)
	    If _UPD_USER <> value Then
	        IsChanged = True
	        _UPD_USER= value
	    End If
    End Set
End property 

Protected _REC_STAT as Boolean  = False 
Public Overridable Property REC_STAT() as Boolean  Implements _ISdmaster.REC_STAT
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


#End Region

#Region "Method"
''' <summary>
'''This method read an Sdmaster from DB.
''' </summary>
''' <returns>
'''Return 0 if all ok, 1 if error
''' </returns>
Public Overridable Function Read(Id As Integer) As Integer
    'Return 0 if all ok
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Dim int As Sdmaster = Manager.Read(Id)
                    _SDMASTER_ID = int.SDMASTER_ID
                    _ACCTNO = int.ACCTNO
                    _KBCI_NO = int.KBCI_NO
                    _CBEMPNO = int.CBEMPNO
                    _ACCTNAME = int.ACCTNAME
                    _ACCTADDR1 = int.ACCTADDR1
                    _ACCTADDR2 = int.ACCTADDR2
                    _ACCTSNAME = int.ACCTSNAME
                    _ACCTPHONE1 = int.ACCTPHONE1
                    _ACCTPHONE2 = int.ACCTPHONE2
                    _ACCTDTYPE = int.ACCTDTYPE
                    _ACCTCCODE = int.ACCTCCODE
                    _ACCTICODE = int.ACCTICODE
                    _ACCTATX = int.ACCTATX
                    _ACCTOTH1 = int.ACCTOTH1
                    _ACCTOTH2 = int.ACCTOTH2
                    _ACCTMAINT = int.ACCTMAINT
                    _ACCTIDEP = int.ACCTIDEP
                    _ACCTPBAL = int.ACCTPBAL
                    _ACCTLBAL = int.ACCTLBAL
                    _ACCTOBAL = int.ACCTOBAL
                    _ACCTABAL = int.ACCTABAL
                    _ACCTFLOATS = int.ACCTFLOATS
                    _ACCTTEX = int.ACCTTEX
                    _ACCTACLO = int.ACCTACLO
                    _ACCTWMIN = int.ACCTWMIN
                    _ACCTWSC = int.ACCTWSC
                    _ACCTWINT = int.ACCTWINT
                    _ACCTSTAT = int.ACCTSTAT
                    _PLINE = int.PLINE
                    _LLINE = int.LLINE
                    _UNPOSTED = int.UNPOSTED
                    _HOLDOUT = int.HOLDOUT
                    _LSEQ = int.LSEQ
                    _LTRANDATE = int.LTRANDATE
                    _ADD_DATE = int.ADD_DATE
                    _CHG_DATE = int.CHG_DATE
                    _UPD_USER = int.UPD_USER
                    _REC_STAT = int.REC_STAT
        	    End Using
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
	    Ris = 1
    End Try
    Return Ris
End Function

''' <summary>
'''This method save an Sdmaster on DB.
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
	  if _ACCTNO.Length > 10 then Ris = False
  if _KBCI_NO.Length > 7 then Ris = False
  if _CBEMPNO.Length > 6 then Ris = False
  if _ACCTNAME.Length > 40 then Ris = False
  if _ACCTADDR1.Length > 100 then Ris = False
  if _ACCTADDR2.Length > 100 then Ris = False
  if _ACCTSNAME.Length > 20 then Ris = False
  if _ACCTPHONE1.Length > 20 then Ris = False
  if _ACCTPHONE2.Length > 20 then Ris = False
  if _ACCTDTYPE.Length > 1 then Ris = False
  if _ACCTCCODE.Length > 1 then Ris = False
  if _ACCTICODE.Length > 1 then Ris = False
  if _ACCTATX.Length > 1 then Ris = False
  if _ACCTOTH1.Length > 10 then Ris = False
  if _ACCTOTH2.Length > 10 then Ris = False
  if _ACCTTEX.Length > 1 then Ris = False
  if _ACCTACLO.Length > 1 then Ris = False
  if _ACCTWMIN.Length > 1 then Ris = False
  if _ACCTWSC.Length > 1 then Ris = False
  if _ACCTWINT.Length > 1 then Ris = False
  if _ACCTSTAT.Length > 1 then Ris = False
  if _UPD_USER.Length > 8 then Ris = False

	Return Ris
End Function

#End Region

#Region "Embedded Class"


#End Region

End Class 

''' <summary>
'''Interface for table Sdmaster
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _ISdmaster

Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

    
    Property SDMASTER_ID() as Int64

    
    Property ACCTNO() as string

    
    Property KBCI_NO() as string

    
    Property CBEMPNO() as string

    
    Property ACCTNAME() as string

    
    Property ACCTADDR1() as string

    
    Property ACCTADDR2() as string

    
    Property ACCTSNAME() as string

    
    Property ACCTPHONE1() as string

    
    Property ACCTPHONE2() as string

    
    Property ACCTDTYPE() as string

    
    Property ACCTCCODE() as string

    
    Property ACCTICODE() as string

    
    Property ACCTATX() as string

    
    Property ACCTOTH1() as string

    
    Property ACCTOTH2() as string

    
    Property ACCTMAINT() as single

    
    Property ACCTIDEP() as single

    
    Property ACCTPBAL() as single

    
    Property ACCTLBAL() as single

    
    Property ACCTOBAL() as single

    
    Property ACCTABAL() as single

    
    Property ACCTFLOATS() as single

    
    Property ACCTTEX() as string

    
    Property ACCTACLO() as string

    
    Property ACCTWMIN() as string

    
    Property ACCTWSC() as string

    
    Property ACCTWINT() as string

    
    Property ACCTSTAT() as string

    
    Property PLINE() as single

    
    Property LLINE() as single

    
    Property UNPOSTED() as single

    
    Property HOLDOUT() as single

    
    Property LSEQ() as single

    
    Property LTRANDATE() as DateTime

    
    Property ADD_DATE() as DateTime

    
    Property CHG_DATE() as DateTime

    
    Property UPD_USER() as string

    
    Property REC_STAT() as Boolean

    
#End Region

End Interface