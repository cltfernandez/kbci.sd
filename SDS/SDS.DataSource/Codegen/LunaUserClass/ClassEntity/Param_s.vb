#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 20/06/2015 
#End Region



''' <summary>
'''Entity Class for table Param_s
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Param_s
	Inherits _Param_s
    Implements IParam_s

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property OTCOUNTER() as Boolean
    Get
	    Return MyBase.OTCOUNTER
    End Get
    Set (byval value as Boolean)
        MyBase.OTCOUNTER= value
    End Set
End property 


Public Overrides Property ENDOFDAY() as Boolean
    Get
	    Return MyBase.ENDOFDAY
    End Get
    Set (byval value as Boolean)
        MyBase.ENDOFDAY= value
    End Set
End property 


Public Overrides Property INTACCR() as Boolean
    Get
	    Return MyBase.INTACCR
    End Get
    Set (byval value as Boolean)
        MyBase.INTACCR= value
    End Set
End property 


Public Overrides Property INTPOST() as Boolean
    Get
	    Return MyBase.INTPOST
    End Get
    Set (byval value as Boolean)
        MyBase.INTPOST= value
    End Set
End property 


Public Overrides Property LPDATE() as single
    Get
	    Return MyBase.LPDATE
    End Get
    Set (byval value as single)
        MyBase.LPDATE= value
    End Set
End property 


Public Overrides Property LPAMT() as single
    Get
	    Return MyBase.LPAMT
    End Get
    Set (byval value as single)
        MyBase.LPAMT= value
    End Set
End property 


Public Overrides Property LPPOST() as DateTime
    Get
	    Return MyBase.LPPOST
    End Get
    Set (byval value as DateTime)
        MyBase.LPPOST= value
    End Set
End property 


Public Overrides Property LDAMT() as single
    Get
	    Return MyBase.LDAMT
    End Get
    Set (byval value as single)
        MyBase.LDAMT= value
    End Set
End property 


Public Overrides Property LDPOST() as DateTime
    Get
	    Return MyBase.LDPOST
    End Get
    Set (byval value as DateTime)
        MyBase.LDPOST= value
    End Set
End property 


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements IParam_s.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements IParam_s.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements IParam_s.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Param_s
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface IParam_s
        Inherits _IParam_s

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface