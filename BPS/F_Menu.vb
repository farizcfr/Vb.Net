Imports System.Data.OleDb
Public Class F_Menu
    Private Sub BiodataCalonMitraStatistikToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BiodataCalonMitraStatistikToolStripMenuItem.Click
        Bio_CMS.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        LoginForm1.Show()
        Me.Hide()
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub TambahAdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahAdminToolStripMenuItem.Click
        F_User.Show()
        Me.Hide()
    End Sub

    Private Sub RepotCalonPetugasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepotCalonPetugasToolStripMenuItem.Click
        R_BiodataCPMS.Show()
        Me.Hide()

    End Sub

    Private Sub ReportAdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportAdminToolStripMenuItem.Click
        R_DataAdmin.Show()
        Me.Hide()

    End Sub
End Class