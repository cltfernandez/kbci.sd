#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 20/06/2015 
#End Region



''' <summary>
'''Entity Class for table Interest_s
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Interest_s
	Inherits _Interest_s
    Implements IInterest_s

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property INTEREST_S_ID() as Int64
    Get
	    Return MyBase.INTEREST_S_ID
    End Get
    Set (byval value as Int64)
        MyBase.INTEREST_S_ID= value
    End Set
End property 


Public Overrides Property ACCTNO() as string
    Get
	    Return MyBase.ACCTNO
    End Get
    Set (byval value as string)
        MyBase.ACCTNO= value
    End Set
End property 


Public Overrides Property ADB() as single
    Get
	    Return MyBase.ADB
    End Get
    Set (byval value as single)
        MyBase.ADB= value
    End Set
End property 


Public Overrides Property MONTH1() as single
    Get
	    Return MyBase.MONTH1
    End Get
    Set (byval value as single)
        MyBase.MONTH1= value
    End Set
End property 


Public Overrides Property MONTH2() as single
    Get
	    Return MyBase.MONTH2
    End Get
    Set (byval value as single)
        MyBase.MONTH2= value
    End Set
End property 


Public Overrides Property MONTH3() as single
    Get
	    Return MyBase.MONTH3
    End Get
    Set (byval value as single)
        MyBase.MONTH3= value
    End Set
End property 


Public Overrides Property QTD() as single
    Get
	    Return MyBase.QTD
    End Get
    Set (byval value as single)
        MyBase.QTD= value
    End Set
End property 


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements IInterest_s.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements IInterest_s.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements IInterest_s.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Interest_s
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface IInterest_s
        Inherits _IInterest_s

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface