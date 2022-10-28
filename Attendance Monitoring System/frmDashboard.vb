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
            & " AS 'Full Name', `Date`, TIME_FORMAT(`TimeLogIn_AM`, '%r') AS 'AM Time In'" _
            & ", TIME_FORMAT(`TimeLogOut_AM`, '%r') AS 'AM Time Out', `AM_Status` AS 'AM Status'" _
            & ", TIME_FORMAT(`TimeLogIn_PM`, '%r') AS 'PM Time In'" _
            & ", TIME_FORMAT(`TimeLogOut_PM`, '%r') AS 'PM Time Out', `PM_Status` AS 'PM Status'" _
            & " FROM `attendance` WHERE `Date` = curdate()"
        reloadDgv(query, dgvAttendanceRecord)
    End Sub
End Class