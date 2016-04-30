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
'''DAO Class for table Sd
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Sd
	Inherits LUNA.LunaBaseClassEntity
    Implements _ISd
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _ISd.FillFromDataRecord
     SD_ID = myRecord("SD_ID")
    		if not myRecord("KBCI_NO") is DBNull.Value then KBCI_NO = myRecord("KBCI_NO")
    		if not myRecord("FEBTC_SA") is DBNull.Value then FEBTC_SA = myRecord("FEBTC_SA")
    		if not myRecord("TRAN_CODE") is DBNull.Value then TRAN_CODE = myRecord("TRAN_CODE")
        If Not myRecord("DATE") Is DBNull.Value Then SDDATE = myRecord("DATE")
    		if not myRecord("REF") is DBNull.Value then REF = myRecord("REF")
    		if not myRecord("AMOUNT") is DBNull.Value then AMOUNT = myRecord("AMOUNT")
    		if not myRecord("BALANCE") is DBNull.Value then BALANCE = myRecord("BALANCE")
    		if not myRecord("RMK") is DBNull.Value then RMK = myRecord("RMK")
    		if not myRecord("ADD_DATE") is DBNull.Value then ADD_DATE = myRecord("ADD_DATE")
    		if not myRecord("USER") is DBNull.Value then USER = myRecord("USER")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Sd)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(SdDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Sd))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _SD_ID as Int64  = Nothing 
Public Overridable Property SD_ID() as Int64  Implements _ISd.SD_ID
    Get
	    Return _SD_ID
    End Get
    Set (byval value as Int64)
	    If _SD_ID <> value Then
	        IsChanged = True
	        _SD_ID= value
	    End If
    End Set
End property 

Protected _KBCI_NO as string  = "" 
Public Overridable Property KBCI_NO() as string  Implements _ISd.KBCI_NO
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

Protected _FEBTC_SA as string  = "" 
Public Overridable Property FEBTC_SA() as string  Implements _ISd.FEBTC_SA
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

Protected _TRAN_CODE as string  = "" 
Public Overridable Property TRAN_CODE() as string  Implements _ISd.TRAN_CODE
    Get
	    Return _TRAN_CODE
    End Get
    Set (byval value as string)
	    If _TRAN_CODE <> value Then
	        IsChanged = True
	        _TRAN_CODE= value
	    End If
    End Set
End property 

Protected _DATE as DateTime  = Nothing 
    Public Overridable Property SDDATE() As DateTime Implements _ISd.SDDATE
        Get
            Return _DATE
        End Get
        Set(ByVal value As DateTime)
            If _DATE <> value Then
                IsChanged = True
                _DATE = value
            End If
        End Set
    End Property

Protected _REF as string  = "" 
Public Overridable Property REF() as string  Implements _ISd.REF
    Get
	    Return _REF
    End Get
    Set (byval value as string)
	    If _REF <> value Then
	        IsChanged = True
	        _REF= value
	    End If
    End Set
End property 

Protected _AMOUNT as single  = 0 
Public Overridable Property AMOUNT() as single  Implements _ISd.AMOUNT
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

Protected _BALANCE as single  = 0 
Public Overridable Property BALANCE() as single  Implements _ISd.BALANCE
    Get
	    Return _BALANCE
    End Get
    Set (byval value as single)
	    If _BALANCE <> value Then
	        IsChanged = True
	        _BALANCE= value
	    End If
    End Set
End property 

Protected _RMK as string  = "" 
Public Overridable Property RMK() as string  Implements _ISd.RMK
    Get
	    Return _RMK
    End Get
    Set (byval value as string)
	    If _RMK <> value Then
	        IsChanged = True
	        _RMK= value
	    End If
    End Set
End property 

Protected _ADD_DATE as DateTime  = Nothing 
Public Overridable Property ADD_DATE() as DateTime  Implements _ISd.ADD_DATE
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

Protected _USER as string  = "" 
Public Overridable Property USER() as string  Implements _ISd.USER
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
'''This method read an Sd from DB.
''' </summary>
''' <returns>
'''Return 0 if all ok, 1 if error
''' </returns>
Public Overridable Function Read(Id As Integer) As Integer
    'Return 0 if all ok
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Dim int As Sd = Manager.Read(Id)
                    _SD_ID = int.SD_ID
                    _KBCI_NO = int.KBCI_NO
                    _FEBTC_SA = int.FEBTC_SA
                    _TRAN_CODE = int.TRAN_CODE
                _DATE = int.SDDATE
                    _REF = int.REF
                    _AMOUNT = int.AMOUNT
                    _BALANCE = int.BALANCE
                    _RMK = int.RMK
                    _ADD_DATE = int.ADD_DATE
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
'''This method save an Sd on DB.
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
  if _FEBTC_SA.Length > 10 then Ris = False
  if _TRAN_CODE.Length > 1 then Ris = False
  if _REF.Length > 10 then Ris = False
  if _RMK.Length > 40 then Ris = False
  if _USER.Length > 8 then Ris = False

	Return Ris
End Function

#End Region

#Region "Embedded Class"


#End Region

End Class 

''' <summary>
'''Interface for table Sd
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _ISd

Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

    
    Property SD_ID() as Int64

    
    Property KBCI_NO() as string

    
    Property FEBTC_SA() as string

    
    Property TRAN_CODE() as string

    
    Property SDDATE() As DateTime

    
    Property REF() as string

    
    Property AMOUNT() as single

    
    Property BALANCE() as single

    
    Property RMK() as string

    
    Property ADD_DATE() as DateTime

    
    Property USER() as string

    
#End Region

End Interface