using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnKiemThu
{
    public partial class QuanLyDayHoc : UserControl
    {
        DataTable dtdayhoc = new DataTable();
        DataTable dtmonhoc = new DataTable();
        DataTable dtgiaovien = new DataTable();
        DataTable dtlop = new DataTable();
        DataTable dtchuyenmon = new DataTable();
        DAODayHoc dayhoc = new DAODayHoc();
        DAOLop lop = new DAOLop();
        DAOGiaoVien giaovien = new DAOGiaoVien();
        DAOMonHoc monhoc = new DAOMonHoc();
        public QuanLyDayHoc()
        {
            InitializeComponent();
            loadDL();
        }

        public void loadDL()
        {
            dtdayhoc.Rows.Clear();
            lbloimamonhoc.Text = "";
            lbloimagiaovien.Text = "";
            lbloilop.Text = "";
            lbloihocky.Text = "";
            lbloinamhoc.Text = "";

            dtdayhoc = dayhoc.getAllDayHoc();
            dgvdayhoc.DataSource = dtdayhoc;

            loadChuyenMon();
            loadMonhoc();
            
            loadMaLop();

        }

        public void loadMonhoc()
        {
            dtmonhoc.Rows.Clear();
            dtmonhoc = monhoc.getAllMaMonHoc();
            cbmamonhocdayhoc.DataSource = dtmonhoc;
            cbmamonhocdayhoc.DisplayMember = "MaMonHoc";
            cbmamonhocdayhoc.ValueMember = "MaMonHoc";
        }

        public void loadMaGiaoVien()
        {
            dtgiaovien.Rows.Clear();
            dtgiaovien = giaovien.getAllMaGiaoVien(cbchuyenmonloc.Text);
            cbmagvdayhoc.DataSource = dtgiaovien;
            cbmagvdayhoc.DisplayMember = "TenDangNhap";
            cbmagvdayhoc.ValueMember = "TenDangNhap";
        }

        public void loadMaLop()
        {
            dtlop.Rows.Clear();
            dtlop = lop.getAllMaLop();
            cblopdayhoc.DataSource = dtlop;
            cblopdayhoc.DisplayMember = "MaLop";
            cblopdayhoc.ValueMember = "MaLop";
        }

        public void loadChuyenMon()
        {
            dtchuyenmon.Rows.Clear();
            dtchuyenmon = giaovien.getAllChuyenMon();
            cbchuyenmonloc.DataSource = dtchuyenmon;
            cbchuyenmonloc.DisplayMember = "ChuyenMon";
            cbchuyenmonloc.ValueMember = "ChuyenMon";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string namhoc = cbtknamhoc.Text.Trim();
            string hk = cbtkhocky.Text.Trim();
            dtdayhoc.Rows.Clear();
            dtdayhoc = dayhoc.timKiemDayHoc(namhoc, hk);
            dgvdayhoc.DataSource = dtdayhoc;
        }

        private bool checkMaMH(string mamh)
        {
            if(mamh.Length <= 0)
            {
                lbloimamonhoc.Text = "Mã môn học không được bỏ trống";
                return false;
            }
            lbloimamonhoc.Text = "";
            return true;
        }

        private bool checkMaGV(string magv)
        {
            if(magv.Length <= 0)
            {
                lbloimagiaovien.Text = "Giáo viên không được bỏ trống";
            }
            lbloimagiaovien.Text = "";
            return true;
        }

        private bool checkHocKy(string hk)
        {
            if(hk.Length <= 0)
            {
                lbloihocky.Text = "Học kỳ không được bỏ trống";
                return false;
            }
            lbloihocky.Text = "";
            return true;
        }

        private bool checkNamHoc(string namhoc)
        {
            if(namhoc.Length <= 0)
            {
                lbloinamhoc.Text = "Năm học không được bỏ trống";
                return false;
            }
            lbloinamhoc.Text = "";
            return true;
        }

        private bool checkMaLop(string malop)
        {
            if(malop.Length <= 0)
            {
                lbloilop.Text = "Lớp không được bỏ trống";
                return false;
            }
            lbloilop.Text = "";
            return true;
        }

        public bool checkThem(string magv, string mamh, string hk, string namhoc, string malop)
        {
            bool check = true;
            if (!checkMaGV(magv))
            {
                check = false;
            }

            if (!checkMaMH(mamh))
            {
                check = false;
            }
            if (!checkHocKy(hk))
            {
                check = false;
            }
            if (!checkNamHoc(namhoc))
            {
                check = false;
            }
            if (!checkMaLop(malop))
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

        private void btnThemDayHoc_Click(object sender, EventArgs e)
        {
            string magv = cbmagvdayhoc.Text;
            string mamh = cbmamonhocdayhoc.Text;
            string hk = cbhockydayhoc.Text;
            string namhoc = cbnamhocdayhoc.Text;
            string malop = cblopdayhoc.Text;
            if(checkThem(magv, mamh, hk, namhoc, malop))
            {
                if(dayhoc.insertDayHoc(magv, mamh, hk, namhoc, malop) > 0)
                {
                    loadDL();
                    MessageBox.Show("Thêm thông tin dạy học thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Thêm thông tin dạy học thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thêm thông tin dạy học thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaDayHoc_Click(object sender, EventArgs e)
        {
            string magv = cbmagvdayhoc.Text;
            string mamh = cbmamonhocdayhoc.Text;
            string hk = cbhockydayhoc.Text;
            string namhoc = cbnamhocdayhoc.Text;
            string malop = cblopdayhoc.Text;
            if(checkThem(magv, mamh, hk, namhoc, malop))
            {
                if(dayhoc.updateDayHoc(magv, mamh, hk, namhoc, malop, tendncheck, mamhcheck, hkcheck, malopcheck, namhoccheck) > 0)
                {
                    loadDL();
                    MessageBox.Show("Sửa thông tin dạy học thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Sửa thông tin dạy học thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sửa thông tin dạy học thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaDayHoc_Click(object sender, EventArgs e)
        {

        }

        private void cbmamonhocdayhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txttenmonhocdayhoc.Text = monhoc.getTenMon(cbmamonhocdayhoc.Text);
        }

        private void cbmagvdayhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txttengvdayhoc.Text = giaovien.getTenGV(cbmagvdayhoc.Text);
        }

        int ddc = -1;
        string tendncheck = "";
        string mamhcheck = "";
        string hkcheck = "";
        string namhoccheck = "";
        string malopcheck = "";
        private void dgvdayhoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ddc = e.RowIndex;
                cbmamonhocdayhoc.Text = dgvdayhoc.Rows[ddc].Cells[7].Value.ToString();
                txttenmonhocdayhoc.Text = dgvdayhoc.Rows[ddc].Cells[8].Value.ToString();
                cbmagvdayhoc.Text = dgvdayhoc.Rows[0].Cells[0].Value.ToString();
                txttengvdayhoc.Text = dgvdayhoc.Rows[ddc].Cells[1].Value.ToString();
                cblopdayhoc.Text = dgvdayhoc.Rows[ddc].Cells[4].Value.ToString();
                cbhockydayhoc.Text = dgvdayhoc.Rows[ddc].Cells[9].Value.ToString();
                cbnamhocdayhoc.Text = dgvdayhoc.Rows[ddc].Cells[10].Value.ToString();
                tendncheck = dgvdayhoc.Rows[0].Cells[0].Value.ToString();
                mamhcheck = dgvdayhoc.Rows[ddc].Cells[7].Value.ToString();
                hkcheck = dgvdayhoc.Rows[ddc].Cells[9].Value.ToString();
                namhoccheck = dgvdayhoc.Rows[ddc].Cells[10].Value.ToString();
                malopcheck = dgvdayhoc.Rows[ddc].Cells[4].Value.ToString();
            }
        }

        private void cbchuyenmonloc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            loadMaGiaoVien();
        }
    }
}
