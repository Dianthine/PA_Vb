Imports System.Data.Common
Imports System.Data.Odbc

Public Class FormLibrary
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

    Private Sub FormLibrary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataBuku()
    End Sub

    Private Sub LoadDataBuku()
        Call Koneksi()
        Da = New OdbcDataAdapter("SELECT * FROM tbl_buku", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_buku")
        DataGridView1.DataSource = Ds.Tables("tbl_buku")
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormTambahBuku.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SearchDataBuku(TextBox1.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LoadDataBuku() ' Refresh data
    End Sub

    Private Sub SearchDataBuku(keyword As String)
        Call Koneksi()
        Dim query As String = "SELECT * FROM tbl_buku WHERE " &
                              "id_buku LIKE ? OR " &
                              "judul LIKE ? OR " &
                              "tahun_terbit LIKE ? OR " &
                              "genre LIKE ? OR " &
                              "Penerbit LIKE ? OR " &
                              "pengarang LIKE ? OR " &
                              "stock LIKE ?"
        Cmd = New OdbcCommand(query, Conn)
        Cmd.Parameters.AddWithValue("@keyword1", "%" & keyword & "%")
        Cmd.Parameters.AddWithValue("@keyword2", "%" & keyword & "%")
        Cmd.Parameters.AddWithValue("@keyword3", "%" & keyword & "%")
        Cmd.Parameters.AddWithValue("@keyword4", "%" & keyword & "%")
        Cmd.Parameters.AddWithValue("@keyword5", "%" & keyword & "%")
        Cmd.Parameters.AddWithValue("@keyword6", "%" & keyword & "%")
        Cmd.Parameters.AddWithValue("@keyword7", "%" & keyword & "%")

        Da = New OdbcDataAdapter(Cmd)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_buku")
        DataGridView1.DataSource = Ds.Tables("tbl_buku")
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
End Class
