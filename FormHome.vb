Public Class FormHome
    Private Sub FormHome_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonBDayInvi_Click(sender As Object, e As EventArgs) Handles ButtonBDayInvi.Click
        cardType = "Birtday Invitation"
        Me.Hide()
        FormCardList.Show()
    End Sub

    Private Sub ButtonAnneversiryInvi_Click(sender As Object, e As EventArgs) Handles ButtonAnneversiryInvi.Click
        cardType = "Anneversery Invitation"
        Me.Hide()
        FormCardList.Show()
    End Sub

    Private Sub ButtonWeddingInvitation_Click(sender As Object, e As EventArgs) Handles ButtonWeddingInvitation.Click
        cardType = "Wedding Invitation"
        Me.Hide()
        FormCardList.Show()
    End Sub

    Private Sub ButtonBabyShowerInvitation_Click(sender As Object, e As EventArgs) Handles ButtonBabyShowerInvitation.Click
        cardType = "Baby Shower Invitation"
        Me.Hide()
        FormCardList.Show()
    End Sub

    Private Sub ButtonBussinessInvitation_Click(sender As Object, e As EventArgs) Handles ButtonBussinessInvitation.Click
        cardType = "Business Invitation"
        Me.Hide()
        FormCardList.Show()
    End Sub

    Private Sub ButtonInaugrationInvitation_Click(sender As Object, e As EventArgs) Handles ButtonInaugrationInvitation.Click
        cardType = "Inaugration Invitation"
        Me.Hide()
        FormCardList.Show()
    End Sub

    Private Sub Button1NewYeae_Click(sender As Object, e As EventArgs) Handles Button1NewYeae.Click
        cardType = "New Year Wish"
        Me.Hide()
        FormCardList.Show()
    End Sub

    Private Sub ButtonChristmas_Click(sender As Object, e As EventArgs) Handles ButtonChristmas.Click
        cardType = "Christmas Wish"
        Me.Hide()
        FormCardList.Show()
    End Sub

    Private Sub ButtonValentine_Click(sender As Object, e As EventArgs) Handles ButtonValentine.Click
        cardType = "Valentine Wish"
        Me.Hide()
        FormCardList.Show()
    End Sub

    Private Sub ButtonRetirementWishing_Click(sender As Object, e As EventArgs) Handles ButtonRetirementWishing.Click
        cardType = "Retirement Wish"
        Me.Hide()
        FormCardList.Show()
    End Sub

    Private Sub ButtonAnneversaryWishing_Click(sender As Object, e As EventArgs) Handles ButtonAnneversaryWishing.Click
        cardType = "Anneversary Wish"
        Me.Hide()
        FormCardList.Show()
    End Sub

    Private Sub ButtonBirthdayWishing_Click(sender As Object, e As EventArgs) Handles ButtonBirthdayWishing.Click
        cardType = "Birthday Wish"
        Me.Hide()
        FormCardList.Show()
    End Sub
End Class
