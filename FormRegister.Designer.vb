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
        TextBoxRegPhoneNo.Location = New Point(131, 191)
        TextBoxRegPhoneNo.Margin = New Padding(3, 4, 3, 4)
        TextBoxRegPhoneNo.Name = "TextBoxRegPhoneNo"
        TextBoxRegPhoneNo.PlaceholderText = "Phone No."
        TextBoxRegPhoneNo.Size = New Size(342, 56)
        TextBoxRegPhoneNo.TabIndex = 5
        ' 
        ' TextBoxRegFullName
        ' 
        TextBoxRegFullName.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxRegFullName.Location = New Point(134, 107)
        TextBoxRegFullName.Margin = New Padding(3, 4, 3, 4)
        TextBoxRegFullName.Name = "TextBoxRegFullName"
        TextBoxRegFullName.PlaceholderText = "Full Name"
        TextBoxRegFullName.Size = New Size(342, 56)
        TextBoxRegFullName.TabIndex = 6
        ' 
        ' TextBoxRegPassword
        ' 
        TextBoxRegPassword.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxRegPassword.Location = New Point(131, 679)
        TextBoxRegPassword.Margin = New Padding(3, 4, 3, 4)
        TextBoxRegPassword.Name = "TextBoxRegPassword"
        TextBoxRegPassword.PasswordChar = "*"c
        TextBoxRegPassword.PlaceholderText = "Password"
        TextBoxRegPassword.Size = New Size(342, 56)
        TextBoxRegPassword.TabIndex = 7
        ' 
        ' TextBoxRegEmail
        ' 
        TextBoxRegEmail.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxRegEmail.Location = New Point(131, 556)
        TextBoxRegEmail.Margin = New Padding(3, 4, 3, 4)
        TextBoxRegEmail.Name = "TextBoxRegEmail"
        TextBoxRegEmail.PlaceholderText = "Email"
        TextBoxRegEmail.Size = New Size(342, 56)
        TextBoxRegEmail.TabIndex = 8
        ' 
        ' RadioButtonMale
        ' 
        RadioButtonMale.AutoSize = True
        RadioButtonMale.Location = New Point(139, 373)
        RadioButtonMale.Margin = New Padding(3, 4, 3, 4)
        RadioButtonMale.Name = "RadioButtonMale"
        RadioButtonMale.Size = New Size(63, 24)
        RadioButtonMale.TabIndex = 9
        RadioButtonMale.TabStop = True
        RadioButtonMale.Text = "Male"
        RadioButtonMale.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonFemale
        ' 
        RadioButtonFemale.AutoSize = True
        RadioButtonFemale.Location = New Point(316, 373)
        RadioButtonFemale.Margin = New Padding(3, 4, 3, 4)
        RadioButtonFemale.Name = "RadioButtonFemale"
        RadioButtonFemale.Size = New Size(78, 24)
        RadioButtonFemale.TabIndex = 10
        RadioButtonFemale.TabStop = True
        RadioButtonFemale.Text = "Female"
        RadioButtonFemale.UseVisualStyleBackColor = True
        ' 
        ' DateTimePickerDOB
        ' 
        DateTimePickerDOB.Location = New Point(230, 465)
        DateTimePickerDOB.Margin = New Padding(3, 4, 3, 4)
        DateTimePickerDOB.Name = "DateTimePickerDOB"
        DateTimePickerDOB.Size = New Size(228, 27)
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
        ButtonRegister.Location = New Point(209, 768)
        ButtonRegister.Margin = New Padding(3, 4, 3, 4)
        ButtonRegister.Name = "ButtonRegister"
        ButtonRegister.Size = New Size(194, 67)
        ButtonRegister.TabIndex = 12
        ButtonRegister.Text = "Register"
        ButtonRegister.UseVisualStyleBackColor = False
        ' 
        ' LabelGender
        ' 
        LabelGender.AutoSize = True
        LabelGender.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        LabelGender.Location = New Point(131, 309)
        LabelGender.Name = "LabelGender"
        LabelGender.Size = New Size(104, 37)
        LabelGender.TabIndex = 14
        LabelGender.Text = "Gender"' 
        ' LabelRegisteration
        ' 
        LabelRegisteration.AutoSize = True
        LabelRegisteration.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        LabelRegisteration.Location = New Point(29, 25)
        LabelRegisteration.Name = "LabelRegisteration"
        LabelRegisteration.Size = New Size(257, 54)
        LabelRegisteration.TabIndex = 15
        LabelRegisteration.Text = "Registeration"' 
        ' LabelDOB
        ' 
        LabelDOB.AutoSize = True
        LabelDOB.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        LabelDOB.Location = New Point(131, 455)
        LabelDOB.Name = "LabelDOB"
        LabelDOB.Size = New Size(71, 37)
        LabelDOB.TabIndex = 16
        LabelDOB.Text = "DOB"
        LabelDOB.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBoxRegFullName
        ' 
        PictureBoxRegFullName.Image = My.Resources.Resources.icons8_customer_48
        PictureBoxRegFullName.Location = New Point(48, 101)
        PictureBoxRegFullName.Margin = New Padding(3, 4, 3, 4)
        PictureBoxRegFullName.Name = "PictureBoxRegFullName"
        PictureBoxRegFullName.Size = New Size(57, 67)
        PictureBoxRegFullName.TabIndex = 17
        PictureBoxRegFullName.TabStop = False
        ' 
        ' PictureBoxRegPhoneNo
        ' 
        PictureBoxRegPhoneNo.Image = My.Resources.Resources.icons8_phone_50
        PictureBoxRegPhoneNo.Location = New Point(48, 191)
        PictureBoxRegPhoneNo.Margin = New Padding(3, 4, 3, 4)
        PictureBoxRegPhoneNo.Name = "PictureBoxRegPhoneNo"
        PictureBoxRegPhoneNo.Size = New Size(57, 67)
        PictureBoxRegPhoneNo.TabIndex = 18
        PictureBoxRegPhoneNo.TabStop = False
        ' 
        ' PictureBoxRegEmail
        ' 
        PictureBoxRegEmail.Image = My.Resources.Resources.icons8_secured_letter_48
        PictureBoxRegEmail.Location = New Point(48, 556)
        PictureBoxRegEmail.Margin = New Padding(3, 4, 3, 4)
        PictureBoxRegEmail.Name = "PictureBoxRegEmail"
        PictureBoxRegEmail.Size = New Size(57, 67)
        PictureBoxRegEmail.TabIndex = 21
        PictureBoxRegEmail.TabStop = False
        ' 
        ' PictureBoxRegPassword
        ' 
        PictureBoxRegPassword.Image = My.Resources.Resources.icons8_protonmail_48
        PictureBoxRegPassword.Location = New Point(48, 679)
        PictureBoxRegPassword.Margin = New Padding(3, 4, 3, 4)
        PictureBoxRegPassword.Name = "PictureBoxRegPassword"
        PictureBoxRegPassword.Size = New Size(57, 67)
        PictureBoxRegPassword.TabIndex = 22
        PictureBoxRegPassword.TabStop = False
        ' 
        ' PictureBoxRegDOB
        ' 
        PictureBoxRegDOB.Image = My.Resources.Resources.icons8_birth_date_50
        PictureBoxRegDOB.Location = New Point(48, 443)
        PictureBoxRegDOB.Margin = New Padding(3, 4, 3, 4)
        PictureBoxRegDOB.Name = "PictureBoxRegDOB"
        PictureBoxRegDOB.Size = New Size(57, 67)
        PictureBoxRegDOB.TabIndex = 23
        PictureBoxRegDOB.TabStop = False
        ' 
        ' PictureBoxErrorRegFullName
        ' 
        PictureBoxErrorRegFullName.Image = My.Resources.Resources.icons8_cancel_20
        PictureBoxErrorRegFullName.Location = New Point(503, 124)
        PictureBoxErrorRegFullName.Margin = New Padding(3, 4, 3, 4)
        PictureBoxErrorRegFullName.Name = "PictureBoxErrorRegFullName"
        PictureBoxErrorRegFullName.Size = New Size(23, 27)
        PictureBoxErrorRegFullName.TabIndex = 24
        PictureBoxErrorRegFullName.TabStop = False
        ' 
        ' PictureBoxErrorRegPhoneNo
        ' 
        PictureBoxErrorRegPhoneNo.Image = My.Resources.Resources.icons8_cancel_20
        PictureBoxErrorRegPhoneNo.Location = New Point(503, 215)
        PictureBoxErrorRegPhoneNo.Margin = New Padding(3, 4, 3, 4)
        PictureBoxErrorRegPhoneNo.Name = "PictureBoxErrorRegPhoneNo"
        PictureBoxErrorRegPhoneNo.Size = New Size(23, 27)
        PictureBoxErrorRegPhoneNo.TabIndex = 25
        PictureBoxErrorRegPhoneNo.TabStop = False
        ' 
        ' PictureBoxErrorRegGender
        ' 
        PictureBoxErrorRegGender.Image = My.Resources.Resources.icons8_cancel_20
        PictureBoxErrorRegGender.Location = New Point(503, 370)
        PictureBoxErrorRegGender.Margin = New Padding(3, 4, 3, 4)
        PictureBoxErrorRegGender.Name = "PictureBoxErrorRegGender"
        PictureBoxErrorRegGender.Size = New Size(23, 27)
        PictureBoxErrorRegGender.TabIndex = 27
        PictureBoxErrorRegGender.TabStop = False
        ' 
        ' PictureBoxErrorRegDOB
        ' 
        PictureBoxErrorRegDOB.Image = My.Resources.Resources.icons8_cancel_20
        PictureBoxErrorRegDOB.Location = New Point(503, 465)
        PictureBoxErrorRegDOB.Margin = New Padding(3, 4, 3, 4)
        PictureBoxErrorRegDOB.Name = "PictureBoxErrorRegDOB"
        PictureBoxErrorRegDOB.Size = New Size(23, 27)
        PictureBoxErrorRegDOB.TabIndex = 28
        PictureBoxErrorRegDOB.TabStop = False
        ' 
        ' PictureBoxErrorRegEmail
        ' 
        PictureBoxErrorRegEmail.Image = My.Resources.Resources.icons8_cancel_20
        PictureBoxErrorRegEmail.Location = New Point(503, 570)
        PictureBoxErrorRegEmail.Margin = New Padding(3, 4, 3, 4)
        PictureBoxErrorRegEmail.Name = "PictureBoxErrorRegEmail"
        PictureBoxErrorRegEmail.Size = New Size(23, 27)
        PictureBoxErrorRegEmail.TabIndex = 30
        PictureBoxErrorRegEmail.TabStop = False
        ' 
        ' PictureBoxErrorRegPassword
        ' 
        PictureBoxErrorRegPassword.Image = My.Resources.Resources.icons8_cancel_20
        PictureBoxErrorRegPassword.Location = New Point(503, 697)
        PictureBoxErrorRegPassword.Margin = New Padding(3, 4, 3, 4)
        PictureBoxErrorRegPassword.Name = "PictureBoxErrorRegPassword"
        PictureBoxErrorRegPassword.Size = New Size(23, 27)
        PictureBoxErrorRegPassword.TabIndex = 31
        PictureBoxErrorRegPassword.TabStop = False
        ' 
        ' FormRegister
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(617, 873)
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
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
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
