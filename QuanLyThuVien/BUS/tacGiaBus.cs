﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace BUS
{
    public class tacGiaBus
    {
        Data da = new Data();

        public void insert(string tentacgia, string email, string gioitinh, string mota, string matacgia)
        {
            string sql = "Insert into tacgia values(N'" + tentacgia + "', N'" + email + "', N'" + gioitinh + "', N'" + mota + "', N'" + matacgia + "')";
            da.ExecuteNonQuery(sql);
        }

        public void update(string tentacgia, string email, string gioitinh, string mota, string matacgia)
        {
            string sql = "update tacgia set tentacgia = N'" + tentacgia + "', email = N'" + email + "', gioiTinh = N'" + gioitinh + "', mota = N'" + mota + "', matacgia = N'" + matacgia + "'";
            da.ExecuteNonQuery(sql);
        }

        public DataTable hienThi_DG()
        {
            string sql = "select * from tacgia";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public SqlDataReader hienThiTacGia()
        {
            string sql = "select matacgia from tacgia";
            SqlDataReader dr = da.getReader(sql);
            return dr;
        }
    }
}
