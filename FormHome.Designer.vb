<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PictureThumnailBDayInvi = New PictureBox()
        LabelChooseTypeCard = New Label()
        PictureThumbnailAniiverseryInvi = New PictureBox()
        PictureThumbnailWeddingInvitation = New PictureBox()
        PictureThumbnailBirthdayWishing = New PictureBox()
        PictureThumbnailAnneversaryWishing = New PictureBox()
        PictureThumbnailRetirementWishing = New PictureBox()
        ButtonBDayInvi = New Button()
        ButtonAnneversiryInvi = New Button()
        ButtonWeddingInvitation = New Button()
        ButtonBirthdayWishing = New Button()
        ButtonAnneversaryWishing = New Button()
        ButtonRetirementWishing = New Button()
        ButtonValentine = New Button()
        ButtonBabyShowerInvitation = New Button()
        PictureThumbnailValentine = New PictureBox()
        PictureThumbnailBabyShowerInvitation = New PictureBox()
        ButtonChristmas = New Button()
        ButtonBussinessInvitation = New Button()
        PictureThumbnailChristmas = New PictureBox()
        PictureThumbnailBussinessInvitation = New PictureBox()
        Button1NewYeae = New Button()
        ButtonInaugrationInvitation = New Button()
        PictureThumbnailNewYear = New PictureBox()
        PicturethumbnailInaugrationInvitation = New PictureBox()
        CType(PictureThumnailBDayInvi, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureThumbnailAniiverseryInvi, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureThumbnailWeddingInvitation, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureThumbnailBirthdayWishing, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureThumbnailAnneversaryWishing, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureThumbnailRetirementWishing, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureThumbnailValentine, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureThumbnailBabyShowerInvitation, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureThumbnailChristmas, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureThumbnailBussinessInvitation, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureThumbnailNewYear, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicturethumbnailInaugrationInvitation, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabHome)
        TabControl1.Controls.Add(TabWatchlist)
        TabControl1.Controls.Add(TabHoldings)
        TabControl1.Controls.Add(TabWallet)
        TabControl1.Location = New Point(2, 1)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1112, 587)
        TabControl1.TabIndex = 0
        ' 
        ' TabHome
        ' 
        TabHome.Controls.Add(Button1)
        TabHome.Controls.Add(ButtonAddWatchlist)
        TabHome.Controls.Add(ListViewHome)
        TabHome.Location = New Point(4, 24)
        TabHome.Margin = New Padding(10)
        TabHome.Name = "TabHome"
        TabHome.Padding = New Padding(3)
        TabHome.Size = New Size(1104, 559)
        TabHome.TabIndex = 0
        TabHome.Text = "Home"
        TabHome.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Cursor = Cursors.Hand
        Button1.Location = New Point(848, 490)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 3
        Button1.Text = "View  Market"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ButtonAddWatchlist
        ' 
        ButtonAddWatchlist.Location = New Point(931, 482)
        ButtonAddWatchlist.Name = "ButtonAddWatchlist"
        ButtonAddWatchlist.Size = New Size(75, 41)
        ButtonAddWatchlist.TabIndex = 2
        ButtonAddWatchlist.Text = "Add to Watchlist"
        ButtonAddWatchlist.UseVisualStyleBackColor = True
        ' 
        ' ListViewHome
        ' 
        ListViewHome.Columns.AddRange(New ColumnHeader() {ColumnCompanyName, ColumnStockName, ColumnPrice, ColumnWatchlist})
        ListViewHome.GridLines = True
        ListViewHome.Location = New Point(127, 120)
        ListViewHome.Name = "ListViewHome"
        ListViewHome.Size = New Size(879, 335)
        ListViewHome.TabIndex = 1
        ListViewHome.UseCompatibleStateImageBehavior = False
        ListViewHome.View = View.Details
        ' 
        ' ColumnCompanyName
        ' 
        ColumnCompanyName.Text = "Company Name"
        ColumnCompanyName.Width = 350
        ' 
        ' ColumnStockName
        ' 
        ColumnStockName.Text = "Stock Name"
        ColumnStockName.Width = 150
        ' 
        ' ColumnPrice
        ' 
        ColumnPrice.Text = "Price"
        ColumnPrice.Width = 100
        ' 
        ' ColumnWatchlist
        ' 
        ColumnWatchlist.Text = "Watchlist"
        ColumnWatchlist.Width = 150
        ' 
        ' TabWatchlist
        ' 
        TabWatchlist.Location = New Point(4, 24)
        TabWatchlist.Name = "TabWatchlist"
        TabWatchlist.Padding = New Padding(3)
        TabWatchlist.Size = New Size(1104, 559)
        TabWatchlist.TabIndex = 1
        TabWatchlist.Text = "Watchlist"
        TabWatchlist.UseVisualStyleBackColor = True
        ' 
        ' TabHoldings
        ' 
        TabHoldings.Location = New Point(4, 24)
        TabHoldings.Name = "TabHoldings"
        TabHoldings.Padding = New Padding(3)
        TabHoldings.Size = New Size(1104, 559)
        TabHoldings.TabIndex = 2
        TabHoldings.Text = "Holdings"
        TabHoldings.UseVisualStyleBackColor = True
        ' 
        ' TabWallet
        ' 
        TabWallet.Font = New Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        TabWallet.Location = New Point(4, 24)
        TabWallet.Name = "TabWallet"
        TabWallet.Padding = New Padding(3)
        TabWallet.Size = New Size(1104, 559)
        TabWallet.TabIndex = 3
        TabWallet.Text = "Wallet"
        TabWallet.UseVisualStyleBackColor = True
        ' 
        ' FormHome
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.New_Year_gifts
        ClientSize = New Size(1924, 1061)
        Controls.Add(Button1NewYeae)
        Controls.Add(ButtonInaugrationInvitation)
        Controls.Add(PictureThumbnailNewYear)
        Controls.Add(PicturethumbnailInaugrationInvitation)
        Controls.Add(ButtonChristmas)
        Controls.Add(ButtonBussinessInvitation)
        Controls.Add(PictureThumbnailChristmas)
        Controls.Add(PictureThumbnailBussinessInvitation)
        Controls.Add(ButtonValentine)
        Controls.Add(ButtonBabyShowerInvitation)
        Controls.Add(PictureThumbnailValentine)
        Controls.Add(PictureThumbnailBabyShowerInvitation)
        Controls.Add(ButtonRetirementWishing)
        Controls.Add(ButtonAnneversaryWishing)
        Controls.Add(ButtonBirthdayWishing)
        Controls.Add(ButtonWeddingInvitation)
        Controls.Add(ButtonAnneversiryInvi)
        Controls.Add(ButtonBDayInvi)
        Controls.Add(PictureThumbnailRetirementWishing)
        Controls.Add(PictureThumbnailAnneversaryWishing)
        Controls.Add(PictureThumbnailBirthdayWishing)
        Controls.Add(PictureThumbnailWeddingInvitation)
        Controls.Add(PictureThumbnailAniiverseryInvi)
        Controls.Add(LabelChooseTypeCard)
        Controls.Add(PictureThumnailBDayInvi)
        Name = "FormHome"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormHome"
        WindowState = FormWindowState.Maximized
        CType(PictureThumnailBDayInvi, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureThumbnailAniiverseryInvi, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureThumbnailWeddingInvitation, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureThumbnailBirthdayWishing, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureThumbnailAnneversaryWishing, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureThumbnailRetirementWishing, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureThumbnailValentine, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureThumbnailBabyShowerInvitation, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureThumbnailChristmas, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureThumbnailBussinessInvitation, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureThumbnailNewYear, ComponentModel.ISupportInitialize).EndInit()
        CType(PicturethumbnailInaugrationInvitation, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureThumnailBDayInvi As PictureBox
    Friend WithEvents LabelChooseTypeCard As Label
    Friend WithEvents PictureThumbnailAniiverseryInvi As PictureBox
    Friend WithEvents PictureThumbnailWeddingInvitation As PictureBox
    Friend WithEvents PictureThumbnailBirthdayWishing As PictureBox
    Friend WithEvents PictureThumbnailAnneversaryWishing As PictureBox
    Friend WithEvents PictureThumbnailRetirementWishing As PictureBox
    Friend WithEvents ButtonBDayInvi As Button
    Friend WithEvents ButtonAnneversiryInvi As Button
    Friend WithEvents ButtonWeddingInvitation As Button
    Friend WithEvents ButtonBirthdayWishing As Button
    Friend WithEvents ButtonAnneversaryWishing As Button
    Friend WithEvents ButtonRetirementWishing As Button
    Friend WithEvents ButtonValentine As Button
    Friend WithEvents ButtonBabyShowerInvitation As Button
    Friend WithEvents PictureThumbnailValentine As PictureBox
    Friend WithEvents PictureThumbnailBabyShowerInvitation As PictureBox
    Friend WithEvents ButtonChristmas As Button
    Friend WithEvents ButtonBussinessInvitation As Button
    Friend WithEvents PictureThumbnailChristmas As PictureBox
    Friend WithEvents PictureThumbnailBussinessInvitation As PictureBox
    Friend WithEvents Button1NewYeae As Button
    Friend WithEvents ButtonInaugrationInvitation As Button
    Friend WithEvents PictureThumbnailNewYear As PictureBox
    Friend WithEvents PicturethumbnailInaugrationInvitation As PictureBox
End Class
