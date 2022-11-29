Imports FireSharp.Response
Imports Mysqlx.XDevAPI
Imports Newtonsoft.Json
Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports Org.BouncyCastle.Asn1.X509
Imports System.Xml.XPath

Public Class Form9
    Private fcon As New FirebaseConfig With
        {
         .AuthSecret = "HeVjDKbwc6BTVvWtfn6WuaWnMnqapxWYnPV04Sqf ",
        .BasePath = " https://rumuruti-hospital-fca60-default-rtdb.firebaseio.com/"
  }
    Private client As IFirebaseClient
    Public Shared Fname

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim PRESCRIPTION As New PRESCRIPTION With
{
       .PATNAME = TextBox1.Text,
       .PATID = TextBox2.Text,
       .DIAGNOSIS = TextBox3.Text,
       .DOSAGE = TextBox5.Text,
        .DRUG = TextBox4.Text,
        .ANYOTHER = TextBox6.Text,
        .DOSAGE2 = TextBox7.Text,
        .SIDEEFFECT = TextBox8.Text}



        MessageBox.Show("data stored successfully")
        Dim setter = client.Set("PRESCRIPTION /" + TextBox1.Text, PRESCRIPTION)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim res As FirebaseResponse = client.Get("PRESCRIPTION")
        Dim data As Dictionary(Of String, PRESCRIPTION) = JsonConvert.DeserializeObject(Of Dictionary(Of String, PRESCRIPTION))(res.Body.ToString())
        updateDataGrid(data)
    End Sub
    Sub updateDataGrid(ByVal records As Dictionary(Of String, PRESCRIPTION))

        DataGridView1.Rows.Clear()



        DataGridView1.Columns.Add("PATNAME", "PATNAME")
            DataGridView1.Columns.Add("PATID", "PATID")
            DataGridView1.Columns.Add("DIAGNOSIS", "DIAGNOSIS")
            DataGridView1.Columns.Add("DRUG", "DRUG")
            DataGridView1.Columns.Add("DOSAGE", "DOSAGE")
            DataGridView1.Columns.Add("ANYOTHER", "ANYOTHER")

            DataGridView1.Columns.Add("DOSAGE2", "DOSAGE2")
            DataGridView1.Columns.Add("SIDEFFECTS", "SIDEEFFECTS")



        For Each items In records
            DataGridView1.Rows.Add(items.Key, items.Value.PATNAME, items.Value.PATID, items.Value.DIAGNOSIS, items.Value.DRUG, items.Value.DOSAGE, items.Value.ANYOTHER, items.Value.DOSAGE2, items.Value.SIDEEFFECT)
        Next








    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form10.Show()

    End Sub
End Class