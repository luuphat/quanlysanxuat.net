using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLySanXuat
{
    public class MyConfig
    {
        public static string Connection
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["QLSX.Connection"] != null ? System.Configuration.ConfigurationManager.AppSettings["QLSX.Connection"] : ""; 
                //return System.Configuration.ConfigurationManager.ConnectionStrings["QuanLySanXuat.Properties.Settings.QLSXConnectionString"].ConnectionString;
            }
        }
    }
}
