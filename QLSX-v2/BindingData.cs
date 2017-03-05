using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLSX.BO;
using QLSX.Models;

namespace QLSX
{
    public class BindingData
    {
        public static void BindingKhachHang(System.Windows.Forms.ComboBox cboKhachHang)
        {
            cboKhachHang.Items.Clear();
            BLL_KhachHang adapter = new BLL_KhachHang();
            List<KhachHang> list = adapter.GetList(string.Empty);

            if (list != null)
            {
                KhachHang item = new KhachHang();
                item.MaKhachHang = -1;
                item.TenKhachHang = "Khách hàng - chọn -";
                list.Insert(0, item);
                cboKhachHang.DataSource = list;
                cboKhachHang.ValueMember = "MaKhachHang";
                cboKhachHang.DisplayMember = "TenKhachHang";
            }
        }

        public static void BindingTTHopDong(System.Windows.Forms.ComboBox _combobox)
        {
            _combobox.Items.Clear();
            BLL_TinhTrangHopDong adapter = new BLL_TinhTrangHopDong();
            List<TinhTrangHopDong> list = adapter.GetList(string.Empty);

            if (list != null)
            {
                TinhTrangHopDong item = new TinhTrangHopDong();
                item.MaTinhTrang = "-1";
                item.TenTinhTrang = "Tình trạng - chọn -";
                list.Insert(0, item);
                _combobox.DataSource = list;
                _combobox.ValueMember = "MaTinhTrang";
                _combobox.DisplayMember = "TenTinhTrang";
            }
        }
    }
}
