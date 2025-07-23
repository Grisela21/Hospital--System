<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cprofile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.logOut = New FontAwesome.Sharp.IconButton()
        Me.Equipments = New FontAwesome.Sharp.IconButton()
        Me.services = New FontAwesome.Sharp.IconButton()
        Me.imagePanel = New System.Windows.Forms.Panel()
        Me.imgHome = New System.Windows.Forms.PictureBox()
        Me.btnMaximize = New FontAwesome.Sharp.IconButton()
        Me.btnMinimize = New FontAwesome.Sharp.IconButton()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.menuBtn = New FontAwesome.Sharp.IconButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.leftside = New System.Windows.Forms.Panel()
        Me.doctoE = New FontAwesome.Sharp.IconButton()
        Me.calendar = New FontAwesome.Sharp.IconButton()
        Me.clemail = New System.Windows.Forms.Label()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.imagePanel.SuspendLayout()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelTitleBar.SuspendLayout()
        Me.leftside.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
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
        'logOut
        '
        Me.logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logOut.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logOut.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.logOut.IconChar = FontAwesome.Sharp.IconChar.RightLong
        Me.logOut.IconColor = System.Drawing.Color.White
        Me.logOut.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.logOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logOut.Location = New System.Drawing.Point(0, 523)
        Me.logOut.Name = "logOut"
        Me.logOut.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.logOut.Size = New System.Drawing.Size(220, 42)
        Me.logOut.TabIndex = 7
        Me.logOut.Text = "Log out"
        Me.logOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.logOut.UseVisualStyleBackColor = True
        '
        'Equipments
        '
        Me.Equipments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Equipments.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Equipments.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Equipments.IconChar = FontAwesome.Sharp.IconChar.Stethoscope
        Me.Equipments.IconColor = System.Drawing.Color.White
        Me.Equipments.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Equipments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Equipments.Location = New System.Drawing.Point(0, 380)
        Me.Equipments.Name = "Equipments"
        Me.Equipments.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Equipments.Size = New System.Drawing.Size(220, 42)
        Me.Equipments.TabIndex = 6
        Me.Equipments.Text = "Appoitments"
        Me.Equipments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Equipments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Equipments.UseVisualStyleBackColor = True
        '
        'services
        '
        Me.services.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.services.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.services.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.services.IconChar = FontAwesome.Sharp.IconChar.HospitalAlt
        Me.services.IconColor = System.Drawing.Color.White
        Me.services.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.services.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.services.Location = New System.Drawing.Point(0, 305)
        Me.services.Name = "services"
        Me.services.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.services.Size = New System.Drawing.Size(220, 58)
        Me.services.TabIndex = 5
        Me.services.Text = "Reserved Services"
        Me.services.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.services.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.services.UseVisualStyleBackColor = True
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
        Me.imgHome.Image = Global.DK2.My.Resources.Resources.burjeel_hospital_logo_vector
        Me.imgHome.Location = New System.Drawing.Point(16, 0)
        Me.imgHome.Name = "imgHome"
        Me.imgHome.Size = New System.Drawing.Size(194, 104)
        Me.imgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgHome.TabIndex = 0
        Me.imgHome.TabStop = False
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
        Me.btnMaximize.Location = New System.Drawing.Point(512, 12)
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
        Me.btnMinimize.Location = New System.Drawing.Point(481, 12)
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
        Me.btnExit.Location = New System.Drawing.Point(543, 12)
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
        Me.Panel3.Controls.Add(Me.clemail)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(220, 409)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(580, 41)
        Me.Panel3.TabIndex = 7
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(220, 44)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(580, 406)
        Me.PanelDesktop.TabIndex = 8
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
        Me.PanelTitleBar.Location = New System.Drawing.Point(220, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(580, 44)
        Me.PanelTitleBar.TabIndex = 6
        '
        'leftside
        '
        Me.leftside.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.leftside.Controls.Add(Me.calendar)
        Me.leftside.Controls.Add(Me.doctoE)
        Me.leftside.Controls.Add(Me.logOut)
        Me.leftside.Controls.Add(Me.Equipments)
        Me.leftside.Controls.Add(Me.services)
        Me.leftside.Controls.Add(Me.imagePanel)
        Me.leftside.Controls.Add(Me.Panel4)
        Me.leftside.Dock = System.Windows.Forms.DockStyle.Left
        Me.leftside.Location = New System.Drawing.Point(0, 0)
        Me.leftside.Name = "leftside"
        Me.leftside.Size = New System.Drawing.Size(220, 450)
        Me.leftside.TabIndex = 5
        '
        'doctoE
        '
        Me.doctoE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.doctoE.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doctoE.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.doctoE.IconChar = FontAwesome.Sharp.IconChar.Stethoscope
        Me.doctoE.IconColor = System.Drawing.Color.White
        Me.doctoE.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.doctoE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.doctoE.Location = New System.Drawing.Point(-25, 178)
        Me.doctoE.Name = "doctoE"
        Me.doctoE.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.doctoE.Size = New System.Drawing.Size(275, 55)
        Me.doctoE.TabIndex = 8
        Me.doctoE.Text = "Services/Equipment"
        Me.doctoE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.doctoE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.doctoE.UseVisualStyleBackColor = True
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
        Me.calendar.Location = New System.Drawing.Point(0, 239)
        Me.calendar.Name = "calendar"
        Me.calendar.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.calendar.Size = New System.Drawing.Size(220, 51)
        Me.calendar.TabIndex = 9
        Me.calendar.Text = "Calendar"
        Me.calendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.calendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.calendar.UseVisualStyleBackColor = True
        '
        'clemail
        '
        Me.clemail.AutoSize = True
        Me.clemail.Location = New System.Drawing.Point(28, 0)
        Me.clemail.Name = "clemail"
        Me.clemail.Size = New System.Drawing.Size(39, 13)
        Me.clemail.TabIndex = 3
        Me.clemail.Text = "clemail"
        Me.clemail.Visible = False
        '
        'Cprofile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.leftside)
        Me.Name = "Cprofile"
        Me.Text = "Cprofile"
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.imagePanel.ResumeLayout(False)
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        Me.leftside.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents logOut As FontAwesome.Sharp.IconButton
    Friend WithEvents Equipments As FontAwesome.Sharp.IconButton
    Friend WithEvents services As FontAwesome.Sharp.IconButton
    Friend WithEvents imagePanel As Panel
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents btnMaximize As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMinimize As FontAwesome.Sharp.IconButton
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents menuBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents leftside As Panel
    Friend WithEvents doctoE As FontAwesome.Sharp.IconButton
    Friend WithEvents calendar As FontAwesome.Sharp.IconButton
    Friend WithEvents clemail As Label
End Class
