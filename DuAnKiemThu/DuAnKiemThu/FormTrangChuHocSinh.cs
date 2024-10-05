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
    public partial class FormTrangChuHocSinh : Form
    {
        public FormTrangChuHocSinh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xemDiem1.BringToFront();
        }

        private void btnXemThongTinHocSinh_Click(object sender, EventArgs e)
        {
            xemThongTinHocSinh1.BringToFront();
        }

        private void btnXemThongTinLop_Click(object sender, EventArgs e)
        {
            xemThongTinLop1.BringToFront();
        }

        private void btnXemThongTinMonHoc_Click(object sender, EventArgs e)
        {
            xemThongTinMonHochs1.BringToFront();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FormQuanLyDangNhap dn = new FormQuanLyDangNhap();
            this.Close();
            dn.Show();
        }
    }
}
