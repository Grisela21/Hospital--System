Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class Form1

    Dim salt As String
    Dim Lrole As String
    Public lemail As String



    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
        conn.Open()

        Dim cmdS As SqlCommand = New SqlCommand("
               SELECT * FROM DK_USERS WHERE email= @email
               ", conn)
        cmdS.Parameters.AddWithValue("@email", email.Text)



        Dim readS As SqlDataReader = cmdS.ExecuteReader

        If readS.Read Then
            salt = readS("salt").ToString
            Lrole = readS("role").ToString
            Dim new_hashed As String = Form2.HashPassword(password.Text, salt, 10101, 100)
            conn.Close()
            '  MsgBox(new_hashed)
            Dim cmd As SqlCommand = New SqlCommand("
               SELECT * FROM DK_USERS WHERE email= @email
               and password= @password", conn)
            cmd.Parameters.AddWithValue("@email", email.Text)
            cmd.Parameters.AddWithValue("@password", new_hashed)

            conn.Open()
            Dim myread As SqlDataReader = cmd.ExecuteReader

            If myread.Read Then


                'MsgBox("Success")

                Me.Hide()
                If Lrole = "menager" Then
                    menager.Show()
                ElseIf Lrole = "doctor" Then
                    Doctor_Profile.docEmail.Text = email.Text
                    Doctor_Profile.Show()
                ElseIf Lrole = "employer" Then
                    Employee_Profile.Show()
                ElseIf Lrole = "client" Then
                    ' MsgBox(email.Text)
                    Cprofile.clemail.Text = email.Text
                    Cprofile.Show()
                Else
                    Me.Show()
                    MsgBox("hmm..I don't think you have an account. Click the link below to register :)")

                End If
                lemail = email.Text
                email.Clear()
                password.Clear()

            Else
                MsgBox("Authentication Failed!")
                conn.Close()

            End If
            conn.Close()
        Else
            MsgBox("Authentication Failed!")
            conn.Close()

        End If


    End Sub
    Public Shared Function verifypassword(ByVal password As String, ByVal hashed_password As String, ByVal salt As String) As Boolean

        Dim new_hashed As String = Form2.HashPassword(password, salt, 10101, 70)
        Return new_hashed.Equals(hashed_password)

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'HIDE THE TEXT OF THE TextBox3 ON THE FIRST LOAD
        password.UseSystemPasswordChar = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'CHECKING IF THE CHECKBOX WAS CHECKED OR NOT.
        If CheckBox1.CheckState = CheckState.Checked Then
            'IF TRUE, IT SHOWS THE TEXT
            password.UseSystemPasswordChar = False
        Else
            'IF FALSE, IT WILL HIDE THE TEXT AND IT WILL TURN INTO BULLETS.
            password.UseSystemPasswordChar = True
        End If
    End Sub

End Class