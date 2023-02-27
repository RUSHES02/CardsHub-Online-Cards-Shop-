<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        PictureBoxErrorLogPassword = New PictureBox()
        PictureBoxErrorLogUsername = New PictureBox()
        LabelNewUser = New Label()
        LabelLogin = New Label()
        ButtonRegisterPage = New Button()
        ButtonLogin = New Button()
        PictureBoxLogPassword = New PictureBox()
        PictureBoxLogUsername = New PictureBox()
        TextBoxLogPassword = New TextBox()
        TextBoxLogUsername = New TextBox()
        PictureBoxLoginPage = New PictureBox()
        CType(PictureBoxErrorLogPassword, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxErrorLogUsername, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxLogPassword, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxLogUsername, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxLoginPage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBoxErrorLogPassword
        ' 
        PictureBoxErrorLogPassword.Image = My.Resources.Resources.icons8_cancel_20
        PictureBoxErrorLogPassword.Location = New Point(1001, 376)
        PictureBoxErrorLogPassword.Name = "PictureBoxErrorLogPassword"
        PictureBoxErrorLogPassword.Size = New Size(20, 20)
        PictureBoxErrorLogPassword.TabIndex = 21
        PictureBoxErrorLogPassword.TabStop = False
        ' 
        ' PictureBoxErrorLogUsername
        ' 
        PictureBoxErrorLogUsername.Image = My.Resources.Resources.icons8_cancel_20
        PictureBoxErrorLogUsername.Location = New Point(1001, 258)
        PictureBoxErrorLogUsername.Name = "PictureBoxErrorLogUsername"
        PictureBoxErrorLogUsername.Size = New Size(20, 20)
        PictureBoxErrorLogUsername.TabIndex = 20
        PictureBoxErrorLogUsername.TabStop = False
        ' 
        ' LabelNewUser
        ' 
        LabelNewUser.AutoSize = True
        LabelNewUser.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        LabelNewUser.Location = New Point(72, 400)
        LabelNewUser.Name = "LabelNewUser"
        LabelNewUser.Size = New Size(120, 30)
        LabelNewUser.TabIndex = 19
        LabelNewUser.Text = "New User??"' 
        ' LabelLogin
        ' 
        LabelLogin.AutoSize = True
        LabelLogin.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        LabelLogin.Location = New Point(625, 111)
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
        ButtonRegisterPage.Location = New Point(72, 433)
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
        ButtonLogin.Location = New Point(738, 445)
        ButtonLogin.Name = "ButtonLogin"
        ButtonLogin.Size = New Size(170, 50)
        ButtonLogin.TabIndex = 16
        ButtonLogin.Text = "Login"
        ButtonLogin.UseVisualStyleBackColor = False
        ' 
        ' PictureBoxLogPassword
        ' 
        PictureBoxLogPassword.Image = My.Resources.Resources.icons8_protonmail_48
        PictureBoxLogPassword.Location = New Point(609, 361)
        PictureBoxLogPassword.Name = "PictureBoxLogPassword"
        PictureBoxLogPassword.Size = New Size(50, 50)
        PictureBoxLogPassword.TabIndex = 15
        PictureBoxLogPassword.TabStop = False
        ' 
        ' PictureBoxLogUsername
        ' 
        PictureBoxLogUsername.Image = My.Resources.Resources.icons8_customer_48
        PictureBoxLogUsername.Location = New Point(609, 239)
        PictureBoxLogUsername.Name = "PictureBoxLogUsername"
        PictureBoxLogUsername.Size = New Size(50, 50)
        PictureBoxLogUsername.TabIndex = 14
        PictureBoxLogUsername.TabStop = False
        ' 
        ' TextBoxLogPassword
        ' 
        TextBoxLogPassword.Cursor = Cursors.Hand
        TextBoxLogPassword.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxLogPassword.Location = New Point(674, 365)
        TextBoxLogPassword.Name = "TextBoxLogPassword"
        TextBoxLogPassword.PasswordChar = "*"c
        TextBoxLogPassword.PlaceholderText = "Password"
        TextBoxLogPassword.Size = New Size(300, 46)
        TextBoxLogPassword.TabIndex = 13
        ' 
        ' TextBoxLogUsername
        ' 
        TextBoxLogUsername.Cursor = Cursors.Hand
        TextBoxLogUsername.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxLogUsername.Location = New Point(674, 243)
        TextBoxLogUsername.Name = "TextBoxLogUsername"
        TextBoxLogUsername.PlaceholderText = "Username"
        TextBoxLogUsername.Size = New Size(300, 46)
        TextBoxLogUsername.TabIndex = 12
        ' 
        ' PictureBoxLoginPage
        ' 
        PictureBoxLoginPage.Image = My.Resources.Resources.New_Year_gifts
        PictureBoxLoginPage.Location = New Point(1, -3)
        PictureBoxLoginPage.Name = "PictureBoxLoginPage"
        PictureBoxLoginPage.Size = New Size(571, 521)
        PictureBoxLoginPage.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxLoginPage.TabIndex = 11
        PictureBoxLoginPage.TabStop = False
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1044, 521)
        Controls.Add(PictureBoxErrorLogPassword)
        Controls.Add(PictureBoxErrorLogUsername)
        Controls.Add(LabelNewUser)
        Controls.Add(LabelLogin)
        Controls.Add(ButtonRegisterPage)
        Controls.Add(ButtonLogin)
        Controls.Add(PictureBoxLogPassword)
        Controls.Add(PictureBoxLogUsername)
        Controls.Add(TextBoxLogPassword)
        Controls.Add(TextBoxLogUsername)
        Controls.Add(PictureBoxLoginPage)
        Name = "FormLogin"
        Text = "z"
        CType(PictureBoxErrorLogPassword, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxErrorLogUsername, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxLogPassword, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxLogUsername, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxLoginPage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBoxErrorLogPassword As PictureBox
    Friend WithEvents PictureBoxErrorLogUsername As PictureBox
    Friend WithEvents LabelNewUser As Label
    Friend WithEvents LabelLogin As Label
    Friend WithEvents ButtonRegisterPage As Button
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents PictureBoxLogPassword As PictureBox
    Friend WithEvents PictureBoxLogUsername As PictureBox
    Friend WithEvents TextBoxLogPassword As TextBox
    Friend WithEvents TextBoxLogUsername As TextBox
    Friend WithEvents PictureBoxLoginPage As PictureBox
End Class
