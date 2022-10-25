Imports MySql.Data.MySqlClient

Public Class frmAttendance
    Public con As MySqlConnection = mysqldb()
    Dim logdate As String = String.Format("{0:yyyy-MM-dd}", Date.Now)
    Dim query2 As String = "UPDATE attendance att, practicum prac SET att.LastName = prac.LastName, att.FirstName = prac.FirstName WHERE att.PracticumID = prac.PracticumID"
    Private Sub frmAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_AMAttendance()
        dgvAMAttendance.RowTemplate.Height = 25
        dgvAMAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvAMAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAMAttendance.AlternatingRowsDefaultCellStyle.BackColor = Color.White

        load_PMAttendance()
        dgvPMAttendance.RowTemplate.Height = 25
        dgvPMAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvPMAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPMAttendance.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub
    Public Sub load_AMAttendance()
        query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                & " AS 'Full Name', `Date`, `TimeLogIn_AM` AS 'Time In - AM', `TimeLogOut_AM` AS 'Time Out - AM'" _
                & " FROM `attendance` WHERE `Date` = curdate()"
        reloadDgv(query, dgvAMAttendance)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToLongDateString
        lblTime.Text = TimeOfDay.ToLongTimeString
    End Sub
    Private Sub txtAM_TextChanged(sender As Object, e As EventArgs) Handles txtAM.TextChanged
        Try
            If txtAM.Text = "" Then
            Else
                reloadtxt("SELECT * FROM practicum WHERE PracticumID = '" & txtAM.Text & "'")
                If dt.Rows.Count > 0 Then
                    reloadtxt("SELECT * FROM attendance WHERE PracticumID = '" & txtAM.Text & "' AND DATE = '" & logdate _
                    & "' AND AM_Status = 'OUT'")
                    If dt.Rows.Count > 0 Then
                        MessageBox.Show("you've had enough for this day", "attention", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtAM.Text = Nothing
                    Else
                        reloadtxt("SELECT * FROM attendance WHERE PracticumID = '" & txtAM.Text & "' AND AM_Status = 'IN'")
                        If dt.Rows.Count > 0 Then
                            Dim amout As String = "UPDATE attendance SET TimeLogOut_AM = '" & TimeOfDay & "', AM_Status = 'OUT' WHERE PracticumID = '" & txtAM.Text & "' AND `Date` = '" & logdate & "'"
                            Dim QueryString As String = String.Concat(amout, ";", query2)
                            updateNoMsg(QueryString)
                            load_AMAttendance()
                            PracInfo_AM()
                            txtAM.Text = Nothing
                            TabPage1.Refresh()
                        Else
                            Dim amin As String = "INSERT INTO attendance (PracticumID, Date, TimeLogIn_AM, AM_Status) " _
                            & " VALUES ('" & txtAM.Text & "', '" & logdate & "', '" & TimeOfDay & "', 'IN')"
                            Dim QueryString1 As String = String.Concat(amin, ";", query2)
                            createNoMsg(QueryString1)
                            load_AMAttendance()
                            PracInfo_AM()
                            txtAM.Text = Nothing
                            TabPage1.Refresh()
                        End If
                    End If
                Else
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub load_PMAttendance()
        query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                & " AS 'Full Name', `Date`, `TimeLogIn_PM` AS 'Time In - PM', `TimeLogOut_PM`" _
                & " AS 'Time Out - PM' FROM `attendance` WHERE `Date` = curdate()"
        reloadDgv(query, dgvPMAttendance)
    End Sub

    Private Sub txtPM_TextChanged(sender As Object, e As EventArgs) Handles txtPM.TextChanged
        Try
            If txtPM.Text = "" Then
            Else
                reloadtxt("SELECT * FROM practicum WHERE PracticumID = '" & txtPM.Text & "'")
                If dt.Rows.Count > 0 Then
                    reloadtxt("SELECT * FROM attendance WHERE PracticumID = '" & txtPM.Text & "' AND DATE = '" & logdate _
                    & "' AND PM_Status = 'OUT'")
                    If dt.Rows.Count > 0 Then
                        MessageBox.Show("you've had enough for this day", "attention", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtPM.Text = Nothing
                    Else
                        reloadtxt("SELECT * FROM attendance WHERE PracticumID = '" & txtPM.Text & "' AND PM_Status = 'IN'")
                        If dt.Rows.Count > 0 Then
                            Dim pmout As String = "UPDATE attendance SET TimeLogOut_PM = '" & TimeOfDay & "', PM_Status = 'OUT' WHERE PracticumID = '" & txtPM.Text & "' AND `Date` = '" & logdate & "'"
                            Dim QueryString2 As String = String.Concat(pmout, ";", query2)
                            updateNoMsg(QueryString2)
                            load_PMAttendance()
                            PracInfo_PM()
                            txtPM.Text = Nothing
                            TabPage2.Refresh()
                        Else
                            reloadtxt("SELECT * FROM attendance WHERE PracticumID = '" & txtPM.Text & "' AND DATE = '" & logdate _
                    & "' AND AM_Status = 'OUT'")
                            If dt.Rows.Count > 0 Then
                                Dim pmin As String = "UPDATE attendance SET TimeLogIn_PM = '" & TimeOfDay & "', PM_Status = 'IN' WHERE PracticumID = '" & txtPM.Text & "' AND `Date` = '" & logdate & "'"
                                Dim QueryString4 As String = String.Concat(pmin, ";", query2)
                                updateNoMsg(QueryString4)
                                load_PMAttendance()
                                PracInfo_PM()
                                txtPM.Text = Nothing
                                TabPage2.Refresh()
                            Else
                                Dim pmins As String = "INSERT INTO attendance (PracticumID, Date, TimeLogIn_PM, PM_Status) " _
                          & " VALUES ('" & txtPM.Text & "', '" & logdate & "', '" & TimeOfDay & "', 'IN')"
                                Dim QueryString5 As String = String.Concat(pmins, ";", query2)
                                createNoMsg(QueryString5)
                                load_PMAttendance()
                                PracInfo_PM()
                                txtPM.Text = Nothing
                                TabPage2.Refresh()
                            End If
                        End If
                    End If
                Else
                End If
                End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub PracInfo_AM()
        Try
            query = "SELECT * FROM `practicum` WHERE `PracticumID`='" & txtAM.Text & "'"
            reloadtxt(query)

            If dt.Rows.Count > 0 Then
                lblPracticumID_AM.Text = dt.Rows(0).Item("PracticumID")
                lblLastName_AM.Text = dt.Rows(0).Item("LastName")
                lblFirstName_AM.Text = dt.Rows(0).Item("FirstName")
                lblVenue_AM.Text = dt.Rows(0).Item("Venue")
                lblAssignment_AM.Text = dt.Rows(0).Item("Assignment")
            Else
                lblPracticumID_AM.Text = Nothing
                lblLastName_AM.Text = Nothing
                lblFirstName_AM.Text = Nothing
                lblVenue_AM.Text = Nothing
                lblAssignment_AM.Text = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub PracInfo_PM()
        Try
            query = "SELECT * FROM `practicum` WHERE `PracticumID`='" & txtPM.Text & "'"
            reloadtxt(query)

            If dt.Rows.Count > 0 Then
                lblPracticumID_PM.Text = dt.Rows(0).Item("PracticumID")
                lblLastName_PM.Text = dt.Rows(0).Item("LastName")
                lblFirstName_PM.Text = dt.Rows(0).Item("FirstName")
                lblVenue_PM.Text = dt.Rows(0).Item("Venue")
                lblAssignment_PM.Text = dt.Rows(0).Item("Assignment")
            Else
                lblPracticumID_PM.Text = Nothing
                lblLastName_PM.Text = Nothing
                lblFirstName_PM.Text = Nothing
                lblVenue_PM.Text = Nothing
                lblAssignment_PM.Text = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txtAM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAM.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtPM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPM.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
    Private Sub dgvAMAttendance_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAMAttendance.CellContentClick
        lblAM.Text = dgvAMAttendance.CurrentRow.Cells(0).Value
    End Sub
    Private Sub dgvPMAttendance_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPMAttendance.CellContentClick
        lblPM.Text = dgvPMAttendance.CurrentRow.Cells(0).Value
    End Sub
    Private Sub lblAM_TextChanged(sender As Object, e As EventArgs) Handles lblAM.TextChanged
        Try
            query = "SELECT * FROM `practicum` WHERE `PracticumID`='" & lblAM.Text & "'"
            reloadtxt(query)

            If dt.Rows.Count > 0 Then
                lblPracticumID_AM.Text = dt.Rows(0).Item("PracticumID")
                lblLastName_AM.Text = dt.Rows(0).Item("LastName")
                lblFirstName_AM.Text = dt.Rows(0).Item("FirstName")
                lblVenue_AM.Text = dt.Rows(0).Item("Venue")
                lblAssignment_AM.Text = dt.Rows(0).Item("Assignment")
            Else
                lblPracticumID_AM.Text = Nothing
                lblLastName_AM.Text = Nothing
                lblFirstName_AM.Text = Nothing
                lblVenue_AM.Text = Nothing
                lblAssignment_AM.Text = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub lblPM_TextChanged(sender As Object, e As EventArgs) Handles lblPM.TextChanged
        Try
            query = "SELECT * FROM `practicum` WHERE `PracticumID`='" & lblPM.Text & "'"
            reloadtxt(query)

            If dt.Rows.Count > 0 Then
                lblPracticumID_PM.Text = dt.Rows(0).Item("PracticumID")
                lblLastName_PM.Text = dt.Rows(0).Item("LastName")
                lblFirstName_PM.Text = dt.Rows(0).Item("FirstName")
                lblVenue_PM.Text = dt.Rows(0).Item("Venue")
                lblAssignment_PM.Text = dt.Rows(0).Item("Assignment")
            Else
                lblPracticumID_PM.Text = Nothing
                lblLastName_PM.Text = Nothing
                lblFirstName_PM.Text = Nothing
                lblVenue_PM.Text = Nothing
                lblAssignment_PM.Text = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class