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
'''DAO Class for table Divref
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Divref
	Inherits LUNA.LunaBaseClassEntity
    Implements _IDivref
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _IDivref.FillFromDataRecord
     DIVREF_ID = myRecord("DIVREF_ID")
    		if not myRecord("KBCI_NO") is DBNull.Value then KBCI_NO = myRecord("KBCI_NO")
    		if not myRecord("LNAME") is DBNull.Value then LNAME = myRecord("LNAME")
    		if not myRecord("FNAME") is DBNull.Value then FNAME = myRecord("FNAME")
    		if not myRecord("MI") is DBNull.Value then MI = myRecord("MI")
    		if not myRecord("FEBTC_SA") is DBNull.Value then FEBTC_SA = myRecord("FEBTC_SA")
    		if not myRecord("DIVIDEND") is DBNull.Value then DIVIDEND = myRecord("DIVIDEND")
    		if not myRecord("REFUND") is DBNull.Value then REFUND = myRecord("REFUND")
    		if not myRecord("DEDUCTIONS") is DBNull.Value then DEDUCTIONS = myRecord("DEDUCTIONS")
    		if not myRecord("DETAILS") is DBNull.Value then DETAILS = myRecord("DETAILS")
    		if not myRecord("LNDETAIL") is DBNull.Value then LNDETAIL = myRecord("LNDETAIL")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Divref)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(DivrefDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Divref))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _DIVREF_ID as Int64  = Nothing 
Public Overridable Property DIVREF_ID() as Int64  Implements _IDivref.DIVREF_ID
    Get
	    Return _DIVREF_ID
    End Get
    Set (byval value as Int64)
	    If _DIVREF_ID <> value Then
	        IsChanged = True
	        _DIVREF_ID= value
	    End If
    End Set
End property 

Protected _KBCI_NO as string  = "" 
Public Overridable Property KBCI_NO() as string  Implements _IDivref.KBCI_NO
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
Public Overridable Property LNAME() as string  Implements _IDivref.LNAME
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
Public Overridable Property FNAME() as string  Implements _IDivref.FNAME
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
Public Overridable Property MI() as string  Implements _IDivref.MI
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

Protected _FEBTC_SA as string  = "" 
Public Overridable Property FEBTC_SA() as string  Implements _IDivref.FEBTC_SA
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

Protected _DIVIDEND as single  = 0 
Public Overridable Property DIVIDEND() as single  Implements _IDivref.DIVIDEND
    Get
	    Return _DIVIDEND
    End Get
    Set (byval value as single)
	    If _DIVIDEND <> value Then
	        IsChanged = True
	        _DIVIDEND= value
	    End If
    End Set
End property 

Protected _REFUND as single  = 0 
Public Overridable Property REFUND() as single  Implements _IDivref.REFUND
    Get
	    Return _REFUND
    End Get
    Set (byval value as single)
	    If _REFUND <> value Then
	        IsChanged = True
	        _REFUND= value
	    End If
    End Set
End property 

Protected _DEDUCTIONS as single  = 0 
Public Overridable Property DEDUCTIONS() as single  Implements _IDivref.DEDUCTIONS
    Get
	    Return _DEDUCTIONS
    End Get
    Set (byval value as single)
	    If _DEDUCTIONS <> value Then
	        IsChanged = True
	        _DEDUCTIONS= value
	    End If
    End Set
End property 

Protected _DETAILS as string  = "" 
Public Overridable Property DETAILS() as string  Implements _IDivref.DETAILS
    Get
	    Return _DETAILS
    End Get
    Set (byval value as string)
	    If _DETAILS <> value Then
	        IsChanged = True
	        _DETAILS= value
	    End If
    End Set
End property 

Protected _LNDETAIL as string  = "" 
Public Overridable Property LNDETAIL() as string  Implements _IDivref.LNDETAIL
    Get
	    Return _LNDETAIL
    End Get
    Set (byval value as string)
	    If _LNDETAIL <> value Then
	        IsChanged = True
	        _LNDETAIL= value
	    End If
    End Set
End property 


#End Region

#Region "Method"
''' <summary>
'''This method read an Divref from DB.
''' </summary>
''' <returns>
'''Return 0 if all ok, 1 if error
''' </returns>
Public Overridable Function Read(Id As Integer) As Integer
    'Return 0 if all ok
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Dim int As Divref = Manager.Read(Id)
                    _DIVREF_ID = int.DIVREF_ID
                    _KBCI_NO = int.KBCI_NO
                    _LNAME = int.LNAME
                    _FNAME = int.FNAME
                    _MI = int.MI
                    _FEBTC_SA = int.FEBTC_SA
                    _DIVIDEND = int.DIVIDEND
                    _REFUND = int.REFUND
                    _DEDUCTIONS = int.DEDUCTIONS
                    _DETAILS = int.DETAILS
                    _LNDETAIL = int.LNDETAIL
        	    End Using
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
	    Ris = 1
    End Try
    Return Ris
End Function

''' <summary>
'''This method save an Divref on DB.
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
	  if _KBCI_NO.Length > 7 then Ris = False
  if _LNAME.Length > 20 then Ris = False
  if _FNAME.Length > 20 then Ris = False
  if _MI.Length > 1 then Ris = False
  if _FEBTC_SA.Length > 10 then Ris = False
  if _DETAILS.Length > 10 then Ris = False
  if _LNDETAIL.Length > 21 then Ris = False

	Return Ris
End Function

#End Region

#Region "Embedded Class"


#End Region

End Class 

''' <summary>
'''Interface for table Divref
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _IDivref

Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

    
    Property DIVREF_ID() as Int64

    
    Property KBCI_NO() as string

    
    Property LNAME() as string

    
    Property FNAME() as string

    
    Property MI() as string

    
    Property FEBTC_SA() as string

    
    Property DIVIDEND() as single

    
    Property REFUND() as single

    
    Property DEDUCTIONS() as single

    
    Property DETAILS() as string

    
    Property LNDETAIL() as string

    
#End Region

End Interface