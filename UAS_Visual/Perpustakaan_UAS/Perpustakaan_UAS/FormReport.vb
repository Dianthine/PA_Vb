Imports System.Data.Odbc
Imports System.Drawing.Printing

Public Class FormReport
    Dim Conn As OdbcConnection
    Dim Cmd As OdbcCommand
    Dim Ds As DataSet
    Dim Da As OdbcDataAdapter
    Dim Rd As OdbcDataReader
    Dim MyDB As String

    Sub Koneksi()
        MyDB = "Driver={MySQL ODBC 8.3 ANSI Driver};Database=db_perpustakaan;Server=localhost;uid=root"
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
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
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

            Da = New OdbcDataAdapter(Cmd)
            Ds = New DataSet
            Da.Fill(Ds, "tbl_peminjaman")
            DataGridView1.DataSource = Ds.Tables("tbl_peminjaman")
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Membuat dialog untuk preview sebelum mencetak
        Dim printPreviewDialog As New PrintPreviewDialog()
        Dim printDocument As New Printing.PrintDocument()

        ' Mengatur event untuk cetak
        AddHandler printDocument.PrintPage, AddressOf PrintDocument_PrintPage

        ' Mengatur dokumen yang akan ditampilkan di preview dialog
        printPreviewDialog.Document = printDocument

        ' Menampilkan dialog preview
        printPreviewDialog.ShowDialog()
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        ' Mengatur font dan ukuran untuk teks
        Dim fontHeader As New Font("Arial", 16, FontStyle.Bold)
        Dim fontSubHeader As New Font("Arial", 10)
        Dim fontContent As New Font("Arial", 10)
        Dim fontFooter As New Font("Arial", 10)

        ' Mengatur margin
        Dim marginKanan As Integer = 4 * 100 / 2.54 ' Konversi cm ke inci kemudian ke piksel
        Dim marginAtas As Integer = 3 * 100 / 2.54
        Dim marginKiri As Integer = 3 * 100 / 2.54
        Dim marginBawah As Integer = 3 * 100 / 2.54

        e.PageSettings.Margins = New Margins(marginKiri, marginKanan, marginAtas, marginBawah)

        ' Mengatur posisi dan format tanggal
        Dim now As DateTime = DateTime.Now
        Dim formattedDate As String = now.ToString("HH:mm, dd MMMM yyyy")

        ' Menulis judul utama
        Dim title As String = "Data Peminjaman Buku Perpustakaan"
        Dim titleSize As SizeF = e.Graphics.MeasureString(title, fontHeader)
        e.Graphics.DrawString(title, fontHeader, Brushes.Black,
                              (e.PageBounds.Width - titleSize.Width) / 2, marginAtas)

        ' Menulis tanggal di bawah judul
        Dim dateSize As SizeF = e.Graphics.MeasureString(formattedDate, fontSubHeader)
        e.Graphics.DrawString(formattedDate, fontSubHeader, Brushes.Black,
                              (e.PageBounds.Width - dateSize.Width) / 2, marginAtas + 50)

        ' Garis pembatas atas
        e.Graphics.DrawLine(Pens.Black, marginKiri, marginAtas + 80, e.PageBounds.Width - marginKanan, marginAtas + 80)

        ' Data peminjaman
        Dim startY As Integer = marginAtas + 90
        Dim lineHeight As Integer = 20
        Dim usersPerPage As Integer = 4
        Dim usersPrinted As Integer = 0

        ' Mengambil data dari DataGridView
        Dim dgv As DataGridView = DataGridView1
        For Each row As DataGridViewRow In dgv.Rows
            ' Pastikan baris tidak null dan tidak kosong
            If Not row.IsNewRow AndAlso row.Cells("id_transaksi").Value IsNot Nothing Then
                If usersPrinted >= usersPerPage Then
                    e.HasMorePages = True
                    Exit Sub
                End If

                Dim idTransaksi As String = row.Cells("id_transaksi").Value.ToString()
                Dim idAnggota As String = row.Cells("id_anggota").Value.ToString()
                Dim namaAnggota As String = row.Cells("nama_anggota").Value.ToString()
                Dim judul As String = row.Cells("judul").Value.ToString()
                Dim tglPinjam As String = row.Cells("tgl_pinjam").Value.ToString()
                Dim tglKembali As String = row.Cells("tgl_kembali").Value.ToString()

                ' Menulis label dan nilainya
                e.Graphics.DrawString("ID Transaksi:", fontContent, Brushes.Black, marginKiri, startY)
                e.Graphics.DrawString(idTransaksi, fontContent, Brushes.Black, marginKiri + 200, startY)
                e.Graphics.DrawString("ID Anggota:", fontContent, Brushes.Black, marginKiri, startY + lineHeight)
                e.Graphics.DrawString(idAnggota, fontContent, Brushes.Black, marginKiri + 200, startY + lineHeight)
                e.Graphics.DrawString("Nama Anggota:", fontContent, Brushes.Black, marginKiri, startY + 2 * lineHeight)
                e.Graphics.DrawString(namaAnggota, fontContent, Brushes.Black, marginKiri + 200, startY + 2 * lineHeight)
                e.Graphics.DrawString("Judul:", fontContent, Brushes.Black, marginKiri, startY + 3 * lineHeight)
                e.Graphics.DrawString(judul, fontContent, Brushes.Black, marginKiri + 200, startY + 3 * lineHeight)
                e.Graphics.DrawString("Tgl Pinjam:", fontContent, Brushes.Black, marginKiri, startY + 4 * lineHeight)
                e.Graphics.DrawString(tglPinjam, fontContent, Brushes.Black, marginKiri + 200, startY + 4 * lineHeight)
                e.Graphics.DrawString("Tgl Kembali:", fontContent, Brushes.Black, marginKiri, startY + 5 * lineHeight)
                e.Graphics.DrawString(tglKembali, fontContent, Brushes.Black, marginKiri + 200, startY + 5 * lineHeight)

                ' Pindah ke baris berikutnya
                startY += 7 * lineHeight
                usersPrinted += 1
            End If
        Next

        ' Garis pembatas antara data dan informasi tambahan
        e.Graphics.DrawLine(Pens.Black, marginKiri, startY, e.PageBounds.Width - marginKanan, startY)

        ' Informasi tambahan
        startY += lineHeight
        Dim statement As String = "Dengan ini saya menyatakan:"
        e.Graphics.DrawString(statement, fontFooter, Brushes.Black, marginKiri, startY)
        startY += lineHeight ' Tambahkan lineHeight setelah menulis statement

        Dim statements As String() = {
            "- bahwa saya sanggup mentaati/merawat, menjaga keutuhan dan kebersihan dari buku yang saya pinjam dengan sebaik-baiknya",
            "- Janji ini saya buat dengan tidak ada paksaan dari pihak manapun.",
            "- Apabila saya melanggar/mengingkari janji, saya sanggup diberi sanksi sesuai peraturan yang berlaku di Perpustakaan."
        }

        ' Menulis setiap pernyataan dengan memeriksa ukuran teks
        For Each stmt As String In statements
            Dim textSize As SizeF = e.Graphics.MeasureString(stmt, fontFooter)
            If textSize.Width > e.PageBounds.Width - (marginKiri + marginKanan) Then
                ' Teks terlalu panjang, perlu dibagi menjadi beberapa baris
                Dim words As String() = stmt.Split(" "c)
                Dim currentLine As String = ""
                For Each word As String In words
                    Dim testLine As String = If(currentLine = "", word, currentLine & " " & word)
                    If e.Graphics.MeasureString(testLine, fontFooter).Width > e.PageBounds.Width - (marginKiri + marginKanan) Then
                        ' Gambar baris saat ini
                        e.Graphics.DrawString(currentLine, fontFooter, Brushes.Black, marginKiri, startY)
                        currentLine = word
                        startY += lineHeight
                    Else
                        currentLine = testLine
                    End If
                Next
                ' Gambar baris terakhir
                If currentLine <> "" Then
                    e.Graphics.DrawString(currentLine, fontFooter, Brushes.Black, marginKiri, startY)
                    startY += lineHeight
                End If
            Else
                e.Graphics.DrawString(stmt, fontFooter, Brushes.Black, marginKiri, startY)
                startY += lineHeight
            End If
        Next

        ' Selesai
        e.HasMorePages = False

        ' Membersihkan objek font
        fontHeader.Dispose()
        fontSubHeader.Dispose()
        fontContent.Dispose()
        fontFooter.Dispose()
    End Sub
End Class
