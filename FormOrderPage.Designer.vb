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
        TextBoxCity = New TextBox()
        ComboBoxState = New ComboBox()
        LabelState = New Label()
        LabelCity = New Label()
        LabelAddLine = New Label()
        LabelPinCode = New Label()
        LabelLandmark = New Label()
        LabelName = New Label()
        LabelPhoneno = New Label()
        LabelEmail = New Label()
        TextBoxEmail = New TextBox()
        TextBoxAddress = New RichTextBox()
        TextBoxLandmark = New RichTextBox()
        RadioButtonCard = New RadioButton()
        RadioButtonUPI = New RadioButton()
        RadioButtonPOD = New RadioButton()
        LabelTransactionMode = New Label()
        TextBoxPincode = New TextBox()
        TextBoxName = New TextBox()
        TextBoxPhoneNo = New TextBox()
        TextBox1UPIOrCard = New TextBox()
        LabelUPIOrCard = New Label()
        ButtonConfirmOrder = New Button()
        SuspendLayout()
        ' 
        ' TextBoxCity
        ' 
        TextBoxCity.Location = New Point(110, 124)
        TextBoxCity.Name = "TextBoxCity"
        TextBoxCity.Size = New Size(142, 23)
        TextBoxCity.TabIndex = 1
        ' 
        ' ComboBoxState
        ' 
        ComboBoxState.DropDownHeight = 50
        ComboBoxState.FormattingEnabled = True
        ComboBoxState.IntegralHeight = False
        ComboBoxState.Location = New Point(110, 65)
        ComboBoxState.Name = "ComboBoxState"
        ComboBoxState.Size = New Size(132, 23)
        ComboBoxState.TabIndex = 2
        ' 
        ' LabelState
        ' 
        LabelState.AutoSize = True
        LabelState.Location = New Point(12, 68)
        LabelState.Name = "LabelState"
        LabelState.Size = New Size(33, 15)
        LabelState.TabIndex = 3
        LabelState.Text = "State"' 
        ' LabelCity
        ' 
        LabelCity.AutoSize = True
        LabelCity.Location = New Point(12, 127)
        LabelCity.Name = "LabelCity"
        LabelCity.Size = New Size(28, 15)
        LabelCity.TabIndex = 4
        LabelCity.Text = "City"' 
        ' LabelAddLine
        ' 
        LabelAddLine.AutoSize = True
        LabelAddLine.Location = New Point(12, 187)
        LabelAddLine.Name = "LabelAddLine"
        LabelAddLine.Size = New Size(74, 15)
        LabelAddLine.TabIndex = 5
        LabelAddLine.Text = "Address Line"' 
        ' LabelPinCode
        ' 
        LabelPinCode.AutoSize = True
        LabelPinCode.Location = New Point(12, 249)
        LabelPinCode.Name = "LabelPinCode"
        LabelPinCode.Size = New Size(55, 15)
        LabelPinCode.TabIndex = 8
        LabelPinCode.Text = "Pin Code"' 
        ' LabelLandmark
        ' 
        LabelLandmark.AutoSize = True
        LabelLandmark.Location = New Point(12, 295)
        LabelLandmark.Name = "LabelLandmark"
        LabelLandmark.Size = New Size(60, 15)
        LabelLandmark.TabIndex = 9
        LabelLandmark.Text = "Landmark"' 
        ' LabelName
        ' 
        LabelName.AutoSize = True
        LabelName.Location = New Point(418, 63)
        LabelName.Name = "LabelName"
        LabelName.Size = New Size(39, 15)
        LabelName.TabIndex = 12
        LabelName.Text = "Name"' 
        ' LabelPhoneno
        ' 
        LabelPhoneno.AutoSize = True
        LabelPhoneno.Location = New Point(418, 128)
        LabelPhoneno.Name = "LabelPhoneno"
        LabelPhoneno.Size = New Size(60, 15)
        LabelPhoneno.TabIndex = 13
        LabelPhoneno.Text = "Phone No"
        LabelPhoneno.TextAlign = ContentAlignment.TopCenter
        ' 
        ' LabelEmail
        ' 
        LabelEmail.AutoSize = True
        LabelEmail.Location = New Point(423, 187)
        LabelEmail.Name = "LabelEmail"
        LabelEmail.Size = New Size(36, 15)
        LabelEmail.TabIndex = 14
        LabelEmail.Text = "Email"' 
        ' TextBoxEmail
        ' 
        TextBoxEmail.Location = New Point(514, 187)
        TextBoxEmail.Name = "TextBoxEmail"
        TextBoxEmail.Size = New Size(147, 23)
        TextBoxEmail.TabIndex = 15
        ' 
        ' TextBoxAddress
        ' 
        TextBoxAddress.Location = New Point(110, 176)
        TextBoxAddress.Name = "TextBoxAddress"
        TextBoxAddress.Size = New Size(157, 26)
        TextBoxAddress.TabIndex = 16
        TextBoxAddress.Text = ""' 
        ' TextBoxLandmark
        ' 
        TextBoxLandmark.Location = New Point(104, 294)
        TextBoxLandmark.Name = "TextBoxLandmark"
        TextBoxLandmark.Size = New Size(150, 29)
        TextBoxLandmark.TabIndex = 17
        TextBoxLandmark.Text = ""' 
        ' RadioButtonCard
        ' 
        RadioButtonCard.AutoSize = True
        RadioButtonCard.Location = New Point(432, 291)
        RadioButtonCard.Name = "RadioButtonCard"
        RadioButtonCard.Size = New Size(50, 19)
        RadioButtonCard.TabIndex = 18
        RadioButtonCard.TabStop = True
        RadioButtonCard.Text = "Card"
        RadioButtonCard.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonUPI
        ' 
        RadioButtonUPI.AutoSize = True
        RadioButtonUPI.Location = New Point(517, 295)
        RadioButtonUPI.Name = "RadioButtonUPI"
        RadioButtonUPI.Size = New Size(43, 19)
        RadioButtonUPI.TabIndex = 19
        RadioButtonUPI.TabStop = True
        RadioButtonUPI.Text = "UPI"
        RadioButtonUPI.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonPOD
        ' 
        RadioButtonPOD.AutoSize = True
        RadioButtonPOD.Location = New Point(593, 295)
        RadioButtonPOD.Name = "RadioButtonPOD"
        RadioButtonPOD.Size = New Size(105, 19)
        RadioButtonPOD.TabIndex = 20
        RadioButtonPOD.TabStop = True
        RadioButtonPOD.Text = "Pay on delivery"
        RadioButtonPOD.UseVisualStyleBackColor = True
        ' 
        ' LabelTransactionMode
        ' 
        LabelTransactionMode.AutoSize = True
        LabelTransactionMode.Location = New Point(418, 243)
        LabelTransactionMode.Name = "LabelTransactionMode"
        LabelTransactionMode.Size = New Size(135, 15)
        LabelTransactionMode.TabIndex = 21
        LabelTransactionMode.Text = "Select Transaction Mode"' 
        ' TextBoxPincode
        ' 
        TextBoxPincode.Location = New Point(110, 241)
        TextBoxPincode.Name = "TextBoxPincode"
        TextBoxPincode.Size = New Size(100, 23)
        TextBoxPincode.TabIndex = 22
        ' 
        ' TextBoxName
        ' 
        TextBoxName.Location = New Point(517, 65)
        TextBoxName.Name = "TextBoxName"
        TextBoxName.Size = New Size(144, 23)
        TextBoxName.TabIndex = 23
        ' 
        ' TextBoxPhoneNo
        ' 
        TextBoxPhoneNo.Location = New Point(517, 127)
        TextBoxPhoneNo.Name = "TextBoxPhoneNo"
        TextBoxPhoneNo.Size = New Size(144, 23)
        TextBoxPhoneNo.TabIndex = 24
        ' 
        ' TextBox1UPIOrCard
        ' 
        TextBox1UPIOrCard.Location = New Point(493, 339)
        TextBox1UPIOrCard.Name = "TextBox1UPIOrCard"
        TextBox1UPIOrCard.Size = New Size(168, 23)
        TextBox1UPIOrCard.TabIndex = 25
        ' 
        ' LabelUPIOrCard
        ' 
        LabelUPIOrCard.AutoSize = True
        LabelUPIOrCard.Location = New Point(440, 342)
        LabelUPIOrCard.Name = "LabelUPIOrCard"
        LabelUPIOrCard.Size = New Size(38, 15)
        LabelUPIOrCard.TabIndex = 26
        LabelUPIOrCard.Text = "UPI Id"' 
        ' ButtonConfirmOrder
        ' 
        ButtonConfirmOrder.Location = New Point(278, 385)
        ButtonConfirmOrder.Name = "ButtonConfirmOrder"
        ButtonConfirmOrder.Size = New Size(142, 37)
        ButtonConfirmOrder.TabIndex = 27
        ButtonConfirmOrder.Text = "Confirm Order"
        ButtonConfirmOrder.UseVisualStyleBackColor = True
        ' 
        ' FormOrderPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonConfirmOrder)
        Controls.Add(LabelUPIOrCard)
        Controls.Add(TextBox1UPIOrCard)
        Controls.Add(TextBoxPhoneNo)
        Controls.Add(TextBoxName)
        Controls.Add(TextBoxPincode)
        Controls.Add(LabelTransactionMode)
        Controls.Add(RadioButtonPOD)
        Controls.Add(RadioButtonUPI)
        Controls.Add(RadioButtonCard)
        Controls.Add(TextBoxLandmark)
        Controls.Add(TextBoxAddress)
        Controls.Add(TextBoxEmail)
        Controls.Add(LabelEmail)
        Controls.Add(LabelPhoneno)
        Controls.Add(LabelName)
        Controls.Add(LabelLandmark)
        Controls.Add(LabelPinCode)
        Controls.Add(LabelAddLine)
        Controls.Add(LabelCity)
        Controls.Add(LabelState)
        Controls.Add(ComboBoxState)
        Controls.Add(TextBoxCity)
        Name = "FormOrderPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormOrderPage"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBoxPincode As TextBox
    Friend WithEvents TextBoxCity As TextBox
    Friend WithEvents ComboBoxState As ComboBox
    Friend WithEvents LabelState As Label
    Friend WithEvents LabelCity As Label
    Friend WithEvents LabelAddLine As Label
    Friend WithEvents TextBoxPhoneNo As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents LabelPinCode As Label
    Friend WithEvents LabelLandmark As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelPhoneno As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxAddress As RichTextBox
    Friend WithEvents TextBoxLandmark As RichTextBox
    Friend WithEvents RadioButtonCard As RadioButton
    Friend WithEvents RadioButtonUPI As RadioButton
    Friend WithEvents RadioButtonPOD As RadioButton
    Friend WithEvents LabelTransactionMode As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBox1UPIOrCard As TextBox
    Friend WithEvents LabelUPIOrCard As Label
    Friend WithEvents ButtonConfirmOrder As Button
End Class
