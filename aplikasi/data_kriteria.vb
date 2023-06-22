Imports MySql.Data.MySqlClient
Public Class data_kriteria
    Sub bersih()
        txtkode.Text = ""
        txtnm.Text = "Pilih"
        cmbstatus.Text = "Pilih"
        txtbobot.Text = ""
        txtkode.Focus()

    End Sub
    Sub tampilgird()
        Call koneksi_oke()
        da = New MySqlDataAdapter("select * from table_kriteria ORDER BY kode_kriteria ASC", conn)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.ReadOnly = True

    End Sub

    Private Sub data_kriteria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi_oke()
        Call tampilgird()
    End Sub

    Private Sub simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpan.Click
        If txtkode.Text = "" Or txtnm.Text = "Pilih" Or cmbstatus.Text = "Pilih" Or txtbobot.Text = "" Then
            MsgBox("Data Masih Ada Yang Kosong")
        Else
            txtbobot.Text = txtbobot.Text.Replace(",", ".")

            Call koneksi_oke()
            cmd = New MySqlCommand("select * from table_kriteria where kode_kriteria = '" & txtkode.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                Call koneksi_oke()
                sql = "insert into table_kriteria values('" & txtkode.Text & "','" & txtnm.Text & "','" & cmbstatus.Text & "','" & txtbobot.Text & "' )"
                cmd = New MySqlCommand(sql, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Sukses Disimpan")
            Else
                MsgBox("Uncek Masalahnyo")
            End If
            Call tampilgird()
        End If
    End Sub

    Private Sub tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tambah.Click
        txtkode.Text = ""
        txtnm.Text = "Pilih"
        cmbstatus.Text = "Pilih"
        txtbobot.Text = ""

        txtkode.Focus()
        simpan.Text = "Simpan"
    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        koneksi_oke()
        Dim edit As String = "update table_kriteria set nm_kriteria ='" & txtnm.Text & "',status= '" & cmbstatus.Text & "',bobot= '" & txtbobot.Text & "' where kode_kriteria ='" & txtkode.Text & "'"
        cmd = New MySqlCommand(edit, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Diupdate", MsgBoxStyle.Information, "Infbormation")
        Call tampilgird()
        Call bersih()
    End Sub

    Private Sub hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapus.Click
        If MessageBox.Show("apakah data yakin dihapus", "pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Call koneksi_oke()
            Dim hapus As String = "delete from table_kriteria where kode_kriteria ='" & txtkode.Text & "'"
            cmd = New MySqlCommand(hapus, conn)
            cmd.ExecuteNonQuery()
            MsgBox("data telah terhapus", MsgBoxStyle.Information, "information")
        End If
        Call tampilgird()
        Call bersih()
    End Sub

    Private Sub txtcari_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcari.KeyPress
        Call koneksi_oke()
        str = "select * from table_kriteria where kode_kriteria like '%" & txtcari.Text & "%' or nm_kriteria like '%" & txtcari.Text & "%'"
        cmd = New MySqlCommand(str, conn)
        dr = cmd.ExecuteReader
        dr.Read()

        If dr.HasRows Then
            txtkode.Text = dr.Item("kode_kriteria")
            txtnm.Text = dr.Item("nm_kriteria")
            cmbstatus.Text = dr.Item("status")
            txtbobot.Text = dr.Item("bobot")
        Else
            MsgBox("Data Tidak Ditemukan")
            Call bersih()
            txtcari.Focus()
        End If
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        Call koneksi_oke()
        str = "select * from table_kriteria where kode_kriteria like '%" & txtcari.Text & "%' or nm_kriteria like '%" & txtcari.Text & "%'"
        cmd = New MySqlCommand(str, conn)
        dr = cmd.ExecuteReader
        dr.Read()

        If dr.HasRows Then
            Call koneksi_oke()
            da = New MySqlDataAdapter("select * from table_kriteria where kode_kriteria like '%" & txtcari.Text & "%' or nm_kriteria like '%" & txtcari.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("Data Tidak Ditemukan")
            Call bersih()
            txtcari.Focus()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class