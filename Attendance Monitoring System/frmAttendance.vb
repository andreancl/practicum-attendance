Imports WebCam_Capture
Imports MessagingToolkit.QRCode.Codec
Imports MySql.Data.MySqlClient

Public Class frmAttendance
    Public con As MySqlConnection = mysqldb()
        WithEvents MyWebcam As WebCamCapture
        Dim Reader As QRCodeDecoder
        Dim logdate As String = String.Format("{0:yyyy-MM-dd}", Date.Now)
        Dim timein_am = TimeOfDay
        Dim timeout_am = TimeOfDay
        Dim timein_pm = TimeOfDay
        Dim timeout_pm = TimeOfDay
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
    Private Sub frmAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_PracticumAttendance()
        dgvAttendanceRecord.RowTemplate.Height = 25
        dgvAttendanceRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvAttendanceRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAttendanceRecord.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub
    Public Sub load_PracticumAttendance()
        query = "SELECT `PracticumID` AS 'Practicum ID', CONCAT(`LastName`,', ', `FirstName`)" _
                & " AS 'Full Name', `Date`, `TimeLogIn_AM` AS 'Time In - AM', `TimeLogOut_AM` AS 'Time Out - AM'," _
                & " `TimeLogIn_PM` AS 'Time In - PM', `TimeLogOut_PM` AS 'Time Out - PM' FROM `attendance`"
        reloadDgv(query, dgvAttendanceRecord)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = Date.Now.ToString("dd MMM yyyy   hh:mm:ss")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StartWebcam()
        TextBox1.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StopWebcam()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            StopWebcam()
            Reader = New QRCodeDecoder
            TextBox1.Text = Reader.decode(New Data.QRCodeBitmapImage(PictureBox1.Image))
            MsgBox("QR code is detected!")
        Catch ex As Exception
            StartWebcam()
        End Try
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(7) Then
            MsgBox(TextBox1.Text, MsgBoxStyle.Information)
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        Try
            If TextBox1.Text = "" Then
                MessageBox.Show("retry")
            Else
                reloadtxt("SELECT * FROM practicum WHERE PracticumID = '" & TextBox1.Text & "'")
            If dt.Rows.Count > 0 Then
                reloadtxt("SELECT * FROM attendance WHERE PracticumID = '" & TextBox1.Text & "' AND DATE = '" & logdate _
                & "' AND Status = 'OUT'")
                If dt.Rows.Count > 0 Then
                    MessageBox.Show("STOP NA BE", "already", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                        reloadtxt("SELECT * FROM attendance WHERE PracticumID = '" & TextBox1.Text & "' AND Status = 'IN'")
                    If dt.Rows.Count > 0 Then
                        Dim quers As String = "UPDATE attendance SET TimeLogOut_AM = '" & timeout_am & "', Status = 'Out' WHERE PracticumID = '" & TextBox1.Text & "'"
                        Dim query2 As String = "UPDATE attendance att, practicum prac SET att.LastName = prac.LastName, att.FirstName = prac.FirstName WHERE att.PracticumID = prac.PracticumID"
                        Dim QueryString2 As String = String.Concat(quers, ";", query2)
                            updates(QueryString2)
                            load_PracticumAttendance()
                        MessageBox.Show("timeout")
                    Else
                        Dim query As String = "INSERT INTO attendance (PracticumID, Date, TimeLogIn_AM, Status) " _
                                          & " VALUES ('" & TextBox1.Text & "', '" & logdate & "', '" & timein_am & "', 'IN')"
                        Dim query2 As String = "UPDATE attendance att, practicum prac SET att.LastName = prac.LastName, att.FirstName = prac.FirstName WHERE att.PracticumID = prac.PracticumID"
                        Dim QueryString As String = String.Concat(query, ";", query2)
                        create(QueryString)
                        load_PracticumAttendance()
                        MessageBox.Show("TimeIn")
                    End If
                    End If

            Else
                MessageBox.Show("amakana akla")
            End If
            End If

            'Else
            ' create("INSERT INTO attendance (PracticumID, Date, TimeLogIn_AM, AM_Status) " _
            ' & " VALUES ('" & TextBox1.Text & "', '" & logdate & "', '" & timein_am & "', 'IN')")
            ' updates("UPDATE attendance att, practicum prac SET att.LastName = prac.LastName, att.FirstName = prac.FirstName WHERE att.PracticumID = prac.PracticumID")
            ' End If
            'End If
            '   Else
            '        MessageBox.Show("wtf", "wth", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            '    End If
            'Dim query As String = "INSERT INTO attendance (PracticumID, Date, TimeLogIn_AM,  ) " _
            '& " VALUES ('" & TextBox1.Text & "', '" & logdate & "', '" & timein_am & "')"
            ' Dim query2 As String = "UPDATE attendance att, practicum prac SET att.LastName = prac.LastName, att.FirstName = prac.FirstName WHERE att.PracticumID = prac.PracticumID"
            'Dim QueryString As String = String.Concat(query, ";", query2)
            'create(QueryString)
            'load_PracticumAttendance()

            'query = "SELECT * FROM attendance WHERE TimeLogIn_AM IS NULL"
        Catch ex As Exception
        End Try
    End Sub
End Class