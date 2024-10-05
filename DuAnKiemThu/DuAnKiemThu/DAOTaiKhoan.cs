using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnKiemThu
{
    public class DAOTaiKhoan
    {
        DB db = new DB();
        public DAOTaiKhoan() {}

        public int kiemTraDangNhap(string tendn, string mk)
        {
            db.moKN();
            string sql = "select count(*) from TaiKhoan where TenDangNhap COLLATE SQL_Latin1_General_CP1_CS_AS = '" + tendn + "' and MatKhau COLLATE SQL_Latin1_General_CP1_CS_AS ='" + mk + "'";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            int result = (int)cmd.ExecuteScalar();
            db.dongKN();
            return result;
        }

        public string getVaiTroDangNhap(string tendn, string mk)
        {
            db.moKN();
            string sqlVaiTro = "select VaiTro from TaiKhoan where TenDangNhap ='" + tendn + "' and MatKhau='" + mk + "'";
            SqlCommand cmd = new SqlCommand(sqlVaiTro, db.getConnection());
            string result = (string)cmd.ExecuteScalar();
            db.dongKN();
            return result;
        }

        public int getTenDangNhap (string tendn)
        {
            db.moKN();
            string sqlten = "select count(*) from TaiKhoan where TenDangNhap COLLATE SQL_Latin1_General_CP1_CS_AS = '" + tendn + "'";
            SqlCommand cmd = new SqlCommand(sqlten, db.getConnection());
            int result = (int)cmd.ExecuteScalar();
            db.dongKN();
            return result;
        }

        public int updateTrangThaiTK(string tendn)
        {
            db.moKN();
            string sqlten = "update TaiKhoan set TinhTrang = N'Đang hoạt động' where TenDangNhap = '"+tendn+"'";
            SqlCommand cmd = new SqlCommand(sqlten, db.getConnection());
            int result = cmd.ExecuteNonQuery();
            db.dongKN();
            return result;
        }

        public void dangkyTaiKhoanSV(string tendn)
        {
            db.moKN();
            string sql = "insert into TaiKhoan values('"+tendn+"','ffff',N'Học Sinh', N'Chưa kích hoạt')";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            cmd.ExecuteNonQuery();
            db.dongKN();       
        }

        public DataTable getAllVaiTro()
        {
            DataTable daVaiTro = new DataTable();
            db.moKN();
            string sql = "select distinct(VaiTro) from TaiKhoan";
            SqlDataAdapter da = new SqlDataAdapter(sql, db.getConnection());
            da.Fill(daVaiTro);
            db.dongKN();
            return daVaiTro;
        }

        public DataTable getAllTaiKhoan()
        {
            DataTable daVaiTro = new DataTable();
            db.moKN();
            string sql = "select TenDangNhap as 'Tên đăng nhập', VaiTro as 'Vai trò', TinhTrang as 'Tình trạng' from TaiKhoan";
            SqlDataAdapter da = new SqlDataAdapter(sql, db.getConnection());
            da.Fill(daVaiTro);
            db.dongKN();
            return daVaiTro;
        }

        public DataTable locTaiKhoan(string vaitro)
        {
            DataTable daloc = new DataTable();
            db.moKN();
            string sql = "select TenDangNhap as 'Tên đăng nhập', VaiTro as 'Vai trò', TinhTrang as 'Tình trạng' from TaiKhoan where VaiTro = N'"+vaitro+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, db.getConnection());
            da.Fill(daloc);
            db.dongKN();
            return daloc;
        }

        public int insertTaiKhoan(string tendn, string mk, string vaitro, string tinhtrang)
        { 
            db.moKN();
            string sql = "insert into TaiKhoan values('"+tendn+"','"+mk+"',N'"+vaitro+"',N'"+tinhtrang+"')";
            SqlCommand cmd = new SqlCommand(sql,db.getConnection());
            int result = cmd.ExecuteNonQuery();
            db.dongKN();
            return result;
        }

        public int updateTaiKhoan(string tendn, string mk, string vaitro, string tinhtrang, string tendncu)
        {
            db.moKN();
            string sql = "update TaiKhoan set TenDangNhap = '"+tendn+"', MatKhau = '"+mk+"', VaiTro = N'"+vaitro+"', TinhTrang = N'"+tinhtrang+"' where TenDangNhap = '"+tendncu+"'";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            int result = cmd.ExecuteNonQuery();
            return result;
        }

        public string getMatKhau(string tendn)
        {
            db.moKN();
            DataTable daMk = new DataTable();
            string sql = "select MatKhau from TaiKhoan where TenDangNhap = '"+tendn+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, db.getConnection());
            da.Fill(daMk);
            if (daMk.Rows.Count > 0)
            {
                return daMk.Rows[0]["MatKhau"].ToString();
            }
            else
            {
                return "";
            }
        }

        public int deleteTaiKhoan(string tendn)
        {
            db.moKN();
            string sql = "update TaiKhoan set TinhTrang = N'Ngưng hoạt động' where TenDangNhap = '"+tendn+"'";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            int result = cmd.ExecuteNonQuery();
            db.dongKN();
            return result;
        }

        public DataTable getALlTKNew()
        {
            DataTable dt = new DataTable();
            db.moKN();
            string sql = "select TenDangNhap as 'Tên đăng nhập', MatKhau as 'Mật khẩu', VaiTro as 'Vai trò', TinhTrang as 'Tình trạng' from TaiKhoan where TinhTrang = N'Chưa kích hoạt' and VaiTro = N'Giáo Viên'";
            SqlDataAdapter cmd = new SqlDataAdapter(sql, db.getConnection());
            cmd.Fill(dt);
            db.dongKN();
            return dt;
        }

        public DataTable getALlTKNewHS()
        {
            DataTable dt = new DataTable();
            db.moKN();
            string sql = "select TenDangNhap as 'Tên đăng nhập', MatKhau as 'Mật khẩu', VaiTro as 'Vai trò', TinhTrang as 'Tình trạng' from TaiKhoan where TinhTrang = N'Chưa kích hoạt' and VaiTro = N'Học sinh'";
            SqlDataAdapter cmd = new SqlDataAdapter(sql, db.getConnection());
            cmd.Fill(dt);
            db.dongKN();
            return dt;
        }
    }
}
