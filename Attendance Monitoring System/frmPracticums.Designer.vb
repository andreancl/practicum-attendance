<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPracticums
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPracticums))
        Me.gbPracticums = New System.Windows.Forms.GroupBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSaveQR = New System.Windows.Forms.Button()
        Me.pbQR = New System.Windows.Forms.PictureBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.cmbSY = New System.Windows.Forms.ComboBox()
        Me.cmbBatch = New System.Windows.Forms.ComboBox()
        Me.cmbAssignment = New System.Windows.Forms.ComboBox()
        Me.cmbVenue = New System.Windows.Forms.ComboBox()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPracticumID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblResRec = New System.Windows.Forms.Label()
        Me.dgvPracticumRecord = New System.Windows.Forms.DataGridView()
        Me.lblSearchBy = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog2 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.btnPrintdgv = New System.Windows.Forms.Button()
        Me.gbPracticums.SuspendLayout()
        CType(Me.pbQR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvPracticumRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbPracticums
        '
        Me.gbPracticums.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.gbPracticums.Controls.Add(Me.btnPrint)
        Me.gbPracticums.Controls.Add(Me.btnSaveQR)
        Me.gbPracticums.Controls.Add(Me.pbQR)
        Me.gbPracticums.Controls.Add(Me.btnClear)
        Me.gbPracticums.Controls.Add(Me.btnUpdate)
        Me.gbPracticums.Controls.Add(Me.btnDelete)
        Me.gbPracticums.Controls.Add(Me.btnSave)
        Me.gbPracticums.Controls.Add(Me.dtpEnd)
        Me.gbPracticums.Controls.Add(Me.dtpStart)
        Me.gbPracticums.Controls.Add(Me.cmbSY)
        Me.gbPracticums.Controls.Add(Me.cmbBatch)
        Me.gbPracticums.Controls.Add(Me.cmbAssignment)
        Me.gbPracticums.Controls.Add(Me.cmbVenue)
        Me.gbPracticums.Controls.Add(Me.cmbCourse)
        Me.gbPracticums.Controls.Add(Me.txtFirstName)
        Me.gbPracticums.Controls.Add(Me.txtLastName)
        Me.gbPracticums.Controls.Add(Me.lblEnd)
        Me.gbPracticums.Controls.Add(Me.Label5)
        Me.gbPracticums.Controls.Add(Me.Label6)
        Me.gbPracticums.Controls.Add(Me.lblStart)
        Me.gbPracticums.Controls.Add(Me.Label3)
        Me.gbPracticums.Controls.Add(Me.Label1)
        Me.gbPracticums.Controls.Add(Me.Label2)
        Me.gbPracticums.Controls.Add(Me.Label4)
        Me.gbPracticums.Controls.Add(Me.txtPracticumID)
        Me.gbPracticums.Controls.Add(Me.Label10)
        Me.gbPracticums.Controls.Add(Me.Label11)
        Me.gbPracticums.Location = New System.Drawing.Point(19, 19)
        Me.gbPracticums.Name = "gbPracticums"
        Me.gbPracticums.Size = New System.Drawing.Size(1021, 249)
        Me.gbPracticums.TabIndex = 81
        Me.gbPracticums.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPrint.BackColor = System.Drawing.Color.Green
        Me.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(935, 206)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(66, 29)
        Me.btnPrint.TabIndex = 228
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnSaveQR
        '
        Me.btnSaveQR.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSaveQR.BackColor = System.Drawing.Color.Green
        Me.btnSaveQR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSaveQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveQR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveQR.ForeColor = System.Drawing.Color.White
        Me.btnSaveQR.Location = New System.Drawing.Point(818, 206)
        Me.btnSaveQR.Name = "btnSaveQR"
        Me.btnSaveQR.Size = New System.Drawing.Size(92, 29)
        Me.btnSaveQR.TabIndex = 227
        Me.btnSaveQR.Text = "Save QR"
        Me.btnSaveQR.UseVisualStyleBackColor = False
        '
        'pbQR
        '
        Me.pbQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbQR.Location = New System.Drawing.Point(818, 19)
        Me.pbQR.Name = "pbQR"
        Me.pbQR.Size = New System.Drawing.Size(183, 169)
        Me.pbQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbQR.TabIndex = 226
        Me.pbQR.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnClear.BackColor = System.Drawing.Color.Green
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(598, 206)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(135, 29)
        Me.btnClear.TabIndex = 225
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnUpdate.BackColor = System.Drawing.Color.Green
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(433, 206)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(135, 29)
        Me.btnUpdate.TabIndex = 224
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDelete.BackColor = System.Drawing.Color.Green
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(257, 206)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(135, 29)
        Me.btnDelete.TabIndex = 223
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(80, 206)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(135, 29)
        Me.btnSave.TabIndex = 222
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'dtpEnd
        '
        Me.dtpEnd.CustomFormat = "yyyy-MM-dd"
        Me.dtpEnd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEnd.Location = New System.Drawing.Point(555, 160)
        Me.dtpEnd.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(240, 27)
        Me.dtpEnd.TabIndex = 221
        Me.dtpEnd.Value = New Date(2022, 5, 19, 0, 0, 0, 0)
        '
        'dtpStart
        '
        Me.dtpStart.CustomFormat = "yyyy-MM-dd"
        Me.dtpStart.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStart.Location = New System.Drawing.Point(555, 125)
        Me.dtpStart.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(240, 27)
        Me.dtpStart.TabIndex = 220
        Me.dtpStart.Value = New Date(2022, 5, 19, 0, 0, 0, 0)
        '
        'cmbSY
        '
        Me.cmbSY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSY.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSY.FormattingEnabled = True
        Me.cmbSY.Items.AddRange(New Object() {"", "2021-2022", "2022-2023"})
        Me.cmbSY.Location = New System.Drawing.Point(555, 89)
        Me.cmbSY.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmbSY.Name = "cmbSY"
        Me.cmbSY.Size = New System.Drawing.Size(240, 29)
        Me.cmbSY.TabIndex = 219
        '
        'cmbBatch
        '
        Me.cmbBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBatch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBatch.FormattingEnabled = True
        Me.cmbBatch.Items.AddRange(New Object() {"", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbBatch.Location = New System.Drawing.Point(555, 54)
        Me.cmbBatch.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmbBatch.Name = "cmbBatch"
        Me.cmbBatch.Size = New System.Drawing.Size(240, 29)
        Me.cmbBatch.TabIndex = 218
        '
        'cmbAssignment
        '
        Me.cmbAssignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAssignment.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAssignment.FormattingEnabled = True
        Me.cmbAssignment.Items.AddRange(New Object() {"", "Assistant", "Background Investigation", "Carding", "Encoding", "Evaluation", "Filing Reg Card", "Filing Permit", "Filing Credentials", "Front Desk", "Verification of Grades", "Window 5", "Window 7", "Window 8", "Window 9 ", "Window 10", "Window 12"})
        Me.cmbAssignment.Location = New System.Drawing.Point(555, 19)
        Me.cmbAssignment.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmbAssignment.Name = "cmbAssignment"
        Me.cmbAssignment.Size = New System.Drawing.Size(240, 29)
        Me.cmbAssignment.TabIndex = 217
        '
        'cmbVenue
        '
        Me.cmbVenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVenue.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVenue.FormattingEnabled = True
        Me.cmbVenue.Items.AddRange(New Object() {"", "Admission Office", "Accounting Office", "Records Section"})
        Me.cmbVenue.Location = New System.Drawing.Point(138, 161)
        Me.cmbVenue.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmbVenue.Name = "cmbVenue"
        Me.cmbVenue.Size = New System.Drawing.Size(265, 29)
        Me.cmbVenue.TabIndex = 215
        '
        'cmbCourse
        '
        Me.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCourse.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Items.AddRange(New Object() {"", "BS Business Administration - FA", "BS Business Administration - FM", "BS Business Administration - HRDM", "BS Business Administration - MM", "BS Computer Science", "BS Foreign Service", "AB Political Science"})
        Me.cmbCourse.Location = New System.Drawing.Point(138, 124)
        Me.cmbCourse.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(265, 29)
        Me.cmbCourse.TabIndex = 214
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(138, 91)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtFirstName.MaxLength = 50
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFirstName.Size = New System.Drawing.Size(265, 27)
        Me.txtFirstName.TabIndex = 213
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(138, 55)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtLastName.MaxLength = 50
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLastName.Size = New System.Drawing.Size(265, 27)
        Me.txtLastName.TabIndex = 200
        '
        'lblEnd
        '
        Me.lblEnd.BackColor = System.Drawing.Color.Green
        Me.lblEnd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.ForeColor = System.Drawing.Color.White
        Me.lblEnd.Location = New System.Drawing.Point(429, 161)
        Me.lblEnd.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(121, 25)
        Me.lblEnd.TabIndex = 195
        Me.lblEnd.Text = "End Date"
        Me.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Green
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(429, 126)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 25)
        Me.Label5.TabIndex = 193
        Me.Label5.Text = "Start Date"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Green
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(429, 90)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 25)
        Me.Label6.TabIndex = 191
        Me.Label6.Text = "School Year"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStart
        '
        Me.lblStart.BackColor = System.Drawing.Color.Green
        Me.lblStart.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.ForeColor = System.Drawing.Color.White
        Me.lblStart.Location = New System.Drawing.Point(429, 55)
        Me.lblStart.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(121, 25)
        Me.lblStart.TabIndex = 182
        Me.lblStart.Text = "Batch"
        Me.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Green
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(17, 161)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 27)
        Me.Label3.TabIndex = 175
        Me.Label3.Text = "Venue"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Green
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 25)
        Me.Label1.TabIndex = 173
        Me.Label1.Text = "Practicum ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Green
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(17, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 25)
        Me.Label2.TabIndex = 167
        Me.Label2.Text = "First Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Green
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(17, 56)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 25)
        Me.Label4.TabIndex = 156
        Me.Label4.Text = "Last Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPracticumID
        '
        Me.txtPracticumID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPracticumID.Location = New System.Drawing.Point(138, 20)
        Me.txtPracticumID.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtPracticumID.MaxLength = 7
        Me.txtPracticumID.Name = "txtPracticumID"
        Me.txtPracticumID.Size = New System.Drawing.Size(265, 27)
        Me.txtPracticumID.TabIndex = 157
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Green
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(17, 126)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 25)
        Me.Label10.TabIndex = 162
        Me.Label10.Text = "Course"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Green
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(429, 20)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 25)
        Me.Label11.TabIndex = 163
        Me.Label11.Text = "Assignment"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.gbPracticums)
        Me.Panel1.Location = New System.Drawing.Point(33, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1062, 286)
        Me.Panel1.TabIndex = 80
        '
        'lblResRec
        '
        Me.lblResRec.AutoSize = True
        Me.lblResRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblResRec.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResRec.Location = New System.Drawing.Point(28, 22)
        Me.lblResRec.Name = "lblResRec"
        Me.lblResRec.Size = New System.Drawing.Size(355, 38)
        Me.lblResRec.TabIndex = 81
        Me.lblResRec.Text = "ADD NEW PRACTICUM"
        '
        'dgvPracticumRecord
        '
        Me.dgvPracticumRecord.AllowUserToAddRows = False
        Me.dgvPracticumRecord.AllowUserToDeleteRows = False
        Me.dgvPracticumRecord.AllowUserToResizeColumns = False
        Me.dgvPracticumRecord.AllowUserToResizeRows = False
        Me.dgvPracticumRecord.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPracticumRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPracticumRecord.BackgroundColor = System.Drawing.Color.Green
        Me.dgvPracticumRecord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Green
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(148, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPracticumRecord.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPracticumRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPracticumRecord.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPracticumRecord.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPracticumRecord.Location = New System.Drawing.Point(33, 422)
        Me.dgvPracticumRecord.Name = "dgvPracticumRecord"
        Me.dgvPracticumRecord.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.dgvPracticumRecord.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPracticumRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPracticumRecord.Size = New System.Drawing.Size(1062, 133)
        Me.dgvPracticumRecord.StandardTab = True
        Me.dgvPracticumRecord.TabIndex = 82
        '
        'lblSearchBy
        '
        Me.lblSearchBy.AutoSize = True
        Me.lblSearchBy.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchBy.ForeColor = System.Drawing.Color.Black
        Me.lblSearchBy.Location = New System.Drawing.Point(33, 393)
        Me.lblSearchBy.Name = "lblSearchBy"
        Me.lblSearchBy.Size = New System.Drawing.Size(146, 19)
        Me.lblSearchBy.TabIndex = 172
        Me.lblSearchBy.Text = "SEARCH BY NAME:"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(185, 390)
        Me.txtSearch.MaxLength = 35
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(229, 26)
        Me.txtSearch.TabIndex = 174
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "jpg"
        Me.SaveFileDialog1.Filter = "JPEG Image | *.jpg"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog2
        '
        Me.PrintPreviewDialog2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog2.Enabled = True
        Me.PrintPreviewDialog2.Icon = CType(resources.GetObject("PrintPreviewDialog2.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog2.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog2.Visible = False
        '
        'PrintDocument2
        '
        '
        'btnPrintdgv
        '
        Me.btnPrintdgv.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPrintdgv.BackColor = System.Drawing.Color.Green
        Me.btnPrintdgv.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPrintdgv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintdgv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintdgv.ForeColor = System.Drawing.Color.White
        Me.btnPrintdgv.Location = New System.Drawing.Point(1029, 389)
        Me.btnPrintdgv.Name = "btnPrintdgv"
        Me.btnPrintdgv.Size = New System.Drawing.Size(66, 29)
        Me.btnPrintdgv.TabIndex = 229
        Me.btnPrintdgv.Text = "Print"
        Me.btnPrintdgv.UseVisualStyleBackColor = False
        '
        'frmPracticums
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1130, 585)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPrintdgv)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblSearchBy)
        Me.Controls.Add(Me.dgvPracticumRecord)
        Me.Controls.Add(Me.lblResRec)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPracticums"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gbPracticums.ResumeLayout(False)
        Me.gbPracticums.PerformLayout()
        CType(Me.pbQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvPracticumRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbPracticums As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPracticumID As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblResRec As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents dgvPracticumRecord As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblEnd As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents cmbVenue As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbSY As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBatch As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAssignment As System.Windows.Forms.ComboBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblSearchBy As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents pbQR As System.Windows.Forms.PictureBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnSaveQR As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog2 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument2 As System.Drawing.Printing.PrintDocument
    Friend WithEvents btnPrintdgv As System.Windows.Forms.Button
End Class
