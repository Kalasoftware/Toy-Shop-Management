Imports System.Configuration
Imports System.Data.OleDb
Imports System.Net.Configuration

Public Class age_in
    Dim connection As OleDbConnection
    Dim ds As DataSet
    Private Sub age_in_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection_string As String = ConfigurationManager.ConnectionStrings("c_string").ConnectionString
        connection = New OleDbConnection(connection_string)
        fillage()
    End Sub

    Private Sub fillage()
        ds = New DataSet
        Dim dt As New OleDbDataAdapter("select * from age_category", connection)
        dt.Fill(ds, "age_category")
        ageview.DataSource = ds.Tables("age_category")
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Close()
    End Sub

    Private Sub Insertbtn_Click(sender As Object, e As EventArgs) Handles Insertbtn.Click
        Try
            connection.Open()
            Dim cmd As New OleDbCommand("insert into age_category values(?,?)", connection)
            cmd.Parameters.AddWithValue("?", CInt(TextBox2.Text))
            cmd.Parameters.AddWithValue("?", TextBox1.Text)
            Dim rowins = cmd.ExecuteNonQuery
            If (rowins >= 1) Then
                fillage()
                connection.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            connection.Close()
        End Try

    End Sub

    Private Sub ageview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ageview.CellContentClick

    End Sub

    Private Sub ageview_SelectionChanged(sender As Object, e As EventArgs) Handles ageview.SelectionChanged
        Try
            TextBox2.Text = ageview.SelectedRows(0).Cells(0).Value
            TextBox1.Text = ageview.SelectedRows(0).Cells(1).Value
        Catch ex As Exception

        End Try

    End Sub

    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        Try
            connection.Open()
            Dim cmd As New OleDbCommand("update age_category set years=? where age_code=?", connection)

            cmd.Parameters.AddWithValue("?", TextBox1.Text)
            cmd.Parameters.AddWithValue("?", CInt(TextBox2.Text))
            Dim effrow = cmd.ExecuteNonQuery

            If (effrow >= 1) Then
                fillage()
                connection.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub delbtn_Click(sender As Object, e As EventArgs) Handles delbtn.Click
        Try
            connection.Open()
            Dim cmd As New OleDbCommand("delete from age_category where age_code=?", connection)
            cmd.Parameters.AddWithValue("?", CInt(TextBox2.Text))
            Dim effrow = cmd.ExecuteNonQuery
            If (effrow >= 1) Then
                fillage()
                connection.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class