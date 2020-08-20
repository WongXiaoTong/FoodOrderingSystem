Public Class SplashScreen
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Hide()
        UserLogin.Show()
    End Sub

    Private Sub cmsExit_Click(sender As Object, e As EventArgs) Handles cmsExit.Click
        Me.Close()
    End Sub

    Private Sub PictureBoxExit_Click(sender As Object, e As EventArgs) Handles PictureBoxExit.Click
        Me.Close()
    End Sub

End Class