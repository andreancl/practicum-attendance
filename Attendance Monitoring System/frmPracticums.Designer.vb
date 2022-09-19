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
        Me.gbMembers = New System.Windows.Forms.GroupBox()
        Me.cmbBatch = New System.Windows.Forms.ComboBox()
        Me.cmbAssignment = New System.Windows.Forms.ComboBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.pbQR = New System.Windows.Forms.PictureBox()
        Me.pbProfile = New System.Windows.Forms.PictureBox()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.cmbVenue = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.txtPracticumID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblMemId = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblResRec = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.dgvMembersRecord = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbMembers.SuspendLayout()
        CType(Me.pbQR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvMembersRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbMembers
        '
        Me.gbMembers.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.gbMembers.Controls.Add(Me.cmbBatch)
        Me.gbMembers.Controls.Add(Me.cmbAssignment)
        Me.gbMembers.Controls.Add(Me.btnBrowse)
        Me.gbMembers.Controls.Add(Me.pbQR)
        Me.gbMembers.Controls.Add(Me.pbProfile)
        Me.gbMembers.Controls.Add(Me.lblStart)
        Me.gbMembers.Controls.Add(Me.cmbVenue)
        Me.gbMembers.Controls.Add(Me.Label3)
        Me.gbMembers.Controls.Add(Me.txtFullName)
        Me.gbMembers.Controls.Add(Me.Label1)
        Me.gbMembers.Controls.Add(Me.btnClear)
        Me.gbMembers.Controls.Add(Me.btnUpdate)
        Me.gbMembers.Controls.Add(Me.btnDelete)
        Me.gbMembers.Controls.Add(Me.btnSave)
        Me.gbMembers.Controls.Add(Me.cmbCourse)
        Me.gbMembers.Controls.Add(Me.Label2)
        Me.gbMembers.Controls.Add(Me.Label4)
        Me.gbMembers.Controls.Add(Me.txtContactNo)
        Me.gbMembers.Controls.Add(Me.txtPracticumID)
        Me.gbMembers.Controls.Add(Me.Label10)
        Me.gbMembers.Controls.Add(Me.Label11)
        Me.gbMembers.Controls.Add(Me.lblMemId)
        Me.gbMembers.Location = New System.Drawing.Point(19, 19)
        Me.gbMembers.Name = "gbMembers"
        Me.gbMembers.Size = New System.Drawing.Size(982, 321)
        Me.gbMembers.TabIndex = 81
        Me.gbMembers.TabStop = False
        '
        'cmbBatch
        '
        Me.cmbBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBatch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBatch.FormattingEnabled = True
        Me.cmbBatch.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbBatch.Location = New System.Drawing.Point(173, 235)
        Me.cmbBatch.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmbBatch.Name = "cmbBatch"
        Me.cmbBatch.Size = New System.Drawing.Size(265, 29)
        Me.cmbBatch.TabIndex = 190
        '
        'cmbAssignment
        '
        Me.cmbAssignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAssignment.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAssignment.FormattingEnabled = True
        Me.cmbAssignment.Items.AddRange(New Object() {"Carding", "Filing Reg Card", "Filing Permit", "Filing Credentials", "Front Desk", "Verification of Grades", "Window 5", "Window 7", "Window 8", "Window 9 ", "Window 10", "Window 12", "Background Investigation", "Evaluation", "Assistant"})
        Me.cmbAssignment.Location = New System.Drawing.Point(173, 199)
        Me.cmbAssignment.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmbAssignment.Name = "cmbAssignment"
        Me.cmbAssignment.Size = New System.Drawing.Size(265, 29)
        Me.cmbAssignment.TabIndex = 189
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBrowse.BackColor = System.Drawing.Color.Green
        Me.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.Location = New System.Drawing.Point(734, 193)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(190, 29)
        Me.btnBrowse.TabIndex = 188
        Me.btnBrowse.Text = "Browse Image"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'pbQR
        '
        Me.pbQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbQR.Location = New System.Drawing.Point(505, 20)
        Me.pbQR.Name = "pbQR"
        Me.pbQR.Size = New System.Drawing.Size(190, 167)
        Me.pbQR.TabIndex = 187
        Me.pbQR.TabStop = False
        '
        'pbProfile
        '
        Me.pbProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbProfile.Location = New System.Drawing.Point(734, 20)
        Me.pbProfile.Name = "pbProfile"
        Me.pbProfile.Size = New System.Drawing.Size(190, 167)
        Me.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProfile.TabIndex = 186
        Me.pbProfile.TabStop = False
        '
        'lblStart
        '
        Me.lblStart.BackColor = System.Drawing.Color.Green
        Me.lblStart.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.ForeColor = System.Drawing.Color.White
        Me.lblStart.Location = New System.Drawing.Point(47, 236)
        Me.lblStart.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(121, 25)
        Me.lblStart.TabIndex = 182
        Me.lblStart.Text = "Batch"
        Me.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbVenue
        '
        Me.cmbVenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVenue.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVenue.FormattingEnabled = True
        Me.cmbVenue.Items.AddRange(New Object() {"Admission Office", "Accounting Office", "Records Section"})
        Me.cmbVenue.Location = New System.Drawing.Point(172, 162)
        Me.cmbVenue.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmbVenue.Name = "cmbVenue"
        Me.cmbVenue.Size = New System.Drawing.Size(265, 29)
        Me.cmbVenue.TabIndex = 176
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Green
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(46, 163)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 27)
        Me.Label3.TabIndex = 175
        Me.Label3.Text = "Venue"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFullName
        '
        Me.txtFullName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(172, 55)
        Me.txtFullName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtFullName.MaxLength = 11
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFullName.Size = New System.Drawing.Size(265, 27)
        Me.txtFullName.TabIndex = 174
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Green
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(46, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 25)
        Me.Label1.TabIndex = 173
        Me.Label1.Text = "Practicum ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnClear.BackColor = System.Drawing.Color.Green
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(756, 237)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(135, 29)
        Me.btnClear.TabIndex = 172
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
        Me.btnUpdate.Location = New System.Drawing.Point(756, 272)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(135, 29)
        Me.btnUpdate.TabIndex = 171
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
        Me.btnDelete.Location = New System.Drawing.Point(534, 272)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(135, 29)
        Me.btnDelete.TabIndex = 170
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
        Me.btnSave.Location = New System.Drawing.Point(534, 237)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(135, 29)
        Me.btnSave.TabIndex = 169
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'cmbCourse
        '
        Me.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCourse.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Items.AddRange(New Object() {"Bachelor of Science in Business Administration - FA", "Bachelor of Science in Business Administration - FM", "Bachelor of Science in Business Administration - HRDM", "Bachelor of Science in Business Administration - MM", "Bachelor of Science in Computer Science", "Bachelor of Science in Foreign Service", "Bachelor of Arts in Political Science"})
        Me.cmbCourse.Location = New System.Drawing.Point(173, 91)
        Me.cmbCourse.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(265, 29)
        Me.cmbCourse.TabIndex = 168
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Green
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(46, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 25)
        Me.Label2.TabIndex = 167
        Me.Label2.Text = "Course"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Green
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(46, 56)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 25)
        Me.Label4.TabIndex = 156
        Me.Label4.Text = "Full Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtContactNo
        '
        Me.txtContactNo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNo.Location = New System.Drawing.Point(172, 128)
        Me.txtContactNo.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtContactNo.MaxLength = 11
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtContactNo.Size = New System.Drawing.Size(265, 27)
        Me.txtContactNo.TabIndex = 165
        '
        'txtPracticumID
        '
        Me.txtPracticumID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPracticumID.Location = New System.Drawing.Point(173, 20)
        Me.txtPracticumID.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtPracticumID.MaxLength = 30
        Me.txtPracticumID.Name = "txtPracticumID"
        Me.txtPracticumID.Size = New System.Drawing.Size(265, 27)
        Me.txtPracticumID.TabIndex = 157
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Green
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(46, 128)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 25)
        Me.Label10.TabIndex = 162
        Me.Label10.Text = "Contact No."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Green
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(47, 201)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 25)
        Me.Label11.TabIndex = 163
        Me.Label11.Text = "Assignment"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMemId
        '
        Me.lblMemId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMemId.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemId.Location = New System.Drawing.Point(628, 18)
        Me.lblMemId.Name = "lblMemId"
        Me.lblMemId.Size = New System.Drawing.Size(183, 26)
        Me.lblMemId.TabIndex = 81
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.gbMembers)
        Me.Panel1.Location = New System.Drawing.Point(30, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 358)
        Me.Panel1.TabIndex = 80
        '
        'lblResRec
        '
        Me.lblResRec.AutoSize = True
        Me.lblResRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblResRec.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResRec.Location = New System.Drawing.Point(23, 22)
        Me.lblResRec.Name = "lblResRec"
        Me.lblResRec.Size = New System.Drawing.Size(355, 38)
        Me.lblResRec.TabIndex = 81
        Me.lblResRec.Text = "ADD NEW PRACTICUM"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'dgvMembersRecord
        '
        Me.dgvMembersRecord.AllowUserToAddRows = False
        Me.dgvMembersRecord.AllowUserToDeleteRows = False
        Me.dgvMembersRecord.AllowUserToResizeColumns = False
        Me.dgvMembersRecord.AllowUserToResizeRows = False
        Me.dgvMembersRecord.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMembersRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvMembersRecord.BackgroundColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(213, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMembersRecord.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMembersRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMembersRecord.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMembersRecord.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvMembersRecord.Location = New System.Drawing.Point(49, 467)
        Me.dgvMembersRecord.Name = "dgvMembersRecord"
        Me.dgvMembersRecord.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.dgvMembersRecord.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMembersRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMembersRecord.Size = New System.Drawing.Size(951, 102)
        Me.dgvMembersRecord.StandardTab = True
        Me.dgvMembersRecord.TabIndex = 82
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(757, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 26)
        Me.Label5.TabIndex = 83
        '
        'frmPracticums
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1105, 581)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvMembersRecord)
        Me.Controls.Add(Me.lblResRec)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPracticums"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gbMembers.ResumeLayout(False)
        Me.gbMembers.PerformLayout()
        CType(Me.pbQR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvMembersRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbMembers As System.Windows.Forms.GroupBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtContactNo As System.Windows.Forms.TextBox
    Friend WithEvents txtPracticumID As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblMemId As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblResRec As System.Windows.Forms.Label
    Friend WithEvents cmbVenue As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pbQR As System.Windows.Forms.PictureBox
    Friend WithEvents pbProfile As System.Windows.Forms.PictureBox
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents cmbAssignment As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBatch As System.Windows.Forms.ComboBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dgvMembersRecord As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
