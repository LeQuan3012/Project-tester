using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnKiemThu
{
    internal class DAOKhoaHoc
    {
        DB db = new DB();
        public DAOKhoaHoc() { }
        public string getMaKhoaHoc(string tenkhoa)
        {
            db.moKN();
            string sql = "select MaKhoaHoc from KhoaHoc where TenKhoa = N'" + tenkhoa + "'";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            string makhoa = (string)cmd.ExecuteScalar();
            db.dongKN();
            return makhoa;
        }

        public DataTable getTenKhoaHoc()
        {
            DataTable dtTenKH = new DataTable();
            string sql = "select TenKhoa from KhoaHoc";
            db.moKN();
            SqlDataAdapter daKH = new SqlDataAdapter(sql, db.getConnection());
            daKH.Fill(dtTenKH);
            db.dongKN();
            return dtTenKH;
        }

        public DataTable getAllKhoaHoc()
        {
            DataTable dtAllKH = new DataTable();
            string sql = "select MaKhoaHoc as 'Mã khóa học', TenKhoa as 'Tên khóa học', TinhTrang as 'Tình trạng' from KhoaHoc";
            db.moKN();
            SqlDataAdapter da = new SqlDataAdapter(sql, db.getConnection());
            da.Fill(dtAllKH);
            db.dongKN();
            return dtAllKH;
        }

        public int checkTrungKhoaHoc(string makh)
        {
            db.moKN();
            string sql = "select count(*) from KhoaHoc where MaKhoaHoc = '" + makh + "'";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            int result = (int)cmd.ExecuteScalar();
            db.dongKN();
            return result;
        }

        public int checkTrungTenKhoaHoc(string tenkhoa)
        {
            db.moKN();
            string sql = "select count(*) from KhoaHoc where TenKhoa = N'" + tenkhoa + "'";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            int result = (int)cmd.ExecuteScalar();
            db.dongKN();
            return result;
        }

        public int insertKhoaHoc(string ma, string ten, string tt)
        {
            db.moKN();
            string sql = "insert into KhoaHoc values('"+ma+"', N'"+ten+"', N'"+tt+"')";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            int result = cmd.ExecuteNonQuery();
            db.dongKN();
            return result;
        }

        public int updateKhoaHoc(string ma, string ten, string tt)
        {
            db.moKN();
            string sql = "update KhoaHoc set TenKhoa = N'"+ten+"', TinhTrang = N'"+tt+"' where MaKhoaHoc = '"+ma+"'";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            int result = cmd.ExecuteNonQuery();
            db.dongKN();
            return result;
        }

        public int deleteKhoaHoc(string ma)
        {
            db.moKN();
            string sql = "update KhoaHoc set TinhTrang = N'Đã ra trường' where MaKhoaHoc = '"+ma+"'";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            int result = cmd.ExecuteNonQuery();
            db.dongKN();
            return result;
        }

    }
}
