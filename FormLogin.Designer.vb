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
        TextBoxLogEmail = New TextBox()
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
        PictureBoxErrorLogPassword.Location = New Point(1144, 501)
        PictureBoxErrorLogPassword.Margin = New Padding(3, 4, 3, 4)
        PictureBoxErrorLogPassword.Name = "PictureBoxErrorLogPassword"
        PictureBoxErrorLogPassword.Size = New Size(23, 27)
        PictureBoxErrorLogPassword.TabIndex = 21
        PictureBoxErrorLogPassword.TabStop = False
        ' 
        ' PictureBoxErrorLogUsername
        ' 
        PictureBoxErrorLogUsername.Image = My.Resources.Resources.icons8_cancel_20
        PictureBoxErrorLogUsername.Location = New Point(1144, 344)
        PictureBoxErrorLogUsername.Margin = New Padding(3, 4, 3, 4)
        PictureBoxErrorLogUsername.Name = "PictureBoxErrorLogUsername"
        PictureBoxErrorLogUsername.Size = New Size(23, 27)
        PictureBoxErrorLogUsername.TabIndex = 20
        PictureBoxErrorLogUsername.TabStop = False
        ' 
        ' LabelNewUser
        ' 
        LabelNewUser.AutoSize = True
        LabelNewUser.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        LabelNewUser.Location = New Point(82, 533)
        LabelNewUser.Name = "LabelNewUser"
        LabelNewUser.Size = New Size(155, 37)
        LabelNewUser.TabIndex = 19
        LabelNewUser.Text = "New User??"' 
        ' LabelLogin
        ' 
        LabelLogin.AutoSize = True
        LabelLogin.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        LabelLogin.Location = New Point(714, 148)
        LabelLogin.Name = "LabelLogin"
        LabelLogin.Size = New Size(122, 54)
        LabelLogin.TabIndex = 18
        LabelLogin.Text = "Login"' 
        ' ButtonRegisterPage
        ' 
        ButtonRegisterPage.BackColor = Color.Fuchsia
        ButtonRegisterPage.Cursor = Cursors.Hand
        ButtonRegisterPage.FlatStyle = FlatStyle.Popup
        ButtonRegisterPage.Font = New Font("Sitka Banner", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonRegisterPage.ForeColor = SystemColors.ButtonHighlight
        ButtonRegisterPage.Location = New Point(82, 577)
        ButtonRegisterPage.Margin = New Padding(3, 4, 3, 4)
        ButtonRegisterPage.Name = "ButtonRegisterPage"
        ButtonRegisterPage.Size = New Size(194, 67)
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
        ButtonLogin.Location = New Point(843, 593)
        ButtonLogin.Margin = New Padding(3, 4, 3, 4)
        ButtonLogin.Name = "ButtonLogin"
        ButtonLogin.Size = New Size(194, 67)
        ButtonLogin.TabIndex = 16
        ButtonLogin.Text = "Login"
        ButtonLogin.UseVisualStyleBackColor = False
        ' 
        ' PictureBoxLogPassword
        ' 
        PictureBoxLogPassword.Image = My.Resources.Resources.icons8_protonmail_48
        PictureBoxLogPassword.Location = New Point(696, 481)
        PictureBoxLogPassword.Margin = New Padding(3, 4, 3, 4)
        PictureBoxLogPassword.Name = "PictureBoxLogPassword"
        PictureBoxLogPassword.Size = New Size(57, 67)
        PictureBoxLogPassword.TabIndex = 15
        PictureBoxLogPassword.TabStop = False
        ' 
        ' PictureBoxLogUsername
        ' 
        PictureBoxLogUsername.Image = My.Resources.Resources.icons8_username_50
        PictureBoxLogUsername.Location = New Point(696, 319)
        PictureBoxLogUsername.Margin = New Padding(3, 4, 3, 4)
        PictureBoxLogUsername.Name = "PictureBoxLogUsername"
        PictureBoxLogUsername.Size = New Size(57, 67)
        PictureBoxLogUsername.TabIndex = 14
        PictureBoxLogUsername.TabStop = False
        ' 
        ' TextBoxLogPassword
        ' 
        TextBoxLogPassword.Cursor = Cursors.Hand
        TextBoxLogPassword.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxLogPassword.Location = New Point(770, 487)
        TextBoxLogPassword.Margin = New Padding(3, 4, 3, 4)
        TextBoxLogPassword.Name = "TextBoxLogPassword"
        TextBoxLogPassword.PasswordChar = "*"c
        TextBoxLogPassword.PlaceholderText = "Password"
        TextBoxLogPassword.Size = New Size(342, 56)
        TextBoxLogPassword.TabIndex = 13
        ' 
        ' TextBoxLogEmail
        ' 
        TextBoxLogEmail.Cursor = Cursors.Hand
        TextBoxLogEmail.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxLogEmail.Location = New Point(770, 324)
        TextBoxLogEmail.Margin = New Padding(3, 4, 3, 4)
        TextBoxLogEmail.Name = "TextBoxLogEmail"
        TextBoxLogEmail.PlaceholderText = "Gmail"
        TextBoxLogEmail.Size = New Size(342, 56)
        TextBoxLogEmail.TabIndex = 12
        ' 
        ' PictureBoxLoginPage
        ' 
        PictureBoxLoginPage.Image = My.Resources.Resources.stock_market_traders_data_provider_1000x1000
        PictureBoxLoginPage.Location = New Point(1, -4)
        PictureBoxLoginPage.Margin = New Padding(3, 4, 3, 4)
        PictureBoxLoginPage.Name = "PictureBoxLoginPage"
        PictureBoxLoginPage.Size = New Size(653, 695)
        PictureBoxLoginPage.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxLoginPage.TabIndex = 11
        PictureBoxLoginPage.TabStop = False
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1212, 748)
        Controls.Add(PictureBoxErrorLogPassword)
        Controls.Add(PictureBoxErrorLogUsername)
        Controls.Add(LabelNewUser)
        Controls.Add(LabelLogin)
        Controls.Add(ButtonRegisterPage)
        Controls.Add(ButtonLogin)
        Controls.Add(PictureBoxLogPassword)
        Controls.Add(PictureBoxLogUsername)
        Controls.Add(TextBoxLogPassword)
        Controls.Add(TextBoxLogEmail)
        Controls.Add(PictureBoxLoginPage)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormLogin"
        Text = "FormLogin"
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
    Friend WithEvents TextBoxLogEmail As TextBox
    Friend WithEvents PictureBoxLoginPage As PictureBox
End Class
