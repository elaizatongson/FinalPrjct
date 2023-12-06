<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Dashboard
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
        Label17 = New Label()
        btnAccMan_Admin = New Button()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnCustoRan_Admin = New Button()
        btnReports_Admin = New Button()
        btnPurchase_Admin = New Button()
        btnCusInfo_Admin = New Button()
        btnDashboard_Admin = New Button()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        btnProfile_Admin = New Button()
        Label6 = New Label()
        Panel3 = New Panel()
        dgvPendingDiscount_Admin = New DataGridView()
        btnUnclaimed_Admin = New Button()
        btnSearch_Admin = New Button()
        txtboxSearch_Admin = New TextBox()
        Label7 = New Label()
        Panel4 = New Panel()
        btnSeeMore_Admin = New Button()
        Label8 = New Label()
        dgvCustomerRanking_Admin = New DataGridView()
        Panel5 = New Panel()
        Label10 = New Label()
        lblTotalCus_Admin = New Label()
        PictureBox2 = New PictureBox()
        Panel6 = New Panel()
        Label13 = New Label()
        PictureBox3 = New PictureBox()
        lblUnclaimedDiscount_Admin = New Label()
        Panel7 = New Panel()
        Label11 = New Label()
        lblNewCus_Admin = New Label()
        PictureBox4 = New PictureBox()
        Panel8 = New Panel()
        Label15 = New Label()
        lblTotalClaimed_Admin = New Label()
        PictureBox5 = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(dgvPendingDiscount_Admin, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(dgvCustomerRanking_Admin, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel8.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Orange
        Panel1.Controls.Add(Label17)
        Panel1.Controls.Add(btnAccMan_Admin)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnCustoRan_Admin)
        Panel1.Controls.Add(btnReports_Admin)
        Panel1.Controls.Add(btnPurchase_Admin)
        Panel1.Controls.Add(btnCusInfo_Admin)
        Panel1.Controls.Add(btnDashboard_Admin)
        Panel1.Location = New Point(0, 78)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(86, 823)
        Panel1.TabIndex = 1
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Orange
        Label17.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.ImageAlign = ContentAlignment.TopLeft
        Label17.Location = New Point(-2, 663)
        Label17.Name = "Label17"
        Label17.Size = New Size(89, 34)
        Label17.TabIndex = 13
        Label17.Text = "Account" & vbCrLf & "Management"
        Label17.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnAccMan_Admin
        ' 
        btnAccMan_Admin.BackColor = Color.Orange
        btnAccMan_Admin.FlatAppearance.BorderSize = 0
        btnAccMan_Admin.FlatStyle = FlatStyle.Flat
        btnAccMan_Admin.ForeColor = Color.Transparent
        btnAccMan_Admin.Image = My.Resources.Resources.account_setting
        btnAccMan_Admin.Location = New Point(3, 602)
        btnAccMan_Admin.Name = "btnAccMan_Admin"
        btnAccMan_Admin.Size = New Size(80, 81)
        btnAccMan_Admin.TabIndex = 12
        btnAccMan_Admin.UseVisualStyleBackColor = False
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
        ' btnCustoRan_Admin
        ' 
        btnCustoRan_Admin.BackColor = Color.Orange
        btnCustoRan_Admin.FlatAppearance.BorderSize = 0
        btnCustoRan_Admin.FlatStyle = FlatStyle.Flat
        btnCustoRan_Admin.ForeColor = Color.Transparent
        btnCustoRan_Admin.Image = My.Resources.Resources.customer_ranking
        btnCustoRan_Admin.Location = New Point(3, 382)
        btnCustoRan_Admin.Name = "btnCustoRan_Admin"
        btnCustoRan_Admin.Size = New Size(80, 81)
        btnCustoRan_Admin.TabIndex = 7
        btnCustoRan_Admin.UseVisualStyleBackColor = False
        ' 
        ' btnReports_Admin
        ' 
        btnReports_Admin.BackColor = Color.Orange
        btnReports_Admin.FlatAppearance.BorderSize = 0
        btnReports_Admin.FlatStyle = FlatStyle.Flat
        btnReports_Admin.ForeColor = Color.Transparent
        btnReports_Admin.Image = My.Resources.Resources.reports
        btnReports_Admin.Location = New Point(3, 493)
        btnReports_Admin.Name = "btnReports_Admin"
        btnReports_Admin.Size = New Size(80, 81)
        btnReports_Admin.TabIndex = 6
        btnReports_Admin.UseVisualStyleBackColor = False
        ' 
        ' btnPurchase_Admin
        ' 
        btnPurchase_Admin.BackColor = Color.Orange
        btnPurchase_Admin.FlatAppearance.BorderSize = 0
        btnPurchase_Admin.FlatStyle = FlatStyle.Flat
        btnPurchase_Admin.ForeColor = Color.Transparent
        btnPurchase_Admin.Image = My.Resources.Resources.purchase_history
        btnPurchase_Admin.Location = New Point(3, 256)
        btnPurchase_Admin.Name = "btnPurchase_Admin"
        btnPurchase_Admin.Size = New Size(80, 81)
        btnPurchase_Admin.TabIndex = 5
        btnPurchase_Admin.UseVisualStyleBackColor = False
        ' 
        ' btnCusInfo_Admin
        ' 
        btnCusInfo_Admin.BackColor = Color.Orange
        btnCusInfo_Admin.FlatAppearance.BorderSize = 0
        btnCusInfo_Admin.FlatStyle = FlatStyle.Flat
        btnCusInfo_Admin.ForeColor = Color.Transparent
        btnCusInfo_Admin.Image = My.Resources.Resources.customer_info
        btnCusInfo_Admin.Location = New Point(3, 138)
        btnCusInfo_Admin.Name = "btnCusInfo_Admin"
        btnCusInfo_Admin.Size = New Size(80, 81)
        btnCusInfo_Admin.TabIndex = 3
        btnCusInfo_Admin.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard_Admin
        ' 
        btnDashboard_Admin.BackColor = Color.Orange
        btnDashboard_Admin.FlatAppearance.BorderSize = 0
        btnDashboard_Admin.FlatStyle = FlatStyle.Flat
        btnDashboard_Admin.ForeColor = Color.Transparent
        btnDashboard_Admin.Image = My.Resources.Resources.dashboard1
        btnDashboard_Admin.Location = New Point(3, 20)
        btnDashboard_Admin.Name = "btnDashboard_Admin"
        btnDashboard_Admin.Size = New Size(80, 81)
        btnDashboard_Admin.TabIndex = 2
        btnDashboard_Admin.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Moccasin
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(btnProfile_Admin)
        Panel2.Controls.Add(Label6)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1114, 78)
        Panel2.TabIndex = 2
        Panel2.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.normilogo
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(83, 75)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' btnProfile_Admin
        ' 
        btnProfile_Admin.BackColor = Color.Transparent
        btnProfile_Admin.Image = My.Resources.Resources.user_icon
        btnProfile_Admin.Location = New Point(1031, 9)
        btnProfile_Admin.Name = "btnProfile_Admin"
        btnProfile_Admin.Size = New Size(77, 60)
        btnProfile_Admin.TabIndex = 3
        btnProfile_Admin.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Navy
        Label6.Location = New Point(92, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(356, 60)
        Label6.TabIndex = 2
        Label6.Text = "ADMIN PORTAL"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Wheat
        Panel3.Controls.Add(dgvPendingDiscount_Admin)
        Panel3.Controls.Add(btnUnclaimed_Admin)
        Panel3.Controls.Add(btnSearch_Admin)
        Panel3.Controls.Add(txtboxSearch_Admin)
        Panel3.Controls.Add(Label7)
        Panel3.Location = New Point(103, 99)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(611, 790)
        Panel3.TabIndex = 3
        ' 
        ' dgvPendingDiscount_Admin
        ' 
        dgvPendingDiscount_Admin.AllowUserToAddRows = False
        dgvPendingDiscount_Admin.BackgroundColor = Color.Wheat
        dgvPendingDiscount_Admin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPendingDiscount_Admin.Location = New Point(19, 143)
        dgvPendingDiscount_Admin.Name = "dgvPendingDiscount_Admin"
        dgvPendingDiscount_Admin.RowHeadersWidth = 51
        dgvPendingDiscount_Admin.RowTemplate.Height = 29
        dgvPendingDiscount_Admin.Size = New Size(574, 629)
        dgvPendingDiscount_Admin.TabIndex = 5
        ' 
        ' btnUnclaimed_Admin
        ' 
        btnUnclaimed_Admin.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        btnUnclaimed_Admin.FlatAppearance.BorderSize = 0
        btnUnclaimed_Admin.FlatStyle = FlatStyle.Flat
        btnUnclaimed_Admin.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnUnclaimed_Admin.Location = New Point(469, 85)
        btnUnclaimed_Admin.Name = "btnUnclaimed_Admin"
        btnUnclaimed_Admin.Size = New Size(125, 34)
        btnUnclaimed_Admin.TabIndex = 4
        btnUnclaimed_Admin.Text = "Unclaimed"
        btnUnclaimed_Admin.UseVisualStyleBackColor = False
        ' 
        ' btnSearch_Admin
        ' 
        btnSearch_Admin.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnSearch_Admin.FlatAppearance.BorderSize = 0
        btnSearch_Admin.FlatStyle = FlatStyle.Flat
        btnSearch_Admin.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnSearch_Admin.Location = New Point(327, 85)
        btnSearch_Admin.Name = "btnSearch_Admin"
        btnSearch_Admin.Size = New Size(125, 34)
        btnSearch_Admin.TabIndex = 3
        btnSearch_Admin.Text = "Search"
        btnSearch_Admin.UseVisualStyleBackColor = False
        ' 
        ' txtboxSearch_Admin
        ' 
        txtboxSearch_Admin.BackColor = SystemColors.Control
        txtboxSearch_Admin.BorderStyle = BorderStyle.None
        txtboxSearch_Admin.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtboxSearch_Admin.Location = New Point(20, 85)
        txtboxSearch_Admin.Multiline = True
        txtboxSearch_Admin.Name = "txtboxSearch_Admin"
        txtboxSearch_Admin.PlaceholderText = "Search Name"
        txtboxSearch_Admin.Size = New Size(272, 34)
        txtboxSearch_Admin.TabIndex = 1
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
        ' Panel4
        ' 
        Panel4.BackColor = Color.Wheat
        Panel4.Controls.Add(btnSeeMore_Admin)
        Panel4.Controls.Add(Label8)
        Panel4.Controls.Add(dgvCustomerRanking_Admin)
        Panel4.Location = New Point(722, 99)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(381, 442)
        Panel4.TabIndex = 4
        ' 
        ' btnSeeMore_Admin
        ' 
        btnSeeMore_Admin.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        btnSeeMore_Admin.FlatAppearance.BorderSize = 0
        btnSeeMore_Admin.FlatStyle = FlatStyle.Flat
        btnSeeMore_Admin.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnSeeMore_Admin.ForeColor = Color.White
        btnSeeMore_Admin.Location = New Point(278, 33)
        btnSeeMore_Admin.Name = "btnSeeMore_Admin"
        btnSeeMore_Admin.Size = New Size(94, 29)
        btnSeeMore_Admin.TabIndex = 2
        btnSeeMore_Admin.Text = "See more"
        btnSeeMore_Admin.UseVisualStyleBackColor = False
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
        ' dgvCustomerRanking_Admin
        ' 
        dgvCustomerRanking_Admin.BackgroundColor = Color.Wheat
        dgvCustomerRanking_Admin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCustomerRanking_Admin.Location = New Point(9, 68)
        dgvCustomerRanking_Admin.Name = "dgvCustomerRanking_Admin"
        dgvCustomerRanking_Admin.ReadOnly = True
        dgvCustomerRanking_Admin.RowHeadersWidth = 51
        dgvCustomerRanking_Admin.RowTemplate.Height = 29
        dgvCustomerRanking_Admin.Size = New Size(363, 366)
        dgvCustomerRanking_Admin.TabIndex = 0
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Thistle
        Panel5.Controls.Add(Label10)
        Panel5.Controls.Add(lblTotalCus_Admin)
        Panel5.Controls.Add(PictureBox2)
        Panel5.Location = New Point(722, 547)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(177, 164)
        Panel5.TabIndex = 7
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
        ' lblTotalCus_Admin
        ' 
        lblTotalCus_Admin.AutoSize = True
        lblTotalCus_Admin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotalCus_Admin.Location = New Point(65, 79)
        lblTotalCus_Admin.Name = "lblTotalCus_Admin"
        lblTotalCus_Admin.Size = New Size(48, 28)
        lblTotalCus_Admin.TabIndex = 1
        lblTotalCus_Admin.Text = "256"
        lblTotalCus_Admin.TextAlign = ContentAlignment.MiddleCenter
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
        Panel6.Controls.Add(lblUnclaimedDiscount_Admin)
        Panel6.Location = New Point(926, 547)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(177, 164)
        Panel6.TabIndex = 8
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
        ' lblUnclaimedDiscount_Admin
        ' 
        lblUnclaimedDiscount_Admin.AutoSize = True
        lblUnclaimedDiscount_Admin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblUnclaimedDiscount_Admin.Location = New Point(83, 80)
        lblUnclaimedDiscount_Admin.Name = "lblUnclaimedDiscount_Admin"
        lblUnclaimedDiscount_Admin.Size = New Size(24, 28)
        lblUnclaimedDiscount_Admin.TabIndex = 3
        lblUnclaimedDiscount_Admin.Text = "3"
        lblUnclaimedDiscount_Admin.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.PowderBlue
        Panel7.Controls.Add(Label11)
        Panel7.Controls.Add(lblNewCus_Admin)
        Panel7.Controls.Add(PictureBox4)
        Panel7.Location = New Point(722, 725)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(177, 164)
        Panel7.TabIndex = 9
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
        ' lblNewCus_Admin
        ' 
        lblNewCus_Admin.AutoSize = True
        lblNewCus_Admin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblNewCus_Admin.Location = New Point(73, 70)
        lblNewCus_Admin.Name = "lblNewCus_Admin"
        lblNewCus_Admin.Size = New Size(24, 28)
        lblNewCus_Admin.TabIndex = 3
        lblNewCus_Admin.Text = "5"
        lblNewCus_Admin.TextAlign = ContentAlignment.MiddleCenter
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
        Panel8.Controls.Add(lblTotalClaimed_Admin)
        Panel8.Controls.Add(PictureBox5)
        Panel8.Location = New Point(926, 725)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(177, 164)
        Panel8.TabIndex = 10
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
        ' lblTotalClaimed_Admin
        ' 
        lblTotalClaimed_Admin.AutoSize = True
        lblTotalClaimed_Admin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotalClaimed_Admin.Location = New Point(83, 70)
        lblTotalClaimed_Admin.Name = "lblTotalClaimed_Admin"
        lblTotalClaimed_Admin.Size = New Size(24, 28)
        lblTotalClaimed_Admin.TabIndex = 3
        lblTotalClaimed_Admin.Text = "0"
        lblTotalClaimed_Admin.TextAlign = ContentAlignment.MiddleCenter
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
        ' Admin_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(1113, 901)
        Controls.Add(Panel8)
        Controls.Add(Panel7)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Admin_Dashboard"
        Text = "Admin_Dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(dgvPendingDiscount_Admin, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(dgvCustomerRanking_Admin, ComponentModel.ISupportInitialize).EndInit()
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
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCustoRan_Admin As Button
    Friend WithEvents btnReports_Admin As Button
    Friend WithEvents btnPurchase_Admin As Button
    Friend WithEvents btnCusInfo_Admin As Button
    Friend WithEvents btnDashboard_Admin As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnProfile_Admin As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgvPendingDiscount_Admin As DataGridView
    Friend WithEvents btnUnclaimed_Admin As Button
    Friend WithEvents btnSearch_Admin As Button
    Friend WithEvents txtboxSearch_Admin As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgvCustomerRanking_Admin As DataGridView
    Friend WithEvents btnSeeMore_Admin As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents lblTotalCus_Admin As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblUnclaimedDiscount_Admin As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents lblNewCus_Admin As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents lblTotalClaimed_Admin As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents btnAccMan_Admin As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
