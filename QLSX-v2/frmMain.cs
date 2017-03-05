using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLSX
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forms.frmCongTrinh frmCongTrinh = new Forms.frmCongTrinh();
            frmCongTrinh.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.frmKhachHang frmKH = new Forms.frmKhachHang();
            frmKH.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SessionUser.Login("admin", "admin");
        }
    }
}
