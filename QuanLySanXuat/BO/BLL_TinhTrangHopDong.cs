using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLySanXuat.Models;

namespace QuanLySanXuat.BO
{
    public class BLL_TinhTrangHopDong : TinhTrangHopDongDataContext
    {
        public BLL_TinhTrangHopDong()
            : base(MyConfig.Connection)
        {
        }

        /// <summary>
        /// phat.luu
        /// april 28,2014
        /// danh sách tình trạng công trình
        /// </summary>
        /// <param name="keySearch"></param>
        /// <returns></returns>
        public List<TinhTrangHopDong> GetList(string keySearch)
        {
            try
            {
                List<TinhTrangHopDong> list = TinhTrangHopDong_getList(keySearch).ToList();
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
    }
}
