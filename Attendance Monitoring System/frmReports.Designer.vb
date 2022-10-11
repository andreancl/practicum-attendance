<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReports))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRecords = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAllLogs = New System.Windows.Forms.Button()
        Me.btnMonthly = New System.Windows.Forms.Button()
        Me.btnWeekly = New System.Windows.Forms.Button()
        Me.btnDaily = New System.Windows.Forms.Button()
        Me.dgvPracticumRecord = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearchBy = New System.Windows.Forms.Label()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnPrintdgv = New System.Windows.Forms.Button()
        Me.txtSearchAtt = New System.Windows.Forms.TextBox()
        Me.cmbAtt = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvPracticumRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnRecords)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnAllLogs)
        Me.Panel1.Controls.Add(Me.btnMonthly)
        Me.Panel1.Controls.Add(Me.btnWeekly)
        Me.Panel1.Controls.Add(Me.btnDaily)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(125, 585)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "LOGS"
        '
        'btnRecords
        '
        Me.btnRecords.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecords.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecords.Image = CType(resources.GetObject("btnRecords.Image"), System.Drawing.Image)
        Me.btnRecords.Location = New System.Drawing.Point(2, 341)
        Me.btnRecords.Name = "btnRecords"
        Me.btnRecords.Size = New System.Drawing.Size(121, 64)
        Me.btnRecords.TabIndex = 7
        Me.btnRecords.Text = "RECORDS"
        Me.btnRecords.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnRecords.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 314)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "PRACTICUM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 5
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
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Green
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(148, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPracticumRecord.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvPracticumRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPracticumRecord.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPracticumRecord.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvPracticumRecord.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPracticumRecord.Location = New System.Drawing.Point(150, 69)
        Me.dgvPracticumRecord.Name = "dgvPracticumRecord"
        Me.dgvPracticumRecord.RowHeadersVisible = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.dgvPracticumRecord.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvPracticumRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPracticumRecord.Size = New System.Drawing.Size(957, 464)
        Me.dgvPracticumRecord.StandardTab = True
        Me.dgvPracticumRecord.TabIndex = 83
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(423, 37)
        Me.txtSearch.MaxLength = 35
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(229, 26)
        Me.txtSearch.TabIndex = 177
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSearchBy
        '
        Me.lblSearchBy.AutoSize = True
        Me.lblSearchBy.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchBy.ForeColor = System.Drawing.Color.Black
        Me.lblSearchBy.Location = New System.Drawing.Point(156, 40)
        Me.lblSearchBy.Name = "lblSearchBy"
        Me.lblSearchBy.Size = New System.Drawing.Size(96, 19)
        Me.lblSearchBy.TabIndex = 175
        Me.lblSearchBy.Text = "SEARCH BY:"
        '
        'cmbFilter
        '
        Me.cmbFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilter.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFilter.ForeColor = System.Drawing.Color.Black
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Items.AddRange(New Object() {"", "NAME", "PRACTICUM ID", "COURSE", "VENUE", "ASSIGNMENT", "BATCH"})
        Me.cmbFilter.Location = New System.Drawing.Point(255, 34)
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
        Me.btnPrintdgv.Location = New System.Drawing.Point(1041, 34)
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
        Me.txtSearchAtt.Location = New System.Drawing.Point(423, 37)
        Me.txtSearchAtt.MaxLength = 35
        Me.txtSearchAtt.Name = "txtSearchAtt"
        Me.txtSearchAtt.Size = New System.Drawing.Size(229, 26)
        Me.txtSearchAtt.TabIndex = 231
        Me.txtSearchAtt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbAtt
        '
        Me.cmbAtt.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.cmbAtt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAtt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAtt.ForeColor = System.Drawing.Color.Black
        Me.cmbAtt.FormattingEnabled = True
        Me.cmbAtt.Items.AddRange(New Object() {"", "NAME", "PRACTICUM ID"})
        Me.cmbAtt.Location = New System.Drawing.Point(255, 34)
        Me.cmbAtt.Name = "cmbAtt"
        Me.cmbAtt.Size = New System.Drawing.Size(162, 29)
        Me.cmbAtt.TabIndex = 232
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1130, 585)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbAtt)
        Me.Controls.Add(Me.txtSearchAtt)
        Me.Controls.Add(Me.btnPrintdgv)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblSearchBy)
        Me.Controls.Add(Me.cmbFilter)
        Me.Controls.Add(Me.dgvPracticumRecord)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvPracticumRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnRecords As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAllLogs As System.Windows.Forms.Button
    Friend WithEvents btnMonthly As System.Windows.Forms.Button
    Friend WithEvents btnWeekly As System.Windows.Forms.Button
    Friend WithEvents btnDaily As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvPracticumRecord As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblSearchBy As System.Windows.Forms.Label
    Friend WithEvents cmbFilter As System.Windows.Forms.ComboBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents btnPrintdgv As System.Windows.Forms.Button
    Friend WithEvents txtSearchAtt As System.Windows.Forms.TextBox
    Friend WithEvents cmbAtt As System.Windows.Forms.ComboBox
End Class
