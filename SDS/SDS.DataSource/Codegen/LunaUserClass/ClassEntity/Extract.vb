#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 20/06/2015 
#End Region



''' <summary>
'''Entity Class for table Extract
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Extract
	Inherits _Extract
    Implements IExtract

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property PN_NO() as string
    Get
	    Return MyBase.PN_NO
    End Get
    Set (byval value as string)
        MyBase.PN_NO= value
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


Public Overrides Property LOAN_TYPE() as string
    Get
	    Return MyBase.LOAN_TYPE
    End Get
    Set (byval value as string)
        MyBase.LOAN_TYPE= value
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


Public Overrides Property CHG_DATE() as DateTime
    Get
	    Return MyBase.CHG_DATE
    End Get
    Set (byval value as DateTime)
        MyBase.CHG_DATE= value
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


Public Overrides Property AMOUNT() as single
    Get
	    Return MyBase.AMOUNT
    End Get
    Set (byval value as single)
        MyBase.AMOUNT= value
    End Set
End property 


Public Overrides Property REMARKS() as string
    Get
	    Return MyBase.REMARKS
    End Get
    Set (byval value as string)
        MyBase.REMARKS= value
    End Set
End property 


Public Overrides Property SAVINGS() as Boolean
    Get
	    Return MyBase.SAVINGS
    End Get
    Set (byval value as Boolean)
        MyBase.SAVINGS= value
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


Public Overrides Property STATUS() as string
    Get
	    Return MyBase.STATUS
    End Get
    Set (byval value as string)
        MyBase.STATUS= value
    End Set
End property 


Public Overrides Property EXSEQ() as single
    Get
	    Return MyBase.EXSEQ
    End Get
    Set (byval value as single)
        MyBase.EXSEQ= value
    End Set
End property 


Public Overrides Property EXTIME() as string
    Get
	    Return MyBase.EXTIME
    End Get
    Set (byval value as string)
        MyBase.EXTIME= value
    End Set
End property 


Public Overrides Property EXBBAL() as single
    Get
	    Return MyBase.EXBBAL
    End Get
    Set (byval value as single)
        MyBase.EXBBAL= value
    End Set
End property 


Public Overrides Property EXEBAL() as single
    Get
	    Return MyBase.EXEBAL
    End Get
    Set (byval value as single)
        MyBase.EXEBAL= value
    End Set
End property 


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements IExtract.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements IExtract.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements IExtract.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Extract
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface IExtract
        Inherits _IExtract

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface