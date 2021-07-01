Imports System.Data.Odbc

Public Class member
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub
    Sub tampilData()
        'mengambil data pada database
        Call konek()
        da = New OdbcDataAdapter("SELECT * FROM member", koneksi)
        ds = New DataSet
        da.Fill(ds)
        DG1.DataSource = ds.Tables(0)
        DG1.ReadOnly = True
        DG1.Columns(1).Width = 210
        DG1.Columns(2).Width = 115
    End Sub

    Sub Resetform()
        TB_nama.Clear()
        TB_kode.Clear()
        TB_notelp.Clear()
        TB_kode.Focus()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles B_Input.Click
        'menyimpan data ketabel
        Try
            If TB_nama.Text = "" Then
                MsgBox("Nama tidak boleh kosong")
            ElseIf TB_notelp.Text = "" Then
                MsgBox("Notlp tidak boleh kosong")
            Else
                cmd = New OdbcCommand("SELECT * FROM member WHERE kode = '" & "" & "'", koneksi)
                dr = cmd.ExecuteReader
                dr.Read()
                If Not dr.HasRows Then
                    cmd = New OdbcCommand("INSERT INTO member (nama, notlp ) VALUES ('" & TB_nama.Text() & "', '" & TB_notelp.Text() & "')", koneksi)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data berhasil disimpan")
                    Call Resetform()
                    Call tampilData()
                Else
                    MsgBox("Data '" & TB_kode.Text() & "' sudah ada di database")
                End If
            End If
        Catch ex As Exception
            MsgBox("Ada kesalahan pada: " & ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData()
    End Sub

    Private Sub DG1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG1.CellContentClick

    End Sub

    Private Sub B_edit_Click(sender As Object, e As EventArgs) Handles B_edit.Click
        'mengedit data pada tabel
        Try
            If TB_kode.Text() = "" Then
                MsgBox("Kode tidak boleh kosong")
            ElseIf TB_nama.Text = "" Then
                MsgBox("Nama tidak boleh kosong")
            ElseIf TB_notelp.Text = "" Then
                MsgBox("Notlp tidak boleh kosong")
            Else
                cmd = New OdbcCommand("SELECT * FROM member WHERE kode = '" & TB_kode.Text() & "'", koneksi)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    Dim edit As String = "UPDATE member SET nama ='" & TB_nama.Text & "', notlp='" & TB_notelp.Text & "' WHERE kode = '" & TB_kode.Text & "'"
                    cmd = New OdbcCommand(edit, koneksi)
                    cmd.ExecuteNonQuery()
                    MsgBox("berhasil di edit", vbInformation, "Simpan")
                    Call tampilData()
                    Call Resetform()
                Else
                    MsgBox("data belum dipilih")
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox("Ada kesalahan pada: " & ex.Message)
        End Try
    End Sub

    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
        'mencari data berdasarkan nama kolom pada tabel
        If CB1.SelectedIndex = 0 Then
            da = New OdbcDataAdapter("SELECT * FROM member WHERE kode like '" & TxtCari.Text & "%'", koneksi)
            ds = New DataSet
            da.Fill(ds)
            DG1.DataSource = ds.Tables(0)
        Else
            da = New OdbcDataAdapter("SELECT * FROM member WHERE nama like '" & TxtCari.Text & "%'", koneksi)
            ds = New DataSet
            da.Fill(ds)
            DG1.DataSource = ds.Tables(0)
        End If

    End Sub

    Private Sub B_delete_Click(sender As Object, e As EventArgs) Handles B_delete.Click
        'menghapus data pada tabel
        If TB_kode.Text = "" Then
            MsgBox("data belum dipilih !", vbInformation, "Pesan")
            Exit Sub
        Else
            Dim hapus As String = "DELETE FROM member WHERE kode = '" & TB_kode.Text & "'"
            cmd = New OdbcCommand(hapus, koneksi)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus ", vbInformation, "Pesan")
            Call tampilData()
            Call Resetform()
        End If
    End Sub

    Private Sub DG1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DG1.CellMouseClick
        On Error Resume Next
        'menampilkan data pada text box apabila salah satu baris di klik
        TB_kode.Text = DG1.Rows(e.RowIndex).Cells(0).Value
        cmd = New OdbcCommand("SELECT * FROM member WHERE kode= '" & TB_kode.Text & "'", koneksi)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            TB_kode.Text = dr.Item("kode")
            TB_nama.Text = dr.Item("nama")
            TB_notelp.Text = dr.Item("notlp")
        End If
    End Sub

    Private Sub B_clear_Click(sender As Object, e As EventArgs) Handles B_clear.Click
        Call Resetform()
    End Sub

    Private Sub CB1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB1.SelectedIndexChanged

    End Sub
End Class
