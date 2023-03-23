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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormRegister))
        ButtonBack = New Button()
        PictureBoxRegister = New PictureBox()
        PanelRegisterBackground = New Panel()
        PanelRegister = New Panel()
        PictureBoxFemale = New PictureBox()
        PictureBoxGenderMale = New PictureBox()
        PictureBoxRegFullName = New PictureBox()
        PictureBoxRegPhoneNo = New PictureBox()
        ButtonRegister = New Button()
        PictureBoxErrorRegPassword = New PictureBox()
        PictureBoxRegDOB = New PictureBox()
        PictureBoxErrorRegEmail = New PictureBox()
        PictureBoxRegEmail = New PictureBox()
        PictureBoxErrorRegDOB = New PictureBox()
        PictureBoxRegPassword = New PictureBox()
        PictureBoxErrorRegGender = New PictureBox()
        PictureBoxErrorRegPhoneNo = New PictureBox()
        LabelRegisteration = New Label()
        PictureBoxErrorRegFullName = New PictureBox()
        TextBoxRegFullName = New TextBox()
        TextBoxRegPassword = New TextBox()
        TextBoxRegEmail = New TextBox()
        DateTimePickerDOB = New DateTimePicker()
        TextBoxRegPhoneNo = New TextBox()
        LabelGender = New Label()
        RadioButtonFemale = New RadioButton()
        RadioButtonMale = New RadioButton()
        PictureBox1 = New PictureBox()
        CType(PictureBoxRegister, ComponentModel.ISupportInitialize).BeginInit()
        PanelRegisterBackground.SuspendLayout()
        PanelRegister.SuspendLayout()
        CType(PictureBoxFemale, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxGenderMale, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxRegFullName, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxRegPhoneNo, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxErrorRegPassword, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxRegDOB, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxErrorRegEmail, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxRegEmail, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxErrorRegDOB, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxRegPassword, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxErrorRegGender, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxErrorRegPhoneNo, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxErrorRegFullName, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ButtonBack
        ' 
        ButtonBack.ForeColor = Color.BlueViolet
        ButtonBack.Image = My.Resources.Resources.icons8_back_arrow_50
        ButtonBack.ImageAlign = ContentAlignment.MiddleLeft
        ButtonBack.Location = New Point(52, -1)
        ButtonBack.Name = "ButtonBack"
        ButtonBack.Size = New Size(65, 45)
        ButtonBack.TabIndex = 56
        ButtonBack.UseVisualStyleBackColor = True
        ' 
        ' PictureBoxRegister
        ' 
        PictureBoxRegister.Image = My.Resources.Resources.image_2023_03_21_014724189
        PictureBoxRegister.Location = New Point(608, 26)
        PictureBoxRegister.Name = "PictureBoxRegister"
        PictureBoxRegister.Size = New Size(549, 622)
        PictureBoxRegister.TabIndex = 25
        PictureBoxRegister.TabStop = False
        ' 
        ' PanelRegisterBackground
        ' 
        PanelRegisterBackground.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PanelRegisterBackground.BackColor = Color.White
        PanelRegisterBackground.Controls.Add(PanelRegister)
        PanelRegisterBackground.Controls.Add(PictureBoxRegister)
        PanelRegisterBackground.Controls.Add(PictureBox1)
        PanelRegisterBackground.Location = New Point(52, 50)
        PanelRegisterBackground.Name = "PanelRegisterBackground"
        PanelRegisterBackground.Size = New Size(1176, 660)
        PanelRegisterBackground.TabIndex = 59
        ' 
        ' PanelRegister
        ' 
        PanelRegister.BackColor = Color.FromArgb(CByte(191), CByte(215), CByte(255))
        PanelRegister.Controls.Add(PictureBoxFemale)
        PanelRegister.Controls.Add(PictureBoxGenderMale)
        PanelRegister.Controls.Add(PictureBoxRegFullName)
        PanelRegister.Controls.Add(PictureBoxRegPhoneNo)
        PanelRegister.Controls.Add(ButtonRegister)
        PanelRegister.Controls.Add(PictureBoxErrorRegPassword)
        PanelRegister.Controls.Add(PictureBoxRegDOB)
        PanelRegister.Controls.Add(PictureBoxErrorRegEmail)
        PanelRegister.Controls.Add(PictureBoxRegEmail)
        PanelRegister.Controls.Add(PictureBoxErrorRegDOB)
        PanelRegister.Controls.Add(PictureBoxRegPassword)
        PanelRegister.Controls.Add(PictureBoxErrorRegGender)
        PanelRegister.Controls.Add(PictureBoxErrorRegPhoneNo)
        PanelRegister.Controls.Add(LabelRegisteration)
        PanelRegister.Controls.Add(PictureBoxErrorRegFullName)
        PanelRegister.Controls.Add(TextBoxRegFullName)
        PanelRegister.Controls.Add(TextBoxRegPassword)
        PanelRegister.Controls.Add(TextBoxRegEmail)
        PanelRegister.Controls.Add(DateTimePickerDOB)
        PanelRegister.Controls.Add(TextBoxRegPhoneNo)
        PanelRegister.Controls.Add(LabelGender)
        PanelRegister.Controls.Add(RadioButtonFemale)
        PanelRegister.Controls.Add(RadioButtonMale)
        PanelRegister.Location = New Point(39, 58)
        PanelRegister.Name = "PanelRegister"
        PanelRegister.Size = New Size(547, 567)
        PanelRegister.TabIndex = 58
        ' 
        ' PictureBoxFemale
        ' 
        PictureBoxFemale.BackColor = Color.Transparent
        PictureBoxFemale.Image = My.Resources.Resources.icons8_female_user_50
        PictureBoxFemale.Location = New Point(268, 416)
        PictureBoxFemale.Name = "PictureBoxFemale"
        PictureBoxFemale.Size = New Size(40, 36)
        PictureBoxFemale.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxFemale.TabIndex = 57
        PictureBoxFemale.TabStop = False
        ' 
        ' PictureBoxGenderMale
        ' 
        PictureBoxGenderMale.BackColor = Color.Transparent
        PictureBoxGenderMale.Image = My.Resources.Resources.icons8_user_male_50
        PictureBoxGenderMale.Location = New Point(122, 417)
        PictureBoxGenderMale.Name = "PictureBoxGenderMale"
        PictureBoxGenderMale.Size = New Size(40, 36)
        PictureBoxGenderMale.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxGenderMale.TabIndex = 56
        PictureBoxGenderMale.TabStop = False
        ' 
        ' PictureBoxRegFullName
        ' 
        PictureBoxRegFullName.BackColor = Color.Transparent
        PictureBoxRegFullName.Image = My.Resources.Resources.icons8_user_50
        PictureBoxRegFullName.Location = New Point(40, 79)
        PictureBoxRegFullName.Name = "PictureBoxRegFullName"
        PictureBoxRegFullName.Size = New Size(40, 36)
        PictureBoxRegFullName.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxRegFullName.TabIndex = 45
        PictureBoxRegFullName.TabStop = False
        ' 
        ' PictureBoxRegPhoneNo
        ' 
        PictureBoxRegPhoneNo.BackColor = Color.Transparent
        PictureBoxRegPhoneNo.Image = My.Resources.Resources.icons8_phone_50
        PictureBoxRegPhoneNo.Location = New Point(43, 149)
        PictureBoxRegPhoneNo.Name = "PictureBoxRegPhoneNo"
        PictureBoxRegPhoneNo.Size = New Size(35, 37)
        PictureBoxRegPhoneNo.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxRegPhoneNo.TabIndex = 46
        PictureBoxRegPhoneNo.TabStop = False
        ' 
        ' ButtonRegister
        ' 
        ButtonRegister.BackColor = Color.FromArgb(CByte(37), CByte(65), CByte(178))
        ButtonRegister.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ButtonRegister.FlatStyle = FlatStyle.Popup
        ButtonRegister.Font = New Font("Sitka Banner", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonRegister.ForeColor = SystemColors.ButtonHighlight
        ButtonRegister.Location = New Point(170, 499)
        ButtonRegister.Name = "ButtonRegister"
        ButtonRegister.Size = New Size(170, 50)
        ButtonRegister.TabIndex = 41
        ButtonRegister.Text = "Register"
        ButtonRegister.UseVisualStyleBackColor = False
        ' 
        ' PictureBoxErrorRegPassword
        ' 
        PictureBoxErrorRegPassword.BackColor = Color.Transparent
        PictureBoxErrorRegPassword.Image = CType(resources.GetObject("PictureBoxErrorRegPassword.Image"), Image)
        PictureBoxErrorRegPassword.Location = New Point(465, 372)
        PictureBoxErrorRegPassword.Name = "PictureBoxErrorRegPassword"
        PictureBoxErrorRegPassword.Size = New Size(20, 20)
        PictureBoxErrorRegPassword.TabIndex = 55
        PictureBoxErrorRegPassword.TabStop = False
        ' 
        ' PictureBoxRegDOB
        ' 
        PictureBoxRegDOB.BackColor = Color.Transparent
        PictureBoxRegDOB.Image = CType(resources.GetObject("PictureBoxRegDOB.Image"), Image)
        PictureBoxRegDOB.Location = New Point(40, 217)
        PictureBoxRegDOB.Name = "PictureBoxRegDOB"
        PictureBoxRegDOB.Size = New Size(38, 37)
        PictureBoxRegDOB.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxRegDOB.TabIndex = 49
        PictureBoxRegDOB.TabStop = False
        ' 
        ' PictureBoxErrorRegEmail
        ' 
        PictureBoxErrorRegEmail.BackColor = Color.Transparent
        PictureBoxErrorRegEmail.Image = CType(resources.GetObject("PictureBoxErrorRegEmail.Image"), Image)
        PictureBoxErrorRegEmail.Location = New Point(465, 301)
        PictureBoxErrorRegEmail.Name = "PictureBoxErrorRegEmail"
        PictureBoxErrorRegEmail.Size = New Size(20, 20)
        PictureBoxErrorRegEmail.TabIndex = 54
        PictureBoxErrorRegEmail.TabStop = False
        ' 
        ' PictureBoxRegEmail
        ' 
        PictureBoxRegEmail.BackColor = Color.Transparent
        PictureBoxRegEmail.Image = My.Resources.Resources.icons8_mail_50
        PictureBoxRegEmail.Location = New Point(38, 285)
        PictureBoxRegEmail.Name = "PictureBoxRegEmail"
        PictureBoxRegEmail.Size = New Size(40, 36)
        PictureBoxRegEmail.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxRegEmail.TabIndex = 47
        PictureBoxRegEmail.TabStop = False
        ' 
        ' PictureBoxErrorRegDOB
        ' 
        PictureBoxErrorRegDOB.BackColor = Color.Transparent
        PictureBoxErrorRegDOB.Image = CType(resources.GetObject("PictureBoxErrorRegDOB.Image"), Image)
        PictureBoxErrorRegDOB.Location = New Point(465, 225)
        PictureBoxErrorRegDOB.Name = "PictureBoxErrorRegDOB"
        PictureBoxErrorRegDOB.Size = New Size(20, 20)
        PictureBoxErrorRegDOB.TabIndex = 53
        PictureBoxErrorRegDOB.TabStop = False
        ' 
        ' PictureBoxRegPassword
        ' 
        PictureBoxRegPassword.BackColor = Color.Transparent
        PictureBoxRegPassword.Image = My.Resources.Resources.icons8_private_lock_50
        PictureBoxRegPassword.Location = New Point(40, 356)
        PictureBoxRegPassword.Name = "PictureBoxRegPassword"
        PictureBoxRegPassword.Size = New Size(40, 36)
        PictureBoxRegPassword.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxRegPassword.TabIndex = 48
        PictureBoxRegPassword.TabStop = False
        ' 
        ' PictureBoxErrorRegGender
        ' 
        PictureBoxErrorRegGender.BackColor = Color.Transparent
        PictureBoxErrorRegGender.Image = CType(resources.GetObject("PictureBoxErrorRegGender.Image"), Image)
        PictureBoxErrorRegGender.Location = New Point(465, 428)
        PictureBoxErrorRegGender.Name = "PictureBoxErrorRegGender"
        PictureBoxErrorRegGender.Size = New Size(20, 20)
        PictureBoxErrorRegGender.TabIndex = 52
        PictureBoxErrorRegGender.TabStop = False
        ' 
        ' PictureBoxErrorRegPhoneNo
        ' 
        PictureBoxErrorRegPhoneNo.BackColor = Color.Transparent
        PictureBoxErrorRegPhoneNo.Image = CType(resources.GetObject("PictureBoxErrorRegPhoneNo.Image"), Image)
        PictureBoxErrorRegPhoneNo.Location = New Point(465, 150)
        PictureBoxErrorRegPhoneNo.Name = "PictureBoxErrorRegPhoneNo"
        PictureBoxErrorRegPhoneNo.Size = New Size(20, 20)
        PictureBoxErrorRegPhoneNo.TabIndex = 51
        PictureBoxErrorRegPhoneNo.TabStop = False
        ' 
        ' LabelRegisteration
        ' 
        LabelRegisteration.AutoSize = True
        LabelRegisteration.Font = New Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        LabelRegisteration.ForeColor = Color.FromArgb(CByte(3), CByte(37), CByte(108))
        LabelRegisteration.Location = New Point(101, 16)
        LabelRegisteration.Name = "LabelRegisteration"
        LabelRegisteration.Size = New Size(271, 35)
        LabelRegisteration.TabIndex = 43
        LabelRegisteration.Text = "REGISTRATION"' 
        ' PictureBoxErrorRegFullName
        ' 
        PictureBoxErrorRegFullName.BackColor = Color.Transparent
        PictureBoxErrorRegFullName.Image = CType(resources.GetObject("PictureBoxErrorRegFullName.Image"), Image)
        PictureBoxErrorRegFullName.Location = New Point(465, 79)
        PictureBoxErrorRegFullName.Name = "PictureBoxErrorRegFullName"
        PictureBoxErrorRegFullName.Size = New Size(20, 20)
        PictureBoxErrorRegFullName.TabIndex = 50
        PictureBoxErrorRegFullName.TabStop = False
        ' 
        ' TextBoxRegFullName
        ' 
        TextBoxRegFullName.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxRegFullName.Location = New Point(101, 79)
        TextBoxRegFullName.Name = "TextBoxRegFullName"
        TextBoxRegFullName.PlaceholderText = "Full Name"
        TextBoxRegFullName.Size = New Size(300, 36)
        TextBoxRegFullName.TabIndex = 35
        ' 
        ' TextBoxRegPassword
        ' 
        TextBoxRegPassword.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxRegPassword.Location = New Point(101, 356)
        TextBoxRegPassword.Name = "TextBoxRegPassword"
        TextBoxRegPassword.PasswordChar = "*"c
        TextBoxRegPassword.PlaceholderText = "Password"
        TextBoxRegPassword.Size = New Size(300, 36)
        TextBoxRegPassword.TabIndex = 36
        ' 
        ' TextBoxRegEmail
        ' 
        TextBoxRegEmail.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxRegEmail.Location = New Point(101, 285)
        TextBoxRegEmail.Name = "TextBoxRegEmail"
        TextBoxRegEmail.PlaceholderText = "Email"
        TextBoxRegEmail.Size = New Size(300, 36)
        TextBoxRegEmail.TabIndex = 37
        ' 
        ' DateTimePickerDOB
        ' 
        DateTimePickerDOB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePickerDOB.Location = New Point(101, 225)
        DateTimePickerDOB.Name = "DateTimePickerDOB"
        DateTimePickerDOB.Size = New Size(300, 29)
        DateTimePickerDOB.TabIndex = 40
        DateTimePickerDOB.Value = New DateTime(2005, 1, 1, 0, 0, 0, 0)
        ' 
        ' TextBoxRegPhoneNo
        ' 
        TextBoxRegPhoneNo.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxRegPhoneNo.Location = New Point(101, 150)
        TextBoxRegPhoneNo.Name = "TextBoxRegPhoneNo"
        TextBoxRegPhoneNo.PlaceholderText = "Phone No."
        TextBoxRegPhoneNo.Size = New Size(300, 36)
        TextBoxRegPhoneNo.TabIndex = 34
        ' 
        ' LabelGender
        ' 
        LabelGender.AutoSize = True
        LabelGender.BackColor = Color.Transparent
        LabelGender.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        LabelGender.ForeColor = Color.FromArgb(CByte(3), CByte(37), CByte(108))
        LabelGender.Location = New Point(38, 424)
        LabelGender.Name = "LabelGender"
        LabelGender.Size = New Size(78, 25)
        LabelGender.TabIndex = 42
        LabelGender.Text = "Gender"' 
        ' RadioButtonFemale
        ' 
        RadioButtonFemale.AutoSize = True
        RadioButtonFemale.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        RadioButtonFemale.ForeColor = Color.FromArgb(CByte(3), CByte(37), CByte(108))
        RadioButtonFemale.Location = New Point(314, 423)
        RadioButtonFemale.Name = "RadioButtonFemale"
        RadioButtonFemale.Size = New Size(90, 29)
        RadioButtonFemale.TabIndex = 39
        RadioButtonFemale.TabStop = True
        RadioButtonFemale.Text = "Female"
        RadioButtonFemale.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonMale
        ' 
        RadioButtonMale.AutoSize = True
        RadioButtonMale.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        RadioButtonMale.ForeColor = Color.FromArgb(CByte(3), CByte(37), CByte(108))
        RadioButtonMale.Location = New Point(170, 424)
        RadioButtonMale.Name = "RadioButtonMale"
        RadioButtonMale.Size = New Size(72, 29)
        RadioButtonMale.TabIndex = 38
        RadioButtonMale.TabStop = True
        RadioButtonMale.Text = "Male"
        RadioButtonMale.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox1.Image = My.Resources.Resources.image_2023_03_21_014724189
        PictureBox1.Location = New Point(2562, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(563, 654)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 24
        PictureBox1.TabStop = False
        ' 
        ' FormRegister
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(120), CByte(139), CByte(255))
        ClientSize = New Size(1280, 757)
        Controls.Add(PanelRegisterBackground)
        Controls.Add(ButtonBack)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "FormRegister"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormRegister"
        CType(PictureBoxRegister, ComponentModel.ISupportInitialize).EndInit()
        PanelRegisterBackground.ResumeLayout(False)
        PanelRegister.ResumeLayout(False)
        PanelRegister.PerformLayout()
        CType(PictureBoxFemale, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxGenderMale, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxRegFullName, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxRegPhoneNo, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxErrorRegPassword, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxRegDOB, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxErrorRegEmail, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxRegEmail, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxErrorRegDOB, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxRegPassword, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxErrorRegGender, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxErrorRegPhoneNo, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxErrorRegFullName, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents ButtonBack As Button
    Friend WithEvents PictureBoxRegister As PictureBox
    Friend WithEvents PanelRegisterBackground As Panel
    Friend WithEvents PanelRegister As Panel
    Friend WithEvents PictureBoxRegFullName As PictureBox
    Friend WithEvents PictureBoxRegPhoneNo As PictureBox
    Friend WithEvents PictureBoxErrorRegPassword As PictureBox
    Friend WithEvents PictureBoxRegDOB As PictureBox
    Friend WithEvents PictureBoxErrorRegEmail As PictureBox
    Friend WithEvents PictureBoxRegEmail As PictureBox
    Friend WithEvents PictureBoxErrorRegDOB As PictureBox
    Friend WithEvents PictureBoxRegPassword As PictureBox
    Friend WithEvents PictureBoxErrorRegGender As PictureBox
    Friend WithEvents ButtonRegister As Button
    Friend WithEvents PictureBoxErrorRegPhoneNo As PictureBox
    Friend WithEvents LabelRegisteration As Label
    Friend WithEvents PictureBoxErrorRegFullName As PictureBox
    Friend WithEvents TextBoxRegFullName As TextBox
    Friend WithEvents TextBoxRegPassword As TextBox
    Friend WithEvents TextBoxRegEmail As TextBox
    Friend WithEvents DateTimePickerDOB As DateTimePicker
    Friend WithEvents TextBoxRegPhoneNo As TextBox
    Friend WithEvents LabelGender As Label
    Friend WithEvents RadioButtonFemale As RadioButton
    Friend WithEvents RadioButtonMale As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBoxFemale As PictureBox
    Friend WithEvents PictureBoxGenderMale As PictureBox
End Class
