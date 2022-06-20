<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_cari = New System.Windows.Forms.TextBox()
        Me.btn_report = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.dgv_barang = New System.Windows.Forms.DataGridView()
        Me.txt_stock = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_harga = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rd_tidak = New System.Windows.Forms.RadioButton()
        Me.rd_ya = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_jenis = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_kode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_no = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.dgv_barang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(20, 437)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 39)
        Me.Button2.TabIndex = 47
        Me.Button2.Text = "&Bersih"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(45, 339)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Total"
        '
        'txt_total
        '
        Me.txt_total.Enabled = False
        Me.txt_total.Location = New System.Drawing.Point(120, 336)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(100, 20)
        Me.txt_total.TabIndex = 45
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(705, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "&Cari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_cari
        '
        Me.txt_cari.Location = New System.Drawing.Point(563, 95)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(136, 20)
        Me.txt_cari.TabIndex = 43
        '
        'btn_report
        '
        Me.btn_report.Location = New System.Drawing.Point(112, 437)
        Me.btn_report.Name = "btn_report"
        Me.btn_report.Size = New System.Drawing.Size(75, 39)
        Me.btn_report.TabIndex = 42
        Me.btn_report.Text = "&Report"
        Me.btn_report.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(199, 437)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 39)
        Me.btn_exit.TabIndex = 41
        Me.btn_exit.Text = "&Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(199, 382)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(75, 39)
        Me.btn_hapus.TabIndex = 40
        Me.btn_hapus.Text = "&Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(112, 382)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 39)
        Me.btn_edit.TabIndex = 39
        Me.btn_edit.Text = "&Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(20, 382)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 39)
        Me.btn_save.TabIndex = 38
        Me.btn_save.Text = "&Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'dgv_barang
        '
        Me.dgv_barang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_barang.Location = New System.Drawing.Point(288, 124)
        Me.dgv_barang.Name = "dgv_barang"
        Me.dgv_barang.Size = New System.Drawing.Size(492, 357)
        Me.dgv_barang.TabIndex = 37
        '
        'txt_stock
        '
        Me.txt_stock.Location = New System.Drawing.Point(120, 296)
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.Size = New System.Drawing.Size(100, 20)
        Me.txt_stock.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 299)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Stock"
        '
        'txt_harga
        '
        Me.txt_harga.Location = New System.Drawing.Point(120, 261)
        Me.txt_harga.Name = "txt_harga"
        Me.txt_harga.Size = New System.Drawing.Size(100, 20)
        Me.txt_harga.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Harga"
        '
        'rd_tidak
        '
        Me.rd_tidak.AutoSize = True
        Me.rd_tidak.Location = New System.Drawing.Point(182, 228)
        Me.rd_tidak.Name = "rd_tidak"
        Me.rd_tidak.Size = New System.Drawing.Size(52, 17)
        Me.rd_tidak.TabIndex = 32
        Me.rd_tidak.TabStop = True
        Me.rd_tidak.Text = "Tidak"
        Me.rd_tidak.UseVisualStyleBackColor = True
        '
        'rd_ya
        '
        Me.rd_ya.AutoSize = True
        Me.rd_ya.Location = New System.Drawing.Point(120, 228)
        Me.rd_ya.Name = "rd_ya"
        Me.rd_ya.Size = New System.Drawing.Size(38, 17)
        Me.rd_ya.TabIndex = 31
        Me.rd_ya.TabStop = True
        Me.rd_ya.Text = "Ya"
        Me.rd_ya.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Return"
        '
        'txt_jenis
        '
        Me.txt_jenis.FormattingEnabled = True
        Me.txt_jenis.Items.AddRange(New Object() {"Sampoerna", "Marlboro", "Forte", "Magnum", "Dunhill"})
        Me.txt_jenis.Location = New System.Drawing.Point(120, 186)
        Me.txt_jenis.Name = "txt_jenis"
        Me.txt_jenis.Size = New System.Drawing.Size(121, 21)
        Me.txt_jenis.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Jenis Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Kode Barang"
        '
        'txt_kode
        '
        Me.txt_kode.Enabled = False
        Me.txt_kode.Location = New System.Drawing.Point(120, 147)
        Me.txt_kode.Name = "txt_kode"
        Me.txt_kode.Size = New System.Drawing.Size(100, 20)
        Me.txt_kode.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "No"
        '
        'txt_no
        '
        Me.txt_no.Enabled = False
        Me.txt_no.Location = New System.Drawing.Point(120, 109)
        Me.txt_no.Name = "txt_no"
        Me.txt_no.Size = New System.Drawing.Size(100, 20)
        Me.txt_no.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Nama: Wismoyo Bagas Laksono"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "NPM : 20400006"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 13)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Kelas: DDT-40/20"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(795, 496)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_cari)
        Me.Controls.Add(Me.btn_report)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.dgv_barang)
        Me.Controls.Add(Me.txt_stock)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_harga)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rd_tidak)
        Me.Controls.Add(Me.rd_ya)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_jenis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_kode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_no)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.dgv_barang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_cari As TextBox
    Friend WithEvents btn_report As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents dgv_barang As DataGridView
    Friend WithEvents txt_stock As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_harga As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents rd_tidak As RadioButton
    Friend WithEvents rd_ya As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_jenis As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_kode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_no As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
