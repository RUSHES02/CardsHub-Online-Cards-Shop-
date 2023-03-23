<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdminCards
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
        LabelNotFound = New Label()
        PictureBoxSearchId = New PictureBox()
        TextBoxSearchId = New TextBox()
        PanelSearchById = New Panel()
        LabelSearchById = New Label()
        PanelFilter = New Panel()
        LabelSelectCardType = New Label()
        CheckedListBoxFilter = New CheckedListBox()
        PictureBoxAddNew = New PictureBox()
        PictureBoxOrderHistory = New PictureBox()
        PictureBoxBack = New PictureBox()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        LabelAddNewCard = New Label()
        LabelOrderHistory = New Label()
        PictureBoxBanner = New PictureBox()
        FlowLayoutAdmin = New FlowLayoutPanel()
        PanelSidePane.SuspendLayout()
        CType(PictureBoxSearchId, ComponentModel.ISupportInitialize).BeginInit()
        PanelSearchById.SuspendLayout()
        PanelFilter.SuspendLayout()
        CType(PictureBoxAddNew, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxOrderHistory, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxBack, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxBanner, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelSidePane
        ' 
        PanelSidePane.BackColor = Color.Silver
        PanelSidePane.Controls.Add(LabelNotFound)
        PanelSidePane.Controls.Add(PictureBoxSearchId)
        PanelSidePane.Controls.Add(TextBoxSearchId)
        PanelSidePane.Controls.Add(PanelSearchById)
        PanelSidePane.Controls.Add(PanelFilter)
        PanelSidePane.Controls.Add(CheckedListBoxFilter)
        PanelSidePane.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        PanelSidePane.Location = New Point(0, 208)
        PanelSidePane.Name = "PanelSidePane"
        PanelSidePane.Size = New Size(332, 837)
        PanelSidePane.TabIndex = 56
        ' 
        ' LabelNotFound
        ' 
        LabelNotFound.AutoSize = True
        LabelNotFound.Font = New Font("Aparajita", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        LabelNotFound.ForeColor = Color.Red
        LabelNotFound.Location = New Point(92, 588)
        LabelNotFound.Name = "LabelNotFound"
        LabelNotFound.Size = New Size(126, 24)
        LabelNotFound.TabIndex = 62
        LabelNotFound.Text = "Card Not Found"' 
        ' PictureBoxSearchId
        ' 
        PictureBoxSearchId.BackColor = Color.Transparent
        PictureBoxSearchId.Image = My.Resources.Resources.icons8_search_501
        PictureBoxSearchId.Location = New Point(12, 536)
        PictureBoxSearchId.Name = "PictureBoxSearchId"
        PictureBoxSearchId.Size = New Size(40, 40)
        PictureBoxSearchId.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxSearchId.TabIndex = 61
        PictureBoxSearchId.TabStop = False
        ' 
        ' TextBoxSearchId
        ' 
        TextBoxSearchId.BackColor = Color.White
        TextBoxSearchId.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxSearchId.Location = New Point(62, 544)
        TextBoxSearchId.Name = "TextBoxSearchId"
        TextBoxSearchId.ScrollBars = ScrollBars.Both
        TextBoxSearchId.Size = New Size(191, 32)
        TextBoxSearchId.TabIndex = 53
        ' 
        ' PanelSearchById
        ' 
        PanelSearchById.BackColor = Color.Black
        PanelSearchById.BorderStyle = BorderStyle.FixedSingle
        PanelSearchById.Controls.Add(LabelSearchById)
        PanelSearchById.ForeColor = Color.White
        PanelSearchById.Location = New Point(3, 443)
        PanelSearchById.Name = "PanelSearchById"
        PanelSearchById.Size = New Size(329, 59)
        PanelSearchById.TabIndex = 53
        ' 
        ' LabelSearchById
        ' 
        LabelSearchById.AutoSize = True
        LabelSearchById.BackColor = Color.Transparent
        LabelSearchById.Font = New Font("Arial Rounded MT Bold", 20F, FontStyle.Regular, GraphicsUnit.Point)
        LabelSearchById.ForeColor = Color.White
        LabelSearchById.Location = New Point(20, 10)
        LabelSearchById.Name = "LabelSearchById"
        LabelSearchById.Size = New Size(181, 32)
        LabelSearchById.TabIndex = 52
        LabelSearchById.Text = "Search By Id"' 
        ' PanelFilter
        ' 
        PanelFilter.BackColor = Color.Black
        PanelFilter.Controls.Add(LabelSelectCardType)
        PanelFilter.Dock = DockStyle.Top
        PanelFilter.Location = New Point(0, 0)
        PanelFilter.Name = "PanelFilter"
        PanelFilter.Size = New Size(332, 56)
        PanelFilter.TabIndex = 51
        ' 
        ' LabelSelectCardType
        ' 
        LabelSelectCardType.AutoSize = True
        LabelSelectCardType.BackColor = Color.Transparent
        LabelSelectCardType.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelSelectCardType.ForeColor = Color.White
        LabelSelectCardType.Location = New Point(12, 15)
        LabelSelectCardType.Name = "LabelSelectCardType"
        LabelSelectCardType.Size = New Size(241, 32)
        LabelSelectCardType.TabIndex = 0
        LabelSelectCardType.Text = "Select Card Type"' 
        ' CheckedListBoxFilter
        ' 
        CheckedListBoxFilter.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        CheckedListBoxFilter.CheckOnClick = True
        CheckedListBoxFilter.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        CheckedListBoxFilter.FormattingEnabled = True
        CheckedListBoxFilter.Items.AddRange(New Object() {"Birthday Invitation", "Wedding Invitation", "Anniversary Invitation", "Baby Shower Invitation", "Business Party", "Inaugration", "Valentine", "Retirement Wishing", "Anniversary Wishing", "Birthday Wishing", "Christmas", "New Year"})
        CheckedListBoxFilter.Location = New Point(0, 80)
        CheckedListBoxFilter.Margin = New Padding(3, 3, 3, 5)
        CheckedListBoxFilter.Name = "CheckedListBoxFilter"
        CheckedListBoxFilter.Size = New Size(329, 340)
        CheckedListBoxFilter.TabIndex = 50
        ' 
        ' PictureBoxAddNew
        ' 
        PictureBoxAddNew.BackColor = Color.Black
        PictureBoxAddNew.Image = My.Resources.Resources.icons8_add_new_50
        PictureBoxAddNew.Location = New Point(9, 138)
        PictureBoxAddNew.Name = "PictureBoxAddNew"
        PictureBoxAddNew.Size = New Size(63, 50)
        PictureBoxAddNew.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxAddNew.TabIndex = 60
        PictureBoxAddNew.TabStop = False
        ' 
        ' PictureBoxOrderHistory
        ' 
        PictureBoxOrderHistory.BackColor = Color.Black
        PictureBoxOrderHistory.Image = My.Resources.Resources.icons8_order_history_501
        PictureBoxOrderHistory.Location = New Point(10, 69)
        PictureBoxOrderHistory.Name = "PictureBoxOrderHistory"
        PictureBoxOrderHistory.Size = New Size(63, 50)
        PictureBoxOrderHistory.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxOrderHistory.TabIndex = 59
        PictureBoxOrderHistory.TabStop = False
        ' 
        ' PictureBoxBack
        ' 
        PictureBoxBack.BackColor = Color.Black
        PictureBoxBack.Image = My.Resources.Resources.icons8_back_arrow_501
        PictureBoxBack.Location = New Point(10, 3)
        PictureBoxBack.Name = "PictureBoxBack"
        PictureBoxBack.Size = New Size(63, 50)
        PictureBoxBack.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxBack.TabIndex = 58
        PictureBoxBack.TabStop = False
        ' 
        ' LabelAddNewCard
        ' 
        LabelAddNewCard.AutoSize = True
        LabelAddNewCard.Font = New Font("Berlin Sans FB", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        LabelAddNewCard.Location = New Point(78, 159)
        LabelAddNewCard.Name = "LabelAddNewCard"
        LabelAddNewCard.Size = New Size(141, 23)
        LabelAddNewCard.TabIndex = 61
        LabelAddNewCard.Text = "Add New Card"' 
        ' LabelOrderHistory
        ' 
        LabelOrderHistory.AutoSize = True
        LabelOrderHistory.Font = New Font("Berlin Sans FB", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        LabelOrderHistory.Location = New Point(78, 87)
        LabelOrderHistory.Name = "LabelOrderHistory"
        LabelOrderHistory.Size = New Size(126, 23)
        LabelOrderHistory.TabIndex = 62
        LabelOrderHistory.Text = "Order History"' 
        ' PictureBoxBanner
        ' 
        PictureBoxBanner.Image = My.Resources.Resources.banner2
        PictureBoxBanner.Location = New Point(328, 12)
        PictureBoxBanner.Name = "PictureBoxBanner"
        PictureBoxBanner.Size = New Size(1585, 192)
        PictureBoxBanner.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxBanner.TabIndex = 66
        PictureBoxBanner.TabStop = False
        ' 
        ' FlowLayoutAdmin
        ' 
        FlowLayoutAdmin.AutoScroll = True
        FlowLayoutAdmin.BackColor = Color.Silver
        FlowLayoutAdmin.BorderStyle = BorderStyle.FixedSingle
        FlowLayoutAdmin.Location = New Point(335, 208)
        FlowLayoutAdmin.Name = "FlowLayoutAdmin"
        FlowLayoutAdmin.Padding = New Padding(5, 5, 0, 0)
        FlowLayoutAdmin.Size = New Size(1585, 837)
        FlowLayoutAdmin.TabIndex = 67
        ' 
        ' FormAdminCards
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1893, 1057)
        Controls.Add(FlowLayoutAdmin)
        Controls.Add(PictureBoxBanner)
        Controls.Add(LabelOrderHistory)
        Controls.Add(LabelAddNewCard)
        Controls.Add(PanelSidePane)
        Controls.Add(PictureBoxAddNew)
        Controls.Add(PictureBoxOrderHistory)
        Controls.Add(PictureBoxBack)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "FormAdminCards"
        StartPosition = FormStartPosition.CenterParent
        Text = "FormAdmin"
        WindowState = FormWindowState.Maximized
        PanelSidePane.ResumeLayout(False)
        PanelSidePane.PerformLayout()
        CType(PictureBoxSearchId, ComponentModel.ISupportInitialize).EndInit()
        PanelSearchById.ResumeLayout(False)
        PanelSearchById.PerformLayout()
        PanelFilter.ResumeLayout(False)
        PanelFilter.PerformLayout()
        CType(PictureBoxAddNew, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxOrderHistory, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxBack, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxBanner, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PanelSidePane As Panel
    Friend WithEvents LabelCategories As Label
    Friend WithEvents PanelFilter As Panel
    Friend WithEvents LabelSelectCardType As Label
    Friend WithEvents CheckedListBoxFilter As CheckedListBox
    Friend WithEvents PictureBoxAddNew As PictureBox
    Friend WithEvents PictureBoxOrderHistory As PictureBox
    Friend WithEvents PictureBoxBack As PictureBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents PanelSearchById As Panel
    Friend WithEvents LabelSearchById As Label
    Friend WithEvents PictureBoxSearchId As PictureBox
    Friend WithEvents TextBoxSearchId As TextBox
    Friend WithEvents LabelNotFound As Label
    Friend WithEvents LabelAddNewCard As Label
    Friend WithEvents LabelOrderHistory As Label
    Friend WithEvents PictureBoxBanner As PictureBox
    Friend WithEvents FlowLayoutAdmin As FlowLayoutPanel
End Class
