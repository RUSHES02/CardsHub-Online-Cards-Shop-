Imports System.IO
Imports System.Data.SqlClient
Imports System.Runtime.Intrinsics

Public Class FormCardList

    Private currentPanel As String = Nothing        'to store the name of the current panel ethat is being added
    Private totalPanel As Integer = 0               'to store the panel number that is being added

    'sql variables
    Dim conn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader

    Dim totalwidth = My.Computer.Screen.Bounds.Size.Width           'variable to store width of the screen
    Dim totalheight = My.Computer.Screen.Bounds.Size.Height         'variable to store the height of the screen
    Dim flowLayoutWidth As Double                                   'variable to store the width of the flow layout
    Dim panelWidth As Double                                        'variable to store the width of a indivisual panel
    Dim panelHeight As Double                                       'variable to store the width of a indivisual panel

    Private Sub FormCardList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'disabling price filter
        CheckedListBoxPrice.Visible = False
        LabelPrice.Visible = False

        'setting all the dimention of flow layout and indivisual panels
        flowLayoutWidth = (totalwidth * (6 / 7)) - 30
        FlowLayoutGiftList.Size = New Size(flowLayoutWidth, 750)
        FlowLayoutGiftList.Location = New Point((totalwidth / 7) + 30, 250)
        PanelSidePane.Size = New Size((totalwidth / 7), totalheight)
        PanelSidePane.Location = New Point(0, 250)
        panelWidth = flowLayoutWidth / 6 - 10
        panelHeight = panelWidth * 1.5 + 150

        'setting the banner size and location
        PictureBoxBanner.Size = New Size(flowLayoutWidth, 240)
        PictureBoxBanner.Location = New Point((totalwidth / 7) + 30, 5)

        'adding all cards to the flow layout
        enterAllCards()
    End Sub

    'button for back to login page
    Private Sub PictureBoxBack_Click(sender As Object, e As EventArgs) Handles PictureBoxBack.Click
        Me.Close()
        FormLogin.Show()
    End Sub

    'button to go to order history page
    Private Sub PictureBoxOrderHistory_Click(sender As Object, e As EventArgs) Handles PictureBoxOrderHistory.Click
        Me.Close()
        FormOrderHistory.Show()
    End Sub

    'applying type filter to the Gift list
    Private Sub CheckedListBoxFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBoxFilter.SelectedIndexChanged
        FlowLayoutGiftList.Controls.Clear()
        Dim l = CheckedListBoxFilter.CheckedItems.Count
        'if nothing is selected in the checked list
        If l = 0 Then
            'disabling price if no type is selected
            CheckedListBoxPrice.Visible = False
            LabelPrice.Visible = False
            enterAllCards()
        Else
            CheckedListBoxPrice.Visible = True
            LabelPrice.Visible = True
            enterAccordingToFilter()
        End If
    End Sub

    Private Sub CheckedListBoxPrice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBoxPrice.SelectedIndexChanged
        FlowLayoutGiftList.Controls.Clear()
        enterAccordingToFilter()
    End Sub

    Public Sub enterAccordingToFilter()
        LabelCategories.Visible = False
        FlowLayoutGiftList.Controls.Clear()

        If CheckedListBoxPrice.CheckedItems.Count = 0 Then
            enterAllCardsOfType()
        End If
        'if no price is selected in the checked list
        For Each itemPrice In CheckedListBoxPrice.CheckedItems
            If itemPrice = "All" Then
                LabelCategories.Visible = True
                enterAllCardsOfType()
                Return
            End If
        Next

        'looping throgh all the items selected in the checked list box and displaying the cards of that type
        For Each item In CheckedListBoxFilter.CheckedItems
            For Each itemPrice In CheckedListBoxPrice.CheckedItems
                'setting sql connection and selecting data according to type selected
                conn.ConnectionString = "Data Source=LAPTOP-G773S8H7;Initial Catalog=SE-PROJECT;Integrated Security=True;"
                conn.Open()

                If itemPrice = "Below ₹50" Then
                    cmd = New SqlCommand("SELECT TableGifts.Giftid, TableGifts.GiftTemplate, TableGifts.Price, TableGiftType.Type, TableGifts.Name FROM TableGifts JOIN TableGiftType ON TableGifts.TypeId = TableGiftType.TypeId WHERE TableGifts.TypeId = (SELECT TypeId FROM TableGiftType WHERE Type = @type) AND (TableGifts.Price < 50)", conn)
                    cmd.Parameters.AddWithValue("@type", item)
                    cmd.ExecuteNonQuery()
                End If

                If itemPrice = "₹50 - ₹100" Then
                    cmd = New SqlCommand("SELECT TableGifts.Giftid, TableGifts.GiftTemplate, TableGifts.Price, TableGiftType.Type, TableGifts.Name FROM TableGifts JOIN TableGiftType ON TableGifts.TypeId = TableGiftType.TypeId WHERE TableGifts.TypeId = (SELECT TypeId FROM TableGiftType WHERE Type = @type) AND (TableGifts.Price BETWEEN 50 AND 99)", conn)
                    cmd.Parameters.AddWithValue("@type", item)
                    cmd.ExecuteNonQuery()
                End If

                If itemPrice = "₹100 - ₹150" Then
                    cmd = New SqlCommand("SELECT TableGifts.Giftid, TableGifts.GiftTemplate, TableGifts.Price, TableGiftType.Type, TableGifts.Name FROM TableGifts JOIN TableGiftType ON TableGifts.TypeId = TableGiftType.TypeId WHERE TableGifts.TypeId = (SELECT TypeId FROM TableGiftType WHERE Type = @type) AND (TableGifts.Price BETWEEN 100 AND 150)", conn)
                    cmd.Parameters.AddWithValue("@type", item)
                    cmd.ExecuteNonQuery()
                End If

                If itemPrice = "Above ₹150" Then
                    cmd = New SqlCommand("SELECT TableGifts.Giftid, TableGifts.GiftTemplate, TableGifts.Price, TableGiftType.Type, TableGifts.Name FROM TableGifts JOIN TableGiftType ON TableGifts.TypeId = TableGiftType.TypeId WHERE TableGifts.TypeId = (SELECT TypeId FROM TableGiftType WHERE Type = @type) AND (TableGifts.Price > 150)", conn)
                    cmd.Parameters.AddWithValue("@type", item)
                    cmd.ExecuteNonQuery()
                End If
                reader = cmd.ExecuteReader
                If reader.HasRows() Then
                    While reader.Read()
                        'variable to store Gift image
                        Dim GiftImage() As Byte
                        GiftImage = reader.Item("GiftTemplate")
                        'converting Gift image to memory stream
                        Dim ms As New MemoryStream(GiftImage)
                        'setting the panel
                        createPanel(reader.Item("GiftId"))
                        createCardPictureBox(currentPanel, ms)
                        createCardLabelPrice(currentPanel, reader.Item("Price"))
                        createCardLabelName(currentPanel, reader.Item("Name"))
                        createCardButtonOpen(currentPanel)
                    End While
                End If
                conn.Close()
            Next
        Next

    End Sub

    'to all the cards in the database which are of the selected type
    Public Sub enterAllCardsOfType()
        FlowLayoutGiftList.Controls.Clear()
        For Each item In CheckedListBoxFilter.CheckedItems
            conn.ConnectionString = "Data Source=LAPTOP-G773S8H7;Initial Catalog=SE-PROJECT;Integrated Security=True;"
            conn.Open()
            cmd = New SqlCommand("SELECT TableGifts.Giftid, TableGifts.GiftTemplate, TableGifts.Price, TableGiftType.Type, TableGifts.Name FROM TableGifts JOIN TableGiftType ON TableGifts.TypeId = TableGiftType.TypeId WHERE TableGifts.TypeId = (SELECT TypeId FROM TableGiftType WHERE Type = @type)", conn)
            cmd.Parameters.AddWithValue("@type", item)
            cmd.ExecuteNonQuery()
            reader = cmd.ExecuteReader
            If reader.HasRows() Then
                While reader.Read()
                    'variable to store Gift image
                    Dim GiftImage() As Byte
                    GiftImage = reader.Item("GiftTemplate")
                    'converting Gift image to memory stream
                    Dim ms As New MemoryStream(GiftImage)
                    'setting the panel
                    createPanel(reader.Item("GiftId"))
                    createCardPictureBox(currentPanel, ms)
                    createCardLabelPrice(currentPanel, reader.Item("Price"))
                    createCardLabelName(currentPanel, reader.Item("Name"))
                    createCardButtonOpen(currentPanel)
                End While
            End If
            conn.Close()
        Next
    End Sub

    'to enter all cards from the database
    Public Sub enterAllCards()
        conn.ConnectionString = "Data Source=LAPTOP-G773S8H7;Initial Catalog=SE-PROJECT;Integrated Security=True;"
        conn.Open()
        cmd = New SqlCommand("SELECT TableGifts.Giftid, TableGifts.GiftTemplate, TableGifts.Price, TableGiftType.Type, TableGifts.Name FROM TableGifts JOIN TableGiftType ON TableGifts.TypeId = TableGiftType.TypeId", conn)
        reader = cmd.ExecuteReader

        While reader.Read()
            Dim GiftImage() As Byte
            GiftImage = reader.Item("GiftTemplate")
            Dim ms As New MemoryStream(GiftImage)
            createPanel(reader.Item("GiftId"))
            createCardPictureBox(currentPanel, ms)
            createCardLabelPrice(currentPanel, reader.Item("Price"))
            createCardLabelName(currentPanel, reader.Item("Name"))
            createCardButtonOpen(currentPanel)
        End While
        conn.Close()
    End Sub

    'adding panels to the flow layout
    Public Sub createPanel(ByVal uid As String)
        Dim cardPanel As Panel
        cardPanel = New Panel()
        'Set panel properties
        With cardPanel
            .BackColor = Color.White
            .Size = New Size(panelWidth, panelHeight)
            .Name = uid + "Pane"
            .BackColor = Color.White
        End With

        'Add panel to layout panel
        FlowLayoutGiftList.Controls.Add(cardPanel)

        currentPanel = cardPanel.Name
    End Sub

    'adding picture box to the panel and card image
    Public Sub createCardPictureBox(ByVal panelName As String, ByVal ms As MemoryStream)
        Dim GiftTemplate As PictureBox
        GiftTemplate = New PictureBox

        'Set picture box properties
        With GiftTemplate
            .SizeMode = PictureBoxSizeMode.Zoom
            .Size = New Drawing.Size(panelWidth - 10, (panelWidth - 10) * 1.5)
            .Location = New Point(5, 5)
            .Name = "GiftTemplate" + currentPanel
            .Image = Image.FromStream(ms)
        End With

        'Add Gift image to the layout
        For Each controlObject In FlowLayoutGiftList.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(GiftTemplate)
            End If
        Next
    End Sub

    'adding label name to the panel and Gift image
    Public Sub createCardLabelName(ByVal panelName As String, ByVal name As String)
        Dim GiftLabelName As Label
        GiftLabelName = New Label

        'Set label name properties
        With GiftLabelName
            .AutoSize = True
            .Location = New Point(5, (panelWidth - 10) * 1.5 + 10)
            .Name = "GiftLabelName" + currentPanel
            .Text = name
            .AutoSize = True
            .MaximumSize = New Size(panelWidth, 0)
            .Font = New Font("Book Antiqua", 14)
        End With

        'Add label name to the panel
        For Each controlObject In FlowLayoutGiftList.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(GiftLabelName)
            End If
        Next
    End Sub

    'adding label price to the panel and card image
    Public Sub createCardLabelPrice(ByVal panelName As String, ByVal price As String)
        Dim cardLabelPrice As Label
        cardLabelPrice = New Label

        'Set label price properties
        With cardLabelPrice
            .AutoSize = True
            .Location = New Point(5, panelHeight - 80)
            .Name = "GiftLabelPrice" + currentPanel
            .Text = "₹" + price
            .Font = New Font("Book Antiqua", 14)
        End With

        'Add label name to the panel
        For Each controlObject In FlowLayoutGiftList.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(cardLabelPrice)
            End If
        Next
    End Sub

    'creating and adding button to open the card apge
    Public Sub createCardButtonOpen(ByVal panelName As String)
        Dim buttonOpen As Button
        buttonOpen = New Button

        'setting button properties
        With buttonOpen
            .AutoSize = False
            .Size = New Size(panelWidth - 10, 50)
            .Location = New Point(5, panelHeight - 55)
            .Name = currentPanel + "buttonOpen"
            .Text = "Buy Now"
            .BackColor = Color.Black
            .ForeColor = Color.White
            .Font = New Font("Arial Rounded MT Bold", 14)
        End With

        'adding button to the panel
        For Each controlObject In FlowLayoutGiftList.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(buttonOpen)
            End If
        Next
        'adding handler to the button
        AddHandler buttonOpen.Click, AddressOf DynamicButton_Click
    End Sub

    'funtion to open the card page of the selected card
    Public Sub DynamicButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim cardId = ""
        For Each c As Char In sender.name
            If Char.IsNumber(c) Then
                cardId += c
            Else
                Exit For
            End If
        Next

        selectCardUid = Convert.ToDecimal(cardId)
        Me.Hide()
        FormCardPage.Show()
    End Sub

    Private Sub FormCardList_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormLogin.Show()
    End Sub
End Class