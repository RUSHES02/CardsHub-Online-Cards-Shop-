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
        Label1 = New Label()
        ButtonBack = New Button()
        FlowLayoutCardList = New FlowLayoutPanel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(622, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 0
        Label1.Text = "Label1"' 
        ' ButtonBack
        ' 
        ButtonBack.Location = New Point(1023, 33)
        ButtonBack.Name = "ButtonBack"
        ButtonBack.Size = New Size(75, 23)
        ButtonBack.TabIndex = 1
        ButtonBack.Text = "Back"
        ButtonBack.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutCardList
        ' 
        FlowLayoutCardList.AutoScroll = True
        FlowLayoutCardList.FlowDirection = FlowDirection.TopDown
        FlowLayoutCardList.Location = New Point(0, 142)
        FlowLayoutCardList.Name = "FlowLayoutCardList"
        FlowLayoutCardList.Padding = New Padding(10, 5, 0, 0)
        FlowLayoutCardList.Size = New Size(1123, 610)
        FlowLayoutCardList.TabIndex = 4
        FlowLayoutCardList.WrapContents = False
        ' 
        ' FormCardList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1124, 751)
        Controls.Add(FlowLayoutCardList)
        Controls.Add(ButtonBack)
        Controls.Add(Label1)
        Name = "FormCardList"
        Text = "FormCardList"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonBack As Button
    Friend WithEvents FlowLayoutCardList As FlowLayoutPanel
End Class
