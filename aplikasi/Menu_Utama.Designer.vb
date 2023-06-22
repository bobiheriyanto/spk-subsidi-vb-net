<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Utama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ENTRYDATAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPenerimaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataKriteriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputNilaiPenerimaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROSESDATAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProsesPerhitunganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAPORANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanHasilKeputusanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Sitka Small", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ENTRYDATAToolStripMenuItem, Me.PROSESDATAToolStripMenuItem, Me.LAPORANToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(1, 2, 0, 2)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(854, 36)
        Me.MenuStrip1.Stretch = False
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ENTRYDATAToolStripMenuItem
        '
        Me.ENTRYDATAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataPenerimaToolStripMenuItem, Me.DataKriteriaToolStripMenuItem, Me.InputNilaiPenerimaToolStripMenuItem})
        Me.ENTRYDATAToolStripMenuItem.Name = "ENTRYDATAToolStripMenuItem"
        Me.ENTRYDATAToolStripMenuItem.Size = New System.Drawing.Size(153, 32)
        Me.ENTRYDATAToolStripMenuItem.Text = "ENTRY DATA"
        '
        'DataPenerimaToolStripMenuItem
        '
        Me.DataPenerimaToolStripMenuItem.Name = "DataPenerimaToolStripMenuItem"
        Me.DataPenerimaToolStripMenuItem.Size = New System.Drawing.Size(295, 32)
        Me.DataPenerimaToolStripMenuItem.Text = "Data Penerima"
        '
        'DataKriteriaToolStripMenuItem
        '
        Me.DataKriteriaToolStripMenuItem.Name = "DataKriteriaToolStripMenuItem"
        Me.DataKriteriaToolStripMenuItem.Size = New System.Drawing.Size(295, 32)
        Me.DataKriteriaToolStripMenuItem.Text = "Data Kriteria"
        '
        'InputNilaiPenerimaToolStripMenuItem
        '
        Me.InputNilaiPenerimaToolStripMenuItem.Name = "InputNilaiPenerimaToolStripMenuItem"
        Me.InputNilaiPenerimaToolStripMenuItem.Size = New System.Drawing.Size(295, 32)
        Me.InputNilaiPenerimaToolStripMenuItem.Text = "Input Data Penilaian"
        '
        'PROSESDATAToolStripMenuItem
        '
        Me.PROSESDATAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProsesPerhitunganToolStripMenuItem})
        Me.PROSESDATAToolStripMenuItem.Name = "PROSESDATAToolStripMenuItem"
        Me.PROSESDATAToolStripMenuItem.Size = New System.Drawing.Size(164, 32)
        Me.PROSESDATAToolStripMenuItem.Text = "PROSES DATA"
        '
        'ProsesPerhitunganToolStripMenuItem
        '
        Me.ProsesPerhitunganToolStripMenuItem.Name = "ProsesPerhitunganToolStripMenuItem"
        Me.ProsesPerhitunganToolStripMenuItem.Size = New System.Drawing.Size(282, 32)
        Me.ProsesPerhitunganToolStripMenuItem.Text = "Proses Perhitungan"
        '
        'LAPORANToolStripMenuItem
        '
        Me.LAPORANToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanHasilKeputusanToolStripMenuItem})
        Me.LAPORANToolStripMenuItem.Name = "LAPORANToolStripMenuItem"
        Me.LAPORANToolStripMenuItem.Size = New System.Drawing.Size(123, 32)
        Me.LAPORANToolStripMenuItem.Text = "LAPORAN"
        '
        'LaporanHasilKeputusanToolStripMenuItem
        '
        Me.LaporanHasilKeputusanToolStripMenuItem.Name = "LaporanHasilKeputusanToolStripMenuItem"
        Me.LaporanHasilKeputusanToolStripMenuItem.Size = New System.Drawing.Size(339, 32)
        Me.LaporanHasilKeputusanToolStripMenuItem.Text = "Laporan hasil Keputusan"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(98, 32)
        Me.LogOutToolStripMenuItem.Text = "LogOut"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(1, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(852, 386)
        Me.Panel1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bell MT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(219, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 30)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "KEPUTUSAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bell MT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PENDUKUNG"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(30, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SISTEM"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 351)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(853, 34)
        Me.Panel2.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.aplikasi.My.Resources.Resources.hpi
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(11, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(830, 333)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Menu_Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(854, 423)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu_Utama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ENTRYDATAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PROSESDATAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LAPORANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPenerimaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataKriteriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputNilaiPenerimaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProsesPerhitunganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanHasilKeputusanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
