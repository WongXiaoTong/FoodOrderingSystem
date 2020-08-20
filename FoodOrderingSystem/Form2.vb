Imports System.Data.SqlClient

Public Class Form2
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SatffDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.SatffDataSet.Staff)

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sam Kuen\Desktop\FoodOrderingSystemAssignment\FoodOrderingSystem\FoodOrderingSystem\Satff.mdf;Integrated Security=True;Connect Timeout=30"
        If con.State = ConnectionState.Open Then
            con.Open()
        End If
        con.Open()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub StaffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SatffDataSet)

    End Sub

    Private Sub User_TypeLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub StaffDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StaffDataGridView.CellContentClick

    End Sub

    Private Sub User_TypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles User_TypeComboBox.SelectedIndexChanged

    End Sub

    Private Sub User_NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles User_NameTextBox.TextChanged

    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ADD.Click
        cmd = con.CreateCommand()
        cmd.CommandType = "insert into table1 value('" & User_TypeComboBox.Text & "','" & User_NameTextBox.Text & "','" & PasswordTextBox.Text & "')"
        cmd.ExecuteNonQuery()

        MessageBox.Show("Record Insert Successfully")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles DELETE.Click

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles DELETE.Click

    End Sub
End Class