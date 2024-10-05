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
    public partial class QuanLyTaiKhoan : UserControl
    {
        DAOTaiKhoan tk = new DAOTaiKhoan();
        DataTable dttk = new DataTable();
        DataTable dtalltk = new DataTable();
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            lbloimatkhau.Text = "";
            lbloitendangnhap.Text = "";
            lbloivaitro.Text = "";
            lbloitinhtrang.Text = "";
            cbtinhtrangqltk.SelectedIndex = 0;
            cbvaitroqltk.SelectedIndex = 2;
            loadVaiTro();
            loadDuLieuTK();
        }

        private void loadVaiTro()
        {
            dttk.Rows.Clear();
            dttk = tk.getAllVaiTro();
            cbloctaikhoan.DataSource = dttk;
            cbloctaikhoan.ValueMember = "VaiTro";
            cbloctaikhoan.DisplayMember = "VaiTro";
        }

        private void loadDuLieuTK()
        {
            dtalltk.Rows.Clear();
            dtalltk = tk.getAllTaiKhoan();
            dgvqltk.DataSource = dtalltk;
        }

        private void btntkloc_Click_1(object sender, EventArgs e)
        {
            dtalltk.Rows.Clear();
            dtalltk = tk.locTaiKhoan(cbloctaikhoan.Text);
            dgvqltk.DataSource = dtalltk;
        }

        private void btntklammoi_Click(object sender, EventArgs e)
        {
            loadDuLieuTK();
        }

        private bool checktendangnhap(string tendn)
        {
            bool check = true;
            if (tendn.Length == 0)
            {
                lbloitendangnhap.Text = "Tên đăng nhập không được để trống";
                return false;
            }
            else if (tk.getTenDangNhap(tendn) > 0)
            {
                lbloitendangnhap.Text = "Tên đăng nhập đã tồn tại";
                return false;
            }
            else if (tendn.Length < 6)
            {
                lbloitendangnhap.Text = "Tên đăng nhập phải có ít nhất 6 ký tự";
                return false;
            }
            else if (!tendn.Any(char.IsUpper))
            {
                lbloitendangnhap.Text = "Tên đăng nhập phải có ít nhất một chữ cái viết hoa";
                return false;
            }
            else if (!tendn.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                lbloitendangnhap.Text = "Tên đăng nhập phải có ít nhất một ký tự đặc biệt";
                return false;
            }
            else
            {
                return true;
            }

        }

        private bool checktendangnhapsua(string tendn)
        {
            bool check = true;
            if (tendn.Length == 0)
            {
                lbloitendangnhap.Text = "Tên đăng nhập không được để trống";
                return false;
            }
            else if (tendn.Length < 6)
            {
                lbloitendangnhap.Text = "Tên đăng nhập phải có ít nhất 6 ký tự";
                return false;
            }
            else if (!tendn.Any(char.IsUpper))
            {
                lbloitendangnhap.Text = "Tên đăng nhập phải có ít nhất một chữ cái viết hoa";
                return false;
            }
            else if (!tendn.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                lbloitendangnhap.Text = "Tên đăng nhập phải có ít nhất một ký tự đặc biệt";
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btnthemtk_Click(object sender, EventArgs e)
        {
            if (checktendangnhap(tbtendangnhapqltk.Text.Trim()) && checkmatkhau(tbmatkhauqltk.Text.Trim()) && checkvaitro(cbvaitroqltk.Text) && checktinhtrang(cbtinhtrangqltk.Text))
            {
                //MessageBox.Show(tbtendangnhapqltk.Text.Trim() + ", " + tbmatkhauqltk.Text.Trim() + ", " + cbvaitroqltk.Text + ", " + cbtinhtrangqltk.Text);
                if (tk.insertTaiKhoan(tbtendangnhapqltk.Text.Trim(), tbmatkhauqltk.Text.Trim(), cbvaitroqltk.Text, "Chưa kích hoạt") > 0)
                {
                    MessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
                    loadDuLieuTK();
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại. Vui lòng kiểm tra lại thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại. Vui lòng kiểm tra lại thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tbtendangnhapqltk_TextChanged(object sender, EventArgs e)
        {
            string tendn = tbtendangnhapqltk.Text.Trim();
            if (checktendangnhap(tendn))
            {
                lbloitendangnhap.Text = "";
            }
        }

        private bool checkmatkhau(string mk)
        {
            bool check = true;
            if (mk.Length == 0)
            {
                lbloimatkhau.Text = "Mật khẩu không được để trống";
                return false;
            }
            else if (mk.Length < 6)
            {
                lbloimatkhau.Text = "Mật khẩu không được nhỏ hơn 6 ký tự";
                return false;
            }
            else if (!mk.Any(char.IsDigit))
            {
                lbloimatkhau.Text = "Mật khẩu phải có ít nhất một số";
                return false;
            }
            else if (!mk.Any(char.IsUpper))
            {
                lbloimatkhau.Text = "Mật khẩu phải có ít nhất một ký tự viết hoa";
                return false;
            }
            else if (!mk.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                lbloimatkhau.Text = "Mật khẩu phải có ít nhất một ký tự đặc biệt";
                return false;
            }
            else
            {
                return true;
            }
        }


        private void tbmatkhauqltk_TextChanged(object sender, EventArgs e)
        {
            string mk = tbmatkhauqltk.Text.Trim();
            if (checkmatkhau(mk))
            {
                lbloimatkhau.Text = "";
            }
        }

        private bool checkvaitro(string vaitro)
        {
            bool check = true;
            if (vaitro.Length == 0)
            {
                lbloivaitro.Text = "Vai trò tài khoản không được để trống";
                return false;
            }
            else
            {
                return true;
            }
        }

        private void cbvaitroqltk_SelectedIndexChanged(object sender, EventArgs e)
        {
            string vaitro = cbvaitroqltk.Text.Trim();
            if (checkvaitro(vaitro))
            {
                lbloivaitro.Text = "";
            }
        }

        private bool checktinhtrang(string tinhtrang)
        {
            bool check = true;
            if (tinhtrang.Length == 0)
            {
                lbloivaitro.Text = "Tình trạng tài khoản không được để trống";
                return false;
            }
            else
            {
                return true;
            }
        }

        private void cbtinhtrangqltk_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tinhtrang = cbtinhtrangqltk.Text.Trim();
            if (checktinhtrang(tinhtrang))
            {
                lbloivaitro.Text = "";
            }
        }
        int dongdangchon;
        private void dgvqltk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dongdangchon = e.RowIndex;
            if (dongdangchon >= 0)
            {
                tbtendangnhapqltk.Text = dgvqltk.Rows[dongdangchon].Cells[0].Value.ToString();
                cbvaitroqltk.Text = dgvqltk.Rows[dongdangchon].Cells[1].Value.ToString();
                cbtinhtrangqltk.Text = dgvqltk.Rows[dongdangchon].Cells[2].Value.ToString();
                lbloitendangnhap.Text = "";
                tbmatkhauqltk.Text = tk.getMatKhau(tbtendangnhapqltk.Text);
                lbloimatkhau.Text = "";
            }
        }

        private void btnsuatk_Click(object sender, EventArgs e)
        {
            string tendncu = dgvqltk.Rows[dongdangchon].Cells[0].Value.ToString();
            string tentk = tbtendangnhapqltk.Text.Trim();
            string mk = tbmatkhauqltk.Text.Trim();
            string vaitro = cbvaitroqltk.Text.Trim();
            string tinhtrang = cbtinhtrangqltk.Text.Trim();

            if (checktendangnhapsua(tbtendangnhapqltk.Text.Trim()) && checkmatkhau(tbmatkhauqltk.Text.Trim()) && checkvaitro(cbvaitroqltk.Text) && checktinhtrang(cbtinhtrangqltk.Text))
            {
                MessageBox.Show(tendncu);
                if (tk.updateTaiKhoan(tentk, mk, vaitro, tinhtrang, tendncu) > 0)
                {
                    MessageBox.Show("Chỉnh sửa tài khoản thành công");
                    loadDuLieuTK();
                }
                else
                {
                    MessageBox.Show("Lỗi không sửa được tài khoản. Vui lòng kiểm tra lại thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không thể sửa tài khoản. Vui lòng kiểm tra lại thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoatk_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản " + tbtendangnhapqltk.Text + "này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (tk.deleteTaiKhoan(tbtendangnhapqltk.Text) > 0)
                {
                    MessageBox.Show("Bạn đã xóa tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
                    tbtendangnhapqltk.Text = "";
                    tbmatkhauqltk.Text = "";
                    lbloimatkhau.Text = "";
                    lbloitendangnhap.Text = "";
                    loadDuLieuTK();
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản thất bại. Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
