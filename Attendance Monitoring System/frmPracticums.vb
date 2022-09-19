Imports MySql.Data.MySqlClient

Public Class frmPracticums
    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Public con As MySqlConnection = mysqldb()
    Dim results As Integer
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim sql As String

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            Dim OFD As FileDialog = New OpenFileDialog()

            OFD.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                pbProfile.ImageLocation = imgpath

            End If

            OFD = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtFullName.Text = "" And txtPracticumID.Text = "" And cmbCourse.Text = "" And txtContactNo.Text = "" _
        And cmbVenue.Text = "" And cmbAssignment.Text = "" And cmbBatch.Text = "" Then
            MsgBox("Fill up the registration details", MsgBoxStyle.Critical, "ATTENTION!")
            txtFullName.Focus()
        ElseIf txtFullName.Text = "" Then
            MsgBox("No Practicum ID Found!", MsgBoxStyle.Critical, "Error")
            txtFullName.Focus()
        ElseIf txtPracticumID.Text = "" Then
            MsgBox("No Full Name Found!", MsgBoxStyle.Critical, "Error")
            txtPracticumID.Focus()
        ElseIf cmbCourse.Text = "" Then
            MsgBox("Please Select Course", MsgBoxStyle.Critical, "Error")
            cmbCourse.Focus()
        ElseIf txtContactNo.Text = "" Then
            MsgBox("No Contact Number Found!", MsgBoxStyle.Critical, "Error")
            txtContactNo.Focus()
        ElseIf cmbVenue.Text = "" Then
            MsgBox("Please Select Venue", MsgBoxStyle.Critical, "Error")
            cmbVenue.Focus()
        ElseIf cmbAssignment.Text = "" Then
            MsgBox("Please Select Assignment", MsgBoxStyle.Critical, "Error")
            cmbAssignment.Focus()
        ElseIf cmbBatch.Text = "" Then
            MsgBox("Please Select Batch", MsgBoxStyle.Critical, "Error")
            cmbBatch.Focus()
        Else
            CheckingID()
        End If
    End Sub
    Private Sub CheckingID()
        Try
            con.Open()
            query = "SELECT PracticumID FROM practicum WHERE PracticumID = '" & txtFullName.Text & "'"
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
            Dim mstream As New System.IO.MemoryStream()
            pbProfile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Dim FileSize As UInt32
            FileSize = mstream.Length

            mstream.Close()
            query = "INSERT INTO practicum (`PracticumID`, `PracticumName`, `Course`, `ContactNumber`" _
                & ", `Venue`, `Assignment`, `Batch`,`PracticumProfile`) VALUES (@PracticumID, @PracticumName, @Course, @ContactNumber, @Venue, @Assignment,@Batch,@PracticumProfile)"
            cmd.Parameters.AddWithValue("@PracticumID", txtPracticumID.Text)
            cmd.Parameters.AddWithValue("@PracticumName", txtFullName.Text)
            cmd.Parameters.AddWithValue("@Course", cmbCourse.Text)
            cmd.Parameters.AddWithValue("@ContactNumber", txtContactNo.Text)
            cmd.Parameters.AddWithValue("@Venue", cmbVenue.Text)
            cmd.Parameters.AddWithValue("@Assignment", cmbAssignment.Text)
            cmd.Parameters.AddWithValue("@Batch", cmbBatch.Text)
            cmd.Parameters.AddWithValue("@PracticumProfile", arrImage)
            create(query, txtPracticumID.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub load_MembersInfo()
        query = "SELECT `PracticumID`, `PracticumName`, `Course`, `ContactNumber`" _
                & ", `Venue`, `Assignment`, `Batch` FROM `practicum`"
        reloadDgv(query, dgvMembersRecord)
    End Sub

    Private Sub frmPracticums_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_MembersInfo()
    End Sub

    Private Sub txtPracticumID_TextChanged(sender As Object, e As EventArgs) Handles txtPracticumID.TextChanged
        Try
            pbQR.Image = QR_Generator.Encode(txtPracticumID.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            query = "SELECT * FROM `practicum` WHERE `PracticumID`='" & txtPracticumID.Text & "'"
            reloadtxt(query)

            If dt.Rows.Count > 0 Then
                txtPracticumID.Text = dt.Rows(0).Item("PracticumID")
                txtFullName.Text = dt.Rows(0).Item("PracticumName")
                cmbCourse.Text = dt.Rows(0).Item("Course")
                txtContactNo.Text = dt.Rows(0).Item("ContactNumber")
                cmbVenue.Text = dt.Rows(0).Item("Venue")
                cmbAssignment.Text = dt.Rows(0).Item("Assignment")
                cmbBatch.Text = dt.Rows(0).Item("Batch")
                arrImage = dt.Rows(0).Item("PracticumProfile")

                Dim mstream As New System.IO.MemoryStream(arrImage)
                pbProfile.Image = Image.FromStream(mstream)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgvMembersRecord_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMembersRecord.CellContentClick
        txtPracticumID.Text = dgvMembersRecord.CurrentRow.Cells(0).Value
    End Sub
End Class