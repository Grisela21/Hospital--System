Imports System.Data.SqlClient
Imports System.Windows.Controls

Public Class Dispaly_Services
    Private Sub Dispaly_Services_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT service.service, service.duration,EQUIPMENTS.equipment , EQUIPMENTS.duration   FROM service  INNER JOIN EQUIPMENTS   ON service.id_eq  = EQUIPMENTS.Id "
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


            Dim query As String = "SELECT service.service, service.duration,EQUIPMENTS.equipment , EQUIPMENTS.duration   FROM service  INNER JOIN EQUIPMENTS   ON service.id_eq  = EQUIPMENTS.Id WHERE service='" & searchLabel.Text & "'"

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
End Class