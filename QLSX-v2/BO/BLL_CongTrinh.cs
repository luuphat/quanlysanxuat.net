using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLSX.Models;

namespace QLSX.BO
{
    public class BLL_CongTrinh : QLSXDataContext
    {
        public BLL_CongTrinh()
            : base(MyConfig.Connection)
        {

        }

        /// <summary>
        /// phat.luu
        /// april 28,2014
        /// tìm danh sách công trình theo điều kiện
        /// </summary>
        /// <param name="keySearch"></param>
        /// <returns></returns>
        public List<CongTrinh> GetList(int maKhachHang, string maTinhTrang, DateTime tuNgay, DateTime denNgay, string searchKey)
        {
            try
            {
                List<CongTrinh> list = CongTrinh_getList(-1, maKhachHang, maTinhTrang, tuNgay, denNgay, searchKey).ToList();
                if (list.Count <= 0)
                    return null;
                return list;
            }
            catch (Exception e)
            {
                Logger.WriteLog(LogLevel.DEBUG, e.Message);
                return null;
            }
        }

        /// <summary>
        /// phat.lu
        /// april 29,2014
        /// tìm công trình theo ID
        /// </summary>
        /// <param name="maKhachHang"></param>
        /// <returns></returns>
        public CongTrinh GetByID(int maCongTrinh)
        {
            try
            {
                List<CongTrinh> list = CongTrinh_getList(maCongTrinh, -1, "-1", null, null, string.Empty).ToList();
                if (list.Count <= 0)
                    return null;
                return list[0];
            }
            catch (Exception e)
            {
                Logger.WriteLog(LogLevel.DEBUG, e.Message);
                return null;
            }
        }

        /// <summary>
        /// phat.luu
        /// april 27, 2014
        /// thêm công trình mới
        /// </summary>
        /// <param name="objKH"></param>
        /// <returns></returns>
        public int Add(CongTrinh objCT)
        {
            try
            {
                int? _maCongTrinh = 0;
                CongTrinh_add(objCT.TenCongTrinh, objCT.MaHieuCT, objCT.SoHopDong, objCT.MaKhachHang, objCT.NgayKy, 
                    objCT.NgayBatDauCT, objCT.NgayKetThucCT, objCT.MaTinhTrang, objCT.GiaTriHD, objCT.GhiChu,
                    objCT.NguoiTao, ref _maCongTrinh);
                return (int)_maCongTrinh;
            }
            catch (Exception e)
            {
                Logger.WriteLog(LogLevel.DEBUG, e.Message);
                return -1;
            }
        }

        /// <summary>
        /// phat.luu
        /// april 27, 2014
        /// cập nhật thông tin công trình
        /// </summary>
        /// <param name="objKH"></param>
        /// <returns></returns>
        public int Update(CongTrinh objCT)
        {
            try
            {
                return CongTrinh_update(objCT.MaCongTrinh, objCT.TenCongTrinh, objCT.MaHieuCT, objCT.SoHopDong, objCT.MaKhachHang, objCT.NgayKy, objCT.NgayBatDauCT, objCT.NgayKetThucCT, objCT.MaTinhTrang, objCT.GiaTriHD, objCT.GhiChu, objCT.TrongLuongTK, objCT.TrongLuongTT, objCT.HoanCong, objCT.QuyetToanKH);
            }
            catch (Exception e)
            {
                Logger.WriteLog(LogLevel.DEBUG, e.Message);
                return -1;
            }
        }

        /// <summary>
        /// phat.luu
        /// april 29,2014
        /// xóa 1 công trình
        /// </summary>
        /// <param name="objKH"></param>
        /// <returns></returns>
        public int Delete(CongTrinh objCT)
        {
            try
            {
                return CongTrinh_delete(objCT.MaCongTrinh);
            }
            catch (Exception e)
            {
                Logger.WriteLog(LogLevel.DEBUG, e.Message);
                return -1;
            }
        }
    }
}
