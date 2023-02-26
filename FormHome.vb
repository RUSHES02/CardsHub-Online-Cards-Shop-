Imports System.Data.OleDb
Imports FormLoad
Public Class FormHome

    Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\SE_PROJECT\ShareMarket\Resources\stock_market.accdb"
    Dim conn = New OleDbConnection(dbsource)
    Dim cmd As OleDbCommand
    Dim rd As OleDbDataReader

    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        homeListViewFill()
    End Sub

    Public Sub homeListViewFill()
        conn.Open()
        cmd = New OleDbCommand("SELECT * FROM COMPANY", conn)
        rd = cmd.ExecuteReader
        FormLogin.userlogin()

        If rd.HasRows Then
            While rd.Read
                Dim newItem As New ListViewItem()
                newItem.Text = rd.GetValue(1)
                newItem.SubItems.Add(rd.GetValue(2))
                newItem.SubItems.Add(rd.GetValue(3))
                ListViewHome.Items.Add(newItem)
                'check watchlist table display accordingly
            End While
        End If
        conn.Close()
    End Sub

    Private Sub ListViewHome_Click(sender As Object, e As EventArgs) Handles ListViewHome.Click
        If ListViewHome.SelectedItems Is Nothing Then
            'None, disable button.
            ButtonAddWatchlist.Enabled = False
        Else
            'If an an item was selected. If exactly 1 then enable button, else disable. 
            ButtonAddWatchlist.Enabled = ListViewHome.SelectedItems.Count() > 0
        End If

    End Sub

    Private Sub ButtonAddWatclist_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonAddWatchlist.Click
        'Remove from watch list
    End Sub

End Class