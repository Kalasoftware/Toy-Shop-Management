Imports System.Configuration
Imports System.Data.OleDb

Public Class less_stock
    Dim con As OleDbConnection
    Dim ds As DataSet
    Private Sub less_stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection_string As String = ConfigurationManager.ConnectionStrings("c_string").ConnectionString
        con = New OleDbConnection(connection_string)
        fillstock()
    End Sub

    Private Sub fillstock()
        ds = New DataSet
        Dim dtp As New OleDbDataAdapter("select toy_name from toys where stock<10", con)
        dtp.Fill(ds, "stock")
        stockview.DataSource = ds.Tables("stock")
        stockview.DefaultCellStyle.Font = New Font("Arial", 17)
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Dispose()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        toy_crud.Show()
    End Sub
End Class