Imports System.Runtime.InteropServices
Imports System.Xml
Imports FontAwesome.Sharp
Public Class Cprofile



    Dim sideBar As String = "Close"

        Sub clear()
        ' addP.Text = ""
        'editP.Text = ""

    End Sub

        Sub setname()
        ' addP.Text = "Add Personel"
        ' editP.Text = "Edit Personal"

    End Sub
        Private Sub mAdd_Click(sender As Object, e As EventArgs)
            Me.Hide()
            menagerAdd.Show()
        End Sub



        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
            If sideBar = "Open" Then
                leftside.Width += 25
                If leftside.Width >= 250 Then
                    setname()
                    sideBar = "Close"
                    Timer1.Stop()
                End If
            Else
                leftside.Width -= 25
                If leftside.Width <= 50 Then
                    clear()
                    sideBar = "Open"
                    Timer1.Stop()
                End If
            End If
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

    Private Sub addP_Click(sender As Object, e As EventArgs)
        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New menagerAdd)
    End Sub

    Private Sub editP_Click(sender As Object, e As EventArgs)
        ActivateButton(sender, RGBColors.color2)
        OpenChildForm(New Edit_Personel)
    End Sub

    Private Sub services_Click(sender As Object, e As EventArgs) Handles services.Click
        ActivateButton(sender, RGBColors.color3)
        OpenChildForm(New Reserved_Services)
    End Sub

    Private Sub Equipments_Click(sender As Object, e As EventArgs) Handles Equipments.Click
        ActivateButton(sender, RGBColors.color4)
        OpenChildForm(New Display_Appoitments)
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

    Private Sub logOut_Click(sender As Object, e As EventArgs) Handles logOut.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub doctoE_Click(sender As Object, e As EventArgs) Handles doctoE.Click
        ActivateButton(sender, RGBColors.color6)
        OpenChildForm(New Dispaly_Services)
    End Sub

    Private Sub calendar_Click(sender As Object, e As EventArgs) Handles calendar.Click
        ' MsgBox(clemail.Text)
        ClientsDisplayAppintment.clemailD.Text = clemail.Text
        ' MsgBox(ClientsDisplayAppintment.clemailD.Text)
        ActivateButton(sender, RGBColors.color5)
        OpenChildForm(New ClientsDisplayAppintment)
    End Sub
End Class