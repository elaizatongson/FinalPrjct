﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Ranking
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
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        btnProfile_Admin = New Button()
        Label6 = New Label()
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
        Label7 = New Label()
        TextBox1 = New TextBox()
        Label9 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox3 = New ComboBox()
        Label8 = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Moccasin
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(btnProfile_Admin)
        Panel2.Controls.Add(Label6)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1113, 78)
        Panel2.TabIndex = 5
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
        Panel1.TabIndex = 6
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
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.Orange
        Label7.Location = New Point(113, 99)
        Label7.Name = "Label7"
        Label7.Size = New Size(259, 38)
        Label7.TabIndex = 11
        Label7.Text = "Customer Ranking"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(113, 169)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Search"
        TextBox1.Size = New Size(262, 40)
        TextBox1.TabIndex = 12
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(739, 109)
        Label9.Name = "Label9"
        Label9.Size = New Size(61, 25)
        Label9.TabIndex = 38
        Label9.Text = "Filter:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        ComboBox1.Location = New Point(806, 110)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(143, 28)
        ComboBox1.TabIndex = 39
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023"})
        ComboBox3.Location = New Point(958, 110)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(143, 28)
        ComboBox3.TabIndex = 40
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.Orange
        Label8.Location = New Point(486, 216)
        Label8.Name = "Label8"
        Label8.Size = New Size(232, 38)
        Label8.TabIndex = 41
        Label8.Text = "September 2023"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.Beige
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        DataGridView1.Location = New Point(351, 272)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(551, 617)
        DataGridView1.TabIndex = 42
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Rank"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Customer Name"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Total Amount Spent(This Month)"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Numbers of Item Purchased"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 125
        ' 
        ' Admin_Ranking
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(1113, 901)
        Controls.Add(DataGridView1)
        Controls.Add(Label8)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox1)
        Controls.Add(Label9)
        Controls.Add(TextBox1)
        Controls.Add(Label7)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "Admin_Ranking"
        Text = "Admin_Ranking"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnProfile_Admin As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents btnAccMan_Admin As Button
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
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
