namespace DuAnKiemThu
{
    partial class FormTrangChuHocSinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            btnXemThongTinHocSinh = new Button();
            btnXemThongTinLop = new Button();
            btnXemThongTinMonHoc = new Button();
            panel2 = new Panel();
            btnDangXuat = new Button();
            panel5 = new Panel();
            pictureBox7 = new PictureBox();
            lbhoten = new Label();
            panel1 = new Panel();
            xemThongTinMonHochs1 = new XemThongTinMonHocHS();
            taiKhoan1 = new TaiKhoan();
            xemThongTinMonHoc1 = new XemThongTinMonHoc();
            xemThongTinLop1 = new XemThongTinLop();
            xemThongTinHocSinh1 = new XemThongTinHocSinh();
            xemDiem1 = new XemDiem();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(274, 659);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.5074635F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.49254F));
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Controls.Add(btnXemThongTinHocSinh, 1, 2);
            tableLayoutPanel1.Controls.Add(btnXemThongTinLop, 1, 4);
            tableLayoutPanel1.Controls.Add(btnXemThongTinMonHoc, 1, 6);
            tableLayoutPanel1.Controls.Add(panel2, 1, 12);
            tableLayoutPanel1.Controls.Add(panel5, 1, 11);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 23);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 13;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 3.63349128F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.688784F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.10742474F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.846762F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.89731455F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.530806F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.265403F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.688784F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.58135843F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.320695F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.3254337F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tableLayoutPanel1.Size = new Size(268, 633);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.AccessibleDescription = "btnXemDiem";
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(66, 3);
            button1.Name = "button1";
            button1.Size = new Size(199, 43);
            button1.TabIndex = 0;
            button1.Text = "Xem điểm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnXemThongTinHocSinh
            // 
            btnXemThongTinHocSinh.Dock = DockStyle.Fill;
            btnXemThongTinHocSinh.Location = new Point(66, 75);
            btnXemThongTinHocSinh.Name = "btnXemThongTinHocSinh";
            btnXemThongTinHocSinh.Size = new Size(199, 49);
            btnXemThongTinHocSinh.TabIndex = 1;
            btnXemThongTinHocSinh.Text = "Xem thông tin học sinh";
            btnXemThongTinHocSinh.UseVisualStyleBackColor = true;
            btnXemThongTinHocSinh.Click += btnXemThongTinHocSinh_Click;
            // 
            // btnXemThongTinLop
            // 
            btnXemThongTinLop.Dock = DockStyle.Fill;
            btnXemThongTinLop.Location = new Point(66, 156);
            btnXemThongTinLop.Name = "btnXemThongTinLop";
            btnXemThongTinLop.Size = new Size(199, 50);
            btnXemThongTinLop.TabIndex = 2;
            btnXemThongTinLop.Text = "Xem thông tin lớp";
            btnXemThongTinLop.UseVisualStyleBackColor = true;
            btnXemThongTinLop.Click += btnXemThongTinLop_Click;
            // 
            // btnXemThongTinMonHoc
            // 
            btnXemThongTinMonHoc.Dock = DockStyle.Fill;
            btnXemThongTinMonHoc.Location = new Point(66, 243);
            btnXemThongTinMonHoc.Name = "btnXemThongTinMonHoc";
            btnXemThongTinMonHoc.Size = new Size(199, 48);
            btnXemThongTinMonHoc.TabIndex = 3;
            btnXemThongTinMonHoc.Text = "Xem thông tin môn học";
            btnXemThongTinMonHoc.UseVisualStyleBackColor = true;
            btnXemThongTinMonHoc.Click += btnXemThongTinMonHoc_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDangXuat);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(66, 583);
            panel2.Name = "panel2";
            panel2.Size = new Size(199, 47);
            panel2.TabIndex = 7;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Location = new Point(47, 8);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(94, 29);
            btnDangXuat.TabIndex = 0;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 224, 192);
            panel5.Controls.Add(pictureBox7);
            panel5.Controls.Add(lbhoten);
            panel5.Location = new Point(66, 467);
            panel5.Name = "panel5";
            panel5.Size = new Size(199, 110);
            panel5.TabIndex = 8;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.png_clipart_computer_icons_user_icon_design_scalable_graphics_personal_check_information_angle_logo_thumbnail;
            pictureBox7.Location = new Point(77, 6);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(40, 41);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            // 
            // lbhoten
            // 
            lbhoten.AutoSize = true;
            lbhoten.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbhoten.Location = new Point(48, 57);
            lbhoten.Name = "lbhoten";
            lbhoten.Size = new Size(109, 23);
            lbhoten.TabIndex = 1;
            lbhoten.Text = "Lê Văn Quân";
            // 
            // panel1
            // 
            panel1.Controls.Add(xemThongTinMonHochs1);
            panel1.Controls.Add(taiKhoan1);
            panel1.Controls.Add(xemThongTinMonHoc1);
            panel1.Controls.Add(xemThongTinLop1);
            panel1.Controls.Add(xemThongTinHocSinh1);
            panel1.Controls.Add(xemDiem1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(274, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(738, 659);
            panel1.TabIndex = 1;
            // 
            // xemThongTinMonHochs1
            // 
            xemThongTinMonHochs1.Dock = DockStyle.Fill;
            xemThongTinMonHochs1.Location = new Point(0, 0);
            xemThongTinMonHochs1.Name = "xemThongTinMonHochs1";
            xemThongTinMonHochs1.Size = new Size(738, 659);
            xemThongTinMonHochs1.TabIndex = 5;
            // 
            // taiKhoan1
            // 
            taiKhoan1.Dock = DockStyle.Fill;
            taiKhoan1.Location = new Point(0, 0);
            taiKhoan1.Name = "taiKhoan1";
            taiKhoan1.Size = new Size(738, 659);
            taiKhoan1.TabIndex = 4;
            // 
            // xemThongTinMonHoc1
            // 
            xemThongTinMonHoc1.Dock = DockStyle.Fill;
            xemThongTinMonHoc1.Location = new Point(0, 0);
            xemThongTinMonHoc1.Name = "xemThongTinMonHoc1";
            xemThongTinMonHoc1.Size = new Size(738, 659);
            xemThongTinMonHoc1.TabIndex = 3;
            // 
            // xemThongTinLop1
            // 
            xemThongTinLop1.Dock = DockStyle.Fill;
            xemThongTinLop1.Location = new Point(0, 0);
            xemThongTinLop1.Name = "xemThongTinLop1";
            xemThongTinLop1.Size = new Size(738, 659);
            xemThongTinLop1.TabIndex = 2;
            // 
            // xemThongTinHocSinh1
            // 
            xemThongTinHocSinh1.Dock = DockStyle.Fill;
            xemThongTinHocSinh1.Location = new Point(0, 0);
            xemThongTinHocSinh1.Name = "xemThongTinHocSinh1";
            xemThongTinHocSinh1.Size = new Size(738, 659);
            xemThongTinHocSinh1.TabIndex = 1;
            // 
            // xemDiem1
            // 
            xemDiem1.Dock = DockStyle.Fill;
            xemDiem1.Location = new Point(0, 0);
            xemDiem1.Name = "xemDiem1";
            xemDiem1.Size = new Size(738, 659);
            xemDiem1.TabIndex = 0;
            // 
            // FormTrangChuHocSinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 659);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "FormTrangChuHocSinh";
            Text = "Trang chủ";
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button btnXemThongTinHocSinh;
        private Button btnXemThongTinLop;
        private Button btnXemThongTinMonHoc;
        private Panel panel2;
        private Button btnDangXuat;
        private Panel panel5;
        private PictureBox pictureBox7;
        private Label lbhoten;
        private TaiKhoan taiKhoan1;
        private XemThongTinMonHoc xemThongTinMonHoc1;
        private XemThongTinLop xemThongTinLop1;
        private XemThongTinHocSinh xemThongTinHocSinh1;
        private XemDiem xemDiem1;
        private XemThongTinMonHocHS xemThongTinMonHochs1;
    }
}