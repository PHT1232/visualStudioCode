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
    public class Khoa
    {
        Data da = new Data();
        public void Insert(string maKhoa, string tenKhoa, string diaChi, string email, string sdt)
        {
            string sql = "Insert into t_khoa values(N'" + maKhoa + "', N'" + tenKhoa + "', N'" + diaChi + "', '" + email + "', N'" + sdt + "')";
            da.ExecuteNonQuery(sql);
        }

        public void UpdateKhoa(string tenKhoa, string diaChi, string email, string sdt, string ma)
        {
            string sql_edit = "Update t_khoa set tenkhoa = N'" + tenKhoa + "', diachi = N'" + diaChi + "', email = N'" + email + "', sdt = N'" + sdt + "' where maKhoa = N'" + ma + "'";
            da.ExecuteNonQuery(sql_edit);
        }

        public DataTable HienThi_DG()
        {
            string sql = "select * from t_khoa";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }

        public void del_khoa(string makhoa)
        {
            string sql_del = "delete from t_khoa where makhoa=N'" + makhoa + "'";
            da.ExecuteNonQuery(sql_del);
        }

        public SqlDataReader hienThiKhoa()
        {
            string sql = "select maKhoa from t_khoa";
            SqlDataReader dr = da.getReader(sql);
            return dr;
        } 
    }
}
