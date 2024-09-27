Imports MySql.Data.MySqlClient

Public Class CreateOrder

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ChooseOrder.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String = TextBox1.Text
        Dim kilo As Integer
        Dim price As Decimal
        Dim service As String = "Self Service" ' Automatically set the service to "Self Service"
        Dim serviceType As String = ComboBox1.SelectedItem.ToString() ' Get the selected service type (Washing or Drying)
        Dim currentDateTime As DateTime = DateTime.Now ' Get current date and time
        Dim pickupDate As Date = DateTimePicker1.Value ' Get the date from DateTimePicker1
        Dim status As String = "Pending" ' Automatically set status to "Pending"
        Dim orderType As String = serviceType ' Set the "type" based on the selected service type (Washing or Drying)

        ' Validate name
        If String.IsNullOrWhiteSpace(name) Then
            MessageBox.Show("Please enter a name.")
            TextBox1.Focus() ' Set focus back to TextBox1 for user input
            Exit Sub
        End If

        ' Validate and process kilo
        If Integer.TryParse(TextBox2.Text, kilo) Then
            ' Calculate price based on selected service and kilo weight
            If serviceType = "Washing" Then
                If kilo <= 4 Then
                    price = kilo * 55
                Else
                    price = kilo * 75
                End If
            ElseIf serviceType = "Drying" Then
                If kilo <= 4 Then
                    price = kilo * 45
                Else
                    price = kilo * 65
                End If
            Else
                MessageBox.Show("Please select a valid service type.")
                Exit Sub
            End If

            Label7.Text = "" & price.ToString("C")

            ' SQL Insert Query with type and status included
            Dim query As String = "INSERT INTO orders (name, service, kilo, price, date, pickupdate, status, type) " &
                                  "VALUES (@name, @service, @kilo, @price, @date, @pickupdate, @status, @type)"

            ' Database connection
            Try
                Using con As New MySqlConnection("Server=localhost;User Id=root;Password=;Database=e&qlaundry;")
                    Using cmd As New MySqlCommand(query, con)
                        ' Set parameters
                        cmd.Parameters.AddWithValue("@name", name)
                        cmd.Parameters.AddWithValue("@service", service)
                        cmd.Parameters.AddWithValue("@kilo", kilo)
                        cmd.Parameters.AddWithValue("@price", price)
                        cmd.Parameters.AddWithValue("@date", currentDateTime) ' Insert current date and time
                        cmd.Parameters.AddWithValue("@pickupdate", pickupDate)
                        cmd.Parameters.AddWithValue("@status", status) ' Insert "Pending" into the status column
                        cmd.Parameters.AddWithValue("@type", orderType) ' Insert "Washing" or "Drying" into the type column

                        ' Open connection and execute query
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()

                        ' Show confirmation message
                        MessageBox.Show("Order added successfully!")
                        Me.Hide()
                        Orders.Show()
                    End Using
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Failed to insert data: " & ex.Message)
            End Try
        Else
            ' Show error message if kilo is not a valid number
            MessageBox.Show("Please enter a valid number for kilo.")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        UpdateLabel7()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        UpdateLabel7()
    End Sub

    Private Sub UpdateLabel7()
        Dim kilo As Integer
        Dim price As Decimal
        Dim serviceType As String = ComboBox1.SelectedItem?.ToString() ' Get the selected service type (Washing or Drying)

        ' Check if the selected service and quantity (kilo) are valid
        If serviceType IsNot Nothing AndAlso Integer.TryParse(TextBox2.Text, kilo) Then

            ' Calculate price based on selected service and kilo weight
            If serviceType = "Washing" Then
                If kilo <= 4 Then
                    price = kilo * 55
                Else
                    price = kilo * 75
                End If
            ElseIf serviceType = "Drying" Then
                If kilo <= 4 Then
                    price = kilo * 45
                Else
                    price = kilo * 65
                End If
            Else
                Label7.Text = "Invalid service selected."
                Exit Sub
            End If

            ' Update Label7 with the computed price
            Label7.Text = "" & price.ToString("C")
        Else
            Label7.Text = ""
        End If
    End Sub

End Class
