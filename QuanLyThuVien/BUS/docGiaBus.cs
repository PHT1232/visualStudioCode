using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BUS
{
    public class docGiaBus
    {
        Data da = new Data();
        
        public void insert(string madocgia, string tendocgia, string diachi, int trangthai)
        {
            string sql = "Insert into docgia values (N'" + madocgia + "', N'" + tendocgia + "', N'" + diachi + "', " + trangthai + ")";
            da.ExecuteNonQuery(sql);
        }

        public void update(string madocgia, string tendocgia, string diachi, int trangthai)
        {
            string sql = "Update docgia set tendocgia = N'" + tendocgia + "', diachi = N'" + diachi + "', trangthai = " + trangthai + " where madocgia = N'" + madocgia + "'";
            da.ExecuteNonQuery(sql);
        }

        public DataTable HienThi_DG()
        {
            string sql = "select * from docgia";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }

        public SqlDataReader hienThiDocGia()
        {
            string sql = "select madocgia from docgia";
            SqlDataReader dr = da.getReader(sql);
            return dr;
        }
    }
}
