Imports System.Drawing.Printing

Public Class frmReports
    Private mRow As Integer = 0
    Private newpage As Boolean = True
    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click
        query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
               & " AS 'Full Name', `Course`, `Venue`, `Assignment`, `TotalHours` AS 'Total Hours'," _
               & " `Batch`,  `SchoolYear` AS 'S.Y', `StartDate` AS 'Start Date', `EndDate` AS 'End Date'" _
               & " FROM `practicum`"
        reloadDgv(query, dgvPracticumRecord)
        txtSearch.Show()
        txtSearchAtt.Hide()
        cmbAtt.Hide()
        cmbFilter.Show()
    End Sub

    Private Sub frmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSearch.Hide()
        cmbFilter.Hide()
        daily()
        dgvPracticumRecord.RowTemplate.Height = 25
        dgvPracticumRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvPracticumRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPracticumRecord.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If cmbFilter.Text = "NAME" Then
            query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                & " AS 'Full Name', `Course`, `Venue`, `Assignment`, `Batch`,  `SchoolYear` AS 'S.Y', " _
                & " `StartDate` AS 'Start Date', `EndDate` AS 'End Date' FROM `practicum`" _
                & " WHERE CONCAT(`LastName`,', ', `FirstName`) LIKE '%" & txtSearch.Text & "%'"
            reloadDgv(query, dgvPracticumRecord)
        ElseIf cmbFilter.Text = "PRACTICUM ID" Then
            query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                & " AS 'Full Name', `Course`, `Venue`, `Assignment`, `Batch`,  `SchoolYear` AS 'S.Y', " _
                & " `StartDate` AS 'Start Date', `EndDate` AS 'End Date' FROM `practicum`" _
                & " WHERE PracticumID LIKE '%" & txtSearch.Text & "%'"
            reloadDgv(query, dgvPracticumRecord)
        ElseIf cmbFilter.Text = "COURSE" Then
            query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
              & " AS 'Full Name', `Course`, `Venue`, `Assignment`, `Batch`,  `SchoolYear` AS 'S.Y', " _
              & " `StartDate` AS 'Start Date', `EndDate` AS 'End Date' FROM `practicum`" _
              & " WHERE Course LIKE '%" & txtSearch.Text & "%'"
            reloadDgv(query, dgvPracticumRecord)
        ElseIf cmbFilter.Text = "VENUE" Then
            query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
              & " AS 'Full Name', `Course`, `Venue`, `Assignment`, `Batch`,  `SchoolYear` AS 'S.Y', " _
              & " `StartDate` AS 'Start Date', `EndDate` AS 'End Date' FROM `practicum`" _
              & " WHERE Venue LIKE '%" & txtSearch.Text & "%'"
            reloadDgv(query, dgvPracticumRecord)
        ElseIf cmbFilter.Text = "ASSIGNMENT" Then
            query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
              & " AS 'Full Name', `Course`, `Venue`, `Assignment`, `Batch`,  `SchoolYear` AS 'S.Y', " _
              & " `StartDate` AS 'Start Date', `EndDate` AS 'End Date' FROM `practicum`" _
              & " WHERE Assignment LIKE '%" & txtSearch.Text & "%'"
            reloadDgv(query, dgvPracticumRecord)
        ElseIf cmbFilter.Text = "BATCH" Then
            query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
              & " AS 'Full Name', `Course`, `Venue`, `Assignment`, `Batch`,  `SchoolYear` AS 'S.Y', " _
              & " `StartDate` AS 'Start Date', `EndDate` AS 'End Date' FROM `practicum`" _
              & " WHERE Batch LIKE '%" & txtSearch.Text & "%'"
            reloadDgv(query, dgvPracticumRecord)
        End If
    End Sub

    Private Sub btnDaily_Click(sender As Object, e As EventArgs) Handles btnDaily.Click
        daily()
        txtSearch.Hide()
        cmbFilter.Hide()
        txtSearchAtt.Show()
        cmbAtt.Show()
    End Sub
    Public Sub daily()
        query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                   & " AS 'Full Name', `Date`, `TimeLogIn_AM` AS 'AM Time In', `TimeLogOut_AM` AS 'AM Time Out', " _
                   & " `AM_Status` AS 'AM Status',`TimeLogIn_PM` AS 'PM Time In', `TimeLogOut_PM` AS 'PM Time Out'," _
                   & " `PM_Status` AS 'PM Status' FROM `attendance` WHERE `Date` = curdate()"
        reloadDgv(query, dgvPracticumRecord)
        txtSearch.Hide()
        cmbFilter.Hide()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        ' sets it to show '...' for long text
        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        fmt.LineAlignment = StringAlignment.Center
        fmt.Trimming = StringTrimming.EllipsisCharacter
        Dim y As Int32 = e.MarginBounds.Top
        Dim rc As Rectangle
        Dim x As Int32
        Dim h As Int32 = 0
        Dim row As DataGridViewRow


        ' print the header text for a new page
        ' use a grey bg just like the control
        If newpage Then
            row = dgvPracticumRecord.Rows(mRow)
            x = e.MarginBounds.Left
            For Each cell As DataGridViewCell In row.Cells
                ' since we are printing the control's view,
                ' skip invisible columns
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)

                    e.Graphics.FillRectangle(Brushes.LightGray, rc)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    ' reuse in data print - should be a function
                    Select Case dgvPracticumRecord.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                             DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                            DataGridViewContentAlignment.MiddleCenter
                            fmt.Alignment = StringAlignment.Center
                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)
                    End Select

                    e.Graphics.DrawString(dgvPracticumRecord.Columns(cell.ColumnIndex).HeaderText, dgvPracticumRecord.Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h

        End If
        newpage = False

        ' now print the data for each row
        Dim thisNDX As Int32
        For thisNDX = mRow To dgvPracticumRecord.RowCount - 1
            ' no need to try to print the new row
            If dgvPracticumRecord.Rows(thisNDX).IsNewRow Then Exit For

            row = dgvPracticumRecord.Rows(thisNDX)
            x = e.MarginBounds.Left
            h = 0

            ' reset X for data
            x = e.MarginBounds.Left

            ' print the data
            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    Select Case dgvPracticumRecord.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                             DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                            DataGridViewContentAlignment.MiddleCenter
                            fmt.Alignment = StringAlignment.Center
                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)
                    End Select

                    e.Graphics.DrawString(cell.FormattedValue.ToString(),
                                          dgvPracticumRecord.Font, Brushes.Black, rc, fmt)

                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If

            Next
            y += h
            ' next row to print
            mRow = thisNDX + 1

            If y + h > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                ' mRow -= 1   causes last row to rePrint on next page
                newpage = True
                Return
            End If
        Next
    End Sub
    Private Sub btnPrintdgv_Click(sender As Object, e As EventArgs) Handles btnPrintdgv.Click
        mRow = 0
        newpage = True
        Dim xCustomSize As New PaperSize("Legal", 850, 1600)
        PrintDocument1.DefaultPageSettings.PaperSize = xCustomSize
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.PrintPreviewControl.StartPage = 0
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1.0
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub txtSearchAtt_TextChanged(sender As Object, e As EventArgs) Handles txtSearchAtt.TextChanged
        If cmbAtt.Text = "NAME" And btnDaily.Visible = True Then
            query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                & " AS 'Full Name', `Date`, `TimeLogIn_AM` AS 'AM Time In', `TimeLogOut_AM` AS 'AM Time Out', " _
                & " `AM_Status` AS 'AM Status',`TimeLogIn_PM` AS 'PM Time In', `TimeLogOut_PM` AS 'PM Time Out'," _
                & " `PM_Status` AS 'PM Status' FROM `attendance` WHERE `Date` = curdate() AND" _
                & " CONCAT(`LastName`,', ', `FirstName`) LIKE '%" & txtSearchAtt.Text & "%'"
            reloadDgv(query, dgvPracticumRecord)
        ElseIf cmbAtt.Text = "NAME" And btnWeekly.Visible = True Then
            query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                & " AS 'Full Name', `Date`, `TimeLogIn_AM` AS 'AM Time In', `TimeLogOut_AM` AS 'AM Time Out', " _
                & " `AM_Status` AS 'AM Status',`TimeLogIn_PM` AS 'PM Time In', `TimeLogOut_PM` AS 'PM Time Out'," _
                & " `PM_Status` AS 'PM Status' FROM `attendance` WHERE YEARWEEK(Date) = YEARWEEK(NOW() - INTERVAL 1 WEEK)" _
                & " AND CONCAT(`LastName`,', ', `FirstName`) LIKE '%" & txtSearchAtt.Text & "%'"
            reloadDgv(query, dgvPracticumRecord)
        ElseIf cmbAtt.Text = "NAME" And btnMonthly.Visible = True Then
            query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                & " AS 'Full Name', `Date`, `TimeLogIn_AM` AS 'AM Time In', `TimeLogOut_AM` AS 'AM Time Out', " _
                & " `AM_Status` AS 'AM Status',`TimeLogIn_PM` AS 'PM Time In', `TimeLogOut_PM` AS 'PM Time Out'," _
                & " `PM_Status` AS 'PM Status' FROM `attendance` WHERE EXTRACT(MONTH FROM `Date`)" _
                & " = EXTRACT(MONTH FROM CURRENT_DATE) AND EXTRACT(YEAR FROM `Date`) = EXTRACT(YEAR FROM CURRENT_DATE)" _
                & " AND CONCAT(`LastName`,', ', `FirstName`) LIKE '%" & txtSearchAtt.Text & "%'"
            reloadDgv(query, dgvPracticumRecord)
        ElseIf cmbAtt.Text = "NAME" And btnAllLogs.Visible = True Then
            query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                & " AS 'Full Name', `Date`, `TimeLogIn_AM` AS 'AM Time In', `TimeLogOut_AM` AS 'AM Time Out', " _
                & " `AM_Status` AS 'AM Status',`TimeLogIn_PM` AS 'PM Time In', `TimeLogOut_PM` AS 'PM Time Out'," _
                & " `PM_Status` AS 'PM Status' FROM `attendance` WHERE CONCAT(`LastName`,', ', `FirstName`)" _
                & " LIKE '%" & txtSearchAtt.Text & "%'"
            reloadDgv(query, dgvPracticumRecord)
        End If
    End Sub

    Private Sub btnWeekly_Click(sender As Object, e As EventArgs) Handles btnWeekly.Click
        query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
           & " AS 'Full Name', `Date`, `TimeLogIn_AM` AS 'AM Time In', `TimeLogOut_AM` AS 'AM Time Out', " _
           & " `AM_Status` AS 'AM Status',`TimeLogIn_PM` AS 'PM Time In', `TimeLogOut_PM` AS 'PM Time Out'," _
           & " `PM_Status` AS 'PM Status' FROM `attendance` WHERE YEARWEEK(Date) = YEARWEEK(NOW() - INTERVAL 1 WEEK)"
        reloadDgv(query, dgvPracticumRecord)
        txtSearch.Hide()
        cmbFilter.Hide()
        txtSearchAtt.Show()
        cmbAtt.Show()
    End Sub

    Private Sub btnMonthly_Click(sender As Object, e As EventArgs) Handles btnMonthly.Click
        query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
         & " AS 'Full Name', `Date`, `TimeLogIn_AM` AS 'AM Time In', `TimeLogOut_AM` AS 'AM Time Out', " _
         & " `AM_Status` AS 'AM Status',`TimeLogIn_PM` AS 'PM Time In', `TimeLogOut_PM` AS 'PM Time Out'," _
         & " `PM_Status` AS 'PM Status' FROM `attendance` WHERE EXTRACT(MONTH FROM `Date`) = EXTRACT(MONTH FROM CURRENT_DATE) AND EXTRACT(YEAR FROM `Date`) = EXTRACT(YEAR FROM CURRENT_DATE)"
        reloadDgv(query, dgvPracticumRecord)
        txtSearch.Hide()
        cmbFilter.Hide()
        txtSearchAtt.Show()
        cmbAtt.Show()
    End Sub

    Private Sub btnAllLogs_Click(sender As Object, e As EventArgs) Handles btnAllLogs.Click
        query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
         & " AS 'Full Name', `Date`, `TimeLogIn_AM` AS 'AM Time In', `TimeLogOut_AM` AS 'AM Time Out', " _
         & " `AM_Status` AS 'AM Status',`TimeLogIn_PM` AS 'PM Time In', `TimeLogOut_PM` AS 'PM Time Out'," _
         & " `PM_Status` AS 'PM Status' FROM `attendance`"
        reloadDgv(query, dgvPracticumRecord)
        txtSearch.Hide()
        cmbFilter.Hide()
        txtSearchAtt.Show()
        cmbAtt.Show()
    End Sub
End Class