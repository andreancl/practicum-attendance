Public Class frmDashboard

    Private Sub btnPracticums_Click(sender As Object, e As EventArgs) Handles btnPracticums.Click
        closeChildForm()
        showForm(frmPracticums)
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        btnLogOut.Text = MessageBox.Show("Are you sure you want to logout?", "ATTENTION", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If btnLogOut.Text = DialogResult.Yes Then
            Me.Hide()
            Reset()
            frmLogIn.Show()
            frmLogIn.Reset()
        Else
            btnLogOut.Text = "Log Out"
        End If
    End Sub

End Class