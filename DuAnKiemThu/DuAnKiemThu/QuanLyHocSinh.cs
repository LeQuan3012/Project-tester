using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnKiemThu
{
    public partial class QuanLyHocSinh : UserControl
    {
        DAOKhoaHoc khoahoc = new DAOKhoaHoc();
        DAOLop lop = new DAOLop();
        DAOHocSinh hocsinh = new DAOHocSinh();
        DAOTaiKhoan taikhoan = new DAOTaiKhoan();
        DataTable dtkhoahoc = new DataTable();
        DataTable dtlop = new DataTable();
        DataTable dthocsinh = new DataTable();
        DataTable dtlophocsinh = new DataTable();
        public QuanLyHocSinh()
        {
            InitializeComponent();
            loadDL();
        }

        private void loadDL()
        {
            dthocsinh.Rows.Clear();
            dtkhoahoc.Rows.Clear();

            lbloimahs.Text = "";
            lbloihotenhs.Text = "";
            lbloikhoahochs.Text = "";
            lbloinamsinhhs.Text = "";
            lbloigioitinhhs.Text = "";
            lbloingaynhaphochs.Text = "";
            lbloitinhtranghs.Text = "";
            lbloilophs.Text = "";
            cbtinhtranghs.SelectedIndex = 0;
            txtmahocsinh.Text = "";
            txttenhs.Text = "";


            dtkhoahoc = khoahoc.getTenKhoaHoc();
            cbkhoahochs.DataSource = dtkhoahoc;
            cbkhoahochs.ValueMember = "TenKhoa";
            cbkhoahochs.DisplayMember = "TenKhoa";

            cbkhoahoctimkiem.DataSource = dtkhoahoc;
            cbkhoahoctimkiem.ValueMember = "TenKhoa";
            cbkhoahoctimkiem.DisplayMember = "TenKhoa";

            dthocsinh = hocsinh.getAllHocSinh();
            dgvhocsinh.DataSource = dthocsinh;

        }
        private void xoaloi()
        {
            lbloimahs.Text = "";
            lbloihotenhs.Text = "";
            lbloikhoahochs.Text = "";
            lbloinamsinhhs.Text = "";
            lbloigioitinhhs.Text = "";
            lbloingaynhaphochs.Text = "";
            lbloitinhtranghs.Text = "";
            lbloilophs.Text = "";
        }
        private void cbkhoahoctimkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtlop.Rows.Clear();
            dtlop = lop.getAllTenLop(cbkhoahoctimkiem.Text);
            cbloploc.DataSource = dtlop;
            cbloploc.DisplayMember = "TenLop";
            cbloploc.ValueMember = "TenLop";
        }

        private void btntimkiemhs_Click(object sender, EventArgs e)
        {
            dthocsinh.Rows.Clear();
            string khoahoc = cbkhoahoctimkiem.Text.Trim();
            string tenlop = cbloploc.Text.Trim();
            dthocsinh = hocsinh.getALlHocSinhLoc(khoahoc, tenlop);
            dgvhocsinh.DataSource = dthocsinh;
        }

        private void btntracuumahs_Click(object sender, EventArgs e)
        {
            FormTraCuuHocSinh form = new FormTraCuuHocSinh(this);
            form.Show();
        }

        public void setTenDangNhap(string ma)
        {
            txtmahocsinh.Text = ma;
        }

        public bool checkmaHS(string ma)
        {
            if (taikhoan.getTenDangNhap(ma) <= 0)
            {
                lbloimahs.Text = "Tên đăng nhập chưa chính xác";
                return false;
            }
            lbloimahs.Text = "";
            return true;
        }

        public bool checkSuaMaHS(string ma, string macheck)
        {
            if (!ma.Equals(macheck))
            {
                lbloimahs.Text = "Không được sửa mã học sinh";
                return false;
            }
            lbloimahs.Text = "";
            return true;
        }

        private string chuanhoaTen(string ten)
        {
            string[] words = ten.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Viết hoa chữ cái đầu của mỗi từ và viết thường các ký tự còn lại
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                }
            }

            // Kết hợp các từ thành một chuỗi và trả về
            return string.Join(" ", words);
        }
        private bool checkHoTen(string hoTen)
        {
            if (hoTen.Length == 0)
            {
                lbloihotenhs.Text = "Họ tên không được bỏ trống";
                return false;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(hoTen, @"[^a-zA-ZÀ-Ỹà-ỹ\s]"))
            {
                lbloihotenhs.Text = "Họ tên không được chứa số hoặc ký tự đặc biệt";
                return false;
            }
            else
            {
                lbloihotenhs.Text = "";
                return true;
            }
        }

        private string chuanhoaDate(string date)
        {
            DateTime parsedDate;
            if (DateTime.TryParseExact(date, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out parsedDate))
            {
                return parsedDate.ToString("yyyy-MM-dd");
            }
            else
            {
                return "";
            }
        }

        private bool checkngaysinh(string ngay)
        {
            // Ngày hiện tại
            DateTime today = DateTime.Today;
            DateTime parsedDate;
            if(ngay.Length <= 0)
            {
                lbloinamsinhhs.Text = "Ngày sinh không được bỏ trống";
                return false;
            }
            if (!DateTime.TryParseExact(ngay, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out parsedDate))
            {
                lbloinamsinhhs.Text = ("Ngày sinh phải theo định dạng dd/MM/yyyy.");
                return false;
            }

            int age = today.Year - parsedDate.Year;
            if (parsedDate > today.AddYears(-age)) 
                age--;

            if (parsedDate > today)
            {
                lbloinamsinhhs.Text = ("Ngày sinh không được lớn hơn ngày hiện tại.");
                return false;
            }
            else if (parsedDate == today.Date)
            {
                lbloinamsinhhs.Text = ("Ngày sinh không được là ngày hiện tại.");
                return false;
            }
            else if (age < 15)
            {
                lbloinamsinhhs.Text = "Học sinh phải từ 15 tuổi trở lên";
                return false;
            }
            else
            {
                lbloinamsinhhs.Text = "";
                return true;
            }

        }

        private bool checkngaynhaphoc(string ngay)
        {
            // Ngày hiện tại
            DateTime today = DateTime.Today;
            DateTime parsedDate;
            if (!DateTime.TryParseExact(ngay, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out parsedDate))
            {
                lbloingaynhaphochs.Text = ("Ngày nhập học phải theo định dạng dd/MM/yyyy.");
                return false;
            }
            if (ngay.Length <= 0)
            {
                lbloingaynhaphochs.Text = "Ngày nhập học không được bỏ trống";
                return false;
            }

            if (parsedDate > today)
            {
                lbloingaynhaphochs.Text = ("Ngày nhập học không được lớn hơn ngày hiện tại.");
                return false;
            }
            else
            {
                lbloingaynhaphochs.Text = "";
                return true;
            }

        }

        public bool checkMaKhoaHoc(string ma)
        {
            if (khoahoc.checkTrungKhoaHoc(ma) <= 0)
            {
                lbloikhoahochs.Text = "Khóa học không được bỏ trống";
                return false;
            }
            lbloikhoahochs.Text = "";
            return true;
        }


        public bool checkMaLop(string malop)
        {
            if (lop.checkTrungMaLop(malop) <= 0)
            {
                lbloilophs.Text = "lớp không được bỏ trống";
                return false;
            }
            lbloilophs.Text = "";
            return true;
        }

        public bool checkGioiTinh(string gt)
        {
            if (gt.Length <= 0)
            {
                lbloigioitinhhs.Text = "Giới tính không được bỏ trống";
                return false;
            }
            lbloigioitinhhs.Text = "";
            return true;
        }

        public bool checkTinhTrang(string tt)
        {
            if(tt.Length <= 0)
            {
                lbloitinhtranghs.Text = "Tình trạng không được bỏ trốngg";
                return false;
            }
            lbloitinhtranghs.Text = "";
            return true;
        }

        private bool checkThem(string mahs, string tenhs, string malop, string ngaysinh, string gt, string ngaynhaphoc, string makhoahoc, string tt)
        {
            bool check = true;
            if (!checkmaHS(mahs))
            {
                check = false;
            }
            if (!checkHoTen(tenhs))
            {
                check = false;
            }
            if (!checkMaLop(malop))
            {
                check = false;
            }
            if (!checkngaysinh(ngaysinh))
            {
                check = false;
            }

            if (!checkGioiTinh(gt))
            {
                check = false;
            }
            if (!checkngaynhaphoc(ngaynhaphoc))
            {
                check = false;
            }
            if (!checkMaKhoaHoc(makhoahoc))
            {
                check = false;
            }
            if (checkTinhTrang(tt))
            {
                check = false;
            }
            if (check)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string mahs = txtmahocsinh.Text.Trim();
            string tenhs = txttenhs.Text.Trim();
            string malop = cblophs.Text.Trim();
            string ngaysinh = dtpnamsinhhs.Value.ToString("dd/MM/yyyy");
            string gt = cbgioitinhhs.Text;
            string ngaynhaphoc = dtpngaynhaphochs.Value.ToString("dd/MM/yyyy");
            string tenkhoahoc = cbkhoahochs.Text;
            tenkhoahoc = khoahoc.getMaKhoaHoc(tenkhoahoc);
            string tinhtrang = cbtinhtranghs.Text;
            malop = lop.getMaLop(malop, tenkhoahoc);
            if (checkThem(mahs, tenhs, malop, ngaysinh, gt, ngaynhaphoc, tenkhoahoc, tinhtrang))
            {
                ngaynhaphoc = chuanhoaDate(ngaynhaphoc);
                ngaysinh = chuanhoaDate(ngaysinh);
                tenhs = chuanhoaTen(tenhs);

                if (hocsinh.insertHocSinh(mahs, tenhs, ngaysinh, gt, ngaynhaphoc, tenkhoahoc, malop, tinhtrang) > 0)
                {
                    if (taikhoan.updateTrangThaiTK(mahs) > 0)
                    {
                        loadDL();
                        MessageBox.Show("Thêm thông tin sinh viên thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Thêm thông tin sinh viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thêm thông tin sinh viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mahs = txtmahocsinh.Text.Trim();
            string tenhs = txttenhs.Text.Trim();
            string malop = cblophs.Text.Trim();
            string ngaysinh = dtpnamsinhhs.Value.ToString("dd/MM/yyyy");
            string gt = cbgioitinhhs.Text;
            string ngaynhaphoc = dtpngaynhaphochs.Value.ToString("dd/MM/yyyy");
            string tenkhoahoc = cbkhoahochs.Text;
            tenkhoahoc = khoahoc.getMaKhoaHoc(tenkhoahoc);
            string tinhtrang = cbtinhtranghs.Text;
            malop = lop.getMaLop(malop, tenkhoahoc);
            if(checkSuaHS(mahs, tenkhoahoc, tenhs, ngaysinh, gt, ngaynhaphoc, malop, tinhtrang))
            {
                ngaynhaphoc = chuanhoaDate(ngaynhaphoc);
                ngaysinh = chuanhoaDate(ngaysinh);
                tenhs = chuanhoaTen(tenhs);

                if (hocsinh.updateHocSinh(mahs, tenhs, ngaysinh, gt, ngaynhaphoc, tenkhoahoc, malop, tinhtrang) > 0)
                {
                    loadDL();
                    MessageBox.Show("Sửa thông tin sinh viên thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Sửa thông tin sinh viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sửa thông tin sinh viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (hocsinh.deleteHocSinh(tendn) > 0)
            {
                loadDL();
                MessageBox.Show("Xóa thông tin sinh viên thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Xóa thông tin sinh viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbkhoahochs_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtlophocsinh.Rows.Clear();
            dtlophocsinh = lop.getAllTenLop(cbkhoahochs.Text);
            cblophs.DataSource = dtlophocsinh;
            cblophs.DisplayMember = "TenLop";
            cblophs.ValueMember = "TenLop";
        }

        int ddc;
        string tendn = "";
        private void dgvhocsinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                xoaloi();
                ddc = e.RowIndex;
                tendn = dgvhocsinh.Rows[ddc].Cells[4].Value.ToString(); ;
                txtmahocsinh.Text = dgvhocsinh.Rows[ddc].Cells[4].Value.ToString();
                cbkhoahochs.Text = dgvhocsinh.Rows[ddc].Cells[3].Value.ToString();
                txttenhs.Text = dgvhocsinh.Rows[ddc].Cells[5].Value.ToString();
                dtpnamsinhhs.Text = dgvhocsinh.Rows[ddc].Cells[6].Value.ToString();
                cbgioitinhhs.Text = dgvhocsinh.Rows[ddc].Cells[7].Value.ToString();
                dtpngaynhaphochs.Text = dgvhocsinh.Rows[ddc].Cells[8].Value.ToString();
                cblophs.Text = dgvhocsinh.Rows[ddc].Cells[1].Value.ToString();
                cbtinhtranghs.Text = dgvhocsinh.Rows[ddc].Cells[9].Value.ToString();
            }
        }
        private bool checkSuaHS(string mahs, string khoahoc, string hoten, string ngaysinh, string gt, string ngaynh, string lop, string tinhtrang)
        {
            bool check = true;
            if (!checkSuaMaHS(mahs, tendn))
            {
                check = false;
            }
            if (!checkMaKhoaHoc(khoahoc))
            {
                check = false;
            }
            if (!checkHoTen(hoten))
            {
                check = false;
            }
            if (!checkngaysinh(ngaysinh))
            {
                check = false;
            }
            if (!checkGioiTinh(gt))
            {
                check = false;
            }

            if (!checkMaLop(lop))
            {
                check = false;
            }
            if (!checkTinhTrang(tinhtrang))
            {
                check = false;
            }
            if (check)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
