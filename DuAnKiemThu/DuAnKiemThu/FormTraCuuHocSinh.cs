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
    public partial class FormTraCuuHocSinh : Form
    {
        DAOTaiKhoan taikhoan = new DAOTaiKhoan();
        DataTable dttaikhoan = new DataTable();
        QuanLyHocSinh qlhs;

        public FormTraCuuHocSinh(QuanLyHocSinh ql)
        {
            InitializeComponent();
            loadDL();
            qlhs = ql;
        }

        private void loadDL()
        {
            dttaikhoan.Rows.Clear();
            dttaikhoan = taikhoan.getALlTKNewHS();
            dgvDSTKmoiTaoHS.DataSource = dttaikhoan;
        }

        private void btnLamMoiHS_Click(object sender, EventArgs e)
        {

        }
        int dongdangchon = -1;
        private void dgvDSTKmoiTaoHS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dongdangchon = e.RowIndex;
                string ma = dgvDSTKmoiTaoHS.Rows[dongdangchon].Cells[0].Value.ToString();
                qlhs.setTenDangNhap(ma);
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đúng dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
