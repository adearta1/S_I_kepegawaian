<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class member
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_kode = New System.Windows.Forms.TextBox()
        Me.TB_nama = New System.Windows.Forms.TextBox()
        Me.TB_notelp = New System.Windows.Forms.TextBox()
        Me.B_Input = New System.Windows.Forms.Button()
        Me.B_delete = New System.Windows.Forms.Button()
        Me.B_edit = New System.Windows.Forms.Button()
        Me.DG1 = New System.Windows.Forms.DataGridView()
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CB1 = New System.Windows.Forms.ComboBox()
        Me.B_clear = New System.Windows.Forms.Button()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(22, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(22, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(22, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No.Telp"
        '
        'TB_kode
        '
        Me.TB_kode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_kode.Location = New System.Drawing.Point(137, 29)
        Me.TB_kode.Name = "TB_kode"
        Me.TB_kode.Size = New System.Drawing.Size(140, 27)
        Me.TB_kode.TabIndex = 3
        '
        'TB_nama
        '
        Me.TB_nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_nama.Location = New System.Drawing.Point(137, 69)
        Me.TB_nama.Name = "TB_nama"
        Me.TB_nama.Size = New System.Drawing.Size(319, 27)
        Me.TB_nama.TabIndex = 4
        '
        'TB_notelp
        '
        Me.TB_notelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_notelp.Location = New System.Drawing.Point(137, 108)
        Me.TB_notelp.Name = "TB_notelp"
        Me.TB_notelp.Size = New System.Drawing.Size(319, 27)
        Me.TB_notelp.TabIndex = 5
        '
        'B_Input
        '
        Me.B_Input.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.B_Input.Cursor = System.Windows.Forms.Cursors.Default
        Me.B_Input.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Input.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.B_Input.Location = New System.Drawing.Point(26, 164)
        Me.B_Input.Name = "B_Input"
        Me.B_Input.Size = New System.Drawing.Size(87, 29)
        Me.B_Input.TabIndex = 6
        Me.B_Input.Text = "Input"
        Me.B_Input.UseVisualStyleBackColor = False
        '
        'B_delete
        '
        Me.B_delete.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.B_delete.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_delete.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.B_delete.Location = New System.Drawing.Point(579, 164)
        Me.B_delete.Name = "B_delete"
        Me.B_delete.Size = New System.Drawing.Size(83, 29)
        Me.B_delete.TabIndex = 7
        Me.B_delete.Text = "Delete"
        Me.B_delete.UseVisualStyleBackColor = False
        '
        'B_edit
        '
        Me.B_edit.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.B_edit.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_edit.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.B_edit.Location = New System.Drawing.Point(404, 164)
        Me.B_edit.Name = "B_edit"
        Me.B_edit.Size = New System.Drawing.Size(87, 29)
        Me.B_edit.TabIndex = 9
        Me.B_edit.Text = "Update"
        Me.B_edit.UseVisualStyleBackColor = False
        '
        'DG1
        '
        Me.DG1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG1.Location = New System.Drawing.Point(26, 211)
        Me.DG1.Name = "DG1"
        Me.DG1.RowHeadersWidth = 51
        Me.DG1.RowTemplate.Height = 24
        Me.DG1.Size = New System.Drawing.Size(636, 182)
        Me.DG1.TabIndex = 10
        '
        'TxtCari
        '
        Me.TxtCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCari.Location = New System.Drawing.Point(254, 410)
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(408, 27)
        Me.TxtCari.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(23, 413)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 19)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Search"
        '
        'CB1
        '
        Me.CB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB1.FormattingEnabled = True
        Me.CB1.Items.AddRange(New Object() {"kode", "nama"})
        Me.CB1.Location = New System.Drawing.Point(137, 409)
        Me.CB1.Name = "CB1"
        Me.CB1.Size = New System.Drawing.Size(99, 28)
        Me.CB1.TabIndex = 13
        '
        'B_clear
        '
        Me.B_clear.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.B_clear.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_clear.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.B_clear.Location = New System.Drawing.Point(202, 164)
        Me.B_clear.Name = "B_clear"
        Me.B_clear.Size = New System.Drawing.Size(90, 29)
        Me.B_clear.TabIndex = 14
        Me.B_clear.Text = "Clear"
        Me.B_clear.UseVisualStyleBackColor = False
        '
        'member
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(687, 458)
        Me.Controls.Add(Me.B_clear)
        Me.Controls.Add(Me.CB1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtCari)
        Me.Controls.Add(Me.DG1)
        Me.Controls.Add(Me.B_edit)
        Me.Controls.Add(Me.B_delete)
        Me.Controls.Add(Me.B_Input)
        Me.Controls.Add(Me.TB_notelp)
        Me.Controls.Add(Me.TB_nama)
        Me.Controls.Add(Me.TB_kode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "member"
        Me.Text = "Member"
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_kode As TextBox
    Friend WithEvents TB_nama As TextBox
    Friend WithEvents TB_notelp As TextBox
    Friend WithEvents B_Input As Button
    Friend WithEvents B_delete As Button
    Friend WithEvents B_edit As Button
    Friend WithEvents DG1 As DataGridView
    Friend WithEvents TxtCari As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CB1 As ComboBox
    Friend WithEvents B_clear As Button
End Class
