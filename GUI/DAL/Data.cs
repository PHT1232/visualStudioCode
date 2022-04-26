using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Data
    {
        public SqlConnection getKetNoi()
        {
            return new SqlConnection(@"Data Source=NGUYENTANPHAT\SQLEXPRESS;Initial Catalog=DH9C5;Integrated Security=True");
        }

        public void ExecuteNonQuery(String sql)
        {
            SqlConnection conn = getKetNoi();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public DataTable getTable(String sql)
        {
            SqlConnection conn = getKetNoi();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public SqlDataReader getReader(String sql)
        {
            SqlConnection conn = getKetNoi();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr; //khai báo đối tượng
            dr = cmd.ExecuteReader(); //Đổ dữ liệu vào Datareader
            return dr;
        }
    }
}
