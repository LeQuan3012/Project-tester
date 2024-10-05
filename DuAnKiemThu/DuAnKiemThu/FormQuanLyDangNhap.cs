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
    public partial class FormQuanLyDangNhap : Form
    {
        private DAOTaiKhoan taikhoan = new DAOTaiKhoan();
        public FormQuanLyDangNhap()
        {
            InitializeComponent();
            dangNhap1.BringToFront();
            dangNhap1.OnClickQuenMK += DangNhap1_OnClick;
            dangNhap1.OnClickDangKy += DangNhap1_OnClickDangKy;
            dangNhap1.OnClickDanhNhap += DangNhap1_OnClickDanhNhap;
        }

        private void DangNhap1_OnClickDangKy(object? sender, EventArgs e)
        {
            dangKy1.BringToFront();
            this.Text = "Đăng ký tài khoản";
            dangKy1.OnClickQuayLai += DangKy1_OnClickQuayLai;
        }

        private void DangKy1_OnClickQuayLai(object? sender, EventArgs e)
        {
            dangNhap1.BringToFront();
            this.Text = "Đăng nhập";
        }

        private void DangNhap1_OnClickDanhNhap(object? sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void DangNhap1_OnClick(object? sender, EventArgs e)
        {
            quenmatkhau1.BringToFront();
            this.Text = "Quên mật khẩu";
            quenmatkhau1.OnClickQuayLai += Quenmatkhau1_OnClickQuayLai;
        }

        private void Quenmatkhau1_OnClickQuayLai(object? sender, EventArgs e)
        {
            dangNhap1.BringToFront();
            this.Text = "Đăng nhập";
        }
    }
}
