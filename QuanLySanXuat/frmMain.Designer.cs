namespace QuanLySanXuat
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Ketcau = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_KhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_NhomKetCau = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_CongTrinh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(713, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Ketcau,
            this.ToolStripMenuItem_KhachHang,
            this.ToolStripMenuItem_NhomKetCau,
            this.ToolStripMenuItem_CongTrinh});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // ToolStripMenuItem_Ketcau
            // 
            this.ToolStripMenuItem_Ketcau.Name = "ToolStripMenuItem_Ketcau";
            this.ToolStripMenuItem_Ketcau.Size = new System.Drawing.Size(191, 22);
            this.ToolStripMenuItem_Ketcau.Text = "Quản lý kết cấu";
            this.ToolStripMenuItem_Ketcau.Click += new System.EventHandler(this.ToolStripMenuItem_Ketcau_Click);
            // 
            // ToolStripMenuItem_KhachHang
            // 
            this.ToolStripMenuItem_KhachHang.Name = "ToolStripMenuItem_KhachHang";
            this.ToolStripMenuItem_KhachHang.Size = new System.Drawing.Size(191, 22);
            this.ToolStripMenuItem_KhachHang.Text = "Quản lý Khách hàng";
            this.ToolStripMenuItem_KhachHang.Click += new System.EventHandler(this.ToolStripMenuItem_KhachHang_Click);
            // 
            // ToolStripMenuItem_NhomKetCau
            // 
            this.ToolStripMenuItem_NhomKetCau.Name = "ToolStripMenuItem_NhomKetCau";
            this.ToolStripMenuItem_NhomKetCau.Size = new System.Drawing.Size(191, 22);
            this.ToolStripMenuItem_NhomKetCau.Text = "Quản lý nhóm kết cấu";
            this.ToolStripMenuItem_NhomKetCau.Click += new System.EventHandler(this.ToolStripMenuItem_NhomKetCau_Click);
            // 
            // ToolStripMenuItem_CongTrinh
            // 
            this.ToolStripMenuItem_CongTrinh.Name = "ToolStripMenuItem_CongTrinh";
            this.ToolStripMenuItem_CongTrinh.Size = new System.Drawing.Size(191, 22);
            this.ToolStripMenuItem_CongTrinh.Text = "Quản lý công trình";
            this.ToolStripMenuItem_CongTrinh.Click += new System.EventHandler(this.ToolStripMenuItem_CongTrinh_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 408);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản xuất";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Ketcau;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_KhachHang;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_NhomKetCau;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_CongTrinh;
    }
}

