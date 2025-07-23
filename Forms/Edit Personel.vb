Imports System.Data.SqlClient
Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Edit_Personel
    Public lemail As String
    Public Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        If String.IsNullOrEmpty(searchLabel.Text) = False Then


            Dim query As String = "SELECT * FROM DK_USERS WHERE email='" & searchLabel.Text & "'"

            Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    Using da As New SqlDataAdapter()
                        da.SelectCommand = cmd
                        Using dt As New DataTable()
                            da.Fill(dt)
                            If dt.Rows.Count > 0 Then
                                cname.Text = dt.Rows(0)(0).ToString()
                                lastname.Text = dt.Rows(0)(1).ToString()
                                gender.Text = dt.Rows(0)(2).ToString()
                                email.Text = dt.Rows(0)(3).ToString()
                                phone.Text = dt.Rows(0)(4).ToString()
                                Country.Text = dt.Rows(0)(5).ToString()
                                role.Text = dt.Rows(0)(8).ToString()
                                salt = email.Text
                                lemail = email.Text

                                'MsgBox(salt)


                            Else
                                cname.Text = ""
                                lastname.Text = ""
                                gender.Text = ""
                                email.Text = ""
                                phone.Text = ""
                                Country.Text = ""
                                role.Text = ""
                                salt = ""
                                lemail = ""
                            End If


                        End Using
                    End Using
                End Using
            End Using
        Else
            BindData()
        End If
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        Dim Lemail As String = email.Text
        Dim Lcname As String = cname.Text
        Dim Llastname As String = lastname.Text
        Dim Lgender As String = gender.SelectedItem.ToString()
        Dim Lphone As String = phone.Text
        Dim Lcountry As String = Country.Text
        Dim Lrole As String = role.SelectedItem.ToString()

        Dim query As String = ("UPDATE DK_USERS SET name=@name, last_name=@last_name, gender=@gender 
           , email=@emaill 
, phone=@phone 
, country=@country 
, role=@role 
 
WHERE email=@email")
        Using CON As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
            Using cmd As SqlCommand = New SqlCommand(query, CON)
                cmd.Parameters.AddWithValue("@name", Lcname)
                cmd.Parameters.AddWithValue("@last_name", Llastname)
                cmd.Parameters.AddWithValue("@gender", Lgender)
                cmd.Parameters.AddWithValue("@emaill", Lemail)
                cmd.Parameters.AddWithValue("@email", searchLabel.Text)
                cmd.Parameters.AddWithValue("@phone", Lphone)

                cmd.Parameters.AddWithValue("@country", Lcountry)

                cmd.Parameters.AddWithValue("@role", Lrole)

                CON.Open()
                cmd.ExecuteNonQuery()
                CON.Close()
                cname.Text = ""
                lastname.Text = ""
                gender.Text = ""
                email.Text = ""
                phone.Text = ""
                Country.Text = ""
                role.Text = ""

                MessageBox.Show("successful UPDATED")
                BindData()
            End Using
        End Using
    End Sub

    Public Sub BindData()
        Dim query As String = "SELECT * FROM DK_USERS"
        Using CON As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
            Using cmd As SqlCommand = New SqlCommand(query, CON)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        DataGridView1.DataSource = dt


                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Dim Lemail As String = email.Text


        Dim query As String = ("DELETE FROM DK_USERS  WHERE email=@email")
        Using CON As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
            Using cmd As SqlCommand = New SqlCommand(query, CON)
                cmd.Parameters.AddWithValue("@email", Lemail)

                CON.Open()
                cmd.ExecuteNonQuery()
                CON.Close()
                cname.Text = ""
                lastname.Text = ""
                gender.Text = ""
                email.Text = ""
                phone.Text = ""
                Country.Text = ""
                role.Text = ""

                MessageBox.Show("successful deleted")
                BindData()
            End Using
        End Using
    End Sub

    Private Sub passwCh_Click(sender As Object, e As EventArgs) Handles passwCh.Click

        Change_Password.ShowDialog()


    End Sub
End Class