<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_PurchaseHisto
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
        Label7 = New Label()
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
        TextBox1 = New TextBox()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Button1 = New Button()
        Label8 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Button3 = New Button()
        Button4 = New Button()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        Label9 = New Label()
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
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1114, 78)
        Panel2.TabIndex = 4
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
        Label6.Size = New Size(421, 60)
        Label6.TabIndex = 2
        Label6.Text = "EMPLOYEE PORTAL"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.Orange
        Label7.Location = New Point(113, 99)
        Label7.Name = "Label7"
        Label7.Size = New Size(255, 38)
        Label7.TabIndex = 7
        Label7.Text = "Purchased History"
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
        Panel1.TabIndex = 8
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
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(113, 169)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Search"
        TextBox1.Size = New Size(262, 40)
        TextBox1.TabIndex = 9
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.Beige
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        DataGridView1.Location = New Point(113, 229)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(653, 595)
        DataGridView1.TabIndex = 10
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Date"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Name"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Item/s"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Quantity"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Prices per pcs"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 125
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Orange
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Image = My.Resources.Resources.import1
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(869, 169)
        Button1.Name = "Button1"
        Button1.Size = New Size(158, 40)
        Button1.TabIndex = 11
        Button1.Text = "Import"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(694, 844)
        Label8.Name = "Label8"
        Label8.Size = New Size(59, 25)
        Label8.TabIndex = 12
        Label8.Text = "Total:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(800, 294)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Date"
        TextBox2.Size = New Size(271, 38)
        TextBox2.TabIndex = 13
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox3.Location = New Point(800, 361)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Name"
        TextBox3.Size = New Size(271, 38)
        TextBox3.TabIndex = 14
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox4.Location = New Point(800, 424)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.PlaceholderText = "Item/s"
        TextBox4.Size = New Size(271, 38)
        TextBox4.TabIndex = 15
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox5.Location = New Point(800, 487)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.PlaceholderText = "Quantity"
        TextBox5.Size = New Size(271, 38)
        TextBox5.TabIndex = 16
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox6.Location = New Point(800, 556)
        TextBox6.Multiline = True
        TextBox6.Name = "TextBox6"
        TextBox6.PlaceholderText = "Prices per pcs"
        TextBox6.Size = New Size(271, 38)
        TextBox6.TabIndex = 17
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Orange
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Image = My.Resources.Resources.edit2
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(869, 654)
        Button3.Name = "Button3"
        Button3.Size = New Size(158, 42)
        Button3.TabIndex = 19
        Button3.Text = "Edit"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Orange
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Image = My.Resources.Resources.delete1
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(869, 735)
        Button4.Name = "Button4"
        Button4.Size = New Size(158, 42)
        Button4.TabIndex = 20
        Button4.Text = "Delete"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        ComboBox1.Location = New Point(656, 110)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(143, 28)
        ComboBox1.TabIndex = 23
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        ComboBox2.Location = New Point(805, 110)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(143, 28)
        ComboBox2.TabIndex = 34
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023"})
        ComboBox3.Location = New Point(954, 110)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(143, 28)
        ComboBox3.TabIndex = 35
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(578, 111)
        Label9.Name = "Label9"
        Label9.Size = New Size(61, 25)
        Label9.TabIndex = 36
        Label9.Text = "Filter:"
        ' 
        ' Employee_PurchaseHisto
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(1113, 901)
        Controls.Add(Label9)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label8)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox1)
        Controls.Add(Panel1)
        Controls.Add(Label7)
        Controls.Add(Panel2)
        Controls.Add(ComboBox2)
        Name = "Employee_PurchaseHisto"
        Text = "Employee_PurchaseHisto"
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
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCustoRan_Employee As Button
    Friend WithEvents btnReports_Employee As Button
    Friend WithEvents btnPurchase_Emp As Button
    Friend WithEvents btnCusInfo_Emp As Button
    Friend WithEvents btnDashboard_Emp As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label9 As Label
End Class
