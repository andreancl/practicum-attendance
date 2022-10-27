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
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnPrintdgv = New System.Windows.Forms.Button()
        Me.txtSearchAtt = New System.Windows.Forms.TextBox()
        Me.LogPanel = New System.Windows.Forms.Panel()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRecords = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAllLogs = New System.Windows.Forms.Button()
        Me.btnMonthly = New System.Windows.Forms.Button()
        Me.btnWeekly = New System.Windows.Forms.Button()
        Me.btnDaily = New System.Windows.Forms.Button()
        Me.txtProfileSearch = New System.Windows.Forms.TextBox()
        Me.dgvPracticumRecord = New System.Windows.Forms.DataGridView()
        Me.lblSearchBy = New System.Windows.Forms.Label()
        Me.lblSB = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog2 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlPracticums = New System.Windows.Forms.Panel()
        Me.pbProfile = New System.Windows.Forms.PictureBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dgvPersonalRecord = New System.Windows.Forms.DataGridView()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.lblSY = New System.Windows.Forms.Label()
        Me.lblBatch = New System.Windows.Forms.Label()
        Me.lblAssignment = New System.Windows.Forms.Label()
        Me.lblVenue = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblPracticumID = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LogPanel.SuspendLayout()
        CType(Me.dgvPracticumRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPracticums.SuspendLayout()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPersonalRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(423, 79)
        Me.txtSearch.MaxLength = 35
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(229, 26)
        Me.txtSearch.TabIndex = 177
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbFilter
        '
        Me.cmbFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilter.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFilter.ForeColor = System.Drawing.Color.Black
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Items.AddRange(New Object() {"", "NAME", "PRACTICUM ID", "COURSE", "VENUE", "ASSIGNMENT", "BATCH"})
        Me.cmbFilter.Location = New System.Drawing.Point(255, 76)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(162, 29)
        Me.cmbFilter.TabIndex = 176
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
        'btnPrintdgv
        '
        Me.btnPrintdgv.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPrintdgv.BackColor = System.Drawing.Color.Green
        Me.btnPrintdgv.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPrintdgv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintdgv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintdgv.ForeColor = System.Drawing.Color.White
        Me.btnPrintdgv.Location = New System.Drawing.Point(1041, 76)
        Me.btnPrintdgv.Name = "btnPrintdgv"
        Me.btnPrintdgv.Size = New System.Drawing.Size(66, 29)
        Me.btnPrintdgv.TabIndex = 230
        Me.btnPrintdgv.Text = "Print"
        Me.btnPrintdgv.UseVisualStyleBackColor = False
        '
        'txtSearchAtt
        '
        Me.txtSearchAtt.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtSearchAtt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchAtt.ForeColor = System.Drawing.Color.Black
        Me.txtSearchAtt.Location = New System.Drawing.Point(382, 79)
        Me.txtSearchAtt.MaxLength = 7
        Me.txtSearchAtt.Name = "txtSearchAtt"
        Me.txtSearchAtt.Size = New System.Drawing.Size(229, 26)
        Me.txtSearchAtt.TabIndex = 231
        Me.txtSearchAtt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.LogPanel.Controls.Add(Me.btnMonthly)
        Me.LogPanel.Controls.Add(Me.btnWeekly)
        Me.LogPanel.Controls.Add(Me.btnDaily)
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
        Me.btnProfile.Location = New System.Drawing.Point(2, 338)
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
        Me.btnRecords.Location = New System.Drawing.Point(2, 408)
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
        Me.Label2.Location = New System.Drawing.Point(10, 312)
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
        Me.btnAllLogs.Location = New System.Drawing.Point(2, 241)
        Me.btnAllLogs.Name = "btnAllLogs"
        Me.btnAllLogs.Size = New System.Drawing.Size(121, 64)
        Me.btnAllLogs.TabIndex = 4
        Me.btnAllLogs.Text = "All Logs"
        Me.btnAllLogs.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAllLogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAllLogs.UseVisualStyleBackColor = True
        '
        'btnMonthly
        '
        Me.btnMonthly.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMonthly.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMonthly.Image = CType(resources.GetObject("btnMonthly.Image"), System.Drawing.Image)
        Me.btnMonthly.Location = New System.Drawing.Point(2, 172)
        Me.btnMonthly.Name = "btnMonthly"
        Me.btnMonthly.Size = New System.Drawing.Size(121, 64)
        Me.btnMonthly.TabIndex = 3
        Me.btnMonthly.Text = "Monthly"
        Me.btnMonthly.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMonthly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnMonthly.UseVisualStyleBackColor = True
        '
        'btnWeekly
        '
        Me.btnWeekly.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnWeekly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWeekly.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWeekly.Image = CType(resources.GetObject("btnWeekly.Image"), System.Drawing.Image)
        Me.btnWeekly.Location = New System.Drawing.Point(2, 104)
        Me.btnWeekly.Name = "btnWeekly"
        Me.btnWeekly.Size = New System.Drawing.Size(121, 64)
        Me.btnWeekly.TabIndex = 2
        Me.btnWeekly.Text = "Weekly"
        Me.btnWeekly.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnWeekly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnWeekly.UseVisualStyleBackColor = True
        '
        'btnDaily
        '
        Me.btnDaily.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDaily.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDaily.Image = CType(resources.GetObject("btnDaily.Image"), System.Drawing.Image)
        Me.btnDaily.Location = New System.Drawing.Point(2, 36)
        Me.btnDaily.Name = "btnDaily"
        Me.btnDaily.Size = New System.Drawing.Size(121, 64)
        Me.btnDaily.TabIndex = 0
        Me.btnDaily.Text = "Daily"
        Me.btnDaily.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDaily.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDaily.UseVisualStyleBackColor = True
        '
        'txtProfileSearch
        '
        Me.txtProfileSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtProfileSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfileSearch.ForeColor = System.Drawing.Color.Black
        Me.txtProfileSearch.Location = New System.Drawing.Point(383, 78)
        Me.txtProfileSearch.MaxLength = 7
        Me.txtProfileSearch.Name = "txtProfileSearch"
        Me.txtProfileSearch.Size = New System.Drawing.Size(229, 26)
        Me.txtProfileSearch.TabIndex = 223
        Me.txtProfileSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'lblSearchBy
        '
        Me.lblSearchBy.AutoSize = True
        Me.lblSearchBy.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchBy.ForeColor = System.Drawing.Color.Black
        Me.lblSearchBy.Location = New System.Drawing.Point(156, 82)
        Me.lblSearchBy.Name = "lblSearchBy"
        Me.lblSearchBy.Size = New System.Drawing.Size(96, 19)
        Me.lblSearchBy.TabIndex = 175
        Me.lblSearchBy.Text = "SEARCH BY:"
        '
        'lblSB
        '
        Me.lblSB.AutoSize = True
        Me.lblSB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSB.ForeColor = System.Drawing.Color.Black
        Me.lblSB.Location = New System.Drawing.Point(169, 82)
        Me.lblSB.Name = "lblSB"
        Me.lblSB.Size = New System.Drawing.Size(208, 19)
        Me.lblSB.TabIndex = 235
        Me.lblSB.Text = "SEARCH BY PRACTICUM ID:"
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
        Me.pnlPracticums.Controls.Add(Me.pbProfile)
        Me.pnlPracticums.Controls.Add(Me.Label19)
        Me.pnlPracticums.Controls.Add(Me.dgvPersonalRecord)
        Me.pnlPracticums.Controls.Add(Me.lblEndDate)
        Me.pnlPracticums.Controls.Add(Me.lblStartDate)
        Me.pnlPracticums.Controls.Add(Me.lblSY)
        Me.pnlPracticums.Controls.Add(Me.lblBatch)
        Me.pnlPracticums.Controls.Add(Me.lblAssignment)
        Me.pnlPracticums.Controls.Add(Me.lblVenue)
        Me.pnlPracticums.Controls.Add(Me.lblCourse)
        Me.pnlPracticums.Controls.Add(Me.lblFirstName)
        Me.pnlPracticums.Controls.Add(Me.lblLastName)
        Me.pnlPracticums.Controls.Add(Me.lblPracticumID)
        Me.pnlPracticums.Controls.Add(Me.Label14)
        Me.pnlPracticums.Controls.Add(Me.Label5)
        Me.pnlPracticums.Controls.Add(Me.Label6)
        Me.pnlPracticums.Controls.Add(Me.Label13)
        Me.pnlPracticums.Controls.Add(Me.Label7)
        Me.pnlPracticums.Controls.Add(Me.Label8)
        Me.pnlPracticums.Controls.Add(Me.Label9)
        Me.pnlPracticums.Controls.Add(Me.Label10)
        Me.pnlPracticums.Controls.Add(Me.Label11)
        Me.pnlPracticums.Controls.Add(Me.Label12)
        Me.pnlPracticums.Location = New System.Drawing.Point(150, 112)
        Me.pnlPracticums.Name = "pnlPracticums"
        Me.pnlPracticums.Size = New System.Drawing.Size(957, 463)
        Me.pnlPracticums.TabIndex = 239
        '
        'pbProfile
        '
        Me.pbProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbProfile.Location = New System.Drawing.Point(114, 44)
        Me.pbProfile.Name = "pbProfile"
        Me.pbProfile.Size = New System.Drawing.Size(214, 151)
        Me.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProfile.TabIndex = 278
        Me.pbProfile.TabStop = False
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(314, 8)
        Me.Label19.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(224, 25)
        Me.Label19.TabIndex = 275
        Me.Label19.Text = "Practicum Information"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.dgvPersonalRecord.Location = New System.Drawing.Point(407, 44)
        Me.dgvPersonalRecord.Name = "dgvPersonalRecord"
        Me.dgvPersonalRecord.RowHeadersVisible = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.dgvPersonalRecord.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPersonalRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPersonalRecord.Size = New System.Drawing.Size(522, 412)
        Me.dgvPersonalRecord.StandardTab = True
        Me.dgvPersonalRecord.TabIndex = 257
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndDate.Location = New System.Drawing.Point(140, 437)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(0, 21)
        Me.lblEndDate.TabIndex = 256
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartDate.Location = New System.Drawing.Point(140, 411)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(0, 21)
        Me.lblStartDate.TabIndex = 255
        '
        'lblSY
        '
        Me.lblSY.AutoSize = True
        Me.lblSY.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSY.Location = New System.Drawing.Point(140, 386)
        Me.lblSY.Name = "lblSY"
        Me.lblSY.Size = New System.Drawing.Size(0, 21)
        Me.lblSY.TabIndex = 254
        '
        'lblBatch
        '
        Me.lblBatch.AutoSize = True
        Me.lblBatch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBatch.Location = New System.Drawing.Point(140, 359)
        Me.lblBatch.Name = "lblBatch"
        Me.lblBatch.Size = New System.Drawing.Size(0, 21)
        Me.lblBatch.TabIndex = 253
        '
        'lblAssignment
        '
        Me.lblAssignment.AutoSize = True
        Me.lblAssignment.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssignment.Location = New System.Drawing.Point(140, 333)
        Me.lblAssignment.Name = "lblAssignment"
        Me.lblAssignment.Size = New System.Drawing.Size(0, 21)
        Me.lblAssignment.TabIndex = 252
        '
        'lblVenue
        '
        Me.lblVenue.AutoSize = True
        Me.lblVenue.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenue.Location = New System.Drawing.Point(140, 303)
        Me.lblVenue.Name = "lblVenue"
        Me.lblVenue.Size = New System.Drawing.Size(0, 21)
        Me.lblVenue.TabIndex = 251
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.Location = New System.Drawing.Point(140, 277)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(0, 21)
        Me.lblCourse.TabIndex = 250
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(140, 252)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(0, 21)
        Me.lblFirstName.TabIndex = 249
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(140, 225)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(0, 21)
        Me.lblLastName.TabIndex = 248
        '
        'lblPracticumID
        '
        Me.lblPracticumID.AutoSize = True
        Me.lblPracticumID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPracticumID.Location = New System.Drawing.Point(140, 199)
        Me.lblPracticumID.Name = "lblPracticumID"
        Me.lblPracticumID.Size = New System.Drawing.Size(0, 21)
        Me.lblPracticumID.TabIndex = 247
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(16, 433)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(116, 25)
        Me.Label14.TabIndex = 246
        Me.Label14.Text = "End Date:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(16, 407)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 25)
        Me.Label5.TabIndex = 245
        Me.Label5.Text = "Start Date:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(16, 381)
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
        Me.Label13.Location = New System.Drawing.Point(16, 355)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 25)
        Me.Label13.TabIndex = 243
        Me.Label13.Text = "Batch:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(16, 302)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 27)
        Me.Label7.TabIndex = 242
        Me.Label7.Text = "Venue:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(16, 198)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 25)
        Me.Label8.TabIndex = 241
        Me.Label8.Text = "Practicum ID:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(16, 250)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 25)
        Me.Label9.TabIndex = 240
        Me.Label9.Text = "First Name:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(16, 224)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 25)
        Me.Label10.TabIndex = 237
        Me.Label10.Text = "Last Name:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(16, 276)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 25)
        Me.Label11.TabIndex = 238
        Me.Label11.Text = "Course:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(16, 329)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 25)
        Me.Label12.TabIndex = 239
        Me.Label12.Text = "Assignment:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Controls.Add(Me.pnlPracticums)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblSB)
        Me.Controls.Add(Me.LogPanel)
        Me.Controls.Add(Me.txtSearchAtt)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblSearchBy)
        Me.Controls.Add(Me.cmbFilter)
        Me.Controls.Add(Me.dgvPracticumRecord)
        Me.Controls.Add(Me.btnPrintdgv)
        Me.Controls.Add(Me.txtProfileSearch)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.LogPanel.ResumeLayout(False)
        Me.LogPanel.PerformLayout()
        CType(Me.dgvPracticumRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPracticums.ResumeLayout(False)
        Me.pnlPracticums.PerformLayout()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPersonalRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmbFilter As System.Windows.Forms.ComboBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents btnPrintdgv As System.Windows.Forms.Button
    Friend WithEvents txtSearchAtt As System.Windows.Forms.TextBox
    Friend WithEvents LogPanel As System.Windows.Forms.Panel
    Friend WithEvents btnProfile As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnRecords As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAllLogs As System.Windows.Forms.Button
    Friend WithEvents btnMonthly As System.Windows.Forms.Button
    Friend WithEvents btnWeekly As System.Windows.Forms.Button
    Friend WithEvents btnDaily As System.Windows.Forms.Button
    Friend WithEvents txtProfileSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgvPracticumRecord As System.Windows.Forms.DataGridView
    Friend WithEvents lblSearchBy As System.Windows.Forms.Label
    Friend WithEvents lblSB As System.Windows.Forms.Label
    Friend WithEvents PrintPreviewDialog2 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument2 As System.Drawing.Printing.PrintDocument
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pnlPracticums As System.Windows.Forms.Panel
    Friend WithEvents dgvPersonalRecord As System.Windows.Forms.DataGridView
    Friend WithEvents lblEndDate As System.Windows.Forms.Label
    Friend WithEvents lblStartDate As System.Windows.Forms.Label
    Friend WithEvents lblSY As System.Windows.Forms.Label
    Friend WithEvents lblBatch As System.Windows.Forms.Label
    Friend WithEvents lblAssignment As System.Windows.Forms.Label
    Friend WithEvents lblVenue As System.Windows.Forms.Label
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblPracticumID As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents pbProfile As System.Windows.Forms.PictureBox
End Class
