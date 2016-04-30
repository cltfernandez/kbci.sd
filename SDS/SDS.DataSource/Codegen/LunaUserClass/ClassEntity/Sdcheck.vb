#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 20/06/2015 
#End Region



''' <summary>
'''Entity Class for table Sdcheck
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Sdcheck
	Inherits _Sdcheck
    Implements ISdcheck

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property SDCHECK_ID() as Int64
    Get
	    Return MyBase.SDCHECK_ID
    End Get
    Set (byval value as Int64)
        MyBase.SDCHECK_ID= value
    End Set
End property 


Public Overrides Property ACCTNUM() as string
    Get
	    Return MyBase.ACCTNUM
    End Get
    Set (byval value as string)
        MyBase.ACCTNUM= value
    End Set
End property 


Public Overrides Property TRANDATE() as DateTime
    Get
	    Return MyBase.TRANDATE
    End Get
    Set (byval value as DateTime)
        MyBase.TRANDATE= value
    End Set
End property 


Public Overrides Property TRANSEQ() as single
    Get
	    Return MyBase.TRANSEQ
    End Get
    Set (byval value as single)
        MyBase.TRANSEQ= value
    End Set
End property 


Public Overrides Property CHKCODE() as string
    Get
	    Return MyBase.CHKCODE
    End Get
    Set (byval value as string)
        MyBase.CHKCODE= value
    End Set
End property 


Public Overrides Property CHKAMT() as single
    Get
	    Return MyBase.CHKAMT
    End Get
    Set (byval value as single)
        MyBase.CHKAMT= value
    End Set
End property 


Public Overrides Property CHKNUM() as string
    Get
	    Return MyBase.CHKNUM
    End Get
    Set (byval value as string)
        MyBase.CHKNUM= value
    End Set
End property 


Public Overrides Property CHKBANK() as string
    Get
	    Return MyBase.CHKBANK
    End Get
    Set (byval value as string)
        MyBase.CHKBANK= value
    End Set
End property 


Public Overrides Property CHKCDATE() as DateTime
    Get
	    Return MyBase.CHKCDATE
    End Get
    Set (byval value as DateTime)
        MyBase.CHKCDATE= value
    End Set
End property 


Public Overrides Property CHKCDAYS() as single
    Get
	    Return MyBase.CHKCDAYS
    End Get
    Set (byval value as single)
        MyBase.CHKCDAYS= value
    End Set
End property 


Public Overrides Property CHKNDAYS() as single
    Get
	    Return MyBase.CHKNDAYS
    End Get
    Set (byval value as single)
        MyBase.CHKNDAYS= value
    End Set
End property 


Public Overrides Property CHKSTAT() as string
    Get
	    Return MyBase.CHKSTAT
    End Get
    Set (byval value as string)
        MyBase.CHKSTAT= value
    End Set
End property 


Public Overrides Property ADD_DATE() as DateTime
    Get
	    Return MyBase.ADD_DATE
    End Get
    Set (byval value as DateTime)
        MyBase.ADD_DATE= value
    End Set
End property 


Public Overrides Property ADD_TIME() as string
    Get
	    Return MyBase.ADD_TIME
    End Get
    Set (byval value as string)
        MyBase.ADD_TIME= value
    End Set
End property 


Public Overrides Property USER() as string
    Get
	    Return MyBase.USER
    End Get
    Set (byval value as string)
        MyBase.USER= value
    End Set
End property 


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements ISdcheck.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements ISdcheck.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements ISdcheck.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Sdcheck
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface ISdcheck
        Inherits _ISdcheck

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface