namespace DuAnKiemThu
{
    partial class QuanLyMonHoc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvmonhoc = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            label4 = new Label();
            cbtinhtrangMH = new ComboBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label2 = new Label();
            txtmamonhoc = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label3 = new Label();
            txttenmonhoc = new TextBox();
            btnLamMoiMonHoc = new Button();
            panel3 = new Panel();
            lbloimamonhoc = new Label();
            panel4 = new Panel();
            lbloitenmonhoc = new Label();
            panel5 = new Panel();
            lbloitinhtrangmonhoc = new Label();
            btnLuuLaiMonHoc = new Button();
            btnSuaMonHoc = new Button();
            btnXoaMonHoc = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvmonhoc).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvmonhoc
            // 
            dgvmonhoc.AllowUserToAddRows = false;
            dgvmonhoc.AllowUserToDeleteRows = false;
            dgvmonhoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvmonhoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvmonhoc.Columns.AddRange(new DataGridViewColumn[] { Column4, Column1, Column2, Column3 });
            dgvmonhoc.Dock = DockStyle.Fill;
            dgvmonhoc.Location = new Point(0, 0);
            dgvmonhoc.Name = "dgvmonhoc";
            dgvmonhoc.RowHeadersWidth = 51;
            dgvmonhoc.RowTemplate.Height = 29;
            dgvmonhoc.Size = new Size(1035, 580);
            dgvmonhoc.TabIndex = 0;
            dgvmonhoc.CellClick += dgvmonhoc_CellClick;
            // 
            // Column4
            // 
            Column4.HeaderText = "STT";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã môn học";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên môn học";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Tình trạng";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.44753456F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.4690266F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 74.0834351F));
            tableLayoutPanel1.Size = new Size(1041, 791);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1035, 45);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(428, 8);
            label1.Name = "label1";
            label1.Size = new Size(222, 30);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ MÔN HỌC";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 54);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1035, 148);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.92614F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.4684143F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.605442F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel2.Controls.Add(btnLamMoiMonHoc, 2, 3);
            tableLayoutPanel2.Controls.Add(panel3, 0, 1);
            tableLayoutPanel2.Controls.Add(panel4, 0, 3);
            tableLayoutPanel2.Controls.Add(panel5, 1, 1);
            tableLayoutPanel2.Controls.Add(btnLuuLaiMonHoc, 2, 0);
            tableLayoutPanel2.Controls.Add(btnSuaMonHoc, 2, 1);
            tableLayoutPanel2.Controls.Add(btnXoaMonHoc, 2, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(1029, 142);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.2668228F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.73318F));
            tableLayoutPanel6.Controls.Add(label4, 0, 0);
            tableLayoutPanel6.Controls.Add(cbtinhtrangMH, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(454, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(431, 29);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 0;
            label4.Text = "Tình trạng";
            // 
            // cbtinhtrangMH
            // 
            cbtinhtrangMH.Dock = DockStyle.Fill;
            cbtinhtrangMH.FormattingEnabled = true;
            cbtinhtrangMH.Items.AddRange(new object[] { "Đang học", "Ngưng học" });
            cbtinhtrangMH.Location = new Point(155, 3);
            cbtinhtrangMH.Name = "cbtinhtrangMH";
            cbtinhtrangMH.Size = new Size(273, 28);
            cbtinhtrangMH.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.13483F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.8651657F));
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Controls.Add(txtmamonhoc, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(445, 29);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã môn học";
            // 
            // txtmamonhoc
            // 
            txtmamonhoc.Dock = DockStyle.Fill;
            txtmamonhoc.Location = new Point(146, 3);
            txtmamonhoc.Name = "txtmamonhoc";
            txtmamonhoc.Size = new Size(296, 27);
            txtmamonhoc.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.0337067F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.96629F));
            tableLayoutPanel5.Controls.Add(label3, 0, 0);
            tableLayoutPanel5.Controls.Add(txttenmonhoc, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 73);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(445, 29);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 0;
            label3.Text = "Tên môn học";
            // 
            // txttenmonhoc
            // 
            txttenmonhoc.Dock = DockStyle.Fill;
            txttenmonhoc.Location = new Point(149, 3);
            txttenmonhoc.Name = "txttenmonhoc";
            txttenmonhoc.Size = new Size(293, 27);
            txttenmonhoc.TabIndex = 1;
            // 
            // btnLamMoiMonHoc
            // 
            btnLamMoiMonHoc.Location = new Point(891, 108);
            btnLamMoiMonHoc.Name = "btnLamMoiMonHoc";
            btnLamMoiMonHoc.Size = new Size(94, 29);
            btnLamMoiMonHoc.TabIndex = 4;
            btnLamMoiMonHoc.Text = "Làm mới";
            btnLamMoiMonHoc.UseVisualStyleBackColor = true;
            btnLamMoiMonHoc.Click += btnLamMoiMonHoc_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(lbloimamonhoc);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 38);
            panel3.Name = "panel3";
            panel3.Size = new Size(445, 29);
            panel3.TabIndex = 5;
            // 
            // lbloimamonhoc
            // 
            lbloimamonhoc.AutoSize = true;
            lbloimamonhoc.ForeColor = Color.Red;
            lbloimamonhoc.Location = new Point(8, 4);
            lbloimamonhoc.Name = "lbloimamonhoc";
            lbloimamonhoc.Size = new Size(50, 20);
            lbloimamonhoc.TabIndex = 0;
            lbloimamonhoc.Text = "label5";
            // 
            // panel4
            // 
            panel4.Controls.Add(lbloitenmonhoc);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 108);
            panel4.Name = "panel4";
            panel4.Size = new Size(445, 31);
            panel4.TabIndex = 6;
            // 
            // lbloitenmonhoc
            // 
            lbloitenmonhoc.AutoSize = true;
            lbloitenmonhoc.ForeColor = Color.Red;
            lbloitenmonhoc.Location = new Point(11, 6);
            lbloitenmonhoc.Name = "lbloitenmonhoc";
            lbloitenmonhoc.Size = new Size(50, 20);
            lbloitenmonhoc.TabIndex = 0;
            lbloitenmonhoc.Text = "label6";
            // 
            // panel5
            // 
            panel5.Controls.Add(lbloitinhtrangmonhoc);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(454, 38);
            panel5.Name = "panel5";
            panel5.Size = new Size(431, 29);
            panel5.TabIndex = 7;
            // 
            // lbloitinhtrangmonhoc
            // 
            lbloitinhtrangmonhoc.AutoSize = true;
            lbloitinhtrangmonhoc.ForeColor = Color.Red;
            lbloitinhtrangmonhoc.Location = new Point(8, 5);
            lbloitinhtrangmonhoc.Name = "lbloitinhtrangmonhoc";
            lbloitinhtrangmonhoc.Size = new Size(50, 20);
            lbloitinhtrangmonhoc.TabIndex = 0;
            lbloitinhtrangmonhoc.Text = "label7";
            // 
            // btnLuuLaiMonHoc
            // 
            btnLuuLaiMonHoc.Location = new Point(891, 3);
            btnLuuLaiMonHoc.Name = "btnLuuLaiMonHoc";
            btnLuuLaiMonHoc.Size = new Size(94, 29);
            btnLuuLaiMonHoc.TabIndex = 3;
            btnLuuLaiMonHoc.Text = "Thêm";
            btnLuuLaiMonHoc.UseVisualStyleBackColor = true;
            btnLuuLaiMonHoc.Click += btnLuuLaiMonHoc_Click;
            // 
            // btnSuaMonHoc
            // 
            btnSuaMonHoc.Location = new Point(891, 38);
            btnSuaMonHoc.Name = "btnSuaMonHoc";
            btnSuaMonHoc.Size = new Size(94, 29);
            btnSuaMonHoc.TabIndex = 8;
            btnSuaMonHoc.Text = "Sửa";
            btnSuaMonHoc.UseVisualStyleBackColor = true;
            btnSuaMonHoc.Click += btnSuaMonHoc_Click;
            // 
            // btnXoaMonHoc
            // 
            btnXoaMonHoc.Location = new Point(891, 73);
            btnXoaMonHoc.Name = "btnXoaMonHoc";
            btnXoaMonHoc.Size = new Size(94, 29);
            btnXoaMonHoc.TabIndex = 9;
            btnXoaMonHoc.Text = "Xóa";
            btnXoaMonHoc.UseVisualStyleBackColor = true;
            btnXoaMonHoc.Click += btnXoaMonHoc_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvmonhoc);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 208);
            panel2.Name = "panel2";
            panel2.Size = new Size(1035, 580);
            panel2.TabIndex = 2;
            // 
            // QuanLyMonHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "QuanLyMonHoc";
            Size = new Size(1041, 791);
            ((System.ComponentModel.ISupportInitialize)dgvmonhoc).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvmonhoc;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label4;
        private ComboBox cbtinhtrangMH;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label2;
        private TextBox txtmamonhoc;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label3;
        private TextBox txttenmonhoc;
        private Button btnLamMoiMonHoc;
        private Button btnLuuLaiMonHoc;
        private Panel panel3;
        private Label lbloimamonhoc;
        private Panel panel4;
        private Label lbloitenmonhoc;
        private Panel panel5;
        private Label lbloitinhtrangmonhoc;
        private Button btnSuaMonHoc;
        private Button btnXoaMonHoc;
    }
}
