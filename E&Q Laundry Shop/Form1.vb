Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        SignUpfrm.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MySqlConnection As New MySqlConnection("Server=localhost;User Id=root;Password=;Database=e&qlaundry;")

        Try
            MySqlConnection.Open()

            ' Modify the SQL query to return the username
            Dim MySqlCommand As New MySqlCommand("SELECT username FROM admin WHERE username = @username AND password = @password", MySqlConnection)

            MySqlCommand.Parameters.AddWithValue("@username", TextBox1.Text)
            MySqlCommand.Parameters.AddWithValue("@password", TextBox2.Text)

            Dim username As String = Convert.ToString(MySqlCommand.ExecuteScalar())

            If Not String.IsNullOrEmpty(username) Then
                MessageBox.Show("Login successful!")

                ' Pass the logged-in username to the Dashboard form
                GlobalVariables.LoggedInUsername = TextBox1.Text
                ' Pass the global username to the dashboard
                Dim dashboard As New Dashboard(GlobalVariables.LoggedInUsername)
                dashboard.Show()
                Me.Hide()
            Else
                MessageBox.Show("Login failed: Invalid username or password.")
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            MySqlConnection.Close()
        End Try
    End Sub
End Class
