namespace MyApp
{
    partial class frmDonHang
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
            labelMaDH = new Label();
            txtMaDH = new TextBox();
            labelSDTKH = new Label();
            txtSDTKhachHang = new TextBox();
            labelNgayTao = new Label();
            dateTimeNgayTao = new DateTimePicker();
            dataGridViewDonHangBan = new DataGridView();
            btnXoaDH = new Button();
            btnUpdateDH = new Button();
            cboTenSP = new ComboBox();
            labelTenSP = new Label();
            labelMaSP = new Label();
            txtMaSP = new TextBox();
            soLuong = new NumericUpDown();
            dataGridViewDHCT = new DataGridView();
            btnThemDonHang = new Button();
            btnThemDHCT = new Button();
            label1 = new Label();
            txtTongTien = new TextBox();
            labelSL = new Label();
            btnXoaSP = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDonHangBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)soLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDHCT).BeginInit();
            SuspendLayout();
            // 
            // labelMaDH
            // 
            labelMaDH.AutoSize = true;
            labelMaDH.Location = new Point(29, 100);
            labelMaDH.Name = "labelMaDH";
            labelMaDH.Size = new Size(123, 25);
            labelMaDH.TabIndex = 1;
            labelMaDH.Text = "Mã đơn hàng:";
            labelMaDH.Click += label1_Click;
            // 
            // txtMaDH
            // 
            txtMaDH.Location = new Point(227, 94);
            txtMaDH.Name = "txtMaDH";
            txtMaDH.Size = new Size(150, 31);
            txtMaDH.TabIndex = 2;
            // 
            // labelSDTKH
            // 
            labelSDTKH.AutoSize = true;
            labelSDTKH.Location = new Point(29, 28);
            labelSDTKH.Name = "labelSDTKH";
            labelSDTKH.Size = new Size(192, 25);
            labelSDTKH.TabIndex = 3;
            labelSDTKH.Text = "Nhập SĐT khách hàng:";
            // 
            // txtSDTKhachHang
            // 
            txtSDTKhachHang.Location = new Point(227, 22);
            txtSDTKhachHang.Name = "txtSDTKhachHang";
            txtSDTKhachHang.Size = new Size(150, 31);
            txtSDTKhachHang.TabIndex = 4;
            // 
            // labelNgayTao
            // 
            labelNgayTao.AutoSize = true;
            labelNgayTao.Location = new Point(622, 28);
            labelNgayTao.Name = "labelNgayTao";
            labelNgayTao.Size = new Size(89, 25);
            labelNgayTao.TabIndex = 5;
            labelNgayTao.Text = "Ngày tạo:";
            // 
            // dateTimeNgayTao
            // 
            dateTimeNgayTao.Location = new Point(764, 20);
            dateTimeNgayTao.Name = "dateTimeNgayTao";
            dateTimeNgayTao.Size = new Size(300, 31);
            dateTimeNgayTao.TabIndex = 6;
            // 
            // dataGridViewDonHangBan
            // 
            dataGridViewDonHangBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDonHangBan.Location = new Point(29, 297);
            dataGridViewDonHangBan.Name = "dataGridViewDonHangBan";
            dataGridViewDonHangBan.RowHeadersWidth = 62;
            dataGridViewDonHangBan.Size = new Size(508, 362);
            dataGridViewDonHangBan.TabIndex = 7;
            dataGridViewDonHangBan.CellClick += dataGridViewDonHangBan_CellClick;
            // 
            // btnXoaDH
            // 
            btnXoaDH.BackColor = Color.LightCoral;
            btnXoaDH.Location = new Point(408, 221);
            btnXoaDH.Name = "btnXoaDH";
            btnXoaDH.Size = new Size(129, 48);
            btnXoaDH.TabIndex = 8;
            btnXoaDH.Text = "Xóa ";
            btnXoaDH.UseVisualStyleBackColor = false;
            btnXoaDH.Click += btnXoaDH_Click;
            // 
            // btnUpdateDH
            // 
            btnUpdateDH.Location = new Point(216, 221);
            btnUpdateDH.Name = "btnUpdateDH";
            btnUpdateDH.Size = new Size(129, 48);
            btnUpdateDH.TabIndex = 9;
            btnUpdateDH.Text = "Sửa";
            btnUpdateDH.UseVisualStyleBackColor = true;
            btnUpdateDH.Click += btnUpdateDH_Click;
            // 
            // cboTenSP
            // 
            cboTenSP.FormattingEnabled = true;
            cboTenSP.Location = new Point(764, 97);
            cboTenSP.Name = "cboTenSP";
            cboTenSP.Size = new Size(172, 33);
            cboTenSP.TabIndex = 10;
            cboTenSP.SelectedIndexChanged += cboTenSP_SelectedIndexChanged;
            // 
            // labelTenSP
            // 
            labelTenSP.AutoSize = true;
            labelTenSP.Location = new Point(622, 100);
            labelTenSP.Name = "labelTenSP";
            labelTenSP.Size = new Size(67, 25);
            labelTenSP.TabIndex = 11;
            labelTenSP.Text = "Tên SP:";
            // 
            // labelMaSP
            // 
            labelMaSP.AutoSize = true;
            labelMaSP.Location = new Point(623, 175);
            labelMaSP.Name = "labelMaSP";
            labelMaSP.Size = new Size(66, 25);
            labelMaSP.TabIndex = 12;
            labelMaSP.Text = "Mã SP:";
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(764, 169);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(172, 31);
            txtMaSP.TabIndex = 13;
            // 
            // soLuong
            // 
            soLuong.Location = new Point(764, 229);
            soLuong.Name = "soLuong";
            soLuong.Size = new Size(53, 31);
            soLuong.TabIndex = 14;
            // 
            // dataGridViewDHCT
            // 
            dataGridViewDHCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDHCT.Location = new Point(607, 297);
            dataGridViewDHCT.Name = "dataGridViewDHCT";
            dataGridViewDHCT.RowHeadersWidth = 62;
            dataGridViewDHCT.Size = new Size(593, 433);
            dataGridViewDHCT.TabIndex = 16;
            dataGridViewDHCT.CellClick += dataGridViewDHCT_CellClick;
            // 
            // btnThemDonHang
            // 
            btnThemDonHang.Location = new Point(29, 221);
            btnThemDonHang.Name = "btnThemDonHang";
            btnThemDonHang.Size = new Size(129, 48);
            btnThemDonHang.TabIndex = 0;
            btnThemDonHang.Text = "Thêm mới";
            btnThemDonHang.UseVisualStyleBackColor = true;
            btnThemDonHang.Click += btnThemDonHang_Click;
            // 
            // btnThemDHCT
            // 
            btnThemDHCT.Location = new Point(1033, 79);
            btnThemDHCT.Name = "btnThemDHCT";
            btnThemDHCT.Size = new Size(125, 51);
            btnThemDHCT.TabIndex = 17;
            btnThemDHCT.Text = "Thêm SP";
            btnThemDHCT.UseVisualStyleBackColor = true;
            btnThemDHCT.Click += btnThemDHCT_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 168);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 18;
            label1.Text = "Tổng tiền:";
            label1.Click += label1_Click_1;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(227, 169);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(150, 31);
            txtTongTien.TabIndex = 19;
            // 
            // labelSL
            // 
            labelSL.AutoSize = true;
            labelSL.Location = new Point(623, 235);
            labelSL.Name = "labelSL";
            labelSL.Size = new Size(85, 25);
            labelSL.TabIndex = 20;
            labelSL.Text = "Số lượng";
            // 
            // btnXoaSP
            // 
            btnXoaSP.Location = new Point(1033, 175);
            btnXoaSP.Name = "btnXoaSP";
            btnXoaSP.Size = new Size(125, 51);
            btnXoaSP.TabIndex = 21;
            btnXoaSP.Text = "Xóa SP";
            btnXoaSP.UseVisualStyleBackColor = true;
            btnXoaSP.Click += btnXoaSP_Click;
            // 
            // frmDonHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1225, 666);
            Controls.Add(btnXoaSP);
            Controls.Add(labelSL);
            Controls.Add(txtTongTien);
            Controls.Add(label1);
            Controls.Add(btnThemDHCT);
            Controls.Add(dataGridViewDHCT);
            Controls.Add(soLuong);
            Controls.Add(txtMaSP);
            Controls.Add(labelMaSP);
            Controls.Add(labelTenSP);
            Controls.Add(cboTenSP);
            Controls.Add(btnUpdateDH);
            Controls.Add(btnXoaDH);
            Controls.Add(dataGridViewDonHangBan);
            Controls.Add(dateTimeNgayTao);
            Controls.Add(labelNgayTao);
            Controls.Add(txtSDTKhachHang);
            Controls.Add(labelSDTKH);
            Controls.Add(txtMaDH);
            Controls.Add(labelMaDH);
            Controls.Add(btnThemDonHang);
            Name = "frmDonHang";
            Text = "frmDonHang";
            Load += frmDonHang_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDonHangBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)soLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDHCT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelMaDH;
        private TextBox txtMaDH;
        private Label labelSDTKH;
        private TextBox txtSDTKhachHang;
        private Label labelNgayTao;
        private DateTimePicker dateTimeNgayTao;
        private DataGridView dataGridViewDonHangBan;
        private Button btnXoaDH;
        private ComboBox cboTenSP;
        private Label labelTenSP;
        private Label labelMaSP;
        private TextBox txtMaSP;
        private NumericUpDown soLuong;
        private DataGridView dataGridViewDHCT;
        private Button btnThemDonHang;
        private Button btnThemDHCT;
        private Button btnUpdateDH;
        private Label label1;
        private TextBox txtTongTien;
        private Label labelSL;
        private Button btnXoaSP;
    }
}