Imports MySql.Data.MySqlClient
Public Class data_calon_penerima
    Private Sub keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keluar.Click
        Me.Close()
    End Sub
    Sub bersih()
        txtid.Text = ""
        txtnm.Text = ""
        txttempat.Text = ""
        DateTimePicker1.ResetText()
        cmbjk.Text = ""
        txtalamat.Text = ""
        cmbagama.Text = ""
        txtpdd.Text = ""
        txtid.Focus()
    End Sub
    Sub tampilgird()
        Call koneksi_oke()
        da = New MySqlDataAdapter("select * from table_penerima order by id asc", conn)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub data_karyawan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi_oke()
        Call tampilgird()
    End Sub

    Private Sub simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpan.Click
        If txtid.Text = "" Or txtnm.Text = "" Or cmbjk.Text = "" Or txttempat.Text = "" Or txtalamat.Text = "" Or cmbagama.Text = "" Or txtpdd.Text = "" Then
            MsgBox("Data Masih Ada Yang Kosong")
        Else
            Call koneksi_oke()
            cmd = New MySqlCommand("select * from table_penerima where id = '" & txtid.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                Call koneksi_oke()
                sql = "insert into table_penerima values('" & txtid.Text & "','" & txtnm.Text & "','" & txttempat.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & cmbjk.Text & "','" & txtalamat.Text & "','" & cmbagama.Text & "','" & txtpdd.Text & "')"
                cmd = New MySqlCommand(sql, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Sukses Disimpan")
            Else
                MsgBox("Ada Problem")
            End If
            Call tampilgird()
            Call bersih()
        End If
    End Sub

    Private Sub tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tambah.Click
        txtid.Text = ""
        txtnm.Text = ""
        txttempat.Text = ""
        DateTimePicker1.ResetText()
        cmbjk.Text = ""
        txtalamat.Text = ""
        cmbagama.Text = ""
        txtpdd.Text = ""
        txtid.Focus()
        simpan.Text = "SIMPAN"
    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        koneksi_oke()
        Dim edit As String = "update table_penerima set nm ='" &
                                txtnm.Text & "',tempat ='" &
                                txttempat.Text & "',tgl ='" &
                                Format(DateTimePicker1.Value, "yyyy-MM-dd") & "',jk ='" &
                                cmbjk.Text & "',almt ='" &
                                txtalamat.Text & "',agm ='" &
                                cmbagama.Text & "', pdd ='" &
                                txtpdd.Text & "'where id ='" & txtid.Text & "'"
        cmd = New MySqlCommand(edit, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Diupdate", MsgBoxStyle.Information, "Infbormation")
        Call tampilgird()
        Call bersih()
    End Sub

    Private Sub txtid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtid.KeyPress
        txtid.MaxLength = 20
        If e.KeyChar = Chr(13) Then
            Call koneksi_oke()

            cmd = New MySqlCommand("select * from table_penerima where id= '" & txtid.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then 'apabila data sudah ada
                txtid.Text = dr.Item("id")
                txtnm.Text = dr.Item("nm")
                txttempat.Text = dr.Item("tempat")
                DateTimePicker1.Text = dr.Item("tgl")
                cmbjk.Text = dr.Item("jk")
                txtalamat.Text = dr.Item("almt")
                cmbagama.Text = dr.Item("agm")
                txtpdd.Text = dr.Item("pdd")
                txtnm.Focus()
            Else
                'jika data belum ada
                Call bersih()
                simpan.Text = "simpan"
            End If
        End If
    End Sub

    Private Sub hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapus.Click
        If MessageBox.Show("apakah data yakin dihapus", "pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Call koneksi_oke()
            Dim hapus As String = "delete from table_penerima where id ='" & txtid.Text & "'"
            cmd = New MySqlCommand(hapus, conn)
            cmd.ExecuteNonQuery()
            MsgBox("data telah terhapus", MsgBoxStyle.Information, "information")
        End If
        Call tampilgird()
        Call bersih()
    End Sub
End Class