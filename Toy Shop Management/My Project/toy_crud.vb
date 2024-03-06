Imports System.Data.OleDb
Imports System.Configuration
Imports System.Data.Common
Public Class toy_crud
    Dim connection As OleDbConnection
    Dim ds As DataSet
    Private Sub Toy_CRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection_string As New String("Data Source=localhost;" + "password=int1; User id=int1;" + "Provider=ORAOLEDB.Oracle;")
        connection = New OleDbConnection(connection_string)
        filldatagrid()
    End Sub

    Private Sub filldatagrid()
        ds = New DataSet
        Dim tdp As New OleDbDataAdapter("select * from toys", connection)
        tdp.Fill(ds, "toys")
        DataGridView1.DataSource = ds.Tables("toys")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'insert into 

        Try
            connection.Open()
            Dim qry As String
            qry = "insert into toys values(?,?,?,?,?,?)"
            Dim command As New OleDbCommand(qry, connection)

            command.Parameters.AddWithValue("?", CInt(TextBox1.Text))
            command.Parameters.AddWithValue("?", TextBox2.Text)
            command.Parameters.AddWithValue("?", descbox.Text)
            command.Parameters.AddWithValue("?", CInt(NumericUpDown1.Value))
            command.Parameters.AddWithValue("?", TextBox3.Text)
            command.Parameters.AddWithValue("?", CInt(TextBox4.Text))



            Dim insrow = command.ExecuteNonQuery()
            connection.Close()
            If (insrow >= 1) Then
                MessageBox.Show("insert bro")
                filldatagrid()
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
End Class