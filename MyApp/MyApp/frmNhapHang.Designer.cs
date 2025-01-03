namespace MyApp
{
    partial class frmNhapHang
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
            btnXoaSP = new Button();
            labelSL = new Label();
            txtTongTien = new TextBox();
            labelTongTien = new Label();
            btnThemDHCT = new Button();
            dataGridViewDHNCT = new DataGridView();
            soLuong = new NumericUpDown();
            txtMaSP = new TextBox();
            labelMaSP = new Label();
            labelTenSP = new Label();
            cboTenSP = new ComboBox();
            btnUpdateDH = new Button();
            btnXoaDH = new Button();
            dataGridViewDonHangNhap = new DataGridView();
            dateTimeNgayTao = new DateTimePicker();
            labelNgayTao = new Label();
            txtSDT_NCC = new TextBox();
            labelSDT_NCC = new Label();
            txtMaDH = new TextBox();
            labelMaDH = new Label();
            btnThemDonHang = new Button();
            labelGiaBan = new Label();
            txtGiaNhap = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDHNCT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)soLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDonHangNhap).BeginInit();
            SuspendLayout();
            // 
            // btnXoaSP
            // 
            btnXoaSP.Location = new Point(1072, 98);
            btnXoaSP.Name = "btnXoaSP";
            btnXoaSP.Size = new Size(125, 51);
            btnXoaSP.TabIndex = 42;
            btnXoaSP.Text = "Xóa SP";
            btnXoaSP.UseVisualStyleBackColor = true;
            btnXoaSP.Click += btnXoaSP_Click;
            // 
            // labelSL
            // 
            labelSL.AutoSize = true;
            labelSL.Location = new Point(1001, 179);
            labelSL.Name = "labelSL";
            labelSL.Size = new Size(85, 25);
            labelSL.TabIndex = 41;
            labelSL.Text = "Số lượng";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(224, 173);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(150, 31);
            txtTongTien.TabIndex = 40;
            // 
            // labelTongTien
            // 
            labelTongTien.AutoSize = true;
            labelTongTien.Location = new Point(26, 172);
            labelTongTien.Name = "labelTongTien";
            labelTongTien.Size = new Size(91, 25);
            labelTongTien.TabIndex = 39;
            labelTongTien.Text = "Tổng tiền:";
            // 
            // btnThemDHCT
            // 
            btnThemDHCT.Location = new Point(1072, 19);
            btnThemDHCT.Name = "btnThemDHCT";
            btnThemDHCT.Size = new Size(125, 51);
            btnThemDHCT.TabIndex = 38;
            btnThemDHCT.Text = "Thêm SP";
            btnThemDHCT.UseVisualStyleBackColor = true;
            btnThemDHCT.Click += btnThemDHCT_Click;
            // 
            // dataGridViewDHNCT
            // 
            dataGridViewDHNCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDHNCT.Location = new Point(604, 301);
            dataGridViewDHNCT.Name = "dataGridViewDHNCT";
            dataGridViewDHNCT.RowHeadersWidth = 62;
            dataGridViewDHNCT.Size = new Size(593, 433);
            dataGridViewDHNCT.TabIndex = 37;
            dataGridViewDHNCT.CellClick += dataGridViewDHNCT_CellClick;
            // 
            // soLuong
            // 
            soLuong.Location = new Point(1127, 177);
            soLuong.Name = "soLuong";
            soLuong.Size = new Size(53, 31);
            soLuong.TabIndex = 36;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(761, 173);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(172, 31);
            txtMaSP.TabIndex = 35;
            // 
            // labelMaSP
            // 
            labelMaSP.AutoSize = true;
            labelMaSP.Location = new Point(619, 173);
            labelMaSP.Name = "labelMaSP";
            labelMaSP.Size = new Size(66, 25);
            labelMaSP.TabIndex = 34;
            labelMaSP.Text = "Mã SP:";
            // 
            // labelTenSP
            // 
            labelTenSP.AutoSize = true;
            labelTenSP.Location = new Point(619, 104);
            labelTenSP.Name = "labelTenSP";
            labelTenSP.Size = new Size(67, 25);
            labelTenSP.TabIndex = 33;
            labelTenSP.Text = "Tên SP:";
            // 
            // cboTenSP
            // 
            cboTenSP.FormattingEnabled = true;
            cboTenSP.Location = new Point(761, 101);
            cboTenSP.Name = "cboTenSP";
            cboTenSP.Size = new Size(172, 33);
            cboTenSP.TabIndex = 32;
            // 
            // btnUpdateDH
            // 
            btnUpdateDH.Location = new Point(213, 225);
            btnUpdateDH.Name = "btnUpdateDH";
            btnUpdateDH.Size = new Size(129, 48);
            btnUpdateDH.TabIndex = 31;
            btnUpdateDH.Text = "Sửa";
            btnUpdateDH.UseVisualStyleBackColor = true;
            btnUpdateDH.Click += btnUpdateDH_Click;
            // 
            // btnXoaDH
            // 
            btnXoaDH.BackColor = Color.LightCoral;
            btnXoaDH.Location = new Point(405, 225);
            btnXoaDH.Name = "btnXoaDH";
            btnXoaDH.Size = new Size(129, 48);
            btnXoaDH.TabIndex = 30;
            btnXoaDH.Text = "Xóa ";
            btnXoaDH.UseVisualStyleBackColor = false;
            btnXoaDH.Click += btnXoaDH_Click;
            // 
            // dataGridViewDonHangNhap
            // 
            dataGridViewDonHangNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDonHangNhap.Location = new Point(45, 301);
            dataGridViewDonHangNhap.Name = "dataGridViewDonHangNhap";
            dataGridViewDonHangNhap.RowHeadersWidth = 62;
            dataGridViewDonHangNhap.Size = new Size(508, 362);
            dataGridViewDonHangNhap.TabIndex = 29;
            dataGridViewDonHangNhap.CellClick += dataGridViewDonHangNhap_CellClick;
            // 
            // dateTimeNgayTao
            // 
            dateTimeNgayTao.Location = new Point(761, 24);
            dateTimeNgayTao.Name = "dateTimeNgayTao";
            dateTimeNgayTao.Size = new Size(272, 31);
            dateTimeNgayTao.TabIndex = 28;
            // 
            // labelNgayTao
            // 
            labelNgayTao.AutoSize = true;
            labelNgayTao.Location = new Point(619, 32);
            labelNgayTao.Name = "labelNgayTao";
            labelNgayTao.Size = new Size(89, 25);
            labelNgayTao.TabIndex = 27;
            labelNgayTao.Text = "Ngày tạo:";
            // 
            // txtSDT_NCC
            // 
            txtSDT_NCC.Location = new Point(224, 26);
            txtSDT_NCC.Name = "txtSDT_NCC";
            txtSDT_NCC.Size = new Size(150, 31);
            txtSDT_NCC.TabIndex = 26;
            // 
            // labelSDT_NCC
            // 
            labelSDT_NCC.AutoSize = true;
            labelSDT_NCC.Location = new Point(26, 32);
            labelSDT_NCC.Name = "labelSDT_NCC";
            labelSDT_NCC.Size = new Size(136, 25);
            labelSDT_NCC.TabIndex = 25;
            labelSDT_NCC.Text = "Nhập SĐT NCC:";
            // 
            // txtMaDH
            // 
            txtMaDH.Location = new Point(224, 98);
            txtMaDH.Name = "txtMaDH";
            txtMaDH.Size = new Size(150, 31);
            txtMaDH.TabIndex = 24;
            // 
            // labelMaDH
            // 
            labelMaDH.AutoSize = true;
            labelMaDH.Location = new Point(26, 104);
            labelMaDH.Name = "labelMaDH";
            labelMaDH.Size = new Size(123, 25);
            labelMaDH.TabIndex = 23;
            labelMaDH.Text = "Mã đơn hàng:";
            // 
            // btnThemDonHang
            // 
            btnThemDonHang.Location = new Point(26, 225);
            btnThemDonHang.Name = "btnThemDonHang";
            btnThemDonHang.Size = new Size(129, 48);
            btnThemDonHang.TabIndex = 22;
            btnThemDonHang.Text = "Thêm mới";
            btnThemDonHang.UseVisualStyleBackColor = true;
            btnThemDonHang.Click += btnThemDonHang_Click;
            // 
            // labelGiaBan
            // 
            labelGiaBan.AutoSize = true;
            labelGiaBan.Location = new Point(620, 237);
            labelGiaBan.Name = "labelGiaBan";
            labelGiaBan.Size = new Size(86, 25);
            labelGiaBan.TabIndex = 43;
            labelGiaBan.Text = "Giá nhập:";
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Location = new Point(761, 237);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(172, 31);
            txtGiaNhap.TabIndex = 44;
            // 
            // frmNhapHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1225, 666);
            Controls.Add(txtGiaNhap);
            Controls.Add(labelGiaBan);
            Controls.Add(btnXoaSP);
            Controls.Add(labelSL);
            Controls.Add(txtTongTien);
            Controls.Add(labelTongTien);
            Controls.Add(btnThemDHCT);
            Controls.Add(dataGridViewDHNCT);
            Controls.Add(soLuong);
            Controls.Add(txtMaSP);
            Controls.Add(labelMaSP);
            Controls.Add(labelTenSP);
            Controls.Add(cboTenSP);
            Controls.Add(btnUpdateDH);
            Controls.Add(btnXoaDH);
            Controls.Add(dataGridViewDonHangNhap);
            Controls.Add(dateTimeNgayTao);
            Controls.Add(labelNgayTao);
            Controls.Add(txtSDT_NCC);
            Controls.Add(labelSDT_NCC);
            Controls.Add(txtMaDH);
            Controls.Add(labelMaDH);
            Controls.Add(btnThemDonHang);
            Name = "frmNhapHang";
            Text = "frmNhapHang";
            Load += frmNhapHang_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDHNCT).EndInit();
            ((System.ComponentModel.ISupportInitialize)soLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDonHangNhap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnXoaSP;
        private Label labelSL;
        private TextBox txtTongTien;
        private Label labelTongTien;
        private Button btnThemDHCT;
        private DataGridView dataGridViewDHNCT;
        private NumericUpDown soLuong;
        private TextBox txtMaSP;
        private Label labelMaSP;
        private Label labelTenSP;
        private ComboBox cboTenSP;
        private Button btnUpdateDH;
        private Button btnXoaDH;
        private DataGridView dataGridViewDonHangNhap;
        private DateTimePicker dateTimeNgayTao;
        private Label labelNgayTao;
        private TextBox txtSDT_NCC;
        private Label labelSDT_NCC;
        private TextBox txtMaDH;
        private Label labelMaDH;
        private Button btnThemDonHang;
        private Label labelGiaBan;
        private TextBox txtGiaNhap;
    }
}