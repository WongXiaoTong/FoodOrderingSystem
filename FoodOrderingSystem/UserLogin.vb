Public Class UserLogin
    Private Sub lblUsername_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "admin" And txtPassword.Text = "admin" Then
            MsgBox("Login Successfully!", MsgBoxStyle.OkOnly, "Log in Form")
            Me.Hide()
            Home.Show()
        Else
            MsgBox("Please Enter a Valid Username or Password", MsgBoxStyle.OkOnly, "Invalid")
        End If
    End Sub

    Private Sub cmsExit_Click(sender As Object, e As EventArgs) Handles cmsExit.Click
        Me.Close()
    End Sub

    Private Sub PictureBoxExit_Click(sender As Object, e As EventArgs) Handles PictureBoxExit.Click
        Me.Close()
    End Sub

    Private Sub UserLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class