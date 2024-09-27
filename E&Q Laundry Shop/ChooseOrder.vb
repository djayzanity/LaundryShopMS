Public Class ChooseOrder
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        CreateOrder.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        CreateOrder.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        CreateOrder2.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim dashboard As New Dashboard(GlobalVariables.LoggedInUsername)
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Orders.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Customers.Show()
        Me.Hide()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        OrderHistory.Show()
        Me.Hide()
    End Sub
End Class