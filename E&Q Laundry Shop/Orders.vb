Imports MySql.Data.MySqlClient

Public Class Orders
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim dashboard As New Dashboard(GlobalVariables.LoggedInUsername)
        dashboard.Show()
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ChooseOrder.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        ChooseOrder.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        ViewOrders.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        ViewOrders.Show()
        Me.Hide()
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel12_Paint(sender As Object, e As PaintEventArgs) Handles Panel12.Paint

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub
End Class
