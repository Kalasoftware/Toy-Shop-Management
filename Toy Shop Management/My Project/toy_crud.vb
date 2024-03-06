Imports System.Data.OleDb
Imports System.Configuration
Imports System.Data.Common
Imports System.IO
Public Class toy_crud
    Dim connection As OleDbConnection
    Dim ds As DataSet
    Private Sub Toy_CRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection_string As New String("Data Source=localhost;" + "password=int1; User id=int1;" + "Provider=ORAOLEDB.Oracle;")
        connection = New OleDbConnection(connection_string)
        filldatagrid()
        fillagecode()
    End Sub

    Private Sub fillagecode()
        ds = New DataSet
        Dim tcp As New OleDbDataAdapter("select * from age_category", connection)
        tcp.Fill(ds, "age_category")
        agecodebox.DataSource = ds.Tables("age_category")
        agecodebox.DisplayMember = "years"
        agecodebox.ValueMember = "age_code"


    End Sub

    Private Sub filldatagrid()
        ds = New DataSet
        Dim tdp As New OleDbDataAdapter("select * from toys", connection)
        tdp.Fill(ds, "toys")
        DataGridView1.DataSource = ds.Tables("toys")
        ' showing the images into the datagridview begins here 
        Dim imageColumn As New DataGridViewImageColumn()
        imageColumn.HeaderText = "image"
        imageColumn.Name = "imageColumn"

        imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch
        DataGridView1.Columns.Add(imageColumn)

        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                Dim filename As String = row.Cells(4).Value
                If File.Exists(filename) Then
                    Dim image As Image = Image.FromFile(filename)
                    row.Cells("imageColumn").Value = image
                Else
                    MessageBox.Show("no file path exits like this ")
                End If

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


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
            command.Parameters.AddWithValue("?", agecodebox.SelectedValue)
            NumericUpDown1.Value = agecodebox.SelectedValue
            'command.Parameters.AddWithValue("?", CInt(NumericUpDown1.Value))
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim imagePath As String = OpenFileDialog1.FileName
            PictureBox1.Image = Image.FromFile(imagePath)
            TextBox3.Text = imagePath
        End If
    End Sub


    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting



    End Sub


End Class