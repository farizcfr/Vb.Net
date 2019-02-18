<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_User
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_User))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CariDataTextBox = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.B_delete = New System.Windows.Forms.Button()
        Me.B_tambah = New System.Windows.Forms.Button()
        Me.B_update = New System.Windows.Forms.Button()
        Me.B_save = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Nama_PegawaiTextBox = New System.Windows.Forms.TextBox()
        Me.JabatanTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.AdminDataGridView = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportDataCalonPetugasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportDataAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        IDLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.AdminDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(12, 134)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(27, 16)
        IDLabel.TabIndex = 117
        IDLabel.Text = "ID:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsernameLabel.Location = New System.Drawing.Point(12, 160)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(74, 16)
        UsernameLabel.TabIndex = 119
        UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.Location = New System.Drawing.Point(12, 186)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(69, 16)
        PasswordLabel.TabIndex = 121
        PasswordLabel.Text = "Password:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.Location = New System.Drawing.Point(12, 212)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(99, 16)
        Label9.TabIndex = 124
        Label9.Text = "Nama Pegawai"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.Location = New System.Drawing.Point(12, 238)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(56, 16)
        Label10.TabIndex = 126
        Label10.Text = "Jabatan"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(633, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(208, 150)
        Me.GroupBox2.TabIndex = 116
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "User Info"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 16)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "ID :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(121, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 114
        Me.Label8.Text = "Label8"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(121, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Label1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 113
        Me.Label7.Text = "Jabatan :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(121, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Label2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 16)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "Nama Pegawai :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(121, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Label3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "Username :"
        '
        'IDTextBox
        '
        Me.IDTextBox.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(120, 132)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(168, 21)
        Me.IDTextBox.TabIndex = 118
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(120, 158)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(168, 21)
        Me.UsernameTextBox.TabIndex = 120
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(120, 184)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(168, 21)
        Me.PasswordTextBox.TabIndex = 122
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.CariDataTextBox)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.B_delete)
        Me.GroupBox1.Controls.Add(Me.B_tambah)
        Me.GroupBox1.Controls.Add(Me.B_update)
        Me.GroupBox1.Controls.Add(Me.B_save)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(311, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 150)
        Me.GroupBox1.TabIndex = 123
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit Button Grup"
        '
        'CariDataTextBox
        '
        Me.CariDataTextBox.Location = New System.Drawing.Point(80, 114)
        Me.CariDataTextBox.Name = "CariDataTextBox"
        Me.CariDataTextBox.Size = New System.Drawing.Size(140, 23)
        Me.CariDataTextBox.TabIndex = 85
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(229, 14)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(62, 16)
        Me.Label25.TabIndex = 84
        Me.Label25.Text = "Hapus"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(150, 14)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(70, 16)
        Me.Label24.TabIndex = 83
        Me.Label24.Text = "Edit"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(77, 14)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(70, 16)
        Me.Label23.TabIndex = 82
        Me.Label23.Text = "Simpan"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(8, 14)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(66, 16)
        Me.Label22.TabIndex = 81
        Me.Label22.Text = "Tambah"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(80, 98)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 16)
        Me.Label21.TabIndex = 80
        Me.Label21.Text = "Cari Data"
        '
        'B_delete
        '
        Me.B_delete.BackColor = System.Drawing.Color.White
        Me.B_delete.ForeColor = System.Drawing.Color.Red
        Me.B_delete.Image = CType(resources.GetObject("B_delete.Image"), System.Drawing.Image)
        Me.B_delete.Location = New System.Drawing.Point(224, 33)
        Me.B_delete.Name = "B_delete"
        Me.B_delete.Size = New System.Drawing.Size(67, 57)
        Me.B_delete.TabIndex = 6
        Me.B_delete.UseVisualStyleBackColor = False
        '
        'B_tambah
        '
        Me.B_tambah.BackColor = System.Drawing.Color.White
        Me.B_tambah.ForeColor = System.Drawing.Color.Red
        Me.B_tambah.Image = CType(resources.GetObject("B_tambah.Image"), System.Drawing.Image)
        Me.B_tambah.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.B_tambah.Location = New System.Drawing.Point(7, 32)
        Me.B_tambah.Name = "B_tambah"
        Me.B_tambah.Size = New System.Drawing.Size(67, 57)
        Me.B_tambah.TabIndex = 3
        Me.B_tambah.UseVisualStyleBackColor = False
        '
        'B_update
        '
        Me.B_update.BackColor = System.Drawing.Color.White
        Me.B_update.ForeColor = System.Drawing.Color.Red
        Me.B_update.Image = CType(resources.GetObject("B_update.Image"), System.Drawing.Image)
        Me.B_update.Location = New System.Drawing.Point(153, 33)
        Me.B_update.Name = "B_update"
        Me.B_update.Size = New System.Drawing.Size(65, 57)
        Me.B_update.TabIndex = 5
        Me.B_update.UseVisualStyleBackColor = False
        '
        'B_save
        '
        Me.B_save.BackColor = System.Drawing.Color.White
        Me.B_save.ForeColor = System.Drawing.Color.Red
        Me.B_save.Image = CType(resources.GetObject("B_save.Image"), System.Drawing.Image)
        Me.B_save.Location = New System.Drawing.Point(80, 33)
        Me.B_save.Name = "B_save"
        Me.B_save.Size = New System.Drawing.Size(67, 57)
        Me.B_save.TabIndex = 4
        Me.B_save.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.ForeColor = System.Drawing.Color.Red
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(7, 88)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(67, 56)
        Me.Button5.TabIndex = 79
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Nama_PegawaiTextBox
        '
        Me.Nama_PegawaiTextBox.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama_PegawaiTextBox.Location = New System.Drawing.Point(120, 210)
        Me.Nama_PegawaiTextBox.Name = "Nama_PegawaiTextBox"
        Me.Nama_PegawaiTextBox.Size = New System.Drawing.Size(168, 21)
        Me.Nama_PegawaiTextBox.TabIndex = 125
        '
        'JabatanTextBox
        '
        Me.JabatanTextBox.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JabatanTextBox.Location = New System.Drawing.Point(120, 236)
        Me.JabatanTextBox.Name = "JabatanTextBox"
        Me.JabatanTextBox.Size = New System.Drawing.Size(168, 21)
        Me.JabatanTextBox.TabIndex = 127
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Controls.Add(Me.AdminDataGridView)
        Me.Panel3.Location = New System.Drawing.Point(12, 290)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(829, 174)
        Me.Panel3.TabIndex = 128
        '
        'AdminDataGridView
        '
        Me.AdminDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AdminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AdminDataGridView.Location = New System.Drawing.Point(16, 19)
        Me.AdminDataGridView.Name = "AdminDataGridView"
        Me.AdminDataGridView.Size = New System.Drawing.Size(797, 144)
        Me.AdminDataGridView.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataMenuToolStripMenuItem, Me.ReportToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(853, 24)
        Me.MenuStrip1.TabIndex = 129
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataMenuToolStripMenuItem
        '
        Me.DataMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterMenuToolStripMenuItem, Me.TambahToolStripMenuItem})
        Me.DataMenuToolStripMenuItem.Name = "DataMenuToolStripMenuItem"
        Me.DataMenuToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.DataMenuToolStripMenuItem.Text = "Data Menu"
        '
        'MasterMenuToolStripMenuItem
        '
        Me.MasterMenuToolStripMenuItem.Name = "MasterMenuToolStripMenuItem"
        Me.MasterMenuToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.MasterMenuToolStripMenuItem.Text = "Master Menu"
        '
        'TambahToolStripMenuItem
        '
        Me.TambahToolStripMenuItem.Name = "TambahToolStripMenuItem"
        Me.TambahToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.TambahToolStripMenuItem.Text = "Biodata Calon Petugas Mitra Statistik"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportDataCalonPetugasToolStripMenuItem, Me.ReportDataAdminToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'ReportDataCalonPetugasToolStripMenuItem
        '
        Me.ReportDataCalonPetugasToolStripMenuItem.Name = "ReportDataCalonPetugasToolStripMenuItem"
        Me.ReportDataCalonPetugasToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.ReportDataCalonPetugasToolStripMenuItem.Text = "Report Data Calon Petugas"
        '
        'ReportDataAdminToolStripMenuItem
        '
        Me.ReportDataAdminToolStripMenuItem.Name = "ReportDataAdminToolStripMenuItem"
        Me.ReportDataAdminToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.ReportDataAdminToolStripMenuItem.Text = "Report Data Admin"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'F_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(853, 480)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Label10)
        Me.Controls.Add(Me.JabatanTextBox)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Me.Nama_PegawaiTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "F_User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.AdminDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CariDataTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents B_delete As System.Windows.Forms.Button
    Friend WithEvents B_tambah As System.Windows.Forms.Button
    Friend WithEvents B_update As System.Windows.Forms.Button
    Friend WithEvents B_save As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Nama_PegawaiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JabatanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents AdminDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DataMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TambahToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportDataCalonPetugasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportDataAdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
