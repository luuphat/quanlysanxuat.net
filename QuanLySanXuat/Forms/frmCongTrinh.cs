using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLySanXuat.Models;
using QuanLySanXuat.BO;

namespace QuanLySanXuat.Forms
{
    public partial class frmCongTrinh : Form
    {
        public frmCongTrinh()
        {
            InitializeComponent();
        }

        private void frmCongTrinh_Load(object sender, EventArgs e)
        {
            BindingCongTrinh(string.Empty, -1, -1, dtTuNgay.Value, dtDenNgay.Value);
            BindingData.BindingKhachHang(cboKhachHang);
            BindingData.BindingKhachHang(cboKhachHang1);
            BindingData.BindingTTHopDong(cboTinhTrang);
            BindingData.BindingTTHopDong(cboTinhTrang1);
        }

        private void BindingCongTrinh(string keySearch, int maKhachHang, int maTinhTrang, DateTime tuNgay, DateTime denNgay)
        {
            //dgvCongTrinh.DataSource = null;

            //BLL_CongTrinh adapter = new BLL_CongTrinh();
            //List<CongTrinh> list = adapter.GetList(maKhachHang, maTinhTrang, tuNgay, denNgay, keySearch);
            //if (list != null && list.Count > 0)
            //{
            //    dgvCongTrinh.DataSource = list;
            //}
        }

        private void ToolStripMenuItem_Add_Click(object sender, EventArgs e)
        {
            ResetFormCongTrinh();
            tabControl_CongTrinh.SelectedIndex = 1;

        }

        private void ToolStripMenuItem_Edit_Click(object sender, EventArgs e)
        {
            //if (dgvCongTrinh.Rows.Count <= 0)
            //    return;
            //if (dgvCongTrinh.SelectedRows.Count <= 0)
            //    return;

            //DataGridViewRow r = dgvCongTrinh.SelectedRows[0];
            //if (r != null)
            //{
            //    ResetFormCongTrinh();
            //    txtMaCongTrinh.Text = r.Cells["CongTrinhID"].Value.ToString();
            //    txtTenCongTrinh.Text = r.Cells["TenCongTrinh"].Value.ToString();
            //    txtMaHieuCT.Text = r.Cells["MaHieuCT"].Value.ToString();
            //    txtSoHopDong.Text = r.Cells["SoHopDong"].Value.ToString();
            //    cboKhachHang1.SelectedValue = r.Cells["MaKhachHang"].Value;
            //    dtNgayKy.Value = Convert.ToDateTime(r.Cells["NgayKy"].Value);
            //    dtNgayBatDau.Value = Convert.ToDateTime(r.Cells["NgayBatDauCT"].Value);
            //    dtNgayKetThuc.Value = Convert.ToDateTime(r.Cells["NgayKetThucCT"].Value);
            //    cboTinhTrang1.SelectedValue = r.Cells["TinhTrangID"].Value;
            //    txtGhiChu.Text = r.Cells["GhiChu"].Value.ToString();

            //    tabControl_CongTrinh.SelectedIndex = 1;
            //}
        }

        private void ToolStripMenuItem_Delete_Click(object sender, EventArgs e)
        {

        }

        private void ResetFormCongTrinh()
        {
            txtMaCongTrinh.Text = string.Empty;
            txtTenCongTrinh.Text = string.Empty;
            txtMaHieuCT.Text = string.Empty;
            txtSoHopDong.Text = string.Empty;
            cboKhachHang1.SelectedIndex = 0;
            cboTinhTrang1.SelectedIndex = 0;
            dtNgayKy.Value = DateTime.Now;
            dtNgayBatDau.Value = DateTime.Now;
            dtNgayKetThuc.Value = DateTime.Now;
            txtGhiChu.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetFormCongTrinh();
            tabControl_CongTrinh.SelectedIndex = 0;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            CongTrinh _congtrinh = new CongTrinh();
            _congtrinh.TenCongTrinh = txtTenCongTrinh.Text;
            _congtrinh.MaHieuCT = txtMaHieuCT.Text;
            _congtrinh.SoHopDong = txtSoHopDong.Text;
            _congtrinh.MaKhachHang = Convert.ToInt32(cboKhachHang1.SelectedValue);
            _congtrinh.TinhTrangID = Convert.ToInt32(cboTinhTrang1.SelectedValue);
            _congtrinh.NgayKy = dtNgayKy.Value;
            _congtrinh.NgayBatDauCT = dtNgayBatDau.Value;
            _congtrinh.NgayKetThucCT = dtNgayKetThuc.Value;
            _congtrinh.NguoiTao = SessionUser.UserName;
            _congtrinh.GhiChu = txtGhiChu.Text;

            if (txtMaCongTrinh.Text != string.Empty)
                _congtrinh.CongTrinhID = Convert.ToInt32(txtMaCongTrinh.Text);

            BLL_CongTrinh adapter = new BLL_CongTrinh();
            adapter.Add(_congtrinh);

            BindingCongTrinh(string.Empty, Convert.ToInt32(cboKhachHang.SelectedValue), Convert.ToInt32(cboTinhTrang.SelectedValue), dtTuNgay.Value, dtDenNgay.Value);
            tabControl_CongTrinh.SelectedIndex = 0;
        }
    }
}
