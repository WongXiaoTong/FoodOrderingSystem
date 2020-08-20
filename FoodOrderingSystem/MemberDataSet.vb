Partial Class MemberDataSet
    Partial Public Class MemberDataTable
        Private Sub MemberDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.AdressColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

        Private Function AdressColumn() As Object
            Throw New NotImplementedException()
        End Function
    End Class
End Class
