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
            return new SqlConnection(@"Data Source=NGUYENTANPHAT\SQLEXPRESS;Initial Catalog=ThuVien;Integrated Security=True");
        }

        public void ExecuteNonQuery(String sql)
        {
            SqlConnection conn = getKetNoi();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn); 
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public DataTable getTable(string sql)
        {
            SqlConnection conn = getKetNoi();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public SqlDataReader getReader(string sql)
        {
            SqlConnection conn = getKetNoi();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
