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
    public partial class DangNhap : UserControl
    {
        private DAOTaiKhoan daotk = new DAOTaiKhoan();
        private System.Windows.Forms.Timer timer;
        private Color[] colors = { Color.Green, Color.Red, Color.Yellow };
        private int colorIndex = 0;
        public DangNhap()
        {
            InitializeComponent();
            RoundCorners(panel1, 15);
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 800;
            timer.Tick += Timer_Tick;
            Load += (sender, e) => timer.Start();
            lbloimatkhau.Text = "";
            lbloitendangnhap.Text = "";
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            label4.ForeColor = colors[colorIndex];
            colorIndex = (colorIndex + 1) % colors.Length;
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
        public event EventHandler OnClickQuenMK;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnClickQuenMK?.Invoke(this, EventArgs.Empty);
        }
        public event EventHandler OnClickDangKy;

        private void btndangky_Click(object sender, EventArgs e)
        {
            OnClickDangKy?.Invoke(this, EventArgs.Empty);
        }
        public event EventHandler OnClickDanhNhap;

        private bool checkLoiNhap(string tendn, string matkhau)
        {
            if(tendn.Length < 1 && matkhau.Length < 1)
            {
                lbloitendangnhap.Text = "Tên đăng nhập không được để trống";
                lbloimatkhau.Text = "Mật khẩu không được để trống";
                return false;
            }
            else if(tendn.Length < 1)
            {
                lbloitendangnhap.Text = "Tên đăng nhập không được để trống";
                lbloimatkhau.Text = "";
                return false;
            }
            else if(matkhau.Length < 1)
            {
                lbloimatkhau.Text = "Mật khẩu không được để trống";
                lbloitendangnhap.Text = "";
                return false;
            }
            else
            {
                lbloimatkhau.Text = "";
                lbloitendangnhap.Text = "";
                return true;
            }
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string tendn = txttendangnhap.Text;
            string matkhau = txtmatkhaudangnhap.Text;
            if(checkLoiNhap(tendn, matkhau))
            {
                int a = daotk.kiemTraDangNhap(tendn, matkhau);
                if (a > 0)
                {
                    string vaitro = daotk.getVaiTroDangNhap(tendn, matkhau);
                    if (vaitro == "Admin")
                    {
                        FormTrangChuAdmin admin = new FormTrangChuAdmin();
                        admin.ShowDialog();
                    }
                    else if (vaitro == "Giáo Viên")
                    {
                        FormTrangChuGiaoVien gv = new FormTrangChuGiaoVien();
                        gv.ShowDialog();
                    }
                    else
                    {
                        FormTrangChuHocSinh hs = new FormTrangChuHocSinh();
                        hs.ShowDialog();
                    }
                    OnClickDanhNhap?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    lbloitendangnhap.Text = "Vui lòng kiểm tra lại tên đăng nhập!";
                    lbloimatkhau.Text = "Vui lòng kiểm tra lại mật khẩu";
                }
            }           
        }
    }
}
