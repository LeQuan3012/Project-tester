using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnKiemThu
{
    internal class DAOMonHoc
    {
        DB db = new DB();

        public DAOMonHoc() { }

        public DataTable getAllMonHoc()
        {
            db.moKN();
            string sql = "select * from MonHoc";
            SqlDataAdapter da = new SqlDataAdapter(sql, db.getConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            db.dongKN();
            return dt;
        }

        public DataTable getAllMaMonHoc()
        {
            db.moKN();
            string sql = "select MaMonHoc from MonHoc";
            SqlDataAdapter da = new SqlDataAdapter(sql, db.getConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            db.dongKN();
            return dt;
        }

        public int checkMonHocDaThem(string mamh)
        {
            db.moKN();
            string sql = "select count(*) from MonHoc where MaMonHoc = '"+mamh+"'";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            int result = (int)cmd.ExecuteScalar();
            db.dongKN();
            return result;
        }

        public int insertMonHoc(string mamh, string tenmon, string tinhtrang)
        {
            db.moKN();
            string sql = "insert into MonHoc values('"+mamh+"', N'"+tenmon+"', N'"+tinhtrang+"')";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            int result = cmd.ExecuteNonQuery();
            db.dongKN();
            return result;
        }

        public int updateMonHoc(string manh, string tenmon, string tinhtrang)
        {
            db.moKN();
            string sql = "update MonHoc set TenMonHoc = N'" + tenmon + "', TinhTrang = N'" + tinhtrang + "' where MaMonHoc = '" + manh + "'";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            int kq = cmd.ExecuteNonQuery();
            db.dongKN();
            return kq;
        }

        public int deleteMonHoc(string mamh)
        {
            db.moKN();
            string sql = "update MonHoc set TinhTrang = N'Ngưng học' where MaMonHoc = '" + mamh + "'";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            int kq = cmd.ExecuteNonQuery();
            db.dongKN();
            return kq;
        }

        public string getTenMon(string mamon)
        {
            db.moKN();
            string sql = "select TenMonHoc from MonHoc where MaMonHoc = '" + mamon + "'";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            string result = (string)cmd.ExecuteScalar();
            db.dongKN();
            return result;
        }
    }
}
