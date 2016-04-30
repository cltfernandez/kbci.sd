Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data
Imports System.Net
Imports System.Net.Sockets
Imports System.Text.RegularExpressions


Public Class db_Database
#Region "variables"

    Private _Server As String
    Private _UserID As String
    Private _Password As String
    Private _DB As String
    Private _Connectionstring As String
    Protected defaultConnection As SqlConnection

#End Region
#Region "properties"
    Public Property Server() As String
        Get
            Return _Server
        End Get
        Set(ByVal value As String)
            _Server = "Data Source=" + value
        End Set
    End Property
    Public Property UserID() As String
        Get
            Return _UserID
        End Get
        Set(ByVal value As String)
            _UserID = ";User ID=" + value
        End Set
    End Property
    Public Property Password() As String
        Get
            Return _Password
        End Get
        Set(ByVal value As String)
            _Password = ";Password=" + value
        End Set
    End Property

    Public Property DB() As String
        Get
            Return _DB
        End Get
        Set(ByVal value As String)
            _DB = ";Initial Catalog=" + value
        End Set
    End Property
    Public Property Connectionstring() As String
        Get
            If _Server <> [String].Empty AndAlso _UserID <> [String].Empty AndAlso _Password <> [String].Empty Then
                _Connectionstring = _Server + _UserID + _Password + _DB
            End If
            Return _Connectionstring
        End Get
        Set(ByVal value As String)
            _Connectionstring = value
        End Set
    End Property

#End Region
#Region "constructor"
    Public Sub New()
        _Server = ""
        _UserID = ""
        _Password = ""
        _DB = ""
        defaultConnection = Nothing
    End Sub
#End Region
#Region "methods"
    Public Sub Open()
        defaultConnection = New SqlConnection()
        If _Server <> [String].Empty AndAlso _UserID <> [String].Empty AndAlso _Password <> [String].Empty Then
            _Connectionstring = _Server + _UserID + _Password + _DB
        End If
        defaultConnection.ConnectionString = Me.Connectionstring
        Connect()

    End Sub
    Public Sub Open(ByVal ConnString As String)
        defaultConnection = New SqlConnection()
        _Connectionstring = ConnString
        defaultConnection.ConnectionString = ConnString
        Connect()
    End Sub

    Public Sub Open(ByVal server As String, ByVal userid As String, ByVal password As String)
        defaultConnection = New SqlConnection()
        Me.Server = server
        Me.UserID = userid
        Me.Password = password
        _Connectionstring = Me.Connectionstring
        defaultConnection.ConnectionString = Me.Connectionstring
        Connect()
    End Sub

    Private Sub Connect()
        If defaultConnection.ConnectionString Is Nothing Then
            Dim ex As New Exception("Data server was not configured.")
            Throw ex
        Else
            If defaultConnection.State = ConnectionState.Closed Then
                defaultConnection.Open()
            End If
        End If

    End Sub
    Public Sub Close()
        If defaultConnection.State = ConnectionState.Open Then
            defaultConnection.Close()
        End If
    End Sub
    Public Function IsConnected(ByRef errMsg As String) As Boolean
        Dim ip As String
        Dim port As Integer
        Dim sqldbHost As New IPHostEntry()
        Dim sqldbTCP As New TcpClient()
        Try

            ip = Me.Server.Substring(Me.Server.IndexOf("=") + 1, Me.Server.Length - ((Me.Server.IndexOf("=") + 1) + (Me.Server.Length - Me.Server.IndexOf(","))))
            port = Integer.Parse(Me.Server.Substring(Me.Server.IndexOf(",") + 1, Me.Server.Length - (Me.Server.IndexOf(",") + 1)))
            sqldbHost = Dns.GetHostEntry(ip)
            Dim sqldbIPAddress As IPAddress = sqldbHost.AddressList(0)
            sqldbTCP.Connect(ip, port)
            sqldbIPAddress = Nothing
        Catch ex As Exception
            errMsg = ex.Message
            Return False
        Finally
            sqldbTCP.Close()
            sqldbTCP = Nothing
            sqldbHost = Nothing
        End Try
        Return True
    End Function
    Public Sub GetData(ByVal StoredProcedure As String, ByVal spParam As List(Of SqlParameter), ByRef sqldtrdr As SqlDataReader)
        Dim sqlcmd As New SqlCommand(StoredProcedure, defaultConnection)
        sqlcmd.CommandType = CommandType.StoredProcedure
        For Each sqlparam As SqlParameter In spParam
            sqlcmd.Parameters.Add(sqlparam)
        Next
        sqldtrdr = sqlcmd.ExecuteReader()
    End Sub
    Public Function ExecSP(ByVal storedProc As String, ByVal sqlParm As List(Of SqlParameter)) As Integer
        Dim sqlcmd As New SqlCommand(storedProc, defaultConnection)

        sqlcmd.CommandType = CommandType.StoredProcedure
        For Each sqlparam As SqlParameter In sqlParm
            sqlcmd.Parameters.Add(sqlparam)
        Next
        sqlcmd.ExecuteNonQuery()
        Return 0
    End Function
#End Region

End Class
