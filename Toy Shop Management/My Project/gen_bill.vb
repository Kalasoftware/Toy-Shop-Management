Imports System.Data.OleDb
Imports System.Security.Cryptography

Public Class gen_bill
    Dim price As Decimal
    Dim total_amout As Decimal
    Dim total_amount As Decimal
    Dim connection As OleDbConnection
    Dim ds As DataSet
    Private Sub gen_bill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New String("data source=localhost;password=int1; user id=int1; provider=oraoledb.Oracle")
        connection = New OleDbConnection(con)
        filltoy()
    End Sub

    Private Sub filltoy()
        ds = New DataSet
        Dim adp = New OleDbDataAdapter("select toy_id,toy_name from toys", connection)
        adp.Fill(ds, "toys")

        toycombo.DataSource = ds.Tables("toys")
        toycombo.DisplayMember = ("toy_name")
        toycombo.ValueMember = ("toy_id")
        'price dic here '



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            connection.Open()
            Dim cmd As New OleDbCommand("insert into bills values(?,?,?,?,?,?,TO_DATE(?,'YYYY-MM-DD'))", connection)
            cmd.Parameters.AddWithValue("?", CInt(TextBox1.Text))
            cmd.Parameters.AddWithValue("?", (cin.Text))
            cmd.Parameters.AddWithValue("?", (toycombo.SelectedValue))

            cmd.Parameters.AddWithValue("?", (qin.Value))
            cmd.Parameters.AddWithValue("?", din.Value)
            cmd.Parameters.AddWithValue("?", CInt(amoutin.Text))
            cmd.Parameters.AddWithValue("?", datein.Value.ToString("yyyy-MM-dd"))
            Dim valuein = cmd.ExecuteNonQuery
            If (valuein >= 1) Then
                resultlbl.Text = "Done"
                connection.Close()
                genebill()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            connection.Close()
        End Try
    End Sub

    Private Sub genebill()
        billbl.Text = TextBox1.Text
        csutomerlbl.Text = cin.Text
        toy_idlbl.Text = toycombo.SelectedValue
        quanlbl.Text = qin.Value
        disclbl.Text = din.Value
        amountlbl.Text = amoutin.Text
        datelbl.Text = datein.Value.ToString("yyyy-MM-dd")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub toycombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles toycombo.SelectedIndexChanged
        ' MsgBox(toycombo.SelectedValue.ToString)
        Try
            Dim se_toy_id As Integer = toycombo.SelectedValue
            Dim qry As String
            qry = "select price_per_item from toys where toy_id=?"
            Dim cmd As New OleDbCommand(qry, connection)
            cmd.Parameters.AddWithValue("?", CInt(se_toy_id))
            connection.Open()
            price = Convert.ToDecimal(cmd.ExecuteScalar())
            amoutin.Text = Convert.ToDecimal(price).ToString
            connection.Close()
        Catch ex As Exception

            connection.Close()
        End Try
    End Sub

    Private Sub qin_ValueChanged(sender As Object, e As EventArgs) Handles qin.ValueChanged
        Try
            Dim q As Decimal = Convert.ToDecimal(qin.Value)

            total_amout = q * price
            amoutin.Text = Convert.ToDecimal(total_amout)
        Catch ex As Exception

        End Try
    End Sub





    Private Sub din_ValueChanged(sender As Object, e As EventArgs) Handles din.ValueChanged
        Try
            Dim d As Decimal = Convert.ToDecimal(din.Value) / 100

            total_amout -= total_amout * d
            amoutin.Text = Convert.ToDecimal(total_amout)
        Catch ex As Exception

        End Try
    End Sub
End Class