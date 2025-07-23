<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scheduling
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.TextBox()
        Me.comment = New System.Windows.Forms.TextBox()
        Me.cusCont = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.populateS = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Reserve = New System.Windows.Forms.Button()
        Me.close = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.populateHour = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.docpopulate = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.cmbHour = New System.Windows.Forms.ComboBox()
        Me.id_hide = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.statusApp = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ehour = New System.Windows.Forms.TextBox()
        Me.cbPriority = New System.Windows.Forms.ComboBox()
        Me.btnSendResults = New System.Windows.Forms.Button()
        Me.invalidHours = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(45, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(45, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer Contact"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(45, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Comment"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(45, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ID"
        '
        'id
        '
        Me.id.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.Location = New System.Drawing.Point(153, 12)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(200, 38)
        Me.id.TabIndex = 6
        '
        'comment
        '
        Me.comment.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comment.Location = New System.Drawing.Point(153, 273)
        Me.comment.Multiline = True
        Me.comment.Name = "comment"
        Me.comment.Size = New System.Drawing.Size(221, 125)
        Me.comment.TabIndex = 9
        '
        'cusCont
        '
        Me.cusCont.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cusCont.Location = New System.Drawing.Point(153, 218)
        Me.cusCont.Name = "cusCont"
        Me.cusCont.Size = New System.Drawing.Size(221, 38)
        Me.cusCont.TabIndex = 10
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(153, 174)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(221, 28)
        Me.DateTimePicker1.TabIndex = 11
        '
        'populateS
        '
        Me.populateS.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.populateS.Location = New System.Drawing.Point(250, 429)
        Me.populateS.Name = "populateS"
        Me.populateS.Size = New System.Drawing.Size(124, 41)
        Me.populateS.TabIndex = 159
        Me.populateS.Text = "Populate"
        Me.populateS.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(45, 462)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 25)
        Me.Label3.TabIndex = 158
        Me.Label3.Text = "Services"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(153, 476)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(221, 154)
        Me.ListBox1.TabIndex = 157
        '
        'Reserve
        '
        Me.Reserve.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reserve.Location = New System.Drawing.Point(876, 35)
        Me.Reserve.Name = "Reserve"
        Me.Reserve.Size = New System.Drawing.Size(151, 54)
        Me.Reserve.TabIndex = 160
        Me.Reserve.Text = "Reserve"
        Me.Reserve.UseVisualStyleBackColor = True
        '
        'close
        '
        Me.close.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close.Location = New System.Drawing.Point(876, 240)
        Me.close.Name = "close"
        Me.close.Size = New System.Drawing.Size(151, 48)
        Me.close.TabIndex = 161
        Me.close.Text = "Close"
        Me.close.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(876, 123)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(151, 48)
        Me.btnDelete.TabIndex = 162
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(432, 346)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 25)
        Me.Label5.TabIndex = 163
        Me.Label5.Text = "Hour"
        '
        'populateHour
        '
        Me.populateHour.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.populateHour.Location = New System.Drawing.Point(624, 296)
        Me.populateHour.Name = "populateHour"
        Me.populateHour.Size = New System.Drawing.Size(111, 44)
        Me.populateHour.TabIndex = 167
        Me.populateHour.Text = "Populate"
        Me.populateHour.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 25
        Me.ListBox2.Location = New System.Drawing.Point(514, 356)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(221, 179)
        Me.ListBox2.TabIndex = 165
        '
        'docpopulate
        '
        Me.docpopulate.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.docpopulate.Location = New System.Drawing.Point(621, 46)
        Me.docpopulate.Name = "docpopulate"
        Me.docpopulate.Size = New System.Drawing.Size(114, 27)
        Me.docpopulate.TabIndex = 170
        Me.docpopulate.Text = "Populate"
        Me.docpopulate.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(414, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 25)
        Me.Label7.TabIndex = 169
        Me.Label7.Text = "Doctor"
        '
        'ListBox3
        '
        Me.ListBox3.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 25
        Me.ListBox3.Location = New System.Drawing.Point(514, 92)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(221, 154)
        Me.ListBox3.TabIndex = 168
        '
        'cmbHour
        '
        Me.cmbHour.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbHour.FormattingEnabled = True
        Me.cmbHour.Location = New System.Drawing.Point(876, 615)
        Me.cmbHour.Name = "cmbHour"
        Me.cmbHour.Size = New System.Drawing.Size(121, 33)
        Me.cmbHour.TabIndex = 171
        Me.cmbHour.Visible = False
        '
        'id_hide
        '
        Me.id_hide.AutoSize = True
        Me.id_hide.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_hide.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.id_hide.Location = New System.Drawing.Point(76, 42)
        Me.id_hide.Name = "id_hide"
        Me.id_hide.Size = New System.Drawing.Size(77, 25)
        Me.id_hide.TabIndex = 172
        Me.id_hide.Text = "id_hide"
        Me.id_hide.Visible = False
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(876, 449)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(151, 50)
        Me.btnStart.TabIndex = 173
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        Me.btnStart.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(876, 340)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(151, 58)
        Me.btnCancel.TabIndex = 174
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(45, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 25)
        Me.Label8.TabIndex = 176
        Me.Label8.Text = "Status"
        '
        'statusApp
        '
        Me.statusApp.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusApp.Location = New System.Drawing.Point(153, 79)
        Me.statusApp.Name = "statusApp"
        Me.statusApp.ReadOnly = True
        Me.statusApp.Size = New System.Drawing.Size(200, 38)
        Me.statusApp.TabIndex = 177
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(45, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 25)
        Me.Label9.TabIndex = 178
        Me.Label9.Text = "Priority"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(387, 577)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 25)
        Me.Label10.TabIndex = 180
        Me.Label10.Text = "End Hour"
        '
        'ehour
        '
        Me.ehour.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ehour.Location = New System.Drawing.Point(514, 574)
        Me.ehour.Name = "ehour"
        Me.ehour.ReadOnly = True
        Me.ehour.Size = New System.Drawing.Size(221, 38)
        Me.ehour.TabIndex = 181
        '
        'cbPriority
        '
        Me.cbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPriority.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPriority.FormattingEnabled = True
        Me.cbPriority.Items.AddRange(New Object() {"Low", "High"})
        Me.cbPriority.Location = New System.Drawing.Point(153, 132)
        Me.cbPriority.Name = "cbPriority"
        Me.cbPriority.Size = New System.Drawing.Size(221, 33)
        Me.cbPriority.TabIndex = 182
        '
        'btnSendResults
        '
        Me.btnSendResults.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendResults.Location = New System.Drawing.Point(876, 541)
        Me.btnSendResults.Name = "btnSendResults"
        Me.btnSendResults.Size = New System.Drawing.Size(151, 46)
        Me.btnSendResults.TabIndex = 183
        Me.btnSendResults.Text = "Send Results"
        Me.btnSendResults.UseVisualStyleBackColor = True
        Me.btnSendResults.Visible = False
        '
        'invalidHours
        '
        Me.invalidHours.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invalidHours.FormattingEnabled = True
        Me.invalidHours.ItemHeight = 25
        Me.invalidHours.Location = New System.Drawing.Point(750, 423)
        Me.invalidHours.Name = "invalidHours"
        Me.invalidHours.Size = New System.Drawing.Size(120, 79)
        Me.invalidHours.TabIndex = 184
        Me.invalidHours.Visible = False
        '
        'Scheduling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1073, 687)
        Me.Controls.Add(Me.invalidHours)
        Me.Controls.Add(Me.btnSendResults)
        Me.Controls.Add(Me.cbPriority)
        Me.Controls.Add(Me.ehour)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.statusApp)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.id_hide)
        Me.Controls.Add(Me.cmbHour)
        Me.Controls.Add(Me.docpopulate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.populateHour)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.close)
        Me.Controls.Add(Me.Reserve)
        Me.Controls.Add(Me.populateS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cusCont)
        Me.Controls.Add(Me.comment)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Scheduling"
        Me.Text = "Scheduling"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents id As TextBox
    Friend WithEvents comment As TextBox
    Friend WithEvents cusCont As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents populateS As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Reserve As Button
    Friend WithEvents close As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents populateHour As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents docpopulate As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents cmbHour As ComboBox
    Friend WithEvents id_hide As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents statusApp As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ehour As TextBox
    Friend WithEvents cbPriority As ComboBox
    Friend WithEvents btnSendResults As Button
    Friend WithEvents invalidHours As ListBox
End Class
