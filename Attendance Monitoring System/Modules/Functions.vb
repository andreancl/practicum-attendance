Module Functions
    Public Sub closeChildForm()
        For Each frm As Form In frmMain.MdiChildren()
            frm.Close()
        Next
    End Sub
    Public Sub showForm(frm As Form)
        With frm
            .MdiParent = frmMain
            .Show()
        End With
    End Sub
    Public Sub clearcontrol(ByVal obj As Object)
        Dim ChkBox As CheckBox = Nothing
        Dim RdoBtn As RadioButton = Nothing
        Dim CmbBox As ComboBox = Nothing
        Dim pbox As PictureBox = Nothing
        Dim tbox As TextBox = Nothing

        For Each XObject As Control In obj.Controls
            If TypeOf XObject Is TextBox Then
                tbox = XObject
                tbox.Text = Nothing
            End If
        Next
        For Each ctrl As Control In obj.Controls
            If ctrl.GetType Is GetType(DateTimePicker) Then
                ctrl.Text = Now
            End If
        Next
        For Each xObject As Object In obj.Controls()
            If TypeOf xObject Is CheckBox Then
                ChkBox = xObject
                ChkBox.Checked = False
            End If
        Next
        For Each xObject As Object In obj.Controls()
            If TypeOf xObject Is RadioButton Then
                RdoBtn = xObject
                RdoBtn.Checked = False
            End If
        Next
        For Each xObject As Object In obj.Controls()
            If TypeOf xObject Is ComboBox Then
                CmbBox = xObject
                CmbBox.Text = ""
            End If
        Next
        For Each XObject As Object In obj.Controls()
            If TypeOf XObject Is PictureBox Then
                pbox = XObject
                pbox.Image = Nothing
            End If
        Next
    End Sub
End Module
