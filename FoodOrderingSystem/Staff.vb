Public Class Staff
    Private Sub TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StaffDataSet)

    End Sub

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StaffDataSet.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.StaffDataSet.Table)

    End Sub
End Class