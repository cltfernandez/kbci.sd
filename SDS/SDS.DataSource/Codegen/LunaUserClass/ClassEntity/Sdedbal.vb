#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 20/06/2015 
#End Region



''' <summary>
'''Entity Class for table Sdedbal
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Sdedbal
	Inherits _Sdedbal
    Implements ISdedbal

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property SDEDBAL_ID() as Int64
    Get
	    Return MyBase.SDEDBAL_ID
    End Get
    Set (byval value as Int64)
        MyBase.SDEDBAL_ID= value
    End Set
End property 


Public Overrides Property ID() as string
    Get
	    Return MyBase.ID
    End Get
    Set (byval value as string)
        MyBase.ID= value
    End Set
End property 


Public Overrides Property PN_TAG() as Boolean
    Get
	    Return MyBase.PN_TAG
    End Get
    Set (byval value as Boolean)
        MyBase.PN_TAG= value
    End Set
End property 


Public Overrides Property PN_NO() as string
    Get
	    Return MyBase.PN_NO
    End Get
    Set (byval value as string)
        MyBase.PN_NO= value
    End Set
End property 


Public Overrides Property LOAN_TYPE() as string
    Get
	    Return MyBase.LOAN_TYPE
    End Get
    Set (byval value as string)
        MyBase.LOAN_TYPE= value
    End Set
End property 


Public Overrides Property LOAN_STAT() as string
    Get
	    Return MyBase.LOAN_STAT
    End Get
    Set (byval value as string)
        MyBase.LOAN_STAT= value
    End Set
End property 


Public Overrides Property DATE_GRANT() as DateTime
    Get
	    Return MyBase.DATE_GRANT
    End Get
    Set (byval value as DateTime)
        MyBase.DATE_GRANT= value
    End Set
End property 


Public Overrides Property DATE_DUE() as DateTime
    Get
	    Return MyBase.DATE_DUE
    End Get
    Set (byval value as DateTime)
        MyBase.DATE_DUE= value
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


Public Overrides Property PRINCIPAL() as single
    Get
	    Return MyBase.PRINCIPAL
    End Get
    Set (byval value as single)
        MyBase.PRINCIPAL= value
    End Set
End property 


Public Overrides Property OUTSBAL() as single
    Get
	    Return MyBase.OUTSBAL
    End Get
    Set (byval value as single)
        MyBase.OUTSBAL= value
    End Set
End property 


Public Overrides Property RENEW() as Boolean
    Get
	    Return MyBase.RENEW
    End Get
    Set (byval value as Boolean)
        MyBase.RENEW= value
    End Set
End property 


Public Overrides Property ARREARS() as single
    Get
	    Return MyBase.ARREARS
    End Get
    Set (byval value as single)
        MyBase.ARREARS= value
    End Set
End property 


Public Overrides Property PAY_TAG() as string
    Get
	    Return MyBase.PAY_TAG
    End Get
    Set (byval value as string)
        MyBase.PAY_TAG= value
    End Set
End property 


Public Overrides Property PAY_AMT() as single
    Get
	    Return MyBase.PAY_AMT
    End Get
    Set (byval value as single)
        MyBase.PAY_AMT= value
    End Set
End property 


Public Overrides Property LRI_DUE() as single
    Get
	    Return MyBase.LRI_DUE
    End Get
    Set (byval value as single)
        MyBase.LRI_DUE= value
    End Set
End property 


Public Overrides Property YEARLY_LRI() as single
    Get
	    Return MyBase.YEARLY_LRI
    End Get
    Set (byval value as single)
        MyBase.YEARLY_LRI= value
    End Set
End property 


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements ISdedbal.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements ISdedbal.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements ISdedbal.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Sdedbal
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface ISdedbal
        Inherits _ISdedbal

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface