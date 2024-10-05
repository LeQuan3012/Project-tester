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
    internal class DAOHocSinh
    {
        DB db = new DB();
        public DAOHocSinh() { }

        public int dangKyHocSinh(string tendn, string tenhs, string ngaysinh, string gt, string ngaynhaphoc, string makhoa, string malop)
        {
            db.moKN();
            string sql = "insert into SinhVien values('"+tendn+"', N'"+tenhs+"','"+ngaysinh+"',N'"+gt+"','"+ngaynhaphoc+"','"+makhoa+"',N'Đang còn học', '"+malop+"')";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            int result = cmd.ExecuteNonQuery();
            db.dongKN();
            return result;
        }
        public int insertHocSinh(string tendn, string tenhs, string ngaysinh, string gt, string ngaynhaphoc, string makhoa, string malop, string tt)
        {
            db.moKN();
            string sql = "insert into SinhVien values('" + tendn + "', N'" + tenhs + "','" + ngaysinh + "',N'" + gt + "','" + ngaynhaphoc + "','" + makhoa + "',N'"+tt+"', '" + malop + "')";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            int result = cmd.ExecuteNonQuery();
            db.dongKN();
            return result;
        }

        public int updateHocSinh(string tendn, string tenhs, string ngaysinh, string gt, string ngaynhaphoc, string makhoa, string malop, string tt)
        {
            db.moKN();
            string sql = "update SinhVien set TenSinhVien = N'"+tenhs+"', NamSinh = '"+ngaysinh+"', GioiTinh = N'"+gt+"', NgayNhapHoc = '"+ngaynhaphoc+"', MaKhoaHoc = '"+makhoa+"', TinhTrang = N'"+tt+"', MaLop = '"+malop+"' where TenDangNhap = '"+tendn+"'";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            int result = cmd.ExecuteNonQuery();
            db.dongKN();
            return result;
        }

        public int deleteHocSinh(string tendn)
        {
            db.moKN();
            string sql = "update SinhVien set TinhTrang = N'Đã ra trường' where TenDangNhap = '" + tendn + "'";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            int result = cmd.ExecuteNonQuery();
            db.dongKN();
            return result;
        }

        public DataTable getAllHocSinh()
        {
            db.moKN();
            DataTable dt = new DataTable();
            string sql = "select Lop.MaLop as 'Mã lớp', TenLop as 'Tên lớp', NamHoc as 'Năm học', TenKhoa as 'Tên khóa',SinhVien.TenDangNhap as'Tên đăng nhập', SinhVien.TenSinhVien as 'Tên sinh viên', NamSinh as 'Năm sinh', GioiTinh as 'Giới Tính', NgayNhapHoc as 'Ngày nhập học', SinhVien.TinhTrang as 'Tình trạng' \r\nfrom Lop inner join KhoaHoc on Lop.MaKhoaHoc = KhoaHoc.MaKhoaHoc\r\ninner join SinhVien on Lop.MaLop = SinhVien.MaLop";
            SqlDataAdapter da = new SqlDataAdapter(sql, db.getConnection());
            da.Fill(dt);
            db.dongKN();
            return dt;
        }

        public DataTable getALlHocSinhLoc(string tenkhoa, string tenlop)
        {
            db.moKN();
            DataTable dt = new DataTable();
            string sql = "select Lop.MaLop as 'Mã lớp', TenLop as 'Tên lớp', NamHoc as 'Năm học', TenKhoa as 'Tên khóa', TenSinhVien as 'Tên sinh viên', NamSinh as 'Năm sinh', GioiTinh as 'Giới Tính', NgayNhapHoc as 'Ngày nhập học', SinhVien.TinhTrang as 'Tình trạng' \r\nfrom Lop inner join KhoaHoc on Lop.MaKhoaHoc = KhoaHoc.MaKhoaHoc\r\ninner join SinhVien on Lop.MaLop = SinhVien.MaLop where TenKhoa = N'" + tenkhoa+"' and TenLop = N'"+tenlop+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, db.getConnection());
            da.Fill(dt);
            db.dongKN();
            return dt;
        }
    }
}
