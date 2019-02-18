Imports System.Data.OleDb
Public Class F_User

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim JMLRow As Integer

        Call Connect()
        NamaTabel = "Login"
        'sql pencarian parsial karakter
        dbSQL = "select * from " + NamaTabel + " where ID like '%" + CariDataTextBox.Text + "%'"

        'sql pencarian full karakter
        'dbSQL = "select * from " + NamaTabel + " where Nama_Lengkap  '%" + CariDataTextBox.Text + "%"

        dbDA = New OleDbDataAdapter(dbSQL, dbConnection)
        dbDS = New DataSet
        dbDA.Fill(dbDS, NamaTabel)
        AdminDataGridView.DataSource = dbDS.Tables(NamaTabel)

        JMLRow = dbDS.Tables(NamaTabel).Rows.Count
        If JMLRow = 0 Then
            MsgBox("Data tidak ditemukan...")
            B_update.Enabled = False  'ERROR HANDLING!!!! pengaktifan kembali b_update
            B_delete.Enabled = False  'ERROR HANDLING!!!! pengaktifan kembali b_delete
            B_save.Enabled = False
            B_save.BackColor = Color.Black
            B_update.BackColor = Color.Black
            B_delete.BackColor = Color.Black

        Else 'Bila data ditemukan

            PosisiRow = 0

            'tampil data ke textbox 

            IDTextBox.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("ID")
            UsernameTextBox.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Username")
            PasswordTextBox.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Password")
            Nama_PegawaiTextBox.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Nama_Pegawai")
            JabatanTextBox.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Jabatan")



            B_update.Enabled = True 'ERROR HANDLING!!!! pengaktifan kembali b_update
            B_delete.Enabled = True 'ERROR HANDLING!!!! pengaktifan kembali b_delete
            B_save.Enabled = False
            B_save.BackColor = Color.Black
            B_update.BackColor = Color.White
            B_delete.BackColor = Color.White
        End If
        dbConnection.Close()
    End Sub
    Private Sub B_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_tambah.Click
        IDTextBox.Clear()
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
        Nama_PegawaiTextBox.Clear()
        JabatanTextBox.Clear()

        IDTextBox.Focus()
        B_save.Enabled = True
        B_save.BackColor = Color.White
        B_update.Enabled = False
        B_update.BackColor = Color.Black
        B_delete.Enabled = False
        B_delete.BackColor = Color.Black
    End Sub
    Private Sub B_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_save.Click
        B_update.Enabled = False
        B_delete.Enabled = False
        B_update.BackColor = Color.Black
        B_delete.BackColor = Color.Black
        Call Connect()
        NamaTabel = "Login"
        dbSQL = "select * from " + NamaTabel
        dbDA = New OleDbDataAdapter(dbSQL, dbConnection)
        dbDS = New DataSet
        dbDA.Fill(dbDS, NamaTabel)

        dbCB = New OleDbCommandBuilder(dbDA)

        If IDTextBox.Text = "" _
        Or UsernameTextBox.Text = "" _
        Or PasswordTextBox.Text = "" _
        Or Nama_PegawaiTextBox.Text = "" _
        Or JabatanTextBox.Text = "" Then




            MsgBox("Data Belum Lengkap...")

        ElseIf IsNumeric(IDTextBox.Text) And IsNumeric(IDTextBox.Text) Then 'cek text stok apakah numeric atau bukan
            Try
                Dim dsNewRow As DataRow 'objek untuk new row / baris baru

                dsNewRow = dbDS.Tables(NamaTabel).NewRow() 'perintah tambah baris


                dsNewRow.Item("ID") = IDTextBox.Text
                dsNewRow.Item("Username") = UsernameTextBox.Text
                dsNewRow.Item("Password") = PasswordTextBox.Text
                dsNewRow.Item("Nama_Pegawai") = Nama_PegawaiTextBox.Text
                dsNewRow.Item("Jabatan") = JabatanTextBox.Text


                dbDS.Tables(NamaTabel).Rows.Add(dsNewRow) 'perintah input baris ke dalam tabel data set

                dbDA.Update(dbDS, NamaTabel) 'update database dari data set
                MsgBox("Data Baru Ditambahkan")
                AdminDataGridView.DataSource = dbDS.Tables(NamaTabel)
                B_update.Enabled = False 'ERROR HANDLING!!!! agar setelah save tidak bisa langsung di update
                B_update.BackColor = Color.Black 'tombol update berubah warna hitam berarti non-aktif


                IDTextBox.Clear()
                UsernameTextBox.Clear()
                PasswordTextBox.Clear()
                Nama_PegawaiTextBox.Clear()
                JabatanTextBox.Clear()


                dbConnection.Close()
            Catch ex As Exception
                MsgBox("ID sudah ada") 'jika memasukan ID Binatang yang sama dengan catatan semua data harus di isi

            End Try
        Else
            MsgBox("ID harus angka ") 'jika memasukan huruf akan keluar message box ini

        End If
        dbConnection.Close()
    End Sub

    Private Sub B_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_delete.Click
        MessageBox.Show("Perintah DELETE sesuai dengan apa yang tertulis pada textbox, pastikan untuk menghapus data yang benar!", "WARNING")
        If MessageBox.Show("Yakin Akan Dihapus ?", _
                           "Hapus Data", MessageBoxButtons.YesNo, _
                           MessageBoxIcon.Warning) = DialogResult.No Then
            MsgBox("Perintah Hapus Dibatalkan")

        Else 'perintah hapus data
            dbCB = New OleDbCommandBuilder(dbDA)
            NamaTabel = "Login"
            PosisiRow = 0
            dbDS.Tables(NamaTabel).Rows(PosisiRow).Delete()
            dbDA.Update(dbDS, NamaTabel)
            MsgBox("Data Sudah Dihapus")
            B_save.Enabled = True
            B_save.BackColor = Color.White 'tombol save berubah putih tandanya aktif
            B_delete.Enabled = False 'ERROR HANDLING!!!! agar saat selesai menghapus sebuah data, kita tidak bisa meng-klik b_delete
            B_update.Enabled = False 'ERROR HANDLING!!!! agar saat selesai menghapus sebuah data, tidak bisa langsung meng-update
            B_update.BackColor = Color.Black 'tombol update berubah hitam tandanya non- aktif
            B_delete.BackColor = Color.Black 'tombol save berubah putih tandanya non-aktif
            IDTextBox.Clear()
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
            Nama_PegawaiTextBox.Clear()
            JabatanTextBox.Clear()
            IDTextBox.Focus()
        End If
    End Sub

    Private Sub MasterMenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterMenuToolStripMenuItem.Click
        F_Menu.Show()
        Me.Hide()

    End Sub

    Private Sub TambahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahToolStripMenuItem.Click
        Bio_CMS.Show()
        Me.Hide()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        LoginForm1.Show()
        Me.Hide()
    End Sub

    Private Sub F_User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        B_save.Enabled = False
        B_update.Enabled = False 'ERROR HANDLING!!!! agar saat memulai form kita tidak bisa meng-klik b_update
        B_delete.Enabled = False 'ERR
        B_save.BackColor = Color.Black
        B_update.BackColor = Color.Black
        B_delete.BackColor = Color.Black
    End Sub
End Class