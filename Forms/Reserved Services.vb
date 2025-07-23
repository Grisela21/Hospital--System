Imports System.Data.SqlClient

Public Class Reserved_Services
    Private Sub Reserved_Services_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT reservetion.service,Equipments.equipment, reservetion.date, reservetion.hour, reservetion.endHour FROM reservetion  INNER JOIN service   ON reservetion.service  = service.service inner join equipments on service.id_eq= EQUIPMENTS.id "
        Using CON As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
            Using cmd As SqlCommand = New SqlCommand(query, CON)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        DataGridView1.DataSource = dt


                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        If String.IsNullOrEmpty(searchLabel.Text) = False Then


            Dim query As String = "SELECT reservetion.service,Equipments.equipment, reservetion.date, reservetion.hour, reservetion.endHour FROM reservetion  INNER JOIN service   ON reservetion.service  = service.service inner join equipments on service.id_eq= EQUIPMENTS.id 
 WHERE service='" & searchLabel.Text & "'"

            Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    Using da As New SqlDataAdapter()
                        da.SelectCommand = cmd
                        Using dt As New DataTable()
                            da.Fill(dt)
                            DataGridView1.DataSource = dt

                        End Using
                    End Using
                End Using
            End Using
        Else
            MsgBox("Type an input please", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private mRow As Integer = 0
    Private newPage As Boolean = True

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim format As New StringFormat
        format.Alignment = StringAlignment.Center
        e.Graphics.DrawString("Reserved Services List", New Font("Centery Goyhic", 20, FontStyle.Bold),
Brushes.Black, New PointF(400, 20), format)
        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        fmt.LineAlignment = StringAlignment.Center
        fmt.Trimming = StringTrimming.EllipsisCharacter
        fmt.Alignment = StringAlignment.Center

        Dim y As Integer = 100
        Dim x As Integer = 150
        Dim h As Integer = 0
        Dim rc As Rectangle
        Dim row As DataGridViewRow
        If newPage Then
            row = DataGridView1.Rows(mRow)
            x = 150
            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.FillRectangle(Brushes.LightGray, rc)
                    e.Graphics.DrawRectangle(Pens.Black, rc)
                    e.Graphics.DrawString(DataGridView1.Columns(cell.ColumnIndex).HeaderText,
                                          DataGridView1.Font, Brushes.Black, rc, fmt)

                    x += rc.Width
                    h = Math.Max(h, rc.Height)

                End If
            Next
            y += h
        End If

        newPage = False
        Dim displayNow As Integer
        For displayNow = mRow To DataGridView1.RowCount - 1
            row = DataGridView1.Rows(displayNow)
            x = 150
            h = 0

            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    fmt.Alignment = StringAlignment.Near
                    rc.Offset(10, 0)


                    e.Graphics.DrawString(cell.FormattedValue.ToString(), DataGridView1.Font, Brushes.Black, rc, fmt)


                    x += rc.Width
                    h = Math.Max(h, rc.Height)

                End If
            Next
            y += h

        Next
    End Sub
End Class