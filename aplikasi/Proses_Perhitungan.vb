Imports MySql.Data.MySqlClient
Public Class Proses_Perhitungan
    Sub tampilgird()
        Call koneksi_oke()
        da = New MySqlDataAdapter("SELECT id, nm, hasil, keterangan FROM table_proses_perhitungan ORDER BY id ASC ", conn)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub
    
    Sub bersih()
        txtid.Text = ""
        txtnm.Text = ""
        hasil.Text = ""
        keterangan.Text = ""
        txtid.Focus()
        gb2.Visible = False

    End Sub
    Sub bobot1()
        Call koneksi_oke()
        str = "Select * from table_kriteria where kode_kriteria ='001'"
        cmd = New MySqlCommand(str, conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            txtb1.Text = (dr.Item("bobot"))
        Loop
    End Sub
    Sub bobot2()
        Call koneksi_oke()
        str = "Select * from table_kriteria where kode_kriteria ='002'"
        cmd = New MySqlCommand(str, conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            txtb2.Text = (dr.Item("bobot"))
        Loop
    End Sub
    Sub bobot3()
        Call koneksi_oke()
        str = "Select * from table_kriteria where kode_kriteria ='003'"
        cmd = New MySqlCommand(str, conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            txtb3.Text = (dr.Item("bobot"))
        Loop
    End Sub
    Sub bobot4()
        Call koneksi_oke()
        str = "Select * from table_kriteria where kode_kriteria ='004'"
        cmd = New MySqlCommand(str, conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            txtb4.Text = (dr.Item("bobot"))
        Loop
    End Sub
    Sub bobot5()
        Call koneksi_oke()
        str = "Select * from table_kriteria where kode_kriteria ='005'"
        cmd = New MySqlCommand(str, conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            txtb5.Text = (dr.Item("bobot"))
        Loop
    End Sub
    Sub bobot6()
        Call koneksi_oke()
        str = "Select * from table_kriteria where kode_kriteria ='006'"
        cmd = New MySqlCommand(str, conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            txtb6.Text = (dr.Item("bobot"))
        Loop
    End Sub
    Sub bobot7()
        Call koneksi_oke()
        str = "Select * from table_kriteria where kode_kriteria ='007'"
        cmd = New MySqlCommand(str, conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            txtb7.Text = (dr.Item("bobot"))
        Loop
    End Sub
    Private Sub Proses_Perhitungan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call bersih()
        Call tampilgird()
        gb2.Visible = False
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub btnproses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnproses.Click
        hasil.Text = hasil.Text.Replace(",", ".")
        keterangan.Text = keterangan.Text.Replace(",", ".")
        hasil.Text = Val((txtb1.Text * Txtn1.Text) + (txtb2.Text * Txtn2.Text) + (txtb3.Text * Txtn3.Text) + (txtb4.Text * Txtn4.Text) + (txtb5.Text * Txtn5.Text) + (txtb6.Text * Txtn6.Text) + (txtb7.Text * Txtn7.Text))
        If (hasil.Text >= 0.72) Then
            keterangan.Text = "Eligible"
        ElseIf (hasil.Text < 0.72) Then
            keterangan.Text = "Non Eligible"
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        hasil.Text = hasil.Text.Replace(",", ".")
        keterangan.Text = keterangan.Text.Replace(",", ".")
        If txtid.Text = "" Or txtnm.Text = "" Or hasil.Text = "" Or keterangan.Text = "" Then
            MsgBox("Data Masih Ada Yang Kosong")
        Else
            Call koneksi_oke()
            cmd = New MySqlCommand("select * from table_proses_perhitungan where id = '" & txtid.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                Call koneksi_oke()
                sql = "insert into table_proses_perhitungan values('" & txtid.Text & "','" & txtnm.Text & "','" & hasil.Text & "','" & keterangan.Text & "')"
                cmd = New MySqlCommand(sql, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Sukses Disimpan")
            Else
                MsgBox("Ada Masalah")
            End If
            Call tampilgird()
            Call bersih()
        End If
    End Sub

    Private Sub hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapus.Click
        If MessageBox.Show("apakah data yakin dihapus", "pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Call koneksi_oke()
            Dim hapus As String = "delete from table_proses_perhitungan where id ='" & txtid.Text & "'"
            cmd = New MySqlCommand(hapus, conn)
            cmd.ExecuteNonQuery()
            MsgBox("data telah terhapus", MsgBoxStyle.Information, "information")
            Call tampilgird()
            Call bersih()

        End If
    End Sub


    Private Sub txtid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtid.KeyPress
        txtid.MaxLength = 20
        If e.KeyChar = Chr(13) Then
            Call koneksi_oke()
            cmd = New MySqlCommand("select * from table_nilai_penerima where id= '" & txtid.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then 'apabila data sudah ada
                txtnm.Text = dr.Item("nm")
                gb2.Visible = True
                btnproses.Focus()
                Txtn1.Text = dr.Item("nilai1")
                Txtn2.Text = dr.Item("nilai2")
                Txtn3.Text = dr.Item("nilai3")
                Txtn4.Text = dr.Item("nilai4")
                Txtn5.Text = dr.Item("nilai5")
                Txtn6.Text = dr.Item("nilai6")
                Txtn7.Text = dr.Item("nilai7")
                Call bobot1()
                Call bobot2()
                Call bobot3()
                Call bobot4()
                Call bobot5()
                Call bobot6()
                Call bobot7()

            End If
        End If
    End Sub
End Class