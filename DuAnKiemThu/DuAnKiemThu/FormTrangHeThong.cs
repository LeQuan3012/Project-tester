using System.Drawing;
namespace DuAnKiemThu
{
    public partial class FormTrangHeThong : Form
    {
        private System.Windows.Forms.Timer timer;
        private Color[] colors = { Color.Green, Color.Black, Color.Red, Color.Purple };
        private int colorIndex = 0;
        public FormTrangHeThong()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            Load += (sender, e) => timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            lbhethong.ForeColor = colors[colorIndex];
            btnbatdau.BackColor = colors[colorIndex];
            colorIndex = (colorIndex + 1) % colors.Length;
        }

        private void btnbatdau_MouseEnter(object sender, EventArgs e)
        {
            btnbatdau.Font = new Font(btnbatdau.Font, FontStyle.Underline);
        }

        private void btnbatdau_MouseLeave(object sender, EventArgs e)
        {
            btnbatdau.Font = new Font(btnbatdau.Font, FontStyle.Regular);
        }

        private void btnbatdau_Click(object sender, EventArgs e)
        {

            FormQuanLyDangNhap formDN = new FormQuanLyDangNhap();
            this.Hide();
            formDN.Show();
            
        }

    }
}