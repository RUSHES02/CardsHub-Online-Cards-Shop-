Public Class FormChooseType
    Private Sub ButtonBithdayInvitation_Click(sender As Object, e As EventArgs) Handles ButtonBithdayInvitation.Click
        cardType = "BithdayInvitation"
        Me.Hide()
        FormCardList.Show()
    End Sub

    Private Sub ButtonWeddingInvitation_Click(sender As Object, e As EventArgs) Handles ButtonWeddingInvitation.Click
        cardType = "WeddingInvitation"
        Me.Hide()
        FormCardList.Show()
    End Sub

    Private Sub ButtonAnneversaryInvitation_Click(sender As Object, e As EventArgs) Handles ButtonAnneversaryInvitation.Click
        cardType = "AnneversaryInvitation"
        Me.Hide()
        FormCardList.Show()
    End Sub

    Private Sub ButtonBabyShowerInvitation_Click(sender As Object, e As EventArgs) Handles ButtonBabyShowerInvitation.Click
        cardType = "BabyShowerInvitation"
        Me.Hide()
        FormCardList.Show()
    End Sub

    Private Sub ButtonBusinessParty_Click(sender As Object, e As EventArgs) Handles ButtonBusinessParty.Click
        cardType = "BusinessParty"
        Me.Hide()
        FormCardList.Show()
    End Sub

    Private Sub ButtonInaugration_Click(sender As Object, e As EventArgs) Handles ButtonInaugration.Click
        cardType = "Inaugration"
        Me.Hide()
        FormCardList.Show()
    End Sub

    Private Sub ButtonValentine_Click(sender As Object, e As EventArgs) Handles ButtonValentine.Click
        cardType = "Valentine"
        Me.Hide()
        FormCardList.Show()
    End Sub

    Private Sub ButtonRetirementWishing_Click(sender As Object, e As EventArgs) Handles ButtonRetirementWishing.Click
        cardType = "RetirementWishing"
        Me.Hide()
        FormCardList.Show()
    End Sub

    Private Sub ButtonAnneversaryWishing_Click(sender As Object, e As EventArgs) Handles ButtonAnneversaryWishing.Click
        cardType = "AnneversaryWishing"
        Me.Hide()
        FormCardList.Show()
    End Sub

    Private Sub ButtonBirthdayWishing_Click(sender As Object, e As EventArgs) Handles ButtonBirthdayWishing.Click
        cardType = "BithdayWishing"
        Me.Hide()
        FormCardList.Show()
    End Sub

    Private Sub ButtonChristmas_Click(sender As Object, e As EventArgs) Handles ButtonChristmas.Click
        cardType = "Christmas"
        Me.Hide()
        FormCardList.Show()
    End Sub

    Private Sub ButtonNewYear_Click(sender As Object, e As EventArgs) Handles ButtonNewYear.Click
        cardType = "NewYear"
        Me.Hide()
        FormCardList.Show()
    End Sub
End Class