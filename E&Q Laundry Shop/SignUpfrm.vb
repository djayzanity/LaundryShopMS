Imports MySql.Data.MySqlClient

Public Class SignUpfrm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MySqlConnection As New MySqlConnection("Server=localhost;User Id=root;Password=;Database=e&qlaundry;")
        Try
            MySqlConnection.Open()

            Dim MySqlCommand As New MySqlCommand("INSERT INTO admin (username, password, phone, address) VALUES (@username, @password, @phone, @address)", MySqlConnection)

            MySqlCommand.Parameters.AddWithValue("@username", TextBox2.Text)
            MySqlCommand.Parameters.AddWithValue("@password", TextBox3.Text)
            MySqlCommand.Parameters.AddWithValue("@phone", TextBox1.Text)
            MySqlCommand.Parameters.AddWithValue("@address", TextBox4.Text)

            MySqlCommand.ExecuteNonQuery()

            MessageBox.Show("Data inserted successfully!")
            Me.Hide()
            Form1.Show()

        Catch ex As Exception
            MessageBox.Show("Failed to insert data: " & ex.Message)
        Finally
            MySqlConnection.Close()
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form1.Show()
    End Sub
End Class