namespace QLSX.Forms
{
    partial class frmCongTrinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCongTrinh));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKeySearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl_CongTrinh = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.flexCongTrinh = new C1DataTree.C1FlexDataTree();
            this.ctxMenuStrip_CongTrinh = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.flexHangMuc = new C1DataTree.C1FlexDataTree();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.dtNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtNgayKy = new System.Windows.Forms.DateTimePicker();
            this.cboTinhTrang1 = new System.Windows.Forms.ComboBox();
            this.cboKhachHang1 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtSoHopDong = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaHieuCT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenCongTrinh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaCongTrinh = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl_CongTrinh.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexCongTrinh)).BeginInit();
            this.ctxMenuStrip_CongTrinh.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexHangMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.dtDenNgay);
            this.groupBox1.Controls.Add(this.dtTuNgay);
            this.groupBox1.Controls.Add(this.cboTinhTrang);
            this.groupBox1.Controls.Add(this.cboKhachHang);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtKeySearch);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(750, 49);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtDenNgay
            // 
            this.dtDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDenNgay.Location = new System.Drawing.Point(617, 19);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Size = new System.Drawing.Size(104, 22);
            this.dtDenNgay.TabIndex = 3;
            // 
            // dtTuNgay
            // 
            this.dtTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTuNgay.Location = new System.Drawing.Point(439, 21);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Size = new System.Drawing.Size(98, 22);
            this.dtTuNgay.TabIndex = 3;
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Location = new System.Drawing.Point(439, 49);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(282, 24);
            this.cboTinhTrang.TabIndex = 2;
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(103, 49);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(254, 24);
            this.cboKhachHang.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tình trạng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Khách hàng:";
            // 
            // txtKeySearch
            // 
            this.txtKeySearch.Location = new System.Drawing.Point(103, 21);
            this.txtKeySearch.Name = "txtKeySearch";
            this.txtKeySearch.Size = new System.Drawing.Size(254, 22);
            this.txtKeySearch.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đến ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Từ ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nội dung tìm:";
            // 
            // tabControl_CongTrinh
            // 
            this.tabControl_CongTrinh.Controls.Add(this.tabPage4);
            this.tabControl_CongTrinh.Controls.Add(this.tabPage5);
            this.tabControl_CongTrinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_CongTrinh.Location = new System.Drawing.Point(0, 0);
            this.tabControl_CongTrinh.Name = "tabControl_CongTrinh";
            this.tabControl_CongTrinh.SelectedIndex = 0;
            this.tabControl_CongTrinh.Size = new System.Drawing.Size(855, 481);
            this.tabControl_CongTrinh.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.flexCongTrinh);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(847, 452);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Danh sách công trình";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // flexCongTrinh
            // 
            this.flexCongTrinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flexCongTrinh.ColumnInfo = "10,1,0,0,0,105,Columns:0{Width:38;Style:\"ImageAlign:RightCenter;\";}\t";
            this.flexCongTrinh.ContextMenuStrip = this.ctxMenuStrip_CongTrinh;
            this.flexCongTrinh.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
            this.flexCongTrinh.Location = new System.Drawing.Point(8, 97);
            this.flexCongTrinh.Name = "flexCongTrinh";
            this.flexCongTrinh.Rows.DefaultSize = 21;
            this.flexCongTrinh.Size = new System.Drawing.Size(831, 347);
            this.flexCongTrinh.StyleInfo = resources.GetString("flexCongTrinh.StyleInfo");
            this.flexCongTrinh.TabIndex = 1;
            this.flexCongTrinh.SetupColumns += new System.EventHandler(this._flex_SetupColumns);
            // 
            // ctxMenuStrip_CongTrinh
            // 
            this.ctxMenuStrip_CongTrinh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Add,
            this.ToolStripMenuItem_Edit,
            this.ToolStripMenuItem_Delete});
            this.ctxMenuStrip_CongTrinh.Name = "ctxMenuStrip_CongTrinh";
            this.ctxMenuStrip_CongTrinh.Size = new System.Drawing.Size(106, 70);
            // 
            // ToolStripMenuItem_Add
            // 
            this.ToolStripMenuItem_Add.Name = "ToolStripMenuItem_Add";
            this.ToolStripMenuItem_Add.Size = new System.Drawing.Size(105, 22);
            this.ToolStripMenuItem_Add.Text = "Thêm";
            this.ToolStripMenuItem_Add.Click += new System.EventHandler(this.ToolStripMenuItem_Add_Click);
            // 
            // ToolStripMenuItem_Edit
            // 
            this.ToolStripMenuItem_Edit.Name = "ToolStripMenuItem_Edit";
            this.ToolStripMenuItem_Edit.Size = new System.Drawing.Size(105, 22);
            this.ToolStripMenuItem_Edit.Text = "Sửa";
            this.ToolStripMenuItem_Edit.Click += new System.EventHandler(this.ToolStripMenuItem_Edit_Click);
            // 
            // ToolStripMenuItem_Delete
            // 
            this.ToolStripMenuItem_Delete.Name = "ToolStripMenuItem_Delete";
            this.ToolStripMenuItem_Delete.Size = new System.Drawing.Size(105, 22);
            this.ToolStripMenuItem_Delete.Text = "Xóa";
            this.ToolStripMenuItem_Delete.Click += new System.EventHandler(this.ToolStripMenuItem_Delete_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.flexHangMuc);
            this.tabPage5.Controls.Add(this.btnCancel);
            this.tabPage5.Controls.Add(this.btnAccept);
            this.tabPage5.Controls.Add(this.dtNgayKetThuc);
            this.tabPage5.Controls.Add(this.dtNgayBatDau);
            this.tabPage5.Controls.Add(this.dtNgayKy);
            this.tabPage5.Controls.Add(this.cboTinhTrang1);
            this.tabPage5.Controls.Add(this.cboKhachHang1);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.txtGhiChu);
            this.tabPage5.Controls.Add(this.txtSoHopDong);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.txtMaHieuCT);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.txtTenCongTrinh);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.txtMaCongTrinh);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(847, 452);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Cập nhật công trình";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // flexHangMuc
            // 
            this.flexHangMuc.AllowAddNew = true;
            this.flexHangMuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flexHangMuc.ColumnInfo = "10,1,0,0,0,105,Columns:0{Width:38;Style:\"ImageAlign:RightCenter;\";}\t";
            this.flexHangMuc.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
            this.flexHangMuc.Location = new System.Drawing.Point(8, 130);
            this.flexHangMuc.Name = "flexHangMuc";
            this.flexHangMuc.Rows.Count = 51;
            this.flexHangMuc.Rows.DefaultSize = 21;
            this.flexHangMuc.Size = new System.Drawing.Size(831, 285);
            this.flexHangMuc.StyleInfo = resources.GetString("flexHangMuc.StyleInfo");
            this.flexHangMuc.TabIndex = 5;
            this.flexHangMuc.SetupColumns += new System.EventHandler(this._flex_SetupColumns);
            this.flexHangMuc.RowValidated += new C1.Win.C1FlexGrid.RowColEventHandler(this.flexHangMuc_RowValidated);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(764, 421);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Bỏ qua";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Location = new System.Drawing.Point(653, 421);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Đồng ý";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // dtNgayKetThuc
            // 
            this.dtNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayKetThuc.Location = new System.Drawing.Point(318, 74);
            this.dtNgayKetThuc.Name = "dtNgayKetThuc";
            this.dtNgayKetThuc.Size = new System.Drawing.Size(101, 22);
            this.dtNgayKetThuc.TabIndex = 3;
            // 
            // dtNgayBatDau
            // 
            this.dtNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayBatDau.Location = new System.Drawing.Point(108, 72);
            this.dtNgayBatDau.Name = "dtNgayBatDau";
            this.dtNgayBatDau.Size = new System.Drawing.Size(101, 22);
            this.dtNgayBatDau.TabIndex = 3;
            // 
            // dtNgayKy
            // 
            this.dtNgayKy.CustomFormat = "dd/MM/yyyy";
            this.dtNgayKy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayKy.Location = new System.Drawing.Point(712, 44);
            this.dtNgayKy.Name = "dtNgayKy";
            this.dtNgayKy.Size = new System.Drawing.Size(127, 22);
            this.dtNgayKy.TabIndex = 3;
            // 
            // cboTinhTrang1
            // 
            this.cboTinhTrang1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhTrang1.DropDownWidth = 200;
            this.cboTinhTrang1.FormattingEnabled = true;
            this.cboTinhTrang1.Location = new System.Drawing.Point(712, 72);
            this.cboTinhTrang1.Name = "cboTinhTrang1";
            this.cboTinhTrang1.Size = new System.Drawing.Size(127, 24);
            this.cboTinhTrang1.TabIndex = 2;
            // 
            // cboKhachHang1
            // 
            this.cboKhachHang1.FormattingEnabled = true;
            this.cboKhachHang1.Location = new System.Drawing.Point(318, 44);
            this.cboKhachHang1.Name = "cboKhachHang1";
            this.cboKhachHang1.Size = new System.Drawing.Size(303, 24);
            this.cboKhachHang1.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(627, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tình trạng:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(108, 102);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(732, 22);
            this.txtGhiChu.TabIndex = 1;
            // 
            // txtSoHopDong
            // 
            this.txtSoHopDong.Location = new System.Drawing.Point(107, 44);
            this.txtSoHopDong.Name = "txtSoHopDong";
            this.txtSoHopDong.Size = new System.Drawing.Size(100, 22);
            this.txtSoHopDong.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "Ghi chú:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(220, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Khách hàng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số hợp đồng:";
            // 
            // txtMaHieuCT
            // 
            this.txtMaHieuCT.Location = new System.Drawing.Point(712, 16);
            this.txtMaHieuCT.Name = "txtMaHieuCT";
            this.txtMaHieuCT.Size = new System.Drawing.Size(127, 22);
            this.txtMaHieuCT.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(627, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã hiệu CT:";
            // 
            // txtTenCongTrinh
            // 
            this.txtTenCongTrinh.Location = new System.Drawing.Point(318, 16);
            this.txtTenCongTrinh.Name = "txtTenCongTrinh";
            this.txtTenCongTrinh.Size = new System.Drawing.Size(303, 22);
            this.txtTenCongTrinh.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên công trình:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(220, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Ngày kết thúc:";
            // 
            // txtMaCongTrinh
            // 
            this.txtMaCongTrinh.Location = new System.Drawing.Point(108, 16);
            this.txtMaCongTrinh.Name = "txtMaCongTrinh";
            this.txtMaCongTrinh.ReadOnly = true;
            this.txtMaCongTrinh.Size = new System.Drawing.Size(100, 22);
            this.txtMaCongTrinh.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ngày bắt đầu:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã công trình:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày ký:";
            // 
            // frmCongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 481);
            this.Controls.Add(this.tabControl_CongTrinh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCongTrinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý công trình";
            this.Load += new System.EventHandler(this.frmCongTrinh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl_CongTrinh.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flexCongTrinh)).EndInit();
            this.ctxMenuStrip_CongTrinh.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexHangMuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtDenNgay;
        private System.Windows.Forms.DateTimePicker dtTuNgay;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKeySearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TabControl tabControl_CongTrinh;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtSoHopDong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaHieuCT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenCongTrinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaCongTrinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtNgayKy;
        private System.Windows.Forms.ComboBox cboKhachHang1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboTinhTrang1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.ContextMenuStrip ctxMenuStrip_CongTrinh;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Add;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Edit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Delete;
        private C1DataTree.C1FlexDataTree flexHangMuc;
        private C1DataTree.C1FlexDataTree flexCongTrinh;
    }
}