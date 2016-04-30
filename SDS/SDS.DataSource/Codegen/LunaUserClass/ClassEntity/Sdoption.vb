#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 20/06/2015 
#End Region



''' <summary>
'''Entity Class for table Sdoption
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Sdoption
	Inherits _Sdoption
    Implements ISdoption

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property SDOPTION_ID() as Int64
    Get
	    Return MyBase.SDOPTION_ID
    End Get
    Set (byval value as Int64)
        MyBase.SDOPTION_ID= value
    End Set
End property 


Public Overrides Property SDTAG() as Boolean
    Get
	    Return MyBase.SDTAG
    End Get
    Set (byval value as Boolean)
        MyBase.SDTAG= value
    End Set
End property 


Public Overrides Property SDPROG() as string
    Get
	    Return MyBase.SDPROG
    End Get
    Set (byval value as string)
        MyBase.SDPROG= value
    End Set
End property 


Public Overrides Property SDDESC() as string
    Get
	    Return MyBase.SDDESC
    End Get
    Set (byval value as string)
        MyBase.SDDESC= value
    End Set
End property 


Public Overrides Property SDTITL() as Boolean
    Get
	    Return MyBase.SDTITL
    End Get
    Set (byval value as Boolean)
        MyBase.SDTITL= value
    End Set
End property 


Public Overrides Property SDPOS() as single
    Get
	    Return MyBase.SDPOS
    End Get
    Set (byval value as single)
        MyBase.SDPOS= value
    End Set
End property 


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements ISdoption.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements ISdoption.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements ISdoption.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Sdoption
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface ISdoption
        Inherits _ISdoption

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface