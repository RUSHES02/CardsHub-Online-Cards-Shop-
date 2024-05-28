Imports System.Data.SqlClient
Imports System.IO

Public Class FormAdminCardEdit

    'sql variables
    Dim conn As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub FormAdminCardEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormCardPage.Close()
        FormLogin.Hide()
        'adding types to type combo box
        ComboBoxType.Items.Add("Birthday")
        ComboBoxType.Items.Add("Wedding")
        ComboBoxType.Items.Add("Anniversary")
        ComboBoxType.Items.Add("Valentine")
        ComboBoxType.Items.Add("Festival")
        ComboBoxType.Items.Add("Others")

        'if the admin wants to edit card details
        If Not alterUid = 0 Then
            'disabling change Gift type and Gift image
            ComboBoxType.Enabled = False
            ButtonBrowseImage.Visible = False

            'setting sql connection and fetching the details of that Gift
            conn.ConnectionString = "Data Source=LAPTOP-G773S8H7;Initial Catalog=SE-PROJECT;Integrated Security=True;"
            conn.Open()
            cmd = New SqlCommand("SELECT TableGifts.Giftid, TableGifts.GiftTemplate, TableGifts.Price, TableGiftType.Type, TableGifts.Name, TableInventory.Quantity FROM TableGifts JOIN TableGiftType ON TableGifts.TypeId = TableGiftType.TypeId JOIN TableInventory ON TableGifts.GiftId = TableInventory.GiftId WHERE TableGifts.GiftId = @id", conn)
            cmd.Parameters.AddWithValue("@id", alterUid)
            Dim reader As SqlDataReader = cmd.ExecuteReader
            reader.Read()

            'setting al the controls with the fetched data
            Dim GiftImage() As Byte
            GiftImage = reader.Item("GiftTemplate")
            Dim ms As New MemoryStream(GiftImage)
            PictureBoxImageTemplate.Image = Image.FromStream(ms)
            TextBoxPrice.Text = reader.Item("Price")
            TextBoxQuantity.Text = reader.Item("Quantity")
            ComboBoxType.SelectedItem = reader.Item("Type")
            TextBoxName.Text = reader.Item("Name")
            conn.Close()
        End If
    End Sub

    'button to browse images for Gifts
    Private Sub ButtonBrowseImage_Click(sender As Object, e As EventArgs) Handles ButtonBrowseImage.Click
        OpenFileDialogSelectCardTemplate.FileName = ""
        OpenFileDialogSelectCardTemplate.Filter = "(Images)|*.jpg;*.png"
        If OpenFileDialogSelectCardTemplate.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBoxImageTemplate.Image = Image.FromFile(OpenFileDialogSelectCardTemplate.FileName)
        End If
    End Sub

    'to check only numbers are being enterd in the quantity text box
    Private Sub TextBoxPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxPrice.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    'to check only numbers are being enterd in the quantity text box
    Private Sub TextBoxQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxQuantity.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    'button to save the details of the Gift
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        'if a new Gift is being added
        If alterUid = 0 Then
            conn.ConnectionString = "Data Source=LAPTOP-G773S8H7;Initial Catalog=SE-PROJECT;Integrated Security=True;"

            Dim sqlStatement = "INSERT INTO TableGifts(GiftId, GiftTemplate, TypeId, Price, Name) VALUES ((SELECT ISNULL(MAX(GiftId) + 1, 1) FROM TableGifts), @GiftTemplate, @typeId, @price, @name)"
            Dim imageTemp As New MemoryStream
            PictureBoxImageTemplate.Image.Save(imageTemp, PictureBoxImageTemplate.Image.RawFormat)

            conn.Open()
            cmd = New SqlCommand(sqlStatement, conn)
            cmd.Parameters.AddWithValue("@GiftTemplate", imageTemp.ToArray)
            cmd.Parameters.AddWithValue("@typeId", ComboBoxType.SelectedIndex + 1)
            cmd.Parameters.AddWithValue("@price", TextBoxPrice.Text)
            cmd.Parameters.AddWithValue("@name", TextBoxName.Text)
            cmd.ExecuteNonQuery()

            cmd = New SqlCommand("INSERT INTO TableInventory(GiftId, Quantity) VALUES ((SELECT ISNULL(MAX(GiftId), 1) FROM TableGifts), @quantity)", conn)
            cmd.Parameters.AddWithValue("@quantity", TextBoxQuantity.Text)
            cmd.ExecuteNonQuery()
            conn.Close()
            alterUid = 0

            'updating Gift details to be ordered
        Else
            'updating the Gifts table
            conn.ConnectionString = "Data Source=LAPTOP-G773S8H7;Initial Catalog=SE-PROJECT;Integrated Security=True;"
            conn.Open()
            cmd = New SqlCommand("UPDATE TableGifts SET Price = @price, Name = @name WHERE GiftId = @id", conn)
            cmd.Parameters.AddWithValue("@id", alterUid)
            cmd.Parameters.AddWithValue("@price", TextBoxPrice.Text)
            cmd.Parameters.AddWithValue("@name", TextBoxName.Text)
            cmd.ExecuteNonQuery()

            'updating the inventory
            cmd = New SqlCommand("UPDATE TableInventory SET Quantity = @quantity WHERE GiftId = @id", conn)
            cmd.Parameters.AddWithValue("@id", alterUid)
            cmd.Parameters.AddWithValue("@quantity", TextBoxQuantity.Text)
            cmd.ExecuteNonQuery()

            conn.Close()
            alterUid = 0
        End If

        Me.Close()
        FormAdminCards.Show()

    End Sub

    'button back to admin Gifts page
    Private Sub PictureBoxBack_Click(sender As Object, e As EventArgs) Handles PictureBoxBack.Click
        alterUid = 0
        Me.Close()
        FormAdminCards.Show()
    End Sub

    Private Sub FormAdminCardEdit_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormAdminCards.Show()
    End Sub
End Class