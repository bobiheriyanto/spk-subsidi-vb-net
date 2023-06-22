Imports MySql.Data.MySqlClient
Module koneksi
    Public conn As MySqlConnection
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public str, sql As String

    Public Sub koneksi_oke()
        str = "server=localhost; user=root; database=subsidi; port=3306"
        conn = New MySqlConnection(str)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
            If conn.State = ConnectionState.Closed Then conn.Open()
            'MsgBox("Database Terkoneksi")
        Else
            MsgBox("Koneksi Gagal")

        End If

    End Sub
End Module
