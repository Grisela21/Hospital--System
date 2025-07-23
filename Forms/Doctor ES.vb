Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Windows

Public Class Doctor_ES
    Dim dict As New Dictionary(Of String, String)
    Dim dict2 As New Dictionary(Of String, String)
    Dim Lemail As String = Form1.lemail

    Private Sub populateS_Click(sender As Object, e As EventArgs) Handles populateS.Click
        Dim lId As Integer
        Dim lServices As String
        Dim lDuration As String


        Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
        conn.Open()



        Dim cmdS As SqlCommand = New SqlCommand("
               SELECT * FROM service
               ", conn)




        Dim readS As SqlDataReader = cmdS.ExecuteReader
        ListBox1.Items.Clear()
        If readS.HasRows Then


            '  If data_reader.HasRows Then
            Do While readS.Read()

                lServices = readS("service")

                lId = readS("id")
                dict.Add(lServices, lId)

                lDuration = readS("duration")

                ListBox1.Items.Add(lServices)
            Loop
        End If

        conn.Close()

    End Sub

    Private Sub EPopulate_Click(sender As Object, e As EventArgs) Handles EPopulate.Click
        Dim lId As Integer
        Dim lEquipment As String
        Dim lDuration As String


        Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
        conn.Open()



        Dim cmdS As SqlCommand = New SqlCommand("
               SELECT * FROM EQUIPMENTS
               ", conn)




        Dim readS As SqlDataReader = cmdS.ExecuteReader
        ListBox2.Items.Clear()
        If readS.HasRows Then


            '  If data_reader.HasRows Then
            Do While readS.Read()

                lEquipment = readS("equipment")

                lId = readS("id")
                dict2.Add(lEquipment, lId.ToString)

                lDuration = readS("duration")
                ListBox2.Items.Add(lEquipment)
            Loop
        End If

        conn.Close()


    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Using CON As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
            '  CON.Open()
            Dim LID As String
            Dim LService As String
            Dim service As String
            Dim LEquipment As String
            Dim equipment As String
            Dim EMAIL As String
            'MsgBox(Lemail)

            Dim i As String


            For Each i In Me.ListBox1.SelectedItems
                'MsgBox(Me.ListBox1.SelectedItems.ToString)
                '  LService = dict(i)
                dict.TryGetValue(i, LService)
                ' MsgBox(LService)
                CON.Open()
                Dim cmdS As SqlCommand = New SqlCommand("
               SELECT * FROM DOCTOR 
               ", CON)


                Dim readS As SqlDataReader = cmdS.ExecuteReader
                If readS.HasRows Then


                    Do While readS.Read()
                        service = readS("service")
                        EMAIL = readS("email")
                        LID = readS("id")
                        If Lemail = EMAIL And LService = service Then
                            MsgBox("You have choosen this service already :)")
                            CON.Close()
                            Exit Sub
                        End If


                    Loop
                End If
                CON.Close()




                Dim query As String = "INSERT INTO doctor VALUES(@email, @service, '')"
                Using cmd As SqlCommand = New SqlCommand(query, CON)
                    cmd.Parameters.AddWithValue("@email", Lemail)
                    cmd.Parameters.AddWithValue("@Service", LService)
                    ' cmd.Parameters.AddWithValue("@EQUIPMENTS", LEquipment)
                    CON.Open()
                    Try
                        cmd.ExecuteNonQuery()
                    Catch ex As SqlException When ex.ErrorCode = -2146232060
                        MsgBox("Error!!")
                        CON.Close()
                        Exit Sub
                    End Try
                    CON.Close()


                    MessageBox.Show("successful inserted")

                End Using
            Next

            'equipments
            For Each i In Me.ListBox2.SelectedItems
                'MsgBox(Me.ListBox1.SelectedItems.ToString)
                dict2.TryGetValue(i, LEquipment)
                'MsgBox(LEquipment)
                CON.Open()
                Dim cmdE As SqlCommand = New SqlCommand("
               SELECT * FROM DOCTOR 
               ", CON)


                Dim readE As SqlDataReader = cmdE.ExecuteReader
                If readE.HasRows Then


                    '  If data_reader.HasRows Then
                    Do While readE.Read()
                        equipment = readE("equipment")
                        EMAIL = readE("email")
                        LID = readE("id")
                        If Lemail = EMAIL And LEquipment = equipment Then
                            MsgBox("You have choosen this equipment alreay :)")
                            CON.Close()
                            Exit Sub

                        End If


                    Loop
                End If
                CON.Close()

                Dim queryE As String = "INSERT INTO doctor VALUES(@email,'', @equipment)"
                ' Using CON As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
                Using cmdK As SqlCommand = New SqlCommand(queryE, CON)
                    cmdK.Parameters.AddWithValue("@email", Lemail)
                    cmdK.Parameters.AddWithValue("@equipment", LEquipment)
                    ' cmd.Parameters.AddWithValue("@EQUIPMENTS", LEquipment)
                    CON.Open()
                    Try
                        cmdK.ExecuteNonQuery()
                    Catch ex As SqlException When ex.ErrorCode = -2146232060
                        MsgBox("Error!!")
                        CON.Close()

                        Exit Sub
                    End Try
                    CON.Close()


                    MessageBox.Show("successful inserted")

                End Using
            Next
        End Using
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class