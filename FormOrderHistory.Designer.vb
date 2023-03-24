<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOrderHistory
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
        FlowLayoutOrderHistory = New FlowLayoutPanel()
        PictureBoxBack = New PictureBox()
        LabelOrderHistory = New Label()
        LabelSelectType = New Label()
        LabelSearch = New Label()
        ComboBoxSearchCategory = New ComboBox()
        TextBoxSearch = New TextBox()
        TimerOrderHistory = New Timer(components)
        CType(PictureBoxBack, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' FlowLayoutOrderHistory
        ' 
        FlowLayoutOrderHistory.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutOrderHistory.AutoScroll = True
        FlowLayoutOrderHistory.BackColor = Color.Silver
        FlowLayoutOrderHistory.Location = New Point(3, 175)
        FlowLayoutOrderHistory.Name = "FlowLayoutOrderHistory"
        FlowLayoutOrderHistory.Size = New Size(1302, 366)
        FlowLayoutOrderHistory.TabIndex = 0
        ' 
        ' PictureBoxBack
        ' 
        PictureBoxBack.BackColor = Color.Black
        PictureBoxBack.Image = My.Resources.Resources.icons8_back_arrow_501
        PictureBoxBack.Location = New Point(12, 12)
        PictureBoxBack.Name = "PictureBoxBack"
        PictureBoxBack.Size = New Size(63, 50)
        PictureBoxBack.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxBack.TabIndex = 54
        PictureBoxBack.TabStop = False
        ' 
        ' LabelOrderHistory
        ' 
        LabelOrderHistory.AutoSize = True
        LabelOrderHistory.Font = New Font("Azonix", 23.9999962F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        LabelOrderHistory.Location = New Point(100, 30)
        LabelOrderHistory.Name = "LabelOrderHistory"
        LabelOrderHistory.Size = New Size(311, 32)
        LabelOrderHistory.TabIndex = 55
        LabelOrderHistory.Text = "Order History"' 
        ' LabelSelectType
        ' 
        LabelSelectType.AutoSize = True
        LabelSelectType.Font = New Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        LabelSelectType.Location = New Point(153, 114)
        LabelSelectType.Name = "LabelSelectType"
        LabelSelectType.Size = New Size(104, 23)
        LabelSelectType.TabIndex = 56
        LabelSelectType.Text = "Select Type"' 
        ' LabelSearch
        ' 
        LabelSearch.AutoSize = True
        LabelSearch.Font = New Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        LabelSearch.Location = New Point(477, 117)
        LabelSearch.Name = "LabelSearch"
        LabelSearch.Size = New Size(60, 23)
        LabelSearch.TabIndex = 57
        LabelSearch.Text = "Name"' 
        ' ComboBoxSearchCategory
        ' 
        ComboBoxSearchCategory.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBoxSearchCategory.FormattingEnabled = True
        ComboBoxSearchCategory.Location = New Point(274, 114)
        ComboBoxSearchCategory.Name = "ComboBoxSearchCategory"
        ComboBoxSearchCategory.Size = New Size(137, 26)
        ComboBoxSearchCategory.TabIndex = 58
        ' 
        ' TextBoxSearch
        ' 
        TextBoxSearch.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxSearch.Location = New Point(553, 117)
        TextBoxSearch.Name = "TextBoxSearch"
        TextBoxSearch.Size = New Size(135, 26)
        TextBoxSearch.TabIndex = 59
        ' 
        ' TimerOrderHistory
        ' 
        ' 
        ' FormOrderHistory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(1305, 539)
        Controls.Add(TextBoxSearch)
        Controls.Add(ComboBoxSearchCategory)
        Controls.Add(LabelSearch)
        Controls.Add(LabelSelectType)
        Controls.Add(LabelOrderHistory)
        Controls.Add(PictureBoxBack)
        Controls.Add(FlowLayoutOrderHistory)
        Name = "FormOrderHistory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormOrderHistory"
        WindowState = FormWindowState.Maximized
        CType(PictureBoxBack, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FlowLayoutOrderHistory As FlowLayoutPanel
    Friend WithEvents PictureBoxBack As PictureBox
    Friend WithEvents LabelOrderHistory As Label
    Friend WithEvents LabelSelectType As Label
    Friend WithEvents LabelSearch As Label
    Friend WithEvents ComboBoxSearchCategory As ComboBox
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents TimerOrderHistory As Timer
End Class
