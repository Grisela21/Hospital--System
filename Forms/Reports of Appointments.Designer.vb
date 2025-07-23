<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports_of_Appointments
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.docpopulate = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.listDoc = New System.Windows.Forms.ListBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxMonths = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.year = New System.Windows.Forms.TextBox()
        Me.btnAM = New System.Windows.Forms.Button()
        Me.btnDC = New System.Windows.Forms.Button()
        Me.btnDF = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportViewer1.Location = New System.Drawing.Point(26, 261)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1004, 366)
        Me.ReportViewer1.TabIndex = 0
        '
        'docpopulate
        '
        Me.docpopulate.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.docpopulate.Location = New System.Drawing.Point(12, 43)
        Me.docpopulate.Name = "docpopulate"
        Me.docpopulate.Size = New System.Drawing.Size(105, 37)
        Me.docpopulate.TabIndex = 173
        Me.docpopulate.Text = "Populate"
        Me.docpopulate.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(122, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 24)
        Me.Label7.TabIndex = 172
        Me.Label7.Text = "Doctor"
        '
        'listDoc
        '
        Me.listDoc.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listDoc.FormattingEnabled = True
        Me.listDoc.ItemHeight = 24
        Me.listDoc.Location = New System.Drawing.Point(126, 43)
        Me.listDoc.Name = "listDoc"
        Me.listDoc.Size = New System.Drawing.Size(181, 124)
        Me.listDoc.TabIndex = 171
        '
        'btnLoad
        '
        Me.btnLoad.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(452, 188)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(105, 37)
        Me.btnLoad.TabIndex = 174
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(410, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 24)
        Me.Label1.TabIndex = 176
        Me.Label1.Text = "Canceled"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckBox1.Location = New System.Drawing.Point(519, 33)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(123, 28)
        Me.CheckBox1.TabIndex = 179
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckBox2.Location = New System.Drawing.Point(519, 69)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(123, 28)
        Me.CheckBox2.TabIndex = 181
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(410, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 24)
        Me.Label2.TabIndex = 180
        Me.Label2.Text = "Fulfilled"
        '
        'ComboBoxMonths
        '
        Me.ComboBoxMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMonths.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxMonths.FormattingEnabled = True
        Me.ComboBoxMonths.Items.AddRange(New Object() {"", "Janary", "Febrary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.ComboBoxMonths.Location = New System.Drawing.Point(799, 36)
        Me.ComboBoxMonths.Name = "ComboBoxMonths"
        Me.ComboBoxMonths.Size = New System.Drawing.Size(160, 32)
        Me.ComboBoxMonths.TabIndex = 182
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(665, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 24)
        Me.Label3.TabIndex = 183
        Me.Label3.Text = "Months"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(665, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 24)
        Me.Label4.TabIndex = 184
        Me.Label4.Text = "Year"
        '
        'year
        '
        Me.year.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.year.Location = New System.Drawing.Point(799, 148)
        Me.year.Name = "year"
        Me.year.Size = New System.Drawing.Size(160, 30)
        Me.year.TabIndex = 185
        '
        'btnAM
        '
        Me.btnAM.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAM.Location = New System.Drawing.Point(809, 188)
        Me.btnAM.Name = "btnAM"
        Me.btnAM.Size = New System.Drawing.Size(136, 49)
        Me.btnAM.TabIndex = 186
        Me.btnAM.Text = "Appointmenmt/Month"
        Me.btnAM.UseVisualStyleBackColor = True
        '
        'btnDC
        '
        Me.btnDC.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDC.Location = New System.Drawing.Point(746, 80)
        Me.btnDC.Name = "btnDC"
        Me.btnDC.Size = New System.Drawing.Size(136, 46)
        Me.btnDC.TabIndex = 187
        Me.btnDC.Text = "Doctor/Canceled"
        Me.btnDC.UseVisualStyleBackColor = True
        '
        'btnDF
        '
        Me.btnDF.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDF.Location = New System.Drawing.Point(903, 80)
        Me.btnDF.Name = "btnDF"
        Me.btnDF.Size = New System.Drawing.Size(136, 46)
        Me.btnDF.TabIndex = 188
        Me.btnDF.Text = "Doctor/Fulfilled"
        Me.btnDF.UseVisualStyleBackColor = True
        '
        'Reports_of_Appointments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1042, 679)
        Me.Controls.Add(Me.btnDF)
        Me.Controls.Add(Me.btnDC)
        Me.Controls.Add(Me.btnAM)
        Me.Controls.Add(Me.year)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxMonths)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.docpopulate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.listDoc)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Reports_of_Appointments"
        Me.Text = "Reports_of_Appointments"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents docpopulate As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents listDoc As ListBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxMonths As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents year As TextBox
    Friend WithEvents btnAM As Button
    Friend WithEvents btnDC As Button
    Friend WithEvents btnDF As Button
End Class
