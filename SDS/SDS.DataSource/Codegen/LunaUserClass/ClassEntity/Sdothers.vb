#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 20/06/2015 
#End Region



''' <summary>
'''Entity Class for table Sdothers
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Sdothers
	Inherits _Sdothers
    Implements ISdothers

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property SDOTHERS_ID() as Int64
    Get
	    Return MyBase.SDOTHERS_ID
    End Get
    Set (byval value as Int64)
        MyBase.SDOTHERS_ID= value
    End Set
End property 


Public Overrides Property OTHDATE() as DateTime
    Get
	    Return MyBase.OTHDATE
    End Get
    Set (byval value as DateTime)
        MyBase.OTHDATE= value
    End Set
End property 


Public Overrides Property OTHTIME() as string
    Get
	    Return MyBase.OTHTIME
    End Get
    Set (byval value as string)
        MyBase.OTHTIME= value
    End Set
End property 


Public Overrides Property OTHNAME() as string
    Get
	    Return MyBase.OTHNAME
    End Get
    Set (byval value as string)
        MyBase.OTHNAME= value
    End Set
End property 


Public Overrides Property OTHAMOUNT() as single
    Get
	    Return MyBase.OTHAMOUNT
    End Get
    Set (byval value as single)
        MyBase.OTHAMOUNT= value
    End Set
End property 


Public Overrides Property OTHTYPE() as string
    Get
	    Return MyBase.OTHTYPE
    End Get
    Set (byval value as string)
        MyBase.OTHTYPE= value
    End Set
End property 


Public Overrides Property OTHBANK() as string
    Get
	    Return MyBase.OTHBANK
    End Get
    Set (byval value as string)
        MyBase.OTHBANK= value
    End Set
End property 


Public Overrides Property OTHCHKNO() as string
    Get
	    Return MyBase.OTHCHKNO
    End Get
    Set (byval value as string)
        MyBase.OTHCHKNO= value
    End Set
End property 


Public Overrides Property OTHUSER() as string
    Get
	    Return MyBase.OTHUSER
    End Get
    Set (byval value as string)
        MyBase.OTHUSER= value
    End Set
End property 


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements ISdothers.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements ISdothers.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements ISdothers.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Sdothers
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface ISdothers
        Inherits _ISdothers

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface