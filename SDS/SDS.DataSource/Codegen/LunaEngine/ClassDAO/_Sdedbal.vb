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
'''DAO Class for table Sdedbal
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Sdedbal
	Inherits LUNA.LunaBaseClassEntity
    Implements _ISdedbal
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _ISdedbal.FillFromDataRecord
     SDEDBAL_ID = myRecord("SDEDBAL_ID")
    		if not myRecord("ID") is DBNull.Value then ID = myRecord("ID")
    		if not myRecord("PN_TAG") is DBNull.Value then PN_TAG = myRecord("PN_TAG")
    		if not myRecord("PN_NO") is DBNull.Value then PN_NO = myRecord("PN_NO")
    		if not myRecord("LOAN_TYPE") is DBNull.Value then LOAN_TYPE = myRecord("LOAN_TYPE")
    		if not myRecord("LOAN_STAT") is DBNull.Value then LOAN_STAT = myRecord("LOAN_STAT")
    		if not myRecord("DATE_GRANT") is DBNull.Value then DATE_GRANT = myRecord("DATE_GRANT")
    		if not myRecord("DATE_DUE") is DBNull.Value then DATE_DUE = myRecord("DATE_DUE")
    		if not myRecord("KBCI_NO") is DBNull.Value then KBCI_NO = myRecord("KBCI_NO")
    		if not myRecord("PRINCIPAL") is DBNull.Value then PRINCIPAL = myRecord("PRINCIPAL")
    		if not myRecord("OUTSBAL") is DBNull.Value then OUTSBAL = myRecord("OUTSBAL")
    		if not myRecord("RENEW") is DBNull.Value then RENEW = myRecord("RENEW")
    		if not myRecord("ARREARS") is DBNull.Value then ARREARS = myRecord("ARREARS")
    		if not myRecord("PAY_TAG") is DBNull.Value then PAY_TAG = myRecord("PAY_TAG")
    		if not myRecord("PAY_AMT") is DBNull.Value then PAY_AMT = myRecord("PAY_AMT")
    		if not myRecord("LRI_DUE") is DBNull.Value then LRI_DUE = myRecord("LRI_DUE")
    		if not myRecord("YEARLY_LRI") is DBNull.Value then YEARLY_LRI = myRecord("YEARLY_LRI")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Sdedbal)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(SdedbalDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Sdedbal))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _SDEDBAL_ID as Int64  = Nothing 
Public Overridable Property SDEDBAL_ID() as Int64  Implements _ISdedbal.SDEDBAL_ID
    Get
	    Return _SDEDBAL_ID
    End Get
    Set (byval value as Int64)
	    If _SDEDBAL_ID <> value Then
	        IsChanged = True
	        _SDEDBAL_ID= value
	    End If
    End Set
End property 

Protected _ID as string  = "" 
Public Overridable Property ID() as string  Implements _ISdedbal.ID
    Get
	    Return _ID
    End Get
    Set (byval value as string)
	    If _ID <> value Then
	        IsChanged = True
	        _ID= value
	    End If
    End Set
End property 

Protected _PN_TAG as Boolean  = False 
Public Overridable Property PN_TAG() as Boolean  Implements _ISdedbal.PN_TAG
    Get
	    Return _PN_TAG
    End Get
    Set (byval value as Boolean)
	    If _PN_TAG <> value Then
	        IsChanged = True
	        _PN_TAG= value
	    End If
    End Set
End property 

Protected _PN_NO as string  = "" 
Public Overridable Property PN_NO() as string  Implements _ISdedbal.PN_NO
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

Protected _LOAN_TYPE as string  = "" 
Public Overridable Property LOAN_TYPE() as string  Implements _ISdedbal.LOAN_TYPE
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
Public Overridable Property LOAN_STAT() as string  Implements _ISdedbal.LOAN_STAT
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

Protected _DATE_GRANT as DateTime  = Nothing 
Public Overridable Property DATE_GRANT() as DateTime  Implements _ISdedbal.DATE_GRANT
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

Protected _DATE_DUE as DateTime  = Nothing 
Public Overridable Property DATE_DUE() as DateTime  Implements _ISdedbal.DATE_DUE
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

Protected _KBCI_NO as string  = "" 
Public Overridable Property KBCI_NO() as string  Implements _ISdedbal.KBCI_NO
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

Protected _PRINCIPAL as single  = 0 
Public Overridable Property PRINCIPAL() as single  Implements _ISdedbal.PRINCIPAL
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

Protected _OUTSBAL as single  = 0 
Public Overridable Property OUTSBAL() as single  Implements _ISdedbal.OUTSBAL
    Get
	    Return _OUTSBAL
    End Get
    Set (byval value as single)
	    If _OUTSBAL <> value Then
	        IsChanged = True
	        _OUTSBAL= value
	    End If
    End Set
End property 

Protected _RENEW as Boolean  = False 
Public Overridable Property RENEW() as Boolean  Implements _ISdedbal.RENEW
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

Protected _ARREARS as single  = 0 
Public Overridable Property ARREARS() as single  Implements _ISdedbal.ARREARS
    Get
	    Return _ARREARS
    End Get
    Set (byval value as single)
	    If _ARREARS <> value Then
	        IsChanged = True
	        _ARREARS= value
	    End If
    End Set
End property 

Protected _PAY_TAG as string  = "" 
Public Overridable Property PAY_TAG() as string  Implements _ISdedbal.PAY_TAG
    Get
	    Return _PAY_TAG
    End Get
    Set (byval value as string)
	    If _PAY_TAG <> value Then
	        IsChanged = True
	        _PAY_TAG= value
	    End If
    End Set
End property 

Protected _PAY_AMT as single  = 0 
Public Overridable Property PAY_AMT() as single  Implements _ISdedbal.PAY_AMT
    Get
	    Return _PAY_AMT
    End Get
    Set (byval value as single)
	    If _PAY_AMT <> value Then
	        IsChanged = True
	        _PAY_AMT= value
	    End If
    End Set
End property 

Protected _LRI_DUE as single  = 0 
Public Overridable Property LRI_DUE() as single  Implements _ISdedbal.LRI_DUE
    Get
	    Return _LRI_DUE
    End Get
    Set (byval value as single)
	    If _LRI_DUE <> value Then
	        IsChanged = True
	        _LRI_DUE= value
	    End If
    End Set
End property 

Protected _YEARLY_LRI as single  = 0 
Public Overridable Property YEARLY_LRI() as single  Implements _ISdedbal.YEARLY_LRI
    Get
	    Return _YEARLY_LRI
    End Get
    Set (byval value as single)
	    If _YEARLY_LRI <> value Then
	        IsChanged = True
	        _YEARLY_LRI= value
	    End If
    End Set
End property 


#End Region

#Region "Method"
''' <summary>
'''This method read an Sdedbal from DB.
''' </summary>
''' <returns>
'''Return 0 if all ok, 1 if error
''' </returns>
Public Overridable Function Read(Id As Integer) As Integer
    'Return 0 if all ok
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Dim int As Sdedbal = Manager.Read(Id)
                    _SDEDBAL_ID = int.SDEDBAL_ID
                    _ID = int.ID
                    _PN_TAG = int.PN_TAG
                    _PN_NO = int.PN_NO
                    _LOAN_TYPE = int.LOAN_TYPE
                    _LOAN_STAT = int.LOAN_STAT
                    _DATE_GRANT = int.DATE_GRANT
                    _DATE_DUE = int.DATE_DUE
                    _KBCI_NO = int.KBCI_NO
                    _PRINCIPAL = int.PRINCIPAL
                    _OUTSBAL = int.OUTSBAL
                    _RENEW = int.RENEW
                    _ARREARS = int.ARREARS
                    _PAY_TAG = int.PAY_TAG
                    _PAY_AMT = int.PAY_AMT
                    _LRI_DUE = int.LRI_DUE
                    _YEARLY_LRI = int.YEARLY_LRI
        	    End Using
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
	    Ris = 1
    End Try
    Return Ris
End Function

''' <summary>
'''This method save an Sdedbal on DB.
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
	  if _ID.Length > 22 then Ris = False
  if _PN_NO.Length > 7 then Ris = False
  if _LOAN_TYPE.Length > 3 then Ris = False
  if _LOAN_STAT.Length > 1 then Ris = False
  if _KBCI_NO.Length > 7 then Ris = False
  if _PAY_TAG.Length > 1 then Ris = False

	Return Ris
End Function

#End Region

#Region "Embedded Class"


#End Region

End Class 

''' <summary>
'''Interface for table Sdedbal
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _ISdedbal

Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

    
    Property SDEDBAL_ID() as Int64

    
    Property ID() as string

    
    Property PN_TAG() as Boolean

    
    Property PN_NO() as string

    
    Property LOAN_TYPE() as string

    
    Property LOAN_STAT() as string

    
    Property DATE_GRANT() as DateTime

    
    Property DATE_DUE() as DateTime

    
    Property KBCI_NO() as string

    
    Property PRINCIPAL() as single

    
    Property OUTSBAL() as single

    
    Property RENEW() as Boolean

    
    Property ARREARS() as single

    
    Property PAY_TAG() as string

    
    Property PAY_AMT() as single

    
    Property LRI_DUE() as single

    
    Property YEARLY_LRI() as single

    
#End Region

End Interface