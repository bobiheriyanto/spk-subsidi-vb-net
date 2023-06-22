Imports MySql.Data.MySqlClient
Public Class Data_Nilai_Penerima
    Sub bersih()
        txtid.Text = ""
        txtnm.Text = ""
        cmbnilai1.Text = ""
        cmbnilai2.Text = ""
        cmbnilai3.Text = ""
        cmbnilai4.Text = ""
        cmbnilai5.Text = ""
        cmbnilai6.Text = ""
        cmbnilai7.Text = ""
        txtid.Focus()
        gb2.Visible = False

    End Sub
    Sub tampilgird()
        Call koneksi_oke()
        da = New MySqlDataAdapter("select * from table_nilai_penerima order by id asc", conn)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub
    Sub nilai()
        Call koneksi_oke()
        str = "select * from table_nilai_penerima where id = '" & txtid.Text & "' "
        cmd = New MySqlCommand(str, conn)
        dr = cmd.ExecuteReader
        Do While dr.Read

            txtnm.Text = dr.Item("nm")
            cmbnilai1.Text = dr.Item("nilai1")
            cmbnilai2.Text = dr.Item("nilai2")
            cmbnilai3.Text = dr.Item("nilai3")
            cmbnilai4.Text = dr.Item("nilai4")
            cmbnilai5.Text = dr.Item("nilai5")
            cmbnilai6.Text = dr.Item("nilai6")
            cmbnilai7.Text = dr.Item("nilai7")
        Loop
    End Sub

    Private Sub keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keluar.Click
        Me.Close()
    End Sub

    Private Sub simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpan.Click
        If txtid.Text = "" Or txtnm.Text = "" Or cmbnilai1.Text = "" Or cmbnilai2.Text = "" Or cmbnilai3.Text = "" Or cmbnilai4.Text = "" Or cmbnilai5.Text = "" Or cmbnilai6.Text = "" Or cmbnilai7.Text = "" Then
            MsgBox("Data Masih Ada Yang Kosong")
        Else
            cmbnilai1.Text = cmbnilai1.Text.Replace(",", ".")
            cmbnilai2.Text = cmbnilai2.Text.Replace(",", ".")
            cmbnilai3.Text = cmbnilai3.Text.Replace(",", ".")
            cmbnilai4.Text = cmbnilai4.Text.Replace(",", ".")
            cmbnilai5.Text = cmbnilai5.Text.Replace(",", ".")
            cmbnilai6.Text = cmbnilai6.Text.Replace(",", ".")
            cmbnilai7.Text = cmbnilai7.Text.Replace(",", ".")

            Call koneksi_oke()
            cmd = New MySqlCommand("select * from table_nilai_penerima where id = '" & txtid.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                Call koneksi_oke()
                sql = "insert into table_nilai_penerima values('" & txtid.Text & "','" & txtnm.Text & "','" & cmbnilai1.Text & "','" & cmbnilai2.Text & "','" & cmbnilai3.Text & "','" & cmbnilai4.Text & "','" & cmbnilai5.Text & "','" & cmbnilai6.Text & "','" & cmbnilai7.Text & "')"
                cmd = New MySqlCommand(sql, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Sukses Disimpan")
            Else
                MsgBox("Ada Kesalahan")
            End If
            Call tampilgird()
            Call bersih()
        End If
    End Sub

    Private Sub Data_Nilai_Karyawan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi_oke()
        Call tampilgird()
        gb2.Visible = False
    End Sub

    Private Sub tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tambah.Click
        Call bersih()
    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        koneksi_oke()
        Dim edit As String = "update table_nilai_penerima set nm ='" &
                                            txtnm.Text & "',nilai1 ='" &
                                            cmbnilai1.Text & "',nilai2 ='" &
                                            cmbnilai2.Text & "',nilai3='" &
                                            cmbnilai3.Text & "',nilai4='" &
                                            cmbnilai4.Text & "',nilai5='" &
                                            cmbnilai5.Text & "',nilai6='" &
                                            cmbnilai6.Text & "',nilai7='" &
                                            cmbnilai7.Text & "' where id ='" &
                                            txtid.Text & "'"
        cmd = New MySqlCommand(edit, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Diupdate", MsgBoxStyle.Information, "Infbormation")
        Call tampilgird()
        Call bersih()

    End Sub

    Private Sub hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapus.Click
        If MessageBox.Show("apakah data yakin dihapus", "pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Call koneksi_oke()
            Dim hapus As String = "delete from table_nilai_penerima where id ='" & txtid.Text & "'"
            cmd = New MySqlCommand(hapus, conn)
            cmd.ExecuteNonQuery()
            MsgBox("data telah terhapus", MsgBoxStyle.Information, "information")
        End If
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
                txtnm.Text = dr.Item("nm")
                nilai()
                gb2.Visible = True

            End If
        End If
    End Sub
End Class