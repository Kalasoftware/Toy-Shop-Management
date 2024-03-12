<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class phero
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
        Me.heroview = New System.Windows.Forms.DataGridView()
        CType(Me.heroview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'heroview
        '
        Me.heroview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.heroview.Location = New System.Drawing.Point(152, 48)
        Me.heroview.Name = "heroview"
        Me.heroview.Size = New System.Drawing.Size(741, 528)
        Me.heroview.TabIndex = 0
        '
        'phero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1299, 609)
        Me.Controls.Add(Me.heroview)
        Me.Name = "phero"
        Me.Text = "phero"
        CType(Me.heroview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents heroview As DataGridView
End Class
