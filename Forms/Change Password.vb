Imports System.Data.SqlClient

Public Class Change_Password

    Dim pasww As String
    Dim Lsalt As String
    Dim Lrole As String
    Dim lpassw As String
    Private Sub changeP_Click(sender As Object, e As EventArgs) Handles changeP.Click
        Dim lemail As String = salt

        Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
        ' lemail = Edit_Personel.Lemail
        MsgBox(lemail)
        conn.Open()
        Dim query As String = "SELECT * FROM DK_USERS WHERE email=@email"
        Dim cmdS As SqlCommand = New SqlCommand(query, conn)
        cmdS.Parameters.AddWithValue("@email", lemail)


        Dim readS As SqlDataReader = cmdS.ExecuteReader

        If readS.Read Then
            Lsalt = readS("salt").ToString
            Lrole = readS("role").ToString
            lpassw = readS("password").ToString
            Dim new_hashed As String = Form2.HashPassword(oldP.Text, Lsalt, 10101, 100)
            conn.Close()


            If lpassw = new_hashed Then


                '  If Lrole = "menager" Then

                If newP.Text = "" Then
                    MsgBox("All fileds are required!")
                ElseIf Form2.ValidatePassword(newP.Text) = False Then
                    MessageBox.Show("Password should be at least 8 charachters long and it should cointains at least 1 uppercase/lowercase/number/special charachter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf cNewP.Text = "" Then
                    MsgBox("All fileds are required!")

                ElseIf newP.Text <> cNewP.Text Then
                    MsgBox("New password confirmation failed!")
                Else
                    MsgBox(newP.Text)

                    Dim pwdHashed As String = Form2.HashPassword(newP.Text, salt, 10101, 100)

                    Dim cmdU As SqlCommand = New SqlCommand("
               Update DK_USERS set  password= @password  WHERE  email= @email
               ", conn)
                    cmdU.Parameters.AddWithValue("@email", lemail)
                    cmdU.Parameters.AddWithValue("@password", pwdHashed)
                    conn.Open()
                    cmdU.ExecuteNonQuery()
                    conn.Close()
                    MsgBox("Password was updated succsesfully :)")
                    oldP.Clear()
                    newP.Clear()
                    cNewP.Clear()
                    conn.Close()
                End If
                '  Else
                ' MsgBox("You can't edit this user :(")


                'End If




            Else
                MsgBox("Password is not correct!")
                oldP.Clear()
                newP.Clear()
                cNewP.Clear()
                conn.Close()

            End If
            conn.Close()
        Else
            MsgBox("Error!")
            conn.Close()

        End If
    End Sub


End Class