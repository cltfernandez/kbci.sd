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
'''DAO Class for table Advance
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Advance
	Inherits LUNA.LunaBaseClassEntity
    Implements _IAdvance
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _IAdvance.FillFromDataRecord
     ADVANCE_ID = myRecord("ADVANCE_ID")
    		if not myRecord("PN_NO") is DBNull.Value then PN_NO = myRecord("PN_NO")
    		if not myRecord("KBCI_NO") is DBNull.Value then KBCI_NO = myRecord("KBCI_NO")
    		if not myRecord("LOAN_TYPE") is DBNull.Value then LOAN_TYPE = myRecord("LOAN_TYPE")
    		if not myRecord("ADD_DATE") is DBNull.Value then ADD_DATE = myRecord("ADD_DATE")
    		if not myRecord("CHG_DATE") is DBNull.Value then CHG_DATE = myRecord("CHG_DATE")
    		if not myRecord("USER") is DBNull.Value then USER = myRecord("USER")
    		if not myRecord("AMOUNT") is DBNull.Value then AMOUNT = myRecord("AMOUNT")
    		if not myRecord("REMARKS") is DBNull.Value then REMARKS = myRecord("REMARKS")
    		if not myRecord("SAVINGS") is DBNull.Value then SAVINGS = myRecord("SAVINGS")
    		if not myRecord("ACCTNO") is DBNull.Value then ACCTNO = myRecord("ACCTNO")
    		if not myRecord("STATUS") is DBNull.Value then STATUS = myRecord("STATUS")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Advance)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(AdvanceDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Advance))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _ADVANCE_ID as Int64  = Nothing 
Public Overridable Property ADVANCE_ID() as Int64  Implements _IAdvance.ADVANCE_ID
    Get
	    Return _ADVANCE_ID
    End Get
    Set (byval value as Int64)
	    If _ADVANCE_ID <> value Then
	        IsChanged = True
	        _ADVANCE_ID= value
	    End If
    End Set
End property 

Protected _PN_NO as string  = "" 
Public Overridable Property PN_NO() as string  Implements _IAdvance.PN_NO
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
Public Overridable Property KBCI_NO() as string  Implements _IAdvance.KBCI_NO
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

Protected _LOAN_TYPE as string  = "" 
Public Overridable Property LOAN_TYPE() as string  Implements _IAdvance.LOAN_TYPE
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

Protected _ADD_DATE as DateTime  = Nothing 
Public Overridable Property ADD_DATE() as DateTime  Implements _IAdvance.ADD_DATE
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
Public Overridable Property CHG_DATE() as DateTime  Implements _IAdvance.CHG_DATE
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
Public Overridable Property USER() as string  Implements _IAdvance.USER
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

Protected _AMOUNT as single  = 0 
Public Overridable Property AMOUNT() as single  Implements _IAdvance.AMOUNT
    Get
	    Return _AMOUNT
    End Get
    Set (byval value as single)
	    If _AMOUNT <> value Then
	        IsChanged = True
	        _AMOUNT= value
	    End If
    End Set
End property 

Protected _REMARKS as string  = "" 
Public Overridable Property REMARKS() as string  Implements _IAdvance.REMARKS
    Get
	    Return _REMARKS
    End Get
    Set (byval value as string)
	    If _REMARKS <> value Then
	        IsChanged = True
	        _REMARKS= value
	    End If
    End Set
End property 

Protected _SAVINGS as Boolean  = False 
Public Overridable Property SAVINGS() as Boolean  Implements _IAdvance.SAVINGS
    Get
	    Return _SAVINGS
    End Get
    Set (byval value as Boolean)
	    If _SAVINGS <> value Then
	        IsChanged = True
	        _SAVINGS= value
	    End If
    End Set
End property 

Protected _ACCTNO as string  = "" 
Public Overridable Property ACCTNO() as string  Implements _IAdvance.ACCTNO
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

Protected _STATUS as string  = "" 
Public Overridable Property STATUS() as string  Implements _IAdvance.STATUS
    Get
	    Return _STATUS
    End Get
    Set (byval value as string)
	    If _STATUS <> value Then
	        IsChanged = True
	        _STATUS= value
	    End If
    End Set
End property 


#End Region

#Region "Method"
''' <summary>
'''This method read an Advance from DB.
''' </summary>
''' <returns>
'''Return 0 if all ok, 1 if error
''' </returns>
Public Overridable Function Read(Id As Integer) As Integer
    'Return 0 if all ok
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Dim int As Advance = Manager.Read(Id)
                    _ADVANCE_ID = int.ADVANCE_ID
                    _PN_NO = int.PN_NO
                    _KBCI_NO = int.KBCI_NO
                    _LOAN_TYPE = int.LOAN_TYPE
                    _ADD_DATE = int.ADD_DATE
                    _CHG_DATE = int.CHG_DATE
                    _USER = int.USER
                    _AMOUNT = int.AMOUNT
                    _REMARKS = int.REMARKS
                    _SAVINGS = int.SAVINGS
                    _ACCTNO = int.ACCTNO
                    _STATUS = int.STATUS
        	    End Using
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
	    Ris = 1
    End Try
    Return Ris
End Function

''' <summary>
'''This method save an Advance on DB.
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
  if _LOAN_TYPE.Length > 3 then Ris = False
  if _USER.Length > 8 then Ris = False
  if _REMARKS.Length > 60 then Ris = False
  if _ACCTNO.Length > 10 then Ris = False
  if _STATUS.Length > 1 then Ris = False

	Return Ris
End Function

#End Region

#Region "Embedded Class"


#End Region

End Class 

''' <summary>
'''Interface for table Advance
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _IAdvance

Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

    
    Property ADVANCE_ID() as Int64

    
    Property PN_NO() as string

    
    Property KBCI_NO() as string

    
    Property LOAN_TYPE() as string

    
    Property ADD_DATE() as DateTime

    
    Property CHG_DATE() as DateTime

    
    Property USER() as string

    
    Property AMOUNT() as single

    
    Property REMARKS() as string

    
    Property SAVINGS() as Boolean

    
    Property ACCTNO() as string

    
    Property STATUS() as string

    
#End Region

End Interface