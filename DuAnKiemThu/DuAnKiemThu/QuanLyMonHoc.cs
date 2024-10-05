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
    public partial class QuanLyMonHoc : UserControl
    {
        DataTable dtmonhoc = new DataTable();
        DAOMonHoc monhoc = new DAOMonHoc();
        public QuanLyMonHoc()
        {
            InitializeComponent();
            loadDL();
            lbloimamonhoc.Text = "";
            lbloitenmonhoc.Text = "";
            lbloitinhtrangmonhoc.Text = "";
            cbtinhtrangMH.SelectedIndex = 0;
        }
        int stt = 1;
        private void loadDL()
        {
            stt = 1;
            dtmonhoc.Rows.Clear();
            dtmonhoc = monhoc.getAllMonHoc();
            dgvmonhoc.Rows.Clear();
            txtmamonhoc.Text = "";
            txttenmonhoc.Text = "";
            foreach (DataRow row in dtmonhoc.Rows)
            {
                dgvmonhoc.Rows.Add(stt++, row["MaMonHoc"], row["TenMonHoc"], row["TinhTrang"]);
            }
        }

        public bool checkMaMonHoc(string mamh)
        {
            if (mamh.Length <= 0)
            {
                lbloimamonhoc.Text = "Mã môn học không được để trống";
                return false;
            }
            else if (monhoc.checkMonHocDaThem(mamh) > 0)
            {
                lbloimamonhoc.Text = "Mã môn học đã tồn tại";
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(mamh, @"^[a-zA-Z0-9]+$"))
            {
                lbloimamonhoc.Text = "Mã môn học chỉ bao gồm chữ và số, không được chứa ký tự đặc biệt hoặc khoảng trắng";
                return false;
            }
            lbloimamonhoc.Text = "";
            return true;
        }

        public bool checkTenMon(string tenmon)
        {
            if (tenmon.Length <= 0)
            {
                lbloitenmonhoc.Text = "Tên môn học không được để trống";
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(tenmon, @"^[a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềếềểễệỉịọỏốồổỗộớờởỡợụủứừửữựỳỵỷỹ\s0-9]+$"))
            {
                lbloitenmonhoc.Text = "Tên môn học chỉ bao gồm chữ và số, không được chứa ký tự đặc biệt";
                return false;
            }
            lbloitenmonhoc.Text = "";
            return true;
        }

        private bool checktinhTrang(string tt)
        {
            if(tt.Length <= 0)
            {
                lbloitinhtrangmonhoc.Text = "Tình trạng không được bỏ trống";
                return false;
            }
            lbloitinhtrangmonhoc.Text = "";
            return true;
        }

        private void btnLamMoiMonHoc_Click(object sender, EventArgs e)
        {
            loadDL();
        }

        private bool checkThem(string mamh, string tenmon, string tt)
        {
            bool check = true;
            if (!checkMaMonHoc(mamh))
            {
                check = false;
            }
            if (!checkTenMon(tenmon))
            {
                check = false;
            }
            if (checktinhTrang(tt))
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

        private bool checkSua(string mamh, string tenmon)
        {
            bool check = true;
            if (!checksuaMaMonhoc(mamh))
            {
                check = false;
            }
            if (!checkTenMon(tenmon))
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
        private void btnLuuLaiMonHoc_Click(object sender, EventArgs e)
        {
            string mamh = txtmamonhoc.Text.Trim();
            string tenmon = txttenmonhoc.Text.Trim();
            string tinhtrang = cbtinhtrangMH.Text.Trim();
            if (checkThem(mamh, tenmon, tinhtrang))
            {
                if (monhoc.insertMonHoc(mamh, tenmon, tinhtrang) > 0)
                {
                    MessageBox.Show("Thêm thông tin môn học thành công", "Thông báo", MessageBoxButtons.OK);
                    loadDL();
                }
                else
                {
                    MessageBox.Show("Thêm thông tin môn học thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thêm thông tin môn học thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int dongdangchon;
        string mamonhoc;

        private void dgvmonhoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dongdangchon = e.RowIndex;
                txtmamonhoc.Text = dgvmonhoc.Rows[dongdangchon].Cells[1].Value.ToString();
                txttenmonhoc.Text = dgvmonhoc.Rows[dongdangchon].Cells[2].Value.ToString();
                cbtinhtrangMH.Text = dgvmonhoc.Rows[dongdangchon].Cells[3].Value.ToString();
                mamonhoc = dgvmonhoc.Rows[dongdangchon].Cells[1].Value.ToString();
                MessageBox.Show(mamonhoc);
            }
        }
        private bool checksuaMaMonhoc(string mamh)
        {
            if(!string.Equals(mamh, mamonhoc, StringComparison.Ordinal))
            {
                lbloimamonhoc.Text = "Vui lòng không được sửa mã môn học";
                return false;
            }
            return true;
        }

        private void btnSuaMonHoc_Click(object sender, EventArgs e)
        {
            string mamh = txtmamonhoc.Text.Trim();
            string tenmon = txttenmonhoc.Text.Trim();
            string tinhtrang = cbtinhtrangMH.Text.Trim();
            if(checkSua(mamh, tenmon))
            {
                if(monhoc.updateMonHoc(mamonhoc, tenmon, tinhtrang)>0)
                {
                    MessageBox.Show("Sửa thông tin môn học thành công", "Thông báo", MessageBoxButtons.OK);
                    loadDL();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin môn học thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sửa thông tin môn học thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaMonHoc_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa môn học " + mamonhoc + ": " + txttenmonhoc.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                if (monhoc.deleteMonHoc(mamonhoc) > 0)
                {
                    MessageBox.Show("Xóa thông tin môn học thành công", "Thông báo", MessageBoxButtons.OK);
                    loadDL();
                }
                else
                {
                    MessageBox.Show("Xóa thông tin môn học thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Xóa thông tin môn học thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
