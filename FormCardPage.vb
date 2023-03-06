Public Class FormCardPage

    Private Sub ButtonBuyNow_Click(sender As Object, e As EventArgs) Handles ButtonBuyNow.Click
        Me.Close()
        FormOrderPage.Show()
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Close()
        FormCardList.Show()
    End Sub

    Private Sub FormCardPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class