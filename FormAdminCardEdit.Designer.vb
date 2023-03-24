<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdminCardEdit
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
        OpenFileDialogSelectCardTemplate = New OpenFileDialog()
        PictureBoxImageTemplate = New PictureBox()
        ButtonBrowseImage = New Button()
        Panel1 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        ButtonSave = New Button()
        ComboBoxType = New ComboBox()
        TextBoxQuantity = New TextBox()
        TextBoxPrice = New TextBox()
        TextBoxName = New TextBox()
        PictureBoxBack = New PictureBox()
        CType(PictureBoxImageTemplate, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBoxBack, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' OpenFileDialogSelectCardTemplate
        ' 
        OpenFileDialogSelectCardTemplate.Filter = "(Images)|*.jpg;*.png"
        OpenFileDialogSelectCardTemplate.InitialDirectory = "C:\Users\Abhijaan Ganguly\OneDrive\Pictures\SE Project pics"
        OpenFileDialogSelectCardTemplate.Title = "Select Card Template"' 
        ' PictureBoxImageTemplate
        ' 
        PictureBoxImageTemplate.BackColor = Color.White
        PictureBoxImageTemplate.Image = My.Resources.Resources.icons8_image_file_add_100
        PictureBoxImageTemplate.Location = New Point(63, 87)
        PictureBoxImageTemplate.Name = "PictureBoxImageTemplate"
        PictureBoxImageTemplate.Size = New Size(332, 465)
        PictureBoxImageTemplate.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxImageTemplate.TabIndex = 0
        PictureBoxImageTemplate.TabStop = False
        ' 
        ' ButtonBrowseImage
        ' 
        ButtonBrowseImage.BackColor = Color.Black
        ButtonBrowseImage.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonBrowseImage.ForeColor = Color.White
        ButtonBrowseImage.Location = New Point(120, 573)
        ButtonBrowseImage.Name = "ButtonBrowseImage"
        ButtonBrowseImage.Size = New Size(167, 57)
        ButtonBrowseImage.TabIndex = 6
        ButtonBrowseImage.Text = "Browse Image"
        ButtonBrowseImage.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(222), CByte(226), CByte(230))
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(ButtonSave)
        Panel1.Controls.Add(ComboBoxType)
        Panel1.Controls.Add(TextBoxQuantity)
        Panel1.Controls.Add(TextBoxPrice)
        Panel1.Controls.Add(TextBoxName)
        Panel1.Location = New Point(478, 86)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(545, 544)
        Panel1.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Azonix", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(82, 313)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 19)
        Label4.TabIndex = 63
        Label4.Text = "name"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Azonix", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(79, 228)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 19)
        Label3.TabIndex = 62
        Label3.Text = "Quantity"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Azonix", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(82, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 19)
        Label2.TabIndex = 61
        Label2.Text = "price"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Azonix", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(82, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 19)
        Label1.TabIndex = 60
        Label1.Text = "Card Type"' 
        ' ButtonSave
        ' 
        ButtonSave.BackColor = Color.Black
        ButtonSave.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonSave.ForeColor = Color.White
        ButtonSave.Location = New Point(203, 436)
        ButtonSave.Name = "ButtonSave"
        ButtonSave.Size = New Size(150, 54)
        ButtonSave.TabIndex = 59
        ButtonSave.Text = "SAVE"
        ButtonSave.UseVisualStyleBackColor = False
        ' 
        ' ComboBoxType
        ' 
        ComboBoxType.BackColor = SystemColors.ButtonHighlight
        ComboBoxType.Font = New Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBoxType.FormattingEnabled = True
        ComboBoxType.Location = New Point(233, 55)
        ComboBoxType.Name = "ComboBoxType"
        ComboBoxType.Size = New Size(207, 31)
        ComboBoxType.TabIndex = 58
        ' 
        ' TextBoxQuantity
        ' 
        TextBoxQuantity.BackColor = SystemColors.ButtonHighlight
        TextBoxQuantity.Font = New Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxQuantity.Location = New Point(233, 220)
        TextBoxQuantity.Name = "TextBoxQuantity"
        TextBoxQuantity.Size = New Size(137, 30)
        TextBoxQuantity.TabIndex = 57
        ' 
        ' TextBoxPrice
        ' 
        TextBoxPrice.BackColor = SystemColors.ButtonHighlight
        TextBoxPrice.Font = New Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxPrice.Location = New Point(233, 142)
        TextBoxPrice.Name = "TextBoxPrice"
        TextBoxPrice.Size = New Size(137, 30)
        TextBoxPrice.TabIndex = 56
        ' 
        ' TextBoxName
        ' 
        TextBoxName.BackColor = SystemColors.ButtonHighlight
        TextBoxName.Font = New Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxName.Location = New Point(233, 305)
        TextBoxName.Name = "TextBoxName"
        TextBoxName.Size = New Size(207, 30)
        TextBoxName.TabIndex = 55
        ' 
        ' PictureBoxBack
        ' 
        PictureBoxBack.BackColor = Color.Black
        PictureBoxBack.Image = My.Resources.Resources.icons8_back_arrow_501
        PictureBoxBack.Location = New Point(12, 7)
        PictureBoxBack.Name = "PictureBoxBack"
        PictureBoxBack.Size = New Size(75, 38)
        PictureBoxBack.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxBack.TabIndex = 54
        PictureBoxBack.TabStop = False
        ' 
        ' FormAdminCardEdit
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1089, 653)
        Controls.Add(PictureBoxBack)
        Controls.Add(PictureBoxImageTemplate)
        Controls.Add(ButtonBrowseImage)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "FormAdminCardEdit"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormAdminCardEdit"
        CType(PictureBoxImageTemplate, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBoxBack, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents OpenFileDialogSelectCardTemplate As OpenFileDialog
    Friend WithEvents PictureBoxImageTemplate As PictureBox
    Friend WithEvents ButtonBrowseImage As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBoxBack As PictureBox
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ComboBoxType As ComboBox
    Friend WithEvents TextBoxQuantity As TextBox
    Friend WithEvents TextBoxPrice As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
