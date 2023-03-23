Imports System.IO
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles
Imports System.Reflection.Emit
Imports Microsoft.Data.SqlClient.DataClassification

Public Class FormCardPage

    'sql variables
    Dim conn As New SqlConnection
    Dim cmd As New SqlCommand

    Dim mrp As Integer              'to store the mrp of a single card
    Dim quantityLeft As Integer     'to store the quantity of the card

    Private Sub FormCardPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'setting the labels of the discounted invisible
        LabelDiscountedPrice.Visible = False
        LabelRsDiscount.Visible = False

        'setting the quantity to 1 by default
        TextBoxQuantity.Text = 1

        'setting the visibility of quantity error label false
        LabelQuantityError.Visible = False

        'setting sql connection and running query to all card details
        conn.ConnectionString = "Data Source=LAPTOP-G773S8H7;Initial Catalog=SE-PROJECT;Integrated Security=True;"
        conn.Open()
        cmd = New SqlCommand("SELECT TableCards.Cardid, TableCards.CardTemplate, TableCards.Price, TableCardType.Type, TableCards.Name, TableInventory.Quantity FROM TableCards JOIN TableCardType ON TableCards.TypeId = TableCardType.TypeId JOIN TableInventory ON TableCards.CardId = TableInventory.CardId WHERE TableCards.CardId = @id", conn)
        cmd.Parameters.AddWithValue("@id", selectCardUid)
        'sql reader
        Dim reader As SqlDataReader = cmd.ExecuteReader
        reader.Read()
        'variable to store image
        Dim cardImage() As Byte
        cardImage = reader.Item("CardTemplate")
        'converting the  image to memory stream
        Dim ms As New MemoryStream(cardImage)

        'setting all the data from sql to the components
        PictureBoxCardTemplate.Image = Image.FromStream(ms)
        LabelMRP.Text = reader.Item("Price")
        mrp = reader.Item("Price")
        LabelName.Text = reader.Item("Name")
        quantityLeft = reader.Item("Quantity")
        setContent(reader.Item("Type"))
        conn.Close()
    End Sub

    'button for back
    Private Sub PictureBoxBack_Click(sender As Object, e As EventArgs) Handles PictureBoxBack.Click
        selectCardUid = 0
        quantitySelected = 0
        Me.Close()
        FormCardList.Show()
    End Sub

    'buy now button to go to order page
    Private Sub ButtonBuyNow_Click(sender As Object, e As EventArgs) Handles ButtonBuyNow.Click
        'checking if the inventory has cards as specified
        If Not LabelQuantityError.Visible Then
            quantitySelected = TextBoxQuantity.Text
            costprice = quantitySelected * mrp
            Me.Close()
            FormOrderPage.Show()
        End If
    End Sub

    'to check any change in the text box quantity and diplay price and discounted price accordingly
    Private Sub TextBoxQuantity_TextChanged(sender As Object, e As EventArgs) Handles TextBoxQuantity.TextChanged
        'to check if the quantity is not set 
        If Not (TextBoxQuantity.Text = "" Or TextBoxQuantity.Text = "0") Then
            'checking if the inventory has cards as specified
            If TextBoxQuantity.Text > quantityLeft Then
                LabelQuantityError.Visible = True
                LabelQuantityError.Text = "SORRY! Only " + CStr(quantityLeft) + " units left"
            Else
                LabelQuantityError.Visible = False
            End If

            'if the quantity is set set the mrp accordingly
            LabelMRP.Text = TextBoxQuantity.Text * mrp
            LabelMRP.ForeColor = Color.FromArgb(41, 191, 18)
            LabelRsMRP.ForeColor = Color.FromArgb(41, 191, 18)

            'if the quantity is more than 50 apply discount
            If TextBoxQuantity.Text > 50 Then
                totalAmount = LabelMRP.Text - (1.24 * TextBoxQuantity.Text)
                LabelDiscountedPrice.Text = totalAmount
                LabelDiscountedPrice.Visible = True
                LabelRsDiscount.Visible = True
                LabelMRP.Font = New Font(LabelMRP.Font, LabelMRP.Font.Style Or FontStyle.Strikeout)
                LabelMRP.ForeColor = Color.FromArgb(208, 0, 0)
                LabelRsMRP.ForeColor = Color.FromArgb(208, 0, 0)

                'if the quantity is set less than 51 remove discount 
            Else
                LabelDiscountedPrice.Visible = False
                LabelRsDiscount.Visible = False
                LabelMRP.Text = TextBoxQuantity.Text * mrp
                totalAmount = LabelMRP.Text
                LabelMRP.Font = New Font(LabelMRP.Font, LabelMRP.Font.Style And Not FontStyle.Strikeout)
                LabelMRP.ForeColor = Color.FromArgb(41, 191, 18)
                LabelRsMRP.ForeColor = Color.FromArgb(41, 191, 18)
            End If

            'if the quantity is not set
        Else
            LabelQuantityError.Visible = False
            LabelDiscountedPrice.Visible = False
            LabelRsDiscount.Visible = False
            TextBoxQuantity.Text = 1
            LabelMRP.Text = TextBoxQuantity.Text * mrp
            totalAmount = LabelMRP.Text
            LabelMRP.Font = New Font(LabelMRP.Font, LabelMRP.Font.Style And Not FontStyle.Strikeout)
            LabelMRP.ForeColor = Color.FromArgb(41, 191, 18)
        End If
    End Sub

    'to check only numbers are being enterd in the quantity text box
    Private Sub TextBoxQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxQuantity.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'set content text box according to the type
    Public Sub setContent(ByVal type As String)
        If type = "Birthday Invitation" Then
            RichTextBoxContent.Text = "Kindly grace us with your presence at (birthday boy/girl name) birthday party, adding a year with you is such a blessing!"

        ElseIf type = "Wedding Invitation" Then
            RichTextBoxContent.Text = "Mr. and Mrs. John Smith. Request the honor of your presence at the marriage of their daughter Sarah Elizabeth to Mr. Michael Johnson on. Saturday,July 15 2023."

        ElseIf type = "Anniversary Invitation" Then
            RichTextBoxContent.Text = "I am inviting you to my wedding anniversary this weekend. Please be a part of our celebration. Today we are so excited to invite you to join us and share in our happiness as we celebrate our wedding anniversary. It will be a pleasure for us to have you on this momentous occasion."

        ElseIf type = "Baby Shower Invitation" Then
            RichTextBoxContent.Text = "It’s almost time to welcome our little man to the world! Join us in showering the mom and her new bundle-to-be with lots of love."

        ElseIf type = "Business Party" Then
            RichTextBoxContent.Text = "To celebrate the progress of our company, (company name) is planning an event at the end of this month. Your presence is requested at the party. (Company name) cordially invites you and a guest to the upcoming celebration of our company’s success party. Do come and celebrate with us.We ask you to be present at the ceremony of our new business venture. You and your guest’s presence at the event will be very much appreciated."

        ElseIf type = "Inauguration" Then
            RichTextBoxContent.Text = "It gives us great pleasure to announce that. With the grace of Bhagwan Swaminarayan,the opening of our new office. We request your presence to help us celeberate this happy occasion on Saturday, 12th May 2023, 11.00am onwards,followed by Lunch."

        ElseIf type = "Valentine's" Then
            RichTextBoxContent.Text = "The wind carried away the name I scrawled in the sky for you. The waves swept away the name I had scrawled in the sand for you. I permanently inscribed your name in my heart"

        ElseIf type = "Retirement Wishing" Then
            RichTextBoxContent.Text = "Sending my wonderful wishes to you for your retirement. May your golden years be the most fun and joy of your life. Happy Retirement!"

        ElseIf type = "Anniversary Wishing" Then
            RichTextBoxContent.Text = "Happy anniversary to the most resolved and loved couple. May the love in your relationship multiples day and night."

        ElseIf type = "Birthday Wishing" Then
            RichTextBoxContent.Text = "Wishing you a day filled with happiness and a year filled with joy. Happy birthday!Sending you smiles for every moment of your special day…Have a wonderful time and a very happy birthday! Hope your special day brings you all that your heart desires!"

        ElseIf type = "Christmas" Then
            RichTextBoxContent.Text = "May your heart be lifted in praise this Christmas for the wonderful gift of Jesus and the joy He brings to our lives !! Merry Christmas"

        ElseIf type = "New Year" Then
            RichTextBoxContent.Text = "Here's to another year full of joy, laughter, and unforgettable memories with an unforgettable friend! Knowing you have been a master class in true friendship. During the New Year, I hope to emulate your love and warmth. I wish you a very Happy New Year."
        End If
    End Sub
End Class
