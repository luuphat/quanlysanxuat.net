using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLySanXuat.Models;

namespace QuanLySanXuat.BO
{
    public class BLL_KetCau : KetCauDataContext
    {
        public BLL_KetCau()
            : base(MyConfig.Connection)
        {

        }

        #region Nhóm Kết Cấu
        /// <summary>
        /// phat.luu
        /// april 28,2014
        /// tìm danh sách nhóm kết cấu theo điều kiện
        /// </summary>
        /// <param name="keySearch"></param>
        /// <returns></returns>
        public List<NhomKetCau> NhomKetCau_GetList(string keySearch)
        {
            try
            {
                List<NhomKetCau> list = NhomKetCau_getList(-1, keySearch).ToList();
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
        /// april 28,2014
        /// tìm nhóm kết cấu theo ID
        /// </summary>
        /// <param name="maNhomKetCau"></param>
        /// <returns></returns>
        public NhomKetCau NhomKetCau_GetByID(int maNhomKetCau)
        {
            try
            {
                List<NhomKetCau> list = NhomKetCau_getList(maNhomKetCau, string.Empty).ToList();
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
        /// april 28, 2014
        /// thêm nhóm kết cấu mới
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int NhomKetCau_Add(NhomKetCau obj)
        {
            try
            {
                return NhomKetCau_add(obj.TenNhomKetCau, obj.SapXep, obj.NguoiTao);
            }
            catch (Exception e)
            {
                Logger.WriteLog(LogLevel.DEBUG, e.Message);
                return -1;
            }
        }

        /// <summary>
        /// phat.luu
        /// april 28, 2014
        /// cập nhật thông tin nhóm kết cấu
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int NhomKetCau_Update(NhomKetCau obj)
        {
            try
            {
                return NhomKetCau_update(obj.MaNhomKetCau, obj.TenNhomKetCau, obj.SapXep);
            }
            catch (Exception e)
            {
                Logger.WriteLog(LogLevel.DEBUG, e.Message);
                return -1;
            }
        }

        /// <summary>
        /// phat.luu
        /// april 28,2014
        /// xóa 1 nhóm kết cấu
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int NhomKetCau_Delete(NhomKetCau obj)
        {
            try
            {
                return NhomKetCau_delete(obj.MaNhomKetCau);
            }
            catch (Exception e)
            {
                Logger.WriteLog(LogLevel.DEBUG, e.Message);
                return -1;
            }
        }
        #endregion

        #region Kết Cấu
        /// <summary>
        /// phat.luu
        /// april 29,2014
        /// tìm danh sách kết cấu theo điều kiện
        /// </summary>
        /// <param name="keySearch"></param>
        /// <returns></returns>
        public List<KetCau> GetList(int maNhomKetCau, string keySearch)
        {
            try
            {
                List<KetCau> lstKC = KetCau_getList(-1, maNhomKetCau, keySearch).ToList();
                if (lstKC.Count <= 0)
                    return null;
                return lstKC;
            }
            catch (Exception e)
            {
                Logger.WriteLog(LogLevel.DEBUG, e.Message);
                return null;
            }
        }

        /// <summary>
        /// phat.lu
        /// april 28,2014
        /// tìm kết cấu theo ID
        /// </summary>
        /// <param name="maKetCau"></param>
        /// <returns></returns>
        public KetCau GetByID(int maKetCau)
        {
            try
            {
                List<KetCau> lstKC = KetCau_getList(maKetCau, -1, string.Empty).ToList();
                if (lstKC.Count <= 0)
                    return null;
                return lstKC[0];
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
        /// thêm kết cấu mới
        /// </summary>
        /// <param name="objKH"></param>
        /// <returns></returns>
        public int Add(KetCau objKC)
        {
            try
            {
                return KetCau_add(objKC.TenKetCau, objKC.MaNhomKetCau, objKC.MoTa, objKC.HinhAnh, objKC.NguoiTao);
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
        /// cập nhật thông tin kết cấu
        /// </summary>
        /// <param name="objKH"></param>
        /// <returns></returns>
        public int Update(KetCau objKC)
        {
            try
            {
                return KetCau_update(objKC.MaKetCau, objKC.TenKetCau, objKC.MaNhomKetCau, objKC.MoTa, objKC.HinhAnh);
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
        /// xóa 1 kết cấu
        /// </summary>
        /// <param name="objKH"></param>
        /// <returns></returns>
        public int Delete(KetCau objKC)
        {
            try
            {
                return KetCau_delete(objKC.MaKetCau);
            }
            catch (Exception e)
            {
                Logger.WriteLog(LogLevel.DEBUG, e.Message);
                return -1;
            }
        }
        #endregion

        #region Chi Tiết Kết Cấu
        /// <summary>
        /// phat.luu
        /// april 28,2014
        /// tìm danh sách chi tiết kết cấu theo điều kiện
        /// </summary>
        /// <param name="keySearch"></param>
        /// <returns></returns>
        public List<ChiTietKetCau> ChiTiet_GetList(int maKetCau, string keySearch)
        {
            try
            {
                List<ChiTietKetCau> list = ChiTietKetCau_getList(-1, maKetCau, keySearch).ToList();
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
        /// april 28,2014
        /// lấy danh sách chi tiết kết cấu theo kết cấu id
        /// </summary>
        /// <param name="maKetCau"></param>
        /// <returns></returns>
        public List<ChiTietKetCau> ChiTiet_GetListByKetCauID(int maKetCau)
        {
            try
            {
                List<ChiTietKetCau> list = ChiTietKetCau_getList(-1, maKetCau, string.Empty).ToList();
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
        /// tìm chi tiết kết cấu theo ID
        /// </summary>
        /// <param name="maKhachHang"></param>
        /// <returns></returns>
        public ChiTietKetCau ChiTiet_GetByID(int maChiTietKetCau)
        {
            try
            {
                List<ChiTietKetCau> list = ChiTietKetCau_getList(maChiTietKetCau, -1, string.Empty).ToList();
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
        /// thêm chi tiết kết cấu mới
        /// </summary>
        /// <param name="objKH"></param>
        /// <returns></returns>
        public int ChiTiet_Add(ChiTietKetCau objKC)
        {
            try
            {
                return ChiTietKetCau_add(objKC.MaKetCau, objKC.TenChiTietKetCau, objKC.QuyCach, objKC.ChieuDai, objKC.ChieuRong, objKC.TyTrong, objKC.Gia, objKC.NguoiTao);
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
        /// cập nhật thông tin chi tiết kết cấu
        /// </summary>
        /// <param name="objKH"></param>
        /// <returns></returns>
        public int ChiTiet_Update(ChiTietKetCau objKC)
        {
            try
            {
                return ChiTietKetCau_update(objKC.MaChiTietKetCau, objKC.MaKetCau, objKC.TenChiTietKetCau, objKC.QuyCach, objKC.ChieuDai, objKC.ChieuRong, objKC.TyTrong, objKC.Gia);
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
        /// xóa 1 chi tiết kết cấu
        /// </summary>
        /// <param name="objKH"></param>
        /// <returns></returns>
        public int ChiTiet_Delete(ChiTietKetCau objKC)
        {
            try
            {
                return ChiTietKetCau_delete(objKC.MaChiTietKetCau);
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
