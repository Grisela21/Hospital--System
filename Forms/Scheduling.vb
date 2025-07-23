Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Net.Mail
Imports System.Runtime.InteropServices.WindowsRuntime
Imports System.Runtime.Remoting
Imports System.Security.Cryptography
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Interop
Imports MS.Internal

Public Class Scheduling
    Public appID As Integer = 0
    Dim lEmail = Form1.lemail
    Dim listDoc As ArrayList = New ArrayList()
    Dim result As String
    Dim serviceDuration As Integer
    Dim startHour As String
    Dim endHour As String
    Dim hours As List(Of String)
    Dim totalFreeHours As List(Of String) = New List(Of String)
    Public totalInvalidHours As List(Of String) = New List(Of String)


    Dim freeHours As List(Of String)
    Dim startH As String = "06:00"
    Dim endH As String = "16:00"
    Dim qrCode As String
    Dim id_R As Integer
    Dim dateAppointment As String
    Dim fStartHour As String
    Dim fEndHour As String
    Dim LCbPriority As String
    Dim interval As List(Of String)


    Dim dict As New Dictionary(Of String, String)
    Private Sub Scheduling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDelete.Visible = appID <> 0
        btnCancel.Visible = appID <> 0
        btnSendResults.Visible = appID <> 0
        If status() Then
            statusApp.Text = "Canceled"
        Else
            statusApp.Text = "Opened"
        End If

        'getting from databse the unique id of the resevation 

        ' MsgBox(id_hide.Text)
        'funksion per gjenerimin e id 
        Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
        conn.Open()
        If id_hide.Text = 0 Then
            Dim cmdID As SqlCommand = New SqlCommand("SELECT MAX(ID) AS ID FROM RESERVETION", conn)

            Dim readID As SqlDataReader = cmdID.ExecuteReader

            If readID.HasRows Then

                Do While readID.Read()
                    If Not IsDBNull(readID("ID")) Then
                        id_R = readID("ID") + 1
                    Else
                        id_R = 0


                    End If

                Loop
            End If


        End If
        If id_hide.Text = 1 Then

            id_R = appID
            If startApplication() Then
                btnStart.Visible = True
            End If
        End If
        id.Text = id_R
        ' MsgBox(id.Text)


        conn.Close()





    End Sub

    'Function status shows if  applicaion is closed
    Public Function status() As Boolean
        Dim statusA As String
        Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
        conn.Open()

        Dim cmdSA As SqlCommand = New SqlCommand("SELECT * FROM RESERVETION WHERE id=@appID", conn)
        cmdSA.Parameters.AddWithValue("@appID", appID)
        Dim readSA As SqlDataReader = cmdSA.ExecuteReader

        If readSA.HasRows Then
            'get hours

            Do While readSA.Read()
                statusA = readSA("canceled")

            Loop
        End If
        If statusA = "T" Then
            Return True
        End If

        conn.Close()
        Return False
    End Function

    'function qe ben startimin e nje aplikimi
    Public Function startApplication() As Boolean
        Dim currentDateAsString As String = Date.Now.ToString("yyyy-MM-dd HH:mm")
        ' MsgBox(currentDateAsString)


        ' Get the DateTimePicker value
        Dim myDate As DateTime = DateTimePicker1.Value

        ' Convert it to a string with the desired format
        Dim myString As String = myDate.ToString("yyyy-MM-dd")
        '  MsgBox("myString" + myString)

        dateAppointment = myString + " " + ListBox2.Items(0).ToString()
        ' MsgBox(dateAppointment)
        If currentDateAsString = dateAppointment Then
            ' If "2023-02-26 06:10" = dateAppointment Then

            Return True
        End If
        Return False
    End Function

    'popullimi i serviseve
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
                ' dict.Add(lServices, lId)

                lDuration = readS("duration")

                ListBox1.Items.Add(lServices)
            Loop
        End If

        conn.Close()

    End Sub

    'populllimi i doktoreve
    Private Sub docpopulate_Click(sender As Object, e As EventArgs) Handles docpopulate.Click
        ' Check if at least one item is selected
        If ListBox1.SelectedItems.Count = 0 Then

            MsgBox("Please select a service.")
            Return
        End If
        Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
        conn.Open()



        Dim cmdD As SqlCommand = New SqlCommand("SELECT doctor.*   FROM doctor  INNER JOIN service   ON doctor.service  = service.Id  WHERE service.service=@service ", conn)
        '  MsgBox("service: " + ListBox1.SelectedItem.ToString)
        cmdD.Parameters.AddWithValue("@service", ListBox1.SelectedItem.ToString)




        Dim readD As SqlDataReader = cmdD.ExecuteReader

        If readD.HasRows Then
            'get the doctors

            Do While readD.Read()
                listDoc.Add(readD("email"))
                ListBox3.Items.Add(readD("email"))


            Loop
        End If

    End Sub

    'popullimi i oreve
    Private Sub populateHour_Click(sender As Object, e As EventArgs) Handles populateHour.Click
        ' Check if at least one item is selected
        If ListBox3.SelectedItems.Count = 0 Then

            MsgBox("Please select a Doctor.")
            Return
        End If
        Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
        conn.Open()



        'after choosing the doctor display only hours when he is free


        '1- get the invalid hours 
        Dim cmdH As SqlCommand = New SqlCommand("
               SELECT * FROM RESERVETION WHERE doctor=@doctor and date=@date
               ", conn)
        cmdH.Parameters.AddWithValue("@date", ConvertDateToString(DateTimePicker1.Value))
        cmdH.Parameters.AddWithValue("@doctor", ListBox3.SelectedItem.ToString)

        Dim readH As SqlDataReader = cmdH.ExecuteReader

        If readH.HasRows Then
            'get hours

            Do While readH.Read()
                startHour = readH("hour")
                endHour = readH("endHour")
                ' MsgBox(startHour)
                'MsgBox(endHour)


                hours = GenerateInvalidHours(startHour, endHour)

                '   freeHours = GenerateFreeHours(hours, startH, endH)

                totalInvalidHours.AddRange(hours)
                '  totalFreeHours.AddRange(freeHours)
                hours.Clear()
                ' freeHours.Clear()
            Loop
        Else
            If startHour Is Nothing Then
                startHour = "06:00"
            End If
            If endHour Is Nothing Then
                endHour = "16:00"
            End If

            totalFreeHours = GenerateTotalHours(startHour, endHour)
        End If
        conn.Close()
        For Each item As String In totalInvalidHours
            invalidHours.Items.Add(item)
        Next
        freeHours = GenerateFreeHours(totalInvalidHours, startH, endH)
        '2-get the free hours

        '3- fill list box with free hours
        'ListBox2.DataSource = totalFreeHours
        ListBox2.DataSource = freeHours

        ListBox2.DisplayMember = ""



    End Sub

    'functios of hour

    Public Function GenerateTotalHours(startHour As String, endHour As String) As List(Of String)
        Dim start As DateTime = DateTime.ParseExact(startHour, "HH:mm", CultureInfo.InvariantCulture)
        Dim [end] As DateTime = DateTime.ParseExact(endHour, "HH:mm", CultureInfo.InvariantCulture)
        Dim hours As New List(Of String)

        While start < [end]
            hours.Add(start.ToString("HH:mm"))
            start = start.AddMinutes(1)
        End While

        Return hours
    End Function

    Public Function GenerateInvalidHours(startHour As String, endHour As String) As List(Of String)
        Dim start As DateTime = DateTime.ParseExact(startHour, "HH:mm", CultureInfo.InvariantCulture)
        Dim [end] As DateTime = DateTime.ParseExact(endHour, "HH:mm", CultureInfo.InvariantCulture)
        Dim hours As New List(Of String)
        ' MsgBox(start)
        'MsgBox([end])
        While start < [end]
            hours.Add(start.ToString("HH:mm"))
            start = start.AddMinutes(1)
        End While

        Return hours
    End Function

    Public Function GenerateFreeHours(invalidHours As List(Of String), startHour As String, endHour As String) As List(Of String)
        Dim start As DateTime = DateTime.ParseExact(startHour, "HH:mm", CultureInfo.InvariantCulture)
        Dim [end] As DateTime = DateTime.ParseExact(endHour, "HH:mm", CultureInfo.InvariantCulture)
        Dim allHours As New List(Of String)
        Dim validHours As New List(Of String)
        'MsgBox(start)
        'MsgBox([end])
        While start < [end]
            allHours.Add(start.ToString("HH:mm"))
            start = start.AddMinutes(1)
        End While

        For Each hour As String In allHours
            If Not invalidHours.Contains(hour) Then
                validHours.Add(hour)
            End If
        Next

        Return validHours
    End Function

    'reserve action

    Private Sub Reserve_Click(sender As Object, e As EventArgs) Handles Reserve.Click




        If String.IsNullOrWhiteSpace(cusCont.Text) Then
            MsgBox("Customer Contact  is required.")
            Return
        End If


        If IsConfirm("Do you want to save ?") Then
            'MsgBox(lEmail)
            If appID = 0 Then


                ' Check if at least one item is selected
                If ListBox1.SelectedItems.Count = 0 Then

                    MsgBox("Please select a service.")
                    Return
                End If
                If ListBox2.SelectedItems.Count = 0 Then

                    MsgBox("Please select  one Hour.")
                    Return
                End If
                If ListBox3.SelectedItems.Count = 0 Then

                    MsgBox("Please select one Doctor.")
                    Return
                End If


                serviceDuration = servicesDuration(ListBox1.SelectedItem.ToString)
                result = AddMinutesToTime(ListBox2.SelectedItem.ToString, serviceDuration)
                ehour.Text = ""

                ' MsgBox(result)
                'llogjika qe end hour te mos jete brenda oreve invalide 

                ''kontrollojme intervalin e start hour te zgjedhur dhe end hour a permban ore invalide brenda
                interval = GenerateInvalidHours(ListBox2.SelectedItem.ToString, result)
                For Each hour As String In interval
                    If invalidHours.Items.Contains(result.ToString) Then
                        MsgBox("The interval of free hours is not enogh for this appoitment")
                        Return
                    End If
                Next

                If String.IsNullOrEmpty(cbPriority.Text) = True Then
                    LCbPriority = "Low"
                Else
                    LCbPriority = cbPriority.SelectedItem.ToString()
                End If

                Dim sql As String = $"insert into RESERVETION(date,hour, cus_cont, service, Comment,cus_email,doctor,endHour,priority) 
                                values('{ConvertDateToString(DateTimePicker1.Value)}','{ListBox2.SelectedItem.ToString}','{cusCont.Text}', '{ListBox1.SelectedItem.ToString}'
                                , '{comment.Text}','{lEmail}','{ListBox3.SelectedItem.ToString}', '{result}', '{LCbPriority}')"
                If InsertUpdateDelete(sql) Then
                    MsgBox("Inserted")

                    qrCode = id.Text & vbCrLf & ConvertDateToString(DateTimePicker1.Value) & vbCrLf & ListBox2.SelectedItem.ToString & vbCrLf & cusCont.Text & vbCrLf & comment.Text & vbCrLf & lEmail & vbCrLf & ListBox3.SelectedItem.ToString & vbCrLf & result

                    Dim sqlS As String = $"insert into QRSTRING(qr_string,id_reservetion) 
                                values('{qrCode}','{id.Text}')"
                    If InsertUpdateDelete(sqlS) Then
                        Me.Hide()
                        qrCode = id.Text & vbCrLf & ConvertDateToString(DateTimePicker1.Value) & vbCrLf & ListBox2.SelectedItem.ToString & vbCrLf & cusCont.Text & vbCrLf & comment.Text & vbCrLf & lEmail & vbCrLf & ListBox3.SelectedItem.ToString & vbCrLf & result
                        QR_Code.stringQr.Text = qrCode
                        QR_Code.Show()
                        sendEmailToClient(qrCode)
                    Else
                        MsgBox("Failed to input Qr code data into database")



                    End If
                Else
                    MsgBox("Failed")
                End If



            Else
                ' MsgBox(ListBox2.Items(0).ToString)
                serviceDuration = servicesDuration(ListBox1.Items(0).ToString)

                result = AddMinutesToTime(ListBox2.Items(0).ToString, serviceDuration)
                If ListBox1.Items.Contains(result) Then
                    MsgBox("The interval of free hours is not enogh for this appoitment")
                    Return
                End If
                If String.IsNullOrEmpty(cbPriority.Text) = True Then
                    LCbPriority = "Low"
                Else
                    LCbPriority = cbPriority.SelectedItem.ToString()
                End If
                'MsgBox(LCbPriority)
                Dim sql As String
                'llogjika qe kohezgjatja e takimit te mos jete m e evogel se e sherbimit 
                ' If compareServiceApp(ListBox2.Items(0).ToString, result) Then
                sql = $"update RESERVETION set Date = '{ConvertDateToString(DateTimePicker1.Value)}', 
                                     cus_cont = '{cusCont.Text}', hour = '{ListBox2.Items(0).ToString}', endhour = '{result}',
                                     service = '{ListBox1.Items(0).ToString}', priority = '{LCbPriority}', 
                                       Comment = '{comment.Text}',  doctor = '{ListBox3.Items(0).ToString}'
                             where ID = {appID}"

                If InsertUpdateDelete(sql) Then
                    MsgBox("Updated")
                    qrCode = id.Text & vbCrLf & ConvertDateToString(DateTimePicker1.Value) & vbCrLf & ListBox2.Items(0).ToString & vbCrLf & ListBox1.Items(0).ToString & vbCrLf & cusCont.Text & vbCrLf & comment.Text & vbCrLf & lEmail & vbCrLf & ListBox3.Items(0).ToString & vbCrLf & result

                    Dim sqlS As String = $"insert into QRSTRING(qr_string,id_reservetion) 
                                values('{qrCode}','{id.Text}')"
                    If InsertUpdateDelete(sqlS) Then

                        Me.Hide()
                        qrCode = id.Text & vbCrLf & ConvertDateToString(DateTimePicker1.Value) & vbCrLf & ListBox2.Items(0).ToString & vbCrLf & ListBox1.Items(0).ToString & vbCrLf & cusCont.Text & vbCrLf & comment.Text & vbCrLf & lEmail & vbCrLf & ListBox3.Items(0).ToString & vbCrLf & result
                        QR_Code.stringQr.Text = qrCode
                        QR_Code.Show()
                        sendEmailToClient(qrCode)
                    Else
                        MsgBox("Failed to input Qr code data into database")
                    End If
                Else
                    MsgBox("Update Failed")
                End If

            End If
        End If




    End Sub


    'te krsahasojme kohezghjatjen e takimit me te sherbimit 



    'funksionet e reseve 

    'takes the duration of service

    Public Function servicesDuration(serviceH As String) As Integer
        Dim endHourS As Integer
        Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
        conn.Open()

        Dim cmdEH As SqlCommand = New SqlCommand("
               SELECT * FROM Service WHERE service='" + serviceH + "'", conn)

        Dim readEH As SqlDataReader = cmdEH.ExecuteReader

        If readEH.HasRows Then
            'get hours

            Do While readEH.Read()
                endHourS = readEH("duration")

            Loop
        End If


        conn.Close()


        Return endHourS

    End Function

    'llogarit oren e perfundimit te sherbimit 

    Public Function AddMinutesToTime(time As String, minutes As Integer) As String
        Dim timeParts As String() = time.Split(":"c)
        Dim hours As Integer = Integer.Parse(timeParts(0))
        Dim mins As Integer = Integer.Parse(timeParts(1))

        mins = mins + minutes
        hours = hours + (mins \ 60)
        hours = hours Mod 24
        mins = mins Mod 60

        Return hours.ToString("00") + ":" + mins.ToString("00")
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If IsConfirm("Do you want to delete this appointment ?") Then
            '   MsgBox(appID)

            Dim sql As String = $"delete from RESERVETION where ID = {appID}"
            If InsertUpdateDelete(sql) Then
                MsgBox("Deleted")
                sendEmailToClient("Your Appointment has been canceled!")
                Me.Hide()
            Else
                MsgBox("Delete Failed")
            End If
        End If
        'pjesa e prioritetit
        '1- marim te gjitha rezervimet e asaj date dhe me vone 
        '2' qe nje rezervim te zevendesohet mw tjetrin duhet ne te njejten date ose me von te kete priotet te kete doktorin e njejte te kete intervalin e lire te kohezgjatjes se sherbimit
        '2-kontrollojme oren e te dhenave te gjetura , prioritetin, doctorin, dhe kohezgjatjen 
        '  MsgBox(ListBox2.Items(0).ToString)
        ' MsgBox(ehour.Text)

        searchNextApp(appID, ConvertDateToString(DateTimePicker1.Value), ListBox2.Items(0).ToString, ListBox3.Items(0).ToString)
    End Sub


    'sends email 

    Private Sub sendEmailToClient(stringQr As String)
        Try
            Dim smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage
            smtp_Server.UseDefaultCredentials = False
            smtp_Server.Credentials = New Net.NetworkCredential("hospitalhealinghands94@gmail.com", "ltdirnnocpyevhoo")
            smtp_Server.Port = 587
            smtp_Server.EnableSsl = True
            smtp_Server.Host = "smtp.gmail.com"
            e_mail = New MailMessage()
            e_mail.From = New MailAddress("hospitalhealinghands94@gmail.com")
            e_mail.To.Add(cusCont.Text)
            e_mail.Subject = id.Text
            e_mail.IsBodyHtml = False
            e_mail.Body = stringQr
            smtp_Server.Send(e_mail)
            MsgBox("Message sent!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Something Failed. Try again!", MsgBoxStyle.Critical)
        End Try
    End Sub


    'function of buton dele
    ''sends email for priority appointments
    Private Sub searchNextApp(id As Integer, Pdate As String, fStartHour As String, doc As String)
        Dim lpriority As String
        Dim lid As String
        Dim sStartHour As String
        Dim sEndHour As String


        Dim found As Boolean = False

        Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
        conn.Open()



        Dim cmdSC As SqlCommand = New SqlCommand("select * from reservetion where  (date = @Pdate or date >  @Pdate) and doctor= @doc", conn)
        cmdSC.Parameters.AddWithValue("@doc", doc)

        cmdSC.Parameters.AddWithValue("@Pdate", Pdate)


        Dim readS As SqlDataReader = cmdSC.ExecuteReader
        If readS.HasRows Then

            Do While readS.Read() 'cdo vlere e gjetur do kerkohet njehere nese eshte high
                sStartHour = readS("hour")
                sEndHour = readS("endhour")
                ' MsgBox("sStartHour: " + sStartHour)
                ' MsgBox("sStartHour: " + sStartHour)
                lpriority = readS("priority")
                ' MsgBox("lpriority:" + lpriority)

                If comperHours(fStartHour, sStartHour) Then
                    lid = readS("id")
                    If lpriority = "High" Then


                        found = True
                        Dim frm2 As New Scheduling()
                        MsgBox("send email for another high " + lid)
                        Dim sql As String = $"select * from RESERVETION where ID = {lid}"
                        Dim dt As DataTable = QueryAsDataTable(sql)
                        If dt.Rows.Count > 0 Then
                            Dim row As DataRow = dt.Rows(0)
                            With frm2
                                .id_hide.Text = 1
                                .appID = lid
                                .cusCont.Text = row("cus_Cont")
                                .comment.Text = row("comment")
                                .ListBox1.Items.Add(row("service"))
                                .DateTimePicker1.Value = row("date")
                                .ListBox2.Items.Add(row("hour"))
                                .ListBox3.Items.Add(row("doctor"))

                                .ShowDialog()

                            End With

                        End If
                    End If
                Else
                    MsgBox("There's no application to replace ")
                End If
            Loop





        End If

        conn.Close()


    End Sub

    'krahason oret kush eshte me heret me vone
    Private Function comperHours(fStartHour, sStartHour) As Boolean
        Dim dt1 As DateTime = DateTime.ParseExact(fStartHour, "HH:mm", CultureInfo.InvariantCulture)
        Dim dt2 As DateTime = DateTime.ParseExact(sStartHour, "HH:mm", CultureInfo.InvariantCulture)

        If dt1.Ticks < dt2.Ticks Then
            MsgBox("Time1 is earlier than Time2")
            Return True
        ElseIf dt1.Ticks > dt2.Ticks Then
            MsgBox("Time1 is later than Time2")
            Return False
        Else
            MsgBox("Time1 is the same as Time2")
            Return True
        End If
        Return False
    End Function


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles close.Click
        Me.Hide()
    End Sub


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim sql As String

        sql = $"update RESERVETION set fulfilled ='T'
                             where ID = {appID}"
        If InsertUpdateDelete(sql) Then
            MsgBox("Appointment Started!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim sql As String

        sql = $"update RESERVETION set canceled ='T'
                             where ID = {appID}"
        If InsertUpdateDelete(sql) Then
            MsgBox("This Appointment is Canceled !", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnSendResults_Click(sender As Object, e As EventArgs) Handles btnSendResults.Click
        Me.Hide()
        Send_Result.cusCont.Text = cusCont.Text
        Send_Result.id.Text = id.Text

        Send_Result.Show()
    End Sub
End Class