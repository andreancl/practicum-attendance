<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogIn))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel_LogIn = New System.Windows.Forms.Panel()
        Me.Panel_Username = New System.Windows.Forms.Panel()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnForgotPassword = New System.Windows.Forms.Button()
        Me.chckboxShowPassword = New System.Windows.Forms.CheckBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Panel_Password = New System.Windows.Forms.Panel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel_ForgotPass = New System.Windows.Forms.Panel()
        Me.Panel_SecretA = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSecretAnswer = New System.Windows.Forms.TextBox()
        Me.Panel_ForgotPass_Username = New System.Windows.Forms.Panel()
        Me.txtForgotPass_Username = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.chkbxForgotPass_ShowSA = New System.Windows.Forms.CheckBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Panel_SecretQ = New System.Windows.Forms.Panel()
        Me.cmbSecretQuestion = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel_SetNewPassword = New System.Windows.Forms.Panel()
        Me.Panel_NewPassword = New System.Windows.Forms.Panel()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.lbNewPassword = New System.Windows.Forms.Label()
        Me.btn_SetNP_Back = New System.Windows.Forms.Button()
        Me.chckbox_SetNP_ShowPass = New System.Windows.Forms.CheckBox()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.Panel_ConfirmNewPassword = New System.Windows.Forms.Panel()
        Me.txtConfirmNewPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel_LogIn.SuspendLayout()
        Me.Panel_Username.SuspendLayout()
        Me.Panel_Password.SuspendLayout()
        Me.Panel_ForgotPass.SuspendLayout()
        Me.Panel_SecretA.SuspendLayout()
        Me.Panel_ForgotPass_Username.SuspendLayout()
        Me.Panel_SecretQ.SuspendLayout()
        Me.Panel_SetNewPassword.SuspendLayout()
        Me.Panel_NewPassword.SuspendLayout()
        Me.Panel_ConfirmNewPassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 530)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(202, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 22)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "SYSTEM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(264, 22)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "ATTENDANCE MONITORING"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(156, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 22)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "PRACTICUM"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "THE UNIVERSITY OF MANILA"
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox.Image = CType(resources.GetObject("PictureBox.Image"), System.Drawing.Image)
        Me.PictureBox.Location = New System.Drawing.Point(64, 31)
        Me.PictureBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(171, 150)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox.TabIndex = 10
        Me.PictureBox.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.lblTitle)
        Me.Panel2.Controls.Add(Me.Panel_LogIn)
        Me.Panel2.Controls.Add(Me.Panel_ForgotPass)
        Me.Panel2.Controls.Add(Me.Panel_SetNewPassword)
        Me.Panel2.Location = New System.Drawing.Point(300, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(450, 530)
        Me.Panel2.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnClose.Location = New System.Drawing.Point(407, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(43, 46)
        Me.btnClose.TabIndex = 35
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Green
        Me.lblTitle.Location = New System.Drawing.Point(24, 151)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(282, 30)
        Me.lblTitle.TabIndex = 12
        Me.lblTitle.Text = "Log in to your account"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Panel_LogIn
        '
        Me.Panel_LogIn.Controls.Add(Me.Panel_Username)
        Me.Panel_LogIn.Controls.Add(Me.btnForgotPassword)
        Me.Panel_LogIn.Controls.Add(Me.chckboxShowPassword)
        Me.Panel_LogIn.Controls.Add(Me.btnLogin)
        Me.Panel_LogIn.Controls.Add(Me.Panel_Password)
        Me.Panel_LogIn.Location = New System.Drawing.Point(3, 196)
        Me.Panel_LogIn.Name = "Panel_LogIn"
        Me.Panel_LogIn.Size = New System.Drawing.Size(444, 190)
        Me.Panel_LogIn.TabIndex = 36
        '
        'Panel_Username
        '
        Me.Panel_Username.BackColor = System.Drawing.Color.White
        Me.Panel_Username.Controls.Add(Me.txtUsername)
        Me.Panel_Username.Controls.Add(Me.lblUsername)
        Me.Panel_Username.Location = New System.Drawing.Point(0, 3)
        Me.Panel_Username.Name = "Panel_Username"
        Me.Panel_Username.Size = New System.Drawing.Size(450, 45)
        Me.Panel_Username.TabIndex = 16
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Green
        Me.txtUsername.Location = New System.Drawing.Point(140, 13)
        Me.txtUsername.MaxLength = 12
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(298, 20)
        Me.txtUsername.TabIndex = 6
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Green
        Me.lblUsername.Location = New System.Drawing.Point(3, 10)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(118, 24)
        Me.lblUsername.TabIndex = 5
        Me.lblUsername.Text = "Username:"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnForgotPassword
        '
        Me.btnForgotPassword.BackColor = System.Drawing.SystemColors.Control
        Me.btnForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnForgotPassword.FlatAppearance.BorderSize = 0
        Me.btnForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnForgotPassword.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForgotPassword.ForeColor = System.Drawing.Color.Green
        Me.btnForgotPassword.Location = New System.Drawing.Point(241, 159)
        Me.btnForgotPassword.Name = "btnForgotPassword"
        Me.btnForgotPassword.Size = New System.Drawing.Size(141, 25)
        Me.btnForgotPassword.TabIndex = 19
        Me.btnForgotPassword.TabStop = False
        Me.btnForgotPassword.Text = "FORGOT PASSWORD?"
        Me.btnForgotPassword.UseVisualStyleBackColor = False
        '
        'chckboxShowPassword
        '
        Me.chckboxShowPassword.AutoSize = True
        Me.chckboxShowPassword.BackColor = System.Drawing.Color.Transparent
        Me.chckboxShowPassword.FlatAppearance.BorderSize = 0
        Me.chckboxShowPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckboxShowPassword.ForeColor = System.Drawing.Color.Green
        Me.chckboxShowPassword.Location = New System.Drawing.Point(140, 104)
        Me.chckboxShowPassword.Name = "chckboxShowPassword"
        Me.chckboxShowPassword.Size = New System.Drawing.Size(147, 25)
        Me.chckboxShowPassword.TabIndex = 3
        Me.chckboxShowPassword.TabStop = False
        Me.chckboxShowPassword.Text = "Show Password"
        Me.chckboxShowPassword.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Green
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(78, 153)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(148, 35)
        Me.btnLogin.TabIndex = 18
        Me.btnLogin.TabStop = False
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Panel_Password
        '
        Me.Panel_Password.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_Password.Controls.Add(Me.txtPassword)
        Me.Panel_Password.Controls.Add(Me.Label5)
        Me.Panel_Password.Location = New System.Drawing.Point(0, 53)
        Me.Panel_Password.Name = "Panel_Password"
        Me.Panel_Password.Size = New System.Drawing.Size(450, 45)
        Me.Panel_Password.TabIndex = 17
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Control
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Green
        Me.txtPassword.Location = New System.Drawing.Point(140, 12)
        Me.txtPassword.MaxLength = 12
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(298, 20)
        Me.txtPassword.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Password:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel_ForgotPass
        '
        Me.Panel_ForgotPass.Controls.Add(Me.Panel_SecretA)
        Me.Panel_ForgotPass.Controls.Add(Me.Panel_ForgotPass_Username)
        Me.Panel_ForgotPass.Controls.Add(Me.btnBack)
        Me.Panel_ForgotPass.Controls.Add(Me.chkbxForgotPass_ShowSA)
        Me.Panel_ForgotPass.Controls.Add(Me.btnSubmit)
        Me.Panel_ForgotPass.Controls.Add(Me.Panel_SecretQ)
        Me.Panel_ForgotPass.Location = New System.Drawing.Point(3, 196)
        Me.Panel_ForgotPass.Name = "Panel_ForgotPass"
        Me.Panel_ForgotPass.Size = New System.Drawing.Size(444, 248)
        Me.Panel_ForgotPass.TabIndex = 37
        '
        'Panel_SecretA
        '
        Me.Panel_SecretA.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_SecretA.Controls.Add(Me.Label6)
        Me.Panel_SecretA.Controls.Add(Me.txtSecretAnswer)
        Me.Panel_SecretA.Location = New System.Drawing.Point(0, 102)
        Me.Panel_SecretA.Name = "Panel_SecretA"
        Me.Panel_SecretA.Size = New System.Drawing.Size(450, 45)
        Me.Panel_SecretA.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(52, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 42)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Secret" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Answer:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSecretAnswer
        '
        Me.txtSecretAnswer.BackColor = System.Drawing.SystemColors.Control
        Me.txtSecretAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSecretAnswer.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecretAnswer.ForeColor = System.Drawing.Color.Green
        Me.txtSecretAnswer.Location = New System.Drawing.Point(140, 12)
        Me.txtSecretAnswer.MaxLength = 40
        Me.txtSecretAnswer.Name = "txtSecretAnswer"
        Me.txtSecretAnswer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSecretAnswer.Size = New System.Drawing.Size(298, 20)
        Me.txtSecretAnswer.TabIndex = 7
        '
        'Panel_ForgotPass_Username
        '
        Me.Panel_ForgotPass_Username.BackColor = System.Drawing.Color.White
        Me.Panel_ForgotPass_Username.Controls.Add(Me.txtForgotPass_Username)
        Me.Panel_ForgotPass_Username.Controls.Add(Me.Label7)
        Me.Panel_ForgotPass_Username.Location = New System.Drawing.Point(0, 3)
        Me.Panel_ForgotPass_Username.Name = "Panel_ForgotPass_Username"
        Me.Panel_ForgotPass_Username.Size = New System.Drawing.Size(450, 45)
        Me.Panel_ForgotPass_Username.TabIndex = 16
        '
        'txtForgotPass_Username
        '
        Me.txtForgotPass_Username.BackColor = System.Drawing.Color.White
        Me.txtForgotPass_Username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtForgotPass_Username.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtForgotPass_Username.ForeColor = System.Drawing.Color.Green
        Me.txtForgotPass_Username.Location = New System.Drawing.Point(140, 13)
        Me.txtForgotPass_Username.MaxLength = 12
        Me.txtForgotPass_Username.Name = "txtForgotPass_Username"
        Me.txtForgotPass_Username.Size = New System.Drawing.Size(298, 20)
        Me.txtForgotPass_Username.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Green
        Me.Label7.Location = New System.Drawing.Point(6, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 24)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Username:"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.Control
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Green
        Me.btnBack.Location = New System.Drawing.Point(241, 204)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(141, 25)
        Me.btnBack.TabIndex = 19
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'chkbxForgotPass_ShowSA
        '
        Me.chkbxForgotPass_ShowSA.AutoSize = True
        Me.chkbxForgotPass_ShowSA.BackColor = System.Drawing.Color.Transparent
        Me.chkbxForgotPass_ShowSA.FlatAppearance.BorderSize = 0
        Me.chkbxForgotPass_ShowSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkbxForgotPass_ShowSA.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbxForgotPass_ShowSA.ForeColor = System.Drawing.Color.Green
        Me.chkbxForgotPass_ShowSA.Location = New System.Drawing.Point(140, 153)
        Me.chkbxForgotPass_ShowSA.Name = "chkbxForgotPass_ShowSA"
        Me.chkbxForgotPass_ShowSA.Size = New System.Drawing.Size(184, 25)
        Me.chkbxForgotPass_ShowSA.TabIndex = 3
        Me.chkbxForgotPass_ShowSA.TabStop = False
        Me.chkbxForgotPass_ShowSA.Text = "Show Secret Answer"
        Me.chkbxForgotPass_ShowSA.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Green
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(78, 198)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(148, 35)
        Me.btnSubmit.TabIndex = 18
        Me.btnSubmit.TabStop = False
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Panel_SecretQ
        '
        Me.Panel_SecretQ.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_SecretQ.Controls.Add(Me.cmbSecretQuestion)
        Me.Panel_SecretQ.Controls.Add(Me.Label8)
        Me.Panel_SecretQ.Location = New System.Drawing.Point(0, 53)
        Me.Panel_SecretQ.Name = "Panel_SecretQ"
        Me.Panel_SecretQ.Size = New System.Drawing.Size(450, 45)
        Me.Panel_SecretQ.TabIndex = 17
        '
        'cmbSecretQuestion
        '
        Me.cmbSecretQuestion.BackColor = System.Drawing.SystemColors.Control
        Me.cmbSecretQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSecretQuestion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSecretQuestion.ForeColor = System.Drawing.Color.Green
        Me.cmbSecretQuestion.FormattingEnabled = True
        Me.cmbSecretQuestion.Items.AddRange(New Object() {"", "What is the name of your first pet?", "What is your favorite color?", "In what city were you born?", "What was your father middle name?", "What was your childhood nickname?", "What is your oldest sibling name?"})
        Me.cmbSecretQuestion.Location = New System.Drawing.Point(140, 9)
        Me.cmbSecretQuestion.MaxLength = 40
        Me.cmbSecretQuestion.Name = "cmbSecretQuestion"
        Me.cmbSecretQuestion.Size = New System.Drawing.Size(298, 29)
        Me.cmbSecretQuestion.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Green
        Me.Label8.Location = New System.Drawing.Point(40, 1)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 42)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Secret" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Question:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel_SetNewPassword
        '
        Me.Panel_SetNewPassword.Controls.Add(Me.Panel_NewPassword)
        Me.Panel_SetNewPassword.Controls.Add(Me.btn_SetNP_Back)
        Me.Panel_SetNewPassword.Controls.Add(Me.chckbox_SetNP_ShowPass)
        Me.Panel_SetNewPassword.Controls.Add(Me.btnChangePassword)
        Me.Panel_SetNewPassword.Controls.Add(Me.Panel_ConfirmNewPassword)
        Me.Panel_SetNewPassword.Location = New System.Drawing.Point(3, 200)
        Me.Panel_SetNewPassword.Name = "Panel_SetNewPassword"
        Me.Panel_SetNewPassword.Size = New System.Drawing.Size(444, 190)
        Me.Panel_SetNewPassword.TabIndex = 38
        Me.Panel_SetNewPassword.Visible = False
        '
        'Panel_NewPassword
        '
        Me.Panel_NewPassword.BackColor = System.Drawing.Color.White
        Me.Panel_NewPassword.Controls.Add(Me.txtNewPassword)
        Me.Panel_NewPassword.Controls.Add(Me.lbNewPassword)
        Me.Panel_NewPassword.Location = New System.Drawing.Point(0, 3)
        Me.Panel_NewPassword.Name = "Panel_NewPassword"
        Me.Panel_NewPassword.Size = New System.Drawing.Size(450, 45)
        Me.Panel_NewPassword.TabIndex = 16
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BackColor = System.Drawing.Color.White
        Me.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNewPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.ForeColor = System.Drawing.Color.Green
        Me.txtNewPassword.Location = New System.Drawing.Point(140, 13)
        Me.txtNewPassword.MaxLength = 12
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(298, 20)
        Me.txtNewPassword.TabIndex = 6
        '
        'lbNewPassword
        '
        Me.lbNewPassword.AutoSize = True
        Me.lbNewPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNewPassword.ForeColor = System.Drawing.Color.Green
        Me.lbNewPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbNewPassword.Location = New System.Drawing.Point(28, 1)
        Me.lbNewPassword.Name = "lbNewPassword"
        Me.lbNewPassword.Size = New System.Drawing.Size(86, 42)
        Me.lbNewPassword.TabIndex = 5
        Me.lbNewPassword.Text = "New" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password:"
        Me.lbNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_SetNP_Back
        '
        Me.btn_SetNP_Back.BackColor = System.Drawing.SystemColors.Control
        Me.btn_SetNP_Back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SetNP_Back.FlatAppearance.BorderSize = 0
        Me.btn_SetNP_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SetNP_Back.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SetNP_Back.ForeColor = System.Drawing.Color.Green
        Me.btn_SetNP_Back.Location = New System.Drawing.Point(241, 159)
        Me.btn_SetNP_Back.Name = "btn_SetNP_Back"
        Me.btn_SetNP_Back.Size = New System.Drawing.Size(141, 25)
        Me.btn_SetNP_Back.TabIndex = 19
        Me.btn_SetNP_Back.TabStop = False
        Me.btn_SetNP_Back.Text = "BACK"
        Me.btn_SetNP_Back.UseVisualStyleBackColor = False
        '
        'chckbox_SetNP_ShowPass
        '
        Me.chckbox_SetNP_ShowPass.AutoSize = True
        Me.chckbox_SetNP_ShowPass.BackColor = System.Drawing.Color.Transparent
        Me.chckbox_SetNP_ShowPass.FlatAppearance.BorderSize = 0
        Me.chckbox_SetNP_ShowPass.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckbox_SetNP_ShowPass.ForeColor = System.Drawing.Color.Green
        Me.chckbox_SetNP_ShowPass.Location = New System.Drawing.Point(140, 104)
        Me.chckbox_SetNP_ShowPass.Name = "chckbox_SetNP_ShowPass"
        Me.chckbox_SetNP_ShowPass.Size = New System.Drawing.Size(147, 25)
        Me.chckbox_SetNP_ShowPass.TabIndex = 3
        Me.chckbox_SetNP_ShowPass.TabStop = False
        Me.chckbox_SetNP_ShowPass.Text = "Show Password"
        Me.chckbox_SetNP_ShowPass.UseVisualStyleBackColor = False
        '
        'btnChangePassword
        '
        Me.btnChangePassword.BackColor = System.Drawing.Color.Green
        Me.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangePassword.FlatAppearance.BorderSize = 0
        Me.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePassword.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePassword.ForeColor = System.Drawing.Color.White
        Me.btnChangePassword.Location = New System.Drawing.Point(78, 153)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(148, 35)
        Me.btnChangePassword.TabIndex = 18
        Me.btnChangePassword.TabStop = False
        Me.btnChangePassword.Text = "CONFIRM"
        Me.btnChangePassword.UseVisualStyleBackColor = False
        '
        'Panel_ConfirmNewPassword
        '
        Me.Panel_ConfirmNewPassword.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_ConfirmNewPassword.Controls.Add(Me.txtConfirmNewPassword)
        Me.Panel_ConfirmNewPassword.Controls.Add(Me.lblPassword)
        Me.Panel_ConfirmNewPassword.Location = New System.Drawing.Point(0, 53)
        Me.Panel_ConfirmNewPassword.Name = "Panel_ConfirmNewPassword"
        Me.Panel_ConfirmNewPassword.Size = New System.Drawing.Size(450, 45)
        Me.Panel_ConfirmNewPassword.TabIndex = 17
        '
        'txtConfirmNewPassword
        '
        Me.txtConfirmNewPassword.BackColor = System.Drawing.SystemColors.Control
        Me.txtConfirmNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConfirmNewPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmNewPassword.ForeColor = System.Drawing.Color.Green
        Me.txtConfirmNewPassword.Location = New System.Drawing.Point(140, 12)
        Me.txtConfirmNewPassword.MaxLength = 12
        Me.txtConfirmNewPassword.Name = "txtConfirmNewPassword"
        Me.txtConfirmNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmNewPassword.Size = New System.Drawing.Size(298, 20)
        Me.txtConfirmNewPassword.TabIndex = 7
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Green
        Me.lblPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPassword.Location = New System.Drawing.Point(3, 1)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(111, 42)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Confirm New" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password:"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(750, 530)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.LimeGreen
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel_LogIn.ResumeLayout(False)
        Me.Panel_LogIn.PerformLayout()
        Me.Panel_Username.ResumeLayout(False)
        Me.Panel_Username.PerformLayout()
        Me.Panel_Password.ResumeLayout(False)
        Me.Panel_Password.PerformLayout()
        Me.Panel_ForgotPass.ResumeLayout(False)
        Me.Panel_ForgotPass.PerformLayout()
        Me.Panel_SecretA.ResumeLayout(False)
        Me.Panel_SecretA.PerformLayout()
        Me.Panel_ForgotPass_Username.ResumeLayout(False)
        Me.Panel_ForgotPass_Username.PerformLayout()
        Me.Panel_SecretQ.ResumeLayout(False)
        Me.Panel_SecretQ.PerformLayout()
        Me.Panel_SetNewPassword.ResumeLayout(False)
        Me.Panel_SetNewPassword.PerformLayout()
        Me.Panel_NewPassword.ResumeLayout(False)
        Me.Panel_NewPassword.PerformLayout()
        Me.Panel_ConfirmNewPassword.ResumeLayout(False)
        Me.Panel_ConfirmNewPassword.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Panel_LogIn As System.Windows.Forms.Panel
    Friend WithEvents Panel_Username As System.Windows.Forms.Panel
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents btnForgotPassword As System.Windows.Forms.Button
    Friend WithEvents chckboxShowPassword As System.Windows.Forms.CheckBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents Panel_Password As System.Windows.Forms.Panel
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel_ForgotPass As System.Windows.Forms.Panel
    Friend WithEvents Panel_SecretA As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSecretAnswer As System.Windows.Forms.TextBox
    Friend WithEvents Panel_ForgotPass_Username As System.Windows.Forms.Panel
    Friend WithEvents txtForgotPass_Username As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents chkbxForgotPass_ShowSA As System.Windows.Forms.CheckBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents Panel_SecretQ As System.Windows.Forms.Panel
    Friend WithEvents cmbSecretQuestion As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel_SetNewPassword As System.Windows.Forms.Panel
    Friend WithEvents Panel_NewPassword As System.Windows.Forms.Panel
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents lbNewPassword As System.Windows.Forms.Label
    Friend WithEvents btn_SetNP_Back As System.Windows.Forms.Button
    Friend WithEvents chckbox_SetNP_ShowPass As System.Windows.Forms.CheckBox
    Friend WithEvents btnChangePassword As System.Windows.Forms.Button
    Friend WithEvents Panel_ConfirmNewPassword As System.Windows.Forms.Panel
    Friend WithEvents txtConfirmNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label

End Class
