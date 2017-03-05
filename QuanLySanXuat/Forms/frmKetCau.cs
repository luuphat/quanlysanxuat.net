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
    public partial class frmKetCau : Form
    {
        private int _ketcauId = 0;
        public frmKetCau()
        {
            InitializeComponent();
        }

        private void frmKetCau_Load(object sender, EventArgs e)
        {
            BindingData.BindingKetCau(treeViewKetCau);
            BindingData.BindingNhomKetCau(cboNhomKetCau);
            BindingData.BindingKetCau(cboKetCau, -1);
            ResetFormKC();
        }

        #region kết cấu
        private void ToolStripMenuItem_Add_Click(object sender, EventArgs e)
        {
            ResetFormKC();

            TreeNode node = treeViewKetCau.SelectedNode;
            if (node == null)
                return;

            // nếu người dùng thêm kết cấu từ nhóm thì focus select index đúng nhóm đó
            if (node.Level == 0)
            {
                string s = node.Name;
                if (int.Parse(s) > 0)
                    cboNhomKetCau.SelectedValue = int.Parse(s);
            }
        }

        private void ToolStripMenuItem_Edit_Click(object sender, EventArgs e)
        {
            ResetFormKC();

            TreeNode node = treeViewKetCau.SelectedNode;
            if (node == null)
                return;

            //chỉ edit khi node là Kết cấu
            if (node.Level == 0)
                return;

            string s = node.Name;
            if (int.Parse(s) > 0)
            {
                BLL_KetCau adapter = new BLL_KetCau();
                KetCau _ketcau = adapter.GetByID(int.Parse(s));
                txtTenKetCau.Text = _ketcau.TenKetCau;
                txtMoTa.Text = _ketcau.MoTa;
                cboNhomKetCau.SelectedValue = _ketcau.MaNhomKetCau;
                lblMaKetCau.Text = _ketcau.MaKetCau.ToString();
            }  
            
        }

        private void ToolStripMenuItem_Delete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnKetCau_Accept_Click(object sender, EventArgs e)
        {
            KetCau _ketcau = new KetCau();
            _ketcau.TenKetCau = txtTenKetCau.Text;
            _ketcau.MoTa = txtMoTa.Text;
            _ketcau.NguoiTao = SessionUser.UserName;
            _ketcau.MaNhomKetCau = Convert.ToInt32(cboNhomKetCau.SelectedValue);

            BLL_KetCau adapter = new BLL_KetCau();
            if (lblMaKetCau.Text == string.Empty)
            {
                adapter.Add(_ketcau);
            }
            else
            {
                _ketcau.MaKetCau = int.Parse(lblMaKetCau.Text);
                adapter.Update(_ketcau);
            }

            ResetFormKC();
            BindingData.BindingKetCau(treeViewKetCau);
        }

        private void btnKetCau_Cancel_Click(object sender, EventArgs e)
        {
            ResetFormKC();
        }

        private void ResetFormKC()
        {
            lblMaKetCau.Text = "";
            txtTenKetCau.Text = "";
            txtMoTa.Text = "";
            cboNhomKetCau.SelectedIndex = 0;
        }

        
        #endregion

        #region Chi tiết kết cấu
        private void BindingChiTietKetCau(int maKetCau)
        {
            dgvChiTietKetCau.DataSource = null;

            BLL_KetCau adapter = new BLL_KetCau();
            List<ChiTietKetCau> _list = adapter.ChiTiet_GetListByKetCauID(maKetCau);

            if (_list != null)
            {
                dgvChiTietKetCau.DataSource = _list;
            }
        }

        private void treeViewKetCau_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // show chi tiết kết cấu
            TreeNode node = e.Node;

            if (node != null && node.Level == 1)
            {
                _ketcauId = Convert.ToInt32(node.Name);
                BindingChiTietKetCau(_ketcauId);
            }
        }


        private void ToolStripMenuItem_AddDetail_Click(object sender, EventArgs e)
        {
            ResetFormChiTietKC();
            cboKetCau.SelectedValue = _ketcauId;
            tabControl1.SelectedIndex = 1;
        }

        private void ToolStripMenuItem_EditDetail_Click(object sender, EventArgs e)
        {            
            if (dgvChiTietKetCau.Rows.Count <= 0)
                return;

            if (dgvChiTietKetCau.SelectedRows.Count <= 0)
                return;
            DataGridViewRow r = dgvChiTietKetCau.SelectedRows[0];
            if (r != null)
            {
                ResetFormChiTietKC();
                cboKetCau.SelectedValue = _ketcauId;
                txtMaChiTiet.Text = r.Cells["MaChiTietKetCau"].Value.ToString();
                txtTenChiTiet.Text = r.Cells["TenChiTietKetCau"].Value.ToString();
                txtQuyCach.Text = r.Cells["QuyCach"].Value.ToString();
                txtChieuDai.Text = r.Cells["ChieuDai"].Value.ToString();
                txtChieuRong.Text = r.Cells["ChieuRong"].Value.ToString();
                txtTyTrong.Text = r.Cells["TyTrong"].Value.ToString();
                txtGia.Text = r.Cells["Gia"].Value.ToString();

                tabControl1.SelectedIndex = 1;
            }
        }

        private void ToolStripMenuItem_DeleteDetail_Click(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            ChiTietKetCau chitiet = new ChiTietKetCau();
            chitiet.TenChiTietKetCau = txtTenChiTiet.Text;
            chitiet.MaKetCau = Convert.ToInt32(cboKetCau.SelectedValue);
            chitiet.QuyCach = txtQuyCach.Text;
            chitiet.ChieuDai = Convert.ToInt32(txtChieuDai.Text);
            chitiet.ChieuRong = Convert.ToInt32(txtChieuRong.Text);
            chitiet.TyTrong = Convert.ToDecimal(txtTyTrong.Text);
            chitiet.Gia = Convert.ToDecimal(txtGia.Text);
            chitiet.NguoiTao = SessionUser.UserName;

            BLL_KetCau adapter = new BLL_KetCau();
            int result = -1;
            if (txtMaChiTiet.Text == string.Empty)
            {
                result = adapter.ChiTiet_Add(chitiet);
            }
            else
            {
                chitiet.MaChiTietKetCau = int.Parse(txtMaChiTiet.Text);
                result = adapter.ChiTiet_Update(chitiet);
            }

            if (result >= 0)
            {
                ResetFormChiTietKC();
                BindingChiTietKetCau(_ketcauId);
                tabControl1.SelectedIndex = 0;
            }
            else
                MessageBox.Show("Lỗi khi cập nhật chi tiết kết cấu", "Thông báo");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetFormChiTietKC();
            tabControl1.SelectedIndex = 0;
        }

        private void ResetFormChiTietKC()
        {
            cboKetCau.SelectedIndex = 0;
            txtMaChiTiet.Text = "";
            txtTenChiTiet.Text = "";
            txtQuyCach.Text = "";
            txtChieuDai.Text = "0";
            txtChieuRong.Text = "0";
            txtTyTrong.Text = "0";
            txtGia.Text = "0";
        }
        #endregion

    }
}
