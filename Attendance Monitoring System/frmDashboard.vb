Public Class frmDashboard
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToLongDateString
        lblTime.Text = TimeOfDay.ToLongTimeString
    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Attendance()
        dgvAttendanceRecord.RowTemplate.Height = 25
        dgvAttendanceRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvAttendanceRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAttendanceRecord.AlternatingRowsDefaultCellStyle.BackColor = Color.White
        countall()
        Label5.Text = dt.Rows.Count.ToString
    End Sub
    Public Sub countall()
        query = "SELECT COUNT(*) FROM practicum"
        count(query)
        lblTotalPrac.Text = result.ToString
    End Sub
    Public Sub load_Attendance()
        query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                & " AS 'Full Name', `Date`, `TimeLogIn_AM` AS 'AM Time In', `TimeLogOut_AM` AS 'AM Time Out', " _
                   & " `AM_Status` AS 'AM Status',`TimeLogIn_PM` AS 'PM Time In', `TimeLogOut_PM` AS 'PM Time Out'," _
                   & " `PM_Status` AS 'PM Status' FROM `attendance` WHERE `Date` = curdate()"
        reloadDgv(query, dgvAttendanceRecord)
    End Sub

End Class