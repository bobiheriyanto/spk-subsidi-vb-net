Imports MySql.Data.MySqlClient
Public Class login

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        If Me.username.Text = "" Then
            MessageBox.Show("Username Harus Diisi!", "PERINGATAN", MessageBoxButtons.OK)
            username.Focus()
            Exit Sub
        End If
        If Me.password.Text = "" Then
            MessageBox.Show("Password Harus Diisi!", "PERINGATAN", MessageBoxButtons.OK)
            password.Focus()
            Exit Sub
        End If
        Call koneksi_oke()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        If username.Text = "" Then
            MsgBox("Masukan Username", MsgBoxStyle.Critical)
        ElseIf password.Text = "" Then
            MsgBox("Masukan Password", MsgBoxStyle.Critical)
        Else
            Dim sql As String
            sql = "select * from table_admin where user_name='" + username.Text + "' and password='" + password.Text + "' and pengguna='" + ComboBox1.SelectedItem + "'"
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter(cmd)
            ds = New Data.DataSet
            da.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("Gagal Login", MsgBoxStyle.Critical)
                username.Clear()
                password.Clear()
                ComboBox1.Text = "- Pilih Hak Akses -"
                username.Focus()

            ElseIf ComboBox1.SelectedItem = "Admin" Then
                Menu_Utama.Show()
                Menu_Utama.DataPenerimaToolStripMenuItem.Enabled = True
                Menu_Utama.DataKriteriaToolStripMenuItem.Enabled = True
                Menu_Utama.InputNilaiPenerimaToolStripMenuItem.Enabled = True
                Menu_Utama.ProsesPerhitunganToolStripMenuItem.Enabled = True

                Menu_Utama.LaporanHasilKeputusanToolStripMenuItem.Enabled = True
                Me.Hide()
            ElseIf ComboBox1.SelectedItem = "Pimpinan" Then
                Menu_Utama.Show()
                Menu_Utama.DataPenerimaToolStripMenuItem.Enabled = False
                Menu_Utama.DataKriteriaToolStripMenuItem.Enabled = False
                Menu_Utama.InputNilaiPenerimaToolStripMenuItem.Enabled = False
                Menu_Utama.ProsesPerhitunganToolStripMenuItem.Enabled = False

                Menu_Utama.LaporanHasilKeputusanToolStripMenuItem.Enabled = True
                Me.Hide()
            ElseIf ComboBox1.SelectedItem = "Pengawas" Then
                Menu_Utama.Show()
                Menu_Utama.DataPenerimaToolStripMenuItem.Enabled = False
                Menu_Utama.DataKriteriaToolStripMenuItem.Enabled = False
                Menu_Utama.InputNilaiPenerimaToolStripMenuItem.Enabled = True
                Menu_Utama.ProsesPerhitunganToolStripMenuItem.Enabled = False

                Menu_Utama.LaporanHasilKeputusanToolStripMenuItem.Enabled = True
                Me.Hide()
            End If

        End If
        username.Clear()
        password.Clear()
        ComboBox1.Text = ""


    End Sub


    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        password.PasswordChar = "*"
        koneksi_oke()
        username.Clear()
        password.Clear()
        ComboBox1.Text = ""
    End Sub

End Class
