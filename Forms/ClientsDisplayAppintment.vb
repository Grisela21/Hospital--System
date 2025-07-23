Public Class ClientsDisplayAppintment

    Private listFlDay As New List(Of FlowLayoutPanel)
    Private currentDate As DateTime = DateTime.Today
    Dim qrCode As String

    Private Sub frmDisplayAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateDayPanel(42)
        DisplayCurrentDate()
    End Sub

    Private Sub AddNewAppointment(ByVal sender As Object, e As EventArgs)
        Dim day As Integer = CType(sender, FlowLayoutPanel).Tag
        If day <> 0 Then
            With Scheduling
                .id_hide.Text = 0
                .appID = 0
                .cusCont.Text = ""
                .comment.Text = ""
                .DateTimePicker1.Value = New Date(currentDate.Year, currentDate.Month, day)
                .ListBox1.Items.Clear()
                .ListBox2.Items.Clear()
                .ListBox3.Items.Clear()
                .cbPriority.Text = ""



                .ShowDialog()
            End With
            DisplayCurrentDate()
        End If
    End Sub

    Private Sub ShowAppointmentDetail(sender As Object, e As EventArgs)
        Dim appID As Integer = CType(sender, LinkLabel).Tag
        'MsgBox(appID)
        Scheduling.ListBox1.DataSource = Nothing
        Scheduling.ListBox2.DataSource = Nothing
        Scheduling.ListBox3.DataSource = Nothing
        If Scheduling.ListBox1.InvokeRequired Then
            ' Call the method again on the thread that created the control
            Scheduling.ListBox1.Invoke(Sub() Scheduling.ListBox1.Items.Clear())
        Else
            ' Modify the ListBox directly
            Scheduling.ListBox1.Items.Clear()
        End If

        If Scheduling.ListBox2.InvokeRequired Then
            ' Call the method again on the thread that created the control
            Scheduling.ListBox2.Invoke(Sub() Scheduling.ListBox2.Items.Clear())
        Else
            ' Modify the ListBox directly
            Scheduling.ListBox2.Items.Clear()
        End If

        If Scheduling.ListBox3.InvokeRequired Then
            ' Call the method again on the thread that created the control
            Scheduling.ListBox3.Invoke(Sub() Scheduling.ListBox3.Items.Clear())
        Else
            ' Modify the ListBox directly
            Scheduling.ListBox3.Items.Clear()
        End If
        Dim sql As String = $"select * from RESERVETION where ID = {appID}"
        Dim dt As DataTable = QueryAsDataTable(sql)
        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            With Scheduling
                .id_hide.Text = 1
                .appID = appID
                .cusCont.Text = row("cus_Cont")
                .comment.Text = row("comment")
                .ListBox1.Items.Add(row("service"))
                .DateTimePicker1.Value = row("date")
                .ListBox2.Items.Add(row("hour"))
                .ListBox3.Items.Add(row("doctor"))
                .ehour.Text = row("endHour")
                .cbPriority.Text = row("priority")
                .ShowDialog()

            End With
            DisplayCurrentDate()
        End If
    End Sub

    Private Sub AddAppointmentToFlDay(ByVal startDayAtFlNumber As Integer)
        Dim startDate As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Dim endDate As DateTime = startDate.AddMonths(1).AddDays(-1)
        Dim sd As String = ConvertDateToString(startDate)
        Dim ed As String = ConvertDateToString(endDate)
        ' MsgBox(Cprofile.clemail.Text)
        Dim sql As String = $"select * from RESERVETION   where Date between '" + sd + "' and '" + ed + "' and cus_email='" + Cprofile.clemail.Text + "'"
        Dim dt As DataTable = QueryAsDataTable(sql)

        For Each row As DataRow In dt.Rows
            Dim appDay As DateTime = DateTime.Parse(row("date"))
            Dim link As New LinkLabel
            link.Tag = row("ID")
            link.Name = $"link{row("ID")}"
            link.Text = row("cus_cont")
            AddHandler link.Click, AddressOf ShowAppointmentDetail
            listFlDay((appDay.Day - 1) + (startDayAtFlNumber - 1)).Controls.Add(link)
        Next
    End Sub

    Private Function GetFirstDayOfWeekOfCurrentDate() As Integer
        Dim firstDayOfMonth As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Return firstDayOfMonth.DayOfWeek + 1
    End Function

    Private Function GetTotalDaysOfCurrentDate() As Integer
        Dim firstDayOfCurrentDate As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Return firstDayOfCurrentDate.AddMonths(1).AddDays(-1).Day
    End Function

    Private Sub DisplayCurrentDate()
        lblMonthAndYear.Text = currentDate.ToString("MMMM, yyyy")
        Dim firstDayAtFlNumber As Integer = GetFirstDayOfWeekOfCurrentDate()
        Dim totalDay As Integer = GetTotalDaysOfCurrentDate()
        AddLabelDayToFlDay(firstDayAtFlNumber, totalDay)
        AddAppointmentToFlDay(firstDayAtFlNumber)
    End Sub

    Private Sub PrevMonth()
        currentDate = currentDate.AddMonths(-1)
        DisplayCurrentDate()
    End Sub

    Private Sub NextMonth()
        currentDate = currentDate.AddMonths(1)
        DisplayCurrentDate()
    End Sub

    Private Sub Today()
        currentDate = DateTime.Today
        DisplayCurrentDate()
    End Sub

    Private Sub GenerateDayPanel(ByVal totalDays As Integer)
        flDays.Controls.Clear()
        listFlDay.Clear()
        For i As Integer = 1 To totalDays
            Dim fl As New FlowLayoutPanel
            fl.Name = $"flDay{i}"
            fl.Size = New Size(128, 99)
            fl.BackColor = Color.White
            fl.BorderStyle = BorderStyle.FixedSingle
            fl.Cursor = Cursors.Hand
            fl.AutoScroll = True
            AddHandler fl.Click, AddressOf AddNewAppointment
            flDays.Controls.Add(fl)
            listFlDay.Add(fl)
        Next
    End Sub

    Private Sub AddLabelDayToFlDay(ByVal startDayAtFlNumber As Integer, ByVal totalDaysInMonth As Integer)
        For Each fl As FlowLayoutPanel In listFlDay
            fl.Controls.Clear()
            fl.Tag = 0
            fl.BackColor = Color.White
        Next

        For i As Integer = 1 To totalDaysInMonth
            Dim lbl As New Label
            lbl.Name = $"lblDay{i}"
            lbl.AutoSize = False
            lbl.TextAlign = ContentAlignment.MiddleRight
            lbl.Size = New Size(110, 22)
            lbl.Text = i
            lbl.Font = New Font("Microsoft Sans Serif", 12)
            listFlDay((i - 1) + (startDayAtFlNumber - 1)).Tag = i
            listFlDay((i - 1) + (startDayAtFlNumber - 1)).Controls.Add(lbl)

            If New Date(currentDate.Year, currentDate.Month, i) = Date.Today Then
                listFlDay((i - 1) + (startDayAtFlNumber - 1)).BackColor = Color.Aqua
            End If

        Next
    End Sub

    Private Sub btnPrevMonth_Click(sender As Object, e As EventArgs) Handles btnPrevMonth.Click
        PrevMonth()
    End Sub

    Private Sub btnNextMonth_Click(sender As Object, e As EventArgs) Handles btnNextMonth.Click
        NextMonth()
    End Sub

    Private Sub btnToday_Click(sender As Object, e As EventArgs) Handles btnToday.Click
        Today()
    End Sub

    Private Sub flDays_Paint(sender As Object, e As PaintEventArgs) Handles flDays.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub lblMonthAndYear_Click(sender As Object, e As EventArgs) Handles lblMonthAndYear.Click

    End Sub
End Class