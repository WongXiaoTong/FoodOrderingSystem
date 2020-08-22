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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        TableBindingSource.AddNew()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        TableTableAdapter.Update(MemberRegistrationDataSet)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MemberRegistrationDataSet)

        If btnUpdate.Text = "Update" Then
            btnUpdate.Text = "Save"
            MsgBox("Record Updated")
        Else
            btnUpdate.Text = "Update"
            MsgBox("Record Saved")
        End If
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        TableBindingSource.RemoveCurrent()
        Me.TableAdapterManager.UpdateAll(Me.MemberRegistrationDataSet)
        MsgBox("Record Deleted")
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        With TableBindingSource
            If .Position = 9999 Then
                .MoveFirst()
            Else
                .MoveNext()
            End If
        End With
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        With TableBindingSource
            If .Position = 10000 Then
                .MoveLast()
            Else
                .MovePrevious()
            End If
        End With
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        With TableBindingSource
            If .Position <> 10000 Then
                .MoveFirst()
            Else
                .MovePrevious()
            End If
        End With
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        With TableBindingSource
            If .Position <> 9999 Then
                .MoveLast()
            Else
                .MoveNext()
            End If
        End With
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim id As Integer
        id = InputBox("Enter ID you want to search")
        TableBindingSource.Filter = "Id='" & id & "'"
    End Sub
End Class