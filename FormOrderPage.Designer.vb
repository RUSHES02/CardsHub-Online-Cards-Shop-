<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOrderPage
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormOrderPage))
        PanelOrderPageBackground = New Panel()
        PictureBoxErrorPincode = New PictureBox()
        PictureBoxErrorLandmark = New PictureBox()
        PictureBoxErrorAddress = New PictureBox()
        PictureBoxErrorCity = New PictureBox()
        PictureBoxErrorState = New PictureBox()
        PictureBoxErrorPhone = New PictureBox()
        PictureBoxErrorName = New PictureBox()
        TextBoxName = New TextBox()
        LabelPhoneno = New Label()
        LabelName = New Label()
        TextBoxPhoneNo = New TextBox()
        TextBoxAddress = New RichTextBox()
        LabelAddLine = New Label()
        ComboBoxState = New ComboBox()
        TextBoxCity = New TextBox()
        TextBoxPincode = New TextBox()
        LabelPinCode = New Label()
        TextBoxLandmark = New RichTextBox()
        LabelLandmark = New Label()
        LabelState = New Label()
        LabelCity = New Label()
        PanelPrice = New Panel()
        Label1 = New Label()
        LabelDeliveryCharge = New Label()
        LabelPayableAmount = New Label()
        LabelDiscountedPrice = New Label()
        LabelMRP = New Label()
        LabelTagPayableAmount = New Label()
        LabelTagDeliveryCharge = New Label()
        LabelTagDiscountPrice = New Label()
        LabelTagMRP = New Label()
        PanelPayment = New Panel()
        LabelUPIOrCard = New Label()
        TextBox1UPIOrCard = New TextBox()
        LabelTransactionMode = New Label()
        RadioButtonPOD = New RadioButton()
        RadioButtonUPI = New RadioButton()
        RadioButtonCard = New RadioButton()
        ButtonConfirmOrder = New Button()
        TimerDeliveryDate = New Timer(components)
        LabelOrderDetails = New Label()
        PictureBoxErrorPaymentMode = New PictureBox()
        PanelOrderPageBackground.SuspendLayout()
        CType(PictureBoxErrorPincode, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxErrorLandmark, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxErrorAddress, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxErrorCity, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxErrorState, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxErrorPhone, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxErrorName, ComponentModel.ISupportInitialize).BeginInit()
        PanelPrice.SuspendLayout()
        PanelPayment.SuspendLayout()
        CType(PictureBoxErrorPaymentMode, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelOrderPageBackground
        ' 
        PanelOrderPageBackground.BackColor = Color.White
        PanelOrderPageBackground.Controls.Add(PictureBoxErrorPincode)
        PanelOrderPageBackground.Controls.Add(PictureBoxErrorLandmark)
        PanelOrderPageBackground.Controls.Add(PictureBoxErrorAddress)
        PanelOrderPageBackground.Controls.Add(PictureBoxErrorCity)
        PanelOrderPageBackground.Controls.Add(PictureBoxErrorState)
        PanelOrderPageBackground.Controls.Add(PictureBoxErrorPhone)
        PanelOrderPageBackground.Controls.Add(PictureBoxErrorName)
        PanelOrderPageBackground.Controls.Add(TextBoxName)
        PanelOrderPageBackground.Controls.Add(LabelPhoneno)
        PanelOrderPageBackground.Controls.Add(LabelName)
        PanelOrderPageBackground.Controls.Add(TextBoxPhoneNo)
        PanelOrderPageBackground.Controls.Add(TextBoxAddress)
        PanelOrderPageBackground.Controls.Add(LabelAddLine)
        PanelOrderPageBackground.Controls.Add(ComboBoxState)
        PanelOrderPageBackground.Controls.Add(TextBoxCity)
        PanelOrderPageBackground.Controls.Add(TextBoxPincode)
        PanelOrderPageBackground.Controls.Add(LabelPinCode)
        PanelOrderPageBackground.Controls.Add(TextBoxLandmark)
        PanelOrderPageBackground.Controls.Add(LabelLandmark)
        PanelOrderPageBackground.Controls.Add(LabelState)
        PanelOrderPageBackground.Controls.Add(LabelCity)
        PanelOrderPageBackground.Controls.Add(PanelPrice)
        PanelOrderPageBackground.Controls.Add(PanelPayment)
        PanelOrderPageBackground.Controls.Add(ButtonConfirmOrder)
        PanelOrderPageBackground.Location = New Point(71, 68)
        PanelOrderPageBackground.Name = "PanelOrderPageBackground"
        PanelOrderPageBackground.Size = New Size(1027, 638)
        PanelOrderPageBackground.TabIndex = 0
        ' 
        ' PictureBoxErrorPincode
        ' 
        PictureBoxErrorPincode.BackColor = Color.Transparent
        PictureBoxErrorPincode.Image = CType(resources.GetObject("PictureBoxErrorPincode.Image"), Image)
        PictureBoxErrorPincode.Location = New Point(553, 486)
        PictureBoxErrorPincode.Name = "PictureBoxErrorPincode"
        PictureBoxErrorPincode.Size = New Size(20, 20)
        PictureBoxErrorPincode.TabIndex = 89
        PictureBoxErrorPincode.TabStop = False
        ' 
        ' PictureBoxErrorLandmark
        ' 
        PictureBoxErrorLandmark.BackColor = Color.Transparent
        PictureBoxErrorLandmark.Image = CType(resources.GetObject("PictureBoxErrorLandmark.Image"), Image)
        PictureBoxErrorLandmark.Location = New Point(553, 415)
        PictureBoxErrorLandmark.Name = "PictureBoxErrorLandmark"
        PictureBoxErrorLandmark.Size = New Size(20, 20)
        PictureBoxErrorLandmark.TabIndex = 88
        PictureBoxErrorLandmark.TabStop = False
        ' 
        ' PictureBoxErrorAddress
        ' 
        PictureBoxErrorAddress.BackColor = Color.Transparent
        PictureBoxErrorAddress.Image = CType(resources.GetObject("PictureBoxErrorAddress.Image"), Image)
        PictureBoxErrorAddress.Location = New Point(553, 337)
        PictureBoxErrorAddress.Name = "PictureBoxErrorAddress"
        PictureBoxErrorAddress.Size = New Size(20, 20)
        PictureBoxErrorAddress.TabIndex = 87
        PictureBoxErrorAddress.TabStop = False
        ' 
        ' PictureBoxErrorCity
        ' 
        PictureBoxErrorCity.BackColor = Color.Transparent
        PictureBoxErrorCity.Image = CType(resources.GetObject("PictureBoxErrorCity.Image"), Image)
        PictureBoxErrorCity.Location = New Point(553, 267)
        PictureBoxErrorCity.Name = "PictureBoxErrorCity"
        PictureBoxErrorCity.Size = New Size(20, 20)
        PictureBoxErrorCity.TabIndex = 86
        PictureBoxErrorCity.TabStop = False
        ' 
        ' PictureBoxErrorState
        ' 
        PictureBoxErrorState.BackColor = Color.Transparent
        PictureBoxErrorState.Image = CType(resources.GetObject("PictureBoxErrorState.Image"), Image)
        PictureBoxErrorState.Location = New Point(553, 195)
        PictureBoxErrorState.Name = "PictureBoxErrorState"
        PictureBoxErrorState.Size = New Size(20, 20)
        PictureBoxErrorState.TabIndex = 85
        PictureBoxErrorState.TabStop = False
        ' 
        ' PictureBoxErrorPhone
        ' 
        PictureBoxErrorPhone.BackColor = Color.Transparent
        PictureBoxErrorPhone.Image = CType(resources.GetObject("PictureBoxErrorPhone.Image"), Image)
        PictureBoxErrorPhone.Location = New Point(553, 124)
        PictureBoxErrorPhone.Name = "PictureBoxErrorPhone"
        PictureBoxErrorPhone.Size = New Size(20, 20)
        PictureBoxErrorPhone.TabIndex = 84
        PictureBoxErrorPhone.TabStop = False
        ' 
        ' PictureBoxErrorName
        ' 
        PictureBoxErrorName.BackColor = Color.Transparent
        PictureBoxErrorName.Image = CType(resources.GetObject("PictureBoxErrorName.Image"), Image)
        PictureBoxErrorName.Location = New Point(553, 61)
        PictureBoxErrorName.Name = "PictureBoxErrorName"
        PictureBoxErrorName.Size = New Size(20, 20)
        PictureBoxErrorName.TabIndex = 83
        PictureBoxErrorName.TabStop = False
        ' 
        ' TextBoxName
        ' 
        TextBoxName.BackColor = Color.WhiteSmoke
        TextBoxName.Font = New Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxName.Location = New Point(189, 51)
        TextBoxName.Name = "TextBoxName"
        TextBoxName.Size = New Size(349, 30)
        TextBoxName.TabIndex = 81
        ' 
        ' LabelPhoneno
        ' 
        LabelPhoneno.AutoSize = True
        LabelPhoneno.Font = New Font("Azonix", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point)
        LabelPhoneno.Location = New Point(45, 120)
        LabelPhoneno.Name = "LabelPhoneno"
        LabelPhoneno.Size = New Size(127, 19)
        LabelPhoneno.TabIndex = 80
        LabelPhoneno.Text = "Phone No"
        LabelPhoneno.TextAlign = ContentAlignment.TopCenter
        ' 
        ' LabelName
        ' 
        LabelName.AutoSize = True
        LabelName.Font = New Font("Azonix", 14F, FontStyle.Bold, GraphicsUnit.Point)
        LabelName.Location = New Point(45, 51)
        LabelName.Name = "LabelName"
        LabelName.Size = New Size(71, 19)
        LabelName.TabIndex = 79
        LabelName.Text = "Name"' 
        ' TextBoxPhoneNo
        ' 
        TextBoxPhoneNo.BackColor = Color.WhiteSmoke
        TextBoxPhoneNo.Font = New Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxPhoneNo.Location = New Point(189, 114)
        TextBoxPhoneNo.Name = "TextBoxPhoneNo"
        TextBoxPhoneNo.Size = New Size(240, 30)
        TextBoxPhoneNo.TabIndex = 82
        ' 
        ' TextBoxAddress
        ' 
        TextBoxAddress.BackColor = Color.WhiteSmoke
        TextBoxAddress.Font = New Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxAddress.Location = New Point(185, 326)
        TextBoxAddress.Name = "TextBoxAddress"
        TextBoxAddress.Size = New Size(353, 45)
        TextBoxAddress.TabIndex = 76
        TextBoxAddress.Text = ""' 
        ' LabelAddLine
        ' 
        LabelAddLine.AutoSize = True
        LabelAddLine.Font = New Font("Azonix", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point)
        LabelAddLine.Location = New Point(45, 338)
        LabelAddLine.Name = "LabelAddLine"
        LabelAddLine.Size = New Size(125, 19)
        LabelAddLine.TabIndex = 73
        LabelAddLine.Text = "Address "' 
        ' ComboBoxState
        ' 
        ComboBoxState.BackColor = Color.WhiteSmoke
        ComboBoxState.DropDownHeight = 200
        ComboBoxState.Font = New Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBoxState.FormattingEnabled = True
        ComboBoxState.IntegralHeight = False
        ComboBoxState.Location = New Point(189, 192)
        ComboBoxState.Name = "ComboBoxState"
        ComboBoxState.Size = New Size(240, 31)
        ComboBoxState.TabIndex = 72
        ' 
        ' TextBoxCity
        ' 
        TextBoxCity.BackColor = Color.WhiteSmoke
        TextBoxCity.Font = New Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxCity.Location = New Point(189, 257)
        TextBoxCity.Name = "TextBoxCity"
        TextBoxCity.Size = New Size(240, 30)
        TextBoxCity.TabIndex = 71
        ' 
        ' TextBoxPincode
        ' 
        TextBoxPincode.BackColor = Color.WhiteSmoke
        TextBoxPincode.Font = New Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxPincode.Location = New Point(185, 480)
        TextBoxPincode.Name = "TextBoxPincode"
        TextBoxPincode.Size = New Size(244, 30)
        TextBoxPincode.TabIndex = 78
        ' 
        ' LabelPinCode
        ' 
        LabelPinCode.AutoSize = True
        LabelPinCode.Font = New Font("Azonix", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point)
        LabelPinCode.Location = New Point(45, 486)
        LabelPinCode.Name = "LabelPinCode"
        LabelPinCode.Size = New Size(116, 19)
        LabelPinCode.TabIndex = 74
        LabelPinCode.Text = "Pin Code"' 
        ' TextBoxLandmark
        ' 
        TextBoxLandmark.BackColor = Color.WhiteSmoke
        TextBoxLandmark.Font = New Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxLandmark.Location = New Point(185, 415)
        TextBoxLandmark.Name = "TextBoxLandmark"
        TextBoxLandmark.Size = New Size(353, 29)
        TextBoxLandmark.TabIndex = 77
        TextBoxLandmark.Text = ""' 
        ' LabelLandmark
        ' 
        LabelLandmark.AutoSize = True
        LabelLandmark.Font = New Font("Azonix", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point)
        LabelLandmark.Location = New Point(45, 421)
        LabelLandmark.Name = "LabelLandmark"
        LabelLandmark.Size = New Size(128, 19)
        LabelLandmark.TabIndex = 75
        LabelLandmark.Text = "Landmark"' 
        ' LabelState
        ' 
        LabelState.AutoSize = True
        LabelState.Font = New Font("Azonix", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point)
        LabelState.Location = New Point(45, 195)
        LabelState.Name = "LabelState"
        LabelState.Size = New Size(77, 19)
        LabelState.TabIndex = 69
        LabelState.Text = "State"' 
        ' LabelCity
        ' 
        LabelCity.AutoSize = True
        LabelCity.Font = New Font("Azonix", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point)
        LabelCity.Location = New Point(45, 268)
        LabelCity.Name = "LabelCity"
        LabelCity.Size = New Size(62, 19)
        LabelCity.TabIndex = 70
        LabelCity.Text = "City"' 
        ' PanelPrice
        ' 
        PanelPrice.BackColor = Color.FromArgb(CByte(191), CByte(215), CByte(255))
        PanelPrice.Controls.Add(Label1)
        PanelPrice.Controls.Add(LabelDeliveryCharge)
        PanelPrice.Controls.Add(LabelPayableAmount)
        PanelPrice.Controls.Add(LabelDiscountedPrice)
        PanelPrice.Controls.Add(LabelMRP)
        PanelPrice.Controls.Add(LabelTagPayableAmount)
        PanelPrice.Controls.Add(LabelTagDeliveryCharge)
        PanelPrice.Controls.Add(LabelTagDiscountPrice)
        PanelPrice.Controls.Add(LabelTagMRP)
        PanelPrice.Location = New Point(592, 51)
        PanelPrice.Name = "PanelPrice"
        PanelPrice.Size = New Size(389, 215)
        PanelPrice.TabIndex = 67
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(6, 141)
        Label1.Name = "Label1"
        Label1.Size = New Size(367, 15)
        Label1.TabIndex = 69
        Label1.Text = "------------------------------------------------------------------------"' 
        ' LabelDeliveryCharge
        ' 
        LabelDeliveryCharge.AutoSize = True
        LabelDeliveryCharge.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LabelDeliveryCharge.Location = New Point(275, 114)
        LabelDeliveryCharge.Name = "LabelDeliveryCharge"
        LabelDeliveryCharge.Size = New Size(51, 19)
        LabelDeliveryCharge.TabIndex = 68
        LabelDeliveryCharge.Text = "Label2"' 
        ' LabelPayableAmount
        ' 
        LabelPayableAmount.AutoSize = True
        LabelPayableAmount.Font = New Font("Bahnschrift SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        LabelPayableAmount.Location = New Point(275, 170)
        LabelPayableAmount.Name = "LabelPayableAmount"
        LabelPayableAmount.Size = New Size(74, 25)
        LabelPayableAmount.TabIndex = 67
        LabelPayableAmount.Text = "Label5"' 
        ' LabelDiscountedPrice
        ' 
        LabelDiscountedPrice.AutoSize = True
        LabelDiscountedPrice.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LabelDiscountedPrice.Location = New Point(275, 64)
        LabelDiscountedPrice.Name = "LabelDiscountedPrice"
        LabelDiscountedPrice.Size = New Size(51, 19)
        LabelDiscountedPrice.TabIndex = 66
        LabelDiscountedPrice.Text = "Label2"' 
        ' LabelMRP
        ' 
        LabelMRP.AutoSize = True
        LabelMRP.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMRP.Location = New Point(275, 21)
        LabelMRP.Name = "LabelMRP"
        LabelMRP.Size = New Size(49, 19)
        LabelMRP.TabIndex = 65
        LabelMRP.Text = "Label1"' 
        ' LabelTagPayableAmount
        ' 
        LabelTagPayableAmount.AutoSize = True
        LabelTagPayableAmount.Font = New Font("Azonix", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTagPayableAmount.Location = New Point(17, 177)
        LabelTagPayableAmount.Name = "LabelTagPayableAmount"
        LabelTagPayableAmount.Size = New Size(226, 21)
        LabelTagPayableAmount.TabIndex = 64
        LabelTagPayableAmount.Text = "Payable Amount"' 
        ' LabelTagDeliveryCharge
        ' 
        LabelTagDeliveryCharge.AutoSize = True
        LabelTagDeliveryCharge.Font = New Font("Azonix", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTagDeliveryCharge.Location = New Point(25, 117)
        LabelTagDeliveryCharge.Name = "LabelTagDeliveryCharge"
        LabelTagDeliveryCharge.Size = New Size(180, 16)
        LabelTagDeliveryCharge.TabIndex = 63
        LabelTagDeliveryCharge.Text = "Delivery Charge"' 
        ' LabelTagDiscountPrice
        ' 
        LabelTagDiscountPrice.AutoSize = True
        LabelTagDiscountPrice.Font = New Font("Azonix", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTagDiscountPrice.Location = New Point(25, 66)
        LabelTagDiscountPrice.Name = "LabelTagDiscountPrice"
        LabelTagDiscountPrice.Size = New Size(162, 16)
        LabelTagDiscountPrice.TabIndex = 62
        LabelTagDiscountPrice.Text = "Discount Price"' 
        ' LabelTagMRP
        ' 
        LabelTagMRP.AutoSize = True
        LabelTagMRP.Font = New Font("Azonix", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTagMRP.Location = New Point(25, 21)
        LabelTagMRP.Name = "LabelTagMRP"
        LabelTagMRP.Size = New Size(44, 16)
        LabelTagMRP.TabIndex = 61
        LabelTagMRP.Text = "MRP"' 
        ' PanelPayment
        ' 
        PanelPayment.BackColor = Color.FromArgb(CByte(191), CByte(215), CByte(255))
        PanelPayment.Controls.Add(PictureBoxErrorPaymentMode)
        PanelPayment.Controls.Add(LabelUPIOrCard)
        PanelPayment.Controls.Add(TextBox1UPIOrCard)
        PanelPayment.Controls.Add(LabelTransactionMode)
        PanelPayment.Controls.Add(RadioButtonPOD)
        PanelPayment.Controls.Add(RadioButtonUPI)
        PanelPayment.Controls.Add(RadioButtonCard)
        PanelPayment.Location = New Point(592, 314)
        PanelPayment.Name = "PanelPayment"
        PanelPayment.Size = New Size(389, 204)
        PanelPayment.TabIndex = 68
        ' 
        ' LabelUPIOrCard
        ' 
        LabelUPIOrCard.AutoSize = True
        LabelUPIOrCard.Font = New Font("Azonix", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LabelUPIOrCard.Location = New Point(35, 139)
        LabelUPIOrCard.Name = "LabelUPIOrCard"
        LabelUPIOrCard.Size = New Size(61, 16)
        LabelUPIOrCard.TabIndex = 55
        LabelUPIOrCard.Text = "UPI Id"' 
        ' TextBox1UPIOrCard
        ' 
        TextBox1UPIOrCard.Font = New Font("Azonix", 13F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1UPIOrCard.Location = New Point(139, 136)
        TextBox1UPIOrCard.Name = "TextBox1UPIOrCard"
        TextBox1UPIOrCard.Size = New Size(228, 25)
        TextBox1UPIOrCard.TabIndex = 54
        ' 
        ' LabelTransactionMode
        ' 
        LabelTransactionMode.AutoSize = True
        LabelTransactionMode.Font = New Font("Azonix", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTransactionMode.Location = New Point(17, 24)
        LabelTransactionMode.Name = "LabelTransactionMode"
        LabelTransactionMode.Size = New Size(366, 21)
        LabelTransactionMode.TabIndex = 53
        LabelTransactionMode.Text = "Select Transaction Mode"' 
        ' RadioButtonPOD
        ' 
        RadioButtonPOD.AutoSize = True
        RadioButtonPOD.Font = New Font("Azonix", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButtonPOD.Location = New Point(185, 80)
        RadioButtonPOD.Name = "RadioButtonPOD"
        RadioButtonPOD.Size = New Size(188, 20)
        RadioButtonPOD.TabIndex = 52
        RadioButtonPOD.TabStop = True
        RadioButtonPOD.Text = "Pay on delivery"
        RadioButtonPOD.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonUPI
        ' 
        RadioButtonUPI.AutoSize = True
        RadioButtonUPI.Font = New Font("Azonix", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButtonUPI.Location = New Point(125, 80)
        RadioButtonUPI.Name = "RadioButtonUPI"
        RadioButtonUPI.Size = New Size(54, 20)
        RadioButtonUPI.TabIndex = 51
        RadioButtonUPI.TabStop = True
        RadioButtonUPI.Text = "UPI"
        RadioButtonUPI.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonCard
        ' 
        RadioButtonCard.AutoSize = True
        RadioButtonCard.BackColor = Color.Transparent
        RadioButtonCard.Font = New Font("Azonix", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButtonCard.Location = New Point(44, 80)
        RadioButtonCard.Name = "RadioButtonCard"
        RadioButtonCard.Size = New Size(75, 20)
        RadioButtonCard.TabIndex = 50
        RadioButtonCard.TabStop = True
        RadioButtonCard.Text = "Card"
        RadioButtonCard.UseVisualStyleBackColor = False
        ' 
        ' ButtonConfirmOrder
        ' 
        ButtonConfirmOrder.BackColor = Color.FromArgb(CByte(37), CByte(65), CByte(178))
        ButtonConfirmOrder.Font = New Font("Arial Rounded MT Bold", 13F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonConfirmOrder.ForeColor = SystemColors.ButtonHighlight
        ButtonConfirmOrder.Location = New Point(399, 560)
        ButtonConfirmOrder.Name = "ButtonConfirmOrder"
        ButtonConfirmOrder.Size = New Size(201, 57)
        ButtonConfirmOrder.TabIndex = 65
        ButtonConfirmOrder.Text = "Confirm Order"
        ButtonConfirmOrder.UseVisualStyleBackColor = False
        ' 
        ' TimerDeliveryDate
        ' 
        ' 
        ' LabelOrderDetails
        ' 
        LabelOrderDetails.AutoSize = True
        LabelOrderDetails.Font = New Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point)
        LabelOrderDetails.ForeColor = Color.FromArgb(CByte(3), CByte(37), CByte(108))
        LabelOrderDetails.Location = New Point(446, 9)
        LabelOrderDetails.Name = "LabelOrderDetails"
        LabelOrderDetails.Size = New Size(255, 38)
        LabelOrderDetails.TabIndex = 60
        LabelOrderDetails.Text = "Order Details"' 
        ' PictureBoxErrorPaymentMode
        ' 
        PictureBoxErrorPaymentMode.BackColor = Color.Transparent
        PictureBoxErrorPaymentMode.Image = CType(resources.GetObject("PictureBoxErrorPaymentMode.Image"), Image)
        PictureBoxErrorPaymentMode.Location = New Point(17, 80)
        PictureBoxErrorPaymentMode.Name = "PictureBoxErrorPaymentMode"
        PictureBoxErrorPaymentMode.Size = New Size(20, 20)
        PictureBoxErrorPaymentMode.TabIndex = 90
        PictureBoxErrorPaymentMode.TabStop = False
        ' 
        ' FormOrderPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(120), CByte(139), CByte(255))
        ClientSize = New Size(1176, 754)
        Controls.Add(LabelOrderDetails)
        Controls.Add(PanelOrderPageBackground)
        Name = "FormOrderPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormOrderPage"
        PanelOrderPageBackground.ResumeLayout(False)
        PanelOrderPageBackground.PerformLayout()
        CType(PictureBoxErrorPincode, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxErrorLandmark, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxErrorAddress, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxErrorCity, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxErrorState, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxErrorPhone, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxErrorName, ComponentModel.ISupportInitialize).EndInit()
        PanelPrice.ResumeLayout(False)
        PanelPrice.PerformLayout()
        PanelPayment.ResumeLayout(False)
        PanelPayment.PerformLayout()
        CType(PictureBoxErrorPaymentMode, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DeliveryCharge As Label
    Friend WithEvents PanelOrderPageBackground As Panel
    Friend WithEvents TimerDeliveryDate As Timer
    Friend WithEvents LabelOrderDetails As Label
    Friend WithEvents PanelPayment As Panel
    Friend WithEvents LabelUPIOrCard As Label
    Friend WithEvents TextBox1UPIOrCard As TextBox
    Friend WithEvents LabelTransactionMode As Label
    Friend WithEvents RadioButtonPOD As RadioButton
    Friend WithEvents RadioButtonUPI As RadioButton
    Friend WithEvents RadioButtonCard As RadioButton
    Friend WithEvents ButtonConfirmOrder As Button
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents LabelPhoneno As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents TextBoxPhoneNo As TextBox
    Friend WithEvents TextBoxAddress As RichTextBox
    Friend WithEvents LabelAddLine As Label
    Friend WithEvents ComboBoxState As ComboBox
    Friend WithEvents TextBoxCity As TextBox
    Friend WithEvents TextBoxPincode As TextBox
    Friend WithEvents LabelPinCode As Label
    Friend WithEvents TextBoxLandmark As RichTextBox
    Friend WithEvents LabelLandmark As Label
    Friend WithEvents LabelState As Label
    Friend WithEvents LabelCity As Label
    Friend WithEvents PanelPrice As Panel
    Friend WithEvents LabelDeliveryCharge As Label
    Friend WithEvents LabelPayableAmount As Label
    Friend WithEvents LabelDiscountedPrice As Label
    Friend WithEvents LabelMRP As Label
    Friend WithEvents LabelTagPayableAmount As Label
    Friend WithEvents LabelTagDeliveryCharge As Label
    Friend WithEvents LabelTagDiscountPrice As Label
    Friend WithEvents LabelTagMRP As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBoxErrorPincode As PictureBox
    Friend WithEvents PictureBoxErrorLandmark As PictureBox
    Friend WithEvents PictureBoxErrorAddress As PictureBox
    Friend WithEvents PictureBoxErrorCity As PictureBox
    Friend WithEvents PictureBoxErrorState As PictureBox
    Friend WithEvents PictureBoxErrorPhone As PictureBox
    Friend WithEvents PictureBoxErrorName As PictureBox
    Friend WithEvents PictureBoxErrorPaymentMode As PictureBox
End Class
