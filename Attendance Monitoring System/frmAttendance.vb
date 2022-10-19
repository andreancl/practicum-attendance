Imports WebCam_Capture
Imports MessagingToolkit.QRCode.Codec
Imports MySql.Data.MySqlClient

Public Class frmAttendance
    Public con As MySqlConnection = mysqldb()
    WithEvents MyWebcam As WebCamCapture
    Dim Reader As QRCodeDecoder
    Dim logdate As String = String.Format("{0:yyyy-MM-dd}", Date.Now)
    Dim query2 As String = "UPDATE attendance att, practicum prac SET att.LastName = prac.LastName, att.FirstName = prac.FirstName WHERE att.PracticumID = prac.PracticumID"
    Private Sub MyWebcam_ImageCaptured(source As Object, e As WebcamEventArgs) Handles MyWebcam.ImageCaptured
        PictureBox1.Image = e.WebCamImage
    End Sub
    Private Sub StartWebcam()
        Try
            StopWebcam()
            MyWebcam = New WebCamCapture
            MyWebcam.Start(0)
            MyWebcam.Start(0)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub StopWebcam()
        Try
            MyWebcam.Stop()
            MyWebcam.Dispose()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        StartWebcam()
        txtAM.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        StopWebcam()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Try
            StopWebcam()
            Reader = New QRCodeDecoder
            txtAM.Text = Reader.decode(New Data.QRCodeBitmapImage(PictureBox1.Image))
            MsgBox("QR code is detected!")
        Catch ex As Exception
            StartWebcam()
        End Try
    End Sub
    Private Sub frmAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_AMAttendance()
        dgvAMAttendance.RowTemplate.Height = 25
        dgvAMAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvAMAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAMAttendance.AlternatingRowsDefaultCellStyle.BackColor = Color.White

        load_PMAttendance()
        dgvPMAttendance.RowTemplate.Height = 25
        dgvPMAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvPMAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPMAttendance.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub
    Public Sub load_AMAttendance()
        query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                & " AS 'Full Name', `Date`, `TimeLogIn_AM` AS 'Time In - AM', `TimeLogOut_AM` AS 'Time Out - AM'" _
                & " FROM `attendance` WHERE `Date` = curdate()"
        reloadDgv(query, dgvAMAttendance)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToLongDateString
        lblTime.Text = TimeOfDay.ToLongTimeString
    End Sub
    Private Sub txtAM_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(7) Then
            MsgBox(txtAM.Text, MsgBoxStyle.Information)
            txtAM.Text = ""
        End If
    End Sub
    Private Sub txtAM_TextChanged(sender As Object, e As EventArgs) Handles txtAM.TextChanged
        Try
            If txtAM.Text = "" Then
            Else
                reloadtxt("SELECT * FROM practicum WHERE PracticumID = '" & txtAM.Text & "'")
                If dt.Rows.Count > 0 Then
                    reloadtxt("SELECT * FROM attendance WHERE PracticumID = '" & txtAM.Text & "' AND DATE = '" & logdate _
                    & "' AND AM_Status = 'OUT'")
                    If dt.Rows.Count > 0 Then
                        MessageBox.Show("you've had enough for this day", "attention", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtAM.Text = Nothing
                    Else
                        reloadtxt("SELECT * FROM attendance WHERE PracticumID = '" & txtAM.Text & "' AND AM_Status = 'IN'")
                        If dt.Rows.Count > 0 Then
                            Dim amout As String = "UPDATE attendance SET TimeLogOut_AM = '" & TimeOfDay & "', AM_Status = 'OUT' WHERE PracticumID = '" & txtAM.Text & "'"
                            Dim QueryString As String = String.Concat(amout, ";", query2)
                            updates(QueryString)
                            load_AMAttendance()
                            MessageBox.Show("AM TimeOut")
                            txtAM.Text = Nothing
                            TabPage1.Refresh()
                        Else
                            Dim amin As String = "INSERT INTO attendance (PracticumID, Date, TimeLogIn_AM, AM_Status) " _
                            & " VALUES ('" & txtAM.Text & "', '" & logdate & "', '" & TimeOfDay & "', 'IN')"
                            Dim QueryString1 As String = String.Concat(amin, ";", query2)
                            create(QueryString1)
                            load_AMAttendance()
                            MessageBox.Show("AM TimeIn")
                            txtAM.Text = Nothing
                            TabPage1.Refresh()
                        End If
                    End If
                Else
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub load_PMAttendance()
        query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                & " AS 'Full Name', `Date`, `TimeLogIn_PM` AS 'Time In - PM', `TimeLogOut_PM`" _
                & " AS 'Time Out - PM' FROM `attendance` WHERE `Date` = curdate()"
        reloadDgv(query, dgvPMAttendance)
    End Sub

    Private Sub txtPM_TextChanged(sender As Object, e As EventArgs) Handles txtPM.TextChanged
        Try
            If txtPM.Text = "" Then
            Else
                reloadtxt("SELECT * FROM practicum WHERE PracticumID = '" & txtPM.Text & "'")
                If dt.Rows.Count > 0 Then
                    reloadtxt("SELECT * FROM attendance WHERE PracticumID = '" & txtPM.Text & "' AND DATE = '" & logdate _
                    & "' AND PM_Status = 'OUT'")
                    If dt.Rows.Count > 0 Then
                        MessageBox.Show("you've had enough for this day", "attention", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtPM.Text = Nothing
                    Else
                        reloadtxt("SELECT * FROM attendance WHERE PracticumID = '" & txtPM.Text & "' AND PM_Status = 'IN'")
                        If dt.Rows.Count > 0 Then
                            Dim pmout As String = "UPDATE attendance SET TimeLogOut_PM = '" & TimeOfDay & "', PM_Status = 'OUT' WHERE PracticumID = '" & txtPM.Text & "'"
                            Dim QueryString2 As String = String.Concat(pmout, ";", query2)
                            updates(QueryString2)
                            load_PMAttendance()
                            MessageBox.Show("PM TimeOut")
                            txtPM.Text = Nothing
                            TabPage2.Refresh()
                        Else
                            reloadtxt("SELECT * FROM attendance WHERE PracticumID = '" & txtPM.Text & "' AND DATE = '" & logdate _
                    & "' AND AM_Status = 'OUT'")
                            If dt.Rows.Count > 0 Then
                                Dim pmin As String = "UPDATE attendance SET TimeLogIn_PM = '" & TimeOfDay & "', PM_Status = 'IN' WHERE PracticumID = '" & txtPM.Text & "'"
                                Dim QueryString4 As String = String.Concat(pmin, ";", query2)
                                create(QueryString4)
                                load_PMAttendance()
                                MessageBox.Show("PM TimeIn")
                                txtPM.Text = Nothing
                                TabPage2.Refresh()
                            Else
                                Dim pmins As String = "INSERT INTO attendance (PracticumID, Date, TimeLogIn_PM, PM_Status) " _
                          & " VALUES ('" & txtPM.Text & "', '" & logdate & "', '" & TimeOfDay & "', 'IN')"
                                Dim QueryString5 As String = String.Concat(pmins, ";", query2)
                                create(QueryString5)
                                load_PMAttendance()
                                MessageBox.Show("PM TimeIn")
                                txtPM.Text = Nothing
                                TabPage2.Refresh()
                            End If
                        End If
                    End If
                Else
                End If
                End If
        Catch ex As Exception
        End Try
    End Sub
End Class