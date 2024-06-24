Imports System.Data.Odbc
Imports System.Drawing.Printing

Public Class FormReport
    Dim Conn As OdbcConnection
    Dim Cmd As OdbcCommand
    Dim Ds As DataSet
    Dim Da As OdbcDataAdapter
    Dim usersPrinted As Integer = 0
    Dim currentPrintPage As Integer = 0
    Sub Koneksi()
        Dim MyDB As String = "Driver={MySQL ODBC 8.3 ANSI Driver};Database=db_perpustakaan;Server=localhost;uid=root"
        Conn = New OdbcConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
    Private Sub FormReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPeminjamanData()
    End Sub

    Private Sub LoadPeminjamanData()
        Call Koneksi()
        Da = New OdbcDataAdapter("SELECT * FROM tbl_peminjaman", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_peminjaman")
        DataGridView1.DataSource = Ds.Tables("tbl_peminjaman")
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormTambahReport.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LoadPeminjamanData() ' Refresh data
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SearchPeminjamanData(TextBox1.Text.Trim())
    End Sub

    Private Sub SearchPeminjamanData(keyword As String)
        Try
            Call Koneksi()
            Dim query As String = "SELECT * FROM tbl_peminjaman WHERE " &
                              "id_transaksi LIKE ? OR " &
                              "id_anggota LIKE ? OR " &
                              "nama_anggota LIKE ? OR " &
                              "id_buku LIKE ? OR " &
                              "judul LIKE ? OR " &
                              "keterangan LIKE ? OR " &
                              "tgl_pinjam LIKE ? OR " &
                              "tgl_kembali LIKE ? OR " &
                              "status LIKE ?"

            Cmd = New OdbcCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@keyword1", "%" & keyword & "%")
            Cmd.Parameters.AddWithValue("@keyword2", "%" & keyword & "%")
            Cmd.Parameters.AddWithValue("@keyword3", "%" & keyword & "%")
            Cmd.Parameters.AddWithValue("@keyword4", "%" & keyword & "%")
            Cmd.Parameters.AddWithValue("@keyword5", "%" & keyword & "%")
            Cmd.Parameters.AddWithValue("@keyword6", "%" & keyword & "%")
            Cmd.Parameters.AddWithValue("@keyword7", "%" & keyword & "%")
            Cmd.Parameters.AddWithValue("@keyword8", "%" & keyword & "%")
            Cmd.Parameters.AddWithValue("@keyword9", "%" & keyword & "%")

            Da = New OdbcDataAdapter(Cmd)
            Ds = New DataSet
            Da.Fill(Ds, "tbl_peminjaman")
            DataGridView1.DataSource = Ds.Tables("tbl_peminjaman")
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim printPreviewDialog As New PrintPreviewDialog()
        Dim printDocument As New Printing.PrintDocument()
        AddHandler printDocument.PrintPage, AddressOf PrintDocument_PrintPage
        printPreviewDialog.Document = printDocument
        printPreviewDialog.ShowDialog()
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        Dim fontHeader As New Font("Arial", 16, FontStyle.Bold)
        Dim fontSubHeader As New Font("Arial", 10)
        Dim fontContent As New Font("Arial", 10)
        Dim fontFooter As New Font("Arial", 10)

        Dim marginKanan As Integer = 4 * 100 / 2.54
        Dim marginAtas As Integer = 3 * 100 / 2.54
        Dim marginKiri As Integer = 3 * 100 / 2.54
        Dim marginBawah As Integer = 3 * 100 / 2.54
        Dim now As DateTime = DateTime.Now
        Dim formattedDate As String = now.ToString("dd MMMM yyyy")

        Dim title As String = "Data Peminjaman Buku Perpustakaan"
        Dim titleSize As SizeF = e.Graphics.MeasureString(title, fontHeader)
        e.Graphics.DrawString(title, fontHeader, Brushes.Black, (e.PageBounds.Width - titleSize.Width) / 2, marginAtas)

        Dim dateSize As SizeF = e.Graphics.MeasureString(formattedDate, fontSubHeader)
        e.Graphics.DrawString(formattedDate, fontSubHeader, Brushes.Black, (e.PageBounds.Width - dateSize.Width) / 2, marginAtas + 50)
        e.Graphics.DrawLine(Pens.Black, marginKiri, marginAtas + 80, e.PageBounds.Width - marginKanan, marginAtas + 80)

        ' Data peminjaman
        Dim startY As Integer = marginAtas + 90
        Dim lineHeight As Integer = 20
        Dim usersPerPage As Integer = 3
        Dim startIndex As Integer = currentPrintPage * usersPerPage
        Dim endIndex As Integer = Math.Min(startIndex + usersPerPage - 1, DataGridView1.Rows.Count - 1)

        ' Mengambil data dari DataGridView
        Dim dgv As DataGridView = DataGridView1

        For i As Integer = startIndex To endIndex
            Dim row As DataGridViewRow = dgv.Rows(i)
            If Not row.IsNewRow AndAlso row.Cells("id_transaksi").Value IsNot Nothing Then
                Dim idTransaksi As String = If(row.Cells("id_transaksi").Value IsNot DBNull.Value, row.Cells("id_transaksi").Value.ToString(), "")
                Dim idAnggota As String = If(row.Cells("id_anggota").Value IsNot DBNull.Value, row.Cells("id_anggota").Value.ToString(), "")
                Dim idBuku As String = If(row.Cells("id_buku").Value IsNot DBNull.Value, row.Cells("id_buku").Value.ToString(), "")
                Dim namaAnggota As String = If(row.Cells("nama_anggota").Value IsNot DBNull.Value, row.Cells("nama_anggota").Value.ToString(), "")
                Dim judul As String = If(row.Cells("judul").Value IsNot DBNull.Value, row.Cells("judul").Value.ToString(), "")
                Dim tglPinjam As String = If(row.Cells("tgl_pinjam").Value IsNot DBNull.Value, row.Cells("tgl_pinjam").Value.ToString(), "")
                Dim tglKembali As String = If(row.Cells("tgl_kembali").Value IsNot DBNull.Value, row.Cells("tgl_kembali").Value.ToString(), "")
                Dim statusBuku As String = If(row.Cells("status").Value IsNot DBNull.Value, row.Cells("status").Value.ToString(), "")

                ' Menulis label dan nilainya
                e.Graphics.DrawString("ID Transaksi:", fontContent, Brushes.Black, marginKiri, startY)
                e.Graphics.DrawString(idTransaksi, fontContent, Brushes.Black, marginKiri + 200, startY)
                e.Graphics.DrawString("ID Anggota:", fontContent, Brushes.Black, marginKiri, startY + lineHeight)
                e.Graphics.DrawString(idAnggota, fontContent, Brushes.Black, marginKiri + 200, startY + lineHeight)
                e.Graphics.DrawString("ID Buku:", fontContent, Brushes.Black, marginKiri, startY + 2 * lineHeight)
                e.Graphics.DrawString(idBuku, fontContent, Brushes.Black, marginKiri + 200, startY + 2 * lineHeight)
                e.Graphics.DrawString("Nama Anggota:", fontContent, Brushes.Black, marginKiri, startY + 3 * lineHeight)
                e.Graphics.DrawString(namaAnggota, fontContent, Brushes.Black, marginKiri + 200, startY + 3 * lineHeight)
                e.Graphics.DrawString("Judul:", fontContent, Brushes.Black, marginKiri, startY + 4 * lineHeight)
                e.Graphics.DrawString(judul, fontContent, Brushes.Black, marginKiri + 200, startY + 4 * lineHeight)
                e.Graphics.DrawString("Tgl Pinjam:", fontContent, Brushes.Black, marginKiri, startY + 5 * lineHeight)
                e.Graphics.DrawString(tglPinjam, fontContent, Brushes.Black, marginKiri + 200, startY + 5 * lineHeight)
                e.Graphics.DrawString("Tgl Kembali:", fontContent, Brushes.Black, marginKiri, startY + 6 * lineHeight)
                e.Graphics.DrawString(tglKembali, fontContent, Brushes.Black, marginKiri + 200, startY + 6 * lineHeight)
                e.Graphics.DrawString("Status Buku:", fontContent, Brushes.Black, marginKiri, startY + 7 * lineHeight)
                e.Graphics.DrawString(statusBuku, fontContent, Brushes.Black, marginKiri + 200, startY + 7 * lineHeight)

                ' Pindah ke baris berikutnya
                startY += 9 * lineHeight
            End If
        Next

        ' Garis pembatas antara data dan informasi tambahan
        e.Graphics.DrawLine(Pens.Black, marginKiri, startY, e.PageBounds.Width - marginKanan, startY)

        ' Informasi tambahan
        startY += lineHeight
        Dim statements As String() = {
            "- bahwa saya sanggup mentaati/merawat, menjaga keutuhan dan kebersihan",
            " dari buku yang saya pinjam dengan sebaik-baiknya",
            "- Janji ini saya buat dengan tidak ada paksaan dari pihak manapun.",
            "- Apabila saya melanggar/mengingkari janji, saya sanggup diberi sanksi sesuai",
            " peraturan yang berlaku di Perpustakaan."
        }

        For Each statement In statements
            Dim statementSize As SizeF = e.Graphics.MeasureString(statement, fontFooter, e.PageBounds.Width - marginKiri - marginKanan)
            e.Graphics.DrawString(statement, fontFooter, Brushes.Black, marginKiri, startY)
            startY += statementSize.Height + 5
        Next
        currentPrintPage += 1
        e.Graphics.DrawString("Halaman " & currentPrintPage, fontFooter, Brushes.Black, e.PageBounds.Width - marginKanan - 60, e.PageBounds.Height - marginBawah + 20)

        If endIndex < DataGridView1.Rows.Count - 1 Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            currentPrintPage = 0
        End If
    End Sub

End Class
