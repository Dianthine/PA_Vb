Imports System.Data.Odbc

Public Class FormTambahReport
    Dim Conn As OdbcConnection
    Dim Cmd As OdbcCommand
    Dim Ds As DataSet
    Dim Da As OdbcDataAdapter
    Dim Rd As OdbcDataReader
    Dim MyDB As String

    Private Sub FormTambahReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTambahReport()
    End Sub

    Sub Koneksi()
        MyDB = "Driver={MySQL ODBC 8.3 ANSI Driver};Database=db_perpustakaan;Server=localhost;uid=root"
        Conn = New OdbcConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

    Private Sub LoadTambahReport()
        ClearFields()

        Button1.Text = "Input"
        Button2.Text = "Edit"
        Button3.Text = "Delete"
        Button4.Text = "Back"

        Call Koneksi()
        Da = New OdbcDataAdapter("SELECT * FROM tbl_peminjaman", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_peminjaman")
        DataGridView1.DataSource = Ds.Tables("tbl_peminjaman")
    End Sub

    Private Sub ClearFields()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        DateTimePicker1.Value = DateTime.Now
        DateTimePicker2.Value = DateTime.Now
        ComboBox1.SelectedIndex = -1
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ValidateFields() Then
            Try
                Call Koneksi()
                Dim InputData As String = "INSERT INTO tbl_peminjaman (id_transaksi, id_anggota, nama_anggota, id_buku, judul, keterangan, tgl_pinjam, tgl_kembali, status) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)"
                Cmd = New OdbcCommand(InputData, Conn)
                Cmd.Parameters.AddWithValue("@id_transaksi", TextBox1.Text)
                Cmd.Parameters.AddWithValue("@id_anggota", TextBox2.Text)
                Cmd.Parameters.AddWithValue("@nama_anggota", TextBox3.Text)
                Cmd.Parameters.AddWithValue("@id_buku", TextBox6.Text)
                Cmd.Parameters.AddWithValue("@judul", TextBox4.Text)
                Cmd.Parameters.AddWithValue("@keterangan", TextBox5.Text)
                Cmd.Parameters.AddWithValue("@tgl_pinjam", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
                Cmd.Parameters.AddWithValue("@tgl_kembali", DateTimePicker2.Value.ToString("yyyy-MM-dd"))
                Cmd.Parameters.AddWithValue("@status", ComboBox1.Text)

                Cmd.ExecuteNonQuery()
                MsgBox("Data berhasil ditambahkan")
                LoadTambahReport()
                ClearFields()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                Conn.Close()
            End Try
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Try
                If TextBox1.Text.Trim() <> "" Then
                    Call Koneksi()
                    Dim query As String = "SELECT id_anggota, nama_anggota, id_buku, judul, keterangan, tgl_pinjam, tgl_kembali, status FROM tbl_peminjaman WHERE id_transaksi = ?"
                    Cmd = New OdbcCommand(query, Conn)
                    Cmd.Parameters.AddWithValue("@id_transaksi", TextBox1.Text.Trim())
                    Rd = Cmd.ExecuteReader()

                    If Rd.Read() Then
                        TextBox2.Text = Rd("id_anggota").ToString()
                        TextBox3.Text = Rd("nama_anggota").ToString()
                        TextBox6.Text = Rd("id_buku").ToString()
                        TextBox4.Text = Rd("judul").ToString()
                        TextBox5.Text = Rd("keterangan").ToString()
                        DateTimePicker1.Value = DateTime.Parse(Rd("tgl_pinjam").ToString())
                        DateTimePicker2.Value = DateTime.Parse(Rd("tgl_kembali").ToString())
                        ComboBox1.Text = Rd("status").ToString()
                    Else
                        ClearFields()
                    End If

                    Rd.Close()
                Else
                    ClearFields()
                End If
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                Conn.Close()
            End Try
        End If
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Try
                Call Koneksi()
                Dim query As String = "SELECT nama_anggota FROM tbl_anggota WHERE id_anggota = ?"
                Cmd = New OdbcCommand(query, Conn)
                Cmd.Parameters.AddWithValue("@id_anggota", TextBox2.Text.Trim())
                Rd = Cmd.ExecuteReader()

                If Rd.Read() Then
                    TextBox3.Text = Rd("nama_anggota").ToString()
                Else
                    MsgBox("Data tidak ditemukan")
                    TextBox3.Text = ""
                End If

                Rd.Close()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                Conn.Close()
            End Try
        End If
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Try
                Call Koneksi()
                Dim query As String = "SELECT judul FROM tbl_buku WHERE id_buku = ?"
                Cmd = New OdbcCommand(query, Conn)
                Cmd.Parameters.AddWithValue("@id_buku", TextBox6.Text.Trim())
                Rd = Cmd.ExecuteReader()

                If Rd.Read() Then
                    TextBox4.Text = Rd("judul").ToString()
                Else
                    MsgBox("Data tidak ditemukan")
                    TextBox4.Text = ""
                End If

                Rd.Close()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                Conn.Close()
            End Try
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ValidateFields() Then
            Try
                Call Koneksi()
                Dim EditData As String = "UPDATE tbl_peminjaman SET id_anggota=?, nama_anggota=?, id_buku=?, judul=?, keterangan=?, tgl_pinjam=?, tgl_kembali=?, status=? WHERE id_transaksi=?"
                Cmd = New OdbcCommand(EditData, Conn)
                Cmd.Parameters.AddWithValue("@id_anggota", TextBox2.Text)
                Cmd.Parameters.AddWithValue("@nama_anggota", TextBox3.Text)
                Cmd.Parameters.AddWithValue("@id_buku", TextBox6.Text)
                Cmd.Parameters.AddWithValue("@judul", TextBox4.Text)
                Cmd.Parameters.AddWithValue("@keterangan", TextBox5.Text)
                Cmd.Parameters.AddWithValue("@tgl_pinjam", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
                Cmd.Parameters.AddWithValue("@tgl_kembali", DateTimePicker2.Value.ToString("yyyy-MM-dd"))
                Cmd.Parameters.AddWithValue("@status", ComboBox1.Text)
                Cmd.Parameters.AddWithValue("@id_transaksi", TextBox1.Text)

                Cmd.ExecuteNonQuery()
                MsgBox("Data berhasil diupdate")
                LoadTambahReport()
                ClearFields()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                Conn.Close()
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("Masukkan ID_Transaksi untuk menghapus data")
        Else
            Try
                Call Koneksi()
                Dim HapusData As String = "DELETE FROM tbl_peminjaman WHERE id_transaksi=?"
                Cmd = New OdbcCommand(HapusData, Conn)
                Cmd.Parameters.AddWithValue("@id_transaksi", TextBox1.Text)

                Cmd.ExecuteNonQuery()
                MsgBox("Data berhasil dihapus")
                LoadTambahReport()
                ClearFields()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                Conn.Close()
            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormReport.Show()
        Me.Close()
    End Sub

    Private Function ValidateFields() As Boolean
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or DateTimePicker1.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Pastikan semua field terisi")
            Return False
        Else
            Return True
        End If
    End Function
End Class
