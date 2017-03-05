using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLySanXuat.BO;
using QuanLySanXuat.Models;

namespace QuanLySanXuat.Forms
{
    public partial class frmNhomKetCau : Form
    {
        public frmNhomKetCau()
        {
            InitializeComponent();
        }

        private void frmNhomKetCau_Load(object sender, EventArgs e)
        {
            BindingNhomKetCau();
        }

        private void ToolStripMenuItem_Add_Click(object sender, EventArgs e)
        {
            ResetFormNhomKC();
        }

        private void ToolStripMenuItem_Edit_Click(object sender, EventArgs e)
        {
            ResetFormNhomKC();

            TreeNode node = treeViewNhomKC.SelectedNode;
            if (node == null)
                return;

            string s = node.Name;
            if (int.Parse(s) > 0)
            {
                BLL_KetCau adapter = new BLL_KetCau();
                NhomKetCau _nhomketcau = adapter.NhomKetCau_GetByID(int.Parse(s));
                txtTenNhomKetCau.Text = _nhomketcau.TenNhomKetCau;
                txtSapXep.Text = _nhomketcau.SapXep.ToString();
                txtMaNhomKetCau.Text = _nhomketcau.MaNhomKetCau.ToString();
            }  
        }

        private void ToolStripMenuItem_Delete_Click(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            NhomKetCau _nhomketcau = new NhomKetCau();
            _nhomketcau.TenNhomKetCau = txtTenNhomKetCau.Text;
            _nhomketcau.SapXep = Convert.ToInt32(txtSapXep.Text);
            _nhomketcau.NguoiTao = SessionUser.UserName;

            BLL_KetCau apdater = new BLL_KetCau();
            if (txtMaNhomKetCau.Text != "")
            {
                _nhomketcau.MaNhomKetCau = Convert.ToInt32(txtMaNhomKetCau.Text);
                apdater.NhomKetCau_Update(_nhomketcau);
            }
            else
                apdater.NhomKetCau_Add(_nhomketcau);

            ResetFormNhomKC();
            BindingNhomKetCau();
            // refresh treeView
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetFormNhomKC();
        }

        private void ResetFormNhomKC()
        {
            txtMaNhomKetCau.Text = "";
            txtTenNhomKetCau.Text = "";
            txtTenNhomKetCau.Focus();
            txtSapXep.Text = "0";
        }

        private void BindingNhomKetCau()
        {
            BLL_KetCau adapter = new BLL_KetCau();
            List<NhomKetCau> _list = adapter.NhomKetCau_GetList(string.Empty);

            if (_list != null)
            {
                treeViewNhomKC.Nodes.Clear();
                System.Windows.Forms.TreeNode root = treeViewNhomKC.Nodes.Add("-1", "Nhóm kết cấu - tất cả");

                var list = (from item in _list
                            orderby item.SapXep
                            select item);
                foreach (NhomKetCau o in list)
                {
                    root.Nodes.Add(o.MaNhomKetCau.ToString(), o.TenNhomKetCau);
                }
                treeViewNhomKC.ExpandAll();
            }
        }
    }
}
