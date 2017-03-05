using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLySanXuat.Models;

namespace QuanLySanXuat.BO
{
    public class BLL_HangMucTT : HangMucTTDataContext
    {
        public BLL_HangMucTT()
            : base(MyConfig.Connection)
        {

        }

        #region Hạng mục thực tế
        /// <summary>
        /// phat.luu
        /// april 29,2014
        /// tìm danh sách hạng mục TT theo điều kiện
        /// </summary>
        /// <param name="keySearch"></param>
        /// <returns></returns>
        public List<HangMucTT> GetList(int congTrinhID, string maHieuCT, string keySearch)
        {
            try
            {
                List<HangMucTT> list = HangMucTT_getList(-1, congTrinhID, maHieuCT, keySearch).ToList();
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
        public HangMucTT GetByID(int maHangMucTT)
        {
            try
            {
                List<HangMucTT> list = HangMucTT_getList(maHangMucTT, -1, string.Empty, string.Empty).ToList();
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
        /// thêm hạng mục TT mới
        /// </summary>
        /// <param name="objKH"></param>
        /// <returns></returns>
        public int Add(HangMucTT objctHMTT)
        {
            try
            {
                return HangMucTT_add(objctHMTT.TenHangMucTT, objctHMTT.CongTrinhID, objctHMTT.MaHieuCT, objctHMTT.NguoiTao);
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
        public int Update(HangMucTT objctHMTT)
        {
            try
            {
                return HangMucTT_update(objctHMTT.MaHangMucTT, objctHMTT.TenHangMucTT, objctHMTT.CongTrinhID, objctHMTT.MaHieuCT);
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
        /// xóa 1 hạng mục thực tế
        /// </summary>
        /// <param name="objKH"></param>
        /// <returns></returns>
        public int Delete(HangMucTT objctHMTT)
        {
            try
            {
                return HangMucTT_delete(objctHMTT.MaHangMucTT);
            }
            catch (Exception e)
            {
                Logger.WriteLog(LogLevel.DEBUG, e.Message);
                return -1;
            }
        }

        #endregion

        #region Chi tiết Hạng mục thực tế
        /// <summary>
        /// phat.luu
        /// april 29,2014
        /// lấy danh sách chi tiết hạng mục TT
        /// </summary>
        /// <param name="maHangMucTT"></param>
        /// <param name="keySearch"></param>
        /// <returns></returns>
        public List<ChiTietHangMucTT> ChiTiet_GetList(int maHangMucTT, string keySearch)
        {
            try
            {
                List<ChiTietHangMucTT> lstctHMTT = ChiTietHangMucTT_getList(-1, maHangMucTT, keySearch).ToList();
                if (lstctHMTT.Count <= 0)
                    return null;
                return lstctHMTT;
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
        /// <param name="maHangMucTT"></param>
        /// <param name="keySearch"></param>
        /// <returns></returns>
        public ChiTietHangMucTT ChiTiet_GetByID(int maChiTietHangMucTT)
        {
            try
            {
                List<ChiTietHangMucTT> lstctHMTT = ChiTietHangMucTT_getList(maChiTietHangMucTT, -1, string.Empty).ToList();
                if (lstctHMTT.Count <= 0)
                    return null;
                return lstctHMTT[0];
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
        /// thêm thông tin chi tiết hạng mục TT
        /// </summary>
        /// <param name="objKH"></param>
        /// <returns></returns>
        public int ChiTiet_Add(ChiTietHangMucTT objctHMTT)
        {
            try
            {
                return ChiTietHangMucTT_add(objctHMTT.MaHangMucTT, objctHMTT.MaKetCauChiTiet, objctHMTT.SoLuong, objctHMTT.TLDonVi,
                    objctHMTT.TLTong, objctHMTT.DonGia, objctHMTT.GiaTri, objctHMTT.GhiChu, objctHMTT.NguoiTao, objctHMTT.TLMaKem, objctHMTT.QuyetToanKH);
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
        /// cập nhật thông tin chi tiết hạng mục TT
        /// </summary>
        /// <param name="objKH"></param>
        /// <returns></returns>
        public int ChiTiet_Update(ChiTietHangMucTT objctHMTT)
        {
            try
            {
                return ChiTietHangMucTT_update(objctHMTT.MaChiTietTT, objctHMTT.MaHangMucTT, objctHMTT.MaKetCauChiTiet,
                    objctHMTT.SoLuong, objctHMTT.TLDonVi, objctHMTT.TLTong, objctHMTT.DonGia, objctHMTT.GiaTri, objctHMTT.GhiChu, objctHMTT.TLMaKem, objctHMTT.QuyetToanKH);
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
        /// xóa 1 chi tiết hạng mục TT
        /// </summary>
        /// <param name="objKH"></param>
        /// <returns></returns>
        public int ChiTiet_Delete(ChiTietHangMucTT objctHMTT)
        {
            try
            {
                return ChiTietHangMucTT_delete(objctHMTT.MaChiTietTT);
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
