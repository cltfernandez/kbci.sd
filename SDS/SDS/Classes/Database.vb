Imports System.Data.SqlClient
Imports System.Configuration
Imports SDS.KBCI.SDS.Security
Namespace KBCI.SDS.Database

    Public Class Database
        Private _SQLConn As SqlConnection

        Public Sub New()
            SQLConn.ConnectionString = "Password=" & GetConfig("WP") & ";User ID=" & GetConfig("CL") & ";Initial Catalog=" & GetConfig("DB") & ";Data Source=" & GetConfig("SV")
            SQLConn.Open()
        End Sub
        Public Property SQLConn() As SqlConnection
            Get
                Return _SQLConn
            End Get
            Set(ByVal value As SqlConnection)
                _SQLConn = value
            End Set
        End Property

    End Class
End Namespace
