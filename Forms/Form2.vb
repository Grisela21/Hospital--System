

Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class Form2




    Dim Namec As String
    Dim lastnamec As String
    Dim genderc As String
    Dim emailc As String
    Dim phonec As String
    Dim countryc As String
    Dim passwordc As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-TTO3NMA\SQLEXPRESS;Initial Catalog=DKURSI;Integrated Security=True;Pooling=False")
        Dim Namec As String

        If String.IsNullOrEmpty(cname.Text) = True Then
            MessageBox.Show("Name is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Namec = cname.Text
        End If

        If String.IsNullOrEmpty(lastname.Text) = True Then
            MessageBox.Show("Lastname is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            lastnamec = lastname.Text
        End If


        If String.IsNullOrEmpty(gender.Text) = True Then
            genderc = Nothing

        Else
            genderc = gender.SelectedItem.ToString()
        End If

        If String.IsNullOrEmpty(email.Text) = True Then
            MessageBox.Show("Email is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf IsValidEmailFormat(email.Text) = False Then
            MessageBox.Show("Email is not in correct format !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            emailc = email.Text
        End If
        If String.IsNullOrEmpty(phone.Text) = True Then
            phonec = Nothing
        Else
            phonec = phone.Text
        End If
        If String.IsNullOrEmpty(Country.Text) = True Then
            countryc = Nothing
        Else
            countryc = Country.Text
        End If
        If String.IsNullOrEmpty(password.Text) = True Then
            MessageBox.Show("Password is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub

        End If



        If ValidatePassword(password.Text) Then


            Dim salt As String = GenerateSalt(70)

            Dim pwdHashed As String = HashPassword(password.Text, salt, 10101, 100)


            Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[DK_USERS]
           ([name]
           ,[last_name]
           ,[gender]
           ,[email]
           ,[phone]
           ,[country]
           ,[password]
           ,[salt]
           ,[role])
     VALUES
           ('" + Namec + "',
           '" + lastnamec + "',
           '" + genderc + "'
           ,'" + emailc + "'
           ,'" + phonec + "'
           ,'" + countryc + "'
           ,'" + pwdHashed + "'
           ,'" + salt + "'
            ,'" + "client" + "')", conn)

            conn.Open()
            Try
                cmd.ExecuteNonQuery()
            Catch ex As SqlException When ex.ErrorCode = -2146232060
                MsgBox("Record already exists in the database.")
                Exit Sub
            End Try
            MessageBox.Show("You have registered succsessfully ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.Close()

                Else

                MessageBox.Show("Password should be at least 8 charachters long and it should cointains at least 1 uppercase/lowercase/number/special charachter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form1.Show()
    End Sub

    Public Shared Function GenerateSalt(ByVal nSalt As Integer) As String
        Dim saltBytes = New Byte(nSalt) {}

        Using provider = New RNGCryptoServiceProvider()
            provider.GetNonZeroBytes(saltBytes)
        End Using

        Return Convert.ToBase64String(saltBytes)
    End Function


    Public Shared Function HashPassword(ByVal password As String, ByVal salt As String, ByVal nIterations As Integer, ByVal nHash As Integer) As String
        Dim saltBytes = Convert.FromBase64String(salt)

        Using rfc2898DeriveBytes = New Rfc2898DeriveBytes(password, saltBytes, nIterations)
            Return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(nHash))
        End Using
    End Function

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Function ValidatePassword(ByVal pwd As String,
    Optional ByVal minLength As Integer = 8,
    Optional ByVal numUpper As Integer = 1,
    Optional ByVal numLower As Integer = 1,
    Optional ByVal numNumbers As Integer = 1,
    Optional ByVal numSpecial As Integer = 1) As Boolean

        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Special is "none of the above".
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        ' Check the length.
        If Len(pwd) < minLength Then Return False
        ' Check for minimum number of occurrences.
        If upper.Matches(pwd).Count < numUpper Then Return False
        If lower.Matches(pwd).Count < numLower Then Return False
        If number.Matches(pwd).Count < numNumbers Then Return False
        If special.Matches(pwd).Count < numSpecial Then Return False

        ' Passed all checks.
        Return True
    End Function

    Function IsValidEmailFormat(ByVal s As String) As Boolean
        Try
            Dim a As New System.Net.Mail.MailAddress(s)
        Catch
            Return False
        End Try
        Return True
    End Function


End Class




