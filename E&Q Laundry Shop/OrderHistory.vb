Public Class OrderHistory

    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Orders.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
        Customers.Show()
        Me.Hide()
    End Sub
End Class