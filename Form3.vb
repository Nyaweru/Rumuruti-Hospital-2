Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_MouseClick(sender As Object, e As MouseEventArgs) Handles Button2.MouseClick
        Me.Hide()
        Form8.Show()
    End Sub

    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs) Handles Button1.MouseClick
        Me.Hide()
        Form9.Show()
    End Sub

    Private Sub Button4_MouseClick(sender As Object, e As MouseEventArgs) Handles Button4.MouseClick
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub Button3_MouseClick(sender As Object, e As MouseEventArgs) Handles Button3.MouseClick
        Me.Hide()
        Form11.Show()
    End Sub

    Private Sub Button5_MouseClick(sender As Object, e As MouseEventArgs) Handles Button5.MouseClick
        Me.Hide()
        Form12.Show()
    End Sub

End Class