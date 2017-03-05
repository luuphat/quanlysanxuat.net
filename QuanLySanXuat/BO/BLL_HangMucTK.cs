using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLySanXuat.Models;

namespace QuanLySanXuat.BO
{
    public class BLL_HangMucTK : HangMucTKDataContext
    {
        public BLL_HangMucTK()
            : base(MyConfig.Connection)
        {

        }

        #region Hạng Mục Thiết Kế
        /// <summary>
        /// phat.luu
        /// april 29,2014
        /// tìm danh sách hạng mục TK theo điều kiện
        /// </summary>
        /// <param name="keySearch"></param>
        /// <returns></returns>
        public List<HangMucTK> GetList(int congTrinhID, string maHieuCT, string keySearch)
        {
            try
            {
                List<HangMucTK> list = HangMucTK_getList(-1, congTrinhID, maHieuCT, keySearch).ToList();
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
        /// tìm hang mục TK theo ID
        /// </summary>
        /// <param name="maKhachHang"></param>
        /// <returns></returns>
        public HangMucTK GetByID(int maHangMucTK)
        {
            try
            {
                List<HangMucTK> list = HangMucTK_getList(maHangMucTK, -1, string.Empty, string.Empty).ToList();
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
        /// thêm hạng mục TK mới
        /// </summary>
        /// <param name="objKH"></param>
        /// <returns></returns>
        public int Add(HangMucTK objHMTK)
        {
            try
            {
                return HangMucTK_add(objHMTK.TenHangMucTK, objHMTK.CongTrinhID, objHMTK.MaHieuCT, objHMTK.NguoiTao);
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
        /// cập nhật thông tin hạng mục TK
        /// </summary>
        /// <param name="objKH"></param>
        /// <returns></returns>
        public int Update(HangMucTK objHMTK)
        {
            try
            {
                return HangMucTK_update(objHMTK.MaHangMucTK, objHMTK.TenHangMucTK, objHMTK.CongTrinhID, objHMTK.MaHieuCT);
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
        /// xóa 1 hạng mục thiết kế
        /// </summary>
        /// <param name="objKH"></param>
        /// <returns></returns>
        public int Delete(HangMucTK objHMTK)
        {
            try
            {
                return HangMucTK_delete(objHMTK.MaHangMucTK);
            }
            catch (Exception e)
            {
                Logger.WriteLog(LogLevel.DEBUG, e.Message);
                return -1;
            }
        }
        #endregion

        #region Chi tiết Hạng mục thiết kế
        /// <summary>
        /// phat.luu
        /// april 29,2014
        /// lấy danh sách chi tiết hạng mục thiết kế
        /// </summary>
        /// <param name="maHangMucTK"></param>
        /// <param name="keySearch"></param>
        /// <returns></returns>
        public List<ChiTietHangMucTK> ChiTiet_GetList(int maHangMucTK, string keySearch)
        {
            try
            {
                List<ChiTietHangMucTK> list = ChiTietHangMucTK_getList(-1, maHangMucTK, keySearch).ToList();
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
        /// phat.luu
        /// april 29,2014
        /// lấy chi tiết hạng mục thiết kế
        /// </summary>
        /// <param name="maHangMucTK"></param>
        /// <param name="keySearch"></param>
        /// <returns></returns>
        public ChiTietHangMucTK ChiTiet_GetByID(int maChiTietHangMucTK)
        {
            try
            {
                List<ChiTietHangMucTK> list = ChiTietHangMucTK_getList(maChiTietHangMucTK, -1, string.Empty).ToList();
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
        /// thêm thông tin chi tiết hạng mục TK
        /// </summary>
        /// <param name="objKH"></param>
        /// <returns></returns>
        public int ChiTiet_Add(ChiTietHangMucTK objctHMTK)
        {
            try
            {
                return ChiTietHangMucTK_add(objctHMTK.MaHangMucTK, objctHMTK.MaKetCauChiTiet,
                    objctHMTK.SoLuong, objctHMTK.TLDonVi, objctHMTK.TLTong, objctHMTK.DonGia, objctHMTK.GiaTri, objctHMTK.GhiChu, objctHMTK.NguoiTao);
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
        /// cập nhật thông tin chi tiết hạng mục TK
        /// </summary>
        /// <param name="objKH"></param>
        /// <returns></returns>
        public int ChiTiet_Update(ChiTietHangMucTK objctHMTK)
        {
            try
            {
                return ChiTietHangMucTK_update(objctHMTK.MaChiTietTK, objctHMTK.MaHangMucTK, objctHMTK.MaKetCauChiTiet, 
                    objctHMTK.SoLuong, objctHMTK.TLDonVi, objctHMTK.TLTong, objctHMTK.DonGia, objctHMTK.GiaTri, objctHMTK.GhiChu);
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
        /// xóa 1 chi tiết hạng mục thiết kế
        /// </summary>
        /// <param name="objKH"></param>
        /// <returns></returns>
        public int ChiTiet_Delete(ChiTietHangMucTK objctHMTK)
        {
            try
            {
                return ChiTietHangMucTK_delete(objctHMTK.MaChiTietTK);
            }
            catch (Exception e)
            {
                Logger.WriteLog(LogLevel.DEBUG, e.Message);
                return -1;
            }
        }
        #endregion
    }
}
