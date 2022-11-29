Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form11.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Button2.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.Enabled = False
    End Sub
End Class