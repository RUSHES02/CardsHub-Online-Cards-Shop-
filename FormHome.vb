Imports System.Data.OleDb

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

        If rd.HasRows Then
            While rd.Read
                Dim newItem As New ListViewItem()
                newItem.Text = rd.GetValue(1)
                newItem.SubItems.Add(rd.GetValue(2))
                newItem.SubItems.Add(rd.GetValue(3))
                ListViewHome.Items.Add(newItem)
            End While
        End If
        conn.Close()
    End Sub
End Class