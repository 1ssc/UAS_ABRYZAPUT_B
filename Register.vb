Public Class Register

    Dim id_user As String

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtUsernameSU IsNot Nothing And txtPasswordSU IsNot Nothing And cboRoleSU IsNot Nothing Then
            Dim kode As String
            Dim role As String = cboRoleSU.Text
            If role = "Owner/Admin" Then
                kode = "ADMOWN"
            ElseIf role = "Cashier" Then
                kode = "CSR"
            End If
            ds.Clear()
            da = New Odbc.OdbcDataAdapter("Select CASE WHEN MAX(CAST(SUBSTRING(ID_USER, 4, 3) AS UNSIGNED)) IS NULL THEN '" & kode & "001'
                                       ELSE CONCAT('" & kode & "',LPAD(MAX(CAST(SUBSTRING(ID_USER, 4, 3) AS UNSIGNED)) + 1, 3, '0'))
                                       END AS nomor
                                       FROM user
                                       WHERE ID_USER LIKE '" & kode & "%';", conn)
            da.Fill(ds, "user")
            id_user = ds.Tables("user").Rows(0).Item(0).ToString

            ds.Clear()
            da = New Odbc.OdbcDataAdapter("insert into user Values(?,?,?,?)", conn)
            da.SelectCommand.Parameters.AddWithValue("id_user", id_user)
            da.SelectCommand.Parameters.AddWithValue("username", txtUsernameSU.Text)
            da.SelectCommand.Parameters.AddWithValue("password", txtPasswordSU.Text)
            da.SelectCommand.Parameters.AddWithValue("role", cboRoleSU.Text)
            da.Fill(ds, "xxx")

            Login.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.koneksi()
        Me.AcceptButton = btnRegister
    End Sub
End Class