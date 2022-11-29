Public Class Myuser
    Public Property Username() As String
    Public Property UserID() As String
    Public Property Role() As String
    Private Shared TheError As String = "username not found"
    Public Sub showERROR()
        MessageBox.Show(TheError)

    End Sub
    Public Shared Function IsEqual(User1 As Myuser, User2 As Myuser)
        If (User1 Is Nothing Or User2 Is Nothing) Then
            Error ("user not found")
            Return False

        End If
        If User1.Username Is Nothing Then
            Error ("username not found")
            Return False

        End If
        If User1.UserID Is Nothing Then
            Error (" username  and UserID does not match")
            Return False
        End If

        Return True
        End
    End Function
End Class
