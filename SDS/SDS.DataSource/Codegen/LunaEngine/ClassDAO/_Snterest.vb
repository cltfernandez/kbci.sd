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
'''DAO Class for table Snterest
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Snterest
	Inherits LUNA.LunaBaseClassEntity
    Implements _ISnterest
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _ISnterest.FillFromDataRecord
     SNTEREST = myRecord("SNTEREST")
    		if not myRecord("ACCTNO") is DBNull.Value then ACCTNO = myRecord("ACCTNO")
    		if not myRecord("APLINT") is DBNull.Value then APLINT = myRecord("APLINT")
    		if not myRecord("EDLINT") is DBNull.Value then EDLINT = myRecord("EDLINT")
    		if not myRecord("EMLINT") is DBNull.Value then EMLINT = myRecord("EMLINT")
    		if not myRecord("RGLINT") is DBNull.Value then RGLINT = myRecord("RGLINT")
    		if not myRecord("RSLINT") is DBNull.Value then RSLINT = myRecord("RSLINT")
    		if not myRecord("SPLINT") is DBNull.Value then SPLINT = myRecord("SPLINT")
    		if not myRecord("LHLINT") is DBNull.Value then LHLINT = myRecord("LHLINT")
    		if not myRecord("STLINT") is DBNull.Value then STLINT = myRecord("STLINT")
    		if not myRecord("PTLINT") is DBNull.Value then PTLINT = myRecord("PTLINT")
    		if not myRecord("CMLINT") is DBNull.Value then CMLINT = myRecord("CMLINT")
    		if not myRecord("FALINT") is DBNull.Value then FALINT = myRecord("FALINT")
    		if not myRecord("MPLINT") is DBNull.Value then MPLINT = myRecord("MPLINT")
    		if not myRecord("XMAINT") is DBNull.Value then XMAINT = myRecord("XMAINT")
    		if not myRecord("REC_STAT") is DBNull.Value then REC_STAT = myRecord("REC_STAT")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Snterest)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(SnterestDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Snterest))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _SNTEREST as Int64  = Nothing 
Public Overridable Property SNTEREST() as Int64  Implements _ISnterest.SNTEREST
    Get
	    Return _SNTEREST
    End Get
    Set (byval value as Int64)
	    If _SNTEREST <> value Then
	        IsChanged = True
	        _SNTEREST= value
	    End If
    End Set
End property 

Protected _ACCTNO as string  = "" 
Public Overridable Property ACCTNO() as string  Implements _ISnterest.ACCTNO
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

Protected _APLINT as single  = 0 
Public Overridable Property APLINT() as single  Implements _ISnterest.APLINT
    Get
	    Return _APLINT
    End Get
    Set (byval value as single)
	    If _APLINT <> value Then
	        IsChanged = True
	        _APLINT= value
	    End If
    End Set
End property 

Protected _EDLINT as single  = 0 
Public Overridable Property EDLINT() as single  Implements _ISnterest.EDLINT
    Get
	    Return _EDLINT
    End Get
    Set (byval value as single)
	    If _EDLINT <> value Then
	        IsChanged = True
	        _EDLINT= value
	    End If
    End Set
End property 

Protected _EMLINT as single  = 0 
Public Overridable Property EMLINT() as single  Implements _ISnterest.EMLINT
    Get
	    Return _EMLINT
    End Get
    Set (byval value as single)
	    If _EMLINT <> value Then
	        IsChanged = True
	        _EMLINT= value
	    End If
    End Set
End property 

Protected _RGLINT as single  = 0 
Public Overridable Property RGLINT() as single  Implements _ISnterest.RGLINT
    Get
	    Return _RGLINT
    End Get
    Set (byval value as single)
	    If _RGLINT <> value Then
	        IsChanged = True
	        _RGLINT= value
	    End If
    End Set
End property 

Protected _RSLINT as single  = 0 
Public Overridable Property RSLINT() as single  Implements _ISnterest.RSLINT
    Get
	    Return _RSLINT
    End Get
    Set (byval value as single)
	    If _RSLINT <> value Then
	        IsChanged = True
	        _RSLINT= value
	    End If
    End Set
End property 

Protected _SPLINT as single  = 0 
Public Overridable Property SPLINT() as single  Implements _ISnterest.SPLINT
    Get
	    Return _SPLINT
    End Get
    Set (byval value as single)
	    If _SPLINT <> value Then
	        IsChanged = True
	        _SPLINT= value
	    End If
    End Set
End property 

Protected _LHLINT as single  = 0 
Public Overridable Property LHLINT() as single  Implements _ISnterest.LHLINT
    Get
	    Return _LHLINT
    End Get
    Set (byval value as single)
	    If _LHLINT <> value Then
	        IsChanged = True
	        _LHLINT= value
	    End If
    End Set
End property 

Protected _STLINT as single  = 0 
Public Overridable Property STLINT() as single  Implements _ISnterest.STLINT
    Get
	    Return _STLINT
    End Get
    Set (byval value as single)
	    If _STLINT <> value Then
	        IsChanged = True
	        _STLINT= value
	    End If
    End Set
End property 

Protected _PTLINT as single  = 0 
Public Overridable Property PTLINT() as single  Implements _ISnterest.PTLINT
    Get
	    Return _PTLINT
    End Get
    Set (byval value as single)
	    If _PTLINT <> value Then
	        IsChanged = True
	        _PTLINT= value
	    End If
    End Set
End property 

Protected _CMLINT as single  = 0 
Public Overridable Property CMLINT() as single  Implements _ISnterest.CMLINT
    Get
	    Return _CMLINT
    End Get
    Set (byval value as single)
	    If _CMLINT <> value Then
	        IsChanged = True
	        _CMLINT= value
	    End If
    End Set
End property 

Protected _FALINT as single  = 0 
Public Overridable Property FALINT() as single  Implements _ISnterest.FALINT
    Get
	    Return _FALINT
    End Get
    Set (byval value as single)
	    If _FALINT <> value Then
	        IsChanged = True
	        _FALINT= value
	    End If
    End Set
End property 

Protected _MPLINT as single  = 0 
Public Overridable Property MPLINT() as single  Implements _ISnterest.MPLINT
    Get
	    Return _MPLINT
    End Get
    Set (byval value as single)
	    If _MPLINT <> value Then
	        IsChanged = True
	        _MPLINT= value
	    End If
    End Set
End property 

Protected _XMAINT as single  = 0 
Public Overridable Property XMAINT() as single  Implements _ISnterest.XMAINT
    Get
	    Return _XMAINT
    End Get
    Set (byval value as single)
	    If _XMAINT <> value Then
	        IsChanged = True
	        _XMAINT= value
	    End If
    End Set
End property 

Protected _REC_STAT as Boolean  = False 
Public Overridable Property REC_STAT() as Boolean  Implements _ISnterest.REC_STAT
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
'''This method read an Snterest from DB.
''' </summary>
''' <returns>
'''Return 0 if all ok, 1 if error
''' </returns>
Public Overridable Function Read(Id As Integer) As Integer
    'Return 0 if all ok
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Dim int As Snterest = Manager.Read(Id)
                    _SNTEREST = int.SNTEREST
                    _ACCTNO = int.ACCTNO
                    _APLINT = int.APLINT
                    _EDLINT = int.EDLINT
                    _EMLINT = int.EMLINT
                    _RGLINT = int.RGLINT
                    _RSLINT = int.RSLINT
                    _SPLINT = int.SPLINT
                    _LHLINT = int.LHLINT
                    _STLINT = int.STLINT
                    _PTLINT = int.PTLINT
                    _CMLINT = int.CMLINT
                    _FALINT = int.FALINT
                    _MPLINT = int.MPLINT
                    _XMAINT = int.XMAINT
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
'''This method save an Snterest on DB.
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
	  if _ACCTNO.Length > 7 then Ris = False

	Return Ris
End Function

#End Region

#Region "Embedded Class"


#End Region

End Class 

''' <summary>
'''Interface for table Snterest
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _ISnterest

Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

    
    Property SNTEREST() as Int64

    
    Property ACCTNO() as string

    
    Property APLINT() as single

    
    Property EDLINT() as single

    
    Property EMLINT() as single

    
    Property RGLINT() as single

    
    Property RSLINT() as single

    
    Property SPLINT() as single

    
    Property LHLINT() as single

    
    Property STLINT() as single

    
    Property PTLINT() as single

    
    Property CMLINT() as single

    
    Property FALINT() as single

    
    Property MPLINT() as single

    
    Property XMAINT() as single

    
    Property REC_STAT() as Boolean

    
#End Region

End Interface