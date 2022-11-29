Imports FireSharp.Response
Imports Mysqlx.XDevAPI
Imports Newtonsoft.Json
Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports Org.BouncyCastle.Asn1.X509
Public Class Form7
    Private fcon As New FirebaseConfig With
        {
         .AuthSecret = "HeVjDKbwc6BTVvWtfn6WuaWnMnqapxWYnPV04Sqf ",
        .BasePath = " https://rumuruti-hospital-fca60-default-rtdb.firebaseio.com/"
  }
    Private client As IFirebaseClient
    Public Shared Fname

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim res As FirebaseResponse = client.Get("Order")
        Dim data As Dictionary(Of String, Order) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Order))(res.Body.ToString())
        updateDataGrid(data)
    End Sub
    Sub updateDataGrid(ByVal records As Dictionary(Of String, Order))
        DataGridView1.Rows.Clear()


        DataGridView1.Columns.Add("From", "From")
        DataGridView1.Columns.Add("Recepient", "Recipient")
        DataGridView1.Columns.Add("Type", "Type")
        DataGridView1.Columns.Add("Name", "Name")
        DataGridView1.Columns.Add("Quantity", "Quantity")

        For Each items In records
            DataGridView1.Rows.Add(items.Key, items.Value.From, items.Value.Recipient, items.Value.Type, items.Value.Name, items.Value.Quantity)
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Order As New Order With
{
     .From = TextBox1.Text,
    .Recipient = TextBox2.Text,
    .Type = TextBox3.Text,
        .Name = TextBox4.Text,
        .Quantity = TextBox5.Text}


        MessageBox.Show("You are about to store this set of data")
        Dim setter = client.Set("Order list/" + TextBox2.Text, Order)
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form2.Show()
    End Sub


End Class