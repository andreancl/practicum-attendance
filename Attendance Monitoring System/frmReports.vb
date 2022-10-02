Public Class frmReports

    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click
        query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
               & " AS 'Full Name', `Course`, `Venue`, `Assignment`, `TotalHours` AS 'Total Hours'," _
               & " `Batch`,  `SchoolYear` AS 'S.Y', `StartDate` AS 'Start Date', `EndDate` AS 'End Date'" _
               & " FROM `practicum`"
        reloadDgv(query, dgvRecords)
    End Sub

    Private Sub frmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvRecords.RowTemplate.Height = 25
        dgvRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRecords.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If cmbFilter.Text = "NAME" Then
            query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                & " AS 'Full Name', `Course`, `Venue`, `Assignment`, `Batch`,  `SchoolYear` AS 'S.Y', " _
                & " `StartDate` AS 'Start Date', `EndDate` AS 'End Date' FROM `practicum`" _
                & " WHERE CONCAT(`LastName`,', ', `FirstName`) LIKE '%" & txtSearch.Text & "%'"
            reloadDgv(query, dgvRecords)
        ElseIf cmbFilter.Text = "PRACTICUM ID" Then
            query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                & " AS 'Full Name', `Course`, `Venue`, `Assignment`, `Batch`,  `SchoolYear` AS 'S.Y', " _
                & " `StartDate` AS 'Start Date', `EndDate` AS 'End Date' FROM `practicum`" _
                & " WHERE PracticumID LIKE '%" & txtSearch.Text & "%'"
            reloadDgv(query, dgvRecords)
        ElseIf cmbFilter.Text = "COURSE" Then
            query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
              & " AS 'Full Name', `Course`, `Venue`, `Assignment`, `Batch`,  `SchoolYear` AS 'S.Y', " _
              & " `StartDate` AS 'Start Date', `EndDate` AS 'End Date' FROM `practicum`" _
              & " WHERE Course LIKE '%" & txtSearch.Text & "%'"
            reloadDgv(query, dgvRecords)
        ElseIf cmbFilter.Text = "VENUE" Then
            query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
              & " AS 'Full Name', `Course`, `Venue`, `Assignment`, `Batch`,  `SchoolYear` AS 'S.Y', " _
              & " `StartDate` AS 'Start Date', `EndDate` AS 'End Date' FROM `practicum`" _
              & " WHERE Venue LIKE '%" & txtSearch.Text & "%'"
            reloadDgv(query, dgvRecords)
        ElseIf cmbFilter.Text = "ASSIGNMENT" Then
            query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
              & " AS 'Full Name', `Course`, `Venue`, `Assignment`, `Batch`,  `SchoolYear` AS 'S.Y', " _
              & " `StartDate` AS 'Start Date', `EndDate` AS 'End Date' FROM `practicum`" _
              & " WHERE Assignment LIKE '%" & txtSearch.Text & "%'"
            reloadDgv(query, dgvRecords)
        ElseIf cmbFilter.Text = "BATCH" Then
            query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
              & " AS 'Full Name', `Course`, `Venue`, `Assignment`, `Batch`,  `SchoolYear` AS 'S.Y', " _
              & " `StartDate` AS 'Start Date', `EndDate` AS 'End Date' FROM `practicum`" _
              & " WHERE Batch LIKE '%" & txtSearch.Text & "%'"
            reloadDgv(query, dgvRecords)
        End If
    End Sub

End Class