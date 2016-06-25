#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 25/06/2016 
#End Region



''' <summary>
'''Entity Class for table Ctrl_s
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Ctrl_s
	Inherits _Ctrl_s
    Implements ICtrl_s

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property CTRL_S_ID() as Int64
    Get
	    Return MyBase.CTRL_S_ID
    End Get
    Set (byval value as Int64)
        MyBase.CTRL_S_ID= value
    End Set
End property 


Public Overrides Property SYSDATE() as DateTime
    Get
	    Return MyBase.SYSDATE
    End Get
    Set (byval value as DateTime)
        MyBase.SYSDATE= value
    End Set
End property 


Public Overrides Property ADMDATE() as DateTime
    Get
	    Return MyBase.ADMDATE
    End Get
    Set (byval value as DateTime)
        MyBase.ADMDATE= value
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


Public Overrides Property SDRATE() as single
    Get
	    Return MyBase.SDRATE
    End Get
    Set (byval value as single)
        MyBase.SDRATE= value
    End Set
End property 


Public Overrides Property ACCTBR() as string
    Get
	    Return MyBase.ACCTBR
    End Get
    Set (byval value as string)
        MyBase.ACCTBR= value
    End Set
End property 


Public Overrides Property ACCTSEQ() as single
    Get
	    Return MyBase.ACCTSEQ
    End Get
    Set (byval value as single)
        MyBase.ACCTSEQ= value
    End Set
End property 


Public Overrides Property PMAXL() as single
    Get
	    Return MyBase.PMAXL
    End Get
    Set (byval value as single)
        MyBase.PMAXL= value
    End Set
End property 


Public Overrides Property LMAXL() as single
    Get
	    Return MyBase.LMAXL
    End Get
    Set (byval value as single)
        MyBase.LMAXL= value
    End Set
End property 


Public Overrides Property BINIT() as Boolean
    Get
	    Return MyBase.BINIT
    End Get
    Set (byval value as Boolean)
        MyBase.BINIT= value
    End Set
End property 


Public Overrides Property BPOST() as Boolean
    Get
	    Return MyBase.BPOST
    End Get
    Set (byval value as Boolean)
        MyBase.BPOST= value
    End Set
End property 


Public Overrides Property CLR_ONUS() as single
    Get
	    Return MyBase.CLR_ONUS
    End Get
    Set (byval value as single)
        MyBase.CLR_ONUS= value
    End Set
End property 


Public Overrides Property CLR_LOCAL() as single
    Get
	    Return MyBase.CLR_LOCAL
    End Get
    Set (byval value as single)
        MyBase.CLR_LOCAL= value
    End Set
End property 


Public Overrides Property CLR_REG() as single
    Get
	    Return MyBase.CLR_REG
    End Get
    Set (byval value as single)
        MyBase.CLR_REG= value
    End Set
End property 


Public Overrides Property MINBAL() as single
    Get
	    Return MyBase.MINBAL
    End Get
    Set (byval value as single)
        MyBase.MINBAL= value
    End Set
End property 


Public Overrides Property DBDORMANT() as single
    Get
	    Return MyBase.DBDORMANT
    End Get
    Set (byval value as single)
        MyBase.DBDORMANT= value
    End Set
End property 


Public Overrides Property EOM_FLAG() as Boolean
    Get
	    Return MyBase.EOM_FLAG
    End Get
    Set (byval value as Boolean)
        MyBase.EOM_FLAG= value
    End Set
End property 


Public Overrides Property EOQ_FLAG() as Boolean
    Get
	    Return MyBase.EOQ_FLAG
    End Get
    Set (byval value as Boolean)
        MyBase.EOQ_FLAG= value
    End Set
End property 


Public Overrides Property EOY_FLAG() as Boolean
    Get
	    Return MyBase.EOY_FLAG
    End Get
    Set (byval value as Boolean)
        MyBase.EOY_FLAG= value
    End Set
End property 


Public Overrides Property OTC_FLAG() as Boolean
    Get
	    Return MyBase.OTC_FLAG
    End Get
    Set (byval value as Boolean)
        MyBase.OTC_FLAG= value
    End Set
End property 


Public Overrides Property EOD_FLAG() as Boolean
    Get
	    Return MyBase.EOD_FLAG
    End Get
    Set (byval value as Boolean)
        MyBase.EOD_FLAG= value
    End Set
End property 


Public Overrides Property P_PRINT() as string
    Get
	    Return MyBase.P_PRINT
    End Get
    Set (byval value as string)
        MyBase.P_PRINT= value
    End Set
End property 


Public Overrides Property R_PRINT() as string
    Get
	    Return MyBase.R_PRINT
    End Get
    Set (byval value as string)
        MyBase.R_PRINT= value
    End Set
End property 


Public Overrides Property DormancyCharge() as single
    Get
	    Return MyBase.DormancyCharge
    End Get
    Set (byval value as single)
        MyBase.DormancyCharge= value
    End Set
End property 


Public Overrides Property MinimumInterestEarningBalance() as single
    Get
	    Return MyBase.MinimumInterestEarningBalance
    End Get
    Set (byval value as single)
        MyBase.MinimumInterestEarningBalance= value
    End Set
End property 


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements ICtrl_s.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements ICtrl_s.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements ICtrl_s.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Ctrl_s
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface ICtrl_s
        Inherits _ICtrl_s

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface