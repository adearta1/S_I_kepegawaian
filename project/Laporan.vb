Imports Excel = Microsoft.Office.Interop.Excel
Public Class Laporan
    Sub loaddata()
        'menampilkan data penjualan
        Call konek()
        da = New Odbc.OdbcDataAdapter("SELECT * FROM transaksi", koneksi)
        ds = New DataSet
        da.Fill(ds)
        dgfPenjualan.DataSource = ds.Tables(0)
        dgfPenjualan.ReadOnly = True
        dgfPenjualan.Columns(0).Width = 80
        dgfPenjualan.Columns(2).Width = 180
        dgfPenjualan.Columns(5).Width = 180
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgfPenjualan.CellContentClick

    End Sub

    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loaddata()

    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles b_export.Click
        'mengexport data ke excel
        Try
            Dim ExcelApp As Microsoft.Office.Interop.Excel.Application
            Dim ExcelWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim ExcelWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim a As Integer
            Dim b As Integer

            ExcelApp = New Microsoft.Office.Interop.Excel.Application
            ExcelWorkBook = ExcelApp.Workbooks.Add(misValue)
            ExcelWorkSheet = ExcelWorkBook.Sheets("sheet1")

            For a = 0 To dgfPenjualan.RowCount - 2
                For b = 0 To dgfPenjualan.ColumnCount - 1
                    For c As Integer = 1 To dgfPenjualan.Columns.Count
                        ExcelWorkSheet.Cells(1, c) = dgfPenjualan.Columns(c - 1).HeaderText
                        ExcelWorkSheet.Cells(a + 2, b + 1) = dgfPenjualan(b, a).Value.ToString()
                    Next
                Next
            Next
            'lokasi menyimpan export data
            ExcelWorkSheet.SaveAs("C:\ade\test\project\laporan\LaporanPenjualan.xlsx")
            ExcelWorkBook.Close()
            ExcelApp.Quit()

            releaseObject(ExcelApp)
            releaseObject(ExcelWorkBook)
            releaseObject(ExcelWorkSheet)

            MsgBox("Hasil export tersimpan di C:\ade\test\project\laporan\, dengan nama LaporanPenjualan.xlsx")
        Catch ex As Exception

        End Try
    End Sub
End Class