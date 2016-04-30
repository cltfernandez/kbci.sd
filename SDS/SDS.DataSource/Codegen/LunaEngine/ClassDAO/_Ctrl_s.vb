#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 20/06/2015 
#End Region


Imports System.Xml.Serialization

''' <summary>
'''DAO Class for table Ctrl_s
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Ctrl_s
	Inherits LUNA.LunaBaseClassEntity
    Implements _ICtrl_s
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _ICtrl_s.FillFromDataRecord
     CTRL_S_ID = myRecord("CTRL_S_ID")
    		if not myRecord("SYSDATE") is DBNull.Value then SYSDATE = myRecord("SYSDATE")
    		if not myRecord("ADMDATE") is DBNull.Value then ADMDATE = myRecord("ADMDATE")
    		if not myRecord("ADD_DATE") is DBNull.Value then ADD_DATE = myRecord("ADD_DATE")
    		if not myRecord("CHG_DATE") is DBNull.Value then CHG_DATE = myRecord("CHG_DATE")
    		if not myRecord("USER") is DBNull.Value then USER = myRecord("USER")
    		if not myRecord("SDRATE") is DBNull.Value then SDRATE = myRecord("SDRATE")
    		if not myRecord("ACCTBR") is DBNull.Value then ACCTBR = myRecord("ACCTBR")
    		if not myRecord("ACCTSEQ") is DBNull.Value then ACCTSEQ = myRecord("ACCTSEQ")
    		if not myRecord("PMAXL") is DBNull.Value then PMAXL = myRecord("PMAXL")
    		if not myRecord("LMAXL") is DBNull.Value then LMAXL = myRecord("LMAXL")
    		if not myRecord("BINIT") is DBNull.Value then BINIT = myRecord("BINIT")
    		if not myRecord("BPOST") is DBNull.Value then BPOST = myRecord("BPOST")
    		if not myRecord("CLR_ONUS") is DBNull.Value then CLR_ONUS = myRecord("CLR_ONUS")
    		if not myRecord("CLR_LOCAL") is DBNull.Value then CLR_LOCAL = myRecord("CLR_LOCAL")
    		if not myRecord("CLR_REG") is DBNull.Value then CLR_REG = myRecord("CLR_REG")
    		if not myRecord("MINBAL") is DBNull.Value then MINBAL = myRecord("MINBAL")
    		if not myRecord("DBDORMANT") is DBNull.Value then DBDORMANT = myRecord("DBDORMANT")
    		if not myRecord("EOM_FLAG") is DBNull.Value then EOM_FLAG = myRecord("EOM_FLAG")
    		if not myRecord("EOQ_FLAG") is DBNull.Value then EOQ_FLAG = myRecord("EOQ_FLAG")
    		if not myRecord("EOY_FLAG") is DBNull.Value then EOY_FLAG = myRecord("EOY_FLAG")
    		if not myRecord("OTC_FLAG") is DBNull.Value then OTC_FLAG = myRecord("OTC_FLAG")
    		if not myRecord("EOD_FLAG") is DBNull.Value then EOD_FLAG = myRecord("EOD_FLAG")
    		if not myRecord("P_PRINT") is DBNull.Value then P_PRINT = myRecord("P_PRINT")
    		if not myRecord("R_PRINT") is DBNull.Value then R_PRINT = myRecord("R_PRINT")
    		if not myRecord("DormancyCharge") is DBNull.Value then DormancyCharge = myRecord("DormancyCharge")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Ctrl_s)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(Ctrl_sDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Ctrl_s))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _CTRL_S_ID as Int64  = Nothing 
Public Overridable Property CTRL_S_ID() as Int64  Implements _ICtrl_s.CTRL_S_ID
    Get
	    Return _CTRL_S_ID
    End Get
    Set (byval value as Int64)
	    If _CTRL_S_ID <> value Then
	        IsChanged = True
	        _CTRL_S_ID= value
	    End If
    End Set
End property 

Protected _SYSDATE as DateTime  = Nothing 
Public Overridable Property SYSDATE() as DateTime  Implements _ICtrl_s.SYSDATE
    Get
	    Return _SYSDATE
    End Get
    Set (byval value as DateTime)
	    If _SYSDATE <> value Then
	        IsChanged = True
	        _SYSDATE= value
	    End If
    End Set
End property 

Protected _ADMDATE as DateTime  = Nothing 
Public Overridable Property ADMDATE() as DateTime  Implements _ICtrl_s.ADMDATE
    Get
	    Return _ADMDATE
    End Get
    Set (byval value as DateTime)
	    If _ADMDATE <> value Then
	        IsChanged = True
	        _ADMDATE= value
	    End If
    End Set
End property 

Protected _ADD_DATE as DateTime  = Nothing 
Public Overridable Property ADD_DATE() as DateTime  Implements _ICtrl_s.ADD_DATE
    Get
	    Return _ADD_DATE
    End Get
    Set (byval value as DateTime)
	    If _ADD_DATE <> value Then
	        IsChanged = True
	        _ADD_DATE= value
	    End If
    End Set
End property 

Protected _CHG_DATE as DateTime  = Nothing 
Public Overridable Property CHG_DATE() as DateTime  Implements _ICtrl_s.CHG_DATE
    Get
	    Return _CHG_DATE
    End Get
    Set (byval value as DateTime)
	    If _CHG_DATE <> value Then
	        IsChanged = True
	        _CHG_DATE= value
	    End If
    End Set
End property 

Protected _USER as string  = "" 
Public Overridable Property USER() as string  Implements _ICtrl_s.USER
    Get
	    Return _USER
    End Get
    Set (byval value as string)
	    If _USER <> value Then
	        IsChanged = True
	        _USER= value
	    End If
    End Set
End property 

Protected _SDRATE as single  = 0 
Public Overridable Property SDRATE() as single  Implements _ICtrl_s.SDRATE
    Get
	    Return _SDRATE
    End Get
    Set (byval value as single)
	    If _SDRATE <> value Then
	        IsChanged = True
	        _SDRATE= value
	    End If
    End Set
End property 

Protected _ACCTBR as string  = "" 
Public Overridable Property ACCTBR() as string  Implements _ICtrl_s.ACCTBR
    Get
	    Return _ACCTBR
    End Get
    Set (byval value as string)
	    If _ACCTBR <> value Then
	        IsChanged = True
	        _ACCTBR= value
	    End If
    End Set
End property 

Protected _ACCTSEQ as single  = 0 
Public Overridable Property ACCTSEQ() as single  Implements _ICtrl_s.ACCTSEQ
    Get
	    Return _ACCTSEQ
    End Get
    Set (byval value as single)
	    If _ACCTSEQ <> value Then
	        IsChanged = True
	        _ACCTSEQ= value
	    End If
    End Set
End property 

Protected _PMAXL as single  = 0 
Public Overridable Property PMAXL() as single  Implements _ICtrl_s.PMAXL
    Get
	    Return _PMAXL
    End Get
    Set (byval value as single)
	    If _PMAXL <> value Then
	        IsChanged = True
	        _PMAXL= value
	    End If
    End Set
End property 

Protected _LMAXL as single  = 0 
Public Overridable Property LMAXL() as single  Implements _ICtrl_s.LMAXL
    Get
	    Return _LMAXL
    End Get
    Set (byval value as single)
	    If _LMAXL <> value Then
	        IsChanged = True
	        _LMAXL= value
	    End If
    End Set
End property 

Protected _BINIT as Boolean  = False 
Public Overridable Property BINIT() as Boolean  Implements _ICtrl_s.BINIT
    Get
	    Return _BINIT
    End Get
    Set (byval value as Boolean)
	    If _BINIT <> value Then
	        IsChanged = True
	        _BINIT= value
	    End If
    End Set
End property 

Protected _BPOST as Boolean  = False 
Public Overridable Property BPOST() as Boolean  Implements _ICtrl_s.BPOST
    Get
	    Return _BPOST
    End Get
    Set (byval value as Boolean)
	    If _BPOST <> value Then
	        IsChanged = True
	        _BPOST= value
	    End If
    End Set
End property 

Protected _CLR_ONUS as single  = 0 
Public Overridable Property CLR_ONUS() as single  Implements _ICtrl_s.CLR_ONUS
    Get
	    Return _CLR_ONUS
    End Get
    Set (byval value as single)
	    If _CLR_ONUS <> value Then
	        IsChanged = True
	        _CLR_ONUS= value
	    End If
    End Set
End property 

Protected _CLR_LOCAL as single  = 0 
Public Overridable Property CLR_LOCAL() as single  Implements _ICtrl_s.CLR_LOCAL
    Get
	    Return _CLR_LOCAL
    End Get
    Set (byval value as single)
	    If _CLR_LOCAL <> value Then
	        IsChanged = True
	        _CLR_LOCAL= value
	    End If
    End Set
End property 

Protected _CLR_REG as single  = 0 
Public Overridable Property CLR_REG() as single  Implements _ICtrl_s.CLR_REG
    Get
	    Return _CLR_REG
    End Get
    Set (byval value as single)
	    If _CLR_REG <> value Then
	        IsChanged = True
	        _CLR_REG= value
	    End If
    End Set
End property 

Protected _MINBAL as single  = 0 
Public Overridable Property MINBAL() as single  Implements _ICtrl_s.MINBAL
    Get
	    Return _MINBAL
    End Get
    Set (byval value as single)
	    If _MINBAL <> value Then
	        IsChanged = True
	        _MINBAL= value
	    End If
    End Set
End property 

Protected _DBDORMANT as single  = 0 
Public Overridable Property DBDORMANT() as single  Implements _ICtrl_s.DBDORMANT
    Get
	    Return _DBDORMANT
    End Get
    Set (byval value as single)
	    If _DBDORMANT <> value Then
	        IsChanged = True
	        _DBDORMANT= value
	    End If
    End Set
End property 

Protected _EOM_FLAG as Boolean  = False 
Public Overridable Property EOM_FLAG() as Boolean  Implements _ICtrl_s.EOM_FLAG
    Get
	    Return _EOM_FLAG
    End Get
    Set (byval value as Boolean)
	    If _EOM_FLAG <> value Then
	        IsChanged = True
	        _EOM_FLAG= value
	    End If
    End Set
End property 

Protected _EOQ_FLAG as Boolean  = False 
Public Overridable Property EOQ_FLAG() as Boolean  Implements _ICtrl_s.EOQ_FLAG
    Get
	    Return _EOQ_FLAG
    End Get
    Set (byval value as Boolean)
	    If _EOQ_FLAG <> value Then
	        IsChanged = True
	        _EOQ_FLAG= value
	    End If
    End Set
End property 

Protected _EOY_FLAG as Boolean  = False 
Public Overridable Property EOY_FLAG() as Boolean  Implements _ICtrl_s.EOY_FLAG
    Get
	    Return _EOY_FLAG
    End Get
    Set (byval value as Boolean)
	    If _EOY_FLAG <> value Then
	        IsChanged = True
	        _EOY_FLAG= value
	    End If
    End Set
End property 

Protected _OTC_FLAG as Boolean  = False 
Public Overridable Property OTC_FLAG() as Boolean  Implements _ICtrl_s.OTC_FLAG
    Get
	    Return _OTC_FLAG
    End Get
    Set (byval value as Boolean)
	    If _OTC_FLAG <> value Then
	        IsChanged = True
	        _OTC_FLAG= value
	    End If
    End Set
End property 

Protected _EOD_FLAG as Boolean  = False 
Public Overridable Property EOD_FLAG() as Boolean  Implements _ICtrl_s.EOD_FLAG
    Get
	    Return _EOD_FLAG
    End Get
    Set (byval value as Boolean)
	    If _EOD_FLAG <> value Then
	        IsChanged = True
	        _EOD_FLAG= value
	    End If
    End Set
End property 

Protected _P_PRINT as string  = "" 
Public Overridable Property P_PRINT() as string  Implements _ICtrl_s.P_PRINT
    Get
	    Return _P_PRINT
    End Get
    Set (byval value as string)
	    If _P_PRINT <> value Then
	        IsChanged = True
	        _P_PRINT= value
	    End If
    End Set
End property 

Protected _R_PRINT as string  = "" 
Public Overridable Property R_PRINT() as string  Implements _ICtrl_s.R_PRINT
    Get
	    Return _R_PRINT
    End Get
    Set (byval value as string)
	    If _R_PRINT <> value Then
	        IsChanged = True
	        _R_PRINT= value
	    End If
    End Set
End property 

Protected _DormancyCharge as single  = 0 
Public Overridable Property DormancyCharge() as single  Implements _ICtrl_s.DormancyCharge
    Get
	    Return _DormancyCharge
    End Get
    Set (byval value as single)
	    If _DormancyCharge <> value Then
	        IsChanged = True
	        _DormancyCharge= value
	    End If
    End Set
End property 


#End Region

#Region "Method"
''' <summary>
'''This method read an Ctrl_s from DB.
''' </summary>
''' <returns>
'''Return 0 if all ok, 1 if error
''' </returns>
Public Overridable Function Read(Id As Integer) As Integer
    'Return 0 if all ok
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Dim int As Ctrl_s = Manager.Read(Id)
                    _CTRL_S_ID = int.CTRL_S_ID
                    _SYSDATE = int.SYSDATE
                    _ADMDATE = int.ADMDATE
                    _ADD_DATE = int.ADD_DATE
                    _CHG_DATE = int.CHG_DATE
                    _USER = int.USER
                    _SDRATE = int.SDRATE
                    _ACCTBR = int.ACCTBR
                    _ACCTSEQ = int.ACCTSEQ
                    _PMAXL = int.PMAXL
                    _LMAXL = int.LMAXL
                    _BINIT = int.BINIT
                    _BPOST = int.BPOST
                    _CLR_ONUS = int.CLR_ONUS
                    _CLR_LOCAL = int.CLR_LOCAL
                    _CLR_REG = int.CLR_REG
                    _MINBAL = int.MINBAL
                    _DBDORMANT = int.DBDORMANT
                    _EOM_FLAG = int.EOM_FLAG
                    _EOQ_FLAG = int.EOQ_FLAG
                    _EOY_FLAG = int.EOY_FLAG
                    _OTC_FLAG = int.OTC_FLAG
                    _EOD_FLAG = int.EOD_FLAG
                    _P_PRINT = int.P_PRINT
                    _R_PRINT = int.R_PRINT
                    _DormancyCharge = int.DormancyCharge
        	    End Using
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
	    Ris = 1
    End Try
    Return Ris
End Function

''' <summary>
'''This method save an Ctrl_s on DB.
''' </summary>
''' <returns>
'''Return Id insert in DB if all ok, 0 if error
''' </returns>
Public Overridable Function Save() As Integer
    'Return the id Inserted
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Ris = Manager.Save(Me)
	    End Using
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ris
End Function

Protected Function InternalIsValid() As Boolean
	Dim Ris As Boolean = True
	  if _USER.Length > 8 then Ris = False
  if _ACCTBR.Length > 4 then Ris = False
  if _P_PRINT.Length > 4 then Ris = False
  if _R_PRINT.Length > 4 then Ris = False

	Return Ris
End Function

#End Region

#Region "Embedded Class"


#End Region

End Class 

''' <summary>
'''Interface for table Ctrl_s
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _ICtrl_s

Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

    
    Property CTRL_S_ID() as Int64

    
    Property SYSDATE() as DateTime

    
    Property ADMDATE() as DateTime

    
    Property ADD_DATE() as DateTime

    
    Property CHG_DATE() as DateTime

    
    Property USER() as string

    
    Property SDRATE() as single

    
    Property ACCTBR() as string

    
    Property ACCTSEQ() as single

    
    Property PMAXL() as single

    
    Property LMAXL() as single

    
    Property BINIT() as Boolean

    
    Property BPOST() as Boolean

    
    Property CLR_ONUS() as single

    
    Property CLR_LOCAL() as single

    
    Property CLR_REG() as single

    
    Property MINBAL() as single

    
    Property DBDORMANT() as single

    
    Property EOM_FLAG() as Boolean

    
    Property EOQ_FLAG() as Boolean

    
    Property EOY_FLAG() as Boolean

    
    Property OTC_FLAG() as Boolean

    
    Property EOD_FLAG() as Boolean

    
    Property P_PRINT() as string

    
    Property R_PRINT() as string

    
    Property DormancyCharge() as single

    
#End Region

End Interface