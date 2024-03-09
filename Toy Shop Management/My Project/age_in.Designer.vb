<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class age_in
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ageview = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Insertbtn = New System.Windows.Forms.Button()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.delbtn = New System.Windows.Forms.Button()
        Me.backbtn = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.ageview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ageview
        '
        Me.ageview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ageview.Location = New System.Drawing.Point(288, 48)
        Me.ageview.Name = "ageview"
        Me.ageview.Size = New System.Drawing.Size(258, 219)
        Me.ageview.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.TextBox1.Location = New System.Drawing.Point(137, 143)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 31)
        Me.TextBox1.TabIndex = 1
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.NumericUpDown1.Location = New System.Drawing.Point(137, 59)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 31)
        Me.NumericUpDown1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label1.Location = New System.Drawing.Point(29, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "age code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label2.Location = New System.Drawing.Point(29, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "year"
        '
        'Insertbtn
        '
        Me.Insertbtn.Location = New System.Drawing.Point(137, 202)
        Me.Insertbtn.Name = "Insertbtn"
        Me.Insertbtn.Size = New System.Drawing.Size(75, 23)
        Me.Insertbtn.TabIndex = 5
        Me.Insertbtn.Text = "Insert"
        Me.Insertbtn.UseVisualStyleBackColor = True
        '
        'updatebtn
        '
        Me.updatebtn.Location = New System.Drawing.Point(137, 244)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(75, 23)
        Me.updatebtn.TabIndex = 6
        Me.updatebtn.Text = "update"
        Me.updatebtn.UseVisualStyleBackColor = True
        '
        'delbtn
        '
        Me.delbtn.Location = New System.Drawing.Point(137, 283)
        Me.delbtn.Name = "delbtn"
        Me.delbtn.Size = New System.Drawing.Size(75, 23)
        Me.delbtn.TabIndex = 7
        Me.delbtn.Text = "Delete"
        Me.delbtn.UseVisualStyleBackColor = True
        '
        'backbtn
        '
        Me.backbtn.Location = New System.Drawing.Point(471, 283)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(75, 23)
        Me.backbtn.TabIndex = 8
        Me.backbtn.Text = "Back"
        Me.backbtn.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.TextBox2.Location = New System.Drawing.Point(137, 97)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 31)
        Me.TextBox2.TabIndex = 9
        '
        'age_in
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.backbtn)
        Me.Controls.Add(Me.delbtn)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.Insertbtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ageview)
        Me.Name = "age_in"
        Me.Text = "age_in"
        CType(Me.ageview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ageview As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Insertbtn As Button
    Friend WithEvents updatebtn As Button
    Friend WithEvents delbtn As Button
    Friend WithEvents backbtn As Button
    Friend WithEvents TextBox2 As TextBox
End Class
