Imports System.Drawing.Printing
Imports Org.BouncyCastle.Crypto

Public Class Form10
    Dim a As Integer
    Dim b As Integer
    Dim c As Integer
    Dim d As Integer
    Dim f As Integer

    Dim WithEvents mPrintDocument As New PrintDocument
    Dim mPrintBitMap As Bitmap
    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox16.Text = a
        TextBox17.Text = b
        TextBox18.Text = c
        TextBox23.Text = d
        f = a + b + c + d
        TextBox19.Text = f


    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged
        TextBox16.Text = a

    End Sub

    Private Sub TextBox17_TextChanged(sender As Object, e As EventArgs) Handles TextBox17.TextChanged
        TextBox17.Text = b
    End Sub

    Private Sub TextBox18_TextChanged(sender As Object, e As EventArgs) Handles TextBox18.TextChanged
        TextBox18.Text = c
    End Sub

    Private Sub TextBox23_TextChanged(sender As Object, e As EventArgs) Handles TextBox23.TextChanged
        TextBox23.Text = d
    End Sub
End Class