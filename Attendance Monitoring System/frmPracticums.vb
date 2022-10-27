Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.IO

Public Class frmPracticums
    Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
    Public con As MySqlConnection = mysqldb()
    Private mRow As Integer = 0
    Private newpage As Boolean = True
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim FileSize As UInt32
    Dim mstream As New System.IO.MemoryStream()

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtPracticumID.Text = "" And txtLastName.Text = "" And txtFirstName.Text = "" And cmbCourse.Text = "" _
        And cmbVenue.Text = "" And cmbAssignment.Text = "" And cmbBatch.Text = "" Then
            MsgBox("Fill up the registration details", MsgBoxStyle.Critical, "ATTENTION!")
            txtPracticumID.Focus()
        ElseIf txtPracticumID.Text = "" Then
            MsgBox("No Practicum ID Found!", MsgBoxStyle.Critical, "Error")
            txtPracticumID.Focus()
        ElseIf txtLastName.Text = "" Then
            MsgBox("No Last Name Found!", MsgBoxStyle.Critical, "Error")
            txtLastName.Focus()
        ElseIf txtFirstName.Text = "" Then
            MsgBox("No First Name Found!", MsgBoxStyle.Critical, "Error")
            txtFirstName.Focus()
        ElseIf cmbCourse.Text = "" Then
            MsgBox("Please Select Course", MsgBoxStyle.Critical, "Error")
            cmbCourse.Focus()
        ElseIf cmbVenue.Text = "" Then
            MsgBox("Please Select Venue", MsgBoxStyle.Critical, "Error")
            cmbVenue.Focus()
        ElseIf cmbAssignment.Text = "" Then
            MsgBox("Please Select Assignment", MsgBoxStyle.Critical, "Error")
            cmbAssignment.Focus()
        ElseIf cmbBatch.Text = "" Then
            MsgBox("Please Select Batch", MsgBoxStyle.Critical, "Error")
            cmbBatch.Focus()
        ElseIf cmbSY.Text = "" Then
            MsgBox("Please Select School Year", MsgBoxStyle.Critical, "Error")
            cmbSY.Focus()
        ElseIf pbProfile.Image Is Nothing Then
            MsgBox("Please Insert Image ", MsgBoxStyle.Critical, "Error")
            pbProfile.Focus()
        Else
            CheckingID()
        End If
    End Sub
    Private Sub CheckingID()
        Try
            con.Open()
            query = "SELECT PracticumID FROM practicum WHERE PracticumID = '" & txtPracticumID.Text & "'"
            cmd = New MySqlCommand(query, con)
            dr = cmd.ExecuteReader()
            Dim count As Integer
            count = 0
            While dr.Read
                count = count + 1
            End While
            Select Case count
                Case 1
                    MsgBox("Practicum has already registered!", MsgBoxStyle.Critical, "ATTENTION")
                Case Else
                    con.Close()
                    RegMember()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace)
        Finally
            dr.Close()
            con.Close()
        End Try
    End Sub
    Private Sub RegMember()
        pbProfile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        FileSize = mstream.Length
        mstream.Close()
        Try
            query = "INSERT INTO `practicum` (`PracticumID`, `LastName`, `FirstName`, `Course`" _
                & ", `Venue`, `Assignment`, `Batch`, `SchoolYear`, `StartDate`, `EndDate`, `img`, `filesize`) " _
                & " VALUES (@PracticumID, @LastName, @FirstName, @Course, @Venue, @Assignment, @Batch" _
                & ", @SchoolYear, @StartDate, @EndDate, @img, @filesize)"
            With cmd
                .Parameters.AddWithValue("@PracticumID", txtPracticumID.Text)
                .Parameters.AddWithValue("@LastName", txtLastName.Text)
                .Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                .Parameters.AddWithValue("@Course", cmbCourse.Text)
                .Parameters.AddWithValue("@Venue", cmbVenue.Text)
                .Parameters.AddWithValue("@Assignment", cmbAssignment.Text)
                .Parameters.AddWithValue("@Batch", cmbBatch.Text)
                .Parameters.AddWithValue("@SchoolYear", cmbSY.Text)
                .Parameters.AddWithValue("@StartDate", dtpStart.Text)
                .Parameters.AddWithValue("@EndDate", dtpEnd.Text)
                .Parameters.AddWithValue("@filesize", FileSize)
                .Parameters.AddWithValue("@img", arrImage)
            End With
            create(query)
            load_PracticumInfo()
            clearcontrol(gbPracticums)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub load_PracticumInfo()
        query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                & " AS 'Full Name', `Course`, `Venue`, `Assignment`, `Batch`,  `SchoolYear` AS 'S.Y', " _
                & " `StartDate` AS 'Start Date', `EndDate` AS 'End Date' FROM `practicum`"
        reloadDgv(query, dgvPracticumRecord)
    End Sub

    Private Sub frmPracticums_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_PracticumInfo()
        dgvPracticumRecord.RowTemplate.Height = 25
        dgvPracticumRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvPracticumRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPracticumRecord.AlternatingRowsDefaultCellStyle.BackColor = Color.White
        clearcontrol(gbPracticums)
    End Sub

    Private Sub txtPracticumID_TextChanged(sender As Object, e As EventArgs) Handles txtPracticumID.TextChanged
        Generator.BackColor = Color.White
        Generator.LabelFont = New Font("Arial", 7, FontStyle.Regular)
        Generator.IncludeLabel = True
        Generator.CustomLabel = txtPracticumID.Text

        Try
            pbQR.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code93, txtPracticumID.Text))

            query = "SELECT * FROM `practicum` WHERE `PracticumID`='" & txtPracticumID.Text & "'"
            reloadtxt(query)

            If dt.Rows.Count > 0 Then
                txtPracticumID.Text = dt.Rows(0).Item("PracticumID")
                txtLastName.Text = dt.Rows(0).Item("LastName")
                txtFirstName.Text = dt.Rows(0).Item("FirstName")
                cmbCourse.Text = dt.Rows(0).Item("Course")
                cmbVenue.Text = dt.Rows(0).Item("Venue")
                cmbAssignment.Text = dt.Rows(0).Item("Assignment")
                cmbBatch.Text = dt.Rows(0).Item("Batch")
                cmbSY.Text = dt.Rows(0).Item("SchoolYear")
                dtpStart.Text = dt.Rows(0).Item("StartDate")
                dtpEnd.Text = dt.Rows(0).Item("EndDate")
                Dim lb() As Byte = dt.Rows(0).Item("img")
                Dim lstr As New System.IO.MemoryStream(lb)
                pbProfile.Image = Image.FromStream(lstr)
            Else
                txtLastName.Text = Nothing
                txtFirstName.Text = Nothing
                cmbCourse.Text = Nothing
                cmbVenue.Text = Nothing
                cmbAssignment.Text = Nothing
                cmbBatch.Text = Nothing
                cmbSY.Text = Nothing
                dtpStart.Text = Nothing
                dtpEnd.Text = Nothing
                pbProfile.Image = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dgvMembersRecord_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPracticumRecord.CellContentClick
        txtPracticumID.Text = dgvPracticumRecord.CurrentRow.Cells(0).Value
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearcontrol(gbPracticums)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If txtPracticumID.Text.Equals(String.Empty) Then
                MsgBox("This action cannot be performed.", MsgBoxStyle.Information)
            Else
                Dim question As String
                question = MsgBox("Are you sure you want to delete ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION !")
                If question = vbYes Then
                    DeletePrac()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DeletePrac()
        query = "DELETE FROM `practicum` WHERE `PracticumID`  = '" & txtPracticumID.Text & "'"
        deletes(query, dgvPracticumRecord.CurrentRow.Cells(1).Value)
        load_PracticumInfo()
        clearcontrol(gbPracticums)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtPracticumID.Text = "" And txtLastName.Text = "" And txtFirstName.Text = "" And cmbCourse.Text = "" _
       And cmbVenue.Text = "" And cmbAssignment.Text = "" And cmbBatch.Text = "" Then
            MsgBox("This action cannot be performed.", MsgBoxStyle.Critical, "ATTENTION!")
            txtPracticumID.Focus()
        ElseIf txtPracticumID.Text = "" Then
            MsgBox("No Practicum ID Found!", MsgBoxStyle.Critical, "Error")
            txtPracticumID.Focus()
        ElseIf txtLastName.Text = "" Then
            MsgBox("No Last Name Found!", MsgBoxStyle.Critical, "Error")
            txtLastName.Focus()
        ElseIf txtFirstName.Text = "" Then
            MsgBox("No First Name Found!", MsgBoxStyle.Critical, "Error")
            txtFirstName.Focus()
        ElseIf cmbCourse.Text = "" Then
            MsgBox("Please Select Course", MsgBoxStyle.Critical, "Error")
            cmbCourse.Focus()
        ElseIf cmbVenue.Text = "" Then
            MsgBox("Please Select Venue", MsgBoxStyle.Critical, "Error")
            cmbVenue.Focus()
        ElseIf cmbAssignment.Text = "" Then
            MsgBox("Please Select Assignment", MsgBoxStyle.Critical, "Error")
            cmbAssignment.Focus()
        ElseIf cmbBatch.Text = "" Then
            MsgBox("Please Select Batch", MsgBoxStyle.Critical, "Error")
            cmbBatch.Focus()
        ElseIf cmbSY.Text = "" Then
            MsgBox("Please Select School Year", MsgBoxStyle.Critical, "Error")
            cmbSY.Focus()
        ElseIf pbProfile.Image Is Nothing Then
            MsgBox("Please Insert Image ", MsgBoxStyle.Critical, "Error")
            pbProfile.Focus()
        Else
            UpdatePRac()
        End If
    End Sub
    Public Sub UpdatePRac()
        pbProfile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        FileSize = mstream.Length
        Try
            query = "SELECT * FROM `practicum` WHERE `PracticumID` = '" & txtPracticumID.Text & "'"
            reloadtxt(query)

            Dim cmd As New MySqlCommand("UPDATE `practicum` SET `PracticumID`=@PracticumID, `LastName`=@LastName" _
                        & ", `FirstName`=@FirstName" _
                        & ", `Course`=@Course, `Venue`=@Venue, `Assignment`=@Assignment, `Batch`=@Batch" _
                        & ", `SchoolYear`=@SchoolYear, `StartDate`=@StartDate, `EndDate`=@EndDate" _
                        & ", `filesize`=@filesize, `img`=@img WHERE `PracticumID`=@PracticumID", con)
            With cmd
                .Parameters.AddWithValue("@PracticumID", txtPracticumID.Text)
                .Parameters.AddWithValue("@LastName", txtLastName.Text)
                .Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                .Parameters.AddWithValue("@Course", cmbCourse.Text)
                .Parameters.AddWithValue("@Venue", cmbVenue.Text)
                .Parameters.AddWithValue("@Assignment", cmbAssignment.Text)
                .Parameters.AddWithValue("@Batch", cmbBatch.Text)
                .Parameters.AddWithValue("@SchoolYear", cmbSY.Text)
                .Parameters.AddWithValue("@StartDate", dtpStart.Text)
                .Parameters.AddWithValue("@EndDate", dtpEnd.Text)
                .Parameters.AddWithValue("@filesize", FileSize)
                .Parameters.AddWithValue("@img", arrImage)
            End With
            con.Open()
            If cmd.ExecuteNonQuery() = 1 Then
                MsgBox("Information has been updated.")
            Else
                MsgBox("This action cannot be performed.", MsgBoxStyle.Information)
            End If
            mstream.Close()
            con.Close()
            load_PracticumInfo()
            clearcontrol(gbPracticums)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
            & " AS 'Full Name', `Course`, `Venue`, `Assignment`, `Batch`,  `SchoolYear` AS 'S.Y', " _
            & " `StartDate` AS 'Start Date', `EndDate` AS 'End Date' FROM `practicum`" _
            & " WHERE CONCAT(`LastName`,', ', `FirstName`) LIKE '%" & txtSearch.Text & "%'"
        reloadDgv(query, dgvPracticumRecord)
    End Sub

    Private Sub btnSaveQR_Click(sender As Object, e As EventArgs) Handles btnSaveQR.Click
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            pbQR.Image.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
        clearcontrol(gbPracticums)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(pbQR.Image, 0, 0)
    End Sub
    Private Sub PrintDocument2_PrintPage(sender As System.Object, e As PrintPageEventArgs) Handles PrintDocument2.PrintPage

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
    Private Sub btnPrintdgv_Click(sender As System.Object, e As System.EventArgs) Handles btnPrintdgv.Click
        mRow = 0
        newpage = True
        Dim xCustomSize As New PaperSize("Legal", 850, 1400)
        PrintDocument2.DefaultPageSettings.PaperSize = xCustomSize
        PrintDocument2.DefaultPageSettings.Landscape = True
        PrintPreviewDialog2.PrintPreviewControl.StartPage = 0
        PrintPreviewDialog2.PrintPreviewControl.Zoom = 0.75
        PrintPreviewDialog2.Document = PrintDocument2
        PrintPreviewDialog2.ShowDialog()
    End Sub

#Region "Validation"
    Private Sub txtPracticumID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPracticumID.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            If Asc(e.KeyChar) = 8 Then
                e.Handled = False
            ElseIf Asc(e.KeyChar) = 32 Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            If Asc(e.KeyChar) = 8 Then
                e.Handled = False
            ElseIf Asc(e.KeyChar) = 32 Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub
#End Region

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim OFD As FileDialog = New OpenFileDialog()

            OFD.Filter = "Image File (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png"

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                pbProfile.ImageLocation = imgpath

            End If

            OFD = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
End Class