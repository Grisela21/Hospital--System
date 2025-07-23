<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Change_Password
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.oldP = New System.Windows.Forms.TextBox()
        Me.newP = New System.Windows.Forms.TextBox()
        Me.cNewP = New System.Windows.Forms.TextBox()
        Me.changeP = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Old Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "New Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Confirm New Password"
        '
        'oldP
        '
        Me.oldP.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oldP.Location = New System.Drawing.Point(200, 98)
        Me.oldP.Name = "oldP"
        Me.oldP.Size = New System.Drawing.Size(163, 38)
        Me.oldP.TabIndex = 3
        '
        'newP
        '
        Me.newP.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newP.Location = New System.Drawing.Point(200, 176)
        Me.newP.Name = "newP"
        Me.newP.Size = New System.Drawing.Size(163, 38)
        Me.newP.TabIndex = 4
        '
        'cNewP
        '
        Me.cNewP.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cNewP.Location = New System.Drawing.Point(200, 251)
        Me.cNewP.Name = "cNewP"
        Me.cNewP.Size = New System.Drawing.Size(163, 38)
        Me.cNewP.TabIndex = 5
        '
        'changeP
        '
        Me.changeP.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.changeP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.changeP.Location = New System.Drawing.Point(200, 336)
        Me.changeP.Name = "changeP"
        Me.changeP.Size = New System.Drawing.Size(156, 44)
        Me.changeP.TabIndex = 6
        Me.changeP.Text = "Confirm"
        Me.changeP.UseVisualStyleBackColor = True
        '
        'Change_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(483, 450)
        Me.Controls.Add(Me.changeP)
        Me.Controls.Add(Me.cNewP)
        Me.Controls.Add(Me.newP)
        Me.Controls.Add(Me.oldP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Name = "Change_Password"
        Me.Text = "Change_Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents oldP As TextBox
    Friend WithEvents newP As TextBox
    Friend WithEvents cNewP As TextBox
    Friend WithEvents changeP As Button
End Class
