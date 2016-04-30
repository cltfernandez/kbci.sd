#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 20/06/2015 
#End Region



''' <summary>
'''Entity Class for table Sdmaster
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Sdmaster
	Inherits _Sdmaster
    Implements ISdmaster

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property SDMASTER_ID() as Int64
    Get
	    Return MyBase.SDMASTER_ID
    End Get
    Set (byval value as Int64)
        MyBase.SDMASTER_ID= value
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


Public Overrides Property KBCI_NO() as string
    Get
	    Return MyBase.KBCI_NO
    End Get
    Set (byval value as string)
        MyBase.KBCI_NO= value
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


Public Overrides Property ACCTNAME() as string
    Get
	    Return MyBase.ACCTNAME
    End Get
    Set (byval value as string)
        MyBase.ACCTNAME= value
    End Set
End property 


Public Overrides Property ACCTADDR1() as string
    Get
	    Return MyBase.ACCTADDR1
    End Get
    Set (byval value as string)
        MyBase.ACCTADDR1= value
    End Set
End property 


Public Overrides Property ACCTADDR2() as string
    Get
	    Return MyBase.ACCTADDR2
    End Get
    Set (byval value as string)
        MyBase.ACCTADDR2= value
    End Set
End property 


Public Overrides Property ACCTSNAME() as string
    Get
	    Return MyBase.ACCTSNAME
    End Get
    Set (byval value as string)
        MyBase.ACCTSNAME= value
    End Set
End property 


Public Overrides Property ACCTPHONE1() as string
    Get
	    Return MyBase.ACCTPHONE1
    End Get
    Set (byval value as string)
        MyBase.ACCTPHONE1= value
    End Set
End property 


Public Overrides Property ACCTPHONE2() as string
    Get
	    Return MyBase.ACCTPHONE2
    End Get
    Set (byval value as string)
        MyBase.ACCTPHONE2= value
    End Set
End property 


Public Overrides Property ACCTDTYPE() as string
    Get
	    Return MyBase.ACCTDTYPE
    End Get
    Set (byval value as string)
        MyBase.ACCTDTYPE= value
    End Set
End property 


Public Overrides Property ACCTCCODE() as string
    Get
	    Return MyBase.ACCTCCODE
    End Get
    Set (byval value as string)
        MyBase.ACCTCCODE= value
    End Set
End property 


Public Overrides Property ACCTICODE() as string
    Get
	    Return MyBase.ACCTICODE
    End Get
    Set (byval value as string)
        MyBase.ACCTICODE= value
    End Set
End property 


Public Overrides Property ACCTATX() as string
    Get
	    Return MyBase.ACCTATX
    End Get
    Set (byval value as string)
        MyBase.ACCTATX= value
    End Set
End property 


Public Overrides Property ACCTOTH1() as string
    Get
	    Return MyBase.ACCTOTH1
    End Get
    Set (byval value as string)
        MyBase.ACCTOTH1= value
    End Set
End property 


Public Overrides Property ACCTOTH2() as string
    Get
	    Return MyBase.ACCTOTH2
    End Get
    Set (byval value as string)
        MyBase.ACCTOTH2= value
    End Set
End property 


Public Overrides Property ACCTMAINT() as single
    Get
	    Return MyBase.ACCTMAINT
    End Get
    Set (byval value as single)
        MyBase.ACCTMAINT= value
    End Set
End property 


Public Overrides Property ACCTIDEP() as single
    Get
	    Return MyBase.ACCTIDEP
    End Get
    Set (byval value as single)
        MyBase.ACCTIDEP= value
    End Set
End property 


Public Overrides Property ACCTPBAL() as single
    Get
	    Return MyBase.ACCTPBAL
    End Get
    Set (byval value as single)
        MyBase.ACCTPBAL= value
    End Set
End property 


Public Overrides Property ACCTLBAL() as single
    Get
	    Return MyBase.ACCTLBAL
    End Get
    Set (byval value as single)
        MyBase.ACCTLBAL= value
    End Set
End property 


Public Overrides Property ACCTOBAL() as single
    Get
	    Return MyBase.ACCTOBAL
    End Get
    Set (byval value as single)
        MyBase.ACCTOBAL= value
    End Set
End property 


Public Overrides Property ACCTABAL() as single
    Get
	    Return MyBase.ACCTABAL
    End Get
    Set (byval value as single)
        MyBase.ACCTABAL= value
    End Set
End property 


Public Overrides Property ACCTFLOATS() as single
    Get
	    Return MyBase.ACCTFLOATS
    End Get
    Set (byval value as single)
        MyBase.ACCTFLOATS= value
    End Set
End property 


Public Overrides Property ACCTTEX() as string
    Get
	    Return MyBase.ACCTTEX
    End Get
    Set (byval value as string)
        MyBase.ACCTTEX= value
    End Set
End property 


Public Overrides Property ACCTACLO() as string
    Get
	    Return MyBase.ACCTACLO
    End Get
    Set (byval value as string)
        MyBase.ACCTACLO= value
    End Set
End property 


Public Overrides Property ACCTWMIN() as string
    Get
	    Return MyBase.ACCTWMIN
    End Get
    Set (byval value as string)
        MyBase.ACCTWMIN= value
    End Set
End property 


Public Overrides Property ACCTWSC() as string
    Get
	    Return MyBase.ACCTWSC
    End Get
    Set (byval value as string)
        MyBase.ACCTWSC= value
    End Set
End property 


Public Overrides Property ACCTWINT() as string
    Get
	    Return MyBase.ACCTWINT
    End Get
    Set (byval value as string)
        MyBase.ACCTWINT= value
    End Set
End property 


Public Overrides Property ACCTSTAT() as string
    Get
	    Return MyBase.ACCTSTAT
    End Get
    Set (byval value as string)
        MyBase.ACCTSTAT= value
    End Set
End property 


Public Overrides Property PLINE() as single
    Get
	    Return MyBase.PLINE
    End Get
    Set (byval value as single)
        MyBase.PLINE= value
    End Set
End property 


Public Overrides Property LLINE() as single
    Get
	    Return MyBase.LLINE
    End Get
    Set (byval value as single)
        MyBase.LLINE= value
    End Set
End property 


Public Overrides Property UNPOSTED() as single
    Get
	    Return MyBase.UNPOSTED
    End Get
    Set (byval value as single)
        MyBase.UNPOSTED= value
    End Set
End property 


Public Overrides Property HOLDOUT() as single
    Get
	    Return MyBase.HOLDOUT
    End Get
    Set (byval value as single)
        MyBase.HOLDOUT= value
    End Set
End property 


Public Overrides Property LSEQ() as single
    Get
	    Return MyBase.LSEQ
    End Get
    Set (byval value as single)
        MyBase.LSEQ= value
    End Set
End property 


Public Overrides Property LTRANDATE() as DateTime
    Get
	    Return MyBase.LTRANDATE
    End Get
    Set (byval value as DateTime)
        MyBase.LTRANDATE= value
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


Public Overrides Property UPD_USER() as string
    Get
	    Return MyBase.UPD_USER
    End Get
    Set (byval value as string)
        MyBase.UPD_USER= value
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

Public Overrides Function IsValid() As Boolean Implements ISdmaster.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements ISdmaster.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements ISdmaster.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Sdmaster
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface ISdmaster
        Inherits _ISdmaster

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface