Imports System.Data.Common
Imports System.Data.Odbc
Public Class FormAnggota

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

    Private Sub FormAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataAnggota()
    End Sub
    Private Sub LoadDataAnggota()
        Call Koneksi()
        Da = New OdbcDataAdapter("Select * from tbl_anggota", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_anggota")
        DataGridView1.DataSource = Ds.Tables("tbl_anggota")
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LoadDataAnggota()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormTambahAnggota.Show()
    End Sub
End Class