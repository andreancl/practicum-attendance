Public Class frmMain

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

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        closeChildForm()
        showForm(frmDashboard)
    End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        closeChildForm()
        showForm(frmAttendance)
    End Sub

    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click
        closeChildForm()
        showForm(frmRecords)
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        closeChildForm()
        showForm(frmSettings)
    End Sub
End Class