<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        cbMultiUser = New ComboBox()
        Label4 = New Label()
        txtboxEmail = New TextBox()
        Label5 = New Label()
        txtboxPass = New TextBox()
        comboxRemember = New CheckBox()
        lblForgotPass = New Label()
        btnSignIn = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(117, 98)
        Label1.Name = "Label1"
        Label1.Size = New Size(313, 38)
        Label1.TabIndex = 0
        Label1.Text = "Log in to your account"
        Label1.UseWaitCursor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(133, 140)
        Label2.Name = "Label2"
        Label2.Size = New Size(278, 20)
        Label2.TabIndex = 1
        Label2.Text = "Welcome back! Please enter your details."
        Label2.UseWaitCursor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(215, 186)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 28)
        Label3.TabIndex = 2
        Label3.Text = "LOG IN AS"
        Label3.UseWaitCursor = True
        ' 
        ' cbMultiUser
        ' 
        cbMultiUser.DropDownStyle = ComboBoxStyle.DropDownList
        cbMultiUser.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        cbMultiUser.FormattingEnabled = True
        cbMultiUser.Items.AddRange(New Object() {"Employee", "Admin"})
        cbMultiUser.Location = New Point(192, 217)
        cbMultiUser.Name = "cbMultiUser"
        cbMultiUser.Size = New Size(151, 31)
        cbMultiUser.TabIndex = 3
        cbMultiUser.UseWaitCursor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(93, 274)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 23)
        Label4.TabIndex = 4
        Label4.Text = "Email"
        Label4.UseWaitCursor = True
        ' 
        ' txtboxEmail
        ' 
        txtboxEmail.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtboxEmail.Location = New Point(97, 294)
        txtboxEmail.Multiline = True
        txtboxEmail.Name = "txtboxEmail"
        txtboxEmail.PlaceholderText = "Enter your email"
        txtboxEmail.Size = New Size(340, 42)
        txtboxEmail.TabIndex = 5
        txtboxEmail.UseWaitCursor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Black
        Label5.ImageAlign = ContentAlignment.BottomCenter
        Label5.Location = New Point(94, 356)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 23)
        Label5.TabIndex = 6
        Label5.Text = "Password"
        Label5.UseWaitCursor = True
        ' 
        ' txtboxPass
        ' 
        txtboxPass.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtboxPass.Location = New Point(97, 377)
        txtboxPass.Multiline = True
        txtboxPass.Name = "txtboxPass"
        txtboxPass.PlaceholderText = "Enter your password"
        txtboxPass.Size = New Size(340, 42)
        txtboxPass.TabIndex = 7
        txtboxPass.UseWaitCursor = True
        ' 
        ' comboxRemember
        ' 
        comboxRemember.AutoSize = True
        comboxRemember.BackColor = Color.Transparent
        comboxRemember.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        comboxRemember.ForeColor = Color.Black
        comboxRemember.Location = New Point(97, 447)
        comboxRemember.Name = "comboxRemember"
        comboxRemember.Size = New Size(116, 27)
        comboxRemember.TabIndex = 8
        comboxRemember.Text = "Remember"
        comboxRemember.UseVisualStyleBackColor = False
        comboxRemember.UseWaitCursor = True
        ' 
        ' lblForgotPass
        ' 
        lblForgotPass.AutoSize = True
        lblForgotPass.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblForgotPass.ForeColor = Color.Navy
        lblForgotPass.Location = New Point(299, 447)
        lblForgotPass.Name = "lblForgotPass"
        lblForgotPass.Size = New Size(138, 23)
        lblForgotPass.TabIndex = 9
        lblForgotPass.Text = "Forgot Password"
        lblForgotPass.UseWaitCursor = True
        ' 
        ' btnSignIn
        ' 
        btnSignIn.BackColor = Color.White
        btnSignIn.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnSignIn.ForeColor = Color.Navy
        btnSignIn.Location = New Point(97, 509)
        btnSignIn.Name = "btnSignIn"
        btnSignIn.Size = New Size(340, 42)
        btnSignIn.TabIndex = 10
        btnSignIn.Text = "Sign in"
        btnSignIn.UseVisualStyleBackColor = False
        btnSignIn.UseWaitCursor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.normilogo
        PictureBox1.Location = New Point(232, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(93, 91)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        PictureBox1.UseWaitCursor = True
        PictureBox1.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Moccasin
        ClientSize = New Size(543, 649)
        Controls.Add(PictureBox1)
        Controls.Add(btnSignIn)
        Controls.Add(lblForgotPass)
        Controls.Add(comboxRemember)
        Controls.Add(txtboxPass)
        Controls.Add(Label5)
        Controls.Add(txtboxEmail)
        Controls.Add(Label4)
        Controls.Add(cbMultiUser)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Login"
        UseWaitCursor = True
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbMultiUser As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtboxEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtboxPass As TextBox
    Friend WithEvents comboxRemember As CheckBox
    Friend WithEvents lblForgotPass As Label
    Friend WithEvents btnSignIn As Button
    Friend WithEvents lblSignUp As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
