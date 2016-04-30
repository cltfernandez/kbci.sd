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
'''DAO Class for table Spuser
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Spuser
	Inherits LUNA.LunaBaseClassEntity
    Implements _ISpuser
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _ISpuser.FillFromDataRecord
     SPUSER_ID = myRecord("SPUSER_ID")
    		if not myRecord("SPUSERID") is DBNull.Value then SPUSERID = myRecord("SPUSERID")
    		if not myRecord("SPUSERPASS") is DBNull.Value then SPUSERPASS = myRecord("SPUSERPASS")
    		if not myRecord("SPUSERNAME") is DBNull.Value then SPUSERNAME = myRecord("SPUSERNAME")
    		if not myRecord("SPUSERPOS") is DBNull.Value then SPUSERPOS = myRecord("SPUSERPOS")
    		if not myRecord("SPLOGSTAT") is DBNull.Value then SPLOGSTAT = myRecord("SPLOGSTAT")
    		if not myRecord("SPLOGNO") is DBNull.Value then SPLOGNO = myRecord("SPLOGNO")
    		if not myRecord("SPTELLER") is DBNull.Value then SPTELLER = myRecord("SPTELLER")
    		if not myRecord("SPTAG") is DBNull.Value then SPTAG = myRecord("SPTAG")
    		if not myRecord("ADD_DATE") is DBNull.Value then ADD_DATE = myRecord("ADD_DATE")
    		if not myRecord("CHG_DATE") is DBNull.Value then CHG_DATE = myRecord("CHG_DATE")
    		if not myRecord("USER") is DBNull.Value then USER = myRecord("USER")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Spuser)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(SpuserDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Spuser))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _SPUSER_ID as Int64  = Nothing 
Public Overridable Property SPUSER_ID() as Int64  Implements _ISpuser.SPUSER_ID
    Get
	    Return _SPUSER_ID
    End Get
    Set (byval value as Int64)
	    If _SPUSER_ID <> value Then
	        IsChanged = True
	        _SPUSER_ID= value
	    End If
    End Set
End property 

Protected _SPUSERID as string  = "" 
Public Overridable Property SPUSERID() as string  Implements _ISpuser.SPUSERID
    Get
	    Return _SPUSERID
    End Get
    Set (byval value as string)
	    If _SPUSERID <> value Then
	        IsChanged = True
	        _SPUSERID= value
	    End If
    End Set
End property 

Protected _SPUSERPASS as string  = "" 
Public Overridable Property SPUSERPASS() as string  Implements _ISpuser.SPUSERPASS
    Get
	    Return _SPUSERPASS
    End Get
    Set (byval value as string)
	    If _SPUSERPASS <> value Then
	        IsChanged = True
	        _SPUSERPASS= value
	    End If
    End Set
End property 

Protected _SPUSERNAME as string  = "" 
Public Overridable Property SPUSERNAME() as string  Implements _ISpuser.SPUSERNAME
    Get
	    Return _SPUSERNAME
    End Get
    Set (byval value as string)
	    If _SPUSERNAME <> value Then
	        IsChanged = True
	        _SPUSERNAME= value
	    End If
    End Set
End property 

Protected _SPUSERPOS as string  = "" 
Public Overridable Property SPUSERPOS() as string  Implements _ISpuser.SPUSERPOS
    Get
	    Return _SPUSERPOS
    End Get
    Set (byval value as string)
	    If _SPUSERPOS <> value Then
	        IsChanged = True
	        _SPUSERPOS= value
	    End If
    End Set
End property 

Protected _SPLOGSTAT as Boolean  = False 
Public Overridable Property SPLOGSTAT() as Boolean  Implements _ISpuser.SPLOGSTAT
    Get
	    Return _SPLOGSTAT
    End Get
    Set (byval value as Boolean)
	    If _SPLOGSTAT <> value Then
	        IsChanged = True
	        _SPLOGSTAT= value
	    End If
    End Set
End property 

Protected _SPLOGNO as single  = 0 
Public Overridable Property SPLOGNO() as single  Implements _ISpuser.SPLOGNO
    Get
	    Return _SPLOGNO
    End Get
    Set (byval value as single)
	    If _SPLOGNO <> value Then
	        IsChanged = True
	        _SPLOGNO= value
	    End If
    End Set
End property 

Protected _SPTELLER as Boolean  = False 
Public Overridable Property SPTELLER() as Boolean  Implements _ISpuser.SPTELLER
    Get
	    Return _SPTELLER
    End Get
    Set (byval value as Boolean)
	    If _SPTELLER <> value Then
	        IsChanged = True
	        _SPTELLER= value
	    End If
    End Set
End property 

Protected _SPTAG as string  = "" 
Public Overridable Property SPTAG() as string  Implements _ISpuser.SPTAG
    Get
	    Return _SPTAG
    End Get
    Set (byval value as string)
	    If _SPTAG <> value Then
	        IsChanged = True
	        _SPTAG= value
	    End If
    End Set
End property 

Protected _ADD_DATE as DateTime  = Nothing 
Public Overridable Property ADD_DATE() as DateTime  Implements _ISpuser.ADD_DATE
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
Public Overridable Property CHG_DATE() as DateTime  Implements _ISpuser.CHG_DATE
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
Public Overridable Property USER() as string  Implements _ISpuser.USER
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
'''This method read an Spuser from DB.
''' </summary>
''' <returns>
'''Return 0 if all ok, 1 if error
''' </returns>
Public Overridable Function Read(Id As Integer) As Integer
    'Return 0 if all ok
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Dim int As Spuser = Manager.Read(Id)
                    _SPUSER_ID = int.SPUSER_ID
                    _SPUSERID = int.SPUSERID
                    _SPUSERPASS = int.SPUSERPASS
                    _SPUSERNAME = int.SPUSERNAME
                    _SPUSERPOS = int.SPUSERPOS
                    _SPLOGSTAT = int.SPLOGSTAT
                    _SPLOGNO = int.SPLOGNO
                    _SPTELLER = int.SPTELLER
                    _SPTAG = int.SPTAG
                    _ADD_DATE = int.ADD_DATE
                    _CHG_DATE = int.CHG_DATE
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
'''This method save an Spuser on DB.
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
	  if _SPUSERID.Length > 8 then Ris = False
  if _SPUSERPASS.Length > 8 then Ris = False
  if _SPUSERNAME.Length > 30 then Ris = False
  if _SPUSERPOS.Length > 1 then Ris = False
  if _SPTAG.Length > 40 then Ris = False
  if _USER.Length > 8 then Ris = False

	Return Ris
End Function

#End Region

#Region "Embedded Class"


#End Region

End Class 

''' <summary>
'''Interface for table Spuser
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _ISpuser

Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

    
    Property SPUSER_ID() as Int64

    
    Property SPUSERID() as string

    
    Property SPUSERPASS() as string

    
    Property SPUSERNAME() as string

    
    Property SPUSERPOS() as string

    
    Property SPLOGSTAT() as Boolean

    
    Property SPLOGNO() as single

    
    Property SPTELLER() as Boolean

    
    Property SPTAG() as string

    
    Property ADD_DATE() as DateTime

    
    Property CHG_DATE() as DateTime

    
    Property USER() as string

    
#End Region

End Interface