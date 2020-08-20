Public Class Form4
    Private lblDateTime As Object
    Public Property Timer1 As Object

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblTDin_Click(sender As Object, e As EventArgs) Handles lblTDin.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnTotalR.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub txtLoginUN_Click(sender As Object, e As EventArgs) Handles lblLoginUN.Click
        lblLoginUN.Text = UserLogin.txtUsername.Text

    End Sub

    Private Sub lblTDout_Click(sender As Object, e As EventArgs) Handles lblTDout.Click
        lblTDout.Text = DateTime.Now.ToString("MMMM dd, yyyy h:mm:ss tt")

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim time As DateTime = DateTime.Now
        Dim format As String = "dd MMMMM HH:mm"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class