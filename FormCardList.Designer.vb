<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCardList
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
        PanelSidePane = New Panel()
        CheckedListBoxPrice = New CheckedListBox()
        LabelCategories = New Label()
        LabelPrice = New Label()
        PanelFilter = New Panel()
        LabelFilter = New Label()
        CheckedListBoxFilter = New CheckedListBox()
        FlowLayoutCardList = New FlowLayoutPanel()
        PictureBoxBack = New PictureBox()
        PictureBoxOrderHistory = New PictureBox()
        LabelOrderHistory = New Label()
        PictureBoxBanner = New PictureBox()
        PanelSidePane.SuspendLayout()
        PanelFilter.SuspendLayout()
        CType(PictureBoxBack, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxOrderHistory, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxBanner, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelSidePane
        ' 
        PanelSidePane.BackColor = Color.Silver
        PanelSidePane.Controls.Add(CheckedListBoxPrice)
        PanelSidePane.Controls.Add(LabelCategories)
        PanelSidePane.Controls.Add(LabelPrice)
        PanelSidePane.Controls.Add(PanelFilter)
        PanelSidePane.Controls.Add(CheckedListBoxFilter)
        PanelSidePane.Location = New Point(2, 223)
        PanelSidePane.Name = "PanelSidePane"
        PanelSidePane.Size = New Size(332, 837)
        PanelSidePane.TabIndex = 0
        ' 
        ' CheckedListBoxPrice
        ' 
        CheckedListBoxPrice.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        CheckedListBoxPrice.CheckOnClick = True
        CheckedListBoxPrice.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        CheckedListBoxPrice.FormattingEnabled = True
        CheckedListBoxPrice.Items.AddRange(New Object() {"Below ₹50", "₹50 - ₹100", "₹100 - ₹150", "Above ₹150", "All"})
        CheckedListBoxPrice.Location = New Point(3, 545)
        CheckedListBoxPrice.Margin = New Padding(3, 3, 3, 5)
        CheckedListBoxPrice.Name = "CheckedListBoxPrice"
        CheckedListBoxPrice.Size = New Size(323, 172)
        CheckedListBoxPrice.TabIndex = 53
        ' 
        ' LabelCategories
        ' 
        LabelCategories.AutoSize = True
        LabelCategories.Font = New Font("Elephant", 14F, FontStyle.Bold, GraphicsUnit.Point)
        LabelCategories.Location = New Point(10, 81)
        LabelCategories.Name = "LabelCategories"
        LabelCategories.Size = New Size(172, 25)
        LabelCategories.TabIndex = 0
        LabelCategories.Text = "CATEGORIES"' 
        ' LabelPrice
        ' 
        LabelPrice.AutoSize = True
        LabelPrice.Font = New Font("Elephant", 14F, FontStyle.Bold, GraphicsUnit.Point)
        LabelPrice.Location = New Point(10, 503)
        LabelPrice.Name = "LabelPrice"
        LabelPrice.Size = New Size(90, 25)
        LabelPrice.TabIndex = 52
        LabelPrice.Text = "PRICE"' 
        ' PanelFilter
        ' 
        PanelFilter.BackColor = Color.Black
        PanelFilter.Controls.Add(LabelFilter)
        PanelFilter.Dock = DockStyle.Top
        PanelFilter.Location = New Point(0, 0)
        PanelFilter.Name = "PanelFilter"
        PanelFilter.Size = New Size(332, 47)
        PanelFilter.TabIndex = 51
        ' 
        ' LabelFilter
        ' 
        LabelFilter.AutoSize = True
        LabelFilter.BackColor = Color.Transparent
        LabelFilter.Font = New Font("Arial Rounded MT Bold", 25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelFilter.ForeColor = Color.White
        LabelFilter.Location = New Point(6, 0)
        LabelFilter.Name = "LabelFilter"
        LabelFilter.Size = New Size(121, 39)
        LabelFilter.TabIndex = 0
        LabelFilter.Text = "Filters"' 
        ' CheckedListBoxFilter
        ' 
        CheckedListBoxFilter.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        CheckedListBoxFilter.CheckOnClick = True
        CheckedListBoxFilter.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        CheckedListBoxFilter.FormattingEnabled = True
        CheckedListBoxFilter.Items.AddRange(New Object() {"Birthday Invitation", "Wedding Invitation", "Anniversary Invitation", "Baby Shower Invitation", "Business Party", "Inaugration", "Valentine", "Retirement Wishing", "Anniversary Wishing", "Birthday Wishing", "Christmas", "New Year"})
        CheckedListBoxFilter.Location = New Point(3, 109)
        CheckedListBoxFilter.Margin = New Padding(3, 3, 3, 5)
        CheckedListBoxFilter.Name = "CheckedListBoxFilter"
        CheckedListBoxFilter.Size = New Size(329, 340)
        CheckedListBoxFilter.TabIndex = 50
        ' 
        ' FlowLayoutCardList
        ' 
        FlowLayoutCardList.AllowDrop = True
        FlowLayoutCardList.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutCardList.AutoScroll = True
        FlowLayoutCardList.BackColor = Color.Silver
        FlowLayoutCardList.BorderStyle = BorderStyle.FixedSingle
        FlowLayoutCardList.Location = New Point(340, 223)
        FlowLayoutCardList.Name = "FlowLayoutCardList"
        FlowLayoutCardList.Padding = New Padding(5, 5, 0, 0)
        FlowLayoutCardList.Size = New Size(1585, 826)
        FlowLayoutCardList.TabIndex = 4
        ' 
        ' PictureBoxBack
        ' 
        PictureBoxBack.BackColor = Color.Black
        PictureBoxBack.Image = My.Resources.Resources.icons8_back_arrow_501
        PictureBoxBack.Location = New Point(12, 12)
        PictureBoxBack.Name = "PictureBoxBack"
        PictureBoxBack.Size = New Size(63, 50)
        PictureBoxBack.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxBack.TabIndex = 53
        PictureBoxBack.TabStop = False
        ' 
        ' PictureBoxOrderHistory
        ' 
        PictureBoxOrderHistory.BackColor = Color.Black
        PictureBoxOrderHistory.Image = My.Resources.Resources.icons8_order_history_501
        PictureBoxOrderHistory.Location = New Point(12, 83)
        PictureBoxOrderHistory.Name = "PictureBoxOrderHistory"
        PictureBoxOrderHistory.Size = New Size(63, 50)
        PictureBoxOrderHistory.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxOrderHistory.TabIndex = 54
        PictureBoxOrderHistory.TabStop = False
        ' 
        ' LabelOrderHistory
        ' 
        LabelOrderHistory.AutoSize = True
        LabelOrderHistory.Font = New Font("Berlin Sans FB", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        LabelOrderHistory.Location = New Point(90, 97)
        LabelOrderHistory.Name = "LabelOrderHistory"
        LabelOrderHistory.Size = New Size(126, 23)
        LabelOrderHistory.TabIndex = 64
        LabelOrderHistory.Text = "Order History"' 
        ' PictureBoxBanner
        ' 
        PictureBoxBanner.Image = My.Resources.Resources.banner2
        PictureBoxBanner.Location = New Point(340, 3)
        PictureBoxBanner.Name = "PictureBoxBanner"
        PictureBoxBanner.Size = New Size(1585, 192)
        PictureBoxBanner.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxBanner.TabIndex = 65
        PictureBoxBanner.TabStop = False
        ' 
        ' FormCardList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(244), CByte(246))
        ClientSize = New Size(1924, 1061)
        Controls.Add(PictureBoxBanner)
        Controls.Add(LabelOrderHistory)
        Controls.Add(PictureBoxOrderHistory)
        Controls.Add(PictureBoxBack)
        Controls.Add(FlowLayoutCardList)
        Controls.Add(PanelSidePane)
        Name = "FormCardList"
        Text = "FormCardList"
        WindowState = FormWindowState.Maximized
        PanelSidePane.ResumeLayout(False)
        PanelSidePane.PerformLayout()
        PanelFilter.ResumeLayout(False)
        PanelFilter.PerformLayout()
        CType(PictureBoxBack, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxOrderHistory, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxBanner, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PanelSidePane As Panel
    Friend WithEvents GroupBoxFilters As GroupBox
    Friend WithEvents CheckBoxBirthdayWishing As CheckBox
    Friend WithEvents CheckBoxAnniversaryWishing As CheckBox
    Friend WithEvents CheckBoxRetirementWishing As CheckBox
    Friend WithEvents CheckBoxValentine As CheckBox
    Friend WithEvents CheckBoxInaugration As CheckBox
    Friend WithEvents CheckBoxBusinessParty As CheckBox
    Friend WithEvents CheckBoxBabyShowerInvitation As CheckBox
    Friend WithEvents CheckBoxAnniversaryInvitation As CheckBox
    Friend WithEvents CheckBoxWeddingInvitation As CheckBox
    Friend WithEvents CheckBoxBirthdayInvitation As CheckBox
    Friend WithEvents CheckBoxNewYear As CheckBox
    Friend WithEvents CheckBoxChristmas As CheckBox
    Friend WithEvents CheckedListBoxFilter As CheckedListBox
    Friend WithEvents FlowLayoutCardList As FlowLayoutPanel
    Friend WithEvents PanelFilter As Panel
    Friend WithEvents LabelFilter As Label
    Friend WithEvents LabelCategories As Label
    Friend WithEvents PictureBoxBack As PictureBox
    Friend WithEvents PictureBoxOrderHistory As PictureBox
    Friend WithEvents LabelPrice As Label
    Friend WithEvents CheckedListBoxPrice As CheckedListBox
    Friend WithEvents LabelOrderHistory As Label
    Friend WithEvents PictureBoxBanner As PictureBox
End Class
