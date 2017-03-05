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
using DevExpress.XtraGrid.Views.Grid;
using C1DataTree;
using C1.Win.C1FlexGrid;
using System.Collections;

namespace QLSX.Forms
{
    public partial class frmCongTrinh : Form
    {
        private DataSet _ds = new DataSet();
        private string[] _showColumnCT = new string[] { "MaHieuCT, Mã hiệu công trình", "TenCongTrinh, Tên công trình","SoHopDong, Số hơp đồng", "MaKhachHang, Khách hàng", 
            "NgayKy, Ngày ký", "NgayBatDauCT, Ngày bắt đầu", "NgayKetThucCT, Ngày kết thúc", "MaTinhTrang, Tình trạng", "GiaTriHD, Giá trị HD", "TrongLuongTK, Trọng lượng TK",
            "TrongLuongTT, Trọng lượng TT", "HoanCong, Hoàn công", "QuyetToanKH, Quyết toán KH", "GhiChu, Ghi chú", "NguoiTao, Người tạo", "NgayTao, Ngày tạo"};
        private string[] _showColumnHM = new string[] { "TenHangMuc, Tên hạng mục", "SoLuong, Số lượng", "DonGia, Đơn giá"};
        private string[] _showColumnCTHM = new string[] { "TenChiTiet, Chi tiết", "QuyCach, Quy cách", "ChieuDai, Chiều dài", "ChieuRong, Chiều rộng",
            "TyTrong, Tỷ trọng", "SoLuong, Số lượng", "TLDonVi, TL đơn vị", "DonGia, Đơn giá", "GhiChu, Ghi chú"};

        public frmCongTrinh()
        {
            InitializeComponent();
        }

        private void frmCongTrinh_Load(object sender, EventArgs e)
        {
            //BindingCongTrinh(string.Empty, -1, -1, dtTuNgay.Value, dtDenNgay.Value);
            BindingData.BindingKhachHang(cboKhachHang);
            BindingData.BindingKhachHang(cboKhachHang1);
            BindingData.BindingTTHopDong(cboTinhTrang);
            BindingData.BindingTTHopDong(cboTinhTrang1);

            SearchByCongTrinh(txtKeySearch.Text, dtTuNgay.Value, dtDenNgay.Value, Convert.ToInt32(cboKhachHang.SelectedValue), Convert.ToString(cboTinhTrang.SelectedValue));
            InitDataSetHangMuc(-1);
        }

        private void SearchByCongTrinh(string keySearch, DateTime dtFormDate, DateTime dtToDate, int maKhachHang, string maTinhTrang)
        {
            DataSet _dsCT = new DataSet();
            BLL_CongTrinh adapter = new BLL_CongTrinh();
            BLL_HangMuc adapterHM = new BLL_HangMuc();

            List<CongTrinh> _listCT = adapter.GetList(maKhachHang, maTinhTrang, dtFormDate, dtToDate, keySearch);
            List<HangMuc> _listHM = new List<HangMuc>();
            List<ChiTietHangMuc> _listCTHM = new List<ChiTietHangMuc>();
            if (_listCT != null)
            {
                foreach (CongTrinh _ct in _listCT)
                {
                    List<HangMuc> _temp = adapterHM.GetList(_ct.MaCongTrinh, string.Empty, string.Empty);
                    if (_temp != null)
                        _listHM.AddRange(_temp);
                }

                foreach (HangMuc _hm in _listHM)
                {
                    List<ChiTietHangMuc> _temp1 = adapterHM.ChiTiet_GetList(_hm.MaHangMuc, string.Empty);
                    if(_temp1 != null)
                        _listCTHM.AddRange(_temp1);
                }
            }
            else
            {
                _listCT = new List<CongTrinh>();
            }
            DataTable _congtrinh = Utils.ToDataTable<CongTrinh>(_listCT);
            DataTable _hangmuc = Utils.ToDataTable<HangMuc>(_listHM);
            DataTable _chitiethangmuc = Utils.ToDataTable<ChiTietHangMuc>(_listCTHM);

            _congtrinh.ExtendedProperties.Add("ShowColumns", _showColumnCT);
            _hangmuc.ExtendedProperties.Add("ShowColumns", _showColumnHM);
            _chitiethangmuc.ExtendedProperties.Add("ShowColumns", _showColumnCTHM);

            _dsCT.Tables.Add(_congtrinh);
            _dsCT.Tables.Add(_hangmuc);
            _dsCT.Tables.Add(_chitiethangmuc);
            
            _dsCT.Relations.Add("CongTrinh_HangMuc",
                _dsCT.Tables["CongTrinh"].Columns["MaCongTrinh"],
                _dsCT.Tables["HangMuc"].Columns["MaCongTrinh"]);

            _dsCT.Relations.Add("HangMuc_ChiTietHangMuc",
                _dsCT.Tables["HangMuc"].Columns["MaHangMuc"],
                _dsCT.Tables["ChiTietHangMuc"].Columns["MaHangMuc"]);

            flexCongTrinh.SetDataBinding(_dsCT, "CongTrinh");
        }

        private void InitDataSetHangMuc(int maCongTrinh)
        {
            _ds = new DataSet();
            BLL_HangMuc adapter = new BLL_HangMuc();

            List<HangMuc> _listHM = new List<HangMuc>();
            List<ChiTietHangMuc> _listCTHM = new List<ChiTietHangMuc>();

            if (maCongTrinh > 0)
            {
                _listHM = adapter.GetList(maCongTrinh, string.Empty, string.Empty);
                if (_listHM != null)
                {
                    foreach (HangMuc _hm in _listHM)
                    {
                        List<ChiTietHangMuc> _temp1 = adapter.ChiTiet_GetList(_hm.MaHangMuc, string.Empty);
                        if (_temp1 != null)
                            _listCTHM.AddRange(_temp1);
                    }
                }
                else
                    _listHM = new List<HangMuc>();
            }

            DataTable _hangmuc = Utils.ToDataTable<HangMuc>(_listHM);
            DataTable _chitiethangmuc = Utils.ToDataTable<ChiTietHangMuc>(_listCTHM);

            DataColumn _column = new DataColumn();
            _column.ColumnName = "ID";
            _column.DataType = System.Type.GetType("System.String");
            _column.DefaultValue = Guid.NewGuid();
            _hangmuc.Columns.Add(_column);
            _hangmuc.Columns.Add("Status", Type.GetType("System.String"));
            foreach (DataRow dr in _hangmuc.Rows)
            {
                dr["ID"] = dr["MaHangMuc"];
                dr["Status"] = 1;
            }
            
            _chitiethangmuc.Columns.Add("ParentID", Type.GetType("System.String"));
            foreach (DataRow dr in _chitiethangmuc.Rows)
            {
                dr["ParentID"] = dr["MaHangMuc"];
            }

            _ds.Tables.Add(_hangmuc);
            _ds.Tables.Add(_chitiethangmuc);

            _ds.Relations.Add("HangMuc_ChiTietHangMuc",
                _ds.Tables["HangMuc"].Columns["ID"],
                _ds.Tables["ChiTietHangMuc"].Columns["ParentID"]);
            flexHangMuc.SetDataBinding(_ds, "HangMuc");
        }

        private void ToolStripMenuItem_Add_Click(object sender, EventArgs e)
        {
            InitDataSetHangMuc(0);
            tabControl_CongTrinh.SelectedIndex = 1;
        }

        private void ToolStripMenuItem_Edit_Click(object sender, EventArgs e)
        {
            int _maCT = Convert.ToInt32(flexCongTrinh.Rows[flexCongTrinh.Row]["MaCongTrinh"]);
            txtMaCongTrinh.Text = _maCT.ToString();
            txtTenCongTrinh.Text = flexCongTrinh.Rows[flexCongTrinh.Row]["TenCongTrinh"].ToString();
            txtMaHieuCT.Text = flexCongTrinh.Rows[flexCongTrinh.Row]["MaHieuCT"].ToString();
            txtSoHopDong.Text = flexCongTrinh.Rows[flexCongTrinh.Row]["SoHopDong"].ToString();
            cboKhachHang1.SelectedValue = Convert.ToInt32(flexCongTrinh.Rows[flexCongTrinh.Row]["MaKhachHang"]);
            cboTinhTrang1.SelectedValue = flexCongTrinh.Rows[flexCongTrinh.Row]["MaTinhTrang"];
            dtNgayKy.Value = Convert.ToDateTime(flexCongTrinh.Rows[flexCongTrinh.Row]["NgayKy"]);
            dtNgayBatDau.Value = Convert.ToDateTime(flexCongTrinh.Rows[flexCongTrinh.Row]["NgayBatDauCT"]);
            dtNgayKetThuc.Value = Convert.ToDateTime(flexCongTrinh.Rows[flexCongTrinh.Row]["NgayKetThucCT"]);
            txtGhiChu.Text = flexCongTrinh.Rows[flexCongTrinh.Row]["GhiChu"].ToString();
            InitDataSetHangMuc(_maCT);
            tabControl_CongTrinh.SelectedIndex = 1;
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

        private bool ValidateData()
        {
            if (txtTenCongTrinh.Text.Equals(string.Empty) || txtMaHieuCT.Text.Equals(string.Empty)
                || txtSoHopDong.Text.Equals(string.Empty) || cboKhachHang1.SelectedIndex == 0
                || cboTinhTrang1.SelectedIndex == 0)
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu đầy đủ", "Thông báo");
                return false;
            }
            return true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                CongTrinh _congtrinh = new CongTrinh();
                _congtrinh.TenCongTrinh = txtTenCongTrinh.Text;
                _congtrinh.MaHieuCT = txtMaHieuCT.Text;
                _congtrinh.SoHopDong = txtSoHopDong.Text;
                _congtrinh.MaKhachHang = Convert.ToInt32(cboKhachHang1.SelectedValue);
                _congtrinh.MaTinhTrang = Convert.ToString(cboTinhTrang1.SelectedValue);
                _congtrinh.NgayKy = dtNgayKy.Value;
                _congtrinh.NgayBatDauCT = dtNgayBatDau.Value;
                _congtrinh.NgayKetThucCT = dtNgayKetThuc.Value;
                _congtrinh.NguoiTao = SessionUser.UserName;
                _congtrinh.GhiChu = txtGhiChu.Text;

                int _idCT = 0;
                BLL_CongTrinh adapterCT = new BLL_CongTrinh();
                if (txtMaCongTrinh.Text != string.Empty)
                {
                    _idCT = Convert.ToInt32(txtMaCongTrinh.Text);
                    _congtrinh.MaCongTrinh = _idCT;
                    adapterCT.Update(_congtrinh);
                }
                else
                {
                    // add công trình
                    _idCT = adapterCT.Add(_congtrinh);
                }
                // add hạng mục
                UpdateHangMuc(_ds.Tables["HangMuc"], _idCT, _congtrinh.MaHieuCT);

                //BindingCongTrinh(string.Empty, Convert.ToInt32(cboKhachHang.SelectedValue), Convert.ToInt32(cboTinhTrang.SelectedValue), dtTuNgay.Value, dtDenNgay.Value);
                //tabControl_CongTrinh.SelectedIndex = 0;
            }
        }

        private void UpdateHangMuc(DataTable _tblHangMuc, int _maCongTrinh, string _maHieuCT)
        {
            if (_tblHangMuc.Rows.Count > 0)
            {
                foreach (DataRow dr in _tblHangMuc.Rows)
                {
                    BLL_HangMuc adapter = new BLL_HangMuc();
                    HangMuc _hangmuc = new HangMuc();

                    _hangmuc.MaCongTrinh = _maCongTrinh;
                    _hangmuc.MaHieuCT = _maHieuCT;
                    _hangmuc.TenHangMuc = dr["TenHangMuc"].ToString();
                    _hangmuc.SoLuong = string.IsNullOrEmpty(dr["SoLuong"].ToString()) ? 0 : Convert.ToInt32(dr["SoLuong"]);
                    _hangmuc.DonGia = string.IsNullOrEmpty(dr["DonGia"].ToString()) ? 0 : Convert.ToDecimal(dr["DonGia"]);
                    _hangmuc.NguoiTao = SessionUser.UserName;

                    int _maHangMuc = 0;
                    string _id = dr["ID"].ToString();
                    if (dr["MaHangMuc"].ToString().Equals(string.Empty))
                    {
                        _maHangMuc = adapter.Add(_hangmuc);
                    }
                    else
                    {
                        _maHangMuc = Convert.ToInt32(dr["MaHangMuc"]);
                        _hangmuc.MaHangMuc = _maHangMuc;
                        adapter.Update(_hangmuc);
                    }
                    //them chi tiet hang muc
                    UpdateChiTietHangMuc(adapter, _ds.Tables["ChiTietHangMuc"], _maHangMuc, _id);
                }
            }
        }

        private void UpdateChiTietHangMuc(BLL_HangMuc adapter, DataTable _tblChiTiet, int _maHangMuc, string _id)
        {
            if (_tblChiTiet.Rows.Count > 0)
            {
                foreach (DataRow dr in _tblChiTiet.Select("ParentID = '" + _id + "'"))
                {
                    ChiTietHangMuc _chitietHM = new ChiTietHangMuc();
                    _chitietHM.MaHangMuc = _maHangMuc;
                    _chitietHM.TenChiTiet = dr["TenChiTiet"].ToString();
                    _chitietHM.QuyCach = dr["QuyCach"].ToString();
                    _chitietHM.ChieuDai = string.IsNullOrEmpty(dr["ChieuDai"].ToString()) ? 0 : Convert.ToInt32(dr["ChieuDai"]);
                    _chitietHM.ChieuRong = string.IsNullOrEmpty(dr["ChieuRong"].ToString()) ? 0 : Convert.ToInt32(dr["ChieuRong"]);
                    _chitietHM.TyTrong = string.IsNullOrEmpty(dr["TyTrong"].ToString()) ? 0 : Convert.ToDecimal(dr["TyTrong"]);
                    _chitietHM.SoLuong = string.IsNullOrEmpty(dr["SoLuong"].ToString()) ? 0 : Convert.ToInt32(dr["SoLuong"]);
                    _chitietHM.TLDonVi = string.IsNullOrEmpty(dr["TLDonVi"].ToString()) ? 0 : Convert.ToDecimal(dr["TLDonVi"]);
                    _chitietHM.DonGia = string.IsNullOrEmpty(dr["DonGia"].ToString()) ? 0 : Convert.ToDecimal(dr["DonGia"]);
                    _chitietHM.GhiChu = dr["GhiChu"].ToString();
                    _chitietHM.NguoiTao = SessionUser.UserName;

                    if (dr["MaChiTietHM"].ToString().Equals(string.Empty))
                    {
                        adapter.ChiTiet_Add(_chitietHM);
                    }
                    else
                    {
                        _chitietHM.MaChiTietHM = Convert.ToInt32(dr["MaChiTietHM"]);
                        adapter.ChiTiet_Update(_chitietHM);
                    }
                }
            }
        }

        private void flexHangMuc_RowValidated(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if (flexHangMuc.Rows.Count > 1)
            {
                if (flexHangMuc.Rows[e.Row]["Status"] != null && flexHangMuc.Rows[e.Row]["Status"].ToString().Equals(string.Empty))
                {
                    flexHangMuc.Rows[e.Row]["ID"] = Guid.NewGuid().ToString();
                    flexHangMuc.Rows[e.Row]["Status"] = "1";
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SearchByCongTrinh(txtKeySearch.Text, dtTuNgay.Value, dtDenNgay.Value, Convert.ToInt32(cboKhachHang.SelectedValue), Convert.ToString(cboTinhTrang.SelectedValue));
        }

        private void _flex_SetupColumns(object sender, EventArgs e)
        {
            // get grid that was just bound
            C1FlexDataTree grid = sender as C1FlexDataTree;
            if (grid == null || grid.DataSource == null)
                return;

            // get source DataTable
            CurrencyManager cm = (CurrencyManager)BindingContext[grid.DataSource, grid.DataMember];
            DataTable dt = ((DataView)cm.List).Table;

            // apply custom column order, captions, format
            string[] columns = dt.ExtendedProperties["ShowColumns"] as string[];
            if (columns != null)
            {
                SetupColumns(grid, columns);
            }

            // apply custom data maps
            foreach (Column gridColumn in grid.Cols)
            {
                DataColumn dataColumn = dt.Columns[gridColumn.Name];
                if (dataColumn == null) continue;
                gridColumn.DataMap = dataColumn.ExtendedProperties["DataMap"] as IDictionary;
                if (gridColumn.DataMap != null)
                {
                    gridColumn.TextAlign = TextAlignEnum.LeftCenter;
                }
            }

            // all done, autosize to show mapped data
            if (grid.AutoResize)
            {
                grid.AutoSizeCols(12);
            }
        }

        void SetupColumns(C1FlexDataTree grid, string[] columns)
        {
            // initialize column position
            int position = grid.Cols.Fixed;

            // apply column information
            foreach (string s in columns)
            {
                // split column info (name, caption, format)
                string[] columnInfo = s.Split(',');

                // move column to proper position based on its name
                Column column = grid.Cols[columnInfo[0].Trim()];
                if (column != null)
                {
                    column.Move(position);
                    position++;

                    // apply caption
                    if (columnInfo.Length > 1)
                        column.Caption = columnInfo[1].Trim();

                    // apply format
                    if (columnInfo.Length > 2)
                        column.Format = columnInfo[2].Trim();
                }
            }

            // hide all other columns
            for (int i = position; i < grid.Cols.Count; i++)
                grid.Cols[i].Visible = false;
        }
    }
}
