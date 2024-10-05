using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnKiemThu
{
    public partial class FormTrangChuAdmin : Form
    {
        public FormTrangChuAdmin()
        {
            InitializeComponent();
            RoundCorners(panel5, 10);
            quanLyDayHoc1.BringToFront();
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

        private void btnQuanLyDayHoc_Click(object sender, EventArgs e)
        {
            quanLyDayHoc1.BringToFront();
        }

        private void btnQuanLyDiem_Click(object sender, EventArgs e)
        {
            nhapDiem1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            xemDiem1.BringToFront();
        }

        private void btnQuanLyHocSinh_Click(object sender, EventArgs e)
        {
            quanLyHocSinh1.BringToFront();
        }

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            quanLyTaiKhoan1.BringToFront();
        }

        private void btnQuanLyGiaoVien_Click(object sender, EventArgs e)
        {
            quanLyGiaoVien1.BringToFront();
        }

        private void btnQuanLyLop_Click(object sender, EventArgs e)
        {
            quanLyLop1.BringToFront();
        }

        private void btnQuanLyMonHoc_Click(object sender, EventArgs e)
        {
            quanLyMonHoc2.BringToFront();
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            FormQuanLyDangNhap dn = new FormQuanLyDangNhap();
            this.Close();
            dn.Show();

        }

        private void btnKhoaHoc_Click(object sender, EventArgs e)
        {
            quanLyKhoaHoc1.BringToFront();
        }
    }
}
