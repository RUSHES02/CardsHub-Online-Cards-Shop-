<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
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
        ButtonAddNewCard = New Button()
        ButtonAlter = New Button()
        FlowLayoutAdmin = New FlowLayoutPanel()
        LabelTest = New Label()
        SuspendLayout()
        ' 
        ' ButtonAddNewCard
        ' 
        ButtonAddNewCard.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ButtonAddNewCard.Location = New Point(1038, 523)
        ButtonAddNewCard.Name = "ButtonAddNewCard"
        ButtonAddNewCard.Size = New Size(75, 23)
        ButtonAddNewCard.TabIndex = 1
        ButtonAddNewCard.Text = "Add New Card"
        ButtonAddNewCard.UseVisualStyleBackColor = True
        ' 
        ' ButtonAlter
        ' 
        ButtonAlter.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ButtonAlter.Location = New Point(853, 523)
        ButtonAlter.Name = "ButtonAlter"
        ButtonAlter.Size = New Size(75, 23)
        ButtonAlter.TabIndex = 2
        ButtonAlter.Text = "Alter"
        ButtonAlter.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutAdmin
        ' 
        FlowLayoutAdmin.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutAdmin.AutoScroll = True
        FlowLayoutAdmin.Location = New Point(12, 0)
        FlowLayoutAdmin.Name = "FlowLayoutAdmin"
        FlowLayoutAdmin.Padding = New Padding(5, 5, 0, 0)
        FlowLayoutAdmin.Size = New Size(1176, 460)
        FlowLayoutAdmin.TabIndex = 3
        ' 
        ' LabelTest
        ' 
        LabelTest.AutoSize = True
        LabelTest.Location = New Point(247, 498)
        LabelTest.Name = "LabelTest"
        LabelTest.Size = New Size(41, 15)
        LabelTest.TabIndex = 0
        LabelTest.Text = "Label1"' 
        ' FormAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1200, 557)
        Controls.Add(LabelTest)
        Controls.Add(FlowLayoutAdmin)
        Controls.Add(ButtonAlter)
        Controls.Add(ButtonAddNewCard)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "FormAdmin"
        StartPosition = FormStartPosition.CenterParent
        Text = "FormAdmin"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ButtonAddNewCard As Button
    Friend WithEvents ButtonAlter As Button
    Friend WithEvents FlowLayoutAdmin As FlowLayoutPanel
    Friend WithEvents LabelTest As Label
End Class
