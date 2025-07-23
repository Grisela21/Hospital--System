<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Personel
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.role = New System.Windows.Forms.ComboBox()
        Me.gender = New System.Windows.Forms.ComboBox()
        Me.update = New System.Windows.Forms.Button()
        Me.Country = New System.Windows.Forms.TextBox()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lastname = New System.Windows.Forms.TextBox()
        Me.cname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.searchLabel = New System.Windows.Forms.TextBox()
        Me.delete = New System.Windows.Forms.Button()
        Me.search = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.passwCh = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(56, 460)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 25)
        Me.Label8.TabIndex = 125
        Me.Label8.Text = "Role"
        '
        'role
        '
        Me.role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.role.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.role.FormattingEnabled = True
        Me.role.Items.AddRange(New Object() {"doctor", "employer"})
        Me.role.Location = New System.Drawing.Point(152, 460)
        Me.role.Name = "role"
        Me.role.Size = New System.Drawing.Size(136, 33)
        Me.role.TabIndex = 124
        '
        'gender
        '
        Me.gender.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gender.FormattingEnabled = True
        Me.gender.Items.AddRange(New Object() {"Female", "Male", "Other"})
        Me.gender.Location = New System.Drawing.Point(152, 341)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(136, 33)
        Me.gender.TabIndex = 123
        '
        'update
        '
        Me.update.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.update.Location = New System.Drawing.Point(152, 524)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(171, 45)
        Me.update.TabIndex = 120
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = True
        '
        'Country
        '
        Me.Country.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Country.Location = New System.Drawing.Point(491, 403)
        Me.Country.Name = "Country"
        Me.Country.Size = New System.Drawing.Size(201, 38)
        Me.Country.TabIndex = 117
        '
        'phone
        '
        Me.phone.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phone.Location = New System.Drawing.Point(152, 406)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(136, 38)
        Me.phone.TabIndex = 116
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(357, 406)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 25)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "Country"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(56, 409)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 25)
        Me.Label5.TabIndex = 114
        Me.Label5.Text = "Phone"
        '
        'email
        '
        Me.email.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.Location = New System.Drawing.Point(491, 341)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(201, 38)
        Me.email.TabIndex = 113
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(362, 344)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 25)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 344)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 25)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Gender"
        '
        'lastname
        '
        Me.lastname.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastname.Location = New System.Drawing.Point(491, 280)
        Me.lastname.Name = "lastname"
        Me.lastname.Size = New System.Drawing.Size(201, 38)
        Me.lastname.TabIndex = 110
        '
        'cname
        '
        Me.cname.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cname.Location = New System.Drawing.Point(152, 280)
        Me.cname.Name = "cname"
        Me.cname.Size = New System.Drawing.Size(136, 38)
        Me.cname.TabIndex = 109
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(347, 287)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 25)
        Me.Label7.TabIndex = 108
        Me.Label7.Text = "Lastname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 25)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Name"
        '
        'searchLabel
        '
        Me.searchLabel.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchLabel.Location = New System.Drawing.Point(125, 14)
        Me.searchLabel.Multiline = True
        Me.searchLabel.Name = "searchLabel"
        Me.searchLabel.Size = New System.Drawing.Size(213, 37)
        Me.searchLabel.TabIndex = 129
        '
        'delete
        '
        Me.delete.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.delete.Location = New System.Drawing.Point(501, 514)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(191, 42)
        Me.delete.TabIndex = 128
        Me.delete.Text = "delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'search
        '
        Me.search.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.search.Location = New System.Drawing.Point(365, 12)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(122, 34)
        Me.search.TabIndex = 127
        Me.search.Text = "search"
        Me.search.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(61, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(631, 188)
        Me.DataGridView1.TabIndex = 126
        '
        'passwCh
        '
        Me.passwCh.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwCh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.passwCh.Location = New System.Drawing.Point(333, 589)
        Me.passwCh.Name = "passwCh"
        Me.passwCh.Size = New System.Drawing.Size(154, 40)
        Me.passwCh.TabIndex = 130
        Me.passwCh.Text = "Change Password"
        Me.passwCh.UseVisualStyleBackColor = True
        '
        'Edit_Personel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(835, 661)
        Me.Controls.Add(Me.passwCh)
        Me.Controls.Add(Me.searchLabel)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.role)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.Country)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lastname)
        Me.Controls.Add(Me.cname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Name = "Edit_Personel"
        Me.Text = "Edit_Personel"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents role As ComboBox
    Friend WithEvents gender As ComboBox
    Friend WithEvents update As Button
    Friend WithEvents Country As TextBox
    Friend WithEvents phone As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lastname As TextBox
    Friend WithEvents cname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents searchLabel As TextBox
    Friend WithEvents delete As Button
    Friend WithEvents search As Button
    Friend WithEvents passwCh As Button
    Private WithEvents DataGridView1 As DataGridView
End Class
