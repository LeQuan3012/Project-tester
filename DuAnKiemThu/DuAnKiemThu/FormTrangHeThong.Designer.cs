namespace DuAnKiemThu
{
    partial class FormTrangHeThong
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrangHeThong));
            pictureBox1 = new PictureBox();
            lbhethong = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnbatdau = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbhethong
            // 
            lbhethong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbhethong.AutoSize = true;
            lbhethong.BackColor = Color.Transparent;
            lbhethong.BorderStyle = BorderStyle.Fixed3D;
            lbhethong.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lbhethong.Location = new Point(211, 64);
            lbhethong.Name = "lbhethong";
            lbhethong.Size = new Size(387, 48);
            lbhethong.TabIndex = 1;
            lbhethong.Text = "HỆ THỐNG TÍNH ĐIỂM\r\n";
            // 
            // btnbatdau
            // 
            btnbatdau.Anchor = AnchorStyles.Bottom;
            btnbatdau.BackColor = Color.Silver;
            btnbatdau.Cursor = Cursors.Hand;
            btnbatdau.ForeColor = Color.Transparent;
            btnbatdau.Location = new Point(348, 361);
            btnbatdau.Name = "btnbatdau";
            btnbatdau.Size = new Size(138, 59);
            btnbatdau.TabIndex = 2;
            btnbatdau.Text = "Bắt đầu";
            btnbatdau.UseVisualStyleBackColor = false;
            btnbatdau.Click += btnbatdau_Click;
            btnbatdau.MouseEnter += btnbatdau_MouseEnter;
            btnbatdau.MouseLeave += btnbatdau_MouseLeave;
            // 
            // FormTrangHeThong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnbatdau);
            Controls.Add(lbhethong);
            Controls.Add(pictureBox1);
            MinimizeBox = false;
            Name = "FormTrangHeThong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chào mừng";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbhethong;
        private System.Windows.Forms.Timer timer1;
        private Button btnbatdau;
    }
}