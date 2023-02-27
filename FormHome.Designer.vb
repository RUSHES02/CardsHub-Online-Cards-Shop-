<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHome
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
        TabControl1 = New TabControl()
        TabHome = New TabPage()
        Button1 = New Button()
        ButtonAddWatchlist = New Button()
        ListViewHome = New ListView()
        ColumnCompanyName = New ColumnHeader()
        ColumnStockName = New ColumnHeader()
        ColumnPrice = New ColumnHeader()
        ColumnWatchlist = New ColumnHeader()
        TabWatchlist = New TabPage()
        TabHoldings = New TabPage()
        TabWallet = New TabPage()
        TabControl1.SuspendLayout()
        TabHome.SuspendLayout()
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
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1114, 591)
        Controls.Add(TabControl1)
        Name = "FormHome"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormHome"
        TabControl1.ResumeLayout(False)
        TabHome.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabHome As TabPage
    Friend WithEvents TabWatchlist As TabPage
    Friend WithEvents TabHoldings As TabPage
    Friend WithEvents TabWallet As TabPage
    Friend WithEvents ListViewHome As ListView
    Friend WithEvents ColumnCompanyName As ColumnHeader
    Friend WithEvents ColumnStockName As ColumnHeader
    Friend WithEvents ColumnPrice As ColumnHeader
    Friend WithEvents ButtonAddWatchlist As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ColumnWatchlist As ColumnHeader
End Class
