Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.koneksi()
        Me.AcceptButton = btnLogin
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername IsNot Nothing And txtPassword IsNot Nothing Then
            ds.Clear()
            da = New Odbc.OdbcDataAdapter("select * from user where username='" & txtUsername.Text & "' AND password='" & txtPassword.Text & "';", conn)
            da.Fill(ds, "user")
            If ds.Tables("user").Rows.Count > 0 Then
                Me.Hide()
                ShowSelectedForm()
                clearFormLogin()
            Else
                MessageBox.Show("Invalid Username or Password")
            End If
        End If
    End Sub

    Private Sub ShowSelectedForm()
        Dim selectedForm As String = ds.Tables("user").Rows(0).Item(3).ToString()
        If selectedForm = "Cashier" Then
            Dim formA As New Kasir()
            formA.txtUser.Text = txtUsername.Text
            formA.Show()
            Me.Hide()
        ElseIf selectedForm = "Owner/Admin" Then
            Dim formB As New Menu()
            formB.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub clearFormLogin()
        txtUsername.Text = String.Empty
        txtPassword.Text = String.Empty
    End Sub
End Class
