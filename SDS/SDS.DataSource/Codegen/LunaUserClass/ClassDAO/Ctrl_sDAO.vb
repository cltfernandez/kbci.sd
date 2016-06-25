#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.15.2.90 
'Author: Diego Lunadei
'Date: 25/06/2016 
#End Region


Imports System.Data.Common

''' <summary>
'''DAO Class for table Ctrl_s
''' </summary>
''' <remarks>
'''Write your DATABASE custom method here
''' </remarks>
Public Class Ctrl_sDAO
	Inherits _Ctrl_sDAO

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal Connection As DbConnection)
        MyBase.New(Connection)
    End Sub
End Class