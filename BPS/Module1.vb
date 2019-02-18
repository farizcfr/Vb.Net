Imports System.Data.OleDb
Module Module1
    Public dbConnection As OleDbConnection         'objek koneksi PUBLIC lebih dari 1 form diakses nya kalo DIM cuma 1 form
    Public dbDA As OleDbDataAdapter                'objek data adapter
    Public dbDS As DataSet                         'objek data set
    Public dbCB As OleDbCommandBuilder             'objek command builder

    'Dim dbProvider As String = "PROVIDER=Microsoft.Ace.OLEDB.4.0;"
    Public dbProvider As String = "PROVIDER=Microsoft.Ace.OLEDB.12.0;"
    Public dbSource As String = "Data Source=CMS.mdb"
    Public dbSQL As String
    Public NamaTabel As String
    Public PosisiRow As Integer
    Public Pas1 As String 'karena pas1 dipake buat login dan rubah pass


    Public Sub Connect()
        Try
            dbConnection = New OleDbConnection
            dbConnection.ConnectionString = dbProvider + dbSource
            dbConnection.Open()
        Catch ex As Exception
            MsgBox("Koneksi Gagal")
        End Try
    End Sub
End Module
