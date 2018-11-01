Public Class loginForm
    Dim password = "password"
    Dim username = "username"
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtBoxUsername.Text = "username" And txtBoxPassword.Text = "password" Then
            wageCalc.Show()
        Else
            ErrorLogin.Show()
        End If
    End Sub
End Class
