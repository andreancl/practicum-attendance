Public Class frmAttendance
    Dim logdate = Date.Now
    Dim timein_am = TimeOfDay
    Dim timeout_am = TimeOfDay
    Dim timein_pm = TimeOfDay
    Dim timeout_pm = TimeOfDay
    Private Sub frmAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_PracticumAttendance()
        dgvAttendanceRecord.RowTemplate.Height = 25
        dgvAttendanceRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvAttendanceRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAttendanceRecord.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub
    Public Sub load_PracticumAttendance()
        query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                & " AS 'Full Name', `Date`, `TimeLogIn_AM` AS 'Time In - AM', `TimeLogOut_AM` AS 'Time Out - AM'," _
                & " `TimeLogIn_PM` AS 'Time In - PM', `TimeLogOut_PM` AS 'Time Out - PM' FROM `attendance`"
        reloadDgv(query, dgvAttendanceRecord)
    End Sub

    Private Sub txtReader_TextChanged(sender As Object, e As EventArgs) Handles txtReader.TextChanged
        Try
            query = "INSERT INTO `attendance` (`PracticumId`, `LastName`, `FirstName`, `Date`, `TimeLogIn_AM`," _
                & "`TimeLogOut_AM`, `TimeLogIn_PM`, `TimeLogOut_PM`) VALUES ('" & logdate & "', '" & timein_am _
                & "', '" & timeout_pm & "', '" & timein_pm & "', '" & timeout_pm & "')"
            create(query, logdate)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = Date.Now.ToString("dd MMM yyyy   hh:mm:ss")
    End Sub
End Class