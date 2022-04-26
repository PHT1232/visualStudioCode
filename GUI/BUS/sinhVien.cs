using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
    public class sinhVien
    {
        Data da = new Data();

        public void insert(string masv, string tensv, string gioiTinh, string ngaySinh, string email, string sdt, string diaChi, string maLop)
        {
            string sql = "Insert into sinhVien values(N'" + masv + "'" + ", N'" + tensv + "', N'" + gioiTinh + "', N'" + ngaySinh + "', N'" + email + "', N'" + sdt + "', N'" + diaChi + "', N'" + maLop + "')";
            da.ExecuteNonQuery(sql);
        }

        public void update(string masv, string tensv, string gioiTinh, string ngaySinh, string email, string sdt, string diaChi, string maLop)
        {
            string sql = "Update sinhVien set tensv = N'" + tensv + "', gioiTinh = N'" + gioiTinh + "', ngaySinh = N'" + ngaySinh + "', email = N'" + email + "', sdt = N'" + sdt + "', malop = N'" + maLop + "' where masv = N'" + masv + "'";
            da.ExecuteNonQuery(sql);
        }

        public void delete(string masv)
        {
            string sql = "delete from sinhVien where masv = N'" + masv + "'";
            da.ExecuteNonQuery(sql);
        }

        public DataTable HienThi_DG()
        {
            string sql = "select * from sinhVien";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
    }
}
