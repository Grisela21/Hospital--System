Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Xml
Imports FontAwesome.Sharp

Public Class Doctor_Profile

    Private specificTimes As New List(Of DateTime) ' Declare a List of DateTime objects to hold the specific times

    Dim sideBar As String = "Close"

    '   Sub clear()
    '      mAdd.Text = ""
    '     editPersonel.Text = ""

    '    End Sub

    '    Sub setname()
    '           mAdd.Text = "Add Personel"
    '          editPersonel.Text = "Edit Personal"

    '  End Sub
    Private Sub mAdd_Click(sender As Object, e As EventArgs)
        Me.Hide()
        menagerAdd.Show()
    End Sub



    Private Sub menuBtn_Click(sender As Object, e As EventArgs) Handles menuBtn.Click
        Timer1.Start()

    End Sub


    'menu


    'Fields'
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form
    'Constructor'
    Public Sub New()
        ' This call is required by the designer.'
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.'
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        leftside.Controls.Add(leftBorderBtn)
        'Form'
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub
    'Methods'
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border'
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'current Form icon'
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor
        End If
    End Sub
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub


    Private Sub OpenChildForm(childForm As Form)
        'Open only form'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblFormTitle.Text = childForm.Text
    End Sub


    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        IconCurrentForm.IconChar = IconChar.HouseMedical
        IconCurrentForm.IconColor = Color.MediumPurple
        lblFormTitle.Text = "Home"
    End Sub

    'Events'
    'Reset'

    'Menu buttons Cliks'

    Private Sub imgHome_Click(sender As Object, e As EventArgs) Handles imgHome.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub

    Private Sub doctoE_Click(sender As Object, e As EventArgs) Handles doctoE.Click
        ActivateButton(sender, RGBColors.color5)
        OpenChildForm(New Doctor_ES)
    End Sub



    'Drag Form'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub menager_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    'Close-Maximize-Minimize'
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub editPersonel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PanelTitleBar_Paint(sender As Object, e As PaintEventArgs) Handles PanelTitleBar.Paint
    End Sub

    Private Sub lblFormTitle_Click(sender As Object, e As EventArgs) Handles lblFormTitle.Click
    End Sub

    Private Sub IconCurrentForm_Click(sender As Object, e As EventArgs) Handles IconCurrentForm.Click

        End Sub

        Private Sub leftside_Paint(sender As Object, e As PaintEventArgs) Handles leftside.Paint

        End Sub

        Private Sub PanelDesktop_Paint(sender As Object, e As PaintEventArgs) Handles PanelDesktop.Paint

        End Sub

        Private Sub imagePanel_Paint(sender As Object, e As PaintEventArgs) Handles imagePanel.Paint

        End Sub

        Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

        End Sub



    Private Sub logOut_Click(sender As Object, e As EventArgs) Handles logOut.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Doctor_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  MsgBox(" Form1.lemail" + docEmail.Text)
        Using connection As New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
            connection.Open()
            Dim command As New SqlCommand("SELECT hour FROM RESERVETION where doctor=@doc and date= @date", connection)
            command.Parameters.AddWithValue("@doc", docEmail.Text)
            command.Parameters.AddWithValue("@date", DateTime.Today.ToString("yyyy-MM-dd"))

            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                Dim specificTimeStr As String = reader("hour").ToString()
                ' MsgBox("specificTimeStr" + specificTimeStr)
                Dim specificTimeHour As Integer = Integer.Parse(specificTimeStr.Substring(0, 2))
                ' MsgBox("specificTimeHour" + specificTimeHour)

                Dim specificTimeMinute As Integer = Integer.Parse(specificTimeStr.Substring(3, 2))
                ' MsgBox("specificTimeMinute" + specificTimeMinute)

                Dim specificTime As DateTime = DateTime.Today.AddHours(specificTimeHour).AddMinutes(specificTimeMinute)
                '  specificTime = specificTime.SubtractMinutes(15) ' Subtract 15 minutes from the specific time
                specificTimes.Add(specificTime)
            End While
        End Using

        ' Set up the Timer control
        Timer2.Interval = 1000 ' Set the Timer control's Interval property to 1000 milliseconds (1 second)
        Timer2.Start() ' Start the Timer control
    End Sub

    Private Sub calendar_Click(sender As Object, e As EventArgs) Handles calendar.Click
        ActivateButton(sender, RGBColors.color4)
        OpenChildForm(New APPDoctor)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim currentTime As DateTime = DateTime.Now
        For Each specificTime In specificTimes ' Loop through the List of specific times
            If currentTime.Hour = specificTime.Hour And currentTime.Minute = specificTime.Minute And currentTime.Second = specificTime.Second Then
                MessageBox.Show("Reminder!Your Appoitment has started!")
                Exit Sub ' Exit the Tick event handler after the first alert is displayed
            End If
        Next
    End Sub
End Class