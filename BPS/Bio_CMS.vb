Imports System.Data.OleDb
Public Class Bio_CMS
    Private Sub B_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_tambah.Click
        Try
            Kode_kecamatanTextBox.Clear()
            Kode_DesaTextBox.Clear()
            NIKTextBox.Clear()
            No_MSTextBox.Clear()
            Nama_LengkapTextBox.Clear()
            AlamatTextBox.Clear()
            Tempat_LahirTextBox.Clear()
            UmurTextBox.Clear()
            Jenis_KelaminTextBox.Text = "-"
            PendidikanTextBox.Text = "-"
            StatusTextBox.Text = "-"
            No_HpTextBox.Clear()
            EmailTextBox.Clear()
            PekerjaanTextBox.Clear()
            JabatanTextBox.Clear()
            No_NPWPTextBox.Clear()
            Status_PnsTextBox.Text = "-"
            NIPTextBox.Clear()
            GolonganTextBox.Clear()
            Sensus_SurveiTextBox.Text = "-"
            PengalamanTextBox.Clear()
            Pilihan_lamaranTextBox.Text = "-"
            Fasilitas_kendaraanTextBox.Text = "-"
            Fasiltas_ApkTextBox.Text = "-"
            B_save.Enabled = True
            B_save.BackColor = Color.White
            B_update.Enabled = False
            B_update.BackColor = Color.Black
            B_delete.Enabled = False
            B_delete.BackColor = Color.Black

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        B_save.Enabled = False
        B_update.Enabled = False 'ERROR HANDLING!!!! agar saat memulai form kita tidak bisa meng-klik b_update
        B_delete.Enabled = False 'ERR
        B_save.BackColor = Color.Black
        B_update.BackColor = Color.Black
        B_delete.BackColor = Color.Black
    End Sub

    Private Sub B_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_delete.Click
        MessageBox.Show("Perintah DELETE sesuai dengan apa yang tertulis pada textbox, pastikan untuk menghapus data yang benar!", "WARNING")
        If MessageBox.Show("Yakin Akan Dihapus ?", _
                           "Hapus Data", MessageBoxButtons.YesNo, _
                           MessageBoxIcon.Warning) = DialogResult.No Then
            MsgBox("Perintah Hapus Dibatalkan")

        Else 'perintah hapus data
            dbCB = New OleDbCommandBuilder(dbDA)
            NamaTabel = "Pegawai"
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
            Kode_kecamatanTextBox.Clear()
            Kode_DesaTextBox.Clear()
            NIKTextBox.Clear()
            No_MSTextBox.Clear()
            Nama_LengkapTextBox.Clear()
            AlamatTextBox.Clear()
            Tempat_LahirTextBox.Clear()
            UmurTextBox.Clear()
            Jenis_KelaminTextBox.Text = "-"
            PendidikanTextBox.Text = "-"
            StatusTextBox.Text = "-"
            No_HpTextBox.Clear()
            EmailTextBox.Clear()
            PekerjaanTextBox.Clear()
            JabatanTextBox.Clear()
            No_NPWPTextBox.Clear()
            Status_PnsTextBox.Text = "-"
            NIPTextBox.Clear()
            GolonganTextBox.Clear()
            Sensus_SurveiTextBox.Text = "-"
            PengalamanTextBox.Clear()
            Pilihan_lamaranTextBox.Text = "-"
            Fasilitas_kendaraanTextBox.Text = "-"
            Fasiltas_ApkTextBox.Text = "-"
            NIKTextBox.Focus()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim JMLRow As Integer

        Call Connect()
        NamaTabel = "Pegawai"
        'sql pencarian parsial karakter
        dbSQL = "select * from " + NamaTabel + " where NIK like '%" + CariDataTextBox.Text + "%'"

        'sql pencarian full karakter
        'dbSQL = "select * from " + NamaTabel + " where Nama_Lengkap  '%" + CariDataTextBox.Text + "%"

        dbDA = New OleDbDataAdapter(dbSQL, dbConnection)
        dbDS = New DataSet
        dbDA.Fill(dbDS, NamaTabel)
        PegawaiDataGridView.DataSource = dbDS.Tables(NamaTabel)

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

            Kode_kecamatanTextBox.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Kode_kecamatan")
            Kode_DesaTextBox.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Kode_Desa")
            NIKTextBox.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("NIK")
            No_MSTextBox.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("No_MS")
            Nama_LengkapTextBox.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Nama_Lengkap")
            AlamatTextBox.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Alamat")
            Tempat_LahirTextBox.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Tempat_Lahir")
            Tgl_LahirDateTimePicker.Value = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Tgl_Lahir")
            UmurTextBox.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Umur")
            Jenis_KelaminTextBox.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Jenis_Kelamin")
            PendidikanTextBox.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Pendidikan")
            StatusTextBox.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Status")
            No_HpTextBox.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("No_Hp")
            EmailTextBox.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Email")
            PekerjaanTextBox.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Pekerjaan")
            JabatanTextBox.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Jabatan")
            No_NPWPTextBox.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("No_NPWP")
            Status_PnsTextBox.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Status_Pns")
            NIPTextBox.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("NIP")
            GolonganTextBox.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Golongan")
            Sensus_SurveiTextBox.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Sensus_Survei")
            PengalamanTextBox.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Pengalaman")
            Pilihan_lamaranTextBox.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Pilihan_lamaran")
            Fasilitas_kendaraanTextBox.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Fasilitas_kendaraan")
            Fasiltas_ApkTextBox.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Fasiltas_Apk")

          

            B_update.Enabled = True 'ERROR HANDLING!!!! pengaktifan kembali b_update
            B_delete.Enabled = True 'ERROR HANDLING!!!! pengaktifan kembali b_delete
            B_save.Enabled = False
            B_save.BackColor = Color.Black
            B_update.BackColor = Color.White
            B_delete.BackColor = Color.White
        End If
        dbConnection.Close()
    End Sub

    Private Sub B_update_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_update.Click
        dbCB = New OleDbCommandBuilder(dbDA)

        NamaTabel = "Pegawai"
        PosisiRow = 0


        dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Kode_kecamatan") = Kode_kecamatanTextBox.Text
        dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Kode_Desa") = Kode_DesaTextBox.Text
        dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("NIK") = NIKTextBox.Text
        dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("No_MS") = No_MSTextBox.Text
        dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Nama_Lengkap") = Nama_LengkapTextBox.Text
        dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Alamat") = AlamatTextBox.Text
        dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Tempat_Lahir") = Tempat_LahirTextBox.Text
        dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Tgl_Lahir") = Tgl_LahirDateTimePicker.Value.Date
        dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Umur") = UmurTextBox.Text
        dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Jenis_Kelamin") = Jenis_KelaminTextBox.Text
        dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Pendidikan") = PendidikanTextBox.Text
        dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Status") = StatusTextBox.Text
        dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("No_Hp") = No_HpTextBox.Text
        dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Email") = EmailTextBox.Text
        dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Pekerjaan") = PekerjaanTextBox.Text
        dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Jabatan") = JabatanTextBox.Text
        dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("No_NPWP") = No_NPWPTextBox.Text
        dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Status_Pns") = Status_PnsTextBox.Text
        dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("NIP") = NIPTextBox.Text
        dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Golongan") = GolonganTextBox.Text
        dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Sensus_Survei") = Sensus_SurveiTextBox.Text
        dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Pengalaman") = PengalamanTextBox.Text
        dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Pilihan_lamaran") = Pilihan_lamaranTextBox.Text
        dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Fasilitas_kendaraan") = Fasilitas_kendaraanTextBox.Text
        dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Fasiltas_Apk") = Fasiltas_ApkTextBox.Text

        dbDA.Update(dbDS, NamaTabel)
        MsgBox("Data Sudah Di Update")
        B_delete.Enabled = False 'ERROR HANDLING!!!! agar setelah di update data tidak bisa langsung di delete
        B_delete.BackColor = Color.Black
    End Sub
    Private Sub B_save_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_save.Click
        B_update.Enabled = False
        B_delete.Enabled = False
        B_update.BackColor = Color.Black
        B_delete.BackColor = Color.Black
        Call Connect()
        NamaTabel = "Pegawai"
        dbSQL = "select * from " + NamaTabel
        dbDA = New OleDbDataAdapter(dbSQL, dbConnection)
        dbDS = New DataSet
        dbDA.Fill(dbDS, NamaTabel)

        dbCB = New OleDbCommandBuilder(dbDA)

        If Kode_kecamatanTextBox.Text = "" _
        Or Kode_DesaTextBox.Text = "" _
        Or NIKTextBox.Text = "" _
        Or No_MSTextBox.Text = "" _
        Or Nama_LengkapTextBox.Text = "" _
         Or AlamatTextBox.Text = "" _
          Or Tempat_LahirTextBox.Text = "" _
           Or UmurTextBox.Text = "" _
            Or Jenis_KelaminTextBox.Text = "" _
             Or PendidikanTextBox.Text = "" _
              Or StatusTextBox.Text = "" _
               Or No_HpTextBox.Text = "" _
                Or EmailTextBox.Text = "" _
                 Or PekerjaanTextBox.Text = "" _
                  Or JabatanTextBox.Text = "" _
                   Or No_NPWPTextBox.Text = "" _
                    Or Status_PnsTextBox.Text = "" _
                     Or NIPTextBox.Text = "" _
                      Or GolonganTextBox.Text = "" _
                       Or Sensus_SurveiTextBox.Text = "" _
                        Or PengalamanTextBox.Text = "" _
                         Or Pilihan_lamaranTextBox.Text = "" _
                          Or Fasilitas_kendaraanTextBox.Text = "" _
                           Or Fasiltas_ApkTextBox.Text = "" Then





            MsgBox("Data Belum Lengkap...")

        ElseIf IsNumeric(NIKTextBox.Text) AndAlso IsNumeric(No_MSTextBox.Text) Then 'cek text stok apakah numeric atau bukan
            Try
                Dim dsNewRow As DataRow 'objek untuk new row / baris baru

                dsNewRow = dbDS.Tables(NamaTabel).NewRow() 'perintah tambah baris


                dsNewRow.Item("Kode_kecamatan") = Kode_kecamatanTextBox.Text
                dsNewRow.Item("Kode_Desa") = Kode_DesaTextBox.Text
                dsNewRow.Item("NIK") = NIKTextBox.Text
                dsNewRow.Item("No_MS") = No_MSTextBox.Text
                dsNewRow.Item("Nama_Lengkap") = Nama_LengkapTextBox.Text
                dsNewRow.Item("Alamat") = AlamatTextBox.Text
                dsNewRow.Item("Tempat_Lahir") = Tempat_LahirTextBox.Text
                dsNewRow.Item("Tgl_Lahir") = Tgl_LahirDateTimePicker.Value.Date
                dsNewRow.Item("Umur") = UmurTextBox.Text
                dsNewRow.Item("Jenis_Kelamin") = Jenis_KelaminTextBox.Text
                dsNewRow.Item("Pendidikan") = PendidikanTextBox.Text
                dsNewRow.Item("Status") = StatusTextBox.Text
                dsNewRow.Item("No_Hp") = No_HpTextBox.Text
                dsNewRow.Item("Email") = EmailTextBox.Text
                dsNewRow.Item("Pekerjaan") = PekerjaanTextBox.Text
                dsNewRow.Item("Jabatan") = JabatanTextBox.Text
                dsNewRow.Item("No_NPWP") = No_NPWPTextBox.Text
                dsNewRow.Item("Status_Pns") = Status_PnsTextBox.Text
                dsNewRow.Item("NIP") = NIPTextBox.Text
                dsNewRow.Item("Golongan") = GolonganTextBox.Text
                dsNewRow.Item("Sensus_Survei") = Sensus_SurveiTextBox.Text
                dsNewRow.Item("Pengalaman") = PengalamanTextBox.Text
                dsNewRow.Item("Pilihan_lamaran") = Pilihan_lamaranTextBox.Text
                dsNewRow.Item("Fasilitas_kendaraan") = Fasilitas_kendaraanTextBox.Text
                dsNewRow.Item("Fasiltas_Apk") = Fasiltas_ApkTextBox.Text


                dbDS.Tables(NamaTabel).Rows.Add(dsNewRow) 'perintah input baris ke dalam tabel data set

                dbDA.Update(dbDS, NamaTabel) 'update database dari data set
                MsgBox("Data Baru Ditambahkan")
                PegawaiDataGridView.DataSource = dbDS.Tables(NamaTabel)
                B_update.Enabled = False 'ERROR HANDLING!!!! agar setelah save tidak bisa langsung di update
                B_update.BackColor = Color.Black 'tombol update berubah warna hitam berarti non-aktif

                Kode_kecamatanTextBox.Clear()
                Kode_DesaTextBox.Clear()
                NIKTextBox.Clear()
                No_MSTextBox.Clear()
                Nama_LengkapTextBox.Clear()
                AlamatTextBox.Clear()
                Tempat_LahirTextBox.Clear()
                UmurTextBox.Clear()
                Jenis_KelaminTextBox.Text = "-"
                PendidikanTextBox.Text = "-"
                StatusTextBox.Text = "-"
                No_HpTextBox.Clear()
                EmailTextBox.Clear()
                PekerjaanTextBox.Clear()
                JabatanTextBox.Clear()
                No_NPWPTextBox.Clear()
                Status_PnsTextBox.Text = "-"
                NIPTextBox.Clear()
                GolonganTextBox.Clear()
                Sensus_SurveiTextBox.Text = "-"
                PengalamanTextBox.Clear()
                Pilihan_lamaranTextBox.Text = "-"
                Fasilitas_kendaraanTextBox.Text = "-"
                Fasiltas_ApkTextBox.Text = "-"

                dbConnection.Close()
            Catch ex As Exception
                MsgBox("NIK dan No Mitra Statistik sudah ada") 'jika memasukan ID Binatang yang sama dengan catatan semua data harus di isi

            End Try
        Else
            MsgBox("NIK dan No Mitra Statistik ") 'jika memasukan huruf akan keluar message box ini

        End If
        dbConnection.Close()
    End Sub

    Private Sub NIKTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NIKTextBox.TextChanged

    End Sub

    Private Sub Status_PnsTextBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Status_PnsTextBox.SelectedIndexChanged
        If Status_PnsTextBox.Text = "PNS" Then
            'MsgBox("Jika PNS maka NIP dan Golongan harus di isi")
            NIPTextBox.Enabled = True
            GolonganTextBox.Enabled = True
        Else : Status_PnsTextBox.Text = "Bukan PNS"
            'MsgBox("Jika Bukan PNS NIP dan Golongan tidak perlu di isi")
            NIPTextBox.Text = "-"
            NIPTextBox.Enabled = False
            GolonganTextBox.Text = "-"
            GolonganTextBox.Enabled = False
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        LoginForm1.Show()
        Me.Hide()
    End Sub

    Private Sub MasterMenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterMenuToolStripMenuItem.Click
        F_Menu.Show()
        Me.Hide()

    End Sub

    Private Sub TambahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahToolStripMenuItem.Click
        F_User.Show()
        Me.Hide()
    End Sub

  
    Private Sub CariDataTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CariDataTextBox.TextChanged
        If CariDataTextBox.Text = "" Then
            MsgBox("Cari data harus berdasarkan NIK, Silahkan masukan NIK")
        End If
    End Sub

    Private Sub ReportDataCalonPetugasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportDataCalonPetugasToolStripMenuItem.Click
        R_BiodataCPMS.Show()
        Me.Hide()

    End Sub

    Private Sub ReportDataAdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportDataAdminToolStripMenuItem.Click
        R_DataAdmin.Show()
        Me.Hide()

    End Sub
End Class
