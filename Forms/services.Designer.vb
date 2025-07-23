<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class services
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(services))
        Me.addS = New System.Windows.Forms.Button()
        Me.searchLabel = New System.Windows.Forms.TextBox()
        Me.deleteS = New System.Windows.Forms.Button()
        Me.searchS = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.updateS = New System.Windows.Forms.Button()
        Me.duration = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.lab = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.populateS = New System.Windows.Forms.Button()
        Me.service = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'addS
        '
        Me.addS.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addS.Location = New System.Drawing.Point(116, 592)
        Me.addS.Name = "addS"
        Me.addS.Size = New System.Drawing.Size(130, 57)
        Me.addS.TabIndex = 150
        Me.addS.Text = "Add"
        Me.addS.UseVisualStyleBackColor = True
        '
        'searchLabel
        '
        Me.searchLabel.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchLabel.Location = New System.Drawing.Point(103, 26)
        Me.searchLabel.Multiline = True
        Me.searchLabel.Name = "searchLabel"
        Me.searchLabel.Size = New System.Drawing.Size(617, 37)
        Me.searchLabel.TabIndex = 149
        '
        'deleteS
        '
        Me.deleteS.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteS.Location = New System.Drawing.Point(545, 592)
        Me.deleteS.Name = "deleteS"
        Me.deleteS.Size = New System.Drawing.Size(156, 59)
        Me.deleteS.TabIndex = 148
        Me.deleteS.Text = "delete"
        Me.deleteS.UseVisualStyleBackColor = True
        '
        'searchS
        '
        Me.searchS.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchS.Location = New System.Drawing.Point(739, 26)
        Me.searchS.Name = "searchS"
        Me.searchS.Size = New System.Drawing.Size(135, 34)
        Me.searchS.TabIndex = 147
        Me.searchS.Text = "search"
        Me.searchS.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(103, 81)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(631, 188)
        Me.DataGridView1.TabIndex = 146
        '
        'updateS
        '
        Me.updateS.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateS.Location = New System.Drawing.Point(325, 592)
        Me.updateS.Name = "updateS"
        Me.updateS.Size = New System.Drawing.Size(141, 57)
        Me.updateS.TabIndex = 142
        Me.updateS.Text = "Update"
        Me.updateS.UseVisualStyleBackColor = True
        '
        'duration
        '
        Me.duration.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.duration.Location = New System.Drawing.Point(179, 392)
        Me.duration.Name = "duration"
        Me.duration.Size = New System.Drawing.Size(136, 38)
        Me.duration.TabIndex = 134
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label.Location = New System.Drawing.Point(12, 395)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(163, 25)
        Me.label.TabIndex = 132
        Me.label.Text = "Duration (mm)"
        '
        'lab
        '
        Me.lab.AutoSize = True
        Me.lab.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lab.Location = New System.Drawing.Point(70, 338)
        Me.lab.Name = "lab"
        Me.lab.Size = New System.Drawing.Size(79, 25)
        Me.lab.TabIndex = 131
        Me.lab.Text = "Service"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(457, 382)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox1.Size = New System.Drawing.Size(221, 154)
        Me.ListBox1.TabIndex = 151
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(411, 329)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 25)
        Me.Label1.TabIndex = 152
        Me.Label1.Text = "Equipments"
        '
        'populateS
        '
        Me.populateS.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.populateS.Location = New System.Drawing.Point(558, 319)
        Me.populateS.Name = "populateS"
        Me.populateS.Size = New System.Drawing.Size(133, 44)
        Me.populateS.TabIndex = 153
        Me.populateS.Text = "Populate"
        Me.populateS.UseVisualStyleBackColor = True
        '
        'service
        '
        Me.service.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.service.Location = New System.Drawing.Point(179, 338)
        Me.service.Name = "service"
        Me.service.Size = New System.Drawing.Size(136, 38)
        Me.service.TabIndex = 154
        '
        'services
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(916, 706)
        Me.Controls.Add(Me.service)
        Me.Controls.Add(Me.populateS)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.addS)
        Me.Controls.Add(Me.searchLabel)
        Me.Controls.Add(Me.deleteS)
        Me.Controls.Add(Me.searchS)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.updateS)
        Me.Controls.Add(Me.duration)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.lab)
        Me.Name = "services"
        Me.Text = "services"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents addS As Button
    Friend WithEvents searchLabel As TextBox
    Friend WithEvents deleteS As Button
    Friend WithEvents searchS As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents updateS As Button
    Friend WithEvents duration As TextBox
    Friend WithEvents label As Label
    Friend WithEvents lab As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents populateS As Button
    Friend WithEvents service As TextBox
End Class
