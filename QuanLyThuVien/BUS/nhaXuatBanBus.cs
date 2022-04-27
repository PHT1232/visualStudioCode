using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BUS
{
    public class nhaXuatBanBus
    {
        Data da = new Data();

        public void insert(string manhaxuatban, string tennhaxuatban, string diachi, string email, string nguoidaidien)
        {
            string sql = "Insert into nhaxuatban values(N'" + manhaxuatban + "', N'" + tennhaxuatban + "', N'" + diachi + "', N'" + email + "', N'" + nguoidaidien + "')";
            da.ExecuteNonQuery(sql);
        }

        public void update(string tennhaxuatban, string diachi, string email, string nguoidaidien, string manhaxuatban)
        {
            string sql = "Update nhaxuatban set tennhaxuatban = N'" + tennhaxuatban + "', diachi = N'" + diachi + "', email = N'" + email + "', nguoidaidien = N'" + nguoidaidien + " where manhaxuatban = N'" + manhaxuatban + "'";
            da.ExecuteNonQuery(sql);
        }

        public void delete(string manhaxuatban)
        {
            string sql = "delete from nhaxuatban where manhaxuatban = N'" + manhaxuatban + "'";
            da.ExecuteNonQuery(sql);
        }

        public DataTable HienThi_DG()
        {
            String sql = "Select * from nhaxuatban";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }

        public SqlDataReader hienThiNhaXuatBan()
        {
            string sql = "Select manhaxuatban from nhaxuatban";
            SqlDataReader dr = da.getReader(sql);
            return dr;
        }
    }
}
