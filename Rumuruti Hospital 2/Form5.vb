Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports Org.BouncyCastle.Asn1.X509
Imports Newtonsoft.Json

Public Class Form5
    Private fcon As New FirebaseConfig With
        {
         .AuthSecret = "HeVjDKbwc6BTVvWtfn6WuaWnMnqapxWYnPV04Sqf ",
        .BasePath = " https://rumuruti-hospital-fca60-default-rtdb.firebaseio.com/"
  }
    Private client As IFirebaseClient
    Public Shared Fname

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show("there was a problem with your internet")

        End Try

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim res As FirebaseResponse = client.Get("The users")
        Dim data As Dictionary(Of String, The_Users) = JsonConvert.DeserializeObject(Of Dictionary(Of String, The_Users))(res.Body.ToString())
        updateRTB(data)
    End Sub
    Sub updateRTB(ByVal records As Dictionary(Of String, The_Users))
        RichTextBox1.Clear()

        For Each items In records
            RichTextBox1.Text = items.Key + "\n"
            RichTextBox1.Text = "Role" + items.Value.Role + "\n"
            RichTextBox1.Text = "UserID" + items.Value.UserID + "\n"
            RichTextBox1.Text = "Username" + items.Value.Username + "\n\n"
        Next




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user As New Myuser With
{
        .Role = TextBox1.Text,
        .UserID = TextBox2.Text,
        .Username = TextBox3.Text}
        MessageBox.Show("data stored successfully")
        Dim setter = client.Set("The Users/" + TextBox1.Text, user)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form2.Show()
    End Sub


End Class