<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FulfilledReports
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.monthI = New System.Windows.Forms.Label()
        Me.fulfilled = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.fulfilled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'monthI
        '
        Me.monthI.AutoSize = True
        Me.monthI.Location = New System.Drawing.Point(646, 145)
        Me.monthI.Name = "monthI"
        Me.monthI.Size = New System.Drawing.Size(36, 13)
        Me.monthI.TabIndex = 9
        Me.monthI.Text = "month"
        Me.monthI.Visible = False
        '
        'fulfilled
        '
        ChartArea2.Name = "ChartArea1"
        Me.fulfilled.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.fulfilled.Legends.Add(Legend2)
        Me.fulfilled.Location = New System.Drawing.Point(119, 75)
        Me.fulfilled.Name = "fulfilled"
        Me.fulfilled.Size = New System.Drawing.Size(485, 300)
        Me.fulfilled.TabIndex = 8
        Me.fulfilled.Text = "Chart1"
        '
        'FulfilledReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.monthI)
        Me.Controls.Add(Me.fulfilled)
        Me.Name = "FulfilledReports"
        Me.Text = "FulfilledReports"
        CType(Me.fulfilled, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents monthI As Label
    Friend WithEvents fulfilled As DataVisualization.Charting.Chart
End Class
