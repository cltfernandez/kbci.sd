#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 20/06/2015 
#End Region



''' <summary>
'''Entity Class for table Extkbc
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Extkbc
	Inherits _Extkbc
    Implements IExtkbc

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property EMPNO1() as single
    Get
	    Return MyBase.EMPNO1
    End Get
    Set (byval value as single)
        MyBase.EMPNO1= value
    End Set
End property 


Public Overrides Property ACTYPE() as single
    Get
	    Return MyBase.ACTYPE
    End Get
    Set (byval value as single)
        MyBase.ACTYPE= value
    End Set
End property 


Public Overrides Property ACTCD1() as single
    Get
	    Return MyBase.ACTCD1
    End Get
    Set (byval value as single)
        MyBase.ACTCD1= value
    End Set
End property 


Public Overrides Property ACTCD2() as single
    Get
	    Return MyBase.ACTCD2
    End Get
    Set (byval value as single)
        MyBase.ACTCD2= value
    End Set
End property 


Public Overrides Property DATE7() as DateTime
    Get
	    Return MyBase.DATE7
    End Get
    Set (byval value as DateTime)
        MyBase.DATE7= value
    End Set
End property 


Public Overrides Property AMT7C() as single
    Get
	    Return MyBase.AMT7C
    End Get
    Set (byval value as single)
        MyBase.AMT7C= value
    End Set
End property 


Public Overrides Property CODE5() as single
    Get
	    Return MyBase.CODE5
    End Get
    Set (byval value as single)
        MyBase.CODE5= value
    End Set
End property 


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements IExtkbc.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements IExtkbc.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements IExtkbc.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Extkbc
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface IExtkbc
        Inherits _IExtkbc

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface