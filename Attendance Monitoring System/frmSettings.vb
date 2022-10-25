Imports MySql.Data.MySqlClient

Public Class frmSettings
    Dim rdoad As String = ""
    Public con As MySqlConnection = mysqldb()
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_UserRecords()

        dgvUserRecords.RowTemplate.Height = 30
        dgvUserRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvUserRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUserRecords.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub
    Public Sub load_UserRecords()
        query = "SELECT `UserId` AS 'User ID',`FullName` as 'Full Name' FROM `users`"
        reloadDgv(query, dgvUserRecords)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If txtFullName.Text.Equals(String.Empty) Then
                MsgBox("This action cannot be performed.", MsgBoxStyle.Information)
            Else
                Dim question As String
                question = MsgBox("Are you sure you want to delete ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION !")
                If question = vbYes Then
                    DeleteUser()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub DeleteUser()
        Try
            query = "DELETE FROM users WHERE UserId = '" & dgvUserRecords.CurrentRow.Cells(0).Value & "'"
            deletes(query, dgvUserRecords.CurrentRow.Cells(1).Value)
            load_UserRecords()
            clearcontrol(gbUser)
            lblUserId.Text = ""
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        query = "SELECT * FROM `users` WHERE `UserId`='" & lblUserId.Text & "'"
        reloadtxt(query)

        If rdoadmin.Checked = True Then
            rdoad = "1"
        Else
            rdoad = "2"
        End If
        query = "UPDATE `users` SET  `FullName`='" & txtFullName.Text _
           & "', `Username`='" & txtUsername.Text & "', `Password`='" & txtPassword.Text _
           & "', `SecretQuestion`='" & cmbSecretQuestion.Text & "', `SecretAnswer`='" & txtSecretAnswer.Text _
           & "' WHERE `UserId`='" & lblUserId.Text & "'"
        updates(query)
        load_UserRecords()
        clearcontrol(gbUser)
        lblUserId.Text = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtFullName.Text = "" And txtUsername.Text = "" And txtPassword.Text = "" And rdoad = "" And cmbSecretQuestion.Text = "" And txtSecretAnswer.Text = "" Then
            MsgBox("Fill up your account details", MsgBoxStyle.Critical, "ATTENTION!")
            txtFullName.Focus()
        ElseIf txtFullName.Text = "" Then
            MsgBox("No Full Name Found!", MsgBoxStyle.Critical, "Error")
            txtFullName.Focus()
        ElseIf txtUsername.Text = "" Then
            MsgBox("No Username Found!", MsgBoxStyle.Critical, "Error")
            txtUsername.Focus()
        ElseIf txtPassword.Text = "" Then
            MsgBox("No Password Found!", MsgBoxStyle.Critical, "Error")
            txtPassword.Focus()
        ElseIf rdoadmin.Text = "" Or rdouser.Text = "" Then
            MsgBox("Please Select User Type", MsgBoxStyle.Critical, "Error")
            rdoadmin.Focus()
        ElseIf cmbSecretQuestion.Text = "" Then
            MsgBox("No Secret Question Found!", MsgBoxStyle.Critical, "Error")
            cmbSecretQuestion.Focus()
        ElseIf txtSecretAnswer.Text = "" Then
            MsgBox("No Secret Answer Found!", MsgBoxStyle.Critical, "Error")
            txtSecretAnswer.Focus()
        Else
            CheckingUsername()
        End If
    End Sub
    Private Sub CheckingUsername()
        Try
            con.Open()
            query = "SELECT Username FROM users WHERE Username = '" & txtUsername.Text & "'"
            cmd = New MySqlCommand(query, con)
            dr = cmd.ExecuteReader()
            Dim count As Integer
            count = 0
            While dr.Read
                count = count + 1
            End While
            Select Case count
                Case 1
                    MsgBox("Username already exists. Please try another username!", MsgBoxStyle.Critical, "ATTENTION")
                Case Else
                    con.Close()
                    CreatingAccount()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace)
        Finally
            dr.Close()
            con.Close()
        End Try
    End Sub
    Private Sub CreatingAccount()
        Dim datetime_now As String = String.Format("{0:ddMMyyyhhss}", DateTime.Now)
        Dim user_id = "USER" + datetime_now

        If rdoadmin.Checked = True Then
            rdoad = "1"
        Else
            rdoad = "2"
        End If

        query = "INSERT INTO users (`UserId`, `FullName`, `Username`, `Password`, `SecretQuestion`" _
        & ", `SecretAnswer`, `UserTypeId`) VALUES ('" & user_id & "', '" & txtFullName.Text _
        & "', '" & txtUsername.Text & "', '" & txtPassword.Text & "', '" & cmbSecretQuestion.Text _
        & "', '" & txtSecretAnswer.Text & "', '" & rdoad & "')"
        create(query)
        load_UserRecords()
        clearcontrol(gbUser)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearcontrol(gbUser)
        lblUserId.Text = ""
    End Sub

    Private Sub dgvUserRecords_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserRecords.CellContentClick
        lblUserId.Text = dgvUserRecords.CurrentRow.Cells(0).Value
    End Sub
    Private Sub lblUserId_TextChanged(sender As Object, e As EventArgs) Handles lblUserId.TextChanged
        Try
            query = "SELECT * FROM `users` WHERE `UserId`='" & lblUserId.Text & "'"
            reloadtxt(query)

            If dt.Rows.Count > 0 Then
                txtFullName.Text = dt.Rows(0).Item("FullName")
                txtUsername.Text = dt.Rows(0).Item("Username")
                txtPassword.Text = dt.Rows(0).Item("Password")
                cmbSecretQuestion.Text = dt.Rows(0).Item("SecretQuestion")
                txtSecretAnswer.Text = dt.Rows(0).Item("SecretAnswer")
                If dt.Rows(0).Item("UserTypeId") = "1" Then
                    rdoadmin.Checked = True
                Else
                    rdouser.Checked = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#Region "Validation"
    Private Sub txtFullName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFullName.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            If Asc(e.KeyChar) = 8 Then
                e.Handled = False
            ElseIf Asc(e.KeyChar) = 32 Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            If Asc(e.KeyChar) = 8 Then
                e.Handled = False
            ElseIf Asc(e.KeyChar) = 32 Then
                e.Handled = True
            Else
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtSecretAnswer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSecretAnswer.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            If Asc(e.KeyChar) = 8 Then
                e.Handled = False
            ElseIf Asc(e.KeyChar) = 32 Then
                e.Handled = True
            Else
                e.Handled = True
            End If
        End If
    End Sub
#End Region
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked = False Then
            txtPassword.PasswordChar = "*"
        Else
            txtPassword.PasswordChar = ""
        End If
    End Sub

    Private Sub chkSecretAnswer_CheckedChanged(sender As Object, e As EventArgs) Handles chkSecretAnswer.CheckedChanged
        If chkSecretAnswer.Checked = False Then
            txtSecretAnswer.PasswordChar = "*"
        Else
            txtSecretAnswer.PasswordChar = ""
        End If
    End Sub
End Class