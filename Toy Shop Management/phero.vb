Imports System.Configuration
Imports System.Data.OleDb

Public Class phero
    Dim connection As OleDbConnection
    Dim ds As DataSet
    Private Sub phero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection_string As String = ConfigurationManager.ConnectionStrings("c_string").ConnectionString
        connection = New OleDbConnection(connection_string)
        fillthebox()

    End Sub

    Private Sub fillthebox()
        ds = New DataSet
        Dim d As New OleDbDataAdapter("select max(total_amount) as max_sale from bills", connection)
        d.Fill(ds, "herotable")
        heroview.DataSource = ds.Tables("herotable")
    End Sub
End Class