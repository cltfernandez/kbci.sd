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
'''DAO Class for table Sdpost
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Sdpost
	Inherits LUNA.LunaBaseClassEntity
    Implements _ISdpost
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _ISdpost.FillFromDataRecord
     		if not myRecord("ACCTNO") is DBNull.Value then ACCTNO = myRecord("ACCTNO")
    		if not myRecord("KBCI_NO") is DBNull.Value then KBCI_NO = myRecord("KBCI_NO")
    		if not myRecord("SDNAME") is DBNull.Value then SDNAME = myRecord("SDNAME")
    		if not myRecord("CBEMPNO") is DBNull.Value then CBEMPNO = myRecord("CBEMPNO")
    		if not myRecord("TDATE") is DBNull.Value then TDATE = myRecord("TDATE")
    		if not myRecord("PAMT") is DBNull.Value then PAMT = myRecord("PAMT")
    		if not myRecord("SDSEQ") is DBNull.Value then SDSEQ = myRecord("SDSEQ")
    		if not myRecord("SDTIME") is DBNull.Value then SDTIME = myRecord("SDTIME")
    		if not myRecord("SDBBAL") is DBNull.Value then SDBBAL = myRecord("SDBBAL")
    		if not myRecord("SDEBAL") is DBNull.Value then SDEBAL = myRecord("SDEBAL")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Sdpost)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(SdpostDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Sdpost))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _ACCTNO as string  = "" 
Public Overridable Property ACCTNO() as string  Implements _ISdpost.ACCTNO
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
Public Overridable Property KBCI_NO() as string  Implements _ISdpost.KBCI_NO
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

Protected _SDNAME as string  = "" 
Public Overridable Property SDNAME() as string  Implements _ISdpost.SDNAME
    Get
	    Return _SDNAME
    End Get
    Set (byval value as string)
	    If _SDNAME <> value Then
	        IsChanged = True
	        _SDNAME= value
	    End If
    End Set
End property 

Protected _CBEMPNO as string  = "" 
Public Overridable Property CBEMPNO() as string  Implements _ISdpost.CBEMPNO
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

Protected _TDATE as DateTime  = Nothing 
Public Overridable Property TDATE() as DateTime  Implements _ISdpost.TDATE
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

Protected _PAMT as single  = 0 
Public Overridable Property PAMT() as single  Implements _ISdpost.PAMT
    Get
	    Return _PAMT
    End Get
    Set (byval value as single)
	    If _PAMT <> value Then
	        IsChanged = True
	        _PAMT= value
	    End If
    End Set
End property 

Protected _SDSEQ as single  = 0 
Public Overridable Property SDSEQ() as single  Implements _ISdpost.SDSEQ
    Get
	    Return _SDSEQ
    End Get
    Set (byval value as single)
	    If _SDSEQ <> value Then
	        IsChanged = True
	        _SDSEQ= value
	    End If
    End Set
End property 

Protected _SDTIME as string  = "" 
Public Overridable Property SDTIME() as string  Implements _ISdpost.SDTIME
    Get
	    Return _SDTIME
    End Get
    Set (byval value as string)
	    If _SDTIME <> value Then
	        IsChanged = True
	        _SDTIME= value
	    End If
    End Set
End property 

Protected _SDBBAL as single  = 0 
Public Overridable Property SDBBAL() as single  Implements _ISdpost.SDBBAL
    Get
	    Return _SDBBAL
    End Get
    Set (byval value as single)
	    If _SDBBAL <> value Then
	        IsChanged = True
	        _SDBBAL= value
	    End If
    End Set
End property 

Protected _SDEBAL as single  = 0 
Public Overridable Property SDEBAL() as single  Implements _ISdpost.SDEBAL
    Get
	    Return _SDEBAL
    End Get
    Set (byval value as single)
	    If _SDEBAL <> value Then
	        IsChanged = True
	        _SDEBAL= value
	    End If
    End Set
End property 


#End Region

#Region "Method"
''' <summary>
'''This method read an Sdpost from DB.
''' </summary>
''' <returns>
'''Return 0 if all ok, 1 if error
''' </returns>
Public Overridable Function Read(Id As Integer) As Integer
    'Return 0 if all ok
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Dim int As Sdpost = Manager.Read(Id)
                    _ACCTNO = int.ACCTNO
                    _KBCI_NO = int.KBCI_NO
                    _SDNAME = int.SDNAME
                    _CBEMPNO = int.CBEMPNO
                    _TDATE = int.TDATE
                    _PAMT = int.PAMT
                    _SDSEQ = int.SDSEQ
                    _SDTIME = int.SDTIME
                    _SDBBAL = int.SDBBAL
                    _SDEBAL = int.SDEBAL
        	    End Using
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
	    Ris = 1
    End Try
    Return Ris
End Function

''' <summary>
'''This method save an Sdpost on DB.
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
  if _SDNAME.Length > 40 then Ris = False
  if _CBEMPNO.Length > 6 then Ris = False
  if _SDTIME.Length > 8 then Ris = False

	Return Ris
End Function

#End Region

#Region "Embedded Class"


#End Region

End Class 

''' <summary>
'''Interface for table Sdpost
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _ISdpost

Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

    
    Property ACCTNO() as string

    
    Property KBCI_NO() as string

    
    Property SDNAME() as string

    
    Property CBEMPNO() as string

    
    Property TDATE() as DateTime

    
    Property PAMT() as single

    
    Property SDSEQ() as single

    
    Property SDTIME() as string

    
    Property SDBBAL() as single

    
    Property SDEBAL() as single

    
#End Region

End Interface