namespace MyApp
{
    partial class frmNhaCungCap
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
            dataGridView1 = new DataGridView();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            txtSDT = new TextBox();
            label3 = new Label();
            txtTenNCC = new TextBox();
            label2 = new Label();
            txtMaNCC = new TextBox();
            labelMaKH = new Label();
            menuStrip1 = new MenuStrip();
            noNCC = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(281, 319);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(540, 237);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(539, 239);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 20;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(349, 239);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 18;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(163, 236);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(116, 37);
            btnLuu.TabIndex = 17;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(365, 175);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(286, 31);
            txtSDT.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 175);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 19;
            label3.Text = "Số điện thoại";
            // 
            // txtTenNCC
            // 
            txtTenNCC.Location = new Point(365, 117);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(286, 31);
            txtTenNCC.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(162, 117);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 16;
            label2.Text = "Tên NCC";
            // 
            // txtMaNCC
            // 
            txtMaNCC.Location = new Point(365, 63);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(286, 31);
            txtMaNCC.TabIndex = 12;
            // 
            // labelMaKH
            // 
            labelMaKH.AutoSize = true;
            labelMaKH.ForeColor = Color.Red;
            labelMaKH.Location = new Point(163, 69);
            labelMaKH.Name = "labelMaKH";
            labelMaKH.Size = new Size(77, 25);
            labelMaKH.TabIndex = 13;
            labelMaKH.Text = "Mã NCC";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { noNCC });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(981, 33);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // noNCC
            // 
            noNCC.Name = "noNCC";
            noNCC.Size = new Size(166, 29);
            noNCC.Text = "Nợ Nhà cung cấp";
            noNCC.Click += noNCC_Click;
            // 
            // frmNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(981, 553);
            Controls.Add(dataGridView1);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnLuu);
            Controls.Add(txtSDT);
            Controls.Add(label3);
            Controls.Add(txtTenNCC);
            Controls.Add(label2);
            Controls.Add(txtMaNCC);
            Controls.Add(labelMaKH);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmNhaCungCap";
            Text = "frmNhaCungCap";
            Load += frmNhaCungCap_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private TextBox txtSDT;
        private Label label3;
        private TextBox txtTenNCC;
        private Label label2;
        private TextBox txtMaNCC;
        private Label labelMaKH;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem noNCC;
    }
}