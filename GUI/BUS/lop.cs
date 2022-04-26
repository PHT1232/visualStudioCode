using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using System.Data.SqlClient;

namespace BUS
{
    public class lop
    {
        Data da = new Data();
        
        public void insert(string malop, string tenlop, string makhoa)
        {
            string sql = "insert into lopHoc values(N'" + malop + "', N'" + tenlop + "', N'" + makhoa + "')";
            da.ExecuteNonQuery(sql);
        }

        public void update(string malop, string tenlop, string makhoa)
        {
            string sql = "update lopHoc set tenLop = N'" + tenlop + "', maKhoa = N'" + makhoa + "' where malop = N'" + malop + "'";
            da.ExecuteNonQuery(sql);
        }

        public DataTable HienThi_DG()
        {
            string sql = "select * from lopHoc";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }

        public void delete(string malop)
        {
            string sql = "delete from lopHoc where maLop = N'" + malop + "'";
            da.ExecuteNonQuery(sql);
        }

        public DataTable search_khoa(string makhoa)
        {
            string sql_search = "select * from lopHoc where makhoa=N'" + makhoa + "'";
            DataTable dt = new DataTable();
            dt = da.getTable(sql_search);
            return dt;
        }

        public SqlDataReader hienThiLop()
        {
            string sql = "select maLop from lopHoc";
            SqlDataReader dr = da.getReader(sql);
            return dr;
        }
    }
}
