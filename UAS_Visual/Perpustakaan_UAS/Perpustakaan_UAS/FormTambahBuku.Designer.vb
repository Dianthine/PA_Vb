<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahBuku
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
        ComboBox1 = New ComboBox()
        TextBox7 = New TextBox()
        Label7 = New Label()
        TextBox6 = New TextBox()
        Label6 = New Label()
        TextBox5 = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        GroupBox3 = New GroupBox()
        DataGridView1 = New DataGridView()
        GroupBox4 = New GroupBox()
        Label8 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(TextBox7)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(TextBox6)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(12, 100)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(434, 331)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Pengetahuan", "Fiksi ilmiah", "Fantasi", "Horor", "Buku Anak - Anak"})
        ComboBox1.Location = New Point(195, 157)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(200, 36)
        ComboBox1.TabIndex = 14
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(195, 279)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(200, 34)
        TextBox7.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 282)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 28)
        Label7.TabIndex = 12
        Label7.Text = "Stock"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(195, 239)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(200, 34)
        TextBox6.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 242)
        Label6.Name = "Label6"
        Label6.Size = New Size(105, 28)
        Label6.TabIndex = 10
        Label6.Text = "Pengarang"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(195, 199)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(200, 34)
        TextBox5.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 202)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 28)
        Label5.TabIndex = 8
        Label5.Text = "Penerbit"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 162)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 28)
        Label4.TabIndex = 6
        Label4.Text = "Genre"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(195, 119)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(200, 34)
        TextBox3.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 122)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 28)
        Label3.TabIndex = 4
        Label3.Text = "Tahun Terbit"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(195, 79)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(200, 34)
        TextBox2.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 28)
        Label2.TabIndex = 2
        Label2.Text = "Judul"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(195, 39)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(200, 34)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 28)
        Label1.TabIndex = 0
        Label1.Text = "ID Buku"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        GroupBox2.Controls.Add(Button4)
        GroupBox2.Controls.Add(Button3)
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Font = New Font("Segoe UI", 12F)
        GroupBox2.Location = New Point(12, 558)
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
        GroupBox3.Size = New Size(718, 643)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(6, 18)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(706, 613)
        DataGridView1.TabIndex = 3
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = SystemColors.Control
        GroupBox4.Controls.Add(Label8)
        GroupBox4.Location = New Point(12, 12)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(434, 82)
        GroupBox4.TabIndex = 3
        GroupBox4.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(9, 26)
        Label8.Name = "Label8"
        Label8.Size = New Size(245, 38)
        Label8.TabIndex = 0
        Label8.Text = "Tambahkan Buku"
        ' 
        ' FormTambahBuku
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1182, 673)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "FormTambahBuku"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormTambahBuku"
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
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
