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
'''DAO Class for table Sdpay
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Sdpay
	Inherits LUNA.LunaBaseClassEntity
    Implements _ISdpay
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _ISdpay.FillFromDataRecord
     		if not myRecord("EMPNO1") is DBNull.Value then EMPNO1 = myRecord("EMPNO1")
    		if not myRecord("ACTYPE") is DBNull.Value then ACTYPE = myRecord("ACTYPE")
    		if not myRecord("ACTCD1") is DBNull.Value then ACTCD1 = myRecord("ACTCD1")
    		if not myRecord("ACTCD2") is DBNull.Value then ACTCD2 = myRecord("ACTCD2")
    		if not myRecord("DATE7") is DBNull.Value then DATE7 = myRecord("DATE7")
    		if not myRecord("AMT7C") is DBNull.Value then AMT7C = myRecord("AMT7C")
    		if not myRecord("CODE5") is DBNull.Value then CODE5 = myRecord("CODE5")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Sdpay)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(SdpayDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Sdpay))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _EMPNO1 as single  = 0 
Public Overridable Property EMPNO1() as single  Implements _ISdpay.EMPNO1
    Get
	    Return _EMPNO1
    End Get
    Set (byval value as single)
	    If _EMPNO1 <> value Then
	        IsChanged = True
	        _EMPNO1= value
	    End If
    End Set
End property 

Protected _ACTYPE as single  = 0 
Public Overridable Property ACTYPE() as single  Implements _ISdpay.ACTYPE
    Get
	    Return _ACTYPE
    End Get
    Set (byval value as single)
	    If _ACTYPE <> value Then
	        IsChanged = True
	        _ACTYPE= value
	    End If
    End Set
End property 

Protected _ACTCD1 as single  = 0 
Public Overridable Property ACTCD1() as single  Implements _ISdpay.ACTCD1
    Get
	    Return _ACTCD1
    End Get
    Set (byval value as single)
	    If _ACTCD1 <> value Then
	        IsChanged = True
	        _ACTCD1= value
	    End If
    End Set
End property 

Protected _ACTCD2 as single  = 0 
Public Overridable Property ACTCD2() as single  Implements _ISdpay.ACTCD2
    Get
	    Return _ACTCD2
    End Get
    Set (byval value as single)
	    If _ACTCD2 <> value Then
	        IsChanged = True
	        _ACTCD2= value
	    End If
    End Set
End property 

Protected _DATE7 as DateTime  = Nothing 
Public Overridable Property DATE7() as DateTime  Implements _ISdpay.DATE7
    Get
	    Return _DATE7
    End Get
    Set (byval value as DateTime)
	    If _DATE7 <> value Then
	        IsChanged = True
	        _DATE7= value
	    End If
    End Set
End property 

Protected _AMT7C as single  = 0 
Public Overridable Property AMT7C() as single  Implements _ISdpay.AMT7C
    Get
	    Return _AMT7C
    End Get
    Set (byval value as single)
	    If _AMT7C <> value Then
	        IsChanged = True
	        _AMT7C= value
	    End If
    End Set
End property 

Protected _CODE5 as single  = 0 
Public Overridable Property CODE5() as single  Implements _ISdpay.CODE5
    Get
	    Return _CODE5
    End Get
    Set (byval value as single)
	    If _CODE5 <> value Then
	        IsChanged = True
	        _CODE5= value
	    End If
    End Set
End property 


#End Region

#Region "Method"
''' <summary>
'''This method read an Sdpay from DB.
''' </summary>
''' <returns>
'''Return 0 if all ok, 1 if error
''' </returns>
Public Overridable Function Read(Id As Integer) As Integer
    'Return 0 if all ok
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Dim int As Sdpay = Manager.Read(Id)
                    _EMPNO1 = int.EMPNO1
                    _ACTYPE = int.ACTYPE
                    _ACTCD1 = int.ACTCD1
                    _ACTCD2 = int.ACTCD2
                    _DATE7 = int.DATE7
                    _AMT7C = int.AMT7C
                    _CODE5 = int.CODE5
        	    End Using
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
	    Ris = 1
    End Try
    Return Ris
End Function

''' <summary>
'''This method save an Sdpay on DB.
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
'''Interface for table Sdpay
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _ISdpay

Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

    
    Property EMPNO1() as single

    
    Property ACTYPE() as single

    
    Property ACTCD1() as single

    
    Property ACTCD2() as single

    
    Property DATE7() as DateTime

    
    Property AMT7C() as single

    
    Property CODE5() as single

    
#End Region

End Interface