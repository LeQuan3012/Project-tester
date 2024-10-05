using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace DuAnKiemThu
{
    internal class DAOGiaoVien
    {
        DB db = new DB();
        public DAOGiaoVien() { }

        public DataTable getAllGiaoVien()
        {
            DataTable dt = new DataTable();
            db.moKN();
            string sql = "select TenDangNhap as 'Mã giáo viên', TenGiaoVien as 'Tên giáo viên', NamSinh as 'Năm sinh', GioiTinh as 'Giới tính', NgayVaoLam as 'Ngày vào làm', DiaChi as 'Địa chỉ',SDT, ChuyenMon as 'Chuyên môn', TinhTrang as 'Tình trạng' from GiaoVien";
            SqlDataAdapter da = new SqlDataAdapter(sql, db.getConnection());
            da.Fill(dt);
            db.dongKN();
            return dt;
        }

        public string getTenGV(string magv)
        {
            db.moKN();
            string sql = "select TenGiaoVien from GiaoVien where TenDangNhap = '" + magv + "'";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            string result = (string)cmd.ExecuteScalar();
            db.dongKN();
            return result;
        }

        public DataTable getAllMaGiaoVien(string chuyenmon)
        {
            db.moKN();
            string sql = "select TenDangNhap from GiaoVien where ChuyenMon = N'"+chuyenmon+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, db.getConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            db.dongKN();
            return dt;
        }
        public DataTable getAllChuyenMon()
        {
            db.moKN();
            string sql = "select distinct(ChuyenMon) from GiaoVien";
            SqlDataAdapter da = new SqlDataAdapter(sql, db.getConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            db.dongKN();
            return dt;
        }

        public DataTable getAllChuyenmon()
        {
            DataTable dt = new DataTable();
            db.moKN();
            string sql = "select distinct ChuyenMon from GiaoVien";
            SqlDataAdapter da = new SqlDataAdapter(sql, db.getConnection());
            da.Fill(dt);
            db.dongKN();
            return dt;
        }

        public DataTable getAllTenGiaoVien()
        {
            DataTable dt = new DataTable();
            db.moKN();
            string sql = "select TenGiaoVien from GiaoVien";
            SqlDataAdapter da = new SqlDataAdapter(sql, db.getConnection());
            da.Fill(dt);
            db.dongKN();
            return dt;
        }

        public DataTable locGiaoVien(string chuyenmon)
        {
            DataTable dt = new DataTable();
            db.moKN();
            string sql = "select TenDangNhap as 'Mã giáo viên', TenGiaoVien as 'Tên giáo viên', NamSinh as 'Năm sinh', GioiTinh as 'Giới tính', NgayVaoLam as 'Ngày vào làm', DiaChi as 'Địa chỉ',SDT, ChuyenMon as 'Chuyên môn', TinhTrang as 'Tình trạng' from GiaoVien where ChuyenMon = N'"+chuyenmon+"'";
            SqlDataAdapter da = new SqlDataAdapter (sql, db.getConnection());
            da.Fill(dt);
            db.dongKN();
            return dt;
        }

        public int insertGiaoVien(string tendn, string tengv, string ngaysinh, string gt, string ngayvaolam,string sdt, string diachi, string tinhtrang, string chuyenmon)
        {
            db.moKN();
            string sql = "insert into GiaoVien values('"+tendn+"',N'"+tengv+"', '"+ngaysinh+"', N'"+gt+"', '"+ngayvaolam+"','"+sdt+"',N'"+diachi+"',N'"+tinhtrang+"', N'"+chuyenmon+"')";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            int result = cmd.ExecuteNonQuery();
            db.dongKN();
            return result;
        }

        public int updateGiaoVien(string tendn, string tengv, string ngaysinh, string gt, string ngayvaolam, string sdt, string diachi, string chuyenmon)
        {
            db.moKN();
            string sql = "update GiaoVien set TenGiaoVien = N'"+tengv+"', Namsinh = '"+ngaysinh+"', GioiTinh = N'"+gt+"', NgayVaoLam = '"+ngayvaolam+"', SDT = '"+sdt+"', DiaChi = N'"+diachi+"', ChuyenMon = N'"+chuyenmon+"' where TenDangNhap = '"+tendn+"'";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            int result = cmd.ExecuteNonQuery();
            db.dongKN();
            return result;
        }

        public int deleteGiaoVien(string tendn)
        {
            db.moKN();
            string sql = "update GiaoVien set TinhTrang = N'Ngưng làm việc' where TenDangNhap = '"+tendn+"'";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            int resutl = cmd.ExecuteNonQuery();
            db.dongKN();
            return resutl;
        }

        public string getMaGV(string tengv)
        {
            db.moKN();
            string sql = "select TenDangNhap from GiaoVien where TenGiaoVien = N'"+tengv+"'";
            SqlCommand cmd = new SqlCommand(sql, db.getConnection());
            string resutl = (string)cmd.ExecuteScalar();
            db.dongKN();
            return resutl;
        }
    }
}
