<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecords))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.LogPanel = New System.Windows.Forms.Panel()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRecords = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAllLogs = New System.Windows.Forms.Button()
        Me.dgvPracticumRecord = New System.Windows.Forms.DataGridView()
        Me.PrintPreviewDialog2 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlPracticums = New System.Windows.Forms.Panel()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.lblSY = New System.Windows.Forms.Label()
        Me.lblBatch = New System.Windows.Forms.Label()
        Me.lblVenue = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.lblAssignment = New System.Windows.Forms.Label()
        Me.pbProfile = New System.Windows.Forms.PictureBox()
        Me.dgvPersonalRecord = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblPracticumID = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtProfileSearch = New System.Windows.Forms.TextBox()
        Me.lblSearchBy = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFROM = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpTO = New System.Windows.Forms.DateTimePicker()
        Me.pnlDateFilter = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.pnlProfileSearch = New System.Windows.Forms.Panel()
        Me.pnlSearchList = New System.Windows.Forms.Panel()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnPrintRecord = New System.Windows.Forms.Button()
        Me.btnPrintProfile = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblTotalHours = New System.Windows.Forms.Label()
        Me.LogPanel.SuspendLayout()
        CType(Me.dgvPracticumRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPracticums.SuspendLayout()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPersonalRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDateFilter.SuspendLayout()
        Me.pnlProfileSearch.SuspendLayout()
        Me.pnlSearchList.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintDocument1
        '
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
        'LogPanel
        '
        Me.LogPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.LogPanel.Controls.Add(Me.btnProfile)
        Me.LogPanel.Controls.Add(Me.Label3)
        Me.LogPanel.Controls.Add(Me.btnRecords)
        Me.LogPanel.Controls.Add(Me.Label2)
        Me.LogPanel.Controls.Add(Me.Label4)
        Me.LogPanel.Controls.Add(Me.btnAllLogs)
        Me.LogPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogPanel.Location = New System.Drawing.Point(0, 76)
        Me.LogPanel.Name = "LogPanel"
        Me.LogPanel.Size = New System.Drawing.Size(125, 509)
        Me.LogPanel.TabIndex = 233
        '
        'btnProfile
        '
        Me.btnProfile.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfile.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.Image = CType(resources.GetObject("btnProfile.Image"), System.Drawing.Image)
        Me.btnProfile.Location = New System.Drawing.Point(2, 133)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(121, 64)
        Me.btnProfile.TabIndex = 9
        Me.btnProfile.Text = "Profile"
        Me.btnProfile.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnProfile.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ATTENDANCE"
        '
        'btnRecords
        '
        Me.btnRecords.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecords.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecords.Image = CType(resources.GetObject("btnRecords.Image"), System.Drawing.Image)
        Me.btnRecords.Location = New System.Drawing.Point(2, 203)
        Me.btnRecords.Name = "btnRecords"
        Me.btnRecords.Size = New System.Drawing.Size(121, 64)
        Me.btnRecords.TabIndex = 7
        Me.btnRecords.Text = "Practicum List"
        Me.btnRecords.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnRecords.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "PRACTICUM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 5
        '
        'btnAllLogs
        '
        Me.btnAllLogs.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnAllLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAllLogs.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllLogs.Image = CType(resources.GetObject("btnAllLogs.Image"), System.Drawing.Image)
        Me.btnAllLogs.Location = New System.Drawing.Point(2, 36)
        Me.btnAllLogs.Name = "btnAllLogs"
        Me.btnAllLogs.Size = New System.Drawing.Size(121, 64)
        Me.btnAllLogs.TabIndex = 4
        Me.btnAllLogs.Text = "All Logs"
        Me.btnAllLogs.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAllLogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAllLogs.UseVisualStyleBackColor = True
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
        Me.dgvPracticumRecord.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPracticumRecord.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPracticumRecord.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPracticumRecord.Location = New System.Drawing.Point(150, 111)
        Me.dgvPracticumRecord.Name = "dgvPracticumRecord"
        Me.dgvPracticumRecord.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.dgvPracticumRecord.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPracticumRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPracticumRecord.Size = New System.Drawing.Size(957, 464)
        Me.dgvPracticumRecord.StandardTab = True
        Me.dgvPracticumRecord.TabIndex = 83
        '
        'PrintPreviewDialog2
        '
        Me.PrintPreviewDialog2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog2.Document = Me.PrintDocument2
        Me.PrintPreviewDialog2.Enabled = True
        Me.PrintPreviewDialog2.Icon = CType(resources.GetObject("PrintPreviewDialog2.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog2.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog2.Visible = False
        '
        'PrintDocument2
        '
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(28, 22)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(163, 38)
        Me.lblTitle.TabIndex = 237
        Me.lblTitle.Text = "RECORDS"
        '
        'pnlPracticums
        '
        Me.pnlPracticums.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPracticums.Controls.Add(Me.lblTotalHours)
        Me.pnlPracticums.Controls.Add(Me.Label16)
        Me.pnlPracticums.Controls.Add(Me.lblEndDate)
        Me.pnlPracticums.Controls.Add(Me.lblStartDate)
        Me.pnlPracticums.Controls.Add(Me.lblSY)
        Me.pnlPracticums.Controls.Add(Me.lblBatch)
        Me.pnlPracticums.Controls.Add(Me.lblVenue)
        Me.pnlPracticums.Controls.Add(Me.lblFirstName)
        Me.pnlPracticums.Controls.Add(Me.lblLastName)
        Me.pnlPracticums.Controls.Add(Me.lblCourse)
        Me.pnlPracticums.Controls.Add(Me.lblAssignment)
        Me.pnlPracticums.Controls.Add(Me.pbProfile)
        Me.pnlPracticums.Controls.Add(Me.dgvPersonalRecord)
        Me.pnlPracticums.Controls.Add(Me.Label14)
        Me.pnlPracticums.Controls.Add(Me.Label5)
        Me.pnlPracticums.Controls.Add(Me.Label6)
        Me.pnlPracticums.Controls.Add(Me.Label13)
        Me.pnlPracticums.Controls.Add(Me.Label7)
        Me.pnlPracticums.Controls.Add(Me.lblPracticumID)
        Me.pnlPracticums.Controls.Add(Me.Label9)
        Me.pnlPracticums.Controls.Add(Me.Label10)
        Me.pnlPracticums.Controls.Add(Me.Label11)
        Me.pnlPracticums.Controls.Add(Me.Label12)
        Me.pnlPracticums.Location = New System.Drawing.Point(150, 111)
        Me.pnlPracticums.Name = "pnlPracticums"
        Me.pnlPracticums.Size = New System.Drawing.Size(957, 464)
        Me.pnlPracticums.TabIndex = 239
        '
        'lblEndDate
        '
        Me.lblEndDate.BackColor = System.Drawing.Color.Transparent
        Me.lblEndDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndDate.ForeColor = System.Drawing.Color.Black
        Me.lblEndDate.Location = New System.Drawing.Point(122, 437)
        Me.lblEndDate.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(224, 25)
        Me.lblEndDate.TabIndex = 287
        Me.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStartDate
        '
        Me.lblStartDate.BackColor = System.Drawing.Color.Transparent
        Me.lblStartDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartDate.ForeColor = System.Drawing.Color.Black
        Me.lblStartDate.Location = New System.Drawing.Point(122, 412)
        Me.lblStartDate.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(224, 25)
        Me.lblStartDate.TabIndex = 286
        Me.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSY
        '
        Me.lblSY.BackColor = System.Drawing.Color.Transparent
        Me.lblSY.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSY.ForeColor = System.Drawing.Color.Black
        Me.lblSY.Location = New System.Drawing.Point(122, 387)
        Me.lblSY.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblSY.Name = "lblSY"
        Me.lblSY.Size = New System.Drawing.Size(224, 25)
        Me.lblSY.TabIndex = 285
        Me.lblSY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBatch
        '
        Me.lblBatch.BackColor = System.Drawing.Color.Transparent
        Me.lblBatch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBatch.ForeColor = System.Drawing.Color.Black
        Me.lblBatch.Location = New System.Drawing.Point(122, 362)
        Me.lblBatch.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblBatch.Name = "lblBatch"
        Me.lblBatch.Size = New System.Drawing.Size(224, 25)
        Me.lblBatch.TabIndex = 284
        Me.lblBatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVenue
        '
        Me.lblVenue.BackColor = System.Drawing.Color.Transparent
        Me.lblVenue.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenue.ForeColor = System.Drawing.Color.Black
        Me.lblVenue.Location = New System.Drawing.Point(122, 312)
        Me.lblVenue.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblVenue.Name = "lblVenue"
        Me.lblVenue.Size = New System.Drawing.Size(224, 27)
        Me.lblVenue.TabIndex = 283
        Me.lblVenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFirstName
        '
        Me.lblFirstName.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.Black
        Me.lblFirstName.Location = New System.Drawing.Point(122, 262)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(224, 25)
        Me.lblFirstName.TabIndex = 282
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLastName
        '
        Me.lblLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblLastName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.Black
        Me.lblLastName.Location = New System.Drawing.Point(122, 237)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(224, 25)
        Me.lblLastName.TabIndex = 279
        Me.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCourse
        '
        Me.lblCourse.BackColor = System.Drawing.Color.Transparent
        Me.lblCourse.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.ForeColor = System.Drawing.Color.Black
        Me.lblCourse.Location = New System.Drawing.Point(122, 287)
        Me.lblCourse.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(224, 25)
        Me.lblCourse.TabIndex = 280
        Me.lblCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAssignment
        '
        Me.lblAssignment.BackColor = System.Drawing.Color.Transparent
        Me.lblAssignment.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssignment.ForeColor = System.Drawing.Color.Black
        Me.lblAssignment.Location = New System.Drawing.Point(122, 337)
        Me.lblAssignment.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblAssignment.Name = "lblAssignment"
        Me.lblAssignment.Size = New System.Drawing.Size(224, 25)
        Me.lblAssignment.TabIndex = 281
        Me.lblAssignment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbProfile
        '
        Me.pbProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbProfile.Location = New System.Drawing.Point(67, 11)
        Me.pbProfile.Name = "pbProfile"
        Me.pbProfile.Size = New System.Drawing.Size(241, 199)
        Me.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProfile.TabIndex = 278
        Me.pbProfile.TabStop = False
        '
        'dgvPersonalRecord
        '
        Me.dgvPersonalRecord.AllowUserToAddRows = False
        Me.dgvPersonalRecord.AllowUserToDeleteRows = False
        Me.dgvPersonalRecord.AllowUserToResizeColumns = False
        Me.dgvPersonalRecord.AllowUserToResizeRows = False
        Me.dgvPersonalRecord.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPersonalRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPersonalRecord.BackgroundColor = System.Drawing.Color.Green
        Me.dgvPersonalRecord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Green
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(148, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPersonalRecord.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPersonalRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPersonalRecord.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPersonalRecord.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPersonalRecord.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPersonalRecord.Location = New System.Drawing.Point(365, 11)
        Me.dgvPersonalRecord.Name = "dgvPersonalRecord"
        Me.dgvPersonalRecord.RowHeadersVisible = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.dgvPersonalRecord.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPersonalRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPersonalRecord.Size = New System.Drawing.Size(565, 411)
        Me.dgvPersonalRecord.StandardTab = True
        Me.dgvPersonalRecord.TabIndex = 257
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(10, 436)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 25)
        Me.Label14.TabIndex = 246
        Me.Label14.Text = "End Date:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(10, 411)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 25)
        Me.Label5.TabIndex = 245
        Me.Label5.Text = "Start Date:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(10, 386)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 25)
        Me.Label6.TabIndex = 244
        Me.Label6.Text = "School Year:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(10, 361)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 25)
        Me.Label13.TabIndex = 243
        Me.Label13.Text = "Batch:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(10, 311)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 27)
        Me.Label7.TabIndex = 242
        Me.Label7.Text = "Venue:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPracticumID
        '
        Me.lblPracticumID.BackColor = System.Drawing.Color.Transparent
        Me.lblPracticumID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPracticumID.ForeColor = System.Drawing.Color.Black
        Me.lblPracticumID.Location = New System.Drawing.Point(149, 212)
        Me.lblPracticumID.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblPracticumID.Name = "lblPracticumID"
        Me.lblPracticumID.Size = New System.Drawing.Size(116, 25)
        Me.lblPracticumID.TabIndex = 241
        Me.lblPracticumID.Text = "Practicum ID"
        Me.lblPracticumID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(10, 261)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 25)
        Me.Label9.TabIndex = 240
        Me.Label9.Text = "First Name:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(10, 236)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 25)
        Me.Label10.TabIndex = 237
        Me.Label10.Text = "Last Name:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(10, 286)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 25)
        Me.Label11.TabIndex = 238
        Me.Label11.Text = "Course:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(10, 336)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 25)
        Me.Label12.TabIndex = 239
        Me.Label12.Text = "Assignment:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtProfileSearch
        '
        Me.txtProfileSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtProfileSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfileSearch.ForeColor = System.Drawing.Color.Black
        Me.txtProfileSearch.Location = New System.Drawing.Point(214, 5)
        Me.txtProfileSearch.MaxLength = 7
        Me.txtProfileSearch.Name = "txtProfileSearch"
        Me.txtProfileSearch.Size = New System.Drawing.Size(170, 26)
        Me.txtProfileSearch.TabIndex = 241
        Me.txtProfileSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSearchBy
        '
        Me.lblSearchBy.AutoSize = True
        Me.lblSearchBy.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchBy.ForeColor = System.Drawing.Color.Black
        Me.lblSearchBy.Location = New System.Drawing.Point(1, 9)
        Me.lblSearchBy.Name = "lblSearchBy"
        Me.lblSearchBy.Size = New System.Drawing.Size(208, 19)
        Me.lblSearchBy.TabIndex = 240
        Me.lblSearchBy.Text = "SEARCH BY PRACTICUM ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 19)
        Me.Label1.TabIndex = 242
        Me.Label1.Text = "FROM:"
        '
        'dtpFROM
        '
        Me.dtpFROM.CustomFormat = "yyyy-MM-dd"
        Me.dtpFROM.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFROM.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFROM.Location = New System.Drawing.Point(63, 5)
        Me.dtpFROM.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dtpFROM.Name = "dtpFROM"
        Me.dtpFROM.Size = New System.Drawing.Size(120, 27)
        Me.dtpFROM.TabIndex = 243
        Me.dtpFROM.Value = New Date(2022, 5, 19, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(185, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 19)
        Me.Label8.TabIndex = 244
        Me.Label8.Text = "TO:"
        '
        'dtpTO
        '
        Me.dtpTO.CustomFormat = "yyyy-MM-dd"
        Me.dtpTO.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTO.Location = New System.Drawing.Point(219, 5)
        Me.dtpTO.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dtpTO.Name = "dtpTO"
        Me.dtpTO.Size = New System.Drawing.Size(120, 27)
        Me.dtpTO.TabIndex = 245
        Me.dtpTO.Value = New Date(2022, 5, 19, 0, 0, 0, 0)
        '
        'pnlDateFilter
        '
        Me.pnlDateFilter.BackColor = System.Drawing.Color.Transparent
        Me.pnlDateFilter.Controls.Add(Me.btnSearch)
        Me.pnlDateFilter.Controls.Add(Me.dtpTO)
        Me.pnlDateFilter.Controls.Add(Me.Label1)
        Me.pnlDateFilter.Controls.Add(Me.Label8)
        Me.pnlDateFilter.Controls.Add(Me.dtpFROM)
        Me.pnlDateFilter.Location = New System.Drawing.Point(150, 76)
        Me.pnlDateFilter.Name = "pnlDateFilter"
        Me.pnlDateFilter.Size = New System.Drawing.Size(549, 35)
        Me.pnlDateFilter.TabIndex = 246
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSearch.BackColor = System.Drawing.Color.Green
        Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(366, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(97, 29)
        Me.btnSearch.TabIndex = 246
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'pnlProfileSearch
        '
        Me.pnlProfileSearch.BackColor = System.Drawing.Color.Transparent
        Me.pnlProfileSearch.Controls.Add(Me.lblSearchBy)
        Me.pnlProfileSearch.Controls.Add(Me.txtProfileSearch)
        Me.pnlProfileSearch.Location = New System.Drawing.Point(150, 76)
        Me.pnlProfileSearch.Name = "pnlProfileSearch"
        Me.pnlProfileSearch.Size = New System.Drawing.Size(388, 35)
        Me.pnlProfileSearch.TabIndex = 247
        '
        'pnlSearchList
        '
        Me.pnlSearchList.BackColor = System.Drawing.Color.Transparent
        Me.pnlSearchList.Controls.Add(Me.cmbFilter)
        Me.pnlSearchList.Controls.Add(Me.Label15)
        Me.pnlSearchList.Controls.Add(Me.txtSearch)
        Me.pnlSearchList.Location = New System.Drawing.Point(150, 76)
        Me.pnlSearchList.Name = "pnlSearchList"
        Me.pnlSearchList.Size = New System.Drawing.Size(511, 35)
        Me.pnlSearchList.TabIndex = 248
        '
        'cmbFilter
        '
        Me.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilter.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Items.AddRange(New Object() {"", "PRACTICUM ID", "NAME", "COURSE", "VENUE", "ASSIGNMENT", "BATCH"})
        Me.cmbFilter.Location = New System.Drawing.Point(95, 3)
        Me.cmbFilter.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(182, 29)
        Me.cmbFilter.TabIndex = 242
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(1, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 19)
        Me.Label15.TabIndex = 240
        Me.Label15.Text = "SEARCH BY:"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(285, 3)
        Me.txtSearch.MaxLength = 50
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(219, 27)
        Me.txtSearch.TabIndex = 241
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnPrintRecord
        '
        Me.btnPrintRecord.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPrintRecord.BackColor = System.Drawing.Color.Green
        Me.btnPrintRecord.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPrintRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintRecord.ForeColor = System.Drawing.Color.White
        Me.btnPrintRecord.Location = New System.Drawing.Point(1041, 76)
        Me.btnPrintRecord.Name = "btnPrintRecord"
        Me.btnPrintRecord.Size = New System.Drawing.Size(66, 29)
        Me.btnPrintRecord.TabIndex = 249
        Me.btnPrintRecord.Text = "Print"
        Me.btnPrintRecord.UseVisualStyleBackColor = False
        '
        'btnPrintProfile
        '
        Me.btnPrintProfile.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPrintProfile.BackColor = System.Drawing.Color.Green
        Me.btnPrintProfile.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPrintProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintProfile.ForeColor = System.Drawing.Color.White
        Me.btnPrintProfile.Location = New System.Drawing.Point(1041, 76)
        Me.btnPrintProfile.Name = "btnPrintProfile"
        Me.btnPrintProfile.Size = New System.Drawing.Size(66, 29)
        Me.btnPrintProfile.TabIndex = 250
        Me.btnPrintProfile.Text = "Print"
        Me.btnPrintProfile.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(373, 428)
        Me.Label16.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(101, 25)
        Me.Label16.TabIndex = 288
        Me.Label16.Text = "Total Hours:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalHours
        '
        Me.lblTotalHours.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalHours.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalHours.ForeColor = System.Drawing.Color.Black
        Me.lblTotalHours.Location = New System.Drawing.Point(469, 428)
        Me.lblTotalHours.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTotalHours.Name = "lblTotalHours"
        Me.lblTotalHours.Size = New System.Drawing.Size(224, 25)
        Me.lblTotalHours.TabIndex = 289
        Me.lblTotalHours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1130, 585)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPrintProfile)
        Me.Controls.Add(Me.btnPrintRecord)
        Me.Controls.Add(Me.pnlSearchList)
        Me.Controls.Add(Me.pnlDateFilter)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.LogPanel)
        Me.Controls.Add(Me.pnlProfileSearch)
        Me.Controls.Add(Me.pnlPracticums)
        Me.Controls.Add(Me.dgvPracticumRecord)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.LogPanel.ResumeLayout(False)
        Me.LogPanel.PerformLayout()
        CType(Me.dgvPracticumRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPracticums.ResumeLayout(False)
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPersonalRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDateFilter.ResumeLayout(False)
        Me.pnlDateFilter.PerformLayout()
        Me.pnlProfileSearch.ResumeLayout(False)
        Me.pnlProfileSearch.PerformLayout()
        Me.pnlSearchList.ResumeLayout(False)
        Me.pnlSearchList.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents LogPanel As System.Windows.Forms.Panel
    Friend WithEvents btnProfile As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnRecords As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAllLogs As System.Windows.Forms.Button
    Friend WithEvents dgvPracticumRecord As System.Windows.Forms.DataGridView
    Friend WithEvents PrintPreviewDialog2 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument2 As System.Drawing.Printing.PrintDocument
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pnlPracticums As System.Windows.Forms.Panel
    Friend WithEvents dgvPersonalRecord As System.Windows.Forms.DataGridView
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblPracticumID As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents pbProfile As System.Windows.Forms.PictureBox
    Friend WithEvents lblEndDate As System.Windows.Forms.Label
    Friend WithEvents lblStartDate As System.Windows.Forms.Label
    Friend WithEvents lblSY As System.Windows.Forms.Label
    Friend WithEvents lblBatch As System.Windows.Forms.Label
    Friend WithEvents lblVenue As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents lblAssignment As System.Windows.Forms.Label
    Friend WithEvents txtProfileSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblSearchBy As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFROM As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpTO As System.Windows.Forms.DateTimePicker
    Friend WithEvents pnlDateFilter As System.Windows.Forms.Panel
    Friend WithEvents pnlProfileSearch As System.Windows.Forms.Panel
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents pnlSearchList As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmbFilter As System.Windows.Forms.ComboBox
    Friend WithEvents btnPrintRecord As System.Windows.Forms.Button
    Friend WithEvents btnPrintProfile As System.Windows.Forms.Button
    Friend WithEvents lblTotalHours As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
