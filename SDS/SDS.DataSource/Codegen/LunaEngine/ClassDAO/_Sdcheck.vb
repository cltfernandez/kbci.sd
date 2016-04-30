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
'''DAO Class for table Sdcheck
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Sdcheck
	Inherits LUNA.LunaBaseClassEntity
    Implements _ISdcheck
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _ISdcheck.FillFromDataRecord
     SDCHECK_ID = myRecord("SDCHECK_ID")
    		if not myRecord("ACCTNUM") is DBNull.Value then ACCTNUM = myRecord("ACCTNUM")
    		if not myRecord("TRANDATE") is DBNull.Value then TRANDATE = myRecord("TRANDATE")
    		if not myRecord("TRANSEQ") is DBNull.Value then TRANSEQ = myRecord("TRANSEQ")
    		if not myRecord("CHKCODE") is DBNull.Value then CHKCODE = myRecord("CHKCODE")
    		if not myRecord("CHKAMT") is DBNull.Value then CHKAMT = myRecord("CHKAMT")
    		if not myRecord("CHKNUM") is DBNull.Value then CHKNUM = myRecord("CHKNUM")
    		if not myRecord("CHKBANK") is DBNull.Value then CHKBANK = myRecord("CHKBANK")
    		if not myRecord("CHKCDATE") is DBNull.Value then CHKCDATE = myRecord("CHKCDATE")
    		if not myRecord("CHKCDAYS") is DBNull.Value then CHKCDAYS = myRecord("CHKCDAYS")
    		if not myRecord("CHKNDAYS") is DBNull.Value then CHKNDAYS = myRecord("CHKNDAYS")
    		if not myRecord("CHKSTAT") is DBNull.Value then CHKSTAT = myRecord("CHKSTAT")
    		if not myRecord("ADD_DATE") is DBNull.Value then ADD_DATE = myRecord("ADD_DATE")
    		if not myRecord("ADD_TIME") is DBNull.Value then ADD_TIME = myRecord("ADD_TIME")
    		if not myRecord("USER") is DBNull.Value then USER = myRecord("USER")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Sdcheck)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(SdcheckDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Sdcheck))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _SDCHECK_ID as Int64  = Nothing 
Public Overridable Property SDCHECK_ID() as Int64  Implements _ISdcheck.SDCHECK_ID
    Get
	    Return _SDCHECK_ID
    End Get
    Set (byval value as Int64)
	    If _SDCHECK_ID <> value Then
	        IsChanged = True
	        _SDCHECK_ID= value
	    End If
    End Set
End property 

Protected _ACCTNUM as string  = "" 
Public Overridable Property ACCTNUM() as string  Implements _ISdcheck.ACCTNUM
    Get
	    Return _ACCTNUM
    End Get
    Set (byval value as string)
	    If _ACCTNUM <> value Then
	        IsChanged = True
	        _ACCTNUM= value
	    End If
    End Set
End property 

Protected _TRANDATE as DateTime  = Nothing 
Public Overridable Property TRANDATE() as DateTime  Implements _ISdcheck.TRANDATE
    Get
	    Return _TRANDATE
    End Get
    Set (byval value as DateTime)
	    If _TRANDATE <> value Then
	        IsChanged = True
	        _TRANDATE= value
	    End If
    End Set
End property 

Protected _TRANSEQ as single  = 0 
Public Overridable Property TRANSEQ() as single  Implements _ISdcheck.TRANSEQ
    Get
	    Return _TRANSEQ
    End Get
    Set (byval value as single)
	    If _TRANSEQ <> value Then
	        IsChanged = True
	        _TRANSEQ= value
	    End If
    End Set
End property 

Protected _CHKCODE as string  = "" 
Public Overridable Property CHKCODE() as string  Implements _ISdcheck.CHKCODE
    Get
	    Return _CHKCODE
    End Get
    Set (byval value as string)
	    If _CHKCODE <> value Then
	        IsChanged = True
	        _CHKCODE= value
	    End If
    End Set
End property 

Protected _CHKAMT as single  = 0 
Public Overridable Property CHKAMT() as single  Implements _ISdcheck.CHKAMT
    Get
	    Return _CHKAMT
    End Get
    Set (byval value as single)
	    If _CHKAMT <> value Then
	        IsChanged = True
	        _CHKAMT= value
	    End If
    End Set
End property 

Protected _CHKNUM as string  = "" 
Public Overridable Property CHKNUM() as string  Implements _ISdcheck.CHKNUM
    Get
	    Return _CHKNUM
    End Get
    Set (byval value as string)
	    If _CHKNUM <> value Then
	        IsChanged = True
	        _CHKNUM= value
	    End If
    End Set
End property 

Protected _CHKBANK as string  = "" 
Public Overridable Property CHKBANK() as string  Implements _ISdcheck.CHKBANK
    Get
	    Return _CHKBANK
    End Get
    Set (byval value as string)
	    If _CHKBANK <> value Then
	        IsChanged = True
	        _CHKBANK= value
	    End If
    End Set
End property 

Protected _CHKCDATE as DateTime  = Nothing 
Public Overridable Property CHKCDATE() as DateTime  Implements _ISdcheck.CHKCDATE
    Get
	    Return _CHKCDATE
    End Get
    Set (byval value as DateTime)
	    If _CHKCDATE <> value Then
	        IsChanged = True
	        _CHKCDATE= value
	    End If
    End Set
End property 

Protected _CHKCDAYS as single  = 0 
Public Overridable Property CHKCDAYS() as single  Implements _ISdcheck.CHKCDAYS
    Get
	    Return _CHKCDAYS
    End Get
    Set (byval value as single)
	    If _CHKCDAYS <> value Then
	        IsChanged = True
	        _CHKCDAYS= value
	    End If
    End Set
End property 

Protected _CHKNDAYS as single  = 0 
Public Overridable Property CHKNDAYS() as single  Implements _ISdcheck.CHKNDAYS
    Get
	    Return _CHKNDAYS
    End Get
    Set (byval value as single)
	    If _CHKNDAYS <> value Then
	        IsChanged = True
	        _CHKNDAYS= value
	    End If
    End Set
End property 

Protected _CHKSTAT as string  = "" 
Public Overridable Property CHKSTAT() as string  Implements _ISdcheck.CHKSTAT
    Get
	    Return _CHKSTAT
    End Get
    Set (byval value as string)
	    If _CHKSTAT <> value Then
	        IsChanged = True
	        _CHKSTAT= value
	    End If
    End Set
End property 

Protected _ADD_DATE as DateTime  = Nothing 
Public Overridable Property ADD_DATE() as DateTime  Implements _ISdcheck.ADD_DATE
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

Protected _ADD_TIME as string  = "" 
Public Overridable Property ADD_TIME() as string  Implements _ISdcheck.ADD_TIME
    Get
	    Return _ADD_TIME
    End Get
    Set (byval value as string)
	    If _ADD_TIME <> value Then
	        IsChanged = True
	        _ADD_TIME= value
	    End If
    End Set
End property 

Protected _USER as string  = "" 
Public Overridable Property USER() as string  Implements _ISdcheck.USER
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


#End Region

#Region "Method"
''' <summary>
'''This method read an Sdcheck from DB.
''' </summary>
''' <returns>
'''Return 0 if all ok, 1 if error
''' </returns>
Public Overridable Function Read(Id As Integer) As Integer
    'Return 0 if all ok
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Dim int As Sdcheck = Manager.Read(Id)
                    _SDCHECK_ID = int.SDCHECK_ID
                    _ACCTNUM = int.ACCTNUM
                    _TRANDATE = int.TRANDATE
                    _TRANSEQ = int.TRANSEQ
                    _CHKCODE = int.CHKCODE
                    _CHKAMT = int.CHKAMT
                    _CHKNUM = int.CHKNUM
                    _CHKBANK = int.CHKBANK
                    _CHKCDATE = int.CHKCDATE
                    _CHKCDAYS = int.CHKCDAYS
                    _CHKNDAYS = int.CHKNDAYS
                    _CHKSTAT = int.CHKSTAT
                    _ADD_DATE = int.ADD_DATE
                    _ADD_TIME = int.ADD_TIME
                    _USER = int.USER
        	    End Using
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
	    Ris = 1
    End Try
    Return Ris
End Function

''' <summary>
'''This method save an Sdcheck on DB.
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
	  if _ACCTNUM.Length > 10 then Ris = False
  if _CHKCODE.Length > 3 then Ris = False
  if _CHKNUM.Length > 15 then Ris = False
  if _CHKBANK.Length > 10 then Ris = False
  if _CHKSTAT.Length > 3 then Ris = False
  if _ADD_TIME.Length > 8 then Ris = False
  if _USER.Length > 8 then Ris = False

	Return Ris
End Function

#End Region

#Region "Embedded Class"


#End Region

End Class 

''' <summary>
'''Interface for table Sdcheck
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _ISdcheck

Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

    
    Property SDCHECK_ID() as Int64

    
    Property ACCTNUM() as string

    
    Property TRANDATE() as DateTime

    
    Property TRANSEQ() as single

    
    Property CHKCODE() as string

    
    Property CHKAMT() as single

    
    Property CHKNUM() as string

    
    Property CHKBANK() as string

    
    Property CHKCDATE() as DateTime

    
    Property CHKCDAYS() as single

    
    Property CHKNDAYS() as single

    
    Property CHKSTAT() as string

    
    Property ADD_DATE() as DateTime

    
    Property ADD_TIME() as string

    
    Property USER() as string

    
#End Region

End Interface