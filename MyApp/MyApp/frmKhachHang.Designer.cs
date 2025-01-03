namespace MyApp
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            labelMaKH = new Label();
            txtMaKH = new TextBox();
            label2 = new Label();
            txtTenKH = new TextBox();
            label3 = new Label();
            txtSDT = new TextBox();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            noKhStripMenu = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelMaKH
            // 
            labelMaKH.AutoSize = true;
            labelMaKH.ForeColor = Color.Red;
            labelMaKH.Location = new Point(56, 67);
            labelMaKH.Name = "labelMaKH";
            labelMaKH.Size = new Size(133, 25);
            labelMaKH.TabIndex = 0;
            labelMaKH.Text = "Mã khách hàng";
            labelMaKH.Click += labelMaKH_Click;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(258, 61);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(150, 31);
            txtMaKH.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(55, 115);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 2;
            label2.Text = "Tên khách hàng";
            label2.Click += label2_Click;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(258, 115);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(150, 31);
            txtTenKH.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 173);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 4;
            label3.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(258, 173);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(150, 31);
            txtSDT.TabIndex = 2;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(56, 234);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(116, 37);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += buttonluu_click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(242, 237);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += buttonSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(432, 237);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(174, 317);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(540, 237);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { noKhStripMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(981, 33);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // noKhStripMenu
            // 
            noKhStripMenu.Name = "noKhStripMenu";
            noKhStripMenu.Size = new Size(180, 29);
            noKhStripMenu.Text = "Nợ của khách hàng";
            noKhStripMenu.Click += noKhStripMenu_Click;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(981, 553);
            Controls.Add(dataGridView1);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnLuu);
            Controls.Add(txtSDT);
            Controls.Add(label3);
            Controls.Add(txtTenKH);
            Controls.Add(label2);
            Controls.Add(txtMaKH);
            Controls.Add(labelMaKH);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý khách hàng";
            FormClosing += frmKhachHang_FormClosing;
            Load += frmKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMaKH;
        private TextBox txtMaKH;
        private Label label2;
        private TextBox txtTenKH;
        private Label label3;
        private TextBox txtSDT;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem noKhStripMenu;
    }
}
