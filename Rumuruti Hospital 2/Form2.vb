Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form5.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form6.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        MessageBox.Show("confirm you are about to leave")


        Me.Hide()
        Form1.Show()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form7.Show()
    End Sub
End Class