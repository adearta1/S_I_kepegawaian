<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan
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
        Me.dgfPenjualan = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.b_export = New System.Windows.Forms.Button()
        CType(Me.dgfPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgfPenjualan
        '
        Me.dgfPenjualan.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgfPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgfPenjualan.Location = New System.Drawing.Point(12, 72)
        Me.dgfPenjualan.Name = "dgfPenjualan"
        Me.dgfPenjualan.RowHeadersWidth = 51
        Me.dgfPenjualan.RowTemplate.Height = 24
        Me.dgfPenjualan.Size = New System.Drawing.Size(1463, 329)
        Me.dgfPenjualan.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB Demi", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(590, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LAPORAN PENJUALAN"
        '
        'b_export
        '
        Me.b_export.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.b_export.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_export.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.b_export.Location = New System.Drawing.Point(645, 411)
        Me.b_export.Name = "b_export"
        Me.b_export.Size = New System.Drawing.Size(178, 43)
        Me.b_export.TabIndex = 2
        Me.b_export.Text = "Export "
        Me.b_export.UseVisualStyleBackColor = False
        '
        'Laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1487, 466)
        Me.Controls.Add(Me.b_export)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgfPenjualan)
        Me.Name = "Laporan"
        Me.Text = "Laporan"
        CType(Me.dgfPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgfPenjualan As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents b_export As Button
End Class
