Public Class hour
    Private Sub hour_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 9 To 17
            For j As Integer = 0 To 59
                cmbHour.Items.Add(i.ToString("00") + ":" + j.ToString("00"))
            Next
        Next
        cmbHour.SelectedIndex = 0
    End Sub


    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        MessageBox.Show("Appointment at " + cmbHour.SelectedItem.ToString() + " has been saved.")

    End Sub
End Class