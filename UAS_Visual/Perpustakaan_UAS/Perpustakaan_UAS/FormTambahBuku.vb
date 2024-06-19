Imports System.Data.Odbc

Public Class FormTambahBuku
    Dim Conn As OdbcConnection
    Dim Cmd As OdbcCommand
    Dim Ds As DataSet
    Dim Da As OdbcDataAdapter
    Dim Rd As OdbcDataReader
    Dim MyDB As String

    Private Sub FormTambahBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTambahBuku()
    End Sub

    Sub Koneksi()
        MyDB = "Driver={MySQL ODBC 8.3 ANSI Driver};Database=db_perpustakaan;Server=localhost;uid=root"
        Conn = New OdbcConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

    Private Sub LoadTambahBuku()
        ClearFields()

        Button1.Text = "Input"
        Button2.Text = "Edit"
        Button3.Text = "Delete"
        Button4.Text = "Back"

        Call Koneksi()
        Da = New OdbcDataAdapter("SELECT * FROM tbl_buku", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_buku")
        DataGridView1.DataSource = Ds.Tables("tbl_buku")
    End Sub

    Private Sub ClearFields()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then ' Check if Enter key is pressed
            Call Koneksi()
            Cmd = New OdbcCommand("SELECT * FROM tbl_buku WHERE id_buku=?", Conn)
            Cmd.Parameters.AddWithValue("@id_buku", TextBox1.Text)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                TextBox2.Text = Rd.Item("judul").ToString()
                TextBox3.Text = Rd.Item("tahun_terbit").ToString()
                ComboBox1.Text = Rd.Item("genre").ToString()
                TextBox5.Text = Rd.Item("Penerbit").ToString()
                TextBox6.Text = Rd.Item("pengarang").ToString()
                TextBox7.Text = Rd.Item("stock").ToString()
            Else
                MsgBox("Data Tidak Ada")
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            Call Koneksi()
            Dim InputData As String = "INSERT INTO tbl_buku (id_buku, judul, tahun_terbit, genre, Penerbit, pengarang, stock) VALUES (?, ?, ?, ?, ?, ?, ?)"
            Cmd = New OdbcCommand(InputData, Conn)
            Cmd.Parameters.AddWithValue("@id_buku", TextBox1.Text)
            Cmd.Parameters.AddWithValue("@judul", TextBox2.Text)
            Cmd.Parameters.AddWithValue("@tahun_terbit", TextBox3.Text)
            Cmd.Parameters.AddWithValue("@genre", ComboBox1.Text)
            Cmd.Parameters.AddWithValue("@Penerbit", TextBox5.Text)
            Cmd.Parameters.AddWithValue("@pengarang", TextBox6.Text)
            Cmd.Parameters.AddWithValue("@stock", TextBox7.Text)

            Cmd.ExecuteNonQuery()
            MsgBox("Data berhasil ditambahkan")
            Call LoadTambahBuku()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            Call Koneksi()
            Dim EditData As String = "UPDATE tbl_buku SET judul=?, tahun_terbit=?, genre=?, Penerbit=?, pengarang=?, stock=? WHERE id_buku=?"
            Cmd = New OdbcCommand(EditData, Conn)
            Cmd.Parameters.AddWithValue("@judul", TextBox2.Text)
            Cmd.Parameters.AddWithValue("@tahun_terbit", TextBox3.Text)
            Cmd.Parameters.AddWithValue("@genre", ComboBox1.Text)
            Cmd.Parameters.AddWithValue("@Penerbit", TextBox5.Text)
            Cmd.Parameters.AddWithValue("@pengarang", TextBox6.Text)
            Cmd.Parameters.AddWithValue("@stock", TextBox7.Text)
            Cmd.Parameters.AddWithValue("@id_buku", TextBox1.Text)

            Cmd.ExecuteNonQuery()
            MsgBox("Data berhasil diupdate")
            Call LoadTambahBuku()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("Masukkan ID Buku untuk menghapus data")
        Else
            Call Koneksi()
            Dim HapusData As String = "DELETE FROM tbl_buku WHERE id_buku=?"
            Cmd = New OdbcCommand(HapusData, Conn)
            Cmd.Parameters.AddWithValue("@id_buku", TextBox1.Text)

            Cmd.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus")
            Call LoadTambahBuku()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormLibrary.Show()
        Me.Close()
    End Sub
End Class
