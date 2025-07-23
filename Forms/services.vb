Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class services
    Dim dict As New Dictionary(Of String, String)

    Private Sub addS_Click(sender As Object, e As EventArgs) Handles addS.Click
        Dim LService As String = service.Text
        Dim LDuration As String = duration.Text
        Dim LIdEquipments As String


        Dim i As String
        BindData()

        For Each i In Me.ListBox1.SelectedItems
            'MsgBox(Me.ListBox1.SelectedItems.ToString)
            LIdEquipments = dict(i)
            ' MsgBox(LIdEquipments)
            Dim query As String = "INSERT INTO service VALUES(@SERVICE, @DURATION,@ID_EQUIPMENTS)"
            Using CON As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
                Using cmd As SqlCommand = New SqlCommand(query, CON)
                    cmd.Parameters.AddWithValue("@SERVICE", LService)
                    cmd.Parameters.AddWithValue("@DURATION", LDuration)
                    cmd.Parameters.AddWithValue("@ID_EQUIPMENTS", LIdEquipments)
                    CON.Open()
                    Try
                        cmd.ExecuteNonQuery()
                    Catch ex As SqlException When ex.ErrorCode = -2146232060
                        MsgBox("Record already exists in the database.")
                        Exit Sub
                    End Try
                    CON.Close()
                    service.Text = ""
                    duration.Text = ""
                    'ListBox1.Items.Clear()

                    MessageBox.Show("successful inserted")
                    BindData()
                End Using
            End Using
        Next

    End Sub


    Public Sub BindData()
        Dim query As String = "SELECT * FROM service"
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

    Private Sub populateS_Click(sender As Object, e As EventArgs) Handles populateS.Click
        Dim lId As Integer
        Dim lEquipment As String
        Dim lDuration As String


        Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
        conn.Open()



        Dim cmdS As SqlCommand = New SqlCommand("
               SELECT * FROM EQUIPMENTS
               ", conn)




        Dim readS As SqlDataReader = cmdS.ExecuteReader
        ListBox1.Items.Clear()
        If readS.HasRows Then


            '  If data_reader.HasRows Then
            Do While readS.Read()

                lEquipment = readS("equipment")

                lId = readS("id")
                dict.Add(lEquipment, lId.ToString)

                lDuration = readS("duration")
                ListBox1.Items.Add(lEquipment)
            Loop
        End If

        conn.Close()


    End Sub

    Private Sub searchS_Click(sender As Object, e As EventArgs) Handles searchS.Click
        Dim id_eq As String
        If String.IsNullOrEmpty(searchLabel.Text) = False Then
            Dim query As String = "SELECT * FROM service WHERE service='" & searchLabel.Text & "'"
            Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    Using da As New SqlDataAdapter()
                        da.SelectCommand = cmd
                        Using dt As New DataTable()
                            da.Fill(dt)
                            If dt.Rows.Count > 0 Then
                                service.Text = dt.Rows(0)(1).ToString()
                                duration.Text = dt.Rows(0)(2).ToString()
                                id_eq = dt.Rows(0)(3).ToString()


                            Else
                                service.Text = ""
                                duration.Text = ""
                                ListBox1.Items.Clear()
                            End If



                        End Using
                    End Using
                End Using
            End Using

            'equipment
            Dim lid As String

            Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
            conn.Open()



            Dim cmdS As SqlCommand = New SqlCommand("
               SELECT * FROM EQUIPMENTS where id=@id
               ", conn)

            cmdS.Parameters.AddWithValue("@id", id_eq)


            Dim readS As SqlDataReader = cmdS.ExecuteReader
            If readS.HasRows Then


                '  If data_reader.HasRows Then
                Do While readS.Read()
                    ListBox1.Items.Add(readS("equipment"))

                Loop
            End If

            'equipment
        Else
            BindData()
        End If
    End Sub

    Private Sub updateS_Click(sender As Object, e As EventArgs) Handles updateS.Click
        Dim lService As String = service.Text
        Dim lDuration As String = duration.Text
        'equipment
        Dim lid As String

        Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
        conn.Open()



        Dim cmdS As SqlCommand = New SqlCommand("
               SELECT * FROM EQUIPMENTS where equipment=@eq
               ", conn)

        cmdS.Parameters.AddWithValue("@eq", ListBox1.SelectedItem.ToString)


        Dim readS As SqlDataReader = cmdS.ExecuteReader
        If readS.HasRows Then


            '  If data_reader.HasRows Then
            Do While readS.Read()
                lId = readS("id")

            Loop
        End If

        'equipment

        Dim query As String = ("UPDATE service SET service=@service, duration=@duration, id_eq=@id_eq  WHERE service=@service")
        Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@service", lService)
                cmd.Parameters.AddWithValue("@duration", lDuration)
                cmd.Parameters.AddWithValue("@id_eq", lid)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                service.Text = ""
                duration.Text = ""
                ListBox1.Items.Clear()

                MessageBox.Show("successful UPDATED")
                BindData()
            End Using
        End Using
    End Sub

    Private Sub deleteS_Click(sender As Object, e As EventArgs) Handles deleteS.Click
        Dim lService As String = service.Text


        Dim query As String = ("DELETE FROM service  WHERE service=@service")
        Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@service", lService)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                service.Text = ""
                duration.Text = ""
                ListBox1.Items.Clear()


                MessageBox.Show("successful deleted")
                BindData()
            End Using
        End Using
    End Sub


End Class