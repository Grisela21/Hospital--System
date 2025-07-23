<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QR_Code
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
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.stringQr = New System.Windows.Forms.Label()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic
        '
        Me.pic.Location = New System.Drawing.Point(81, 28)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(467, 349)
        Me.pic.TabIndex = 0
        Me.pic.TabStop = False
        '
        'stringQr
        '
        Me.stringQr.AutoSize = True
        Me.stringQr.Location = New System.Drawing.Point(3, 9)
        Me.stringQr.Name = "stringQr"
        Me.stringQr.Size = New System.Drawing.Size(39, 13)
        Me.stringQr.TabIndex = 1
        Me.stringQr.Text = "Label1"
        Me.stringQr.Visible = False
        '
        'QR_Code
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(627, 461)
        Me.Controls.Add(Me.stringQr)
        Me.Controls.Add(Me.pic)
        Me.Name = "QR_Code"
        Me.Text = "QR_Code"
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic As PictureBox
    Friend WithEvents stringQr As Label
End Class
