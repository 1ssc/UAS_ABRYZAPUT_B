Public Class Menu
    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub btnManageJuz_Click(sender As Object, e As EventArgs) Handles btnManageJuz.Click
        Edit_Menu.Show()
        Me.Hide()
    End Sub

    Private Sub btnCashier_Click(sender As Object, e As EventArgs) Handles btnCashier.Click
        Kasir.Show()
        Me.Hide()
    End Sub

    Private Sub btnTransactionHistory_Click(sender As Object, e As EventArgs) Handles btnTransactionHistory.Click

    End Sub
End Class