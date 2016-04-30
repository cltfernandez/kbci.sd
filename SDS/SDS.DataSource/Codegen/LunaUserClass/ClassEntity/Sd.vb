#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 20/06/2015 
#End Region



''' <summary>
'''Entity Class for table Sd
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Sd
	Inherits _Sd
    Implements ISd

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property SD_ID() as Int64
    Get
	    Return MyBase.SD_ID
    End Get
    Set (byval value as Int64)
        MyBase.SD_ID= value
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


Public Overrides Property FEBTC_SA() as string
    Get
	    Return MyBase.FEBTC_SA
    End Get
    Set (byval value as string)
        MyBase.FEBTC_SA= value
    End Set
End property 


Public Overrides Property TRAN_CODE() as string
    Get
	    Return MyBase.TRAN_CODE
    End Get
    Set (byval value as string)
        MyBase.TRAN_CODE= value
    End Set
End property 


    Public Overrides Property SDDATE() As DateTime
        Get
            Return MyBase.SDDATE
        End Get
        Set(ByVal value As DateTime)
            MyBase.SDDATE = value
        End Set
    End Property


Public Overrides Property REF() as string
    Get
	    Return MyBase.REF
    End Get
    Set (byval value as string)
        MyBase.REF= value
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


Public Overrides Property BALANCE() as single
    Get
	    Return MyBase.BALANCE
    End Get
    Set (byval value as single)
        MyBase.BALANCE= value
    End Set
End property 


Public Overrides Property RMK() as string
    Get
	    Return MyBase.RMK
    End Get
    Set (byval value as string)
        MyBase.RMK= value
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

Public Overrides Function IsValid() As Boolean Implements ISd.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements ISd.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements ISd.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Sd
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface ISd
        Inherits _ISd

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface