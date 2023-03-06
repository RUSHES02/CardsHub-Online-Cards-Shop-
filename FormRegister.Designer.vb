<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegister
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TextBoxRegPhoneNo = New TextBox()
        TextBoxRegFullName = New TextBox()
        TextBoxRegPassword = New TextBox()
        TextBoxRegEmail = New TextBox()
        RadioButtonMale = New RadioButton()
        RadioButtonFemale = New RadioButton()
        DateTimePickerDOB = New DateTimePicker()
        ButtonRegister = New Button()
        LabelGender = New Label()
        LabelRegisteration = New Label()
        LabelDOB = New Label()
        PictureBoxRegFullName = New PictureBox()
        PictureBoxRegPhoneNo = New PictureBox()
        PictureBoxRegEmail = New PictureBox()
        PictureBoxRegPassword = New PictureBox()
        PictureBoxRegDOB = New PictureBox()
        PictureBoxErrorRegFullName = New PictureBox()
        PictureBoxErrorRegPhoneNo = New PictureBox()
        PictureBoxErrorRegGender = New PictureBox()
        PictureBoxErrorRegDOB = New PictureBox()
        PictureBoxErrorRegEmail = New PictureBox()
        PictureBoxErrorRegPassword = New PictureBox()
        CType(PictureBoxRegFullName, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxRegPhoneNo, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxRegEmail, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxRegPassword, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxRegDOB, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxErrorRegFullName, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxErrorRegPhoneNo, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxErrorRegGender, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxErrorRegDOB, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxErrorRegEmail, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxErrorRegPassword, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBoxRegPhoneNo
        ' 
        TextBoxRegPhoneNo.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxRegPhoneNo.Location = New Point(115, 143)
        TextBoxRegPhoneNo.Name = "TextBoxRegPhoneNo"
        TextBoxRegPhoneNo.PlaceholderText = "Phone No."
        TextBoxRegPhoneNo.Size = New Size(300, 46)
        TextBoxRegPhoneNo.TabIndex = 5
        ' 
        ' TextBoxRegFullName
        ' 
        TextBoxRegFullName.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxRegFullName.Location = New Point(117, 80)
        TextBoxRegFullName.Name = "TextBoxRegFullName"
        TextBoxRegFullName.PlaceholderText = "Full Name"
        TextBoxRegFullName.Size = New Size(300, 46)
        TextBoxRegFullName.TabIndex = 6
        ' 
        ' TextBoxRegPassword
        ' 
        TextBoxRegPassword.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxRegPassword.Location = New Point(115, 509)
        TextBoxRegPassword.Name = "TextBoxRegPassword"
        TextBoxRegPassword.PasswordChar = "*"c
        TextBoxRegPassword.PlaceholderText = "Password"
        TextBoxRegPassword.Size = New Size(300, 46)
        TextBoxRegPassword.TabIndex = 7
        ' 
        ' TextBoxRegEmail
        ' 
        TextBoxRegEmail.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxRegEmail.Location = New Point(115, 417)
        TextBoxRegEmail.Name = "TextBoxRegEmail"
        TextBoxRegEmail.PlaceholderText = "Email"
        TextBoxRegEmail.Size = New Size(300, 46)
        TextBoxRegEmail.TabIndex = 8
        ' 
        ' RadioButtonMale
        ' 
        RadioButtonMale.AutoSize = True
        RadioButtonMale.Location = New Point(122, 280)
        RadioButtonMale.Name = "RadioButtonMale"
        RadioButtonMale.Size = New Size(51, 19)
        RadioButtonMale.TabIndex = 9
        RadioButtonMale.TabStop = True
        RadioButtonMale.Text = "Male"
        RadioButtonMale.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonFemale
        ' 
        RadioButtonFemale.AutoSize = True
        RadioButtonFemale.Location = New Point(276, 280)
        RadioButtonFemale.Name = "RadioButtonFemale"
        RadioButtonFemale.Size = New Size(63, 19)
        RadioButtonFemale.TabIndex = 10
        RadioButtonFemale.TabStop = True
        RadioButtonFemale.Text = "Female"
        RadioButtonFemale.UseVisualStyleBackColor = True
        ' 
        ' DateTimePickerDOB
        ' 
        DateTimePickerDOB.Location = New Point(201, 349)
        DateTimePickerDOB.Name = "DateTimePickerDOB"
        DateTimePickerDOB.Size = New Size(200, 23)
        DateTimePickerDOB.TabIndex = 11
        DateTimePickerDOB.Value = New DateTime(2005, 1, 1, 0, 0, 0, 0)
        ' 
        ' ButtonRegister
        ' 
        ButtonRegister.BackColor = Color.Blue
        ButtonRegister.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ButtonRegister.FlatStyle = FlatStyle.Popup
        ButtonRegister.Font = New Font("Sitka Banner", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonRegister.ForeColor = SystemColors.ButtonHighlight
        ButtonRegister.Location = New Point(183, 576)
        ButtonRegister.Name = "ButtonRegister"
        ButtonRegister.Size = New Size(170, 50)
        ButtonRegister.TabIndex = 12
        ButtonRegister.Text = "Register"
        ButtonRegister.UseVisualStyleBackColor = False
        ' 
        ' LabelGender
        ' 
        LabelGender.AutoSize = True
        LabelGender.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        LabelGender.Location = New Point(115, 232)
        LabelGender.Name = "LabelGender"
        LabelGender.Size = New Size(80, 30)
        LabelGender.TabIndex = 14
        LabelGender.Text = "Gender"' 
        ' LabelRegisteration
        ' 
        LabelRegisteration.AutoSize = True
        LabelRegisteration.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        LabelRegisteration.Location = New Point(25, 19)
        LabelRegisteration.Name = "LabelRegisteration"
        LabelRegisteration.Size = New Size(207, 45)
        LabelRegisteration.TabIndex = 15
        LabelRegisteration.Text = "Registeration"' 
        ' LabelDOB
        ' 
        LabelDOB.AutoSize = True
        LabelDOB.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        LabelDOB.Location = New Point(115, 341)
        LabelDOB.Name = "LabelDOB"
        LabelDOB.Size = New Size(56, 30)
        LabelDOB.TabIndex = 16
        LabelDOB.Text = "DOB"
        LabelDOB.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBoxRegFullName
        ' 
        PictureBoxRegFullName.BackColor = Color.Transparent
        PictureBoxRegFullName.Image = My.Resources.Resources.icons8_customer_48
        PictureBoxRegFullName.Location = New Point(42, 76)
        PictureBoxRegFullName.Name = "PictureBoxRegFullName"
        PictureBoxRegFullName.Size = New Size(50, 50)
        PictureBoxRegFullName.TabIndex = 17
        PictureBoxRegFullName.TabStop = False
        ' 
        ' PictureBoxRegPhoneNo
        ' 
        PictureBoxRegPhoneNo.BackColor = Color.Transparent
        PictureBoxRegPhoneNo.Image = My.Resources.Resources.icons8_phone_50
        PictureBoxRegPhoneNo.Location = New Point(42, 143)
        PictureBoxRegPhoneNo.Name = "PictureBoxRegPhoneNo"
        PictureBoxRegPhoneNo.Size = New Size(50, 50)
        PictureBoxRegPhoneNo.TabIndex = 18
        PictureBoxRegPhoneNo.TabStop = False
        ' 
        ' PictureBoxRegEmail
        ' 
        PictureBoxRegEmail.BackColor = Color.Transparent
        PictureBoxRegEmail.Image = My.Resources.Resources.icons8_secured_letter_48
        PictureBoxRegEmail.Location = New Point(42, 417)
        PictureBoxRegEmail.Name = "PictureBoxRegEmail"
        PictureBoxRegEmail.Size = New Size(50, 50)
        PictureBoxRegEmail.TabIndex = 21
        PictureBoxRegEmail.TabStop = False
        ' 
        ' PictureBoxRegPassword
        ' 
        PictureBoxRegPassword.BackColor = Color.Transparent
        PictureBoxRegPassword.Image = My.Resources.Resources.icons8_protonmail_48
        PictureBoxRegPassword.Location = New Point(42, 509)
        PictureBoxRegPassword.Name = "PictureBoxRegPassword"
        PictureBoxRegPassword.Size = New Size(50, 50)
        PictureBoxRegPassword.TabIndex = 22
        PictureBoxRegPassword.TabStop = False
        ' 
        ' PictureBoxRegDOB
        ' 
        PictureBoxRegDOB.BackColor = Color.Transparent
        PictureBoxRegDOB.Image = My.Resources.Resources.icons8_birth_date_50
        PictureBoxRegDOB.Location = New Point(42, 332)
        PictureBoxRegDOB.Name = "PictureBoxRegDOB"
        PictureBoxRegDOB.Size = New Size(50, 50)
        PictureBoxRegDOB.TabIndex = 23
        PictureBoxRegDOB.TabStop = False
        ' 
        ' PictureBoxErrorRegFullName
        ' 
        PictureBoxErrorRegFullName.BackColor = Color.Transparent
        PictureBoxErrorRegFullName.Image = My.Resources.Resources.icons8_cancel_20
        PictureBoxErrorRegFullName.Location = New Point(440, 93)
        PictureBoxErrorRegFullName.Name = "PictureBoxErrorRegFullName"
        PictureBoxErrorRegFullName.Size = New Size(20, 20)
        PictureBoxErrorRegFullName.TabIndex = 24
        PictureBoxErrorRegFullName.TabStop = False
        ' 
        ' PictureBoxErrorRegPhoneNo
        ' 
        PictureBoxErrorRegPhoneNo.BackColor = Color.Transparent
        PictureBoxErrorRegPhoneNo.Image = My.Resources.Resources.icons8_cancel_20
        PictureBoxErrorRegPhoneNo.Location = New Point(440, 161)
        PictureBoxErrorRegPhoneNo.Name = "PictureBoxErrorRegPhoneNo"
        PictureBoxErrorRegPhoneNo.Size = New Size(20, 20)
        PictureBoxErrorRegPhoneNo.TabIndex = 25
        PictureBoxErrorRegPhoneNo.TabStop = False
        ' 
        ' PictureBoxErrorRegGender
        ' 
        PictureBoxErrorRegGender.BackColor = Color.Transparent
        PictureBoxErrorRegGender.Image = My.Resources.Resources.icons8_cancel_20
        PictureBoxErrorRegGender.Location = New Point(440, 278)
        PictureBoxErrorRegGender.Name = "PictureBoxErrorRegGender"
        PictureBoxErrorRegGender.Size = New Size(20, 20)
        PictureBoxErrorRegGender.TabIndex = 27
        PictureBoxErrorRegGender.TabStop = False
        ' 
        ' PictureBoxErrorRegDOB
        ' 
        PictureBoxErrorRegDOB.BackColor = Color.Transparent
        PictureBoxErrorRegDOB.Image = My.Resources.Resources.icons8_cancel_20
        PictureBoxErrorRegDOB.Location = New Point(440, 349)
        PictureBoxErrorRegDOB.Name = "PictureBoxErrorRegDOB"
        PictureBoxErrorRegDOB.Size = New Size(20, 20)
        PictureBoxErrorRegDOB.TabIndex = 28
        PictureBoxErrorRegDOB.TabStop = False
        ' 
        ' PictureBoxErrorRegEmail
        ' 
        PictureBoxErrorRegEmail.BackColor = Color.Transparent
        PictureBoxErrorRegEmail.Image = My.Resources.Resources.icons8_cancel_20
        PictureBoxErrorRegEmail.Location = New Point(440, 428)
        PictureBoxErrorRegEmail.Name = "PictureBoxErrorRegEmail"
        PictureBoxErrorRegEmail.Size = New Size(20, 20)
        PictureBoxErrorRegEmail.TabIndex = 30
        PictureBoxErrorRegEmail.TabStop = False
        ' 
        ' PictureBoxErrorRegPassword
        ' 
        PictureBoxErrorRegPassword.BackColor = Color.Transparent
        PictureBoxErrorRegPassword.Image = My.Resources.Resources.icons8_cancel_20
        PictureBoxErrorRegPassword.Location = New Point(440, 523)
        PictureBoxErrorRegPassword.Name = "PictureBoxErrorRegPassword"
        PictureBoxErrorRegPassword.Size = New Size(20, 20)
        PictureBoxErrorRegPassword.TabIndex = 31
        PictureBoxErrorRegPassword.TabStop = False
        ' 
        ' FormRegister
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(540, 655)
        Controls.Add(PictureBoxErrorRegPassword)
        Controls.Add(PictureBoxErrorRegEmail)
        Controls.Add(PictureBoxErrorRegDOB)
        Controls.Add(PictureBoxErrorRegGender)
        Controls.Add(PictureBoxErrorRegPhoneNo)
        Controls.Add(PictureBoxErrorRegFullName)
        Controls.Add(PictureBoxRegDOB)
        Controls.Add(PictureBoxRegPassword)
        Controls.Add(PictureBoxRegEmail)
        Controls.Add(PictureBoxRegPhoneNo)
        Controls.Add(PictureBoxRegFullName)
        Controls.Add(LabelDOB)
        Controls.Add(LabelRegisteration)
        Controls.Add(LabelGender)
        Controls.Add(ButtonRegister)
        Controls.Add(DateTimePickerDOB)
        Controls.Add(RadioButtonFemale)
        Controls.Add(RadioButtonMale)
        Controls.Add(TextBoxRegEmail)
        Controls.Add(TextBoxRegPassword)
        Controls.Add(TextBoxRegFullName)
        Controls.Add(TextBoxRegPhoneNo)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "FormRegister"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormRegister"
        CType(PictureBoxRegFullName, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxRegPhoneNo, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxRegEmail, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxRegPassword, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxRegDOB, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxErrorRegFullName, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxErrorRegPhoneNo, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxErrorRegGender, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxErrorRegDOB, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxErrorRegEmail, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxErrorRegPassword, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TextBoxRegPhoneNo As TextBox
    Friend WithEvents TextBoxRegFullName As TextBox
    Friend WithEvents TextBoxRegPassword As TextBox
    Friend WithEvents TextBoxRegEmail As TextBox
    Friend WithEvents RadioButtonMale As RadioButton
    Friend WithEvents RadioButtonFemale As RadioButton
    Friend WithEvents DateTimePickerDOB As DateTimePicker
    Friend WithEvents ButtonRegister As Button
    Friend WithEvents LabelGender As Label
    Friend WithEvents LabelRegisteration As Label
    Friend WithEvents LabelDOB As Label
    Friend WithEvents PictureBoxRegFullName As PictureBox
    Friend WithEvents PictureBoxRegPhoneNo As PictureBox
    Friend WithEvents PictureBoxRegEmail As PictureBox
    Friend WithEvents PictureBoxRegPassword As PictureBox
    Friend WithEvents PictureBoxRegDOB As PictureBox
    Friend WithEvents PictureBoxErrorRegFullName As PictureBox
    Friend WithEvents PictureBoxErrorRegPhoneNo As PictureBox
    Friend WithEvents PictureBoxErrorRegGender As PictureBox
    Friend WithEvents PictureBoxErrorRegDOB As PictureBox
    Friend WithEvents PictureBoxErrorRegEmail As PictureBox
    Friend WithEvents PictureBoxErrorRegPassword As PictureBox
End Class
