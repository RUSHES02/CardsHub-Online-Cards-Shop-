Imports System.IO
Imports System.Data.SqlClient

Public Class FormCardList

    Private currentPanel As String = Nothing
    Private totalPanel As Integer = 0

    Private Sub FormCardList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            createPanel(ms)
        Next
        conn.Close()
    End Sub

    Public Sub createPanel(ByRef ms As MemoryStream)
        Dim cardPanel As Panel
        cardPanel = New Panel()
        'Set panel properties
        With cardPanel
            .BackColor = Color.White
            .Size = New Size(1100, 250)
            .Name = "Pane" + totalPanel.ToString
        End With

        'Add panel to layout panel
        FlowLayoutCardList.Controls.Add(cardPanel)

        currentPanel = cardPanel.Name
        totalPanel += 1
        createCardPictureBox(currentPanel, ms)
    End Sub

    Public Sub createCardPictureBox(ByVal panelName As String, ByVal ms As MemoryStream)
        Dim cardTemplate As PictureBox
        cardTemplate = New PictureBox


        With cardTemplate
            .SizeMode = PictureBoxSizeMode.StretchImage
            .Size = New Drawing.Size(200, 225)
            .Location = New Point(5, 5)
            .Name = "cardTemplate" + currentPanel
            .Image = Image.FromStream(ms)
        End With

        For Each controlObject In FlowLayoutCardList.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(cardTemplate)
            End If
        Next
    End Sub


    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Close()
        FormChooseType.Show()
    End Sub

End Class