Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormLogin

    Dim email, password As String
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'setting error alert images to false initialluy
        PictureBoxErrorLogPassword.Visible = False
        PictureBoxErrorLogEmail.Visible = False
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        'storing email and password to variables
        email = TextBoxLogEmail.Text
        password = TextBoxLogPassword.Text

        userlogin()
    End Sub

    Private Sub LabelCreateAccount_Click(sender As Object, e As EventArgs) Handles LabelCreateAccount.Click
        'opening registeration page
        Me.Hide()
        FormRegister.Show()
    End Sub

    Sub userlogin()
        'setting the error alert images to false
        PictureBoxErrorLogPassword.Visible = False
        PictureBoxErrorLogEmail.Visible = False

        'for addmin Login
        If (email = "admin@gmail.com" And password = "Admin123") Then
            logedInEmail = email
            Me.Hide()
            FormAdminCards.Show()
            Return
        End If

        'setting sql connection
        Dim conn As New SqlConnection
        Dim cmd As New SqlCommand
        conn.ConnectionString = "Data Source=LAPTOP-G773S8H7;Initial Catalog=SE-PROJECT;Integrated Security=True;"
        conn.Open()
        Try
            'selecting the password for the entered email
            Dim checkEmail = "SELECT Password FROM TableUser WHERE Email = '" & email & "'"
            Dim sqlPassword As String
            cmd = New SqlCommand(checkEmail, conn)
            Dim reader As SqlDataReader = cmd.ExecuteReader

            'if the email existes it will return a password
            'if the passord esxists
            If reader.Read Then
                sqlPassword = reader("Password")
                'checking if the password is correct
                If (sqlPassword = password) Then
                    logedInEmail = email
                    Me.Hide()
                    FormCardList.Show()

                    'if the password is incorrect
                Else
                    PictureBoxErrorLogPassword.Visible = True
                End If

                'if the email does not exists
            Else
                MessageBox.Show("Your Email does not exist please REGISTER")
                PictureBoxErrorLogEmail.Visible = True
            End If

        Catch ex As Exception
            MsgBox("MSSQL ERROR")
        End Try
        conn.Close()
    End Sub

    Private Sub FormLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Close()
    End Sub
End Class