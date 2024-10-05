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
    public partial class FormTraCuuTK : Form
    {
        DAOTaiKhoan tk = new DAOTaiKhoan();
        DataTable dttknew = new DataTable();
        QuanLyGiaoVien gv;

        public FormTraCuuTK(QuanLyGiaoVien ql)
        {
            InitializeComponent();
            gv = ql;
            loadDL();
        }

        private void loadDL()
        {
            dttknew.Rows.Clear();
            dttknew = tk.getALlTKNew();
            dgvDSTKmoiTao.DataSource = dttknew;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadDL();
        }

        private void dgvDSTKmoiTao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               string tendn = dgvDSTKmoiTao.Rows[e.RowIndex].Cells[0].Value.ToString();
               gv.dienMaGV(tendn);
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đúng dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
