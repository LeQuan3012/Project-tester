namespace DuAnKiemThu
{
    partial class FormTraCuuTK
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            btnLamMoi = new Button();
            label1 = new Label();
            dgvDSTKmoiTao = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSTKmoiTao).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvDSTKmoiTao, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.6090374F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.39096F));
            tableLayoutPanel1.Size = new Size(875, 509);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLamMoi);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(869, 48);
            panel1.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(766, 9);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 1;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(241, 4);
            label1.Name = "label1";
            label1.Size = new Size(370, 30);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH TÀI KHOẢN MỚI TẠO";
            // 
            // dgvDSTKmoiTao
            // 
            dgvDSTKmoiTao.AllowUserToAddRows = false;
            dgvDSTKmoiTao.AllowUserToDeleteRows = false;
            dgvDSTKmoiTao.AllowUserToOrderColumns = true;
            dgvDSTKmoiTao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSTKmoiTao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSTKmoiTao.Dock = DockStyle.Fill;
            dgvDSTKmoiTao.Location = new Point(3, 57);
            dgvDSTKmoiTao.Name = "dgvDSTKmoiTao";
            dgvDSTKmoiTao.RowHeadersWidth = 51;
            dgvDSTKmoiTao.RowTemplate.Height = 29;
            dgvDSTKmoiTao.Size = new Size(869, 449);
            dgvDSTKmoiTao.TabIndex = 1;
            dgvDSTKmoiTao.CellClick += dgvDSTKmoiTao_CellClick;
            // 
            // FormTraCuuTK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 509);
            Controls.Add(tableLayoutPanel1);
            Name = "FormTraCuuTK";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tra cứu tài khoản mới tạo";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSTKmoiTao).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button btnLamMoi;
        private Label label1;
        private DataGridView dgvDSTKmoiTao;
    }
}