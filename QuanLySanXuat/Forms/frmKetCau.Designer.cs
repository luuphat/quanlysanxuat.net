namespace QuanLySanXuat.Forms
{
    partial class frmKetCau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19});
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.treeViewKetCau = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ctxMenuStrip_KetCau = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenKetCau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.dgvChiTietKetCau = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cboNhomKetCau = new System.Windows.Forms.ComboBox();
            this.btnKetCau_Accept = new System.Windows.Forms.Button();
            this.btnKetCau_Cancel = new System.Windows.Forms.Button();
            this.lblMaKetCau = new System.Windows.Forms.Label();
            this.ctxMenuStrip_ChitietKC = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_AddDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_EditDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_DeleteDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaChiTiet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenChiTiet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuyCach = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtChieuDai = new System.Windows.Forms.TextBox();
            this.txtChieuRong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTyTrong = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboKetCau = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.ctxMenuStrip_KetCau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietKetCau)).BeginInit();
            this.ctxMenuStrip_ChitietKC.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(533, 261);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvChiTietKetCau);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(525, 232);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách chi tiết kết cấu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cboKetCau);
            this.tabPage2.Controls.Add(this.btnCancel);
            this.tabPage2.Controls.Add(this.btnAccept);
            this.tabPage2.Controls.Add(this.txtGia);
            this.tabPage2.Controls.Add(this.txtChieuRong);
            this.tabPage2.Controls.Add(this.txtTyTrong);
            this.tabPage2.Controls.Add(this.txtChieuDai);
            this.tabPage2.Controls.Add(this.txtQuyCach);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtTenChiTiet);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtMaChiTiet);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(525, 232);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cập nhật chi tiết";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // treeViewKetCau
            // 
            this.treeViewKetCau.ContextMenuStrip = this.ctxMenuStrip_KetCau;
            this.treeViewKetCau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewKetCau.Location = new System.Drawing.Point(3, 18);
            this.treeViewKetCau.Name = "treeViewKetCau";
            treeNode11.Name = "Node2";
            treeNode11.Text = "Node2";
            treeNode12.Name = "Node3";
            treeNode12.Text = "Node3";
            treeNode13.Name = "Node4";
            treeNode13.Text = "Node4";
            treeNode14.Name = "Node5";
            treeNode14.Text = "Node5";
            treeNode15.Name = "Node0";
            treeNode15.Text = "Node0";
            treeNode16.Name = "Node6";
            treeNode16.Text = "Node6";
            treeNode17.Name = "Node7";
            treeNode17.Text = "Node7";
            treeNode18.Name = "Node8";
            treeNode18.Text = "Node8";
            treeNode19.Name = "Node9";
            treeNode19.Text = "Node9";
            treeNode20.Name = "Node1";
            treeNode20.Text = "Node1";
            this.treeViewKetCau.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode20});
            this.treeViewKetCau.Size = new System.Drawing.Size(206, 464);
            this.treeViewKetCau.TabIndex = 0;
            this.treeViewKetCau.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewKetCau_NodeMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKetCau_Cancel);
            this.groupBox1.Controls.Add(this.btnKetCau_Accept);
            this.groupBox1.Controls.Add(this.picHinhAnh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboNhomKetCau);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMoTa);
            this.groupBox1.Controls.Add(this.txtTenKetCau);
            this.groupBox1.Controls.Add(this.lblMaKetCau);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(218, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 173);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin kết cấu";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(218, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 282);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết kết cấu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.treeViewKetCau);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 485);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách kết cấu";
            // 
            // ctxMenuStrip_KetCau
            // 
            this.ctxMenuStrip_KetCau.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Add,
            this.ToolStripMenuItem_Edit,
            this.ToolStripMenuItem_Delete});
            this.ctxMenuStrip_KetCau.Name = "ctxMenuStrip_KetCau";
            this.ctxMenuStrip_KetCau.Size = new System.Drawing.Size(169, 70);
            // 
            // ToolStripMenuItem_Add
            // 
            this.ToolStripMenuItem_Add.Name = "ToolStripMenuItem_Add";
            this.ToolStripMenuItem_Add.Size = new System.Drawing.Size(168, 22);
            this.ToolStripMenuItem_Add.Text = "Thêm kết cấu";
            this.ToolStripMenuItem_Add.Click += new System.EventHandler(this.ToolStripMenuItem_Add_Click);
            // 
            // ToolStripMenuItem_Edit
            // 
            this.ToolStripMenuItem_Edit.Name = "ToolStripMenuItem_Edit";
            this.ToolStripMenuItem_Edit.Size = new System.Drawing.Size(168, 22);
            this.ToolStripMenuItem_Edit.Text = "Chỉnh sửa kết cấu";
            this.ToolStripMenuItem_Edit.Click += new System.EventHandler(this.ToolStripMenuItem_Edit_Click);
            // 
            // ToolStripMenuItem_Delete
            // 
            this.ToolStripMenuItem_Delete.Name = "ToolStripMenuItem_Delete";
            this.ToolStripMenuItem_Delete.Size = new System.Drawing.Size(168, 22);
            this.ToolStripMenuItem_Delete.Text = "Xóa kết cấu";
            this.ToolStripMenuItem_Delete.Click += new System.EventHandler(this.ToolStripMenuItem_Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên kết cấu:";
            // 
            // txtTenKetCau
            // 
            this.txtTenKetCau.Location = new System.Drawing.Point(110, 55);
            this.txtTenKetCau.Name = "txtTenKetCau";
            this.txtTenKetCau.Size = new System.Drawing.Size(230, 22);
            this.txtTenKetCau.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mô tả:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(110, 83);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(230, 79);
            this.txtMoTa.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hình ảnh:";
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.Location = new System.Drawing.Point(415, 25);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(108, 91);
            this.picHinhAnh.TabIndex = 2;
            this.picHinhAnh.TabStop = false;
            // 
            // dgvChiTietKetCau
            // 
            this.dgvChiTietKetCau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietKetCau.ContextMenuStrip = this.ctxMenuStrip_ChitietKC;
            this.dgvChiTietKetCau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietKetCau.Location = new System.Drawing.Point(3, 3);
            this.dgvChiTietKetCau.Name = "dgvChiTietKetCau";
            this.dgvChiTietKetCau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietKetCau.Size = new System.Drawing.Size(519, 226);
            this.dgvChiTietKetCau.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhóm kết cấu:";
            // 
            // cboNhomKetCau
            // 
            this.cboNhomKetCau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhomKetCau.FormattingEnabled = true;
            this.cboNhomKetCau.Location = new System.Drawing.Point(110, 25);
            this.cboNhomKetCau.Name = "cboNhomKetCau";
            this.cboNhomKetCau.Size = new System.Drawing.Size(230, 24);
            this.cboNhomKetCau.TabIndex = 1;
            // 
            // btnKetCau_Accept
            // 
            this.btnKetCau_Accept.Location = new System.Drawing.Point(367, 139);
            this.btnKetCau_Accept.Name = "btnKetCau_Accept";
            this.btnKetCau_Accept.Size = new System.Drawing.Size(75, 23);
            this.btnKetCau_Accept.TabIndex = 7;
            this.btnKetCau_Accept.Text = "Đồng ý";
            this.btnKetCau_Accept.UseVisualStyleBackColor = true;
            this.btnKetCau_Accept.Click += new System.EventHandler(this.btnKetCau_Accept_Click);
            // 
            // btnKetCau_Cancel
            // 
            this.btnKetCau_Cancel.Location = new System.Drawing.Point(448, 139);
            this.btnKetCau_Cancel.Name = "btnKetCau_Cancel";
            this.btnKetCau_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btnKetCau_Cancel.TabIndex = 8;
            this.btnKetCau_Cancel.Text = "Bỏ qua";
            this.btnKetCau_Cancel.UseVisualStyleBackColor = true;
            this.btnKetCau_Cancel.Click += new System.EventHandler(this.btnKetCau_Cancel_Click);
            // 
            // lblMaKetCau
            // 
            this.lblMaKetCau.AutoSize = true;
            this.lblMaKetCau.Location = new System.Drawing.Point(11, 139);
            this.lblMaKetCau.Name = "lblMaKetCau";
            this.lblMaKetCau.Size = new System.Drawing.Size(0, 16);
            this.lblMaKetCau.TabIndex = 0;
            this.lblMaKetCau.Visible = false;
            // 
            // ctxMenuStrip_ChitietKC
            // 
            this.ctxMenuStrip_ChitietKC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_AddDetail,
            this.ToolStripMenuItem_EditDetail,
            this.ToolStripMenuItem_DeleteDetail});
            this.ctxMenuStrip_ChitietKC.Name = "ctxMenuStrip_ChitietKC";
            this.ctxMenuStrip_ChitietKC.Size = new System.Drawing.Size(145, 70);
            // 
            // ToolStripMenuItem_AddDetail
            // 
            this.ToolStripMenuItem_AddDetail.Name = "ToolStripMenuItem_AddDetail";
            this.ToolStripMenuItem_AddDetail.Size = new System.Drawing.Size(144, 22);
            this.ToolStripMenuItem_AddDetail.Text = "Thêm chi tiết";
            this.ToolStripMenuItem_AddDetail.Click += new System.EventHandler(this.ToolStripMenuItem_AddDetail_Click);
            // 
            // ToolStripMenuItem_EditDetail
            // 
            this.ToolStripMenuItem_EditDetail.Name = "ToolStripMenuItem_EditDetail";
            this.ToolStripMenuItem_EditDetail.Size = new System.Drawing.Size(144, 22);
            this.ToolStripMenuItem_EditDetail.Text = "Sửa chỉ tiết";
            this.ToolStripMenuItem_EditDetail.Click += new System.EventHandler(this.ToolStripMenuItem_EditDetail_Click);
            // 
            // ToolStripMenuItem_DeleteDetail
            // 
            this.ToolStripMenuItem_DeleteDetail.Name = "ToolStripMenuItem_DeleteDetail";
            this.ToolStripMenuItem_DeleteDetail.Size = new System.Drawing.Size(144, 22);
            this.ToolStripMenuItem_DeleteDetail.Text = "Xóa chi tiết";
            this.ToolStripMenuItem_DeleteDetail.Click += new System.EventHandler(this.ToolStripMenuItem_DeleteDetail_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã chi tiết:";
            // 
            // txtMaChiTiet
            // 
            this.txtMaChiTiet.Location = new System.Drawing.Point(85, 51);
            this.txtMaChiTiet.Name = "txtMaChiTiet";
            this.txtMaChiTiet.ReadOnly = true;
            this.txtMaChiTiet.Size = new System.Drawing.Size(213, 22);
            this.txtMaChiTiet.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên chi tiết:";
            // 
            // txtTenChiTiet
            // 
            this.txtTenChiTiet.Location = new System.Drawing.Point(85, 79);
            this.txtTenChiTiet.Name = "txtTenChiTiet";
            this.txtTenChiTiet.Size = new System.Drawing.Size(213, 22);
            this.txtTenChiTiet.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kết cấu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Quy cách:";
            // 
            // txtQuyCach
            // 
            this.txtQuyCach.Location = new System.Drawing.Point(394, 23);
            this.txtQuyCach.Name = "txtQuyCach";
            this.txtQuyCach.Size = new System.Drawing.Size(122, 22);
            this.txtQuyCach.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(314, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Chiều dài:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(314, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Chiều rộng:";
            // 
            // txtChieuDai
            // 
            this.txtChieuDai.Location = new System.Drawing.Point(394, 51);
            this.txtChieuDai.Name = "txtChieuDai";
            this.txtChieuDai.Size = new System.Drawing.Size(122, 22);
            this.txtChieuDai.TabIndex = 1;
            // 
            // txtChieuRong
            // 
            this.txtChieuRong.Location = new System.Drawing.Point(394, 79);
            this.txtChieuRong.Name = "txtChieuRong";
            this.txtChieuRong.Size = new System.Drawing.Size(122, 22);
            this.txtChieuRong.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(314, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tỷ trọng:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(314, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Giá:";
            // 
            // txtTyTrong
            // 
            this.txtTyTrong.Location = new System.Drawing.Point(394, 107);
            this.txtTyTrong.Name = "txtTyTrong";
            this.txtTyTrong.Size = new System.Drawing.Size(122, 22);
            this.txtTyTrong.TabIndex = 1;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(394, 135);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(122, 22);
            this.txtGia.TabIndex = 1;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(327, 189);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Đồng ý";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(426, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Bỏ qua";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboKetCau
            // 
            this.cboKetCau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKetCau.FormattingEnabled = true;
            this.cboKetCau.Location = new System.Drawing.Point(85, 21);
            this.cboKetCau.Name = "cboKetCau";
            this.cboKetCau.Size = new System.Drawing.Size(213, 24);
            this.cboKetCau.TabIndex = 3;
            // 
            // frmKetCau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 485);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmKetCau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý kết cấu";
            this.Load += new System.EventHandler(this.frmKetCau_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ctxMenuStrip_KetCau.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietKetCau)).EndInit();
            this.ctxMenuStrip_ChitietKC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView treeViewKetCau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ContextMenuStrip ctxMenuStrip_KetCau;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Add;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Edit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Delete;
        private System.Windows.Forms.PictureBox picHinhAnh;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenKetCau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvChiTietKetCau;
        private System.Windows.Forms.ComboBox cboNhomKetCau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKetCau_Cancel;
        private System.Windows.Forms.Button btnKetCau_Accept;
        private System.Windows.Forms.Label lblMaKetCau;
        private System.Windows.Forms.ContextMenuStrip ctxMenuStrip_ChitietKC;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_AddDetail;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_EditDetail;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_DeleteDetail;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtChieuRong;
        private System.Windows.Forms.TextBox txtTyTrong;
        private System.Windows.Forms.TextBox txtChieuDai;
        private System.Windows.Forms.TextBox txtQuyCach;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTenChiTiet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaChiTiet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.ComboBox cboKetCau;
    }
}