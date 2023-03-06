<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PictureBoxErrorLogPassword = New PictureBox()
        PictureBoxErrorLogEmail = New PictureBox()
        LabelNewUser = New Label()
        LabelLogin = New Label()
        ButtonRegisterPage = New Button()
        ButtonLogin = New Button()
        PictureBoxLogPassword = New PictureBox()
        PictureBoxLogUsername = New PictureBox()
        TextBoxLogPassword = New TextBox()
        TextBoxLogEmail = New TextBox()
        CType(PictureBoxErrorLogPassword, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxErrorLogEmail, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxLogPassword, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxLogUsername, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBoxErrorLogPassword
        ' 
        PictureBoxErrorLogPassword.BackColor = Color.Transparent
        PictureBoxErrorLogPassword.Image = My.Resources.Resources.icons8_cancel_20
        PictureBoxErrorLogPassword.Location = New Point(483, 312)
        PictureBoxErrorLogPassword.Name = "PictureBoxErrorLogPassword"
        PictureBoxErrorLogPassword.Size = New Size(20, 20)
        PictureBoxErrorLogPassword.TabIndex = 21
        PictureBoxErrorLogPassword.TabStop = False
        ' 
        ' PictureBoxErrorLogEmail
        ' 
        PictureBoxErrorLogEmail.BackColor = Color.Transparent
        PictureBoxErrorLogEmail.Image = My.Resources.Resources.icons8_cancel_20
        PictureBoxErrorLogEmail.Location = New Point(483, 215)
        PictureBoxErrorLogEmail.Name = "PictureBoxErrorLogEmail"
        PictureBoxErrorLogEmail.Size = New Size(20, 20)
        PictureBoxErrorLogEmail.TabIndex = 20
        PictureBoxErrorLogEmail.TabStop = False
        ' 
        ' LabelNewUser
        ' 
        LabelNewUser.AutoSize = True
        LabelNewUser.BackColor = Color.Transparent
        LabelNewUser.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        LabelNewUser.Location = New Point(844, 406)
        LabelNewUser.Name = "LabelNewUser"
        LabelNewUser.Size = New Size(120, 30)
        LabelNewUser.TabIndex = 19
        LabelNewUser.Text = "New User??"' 
        ' LabelLogin
        ' 
        LabelLogin.AutoSize = True
        LabelLogin.BackColor = Color.Transparent
        LabelLogin.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        LabelLogin.Location = New Point(84, 76)
        LabelLogin.Name = "LabelLogin"
        LabelLogin.Size = New Size(99, 45)
        LabelLogin.TabIndex = 18
        LabelLogin.Text = "Login"' 
        ' ButtonRegisterPage
        ' 
        ButtonRegisterPage.BackColor = Color.Fuchsia
        ButtonRegisterPage.Cursor = Cursors.Hand
        ButtonRegisterPage.FlatStyle = FlatStyle.Popup
        ButtonRegisterPage.Font = New Font("Sitka Banner", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonRegisterPage.ForeColor = SystemColors.ButtonHighlight
        ButtonRegisterPage.Location = New Point(844, 439)
        ButtonRegisterPage.Name = "ButtonRegisterPage"
        ButtonRegisterPage.Size = New Size(170, 50)
        ButtonRegisterPage.TabIndex = 17
        ButtonRegisterPage.Text = "Register"
        ButtonRegisterPage.UseVisualStyleBackColor = False
        ' 
        ' ButtonLogin
        ' 
        ButtonLogin.BackColor = Color.Blue
        ButtonLogin.Cursor = Cursors.Hand
        ButtonLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ButtonLogin.FlatStyle = FlatStyle.Popup
        ButtonLogin.Font = New Font("Sitka Banner", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonLogin.ForeColor = SystemColors.ButtonHighlight
        ButtonLogin.Location = New Point(164, 439)
        ButtonLogin.Name = "ButtonLogin"
        ButtonLogin.Size = New Size(170, 50)
        ButtonLogin.TabIndex = 16
        ButtonLogin.Text = "Login"
        ButtonLogin.UseVisualStyleBackColor = False
        ' 
        ' PictureBoxLogPassword
        ' 
        PictureBoxLogPassword.BackColor = Color.Transparent
        PictureBoxLogPassword.Image = My.Resources.Resources.icons8_protonmail_48
        PictureBoxLogPassword.Location = New Point(58, 302)
        PictureBoxLogPassword.Name = "PictureBoxLogPassword"
        PictureBoxLogPassword.Size = New Size(50, 50)
        PictureBoxLogPassword.TabIndex = 15
        PictureBoxLogPassword.TabStop = False
        ' 
        ' PictureBoxLogUsername
        ' 
        PictureBoxLogUsername.BackColor = Color.Transparent
        PictureBoxLogUsername.Image = My.Resources.Resources.icons8_secured_letter_48
        PictureBoxLogUsername.Location = New Point(58, 197)
        PictureBoxLogUsername.Name = "PictureBoxLogUsername"
        PictureBoxLogUsername.Size = New Size(50, 50)
        PictureBoxLogUsername.TabIndex = 14
        PictureBoxLogUsername.TabStop = False
        ' 
        ' TextBoxLogPassword
        ' 
        TextBoxLogPassword.Cursor = Cursors.Hand
        TextBoxLogPassword.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxLogPassword.Location = New Point(137, 302)
        TextBoxLogPassword.Name = "TextBoxLogPassword"
        TextBoxLogPassword.PasswordChar = "*"c
        TextBoxLogPassword.PlaceholderText = "Password"
        TextBoxLogPassword.Size = New Size(300, 46)
        TextBoxLogPassword.TabIndex = 13
        ' 
        ' TextBoxLogEmail
        ' 
        TextBoxLogEmail.Cursor = Cursors.Hand
        TextBoxLogEmail.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxLogEmail.Location = New Point(137, 201)
        TextBoxLogEmail.Name = "TextBoxLogEmail"
        TextBoxLogEmail.PlaceholderText = "Gmail"
        TextBoxLogEmail.Size = New Size(300, 46)
        TextBoxLogEmail.TabIndex = 12
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.New_Year_gifts
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1064, 521)
        Controls.Add(PictureBoxErrorLogPassword)
        Controls.Add(PictureBoxErrorLogEmail)
        Controls.Add(LabelNewUser)
        Controls.Add(LabelLogin)
        Controls.Add(ButtonRegisterPage)
        Controls.Add(ButtonLogin)
        Controls.Add(PictureBoxLogPassword)
        Controls.Add(PictureBoxLogUsername)
        Controls.Add(TextBoxLogPassword)
        Controls.Add(TextBoxLogEmail)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "FormLogin"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormLogin"
        CType(PictureBoxErrorLogPassword, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxErrorLogEmail, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxLogPassword, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxLogUsername, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBoxErrorLogPassword As PictureBox
    Friend WithEvents PictureBoxErrorLogEmail As PictureBox
    Friend WithEvents LabelNewUser As Label
    Friend WithEvents LabelLogin As Label
    Friend WithEvents ButtonRegisterPage As Button
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents PictureBoxLogPassword As PictureBox
    Friend WithEvents PictureBoxLogUsername As PictureBox
    Friend WithEvents TextBoxLogPassword As TextBox
    Friend WithEvents TextBoxLogEmail As TextBox
End Class
