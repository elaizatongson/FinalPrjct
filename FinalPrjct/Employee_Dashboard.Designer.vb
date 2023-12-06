<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_Dashboard
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
        Panel1 = New Panel()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnCustoRan_Employee = New Button()
        btnReports_Employee = New Button()
        btnPurchase_Emp = New Button()
        btnCusInfo_Emp = New Button()
        btnDashboard_Emp = New Button()
        Panel4 = New Panel()
        btnSeeMore_Emp = New Button()
        Label8 = New Label()
        dgvCustomerRanking_Emp = New DataGridView()
        Panel5 = New Panel()
        Label10 = New Label()
        lblTotalCus_Emp = New Label()
        PictureBox2 = New PictureBox()
        Panel6 = New Panel()
        Label13 = New Label()
        PictureBox3 = New PictureBox()
        lblUnclaimedDiscount_Emp = New Label()
        Panel7 = New Panel()
        Label11 = New Label()
        lblNewCus_Emp = New Label()
        PictureBox4 = New PictureBox()
        Panel8 = New Panel()
        Label15 = New Label()
        lblTotalClaimed_Emp = New Label()
        PictureBox5 = New PictureBox()
        Label7 = New Label()
        txtboxSearch_Emp = New TextBox()
        btnSearch_Emp = New Button()
        btnUnclaimed_Emp = New Button()
        dgvPendingDiscount_Emp = New DataGridView()
        Panel3 = New Panel()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        btnProfile_Emp = New Button()
        Label6 = New Label()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        CType(dgvCustomerRanking_Emp, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel8.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvPendingDiscount_Emp, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Orange
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnCustoRan_Employee)
        Panel1.Controls.Add(btnReports_Employee)
        Panel1.Controls.Add(btnPurchase_Emp)
        Panel1.Controls.Add(btnCusInfo_Emp)
        Panel1.Controls.Add(btnDashboard_Emp)
        Panel1.Location = New Point(0, 78)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(86, 823)
        Panel1.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Orange
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ImageAlign = ContentAlignment.TopLeft
        Label5.Location = New Point(12, 554)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 20)
        Label5.TabIndex = 11
        Label5.Text = "Reports"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Orange
        Label4.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(10, 436)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 34)
        Label4.TabIndex = 10
        Label4.Text = "Customer" & vbCrLf & "Ranking"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Orange
        Label3.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(12, 317)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 34)
        Label3.TabIndex = 9
        Label3.Text = "Purchase " & vbCrLf & "History" & vbCrLf
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Orange
        Label2.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ImageAlign = ContentAlignment.TopLeft
        Label2.Location = New Point(3, 194)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 34)
        Label2.TabIndex = 8
        Label2.Text = "Customer" & vbCrLf & "Information"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Orange
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ImageAlign = ContentAlignment.TopLeft
        Label1.Location = New Point(1, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 20)
        Label1.TabIndex = 2
        Label1.Text = "Dashboard"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnCustoRan_Employee
        ' 
        btnCustoRan_Employee.BackColor = Color.Orange
        btnCustoRan_Employee.FlatAppearance.BorderSize = 0
        btnCustoRan_Employee.FlatStyle = FlatStyle.Flat
        btnCustoRan_Employee.ForeColor = Color.Transparent
        btnCustoRan_Employee.Image = My.Resources.Resources.customer_ranking
        btnCustoRan_Employee.Location = New Point(3, 382)
        btnCustoRan_Employee.Name = "btnCustoRan_Employee"
        btnCustoRan_Employee.Size = New Size(80, 81)
        btnCustoRan_Employee.TabIndex = 7
        btnCustoRan_Employee.UseVisualStyleBackColor = False
        ' 
        ' btnReports_Employee
        ' 
        btnReports_Employee.BackColor = Color.Orange
        btnReports_Employee.FlatAppearance.BorderSize = 0
        btnReports_Employee.FlatStyle = FlatStyle.Flat
        btnReports_Employee.ForeColor = Color.Transparent
        btnReports_Employee.Image = My.Resources.Resources.reports
        btnReports_Employee.Location = New Point(3, 493)
        btnReports_Employee.Name = "btnReports_Employee"
        btnReports_Employee.Size = New Size(80, 81)
        btnReports_Employee.TabIndex = 6
        btnReports_Employee.UseVisualStyleBackColor = False
        ' 
        ' btnPurchase_Emp
        ' 
        btnPurchase_Emp.BackColor = Color.Orange
        btnPurchase_Emp.FlatAppearance.BorderSize = 0
        btnPurchase_Emp.FlatStyle = FlatStyle.Flat
        btnPurchase_Emp.ForeColor = Color.Transparent
        btnPurchase_Emp.Image = My.Resources.Resources.purchase_history
        btnPurchase_Emp.Location = New Point(3, 256)
        btnPurchase_Emp.Name = "btnPurchase_Emp"
        btnPurchase_Emp.Size = New Size(80, 81)
        btnPurchase_Emp.TabIndex = 5
        btnPurchase_Emp.UseVisualStyleBackColor = False
        ' 
        ' btnCusInfo_Emp
        ' 
        btnCusInfo_Emp.BackColor = Color.Orange
        btnCusInfo_Emp.FlatAppearance.BorderSize = 0
        btnCusInfo_Emp.FlatStyle = FlatStyle.Flat
        btnCusInfo_Emp.ForeColor = Color.Transparent
        btnCusInfo_Emp.Image = My.Resources.Resources.customer_info
        btnCusInfo_Emp.Location = New Point(3, 138)
        btnCusInfo_Emp.Name = "btnCusInfo_Emp"
        btnCusInfo_Emp.Size = New Size(80, 81)
        btnCusInfo_Emp.TabIndex = 3
        btnCusInfo_Emp.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard_Emp
        ' 
        btnDashboard_Emp.BackColor = Color.Orange
        btnDashboard_Emp.FlatAppearance.BorderSize = 0
        btnDashboard_Emp.FlatStyle = FlatStyle.Flat
        btnDashboard_Emp.ForeColor = Color.Transparent
        btnDashboard_Emp.Image = My.Resources.Resources.dashboard1
        btnDashboard_Emp.Location = New Point(3, 20)
        btnDashboard_Emp.Name = "btnDashboard_Emp"
        btnDashboard_Emp.Size = New Size(80, 81)
        btnDashboard_Emp.TabIndex = 2
        btnDashboard_Emp.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Wheat
        Panel4.Controls.Add(btnSeeMore_Emp)
        Panel4.Controls.Add(Label8)
        Panel4.Controls.Add(dgvCustomerRanking_Emp)
        Panel4.Location = New Point(722, 99)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(381, 442)
        Panel4.TabIndex = 5
        ' 
        ' btnSeeMore_Emp
        ' 
        btnSeeMore_Emp.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        btnSeeMore_Emp.FlatAppearance.BorderSize = 0
        btnSeeMore_Emp.FlatStyle = FlatStyle.Flat
        btnSeeMore_Emp.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnSeeMore_Emp.ForeColor = Color.White
        btnSeeMore_Emp.Location = New Point(278, 33)
        btnSeeMore_Emp.Name = "btnSeeMore_Emp"
        btnSeeMore_Emp.Size = New Size(94, 29)
        btnSeeMore_Emp.TabIndex = 2
        btnSeeMore_Emp.Text = "See more"
        btnSeeMore_Emp.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(9, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(222, 23)
        Label8.TabIndex = 1
        Label8.Text = "Monthly Customer Ranking"
        ' 
        ' dgvCustomerRanking_Emp
        ' 
        dgvCustomerRanking_Emp.BackgroundColor = Color.Wheat
        dgvCustomerRanking_Emp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCustomerRanking_Emp.Location = New Point(9, 68)
        dgvCustomerRanking_Emp.Name = "dgvCustomerRanking_Emp"
        dgvCustomerRanking_Emp.ReadOnly = True
        dgvCustomerRanking_Emp.RowHeadersWidth = 51
        dgvCustomerRanking_Emp.RowTemplate.Height = 29
        dgvCustomerRanking_Emp.Size = New Size(363, 366)
        dgvCustomerRanking_Emp.TabIndex = 0
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Thistle
        Panel5.Controls.Add(Label10)
        Panel5.Controls.Add(lblTotalCus_Emp)
        Panel5.Controls.Add(PictureBox2)
        Panel5.Location = New Point(722, 547)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(177, 164)
        Panel5.TabIndex = 6
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(20, 136)
        Label10.Name = "Label10"
        Label10.Size = New Size(132, 23)
        Label10.TabIndex = 2
        Label10.Text = "Total Customers"
        ' 
        ' lblTotalCus_Emp
        ' 
        lblTotalCus_Emp.AutoSize = True
        lblTotalCus_Emp.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotalCus_Emp.Location = New Point(65, 79)
        lblTotalCus_Emp.Name = "lblTotalCus_Emp"
        lblTotalCus_Emp.Size = New Size(48, 28)
        lblTotalCus_Emp.TabIndex = 1
        lblTotalCus_Emp.Text = "256"
        lblTotalCus_Emp.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.persons
        PictureBox2.Location = New Point(62, 13)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(50, 45)
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Panel6.Controls.Add(Label13)
        Panel6.Controls.Add(PictureBox3)
        Panel6.Controls.Add(lblUnclaimedDiscount_Emp)
        Panel6.Location = New Point(926, 547)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(177, 164)
        Panel6.TabIndex = 7
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(8, 136)
        Label13.Name = "Label13"
        Label13.Size = New Size(163, 23)
        Label13.TabIndex = 4
        Label13.Text = "Unclaimed Discount"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.layers
        PictureBox3.Location = New Point(71, 13)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(50, 45)
        PictureBox3.TabIndex = 1
        PictureBox3.TabStop = False
        ' 
        ' lblUnclaimedDiscount_Emp
        ' 
        lblUnclaimedDiscount_Emp.AutoSize = True
        lblUnclaimedDiscount_Emp.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblUnclaimedDiscount_Emp.Location = New Point(83, 80)
        lblUnclaimedDiscount_Emp.Name = "lblUnclaimedDiscount_Emp"
        lblUnclaimedDiscount_Emp.Size = New Size(24, 28)
        lblUnclaimedDiscount_Emp.TabIndex = 3
        lblUnclaimedDiscount_Emp.Text = "3"
        lblUnclaimedDiscount_Emp.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.PowderBlue
        Panel7.Controls.Add(Label11)
        Panel7.Controls.Add(lblNewCus_Emp)
        Panel7.Controls.Add(PictureBox4)
        Panel7.Location = New Point(722, 725)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(177, 164)
        Panel7.TabIndex = 7
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(26, 114)
        Label11.Name = "Label11"
        Label11.Size = New Size(126, 46)
        Label11.TabIndex = 4
        Label11.Text = "New customer " & vbCrLf & "this month" & vbCrLf
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblNewCus_Emp
        ' 
        lblNewCus_Emp.AutoSize = True
        lblNewCus_Emp.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblNewCus_Emp.Location = New Point(73, 70)
        lblNewCus_Emp.Name = "lblNewCus_Emp"
        lblNewCus_Emp.Size = New Size(24, 28)
        lblNewCus_Emp.TabIndex = 3
        lblNewCus_Emp.Text = "5"
        lblNewCus_Emp.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.newcustomer
        PictureBox4.Location = New Point(62, 12)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(50, 45)
        PictureBox4.TabIndex = 1
        PictureBox4.TabStop = False
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Panel8.Controls.Add(Label15)
        Panel8.Controls.Add(lblTotalClaimed_Emp)
        Panel8.Controls.Add(PictureBox5)
        Panel8.Location = New Point(926, 725)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(177, 164)
        Panel8.TabIndex = 8
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(36, 113)
        Label15.Name = "Label15"
        Label15.Size = New Size(113, 46)
        Label15.TabIndex = 4
        Label15.Text = "Total Claimed" & vbCrLf & "Discounts" & vbCrLf
        Label15.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTotalClaimed_Emp
        ' 
        lblTotalClaimed_Emp.AutoSize = True
        lblTotalClaimed_Emp.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotalClaimed_Emp.Location = New Point(83, 70)
        lblTotalClaimed_Emp.Name = "lblTotalClaimed_Emp"
        lblTotalClaimed_Emp.Size = New Size(24, 28)
        lblTotalClaimed_Emp.TabIndex = 3
        lblTotalClaimed_Emp.Text = "0"
        lblTotalClaimed_Emp.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.claimedDiscount
        PictureBox5.Location = New Point(71, 13)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(50, 45)
        PictureBox5.TabIndex = 2
        PictureBox5.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Orange
        Label7.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(141, 21)
        Label7.Name = "Label7"
        Label7.Size = New Size(303, 46)
        Label7.TabIndex = 0
        Label7.Text = "Pending Discount"
        ' 
        ' txtboxSearch_Emp
        ' 
        txtboxSearch_Emp.BackColor = SystemColors.Control
        txtboxSearch_Emp.BorderStyle = BorderStyle.None
        txtboxSearch_Emp.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtboxSearch_Emp.Location = New Point(20, 85)
        txtboxSearch_Emp.Multiline = True
        txtboxSearch_Emp.Name = "txtboxSearch_Emp"
        txtboxSearch_Emp.PlaceholderText = "Search Name"
        txtboxSearch_Emp.Size = New Size(272, 34)
        txtboxSearch_Emp.TabIndex = 1
        ' 
        ' btnSearch_Emp
        ' 
        btnSearch_Emp.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnSearch_Emp.FlatAppearance.BorderSize = 0
        btnSearch_Emp.FlatStyle = FlatStyle.Flat
        btnSearch_Emp.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnSearch_Emp.Location = New Point(327, 85)
        btnSearch_Emp.Name = "btnSearch_Emp"
        btnSearch_Emp.Size = New Size(125, 34)
        btnSearch_Emp.TabIndex = 3
        btnSearch_Emp.Text = "Search"
        btnSearch_Emp.UseVisualStyleBackColor = False
        ' 
        ' btnUnclaimed_Emp
        ' 
        btnUnclaimed_Emp.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        btnUnclaimed_Emp.FlatAppearance.BorderSize = 0
        btnUnclaimed_Emp.FlatStyle = FlatStyle.Flat
        btnUnclaimed_Emp.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnUnclaimed_Emp.Location = New Point(469, 85)
        btnUnclaimed_Emp.Name = "btnUnclaimed_Emp"
        btnUnclaimed_Emp.Size = New Size(125, 34)
        btnUnclaimed_Emp.TabIndex = 4
        btnUnclaimed_Emp.Text = "Unclaimed"
        btnUnclaimed_Emp.UseVisualStyleBackColor = False
        ' 
        ' dgvPendingDiscount_Emp
        ' 
        dgvPendingDiscount_Emp.AllowUserToAddRows = False
        dgvPendingDiscount_Emp.BackgroundColor = Color.Wheat
        dgvPendingDiscount_Emp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPendingDiscount_Emp.Location = New Point(19, 143)
        dgvPendingDiscount_Emp.Name = "dgvPendingDiscount_Emp"
        dgvPendingDiscount_Emp.RowHeadersWidth = 51
        dgvPendingDiscount_Emp.RowTemplate.Height = 29
        dgvPendingDiscount_Emp.Size = New Size(574, 629)
        dgvPendingDiscount_Emp.TabIndex = 5
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Wheat
        Panel3.Controls.Add(dgvPendingDiscount_Emp)
        Panel3.Controls.Add(btnUnclaimed_Emp)
        Panel3.Controls.Add(btnSearch_Emp)
        Panel3.Controls.Add(txtboxSearch_Emp)
        Panel3.Controls.Add(Label7)
        Panel3.Location = New Point(103, 99)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(611, 790)
        Panel3.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Moccasin
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(btnProfile_Emp)
        Panel2.Controls.Add(Label6)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1114, 78)
        Panel2.TabIndex = 9
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.normilogo
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(83, 75)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' btnProfile_Emp
        ' 
        btnProfile_Emp.BackColor = Color.Transparent
        btnProfile_Emp.Image = My.Resources.Resources.user_icon
        btnProfile_Emp.Location = New Point(1031, 9)
        btnProfile_Emp.Name = "btnProfile_Emp"
        btnProfile_Emp.Size = New Size(77, 60)
        btnProfile_Emp.TabIndex = 12
        btnProfile_Emp.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Navy
        Label6.Location = New Point(92, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(421, 60)
        Label6.TabIndex = 10
        Label6.Text = "EMPLOYEE PORTAL"
        ' 
        ' Employee_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(1113, 901)
        Controls.Add(Panel2)
        Controls.Add(Panel8)
        Controls.Add(Panel7)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Name = "Employee_Dashboard"
        Text = "Employee_Dashboard"
        TransparencyKey = Color.Transparent
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(dgvCustomerRanking_Emp, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvPendingDiscount_Emp, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPurchase_Emp As Button
    Friend WithEvents btnCusInfo_Emp As Button
    Friend WithEvents btnDashboard_Emp As Button
    Friend WithEvents btnReports_Employee As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCustoRan_Employee As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnSeeMore_Emp As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvCustomerRanking_Emp As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblTotalCus_Emp As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lblNewCus_Emp As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lblUnclaimedDiscount_Emp As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblTotalClaimed_Emp As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtboxSearch_Emp As TextBox
    Friend WithEvents btnSearch_Emp As Button
    Friend WithEvents btnUnclaimed_Emp As Button
    Friend WithEvents dgvPendingDiscount_Emp As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btnProfile_Emp As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
