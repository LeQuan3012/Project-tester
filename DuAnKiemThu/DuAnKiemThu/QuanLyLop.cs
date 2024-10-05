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
    public partial class QuanLyLop : UserControl
    {
        DAOLop lop = new DAOLop();
        DAOKhoaHoc khoahoc = new DAOKhoaHoc();
        DataTable dtlop = new DataTable();
        DataTable dtkhoahoc = new DataTable();
        DataTable dtgiovien = new DataTable();
        DAOGiaoVien giaoVien = new DAOGiaoVien();
        public QuanLyLop()
        {
            InitializeComponent();
            loadDL();
        }

        private void loadDL()
        {
            txtmalop.Text = "";
            lbloimalop.Text = "";
            lbloitenlop.Text = "";
            lbloinamhoc.Text = "";
            lbloilopgvcn.Text = "";
            lbloilopkhoa.Text = "";
            lbloilopslhs.Text = "";
            txttenlop.Text = "";
            txtslhs.Text = "";
            dtlop.Rows.Clear();
            dtlop = lop.getAllLop();
            dgvLop.DataSource = dtlop;

            dtkhoahoc.Rows.Clear();
            dtkhoahoc = khoahoc.getTenKhoaHoc();
            cblockhoa.DataSource = dtkhoahoc;
            cblockhoa.DisplayMember = "TenKhoa";
            cblockhoa.ValueMember = "TenKhoa";

            cbkhoalop.DataSource = dtkhoahoc;
            cbkhoalop.DisplayMember = "TenKhoa";
            cbkhoalop.ValueMember = "TenKhoa";

            dtgiovien.Rows.Clear();
            dtgiovien = giaoVien.getAllTenGiaoVien();
            cblopgvcn.DataSource = dtgiovien;
            cblopgvcn.DisplayMember = "TenGiaoVien";
            cblopgvcn.ValueMember = "TenGiaoVien";
        }

        private void btnloclop_Click(object sender, EventArgs e)
        {
            string ndtimkiem = cblockhoa.Text;
            dtlop.Rows.Clear();
            dtlop = lop.getLocLop(ndtimkiem);
            dgvLop.DataSource = dtlop;
        }

        private void btnlammoilop_Click(object sender, EventArgs e)
        {
            loadDL();
        }

        private bool checkMaLop(string malop)
        {
            if (malop.Length == 0)
            {
                lbloimalop.Text = "Mã lớp không được để trống";
                return false;
            }
            else if (lop.checkTrungMaLop(malop) > 0)
            {
                lbloimalop.Text = "Mã lớp đã tồn tại";
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(malop, @"^[a-zA-Z0-9]+$"))
            {
                lbloimalop.Text = "Mã lớp chỉ bao gồm chữ và số, không được chứa ký tự đặc biệt hoặc khoảng trắng";
                return false;
            }
            else
            {
                lbloimalop.Text = "";
                return true;
            }
        }

        private bool checkTenLop(string tenlop)
        {
            if (tenlop.Length == 0)
            {
                lbloitenlop.Text = "Tên lớp không được để trống";
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(tenlop, @"^[a-zA-Z0-9]+$"))
            {
                lbloitenlop.Text = "Tên lớp chỉ bao gồm chữ và số, không được chứa ký tự đặc biệt hoặc khoảng trắng";
                return false;
            }
            else
            {
                lbloitenlop.Text = "";
                return true;
            }
        }

        private bool checkNamHoc(string namhoc)
        {
            if (namhoc.Length == 0)
            {
                lbloinamhoc.Text = "Vui lòng nhập năm học";
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(namhoc, @"^\d{4}-\d{4}$"))
            {
                lbloinamhoc.Text = "Năm học phải là 1 số có dạng yyyy-yyyy";
                return false;
            }
            else
            {
                lbloinamhoc.Text = "";
                return true;
            }
        }

        private bool checkGVCN(string gv)
        {
            if (gv.Length <= 0)
            {
                lbloilopgvcn.Text = "Vui lòng chọn GVCN";
                return false;
            }
            lbloilopgvcn.Text = "";
            return true;
        }

        private bool checkKhoaHoc(string khoahoc)
        {
            if (khoahoc.Length <= 0)
            {
                lbloilopkhoa.Text = "Vui lòng chọn khóa học";
                return false;
            }
            lbloilopkhoa.Text = "";
            return true;
        }

        private bool checkThem(string malop, string tenlop, string namhoc, string khoa, string gvcn)
        {
            bool check = true;
            if (!checkMaLop(malop))
            {
                check = false;
            }
            if (!checkTenLop(tenlop))
            {
                check = false;
            }
            if (!checkNamHoc(namhoc))
            {
                check = false;
            }
            if (!checkKhoaHoc(khoa))
            {
                check = false;
            }
            if (!checkGVCN(gvcn))
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

        private void btnthemlop_Click(object sender, EventArgs e)
        {
            string malop = txtmalop.Text.Trim();
            string tenlop = txttenlop.Text.Trim();
            string namhoc = txtNamHoc.Text.Trim();
            string khoa = cbkhoalop.Text.Trim();
            khoa = khoahoc.getMaKhoaHoc(khoa);
            string gvcn = cblopgvcn.Text.Trim();
            gvcn = giaoVien.getMaGV(gvcn);
            if (checkThem(malop, tenlop, namhoc, khoa, gvcn))
            {
                if (lop.insertLop(malop, tenlop, namhoc, khoa, gvcn) > 0)
                {
                    MessageBox.Show("Thêm thông tin lớp thành công", "Thông báo", MessageBoxButtons.OK);
                    loadDL();
                }
                else
                {
                    MessageBox.Show("Thêm thông tin lớp thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thêm thông tin lớp thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool checkSuaMaLop(string malopa)
        {
            if(!string.Equals(malopa, malop, StringComparison.Ordinal))
            {
                lbloimalop.Text = "Mã lớp không được sửa";
                txtmalop.Text = malop;
                return false;
            }
            else
            {
                lbloimalop.Text = "";
                return true;
            }
        }

        private void btnsualop_Click(object sender, EventArgs e)
        {
            string malop = txtmalop.Text.Trim();
            string tenlop = txttenlop.Text.Trim();
            string namhoc = txtNamHoc.Text.Trim();
            string khoa = cbkhoalop.Text.Trim();
            khoa = khoahoc.getMaKhoaHoc(khoa);
            string gvcn = cblopgvcn.Text.Trim();
            gvcn = giaoVien.getMaGV(gvcn);
            if(checkSuaMaLop(malop) && checkTenLop(tenlop) && checkNamHoc(namhoc))
            {
                if(lop.updateLop(malop,tenlop, namhoc, khoa, gvcn) > 0)
                {
                    MessageBox.Show("Sửa thông tin lớp thành công", "Thông báo", MessageBoxButtons.OK);
                    loadDL();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin lớp thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sửa thông tin lớp thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        int dongdangchon;
        string malop;
        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                dongdangchon = e.RowIndex;
                txtmalop.Text = dgvLop.Rows[dongdangchon].Cells[0].Value.ToString();
                txttenlop.Text = dgvLop.Rows[dongdangchon].Cells[1].Value.ToString();
                txtNamHoc.Text = dgvLop.Rows[dongdangchon].Cells[2].Value.ToString();
                cblopgvcn.Text = dgvLop.Rows[dongdangchon].Cells[3].Value.ToString();
                txtslhs.Text = dgvLop.Rows[dongdangchon].Cells[4].Value.ToString();
                malop = dgvLop.Rows[dongdangchon].Cells[0].Value.ToString();
            }
        }
    }
}
