Imports System.Data.Odbc
Imports System.Collections.Generic

Public Class FormTambahAnggota

    Dim Conn As OdbcConnection
    Dim Cmd As OdbcCommand
    Dim Ds As DataSet
    Dim Da As OdbcDataAdapter
    Dim Rd As OdbcDataReader
    Dim MyDB As String

    Public Shared Event RecentlyAddedEvent()

    Private Sub FormTambahAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadTambahAnggota()
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

    Private Sub LoadTambahAnggota()
        Try
            ClearFields()

            Button1.Text = "Input"
            Button2.Text = "Edit"
            Button3.Text = "Delete"
            Button4.Text = "Back"

            Call Koneksi()
            Da = New OdbcDataAdapter("SELECT * FROM tbl_anggota", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "tbl_anggota")
            DataGridView1.DataSource = Ds.Tables("tbl_anggota")
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
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Public Shared Function GetRecentlyAddedMembers() As List(Of String)
        Dim members As New List(Of String)()
        Dim MyDB As String = "Driver={MySQL ODBC 8.3 ANSI Driver};Database=db_perpustakaan;Server=localhost;uid=root"
        Try
            Using Conn As New OdbcConnection(MyDB)
                Conn.Open()
                Using Cmd As New OdbcCommand("SELECT nama_anggota FROM tbl_anggota ORDER BY id_anggota DESC LIMIT 10", Conn)
                    Using Rd As OdbcDataReader = Cmd.ExecuteReader()
                        While Rd.Read()
                            members.Add(Rd("nama_anggota").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving members: " & ex.Message)
        End Try

        Return members
    End Function

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim idAnggota As String = TextBox1.Text.Trim()

            If idAnggota <> "" Then
                Try
                    Call Koneksi()
                    Cmd = New OdbcCommand("SELECT * FROM tbl_anggota WHERE id_anggota=?", Conn)
                    Cmd.Parameters.AddWithValue("@id_anggota", idAnggota)
                    Rd = Cmd.ExecuteReader()
                    If Rd.Read() Then
                        TextBox2.Text = Rd("nama_anggota").ToString()
                        TextBox3.Text = Rd("nim").ToString()
                        ComboBox1.SelectedItem = Rd("jenis_kelamin").ToString()
                        TextBox4.Text = Rd("email").ToString()
                        TextBox5.Text = Rd("no_telp").ToString()
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
                MsgBox("Masukkan ID Anggota untuk mencari data")
                ClearFields()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ValidateFields() Then
            Try
                Call Koneksi()
                Dim InputData As String = "INSERT INTO tbl_anggota (id_anggota, nama_anggota, nim, jenis_kelamin, email, no_telp) VALUES (?, ?, ?, ?, ?, ?)"
                Cmd = New OdbcCommand(InputData, Conn)
                Cmd.Parameters.AddWithValue("@id_anggota", TextBox1.Text)
                Cmd.Parameters.AddWithValue("@nama_anggota", TextBox2.Text)
                Cmd.Parameters.AddWithValue("@nim", TextBox3.Text)
                Cmd.Parameters.AddWithValue("@jenis_kelamin", ComboBox1.SelectedItem.ToString())
                Cmd.Parameters.AddWithValue("@email", TextBox4.Text)
                Cmd.Parameters.AddWithValue("@no_telp", TextBox5.Text)

                Cmd.ExecuteNonQuery()
                MsgBox("Data berhasil ditambahkan")
                LoadTambahAnggota()

                ' Menyebarkan event bahwa data anggota baru ditambahkan
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
                Dim EditData As String = "UPDATE tbl_anggota SET nama_anggota=?, nim=?, jenis_kelamin=?, email=?, no_telp=? WHERE id_anggota=?"
                Cmd = New OdbcCommand(EditData, Conn)
                Cmd.Parameters.AddWithValue("@nama_anggota", TextBox2.Text)
                Cmd.Parameters.AddWithValue("@nim", TextBox3.Text)
                Cmd.Parameters.AddWithValue("@jenis_kelamin", ComboBox1.SelectedItem.ToString())
                Cmd.Parameters.AddWithValue("@email", TextBox4.Text)
                Cmd.Parameters.AddWithValue("@no_telp", TextBox5.Text)
                Cmd.Parameters.AddWithValue("@id_anggota", TextBox1.Text)

                Cmd.ExecuteNonQuery()
                MsgBox("Data berhasil diupdate")
                LoadTambahAnggota()

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
            MsgBox("Masukkan ID Anggota untuk menghapus data")
        Else
            Try
                Call Koneksi()
                Dim HapusData As String = "DELETE FROM tbl_anggota WHERE id_anggota=?"
                Cmd = New OdbcCommand(HapusData, Conn)
                Cmd.Parameters.AddWithValue("@id_anggota", TextBox1.Text)

                Cmd.ExecuteNonQuery()
                MsgBox("Data berhasil dihapus")
                LoadTambahAnggota()

                RaiseEvent RecentlyAddedEvent()
            Catch ex As Exception
                MessageBox.Show("Error deleting data: " & ex.Message)
            Finally
                If Conn IsNot Nothing AndAlso Conn.State = ConnectionState.Open Then Conn.Close()
            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormAnggota.Show()
        Me.Close()
    End Sub

    Private Function ValidateFields() As Boolean
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.SelectedIndex = -1 Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Pastikan semua field terisi")
            Return False
        Else
            Return True
        End If
    End Function
End Class
