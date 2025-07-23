<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Send_Result
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
        Me.btnSendEmail = New System.Windows.Forms.Button()
        Me.attach = New System.Windows.Forms.Button()
        Me.cusCont = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.Label()
        Me.fileName = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.body = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSendEmail
        '
        Me.btnSendEmail.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendEmail.Location = New System.Drawing.Point(140, 351)
        Me.btnSendEmail.Name = "btnSendEmail"
        Me.btnSendEmail.Size = New System.Drawing.Size(128, 41)
        Me.btnSendEmail.TabIndex = 0
        Me.btnSendEmail.Text = "Send Email"
        Me.btnSendEmail.UseVisualStyleBackColor = True
        '
        'attach
        '
        Me.attach.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attach.Location = New System.Drawing.Point(140, 51)
        Me.attach.Name = "attach"
        Me.attach.Size = New System.Drawing.Size(141, 39)
        Me.attach.TabIndex = 1
        Me.attach.Text = "Attachment"
        Me.attach.UseVisualStyleBackColor = True
        '
        'cusCont
        '
        Me.cusCont.AutoSize = True
        Me.cusCont.Location = New System.Drawing.Point(635, 65)
        Me.cusCont.Name = "cusCont"
        Me.cusCont.Size = New System.Drawing.Size(46, 13)
        Me.cusCont.TabIndex = 2
        Me.cusCont.Text = "cusCont"
        Me.cusCont.Visible = False
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(649, 117)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(15, 13)
        Me.id.TabIndex = 3
        Me.id.Text = "id"
        Me.id.Visible = False
        '
        'fileName
        '
        Me.fileName.AutoSize = True
        Me.fileName.Location = New System.Drawing.Point(656, 156)
        Me.fileName.Name = "fileName"
        Me.fileName.Size = New System.Drawing.Size(48, 13)
        Me.fileName.TabIndex = 4
        Me.fileName.Text = "fileName"
        Me.fileName.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(32, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Comment"
        '
        'body
        '
        Me.body.Location = New System.Drawing.Point(140, 96)
        Me.body.Multiline = True
        Me.body.Name = "body"
        Me.body.Size = New System.Drawing.Size(564, 240)
        Me.body.TabIndex = 6
        '
        'Send_Result
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.body)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fileName)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.cusCont)
        Me.Controls.Add(Me.attach)
        Me.Controls.Add(Me.btnSendEmail)
        Me.Name = "Send_Result"
        Me.Text = "Send_Result"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSendEmail As Button
    Friend WithEvents attach As Button
    Friend WithEvents cusCont As Label
    Friend WithEvents id As Label
    Friend WithEvents fileName As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents body As TextBox
End Class
