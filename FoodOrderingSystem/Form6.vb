Public Class Form6
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "admin" And TxtPassword.Text = "admin" Then
            MsgBox("Login Successfully!", MsgBoxStyle.OkOnly, "Log in Form")
            Form1.Show()
        Else
            MsgBox("Please Enter a Valid Username or Password", MsgBoxStyle.OkOnly, "Invalid")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub
End Class