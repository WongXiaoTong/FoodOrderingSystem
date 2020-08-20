Public Class Home
    Private Sub btnMasterEntry_Click(sender As Object, e As EventArgs) Handles btnMasterEntry.Click
        Slider.Top = btnMasterEntry.Top
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Slider.Top = btnAdmin.Top
        Form2.Show()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Slider.Top = btnMenu.Top
        ContextMenuStrip1.Show(btnMenu, 0, btnMenu.Height)
    End Sub

    Private Sub btnBilling_Click(sender As Object, e As EventArgs) Handles btnBilling.Click
        Slider.Top = btnBilling.Top
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Slider.Top = btnReports.Top
        ContextMenuStrip1.Show(btnReports, 0, btnReports.Height)
    End Sub

    Private Sub DailyMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailyMenuToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim time As DateTime = DateTime.Now
        Dim format As String = "dd MMMMM HH:mm"

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        lblUsername.Text = UserLogin.txtUsername.Text
        lblDateTime.Text = DateTime.Now.ToString("MMMM dd, yyyy h:mm:ss tt")
    End Sub

    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        Slider.Top = btnCal.Top
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub PictureBoxExit_Click(sender As Object, e As EventArgs) Handles PictureBoxExit.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub
End Class