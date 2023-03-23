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
        LabelWelcome = New Label()
        PanelLoginBackground = New Panel()
        PictureBoxLogin = New PictureBox()
        PictureBox1 = New PictureBox()
        GroupBoxLogin = New GroupBox()
        LabelNew = New Label()
        LabelCreateAccount = New Label()
        ButtonLogin = New Button()
        LabelNewUser = New Label()
        PictureBoxErrorLogPassword = New PictureBox()
        LabelLogin = New Label()
        TextBoxLogPassword = New TextBox()
        PictureBoxErrorLogEmail = New PictureBox()
        TextBoxLogEmail = New TextBox()
        PictureBoxLogUsername = New PictureBox()
        PictureBoxLogPassword = New PictureBox()
        PanelLoginBackground.SuspendLayout()
        CType(PictureBoxLogin, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBoxLogin.SuspendLayout()
        CType(PictureBoxErrorLogPassword, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxErrorLogEmail, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxLogUsername, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxLogPassword, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LabelWelcome
        ' 
        LabelWelcome.AutoSize = True
        LabelWelcome.Font = New Font("Castellar", 50.25F, FontStyle.Bold, GraphicsUnit.Point)
        LabelWelcome.ForeColor = Color.FromArgb(CByte(3), CByte(37), CByte(108))
        LabelWelcome.Location = New Point(456, 36)
        LabelWelcome.Name = "LabelWelcome"
        LabelWelcome.Size = New Size(414, 81)
        LabelWelcome.TabIndex = 25
        LabelWelcome.Text = "WELCOME"' 
        ' PanelLoginBackground
        ' 
        PanelLoginBackground.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PanelLoginBackground.BackColor = Color.White
        PanelLoginBackground.Controls.Add(PictureBoxLogin)
        PanelLoginBackground.Controls.Add(PictureBox1)
        PanelLoginBackground.Controls.Add(GroupBoxLogin)
        PanelLoginBackground.Location = New Point(49, 83)
        PanelLoginBackground.Name = "PanelLoginBackground"
        PanelLoginBackground.Size = New Size(1176, 628)
        PanelLoginBackground.TabIndex = 26
        ' 
        ' PictureBoxLogin
        ' 
        PictureBoxLogin.Image = My.Resources.Resources.image_2023_03_21_014724189
        PictureBoxLogin.Location = New Point(592, 32)
        PictureBoxLogin.Name = "PictureBoxLogin"
        PictureBoxLogin.Size = New Size(549, 596)
        PictureBoxLogin.TabIndex = 25
        PictureBoxLogin.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox1.Image = My.Resources.Resources.image_2023_03_21_014724189
        PictureBox1.Location = New Point(1586, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(563, 654)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 24
        PictureBox1.TabStop = False
        ' 
        ' GroupBoxLogin
        ' 
        GroupBoxLogin.BackColor = Color.FromArgb(CByte(191), CByte(215), CByte(255))
        GroupBoxLogin.Controls.Add(LabelNew)
        GroupBoxLogin.Controls.Add(LabelCreateAccount)
        GroupBoxLogin.Controls.Add(ButtonLogin)
        GroupBoxLogin.Controls.Add(LabelNewUser)
        GroupBoxLogin.Controls.Add(PictureBoxErrorLogPassword)
        GroupBoxLogin.Controls.Add(LabelLogin)
        GroupBoxLogin.Controls.Add(TextBoxLogPassword)
        GroupBoxLogin.Controls.Add(PictureBoxErrorLogEmail)
        GroupBoxLogin.Controls.Add(TextBoxLogEmail)
        GroupBoxLogin.Controls.Add(PictureBoxLogUsername)
        GroupBoxLogin.Controls.Add(PictureBoxLogPassword)
        GroupBoxLogin.ForeColor = SystemColors.ControlText
        GroupBoxLogin.Location = New Point(96, 87)
        GroupBoxLogin.Name = "GroupBoxLogin"
        GroupBoxLogin.Size = New Size(444, 458)
        GroupBoxLogin.TabIndex = 23
        GroupBoxLogin.TabStop = False
        ' 
        ' LabelNew
        ' 
        LabelNew.AutoSize = True
        LabelNew.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelNew.Location = New Point(71, 396)
        LabelNew.Name = "LabelNew"
        LabelNew.Size = New Size(94, 21)
        LabelNew.TabIndex = 23
        LabelNew.Text = "New User ?"' 
        ' LabelCreateAccount
        ' 
        LabelCreateAccount.AutoSize = True
        LabelCreateAccount.Font = New Font("Segoe UI", 11F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        LabelCreateAccount.ForeColor = Color.DarkBlue
        LabelCreateAccount.Location = New Point(255, 396)
        LabelCreateAccount.Name = "LabelCreateAccount"
        LabelCreateAccount.Size = New Size(116, 20)
        LabelCreateAccount.TabIndex = 22
        LabelCreateAccount.Text = "Create Account"' 
        ' ButtonLogin
        ' 
        ButtonLogin.BackColor = Color.FromArgb(CByte(37), CByte(65), CByte(178))
        ButtonLogin.Cursor = Cursors.Hand
        ButtonLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ButtonLogin.FlatStyle = FlatStyle.Popup
        ButtonLogin.Font = New Font("Sitka Banner", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonLogin.ForeColor = SystemColors.ButtonHighlight
        ButtonLogin.Location = New Point(71, 342)
        ButtonLogin.Name = "ButtonLogin"
        ButtonLogin.Size = New Size(300, 50)
        ButtonLogin.TabIndex = 16
        ButtonLogin.Text = "Login"
        ButtonLogin.UseVisualStyleBackColor = False
        ' 
        ' LabelNewUser
        ' 
        LabelNewUser.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        LabelNewUser.AutoSize = True
        LabelNewUser.BackColor = Color.Transparent
        LabelNewUser.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        LabelNewUser.Location = New Point(428, 752)
        LabelNewUser.Name = "LabelNewUser"
        LabelNewUser.Size = New Size(95, 25)
        LabelNewUser.TabIndex = 19
        LabelNewUser.Text = "New User?"' 
        ' PictureBoxErrorLogPassword
        ' 
        PictureBoxErrorLogPassword.BackColor = Color.Transparent
        PictureBoxErrorLogPassword.Image = My.Resources.Resources.icons8_cancel_20
        PictureBoxErrorLogPassword.Location = New Point(413, 233)
        PictureBoxErrorLogPassword.Name = "PictureBoxErrorLogPassword"
        PictureBoxErrorLogPassword.Size = New Size(20, 20)
        PictureBoxErrorLogPassword.TabIndex = 21
        PictureBoxErrorLogPassword.TabStop = False
        ' 
        ' LabelLogin
        ' 
        LabelLogin.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelLogin.AutoSize = True
        LabelLogin.BackColor = Color.Transparent
        LabelLogin.Font = New Font("Copperplate Gothic Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        LabelLogin.ForeColor = Color.FromArgb(CByte(3), CByte(37), CByte(108))
        LabelLogin.Location = New Point(155, 19)
        LabelLogin.Name = "LabelLogin"
        LabelLogin.Size = New Size(136, 41)
        LabelLogin.TabIndex = 18
        LabelLogin.Text = "Login"' 
        ' TextBoxLogPassword
        ' 
        TextBoxLogPassword.Cursor = Cursors.Hand
        TextBoxLogPassword.Font = New Font("Poor Richard", 24F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxLogPassword.Location = New Point(95, 218)
        TextBoxLogPassword.Name = "TextBoxLogPassword"
        TextBoxLogPassword.PasswordChar = "*"c
        TextBoxLogPassword.PlaceholderText = "Password"
        TextBoxLogPassword.Size = New Size(300, 44)
        TextBoxLogPassword.TabIndex = 13
        ' 
        ' PictureBoxErrorLogEmail
        ' 
        PictureBoxErrorLogEmail.BackColor = Color.Transparent
        PictureBoxErrorLogEmail.Image = My.Resources.Resources.icons8_cancel_20
        PictureBoxErrorLogEmail.Location = New Point(413, 133)
        PictureBoxErrorLogEmail.Name = "PictureBoxErrorLogEmail"
        PictureBoxErrorLogEmail.Size = New Size(20, 20)
        PictureBoxErrorLogEmail.TabIndex = 20
        PictureBoxErrorLogEmail.TabStop = False
        ' 
        ' TextBoxLogEmail
        ' 
        TextBoxLogEmail.Cursor = Cursors.Hand
        TextBoxLogEmail.Font = New Font("Poor Richard", 24F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxLogEmail.Location = New Point(95, 123)
        TextBoxLogEmail.Name = "TextBoxLogEmail"
        TextBoxLogEmail.PlaceholderText = "Email"
        TextBoxLogEmail.Size = New Size(300, 44)
        TextBoxLogEmail.TabIndex = 12
        ' 
        ' PictureBoxLogUsername
        ' 
        PictureBoxLogUsername.BackColor = Color.Transparent
        PictureBoxLogUsername.Image = My.Resources.Resources.icons8_mail_50
        PictureBoxLogUsername.Location = New Point(30, 123)
        PictureBoxLogUsername.Name = "PictureBoxLogUsername"
        PictureBoxLogUsername.Size = New Size(50, 50)
        PictureBoxLogUsername.TabIndex = 14
        PictureBoxLogUsername.TabStop = False
        ' 
        ' PictureBoxLogPassword
        ' 
        PictureBoxLogPassword.BackColor = Color.Transparent
        PictureBoxLogPassword.Image = My.Resources.Resources.icons8_private_lock_50
        PictureBoxLogPassword.Location = New Point(30, 214)
        PictureBoxLogPassword.Name = "PictureBoxLogPassword"
        PictureBoxLogPassword.Size = New Size(50, 50)
        PictureBoxLogPassword.TabIndex = 15
        PictureBoxLogPassword.TabStop = False
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(120), CByte(139), CByte(255))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1280, 755)
        Controls.Add(PanelLoginBackground)
        Controls.Add(LabelWelcome)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "FormLogin"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "CARDS-HUB"
        PanelLoginBackground.ResumeLayout(False)
        CType(PictureBoxLogin, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBoxLogin.ResumeLayout(False)
        GroupBoxLogin.PerformLayout()
        CType(PictureBoxErrorLogPassword, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxErrorLogEmail, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxLogUsername, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxLogPassword, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelWelcome As Label
    Friend WithEvents PanelLoginBackground As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBoxLogin As GroupBox
    Friend WithEvents LabelCreateAccount As Label
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents LabelNewUser As Label
    Friend WithEvents PictureBoxErrorLogPassword As PictureBox
    Friend WithEvents LabelLogin As Label
    Friend WithEvents TextBoxLogPassword As TextBox
    Friend WithEvents PictureBoxErrorLogEmail As PictureBox
    Friend WithEvents TextBoxLogEmail As TextBox
    Friend WithEvents PictureBoxLogUsername As PictureBox
    Friend WithEvents PictureBoxLogPassword As PictureBox
    Friend WithEvents PictureBoxLogin As PictureBox
    Friend WithEvents LabelNew As Label
End Class
