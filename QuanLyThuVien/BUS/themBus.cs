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
    public class themBus
    {
        Data da = new Data();

        public void insert(string masach, string tensach, string theloai, string tacgia, string namxuatban, string filename, string nhaxuatban, int trangthai, string mota)
        {
            string sql = "Insert into sach values(N'" + masach + "', N'" + tensach + "', N'" + tacgia + "', N'" + theloai + "', N'" + nhaxuatban + "', N'" + namxuatban + "', N'" + filename + "', " + trangthai + ", N'" + mota + "')";
            da.ExecuteNonQuery(sql);
        }

        public void update(string tensach, string masach, string theloai, string tacgia, string namxuatban, string filename, string nhaxuatban, int trangthai, string mota)
        {
            string sql = "Update sach set tensach = N'" + tensach + "', matacgia = N'" + tacgia + "', matheloai = N'" + theloai + "', manhaxuatban = N'" + nhaxuatban + "', namxuatban = N'" + namxuatban + "', hinhanh = N'" + filename + "', trangthai = " + trangthai + ", mota = N'" + mota + "' where masach = N'" + masach + "'";
            da.ExecuteNonQuery(sql);
        }

        public DataTable hienThi_DG()
        {
            string sql = "Select * from sach";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }

        public void del_sach(string masach)
        {
            string sql = "delete from sach where masach = N'" + masach + "'";
            da.ExecuteNonQuery(sql);
        }
    }
}
