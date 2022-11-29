Imports FireSharp.Response
Imports Mysqlx.XDevAPI
Imports Newtonsoft.Json
Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports Org.BouncyCastle.Asn1.X509
Imports System.Configuration

Public Class Form11
    Private fcon As New FirebaseConfig With
        {
         .AuthSecret = "HeVjDKbwc6BTVvWtfn6WuaWnMnqapxWYnPV04Sqf ",
        .BasePath = " https://rumuruti-hospital-fca60-default-rtdb.firebaseio.com/"
  }
    Private client As IFirebaseClient
    Public Shared Fname
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim patient As New Patient With
{
.PATNAME = TextBox1.Text,
.AGE = TextBox2.Text,
.DIAGNOSIS = TextBox4.Text,
.GENDER = TextBox3.Text,
.DOCID = TextBox5.Text}



        MessageBox.Show("data stored successfully")
        Dim setter = client.Set("Patient/" + TextBox2.Text, patient)


    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form3.Show()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim res As FirebaseResponse = client.Get("patient")
        Dim data As Dictionary(Of String, Patient) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Patient))(res.Body.ToString())
        updateDataGrid(data)
    End Sub
    Sub updateDataGrid(ByVal records As Dictionary(Of String, Patient))
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()

        DataGridView1.Columns.Add("PATNAME", "PATNAME")
        DataGridView1.Columns.Add("AGE", "AGE")
        DataGridView1.Columns.Add("GENDER", "GENDER")
        DataGridView1.Columns.Add("DIAGNOSIS", "DIAGNOSIS")
        DataGridView1.Columns.Add("DOCID", "DOCID")


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form9.Show()
    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class