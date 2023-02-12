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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabHome = New System.Windows.Forms.TabPage()
        Me.TabWatchlist = New System.Windows.Forms.TabPage()
        Me.TabHoldings = New System.Windows.Forms.TabPage()
        Me.TabWallet = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabHome)
        Me.TabControl1.Controls.Add(Me.TabWatchlist)
        Me.TabControl1.Controls.Add(Me.TabHoldings)
        Me.TabControl1.Controls.Add(Me.TabWallet)
        Me.TabControl1.Location = New System.Drawing.Point(2, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1112, 587)
        Me.TabControl1.TabIndex = 0
        '
        'TabHome
        '
        Me.TabHome.Location = New System.Drawing.Point(4, 24)
        Me.TabHome.Margin = New System.Windows.Forms.Padding(10)
        Me.TabHome.Name = "TabHome"
        Me.TabHome.Padding = New System.Windows.Forms.Padding(3)
        Me.TabHome.Size = New System.Drawing.Size(1104, 559)
        Me.TabHome.TabIndex = 0
        Me.TabHome.Text = "Home"
        Me.TabHome.UseVisualStyleBackColor = True
        '
        'TabWatchlist
        '
        Me.TabWatchlist.Location = New System.Drawing.Point(4, 24)
        Me.TabWatchlist.Name = "TabWatchlist"
        Me.TabWatchlist.Padding = New System.Windows.Forms.Padding(3)
        Me.TabWatchlist.Size = New System.Drawing.Size(1104, 559)
        Me.TabWatchlist.TabIndex = 1
        Me.TabWatchlist.Text = "Watchlist"
        Me.TabWatchlist.UseVisualStyleBackColor = True
        '
        'TabHoldings
        '
        Me.TabHoldings.Location = New System.Drawing.Point(4, 24)
        Me.TabHoldings.Name = "TabHoldings"
        Me.TabHoldings.Padding = New System.Windows.Forms.Padding(3)
        Me.TabHoldings.Size = New System.Drawing.Size(1104, 559)
        Me.TabHoldings.TabIndex = 2
        Me.TabHoldings.Text = "Holdings"
        Me.TabHoldings.UseVisualStyleBackColor = True
        '
        'TabWallet
        '
        Me.TabWallet.Location = New System.Drawing.Point(4, 24)
        Me.TabWallet.Name = "TabWallet"
        Me.TabWallet.Padding = New System.Windows.Forms.Padding(3)
        Me.TabWallet.Size = New System.Drawing.Size(1104, 559)
        Me.TabWallet.TabIndex = 3
        Me.TabWallet.Text = "Wallet"
        Me.TabWallet.UseVisualStyleBackColor = True
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1114, 591)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormHome"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabHome As TabPage
    Friend WithEvents TabWatchlist As TabPage
    Friend WithEvents TabHoldings As TabPage
    Friend WithEvents TabWallet As TabPage
End Class
