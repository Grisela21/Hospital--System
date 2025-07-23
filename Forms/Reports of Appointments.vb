Imports System.Data.SqlClient
Imports System.Windows.Controls

Public Class Reports_of_Appointments
    Public month As String
    Public Lyear As String
    Private Sub Reports_of_Appointments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable

        Using con As New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
            con.Open()

            Using cmd As New SqlCommand("Select * from RESERVETION", con)
                Dim da As New SqlDataAdapter
                da.SelectCommand = cmd
                da.Fill(dt)
            End Using
        End Using
        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "C:\Users\CRS\Desktop\.Net Klas\DK2\Appoitments Report.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))

        End With

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub docpopulate_Click(sender As Object, e As EventArgs) Handles docpopulate.Click
        Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
        conn.Open()



        Dim cmdD As SqlCommand = New SqlCommand("SELECT distinct email FROM doctor", conn)

        Dim readD As SqlDataReader = cmdD.ExecuteReader

        If readD.HasRows Then
            'get the doctors

            Do While readD.Read()
                ' listDoc.Add(readD("email"))
                listDoc.Items.Add(readD("email"))


            Loop
        End If


    End Sub



    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        Dim dt As New DataTable

        Using con As New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
            con.Open()
            ' MsgBox(ComboBoxMonths.SelectedIndex)
            'MsgBox(year.Text)



            If String.IsNullOrEmpty(ComboBoxMonths.Text()) = True Then
                Month = Nothing
            Else
                Month = ComboBoxMonths.SelectedIndex
            End If
            If String.IsNullOrEmpty(year.Text()) = True Then
                Lyear = Nothing
            Else
                Lyear = year.Text()
            End If

            '  MsgBox("month " + month)
            '  MsgBox("year " + Lyear)

            If ComboBoxMonths.SelectedIndex <> -1 Then
                If CheckBox1.Checked And CheckBox2.Checked = False Then
                    Using cmd As New SqlCommand("SELECT * FROM RESERVETION WHERE MONTH(date) ='" + month + "' AND YEAR(date) ='" + Lyear + "' and doctor='" + listDoc.SelectedItem.ToString + "' and canceled='T'", con)
                        Dim da As New SqlDataAdapter
                        da.SelectCommand = cmd
                        da.Fill(dt)
                    End Using
                ElseIf CheckBox2.Checked And CheckBox1.Checked = False Then
                    Using cmd As New SqlCommand("SELECT * FROM RESERVETION WHERE MONTH(date) ='" + month + "' AND YEAR(date) ='" + Lyear + "' and doctor='" + listDoc.SelectedItem.ToString + "'  and fulfilled='T'", con)
                        Dim da As New SqlDataAdapter
                        da.SelectCommand = cmd
                        da.Fill(dt)
                    End Using
                ElseIf CheckBox1.Checked And CheckBox2.Checked Then
                    Using cmd As New SqlCommand("SELECT * FROM RESERVETION WHERE MONTH(date) ='" + month + "' AND YEAR(date) ='" + Lyear + "' and  doctor='" + listDoc.SelectedItem.ToString + "'  and canceled='T'  and fulfilled='T' ", con)
                        Dim da As New SqlDataAdapter
                        da.SelectCommand = cmd
                        da.Fill(dt)
                    End Using
                Else
                    Using cmd As New SqlCommand("SELECT * FROM RESERVETION WHERE MONTH(date) ='" + month + "' AND YEAR(date) ='" + Lyear + "' and doctor='" + listDoc.SelectedItem.ToString + "'", con)
                        Dim da As New SqlDataAdapter
                        da.SelectCommand = cmd
                        da.Fill(dt)
                    End Using
                End If
            Else
                If CheckBox1.Checked And CheckBox2.Checked = False Then
                    Using cmd As New SqlCommand("SELECT * FROM RESERVETION WHERE   doctor='" + listDoc.SelectedItem.ToString + "' and canceled='T'", con)
                        Dim da As New SqlDataAdapter
                        da.SelectCommand = cmd
                        da.Fill(dt)
                    End Using
                ElseIf CheckBox2.Checked And CheckBox1.Checked = False Then
                    Using cmd As New SqlCommand("SELECT * FROM RESERVETION WHERE  doctor='" + listDoc.SelectedItem.ToString + "'  and fulfilled='T'", con)
                        Dim da As New SqlDataAdapter
                        da.SelectCommand = cmd
                        da.Fill(dt)
                    End Using
                ElseIf CheckBox1.Checked And CheckBox2.Checked Then
                    Using cmd As New SqlCommand("SELECT * FROM RESERVETION WHERE  doctor='" + listDoc.SelectedItem.ToString + "'  and canceled='T'  and fulfilled='T' ", con)
                        Dim da As New SqlDataAdapter
                        da.SelectCommand = cmd
                        da.Fill(dt)
                    End Using
                Else
                    Using cmd As New SqlCommand("SELECT * FROM RESERVETION WHERE doctor='" + listDoc.SelectedItem.ToString + "'", con)
                        Dim da As New SqlDataAdapter
                        da.SelectCommand = cmd
                        da.Fill(dt)
                    End Using
                End If
            End If
        End Using
        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "C:\Users\CRS\Desktop\.Net Klas\DK2\Appoitments Report.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))

        End With

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnAM_Click(sender As Object, e As EventArgs) Handles btnAM.Click
        MonthlyReports.yearI.Text = year.Text()
        MonthlyReports.Show()
    End Sub

    Private Sub btnDC_Click(sender As Object, e As EventArgs) Handles btnDC.Click
        CanceledReport.monthI.Text = ComboBoxMonths.SelectedIndex
        CanceledReport.Show()

    End Sub

    Private Sub btnDF_Click(sender As Object, e As EventArgs) Handles btnDF.Click
        FulfilledReports.monthI.Text = ComboBoxMonths.SelectedIndex
        FulfilledReports.Show()
    End Sub
End Class