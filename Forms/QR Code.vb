Imports QRCoder

Public Class QR_Code
    Private Sub QR_Code_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim gen As QRCodeGenerator = New QRCodeGenerator
        Dim data = gen.CreateQrCode(stringQr.Text, QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCode(data)
        pic.Image = code.GetGraphic(6)
    End Sub
End Class