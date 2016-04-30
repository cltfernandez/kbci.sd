#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 11/10/2015 
#End Region



Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Data
Imports System.Configuration
Imports System.Data.Common
Imports System.Reflection
Imports SDS.Common

Namespace LUNA

	Public Enum enLogicOperator
		enAND = 0
		enOR
	End Enum

    Public Enum enTransactionBoxState
        Active = 0
        Destroyed = 1
    End Enum

    Public Class LunaTransactionBox
        Implements IDisposable

        Public Sub New(CallerFunctionRif As String, CurrentThread As Integer)

            _CallerFunction = CallerFunctionRif
            _ThreadId = CurrentThread

        End Sub


        Private _State As enTransactionBoxState = enTransactionBoxState.Active
        Public Property State() As enTransactionBoxState
            Get
                Return _State
            End Get
            Set(ByVal value As enTransactionBoxState)
                _State = value
            End Set
        End Property

        Private _DbConnection As IDbConnection
        Public ReadOnly Property DbConnection() As IDbConnection
            Get
                If _DbConnection Is Nothing Then
                    _DbConnection = LUNA.LunaContext.GetDbConnection()
                End If
                Return _DbConnection
            End Get
        End Property

        Private _ThreadId As Integer = 0
        Public ReadOnly Property ThreadId() As Integer
            Get
                Return _ThreadId
            End Get
        End Property

        Private _CallerFunction As String = String.Empty
        Public ReadOnly Property CallerFunction() As String
            Get
                Return _CallerFunction
            End Get
        End Property

        Private _Transaction As IDbTransaction
        Public ReadOnly Property Transaction() As IDbTransaction
            Get
                Return _Transaction
            End Get
        End Property

        Public Sub TransactionBegin()
            If Not DbConnection Is Nothing Then
                If _Transaction Is Nothing Then
                    _Transaction = DbConnection.BeginTransaction(LunaContext.IsolationLevel)
                End If
            End If
        End Sub

        Public Sub TransactionCommit()
            If Not _Transaction Is Nothing Then
                _Transaction.Commit()
                DestroyTransaction()
            End If
        End Sub

        Public Sub TransactionRollBack()
            If Not _Transaction Is Nothing Then
                _Transaction.Rollback()
                DestroyTransaction()
            End If
        End Sub
        Private Sub DestroyTransaction()
            Try
                _Transaction.Dispose()
            Catch ex As Exception

            End Try
            Try
                _Transaction = Nothing
            Catch ex As Exception

            End Try

        End Sub
        Private Sub DestroyConnection()
            _DbConnection.Close()
            _DbConnection.Dispose()
            _DbConnection = Nothing
        End Sub
        Private Sub DestroyBox()
            State = enTransactionBoxState.Destroyed
            Try
                If Not _Transaction Is Nothing Then
                    DestroyTransaction()
                End If

                If Not _DbConnection Is Nothing Then
                    If LUNA.LunaContext.ShareConnection = False Then DestroyConnection()
                End If
            Catch ex As Exception

            End Try

            LUNA.LunaContext.DestroyTransactionBox(Me)
        End Sub

#Region "IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            DestroyBox()
            Me.disposedValue = True
        End Sub
        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
        Protected Overrides Sub Finalize()
            Dispose(False)
        End Sub
#End Region


    End Class

   Partial Public Class LunaContext
        Private Shared _ConnectionString As String = String.Empty
        Private Shared DbConnection As Data.IDbConnection

        Shared Sub New()



            'If Not ConfigurationManager.ConnectionStrings(ProjectId & ".ConnectionString") Is Nothing Then
            '    _ConnectionString = ConfigurationManager.ConnectionStrings(ProjectId & ".ConnectionString").ConnectionString
            'ElseIf Not ConfigurationManager.ConnectionStrings("ConnectionString") Is Nothing Then
            '    _ConnectionString = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
            'Else
            '    If System.ComponentModel.LicenseManager.UsageMode <> ComponentModel.LicenseUsageMode.Designtime Then
            '        Throw New Exception("Luna Engine Exception: Connection String not configured!")
            '    End If
            'End If
            _ConnectionString = String.Format("Data Source={3};Initial Catalog={2};MultipleActiveResultSets=true;User Id={1};Password={0};Encrypt=false;Packet Size=4096;Connection Timeout=10;", Utilities.GetConfig("WP"), Utilities.GetConfig("CL"), Utilities.GetConfig("DB"), Utilities.GetConfig("SV"))



            Dim ParamValue As String = ConfigurationManager.AppSettings(ProjectId & ".LUNA.ShareConnection")
            If Not ParamValue Is Nothing Then
                _ShareConnection = Convert.ToBoolean(ParamValue)
            End If

            ParamValue = ConfigurationManager.AppSettings(ProjectId & ".LUNA.DisableLazyLoading")
            If Not ParamValue Is Nothing Then
                _DisableLazyLoading = Convert.ToBoolean(ParamValue)
            End If

        End Sub
		
		Public Shared ReadOnly Property ProjectId As String
            Get
                Dim ris As String = Assembly.GetExecutingAssembly().GetName.Name
                Return ris
            End Get
        End Property

        Private Shared _TransactionBoxes As New List(Of LUNA.LunaTransactionBox)

        Private Shared Function GetTransactionBox() As LUNA.LunaTransactionBox

            Dim ris As LUNA.LunaTransactionBox = Nothing
            Dim stackTrace As New Diagnostics.StackTrace

            For Each T As LUNA.LunaTransactionBox In _TransactionBoxes.FindAll(Function(x) x.ThreadId = CurrentThreadID And x.State = enTransactionBoxState.Active)
                For Each f As StackFrame In stackTrace.GetFrames
                    Dim m As System.Reflection.MethodBase = f.GetMethod
                    If m.Name = T.CallerFunction Then
                        ris = T
                        Exit For
                    End If
                Next
            Next

            Return ris

        End Function

        Public Shared ReadOnly Property TransactionBox As LUNA.LunaTransactionBox
            Get
                Return GetTransactionBox()
            End Get
        End Property

        Public Shared Sub DestroyTransactionBox(ByRef T As LUNA.LunaTransactionBox)
            Try
                _TransactionBoxes.Remove(T)
            Catch ex As Exception

            End Try
            Try
                T = Nothing
            Catch ex As Exception

            End Try

        End Sub

        Private Shared Function GetCallerFunction() As String

            Dim stackTrace As New Diagnostics.StackFrame(2)
            Dim m As System.Reflection.MethodBase = stackTrace.GetMethod
            Return m.Name

        End Function

        Public Shared Function CreateTransactionBox() As LUNA.LunaTransactionBox

            Dim _TransactionBox As LUNA.LunaTransactionBox = TransactionBox
            If _TransactionBox Is Nothing Then
                _TransactionBox = New LunaTransactionBox(GetCallerFunction, CurrentThreadID)
                _TransactionBoxes.Add(_TransactionBox)
            End If

            Return _TransactionBox

        End Function

        Public Shared ReadOnly Property Connection As Data.IDbConnection
            Get
                If DbConnection Is Nothing Then DbConnection = GetDbConnection()
                Return DbConnection
            End Get
        End Property

        Public Shared ReadOnly Property CurrentThreadID As Integer
            Get
                Return Threading.Thread.CurrentThread.ManagedThreadId
            End Get
        End Property

        Private Shared Sub CloseConn(ByRef Conn As IDbConnection)
            If Not Conn Is Nothing Then
                _TotConnAttive.Remove(Conn.GetHashCode)
                If Conn.State <> ConnectionState.Closed Then Conn.Close()
                Conn.Dispose()
                Conn = Nothing
            End If
        End Sub

        Public Shared Sub CloseDbConnection(Optional ByRef Conn As IDbConnection = Nothing)
            Try
                If Not Conn Is Nothing Then
                    If ShareConnection = False Then
                        CloseConn(Conn)
                    End If
                Else
                    CloseConn(DbConnection)
                End If

            Catch ex As Exception
                'Throw New ApplicationException("Luna Engine Exception: Error Closing DB", ex)
            End Try
        End Sub

        Public Shared Function GetDbConnection(Optional ConnString As String = "") As IDbConnection
            Dim ris As IDbConnection = Nothing
            Try
                Dim ConnectionString As String = _ConnectionString
                If ConnString.Length Then
                    ConnectionString = ConnString
                End If
                ris = OpenConn(Connectionstring)
            Catch ex As Exception
                Throw New ApplicationException("Luna Engine Exception: Error Opening DB", ex)
            End Try
            Return ris
        End Function

		Private Shared Function CreateNewConnection(ConnString As String) As IDbConnection

            Dim Ris As IDbConnection
            Dim LunaFactory As DbProviderFactory
            LunaFactory = DbProviderFactories.GetFactory(GetProviderFactory)
            Ris = LunaFactory.CreateConnection
            Ris.ConnectionString = ConnString
            Ris.Open()
            _TotConnAttive.Add(Ris.GetHashCode)
            Return Ris

        End Function

       Private Shared Function OpenConn(ConnString As String) As IDbConnection
            Dim Ris As IDbConnection
            Try
                If ShareConnection = False Then
                    Ris = CreateNewConnection(ConnString)
                Else
                    If DbConnection Is Nothing Then
                        DbConnection = CreateNewConnection(ConnString)
                    ElseIf DbConnection.State <> Data.ConnectionState.Open Then
                        DbConnection.Open()
                    End If
                    Ris = DbConnection
                End If
            Catch ex As Exception
                Throw New ApplicationException("Luna Engine Exception: Error Opening DB", ex)
            End Try
            Return Ris
        End Function

        Private Shared _ShareConnection As Boolean = False
        Public Shared ReadOnly Property ShareConnection As Boolean
            Get
                Return _ShareConnection
            End Get
        End Property

        Private Shared _DisableLazyLoading As Boolean = False
        Public Shared ReadOnly Property DisableLazyLoading As Boolean
            Get
                Return _DisableLazyLoading
            End Get
        End Property

    Private Shared _ProviderFactory As String = String.Empty
    Friend Shared Function GetProviderFactory() As String
        If _ProviderFactory = String.Empty Then
            Dim ParamName As String = ProjectId & ".LUNA.Ioc.ProviderFactory"
            Dim ParamValue As String = ConfigurationManager.AppSettings(ParamName)
            If Not ParamValue Is Nothing Then
                _ProviderFactory = ParamValue
            Else
                _ProviderFactory = "System.Data.SqlClient"
                            End If
        End If
        Return _ProviderFactory
    End Function

    Private Shared _MgrTypeForEntity As System.Type = Nothing
    Friend Shared Function GetMgrTypeForEntity(EntityName As System.Type) As System.Type
        If _MgrTypeForEntity Is Nothing Then
            Dim ParamName As String = ProjectId & ".LUNA.Ioc." & EntityName.Name
            Dim ParamValue As String = ConfigurationManager.AppSettings(ParamName)
            If Not ParamValue Is Nothing Then
                _MgrTypeForEntity = Type.GetType(ParamValue, False, True)
            End If
        End If
        Return _MgrTypeForEntity
    End Function
    Private Shared _TotConnAttive As New List(Of Integer)
    Public Shared ReadOnly Property TotConnAttive As Integer
        Get
            Return _TotConnAttive.Count
        End Get
    End Property

	Public Shared ReadOnly Property TotTransactionAttive As Integer
        Get
            Return _TransactionBoxes.FindAll(Function(x) x.State = enTransactionBoxState.Active).Count
        End Get
    End Property
    
End Class

Public MustInherit Class LunaBaseClass

Public Sub ManageError(ByVal ex As Exception)
	throw new ApplicationException("Luna Engine Exception: " & ex.Message, ex)
End Sub

End Class

Public MustInherit Class LunaBaseClassEntity
	Inherits LunaBaseClass
	Implements ILunaBaseClassEntity

	Private _IsChanged As Boolean = False
	Public Property IsChanged As Boolean
		Get
			Return _IsChanged
		End Get
		Set(value As Boolean)
			_IsChanged = value
		End Set
	End Property

	Public Overridable Function IsValid() As Boolean
		Return True
	End Function

	Public Sub New()

    End Sub

	Protected _Mgr As IDisposable

	#Region "IDisposable Support"
        Private disposedValue As Boolean ' Per rilevare chiamate ridondanti

        ' IDisposable
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    ' TODO: eliminare stato gestito (oggetti gestiti).
					 If Not _Mgr Is Nothing Then
                        _Mgr.Dispose()
                        _Mgr = Nothing
                    End If
                End If

                ' TODO: liberare risorse non gestite (oggetti non gestiti) ed eseguire l'override del seguente Finalize().
                ' TODO: impostare campi di grandi dimensioni su null.
            End If
            Me.disposedValue = True
        End Sub

        ' TODO: eseguire l'override di Finalize() solo se Dispose(ByVal disposing As Boolean) dispone del codice per liberare risorse non gestite.
        'Protected Overrides Sub Finalize()
        '    ' Non modificare questo codice. Inserire il codice di pulizia in Dispose(ByVal disposing As Boolean).
        '    Dispose(False)
        '    MyBase.Finalize()
        'End Sub

        ' Questo codice è aggiunto da Visual Basic per implementare in modo corretto il modello Disposable.
        Public Sub Dispose() Implements IDisposable.Dispose
            ' Non modificare questo codice. Inserire il codice di pulizia in Dispose(disposing As Boolean).
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
	#End Region
	
End Class


Public Interface ILunaBaseClassEntity
    Inherits IDisposable

End Interface


Public Interface ILunaBaseClassDAO(Of T)
    Inherits IDisposable
    Function Read(ByVal Id As Integer) As T
    Function Save(ByRef obj As T) As Integer
    Sub Delete(ByVal Id As Integer)
    Sub Delete(ByRef obj As T, Optional ByRef ListaObj As List(Of T) = Nothing)
    Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As T
    Function FindAll(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of T)
    Function GetAll(Optional ByVal OrderByField As String = "", Optional ByVal AddEmptyItem As Boolean = False) As IEnumerable(Of T)
End Interface

Public MustInherit Class LunaBaseClassDAO(Of T)
	Inherits LunaBaseClass
	Implements IDisposable
	Implements ILunaBaseClassDAO(Of T)

	Private _DbConnection As IDbConnection = Nothing

        Private Sub InitializeDBConnection()
            If _DbConnection Is Nothing Then
                If Not LunaContext.TransactionBox Is Nothing Then
                    _DbConnection = LunaContext.TransactionBox.DbConnection
                Else
                    _DbConnection = LUNA.LunaContext.GetDbConnection
                End If
            End If
        End Sub

        Protected Property _Cn As IDbConnection
            Get
                InitializeDBConnection()
                Return _DbConnection
            End Get
            Set(value As IDbConnection)
                _DbConnection = value
            End Set
        End Property

	Protected _ConnectionString As String = String.Empty
	Private _ConnAdHoc As Boolean = False
	
	Public Sub New()
    
	End Sub

	Public Sub New(ByVal Connection As IDbConnection)
		'Require a valid and OPEN DBconnection
		_cn = Connection
	End Sub

	Public MustOverride Function Read(ByVal Id As Integer) As T Implements ILunaBaseClassDAO(Of T).Read
	Public MustOverride Function Save(ByRef obj As T) As Integer Implements ILunaBaseClassDAO(Of T).Save
	Public MustOverride Sub Delete(ByVal Id As Integer) Implements ILunaBaseClassDAO(Of T).Delete
	Public MustOverride Sub Delete(ByRef obj As T, Optional ByRef ListaObj As List(Of T) = Nothing) Implements ILunaBaseClassDAO(Of T).Delete
	Public MustOverride Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As T Implements ILunaBaseClassDAO(Of T).Find
	Public MustOverride Function FindAll(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of T) Implements ILunaBaseClassDAO(Of T).FindAll
	Public MustOverride Function GetAll(Optional ByVal OrderByField As String = "", Optional ByVal AddEmptyItem As Boolean = False) As IEnumerable(Of T) Implements ILunaBaseClassDAO(Of T).GetAll

	Public Function Ap(ByVal Valore) As String
		Dim str As String = String.Empty
		If TypeOf Valore Is String Then
			Str = Valore.ToString
			Str = Str.Replace("'", "''")
			Str = " '" & Str & "'"
		ElseIf TypeOf Valore Is Date Then
						Dim dateRif As Date = Valore
					str = "  convert(datetime,'" & dateRif.Day.ToString("00") & "-" & dateRif.Month.ToString("00") & "-" & dateRif.Year & " " & dateRif.Hour.ToString("00") & ":" & dateRif.Minute.ToString("00") & "." & dateRif.Second.ToString("00") & "',103)"
					
		ElseIf TypeOf Valore Is [Enum] Then
			str = " " & Valore
		ElseIf Valore Is Nothing Then
			str = " NULL "
		Else
			Str = " " & Valore.ToString
		End If
		Return Str
	End Function

	Public Function ApN(ByVal Testo) As String
		Dim str As String = String.Empty
		str = Testo.ToString
		str = str.Replace(",", ".")
		Return str
	End Function

	Public Function ApLike(ByVal testo)
		Dim str As String
		str = testo.ToString
		str = str.Replace(" '", "''")
		str = "like '%" & str & "%'"
		Return str
	End Function

	Public Function ApLikeRight(ByVal testo)
		Dim str As String
		str = testo.ToString
		str = str.Replace(" '", "''")
		str = "like '" & str & "%'"
		Return str
	End Function

	Protected Function ApIn(ByVal Valore) As String
		Dim str As String = String.Empty
		str = Valore.ToString
		str = str.Replace("'", "''")
		Return str
	End Function

	#Region "Serialization Method"
	Public Function ReadSerialize(ByVal PathXMLSerial As String) as T

	Dim cls As T
		Try
			Dim serialize As XmlSerializer = New XmlSerializer(GetType(T))
			Dim deSerialize As IO.FileStream = New IO.FileStream(PathXMLSerial, IO.FileMode.Open)
			cls = serialize.Deserialize(deSerialize)
		Catch ex As Exception
			ManageError(ex)
		End Try

	Return cls
	End function
	Public Sub SaveSerialize(Obj as T, ByVal PathXML As String)

	Try
		Dim serialize As XmlSerializer = New XmlSerializer(GetType(T))
		Dim Writer As New System.IO.StreamWriter(PathXML)
		serialize.Serialize(Writer, Obj)
		Writer.Close()
		Catch ex As Exception
			ManageError(ex)
		End Try

	End Sub
	#End Region

	#Region "IDisposable Support"
	Private disposedValue As Boolean ' To detect redundant calls
	Protected Overridable Sub Dispose(disposing As Boolean)
	
		If LunaContext.TransactionBox Is Nothing Then LUNA.LunaContext.CloseDbConnection(_Cn)
		Me.disposedValue = True
	End Sub
	Public Sub Dispose() Implements IDisposable.Dispose
		' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
		Dispose(True)
		GC.SuppressFinalize(Me)
	End Sub
	Protected Overrides Sub Finalize()
		Dispose(False)
	End Sub
	#End Region

	End Class

    Public Class LunaSearchOption


        Private _Top As Integer
        Public Property Top() As Integer
            Get
                Return _Top
            End Get
            Set(ByVal value As Integer)
                _Top = value
            End Set
        End Property


        Private _OrderBy As String
        Public Property OrderBy() As String
            Get
                Return _OrderBy
            End Get
            Set(ByVal value As String)
                _OrderBy = value
            End Set
        End Property


        Private _AddEmptyItem As Boolean
        Public Property AddEmptyItem() As Boolean
            Get
                Return _AddEmptyItem
            End Get
            Set(ByVal value As Boolean)
                _AddEmptyItem = value
            End Set
        End Property
    End Class

Public Class LunaSearchParameter

Public Sub New()

End Sub

Public Sub New(ByVal FieldName As String, ByVal Value As Object, Optional ByVal SqlOperator As String = "",Optional ByVal LogicOperator  As enLogicOperator = enLogicOperator.enAND)
	_FieldName = FieldName
	    If TypeOf (Value) Is Boolean Then
            If Value = True Then
                _Value = 1
            Else
                _Value = 0
            End If
        Else
            _Value = Value
        End If
		
	If SqlOperator.Length Then _SqlOperator = SqlOperator
	_LogicOperator = LogicOperator
End Sub

Private _SqlOperator As String = " = "
Public Property SqlOperator As String
	Get
		Return _SqlOperator
	End Get
	Set(ByVal value As String)
		_SqlOperator = value
	End Set
End Property

Private _LogicOperator As enLogicOperator = enLogicOperator.enAND
Public Property LogicOperator As enLogicOperator
	Get
		Return _LogicOperator
	End Get
	Set(ByVal value As enLogicOperator)
		_LogicOperator = value
	End Set
End Property

Public ReadOnly Property LogicOperatorStr As String
	Get
		If _LogicOperator = enLogicOperator.enAND Then
			Return " And "
		 Else
			Return " Or "
		End If
	End Get
End Property

Private _FieldName As String
Public Property FieldName As String
	Get
		Return _FieldName
	End Get
	Set(ByVal value As String)
		_FieldName = value
	End Set
End Property

Private _Value
Public Property Value
	Get
		Return _Value
	End Get
	Set(ByVal value)
		_Value = value
	End Set
End Property

End Class

End Namespace

