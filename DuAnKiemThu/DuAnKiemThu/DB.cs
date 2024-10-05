using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DuAnKiemThu
{
    internal class DB
    {
        SqlConnection conn;
        public DB() {}
        public void ketnoiSQL()
        {
            string chuoikn = "Data Source=DESKTOP-0QUCCCD\\SQLEXPRESS;Initial Catalog=QuanLyDiemTHPT;Integrated Security=True;Encrypt=False";
            conn = new SqlConnection(chuoikn);
        }

        public void moKN()
        {
            ketnoiSQL();
            conn.Open();
        }

        public SqlConnection getConnection()
        {
            return conn;
        }

        public void dongKN()
        {
            conn.Close();
        }
    }
}
