<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Equipments
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
        Me.equipment = New System.Windows.Forms.TextBox()
        Me.addS = New System.Windows.Forms.Button()
        Me.searchLabel = New System.Windows.Forms.TextBox()
        Me.deleteS = New System.Windows.Forms.Button()
        Me.searchS = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.updateS = New System.Windows.Forms.Button()
        Me.duration = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.lab = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'equipment
        '
        Me.equipment.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.equipment.Location = New System.Drawing.Point(302, 372)
        Me.equipment.Name = "equipment"
        Me.equipment.Size = New System.Drawing.Size(195, 38)
        Me.equipment.TabIndex = 167
        '
        'addS
        '
        Me.addS.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.addS.Location = New System.Drawing.Point(147, 561)
        Me.addS.Name = "addS"
        Me.addS.Size = New System.Drawing.Size(130, 57)
        Me.addS.TabIndex = 163
        Me.addS.Text = "Add"
        Me.addS.UseVisualStyleBackColor = True
        '
        'searchLabel
        '
        Me.searchLabel.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchLabel.Location = New System.Drawing.Point(134, 74)
        Me.searchLabel.Multiline = True
        Me.searchLabel.Name = "searchLabel"
        Me.searchLabel.Size = New System.Drawing.Size(277, 37)
        Me.searchLabel.TabIndex = 162
        '
        'deleteS
        '
        Me.deleteS.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.deleteS.Location = New System.Drawing.Point(576, 561)
        Me.deleteS.Name = "deleteS"
        Me.deleteS.Size = New System.Drawing.Size(156, 59)
        Me.deleteS.TabIndex = 161
        Me.deleteS.Text = "delete"
        Me.deleteS.UseVisualStyleBackColor = True
        '
        'searchS
        '
        Me.searchS.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.searchS.Location = New System.Drawing.Point(438, 72)
        Me.searchS.Name = "searchS"
        Me.searchS.Size = New System.Drawing.Size(122, 34)
        Me.searchS.TabIndex = 160
        Me.searchS.Text = "search"
        Me.searchS.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlText
        Me.DataGridView1.Location = New System.Drawing.Point(134, 129)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(631, 188)
        Me.DataGridView1.TabIndex = 159
        '
        'updateS
        '
        Me.updateS.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.updateS.Location = New System.Drawing.Point(356, 561)
        Me.updateS.Name = "updateS"
        Me.updateS.Size = New System.Drawing.Size(141, 57)
        Me.updateS.TabIndex = 158
        Me.updateS.Text = "Update"
        Me.updateS.UseVisualStyleBackColor = True
        '
        'duration
        '
        Me.duration.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.duration.Location = New System.Drawing.Point(302, 466)
        Me.duration.Name = "duration"
        Me.duration.Size = New System.Drawing.Size(195, 38)
        Me.duration.TabIndex = 157
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(133, 469)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(163, 25)
        Me.label.TabIndex = 156
        Me.label.Text = "Duration (mm)"
        '
        'lab
        '
        Me.lab.AutoSize = True
        Me.lab.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab.Location = New System.Drawing.Point(133, 372)
        Me.lab.Name = "lab"
        Me.lab.Size = New System.Drawing.Size(115, 25)
        Me.lab.TabIndex = 155
        Me.lab.Text = "Eqiupment"
        '
        'Equipments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(891, 692)
        Me.Controls.Add(Me.equipment)
        Me.Controls.Add(Me.addS)
        Me.Controls.Add(Me.searchLabel)
        Me.Controls.Add(Me.deleteS)
        Me.Controls.Add(Me.searchS)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.updateS)
        Me.Controls.Add(Me.duration)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.lab)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Name = "Equipments"
        Me.Text = "Equipments"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents equipment As TextBox
    Friend WithEvents addS As Button
    Friend WithEvents searchLabel As TextBox
    Friend WithEvents deleteS As Button
    Friend WithEvents searchS As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents updateS As Button
    Friend WithEvents duration As TextBox
    Friend WithEvents label As Label
    Friend WithEvents lab As Label
End Class
