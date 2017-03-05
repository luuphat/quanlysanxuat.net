using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLySanXuat
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Helper
        private Form IsExistsForm(Type formType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formType)
                    return f;

            }
            return null;
        }
        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            //tạo session
            if (!SessionUser.Login("admin", "admin"))
                Application.Exit();
        }

        private void ToolStripMenuItem_KhachHang_Click(object sender, EventArgs e)
        {
            Form f = IsExistsForm(typeof(Forms.frmKhachHang));
            if (f != null)
                f.Activate();
            else
            {
                Forms.frmKhachHang objF = new Forms.frmKhachHang() { MdiParent = this };
                objF.Show();
            }
        }

        private void ToolStripMenuItem_Ketcau_Click(object sender, EventArgs e)
        {
            Form f = IsExistsForm(typeof(Forms.frmKetCau));
            if (f != null)
                f.Activate();
            else
            {
                Forms.frmKetCau objF = new Forms.frmKetCau() { MdiParent = this };
                objF.Show();
            }
        }

        private void ToolStripMenuItem_NhomKetCau_Click(object sender, EventArgs e)
        {
            Form f = IsExistsForm(typeof(Forms.frmNhomKetCau));
            if (f != null)
                f.Activate();
            else
            {
                Forms.frmNhomKetCau objF = new Forms.frmNhomKetCau() { MdiParent = this };
                objF.Show();
            }
        }

        private void ToolStripMenuItem_CongTrinh_Click(object sender, EventArgs e)
        {
            Form f = IsExistsForm(typeof(Forms.frmCongTrinh));
            if (f != null)
                f.Activate();
            else
            {
                Forms.frmCongTrinh objF = new Forms.frmCongTrinh() { MdiParent = this };
                objF.Show();
            }
        }

    }
}
