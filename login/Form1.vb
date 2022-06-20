
Public Class Form1
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Call koneksi()
        Dim passHas As String = txt_password.Text
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM users  WHERE username = '" & txt_username.Text & "' AND password = '" & txt_password.Text & "'", conn)
        dt = New DataTable
        da.Fill(dt)
        If dt.Rows.Count = 0 Then
            MsgBox("Akun tidak belum terdaftar!", MsgBoxStyle.Information, "ERROR")
            Label3.Text = passHas
        Else
            MsgBox("Berhasil login!", MsgBoxStyle.MsgBoxRight, "SUKSES")
            Form2.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
