Imports System.Data.SqlClient
Imports System.Windows.Controls

Public Class Equipments
    Private Sub addS_Click(sender As Object, e As EventArgs) Handles addS.Click
        Dim Lequipment As String = equipment.Text
        Dim LDuration As String = duration.Text


        BindData()


        Dim query As String = "INSERT INTO equipments VALUES(@equipment, @DURATION)"
        Using CON As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
            Using cmd As SqlCommand = New SqlCommand(query, CON)
                cmd.Parameters.AddWithValue("@equipment", Lequipment)
                cmd.Parameters.AddWithValue("@DURATION", LDuration)
                CON.Open()
                Try
                    cmd.ExecuteNonQuery()
                Catch ex As SqlException When ex.ErrorCode = -2146232060
                    MsgBox("Record already exists in the database.")
                    Exit Sub
                End Try
                CON.Close()
                equipment.Text = ""
                duration.Text = ""

                    MessageBox.Show("successful inserted")
                    BindData()
                End Using
            End Using

    End Sub


    Public Sub BindData()
        Dim query As String = "SELECT * FROM equipments"
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
    End Sub



    Private Sub searchS_Click(sender As Object, e As EventArgs) Handles searchS.Click
        If String.IsNullOrEmpty(searchLabel.Text) = False Then
            Dim query As String = "SELECT * FROM equipments WHERE equipment='" & searchLabel.Text & "'"
            Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    Using da As New SqlDataAdapter()
                        da.SelectCommand = cmd
                        Using dt As New DataTable()
                            da.Fill(dt)
                            If dt.Rows.Count > 0 Then
                                equipment.Text = dt.Rows(0)(1).ToString()
                                duration.Text = dt.Rows(0)(2).ToString()

                            Else
                                equipment.Text = ""
                                duration.Text = ""

                            End If



                        End Using
                    End Using
                End Using
            End Using
        Else
            BindData()
        End If
    End Sub

    Private Sub updateS_Click(sender As Object, e As EventArgs) Handles updateS.Click
        Dim lequipment As String = equipment.Text
        Dim lDuration As String = duration.Text


        Dim query As String = ("UPDATE equipments SET equipment=@equipment, duration=@duration  WHERE equipment=@equipment")
        Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@equipment", lequipment)
                cmd.Parameters.AddWithValue("@duration", lDuration)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                equipment.Text = ""
                duration.Text = ""

                MessageBox.Show("successful UPDATED")
                BindData()
            End Using
        End Using
    End Sub

    Private Sub deleteS_Click(sender As Object, e As EventArgs) Handles deleteS.Click
        Dim lequipment As String = equipment.Text


        Dim query As String = ("DELETE FROM equipments  WHERE equipment=@equipment")
        Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@equipment", lequipment)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                equipment.Text = ""
                duration.Text = ""


                MessageBox.Show("successful deleted")
                BindData()
            End Using
        End Using
    End Sub
End Class