Imports System.Data.OleDb

Public Class phero
    Dim connection As OleDbConnection
    Dim ds As DataSet
    Private Sub phero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New String("data source=localhost;password=int1;user id=int1;provider=oraoledb.Oracle;")
        connection = New OleDbConnection(con)
        fillthebox()

    End Sub

    Private Sub fillthebox()
        ds = New DataSet
        Dim d As New OleDbDataAdapter("select max(total_amount) as max_sale from bills", connection)
        d.Fill(ds, "herotable")
        heroview.DataSource = ds.Tables("herotable")
    End Sub
End Class