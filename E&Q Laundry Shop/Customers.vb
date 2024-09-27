Public Class Customers

    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Orders.Show()
        Me.Hide()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs)
        OrderHistory.Show()
        Me.Hide()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim dashboard As New Dashboard(GlobalVariables.LoggedInUsername)
        dashboard.Show()
        Me.Hide()
    End Sub
End Class