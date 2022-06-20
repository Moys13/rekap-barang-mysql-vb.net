Public Class Form2
    Dim reTrn As String
    Dim total As String
    Dim harga As Integer
    Sub tampil()
        Call koneksi()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM barang ORDER BY no ASC", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds)
        dgv_barang.DataSource = ds.Tables(0)
        kodeOtomatis()
        kondisiAwal()
    End Sub
    Sub kondisiAwal()
        btn_edit.Enabled = False
        btn_hapus.Enabled = False
    End Sub
    Sub bersih()
        kodeOtomatis()
        txt_kode.Text = ""
        txt_jenis.Text = ""
        txt_harga.Text = ""
        txt_stock.Text = ""
        txt_total.Text = ""
        txt_cari.Text = ""
    End Sub
    Sub kodeOtomatis()
        conn.Close()
        Call koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM barang ORDER BY no DESC", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            'txt_kode.Text = "BRG0001"
            txt_no.Text = 1
        Else
            txt_no.Text = rd.Item("no") + 1
            'txt_kode.Text = Microsoft.VisualBasic.Mid(rd.Item("kodebarang").ToString, 5, 4) + 1
            'If Len(txt_kode.Text) = 1 Then
            'txt_kode.Text = "BRG000" + txt_kode.Text
            'ElseIf Len(txt_kode.Text) = 2 Then
            'txt_kode.Text = "BRG00" + txt_kode.Text
            'ElseIf Len(txt_kode.Text) = 3 Then
            'txt_kode.Text = "BRG0" + txt_kode.Text
        End If
    End Sub
    Sub simpan()
        If txt_jenis.Text = "" Or txt_stock.Text = "" Or txt_harga.Text = "" Or txt_total.Text = "" Then
            MsgBox("Tolong lengkapi semua FORM!", MsgBoxStyle.Information, "ERROR")
        Else
            Try
                conn.Close()
                koneksi()
                Dim sqlInput As String = "INSERT INTO barang VALUES(" & txt_no.Text & ", '" & txt_kode.Text & "', '" & txt_jenis.Text & "', '" & reTrn & "', " & txt_harga.Text & ", " & txt_stock.Text & ", " & txt_total.Text & ")"
                cmd = New MySql.Data.MySqlClient.MySqlCommand(sqlInput, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil di inputkan", MsgBoxStyle.MsgBoxRight, "SUKSES")
                tampil()
                bersih()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Sub loads()
        With dgv_barang
            txt_no.Text = .Item(0, .CurrentRow.Index).Value
            txt_kode.Text = .Item(1, .CurrentRow.Index).Value.ToString
            txt_jenis.Text = .Item(2, .CurrentRow.Index).Value.ToString
            txt_harga.Text = .Item(4, .CurrentRow.Index).Value
            txt_stock.Text = .Item(5, .CurrentRow.Index).Value
        End With
        btn_edit.Enabled = True
        btn_hapus.Enabled = True
    End Sub
    Sub hapus()
        Dim dialogHps As DialogResult
        dialogHps = MessageBox.Show("Apakah anda ingin menghapus data yang dipilih?", "HAPUS", MessageBoxButtons.YesNo)
        If dialogHps = DialogResult.Yes Then
            conn.Close()
            Call koneksi()
            cmd = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM barang WHERE no = " & txt_no.Text & "", conn)
            cmd.ExecuteNonQuery()
            tampil()
            bersih()
        End If
    End Sub
    Sub edit()
        Call koneksi()
        Dim sqlEdit As String = "UPDATE barang SET kodebarang = '" & txt_kode.Text & "', jenisbarang = '" & txt_jenis.Text & "', harga = " & txt_harga.Text & ", stock = " & txt_stock.Text & ", total = " & txt_total.Text & " WHERE no = '" & txt_no.Text & "'"
        cmd = New MySql.Data.MySqlClient.MySqlCommand(sqlEdit, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data telah di perbarui!", MsgBoxStyle.MsgBoxRight, "SUKSES")
        tampil()
        bersih()
    End Sub
    Sub cari()
        Call koneksi()
        Dim keyword As String = txt_cari.Text
        Dim sqlCari As String = "SELECT * FROM barang WHERE no LIKE '%" & keyword & "%' OR kodebarang LIKE '%" & keyword & "%' OR jenisbarang LIKE '%" & keyword & "%' OR harga LIKE '%" & keyword & "%' OR stock LIKE '%" & keyword & "%' OR total LIKE '%" & keyword & "%'"
        da = New MySql.Data.MySqlClient.MySqlDataAdapter(sqlCari, conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "barang")
        dgv_barang.DataSource = (ds.Tables("barang"))
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        simpan()
    End Sub

    Private Sub rd_ya_CheckedChanged(sender As Object, e As EventArgs) Handles rd_ya.CheckedChanged
        reTrn = "Ya"
    End Sub

    Private Sub rd_tidak_CheckedChanged(sender As Object, e As EventArgs) Handles rd_tidak.CheckedChanged
        reTrn = "Tidak"
    End Sub

    Private Sub dgv_barang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_barang.CellContentClick
        loads()
    End Sub

    Private Sub dgv_barang_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_barang.RowHeaderMouseClick
        loads()
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        hapus()
    End Sub

    Private Sub txt_jenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_jenis.SelectedIndexChanged
        Select Case txt_jenis.Text
            Case "Sampoerna"
                txt_kode.Text = "SMPRN147"
                txt_harga.Text = 26000
                harga = txt_harga.Text
            Case "Marlboro"
                txt_kode.Text = "MRLB247"
                txt_harga.Text = 36000
                harga = txt_harga.Text
            Case "Forte"
                txt_kode.Text = "FRT347"
                txt_harga.Text = 17000
                harga = txt_harga.Text
            Case "Magnum"
                txt_kode.Text = "MGN347"
                txt_harga.Text = 20000
                harga = txt_harga.Text
            Case "Dunhill"
                txt_kode.Text = "DNHL347"
                txt_harga.Text = 28000
                harga = txt_harga.Text
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        bersih()
        tampil()

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        edit()
    End Sub

    Private Sub txt_stock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_stock.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_total.Text = harga * txt_stock.Text
            btn_save.Focus()
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Close()
    End Sub

    Private Sub btn_report_Click(sender As Object, e As EventArgs) Handles btn_report.Click
        Form3.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cari()
    End Sub
End Class