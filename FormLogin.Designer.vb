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
        Me.PictureBoxErrorLogPassword = New System.Windows.Forms.PictureBox()
        Me.PictureBoxErrorLogUsername = New System.Windows.Forms.PictureBox()
        Me.LabelNewUser = New System.Windows.Forms.Label()
        Me.LabelLogin = New System.Windows.Forms.Label()
        Me.ButtonRegisterPage = New System.Windows.Forms.Button()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.PictureBoxLogPassword = New System.Windows.Forms.PictureBox()
        Me.PictureBoxLogUsername = New System.Windows.Forms.PictureBox()
        Me.TextBoxLogPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxLogUsername = New System.Windows.Forms.TextBox()
        Me.PictureBoxLoginPage = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxErrorLogPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxErrorLogUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxLogPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxLogUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxLoginPage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxErrorLogPassword
        '
        Me.PictureBoxErrorLogPassword.Image = Global.ShareMarket.My.Resources.Resources.icons8_cancel_20
        Me.PictureBoxErrorLogPassword.Location = New System.Drawing.Point(1001, 376)
        Me.PictureBoxErrorLogPassword.Name = "PictureBoxErrorLogPassword"
        Me.PictureBoxErrorLogPassword.Size = New System.Drawing.Size(20, 20)
        Me.PictureBoxErrorLogPassword.TabIndex = 21
        Me.PictureBoxErrorLogPassword.TabStop = False
        '
        'PictureBoxErrorLogUsername
        '
        Me.PictureBoxErrorLogUsername.Image = Global.ShareMarket.My.Resources.Resources.icons8_cancel_20
        Me.PictureBoxErrorLogUsername.Location = New System.Drawing.Point(1001, 258)
        Me.PictureBoxErrorLogUsername.Name = "PictureBoxErrorLogUsername"
        Me.PictureBoxErrorLogUsername.Size = New System.Drawing.Size(20, 20)
        Me.PictureBoxErrorLogUsername.TabIndex = 20
        Me.PictureBoxErrorLogUsername.TabStop = False
        '
        'LabelNewUser
        '
        Me.LabelNewUser.AutoSize = True
        Me.LabelNewUser.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelNewUser.Location = New System.Drawing.Point(72, 400)
        Me.LabelNewUser.Name = "LabelNewUser"
        Me.LabelNewUser.Size = New System.Drawing.Size(120, 30)
        Me.LabelNewUser.TabIndex = 19
        Me.LabelNewUser.Text = "New User??"
        '
        'LabelLogin
        '
        Me.LabelLogin.AutoSize = True
        Me.LabelLogin.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelLogin.Location = New System.Drawing.Point(625, 111)
        Me.LabelLogin.Name = "LabelLogin"
        Me.LabelLogin.Size = New System.Drawing.Size(99, 45)
        Me.LabelLogin.TabIndex = 18
        Me.LabelLogin.Text = "Login"
        '
        'ButtonRegisterPage
        '
        Me.ButtonRegisterPage.BackColor = System.Drawing.Color.Fuchsia
        Me.ButtonRegisterPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRegisterPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonRegisterPage.Font = New System.Drawing.Font("Sitka Banner", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonRegisterPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonRegisterPage.Location = New System.Drawing.Point(72, 433)
        Me.ButtonRegisterPage.Name = "ButtonRegisterPage"
        Me.ButtonRegisterPage.Size = New System.Drawing.Size(170, 50)
        Me.ButtonRegisterPage.TabIndex = 17
        Me.ButtonRegisterPage.Text = "Register"
        Me.ButtonRegisterPage.UseVisualStyleBackColor = False
        '
        'ButtonLogin
        '
        Me.ButtonLogin.BackColor = System.Drawing.Color.Blue
        Me.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonLogin.Font = New System.Drawing.Font("Sitka Banner", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonLogin.Location = New System.Drawing.Point(738, 445)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(170, 50)
        Me.ButtonLogin.TabIndex = 16
        Me.ButtonLogin.Text = "Login"
        Me.ButtonLogin.UseVisualStyleBackColor = False
        '
        'PictureBoxLogPassword
        '
        Me.PictureBoxLogPassword.Image = Global.ShareMarket.My.Resources.Resources.icons8_protonmail_48
        Me.PictureBoxLogPassword.Location = New System.Drawing.Point(609, 361)
        Me.PictureBoxLogPassword.Name = "PictureBoxLogPassword"
        Me.PictureBoxLogPassword.Size = New System.Drawing.Size(50, 50)
        Me.PictureBoxLogPassword.TabIndex = 15
        Me.PictureBoxLogPassword.TabStop = False
        '
        'PictureBoxLogUsername
        '
        Me.PictureBoxLogUsername.Image = Global.ShareMarket.My.Resources.Resources.icons8_username_50
        Me.PictureBoxLogUsername.Location = New System.Drawing.Point(609, 239)
        Me.PictureBoxLogUsername.Name = "PictureBoxLogUsername"
        Me.PictureBoxLogUsername.Size = New System.Drawing.Size(50, 50)
        Me.PictureBoxLogUsername.TabIndex = 14
        Me.PictureBoxLogUsername.TabStop = False
        '
        'TextBoxLogPassword
        '
        Me.TextBoxLogPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBoxLogPassword.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxLogPassword.Location = New System.Drawing.Point(674, 365)
        Me.TextBoxLogPassword.Name = "TextBoxLogPassword"
        Me.TextBoxLogPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxLogPassword.PlaceholderText = "Password"
        Me.TextBoxLogPassword.Size = New System.Drawing.Size(300, 46)
        Me.TextBoxLogPassword.TabIndex = 13
        '
        'TextBoxLogUsername
        '
        Me.TextBoxLogUsername.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBoxLogUsername.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxLogUsername.Location = New System.Drawing.Point(674, 243)
        Me.TextBoxLogUsername.Name = "TextBoxLogUsername"
        Me.TextBoxLogUsername.PlaceholderText = "Username"
        Me.TextBoxLogUsername.Size = New System.Drawing.Size(300, 46)
        Me.TextBoxLogUsername.TabIndex = 12
        '
        'PictureBoxLoginPage
        '
        Me.PictureBoxLoginPage.Image = Global.ShareMarket.My.Resources.Resources.stock_market_traders_data_provider_1000x1000
        Me.PictureBoxLoginPage.Location = New System.Drawing.Point(1, -3)
        Me.PictureBoxLoginPage.Name = "PictureBoxLoginPage"
        Me.PictureBoxLoginPage.Size = New System.Drawing.Size(571, 521)
        Me.PictureBoxLoginPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxLoginPage.TabIndex = 11
        Me.PictureBoxLoginPage.TabStop = False
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 521)
        Me.Controls.Add(Me.PictureBoxErrorLogPassword)
        Me.Controls.Add(Me.PictureBoxErrorLogUsername)
        Me.Controls.Add(Me.LabelNewUser)
        Me.Controls.Add(Me.LabelLogin)
        Me.Controls.Add(Me.ButtonRegisterPage)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.PictureBoxLogPassword)
        Me.Controls.Add(Me.PictureBoxLogUsername)
        Me.Controls.Add(Me.TextBoxLogPassword)
        Me.Controls.Add(Me.TextBoxLogUsername)
        Me.Controls.Add(Me.PictureBoxLoginPage)
        Me.Name = "FormLogin"
        Me.Text = "FormLogin"
        CType(Me.PictureBoxErrorLogPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxErrorLogUsername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxLogPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxLogUsername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxLoginPage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
