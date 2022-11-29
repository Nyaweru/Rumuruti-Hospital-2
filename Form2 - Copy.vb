Public Class Form2
    Private Sub Button4_MouseClick(sender As Object, e As MouseEventArgs) Handles Button4.MouseClick
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs) Handles Button1.MouseClick
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Button2_MouseClick(sender As Object, e As MouseEventArgs) Handles Button2.MouseClick
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub Button3_MouseClick(sender As Object, e As MouseEventArgs) Handles Button3.MouseClick
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form1.Show()
    End Sub


End Class