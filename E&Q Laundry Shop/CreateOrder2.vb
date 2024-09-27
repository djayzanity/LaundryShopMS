Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class CreateOrder2

    ' Define the PrintDocument object
    Private WithEvents PrintDocument1 As New PrintDocument
    Private PrintPreviewDialog1 As New PrintPreviewDialog

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ChooseOrder.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String = TextBox1.Text
        Dim kilo As Integer
        Dim price As Decimal
        Dim service As String = "Full Service"
        Dim serviceType As String = ComboBox1.SelectedItem.ToString()
        Dim currentDateTime As DateTime = DateTime.Now
        Dim pickupDate As Date = DateTimePicker1.Value
        Dim status As String = "Pending"
        Dim orderType As String = serviceType

        ' Validate name
        If String.IsNullOrWhiteSpace(name) Then
            MessageBox.Show("Please enter a name.")
            TextBox1.Focus()
            Exit Sub
        End If

        ' Validate and process kilo
        If Integer.TryParse(TextBox2.Text, kilo) Then
            If serviceType = "Regular Clothes" Then
                If kilo <= 4 Then
                    price = 130
                Else
                    price = 170
                End If
            ElseIf serviceType = "Comforters, Blankets, Bed Sheets" Then
                price = kilo * 130
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
            If serviceType = "Regular Clothes" Then
                If kilo <= 4 Then
                    price = 130
                Else
                    price = 170
                End If
            ElseIf serviceType = "Comforters, Blankets, Bed Sheets" Then
                price = kilo * 130
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

    Private Sub viewreceipt_Click(sender As Object, e As EventArgs) Handles viewreceipt.Click
        ' Configure PrintDocument
        PrintDocument1.DocumentName = "Receipt"
        PrintPreviewDialog1.Document = PrintDocument1

        ' Show Print Preview Dialog
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Define the total dimensions of the receipt
        Dim pageWidth As Integer = 300 ' Example width in pixels
        Dim pageHeight As Integer = 400 ' Example height in pixels

        ' Define margins
        Dim marginLeft As Integer = 20
        Dim marginTop As Integer = 20
        Dim marginRight As Integer = 20
        Dim marginBottom As Integer = 20

        ' Define fonts
        Dim fontHeader As New Font("Arial", 14, FontStyle.Bold)
        Dim fontBody As New Font("Arial", 12, FontStyle.Regular)

        ' Create a graphics object
        Dim graphics As Graphics = e.Graphics

        ' Define starting Y position with top margin
        Dim currentY As Integer = marginTop

        ' Print header
        Dim headerText As String = "E&Q Laundry Shop"
        Dim headerSize As SizeF = graphics.MeasureString(headerText, fontHeader)
        Dim headerX As Integer = (pageWidth - headerSize.Width - marginLeft - marginRight) / 2 + marginLeft
        graphics.DrawString(headerText, fontHeader, Brushes.Black, headerX, currentY)
        currentY += headerSize.Height + 20 ' Move down by height of the header plus padding

        ' Get receipt details
        Dim nameText As String = If(String.IsNullOrWhiteSpace(TextBox1.Text), "N/A", "Name: " & TextBox1.Text)
        Dim serviceText As String = If(ComboBox1.SelectedItem Is Nothing, "Service: N/A", "Service: " & ComboBox1.SelectedItem.ToString())
        Dim kilosText As String = If(String.IsNullOrWhiteSpace(TextBox2.Text), "Kilos: N/A", "Kilos: " & TextBox2.Text)
        Dim priceText As String = If(String.IsNullOrWhiteSpace(Label7.Text), "Price: N/A", "Price: " & Label7.Text)
        Dim dateText As String = "Date: " & DateTime.Now.ToShortDateString()

        ' Print receipt details
        Dim details As String() = {nameText, serviceText, kilosText, priceText, dateText}

        For Each detail As String In details
            Dim detailSize As SizeF = graphics.MeasureString(detail, fontBody)
            Dim detailX As Integer = (pageWidth - detailSize.Width - marginLeft - marginRight) / 2 + marginLeft
            If currentY + detailSize.Height <= pageHeight - marginBottom Then
                ' Draw the text
                graphics.DrawString(detail, fontBody, Brushes.Black, detailX, currentY)
                currentY += detailSize.Height + 10 ' Move down by height of the text plus padding
            Else
                ' If text won't fit, signal more pages (pagination)
                e.HasMorePages = True
                Return
            End If
        Next

        ' Signal that no more pages need to be printed
        e.HasMorePages = False
    End Sub





End Class
