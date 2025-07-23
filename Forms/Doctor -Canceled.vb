Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Doctor__Canceled
    Private Sub Doctor__Canceled_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Retrieve the data from the database using a GROUP BY query
        Dim connectionString As String = "Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False"
        Dim sql As String = "SELECT doctor  , COUNT(*) AS count FROM RESERVETION GROUP BY MONTH(date)"
        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(sql, connection)

                connection.Open()
                dataTable.Load(command.ExecuteReader())
            End Using
        End Using

        ' Create a new chart control
        ' Dim chart1 As New Chart()

        ' Set the chart control's properties
        Chart1.Width = 500
        Chart1.Height = 300
        Chart1.Titles.Add("Monthly Report")

        ' Create a series for the chart
        Dim series1 As New Series("Series1")
        series1.ChartType = SeriesChartType.Column

        ' Add the data to the chart series
        For Each row As DataRow In dataTable.Rows
            Dim month As Integer = CInt(row("month"))
            Dim count As Integer = CInt(row("count"))
            series1.Points.AddXY(month, count)
        Next

        ' Add the series to the chart and display it
        Chart1.Series.Add(series1)
        Me.Controls.Add(Chart1)

    End Sub
End Class