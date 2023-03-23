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
        TimerOrderHistory = New Timer(components)
        TextBoxSearch = New TextBox()
        ComboBoxSearchCategory = New ComboBox()
        PictureBoxBack = New PictureBox()
        Label1 = New Label()
        LabelSelectType = New Label()
        LabelSearch = New Label()
        CType(PictureBoxBack, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' FlowLayoutOrderHistory
        ' 
        FlowLayoutOrderHistory.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutOrderHistory.AutoScroll = True
        FlowLayoutOrderHistory.BackColor = Color.LightGray
        FlowLayoutOrderHistory.Location = New Point(0, 173)
        FlowLayoutOrderHistory.Name = "FlowLayoutOrderHistory"
        FlowLayoutOrderHistory.Size = New Size(1095, 498)
        FlowLayoutOrderHistory.TabIndex = 0
        ' 
        ' TimerOrderHistory
        ' 
        ' 
        ' TextBoxSearch
        ' 
        TextBoxSearch.BackColor = Color.Gainsboro
        TextBoxSearch.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxSearch.Location = New Point(659, 117)
        TextBoxSearch.Name = "TextBoxSearch"
        TextBoxSearch.ScrollBars = ScrollBars.Both
        TextBoxSearch.Size = New Size(191, 32)
        TextBoxSearch.TabIndex = 2
        ' 
        ' ComboBoxSearchCategory
        ' 
        ComboBoxSearchCategory.BackColor = Color.Gainsboro
        ComboBoxSearchCategory.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBoxSearchCategory.FormattingEnabled = True
        ComboBoxSearchCategory.Location = New Point(299, 117)
        ComboBoxSearchCategory.Name = "ComboBoxSearchCategory"
        ComboBoxSearchCategory.Size = New Size(145, 33)
        ComboBoxSearchCategory.TabIndex = 3
        ' 
        ' PictureBoxBack
        ' 
        PictureBoxBack.BackColor = Color.Black
        PictureBoxBack.Image = My.Resources.Resources.icons8_back_arrow_501
        PictureBoxBack.Location = New Point(12, 12)
        PictureBoxBack.Name = "PictureBoxBack"
        PictureBoxBack.Size = New Size(88, 44)
        PictureBoxBack.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxBack.TabIndex = 54
        PictureBoxBack.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Broadway", 24.75F, FontStyle.Underline, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(141, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(253, 37)
        Label1.TabIndex = 55
        Label1.Text = "Order History"' 
        ' LabelSelectType
        ' 
        LabelSelectType.AutoSize = True
        LabelSelectType.Font = New Font("Footlight MT Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        LabelSelectType.Location = New Point(166, 124)
        LabelSelectType.Name = "LabelSelectType"
        LabelSelectType.Size = New Size(104, 22)
        LabelSelectType.TabIndex = 56
        LabelSelectType.Text = "Select Type"' 
        ' LabelSearch
        ' 
        LabelSearch.AutoSize = True
        LabelSearch.Font = New Font("Footlight MT Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        LabelSearch.Location = New Point(577, 124)
        LabelSearch.Name = "LabelSearch"
        LabelSearch.Size = New Size(67, 22)
        LabelSearch.TabIndex = 57
        LabelSearch.Text = "Search"' 
        ' FormOrderHistory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(244), CByte(246))
        ClientSize = New Size(1095, 671)
        Controls.Add(LabelSearch)
        Controls.Add(LabelSelectType)
        Controls.Add(Label1)
        Controls.Add(PictureBoxBack)
        Controls.Add(ComboBoxSearchCategory)
        Controls.Add(TextBoxSearch)
        Controls.Add(FlowLayoutOrderHistory)
        Name = "FormOrderHistory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormProfile"
        WindowState = FormWindowState.Maximized
        CType(PictureBoxBack, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FlowLayoutOrderHistory As FlowLayoutPanel
    Friend WithEvents TimerOrderHistory As Timer
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents ComboBoxSearchCategory As ComboBox
    Friend WithEvents PictureBoxBack As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelSelectType As Label
    Friend WithEvents LabelSearch As Label
End Class
