Imports System.Configuration
Imports System.Data.OleDb

Public Class sales_q
    Dim connection As OleDbConnection
    Dim ds As DataSet
    Private Sub sales_q_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection_string As String = ConfigurationManager.ConnectionStrings("c_string").ConnectionString
        connection = New OleDbConnection(connection_string)

        'Dim startDate As Date = DateTime.Today.AddDays(-DateTime.Today.DayOfWeek - 6)
        'Dim endDate As Date = DateTime.Today.AddDays(-DateTime.Today.DayOfWeek)

        fillbox()



    End Sub

    Private Sub fillbox()
        Dim sql As String = "select b.bill_id,b.customer,t.toy_name,b.quantity,b.total_amount,b.bdate from bills b inner join toys t on b.toy_id=t.toy_id where b.bdate between '12-mar-24' and '22-mar-24'"

        ds = New DataSet
        Dim adp As New OleDbDataAdapter(sql, connection)
        adp.Fill(ds, "showtable")
        DataGridView1.DataSource = ds.Tables("showtable")
    End Sub
End Class