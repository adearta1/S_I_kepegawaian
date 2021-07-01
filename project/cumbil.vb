Public Class cumbil
    Private Sub MembershipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MembershipToolStripMenuItem.Click
        member.Show()
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        DaftarAdmin.Show()
    End Sub

    Private Sub cumbil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem.Click
        Transaksi.Show()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        Laporan.Show()
    End Sub
End Class