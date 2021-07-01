Imports System.Data.Odbc

Module Mdkoneksi

    Public cmd As OdbcCommand
    Public da As OdbcDataAdapter
    Public dr As OdbcDataReader
    Public ds As DataSet
    Public koneksi As OdbcConnection


    Sub konek()
        Try
            koneksi = New OdbcConnection(" DSN=DB_cumbil; MultipleActiveResultSets=True ")
            If koneksi.State = ConnectionState.Closed Then
                koneksi.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi ke database gagal", vbCritical, "gagal")
        End Try
    End Sub
End Module
