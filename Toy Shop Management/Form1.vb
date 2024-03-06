Imports System.Data.Common
Imports System.Data.OleDb
Imports Microsoft.SqlServer.Server
Public Class Form1
    Dim connection As OleDbConnection
    Dim ds As DataSet
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection_string As New String("Data Source=localhost;" + "password=int1; User id=int1;" + "Provider=ORAOLEDB.Oracle;")
        connection = New OleDbConnection(connection_string)
        filldatagrid()
    End Sub

    Private Sub filldatagrid()
        ds = New DataSet
        Dim dtp As New OleDbDataAdapter("select * from bills", connection)
        dtp.Fill(ds, "bills")
        DataGridView1.DataSource = ds.Tables("bills")


    End Sub

    Private Sub ToysToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToysToolStripMenuItem.Click

    End Sub

    Private Sub ADDUPDATEDELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDUPDATEDELETEToolStripMenuItem.Click
        toy_crud.Show()
    End Sub
End Class
