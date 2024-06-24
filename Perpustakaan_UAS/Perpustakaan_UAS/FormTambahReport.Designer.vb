<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        Label5 = New Label()
        TextBox6 = New TextBox()
        DateTimePicker2 = New DateTimePicker()
        Label9 = New Label()
        DateTimePicker1 = New DateTimePicker()
        ComboBox1 = New ComboBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        TextBox5 = New TextBox()
        Label4 = New Label()
        TextBox4 = New TextBox()
        Label3 = New Label()
        TextBox3 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        GroupBox2 = New GroupBox()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        GroupBox3 = New GroupBox()
        DataGridView1 = New DataGridView()
        GroupBox4 = New GroupBox()
        Label10 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(TextBox6)
        GroupBox1.Controls.Add(DateTimePicker2)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Font = New Font("Segoe UI", 12F)
        GroupBox1.Location = New Point(12, 100)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(434, 411)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 122)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 28)
        Label5.TabIndex = 20
        Label5.Text = "ID Buku"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(195, 119)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(200, 34)
        TextBox6.TabIndex = 19
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.Location = New Point(195, 322)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(200, 34)
        DateTimePicker2.TabIndex = 18
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(6, 284)
        Label9.Name = "Label9"
        Label9.Size = New Size(144, 28)
        Label9.TabIndex = 17
        Label9.Text = "Tanggal Pinjam"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(195, 284)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 34)
        DateTimePicker1.TabIndex = 3
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Pinjam", "Kembali", "Telat"})
        ComboBox1.Location = New Point(195, 361)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(200, 36)
        ComboBox1.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(6, 364)
        Label8.Name = "Label8"
        Label8.Size = New Size(65, 28)
        Label8.TabIndex = 15
        Label8.Text = "Status"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 324)
        Label7.Name = "Label7"
        Label7.Size = New Size(156, 28)
        Label7.TabIndex = 13
        Label7.Text = "Tanggal Kembali"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 246)
        Label6.Name = "Label6"
        Label6.Size = New Size(112, 28)
        Label6.TabIndex = 11
        Label6.Text = "Keterangan"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(195, 240)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(200, 34)
        TextBox5.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 203)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 28)
        Label4.TabIndex = 7
        Label4.Text = "Judul"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(195, 200)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(200, 34)
        TextBox4.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 163)
        Label3.Name = "Label3"
        Label3.Size = New Size(146, 28)
        Label3.TabIndex = 5
        Label3.Text = "Nama Anggota"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(195, 160)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(200, 34)
        TextBox3.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 28)
        Label2.TabIndex = 3
        Label2.Text = "ID Anggota"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(195, 79)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(200, 34)
        TextBox2.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 28)
        Label1.TabIndex = 1
        Label1.Text = "ID Transaksi"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(195, 39)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(200, 34)
        TextBox1.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        GroupBox2.Controls.Add(Button4)
        GroupBox2.Controls.Add(Button3)
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Font = New Font("Segoe UI", 12F)
        GroupBox2.Location = New Point(12, 517)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(425, 97)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(309, 33)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 38)
        Button4.TabIndex = 3
        Button4.Text = "Back"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(209, 33)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 38)
        Button3.TabIndex = 2
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(109, 33)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 38)
        Button2.TabIndex = 1
        Button2.Text = "Edit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(9, 33)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 38)
        Button1.TabIndex = 0
        Button1.Text = "Input"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox3.Controls.Add(DataGridView1)
        GroupBox3.Location = New Point(452, 12)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(700, 602)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(6, 18)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(688, 578)
        DataGridView1.TabIndex = 0
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(Label10)
        GroupBox4.Location = New Point(12, 12)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(434, 82)
        GroupBox4.TabIndex = 3
        GroupBox4.TabStop = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        Label10.Location = New Point(9, 26)
        Label10.Name = "Label10"
        Label10.Size = New Size(326, 38)
        Label10.TabIndex = 0
        Label10.Text = "Data Peminjaman Buku"
        ' 
        ' FormTambahReport
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(221), CByte(225))
        ClientSize = New Size(1164, 626)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormTambahReport"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormTambahReport"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox6 As TextBox
End Class
