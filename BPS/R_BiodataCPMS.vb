Public Class R_BiodataCPMS

    Private Sub R_BiodataCPMS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CMSDataSet.Pegawai' table. You can move, or remove it, as needed.
        Me.PegawaiTableAdapter.Fill(Me.CMSDataSet.Pegawai)

        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub MasterMenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterMenuToolStripMenuItem.Click
        F_Menu.Show()
        Me.Hide()
    End Sub

    Private Sub BiodataCalonPetugasMitraStatistikToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BiodataCalonPetugasMitraStatistikToolStripMenuItem.Click
        Bio_CMS.Show()
        Me.Hide()
    End Sub

    Private Sub TambahAdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahAdminToolStripMenuItem.Click
        F_User.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        LoginForm1.Show()
        Me.Hide()
    End Sub
End Class