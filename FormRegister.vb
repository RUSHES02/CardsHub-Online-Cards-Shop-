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

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Close()
        FormLogin.Show()
    End Sub

    'to check only numbers are being enterd in the quantity text box
    Private Sub TextBoxRegPhoneNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxRegPhoneNo.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
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

        'setting and running sql query to fetch email if any
        conn.ConnectionString = ("Data Source=LAPTOP-G773S8H7;Initial Catalog=SE-PROJECT;Integrated Security=True;")
        cmd = New SqlCommand("SELECT Email FROM TableUser WHERE Email = @email", conn)
        cmd.Parameters.AddWithValue("@email", email)
        conn.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader

        'checking if the email is already registered
        If reader.Read Then
            Return False
        End If
        conn.Close()
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
        'setting the sql connection and running query to insert all the details
        conn.ConnectionString = ("Data Source=LAPTOP-G773S8H7;Initial Catalog=SE-PROJECT;Integrated Security=True;")
        conn.Open()
        cmd = New SqlCommand("INSERT INTO TableUser(Name, Phone, Gender, DOB, Email, Password) VALUES (@name, @phone, @gender, @dob, @email, @password)", conn)
        cmd.Parameters.AddWithValue("@name", fullname)
        cmd.Parameters.AddWithValue("@phone", phone)
        cmd.Parameters.AddWithValue("@gender", gender)
        cmd.Parameters.AddWithValue("@dob", dob)
        cmd.Parameters.AddWithValue("@email", email)
        cmd.Parameters.AddWithValue("@password", password)
        cmd.ExecuteNonQuery()
        MsgBox("SUCCESSFULLY REGISTERED ", MsgBoxStyle.Information, "Success")
        conn.Close()

        Me.Close()
        FormLogin.Show()
    End Sub
End Class