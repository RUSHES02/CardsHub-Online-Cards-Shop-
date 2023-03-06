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
        TextBoxPrice = New TextBox()
        TextBoxQuantity = New TextBox()
        LabelPrice = New Label()
        LabelQuantity = New Label()
        ButtonSave = New Button()
        ButtonBrowseImage = New Button()
        ComboBoxType = New ComboBox()
        LabelType = New Label()
        CType(PictureBoxImageTemplate, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' OpenFileDialogSelectCardTemplate
        ' 
        OpenFileDialogSelectCardTemplate.Filter = "(Images)|*.jpg;*.png"
        OpenFileDialogSelectCardTemplate.InitialDirectory = "C:\Users\Abhijaan Ganguly\OneDrive\Pictures\SE Project pics"
        OpenFileDialogSelectCardTemplate.Title = "Select Card Template"' 
        ' PictureBoxImageTemplate
        ' 
        PictureBoxImageTemplate.Image = My.Resources.Resources.Invite_1
        PictureBoxImageTemplate.Location = New Point(12, 28)
        PictureBoxImageTemplate.Name = "PictureBoxImageTemplate"
        PictureBoxImageTemplate.Size = New Size(332, 465)
        PictureBoxImageTemplate.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxImageTemplate.TabIndex = 0
        PictureBoxImageTemplate.TabStop = False
        ' 
        ' TextBoxPrice
        ' 
        TextBoxPrice.Location = New Point(623, 74)
        TextBoxPrice.Name = "TextBoxPrice"
        TextBoxPrice.Size = New Size(100, 23)
        TextBoxPrice.TabIndex = 1
        ' 
        ' TextBoxQuantity
        ' 
        TextBoxQuantity.Location = New Point(627, 144)
        TextBoxQuantity.Name = "TextBoxQuantity"
        TextBoxQuantity.Size = New Size(100, 23)
        TextBoxQuantity.TabIndex = 2
        ' 
        ' LabelPrice
        ' 
        LabelPrice.AutoSize = True
        LabelPrice.Location = New Point(544, 78)
        LabelPrice.Name = "LabelPrice"
        LabelPrice.Size = New Size(33, 15)
        LabelPrice.TabIndex = 3
        LabelPrice.Text = "Price"' 
        ' LabelQuantity
        ' 
        LabelQuantity.AutoSize = True
        LabelQuantity.Location = New Point(557, 146)
        LabelQuantity.Name = "LabelQuantity"
        LabelQuantity.Size = New Size(53, 15)
        LabelQuantity.TabIndex = 4
        LabelQuantity.Text = "Quantity"' 
        ' ButtonSave
        ' 
        ButtonSave.Location = New Point(800, 488)
        ButtonSave.Name = "ButtonSave"
        ButtonSave.Size = New Size(135, 49)
        ButtonSave.TabIndex = 5
        ButtonSave.Text = "Save"
        ButtonSave.UseVisualStyleBackColor = True
        ' 
        ' ButtonBrowseImage
        ' 
        ButtonBrowseImage.Location = New Point(105, 499)
        ButtonBrowseImage.Name = "ButtonBrowseImage"
        ButtonBrowseImage.Size = New Size(133, 49)
        ButtonBrowseImage.TabIndex = 6
        ButtonBrowseImage.Text = "Browse Image"
        ButtonBrowseImage.UseVisualStyleBackColor = True
        ' 
        ' ComboBoxType
        ' 
        ComboBoxType.FormattingEnabled = True
        ComboBoxType.Location = New Point(602, 210)
        ComboBoxType.Name = "ComboBoxType"
        ComboBoxType.Size = New Size(121, 23)
        ComboBoxType.TabIndex = 7
        ' 
        ' LabelType
        ' 
        LabelType.AutoSize = True
        LabelType.Location = New Point(510, 218)
        LabelType.Name = "LabelType"
        LabelType.Size = New Size(31, 15)
        LabelType.TabIndex = 8
        LabelType.Text = "Type"' 
        ' FormAdminCardEdit
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(980, 577)
        Controls.Add(LabelType)
        Controls.Add(ComboBoxType)
        Controls.Add(ButtonBrowseImage)
        Controls.Add(ButtonSave)
        Controls.Add(LabelQuantity)
        Controls.Add(LabelPrice)
        Controls.Add(TextBoxQuantity)
        Controls.Add(TextBoxPrice)
        Controls.Add(PictureBoxImageTemplate)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "FormAdminCardEdit"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormAdminCardEdit"
        CType(PictureBoxImageTemplate, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents OpenFileDialogSelectCardTemplate As OpenFileDialog
    Friend WithEvents PictureBoxImageTemplate As PictureBox
    Friend WithEvents TextBoxPrice As TextBox
    Friend WithEvents TextBoxQuantity As TextBox
    Friend WithEvents LabelPrice As Label
    Friend WithEvents LabelQuantity As Label
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonBrowseImage As Button
    Friend WithEvents ComboBoxType As ComboBox
    Friend WithEvents LabelType As Label
End Class
