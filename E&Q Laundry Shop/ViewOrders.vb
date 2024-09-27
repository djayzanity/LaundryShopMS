Imports MySql.Data.MySqlClient

Public Class ViewOrders
    Private Sub ViewOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrders()
    End Sub

    ' Method to load orders into DataGridView1
    Private Sub LoadOrders()
        Dim connectionString As String = "Server=localhost;User Id=root;Password=;Database=e&qlaundry;"
        Dim query As String = "SELECT * FROM orders"

        ' Create a new connection object
        Using con As New MySqlConnection(connectionString)
            ' Create a data adapter to retrieve data from the database
            Using da As New MySqlDataAdapter(query, con)
                ' Create a DataTable to hold the retrieved data
                Dim dt As New DataTable()

                ' Fill the DataTable with data
                da.Fill(dt)

                ' Bind the DataTable to the DataGridView
                DataGridView1.DataSource = dt
                If DataGridView1.Columns.Contains("id") Then
                    DataGridView1.Columns("id").Visible = False ' Optionally hide the id column
                End If
            End Using
        End Using
    End Sub

    ' Event handler for Button2 to update the selected order's status to "Completed"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Check if a row is selected
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Get the selected order ID (assuming the first column is the order id)
            Dim selectedOrderId As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("id").Value)

            ' Update the status of the selected order to "Completed"
            UpdateOrderStatus(selectedOrderId, "Completed")

            ' Refresh the DataGridView to show the updated data
            LoadOrders()
        Else
            MessageBox.Show("Please select an order to update.")
        End If
    End Sub

    ' Method to update the order status in the database
    Private Sub UpdateOrderStatus(orderId As Integer, newStatus As String)
        Dim connectionString As String = "Server=localhost;User Id=root;Password=;Database=e&qlaundry;"
        Dim query As String = "UPDATE orders SET status = @status WHERE id = @id"

        Try
            Using con As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(query, con)
                    ' Set the parameters
                    cmd.Parameters.AddWithValue("@status", newStatus)
                    cmd.Parameters.AddWithValue("@id", orderId)

                    ' Open the connection and execute the query
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()

                    MessageBox.Show("Order status updated to 'Completed'.")
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Failed to update status: " & ex.Message)
        End Try
    End Sub

    ' Optionally, handle row selection to ensure a row is selected in DataGridView1
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        ' You can add any functionality here if you need to track selected rows
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Get the selected order ID (assuming the first column is the order id)
            Dim selectedOrderId As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("id").Value)

            ' Confirm with the user before deleting the order
            Dim confirmDelete As DialogResult = MessageBox.Show("Are you sure you want to delete this order?", "Confirm Delete", MessageBoxButtons.YesNo)
            If confirmDelete = DialogResult.Yes Then
                ' Delete the selected order
                DeleteOrder(selectedOrderId)

                ' Refresh the DataGridView to show the updated data
                LoadOrders()
            End If
        Else
            MessageBox.Show("Please select an order to delete.")
        End If
    End Sub
    Private Sub DeleteOrder(orderId As Integer)
        Dim connectionString As String = "Server=localhost;User Id=root;Password=;Database=e&qlaundry;"
        Dim query As String = "DELETE FROM orders WHERE id = @id"

        Try
            Using con As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(query, con)
                    ' Set the parameter for the order ID
                    cmd.Parameters.AddWithValue("@id", orderId)

                    ' Open the connection and execute the query
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()

                    MessageBox.Show("Order deleted successfully.")
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Failed to delete order: " & ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Orders.Show()
        Me.Hide()

    End Sub
End Class
