Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class FulfilledReports
    Private Sub FulfilledReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Retrieve the data from the database using a GROUP BY query
        Dim connectionString As String = "Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False"
        Dim sql As String = "SELECT doctor  , COUNT(fulfilled) AS fulfilled FROM RESERVETION where fulfilled='T' and MONTH(date) = '" + monthI.Text + "' GROUP BY doctor  "
        Dim sqlA As String = "SELECT doctor  , COUNT(fulfilled) AS fulfilled FROM RESERVETION where fulfilled='F' and MONTH(date) = '" + monthI.Text + "' GROUP BY doctor  "

        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(sql, connection)

                connection.Open()
                dataTable.Load(command.ExecuteReader())
            End Using
        End Using

        Dim dataTableA As New DataTable()

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(sqlA, connection)

                connection.Open()
                dataTableA.Load(command.ExecuteReader())
            End Using
        End Using


        ' Set the chart control's properties
        fulfilled.Width = 500
        fulfilled.Height = 300
        fulfilled.Titles.Add("Monthly Report")

        ' Create a series for the chart
        Dim series1 As New Series("Fulfilled")
        series1.ChartType = SeriesChartType.Column
        Dim series2 As New Series("Not Fulfilled")
        series2.ChartType = SeriesChartType.Column

        ' Add the data to the chart series
        For Each row As DataRow In dataTable.Rows
            Dim doctor As String = row("doctor")
            Dim fulfilled As Integer = CInt(row("fulfilled"))
            series1.Points.AddXY(doctor, fulfilled)
        Next

        ' Add the data to the chart series
        For Each rowA As DataRow In dataTableA.Rows
            Dim doctor As String = rowA("doctor")
            Dim fulfilled As Integer = CInt(rowA("fulfilled"))
            series2.Points.AddXY(doctor, fulfilled)
        Next
        ' Add the series to the chart and display it
        fulfilled.Series.Add(series1)
        fulfilled.Series.Add(series2)

        Me.Controls.Add(fulfilled)

    End Sub
End Class