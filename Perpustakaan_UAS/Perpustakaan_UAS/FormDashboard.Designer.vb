<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDashboard
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
        components = New ComponentModel.Container()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        GroupBox1 = New GroupBox()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Timer1 = New Timer(components)
        GroupBox2 = New GroupBox()
        Label2 = New Label()
        Label1 = New Label()
        ListView2 = New ListView()
        ListView1 = New ListView()
        Panel1 = New Panel()
        Panel5 = New Panel()
        Label7 = New Label()
        Panel2 = New Panel()
        Label5 = New Label()
        Label3 = New Label()
        Panel3 = New Panel()
        Label6 = New Label()
        Label4 = New Label()
        Panel4 = New Panel()
        Label8 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(6, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(689, 375)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(188, 372)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 10)
        Button1.TabIndex = 4
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(288, 372)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 10)
        Button2.TabIndex = 5
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(388, 372)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 10)
        Button3.TabIndex = 6
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(700, 401)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 3000
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(220), CByte(221), CByte(225))
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(ListView2)
        GroupBox2.Controls.Add(ListView1)
        GroupBox2.Location = New Point(718, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(233, 581)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(6, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(162, 31)
        Label2.TabIndex = 3
        Label2.Text = "Recently Book "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(6, 305)
        Label1.Name = "Label1"
        Label1.Size = New Size(199, 31)
        Label1.TabIndex = 2
        Label1.Text = "Recently Member "
        ' 
        ' ListView2
        ' 
        ListView2.BackColor = Color.FromArgb(CByte(220), CByte(221), CByte(225))
        ListView2.Location = New Point(6, 339)
        ListView2.Name = "ListView2"
        ListView2.Size = New Size(221, 239)
        ListView2.TabIndex = 1
        ListView2.UseCompatibleStateImageBehavior = False
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = Color.FromArgb(CByte(220), CByte(221), CByte(225))
        ListView1.Location = New Point(6, 52)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(221, 239)
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(220), CByte(221), CByte(225))
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Panel3)
        Panel1.Location = New Point(18, 419)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(689, 174)
        Panel1.TabIndex = 2
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(7), CByte(153), CByte(146))
        Panel5.Controls.Add(Label8)
        Panel5.Controls.Add(Label7)
        Panel5.Location = New Point(524, 19)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(162, 125)
        Panel5.TabIndex = 4
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label7.Location = New Point(3, 18)
        Label7.Name = "Label7"
        Label7.Size = New Size(136, 41)
        Label7.TabIndex = 0
        Label7.Text = "Coming "
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(250), CByte(152), CByte(58))
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(261, 19)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(250, 125)
        Panel2.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label5.Location = New Point(3, 18)
        Label5.Name = "Label5"
        Label5.Size = New Size(168, 41)
        Label5.TabIndex = 1
        Label5.Text = "Total Buku"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(3, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 31)
        Label3.TabIndex = 0
        Label3.Text = "Label3"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(235), CByte(47), CByte(6))
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label4)
        Panel3.Location = New Point(0, 19)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(250, 125)
        Panel3.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label6.Location = New Point(3, 18)
        Label6.Name = "Label6"
        Label6.Size = New Size(219, 41)
        Label6.TabIndex = 2
        Label6.Text = "Total Anggota"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        Label4.Location = New Point(3, 73)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 31)
        Label4.TabIndex = 1
        Label4.Text = "Label4"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(127), CByte(143), CByte(166))
        Panel4.Location = New Point(18, 615)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(927, 46)
        Panel4.TabIndex = 5
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label8.Location = New Point(3, 65)
        Label8.Name = "Label8"
        Label8.Size = New Size(89, 41)
        Label8.TabIndex = 1
        Label8.Text = "Soon"
        ' 
        ' FormDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(220), CByte(221), CByte(225))
        ClientSize = New Size(965, 673)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormDashboard"
        Text = "FormDashboard"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Private WithEvents Timer1 As Timer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label8 As Label
End Class
