Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Threading.Tasks.Dataflow

Public Class FormAdminCards

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
    Dim panelHeight As Double                                        'variable to store the width of a indivisual panel

    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'setting all the dimention of flow layout and indivisual panels
        flowLayoutWidth = (totalwidth * (6 / 7)) - 30
        FlowLayoutAdmin.Size = New Size(flowLayoutWidth, totalheight - 250)
        FlowLayoutAdmin.Location = New Point((totalwidth / 7) + 30, 250)
        PanelSidePane.Size = New Size((totalwidth / 7), totalheight)
        PanelSidePane.Location = New Point(0, 250)
        panelWidth = flowLayoutWidth / 6 - 10
        panelHeight = panelWidth * 1.5 + 150

        'setting the banner size and location
        PictureBoxBanner.Size = New Size(flowLayoutWidth, 240)
        PictureBoxBanner.Location = New Point((totalwidth / 7) + 30, 5)

        'adding all cards to the flow layout
        enterAllCards()
        LabelNotFound.Visible = False

    End Sub

    'button for adding new card to the inventory
    Private Sub PictureBoxAddNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PictureBoxAddNew.Click
        Me.Close()
        FormAdminCardEdit.Show()
    End Sub

    'button for back to login page
    Private Sub PictureBoxBack_Click(sender As Object, e As EventArgs) Handles PictureBoxBack.Click
        Me.Close()
        FormLogin.Show()
    End Sub

    'button to go to order history 
    Private Sub PictureBoxOrderHistory_Click(sender As Object, e As EventArgs) Handles PictureBoxOrderHistory.Click
        Me.Close()
        FormOrderHistory.Show()
    End Sub

    'applying type filter to the card list
    Private Sub CheckedListBoxFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBoxFilter.SelectedIndexChanged
        FlowLayoutAdmin.Controls.Clear()
        Dim l = CheckedListBoxFilter.CheckedItems.Count
        'if nothing is selected in the checked list
        If l = 0 Then
            enterAllCards()

        Else
            'looping throgh all the items selected in the checked list box and displaying the cards of that type
            For Each item In CheckedListBoxFilter.CheckedItems
                'setting sql connection and selecting data according to type selected
                conn.ConnectionString = "Data Source=LAPTOP-G773S8H7;Initial Catalog=SE-PROJECT;Integrated Security=True;"
                conn.Open()
                cmd = New SqlCommand("SELECT TableCards.CardId, TableCards.CardTemplate, TableCards.Price, TableCardType.Type, TableCards.Name, TableInventory.Quantity FROM TableCards JOIN TableCardType ON TableCards.TypeId = TableCardType.TypeId JOIN TableInventory ON TableCards.CardId = TableInventory.CardId WHERE TableCards.TypeId = (SELECT TypeId FROM TableCardType WHERE Type = @type)", conn)
                cmd.Parameters.AddWithValue("@type", item)
                cmd.ExecuteNonQuery()
                reader = cmd.ExecuteReader
                If reader.HasRows() Then
                    While reader.Read()
                        'variable to store card image
                        Dim cardImage() As Byte
                        cardImage = reader.Item("CardTemplate")
                        'converting card image to memory stream
                        Dim ms As New MemoryStream(cardImage)
                        'setting the panel
                        createPanel(reader.Item("CardId"))
                        createCardPictureBox(currentPanel, ms)
                        createCardLabelName(currentPanel, reader.Item("Name"), reader.Item("Cardid"))
                        createCardLabelType(currentPanel, reader.Item("Type"))
                        createCardLabelPrice(currentPanel, reader.Item("Price"))
                        createCardLabelQuantity(currentPanel, reader.Item("Quantity"))
                        createCardButtonAlter(currentPanel)
                    End While
                End If
                conn.Close()
            Next
        End If
    End Sub

    'search cards by id
    Private Sub TextBoxSearchId_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearchId.TextChanged
        FlowLayoutAdmin.Controls.Clear()
        LabelNotFound.Visible = False
        If TextBoxSearchId.Text = "" Then
            enterAllCards()

        Else
            Try
                conn.ConnectionString = "Data Source=LAPTOP-G773S8H7;Initial Catalog=SE-PROJECT;Integrated Security=True;"
                conn.Open()
                cmd = New SqlCommand("SELECT TableCards.CardId, TableCards.CardTemplate, TableCards.Price, TableCardType.Type, TableCards.Name, TableInventory.Quantity FROM TableCards JOIN TableCardType ON TableCards.TypeId = TableCardType.TypeId JOIN TableInventory ON TableCards.CardId = TableInventory.CardId WHERE TableCards.CardId = @id", conn)
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(TextBoxSearchId.Text))
                cmd.ExecuteNonQuery()
                reader = cmd.ExecuteReader
                If reader.Read Then
                    Dim cardImage() As Byte
                    cardImage = reader.Item("CardTemplate")
                    Dim ms As New MemoryStream(cardImage)
                    createPanel(reader.Item("CardId"))
                    createCardPictureBox(currentPanel, ms)
                    createCardLabelName(currentPanel, reader.Item("Name"), reader.Item("Cardid"))
                    createCardLabelType(currentPanel, reader.Item("Type"))
                    createCardLabelPrice(currentPanel, reader.Item("Price"))
                    createCardLabelQuantity(currentPanel, reader.Item("Quantity"))
                    createCardButtonAlter(currentPanel)
                Else
                    LabelNotFound.Visible = True
                End If
                conn.Close()
            Catch ex As Exception
                LabelNotFound.Visible = True
            End Try
        End If
    End Sub

    'to enter all cards from the database
    Public Sub enterAllCards()
        conn.ConnectionString = "Data Source=LAPTOP-G773S8H7;Initial Catalog=SE-PROJECT;Integrated Security=True;"
        conn.Open()
        cmd = New SqlCommand("SELECT TableCards.CardId, TableCards.CardTemplate, TableCards.Price, TableCardType.Type, TableCards.Name, TableInventory.Quantity FROM TableCards JOIN TableCardType ON TableCards.TypeId = TableCardType.TypeId JOIN TableInventory ON TableCards.CardId = TableInventory.CardId", conn)
        reader = cmd.ExecuteReader

        While reader.Read()
            Dim cardImage() As Byte
            cardImage = reader.Item("CardTemplate")
            Dim ms As New MemoryStream(cardImage)
            createPanel(reader.Item("CardId"))
            createCardPictureBox(currentPanel, ms)
            createCardLabelName(currentPanel, reader.Item("Name"), reader.Item("Cardid"))
            createCardLabelType(currentPanel, reader.Item("Type"))
            createCardLabelPrice(currentPanel, reader.Item("Price"))
            createCardLabelQuantity(currentPanel, reader.Item("Quantity"))
            createCardButtonAlter(currentPanel)
        End While
        conn.Close()
    End Sub

    'creating and adding panel to the flow layout
    Public Sub createPanel(ByVal uid As String)
        Dim cardPanel As Panel
        cardPanel = New Panel()
        'Set panel properties
        With cardPanel
            .BackColor = Color.White
            .Size = New Size(panelWidth, panelHeight)
            .Name = uid + "Pane"
        End With

        'Add panel to layout panel
        FlowLayoutAdmin.Controls.Add(cardPanel)

        currentPanel = cardPanel.Name
    End Sub

    Public Sub createCardPictureBox(ByVal panelName As String, ByVal ms As MemoryStream)
        Dim cardTemplate As PictureBox
        cardTemplate = New PictureBox

        With cardTemplate
            .SizeMode = PictureBoxSizeMode.Zoom
            .Size = New Drawing.Size(panelWidth - 10, (panelWidth - 10) * 1.5)
            .Location = New Point(5, 5)
            .Name = "cardTemplate" + currentPanel
            .Image = Image.FromStream(ms)
        End With

        For Each controlObject In FlowLayoutAdmin.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(cardTemplate)
            End If
        Next
    End Sub

    Public Sub createCardLabelName(ByVal panelName As String, ByVal name As String, ByVal id As String)
        Dim cardLabelName As Label
        cardLabelName = New Label

        With cardLabelName
            .AutoSize = True
            .Location = New Point(5, (panelWidth - 10) * 1.5 + 10)
            .Name = "cardLabelName" + currentPanel
            .Text = "#" + id + " - " + name
            .AutoSize = True
            .MaximumSize = New Size(panelWidth, 0)
            .Font = New Font("Comic Sans MS", 12)
        End With

        For Each controlObject In FlowLayoutAdmin.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(cardLabelName)
            End If
        Next
    End Sub

    Public Sub createCardLabelType(ByVal panelName As String, ByVal type As String)
        Dim cardLabelType As Label
        cardLabelType = New Label

        With cardLabelType
            .AutoSize = True
            .Location = New Point(5, (panelWidth - 10) * 1.5 + 60)
            .Name = "cardLabelName" + currentPanel
            .Text = "Type - " + type
            .AutoSize = True
            .MaximumSize = New Size(panelWidth, 0)
            .Font = New Font("Comic Sans MS", 12)
        End With

        For Each controlObject In FlowLayoutAdmin.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(cardLabelType)
            End If
        Next
    End Sub

    Public Sub createCardLabelPrice(ByVal panelName As String, ByVal price As String)
        Dim cardLabelPrice As Label
        cardLabelPrice = New Label

        With cardLabelPrice
            .AutoSize = True
            .Location = New Point(5, panelHeight - 70)
            .Name = "cardLabelPrice" + currentPanel
            .Text = "₹" + price
            .Font = New Font("Comic Sans MS", 12)
        End With

        For Each controlObject In FlowLayoutAdmin.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(cardLabelPrice)
            End If
        Next
    End Sub

    Public Sub createCardLabelQuantity(ByVal panelName As String, ByVal quantity As String)
        Dim cardLabelQuantity As Label
        cardLabelQuantity = New Label

        With cardLabelQuantity
            .AutoSize = True
            .Location = New Point((panelWidth / 2), panelHeight - 70)
            .Name = "cardLabelPrice" + currentPanel
            .Text = "Qty - " + quantity
            .Font = New Font("Comic Sans MS", 12)
        End With

        For Each controlObject In FlowLayoutAdmin.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(cardLabelQuantity)
            End If
        Next
    End Sub


    Public Sub createCardButtonAlter(ByVal panelName As String)
        Dim buttonAlter As Button
        buttonAlter = New Button


        With buttonAlter
            .AutoSize = False
            .Size = New Size(panelWidth - 10, 40)
            .Location = New Point(5, panelHeight - 45)
            .Name = currentPanel + "buttonOpen"
            .Text = "Alter"
            .BackColor = Color.Black
            .ForeColor = Color.White
            .Font = New Font("Arial Rounded MT Bold", 14)
        End With

        For Each controlObject In FlowLayoutAdmin.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(buttonAlter)
            End If
        Next

        AddHandler buttonAlter.Click, AddressOf DynamicButton_Click
    End Sub

    Public Sub DynamicButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim cardId = ""
        For Each c As Char In sender.name
            If Char.IsNumber(c) Then
                cardId += c
            Else
                Exit For
            End If
        Next
        alterUid = CInt(cardId)
        Me.Close()
        FormAdminCardEdit.Show()
    End Sub
End Class
