Public Class FormCardList

    Private Sub FormCardList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = cardType
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Close()
        FormHome.Show()
    End Sub
End Class