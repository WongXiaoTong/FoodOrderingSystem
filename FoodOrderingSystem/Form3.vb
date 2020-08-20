Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MemberDataSet.Member' table. You can move, or remove it, as needed.
        Me.MemberTableAdapter.Fill(Me.MemberDataSet.Member)
        'TODO: This line of code loads data into the 'MemberDataSet.Member' table. You can move, or remove it, as needed.
        Me.MemberTableAdapter.Fill(Me.MemberDataSet.Member)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Male_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MemberBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MemberBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MemberDataSet)

    End Sub

    Private Sub MemberBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MemberBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MemberDataSet)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.MemberTableAdapter.FillBy(Me.MemberDataSet.Member)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub AdressLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MemberDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class