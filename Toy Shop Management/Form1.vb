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
        Dim dtp As New OleDbDataAdapter("select b.bill_id as bill ,b.customer,t.toy_name,t.stock,b.quantity,b.total_amount as Amount,b.bdate from bills b,toys t where b.toy_id=t.toy_id", connection)
        dtp.Fill(ds, "bills")
        DataGridView1.DataSource = ds.Tables("bills")
        DataGridView1.DefaultCellStyle.Font = New Font("Arial", 15)


    End Sub

    Private Sub ToysToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToysToolStripMenuItem.Click

    End Sub

    Private Sub ADDUPDATEDELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDUPDATEDELETEToolStripMenuItem.Click
        toy_crud.Show()
    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Dispose()
    End Sub
End Class
