Imports MySql.Data.MySqlClient

Public Class frmLogIn
    Public UsernameGetter As String
    Public con As MySqlConnection = mysqldb()

    Public Sub Reset()
        txtUsername.Select()
        chckboxShowPassword.Checked = False
        txtUsername.Clear()
        txtPassword.Clear()
        txtForgotPass_Username.Clear()
        cmbSecretQuestion.Text = ""
        txtSecretAnswer.Clear()
        txtNewPassword.Clear()
        txtConfirmNewPassword.Clear()
        AcceptButton = btnLogin
    End Sub

#Region "Log In"
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" And txtPassword.Text = "" Then
            MsgBox("No Username and Password Found!", MsgBoxStyle.Critical, "ATTENTION")
            txtUsername.Focus()
        ElseIf txtUsername.Text = "" Then
            MsgBox("No Username Found!", MsgBoxStyle.Critical, "ATTENTION")
            txtUsername.Focus()
        ElseIf txtPassword.Text = "" Then
            MsgBox("No Password Found!", MsgBoxStyle.Critical, "ATTENTION")
            txtPassword.Focus()
        Else
            If Not UserExists() Then
                MsgBox("Wrong Username/Password!", MsgBoxStyle.Critical, "ATTENTION")
            End If
            LogIn(txtUsername.Text, txtPassword.Text)
        End If
    End Sub
    Private Function UserExists() As Boolean
        Dim Result As Boolean = False
        Try
            con.Open()
            Dim query As String
            query = "SELECT * FROM users where BINARY Username= '" & txtUsername.Text & "' and BINARY Password = '" & txtPassword.Text & "' "
            cmd = New MySqlCommand(query, con)
            If cmd.ExecuteScalar() > 0 Then Result = True
            cmd.Dispose()
        Catch ex As Exception
        Finally
            con.Close()
        End Try
        Return Result
    End Function
#Region "Log In Validation"
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
#End Region
    Private Sub txtUsername_Click(sender As Object, e As EventArgs) Handles txtUsername.Click
        txtUsername.BackColor = Color.White
        Panel_Username.BackColor = Color.White

        txtPassword.BackColor = SystemColors.Control
        Panel_Password.BackColor = SystemColors.Control
    End Sub

    Private Sub txtPassword_Click(sender As Object, e As EventArgs) Handles txtPassword.Click
        txtPassword.BackColor = Color.White
        Panel_Password.BackColor = Color.White

        txtUsername.BackColor = SystemColors.Control
        Panel_Username.BackColor = SystemColors.Control
    End Sub

    Private Sub chckboxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chckboxShowPassword.CheckedChanged
        If chckboxShowPassword.Checked = False Then
            txtPassword.PasswordChar = "*"
        Else
            txtPassword.PasswordChar = ""
        End If
    End Sub

    Private Sub btnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        Reset()
        Panel_LogIn.Hide()
        Panel_ForgotPass.Show()
        lblTitle.Text = "Forgot Password"
    End Sub
#End Region

#Region "Forgot Password"
    Private Sub txtForgotPass_Username_Click(sender As Object, e As EventArgs) Handles txtForgotPass_Username.Click
        txtForgotPass_Username.BackColor = Color.White
        Panel_ForgotPass_Username.BackColor = Color.White

        cmbSecretQuestion.BackColor = SystemColors.Control
        Panel_SecretQ.BackColor = SystemColors.Control

        txtSecretAnswer.BackColor = SystemColors.Control
        Panel_SecretA.BackColor = SystemColors.Control
    End Sub
    Private Sub cmbSecretQuestion_Click(sender As Object, e As EventArgs) Handles cmbSecretQuestion.Click
        cmbSecretQuestion.BackColor = Color.White
        Panel_SecretQ.BackColor = Color.White

        txtForgotPass_Username.BackColor = SystemColors.Control
        Panel_ForgotPass_Username.BackColor = SystemColors.Control

        txtSecretAnswer.BackColor = SystemColors.Control
        Panel_SecretA.BackColor = SystemColors.Control
    End Sub
    Private Sub txtSecretAnswer_Click(sender As Object, e As EventArgs) Handles txtSecretAnswer.Click

        txtSecretAnswer.BackColor = Color.White
        Panel_SecretA.BackColor = Color.White

        txtForgotPass_Username.BackColor = SystemColors.Control
        Panel_ForgotPass_Username.BackColor = SystemColors.Control

        cmbSecretQuestion.BackColor = SystemColors.Control
        Panel_SecretQ.BackColor = SystemColors.Control

    End Sub
#Region "Forgot Password Validation"
    Private Sub txtForgotPass_Username_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtForgotPass_Username.KeyPress
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
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Reset()
        Panel_ForgotPass.Hide()
        Panel_LogIn.Show()
        Panel_LogIn.ResetText()
        lblTitle.Text = "LogIn to your account"
    End Sub
    Private Sub chkbxForgotPass_ShowSA_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxForgotPass_ShowSA.CheckedChanged
        If chkbxForgotPass_ShowSA.Checked = False Then
            txtSecretAnswer.PasswordChar = "*"
        Else
            txtSecretAnswer.PasswordChar = ""
        End If
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtForgotPass_Username.Text = "" And cmbSecretQuestion.Text = "" And txtSecretAnswer.Text = "" Then
            MsgBox("Fill up account details!", MsgBoxStyle.Critical, "ATTENTION")
            txtForgotPass_Username.Select()
        ElseIf txtForgotPass_Username.Text = "" Then
            MsgBox("No Username Found!", MsgBoxStyle.Critical, "ATTENTION")
            txtForgotPass_Username.Select()
        ElseIf cmbSecretQuestion.Text = "" Then
            MsgBox("No Secret Question Found!", MsgBoxStyle.Critical, "ATTENTION")
            cmbSecretQuestion.Select()
        ElseIf txtSecretAnswer.Text = "" Then
            MsgBox("No Secret Answer Found!", MsgBoxStyle.Critical, "ATTENTION")
            txtSecretAnswer.Select()
        Else
            Try
                con.Open()
                Dim query As String
                query = "SELECT * FROM users where BINARY Username= '" & txtForgotPass_Username.Text & "' and BINARY SecretQuestion = '" & cmbSecretQuestion.Text & "' and BINARY SecretAnswer = '" & txtSecretAnswer.Text & "' "
                cmd = New MySqlCommand(query, con)
                dr = cmd.ExecuteReader()
                If dr.Read = True Then
                    UsernameGetter = dr.Item("Username")
                    con.Close()
                    dr.Close()
                    Reset()
                    Panel_LogIn.Hide()
                    Panel_ForgotPass.Hide()
                    Panel_SetNewPassword.Show()
                    lblTitle.Text = "Set New Password"
                Else
                    MsgBox("Your details is incorrect!", MsgBoxStyle.Critical, "ATTENTION")
                    dr.Close()
                    con.Close()
                    txtSecretAnswer.Clear()
                    txtSecretAnswer.Focus()
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub txtForgotPass_Username_TextChanged(sender As Object, e As EventArgs) Handles txtForgotPass_Username.TextChanged
        con.Open()
        Dim query As String
        query = "SELECT * FROM users where Username= '" & txtForgotPass_Username.Text & "' "
        cmd = New MySqlCommand(query, con)
        dr = cmd.ExecuteReader()
        If dr.Read Then
            cmbSecretQuestion.Text = dr("SecretQuestion").ToString
        Else
            cmbSecretQuestion.Text = ""
        End If
        con.Close()
    End Sub
#End Region

#Region "Set New Password"
    Private Sub txtNewPassword_Click(sender As Object, e As EventArgs) Handles txtNewPassword.Click
        txtNewPassword.BackColor = Color.White
        Panel_NewPassword.BackColor = Color.White

        txtConfirmNewPassword.BackColor = SystemColors.Control
        Panel_ConfirmNewPassword.BackColor = SystemColors.Control
    End Sub
    Private Sub txtConfirmNewPassword_Click(sender As Object, e As EventArgs) Handles txtConfirmNewPassword.Click
        txtConfirmNewPassword.BackColor = Color.White
        Panel_ConfirmNewPassword.BackColor = Color.White

        txtNewPassword.BackColor = SystemColors.Control
        Panel_NewPassword.BackColor = SystemColors.Control
    End Sub

    Private Sub chckbox_SetNP_ShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chckbox_SetNP_ShowPass.CheckedChanged
        If chckbox_SetNP_ShowPass.Checked = False Then
            txtNewPassword.PasswordChar = "*"
            txtConfirmNewPassword.PasswordChar = "*"
        Else
            txtNewPassword.PasswordChar = ""
            txtConfirmNewPassword.PasswordChar = ""
        End If
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        If txtNewPassword.Text = "" Then
            MsgBox("No New Password Found!", MsgBoxStyle.Critical, "Error")
            txtNewPassword.Focus()
        ElseIf txtConfirmNewPassword.Text = "" Then
            MsgBox("No Confirm New Password Found!", MsgBoxStyle.Critical, "Error")
            txtConfirmNewPassword.Focus()
        Else
            Comparing()
        End If
    End Sub
    Private Sub Comparing()
        If Not txtNewPassword.Text = txtConfirmNewPassword.Text Then
            MsgBox("Your New Password and Confirm New Password are not the same!", MsgBoxStyle.Critical, "Error")
        ElseIf Not txtConfirmNewPassword.Text = txtNewPassword.Text Then
            MsgBox("Your New Password and Confirm New Password are not the same!", MsgBoxStyle.Critical, "Error")
        Else
            SettingANewPassword()
        End If
    End Sub
    Private Sub SettingANewPassword()
        Try
            con.Open()
            Dim query As String
            query = "UPDATE users SET Password = '" & txtConfirmNewPassword.Text & "' WHERE Username = '" & UsernameGetter & "'"
            cmd = New MySqlCommand(query, con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("SUCCESSFULLY UPDATED YOUR PASSWORD", MsgBoxStyle.Information, "ATTENTION")
            Panel_SetNewPassword.Hide()
            Reset()
            Panel_LogIn.Show()
            lblTitle.Text = "LogIn to your account"
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btn_SetNP_Back_Click(sender As Object, e As EventArgs) Handles btn_SetNP_Back.Click
        If btn_SetNP_Back.Text = "BACK" Then
            Reset()
            Panel_SetNewPassword.Hide()
            Panel_ForgotPass.Show()
        Else
            Dim question As String
            question = MsgBox("Are you sure you want to cancel?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
            If question = vbYes Then
                Reset()
                Panel_ForgotPass.Show()
                Panel_SetNewPassword.Hide()
            End If
        End If
    End Sub
#Region "Validation"
    Private Sub Panel_ForgotPass_KeyDown(sender As Object, e As KeyEventArgs) Handles Panel_ForgotPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnChangePassword.PerformClick()
        End If
    End Sub
    Private Sub txtNewPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewPassword.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtConfirmNewPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConfirmNewPassword.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
#End Region
    Private Sub txtNewPassword_TextChanged(sender As Object, e As EventArgs) Handles txtNewPassword.TextChanged
        If txtNewPassword.Text = "" Then
            btn_SetNP_Back.Text = "BACK"
        Else
            btn_SetNP_Back.Text = "CANCEL"
        End If
    End Sub
#End Region

    Private Sub frmLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
        Panel_ForgotPass.Hide()
        Panel_SetNewPassword.Hide()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class
