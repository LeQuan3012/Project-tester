namespace DuAnKiemThu
{
    partial class FormTraCuuHocSinh
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
            dgvDSTKmoiTaoHS = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            btnLamMoiHS = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDSTKmoiTaoHS).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDSTKmoiTaoHS
            // 
            dgvDSTKmoiTaoHS.AllowUserToAddRows = false;
            dgvDSTKmoiTaoHS.AllowUserToDeleteRows = false;
            dgvDSTKmoiTaoHS.AllowUserToOrderColumns = true;
            dgvDSTKmoiTaoHS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSTKmoiTaoHS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSTKmoiTaoHS.Dock = DockStyle.Fill;
            dgvDSTKmoiTaoHS.Location = new Point(3, 55);
            dgvDSTKmoiTaoHS.Name = "dgvDSTKmoiTaoHS";
            dgvDSTKmoiTaoHS.RowHeadersWidth = 51;
            dgvDSTKmoiTaoHS.RowTemplate.Height = 29;
            dgvDSTKmoiTaoHS.Size = new Size(882, 438);
            dgvDSTKmoiTaoHS.TabIndex = 1;
            dgvDSTKmoiTaoHS.CellClick += dgvDSTKmoiTaoHS_CellClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvDSTKmoiTaoHS, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.6090374F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.39096F));
            tableLayoutPanel1.Size = new Size(888, 496);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLamMoiHS);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 46);
            panel1.TabIndex = 0;
            // 
            // btnLamMoiHS
            // 
            btnLamMoiHS.Location = new Point(766, 9);
            btnLamMoiHS.Name = "btnLamMoiHS";
            btnLamMoiHS.Size = new Size(94, 29);
            btnLamMoiHS.TabIndex = 1;
            btnLamMoiHS.Text = "Làm mới";
            btnLamMoiHS.UseVisualStyleBackColor = true;
            btnLamMoiHS.Click += btnLamMoiHS_Click;
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
            // FormTraCuuHocSinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 496);
            Controls.Add(tableLayoutPanel1);
            Name = "FormTraCuuHocSinh";
            Text = "Tra cứu thông tin học sinh";
            ((System.ComponentModel.ISupportInitialize)dgvDSTKmoiTaoHS).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDSTKmoiTaoHS;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button btnLamMoiHS;
        private Label label1;
    }
}