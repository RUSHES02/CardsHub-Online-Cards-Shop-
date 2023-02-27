Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class FormRegister

    Dim fullname, password, gender, email, phone As String
    Dim dob As Date

    Dim conn As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub FormRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PictureBoxErrorRegFullName.Visible = False
        PictureBoxErrorRegPhoneNo.Visible = False
        PictureBoxErrorRegDOB.Visible = False
        PictureBoxErrorRegGender.Visible = False
        PictureBoxErrorRegEmail.Visible = False
        PictureBoxErrorRegPassword.Visible = False
    End Sub


    Private Sub ButtonRegisterPage_Click_1(sender As Object, e As EventArgs) Handles ButtonRegister.Click



        PictureBoxErrorRegFullName.Visible = False
        PictureBoxErrorRegPhoneNo.Visible = False
        PictureBoxErrorRegDOB.Visible = False
        PictureBoxErrorRegGender.Visible = False
        PictureBoxErrorRegEmail.Visible = False
        PictureBoxErrorRegPassword.Visible = False

        fullname = TextBoxRegFullName.Text
        phone = TextBoxRegPhoneNo.Text
        dob = CDate(DateTimePickerDOB.Value)
        If (RadioButtonMale.Checked = True) Then
            gender = "Male"
        ElseIf (RadioButtonFemale.Checked = True) Then
            gender = "Female"
        End If
        email = TextBoxRegEmail.Text
        password = TextBoxRegPassword.Text

        If (checkName() And
            checkPhoneNo() And
            checkDOB() And
            checkGender() And
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

    Private Function checkDOB() As Boolean
        If (dob.Year > 2018) Then
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

    Private Function checkEmail() As Boolean
        If (email = "") Then
            PictureBoxErrorRegEmail.Visible = True
            Return False
        End If
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
        conn.ConnectionString = ("Data Source=(local);Initial Catalog=SE_PROJECT;Integrated Security=True;Pooling=False")

        cmd = New SqlCommand("INSERT INTO table_user(NAME, PHONE, GENDER, DOB, EMAIL, PASSWORD) VALUES ('" & fullname & "' ,'" & phone & "' ,'" & gender & "' , '" & dob & "' ,'" & email & "' , '" & password & "' )", conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        MsgBox("SUCCESSFULLY REGISTERED ", MsgBoxStyle.Information, "Success")
        Me.Hide()
        FormLogin.Show()
        conn.Close()

    End Sub

End Class