Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting
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
        DataGridView1.DefaultCellStyle.Font = New Font("Arial", 16)
    End Sub

    Private Sub ToysToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToysToolStripMenuItem.Click

    End Sub

    Private Sub ADDUPDATEDELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDUPDATEDELETEToolStripMenuItem.Click
        toy_crud.Show()
    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Dispose()
    End Sub

    Private Sub ADDUPDATEDELTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDUPDATEDELTEToolStripMenuItem.Click
        age_in.Show()

    End Sub

    Private Sub GENERATEBILLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GENERATEBILLToolStripMenuItem.Click
        gen_bill.show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        filldatagrid()
    End Sub

    Private Sub SalesOfLastWeekToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesOfLastWeekToolStripMenuItem.Click
        sales_q.show()
    End Sub

    Private Sub ToysHavingStockLessThan10ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToysHavingStockLessThan10ToolStripMenuItem.Click
        less_stock.show()
    End Sub

    Private Sub HeroProductOfMonthToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HeroProductOfMonthToolStripMenuItem.Click
        phero.show()
    End Sub
End Class
