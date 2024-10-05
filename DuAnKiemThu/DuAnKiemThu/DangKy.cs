using System.Data;
using System.Drawing.Drawing2D;

namespace DuAnKiemThu
{
    public partial class DangKy : UserControl
    {
        DAOTaiKhoan tk = new DAOTaiKhoan();
        DAOKhoaHoc kh = new DAOKhoaHoc();
        DAOHocSinh sv = new DAOHocSinh();
        DAOLop lop = new DAOLop();
        DataTable daKH = new DataTable();
        DataTable daLH = new DataTable();
        public DangKy()
        {
            InitializeComponent();
            RoundCorners(panel9, 15);
            rbNam.Checked = true;
            loiTenDangNhap.Text = "";
            loiTenSinhVien.Text = "";
            loiNgaySinh.Text = "";
            loiGioiTinh.Text = "";
            lbloingaynhaphoc.Text = "";
            loiKhoaHoc.Text = "";
            loiLopHoc.Text = "";
            hienthiKhoaHoc();
            hienthilophoc(cbLopHoc.Text);
        }

        private void hienthiKhoaHoc()
        {
            daKH.Rows.Clear();
            daKH = kh.getTenKhoaHoc();
            cbKhoaHoc.DataSource = daKH;
            cbKhoaHoc.DisplayMember = "TenKhoa";
            cbKhoaHoc.ValueMember = "TenKhoa";
        }

        private void hienthilophoc(string tenkhoa)
        {
            daLH.Rows.Clear();
            daLH = lop.getTenLop(tenkhoa);
            cbLopHoc.DataSource = daLH;
            cbLopHoc.DisplayMember = "TenLop";
            cbLopHoc.ValueMember = "TenLop";

        }
        private void RoundCorners(Panel panel, int radius)
        {
            GraphicsPath panelPath = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, panel.Width, panel.Height);
            int diameter = radius * 2;

            panelPath.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            panelPath.AddArc(rect.Width - diameter, rect.Y, diameter, diameter, 270, 90);
            panelPath.AddArc(rect.Width - diameter, rect.Height - diameter, diameter, diameter, 0, 90);
            panelPath.AddArc(rect.X, rect.Height - diameter, diameter, diameter, 90, 90);
            panelPath.CloseFigure();

            panel.Region = new Region(panelPath);
        }
        public event EventHandler OnClickQuayLai;

        private void button1_Click(object sender, EventArgs e)
        {
            OnClickQuayLai?.Invoke(this, EventArgs.Empty);
        }

        private bool checktendangnhap(string tendangnhap)
        {
            if (tendangnhap.Length == 0)
            {
                loiTenDangNhap.Text = "Tên đăng nhập không được bỏ trống";
                return false;
            }
            else if (tk.getTenDangNhap(tendangnhap) > 0)
            {
                loiTenDangNhap.Text = "Tên đăng nhập đã tồn tại";
                return false;
            }
            else if (tendangnhap.Length < 6)
            {
                loiTenDangNhap.Text = "Tên đăng nhập phải có ít nhất 6 ký tự";
                return false;
            }
            else if (!tendangnhap.Any(char.IsUpper))
            {
                loiTenDangNhap.Text = "Tên đăng nhập phải có ít nhất một chữ cái viết hoa";
                return false;
            }
            else if (!tendangnhap.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                loiTenDangNhap.Text = "Tên đăng nhập phải có ít nhất một ký tự đặc biệt";
                return false;
            }
            else
            {
                return true;
            }
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
                loiTenSinhVien.Text = "Họ tên không được bỏ trống";
                return false;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(hoTen, @"[^a-zA-ZÀ-Ỹà-ỹ\s]"))
            {
                loiTenSinhVien.Text = "Họ tên không được chứa số hoặc ký tự đặc biệt";
                return false;
            }
            else
            {
                loiTenSinhVien.Text = "";
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
            if (!DateTime.TryParseExact(ngay, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out parsedDate))
            {
                loiNgaySinh.Text = ("Định dạng ngày sinh không hợp lệ. Vui lòng nhập theo định dạng dd/MM/yyyy.");
                return false;
            }

            if (parsedDate > today)
            {
                loiNgaySinh.Text = ("Ngày sinh không được lớn hơn ngày hiện tại.");
                return false;
            }
            else if (parsedDate == today.Date)
            {
                loiNgaySinh.Text = ("Ngày sinh không được là ngày hiện tại.");
                return false;
            }
            else
            {
                loiNgaySinh.Text = "";
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
                lbloingaynhaphoc.Text = ("Định dạng ngày nhập học không hợp lệ. Vui lòng nhập theo định dạng dd/MM/yyyy.");
                return false;
            }

            if (parsedDate > today)
            {
                lbloingaynhaphoc.Text = ("Ngày nhập học không được lớn hơn ngày hiện tại.");
                return false;
            }
            else
            {
                lbloingaynhaphoc.Text = "";
                return true;
            }

        }

        private bool checkGioiTinh(string gt)
        {
            if(gt.Length <= 0)
            {
                loiGioiTinh.Text = "Vui lòng chọn giới tính";
                return false;
            }
            loiGioiTinh.Text = "";
            return true;
        }

        private bool checkKhoaHoc(string khoahoc)
        {
            if(khoahoc.Length <= 0)
            {
                loiKhoaHoc.Text = "Vui lòng chọn khóa học";
                return false;
            }
            loiKhoaHoc.Text = "";
            return true;
        }

        private bool checkLopHoc(string lop)
        {
            if(lop.Length <= 0)
            {
                loiLopHoc.Text = "Vui lòng chọn lớp học";
                return false;
            }
            loiLopHoc.Text = "";
            return true;
        }

        private bool checkDangKy(string tendangnhap, string hoten, string ngaysinh, string gt, string ngaynhaphoc, string khoahoc, string lophoc)
        {
            bool check = true;
            if (checktendangnhap(tendangnhap) == false)
            {
                check = false;
            }
            if (checkHoTen(hoten) == false)
            {
                check = false;
            }
            if (checkngaysinh(ngaysinh) == false)
            {
                check = false;
            }
            if (checkngaynhaphoc(ngaynhaphoc) == false)
            {
                check = false;
            }
            if (!checkGioiTinh(gt))
            {
                check = false;
            }
            if(checkKhoaHoc(khoahoc) == false)
            {
                check = false;
            }
            if(checkLopHoc(lophoc) == false)
            {
                check = false;
            }
            if (check == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {

            string tendangnhap = txtTenDangNhap.Text.Trim();
            string hoten = txtTenSinhVien.Text.Trim();
            string ngaysinh = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
            string gt = "";
            string ngaynhaphoc = dtpNgayNhapHoc.Value.ToString("dd/MM/yyyy");
            if (rbNam.Checked)
            {
                gt = "Nam";
            }
            else
            {
                gt = "Nữ";
            }
            string lophoc = cbLopHoc.Text;
            string khoahoc = cbKhoaHoc.Text;

            if (checkDangKy(tendangnhap, hoten, ngaysinh, gt, ngaynhaphoc, khoahoc, lophoc))
            {
                ngaysinh = chuanhoaDate(ngaysinh);
                ngaynhaphoc = chuanhoaDate(ngaynhaphoc);
                hoten = chuanhoaTen(hoten);
                khoahoc = kh.getMaKhoaHoc(khoahoc);
                lophoc = lop.getMaLop(lophoc,khoahoc);
                MessageBox.Show(tendangnhap+", "+hoten+", "+ngaysinh+", +"+gt+", "+ngaynhaphoc+", "+khoahoc+", "+lophoc);
                tk.dangkyTaiKhoanSV(tendangnhap);                
                if(sv.dangKyHocSinh(tendangnhap,hoten, ngaysinh, gt, ngaynhaphoc, khoahoc, lophoc) > 0)
                {
                    MessageBox.Show("Đăng ký thông tin thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Đăng ký thông tin thất bại. Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            hienthilophoc(cbKhoaHoc.Text);
        }
    }
}
