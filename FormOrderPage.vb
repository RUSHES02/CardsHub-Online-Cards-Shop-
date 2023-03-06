Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormOrderPage
    Private Sub FormOrderPage_Load(sender As Object, e As EventArgs)
        Dim states() As String = {"Andhra Pradesh", "Arunachal Pradesh", "Assam", "Bihar", "Chhattisgarh", "Goa", "Gujarat", "Haryana", "Himachal Pradesh", "Jharkhand", "Karnataka", "Kerala", "Madhya Pradesh", "Maharashtra", "Manipur", "Meghalaya", "Mizoram", "Nagaland", "Odisha", "Punjab", "Rajasthan", "Sikkim", "Tamil Nadu", "Telangana", "Tripura", "Uttar Pradesh", "Uttarakhand", "West Bengal"}

        ' Add each state to the ComboBox control
        For Each state As String In states
            ComboBoxState.Items.Add(state)
        Next

    End Sub

    Private Sub FormOrderPage_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class