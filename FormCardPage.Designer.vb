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
        PictureBoxCardTemplate = New PictureBox()
        Panel1 = New Panel()
        PanelDetails = New Panel()
        LabelQuantityError = New Label()
        LabelContent2 = New Label()
        LabelContent = New Label()
        LabelRsDiscount = New Label()
        LabelRsMRP = New Label()
        Label2 = New Label()
        LabelPrice = New Label()
        ButtonBuyNow = New Button()
        LabelName = New Label()
        RichTextBoxContent = New RichTextBox()
        LabelQuantity = New Label()
        TextBoxQuantity = New TextBox()
        LabelMRP = New Label()
        LabelDiscountedPrice = New Label()
        PictureBoxBack = New PictureBox()
        CType(PictureBoxCardTemplate, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        PanelDetails.SuspendLayout()
        CType(PictureBoxBack, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBoxCardTemplate
        ' 
        PictureBoxCardTemplate.BackColor = Color.White
        PictureBoxCardTemplate.Image = My.Resources.Resources.icons8_user_male_50
        PictureBoxCardTemplate.Location = New Point(38, 43)
        PictureBoxCardTemplate.Name = "PictureBoxCardTemplate"
        PictureBoxCardTemplate.Size = New Size(360, 530)
        PictureBoxCardTemplate.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxCardTemplate.TabIndex = 0
        PictureBoxCardTemplate.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gainsboro
        Panel1.Controls.Add(PanelDetails)
        Panel1.Controls.Add(PictureBoxCardTemplate)
        Panel1.Location = New Point(84, 88)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1082, 617)
        Panel1.TabIndex = 12
        ' 
        ' PanelDetails
        ' 
        PanelDetails.BackColor = Color.White
        PanelDetails.Controls.Add(LabelQuantityError)
        PanelDetails.Controls.Add(LabelContent2)
        PanelDetails.Controls.Add(LabelContent)
        PanelDetails.Controls.Add(LabelRsDiscount)
        PanelDetails.Controls.Add(LabelRsMRP)
        PanelDetails.Controls.Add(Label2)
        PanelDetails.Controls.Add(LabelPrice)
        PanelDetails.Controls.Add(ButtonBuyNow)
        PanelDetails.Controls.Add(LabelName)
        PanelDetails.Controls.Add(RichTextBoxContent)
        PanelDetails.Controls.Add(LabelQuantity)
        PanelDetails.Controls.Add(TextBoxQuantity)
        PanelDetails.Controls.Add(LabelMRP)
        PanelDetails.Controls.Add(LabelDiscountedPrice)
        PanelDetails.Location = New Point(456, 43)
        PanelDetails.Name = "PanelDetails"
        PanelDetails.Size = New Size(577, 540)
        PanelDetails.TabIndex = 1
        ' 
        ' LabelQuantityError
        ' 
        LabelQuantityError.AutoSize = True
        LabelQuantityError.Font = New Font("Constantia", 11F, FontStyle.Bold, GraphicsUnit.Point)
        LabelQuantityError.ForeColor = Color.FromArgb(CByte(208), CByte(0), CByte(0))
        LabelQuantityError.Location = New Point(211, 233)
        LabelQuantityError.Name = "LabelQuantityError"
        LabelQuantityError.Size = New Size(190, 18)
        LabelQuantityError.TabIndex = 27
        LabelQuantityError.Text = "SORRY! Only 45 units left"' 
        ' LabelContent2
        ' 
        LabelContent2.AutoSize = True
        LabelContent2.Font = New Font("Constantia", 11F, FontStyle.Bold, GraphicsUnit.Point)
        LabelContent2.Location = New Point(209, 275)
        LabelContent2.Name = "LabelContent2"
        LabelContent2.Size = New Size(240, 18)
        LabelContent2.TabIndex = 26
        LabelContent2.Text = "( You can edit the content here )"' 
        ' LabelContent
        ' 
        LabelContent.AutoSize = True
        LabelContent.Font = New Font("Azonix", 15F, FontStyle.Bold, GraphicsUnit.Point)
        LabelContent.Location = New Point(68, 275)
        LabelContent.Name = "LabelContent"
        LabelContent.Size = New Size(135, 20)
        LabelContent.TabIndex = 25
        LabelContent.Text = "Content "' 
        ' LabelRsDiscount
        ' 
        LabelRsDiscount.AutoSize = True
        LabelRsDiscount.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        LabelRsDiscount.ForeColor = Color.FromArgb(CByte(41), CByte(191), CByte(18))
        LabelRsDiscount.Location = New Point(327, 134)
        LabelRsDiscount.Name = "LabelRsDiscount"
        LabelRsDiscount.Size = New Size(25, 28)
        LabelRsDiscount.TabIndex = 24
        LabelRsDiscount.Text = "₹"' 
        ' LabelRsMRP
        ' 
        LabelRsMRP.AutoSize = True
        LabelRsMRP.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        LabelRsMRP.ForeColor = Color.FromArgb(CByte(41), CByte(191), CByte(18))
        LabelRsMRP.Location = New Point(192, 135)
        LabelRsMRP.Name = "LabelRsMRP"
        LabelRsMRP.Size = New Size(25, 28)
        LabelRsMRP.TabIndex = 23
        LabelRsMRP.Text = "₹"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(192, 151)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 22
        ' 
        ' LabelPrice
        ' 
        LabelPrice.AutoSize = True
        LabelPrice.Font = New Font("Azonix", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        LabelPrice.Location = New Point(68, 141)
        LabelPrice.Name = "LabelPrice"
        LabelPrice.Size = New Size(81, 21)
        LabelPrice.TabIndex = 21
        LabelPrice.Text = "Price"' 
        ' ButtonBuyNow
        ' 
        ButtonBuyNow.BackColor = Color.Black
        ButtonBuyNow.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonBuyNow.ForeColor = Color.White
        ButtonBuyNow.Location = New Point(177, 464)
        ButtonBuyNow.Name = "ButtonBuyNow"
        ButtonBuyNow.Size = New Size(211, 54)
        ButtonBuyNow.TabIndex = 20
        ButtonBuyNow.Text = "Buy Now"
        ButtonBuyNow.UseVisualStyleBackColor = False
        ' 
        ' LabelName
        ' 
        LabelName.AutoSize = True
        LabelName.Font = New Font("Azonix", 18F, FontStyle.Bold, GraphicsUnit.Point)
        LabelName.Location = New Point(68, 51)
        LabelName.MaximumSize = New Size(500, 0)
        LabelName.Name = "LabelName"
        LabelName.Size = New Size(88, 24)
        LabelName.TabIndex = 18
        LabelName.Text = "Name"' 
        ' RichTextBoxContent
        ' 
        RichTextBoxContent.Font = New Font("Aparajita", 14F, FontStyle.Bold, GraphicsUnit.Point)
        RichTextBoxContent.Location = New Point(68, 325)
        RichTextBoxContent.Name = "RichTextBoxContent"
        RichTextBoxContent.ScrollBars = RichTextBoxScrollBars.Vertical
        RichTextBoxContent.Size = New Size(458, 114)
        RichTextBoxContent.TabIndex = 19
        RichTextBoxContent.Text = ""' 
        ' LabelQuantity
        ' 
        LabelQuantity.AutoSize = True
        LabelQuantity.Font = New Font("Azonix", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        LabelQuantity.Location = New Point(68, 209)
        LabelQuantity.Name = "LabelQuantity"
        LabelQuantity.Size = New Size(131, 21)
        LabelQuantity.TabIndex = 13
        LabelQuantity.Text = "Quantity"' 
        ' TextBoxQuantity
        ' 
        TextBoxQuantity.Font = New Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxQuantity.Location = New Point(228, 201)
        TextBoxQuantity.Name = "TextBoxQuantity"
        TextBoxQuantity.Size = New Size(160, 29)
        TextBoxQuantity.TabIndex = 15
        ' 
        ' LabelMRP
        ' 
        LabelMRP.AutoSize = True
        LabelMRP.Font = New Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMRP.ForeColor = Color.FromArgb(CByte(41), CByte(191), CByte(18))
        LabelMRP.Location = New Point(211, 135)
        LabelMRP.Name = "LabelMRP"
        LabelMRP.Size = New Size(64, 29)
        LabelMRP.TabIndex = 12
        LabelMRP.Text = "MRP"' 
        ' LabelDiscountedPrice
        ' 
        LabelDiscountedPrice.AutoSize = True
        LabelDiscountedPrice.Font = New Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point)
        LabelDiscountedPrice.ForeColor = Color.FromArgb(CByte(41), CByte(191), CByte(18))
        LabelDiscountedPrice.Location = New Point(349, 135)
        LabelDiscountedPrice.Name = "LabelDiscountedPrice"
        LabelDiscountedPrice.Size = New Size(108, 29)
        LabelDiscountedPrice.TabIndex = 16
        LabelDiscountedPrice.Text = "Discount"' 
        ' PictureBoxBack
        ' 
        PictureBoxBack.BackColor = Color.Black
        PictureBoxBack.Image = My.Resources.Resources.icons8_back_arrow_501
        PictureBoxBack.Location = New Point(12, 12)
        PictureBoxBack.Name = "PictureBoxBack"
        PictureBoxBack.Size = New Size(71, 42)
        PictureBoxBack.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxBack.TabIndex = 54
        PictureBoxBack.TabStop = False
        ' 
        ' FormCardPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1234, 761)
        Controls.Add(PictureBoxBack)
        Controls.Add(Panel1)
        Name = "FormCardPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormCardPage"
        CType(PictureBoxCardTemplate, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        PanelDetails.ResumeLayout(False)
        PanelDetails.PerformLayout()
        CType(PictureBoxBack, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBoxCardTemplate As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBoxBack As PictureBox
    Friend WithEvents PanelDetails As Panel
    Friend WithEvents LabelName As Label
    Friend WithEvents RichTextBoxContent As RichTextBox
    Friend WithEvents LabelQuantity As Label
    Friend WithEvents LabelMRP As Label
    Friend WithEvents LabelDiscountedPrice As Label
    Friend WithEvents TextBoxQuantity As TextBox
    Friend WithEvents ButtonBuyNow As Button
    Friend WithEvents LabelRsDiscount As Label
    Friend WithEvents LabelRsMRP As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelPrice As Label
    Friend WithEvents LabelContent As Label
    Friend WithEvents LabelContent2 As Label
    Friend WithEvents LabelQuantityError As Label
End Class
