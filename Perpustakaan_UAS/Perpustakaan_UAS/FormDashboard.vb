Imports System.Collections.Generic
Imports System.Windows.Forms
Imports System.Data.Odbc
Imports Perpustakaan_UAS.FormTambahBuku
Imports Perpustakaan_UAS.FormTambahAnggota

Public Class FormDashboard
    Dim images As New List(Of Image)()
    Dim currentIndex As Integer = 0
    Dim timerInterval As Integer = 3000
    Dim isPlaying As Boolean = False
    Public Delegate Sub LoadRecentlyAddedDelegate()
    Private Conn As OdbcConnection

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        images.Add(My.Resources.img1)
        images.Add(My.Resources.img2)
        images.Add(My.Resources.img3)
        images.Add(My.Resources.img4)
        images.Add(My.Resources.img5)

        DisplayImage(currentIndex)

        Timer1.Interval = timerInterval
        AddHandler FormTambahBuku.RecentlyAddedEvent, AddressOf UpdateRecentlyAddedBooks
        AddHandler FormTambahAnggota.RecentlyAddedEvent, AddressOf UpdateRecentlyAddedMembers

        UpdateRecentlyAddedBooks()
        UpdateRecentlyAddedMembers()

        ListView1.View = View.List
        ListView2.View = View.List

        UpdateTotalAnggota()
        UpdateTotalBuku()
    End Sub
    Private Sub Koneksi()
        Dim MyDB As String = "Driver={MySQL ODBC 8.3 ANSI Driver};Database=db_perpustakaan;Server=localhost;uid=root"
        Conn = New OdbcConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
    Private Sub DisplayImage(index As Integer)
        If index >= 0 AndAlso index < images.Count Then
            PictureBox1.Image = images(index)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        currentIndex = (currentIndex + 1) Mod images.Count
        DisplayImage(currentIndex)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        currentIndex -= 1
        If currentIndex < 0 Then
            currentIndex = images.Count - 1
        End If
        DisplayImage(currentIndex)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If isPlaying Then
            Timer1.Stop()
            Button2.Text = "Play"
        Else
            Timer1.Start()
            Button2.Text = "Pause"
        End If
        isPlaying = Not isPlaying
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        currentIndex = (currentIndex + 1) Mod images.Count
        DisplayImage(currentIndex)
    End Sub

    Private Sub UpdateRecentlyAddedBooks()
        ListView1.Items.Clear()

        Dim recentlyAddedBooksList As List(Of String) = FormTambahBuku.GetRecentlyAddedBooks()
        Dim maxItems As Integer = 10
        Dim itemsToAdd = Math.Min(recentlyAddedBooksList.Count, maxItems)

        For i As Integer = 0 To itemsToAdd - 1
            Dim item As New ListViewItem(recentlyAddedBooksList(i))
            ListView1.Items.Add(item)
        Next
    End Sub

    Private Sub UpdateRecentlyAddedMembers()
        ListView2.Items.Clear()

        Dim recentlyAddedMembersList As List(Of String) = FormTambahAnggota.GetRecentlyAddedMembers()
        Dim maxItems As Integer = 10
        Dim itemsToAdd = Math.Min(recentlyAddedMembersList.Count, maxItems)

        For i As Integer = 0 To itemsToAdd - 1
            Dim item As New ListViewItem(recentlyAddedMembersList(i))
            ListView2.Items.Add(item)
        Next
    End Sub

    Private Sub UpdateTotalAnggota()
        Try
            Koneksi()
            Dim query As String = "SELECT COUNT(*) FROM tbl_anggota"
            Using command As New OdbcCommand(query, Conn)
                Dim totalAnggota As Integer = Convert.ToInt32(command.ExecuteScalar())
                Label4.Text = totalAnggota.ToString() & " anggota"
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving total anggota: " & ex.Message)
        Finally
            Conn.Close()
        End Try
    End Sub


    Private Sub UpdateTotalBuku()
        Try
            Koneksi()
            Dim query As String = "SELECT COUNT(*) FROM tbl_buku"
            Using command As New OdbcCommand(query, Conn)
                Dim totalBuku As Integer = Convert.ToInt32(command.ExecuteScalar())
                Label3.Text = totalBuku.ToString() & " Buku"
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving total buku: " & ex.Message)
        Finally
            Conn.Close()
        End Try
    End Sub
End Class
