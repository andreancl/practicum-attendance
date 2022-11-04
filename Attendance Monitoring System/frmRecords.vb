Imports System.Drawing.Printing

Public Class frmRecords
    Private mRow As Integer = 0
    Private newpage As Boolean = True
    Dim g, mg As Graphics
    Dim bmp As Bitmap

    Private Sub frmRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Logs()
        pnlDateFilter.Show()
        btnPrintRecord.Show()
        pnlPracticums.Hide()
        pnlProfileSearch.Hide()
        pnlSearchList.Hide()
        btnPrintProfile.Hide()
        clearcontrol(pnlDateFilter)
    End Sub
    Private Sub btnAllLogs_Click(sender As Object, e As EventArgs) Handles btnAllLogs.Click
        load_Logs()
        pnlDateFilter.Show()
        btnPrintRecord.Show()
        pnlPracticums.Hide()
        pnlProfileSearch.Hide()
        pnlSearchList.Hide()
        btnPrintProfile.Hide()
        clearcontrol(pnlDateFilter)
        lblTitle.Text = "ALL LOGS"
    End Sub
    Public Sub load_Logs()
        dgvPracticumRecord.RowTemplate.Height = 25
        dgvPracticumRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvPracticumRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPracticumRecord.AlternatingRowsDefaultCellStyle.BackColor = Color.White
        Try
            query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                & " AS 'Full Name', `Date`, TIME_FORMAT(`TimeLogIn_AM`, '%r') AS 'AM Time In'" _
                & ", TIME_FORMAT(`TimeLogOut_AM`, '%r') AS 'AM Time Out'" _
                & ", TIME_FORMAT(`TimeLogIn_PM`, '%r') AS 'PM Time In'" _
                & ", TIME_FORMAT(`TimeLogOut_PM`, '%r') AS 'PM Time Out'" _
                & ", `TotalHours` AS 'Total Hours' FROM `attendance`"
            reloadDgv(query, dgvPracticumRecord)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                & " AS 'Full Name', `Date`, TIME_FORMAT(`TimeLogIn_AM`, '%r') AS 'AM Time In'" _
                & ", TIME_FORMAT(`TimeLogOut_AM`, '%r') AS 'AM Time Out'" _
                & ", TIME_FORMAT(`TimeLogIn_PM`, '%r') AS 'PM Time In'" _
                & ", TIME_FORMAT(`TimeLogOut_PM`, '%r') AS 'PM Time Out',  `TotalHours` AS 'Total Hours'" _
                & " FROM `attendance` WHERE `Date` BETWEEN '" & dtpFROM.Text & "' AND '" & dtpTO.Text & "'"
            reloadDgv(query, dgvPracticumRecord)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub
    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        dgvPersonalRecord.RowTemplate.Height = 25
        dgvPersonalRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvPersonalRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPersonalRecord.AlternatingRowsDefaultCellStyle.BackColor = Color.White
        pnlPracticums.Show()
        pnlProfileSearch.Show()
        btnPrintProfile.Show()
        btnPrintRecord.Hide()
        pnlDateFilter.Hide()
        pnlSearchList.Hide()
        lblTitle.Text = "PRACTICUM PROFILE"
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
                lblTotalHours.Text = dt.Rows(0).Item("TotalHour")
                Dim lb() As Byte = dt.Rows(0).Item("img")
                Dim lstr As New System.IO.MemoryStream(lb)
                pbProfile.Image = Image.FromStream(lstr)
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
                lblTotalHours.Text = Nothing
                pbProfile.Image = Nothing
            End If
            query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                & " AS 'Full Name', `Date`, TIME_FORMAT(`TimeLogIn_AM`, '%r') AS 'AM Time In'" _
               & ", TIME_FORMAT(`TimeLogOut_AM`, '%r') AS 'AM Time Out'" _
               & ", TIME_FORMAT(`TimeLogIn_PM`, '%r') AS 'PM Time In'" _
               & ", TIME_FORMAT(`TimeLogOut_PM`, '%r') AS 'PM Time Out'" _
               & ", `TotalHours` AS 'Total Hours'" _
               & " FROM `attendance` WHERE `PracticumID`='" & txtProfileSearch.Text & "'"
            reloadDgv(query, dgvPersonalRecord)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub
    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click
        dgvPracticumRecord.RowTemplate.Height = 25
        dgvPracticumRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvPracticumRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPracticumRecord.AlternatingRowsDefaultCellStyle.BackColor = Color.White
        btnPrintProfile.Hide()
        pnlDateFilter.Hide()
        pnlProfileSearch.Hide()
        pnlPracticums.Hide()
        btnPrintRecord.Show()
        pnlSearchList.Show()
        lblTitle.Text = "PRACTICUM LIST"
        Try
            query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                & " AS 'Full Name', `Course`, `Venue`, `Assignment`, `TotalHour` AS 'Total Hours'," _
                & " `Batch`,  `SchoolYear` AS 'S.Y', `StartDate` AS 'Start Date', " _
                & " `EndDate` AS 'End Date' FROM `practicum`"
            reloadDgv(query, dgvPracticumRecord)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If cmbFilter.Text = "PRACTICUM ID" Then
                query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                    & " AS 'Full Name', `Course`, `Venue`, `Assignment`, `TotalHour` AS 'Total Hours'," _
                    & " `Batch`,  `SchoolYear` AS 'S.Y', `StartDate` AS 'Start Date', " _
                    & " `EndDate` AS 'End Date' FROM `practicum`" _
                    & " WHERE PracticumID LIKE '%" & txtSearch.Text & "%'"
                reloadDgv(query, dgvPracticumRecord)
            ElseIf cmbFilter.Text = "NAME" Then
                query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                     & " AS 'Full Name', `Course`, `Venue`, `Assignment`, `TotalHour` AS 'Total Hours'," _
                     & " `Batch`,  `SchoolYear` AS 'S.Y', `StartDate` AS 'Start Date', " _
                     & " `EndDate` AS 'End Date' FROM `practicum`" _
                     & " WHERE CONCAT(`LastName`,', ', `FirstName`) LIKE '%" & txtSearch.Text & "%'"
                reloadDgv(query, dgvPracticumRecord)
            ElseIf cmbFilter.Text = "COURSE" Then
                query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                    & " AS 'Full Name', `Course`, `Venue`, `Assignment`, `TotalHour` AS 'Total Hours'," _
                    & " `Batch`,  `SchoolYear` AS 'S.Y', `StartDate` AS 'Start Date', " _
                    & " `EndDate` AS 'End Date' FROM `practicum`" _
                    & " WHERE Course LIKE '%" & txtSearch.Text & "%'"
                reloadDgv(query, dgvPracticumRecord)
            ElseIf cmbFilter.Text = "VENUE" Then
                query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                    & " AS 'Full Name', `Course`, `Venue`, `Assignment`, `TotalHour` AS 'Total Hours'," _
                    & " `Batch`,  `SchoolYear` AS 'S.Y', `StartDate` AS 'Start Date', " _
                    & " `EndDate` AS 'End Date' FROM `practicum`" _
                    & " WHERE Venue LIKE '%" & txtSearch.Text & "%'"
                reloadDgv(query, dgvPracticumRecord)
            ElseIf cmbFilter.Text = "ASSIGNMENT" Then
                query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                    & " AS 'Full Name', `Course`, `Venue`, `Assignment`, `TotalHour` AS 'Total Hours'," _
                    & " `Batch`,  `SchoolYear` AS 'S.Y', `StartDate` AS 'Start Date', " _
                    & " `EndDate` AS 'End Date' FROM `practicum`" _
                    & " WHERE Assignment LIKE '%" & txtSearch.Text & "%'"
                reloadDgv(query, dgvPracticumRecord)
            ElseIf cmbFilter.Text = "BATCH" Then
                query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                    & " AS 'Full Name', `Course`, `Venue`, `Assignment`, `TotalHour` AS 'Total Hours'," _
                    & " `Batch`,  `SchoolYear` AS 'S.Y', `StartDate` AS 'Start Date', " _
                    & " `EndDate` AS 'End Date' FROM `practicum`" _
                    & " WHERE Batch LIKE '%" & txtSearch.Text & "%'"
                reloadDgv(query, dgvPracticumRecord)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
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
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub
    Private Sub txtProfileSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProfileSearch.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnPrintRecord_Click(sender As Object, e As EventArgs) Handles btnPrintRecord.Click
        Try
            mRow = 0
            newpage = True
            Dim xCustomSize As New PaperSize("Legal", 850, 1600)
            PrintDocument1.DefaultPageSettings.PaperSize = xCustomSize
            PrintDocument1.DefaultPageSettings.Landscape = True
            PrintPreviewDialog1.PrintPreviewControl.StartPage = 0
            PrintPreviewDialog1.PrintPreviewControl.Zoom = 1.0
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub

    Private Sub btnPrintProfile_Click(sender As Object, e As EventArgs) Handles btnPrintProfile.Click
        Try
            mRow = 0
            newpage = True
            Dim xCustomSize As New PaperSize("Legal", 850, 1600)
            PrintDocument2.DefaultPageSettings.PaperSize = xCustomSize
            PrintDocument2.DefaultPageSettings.Landscape = True
            PrintPreviewDialog2.PrintPreviewControl.StartPage = 0
            PrintPreviewDialog2.PrintPreviewControl.Zoom = 1.0
            PrintPreviewDialog2.Document = PrintDocument2
            PrintPreviewDialog2.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub

    Private Sub PrintDocument2_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Try
            Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
            fmt.LineAlignment = StringAlignment.Center
            fmt.Trimming = StringTrimming.EllipsisCharacter
            Dim y As Int32 = e.MarginBounds.Top
            Dim rc As Rectangle
            Dim x As Int32
            Dim h As Int32 = 0
            Dim row As DataGridViewRow

            If newpage Then
                row = dgvPersonalRecord.Rows(mRow)
                x = e.MarginBounds.Left
                For Each cell As DataGridViewCell In row.Cells
                    If cell.Visible Then
                        rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)

                        e.Graphics.FillRectangle(Brushes.LightGray, rc)
                        e.Graphics.DrawRectangle(Pens.Black, rc)

                        Select Case dgvPersonalRecord.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
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

                        e.Graphics.DrawString(dgvPersonalRecord.Columns(cell.ColumnIndex).HeaderText, dgvPersonalRecord.Font, Brushes.Black, rc, fmt)
                        x += rc.Width
                        h = Math.Max(h, rc.Height)
                    End If
                Next
                y += h

            End If
            newpage = False

            Dim thisNDX As Int32
            For thisNDX = mRow To dgvPersonalRecord.RowCount - 1

                If dgvPersonalRecord.Rows(thisNDX).IsNewRow Then Exit For

                row = dgvPersonalRecord.Rows(thisNDX)
                x = e.MarginBounds.Left
                h = 0

                x = e.MarginBounds.Left

                For Each cell As DataGridViewCell In row.Cells
                    If cell.Visible Then
                        rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                        e.Graphics.DrawRectangle(Pens.Black, rc)

                        Select Case dgvPersonalRecord.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
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
                                              dgvPersonalRecord.Font, Brushes.Black, rc, fmt)

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
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub
End Class