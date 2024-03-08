Imports System.Data.OleDb
Imports System.Net.Configuration

Public Class age_in
    Dim connection As OleDbConnection
    Dim ds As DataSet
    Private Sub age_in_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New String("data source=localhost;password=int1; User id=int1;Provider=ORAOLEDB.Oracle;")
        connection = New OleDbConnection(con)
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
            cmd.Parameters.AddWithValue("?", NumericUpDown1.Value)
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
End Class