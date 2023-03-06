Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography
Imports Microsoft.Identity.Client

Public Class FormAdminCardEdit

    Dim conn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim alterId As New Integer

    Private Sub FormAdminCardEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxType.Items.Add("Bithday Invitation")
        ComboBoxType.Items.Add("Wedding Invitation")
        ComboBoxType.Items.Add("Anneversary Invitation")
        ComboBoxType.Items.Add("Baby Shower Invitation")
        ComboBoxType.Items.Add("Business Party")
        ComboBoxType.Items.Add("Inaugration")
        ComboBoxType.Items.Add("Valentine")
        ComboBoxType.Items.Add("Retirement Wishing")
        ComboBoxType.Items.Add("Anneversary Wishing")
        ComboBoxType.Items.Add("Bithday Wishing")
        ComboBoxType.Items.Add("Christmas")
        ComboBoxType.Items.Add("New Year")

        If Not alterUid = "" Then
            ButtonBrowseImage.Enabled = False
            ComboBoxType.Enabled = False
            alterId = Convert.ToDecimal(alterUid)
            conn.ConnectionString = "Data Source=LAPTOP-G773S8H7;Initial Catalog=SE-PROJECT;Integrated Security=True;"
            conn.Open()
            cmd = New SqlCommand("SELECT TableCards.Cardid, TableCards.CardTemplate, TableCards.Price, TableCardType.Type, TableInventory.Quantity FROM TableCards JOIN TableCardType ON TableCards.TypeId = TableCardType.TypeId JOIN TableInventory ON TableCards.CardId = TableInventory.CardId WHERE TableCards.CardId = @id", conn)
            cmd.Parameters.AddWithValue("@id", alterId)
            Dim reader As SqlDataReader = cmd.ExecuteReader
            reader.Read()
            Dim cardImage() As Byte
            cardImage = reader.Item("CardTemplate")
            Dim ms As New MemoryStream(cardImage)
            PictureBoxImageTemplate.Image = Image.FromStream(ms)
            TextBoxPrice.Text = reader.Item("Price")
            TextBoxQuantity.Text = reader.Item("Quantity")
            ComboBoxType.SelectedItem = reader.Item("Type")
            conn.Close()
        End If
    End Sub

    Private Sub ButtonBrowseImage_Click(sender As Object, e As EventArgs) Handles ButtonBrowseImage.Click
        OpenFileDialogSelectCardTemplate.FileName = ""
        OpenFileDialogSelectCardTemplate.Filter = "(Images)|*.jpg;*.png"
        If OpenFileDialogSelectCardTemplate.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBoxImageTemplate.Image = Image.FromFile(OpenFileDialogSelectCardTemplate.FileName)
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If alterUid = "" Then
            Dim uid As Integer
            uid = generateUid()
            conn.ConnectionString = "Data Source=LAPTOP-G773S8H7;Initial Catalog=SE-PROJECT;Integrated Security=True;"

            Dim sqlStatement = "INSERT INTO TableCards(CardId, CardTemplate, TypeId, Price) VALUES (@cardId, @cardTemplate, @typeId, @price)"
            Dim imageTemp As New MemoryStream
            PictureBoxImageTemplate.Image.Save(imageTemp, PictureBoxImageTemplate.Image.RawFormat)

            conn.Open()
            cmd = New SqlCommand(sqlStatement, conn)
            cmd.Parameters.AddWithValue("@cardId", uid)
            cmd.Parameters.AddWithValue("@cardTemplate", imageTemp.ToArray)
            cmd.Parameters.AddWithValue("@typeId", ComboBoxType.SelectedIndex + 1)
            cmd.Parameters.AddWithValue("@price", TextBoxPrice.Text)
            cmd.ExecuteNonQuery()

            cmd = New SqlCommand("INSERT INTO TableInventory(CardId, Quantity) VALUES (@cardId, @quantity)", conn)
            cmd.Parameters.AddWithValue("@cardId", uid)
            cmd.Parameters.AddWithValue("@quantity", TextBoxQuantity.Text)
            cmd.ExecuteNonQuery()
            conn.Close()

        Else
            conn.ConnectionString = "Data Source=LAPTOP-G773S8H7;Initial Catalog=SE-PROJECT;Integrated Security=True;"
            conn.Open()
            cmd = New SqlCommand("UPDATE TableCards SET Price = @price WHERE CardId = @id", conn)
            cmd.Parameters.AddWithValue("@id", alterId)
            cmd.Parameters.AddWithValue("@price", TextBoxPrice.Text)
            cmd.ExecuteNonQuery()

            cmd = New SqlCommand("UPDATE TableInventory SET Quantity = @quantity WHERE CardId = @id", conn)
            cmd.Parameters.AddWithValue("@id", alterId)
            cmd.Parameters.AddWithValue("@quantity", TextBoxQuantity.Text)
            cmd.ExecuteNonQuery()

            conn.Close()
            alterUid = ""
        End If

        Me.Close()
        FormAdmin.Show()

    End Sub

    Private Function generateUid() As Integer
        conn.ConnectionString = "Data Source=LAPTOP-G773S8H7;Initial Catalog=SE-PROJECT;Integrated Security=True;"
        conn.Open()
        cmd = New SqlCommand("SELECT TOP 1 CardId FROM TableCards ORDER BY CardId DESC", conn)
        Dim reader As SqlDataReader = cmd.ExecuteReader
        reader.Read()
        generateUid = reader("CardId") + 1
        conn.Close()
    End Function
End Class