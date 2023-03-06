Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Imports System.Threading.Tasks.Dataflow

Public Class FormAdmin

    Private currentPanel As String = Nothing

    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection
        Dim cmd As New SqlCommand
        Dim maxRow As Integer
        conn.ConnectionString = "Data Source=LAPTOP-G773S8H7;Initial Catalog=SE-PROJECT;Integrated Security=True;"
        conn.Open()
        cmd = New SqlCommand("SELECT TOP 1 CardId FROM TableCards ORDER BY CardId DESC", conn)
        Dim reader As SqlDataReader = cmd.ExecuteReader
        reader.Read()
        maxRow = reader("CardId")
        conn.Close()
        conn.Open()
        Dim i As Integer
        For i = 1 To maxRow
            cmd = New SqlCommand("SELECT * FROM TableCards WHERE CardId = @id", conn)
            cmd.Parameters.AddWithValue("@id", i)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            Dim cardImage() As Byte
            cardImage = dt.Rows(0)(1)
            Dim ms As New MemoryStream(cardImage)
            cmd = New SqlCommand("SELECT Quantity FROM TableInventory WHERE CardId = @id", conn)
            cmd.Parameters.AddWithValue("@id", i)
            createPanel(dt.Rows(0)(0).ToString())
            createCardPictureBox(currentPanel, ms)
            createCardLabelPrice(currentPanel, dt.Rows(0)(3).ToString())
            createCardButtonAlter(currentPanel)
        Next
        conn.Close()
    End Sub

    Private Sub ButtonAddNewCard_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonAddNewCard.Click
        Me.Close()
        FormAdminCardEdit.Show()
    End Sub

    Public Sub createPanel(ByVal uid As String)
        Dim cardPanel As Panel
        cardPanel = New Panel()
        'Set panel properties
        With cardPanel
            .BackColor = Color.White
            .Size = New Size(350, 625)
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
            .SizeMode = PictureBoxSizeMode.StretchImage
            .Size = New Drawing.Size(340, 540)
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

    Public Sub createCardLabelPrice(ByVal panelName As String, ByVal price As String)
        Dim cardLabelPrice As Label
        cardLabelPrice = New Label


        With cardLabelPrice
            .AutoSize = True
            .Location = New Point(125, 550)
            .Name = "cardLabelPrice" + currentPanel
            .Text = "₹" + price
        End With

        For Each controlObject In FlowLayoutAdmin.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(cardLabelPrice)
            End If
        Next
    End Sub

    Public Sub createCardButtonAlter(ByVal panelName As String)
        Dim buttonAlter As Button
        buttonAlter = New Button


        With buttonAlter
            .AutoSize = False
            .Size = New Size(340, 20)
            .Location = New Point(5, 600)
            .Name = currentPanel + "buttonAlter"
            .Text = "Alter"
        End With

        For Each controlObject In FlowLayoutAdmin.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(buttonAlter)
            End If
        Next

        AddHandler buttonAlter.Click, AddressOf DynamicButton_Click
    End Sub

    Public Sub DynamicButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        LabelTest.Text = sender.Name
        For Each c As Char In sender.name
            If Char.IsNumber(c) Then
                alterUid = alterUid + c
            Else
                Exit For
            End If
        Next

        Me.Hide()
        FormAdminCardEdit.Show()
    End Sub
End Class