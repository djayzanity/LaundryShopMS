Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Dashboard
    Private _username As String
    Public Sub New(username As String)
        InitializeComponent() ' Always call InitializeComponent first in a constructor
        _username = username ' Store the username
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

    ' Method to load and refresh dashboard data
    Private Sub LoadDashboardData()
        Label7.Text = "Welcome, " & _username & "!"

        Dim connectionString As String = "Server=localhost;User Id=root;Password=;Database=e&qlaundry;"

        ' Query for number of orders in the past 7 days
        Dim queryOrders As String = "SELECT COUNT(*) AS OrderCount, DATE(date) AS OrderDate " &
                                "FROM orders " &
                                "WHERE date >= DATE_SUB(CURDATE(), INTERVAL 7 DAY) " &
                                "GROUP BY DATE(date) " &
                                "ORDER BY OrderDate;"

        ' Query for total revenue in the past 7 days
        Dim queryRevenue As String = "SELECT SUM(price) AS TotalRevenue, DATE(date) AS OrderDate " &
                                 "FROM orders " &
                                 "WHERE date >= DATE_SUB(CURDATE(), INTERVAL 7 DAY) " &
                                 "GROUP BY DATE(date) " &
                                 "ORDER BY OrderDate;"

        ' Create a new connection object
        Using con As New MySqlConnection(connectionString)
            con.Open()

            ' Fill Chart1 with the number of orders
            Using daOrders As New MySqlDataAdapter(queryOrders, con)
                Dim dtOrders As New DataTable()
                daOrders.Fill(dtOrders)
                Chart1.Series.Clear()
                Chart1.Titles.Clear()  ' Clear previous titles
                Dim seriesOrders As New Series("Orders")
                seriesOrders.ChartType = SeriesChartType.Column
                For Each row As DataRow In dtOrders.Rows
                    seriesOrders.Points.AddXY(row("OrderDate").ToString(), Convert.ToInt32(row("OrderCount")))
                Next
                Chart1.Series.Add(seriesOrders)
                Chart1.ChartAreas(0).AxisX.Title = "Date"
                Chart1.ChartAreas(0).AxisY.Title = "Number of Orders"
                Chart1.Titles.Add("Orders from the Past 7 Days") ' Add title
            End Using

            ' Fill Chart2 with total revenue
            Using daRevenue As New MySqlDataAdapter(queryRevenue, con)
                Dim dtRevenue As New DataTable()
                daRevenue.Fill(dtRevenue)
                Chart2.Series.Clear()
                Chart2.Titles.Clear()  ' Clear previous titles
                Dim seriesRevenue As New Series("Revenue")
                seriesRevenue.ChartType = SeriesChartType.Column
                For Each row As DataRow In dtRevenue.Rows
                    seriesRevenue.Points.AddXY(row("OrderDate").ToString(), Convert.ToDecimal(row("TotalRevenue")))
                Next
                Chart2.Series.Add(seriesRevenue)
                Chart2.ChartAreas(0).AxisX.Title = "Date"
                Chart2.ChartAreas(0).AxisY.Title = "Total Revenue"
                Chart2.Titles.Add("Revenue from the Past 7 Days") ' Add title
            End Using
        End Using
    End Sub


    ' Dashboard load event
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashboardData() ' Load data when the dashboard is loaded
    End Sub

    ' Button click event to refresh the dashboard
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadDashboardData() ' Refresh data when the refresh button is clicked
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        ' Clear the username
        _username = String.Empty

        ' Show a confirmation message before logging out
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            ' Close the current dashboard form
            Me.Hide()

            ' Open the login form (assuming you have a form named LoginForm)
            Dim loginForm As New Form1()
            loginForm.Show()

            ' Optional: You can also close the dashboard completely
            Me.Close()
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class