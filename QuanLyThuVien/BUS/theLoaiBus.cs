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
    public class theLoaiBus
    {
        Data da = new Data();

        public void insert(string tenTheLoai, string mota, string matheloai)
        {
            string sql = "Insert into theloai values(N'" + matheloai + "', N'" + tenTheLoai + "', N'" + mota + "')";
            da.ExecuteNonQuery(sql);
        }

        public void update(string tenTheLoai, string mota, string matheloai)
        {
            string sql = "Update theloai set tentheloai = N'" + tenTheLoai + "', mota = N'" + mota + "' where matheloai = N'" + matheloai + "'";
            da.ExecuteNonQuery(sql);
        }

        public void delete(string matheloai)
        {
            string sql = "delete from theloai where matheloai = N'" + matheloai +"'";
            da.ExecuteNonQuery(sql);
        }

        public DataTable HienThi_DG()
        {
            string sql = "select * from theloai";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }

        public SqlDataReader hienthitheloai()
        {
            string sql = "select matheloai from theloai";
            SqlDataReader dr = da.getReader(sql);
            return dr;
        }
    }
}
