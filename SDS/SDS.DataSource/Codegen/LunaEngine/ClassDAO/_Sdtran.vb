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
'''DAO Class for table Sdtran
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Sdtran
	Inherits LUNA.LunaBaseClassEntity
    Implements _ISdtran
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _ISdtran.FillFromDataRecord
     SDTRAN_ID = myRecord("SDTRAN_ID")
    		if not myRecord("ACCTNUM") is DBNull.Value then ACCTNUM = myRecord("ACCTNUM")
    		if not myRecord("TRANDATE") is DBNull.Value then TRANDATE = myRecord("TRANDATE")
    		if not myRecord("TRANSEQ") is DBNull.Value then TRANSEQ = myRecord("TRANSEQ")
    		if not myRecord("TRANCODE") is DBNull.Value then TRANCODE = myRecord("TRANCODE")
    		if not myRecord("TRANBBAL") is DBNull.Value then TRANBBAL = myRecord("TRANBBAL")
    		if not myRecord("TRANDEB") is DBNull.Value then TRANDEB = myRecord("TRANDEB")
    		if not myRecord("TRANCRE") is DBNull.Value then TRANCRE = myRecord("TRANCRE")
    		if not myRecord("TRANEBAL") is DBNull.Value then TRANEBAL = myRecord("TRANEBAL")
    		if not myRecord("CHKNUM") is DBNull.Value then CHKNUM = myRecord("CHKNUM")
    		if not myRecord("CHKBANK") is DBNull.Value then CHKBANK = myRecord("CHKBANK")
    		if not myRecord("CHKCODE") is DBNull.Value then CHKCODE = myRecord("CHKCODE")
    		if not myRecord("ADD_DATE") is DBNull.Value then ADD_DATE = myRecord("ADD_DATE")
    		if not myRecord("ADD_TIME") is DBNull.Value then ADD_TIME = myRecord("ADD_TIME")
    		if not myRecord("USER") is DBNull.Value then USER = myRecord("USER")
    		if not myRecord("OVERRIDE") is DBNull.Value then OVERRIDE = myRecord("OVERRIDE")
    		if not myRecord("PPOSTED") is DBNull.Value then PPOSTED = myRecord("PPOSTED")
    		if not myRecord("LPOSTED") is DBNull.Value then LPOSTED = myRecord("LPOSTED")
    		if not myRecord("TRANOLD") is DBNull.Value then TRANOLD = myRecord("TRANOLD")
    		if not myRecord("REVERSED") is DBNull.Value then REVERSED = myRecord("REVERSED")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Sdtran)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(SdtranDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Sdtran))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _SDTRAN_ID as Int64  = Nothing 
Public Overridable Property SDTRAN_ID() as Int64  Implements _ISdtran.SDTRAN_ID
    Get
	    Return _SDTRAN_ID
    End Get
    Set (byval value as Int64)
	    If _SDTRAN_ID <> value Then
	        IsChanged = True
	        _SDTRAN_ID= value
	    End If
    End Set
End property 

Protected _ACCTNUM as string  = "" 
Public Overridable Property ACCTNUM() as string  Implements _ISdtran.ACCTNUM
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
Public Overridable Property TRANDATE() as DateTime  Implements _ISdtran.TRANDATE
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
Public Overridable Property TRANSEQ() as single  Implements _ISdtran.TRANSEQ
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

Protected _TRANCODE as string  = "" 
Public Overridable Property TRANCODE() as string  Implements _ISdtran.TRANCODE
    Get
	    Return _TRANCODE
    End Get
    Set (byval value as string)
	    If _TRANCODE <> value Then
	        IsChanged = True
	        _TRANCODE= value
	    End If
    End Set
End property 

Protected _TRANBBAL as single  = 0 
Public Overridable Property TRANBBAL() as single  Implements _ISdtran.TRANBBAL
    Get
	    Return _TRANBBAL
    End Get
    Set (byval value as single)
	    If _TRANBBAL <> value Then
	        IsChanged = True
	        _TRANBBAL= value
	    End If
    End Set
End property 

Protected _TRANDEB as single  = 0 
Public Overridable Property TRANDEB() as single  Implements _ISdtran.TRANDEB
    Get
	    Return _TRANDEB
    End Get
    Set (byval value as single)
	    If _TRANDEB <> value Then
	        IsChanged = True
	        _TRANDEB= value
	    End If
    End Set
End property 

Protected _TRANCRE as single  = 0 
Public Overridable Property TRANCRE() as single  Implements _ISdtran.TRANCRE
    Get
	    Return _TRANCRE
    End Get
    Set (byval value as single)
	    If _TRANCRE <> value Then
	        IsChanged = True
	        _TRANCRE= value
	    End If
    End Set
End property 

Protected _TRANEBAL as single  = 0 
Public Overridable Property TRANEBAL() as single  Implements _ISdtran.TRANEBAL
    Get
	    Return _TRANEBAL
    End Get
    Set (byval value as single)
	    If _TRANEBAL <> value Then
	        IsChanged = True
	        _TRANEBAL= value
	    End If
    End Set
End property 

Protected _CHKNUM as string  = "" 
Public Overridable Property CHKNUM() as string  Implements _ISdtran.CHKNUM
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
Public Overridable Property CHKBANK() as string  Implements _ISdtran.CHKBANK
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

Protected _CHKCODE as string  = "" 
Public Overridable Property CHKCODE() as string  Implements _ISdtran.CHKCODE
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

Protected _ADD_DATE as DateTime  = Nothing 
Public Overridable Property ADD_DATE() as DateTime  Implements _ISdtran.ADD_DATE
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
Public Overridable Property ADD_TIME() as string  Implements _ISdtran.ADD_TIME
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
Public Overridable Property USER() as string  Implements _ISdtran.USER
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

Protected _OVERRIDE as string  = "" 
Public Overridable Property OVERRIDE() as string  Implements _ISdtran.OVERRIDE
    Get
	    Return _OVERRIDE
    End Get
    Set (byval value as string)
	    If _OVERRIDE <> value Then
	        IsChanged = True
	        _OVERRIDE= value
	    End If
    End Set
End property 

Protected _PPOSTED as Boolean  = False 
Public Overridable Property PPOSTED() as Boolean  Implements _ISdtran.PPOSTED
    Get
	    Return _PPOSTED
    End Get
    Set (byval value as Boolean)
	    If _PPOSTED <> value Then
	        IsChanged = True
	        _PPOSTED= value
	    End If
    End Set
End property 

Protected _LPOSTED as Boolean  = False 
Public Overridable Property LPOSTED() as Boolean  Implements _ISdtran.LPOSTED
    Get
	    Return _LPOSTED
    End Get
    Set (byval value as Boolean)
	    If _LPOSTED <> value Then
	        IsChanged = True
	        _LPOSTED= value
	    End If
    End Set
End property 

Protected _TRANOLD as Boolean  = False 
Public Overridable Property TRANOLD() as Boolean  Implements _ISdtran.TRANOLD
    Get
	    Return _TRANOLD
    End Get
    Set (byval value as Boolean)
	    If _TRANOLD <> value Then
	        IsChanged = True
	        _TRANOLD= value
	    End If
    End Set
End property 

Protected _REVERSED as Boolean  = False 
Public Overridable Property REVERSED() as Boolean  Implements _ISdtran.REVERSED
    Get
	    Return _REVERSED
    End Get
    Set (byval value as Boolean)
	    If _REVERSED <> value Then
	        IsChanged = True
	        _REVERSED= value
	    End If
    End Set
End property 


#End Region

#Region "Method"
''' <summary>
'''This method read an Sdtran from DB.
''' </summary>
''' <returns>
'''Return 0 if all ok, 1 if error
''' </returns>
Public Overridable Function Read(Id As Integer) As Integer
    'Return 0 if all ok
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Dim int As Sdtran = Manager.Read(Id)
                    _SDTRAN_ID = int.SDTRAN_ID
                    _ACCTNUM = int.ACCTNUM
                    _TRANDATE = int.TRANDATE
                    _TRANSEQ = int.TRANSEQ
                    _TRANCODE = int.TRANCODE
                    _TRANBBAL = int.TRANBBAL
                    _TRANDEB = int.TRANDEB
                    _TRANCRE = int.TRANCRE
                    _TRANEBAL = int.TRANEBAL
                    _CHKNUM = int.CHKNUM
                    _CHKBANK = int.CHKBANK
                    _CHKCODE = int.CHKCODE
                    _ADD_DATE = int.ADD_DATE
                    _ADD_TIME = int.ADD_TIME
                    _USER = int.USER
                    _OVERRIDE = int.OVERRIDE
                    _PPOSTED = int.PPOSTED
                    _LPOSTED = int.LPOSTED
                    _TRANOLD = int.TRANOLD
                    _REVERSED = int.REVERSED
        	    End Using
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
	    Ris = 1
    End Try
    Return Ris
End Function

''' <summary>
'''This method save an Sdtran on DB.
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
  if _TRANCODE.Length > 3 then Ris = False
  if _CHKNUM.Length > 30 then Ris = False
  if _CHKBANK.Length > 10 then Ris = False
  if _CHKCODE.Length > 3 then Ris = False
  if _ADD_TIME.Length > 8 then Ris = False
  if _USER.Length > 8 then Ris = False
  if _OVERRIDE.Length > 8 then Ris = False

	Return Ris
End Function

#End Region

#Region "Embedded Class"


#End Region

End Class 

''' <summary>
'''Interface for table Sdtran
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _ISdtran

Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

    
    Property SDTRAN_ID() as Int64

    
    Property ACCTNUM() as string

    
    Property TRANDATE() as DateTime

    
    Property TRANSEQ() as single

    
    Property TRANCODE() as string

    
    Property TRANBBAL() as single

    
    Property TRANDEB() as single

    
    Property TRANCRE() as single

    
    Property TRANEBAL() as single

    
    Property CHKNUM() as string

    
    Property CHKBANK() as string

    
    Property CHKCODE() as string

    
    Property ADD_DATE() as DateTime

    
    Property ADD_TIME() as string

    
    Property USER() as string

    
    Property OVERRIDE() as string

    
    Property PPOSTED() as Boolean

    
    Property LPOSTED() as Boolean

    
    Property TRANOLD() as Boolean

    
    Property REVERSED() as Boolean

    
#End Region

End Interface