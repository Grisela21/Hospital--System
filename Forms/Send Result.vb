Imports System.Net.Mail

Public Class Send_Result
    Private Sub btnSendEmail_Click(sender As Object, e As EventArgs) Handles btnSendEmail.Click
        Try
            Dim smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage
            smtp_Server.UseDefaultCredentials = False
            smtp_Server.Credentials = New Net.NetworkCredential("hospitalhealinghands94@gmail.com", "ltdirnnocpyevhoo")
            smtp_Server.Port = 587
            smtp_Server.EnableSsl = True
            smtp_Server.Host = "smtp.gmail.com"
            e_mail = New MailMessage()
            e_mail.From = New MailAddress("hospitalhealinghands94@gmail.com")
            e_mail.To.Add(cusCont.Text)
            e_mail.Subject = id.Text
            e_mail.IsBodyHtml = False
            e_mail.Body = body.Text
            Dim attach As System.Net.Mail.Attachment
            attach = New System.Net.Mail.Attachment(fileName.Text)
            e_mail.Attachments.Add(attach)
            smtp_Server.Send(e_mail)
            MsgBox("Message sent!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Something Failed. Try again!", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub attach_Click(sender As Object, e As EventArgs) Handles attach.Click
        OpenFileDialog1.ShowDialog()
        fileName.Text = OpenFileDialog1.FileName
    End Sub
End Class