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
'''DAO Class for table Sdoption
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Sdoption
	Inherits LUNA.LunaBaseClassEntity
    Implements _ISdoption
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _ISdoption.FillFromDataRecord
     SDOPTION_ID = myRecord("SDOPTION_ID")
    		if not myRecord("SDTAG") is DBNull.Value then SDTAG = myRecord("SDTAG")
    		if not myRecord("SDPROG") is DBNull.Value then SDPROG = myRecord("SDPROG")
    		if not myRecord("SDDESC") is DBNull.Value then SDDESC = myRecord("SDDESC")
    		if not myRecord("SDTITL") is DBNull.Value then SDTITL = myRecord("SDTITL")
    		if not myRecord("SDPOS") is DBNull.Value then SDPOS = myRecord("SDPOS")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Sdoption)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(SdoptionDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Sdoption))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _SDOPTION_ID as Int64  = Nothing 
Public Overridable Property SDOPTION_ID() as Int64  Implements _ISdoption.SDOPTION_ID
    Get
	    Return _SDOPTION_ID
    End Get
    Set (byval value as Int64)
	    If _SDOPTION_ID <> value Then
	        IsChanged = True
	        _SDOPTION_ID= value
	    End If
    End Set
End property 

Protected _SDTAG as Boolean  = False 
Public Overridable Property SDTAG() as Boolean  Implements _ISdoption.SDTAG
    Get
	    Return _SDTAG
    End Get
    Set (byval value as Boolean)
	    If _SDTAG <> value Then
	        IsChanged = True
	        _SDTAG= value
	    End If
    End Set
End property 

Protected _SDPROG as string  = "" 
Public Overridable Property SDPROG() as string  Implements _ISdoption.SDPROG
    Get
	    Return _SDPROG
    End Get
    Set (byval value as string)
	    If _SDPROG <> value Then
	        IsChanged = True
	        _SDPROG= value
	    End If
    End Set
End property 

Protected _SDDESC as string  = "" 
Public Overridable Property SDDESC() as string  Implements _ISdoption.SDDESC
    Get
	    Return _SDDESC
    End Get
    Set (byval value as string)
	    If _SDDESC <> value Then
	        IsChanged = True
	        _SDDESC= value
	    End If
    End Set
End property 

Protected _SDTITL as Boolean  = False 
Public Overridable Property SDTITL() as Boolean  Implements _ISdoption.SDTITL
    Get
	    Return _SDTITL
    End Get
    Set (byval value as Boolean)
	    If _SDTITL <> value Then
	        IsChanged = True
	        _SDTITL= value
	    End If
    End Set
End property 

Protected _SDPOS as single  = 0 
Public Overridable Property SDPOS() as single  Implements _ISdoption.SDPOS
    Get
	    Return _SDPOS
    End Get
    Set (byval value as single)
	    If _SDPOS <> value Then
	        IsChanged = True
	        _SDPOS= value
	    End If
    End Set
End property 


#End Region

#Region "Method"
''' <summary>
'''This method read an Sdoption from DB.
''' </summary>
''' <returns>
'''Return 0 if all ok, 1 if error
''' </returns>
Public Overridable Function Read(Id As Integer) As Integer
    'Return 0 if all ok
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Dim int As Sdoption = Manager.Read(Id)
                    _SDOPTION_ID = int.SDOPTION_ID
                    _SDTAG = int.SDTAG
                    _SDPROG = int.SDPROG
                    _SDDESC = int.SDDESC
                    _SDTITL = int.SDTITL
                    _SDPOS = int.SDPOS
        	    End Using
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
	    Ris = 1
    End Try
    Return Ris
End Function

''' <summary>
'''This method save an Sdoption on DB.
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
	  if _SDPROG.Length > 10 then Ris = False
  if _SDDESC.Length > 35 then Ris = False

	Return Ris
End Function

#End Region

#Region "Embedded Class"


#End Region

End Class 

''' <summary>
'''Interface for table Sdoption
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _ISdoption

Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

    
    Property SDOPTION_ID() as Int64

    
    Property SDTAG() as Boolean

    
    Property SDPROG() as string

    
    Property SDDESC() as string

    
    Property SDTITL() as Boolean

    
    Property SDPOS() as single

    
#End Region

End Interface