Imports System.Data.Odbc
Public Class DaftarAdmin

    Sub Resetform()
        txtid.Clear()
        txtnama.Clear()
        txtusername.Clear()
        txtpassword.Clear()
        txtnama.Focus()
    End Sub

    Sub loaddata()
        'mengambil data pada database
        Call konek()
        da = New Odbc.OdbcDataAdapter("SELECT * FROM login", koneksi)
        ds = New DataSet
        da.Fill(ds)
        tabel1.DataSource = ds.Tables(0)
        tabel1.ReadOnly = True
        tabel1.Columns(1).Width = 180
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        'menyimpan data ketabel
        Try
            If txtnama.Text() = "" Then
                MsgBox("Nama tidak boleh kosong")
            ElseIf txtusername.Text = "" Then
                MsgBox("Username tidak boleh kosong")
            ElseIf txtpassword.Text = "" Then
                MsgBox("Password tidak boleh kosong")
            Else
                cmd = New Odbc.OdbcCommand("SELECT * FROM login WHERE id_admin = '" & "" & "'", koneksi)
                dr = cmd.ExecuteReader
                dr.Read()
                If Not dr.HasRows Then
                    cmd = New Odbc.OdbcCommand("INSERT INTO login (nama, username, password) VALUES ('" & txtnama.Text() & "', '" & txtusername.Text() & "', '" & txtpassword.Text() & "')", koneksi)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data berhasil disimpan")
                    Call Resetform()
                    Call loaddata()
                Else
                    MsgBox("Data '" & txtnama.Text() & "' sudah ada di database")
                End If
            End If
        Catch ex As Exception
            MsgBox("Ada kesalahan pada: " & ex.Message)
        End Try
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        'membersihkan data pada textbox
        Resetform()
    End Sub

    Private Sub DaftarAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        'mengedit data tabel
        Try
            If txtnama.Text() = "" Then
                MsgBox("Nama tidak boleh kosong")
            ElseIf txtusername.Text = "" Then
                MsgBox("Username tidak boleh kosong")
            ElseIf txtpassword.Text = "" Then
                MsgBox("Password tidak boleh kosong")
            Else
                cmd = New Odbc.OdbcCommand("SELECT * FROM login WHERE id_admin = '" & txtid.Text() & "'", koneksi)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    Dim edit As String = "Update login set nama = '" & txtnama.Text & "', username = '" & txtusername.Text & "', password = '" & txtpassword.Text & "' where id_admin = '" & txtid.Text & "'"
                    cmd = New Odbc.OdbcCommand(edit, koneksi)
                    cmd.ExecuteNonQuery()
                    MsgBox("Berhasil di edit", vbInformation, "Edit")
                    Call Resetform()
                    Call loaddata()
                Else
                    MsgBox("Data sudah ada")
                End If
            End If
        Catch ex As Exception
            MsgBox("Ada kesalahan pada: " & ex.Message)
        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        'mendelete data pada tabel
        If txtid.Text = "" Then
            MsgBox("Data belum dipilih", vbInformation, "Pesan")
            Exit Sub
        Else
            Dim hapusdata As String = "delete from login where id_admin ='" & txtid.Text & "'"
            cmd = New Odbc.OdbcCommand(hapusdata, koneksi)
            cmd.ExecuteNonQuery()
            Call loaddata()
            MsgBox("Data berhasil dihapus", vbInformation, "Pesan")
        End If
    End Sub

    Private Sub tabel1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabel1.CellContentClick

    End Sub

    Private Sub tabel1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles tabel1.CellMouseClick
        On Error Resume Next
        'menampilkan data pada text box apabila salah satu baris di klik
        txtid.Text = tabel1.Rows(e.RowIndex).Cells(0).Value
        cmd = New Odbc.OdbcCommand("SELECT * FROM login WHERE id_admin = '" & txtid.Text() & "'", koneksi)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            txtid.Text = dr.Item("id")
            txtnama.Text = dr.Item("nama")
            txtusername.Text = dr.Item("username")
            txtpassword.Text = dr.Item("password")
        End If
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        'pencarian database tergantung nama kolom yang dipilih
        If cbfilter.SelectedIndex = 0 Then
            da = New Odbc.OdbcDataAdapter("select * from login where id_admin like '" & txtcari.Text & "%'", koneksi)
            ds = New DataSet
            da.Fill(ds)
            tabel1.DataSource = ds.Tables(0)
        ElseIf cbfilter.SelectedIndex = 1 Then
            da = New Odbc.OdbcDataAdapter("select * from login where nama like'" & txtcari.Text & "%'", koneksi)
            ds = New DataSet
            da.Fill(ds)
            tabel1.DataSource = ds.Tables(0)
        ElseIf cbfilter.SelectedIndex = 2 Then
            da = New Odbc.OdbcDataAdapter("select * from login where username like'" & txtcari.Text & "%'", koneksi)
            ds = New DataSet
            da.Fill(ds)
            tabel1.DataSource = ds.Tables(0)
        Else
            MsgBox("katagori pencarian belum dipilih")
        End If
    End Sub
End Class