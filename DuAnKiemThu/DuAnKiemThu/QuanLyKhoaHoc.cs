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
    public partial class QuanLyKhoaHoc : UserControl
    {
        DAOKhoaHoc khoahoc = new DAOKhoaHoc();
        DataTable dtkhoahoc = new DataTable();
        public QuanLyKhoaHoc()
        {
            InitializeComponent();
            loadDL();
        }

        private void loadDL()
        {
            txtMaKhoaHoc.Text = "";
            txtTenKhoaHoc.Text = "";
            lbloiMaKhoaHoc.Text = "";
            lbloiTenKhoaHoc.Text = "";
            lbLoiTinhTrang.Text = "";
            dtkhoahoc.Rows.Clear();
            dtkhoahoc = khoahoc.getAllKhoaHoc();
            dgvKhoaHoc.DataSource = dtkhoahoc;
        }

        private bool checkMaKhoaHoc(string makh)
        {
            if (makh.Length <= 0)
            {
                lbloiMaKhoaHoc.Text = "Mã khóa học không được để trống";
                return false;
            }
            else if (khoahoc.checkTrungKhoaHoc(makh) > 0)
            {
                lbloiMaKhoaHoc.Text = "Mã khóa học đã tồn tại";
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(makh, @"^[a-zA-Z0-9]+$"))
            {
                lbloiMaKhoaHoc.Text = "Mã khóa học chỉ bao gồm chữ và số";
                return false;
            }
            else
            {
                lbloiMaKhoaHoc.Text = "";
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

        private bool checkTenKhoaHoc(string ten)
        {
            if (ten.Length == 0)
            {
                lbloiTenKhoaHoc.Text = "Tên khóa học không được để trống";
                return false;
            }
            else if (khoahoc.checkTrungTenKhoaHoc(ten) > 0)
            {
                lbloiTenKhoaHoc.Text = "Tên khóa học đã tồn tại";
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(ten, @"^[a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềếềểễệỉịọỏốồổỗộớờởỡợụủứừửữựỳỵỷỹ\s0-9]+$"))
            {
                lbloiTenKhoaHoc.Text = "Tên khóa học chỉ được phép nhập chữ và số";
                return false;
            }
            else
            {
                lbloiTenKhoaHoc.Text = "";
                return true;
            }
        }

        private bool checkSuaMaKhoaHoc(string ma)
        {
            if(!string.Equals(ma, makhoahoc, StringComparison.Ordinal))
            {
                lbloiMaKhoaHoc.Text = "Không được phép sửa mã khóa học";
                txtMaKhoaHoc.Text = makhoahoc;
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnLamMoiKhoaHoc_Click(object sender, EventArgs e)
        {
            loadDL();
        }

        private void btnThemKhoaHoc_Click(object sender, EventArgs e)
        {
            string makhoahoc = txtMaKhoaHoc.Text.Trim();
            string tenkhoahoc = txtTenKhoaHoc.Text.Trim();
            tenkhoahoc = chuanhoaTen(tenkhoahoc);
            string tinhtrang = cbTinhTrangKhoaHoc.Text.Trim();
            if (checkMaKhoaHoc(makhoahoc) && checkTenKhoaHoc(tenkhoahoc))
            {
                if (khoahoc.insertKhoaHoc(makhoahoc, tenkhoahoc, tinhtrang) > 0)
                {
                    MessageBox.Show("Thêm thông tin khóa học thành công", "Thông báo", MessageBoxButtons.OK);
                    loadDL();
                }
                else
                {
                    MessageBox.Show("Thêm thông tin khóa học thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thêm thông tin khóa học thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaKhoaHoc_Click(object sender, EventArgs e)
        {
            string makhoahoc = txtMaKhoaHoc.Text.Trim();
            string tenkhoahoc = txtTenKhoaHoc.Text.Trim();
            tenkhoahoc = chuanhoaTen(tenkhoahoc);
            string tinhtrang = cbTinhTrangKhoaHoc.Text.Trim();
            if (checkSuaMaKhoaHoc(makhoahoc) && checkTenKhoaHoc(tenkhoahoc))
            {
                if (khoahoc.updateKhoaHoc(makhoahoc, tenkhoahoc, tinhtrang) > 0)
                {
                    MessageBox.Show("Sửa thông tin khóa học thành công", "Thông báo", MessageBoxButtons.OK);
                    loadDL();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin khóa học thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sửa thông tin khóa học thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaKhoaHoc_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa khóa " + txtMaKhoaHoc.Text + ": " + txtTenKhoaHoc.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == kq)
            {
                if (khoahoc.deleteKhoaHoc(txtMaKhoaHoc.Text) > 0)
                {
                    MessageBox.Show("Xóa thông tin khóa học thành công", "Thông báo", MessageBoxButtons.OK);
                    loadDL();
                }
                else
                {
                    MessageBox.Show("Xóa thông tin khóa học thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Xóa thông tin khóa học thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int dongdangchon;
        string makhoahoc;
        private void dgvKhoaHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dongdangchon = e.RowIndex;
                txtMaKhoaHoc.Text = dgvKhoaHoc.Rows[dongdangchon].Cells[0].Value.ToString();
                txtTenKhoaHoc.Text = dgvKhoaHoc.Rows[dongdangchon].Cells[1].Value.ToString();
                cbTinhTrangKhoaHoc.Text = dgvKhoaHoc.Rows[dongdangchon].Cells[2].Value.ToString();
                makhoahoc = dgvKhoaHoc.Rows[dongdangchon].Cells[0].Value.ToString();
            }
        }
    }
}
