Imports System.Drawing.Printing

Public Class frmRecords
    Private mRow As Integer = 0
    Private newpage As Boolean = True
    Dim g, mg As Graphics
    Dim bmp As Bitmap
    Private Sub frmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlPracticums.Hide()
        txtSearch.Hide()
        cmbFilter.Hide()
        lblSearchBy.Hide()
        txtProfileSearch.Hide()
        daily()
        dgvPracticumRecord.RowTemplate.Height = 25
        dgvPracticumRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvPracticumRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPracticumRecord.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub
    Public Sub daily()
        query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                   & " AS 'Full Name', `Date`, `TimeLogIn_AM` AS 'AM Time In', `TimeLogOut_AM` AS 'AM Time Out', " _
                   & " `TimeLogIn_PM` AS 'PM Time In', `TimeLogOut_PM` AS 'PM Time Out'" _
                   & " FROM `attendance` WHERE `Date` = curdate()"
        reloadDgv(query, dgvPracticumRecord)
    End Sub
    Private Sub btnDaily_Click(sender As Object, e As EventArgs) Handles btnDaily.Click
        daily()
        lblSearchBy.Hide()
        cmbFilter.Hide()
        txtSearch.Hide()
        pnlPracticums.Hide()
        txtProfileSearch.Hide()
        lblSB.Show()
        txtSearchAtt.Show()
        dgvPracticumRecord.Show()
        lblTitle.Text = "DAILY"
    End Sub
    Private Sub btnWeekly_Click(sender As Object, e As EventArgs) Handles btnWeekly.Click
        query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
           & " AS 'Full Name', `Date`, `TimeLogIn_AM` AS 'AM Time In', `TimeLogOut_AM` AS 'AM Time Out', " _
           & " `TimeLogIn_PM` AS 'PM Time In', `TimeLogOut_PM` AS 'PM Time Out'" _
           & " FROM `attendance` WHERE YEARWEEK(Date) = YEARWEEK(NOW() - INTERVAL 1 WEEK)"
        reloadDgv(query, dgvPracticumRecord)
        lblSearchBy.Hide()
        cmbFilter.Hide()
        txtSearch.Hide()
        pnlPracticums.Hide()
        txtProfileSearch.Hide()
        lblSB.Show()
        txtSearchAtt.Show()
        dgvPracticumRecord.Show()
        lblTitle.Text = "WEEKLY"
    End Sub
    Private Sub btnMonthly_Click(sender As Object, e As EventArgs) Handles btnMonthly.Click
        query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
         & " AS 'Full Name', `Date`, `TimeLogIn_AM` AS 'AM Time In', `TimeLogOut_AM` AS 'AM Time Out', " _
         & " `TimeLogIn_PM` AS 'PM Time In', `TimeLogOut_PM` AS 'PM Time Out' FROM `attendance`" _
         & " WHERE EXTRACT(MONTH FROM `Date`) = EXTRACT(MONTH FROM CURRENT_DATE) " _
         & " AND EXTRACT(YEAR FROM `Date`) = EXTRACT(YEAR FROM CURRENT_DATE)"
        reloadDgv(query, dgvPracticumRecord)
        lblSearchBy.Hide()
        cmbFilter.Hide()
        txtSearch.Hide()
        pnlPracticums.Hide()
        txtProfileSearch.Hide()
        lblSB.Show()
        txtSearchAtt.Show()
        dgvPracticumRecord.Show()
        lblTitle.Text = "MONTHLY"
    End Sub
    Private Sub btnAllLogs_Click(sender As Object, e As EventArgs) Handles btnAllLogs.Click
        Try
            query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
             & " AS 'Full Name', `Date`, `TimeLogIn_AM` AS 'AM Time In', `TimeLogOut_AM` AS 'AM Time Out', " _
             & " `TimeLogIn_PM` AS 'PM Time In', `TimeLogOut_PM` AS 'PM Time Out' FROM `attendance`"
            reloadDgv(query, dgvPracticumRecord)
            lblSearchBy.Hide()
            cmbFilter.Hide()
            txtSearch.Hide()
            pnlPracticums.Hide()
            txtProfileSearch.Hide()
            lblSB.Show()
            txtSearchAtt.Show()
            dgvPracticumRecord.Show()
            lblTitle.Text = "ALL LOGS"
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txtSearchAtt_TextChanged(sender As Object, e As EventArgs) Handles txtSearchAtt.TextChanged
        If lblTitle.Text = "DAILY" OrElse lblTitle.Text = "RECORDS" Then
            query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                & " AS 'Full Name', `Date`, `TimeLogIn_AM` AS 'AM Time In', `TimeLogOut_AM` AS 'AM Time Out', " _
                & " `TimeLogIn_PM` AS 'PM Time In', `TimeLogOut_PM` AS 'PM Time Out'" _
                & "  FROM `attendance` WHERE `Date` = curdate() AND `PracticumID` LIKE '%" & txtSearchAtt.Text & "%'"
            reloadDgv(query, dgvPracticumRecord)
        ElseIf lblTitle.Text = "WEEKLY" Then
            query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                & " AS 'Full Name', `Date`, `TimeLogIn_AM` AS 'AM Time In', `TimeLogOut_AM` AS 'AM Time Out', " _
                & " `TimeLogIn_PM` AS 'PM Time In', `TimeLogOut_PM` AS 'PM Time Out'" _
                & " FROM `attendance` WHERE YEARWEEK(Date) = YEARWEEK(NOW() - INTERVAL 1 WEEK)" _
                & " AND `PracticumID` LIKE '%" & txtSearchAtt.Text & "%'"
            reloadDgv(query, dgvPracticumRecord)
        ElseIf lblTitle.Text = "MONTHLY" Then
            query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                & " AS 'Full Name', `Date`, `TimeLogIn_AM` AS 'AM Time In', `TimeLogOut_AM` AS 'AM Time Out', " _
                & " `TimeLogIn_PM` AS 'PM Time In', `TimeLogOut_PM` AS 'PM Time Out' FROM `attendance`" _
                & " WHERE EXTRACT(MONTH FROM `Date`) = EXTRACT(MONTH FROM CURRENT_DATE) " _
                & " AND EXTRACT(YEAR FROM `Date`) = EXTRACT(YEAR FROM CURRENT_DATE)" _
                & " AND `PracticumID` LIKE '%" & txtSearchAtt.Text & "%'"
            reloadDgv(query, dgvPracticumRecord)
        ElseIf lblTitle.Text = "ALL LOGS" Then
            query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                & " AS 'Full Name', `Date`, `TimeLogIn_AM` AS 'AM Time In', `TimeLogOut_AM` AS 'AM Time Out', " _
                & " `TimeLogIn_PM` AS 'PM Time In', `TimeLogOut_PM` AS 'PM Time Out' FROM `attendance`" _
                & " WHERE `PracticumID` LIKE '%" & txtSearchAtt.Text & "%'"
            reloadDgv(query, dgvPracticumRecord)
        End If
    End Sub
    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        dgvPersonalRecord.RowTemplate.Height = 25
        dgvPersonalRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvPersonalRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPersonalRecord.AlternatingRowsDefaultCellStyle.BackColor = Color.White
        pnlPracticums.Show()
        txtProfileSearch.Show()
        lblSearchBy.Hide()
        cmbFilter.Hide()
        txtSearch.Hide()
        lblSB.Show()
        txtSearchAtt.Hide()
        dgvPracticumRecord.Hide()
        lblTitle.Text = "PROFILE"
    End Sub
    Private Sub txtProfileSearch_TextChanged(sender As Object, e As EventArgs) Handles txtProfileSearch.TextChanged
        Try
            query = "SELECT * FROM `practicum` WHERE `PracticumID`='" & txtProfileSearch.Text & "'"
            reloadtxt(query)

            If dt.Rows.Count > 0 Then
                lblPracticumID.Text = dt.Rows(0).Item("PracticumID")
                lblLastName.Text = dt.Rows(0).Item("LastName")
                lblFirstName.Text = dt.Rows(0).Item("FirstName")
                lblCourse.Text = dt.Rows(0).Item("Course")
                lblVenue.Text = dt.Rows(0).Item("Venue")
                lblAssignment.Text = dt.Rows(0).Item("Assignment")
                lblBatch.Text = dt.Rows(0).Item("Batch")
                lblSY.Text = dt.Rows(0).Item("SchoolYear")
                lblStartDate.Text = dt.Rows(0).Item("StartDate")
                lblEndDate.Text = dt.Rows(0).Item("EndDate")
            Else
                lblPracticumID.Text = Nothing
                lblLastName.Text = Nothing
                lblFirstName.Text = Nothing
                lblCourse.Text = Nothing
                lblVenue.Text = Nothing
                lblAssignment.Text = Nothing
                lblBatch.Text = Nothing
                lblSY.Text = Nothing
                lblStartDate.Text = Nothing
                lblEndDate.Text = Nothing
            End If
            query = "SELECT `Date`, `TimeLogIn_AM` AS 'AM Time In', `TimeLogOut_AM` AS 'AM Time Out', " _
         & " `TimeLogIn_PM` AS 'PM Time In', `TimeLogOut_PM` AS 'PM Time Out' FROM `attendance`" _
         & " WHERE `PracticumID`='" & txtProfileSearch.Text & "'"
            reloadDgv(query, dgvPersonalRecord)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click
        Try
            lblSearchBy.Show()
            cmbFilter.Show()
            txtSearch.Show()
            pnlPracticums.Hide()
            lblSB.Hide()
            txtSearchAtt.Hide()
            txtProfileSearch.Hide()
            dgvPracticumRecord.Show()
            lblTitle.Text = "PRACTICUM LIST"
            query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                   & " AS 'Full Name', `Course`, `Venue`, `Assignment`, `TotalHours` AS 'Total Hours'," _
                   & " `Batch`, `SchoolYear` AS 'S.Y', `StartDate` AS 'Start Date', `EndDate` AS 'End Date'" _
                   & " FROM `practicum`"
            reloadDgv(query, dgvPracticumRecord)
        Catch ex As Exception
        End Try
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
    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        fmt.LineAlignment = StringAlignment.Center
        fmt.Trimming = StringTrimming.EllipsisCharacter
        Dim y As Int32 = e.MarginBounds.Top
        Dim rc As Rectangle
        Dim x As Int32
        Dim h As Int32 = 0
        Dim row As DataGridViewRow

        If newpage Then
            row = dgvPracticumRecord.Rows(mRow)
            x = e.MarginBounds.Left
            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)

                    e.Graphics.FillRectangle(Brushes.LightGray, rc)
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

                    e.Graphics.DrawString(dgvPracticumRecord.Columns(cell.ColumnIndex).HeaderText, dgvPracticumRecord.Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h

        End If
        newpage = False

        Dim thisNDX As Int32
        For thisNDX = mRow To dgvPracticumRecord.RowCount - 1

            If dgvPracticumRecord.Rows(thisNDX).IsNewRow Then Exit For

            row = dgvPracticumRecord.Rows(thisNDX)
            x = e.MarginBounds.Left
            h = 0

            x = e.MarginBounds.Left

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
            mRow = thisNDX + 1

            If y + h > e.MarginBounds.Bottom Then
                e.HasMorePages = True
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

    Private Sub txtProfileSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProfileSearch.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSearchAtt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchAtt.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
End Class