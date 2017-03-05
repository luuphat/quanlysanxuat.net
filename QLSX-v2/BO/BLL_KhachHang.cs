using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLSX.Models;

namespace QLSX.BO
{
    public class BLL_KhachHang : QLSXDataContext
    {
        public BLL_KhachHang() : base(MyConfig.Connection)
        {

        }

        /// <summary>
        /// phat.luu
        /// april 29,2014
        /// tìm danh sách khách hàng theo điều kiện
        /// </summary>
        /// <param name="keySearch"></param>
        /// <returns></returns>
        public List<KhachHang> GetList(string keySearch)
        {
            try
            {
                List<KhachHang> list = KhachHang_getList(-1, keySearch).ToList();
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
        /// tìm khách hàng theo ID
        /// </summary>
        /// <param name="maKhachHang"></param>
        /// <returns></returns>
        public KhachHang GetByID(int maKhachHang)
        {
            try
            {
                List<KhachHang> list = KhachHang_getList(maKhachHang, string.Empty).ToList();
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
        /// thêm khách hàng mới
        /// </summary>
        /// <param name="objKH"></param>
        /// <returns></returns>
        public int Add(KhachHang objKH)
        {
            try
            {
                return KhachHang_add(objKH.TenKhachHang, objKH.DiaChi, objKH.DienThoai, objKH.Fax, objKH.Email, objKH.Website, objKH.NguoiTao);
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
        /// cập nhật thông tin khách hàng
        /// </summary>
        /// <param name="objKH"></param>
        /// <returns></returns>
        public int Update(KhachHang objKH)
        {
            try
            {
                return KhachHang_update(objKH.MaKhachHang, objKH.TenKhachHang, objKH.DiaChi, objKH.DienThoai, objKH.Fax, objKH.Email, objKH.Website);
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
        /// xóa 1 khách hàng
        /// </summary>
        /// <param name="objKH"></param>
        /// <returns></returns>
        public int Delete(KhachHang objKH)
        {
            try
            {
                return KhachHang_delete(objKH.MaKhachHang);
            }
            catch (Exception e)
            {
                Logger.WriteLog(LogLevel.DEBUG, e.Message);
                return -1;
            }
        }
    }
}
