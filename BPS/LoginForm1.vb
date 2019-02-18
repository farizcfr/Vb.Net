Imports System.Data.OleDb
Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.


    Private Sub OK_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            Dim JMLRow As Integer
            'Dim Akses As String
            Dim User1 As String



            Call Connect()
            NamaTabel = "Login"

            'sql pencarian full karakter
            dbSQL = "select * from " + NamaTabel + _
                    " where Username = '" + UsernameTextBox.Text + _
                    "' and Password = '" + PasswordTextBox.Text + "'"

            dbDA = New OleDbDataAdapter(dbSQL, dbConnection)
            dbDS = New DataSet
            dbDA.Fill(dbDS, NamaTabel)

            JMLRow = dbDS.Tables(NamaTabel).Rows.Count
            If JMLRow = 0 Then 'salah masukin username / pass
                MsgBox("Username / Pass Salah...")

            Else 'Bila data ditemukan
                PosisiRow = 0

                User1 = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Username")
                Pas1 = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Password")

                If User1 = UsernameTextBox.Text And Pas1 = PasswordTextBox.Text Then
                    'Timer1_Tick(sender, e)
                    F_Menu.Show()
                    'MsgBox("Selamat Datang")

                    'Akses = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Akses")

                    ' If Akses = "User" Then
                    ' F_Menu.DataPegawaiToolStripMenuItem.Visible = False
                    'Else
                    ' F_Menu.DataPegawaiToolStripMenuItem.Visible = True
                    'End If

                    F_Menu.Label2.Text = User1
                    F_Menu.Label1.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("ID")
                    F_Menu.Label3.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Nama_Pegawai")
                    F_Menu.Label8.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Jabatan")

                    Bio_CMS.Label1.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("ID") 'F_pembelian.Kd_PegawaiTextBox.Text 
                    Bio_CMS.Label2.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Username")
                    Bio_CMS.Label3.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Nama_Pegawai")
                    Bio_CMS.Label8.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Jabatan")

                    F_User.Label1.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("ID") 'F_pembelian.Kd_PegawaiTextBox.Text 
                    F_User.Label2.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Username")
                    F_User.Label3.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Nama_Pegawai")
                    F_User.Label8.Text = dbDS.Tables(NamaTabel).Rows(PosisiRow).Item("Jabatan")

                    PasswordTextBox.Clear()
                    UsernameTextBox.Clear()

                    Me.Hide()
                Else
                    MsgBox("Username atau Pass salah")
                End If


                dbConnection.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Cancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            PasswordTextBox.UseSystemPasswordChar = False
        Else
            PasswordTextBox.UseSystemPasswordChar = True

        End If
    End Sub
End Class
