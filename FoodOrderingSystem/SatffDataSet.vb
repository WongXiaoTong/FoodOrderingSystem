Partial Class SatffDataSet
    Partial Public Class StaffDataTable
        Private Sub MemberDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.AddressColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

        Private Function AddressColumn() As Object
            Throw New NotImplementedException()
        End Function
    End Class
End Class
