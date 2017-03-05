using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLSX.Models;

namespace QLSX.BO
{
    public class BLL_HangMuc : QLSXDataContext
    {
        public BLL_HangMuc()
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
        public List<HangMuc> GetList(int maCongTrinh, string maHieuCT, string keySearch)
        {
            try
            {
                List<HangMuc> list = HangMuc_getList(-1, maCongTrinh, maHieuCT, keySearch).ToList();
                if (list.Count < 0 || list == null)
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
        public HangMuc GetByID(int maHangMuc)
        {
            try
            {
                List<HangMuc> list = HangMuc_getList(maHangMuc, -1, string.Empty, string.Empty).ToList();
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
        public int Add(HangMuc objHM)
        {
            try
            {
                int? maHangMuc = 0;
                HangMuc_add(objHM.TenHangMuc, objHM.MaCongTrinh, objHM.MaHieuCT, objHM.SoLuong, objHM.DonGia, objHM.NguoiTao, ref maHangMuc);
                return (int)maHangMuc;
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
        public int Update(HangMuc objHM)
        {
            try
            {
                return HangMuc_update(objHM.MaHangMuc, objHM.TenHangMuc, objHM.MaCongTrinh, objHM.MaHieuCT, objHM.SoLuong, objHM.DonGia);
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
        public int Delete(HangMuc objHM)
        {
            try
            {
                return HangMuc_delete(objHM.MaHangMuc);
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
        public List<ChiTietHangMuc> ChiTiet_GetList(int maHangMuc, string keySearch)
        {
            try
            {
                List<ChiTietHangMuc> list = ChiTietHangMuc_getList(-1, maHangMuc, keySearch).ToList();
                if (list.Count < 0 || list == null)
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
        public ChiTietHangMuc ChiTiet_GetByID(int maChiTietHangMuc)
        {
            try
            {
                List<ChiTietHangMuc> list = ChiTietHangMuc_getList(maChiTietHangMuc, -1, string.Empty).ToList();
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
        public int ChiTiet_Add(ChiTietHangMuc objctHM)
        {
            try
            {
                return ChiTietHangMuc_add(objctHM.MaHangMuc, objctHM.TenChiTiet, objctHM.QuyCach, objctHM.ChieuDai,objctHM.ChieuRong,objctHM.TyTrong,
                    objctHM.SoLuong, objctHM.TLDonVi, objctHM.DonGia, objctHM.GhiChu, objctHM.NguoiTao);
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
        public int ChiTiet_Update(ChiTietHangMuc objctHM)
        {
            try
            {
                return ChiTietHangMuc_update(objctHM.MaChiTietHM, objctHM.MaHangMuc, objctHM.TenChiTiet, objctHM.QuyCach, objctHM.ChieuDai, objctHM.ChieuRong, objctHM.TyTrong,
                    objctHM.SoLuong, objctHM.TLDonVi, objctHM.DonGia, objctHM.GhiChu);
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
        public int ChiTiet_Delete(ChiTietHangMuc objctHM)
        {
            try
            {
                return ChiTietHangMuc_delete(objctHM.MaChiTietHM);
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
