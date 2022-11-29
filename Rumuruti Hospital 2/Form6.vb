Imports FireSharp.Response
Imports Mysqlx.XDevAPI
Imports Newtonsoft.Json
Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports Org.BouncyCastle.Asn1.X509


Public Class Form6
    Private fcon As New FirebaseConfig With
        {
         .AuthSecret = "HeVjDKbwc6BTVvWtfn6WuaWnMnqapxWYnPV04Sqf ",
        .BasePath = " https://rumuruti-hospital-fca60-default-rtdb.firebaseio.com/"
  }
    Private client As IFirebaseClient
    Public Shared Fname

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim res As FirebaseResponse = client.Get("Valuables")
        Dim data As Dictionary(Of String, Valuables) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Valuables))(res.Body.ToString())
        updateDataGrid(data)
    End Sub
    Sub updateDataGrid(ByVal records As Dictionary(Of String, Valuables))
        DataGridView2.Rows.Clear()
        DataGridView2.Columns.Clear()

        DataGridView2.Columns.Add("Name", "Name")
            DataGridView2.Columns.Add("Quantity", "Quantity")

        For Each items In records
            DataGridView1.Rows.Add(items.Key, items.Value.Name, items.Value.Quantity)
        Next




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim res As FirebaseResponse = client.Get("Medicine")
        Dim data As Dictionary(Of String, Medicine) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Medicine))(res.Body.ToString())
        updateDataGrid(data)
    End Sub

    Sub updateDataGrid(ByVal records As Dictionary(Of String, Medicine))
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()

        DataGridView1.Columns.Add("MedID", "MedID")
        DataGridView1.Columns.Add("MedName", "MedName")
            DataGridView1.Columns.Add("Quantity", "Quantity")
            DataGridView1.Columns.Add("Type", "Type")

            For Each items In records
            DataGridView1.Rows.Add(items.Key, items.Value.MedID, items.Value.MedName, items.Value.Quantity, items.Value.Type)
        Next


    End Sub

Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Label1.Text += Fname + "!"
    Try
        Client = New FireSharp.FirebaseClient(fcon)
    Catch ex As Exception

    End Try
End Sub

Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim medicine As New Medicine With
{
        .MedID = TextBox1.Text,
        .MedName = TextBox2.Text,
        .Type = TextBox4.Text,
        .Quantity = TextBox3.Text}


        MessageBox.Show("data stored successfully")
        Dim setter = client.Set("Medicine/" + TextBox2.Text, medicine)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim valuables As New Valuables With
{
        .Name = TextBox2.Text,
        .Quantity = TextBox3.Text}


        MessageBox.Show("data stored successfully")
        Dim setter = client.Set("valuables/" + TextBox2.Text, valuables)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class