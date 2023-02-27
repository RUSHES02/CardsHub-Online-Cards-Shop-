
Imports System.Data.SqlClient

Public Class FormLogin

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBoxErrorLogPassword.Visible = False
        PictureBoxErrorLogUsername.Visible = False
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        userlogin()
    End Sub

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegisterPage.Click
        Me.Hide()
        FormRegister.Show()
    End Sub

    Sub userlogin()
        PictureBoxErrorLogPassword.Visible = False
        PictureBoxErrorLogUsername.Visible = False
        Dim conn As New SqlConnection
        Dim cmd As New SqlCommand
        conn.ConnectionString = "Data Source=DESKTOP-A26E0MD;Initial Catalog=SE_PROJECT;Integrated Security=True; "
        conn.Open()
        Try
            Dim check As String = "SELECT * FROM table_user WHERE EMAIL = '" & TextBoxLogEmail.Text & "' AND PASSWORD = '" & TextBoxLogPassword.Text & " ' "
            cmd = New SqlCommand(check, conn)
            Dim reader As SqlDataReader = cmd.ExecuteReader

            If reader.Read Then
                MessageBox.Show("LOGIN SUCCESSFUL !!")
                Me.Hide()
                FormHome.Show()
            Else
                MessageBox.Show("INVALID LOGIN CREDENTIALS !!")
                PictureBoxErrorLogPassword.Visible = True
                PictureBoxErrorLogUsername.Visible = True
            End If

        Catch ex As Exception
            MsgBox("MSSQL ERROR")
        End Try

        conn.close()
    End Sub
End Class
