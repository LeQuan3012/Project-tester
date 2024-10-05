using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnKiemThu
{
    internal class DAOLop
    {
        DB db = new DB();
        public DAOLop() { }
        public DataTable getTenLop(String tenkhoa)
        {
            DataTable dtlop = new DataTable();
            db.moKN();
            string sql = "Select *\r\nfrom Lop inner join KhoaHoc on Lop.MaKhoaHoc = KhoaHoc.MaKhoaHoc\r\nwhere TenKhoa = N'" + tenkhoa + "'";
            SqlDataAdapter dalop = new SqlDataAdapter(sql, db.getConnection());
            dalop.Fill(dtlop);
            db.dongKN();
            return dtlop;
        }

        public string getMaLop(string tenlop, string makhoa)
        {
            db.moKN();
            string sql = "select MaLop from Lop where TenLop = N'" + tenlop + "' and MaKhoaHoc=N'" + makhoa + "'";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            string result = (string)cmd.ExecuteScalar();
            db.dongKN();
            return result;
        }

        public DataTable getAllLop()
        {
            db.moKN();
            DataTable dt = new DataTable();
            string sql = "select MaLop as 'Mã lớp', TenLop as 'Tên lớp', NamHoc as 'Năm học', TenGiaoVien as 'GVCN', SL = (select count(*) from SinhVien where SinhVien.MaLop = Lop.MaLop) from TaiKhoan inner join Lop on Lop.TenDangNhap = TaiKhoan.TenDangNhap inner join GiaoVien on TaiKhoan.TenDangNhap = GiaoVien.TenDangNhap";
            SqlDataAdapter da = new SqlDataAdapter(sql, db.getConnection());
            da.Fill(dt);
            db.dongKN();
            return dt;
        }
        public DataTable getAllMaLop()
        {
            db.moKN();
            string sql = "select MaLop from Lop";
            SqlDataAdapter da = new SqlDataAdapter(sql, db.getConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            db.dongKN();
            return dt;
        }

        public DataTable getAllTenLop(string tenkhoa)
        {
            db.moKN();
            DataTable dt = new DataTable();
            string sql = "select distinct(TenLop) from KhoaHoc inner join Lop on KhoaHoc.MaKhoaHoc = Lop.MaKhoaHoc where TenKhoa = N'"+tenkhoa+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, db.getConnection());
            da.Fill(dt);
            db.dongKN();
            return dt;
        }

        public string getMaKhoa(string tenkhoa)
        {
            db.moKN();
            string sql = "select MaKhoaHoc from KhoaHoc where TenKhoa = N'" + tenkhoa + "'";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            string result = (string)cmd.ExecuteScalar();
            db.dongKN();
            return result;
        }

        public DataTable getLocLop(string tenkhoa)
        {
            db.moKN();
            DataTable dt = new DataTable();
            string sql = "select MaLop as 'Mã lớp', TenLop as 'Tên lớp', NamHoc as 'Năm học', TenGiaoVien as 'GVCN', SL = (select count(*) from SinhVien where SinhVien.MaLop = Lop.MaLop) from TaiKhoan inner join Lop on Lop.TenDangNhap = TaiKhoan.TenDangNhap inner join GiaoVien on TaiKhoan.TenDangNhap = GiaoVien.TenDangNhap where MaKhoaHoc = '" + getMaKhoa(tenkhoa) + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, db.getConnection());
            da.Fill(dt);
            db.dongKN();
            return dt;
        }

        public int checkTrungMaLop(string malop)
        {
            db.moKN();
            string sql = "select count(*) from Lop where MaLop = '" + malop + "'";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            int result = (int)cmd.ExecuteScalar();
            db.dongKN();
            return result;
        }

        public int insertLop(string malop, string tenlop, string namhoc, string khoa, string gvcn)
        {
            db.moKN();
            string sql = "insert into Lop values('" + malop + "', N'" + tenlop + "', '" + namhoc + "', '" + gvcn + "', '" + khoa + "')";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            int result = cmd.ExecuteNonQuery();
            db.dongKN();
            return result;

        }

        public int updateLop(string malop, string tenlop, string namhoc, string khoa, string gvcn)
        {
            db.moKN();
            string sql = "update Lop set TenLop = N'"+tenlop+"', NamHoc = '"+namhoc+"', MaKhoaHoc='"+khoa+"', TenDangNhap = '"+gvcn+"' where MaLop = '"+malop+"'";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            int result = cmd.ExecuteNonQuery();
            db.dongKN();
            return result;

        }

    }
}
