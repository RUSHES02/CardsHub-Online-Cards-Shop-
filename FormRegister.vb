Imports System.Data.SqlClient

Public Class FormRegister

    Dim fullname, password, gender, email, phone As String
    Dim dob As Date

    Dim conn As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub FormRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'initializing all error alert messages to false initially
        PictureBoxErrorRegFullName.Visible = False
        PictureBoxErrorRegPhoneNo.Visible = False
        PictureBoxErrorRegDOB.Visible = False
        PictureBoxErrorRegGender.Visible = False
        PictureBoxErrorRegEmail.Visible = False
        PictureBoxErrorRegPassword.Visible = False
    End Sub


    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        'setting the error alert images to false
        PictureBoxErrorRegFullName.Visible = False
        PictureBoxErrorRegPhoneNo.Visible = False
        PictureBoxErrorRegDOB.Visible = False
        PictureBoxErrorRegGender.Visible = False
        PictureBoxErrorRegEmail.Visible = False
        PictureBoxErrorRegPassword.Visible = False

        'storing all entered details into variable
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

        'checking if all the fields are entered correctly
        If (checkName() And
            checkPhoneNo() And
            checkDOB() And
            checkGender() And
            checkEmail() And
            checkPassword()) Then

            'registering the user
            RegisterInDb()
        End If
    End Sub

    'function to the check the name field
    Private Function checkName() As Boolean
        If (fullname = "") Then
            PictureBoxErrorRegFullName.Visible = True
            Return False
        End If
        Return True
    End Function

    'function to check the phone no field
    Private Function checkPhoneNo() As Boolean
        'checking if the phone no is of length of 10
        If (phone.Length <> 10) Then
            PictureBoxErrorRegPhoneNo.Visible = True
            Return False

            'cj=hecking if the all the characters are numbers
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

    'function to check the DOB field
    Private Function checkDOB() As Boolean
        ' checking the user is 5 years or more
        If (dob.Year > 2018) Then
            PictureBoxErrorRegDOB.Visible = True
            Return False
        End If
        Return True
    End Function

    'function to check the gender field
    Private Function checkGender() As Boolean
        If (RadioButtonMale.Checked = False And RadioButtonFemale.Checked = False) Then
            PictureBoxErrorRegGender.Visible = True
        End If
        Return True
    End Function

    'function to check the email field
    Private Function checkEmail() As Boolean
        If (email = "") Then
            PictureBoxErrorRegEmail.Visible = True
            Return False
        End If

        conn.ConnectionString = ("Data Source=LAPTOP-G773S8H7;Initial Catalog=SE-PROJECT;Integrated Security=True;")
        cmd = New SqlCommand("SELECT Email FROM TableUser WHERE Email = '" & email & "'", conn)
        conn.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader

        'checking if the email is already registered
        If reader.Read Then
            Return False
        End If

        Return True
    End Function

    'function to check the password field
    Private Function checkPassword() As Boolean
        If (password.Length < 6 And password.Length <= 20) Then
            PictureBoxErrorRegPassword.Visible = True
            Return False
        End If
        Return True
    End Function

    'function to register the users to the database
    Private Sub RegisterInDb()
        'setting the sql connection
        conn.ConnectionString = ("Data Source=LAPTOP-G773S8H7;Initial Catalog=SE-PROJECT;Integrated Security=True;")
        cmd = New SqlCommand("INSERT INTO TableUser(Name, Phone, Gender, DOB, Email, Password) VALUES ('" & fullname & "' ,'" & phone & "' ,'" & gender & "' , '" & dob & "' ,'" & email & "' , '" & password & "' )", conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        MsgBox("SUCCESSFULLY REGISTERED ", MsgBoxStyle.Information, "Success")
        conn.Close()

        Me.Close()
        FormLogin.Show()
    End Sub
End Class