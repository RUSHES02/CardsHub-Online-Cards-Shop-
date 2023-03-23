Imports System.Data.SqlClient
Imports System.IO

Public Class FormAdminCardEdit

    'sql variables
    Dim conn As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub FormAdminCardEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'adding types to type combo box
        ComboBoxType.Items.Add("Birthday Invitation")
        ComboBoxType.Items.Add("Wedding Invitation")
        ComboBoxType.Items.Add("Anniversary Invitation")
        ComboBoxType.Items.Add("Baby Shower Invitation")
        ComboBoxType.Items.Add("Business Party")
        ComboBoxType.Items.Add("Inaugration")
        ComboBoxType.Items.Add("Valentine")
        ComboBoxType.Items.Add("Retirement Wishing")
        ComboBoxType.Items.Add("Anniversary Wishing")
        ComboBoxType.Items.Add("Birthday Wishing")
        ComboBoxType.Items.Add("Christmas")
        ComboBoxType.Items.Add("New Year")

        'if the admin wants to edit card details
        If Not alterUid = 0 Then
            'disabling change card type and card image
            ButtonBrowseImage.Enabled = False
            ComboBoxType.Enabled = False

            'setting sql connection and fetching the details of that card
            conn.ConnectionString = "Data Source=LAPTOP-G773S8H7;Initial Catalog=SE-PROJECT;Integrated Security=True;"
            conn.Open()
            cmd = New SqlCommand("SELECT TableCards.Cardid, TableCards.CardTemplate, TableCards.Price, TableCardType.Type, TableCards.Name, TableInventory.Quantity FROM TableCards JOIN TableCardType ON TableCards.TypeId = TableCardType.TypeId JOIN TableInventory ON TableCards.CardId = TableInventory.CardId WHERE TableCards.CardId = @id", conn)
            cmd.Parameters.AddWithValue("@id", alterUid)
            Dim reader As SqlDataReader = cmd.ExecuteReader
            reader.Read()

            'setting al the controls with the fetched data
            Dim cardImage() As Byte
            cardImage = reader.Item("CardTemplate")
            Dim ms As New MemoryStream(cardImage)
            PictureBoxImageTemplate.Image = Image.FromStream(ms)
            TextBoxPrice.Text = reader.Item("Price")
            TextBoxQuantity.Text = reader.Item("Quantity")
            ComboBoxType.SelectedItem = reader.Item("Type")
            TextBoxName.Text = reader.Item("Name")
            conn.Close()
        End If
    End Sub

    'button to browse images for cards
    Private Sub ButtonBrowseImage_Click(sender As Object, e As EventArgs) Handles ButtonBrowseImage.Click
        OpenFileDialogSelectCardTemplate.FileName = ""
        OpenFileDialogSelectCardTemplate.Filter = "(Images)|*.jpg;*.png"
        If OpenFileDialogSelectCardTemplate.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBoxImageTemplate.Image = Image.FromFile(OpenFileDialogSelectCardTemplate.FileName)
        End If
    End Sub

    'button to save the details of the card
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        'if a new card is being added
        If alterUid = 0 Then
            conn.ConnectionString = "Data Source=LAPTOP-G773S8H7;Initial Catalog=SE-PROJECT;Integrated Security=True;"

            Dim sqlStatement = "INSERT INTO TableCards(CardId, CardTemplate, TypeId, Price, Name) VALUES ((SELECT ISNULL(MAX(CardId) + 1, 1) FROM TableCards), @cardTemplate, @typeId, @price, @name)"
            Dim imageTemp As New MemoryStream
            PictureBoxImageTemplate.Image.Save(imageTemp, PictureBoxImageTemplate.Image.RawFormat)

            conn.Open()
            cmd = New SqlCommand(sqlStatement, conn)
            cmd.Parameters.AddWithValue("@cardTemplate", imageTemp.ToArray)
            cmd.Parameters.AddWithValue("@typeId", ComboBoxType.SelectedIndex + 1)
            cmd.Parameters.AddWithValue("@price", TextBoxPrice.Text)
            cmd.Parameters.AddWithValue("@name", TextBoxName.Text)
            cmd.ExecuteNonQuery()

            cmd = New SqlCommand("INSERT INTO TableInventory(CardId, Quantity) VALUES ((SELECT ISNULL(MAX(CardId), 1) FROM TableCards), @quantity)", conn)
            cmd.Parameters.AddWithValue("@quantity", TextBoxQuantity.Text)
            cmd.ExecuteNonQuery()
            conn.Close()

            'updating card details to be ordered
        Else
            'updating the cards table
            conn.ConnectionString = "Data Source=LAPTOP-G773S8H7;Initial Catalog=SE-PROJECT;Integrated Security=True;"
            conn.Open()
            cmd = New SqlCommand("UPDATE TableCards SET Price = @price SET Name = @name WHERE CardId = @id", conn)
            cmd.Parameters.AddWithValue("@id", alterUid)
            cmd.Parameters.AddWithValue("@price", TextBoxPrice.Text)
            cmd.Parameters.AddWithValue("@name", TextBoxName.Text)
            cmd.ExecuteNonQuery()

            'updating the inventory
            cmd = New SqlCommand("UPDATE TableInventory SET Quantity = @quantity WHERE CardId = @id", conn)
            cmd.Parameters.AddWithValue("@id", alterUid)
            cmd.Parameters.AddWithValue("@quantity", TextBoxQuantity.Text)
            cmd.ExecuteNonQuery()

            conn.Close()
            alterUid = 0
        End If

        Me.Close()
        FormAdminCards.Show()

    End Sub

    'button back to admin cards page
    Private Sub PictureBoxBack_Click(sender As Object, e As EventArgs) Handles PictureBoxBack.Click
        Me.Close()
        FormAdminCards.Show()
    End Sub
End Class