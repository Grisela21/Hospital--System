<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_Profile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.leftside = New System.Windows.Forms.Panel()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.logOut = New FontAwesome.Sharp.IconButton()
        Me.calendar = New FontAwesome.Sharp.IconButton()
        Me.imagePanel = New System.Windows.Forms.Panel()
        Me.imgHome = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.menuBtn = New FontAwesome.Sharp.IconButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.btnMaximize = New FontAwesome.Sharp.IconButton()
        Me.btnMinimize = New FontAwesome.Sharp.IconButton()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.leftside.SuspendLayout()
        Me.imagePanel.SuspendLayout()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.PanelTitleBar.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(220, 44)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(973, 656)
        Me.PanelDesktop.TabIndex = 16
        '
        'leftside
        '
        Me.leftside.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.leftside.Controls.Add(Me.IconButton2)
        Me.leftside.Controls.Add(Me.IconButton1)
        Me.leftside.Controls.Add(Me.logOut)
        Me.leftside.Controls.Add(Me.calendar)
        Me.leftside.Controls.Add(Me.imagePanel)
        Me.leftside.Controls.Add(Me.Panel4)
        Me.leftside.Dock = System.Windows.Forms.DockStyle.Left
        Me.leftside.Location = New System.Drawing.Point(0, 44)
        Me.leftside.Name = "leftside"
        Me.leftside.Size = New System.Drawing.Size(220, 656)
        Me.leftside.TabIndex = 13
        '
        'IconButton2
        '
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.FileContract
        Me.IconButton2.IconColor = System.Drawing.Color.White
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(0, 372)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton2.Size = New System.Drawing.Size(220, 54)
        Me.IconButton2.TabIndex = 11
        Me.IconButton2.Text = "Appointments Reports"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Qrcode
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(0, 288)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton1.Size = New System.Drawing.Size(220, 54)
        Me.IconButton1.TabIndex = 9
        Me.IconButton1.Text = "Scan"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'logOut
        '
        Me.logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logOut.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logOut.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.logOut.IconChar = FontAwesome.Sharp.IconChar.RightLong
        Me.logOut.IconColor = System.Drawing.Color.White
        Me.logOut.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.logOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logOut.Location = New System.Drawing.Point(0, 611)
        Me.logOut.Name = "logOut"
        Me.logOut.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.logOut.Size = New System.Drawing.Size(220, 42)
        Me.logOut.TabIndex = 8
        Me.logOut.Text = "Log out"
        Me.logOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.logOut.UseVisualStyleBackColor = True
        '
        'calendar
        '
        Me.calendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calendar.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calendar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.calendar.IconChar = FontAwesome.Sharp.IconChar.CalendarDays
        Me.calendar.IconColor = System.Drawing.Color.White
        Me.calendar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.calendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.calendar.Location = New System.Drawing.Point(-3, 210)
        Me.calendar.Name = "calendar"
        Me.calendar.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.calendar.Size = New System.Drawing.Size(220, 51)
        Me.calendar.TabIndex = 4
        Me.calendar.Text = "Calendar"
        Me.calendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.calendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.calendar.UseVisualStyleBackColor = True
        '
        'imagePanel
        '
        Me.imagePanel.Controls.Add(Me.imgHome)
        Me.imagePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.imagePanel.Location = New System.Drawing.Point(0, 44)
        Me.imagePanel.Name = "imagePanel"
        Me.imagePanel.Size = New System.Drawing.Size(220, 109)
        Me.imagePanel.TabIndex = 1
        '
        'imgHome
        '
        Me.imgHome.Image = Global.DK2.My.Resources.Resources.thank_you_doctors_nurses_other_medical_staff_hospital_employees_fight_spread_coronavirus_pandemic_flat_vector_191013390
        Me.imgHome.Location = New System.Drawing.Point(26, 0)
        Me.imgHome.Name = "imgHome"
        Me.imgHome.Size = New System.Drawing.Size(166, 106)
        Me.imgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgHome.TabIndex = 0
        Me.imgHome.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel4.Controls.Add(Me.menuBtn)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(220, 44)
        Me.Panel4.TabIndex = 0
        '
        'menuBtn
        '
        Me.menuBtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.menuBtn.FlatAppearance.BorderSize = 0
        Me.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menuBtn.Font = New System.Drawing.Font("Perpetua Titling MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.menuBtn.IconChar = FontAwesome.Sharp.IconChar.Bars
        Me.menuBtn.IconColor = System.Drawing.Color.White
        Me.menuBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.menuBtn.IconSize = 38
        Me.menuBtn.Location = New System.Drawing.Point(0, 0)
        Me.menuBtn.Name = "menuBtn"
        Me.menuBtn.Size = New System.Drawing.Size(75, 44)
        Me.menuBtn.TabIndex = 3
        Me.menuBtn.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 700)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1193, 41)
        Me.Panel3.TabIndex = 15
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelTitleBar.Controls.Add(Me.btnMaximize)
        Me.PanelTitleBar.Controls.Add(Me.btnMinimize)
        Me.PanelTitleBar.Controls.Add(Me.btnExit)
        Me.PanelTitleBar.Controls.Add(Me.lblFormTitle)
        Me.PanelTitleBar.Controls.Add(Me.IconCurrentForm)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(1193, 44)
        Me.PanelTitleBar.TabIndex = 14
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Maximize
        Me.btnMaximize.IconColor = System.Drawing.Color.MediumPurple
        Me.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMaximize.IconSize = 20
        Me.btnMaximize.Location = New System.Drawing.Point(1125, 12)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(25, 32)
        Me.btnMaximize.TabIndex = 4
        Me.btnMaximize.UseVisualStyleBackColor = True
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Subtract
        Me.btnMinimize.IconColor = System.Drawing.Color.MediumPurple
        Me.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMinimize.IconSize = 20
        Me.btnMinimize.Location = New System.Drawing.Point(1094, 12)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(25, 32)
        Me.btnMinimize.TabIndex = 3
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.IconChar = FontAwesome.Sharp.IconChar.X
        Me.btnExit.IconColor = System.Drawing.Color.MediumPurple
        Me.btnExit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExit.IconSize = 20
        Me.btnExit.Location = New System.Drawing.Point(1156, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(25, 32)
        Me.btnExit.TabIndex = 2
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFormTitle.Location = New System.Drawing.Point(61, 9)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(52, 20)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Home"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.MediumPurple
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.HouseMedical
        Me.IconCurrentForm.IconColor = System.Drawing.Color.MediumPurple
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.IconSize = 41
        Me.IconCurrentForm.Location = New System.Drawing.Point(3, 3)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(52, 41)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Employee_Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 741)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.leftside)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Name = "Employee_Profile"
        Me.Text = "Employee_Profile"
        Me.leftside.ResumeLayout(False)
        Me.imagePanel.ResumeLayout(False)
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents leftside As Panel
    Friend WithEvents calendar As FontAwesome.Sharp.IconButton
    Friend WithEvents imagePanel As Panel
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents menuBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents btnMaximize As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMinimize As FontAwesome.Sharp.IconButton
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents logOut As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
End Class
