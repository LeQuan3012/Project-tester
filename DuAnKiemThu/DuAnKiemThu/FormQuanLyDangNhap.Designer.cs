namespace DuAnKiemThu
{
    partial class FormQuanLyDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyDangNhap));
            dangNhap1 = new DangNhap();
            quenmatkhau1 = new Quenmatkhau();
            dangKy1 = new DangKy();
            SuspendLayout();
            // 
            // dangNhap1
            // 
            dangNhap1.BackgroundImage = (Image)resources.GetObject("dangNhap1.BackgroundImage");
            dangNhap1.BackgroundImageLayout = ImageLayout.Stretch;
            dangNhap1.Dock = DockStyle.Fill;
            dangNhap1.Location = new Point(0, 0);
            dangNhap1.Name = "dangNhap1";
            dangNhap1.Size = new Size(863, 545);
            dangNhap1.TabIndex = 0;
            // 
            // quenmatkhau1
            // 
            quenmatkhau1.BackgroundImage = (Image)resources.GetObject("quenmatkhau1.BackgroundImage");
            quenmatkhau1.BackgroundImageLayout = ImageLayout.Stretch;
            quenmatkhau1.Dock = DockStyle.Fill;
            quenmatkhau1.Location = new Point(0, 0);
            quenmatkhau1.Name = "quenmatkhau1";
            quenmatkhau1.Size = new Size(863, 545);
            quenmatkhau1.TabIndex = 1;
            // 
            // dangKy1
            // 
            dangKy1.BackgroundImage = (Image)resources.GetObject("dangKy1.BackgroundImage");
            dangKy1.BackgroundImageLayout = ImageLayout.Stretch;
            dangKy1.Dock = DockStyle.Fill;
            dangKy1.Location = new Point(0, 0);
            dangKy1.Name = "dangKy1";
            dangKy1.Size = new Size(863, 545);
            dangKy1.TabIndex = 2;
            // 
            // FormQuanLyDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(863, 545);
            Controls.Add(dangKy1);
            Controls.Add(quenmatkhau1);
            Controls.Add(dangNhap1);
            MaximizeBox = false;
            Name = "FormQuanLyDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ResumeLayout(false);
        }

        #endregion

        private DangNhap dangNhap1;
        private Quenmatkhau quenmatkhau1;
        private DangKy dangKy1;
    }
}