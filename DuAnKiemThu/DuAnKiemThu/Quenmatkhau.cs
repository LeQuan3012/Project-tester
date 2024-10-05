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
    public partial class Quenmatkhau : UserControl
    {
        public Quenmatkhau()
        {
            InitializeComponent();
            RoundCorners(panelktra, 15);
            RoundCorners(paneldoipass, 15);
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
        public event EventHandler OnClickQuayLai;

        private void button1_Click(object sender, EventArgs e)
        {
            OnClickQuayLai?.Invoke(this, EventArgs.Empty);
        }
    }
}
