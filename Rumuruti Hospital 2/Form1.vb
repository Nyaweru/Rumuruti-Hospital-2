Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports Org.BouncyCastle.Asn1.X509

Public Class Form1
    Private fcon As New FirebaseConfig With
        {
        .AuthSecret = "HeVjDKbwc6BTVvWtfn6WuaWnMnqapxWYnPV04Sqf ",
        .BasePath = " https://rumuruti-hospital-fca60-default-rtdb.firebaseio.com/"
        }
    Private client As IFirebaseClient
    Public Shared Fname
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
#Region "Condition"
        If (String.IsNullOrWhiteSpace(TextBox1.Text) AndAlso String.IsNullOrWhiteSpace(TextBox2.Text) AndAlso String.IsNullOrWhiteSpace(TextBox3.Text)) Then
            MessageBox.Show("please fill all the fields")
#End Region
        End If
        Return
        Dim res = client.Get("Users/" + TextBox1.Text)



        Dim resUser = res.ResultAs(Of Myuser)

        Dim CurUser As New Myuser With
            {
            .Role = TextBox1.Text,
            .UserID = TextBox2.Text,
            .Username = TextBox3.Text
            }

        If (Myuser.IsEqual(resUser, CurUser)) Then
            Dim real As New Form
            MessageBox.Show("Login success select from the right side ")

            Me.Hide()
            real.ShowDialog()
            Me.Close()

        Else
            MessageBox.Show("Incorrect logging")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show("check your intrnet connection")
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub
End Class
