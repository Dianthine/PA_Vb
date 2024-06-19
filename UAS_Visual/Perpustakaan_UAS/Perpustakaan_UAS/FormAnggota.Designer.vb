<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAnggota
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAnggota))
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        DataGridView1 = New DataGridView()
        GroupBox2 = New GroupBox()
        Button3 = New Button()
        TextBox1 = New TextBox()
        Button2 = New Button()
        Button1 = New Button()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(15, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(528, 62)
        Label1.TabIndex = 1
        Label1.Text = "Anggota Perpustakaan"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(DataGridView1)
        GroupBox1.Location = New Point(12, 220)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(957, 456)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(6, 26)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(945, 424)
        DataGridView1.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Button3)
        GroupBox2.Controls.Add(TextBox1)
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        GroupBox2.Location = New Point(12, 149)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(957, 74)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(140, 21)
        Button3.Name = "Button3"
        Button3.Size = New Size(109, 38)
        Button3.TabIndex = 3
        Button3.Text = "Refresh"
        Button3.TextAlign = ContentAlignment.MiddleRight
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(638, 24)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(212, 30)
        TextBox1.TabIndex = 2
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(6, 21)
        Button2.Name = "Button2"
        Button2.Size = New Size(128, 38)
        Button2.TabIndex = 1
        Button2.Text = "Tambahkan"
        Button2.TextAlign = ContentAlignment.MiddleRight
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(856, 19)
        Button1.Name = "Button1"
        Button1.Size = New Size(95, 38)
        Button1.TabIndex = 0
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' FormAnggota
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(981, 688)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormAnggota"
        Text = "FormAnggota"
        GroupBox1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
