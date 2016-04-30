#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 20/06/2015 
#End Region



''' <summary>
'''Entity Class for table Spteller
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Spteller
	Inherits _Spteller
    Implements ISpteller

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property SPTELLER_ID() as Int64
    Get
	    Return MyBase.SPTELLER_ID
    End Get
    Set (byval value as Int64)
        MyBase.SPTELLER_ID= value
    End Set
End property 


Public Overrides Property TNAME() as string
    Get
	    Return MyBase.TNAME
    End Get
    Set (byval value as string)
        MyBase.TNAME= value
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


Public Overrides Property CASHB() as single
    Get
	    Return MyBase.CASHB
    End Get
    Set (byval value as single)
        MyBase.CASHB= value
    End Set
End property 


Public Overrides Property COCIB() as single
    Get
	    Return MyBase.COCIB
    End Get
    Set (byval value as single)
        MyBase.COCIB= value
    End Set
End property 


Public Overrides Property ADDLREQ() as single
    Get
	    Return MyBase.ADDLREQ
    End Get
    Set (byval value as single)
        MyBase.ADDLREQ= value
    End Set
End property 


Public Overrides Property ADDMREQ() as single
    Get
	    Return MyBase.ADDMREQ
    End Get
    Set (byval value as single)
        MyBase.ADDMREQ= value
    End Set
End property 


Public Overrides Property CASHSAV() as single
    Get
	    Return MyBase.CASHSAV
    End Get
    Set (byval value as single)
        MyBase.CASHSAV= value
    End Set
End property 


Public Overrides Property CASHOR() as single
    Get
	    Return MyBase.CASHOR
    End Get
    Set (byval value as single)
        MyBase.CASHOR= value
    End Set
End property 


Public Overrides Property ADDLTD() as single
    Get
	    Return MyBase.ADDLTD
    End Get
    Set (byval value as single)
        MyBase.ADDLTD= value
    End Set
End property 


Public Overrides Property CTFNAME1() as string
    Get
	    Return MyBase.CTFNAME1
    End Get
    Set (byval value as string)
        MyBase.CTFNAME1= value
    End Set
End property 


Public Overrides Property CTFAMT1() as single
    Get
	    Return MyBase.CTFAMT1
    End Get
    Set (byval value as single)
        MyBase.CTFAMT1= value
    End Set
End property 


Public Overrides Property CTFNAME2() as string
    Get
	    Return MyBase.CTFNAME2
    End Get
    Set (byval value as string)
        MyBase.CTFNAME2= value
    End Set
End property 


Public Overrides Property CTFAMT2() as single
    Get
	    Return MyBase.CTFAMT2
    End Get
    Set (byval value as single)
        MyBase.CTFAMT2= value
    End Set
End property 


Public Overrides Property CTFNAME3() as string
    Get
	    Return MyBase.CTFNAME3
    End Get
    Set (byval value as string)
        MyBase.CTFNAME3= value
    End Set
End property 


Public Overrides Property CTFAMT3() as single
    Get
	    Return MyBase.CTFAMT3
    End Get
    Set (byval value as single)
        MyBase.CTFAMT3= value
    End Set
End property 


Public Overrides Property ADDCASH() as single
    Get
	    Return MyBase.ADDCASH
    End Get
    Set (byval value as single)
        MyBase.ADDCASH= value
    End Set
End property 


Public Overrides Property CRSAV() as single
    Get
	    Return MyBase.CRSAV
    End Get
    Set (byval value as single)
        MyBase.CRSAV= value
    End Set
End property 


Public Overrides Property CRORO() as single
    Get
	    Return MyBase.CRORO
    End Get
    Set (byval value as single)
        MyBase.CRORO= value
    End Set
End property 


Public Overrides Property CRACC() as single
    Get
	    Return MyBase.CRACC
    End Get
    Set (byval value as single)
        MyBase.CRACC= value
    End Set
End property 


Public Overrides Property CRCR() as single
    Get
	    Return MyBase.CRCR
    End Get
    Set (byval value as single)
        MyBase.CRCR= value
    End Set
End property 


Public Overrides Property ADDCHECKS() as single
    Get
	    Return MyBase.ADDCHECKS
    End Get
    Set (byval value as single)
        MyBase.ADDCHECKS= value
    End Set
End property 


Public Overrides Property ADDTOTAL() as single
    Get
	    Return MyBase.ADDTOTAL
    End Get
    Set (byval value as single)
        MyBase.ADDTOTAL= value
    End Set
End property 


Public Overrides Property DIB() as single
    Get
	    Return MyBase.DIB
    End Get
    Set (byval value as single)
        MyBase.DIB= value
    End Set
End property 


Public Overrides Property REF() as single
    Get
	    Return MyBase.REF
    End Get
    Set (byval value as single)
        MyBase.REF= value
    End Set
End property 


    Public Overrides Property SDWITH() As Single
        Get
            Return MyBase.SDWITH
        End Get
        Set(ByVal value As Single)
            MyBase.SDWITH = value
        End Set
    End Property


Public Overrides Property CHKENC() as single
    Get
	    Return MyBase.CHKENC
    End Get
    Set (byval value as single)
        MyBase.CHKENC= value
    End Set
End property 


Public Overrides Property COCI() as single
    Get
	    Return MyBase.COCI
    End Get
    Set (byval value as single)
        MyBase.COCI= value
    End Set
End property 


Public Overrides Property CHKDEP() as single
    Get
	    Return MyBase.CHKDEP
    End Get
    Set (byval value as single)
        MyBase.CHKDEP= value
    End Set
End property 


Public Overrides Property EMER() as single
    Get
	    Return MyBase.EMER
    End Get
    Set (byval value as single)
        MyBase.EMER= value
    End Set
End property 


Public Overrides Property CTTNAME1() as string
    Get
	    Return MyBase.CTTNAME1
    End Get
    Set (byval value as string)
        MyBase.CTTNAME1= value
    End Set
End property 


Public Overrides Property CTTAMT1() as single
    Get
	    Return MyBase.CTTAMT1
    End Get
    Set (byval value as single)
        MyBase.CTTAMT1= value
    End Set
End property 


Public Overrides Property CTTNAME2() as string
    Get
	    Return MyBase.CTTNAME2
    End Get
    Set (byval value as string)
        MyBase.CTTNAME2= value
    End Set
End property 


Public Overrides Property CTTAMT2() as single
    Get
	    Return MyBase.CTTAMT2
    End Get
    Set (byval value as single)
        MyBase.CTTAMT2= value
    End Set
End property 


Public Overrides Property CTTNAME3() as string
    Get
	    Return MyBase.CTTNAME3
    End Get
    Set (byval value as string)
        MyBase.CTTNAME3= value
    End Set
End property 


Public Overrides Property CTTAMT3() as single
    Get
	    Return MyBase.CTTAMT3
    End Get
    Set (byval value as single)
        MyBase.CTTAMT3= value
    End Set
End property 


Public Overrides Property TOTDISB() as single
    Get
	    Return MyBase.TOTDISB
    End Get
    Set (byval value as single)
        MyBase.TOTDISB= value
    End Set
End property 


Public Overrides Property CBALEND() as single
    Get
	    Return MyBase.CBALEND
    End Get
    Set (byval value as single)
        MyBase.CBALEND= value
    End Set
End property 


Public Overrides Property CTTCEND() as single
    Get
	    Return MyBase.CTTCEND
    End Get
    Set (byval value as single)
        MyBase.CTTCEND= value
    End Set
End property 


Public Overrides Property OVER() as single
    Get
	    Return MyBase.OVER
    End Get
    Set (byval value as single)
        MyBase.OVER= value
    End Set
End property 


Public Overrides Property B_1000() as single
    Get
	    Return MyBase.B_1000
    End Get
    Set (byval value as single)
        MyBase.B_1000= value
    End Set
End property 


Public Overrides Property B_500() as single
    Get
	    Return MyBase.B_500
    End Get
    Set (byval value as single)
        MyBase.B_500= value
    End Set
End property 


Public Overrides Property B_200() as single
    Get
	    Return MyBase.B_200
    End Get
    Set (byval value as single)
        MyBase.B_200= value
    End Set
End property 


Public Overrides Property B_100() as single
    Get
	    Return MyBase.B_100
    End Get
    Set (byval value as single)
        MyBase.B_100= value
    End Set
End property 


Public Overrides Property B_50() as single
    Get
	    Return MyBase.B_50
    End Get
    Set (byval value as single)
        MyBase.B_50= value
    End Set
End property 


Public Overrides Property B_20() as single
    Get
	    Return MyBase.B_20
    End Get
    Set (byval value as single)
        MyBase.B_20= value
    End Set
End property 


Public Overrides Property B_10() as single
    Get
	    Return MyBase.B_10
    End Get
    Set (byval value as single)
        MyBase.B_10= value
    End Set
End property 


Public Overrides Property B_5() as single
    Get
	    Return MyBase.B_5
    End Get
    Set (byval value as single)
        MyBase.B_5= value
    End Set
End property 


Public Overrides Property B_1() as single
    Get
	    Return MyBase.B_1
    End Get
    Set (byval value as single)
        MyBase.B_1= value
    End Set
End property 


Public Overrides Property B_P50() as single
    Get
	    Return MyBase.B_P50
    End Get
    Set (byval value as single)
        MyBase.B_P50= value
    End Set
End property 


Public Overrides Property B_P25() as single
    Get
	    Return MyBase.B_P25
    End Get
    Set (byval value as single)
        MyBase.B_P25= value
    End Set
End property 


Public Overrides Property B_P10() as single
    Get
	    Return MyBase.B_P10
    End Get
    Set (byval value as single)
        MyBase.B_P10= value
    End Set
End property 


Public Overrides Property B_P05() as single
    Get
	    Return MyBase.B_P05
    End Get
    Set (byval value as single)
        MyBase.B_P05= value
    End Set
End property 


Public Overrides Property B_P01() as single
    Get
	    Return MyBase.B_P01
    End Get
    Set (byval value as single)
        MyBase.B_P01= value
    End Set
End property 


Public Overrides Property TCCOUNT() as single
    Get
	    Return MyBase.TCCOUNT
    End Get
    Set (byval value as single)
        MyBase.TCCOUNT= value
    End Set
End property 


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements ISpteller.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements ISpteller.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements ISpteller.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Spteller
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface ISpteller
        Inherits _ISpteller

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface