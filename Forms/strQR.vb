Imports System.Data.SqlClient

Public Class strQR
    Private Sub read_Click(sender As Object, e As EventArgs) Handles read.Click
        Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
        conn.Open()
        Dim cmdID As SqlCommand = New SqlCommand("SELECT *  FROM QRSTRING where qr_string= '" + strFromQR.Text + "'", conn)

        Dim readID As SqlDataReader = cmdID.ExecuteReader

        If readID.HasRows Then

            Do While readID.Read()
                Dim id_App = readID("id_reservetion")


                Me.Hide()
                Dim sql As String = $"select * from RESERVETION where ID = {id_App}"
                Dim dt As DataTable = QueryAsDataTable(sql)
                If dt.Rows.Count > 0 Then
                    Dim row As DataRow = dt.Rows(0)
                    With Scheduling
                        .id_hide.Text = 1
                        .appID = id_App
                        .cusCont.Text = row("cus_Cont")
                        .comment.Text = row("comment")
                        .ListBox1.Items.Add(row("service"))
                        .DateTimePicker1.Value = row("date")
                        .ListBox2.Items.Add(row("hour"))
                        .ListBox3.Items.Add(row("doctor"))

                        .ShowDialog()

                    End With

                End If

            Loop
        Else
            MsgBox("You don`t have an appointment")
        End If
    End Sub


End Class