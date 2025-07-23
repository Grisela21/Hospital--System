<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class strQR
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.strFromQR = New System.Windows.Forms.TextBox()
        Me.read = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(126, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data from QR Code"
        '
        'strFromQR
        '
        Me.strFromQR.Location = New System.Drawing.Point(121, 154)
        Me.strFromQR.Multiline = True
        Me.strFromQR.Name = "strFromQR"
        Me.strFromQR.Size = New System.Drawing.Size(550, 95)
        Me.strFromQR.TabIndex = 1
        '
        'read
        '
        Me.read.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.read.Location = New System.Drawing.Point(131, 304)
        Me.read.Name = "read"
        Me.read.Size = New System.Drawing.Size(186, 52)
        Me.read.TabIndex = 2
        Me.read.Text = "Read"
        Me.read.UseVisualStyleBackColor = True
        '
        'strQR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.read)
        Me.Controls.Add(Me.strFromQR)
        Me.Controls.Add(Me.Label1)
        Me.Name = "strQR"
        Me.Text = "strQR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents strFromQR As TextBox
    Friend WithEvents read As Button
End Class
