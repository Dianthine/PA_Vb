Imports System.Data.Odbc
Imports System.Collections.Generic

Public Class FormTambahBuku

    Dim Conn As OdbcConnection
    Dim Cmd As OdbcCommand
    Dim Ds As DataSet
    Dim Da As OdbcDataAdapter
    Dim Rd As OdbcDataReader
    Dim MyDB As String

    Public Shared Event RecentlyAddedEvent()

    Private Sub FormTambahBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadTambahBuku()
        Catch ex As Exception
            MessageBox.Show("Error loading form: " & ex.Message)
        End Try
    End Sub

    Sub Koneksi()
        Try
            MyDB = "Driver={MySQL ODBC 8.3 ANSI Driver};Database=db_perpustakaan;Server=localhost;uid=root"
            Conn = New OdbcConnection(MyDB)
            If Conn.State = ConnectionState.Closed Then Conn.Open()
        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadTambahBuku()
        Try
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
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        Finally
            If Conn IsNot Nothing AndAlso Conn.State = ConnectionState.Open Then Conn.Close()
        End Try
    End Sub

    Private Sub ClearFields()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.SelectedIndex = -1
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
    End Sub
    Public Shared Function GetRecentlyAddedBooks() As List(Of String)
        Dim bookList As New List(Of String)()

        ' Koneksi dan pengambilan data
        Dim MyDB As String = "Driver={MySQL ODBC 8.3 ANSI Driver};Database=db_perpustakaan;Server=localhost;uid=root"
        Using Conn As New OdbcConnection(MyDB)
            Conn.Open()
            Using Cmd As New OdbcCommand("SELECT judul FROM tbl_buku ORDER BY id_buku DESC LIMIT 10", Conn)
                Using Rd As OdbcDataReader = Cmd.ExecuteReader()
                    While Rd.Read()
                        bookList.Add(Rd("judul").ToString())
                    End While
                End Using
            End Using
        End Using

        Return bookList
    End Function

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim idBuku As String = TextBox1.Text.Trim()

            If idBuku <> "" Then
                Try
                    Call Koneksi()
                    Cmd = New OdbcCommand("SELECT * FROM tbl_buku WHERE id_buku=?", Conn)
                    Cmd.Parameters.AddWithValue("@id_buku", idBuku)
                    Rd = Cmd.ExecuteReader()
                    If Rd.Read() Then
                        TextBox2.Text = Rd("judul").ToString()
                        TextBox3.Text = Rd("tahun_terbit").ToString()
                        ComboBox1.SelectedItem = Rd("genre").ToString()
                        TextBox5.Text = Rd("Penerbit").ToString()
                        TextBox6.Text = Rd("pengarang").ToString()
                        TextBox7.Text = Rd("stock").ToString()
                    Else
                        MsgBox("Data tidak ditemukan")
                        ClearFields()
                    End If
                    Rd.Close()
                Catch ex As Exception
                    MessageBox.Show("Error retrieving data: " & ex.Message)
                Finally
                    If Conn IsNot Nothing AndAlso Conn.State = ConnectionState.Open Then Conn.Close()
                End Try
            Else
                MsgBox("Masukkan ID Buku untuk mencari data")
                ClearFields()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ValidateFields() Then
            Try
                Call Koneksi()
                Dim InputData As String = "INSERT INTO tbl_buku (id_buku, judul, tahun_terbit, genre, Penerbit, pengarang, stock) VALUES (?, ?, ?, ?, ?, ?, ?)"
                Cmd = New OdbcCommand(InputData, Conn)
                Cmd.Parameters.AddWithValue("@id_buku", TextBox1.Text)
                Cmd.Parameters.AddWithValue("@judul", TextBox2.Text)
                Cmd.Parameters.AddWithValue("@tahun_terbit", TextBox3.Text)
                Cmd.Parameters.AddWithValue("@genre", ComboBox1.SelectedItem.ToString())
                Cmd.Parameters.AddWithValue("@Penerbit", TextBox5.Text)
                Cmd.Parameters.AddWithValue("@pengarang", TextBox6.Text)
                Cmd.Parameters.AddWithValue("@stock", TextBox7.Text)

                Cmd.ExecuteNonQuery()
                MsgBox("Data berhasil ditambahkan")
                LoadTambahBuku()

                ' Menyebarkan event bahwa data buku baru ditambahkan
                RaiseEvent RecentlyAddedEvent()
            Catch ex As Exception
                MessageBox.Show("Error adding data: " & ex.Message)
            Finally
                If Conn IsNot Nothing AndAlso Conn.State = ConnectionState.Open Then Conn.Close()
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ValidateFields() Then
            Try
                Call Koneksi()
                Dim EditData As String = "UPDATE tbl_buku SET judul=?, tahun_terbit=?, genre=?, Penerbit=?, pengarang=?, stock=? WHERE id_buku=?"
                Cmd = New OdbcCommand(EditData, Conn)
                Cmd.Parameters.AddWithValue("@judul", TextBox2.Text)
                Cmd.Parameters.AddWithValue("@tahun_terbit", TextBox3.Text)
                Cmd.Parameters.AddWithValue("@genre", ComboBox1.SelectedItem.ToString())
                Cmd.Parameters.AddWithValue("@Penerbit", TextBox5.Text)
                Cmd.Parameters.AddWithValue("@pengarang", TextBox6.Text)
                Cmd.Parameters.AddWithValue("@stock", TextBox7.Text)
                Cmd.Parameters.AddWithValue("@id_buku", TextBox1.Text)

                Cmd.ExecuteNonQuery()
                MsgBox("Data berhasil diupdate")
                LoadTambahBuku()

                RaiseEvent RecentlyAddedEvent()
            Catch ex As Exception
                MessageBox.Show("Error updating data: " & ex.Message)
            Finally
                If Conn IsNot Nothing AndAlso Conn.State = ConnectionState.Open Then Conn.Close()
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("Masukkan ID Buku untuk menghapus data")
        Else
            Try
                Call Koneksi()
                Dim HapusData As String = "DELETE FROM tbl_buku WHERE id_buku=?"
                Cmd = New OdbcCommand(HapusData, Conn)
                Cmd.Parameters.AddWithValue("@id_buku", TextBox1.Text)

                Cmd.ExecuteNonQuery()
                MsgBox("Data berhasil dihapus")
                LoadTambahBuku()

                RaiseEvent RecentlyAddedEvent()
            Catch ex As Exception
                MessageBox.Show("Error deleting data: " & ex.Message)
            Finally
                If Conn IsNot Nothing AndAlso Conn.State = ConnectionState.Open Then Conn.Close()
            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormLibrary.Show()
        Me.Close()
    End Sub

    Private Function ValidateFields() As Boolean
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.SelectedIndex = -1 Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then
            MsgBox("Pastikan semua field terisi")
            Return False
        Else
            Return True
        End If
    End Function
End Class
