Public Class Member
    Private Sub TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MemberRegistrationDataSet)

    End Sub

    Private Sub Member_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MemberRegistrationDataSet.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.MemberRegistrationDataSet.Table)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub GenderLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GenderComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GenderComboBox.SelectedIndexChanged

    End Sub
End Class