Imports MySql.Data.MySqlClient
Module user
    Public con As MySqlConnection = mysqldb()
    Public Sub LogIn(ByVal username As Object, ByVal password As Object)
        Try
            con.Open()
            Dim query As String
            query = "SELECT UserTypeId FROM users where BINARY Username= '" & username & "' and BINARY Password = '" & password & "' "
            cmd = New MySqlCommand(query, con)
            dr = cmd.ExecuteReader
            If dr.HasRows() Then
                dr.Read()
                If dr("UserTypeId") = "1" Then
                    With frmMain
                        .btnDashboard.Visible = True
                        .btnPracticums.Visible = True
                        .btnAttendance.Visible = False
                        .btnRecords.Visible = True
                        .btnSettings.Visible = True
                        .btnLogOut.Text = "Log Out"
                    End With
                    frmMain.Show()
                    showForm(frmDashboard)
                    frmLogIn.Hide()
                Else
                    With frmMain
                        .btnDashboard.Visible = True
                        .btnPracticums.Visible = False
                        .btnAttendance.Visible = True
                        .btnRecords.Visible = False
                        .btnSettings.Visible = False
                        .btnLogOut.Text = "Log Out"
                    End With
                    frmMain.Show()
                    showForm(frmDashboard)
                    frmLogIn.Hide()
                End If
            End If
            dr.Close()
            cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        con.Close()
    End Sub
End Module
