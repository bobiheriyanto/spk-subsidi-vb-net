Public Class Menu_Utama

    Private Sub LOGINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        login.ShowDialog()
    End Sub

    Private Sub DataPenerimaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPenerimaToolStripMenuItem.Click
        data_calon_penerima.ShowDialog()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        login.Show()
        Me.Close()
    End Sub

    Private Sub DataKriteriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataKriteriaToolStripMenuItem.Click
        data_kriteria.ShowDialog()
    End Sub

    Private Sub InputNilaiPenerimaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputNilaiPenerimaToolStripMenuItem.Click
        Data_Nilai_Penerima.ShowDialog()
    End Sub

    Private Sub ProsesPerhitunganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProsesPerhitunganToolStripMenuItem.Click
        Proses_Perhitungan.ShowDialog()
    End Sub

    Private Sub LaporanHasilKeputusanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanHasilKeputusanToolStripMenuItem.Click
        laporan_hsl_keputusan.ShowDialog()

    End Sub
End Class