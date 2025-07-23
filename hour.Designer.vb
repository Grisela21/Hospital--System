<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class hour
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
        Me.cmbHour = New System.Windows.Forms.ComboBox()
        Me.save = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbHour
        '
        Me.cmbHour.FormattingEnabled = True
        Me.cmbHour.Location = New System.Drawing.Point(109, 129)
        Me.cmbHour.Name = "cmbHour"
        Me.cmbHour.Size = New System.Drawing.Size(121, 21)
        Me.cmbHour.TabIndex = 0
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(154, 217)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(75, 23)
        Me.save.TabIndex = 1
        Me.save.Text = "save"
        Me.save.UseVisualStyleBackColor = True
        '
        'hour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.cmbHour)
        Me.Name = "hour"
        Me.Text = "hour"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbHour As ComboBox
    Friend WithEvents save As Button
End Class
