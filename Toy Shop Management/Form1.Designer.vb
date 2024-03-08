<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToysHavingStockLessThan10ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADDUPDATEDELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADDUPDATEDELTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesOfLastWeekToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HeroProductOfMonthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.closebtn = New System.Windows.Forms.Button()
        Me.GENERATEBILLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToysToolStripMenuItem, Me.AgeToolStripMenuItem, Me.BillsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1277, 38)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToysToolStripMenuItem
        '
        Me.ToysToolStripMenuItem.BackColor = System.Drawing.Color.Lime
        Me.ToysToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToysHavingStockLessThan10ToolStripMenuItem, Me.ADDUPDATEDELETEToolStripMenuItem})
        Me.ToysToolStripMenuItem.Name = "ToysToolStripMenuItem"
        Me.ToysToolStripMenuItem.Size = New System.Drawing.Size(74, 34)
        Me.ToysToolStripMenuItem.Text = "Toys "
        '
        'ToysHavingStockLessThan10ToolStripMenuItem
        '
        Me.ToysHavingStockLessThan10ToolStripMenuItem.Name = "ToysHavingStockLessThan10ToolStripMenuItem"
        Me.ToysHavingStockLessThan10ToolStripMenuItem.Size = New System.Drawing.Size(385, 34)
        Me.ToysHavingStockLessThan10ToolStripMenuItem.Text = "Toys Having Stock Less than 10"
        '
        'ADDUPDATEDELETEToolStripMenuItem
        '
        Me.ADDUPDATEDELETEToolStripMenuItem.Name = "ADDUPDATEDELETEToolStripMenuItem"
        Me.ADDUPDATEDELETEToolStripMenuItem.Size = New System.Drawing.Size(385, 34)
        Me.ADDUPDATEDELETEToolStripMenuItem.Text = "ADD / UPDATE / DELETE"
        '
        'AgeToolStripMenuItem
        '
        Me.AgeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDUPDATEDELTEToolStripMenuItem})
        Me.AgeToolStripMenuItem.Name = "AgeToolStripMenuItem"
        Me.AgeToolStripMenuItem.Size = New System.Drawing.Size(64, 34)
        Me.AgeToolStripMenuItem.Text = "Age"
        '
        'ADDUPDATEDELTEToolStripMenuItem
        '
        Me.ADDUPDATEDELTEToolStripMenuItem.Name = "ADDUPDATEDELTEToolStripMenuItem"
        Me.ADDUPDATEDELTEToolStripMenuItem.Size = New System.Drawing.Size(281, 34)
        Me.ADDUPDATEDELTEToolStripMenuItem.Text = "ADD/UPDATE/DELTE"
        '
        'BillsToolStripMenuItem
        '
        Me.BillsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GENERATEBILLToolStripMenuItem, Me.SalesOfLastWeekToolStripMenuItem, Me.HeroProductOfMonthToolStripMenuItem})
        Me.BillsToolStripMenuItem.Name = "BillsToolStripMenuItem"
        Me.BillsToolStripMenuItem.Size = New System.Drawing.Size(62, 34)
        Me.BillsToolStripMenuItem.Text = "Bills"
        '
        'SalesOfLastWeekToolStripMenuItem
        '
        Me.SalesOfLastWeekToolStripMenuItem.Name = "SalesOfLastWeekToolStripMenuItem"
        Me.SalesOfLastWeekToolStripMenuItem.Size = New System.Drawing.Size(312, 34)
        Me.SalesOfLastWeekToolStripMenuItem.Text = "Sales of Last Week "
        '
        'HeroProductOfMonthToolStripMenuItem
        '
        Me.HeroProductOfMonthToolStripMenuItem.Name = "HeroProductOfMonthToolStripMenuItem"
        Me.HeroProductOfMonthToolStripMenuItem.Size = New System.Drawing.Size(312, 34)
        Me.HeroProductOfMonthToolStripMenuItem.Text = "Hero Product of Month"
        '
        'DataGridView1
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(86, 86)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(811, 482)
        Me.DataGridView1.TabIndex = 1
        '
        'closebtn
        '
        Me.closebtn.BackColor = System.Drawing.Color.Red
        Me.closebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.closebtn.Location = New System.Drawing.Point(822, 57)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(75, 23)
        Me.closebtn.TabIndex = 2
        Me.closebtn.Text = "EXIT"
        Me.closebtn.UseVisualStyleBackColor = False
        '
        'GENERATEBILLToolStripMenuItem
        '
        Me.GENERATEBILLToolStripMenuItem.Name = "GENERATEBILLToolStripMenuItem"
        Me.GENERATEBILLToolStripMenuItem.Size = New System.Drawing.Size(312, 34)
        Me.GENERATEBILLToolStripMenuItem.Text = "GENERATE BILL"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(5, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1277, 603)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.closebtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToysToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BillsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToysHavingStockLessThan10ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesOfLastWeekToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HeroProductOfMonthToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ADDUPDATEDELETEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ADDUPDATEDELTEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents closebtn As Button
    Friend WithEvents GENERATEBILLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
End Class
