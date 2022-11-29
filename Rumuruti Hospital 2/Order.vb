Imports FireSharp.Response
Imports Mysqlx.XDevAPI
Imports Newtonsoft.Json
Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports Org.BouncyCastle.Asn1.X509
Imports System.Configuration
Public Class Order
    Public Property From() As String
    Public Property Recipient() As String
    Public Property Type() As String
    Public Property Name() As String
    Public Property Quantity() As String
    Public Property DueDate() As String
End Class
