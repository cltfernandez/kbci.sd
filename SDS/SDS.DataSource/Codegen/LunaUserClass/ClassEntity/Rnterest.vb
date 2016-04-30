#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 20/06/2015 
#End Region



''' <summary>
'''Entity Class for table Rnterest
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Rnterest
	Inherits _Rnterest
    Implements IRnterest

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property RNTEREST() as Int64
    Get
	    Return MyBase.RNTEREST
    End Get
    Set (byval value as Int64)
        MyBase.RNTEREST= value
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


Public Overrides Property APLINT() as single
    Get
	    Return MyBase.APLINT
    End Get
    Set (byval value as single)
        MyBase.APLINT= value
    End Set
End property 


Public Overrides Property EDLINT() as single
    Get
	    Return MyBase.EDLINT
    End Get
    Set (byval value as single)
        MyBase.EDLINT= value
    End Set
End property 


Public Overrides Property EMLINT() as single
    Get
	    Return MyBase.EMLINT
    End Get
    Set (byval value as single)
        MyBase.EMLINT= value
    End Set
End property 


Public Overrides Property RGLINT() as single
    Get
	    Return MyBase.RGLINT
    End Get
    Set (byval value as single)
        MyBase.RGLINT= value
    End Set
End property 


Public Overrides Property RSLINT() as single
    Get
	    Return MyBase.RSLINT
    End Get
    Set (byval value as single)
        MyBase.RSLINT= value
    End Set
End property 


Public Overrides Property SPLINT() as single
    Get
	    Return MyBase.SPLINT
    End Get
    Set (byval value as single)
        MyBase.SPLINT= value
    End Set
End property 


Public Overrides Property LHLINT() as single
    Get
	    Return MyBase.LHLINT
    End Get
    Set (byval value as single)
        MyBase.LHLINT= value
    End Set
End property 


Public Overrides Property STLINT() as single
    Get
	    Return MyBase.STLINT
    End Get
    Set (byval value as single)
        MyBase.STLINT= value
    End Set
End property 


Public Overrides Property PTLINT() as single
    Get
	    Return MyBase.PTLINT
    End Get
    Set (byval value as single)
        MyBase.PTLINT= value
    End Set
End property 


Public Overrides Property CMLINT() as single
    Get
	    Return MyBase.CMLINT
    End Get
    Set (byval value as single)
        MyBase.CMLINT= value
    End Set
End property 


Public Overrides Property FALINT() as single
    Get
	    Return MyBase.FALINT
    End Get
    Set (byval value as single)
        MyBase.FALINT= value
    End Set
End property 


Public Overrides Property MPLINT() as single
    Get
	    Return MyBase.MPLINT
    End Get
    Set (byval value as single)
        MyBase.MPLINT= value
    End Set
End property 


Public Overrides Property XMAINT() as single
    Get
	    Return MyBase.XMAINT
    End Get
    Set (byval value as single)
        MyBase.XMAINT= value
    End Set
End property 


Public Overrides Property REC_STAT() as Boolean
    Get
	    Return MyBase.REC_STAT
    End Get
    Set (byval value as Boolean)
        MyBase.REC_STAT= value
    End Set
End property 


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements IRnterest.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements IRnterest.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements IRnterest.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Rnterest
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface IRnterest
        Inherits _IRnterest

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface