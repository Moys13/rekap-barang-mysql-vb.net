Imports MySql.Data.MySqlClient
Module Module1
    Public conn As MySqlConnection
    Public da As MySqlDataAdapter
    Public cmd As MySqlCommand
    Public ds As DataSet
    Public rd As MySqlDataReader
    Public dt As DataTable

    Public Sub koneksi()
        Try
            conn = New MySqlConnection("server=localhost; userid=root; password=; database=visual")
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("MySQL tidak konek", MsgBoxStyle.Information, "ERROR")
        End Try
    End Sub
End Module
