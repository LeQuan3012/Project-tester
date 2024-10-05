using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace DuAnKiemThu
{
    public partial class QuanLyGiaoVien : UserControl
    {
        DAOGiaoVien giaovien = new DAOGiaoVien();
        DataTable dtgiaovien = new DataTable();
        DataTable dtchuyenmon = new DataTable();
        DataTable dtlocgiaovien = new DataTable();
        DAOTaiKhoan taikhoan = new DAOTaiKhoan();
        public QuanLyGiaoVien()
        {
            InitializeComponent();
            lamMoi();
        }

        private void lamMoi()
        {
            txtmagv.Text = "";
            txttengv.Text = "";
            txtdiachigv.Text = "";
            txtsdtgv.Text = "";
            lbloimagv.Text = "";
            lbloitengv.Text = "";
            lbloinamsinhgv.Text = "";
            lbloigioitinhgv.Text = "";
            lbloidiachigv.Text = "";
            lbloisdtgv.Text = "";
            lbloingayvaolamgv.Text = "";
            loadAllGiaoVien();
            loadAllChuyenMon();
        }

        private void loadAllGiaoVien()
        {
            dtgiaovien.Rows.Clear();
            dtgiaovien = giaovien.getAllGiaoVien();
            dgvgiaovien.DataSource = dtgiaovien;
        }

        private void loadAllChuyenMon()
        {
            dtchuyenmon.Rows.Clear();
            dtchuyenmon = giaovien.getAllChuyenmon();
            cbtimkiemgv.DataSource = dtchuyenmon;
            cbtimkiemgv.DisplayMember = "ChuyenMon";
            cbtimkiemgv.ValueMember = "ChuyenMon";

            cbchuyenmongv.DataSource = dtchuyenmon;
            cbchuyenmongv.DisplayMember = "ChuyenMon";
            cbchuyenmongv.ValueMember = "ChuyenMon";
        }

        private void btnlammoigv_Click(object sender, EventArgs e)
        {
            loadAllGiaoVien();
            lamMoi();
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
                lbloitengv.Text = "Tên giáo viên không được bỏ trống";
                return false;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(hoTen, @"[^a-zA-ZÀ-Ỹà-ỹ\s]"))
            {
                lbloitengv.Text = "Tên giáo viên không được chứa số hoặc ký tự đặc biệt";
                return false;
            }
            else
            {
                lbloitengv.Text = "";
                return true;
            }
        }
        private bool checkngaysinh(string ngay)
        {
            // Ngày hiện tại
            DateTime today = DateTime.Today;
            DateTime parsedDate;
            if (ngay.Length <= 0)
            {
                lbloinamsinhgv.Text = ("Ngày sinh làm không được bỏ trống");
                return false;
            }
            if (!DateTime.TryParseExact(ngay, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out parsedDate))
            {
                lbloinamsinhgv.Text = ("Ngày sinh phải theo định dạng dd-MM-yyyy.");
                return false;
            }
            int age = today.Year - parsedDate.Year;
            if (parsedDate > today.AddYears(-age))
                age--; // Điều chỉnh tuổi nếu chưa đến ngày sinh trong năm hiện tại

            if (parsedDate > today)
            {
                lbloinamsinhgv.Text = ("Ngày sinh không được lớn hơn ngày hiện tại.");
                return false;
            }
            else if (parsedDate == today.Date)
            {
                lbloinamsinhgv.Text = ("Ngày sinh không được là ngày hiện tại.");
                return false;
            }
            else if (age < 18)
            {
                lbloinamsinhgv.Text = ("Giáo viên phải đủ 18 tuổi");
                return false;
            }
            else
            {
                lbloinamsinhgv.Text = "";
                return true;
            }

        }

        private bool checkNgayVaoLam(string ngay)
        {
            DateTime today = DateTime.Today;
            DateTime parsedDate;
            if (ngay.Length <= 0)
            {
                lbloingayvaolamgv.Text = ("Ngày vào làm không được bỏ trống");
                return false;
            }
            if (!DateTime.TryParseExact(ngay, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out parsedDate))
            {
                lbloingayvaolamgv.Text = ("Ngày vào làm phải theo định dạng dd-MM-yyyy.");
                return false;
            }
            else if (parsedDate > today)
            {
                lbloingayvaolamgv.Text = "Ngày vào làm không được lớn hơn ngày hiện tại";
                return false;
            }
            else
            {
                lbloingayvaolamgv.Text = "";
                return true;
            }
        }

        private bool checkDiaChi(string diachi)
        {
            if (diachi.Length == 0)
            {
                lbloidiachigv.Text = "Địa chỉ không được để trống";
                return false;
            }
            
            else
            {
                lbloidiachigv.Text = "";
                return true;
            }
        }

        private bool checkSoDienThoai(string sdt)
        {
            if (sdt.Length == 0)
            {
                lbloisdtgv.Text = "Số điện thoại không được để rỗng";
                return false;
            }
            else if (sdt.Length > 10)
            {
                lbloisdtgv.Text = "Số điện thoại phải có 10 chữ số";
                return false;
            }
            else if (sdt.Length <= 9)
            {
                lbloisdtgv.Text = "Số điện thoại phải có 10 chữ số";
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(sdt, @"^0\d{9}$"))
            {
                lbloisdtgv.Text = "Số điện thoại không được chứa chữ, ký tự đặc biệt và bắt đầu bằng số 0";
                return false;
            }
            else
            {
                lbloisdtgv.Text = "";
                return true;
            }
        }

        private bool checkGT(string gt)
        {
            if (gt.Length <= 0)
            {
                lbloigioitinhgv.Text = "Giới tính không được bỏ trống";
                return false;
            }
            lbloigioitinhgv.Text = "";
            return true;
        }

        private bool checkThem(string magv, string hoten, string namsinh, string gt, string sdt, string ngayvaolam)
        {
            bool check = true;
            if (!checkHoTen(hoten))
            {
                check = false;
            }

            if (!checkngaysinh(namsinh))
            {
                check = false;
            }

            if (!checkSoDienThoai(sdt))
            {
                check = false;
            }

            if (!checkNgayVaoLam(ngayvaolam))
            {
                check = false;
            }
            if (!checkGT(gt))
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

        private void btnthemgv_Click(object sender, EventArgs e)
        {
            string magv = txtmagv.Text.Trim();
            string hoten = txttengv.Text.Trim();
            string namsinh = dtpnamsinhgv.Value.ToString("yyyy-MM-dd");
            string gioitinh;
            if (cbgioitinhgv.Text == "Nam")
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            string diachi = txtdiachigv.Text.Trim();
            string sdt = txtsdtgv.Text.Trim();
            string chuyenmon = cbchuyenmongv.Text.Trim();
            string ngayvaolam = dtpngayvaolam.Value.ToString("yyyy-MM-dd");

            if (checkThem(magv, hoten, namsinh, gioitinh, sdt, ngayvaolam))
            {
                hoten = chuanhoaTen(hoten);
                if (giaovien.insertGiaoVien(magv, hoten, namsinh, gioitinh, ngayvaolam, sdt, diachi, "Đang làm việc", chuyenmon) > 0)
                {
                    MessageBox.Show("Thêm thông tin giáo viên thành công", "Thông báo", MessageBoxButtons.OK);
                    lamMoi();
                }
                else
                {
                    MessageBox.Show("Thêm thông tin giáo viên thất bại. Vui lòng kiểm tra lại thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Một số thông tin còn lỗi. Vui lòng kiểm tra lại thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private string chuanhoaDate(string date)
        {
            DateTime parsedDate;
            if (DateTime.TryParseExact(date, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out parsedDate))
            {
                return parsedDate.ToString("dd-MM-yyyy");
            }
            else
            {
                return "";
            }
        }

        private string chuyenDoiDate(string date)
        {
            string kq = "";
            return kq;
        }

        int dongdangchon;
        private void dgvgiaovien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dongdangchon = e.RowIndex;
                txtmagv.Text = dgvgiaovien.Rows[dongdangchon].Cells[0].Value.ToString();
                txttengv.Text = dgvgiaovien.Rows[dongdangchon].Cells[1].Value.ToString();
                string date = dgvgiaovien.Rows[dongdangchon].Cells[2].Value.ToString();
                DateTime ngaySinh;
                if (DateTime.TryParse(date, out ngaySinh))
                {
                    // Gán giá trị vào DateTimePicker
                    dtpnamsinhgv.Value = ngaySinh;
                }
                else
                {
                    MessageBox.Show("Ngày sinh không hợp lệ.");
                }
                string gt = dgvgiaovien.Rows[dongdangchon].Cells[3].Value.ToString();
                if (gt == "Nam")
                {
                    cbgioitinhgv.Text = "Nam";
                }
                else
                {
                    cbgioitinhgv.Text = "Nữ";
                }
                string ngayvaolam = dgvgiaovien.Rows[dongdangchon].Cells[4].Value.ToString();
                DateTime nvl;
                if (DateTime.TryParse(ngayvaolam, out nvl))
                {
                    // Gán giá trị vào DateTimePicker
                    dtpngayvaolam.Value = nvl;
                }
                else
                {
                    MessageBox.Show("Ngày vào làm không hợp lệ.");
                }
                txtdiachigv.Text = dgvgiaovien.Rows[dongdangchon].Cells[5].Value.ToString();
                txtsdtgv.Text = dgvgiaovien.Rows[dongdangchon].Cells[6].Value.ToString();
                cbchuyenmongv.Text = dgvgiaovien.Rows[dongdangchon].Cells[7].Value.ToString();
            }

        }

        public void dienMaGV(string magv)
        {
            txtmagv.Text = magv.Trim();
        }
        private void btnlocgv_Click(object sender, EventArgs e)
        {
            dtlocgiaovien.Rows.Clear();
            string chuyenmon = cbtimkiemgv.Text;
            MessageBox.Show(chuyenmon);
            dtlocgiaovien = giaovien.locGiaoVien(chuyenmon);
            dgvgiaovien.DataSource = dtlocgiaovien;
        }

        private void btnTracuuMaGV_Click(object sender, EventArgs e)
        {
            FormTraCuuTK a = new FormTraCuuTK(this);
            a.Show();
        }

        private void btnsuagv_Click(object sender, EventArgs e)
        {
            string magv = txtmagv.Text.Trim();
            string tengv = txttengv.Text.Trim();
            string namsinh = dtpnamsinhgv.Value.ToString("yyyy-MM-dd");
            string gt = cbgioitinhgv.Text;
            string ngayvaolam = dtpngayvaolam.Value.ToString("yyyy-MM-dd");
            string diachi = txtdiachigv.Text.Trim();
            string sdt = txtsdtgv.Text.Trim();
            string chuyenmon = cbchuyenmongv.Text.Trim();
            if (checkHoTen(tengv) && checkngaysinh(namsinh) && checkDiaChi(diachi) && checkSoDienThoai(sdt) && checkNgayVaoLam(ngayvaolam))
            {
                if (giaovien.updateGiaoVien(magv, tengv, namsinh, gt, ngayvaolam, sdt, diachi, chuyenmon) > 0)
                {
                    MessageBox.Show("Sửa thông tin giáo viên thành công", "Thông báo", MessageBoxButtons.OK);
                    lamMoi();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin thất bại. Vui lòng kiểm tra lại thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sửa thông tin thất bại.Vui lòng kiểm tra lại thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoagv_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa giáo viên "+txtmagv.Text+": "+txttengv.Text+ "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                if (giaovien.deleteGiaoVien(txtmagv.Text) > 0)
                {
                    MessageBox.Show("Xóa thông tin giáo viên thành công", "Thông báo", MessageBoxButtons.OK);
                    lamMoi();
                }
                else
                {
                    MessageBox.Show("Xóa thông tin thất bại.Vui lòng kiểm tra lại thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Xóa thông tin thất bại.Vui lòng kiểm tra lại thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
