Imports System.Data.OleDb
Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class FormRegister

    Dim fullname, username, password, pan, gender, email, phone, errormsg As String

    Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\SE_PROJECT\ShareMarket\Resources\stock_market.accdb"
    Dim conn = New OleDbConnection(dbsource)

    Private Sub FormRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PictureBoxErrorRegFullName.Visible = False
        PictureBoxErrorRegPhoneNo.Visible = False
        PictureBoxErrorRegPanCard.Visible = False
        PictureBoxErrorRegDOB.Visible = False
        PictureBoxErrorRegGender.Visible = False
        PictureBoxErrorRegUsername.Visible = False
        PictureBoxErrorRegEmail.Visible = False
        PictureBoxErrorRegPassword.Visible = False
    End Sub

    Dim dob As Date

    Private Sub ButtonRegisterPage_Click_1(sender As Object, e As EventArgs) Handles ButtonRegister.Click

        PictureBoxErrorRegFullName.Visible = False
        PictureBoxErrorRegPhoneNo.Visible = False
        PictureBoxErrorRegPanCard.Visible = False
        PictureBoxErrorRegDOB.Visible = False
        PictureBoxErrorRegGender.Visible = False
        PictureBoxErrorRegUsername.Visible = False
        PictureBoxErrorRegEmail.Visible = False
        PictureBoxErrorRegPassword.Visible = False

        fullname = TextBoxRegFullName.Text
        phone = TextBoxRegPhoneNo.Text
        pan = TextBoxRegPanCard.Text
        dob = CDate(DateTimePickerDOB.Value)
        If (RadioButtonMale.Checked = True) Then
            gender = "Male"
        ElseIf (RadioButtonFemale.Checked = True) Then
            gender = "Female"
        End If
        username = TextBoxRegUsername.Text
        email = TextBoxRegEmail.Text
        password = TextBoxRegPassword.Text

        If (checkName() And
            checkPhoneNo() And
            checkPanCard() And
            checkDOB() And
            checkGender() And
            checkUsename() And
            checkEmail() And
            checkPassword()) Then
            RegisterInDb()
        End If
    End Sub
    Private Function checkName() As Boolean
        If (fullname = "") Then
            PictureBoxErrorRegFullName.Visible = True
            Return False
        End If
        Return True
    End Function

    Private Function checkPhoneNo() As Boolean
        If (phone.Length <> 10) Then
            PictureBoxErrorRegPhoneNo.Visible = True
            Return False

        Else
            For Each c As Char In phone
                If (IsNumeric(c) = False) Then
                    PictureBoxErrorRegPhoneNo.Visible = True
                    Return False
                End If
            Next
        End If
        Return True
    End Function



    Private Function checkPanCard() As Boolean
        If (pan.Length <> 10) Then
            PictureBoxErrorRegPanCard.Visible = True
            Return False
        End If
        Dim i = 1
        For Each c As Char In pan
            If (i >= 6 And i <= 9) Then
                If Not (IsNumeric(c)) Then
                    PictureBoxErrorRegPanCard.Visible = True
                    Return False
                End If
            ElseIf Not (Asc(c) >= 65 And Asc(c) <= 90) Then
                PictureBoxErrorRegPanCard.Visible = True
                Return False
            End If
            i += 1
        Next

        conn.Open()
        Using cmd As OleDbCommand = New OleDbCommand("SELECT COUNT (*) FROM REGISTRATION WHERE [PAN]= @PAN", conn)
            cmd.Parameters.AddWithValue("@PAN", OleDbType.VarChar).Value = TextBoxRegPanCard.Text.Trim
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If (count > 0) Then
                PictureBoxErrorRegPanCard.Visible = True
                Return False
            End If
        End Using
        conn.Close()

        Return True
    End Function

    Private Function checkDOB() As Boolean
        If (dob.Year > 2005) Then
            PictureBoxErrorRegDOB.Visible = True
            Return False
        End If
        Return True
    End Function

    Private Function checkGender() As Boolean
        If (RadioButtonMale.Checked = False And RadioButtonFemale.Checked = False) Then
            PictureBoxErrorRegGender.Visible = True
        End If
        Return True
    End Function

    Private Function checkUsename() As Boolean
        If (username = "") Then
            PictureBoxErrorRegUsername.Visible = True
            Return False
        End If

        conn.Open()
        Using cmd As OleDbCommand = New OleDbCommand("SELECT COUNT (*) FROM REGISTRATION WHERE [USERNAME]= @USERNAME", conn)
            cmd.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = TextBoxRegUsername.Text.Trim
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If (count > 0) Then
                PictureBoxErrorRegUsername.Visible = True
                Return False
            End If
        End Using
        conn.Close()

        Return True
    End Function

    Private Function checkEmail() As Boolean
        If (email = "") Then
            PictureBoxErrorRegEmail.Visible = True
            Return False
        End If

        conn.Open()
        Using cmd As OleDbCommand = New OleDbCommand("SELECT COUNT (*) FROM REGISTRATION WHERE [EMAIL]= @EMAIL", conn)
            cmd.Parameters.AddWithValue("@EMAIL", OleDbType.VarChar).Value = TextBoxRegEmail.Text.Trim
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If (count > 0) Then
                PictureBoxErrorRegEmail.Visible = True
                Return False
            End If
        End Using
        conn.Close()

        Return True
    End Function

    Private Function checkPassword() As Boolean
        If (password.Length < 6) Then
            PictureBoxErrorRegPassword.Visible = True
            Return False
        End If
        Return True
    End Function
    Private Sub RegisterInDb()
        conn.Open()
        Dim str = "Insert into [REGISTRATION]( [NAME], [USERNAME], [PASSWORD], [DOB], [PAN], [EMAIL], [GENDER], [PHONE]) Values ('" & fullname & "','" & username & "','" & password & "','" & dob & "','" & pan & "','" & email & "','" & gender & "','" & phone & "' );"
        Dim cmd As OleDbCommand = New OleDbCommand(str, conn)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
            MsgBox("SIGN UP SUCCESSFUL")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Close()
        FormLogin.Show()
    End Sub

End Class