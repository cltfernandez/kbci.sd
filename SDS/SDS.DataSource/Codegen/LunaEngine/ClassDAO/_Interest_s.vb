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
'''DAO Class for table Interest_s
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Interest_s
	Inherits LUNA.LunaBaseClassEntity
    Implements _IInterest_s
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _IInterest_s.FillFromDataRecord
     INTEREST_S_ID = myRecord("INTEREST_S_ID")
    		if not myRecord("ACCTNO") is DBNull.Value then ACCTNO = myRecord("ACCTNO")
    		if not myRecord("ADB") is DBNull.Value then ADB = myRecord("ADB")
    		if not myRecord("MONTH1") is DBNull.Value then MONTH1 = myRecord("MONTH1")
    		if not myRecord("MONTH2") is DBNull.Value then MONTH2 = myRecord("MONTH2")
    		if not myRecord("MONTH3") is DBNull.Value then MONTH3 = myRecord("MONTH3")
    		if not myRecord("QTD") is DBNull.Value then QTD = myRecord("QTD")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Interest_s)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(Interest_sDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Interest_s))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _INTEREST_S_ID as Int64  = Nothing 
Public Overridable Property INTEREST_S_ID() as Int64  Implements _IInterest_s.INTEREST_S_ID
    Get
	    Return _INTEREST_S_ID
    End Get
    Set (byval value as Int64)
	    If _INTEREST_S_ID <> value Then
	        IsChanged = True
	        _INTEREST_S_ID= value
	    End If
    End Set
End property 

Protected _ACCTNO as string  = "" 
Public Overridable Property ACCTNO() as string  Implements _IInterest_s.ACCTNO
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

Protected _ADB as single  = 0 
Public Overridable Property ADB() as single  Implements _IInterest_s.ADB
    Get
	    Return _ADB
    End Get
    Set (byval value as single)
	    If _ADB <> value Then
	        IsChanged = True
	        _ADB= value
	    End If
    End Set
End property 

Protected _MONTH1 as single  = 0 
Public Overridable Property MONTH1() as single  Implements _IInterest_s.MONTH1
    Get
	    Return _MONTH1
    End Get
    Set (byval value as single)
	    If _MONTH1 <> value Then
	        IsChanged = True
	        _MONTH1= value
	    End If
    End Set
End property 

Protected _MONTH2 as single  = 0 
Public Overridable Property MONTH2() as single  Implements _IInterest_s.MONTH2
    Get
	    Return _MONTH2
    End Get
    Set (byval value as single)
	    If _MONTH2 <> value Then
	        IsChanged = True
	        _MONTH2= value
	    End If
    End Set
End property 

Protected _MONTH3 as single  = 0 
Public Overridable Property MONTH3() as single  Implements _IInterest_s.MONTH3
    Get
	    Return _MONTH3
    End Get
    Set (byval value as single)
	    If _MONTH3 <> value Then
	        IsChanged = True
	        _MONTH3= value
	    End If
    End Set
End property 

Protected _QTD as single  = 0 
Public Overridable Property QTD() as single  Implements _IInterest_s.QTD
    Get
	    Return _QTD
    End Get
    Set (byval value as single)
	    If _QTD <> value Then
	        IsChanged = True
	        _QTD= value
	    End If
    End Set
End property 


#End Region

#Region "Method"
''' <summary>
'''This method read an Interest_s from DB.
''' </summary>
''' <returns>
'''Return 0 if all ok, 1 if error
''' </returns>
Public Overridable Function Read(Id As Integer) As Integer
    'Return 0 if all ok
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Dim int As Interest_s = Manager.Read(Id)
                    _INTEREST_S_ID = int.INTEREST_S_ID
                    _ACCTNO = int.ACCTNO
                    _ADB = int.ADB
                    _MONTH1 = int.MONTH1
                    _MONTH2 = int.MONTH2
                    _MONTH3 = int.MONTH3
                    _QTD = int.QTD
        	    End Using
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
	    Ris = 1
    End Try
    Return Ris
End Function

''' <summary>
'''This method save an Interest_s on DB.
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

	Return Ris
End Function

#End Region

#Region "Embedded Class"


#End Region

End Class 

''' <summary>
'''Interface for table Interest_s
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _IInterest_s

Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

    
    Property INTEREST_S_ID() as Int64

    
    Property ACCTNO() as string

    
    Property ADB() as single

    
    Property MONTH1() as single

    
    Property MONTH2() as single

    
    Property MONTH3() as single

    
    Property QTD() as single

    
#End Region

End Interface