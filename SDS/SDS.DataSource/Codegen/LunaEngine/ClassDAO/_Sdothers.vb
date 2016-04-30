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
'''DAO Class for table Sdothers
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Sdothers
	Inherits LUNA.LunaBaseClassEntity
    Implements _ISdothers
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _ISdothers.FillFromDataRecord
     SDOTHERS_ID = myRecord("SDOTHERS_ID")
    		if not myRecord("OTHDATE") is DBNull.Value then OTHDATE = myRecord("OTHDATE")
    		if not myRecord("OTHTIME") is DBNull.Value then OTHTIME = myRecord("OTHTIME")
    		if not myRecord("OTHNAME") is DBNull.Value then OTHNAME = myRecord("OTHNAME")
    		if not myRecord("OTHAMOUNT") is DBNull.Value then OTHAMOUNT = myRecord("OTHAMOUNT")
    		if not myRecord("OTHTYPE") is DBNull.Value then OTHTYPE = myRecord("OTHTYPE")
    		if not myRecord("OTHBANK") is DBNull.Value then OTHBANK = myRecord("OTHBANK")
    		if not myRecord("OTHCHKNO") is DBNull.Value then OTHCHKNO = myRecord("OTHCHKNO")
    		if not myRecord("OTHUSER") is DBNull.Value then OTHUSER = myRecord("OTHUSER")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Sdothers)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(SdothersDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Sdothers))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _SDOTHERS_ID as Int64  = Nothing 
Public Overridable Property SDOTHERS_ID() as Int64  Implements _ISdothers.SDOTHERS_ID
    Get
	    Return _SDOTHERS_ID
    End Get
    Set (byval value as Int64)
	    If _SDOTHERS_ID <> value Then
	        IsChanged = True
	        _SDOTHERS_ID= value
	    End If
    End Set
End property 

Protected _OTHDATE as DateTime  = Nothing 
Public Overridable Property OTHDATE() as DateTime  Implements _ISdothers.OTHDATE
    Get
	    Return _OTHDATE
    End Get
    Set (byval value as DateTime)
	    If _OTHDATE <> value Then
	        IsChanged = True
	        _OTHDATE= value
	    End If
    End Set
End property 

Protected _OTHTIME as string  = "" 
Public Overridable Property OTHTIME() as string  Implements _ISdothers.OTHTIME
    Get
	    Return _OTHTIME
    End Get
    Set (byval value as string)
	    If _OTHTIME <> value Then
	        IsChanged = True
	        _OTHTIME= value
	    End If
    End Set
End property 

Protected _OTHNAME as string  = "" 
Public Overridable Property OTHNAME() as string  Implements _ISdothers.OTHNAME
    Get
	    Return _OTHNAME
    End Get
    Set (byval value as string)
	    If _OTHNAME <> value Then
	        IsChanged = True
	        _OTHNAME= value
	    End If
    End Set
End property 

Protected _OTHAMOUNT as single  = 0 
Public Overridable Property OTHAMOUNT() as single  Implements _ISdothers.OTHAMOUNT
    Get
	    Return _OTHAMOUNT
    End Get
    Set (byval value as single)
	    If _OTHAMOUNT <> value Then
	        IsChanged = True
	        _OTHAMOUNT= value
	    End If
    End Set
End property 

Protected _OTHTYPE as string  = "" 
Public Overridable Property OTHTYPE() as string  Implements _ISdothers.OTHTYPE
    Get
	    Return _OTHTYPE
    End Get
    Set (byval value as string)
	    If _OTHTYPE <> value Then
	        IsChanged = True
	        _OTHTYPE= value
	    End If
    End Set
End property 

Protected _OTHBANK as string  = "" 
Public Overridable Property OTHBANK() as string  Implements _ISdothers.OTHBANK
    Get
	    Return _OTHBANK
    End Get
    Set (byval value as string)
	    If _OTHBANK <> value Then
	        IsChanged = True
	        _OTHBANK= value
	    End If
    End Set
End property 

Protected _OTHCHKNO as string  = "" 
Public Overridable Property OTHCHKNO() as string  Implements _ISdothers.OTHCHKNO
    Get
	    Return _OTHCHKNO
    End Get
    Set (byval value as string)
	    If _OTHCHKNO <> value Then
	        IsChanged = True
	        _OTHCHKNO= value
	    End If
    End Set
End property 

Protected _OTHUSER as string  = "" 
Public Overridable Property OTHUSER() as string  Implements _ISdothers.OTHUSER
    Get
	    Return _OTHUSER
    End Get
    Set (byval value as string)
	    If _OTHUSER <> value Then
	        IsChanged = True
	        _OTHUSER= value
	    End If
    End Set
End property 


#End Region

#Region "Method"
''' <summary>
'''This method read an Sdothers from DB.
''' </summary>
''' <returns>
'''Return 0 if all ok, 1 if error
''' </returns>
Public Overridable Function Read(Id As Integer) As Integer
    'Return 0 if all ok
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Dim int As Sdothers = Manager.Read(Id)
                    _SDOTHERS_ID = int.SDOTHERS_ID
                    _OTHDATE = int.OTHDATE
                    _OTHTIME = int.OTHTIME
                    _OTHNAME = int.OTHNAME
                    _OTHAMOUNT = int.OTHAMOUNT
                    _OTHTYPE = int.OTHTYPE
                    _OTHBANK = int.OTHBANK
                    _OTHCHKNO = int.OTHCHKNO
                    _OTHUSER = int.OTHUSER
        	    End Using
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
	    Ris = 1
    End Try
    Return Ris
End Function

''' <summary>
'''This method save an Sdothers on DB.
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
	  if _OTHTIME.Length > 8 then Ris = False
  if _OTHNAME.Length > 40 then Ris = False
  if _OTHTYPE.Length > 1 then Ris = False
  if _OTHBANK.Length > 10 then Ris = False
  if _OTHCHKNO.Length > 15 then Ris = False
  if _OTHUSER.Length > 8 then Ris = False

	Return Ris
End Function

#End Region

#Region "Embedded Class"


#End Region

End Class 

''' <summary>
'''Interface for table Sdothers
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _ISdothers

Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

    
    Property SDOTHERS_ID() as Int64

    
    Property OTHDATE() as DateTime

    
    Property OTHTIME() as string

    
    Property OTHNAME() as string

    
    Property OTHAMOUNT() as single

    
    Property OTHTYPE() as string

    
    Property OTHBANK() as string

    
    Property OTHCHKNO() as string

    
    Property OTHUSER() as string

    
#End Region

End Interface