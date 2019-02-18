<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class R_BiodataCPMS
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.PegawaiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CMSDataSet = New BPS.CMSDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PegawaiTableAdapter = New BPS.CMSDataSetTableAdapters.PegawaiTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BiodataCalonPetugasMitraStatistikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PegawaiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PegawaiBindingSource
        '
        Me.PegawaiBindingSource.DataMember = "Pegawai"
        Me.PegawaiBindingSource.DataSource = Me.CMSDataSet
        '
        'CMSDataSet
        '
        Me.CMSDataSet.DataSetName = "CMSDataSet"
        Me.CMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PegawaiBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BPS.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 30)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1021, 438)
        Me.ReportViewer1.TabIndex = 0
        '
        'PegawaiTableAdapter
        '
        Me.PegawaiTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1038, 24)
        Me.MenuStrip1.TabIndex = 1
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterMenuToolStripMenuItem, Me.BiodataCalonPetugasMitraStatistikToolStripMenuItem, Me.TambahAdminToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.DataToolStripMenuItem.Text = "Data Menu"
        '
        'MasterMenuToolStripMenuItem
        '
        Me.MasterMenuToolStripMenuItem.Name = "MasterMenuToolStripMenuItem"
        Me.MasterMenuToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.MasterMenuToolStripMenuItem.Text = "Master Menu"
        '
        'BiodataCalonPetugasMitraStatistikToolStripMenuItem
        '
        Me.BiodataCalonPetugasMitraStatistikToolStripMenuItem.Name = "BiodataCalonPetugasMitraStatistikToolStripMenuItem"
        Me.BiodataCalonPetugasMitraStatistikToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.BiodataCalonPetugasMitraStatistikToolStripMenuItem.Text = "Biodata Calon Petugas Mitra Statistik"
        '
        'TambahAdminToolStripMenuItem
        '
        Me.TambahAdminToolStripMenuItem.Name = "TambahAdminToolStripMenuItem"
        Me.TambahAdminToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.TambahAdminToolStripMenuItem.Text = "Tambah Admin"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'R_BiodataCPMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 471)
        Me.ControlBox = False
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "R_BiodataCPMS"
        CType(Me.PegawaiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PegawaiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CMSDataSet As BPS.CMSDataSet
    Friend WithEvents PegawaiTableAdapter As BPS.CMSDataSetTableAdapters.PegawaiTableAdapter
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BiodataCalonPetugasMitraStatistikToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TambahAdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
