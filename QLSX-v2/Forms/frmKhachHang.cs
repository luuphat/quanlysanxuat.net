using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLSX.Models;
using QLSX.BO;

namespace QLSX.Forms
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            SearchKhachHang(string.Empty);
        }

        private void ToolStripMenuItem_Add_Click(object sender, EventArgs e)
        {
            ResetForm();
            tabControl1.SelectedIndex = 1;
        }

        private void ResetForm()
        {
            txtMaKhachHang.Text = "";
            txtTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtFax.Text = "";
            txtEmail.Text = "";
            txtWebsite.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
            SearchKhachHang(string.Empty);
            tabControl1.SelectedIndex = 0;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            BLL_KhachHang adapter = new BLL_KhachHang();
            KhachHang _khachhang = new KhachHang();
            int id;
            int.TryParse(txtMaKhachHang.Text, out id);
            _khachhang.MaKhachHang = id;
            _khachhang.TenKhachHang = txtTenKhachHang.Text;
            _khachhang.DiaChi = txtDiaChi.Text;
            _khachhang.DienThoai = txtDienThoai.Text;
            _khachhang.Fax = txtFax.Text;
            _khachhang.Email = txtEmail.Text;
            _khachhang.Website = txtWebsite.Text;
            _khachhang.NguoiTao = SessionUser.UserName;

            int result = -1;
            if (txtMaKhachHang.Text == "")
                result = adapter.Add(_khachhang);
            else
                result = adapter.Update(_khachhang);

            if (result >= 0)
            {
                MessageBox.Show("Cập nhật thông tin khách hàng thành công");
                ResetForm();
                tabControl1.SelectedIndex =0;
                SearchKhachHang(string.Empty);
            }
            else
            {
                MessageBox.Show("Lỗi khi cập nhật khách hàng");
            }
        }

        private void ToolStripMenuItem_Edit_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.Rows.Count <= 0)
                return;

            if (dgvKhachHang.SelectedRows.Count <= 0)
                return;

            DataGridViewRow r = dgvKhachHang.SelectedRows[0];
            if (r != null)
            {
                ResetForm();
                txtMaKhachHang.Text = r.Cells["MaKhachHang"].Value.ToString();
                txtTenKhachHang.Text = r.Cells["TenKhachHang"].Value.ToString();
                txtDiaChi.Text = r.Cells["DiaChi"].Value.ToString();
                txtDienThoai.Text = r.Cells["DienThoai"].Value.ToString();
                txtFax.Text = r.Cells["Fax"].Value.ToString();
                txtEmail.Text = r.Cells["Email"].Value.ToString();
                txtWebsite.Text = r.Cells["Website"].Value.ToString();

                tabControl1.SelectedIndex = 1;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchKhachHang(txtKeySearch.Text.Trim());
        }

        private void ToolStripMenuItem_Delete_Click(object sender, EventArgs e)
        {
            KhachHang _khachhang = new KhachHang();
            if (dgvKhachHang.Rows.Count <= 0)
                return;

            if (dgvKhachHang.SelectedRows.Count <= 0)
                return;

            DataGridViewRow r = dgvKhachHang.SelectedRows[0];
            if (r != null)
            {
                _khachhang.MaKhachHang = Convert.ToInt32(r.Cells["MaKhachHang"].Value);
                _khachhang.TenKhachHang = r.Cells["TenKhachHang"].Value.ToString();
            }

            if (MessageBox.Show(String.Format("Bạn có muốm xóa khách hàng [{0}] không?", _khachhang.TenKhachHang), "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                BLL_KhachHang adapter = new BLL_KhachHang();
                adapter.Delete(_khachhang);

                SearchKhachHang(string.Empty);
            }
        }

        private void SearchKhachHang(string keySearch)
        {
            BLL_KhachHang adapter = new BLL_KhachHang();
            dgvKhachHang.DataSource = adapter.GetList(keySearch);
        }
    }
}
