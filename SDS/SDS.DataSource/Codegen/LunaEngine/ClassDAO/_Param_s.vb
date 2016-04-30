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
'''DAO Class for table Param_s
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Param_s
	Inherits LUNA.LunaBaseClassEntity
    Implements _IParam_s
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _IParam_s.FillFromDataRecord
     		if not myRecord("OTCOUNTER") is DBNull.Value then OTCOUNTER = myRecord("OTCOUNTER")
    		if not myRecord("ENDOFDAY") is DBNull.Value then ENDOFDAY = myRecord("ENDOFDAY")
    		if not myRecord("INTACCR") is DBNull.Value then INTACCR = myRecord("INTACCR")
    		if not myRecord("INTPOST") is DBNull.Value then INTPOST = myRecord("INTPOST")
    		if not myRecord("LPDATE") is DBNull.Value then LPDATE = myRecord("LPDATE")
    		if not myRecord("LPAMT") is DBNull.Value then LPAMT = myRecord("LPAMT")
    		if not myRecord("LPPOST") is DBNull.Value then LPPOST = myRecord("LPPOST")
    		if not myRecord("LDAMT") is DBNull.Value then LDAMT = myRecord("LDAMT")
    		if not myRecord("LDPOST") is DBNull.Value then LDPOST = myRecord("LDPOST")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Param_s)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(Param_sDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Param_s))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _OTCOUNTER as Boolean  = False 
Public Overridable Property OTCOUNTER() as Boolean  Implements _IParam_s.OTCOUNTER
    Get
	    Return _OTCOUNTER
    End Get
    Set (byval value as Boolean)
	    If _OTCOUNTER <> value Then
	        IsChanged = True
	        _OTCOUNTER= value
	    End If
    End Set
End property 

Protected _ENDOFDAY as Boolean  = False 
Public Overridable Property ENDOFDAY() as Boolean  Implements _IParam_s.ENDOFDAY
    Get
	    Return _ENDOFDAY
    End Get
    Set (byval value as Boolean)
	    If _ENDOFDAY <> value Then
	        IsChanged = True
	        _ENDOFDAY= value
	    End If
    End Set
End property 

Protected _INTACCR as Boolean  = False 
Public Overridable Property INTACCR() as Boolean  Implements _IParam_s.INTACCR
    Get
	    Return _INTACCR
    End Get
    Set (byval value as Boolean)
	    If _INTACCR <> value Then
	        IsChanged = True
	        _INTACCR= value
	    End If
    End Set
End property 

Protected _INTPOST as Boolean  = False 
Public Overridable Property INTPOST() as Boolean  Implements _IParam_s.INTPOST
    Get
	    Return _INTPOST
    End Get
    Set (byval value as Boolean)
	    If _INTPOST <> value Then
	        IsChanged = True
	        _INTPOST= value
	    End If
    End Set
End property 

Protected _LPDATE as single  = 0 
Public Overridable Property LPDATE() as single  Implements _IParam_s.LPDATE
    Get
	    Return _LPDATE
    End Get
    Set (byval value as single)
	    If _LPDATE <> value Then
	        IsChanged = True
	        _LPDATE= value
	    End If
    End Set
End property 

Protected _LPAMT as single  = 0 
Public Overridable Property LPAMT() as single  Implements _IParam_s.LPAMT
    Get
	    Return _LPAMT
    End Get
    Set (byval value as single)
	    If _LPAMT <> value Then
	        IsChanged = True
	        _LPAMT= value
	    End If
    End Set
End property 

Protected _LPPOST as DateTime  = Nothing 
Public Overridable Property LPPOST() as DateTime  Implements _IParam_s.LPPOST
    Get
	    Return _LPPOST
    End Get
    Set (byval value as DateTime)
	    If _LPPOST <> value Then
	        IsChanged = True
	        _LPPOST= value
	    End If
    End Set
End property 

Protected _LDAMT as single  = 0 
Public Overridable Property LDAMT() as single  Implements _IParam_s.LDAMT
    Get
	    Return _LDAMT
    End Get
    Set (byval value as single)
	    If _LDAMT <> value Then
	        IsChanged = True
	        _LDAMT= value
	    End If
    End Set
End property 

Protected _LDPOST as DateTime  = Nothing 
Public Overridable Property LDPOST() as DateTime  Implements _IParam_s.LDPOST
    Get
	    Return _LDPOST
    End Get
    Set (byval value as DateTime)
	    If _LDPOST <> value Then
	        IsChanged = True
	        _LDPOST= value
	    End If
    End Set
End property 


#End Region

#Region "Method"
''' <summary>
'''This method read an Param_s from DB.
''' </summary>
''' <returns>
'''Return 0 if all ok, 1 if error
''' </returns>
Public Overridable Function Read(Id As Integer) As Integer
    'Return 0 if all ok
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Dim int As Param_s = Manager.Read(Id)
                    _OTCOUNTER = int.OTCOUNTER
                    _ENDOFDAY = int.ENDOFDAY
                    _INTACCR = int.INTACCR
                    _INTPOST = int.INTPOST
                    _LPDATE = int.LPDATE
                    _LPAMT = int.LPAMT
                    _LPPOST = int.LPPOST
                    _LDAMT = int.LDAMT
                    _LDPOST = int.LDPOST
        	    End Using
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
	    Ris = 1
    End Try
    Return Ris
End Function

''' <summary>
'''This method save an Param_s on DB.
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
	
	Return Ris
End Function

#End Region

#Region "Embedded Class"


#End Region

End Class 

''' <summary>
'''Interface for table Param_s
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _IParam_s

Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

    
    Property OTCOUNTER() as Boolean

    
    Property ENDOFDAY() as Boolean

    
    Property INTACCR() as Boolean

    
    Property INTPOST() as Boolean

    
    Property LPDATE() as single

    
    Property LPAMT() as single

    
    Property LPPOST() as DateTime

    
    Property LDAMT() as single

    
    Property LDPOST() as DateTime

    
#End Region

End Interface