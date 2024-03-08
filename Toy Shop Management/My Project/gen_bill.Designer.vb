<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gen_bill
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cin = New System.Windows.Forms.TextBox()
        Me.qin = New System.Windows.Forms.NumericUpDown()
        Me.din = New System.Windows.Forms.NumericUpDown()
        Me.amoutin = New System.Windows.Forms.TextBox()
        Me.datein = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.billbl = New System.Windows.Forms.Label()
        Me.csutomerlbl = New System.Windows.Forms.Label()
        Me.toy_idlbl = New System.Windows.Forms.Label()
        Me.quanlbl = New System.Windows.Forms.Label()
        Me.disclbl = New System.Windows.Forms.Label()
        Me.amountlbl = New System.Windows.Forms.Label()
        Me.datelbl = New System.Windows.Forms.Label()
        Me.resultlbl = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.toycombo = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.qin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.din, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.toycombo, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.amoutin, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.din, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.qin, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cin, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.datein, 1, 6)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(62, 63)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(383, 256)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label1.Location = New System.Drawing.Point(4, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BILL ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label2.Location = New System.Drawing.Point(4, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Customer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label3.Location = New System.Drawing.Point(4, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label4.Location = New System.Drawing.Point(4, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Toy iD"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label6.Location = New System.Drawing.Point(4, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Bill Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label7.Location = New System.Drawing.Point(4, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total Amount"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label8.Location = New System.Drawing.Point(4, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 17)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Discount"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.TextBox1.Location = New System.Drawing.Point(191, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 1
        '
        'cin
        '
        Me.cin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.cin.Location = New System.Drawing.Point(191, 40)
        Me.cin.Name = "cin"
        Me.cin.Size = New System.Drawing.Size(100, 23)
        Me.cin.TabIndex = 8
        '
        'qin
        '
        Me.qin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.qin.Location = New System.Drawing.Point(191, 112)
        Me.qin.Name = "qin"
        Me.qin.Size = New System.Drawing.Size(112, 23)
        Me.qin.TabIndex = 9
        '
        'din
        '
        Me.din.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.din.Location = New System.Drawing.Point(191, 148)
        Me.din.Name = "din"
        Me.din.Size = New System.Drawing.Size(112, 23)
        Me.din.TabIndex = 10
        '
        'amoutin
        '
        Me.amoutin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.amoutin.Location = New System.Drawing.Point(191, 184)
        Me.amoutin.Name = "amoutin"
        Me.amoutin.Size = New System.Drawing.Size(100, 23)
        Me.amoutin.TabIndex = 11
        '
        'datein
        '
        Me.datein.Location = New System.Drawing.Point(191, 220)
        Me.datein.Name = "datein"
        Me.datein.Size = New System.Drawing.Size(188, 20)
        Me.datein.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(176, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 24)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Generate Bill"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Button1.Location = New System.Drawing.Point(171, 347)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 48)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Generate "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(656, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 24)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Generated Bill"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.datelbl, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.amountlbl, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.disclbl, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.quanlbl, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.toy_idlbl, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.csutomerlbl, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.billbl, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label13, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label14, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label15, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label16, 0, 3)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(542, 82)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(383, 256)
        Me.TableLayoutPanel2.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label10.Location = New System.Drawing.Point(4, 1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 17)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "BILL ID"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label11.Location = New System.Drawing.Point(4, 217)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 17)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Bill Date"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label12.Location = New System.Drawing.Point(4, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 17)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Customer"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label13.Location = New System.Drawing.Point(4, 181)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 17)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Total Amount"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label14.Location = New System.Drawing.Point(4, 73)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 17)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Toy iD"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label15.Location = New System.Drawing.Point(4, 145)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 17)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Discount(%)"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label16.Location = New System.Drawing.Point(4, 109)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 17)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Quantity"
        '
        'billbl
        '
        Me.billbl.AutoSize = True
        Me.billbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.billbl.Location = New System.Drawing.Point(191, 1)
        Me.billbl.Name = "billbl"
        Me.billbl.Size = New System.Drawing.Size(16, 17)
        Me.billbl.TabIndex = 16
        Me.billbl.Text = "0"
        '
        'csutomerlbl
        '
        Me.csutomerlbl.AutoSize = True
        Me.csutomerlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.csutomerlbl.Location = New System.Drawing.Point(191, 37)
        Me.csutomerlbl.Name = "csutomerlbl"
        Me.csutomerlbl.Size = New System.Drawing.Size(16, 17)
        Me.csutomerlbl.TabIndex = 17
        Me.csutomerlbl.Text = "0"
        '
        'toy_idlbl
        '
        Me.toy_idlbl.AutoSize = True
        Me.toy_idlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.toy_idlbl.Location = New System.Drawing.Point(191, 73)
        Me.toy_idlbl.Name = "toy_idlbl"
        Me.toy_idlbl.Size = New System.Drawing.Size(16, 17)
        Me.toy_idlbl.TabIndex = 18
        Me.toy_idlbl.Text = "0"
        '
        'quanlbl
        '
        Me.quanlbl.AutoSize = True
        Me.quanlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.quanlbl.Location = New System.Drawing.Point(191, 109)
        Me.quanlbl.Name = "quanlbl"
        Me.quanlbl.Size = New System.Drawing.Size(16, 17)
        Me.quanlbl.TabIndex = 19
        Me.quanlbl.Text = "0"
        '
        'disclbl
        '
        Me.disclbl.AutoSize = True
        Me.disclbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.disclbl.Location = New System.Drawing.Point(191, 145)
        Me.disclbl.Name = "disclbl"
        Me.disclbl.Size = New System.Drawing.Size(16, 17)
        Me.disclbl.TabIndex = 20
        Me.disclbl.Text = "0"
        '
        'amountlbl
        '
        Me.amountlbl.AutoSize = True
        Me.amountlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.amountlbl.Location = New System.Drawing.Point(191, 181)
        Me.amountlbl.Name = "amountlbl"
        Me.amountlbl.Size = New System.Drawing.Size(16, 17)
        Me.amountlbl.TabIndex = 21
        Me.amountlbl.Text = "0"
        '
        'datelbl
        '
        Me.datelbl.AutoSize = True
        Me.datelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.datelbl.Location = New System.Drawing.Point(191, 217)
        Me.datelbl.Name = "datelbl"
        Me.datelbl.Size = New System.Drawing.Size(82, 17)
        Me.datelbl.TabIndex = 22
        Me.datelbl.Text = "yyyy/mm/dd"
        '
        'resultlbl
        '
        Me.resultlbl.AutoSize = True
        Me.resultlbl.BackColor = System.Drawing.Color.Lime
        Me.resultlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.resultlbl.Location = New System.Drawing.Point(370, 352)
        Me.resultlbl.Name = "resultlbl"
        Me.resultlbl.Size = New System.Drawing.Size(0, 31)
        Me.resultlbl.TabIndex = 16
        Me.resultlbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(722, 359)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'toycombo
        '
        Me.toycombo.FormattingEnabled = True
        Me.toycombo.Location = New System.Drawing.Point(191, 76)
        Me.toycombo.Name = "toycombo"
        Me.toycombo.Size = New System.Drawing.Size(121, 21)
        Me.toycombo.TabIndex = 18
        '
        'gen_bill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 562)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.resultlbl)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "gen_bill"
        Me.Text = "gen_bill"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.qin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.din, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents amoutin As TextBox
    Friend WithEvents din As NumericUpDown
    Friend WithEvents qin As NumericUpDown
    Friend WithEvents cin As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents datein As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents billbl As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents datelbl As Label
    Friend WithEvents amountlbl As Label
    Friend WithEvents disclbl As Label
    Friend WithEvents quanlbl As Label
    Friend WithEvents toy_idlbl As Label
    Friend WithEvents csutomerlbl As Label
    Friend WithEvents resultlbl As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents toycombo As ComboBox
End Class
