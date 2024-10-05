using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnKiemThu
{
    internal class DAODayHoc
    {
        DB db = new DB();
        public DAODayHoc() { }

        public DataTable getAllDayHoc()
        {
            db.moKN();
            DataTable dt = new DataTable();
            string sql = "select GiaoVien.TenDangNhap as 'Tên đăng nhập', TenGiaoVien as 'Tên giáo viên', SDT, ChuyenMon as 'Chuyên môn', Lop.MaLop as 'Mã lớp', TenLop as 'Tên lớp',Lop.MaKhoaHoc as 'Tên khóa', MonHoc.MaMonHoc as 'Mã môn học', MonHoc.TenMonHoc as 'Tên môn học', HocKy as 'Học kỳ', GV_MH.NamHoc as 'Năm học'\r\nfrom GV_MH inner join GiaoVien on GV_MH.TenDangNhap = GiaoVien.TenDangNhap inner join Lop on GV_MH.MaLop = Lop.MaLop inner join KhoaHoc on Lop.MaKhoaHoc = KhoaHoc.MaKhoaHoc inner join MonHoc on GV_MH.MaMonHoc = MonHoc.MaMonHoc";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, db.getConnection());
            adapter.Fill(dt);
            db.dongKN();
            return dt;
        }

        public DataTable timKiemDayHoc( string namhoc, string hk)
        {
            db.moKN();
            DataTable dt = new DataTable();
            string sql = "select GiaoVien.TenDangNhap as 'Tên đăng nhập', TenGiaoVien as 'Tên giáo viên', SDT, ChuyenMon as 'Chuyên môn', Lop.MaLop as 'Mã lớp', TenLop as 'Tên lớp',Lop.MaKhoaHoc as 'Tên khóa', MonHoc.MaMonHoc as 'Mã môn học', MonHoc.TenMonHoc as 'Tên môn học', HocKy as 'Học kỳ', GV_MH.NamHoc as 'Năm học'\r\nfrom GV_MH inner join GiaoVien on GV_MH.TenDangNhap = GiaoVien.TenDangNhap inner join Lop on GV_MH.MaLop = Lop.MaLop inner join KhoaHoc on Lop.MaKhoaHoc = KhoaHoc.MaKhoaHoc inner join MonHoc on GV_MH.MaMonHoc = MonHoc.MaMonHoc where HocKy = '" + hk+"' and GV_MH.NamHoc = '"+namhoc+"'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, db.getConnection());
            adapter.Fill(dt);
            db.dongKN();
            return dt;
        }

        public int insertDayHoc(string tendn, string mamh, string hk, string namhoc, string malop)
        {
            db.moKN();
            string sql = "insert into GV_MH values ('"+tendn+"','"+mamh+"','"+hk+"','"+namhoc+"','"+malop+"')";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            int result = cmd.ExecuteNonQuery();
            db.dongKN();
            return result;
        }

        public int updateDayHoc(string tendn, string mamh, string hk, string namhoc, string malop, string tendncheck, string mamhcheck, string hkcheck, string malopcheck, string namhoccheck)
        {
            db.moKN();
            string sql = "update GV_MH set TenDangNhap = '"+tendn+"', MaMonHoc = '"+mamh+"', HocKy = '"+hk+"', NamHoc='"+namhoc+"', MaLop = '"+malop+"' where TenDangNhap = '"+tendncheck+ "' and MaMonHoc='"+mamhcheck+"' and HocKy='"+hkcheck+"' and NamHoc='"+namhoccheck+"' and MaLop='"+malopcheck+"'";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            int result = cmd.ExecuteNonQuery();
            db.dongKN();
            return result;
        }
    }
}
