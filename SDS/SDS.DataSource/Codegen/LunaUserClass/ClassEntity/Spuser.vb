#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 20/06/2015 
#End Region



''' <summary>
'''Entity Class for table Spuser
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Spuser
	Inherits _Spuser
    Implements ISpuser

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property SPUSER_ID() as Int64
    Get
	    Return MyBase.SPUSER_ID
    End Get
    Set (byval value as Int64)
        MyBase.SPUSER_ID= value
    End Set
End property 


Public Overrides Property SPUSERID() as string
    Get
	    Return MyBase.SPUSERID
    End Get
    Set (byval value as string)
        MyBase.SPUSERID= value
    End Set
End property 


Public Overrides Property SPUSERPASS() as string
    Get
	    Return MyBase.SPUSERPASS
    End Get
    Set (byval value as string)
        MyBase.SPUSERPASS= value
    End Set
End property 


Public Overrides Property SPUSERNAME() as string
    Get
	    Return MyBase.SPUSERNAME
    End Get
    Set (byval value as string)
        MyBase.SPUSERNAME= value
    End Set
End property 


Public Overrides Property SPUSERPOS() as string
    Get
	    Return MyBase.SPUSERPOS
    End Get
    Set (byval value as string)
        MyBase.SPUSERPOS= value
    End Set
End property 


Public Overrides Property SPLOGSTAT() as Boolean
    Get
	    Return MyBase.SPLOGSTAT
    End Get
    Set (byval value as Boolean)
        MyBase.SPLOGSTAT= value
    End Set
End property 


Public Overrides Property SPLOGNO() as single
    Get
	    Return MyBase.SPLOGNO
    End Get
    Set (byval value as single)
        MyBase.SPLOGNO= value
    End Set
End property 


Public Overrides Property SPTELLER() as Boolean
    Get
	    Return MyBase.SPTELLER
    End Get
    Set (byval value as Boolean)
        MyBase.SPTELLER= value
    End Set
End property 


Public Overrides Property SPTAG() as string
    Get
	    Return MyBase.SPTAG
    End Get
    Set (byval value as string)
        MyBase.SPTAG= value
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


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements ISpuser.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements ISpuser.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements ISpuser.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Spuser
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface ISpuser
        Inherits _ISpuser

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface