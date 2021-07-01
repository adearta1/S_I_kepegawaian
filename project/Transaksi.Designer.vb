<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Transaksi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.b_print = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MCB_member = New MetroFramework.Controls.MetroComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_nama = New MetroFramework.Controls.MetroTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.service3 = New System.Windows.Forms.RadioButton()
        Me.service2 = New System.Windows.Forms.RadioButton()
        Me.service1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_hitung = New System.Windows.Forms.Button()
        Me.txt_kembalian = New MetroFramework.Controls.MetroTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_pembayaran = New MetroFramework.Controls.MetroTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_harga = New MetroFramework.Controls.MetroTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.opt3 = New System.Windows.Forms.CheckBox()
        Me.opt2 = New System.Windows.Forms.CheckBox()
        Me.opt1 = New System.Windows.Forms.CheckBox()
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        Me.txt_plat = New MetroFramework.Controls.MetroTextBox()
        Me.txt_struk = New MetroFramework.Controls.MetroTextBox()
        Me.b_reser = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No.Struk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(667, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(349, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No.Plat"
        '
        'b_print
        '
        Me.b_print.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.b_print.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_print.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.b_print.Location = New System.Drawing.Point(817, 467)
        Me.b_print.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.b_print.Name = "b_print"
        Me.b_print.Size = New System.Drawing.Size(100, 49)
        Me.b_print.TabIndex = 11
        Me.b_print.Text = "Print"
        Me.b_print.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.MCB_member)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_nama)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Berlin Sans FB Demi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Location = New System.Drawing.Point(16, 121)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(291, 297)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pelanggan"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button3.Font = New System.Drawing.Font("Berlin Sans FB Demi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.Location = New System.Drawing.Point(123, 68)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 30)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "TIDAK"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button2.Font = New System.Drawing.Font("Berlin Sans FB Demi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Location = New System.Drawing.Point(37, 68)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 30)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "YA"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'MCB_member
        '
        Me.MCB_member.FormattingEnabled = True
        Me.MCB_member.ItemHeight = 24
        Me.MCB_member.Items.AddRange(New Object() {"Full Service", "Half Service", "Only Wash"})
        Me.MCB_member.Location = New System.Drawing.Point(37, 149)
        Me.MCB_member.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MCB_member.Name = "MCB_member"
        Me.MCB_member.Size = New System.Drawing.Size(209, 30)
        Me.MCB_member.TabIndex = 28
        Me.MCB_member.UseSelectable = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(33, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 19)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Member"
        '
        'txt_nama
        '
        '
        '
        '
        Me.txt_nama.CustomButton.Image = Nothing
        Me.txt_nama.CustomButton.Location = New System.Drawing.Point(189, 1)
        Me.txt_nama.CustomButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nama.CustomButton.Name = ""
        Me.txt_nama.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_nama.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_nama.CustomButton.TabIndex = 1
        Me.txt_nama.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_nama.CustomButton.UseSelectable = True
        Me.txt_nama.CustomButton.Visible = False
        Me.txt_nama.Lines = New String(-1) {}
        Me.txt_nama.Location = New System.Drawing.Point(37, 218)
        Me.txt_nama.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nama.MaxLength = 32767
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nama.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_nama.SelectedText = ""
        Me.txt_nama.SelectionLength = 0
        Me.txt_nama.SelectionStart = 0
        Me.txt_nama.ShortcutsEnabled = True
        Me.txt_nama.Size = New System.Drawing.Size(211, 23)
        Me.txt_nama.TabIndex = 26
        Me.txt_nama.UseSelectable = True
        Me.txt_nama.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_nama.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Location = New System.Drawing.Point(33, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 19)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Id Member"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Location = New System.Drawing.Point(33, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 19)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Nama"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.service3)
        Me.GroupBox2.Controls.Add(Me.service2)
        Me.GroupBox2.Controls.Add(Me.service1)
        Me.GroupBox2.Font = New System.Drawing.Font("Berlin Sans FB Demi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox2.Location = New System.Drawing.Point(349, 121)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(267, 133)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Service"
        '
        'service3
        '
        Me.service3.AutoSize = True
        Me.service3.Location = New System.Drawing.Point(8, 96)
        Me.service3.Margin = New System.Windows.Forms.Padding(4)
        Me.service3.Name = "service3"
        Me.service3.Size = New System.Drawing.Size(114, 23)
        Me.service3.TabIndex = 2
        Me.service3.TabStop = True
        Me.service3.Text = "Only Wash"
        Me.service3.UseVisualStyleBackColor = True
        '
        'service2
        '
        Me.service2.AutoSize = True
        Me.service2.Location = New System.Drawing.Point(8, 62)
        Me.service2.Margin = New System.Windows.Forms.Padding(4)
        Me.service2.Name = "service2"
        Me.service2.Size = New System.Drawing.Size(122, 23)
        Me.service2.TabIndex = 1
        Me.service2.TabStop = True
        Me.service2.Text = "Half Service"
        Me.service2.UseVisualStyleBackColor = True
        '
        'service1
        '
        Me.service1.AutoSize = True
        Me.service1.Location = New System.Drawing.Point(8, 27)
        Me.service1.Margin = New System.Windows.Forms.Padding(4)
        Me.service1.Name = "service1"
        Me.service1.Size = New System.Drawing.Size(118, 23)
        Me.service1.TabIndex = 0
        Me.service1.TabStop = True
        Me.service1.Text = "Full Service"
        Me.service1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_hitung)
        Me.GroupBox3.Controls.Add(Me.txt_kembalian)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txt_pembayaran)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txt_harga)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Font = New System.Drawing.Font("Berlin Sans FB Demi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox3.Location = New System.Drawing.Point(669, 121)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(283, 303)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Harga"
        '
        'btn_hitung
        '
        Me.btn_hitung.Location = New System.Drawing.Point(148, 26)
        Me.btn_hitung.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_hitung.Name = "btn_hitung"
        Me.btn_hitung.Size = New System.Drawing.Size(100, 33)
        Me.btn_hitung.TabIndex = 25
        Me.btn_hitung.Text = "Hitung"
        Me.btn_hitung.UseVisualStyleBackColor = True
        '
        'txt_kembalian
        '
        '
        '
        '
        Me.txt_kembalian.CustomButton.Image = Nothing
        Me.txt_kembalian.CustomButton.Location = New System.Drawing.Point(191, 1)
        Me.txt_kembalian.CustomButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_kembalian.CustomButton.Name = ""
        Me.txt_kembalian.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_kembalian.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_kembalian.CustomButton.TabIndex = 1
        Me.txt_kembalian.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_kembalian.CustomButton.UseSelectable = True
        Me.txt_kembalian.CustomButton.Visible = False
        Me.txt_kembalian.Lines = New String(-1) {}
        Me.txt_kembalian.Location = New System.Drawing.Point(35, 250)
        Me.txt_kembalian.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_kembalian.MaxLength = 32767
        Me.txt_kembalian.Name = "txt_kembalian"
        Me.txt_kembalian.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_kembalian.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_kembalian.SelectedText = ""
        Me.txt_kembalian.SelectionLength = 0
        Me.txt_kembalian.SelectionStart = 0
        Me.txt_kembalian.ShortcutsEnabled = True
        Me.txt_kembalian.Size = New System.Drawing.Size(213, 23)
        Me.txt_kembalian.TabIndex = 29
        Me.txt_kembalian.UseSelectable = True
        Me.txt_kembalian.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_kembalian.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label12.Location = New System.Drawing.Point(29, 71)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 19)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Harga Total"
        '
        'txt_pembayaran
        '
        '
        '
        '
        Me.txt_pembayaran.CustomButton.Image = Nothing
        Me.txt_pembayaran.CustomButton.Location = New System.Drawing.Point(191, 1)
        Me.txt_pembayaran.CustomButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_pembayaran.CustomButton.Name = ""
        Me.txt_pembayaran.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_pembayaran.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_pembayaran.CustomButton.TabIndex = 1
        Me.txt_pembayaran.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_pembayaran.CustomButton.UseSelectable = True
        Me.txt_pembayaran.CustomButton.Visible = False
        Me.txt_pembayaran.Lines = New String(-1) {}
        Me.txt_pembayaran.Location = New System.Drawing.Point(35, 181)
        Me.txt_pembayaran.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_pembayaran.MaxLength = 32767
        Me.txt_pembayaran.Name = "txt_pembayaran"
        Me.txt_pembayaran.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_pembayaran.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_pembayaran.SelectedText = ""
        Me.txt_pembayaran.SelectionLength = 0
        Me.txt_pembayaran.SelectionStart = 0
        Me.txt_pembayaran.ShortcutsEnabled = True
        Me.txt_pembayaran.Size = New System.Drawing.Size(213, 23)
        Me.txt_pembayaran.TabIndex = 28
        Me.txt_pembayaran.UseSelectable = True
        Me.txt_pembayaran.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_pembayaran.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label13.Location = New System.Drawing.Point(29, 145)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 19)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Pembayaran"
        '
        'txt_harga
        '
        '
        '
        '
        Me.txt_harga.CustomButton.Image = Nothing
        Me.txt_harga.CustomButton.Location = New System.Drawing.Point(191, 1)
        Me.txt_harga.CustomButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_harga.CustomButton.Name = ""
        Me.txt_harga.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_harga.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_harga.CustomButton.TabIndex = 1
        Me.txt_harga.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_harga.CustomButton.UseSelectable = True
        Me.txt_harga.CustomButton.Visible = False
        Me.txt_harga.Lines = New String(-1) {}
        Me.txt_harga.Location = New System.Drawing.Point(35, 110)
        Me.txt_harga.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_harga.MaxLength = 32767
        Me.txt_harga.Name = "txt_harga"
        Me.txt_harga.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_harga.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_harga.SelectedText = ""
        Me.txt_harga.SelectionLength = 0
        Me.txt_harga.SelectionStart = 0
        Me.txt_harga.ShortcutsEnabled = True
        Me.txt_harga.Size = New System.Drawing.Size(213, 23)
        Me.txt_harga.TabIndex = 24
        Me.txt_harga.UseSelectable = True
        Me.txt_harga.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_harga.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label14.Location = New System.Drawing.Point(29, 217)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 19)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Kembalian"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 428)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(653, 101)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label17.Location = New System.Drawing.Point(252, 69)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(154, 19)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "telp.082 543 675 345"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Berlin Sans FB Demi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label15.Location = New System.Drawing.Point(281, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 19)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "AK CUMBIL"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label16.Location = New System.Drawing.Point(209, 50)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(238, 19)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Jln Apel Manis 1, Denpasar Utara"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.opt3)
        Me.GroupBox5.Controls.Add(Me.opt2)
        Me.GroupBox5.Controls.Add(Me.opt1)
        Me.GroupBox5.Font = New System.Drawing.Font("Berlin Sans FB Demi", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox5.Location = New System.Drawing.Point(349, 258)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(267, 159)
        Me.GroupBox5.TabIndex = 23
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Optional"
        '
        'opt3
        '
        Me.opt3.AutoSize = True
        Me.opt3.Location = New System.Drawing.Point(15, 113)
        Me.opt3.Margin = New System.Windows.Forms.Padding(4)
        Me.opt3.Name = "opt3"
        Me.opt3.Size = New System.Drawing.Size(143, 23)
        Me.opt3.TabIndex = 2
        Me.opt3.Text = "Inner and Seat"
        Me.opt3.UseVisualStyleBackColor = True
        '
        'opt2
        '
        Me.opt2.AutoSize = True
        Me.opt2.Location = New System.Drawing.Point(15, 76)
        Me.opt2.Margin = New System.Windows.Forms.Padding(4)
        Me.opt2.Name = "opt2"
        Me.opt2.Size = New System.Drawing.Size(86, 23)
        Me.opt2.TabIndex = 1
        Me.opt2.Text = "Engine"
        Me.opt2.UseVisualStyleBackColor = True
        '
        'opt1
        '
        Me.opt1.AutoSize = True
        Me.opt1.Location = New System.Drawing.Point(15, 38)
        Me.opt1.Margin = New System.Windows.Forms.Padding(4)
        Me.opt1.Name = "opt1"
        Me.opt1.Size = New System.Drawing.Size(65, 23)
        Me.opt1.TabIndex = 0
        Me.opt1.Text = "Wax"
        Me.opt1.UseVisualStyleBackColor = True
        '
        'MetroDateTime1
        '
        Me.MetroDateTime1.CalendarFont = New System.Drawing.Font("Berlin Sans FB", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroDateTime1.Location = New System.Drawing.Point(669, 62)
        Me.MetroDateTime1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 30)
        Me.MetroDateTime1.Name = "MetroDateTime1"
        Me.MetroDateTime1.Size = New System.Drawing.Size(283, 30)
        Me.MetroDateTime1.TabIndex = 5
        '
        'txt_plat
        '
        '
        '
        '
        Me.txt_plat.CustomButton.Image = Nothing
        Me.txt_plat.CustomButton.Location = New System.Drawing.Point(185, 1)
        Me.txt_plat.CustomButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_plat.CustomButton.Name = ""
        Me.txt_plat.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_plat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_plat.CustomButton.TabIndex = 1
        Me.txt_plat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_plat.CustomButton.UseSelectable = True
        Me.txt_plat.CustomButton.Visible = False
        Me.txt_plat.Lines = New String(-1) {}
        Me.txt_plat.Location = New System.Drawing.Point(349, 68)
        Me.txt_plat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_plat.MaxLength = 32767
        Me.txt_plat.Name = "txt_plat"
        Me.txt_plat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_plat.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_plat.SelectedText = ""
        Me.txt_plat.SelectionLength = 0
        Me.txt_plat.SelectionStart = 0
        Me.txt_plat.ShortcutsEnabled = True
        Me.txt_plat.Size = New System.Drawing.Size(207, 23)
        Me.txt_plat.TabIndex = 4
        Me.txt_plat.UseSelectable = True
        Me.txt_plat.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_plat.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_struk
        '
        '
        '
        '
        Me.txt_struk.CustomButton.Image = Nothing
        Me.txt_struk.CustomButton.Location = New System.Drawing.Point(169, 1)
        Me.txt_struk.CustomButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_struk.CustomButton.Name = ""
        Me.txt_struk.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_struk.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_struk.CustomButton.TabIndex = 1
        Me.txt_struk.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_struk.CustomButton.UseSelectable = True
        Me.txt_struk.CustomButton.Visible = False
        Me.txt_struk.Lines = New String(-1) {}
        Me.txt_struk.Location = New System.Drawing.Point(16, 68)
        Me.txt_struk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_struk.MaxLength = 32767
        Me.txt_struk.Name = "txt_struk"
        Me.txt_struk.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_struk.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_struk.SelectedText = ""
        Me.txt_struk.SelectionLength = 0
        Me.txt_struk.SelectionStart = 0
        Me.txt_struk.ShortcutsEnabled = True
        Me.txt_struk.Size = New System.Drawing.Size(191, 23)
        Me.txt_struk.TabIndex = 3
        Me.txt_struk.UseSelectable = True
        Me.txt_struk.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_struk.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'b_reser
        '
        Me.b_reser.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.b_reser.Font = New System.Drawing.Font("Berlin Sans FB Demi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_reser.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.b_reser.Location = New System.Drawing.Point(704, 467)
        Me.b_reser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.b_reser.Name = "b_reser"
        Me.b_reser.Size = New System.Drawing.Size(100, 49)
        Me.b_reser.TabIndex = 25
        Me.b_reser.Text = "Reset"
        Me.b_reser.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(999, 551)
        Me.Controls.Add(Me.b_reser)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.b_print)
        Me.Controls.Add(Me.MetroDateTime1)
        Me.Controls.Add(Me.txt_plat)
        Me.Controls.Add(Me.txt_struk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Transaksi"
        Me.Text = "Transaksi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents b_print As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents service3 As RadioButton
    Friend WithEvents service2 As RadioButton
    Friend WithEvents service1 As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents opt3 As CheckBox
    Friend WithEvents opt2 As CheckBox
    Friend WithEvents opt1 As CheckBox
    Friend WithEvents btn_hitung As Button
    Friend WithEvents txt_kembalian As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_pembayaran As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_harga As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_nama As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MCB_member As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txt_plat As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_struk As MetroFramework.Controls.MetroTextBox
    Friend WithEvents b_reser As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
