using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class dangNhap
    {
        Data da = new Data();
        
        public bool select(string username, string matkhau)
        {
            DataTable dt = new DataTable();
            string sql = "Select * from account where username = N'" + username + "' And password = N'" + matkhau + "'";
            dt = da.getTable(sql);
            if(dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
