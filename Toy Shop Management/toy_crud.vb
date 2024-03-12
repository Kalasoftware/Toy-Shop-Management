Imports System.Data.OleDb
Imports System.Configuration
Imports System.Data.Common
Imports System.IO
Public Class toy_crud
    Dim connection As OleDbConnection
    Dim ds As DataSet
    Private Sub Toy_CRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection_string As String = ConfigurationManager.ConnectionStrings("c_string").ConnectionString
        connection = New OleDbConnection(connection_string)

        DataGridView1.RowTemplate.Height = 240
        Dim columnWidth As Integer = 340 ' wdith of the column of image 
        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.Width = columnWidth
        Next
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
        DataGridView1.DefaultCellStyle.Font = New Font("Arial", 16)

    End Sub

    Private Sub filldatagrid()
        'date 12 march' 
        DataGridView1.DataSource = Nothing
        DataGridView1.Columns.Clear()
        DataGridView1.RowTemplate.Height = 100

        Dim debugFolderP As String = AppDomain.CurrentDomain.BaseDirectory


        ds = New DataSet
        Dim tdp As New OleDbDataAdapter("select * from toys", connection)
        tdp.Fill(ds, "toys")
        DataGridView1.DataSource = ds.Tables("toys")
        ' showing the images into the datagridview begins here 
        Dim imageColumn As New DataGridViewImageColumn()
        imageColumn.HeaderText = "Image"
        imageColumn.Name = "ImageColumn"
        imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch
        DataGridView1.Columns.Add(imageColumn)


        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                Dim filename As String = row.Cells(4).Value
                Dim imagePath As String = Path.Combine(debugFolderP, filename)
                If File.Exists(imagePath) Then
                    Dim image As Image = Image.FromFile(imagePath)
                    row.Cells("imageColumn").Value = image
                Else
                    MessageBox.Show($"Image file not found: {filename}", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)

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
            qry = "insert into toys values(?,?,?,?,?,?,?)"
            Dim command As New OleDbCommand(qry, connection)

            command.Parameters.AddWithValue("?", CInt(TextBox1.Text))
            command.Parameters.AddWithValue("?", TextBox2.Text)
            command.Parameters.AddWithValue("?", descbox.Text)
            command.Parameters.AddWithValue("?", agecodebox.SelectedValue)


            command.Parameters.AddWithValue("?", TextBox3.Text)
            command.Parameters.AddWithValue("?", CInt(TextBox4.Text))
            command.Parameters.AddWithValue("?", CInt(TextBox5.Text))

            If PictureBox1.Image IsNot Nothing Then
                Dim debugFolderP As String = Path.GetDirectoryName(Application.ExecutablePath)
                Dim imagePath As String = Path.Combine(debugFolderP, TextBox3.Text)
                PictureBox1.Image.Save(imagePath)
                MessageBox.Show("Image saved to project folder.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No image loaded to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If


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
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            OpenFileDialog1.InitialDirectory = "C:\"
            OpenFileDialog1.Title = "Open an Image File"
            'OpenFileDialog1.Filter = "Image|*.jpg" 'Set the filter to display only image.  
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            'Label2.Text = OpenFileDialog1.FileName 'Path of selected file
            TextBox3.Text = Path.GetFileName(OpenFileDialog1.FileName) 'Path of selected file 
        End If

    End Sub


    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            connection.Open()
            Dim qry As String
            qry = "update toys set toy_name=?,descr=?,age_code=?,stock=?,price_per_item where toy_id=? "
            Dim command As New OleDbCommand(qry, connection)


            command.Parameters.AddWithValue("?", TextBox2.Text)
            command.Parameters.AddWithValue("?", descbox.Text)
            command.Parameters.AddWithValue("?", agecodebox.SelectedValue)

            command.Parameters.AddWithValue("?", CInt(TextBox4.Text))
            command.Parameters.AddWithValue("?", CInt(TextBox5.Text))
            command.Parameters.AddWithValue("?", CInt(TextBox1.Text))



            Dim insrow = command.ExecuteNonQuery()
            connection.Close()
            If (insrow >= 1) Then
                MessageBox.Show("updated bro")
                filldatagrid()
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Try
            TextBox1.Text = DataGridView1.SelectedRows(0).Cells(0).Value
            TextBox2.Text = DataGridView1.SelectedRows(0).Cells(1).Value
            descbox.Text = DataGridView1.SelectedRows(0).Cells(2).Value
            agecodebox.SelectedValue = DataGridView1.SelectedRows(0).Cells(3).Value
            TextBox5.Text = DataGridView1.SelectedRows(0).Cells(4).Value
            TextBox4.Text = DataGridView1.SelectedRows(0).Cells(5).Value
        Catch ex As Exception

        End Try

    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Hide()
        Form1.Show()
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            connection.Open()
            Dim qry As String
            qry = "delete from toys where toy_id=?"
            Dim command As New OleDbCommand(qry, connection)
            command.Parameters.AddWithValue("?", CInt(TextBox1.Text))
            Dim insrow = command.ExecuteNonQuery()
            connection.Close()
            If (insrow >= 1) Then
                MessageBox.Show("deleted bro")
                filldatagrid()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        age_in.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        filldatagrid()
    End Sub
End Class