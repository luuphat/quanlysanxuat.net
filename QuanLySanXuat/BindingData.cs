using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLySanXuat.BO;
using QuanLySanXuat.Models;

namespace QuanLySanXuat
{
    public class BindingData
    {
        public static void BindingKetCau(System.Windows.Forms.TreeView treeViewKetCau)
        {
            treeViewKetCau.Nodes.Clear();
            BLL_KetCau obj = new BLL_KetCau();
            List<NhomKetCau> dsNhom = obj.NhomKetCau_GetList(string.Empty);
            if (dsNhom != null)
            {
                var listNhom = (from nhom in dsNhom
                                orderby nhom.SapXep
                                select nhom);

                foreach (NhomKetCau n in listNhom)
                {
                    System.Windows.Forms.TreeNode root = treeViewKetCau.Nodes.Add(n.MaNhomKetCau.ToString(), n.TenNhomKetCau);

                    List<KetCau> dsKetCau = obj.GetList(n.MaNhomKetCau, string.Empty);
                    if (dsKetCau != null)
                    {
                        foreach (KetCau kc in dsKetCau)
                        {
                            root.Nodes.Add(kc.MaKetCau.ToString(), kc.TenKetCau);
                        }
                    }
                }

                treeViewKetCau.ExpandAll();
            }
        }

        public static void BindingNhomKetCau(System.Windows.Forms.ComboBox cboNhomKetCau)
        {
            cboNhomKetCau.Items.Clear();
            BLL_KetCau obj = new BLL_KetCau();
            List<NhomKetCau> list = obj.NhomKetCau_GetList(string.Empty);

            if (list != null)
            {
                NhomKetCau item = new NhomKetCau();
                item.MaNhomKetCau = -1;
                item.TenNhomKetCau = "Nhóm kết cấu - chọn nhóm";
                list.Insert(0, item);
                cboNhomKetCau.DataSource = list;
                cboNhomKetCau.ValueMember = "MaNhomKetCau";
                cboNhomKetCau.DisplayMember = "TenNhomKetCau";
            }
        }

        public static void BindingKetCau(System.Windows.Forms.ComboBox cboKetCau, int maNhomKetCau)
        {
            cboKetCau.Items.Clear();
            BLL_KetCau obj = new BLL_KetCau();
            List<KetCau> list = obj.GetList(maNhomKetCau, string.Empty);

            if (list != null)
            {
                KetCau item = new KetCau();
                item.MaKetCau = -1;
                item.TenKetCau = "Kết cấu - chọn -";
                list.Insert(0, item);
                cboKetCau.DataSource = list;
                cboKetCau.ValueMember = "MaKetCau";
                cboKetCau.DisplayMember = "TenKetCau";
            }
        }

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
                item.TinhTrangID = -1;
                item.TenTinhTrang = "Tình trạng - chọn -";
                list.Insert(0, item);
                _combobox.DataSource = list;
                _combobox.ValueMember = "TinhTrangID";
                _combobox.DisplayMember = "TenTinhTrang";
            }
        }
    }
}
