Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class CanceledReport
    Private Sub CanceledReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Retrieve the data from the database using a GROUP BY query
        Dim connectionString As String = "Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False"
        Dim sql As String = "SELECT doctor  , COUNT(canceled) AS canceled FROM RESERVETION where canceled='T' and MONTH(date) = '" + monthI.Text + "' GROUP BY doctor  "
        Dim sqlA As String = "SELECT doctor  , COUNT(canceled) AS canceled FROM RESERVETION where canceled='F' and MONTH(date) = '" + monthI.Text + "' GROUP BY doctor  "
        Dim dataTable As New DataTable()
        Dim dataTableA As New DataTable()
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(sql, connection)

                connection.Open()
                dataTable.Load(command.ExecuteReader())
            End Using
        End Using

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(sqlA, connection)

                connection.Open()
                dataTableA.Load(command.ExecuteReader())
            End Using
        End Using

        ' Create a new chart control
        ' Dim chart1 As New Chart()

        ' Set the chart control's properties
        canceled.Width = 500
        canceled.Height = 300
        canceled.Titles.Add("Monthly Report")

        ' Create a series for the chart
        Dim series1 As New Series("Canceled")
        series1.ChartType = SeriesChartType.Column
        Dim series2 As New Series("Opened")
        series2.ChartType = SeriesChartType.Column

        ' Add the data to the chart series
        For Each row As DataRow In dataTable.Rows
            Dim doctor As String = row("doctor")
            Dim canceled As Integer = CInt(row("canceled"))
            series1.Points.AddXY(doctor, canceled)
        Next

        For Each rowA As DataRow In dataTableA.Rows
            Dim doctor As String = rowA("doctor")
            Dim canceled As Integer = CInt(rowA("canceled"))
            series2.Points.AddXY(doctor, canceled)
        Next

        ' Add the series to the chart and display it
        canceled.Series.Add(series1)
        canceled.Series.Add(series2)

        Me.Controls.Add(canceled)

    End Sub
End Class