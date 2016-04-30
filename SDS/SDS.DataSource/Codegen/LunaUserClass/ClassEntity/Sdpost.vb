#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 20/06/2015 
#End Region



''' <summary>
'''Entity Class for table Sdpost
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Sdpost
	Inherits _Sdpost
    Implements ISdpost

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property ACCTNO() as string
    Get
	    Return MyBase.ACCTNO
    End Get
    Set (byval value as string)
        MyBase.ACCTNO= value
    End Set
End property 


Public Overrides Property KBCI_NO() as string
    Get
	    Return MyBase.KBCI_NO
    End Get
    Set (byval value as string)
        MyBase.KBCI_NO= value
    End Set
End property 


Public Overrides Property SDNAME() as string
    Get
	    Return MyBase.SDNAME
    End Get
    Set (byval value as string)
        MyBase.SDNAME= value
    End Set
End property 


Public Overrides Property CBEMPNO() as string
    Get
	    Return MyBase.CBEMPNO
    End Get
    Set (byval value as string)
        MyBase.CBEMPNO= value
    End Set
End property 


Public Overrides Property TDATE() as DateTime
    Get
	    Return MyBase.TDATE
    End Get
    Set (byval value as DateTime)
        MyBase.TDATE= value
    End Set
End property 


Public Overrides Property PAMT() as single
    Get
	    Return MyBase.PAMT
    End Get
    Set (byval value as single)
        MyBase.PAMT= value
    End Set
End property 


Public Overrides Property SDSEQ() as single
    Get
	    Return MyBase.SDSEQ
    End Get
    Set (byval value as single)
        MyBase.SDSEQ= value
    End Set
End property 


Public Overrides Property SDTIME() as string
    Get
	    Return MyBase.SDTIME
    End Get
    Set (byval value as string)
        MyBase.SDTIME= value
    End Set
End property 


Public Overrides Property SDBBAL() as single
    Get
	    Return MyBase.SDBBAL
    End Get
    Set (byval value as single)
        MyBase.SDBBAL= value
    End Set
End property 


Public Overrides Property SDEBAL() as single
    Get
	    Return MyBase.SDEBAL
    End Get
    Set (byval value as single)
        MyBase.SDEBAL= value
    End Set
End property 


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements ISdpost.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements ISdpost.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements ISdpost.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Sdpost
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface ISdpost
        Inherits _ISdpost

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface