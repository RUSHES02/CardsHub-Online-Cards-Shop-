
Imports System.Data.OleDb
Public Class FormLogin

    Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\SE_PROJECT\New folder\Resources\stock_market.accdb"
    Dim conn = New OleDbConnection(dbsource)

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
        conn.open()
        Using cmd As OleDbCommand = New OleDbCommand("SELECT COUNT (*) FROM REGISTRATION WHERE [USERNAME]= @USERNAME", conn)
            cmd.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = TextBoxLogUsername.Text.Trim
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())
            If count = 0 Then
                PictureBoxErrorLogUsername.Visible = True
            End If
        End Using
        Using cmd As OleDbCommand = New OleDbCommand("SELECT COUNT [PASSWORD] = @PASSWORD FROM REGISTERATION WHERE USERNAME = ", conn)
            cmd.Parameters.AddWithValue("@PASSWORD", OleDbType.VarChar).Value = TextBoxLogPassword.Text.Trim

            'Dim count = Convert.ToInt32(cmd.ExecuteScalar())
            'If count > 0 Then
            MessageBox.Show("LOGIN SUCCESSFULL !!")
                Me.Close()
                FormHome.Show()
            ' End If
        End Using
        conn.close()
    End Sub
End Class
