using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;

namespace QLSX
{
    public class Utils
    {
        public static DataTable ToDataTable<T>(List<T> list)
        {
            DataTable _table = new DataTable(typeof(T).Name);
            
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                _table.Columns.Add(prop.Name);
            }

            foreach (T item in list)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                _table.Rows.Add(values);
            }
            return _table;
        }
    }
}
