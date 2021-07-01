Imports System.Data.Odbc
Imports System.Drawing.Printing
Public Class Transaksi
    'variabel print
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    'variabel transaksi
    Dim total, bayar, kembali As Double
    Dim bycuci, totoption As Double
    Dim opt As CheckBox()
    Dim hargaoption() As Double = {70000, 100000, 60000}
    'variabel checkbox
    Dim tipe, tambahan As String
    Sub kondisiawal()
        'kondisi awal member
        txt_nama.Text = "Tidak Member"
        MCB_member.Items.Clear()
        MCB_member.Enabled = False
        txt_nama.Enabled = False
    End Sub

    Sub kosongkan()
        'mengosongkan data pada transaksi
        txt_struk.Clear()
        txt_plat.Clear()
        txt_harga.Clear()
        txt_pembayaran.Clear()
        txt_kembalian.Clear()
        service1.Checked = False
        service2.Checked = False
        service3.Checked = False
        opt1.Checked = False
        opt2.Checked = False
        opt3.Checked = False
        txt_struk.Focus()
    End Sub

    Sub isi()
        'membuka akses combobox member
        MCB_member.Enabled = True
        txt_nama.Text = " "
    End Sub

    Sub member()
        'mengambil data kode member 
        Call konek()
        cmd = New OdbcCommand("SELECT * from member", koneksi)
        dr = cmd.ExecuteReader
        Do While dr.Read
            MCB_member.Items.Add(dr.Item(0))
        Loop
    End Sub

    Sub checked()
        'data yang dicentang agar masuk ke database
        If service1.Checked Then
            tipe = service1.Text
        ElseIf service2.Checked Then
            tipe = service2.Text
        ElseIf service3.Checked Then
            tipe = service3.Text
        End If

        If opt1.Checked Then
            tambahan = opt1.Text
        End If
        If opt2.Checked Then
            tambahan = opt2.Text
        End If
        If opt3.Checked Then
            tambahan = opt3.Text
        End If
        If opt1.Checked = True And opt2.Checked = True Then
            tambahan = opt1.Text & ", " & opt2.Text
        End If
        If opt1.Checked = True And opt3.Checked = True Then
            tambahan = opt1.Text & ", " & opt3.Text
        End If
        If opt2.Checked = True And opt3.Checked = True Then
            tambahan = opt2.Text & ", " & opt3.Text
        End If
        If opt1.Checked = True And opt2.Checked = True And opt3.Checked = True Then
            tambahan = opt1.Text & ", " & opt2.Text & ", " & opt3.Text
        End If
    End Sub
    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()
        Dim i As Integer
        opt = New CheckBox() {opt1, opt2, opt3}
        bycuci = 0
    End Sub

    Private Sub service1_CheckedChanged(sender As Object, e As EventArgs) Handles service1.CheckedChanged
        bycuci = 80000
    End Sub

    Private Sub service2_CheckedChanged(sender As Object, e As EventArgs) Handles service2.CheckedChanged
        bycuci = 60000
    End Sub

    Private Sub service3_CheckedChanged(sender As Object, e As EventArgs) Handles service3.CheckedChanged
        bycuci = 30000
    End Sub

    Private Sub btn_hitung_Click(sender As Object, e As EventArgs) Handles btn_hitung.Click
        Dim i As Integer
        'penghitungan total harga dan potongan harga apabila pelanggan merupakan member
        totoption = 0
        For i = 0 To 2
            If opt(i).Checked Then
                totoption = totoption + hargaoption(i)
            End If
        Next
        total = bycuci + totoption
        If MCB_member.Enabled = True Then
            total = total * 0.9
        End If
        txt_harga.Text = "Rp. " & Format(total, "#,#.##")
    End Sub

    Private Sub txt_pembayaran_Click(sender As Object, e As EventArgs) Handles txt_pembayaran.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'tombol iya apabila ditekan menampilkan kode member pada combobox
        Call isi()
        Call member()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles b_print.Click
        Try
            If txt_plat.Text = "" Then
                MsgBox("data belum terisi")
            Else
                'menyimpan data ke database 
                Call checked()
                cmd = New Odbc.OdbcCommand("SELECT * FROM transaksi WHERE no_struk = '" & txt_struk.Text & "'", koneksi)
                dr = cmd.ExecuteReader
                dr.Read()
                If Not dr.HasRows Then
                    cmd = New Odbc.OdbcCommand("INSERT INTO transaksi (no_struk, no_plat, tanggal, nama_member, tipe, tambahan, harga_total, pembayaran, kembalian) VALUES ('" & txt_struk.Text() & "', '" & txt_plat.Text() & "', '" & MetroDateTime1.Text() & "', '" & txt_nama.Text() & "', '" & tipe & "', '" & tambahan & "', '" & txt_harga.Text() & "', '" & txt_pembayaran.Text() & "', '" & txt_kembalian.Text() & "')", koneksi)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data berhasil disimpan")
                    PPD.Document = PD
                    PPD.ShowDialog()

                    Call kondisiawal()
                    Call kosongkan()
                Else
                    MsgBox("Data '" & txt_struk.Text() & "' sudah ada di database")
                End If


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub b_reser_Click(sender As Object, e As EventArgs) Handles b_reser.Click
        Call kosongkan()
        Call kondisiawal()
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        'membuat ukuran kertas nota
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, 500)
        PD.DefaultPageSettings = pagesetup
    End Sub
    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        'variabel font nota
        Dim f12 As New Font("Times New Roman", 12, FontStyle.Regular)
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f12b As New Font("Times New Roman", 12, FontStyle.Bold)
        Dim f15 As New Font("Times New Roman", 15, FontStyle.Bold)
        'mengatur margin nota
        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width
        'mengatur posisi text
        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        'variabel garis
        Dim garis As String
        garis = "-----------------------------------------------------------"
        Call checked()

        'membuat isi dari nota
        e.Graphics.DrawString("AK CUMBIL", f15, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("Jln Apel Manis 1, Denpasar Utara", f12, Brushes.Black, centermargin, 27, tengah)
        e.Graphics.DrawString("telp.082 543 675 345", f10, Brushes.Black, centermargin, 42, tengah)

        e.Graphics.DrawString("no.struk", f12, Brushes.Black, 0, 62)
        e.Graphics.DrawString(":", f12, Brushes.Black, 67, 62)
        e.Graphics.DrawString(txt_struk.Text, f12, Brushes.Black, 77, 62)

        e.Graphics.DrawString("member", f12, Brushes.Black, 0, 77)
        e.Graphics.DrawString(":", f12, Brushes.Black, 67, 77)
        e.Graphics.DrawString(txt_nama.Text, f12, Brushes.Black, 77, 77)

        e.Graphics.DrawString(MetroDateTime1.Text, f12, Brushes.Black, 0, 92)

        e.Graphics.DrawString(garis, f12, Brushes.Black, 0, 102)

        e.Graphics.DrawString("harga tipe cumbil : ", f10, Brushes.Black, 0, 117)
        e.Graphics.DrawString("1. full service = Rp 80.000", f10, Brushes.Black, 0, 132)
        e.Graphics.DrawString("2. half service = Rp 60.000", f10, Brushes.Black, 0, 147)
        e.Graphics.DrawString("3. only wash = Rp 30.000", f10, Brushes.Black, 0, 162)

        e.Graphics.DrawString("harga tambahan cumbil : ", f10, Brushes.Black, 0, 177)
        e.Graphics.DrawString("1. wax = Rp 70.000", f10, Brushes.Black, 0, 192)
        e.Graphics.DrawString("2. engine service = Rp 100.000", f10, Brushes.Black, 0, 207)
        e.Graphics.DrawString("3. inner and seat = Rp 60.000", f10, Brushes.Black, 0, 222)

        e.Graphics.DrawString("apabila member mendapatkan potongan 9%", f10, Brushes.Black, 0, 237)

        e.Graphics.DrawString(garis, f12, Brushes.Black, 0, 247)

        e.Graphics.DrawString("tipe/tambahan yang dipesan : ", f10, Brushes.Black, 0, 262)
        e.Graphics.DrawString("tipe : ", f10, Brushes.Black, 0, 277)
        e.Graphics.DrawString(tipe, f10, Brushes.Black, 67, 277)

        e.Graphics.DrawString("tambahan : ", f10, Brushes.Black, 0, 292)
        e.Graphics.DrawString(tambahan, f10, Brushes.Black, 67, 292)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 302)

        e.Graphics.DrawString("total : ", f10, Brushes.Black, 0, 317)
        e.Graphics.DrawString(txt_harga.Text, f10, Brushes.Black, 67, 317)

        e.Graphics.DrawString("pembayaran : Rp. ", f10, Brushes.Black, 0, 332)
        e.Graphics.DrawString(txt_pembayaran.Text, f10, Brushes.Black, 107, 332)

        e.Graphics.DrawString("Kembalian : ", f10, Brushes.Black, 0, 347)
        e.Graphics.DrawString(txt_kembalian.Text, f10, Brushes.Black, 67, 347)

        e.Graphics.DrawString("~TERIMA KASIH~", f15, Brushes.Black, centermargin, 367, tengah)
    End Sub

    Private Sub MetroDateTime1_ValueChanged(sender As Object, e As EventArgs) Handles MetroDateTime1.ValueChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call kondisiawal()
    End Sub

    Private Sub MCB_member_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MCB_member.SelectedIndexChanged
        Call konek()
        'menampilkan data nama dari member apabila id member sudah dipilih
        cmd = New OdbcCommand("SELECT * from member where kode ='" & MCB_member.Text & "'", koneksi)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            txt_nama.Text = dr!nama
        End If
    End Sub

    Private Sub txt_pembayaran_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pembayaran.KeyPress
        'untuk menampilkan kembalian setelah data pembayaran di enter
        If e.KeyChar = Chr(13) Then
            kembali = Val(txt_pembayaran.Text) - total
            txt_kembalian.Text = "Rp. " & Format(kembali, "#,#.##")
        End If
    End Sub

End Class