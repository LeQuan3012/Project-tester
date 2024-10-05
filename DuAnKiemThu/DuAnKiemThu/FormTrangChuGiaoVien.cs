using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DuAnKiemThu
{
    public partial class FormTrangChuGiaoVien : Form
    {
        public FormTrangChuGiaoVien()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            xemDiem1.BringToFront();
        }

        private void btnXemThongTinMonHoc_Click(object sender, EventArgs e)
        {
            xemThongTinMonHoc1.BringToFront();
        }

        private void btnQuanLyHocSinh_Click(object sender, EventArgs e)
        {
            quanLyHocSinh1.BringToFront();
        }

        private void btnXemThongTinLop_Click(object sender, EventArgs e)
        {
            xemThongTinLop1.BringToFront();
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            nhapDiem1.BringToFront();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            taiKhoan1.BringToFront();
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            FormQuanLyDangNhap dn = new FormQuanLyDangNhap();
            this.Close();
            dn.Show();
        }
    }
}
