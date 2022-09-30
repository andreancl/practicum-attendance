Imports MySql.Data.MySqlClient

Public Class frmPracticums
    Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
    Public con As MySqlConnection = mysqldb()

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtPracticumID.Text = "" And txtLastName.Text = "" And txtFirstName.Text = "" And cmbCourse.Text = "" _
        And cmbVenue.Text = "" And cmbAssignment.Text = "" And cmbBatch.Text = "" Then
            MsgBox("Fill up the registration details", MsgBoxStyle.Critical, "ATTENTION!")
            txtPracticumID.Focus()
        ElseIf txtPracticumID.Text = "" Then
            MsgBox("No Practicum ID Found!", MsgBoxStyle.Critical, "Error")
            txtPracticumID.Focus()
        ElseIf txtLastName.Text = "" Then
            MsgBox("No Full Name Found!", MsgBoxStyle.Critical, "Error")
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
        Try
            query = "INSERT INTO `practicum` (`PracticumID`, `LastName`, `FirstName`, `Course`" _
                & ", `Venue`, `Assignment`, `Batch`, `SchoolYear`, `StartDate`, `EndDate`) " _
                & " VALUES ('" & txtPracticumID.Text & "', '" & txtLastName.Text & "', '" & txtFirstName.Text _
                & "', '" & cmbCourse.Text & "', '" & cmbVenue.Text & "', '" & cmbAssignment.Text _
                & "', '" & cmbBatch.Text & "', '" & cmbSY.Text & "', '" & dtpStart.Text & "', '" & dtpEnd.Text & "')"
            create(query, txtPracticumID.Text)
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
        Try
            Generator.BackColor = Color.White
            Generator.LabelFont = New Font("Arial", 7, FontStyle.Regular)
            Generator.IncludeLabel = True

            pbQR.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.QRCode, txtPracticumID.Text))

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
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
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
        query = "SELECT * FROM `practicum` WHERE `PracticumID` = '" & txtPracticumID.Text & "'"
        reloadtxt(query)

        query = "UPDATE `practicum` SET `PracticumId` = '" & txtPracticumID.Text & "', `LastName` = '" _
            & txtLastName.Text & "', `FirstName` = '" & txtFirstName.Text & "', `Course` = '" _
            & cmbCourse.Text & "', `Venue` = '" & cmbVenue.Text & "', `Assignment` = '" _
            & cmbAssignment.Text & "',`Batch` = '" & cmbBatch.Text & "', `SchoolYear` = '" _
            & cmbSY.Text & "', `StartDate` = '" & dtpStart.Text & "', `EndDate` = '" _
            & dtpEnd.Text & "' WHERE `PracticumId` = '" & txtPracticumID.Text & "' "
        updates(query, txtPracticumID.Text)
        load_PracticumInfo()
        clearcontrol(gbPracticums)
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
End Class