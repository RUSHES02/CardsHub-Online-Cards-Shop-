Imports System.IO
Imports System.Data.SqlClient
Imports System.ComponentModel.DataAnnotations

Public Class FormOrderHistory

    'sql variables
    Dim conn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader

    Private currentPanel As String = Nothing                    'to store the name of the current pane
    Dim Totalwidth = My.Computer.Screen.Bounds.Size.Width       'to store the length of the screen
    Dim today As String                                         'to store todays date

    Private Sub FormOrderHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'to set label and sech text box false initially
        LabelSearch.Visible = False
        TextBoxSearch.Visible = False

        'setting sql connection
        conn.ConnectionString = "Data Source=LAPTOP-G773S8H7;Initial Catalog=SE-PROJECT;Integrated Security=True;"
        conn.Open()

        'for the admin site
        If logedInEmail = "admin@gmail.com" Then
            ComboBoxSearchCategory.Visible = True
            ComboBoxSearchCategory.Items.Add("Name")
            ComboBoxSearchCategory.Items.Add("Email")
            ComboBoxSearchCategory.Items.Add("Phone")

            'getting all  order history
            cmd = New SqlCommand("SELECT TableOrder.OrderId, TableOrder.State, TableOrder.City, TableOrder.AddressLine, TableOrder.Pincode, TableOrder.Landmark, TableOrder.Email, TableOrder.TotalCost, TableOrder.DeliveryDate, TableOrder.PaymentMode, TableOrder.Name, TableOrder.Phone, TableCards.Cardtemplate, TableCards.Name FROM TableOrder JOIN TableCards ON TableOrder.CardId = TableCards.CardId", conn)

            'for customer site
        Else
            ComboBoxSearchCategory.Visible = False
            LabelSelectType.Visible = False
            'getting only the order history of a specific customer
            cmd = New SqlCommand("SELECT TableOrder.OrderId, TableOrder.State, TableOrder.City, TableOrder.AddressLine, TableOrder.Pincode, TableOrder.Landmark, TableOrder.Email, TableOrder.TotalCost, TableOrder.DeliveryDate, TableOrder.PaymentMode, TableOrder.Name, TableOrder.Phone, TableCards.Cardtemplate, TableCards.Name FROM TableOrder JOIN TableCards ON TableOrder.CardId = TableCards.CardId WHERE TableOrder.Email = @email", conn)
            cmd.Parameters.AddWithValue("@email", logedInEmail)
        End If
        cmd.ExecuteNonQuery()
        reader = cmd.ExecuteReader()

        'setting all the data from sql to the components
        While reader.Read()
            'variable to store image
            Dim cardImage() As Byte
            cardImage = reader.Item("CardTemplate")
            'converting image to memory strem
            Dim ms As New MemoryStream(cardImage)
            'creating panels and setting all data
            createPanel(reader.Item("OrderId"))
            createPictureBox(currentPanel, ms)
            createLabelName(currentPanel, reader.Item("Name") + vbCrLf + vbCrLf + reader.Item("Email") + vbCrLf + vbCrLf + reader.Item("Phone").ToString())
            Dim address = reader.Item("State") + "," + reader.Item("city") + vbCrLf + vbCrLf + reader.Item("AddressLine") + vbCrLf + vbCrLf + reader.Item("Pincode") + vbCrLf + vbCrLf + reader.Item("LandMark")
            createLabelAddress(currentPanel, address)
            createLabelPrice(currentPanel, "₹" + reader.Item("TotalCost").ToString() + vbCrLf + vbCrLf + reader.Item("PaymentMode"))

            'check if todays date is before or after delivery date
            If today > reader.Item("DeliveryDate") Then
                createLabelDelivery(currentPanel, "Delivered on " + vbCrLf + vbCrLf + reader.Item("DeliveryDate"))
            Else
                createLabelDelivery(currentPanel, "Will be delivered by " + vbCrLf + vbCrLf + reader.Item("DeliveryDate"))
            End If

        End While
        conn.Close()

    End Sub

    'to check todays date
    Private Sub TimerOrderHistory_Tick(sender As Object, e As EventArgs)
        today = Date.Now.ToString("dd MMM yyyy")
    End Sub

    'for back button
    Private Sub PictureBoxBack_Click(sender As Object, e As EventArgs)
        Me.Close()
        FormCardList.Show()
    End Sub

    'checking if anu item is selected in the combo box and setting the search box accordingly
    Private Sub ComboBoxSearchCategory_SelectedIndexChanged(sender As Object, e As EventArgs)
        If ComboBoxSearchCategory.SelectedItem = "Name" Then
            TextBoxSearch.Visible = True
            LabelSearch.Visible = True
            LabelSearch.Text = "Name"

        ElseIf ComboBoxSearchCategory.SelectedItem = "Email" Then
            TextBoxSearch.Visible = True
            LabelSearch.Visible = True
            LabelSearch.Text = "Email"

        ElseIf ComboBoxSearchCategory.SelectedItem = "Phone" Then
            TextBoxSearch.Visible = True
            LabelSearch.Visible = True
            LabelSearch.Text = "Phone"
        Else
            TextBoxSearch.Visible = False
            LabelSearch.Visible = False
        End If
    End Sub

    'checking and searching through the order history
    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs)
        FlowLayoutOrderHistory.Controls.Clear()
        conn.ConnectionString = "Data Source=LAPTOP-G773S8H7;Initial Catalog=SE-PROJECT;Integrated Security=True;"
        conn.Open()
        If Not TextBoxSearch.Text = "" Then
            If ComboBoxSearchCategory.SelectedItem = "Name" Then
                cmd = New SqlCommand("SELECT TableOrder.OrderId, TableOrder.State, TableOrder.City, TableOrder.AddressLine, TableOrder.Pincode, TableOrder.Landmark, TableOrder.Email, TableOrder.TotalCost, TableOrder.DeliveryDate, TableOrder.PaymentMode, TableOrder.Name, TableOrder.Phone, TableCards.Cardtemplate, TableCards.Name FROM TableOrder JOIN TableCards ON TableOrder.CardId = TableCards.CardId WHERE TableOrder.Name LIKE @name + '%'", conn)
                cmd.Parameters.AddWithValue("@name", TextBoxSearch.Text)
            ElseIf ComboBoxSearchCategory.SelectedItem = "Email" Then
                cmd = New SqlCommand("SELECT TableOrder.OrderId, TableOrder.State, TableOrder.City, TableOrder.AddressLine, TableOrder.Pincode, TableOrder.Landmark, TableOrder.Email, TableOrder.TotalCost, TableOrder.DeliveryDate, TableOrder.PaymentMode, TableOrder.Name, TableOrder.Phone, TableCards.Cardtemplate, TableCards.Name FROM TableOrder JOIN TableCards ON TableOrder.CardId = TableCards.CardId WHERE TableOrder.Email LIKE @email  + '%'", conn)
                cmd.Parameters.AddWithValue("@email", TextBoxSearch.Text)
            ElseIf ComboBoxSearchCategory.SelectedItem = "Phone" Then
                cmd = New SqlCommand("SELECT TableOrder.OrderId, TableOrder.State, TableOrder.City, TableOrder.AddressLine, TableOrder.Pincode, TableOrder.Landmark, TableOrder.Email, TableOrder.TotalCost, TableOrder.DeliveryDate, TableOrder.PaymentMode, TableOrder.Name, TableOrder.Phone, TableCards.Cardtemplate, TableCards.Name FROM TableOrder JOIN TableCards ON TableOrder.CardId = TableCards.CardId WHERE TableOrder.Phone LIKE @phone + '%'", conn)
                cmd.Parameters.AddWithValue("@phone", TextBoxSearch.Text)
            End If
        Else
            cmd = New SqlCommand("SELECT TableOrder.OrderId, TableOrder.State, TableOrder.City, TableOrder.AddressLine, TableOrder.Pincode, TableOrder.Landmark, TableOrder.Email, TableOrder.TotalCost, TableOrder.DeliveryDate, TableOrder.PaymentMode, TableOrder.Name, TableOrder.Phone, TableCards.Cardtemplate, TableCards.Name FROM TableOrder JOIN TableCards ON TableOrder.CardId = TableCards.CardId", conn)
        End If

        reader = cmd.ExecuteReader()
        While reader.Read()
            Dim cardImage() As Byte
            cardImage = reader.Item("CardTemplate")
            Dim ms As New MemoryStream(cardImage)
            createPanel(reader.Item("OrderId"))
            createPictureBox(currentPanel, ms)
            createLabelName(currentPanel, reader.Item("Name") + vbCrLf + vbCrLf + reader.Item("Email") + vbCrLf + vbCrLf + reader.Item("Phone").ToString())
            Dim address = reader.Item("State") + "," + reader.Item("city") + vbCrLf + vbCrLf + reader.Item("AddressLine") + vbCrLf + vbCrLf + reader.Item("Pincode") + vbCrLf + vbCrLf + reader.Item("LandMark")
            createLabelAddress(currentPanel, address)
            createLabelPrice(currentPanel, "₹" + reader.Item("TotalCost").ToString() + vbCrLf + vbCrLf + reader.Item("PaymentMode"))
            If today > reader.Item("DeliveryDate") Then
                createLabelDelivery(currentPanel, "Delivered on " + vbCrLf + vbCrLf + reader.Item("DeliveryDate"))
            Else
                createLabelDelivery(currentPanel, "Will be delivered by " + vbCrLf + vbCrLf + reader.Item("DeliveryDate"))
            End If

        End While

        conn.Close()
    End Sub

    'creating indivisual panels
    Public Sub createPanel(ByVal uid As String)
        Dim cardPanel As Panel
        cardPanel = New Panel()
        'Set panel properties
        With cardPanel
            .BackColor = Color.White
            .Size = New Size(Width, 300)
            .Name = uid + "Pane"
            .Anchor = AnchorStyles.Top And AnchorStyles.Left
            .BackColor = Color.White
        End With

        'Add panel to layout panel
        FlowLayoutOrderHistory.Controls.Add(cardPanel)

        currentPanel = cardPanel.Name
    End Sub

    'creating picture box and adding card template to it
    Public Sub createPictureBox(ByVal panelName As String, ByVal ms As MemoryStream)
        Dim cardTemplate As PictureBox
        cardTemplate = New PictureBox

        'set picture box properties
        With cardTemplate
            .SizeMode = PictureBoxSizeMode.Zoom
            .Size = New Drawing.Size(190, 285)
            .Location = New Point(5, 5)
            .Name = "cardTemplate" + currentPanel
            .Image = Image.FromStream(ms)
            .Anchor = AnchorStyles.Left And AnchorStyles.Top
        End With

        'adding picture box to the panel
        For Each controlObject In FlowLayoutOrderHistory.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(cardTemplate)
            End If
        Next
    End Sub

    'creating and adding name, email, phone number to the panels
    Public Sub createLabelName(ByVal panelName As String, ByVal name As String)
        Dim cardLabelName As Label
        cardLabelName = New Label

        'setting label properties
        With cardLabelName
            .AutoSize = True
            .Location = New Point(220, 50)
            .Name = "cardLabelName" + currentPanel
            .Text = name
            .Font = New Font("Century Schoolbook", 16)
        End With

        'adding the label to the panel
        For Each controlObject In FlowLayoutOrderHistory.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(cardLabelName)
            End If
        Next
    End Sub

    'creating and adding address to the panel
    Public Sub createLabelAddress(ByVal panelName As String, ByVal address As String)
        Dim cardLabelAddress As Label
        cardLabelAddress = New Label

        'setting label properties
        With cardLabelAddress
            .AutoSize = True
            .Location = New Point(700, 50)
            .Name = "cardLabelQuantity" + currentPanel
            .Text = address
            .Font = New Font("Century Schoolbook", 16)
        End With

        'adding the label to the panel
        For Each controlObject In FlowLayoutOrderHistory.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(cardLabelAddress)
            End If
        Next
    End Sub

    'creating and adding price, transaction mode to the panel
    Public Sub createLabelPrice(ByVal panelName As String, ByVal price As String)
        Dim cardLabelPrice As Label
        cardLabelPrice = New Label

        'setting label properties
        With cardLabelPrice
            .AutoSize = True
            .Location = New Point(1200, 50)
            .Name = "cardLabelQuantity" + currentPanel
            .Text = price
            .Font = New Font("Century Schoolbook", 16)
        End With

        'adding the label to the panel
        For Each controlObject In FlowLayoutOrderHistory.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(cardLabelPrice)
            End If
        Next
    End Sub

    'creating and adding deliverry date to the panel
    Public Sub createLabelDelivery(ByVal panelName As String, ByVal delivery As String)
        Dim cardLabelDelivery As Label
        cardLabelDelivery = New Label

        'setting label properties
        With cardLabelDelivery
            .AutoSize = True
            .Location = New Point(1500, 50)
            .Name = "cardLabelQuantity" + currentPanel
            .Text = delivery
            .Font = New Font("Century Schoolbook", 16)
        End With

        'adding the label to the panel
        For Each controlObject In FlowLayoutOrderHistory.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(cardLabelDelivery)
            End If
        Next
    End Sub
End Class