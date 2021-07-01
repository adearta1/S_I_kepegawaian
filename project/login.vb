Public Class login
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        'menampilkan peringatan saat tombol login ditekan
        Call konek()
        If koneksi.State <> ConnectionState.Closed Then koneksi.Close()
        koneksi.Open()
        cmd = New Odbc.OdbcCommand("SELECT username,password From login  WHERE Username = '" & TxtUsername.Text & "' and Password = '" & TxtPassword.Text & "'", koneksi)
        dr = cmd.ExecuteReader
        If TxtUsername.Text = "" Then
            MessageBox.Show("Username wajib diisi !!!", "Peringatan!")
            TxtUsername.Focus()
            Exit Sub
        ElseIf TxtPassword.Text = "" Then
            MessageBox.Show("Password wajib diisi !!!", "Peringatan!")
            TxtPassword.Focus()
            Exit Sub
        End If
        If (dr.Read) Then
            MsgBox("Login Success", MsgBoxStyle.OkOnly,
                   "SELAMAT DATANG")
            Me.Hide()
            cumbil.Show()
        Else
            MsgBox("Username & Password Anda Salah!", MsgBoxStyle.OkOnly,
                   "Login gagal")
            TxtUsername.Text = ""
            TxtPassword.Text = ""
            TxtUsername.Focus()
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        'keluar dari menu login saat tombol cancel ditekan
        Me.Close()
    End Sub
End Class