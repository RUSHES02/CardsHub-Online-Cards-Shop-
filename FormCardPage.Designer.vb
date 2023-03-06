<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCardPage
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
        PictureBox1 = New PictureBox()
        ComboBoxQuantity = New ComboBox()
        LabelPrice = New Label()
        LabelQuantity = New Label()
        ButtonBack = New Button()
        ButtonBuyNow = New Button()
        LabelDescription = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Invite_1
        PictureBox1.Location = New Point(209, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(300, 427)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' ComboBoxQuantity
        ' 
        ComboBoxQuantity.FormattingEnabled = True
        ComboBoxQuantity.Location = New Point(137, 461)
        ComboBoxQuantity.Name = "ComboBoxQuantity"
        ComboBoxQuantity.Size = New Size(173, 23)
        ComboBoxQuantity.TabIndex = 1
        ' 
        ' LabelPrice
        ' 
        LabelPrice.AutoSize = True
        LabelPrice.Location = New Point(525, 464)
        LabelPrice.Name = "LabelPrice"
        LabelPrice.Size = New Size(41, 15)
        LabelPrice.TabIndex = 2
        LabelPrice.Text = "Label1"' 
        ' LabelQuantity
        ' 
        LabelQuantity.AutoSize = True
        LabelQuantity.Location = New Point(39, 469)
        LabelQuantity.Name = "LabelQuantity"
        LabelQuantity.Size = New Size(53, 15)
        LabelQuantity.TabIndex = 3
        LabelQuantity.Text = "Quantity"' 
        ' ButtonBack
        ' 
        ButtonBack.Location = New Point(12, 12)
        ButtonBack.Name = "ButtonBack"
        ButtonBack.Size = New Size(133, 33)
        ButtonBack.TabIndex = 4
        ButtonBack.Text = "Back"
        ButtonBack.UseVisualStyleBackColor = True
        ' 
        ' ButtonBuyNow
        ' 
        ButtonBuyNow.Location = New Point(268, 749)
        ButtonBuyNow.Name = "ButtonBuyNow"
        ButtonBuyNow.Size = New Size(203, 61)
        ButtonBuyNow.TabIndex = 5
        ButtonBuyNow.Text = "Buy Now"
        ButtonBuyNow.UseVisualStyleBackColor = True
        ' 
        ' LabelDescription
        ' 
        LabelDescription.AutoSize = True
        LabelDescription.Location = New Point(38, 586)
        LabelDescription.Name = "LabelDescription"
        LabelDescription.Size = New Size(67, 15)
        LabelDescription.TabIndex = 6
        LabelDescription.Text = "Description"' 
        ' FormCardPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(725, 861)
        Controls.Add(LabelDescription)
        Controls.Add(ButtonBuyNow)
        Controls.Add(ButtonBack)
        Controls.Add(LabelQuantity)
        Controls.Add(LabelPrice)
        Controls.Add(ComboBoxQuantity)
        Controls.Add(PictureBox1)
        Name = "FormCardPage"
        Text = "FormCardPage"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBoxQuantity As ComboBox
    Friend WithEvents LabelPrice As Label
    Friend WithEvents LabelQuantity As Label
    Friend WithEvents ButtonBack As Button
    Friend WithEvents ButtonBuyNow As Button
    Friend WithEvents LabelDescription As Label
End Class
