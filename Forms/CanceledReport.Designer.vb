<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CanceledReport
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.monthI = New System.Windows.Forms.Label()
        Me.canceled = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.canceled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'monthI
        '
        Me.monthI.AutoSize = True
        Me.monthI.Location = New System.Drawing.Point(646, 145)
        Me.monthI.Name = "monthI"
        Me.monthI.Size = New System.Drawing.Size(36, 13)
        Me.monthI.TabIndex = 7
        Me.monthI.Text = "month"
        Me.monthI.Visible = False
        '
        'canceled
        '
        ChartArea3.Name = "ChartArea1"
        Me.canceled.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.canceled.Legends.Add(Legend3)
        Me.canceled.Location = New System.Drawing.Point(119, 75)
        Me.canceled.Name = "canceled"
        Me.canceled.Size = New System.Drawing.Size(485, 300)
        Me.canceled.TabIndex = 6
        Me.canceled.Text = "Chart1"
        '
        'CanceledReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.monthI)
        Me.Controls.Add(Me.canceled)
        Me.Name = "CanceledReport"
        Me.Text = "CanceledReport"
        CType(Me.canceled, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents monthI As Label
    Friend WithEvents canceled As DataVisualization.Charting.Chart
End Class
