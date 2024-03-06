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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToysHavingStockLessThan10ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesOfLastWeekToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HeroProductOfMonthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ADDUPDATEDELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
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
        'AgeToolStripMenuItem
        '
        Me.AgeToolStripMenuItem.Name = "AgeToolStripMenuItem"
        Me.AgeToolStripMenuItem.Size = New System.Drawing.Size(64, 34)
        Me.AgeToolStripMenuItem.Text = "Age"
        '
        'BillsToolStripMenuItem
        '
        Me.BillsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesOfLastWeekToolStripMenuItem, Me.HeroProductOfMonthToolStripMenuItem})
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
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(577, 316)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'ADDUPDATEDELETEToolStripMenuItem
        '
        Me.ADDUPDATEDELETEToolStripMenuItem.Name = "ADDUPDATEDELETEToolStripMenuItem"
        Me.ADDUPDATEDELETEToolStripMenuItem.Size = New System.Drawing.Size(385, 34)
        Me.ADDUPDATEDELETEToolStripMenuItem.Text = "ADD / UPDATE / DELETE"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1277, 603)
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
End Class
