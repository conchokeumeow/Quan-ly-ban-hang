namespace MyApp
{
    partial class frmNhapSP
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
            btnSua = new Button();
            btnHuyDH = new Button();
            dataDHN = new DataGridView();
            btn_Xoa = new Button();
            btn_ThemSP = new Button();
            dataDHNCT = new DataGridView();
            btnThemDonHang = new Button();
            labelSL = new Label();
            soLuong = new NumericUpDown();
            txtMaSP = new TextBox();
            labelMaSP = new Label();
            labelTenSP = new Label();
            dateTimeNgayTao = new DateTimePicker();
            labelNgayTao = new Label();
            txtTongTien = new TextBox();
            label1 = new Label();
            txtMaDH = new TextBox();
            label_MaDHB = new Label();
            txtSDTNcc = new TextBox();
            label_SDTNCC = new Label();
            lbGiaNhap = new Label();
            txtGiaNhap = new TextBox();
            txtTenSP = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataDHN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataDHNCT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)soLuong).BeginInit();
            SuspendLayout();
            // 
            // btnSua
            // 
            btnSua.Location = new Point(277, 228);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(129, 44);
            btnSua.TabIndex = 51;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnHuyDH
            // 
            btnHuyDH.BackColor = Color.Red;
            btnHuyDH.ForeColor = SystemColors.ButtonHighlight;
            btnHuyDH.Location = new Point(1054, 19);
            btnHuyDH.Name = "btnHuyDH";
            btnHuyDH.Size = new Size(129, 44);
            btnHuyDH.TabIndex = 50;
            btnHuyDH.Text = "Hủy";
            btnHuyDH.UseVisualStyleBackColor = false;
            btnHuyDH.Click += btnHuyDH_Click;
            // 
            // dataDHN
            // 
            dataDHN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataDHN.Location = new Point(28, 335);
            dataDHN.Name = "dataDHN";
            dataDHN.RowHeadersWidth = 62;
            dataDHN.Size = new Size(378, 306);
            dataDHN.TabIndex = 49;
            // 
            // btn_Xoa
            // 
            btn_Xoa.BackColor = Color.Red;
            btn_Xoa.ForeColor = SystemColors.ButtonHighlight;
            btn_Xoa.Location = new Point(493, 228);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(129, 44);
            btn_Xoa.TabIndex = 48;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = false;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_ThemSP
            // 
            btn_ThemSP.Location = new Point(61, 228);
            btn_ThemSP.Name = "btn_ThemSP";
            btn_ThemSP.Size = new Size(129, 44);
            btn_ThemSP.TabIndex = 47;
            btn_ThemSP.Text = "Thêm mới";
            btn_ThemSP.UseVisualStyleBackColor = true;
            btn_ThemSP.Click += btn_ThemSP_Click;
            // 
            // dataDHNCT
            // 
            dataDHNCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataDHNCT.Location = new Point(443, 335);
            dataDHNCT.Name = "dataDHNCT";
            dataDHNCT.RowHeadersWidth = 62;
            dataDHNCT.Size = new Size(761, 306);
            dataDHNCT.TabIndex = 46;
            dataDHNCT.CellClick += dataDHNCT_CellClick;
            // 
            // btnThemDonHang
            // 
            btnThemDonHang.Location = new Point(866, 19);
            btnThemDonHang.Name = "btnThemDonHang";
            btnThemDonHang.Size = new Size(129, 44);
            btnThemDonHang.TabIndex = 45;
            btnThemDonHang.Text = "Thêm ĐH";
            btnThemDonHang.UseVisualStyleBackColor = true;
            btnThemDonHang.Click += btnThemDonHang_Click;
            // 
            // labelSL
            // 
            labelSL.AutoSize = true;
            labelSL.Location = new Point(831, 166);
            labelSL.Name = "labelSL";
            labelSL.Size = new Size(89, 25);
            labelSL.TabIndex = 44;
            labelSL.Text = "Số lượng:";
            // 
            // soLuong
            // 
            soLuong.Location = new Point(942, 162);
            soLuong.Name = "soLuong";
            soLuong.Size = new Size(53, 31);
            soLuong.TabIndex = 43;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(535, 163);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(194, 31);
            txtMaSP.TabIndex = 42;
            // 
            // labelMaSP
            // 
            labelMaSP.AutoSize = true;
            labelMaSP.Location = new Point(424, 169);
            labelMaSP.Name = "labelMaSP";
            labelMaSP.Size = new Size(66, 25);
            labelMaSP.TabIndex = 41;
            labelMaSP.Text = "Mã SP:";
            // 
            // labelTenSP
            // 
            labelTenSP.AutoSize = true;
            labelTenSP.Location = new Point(28, 169);
            labelTenSP.Name = "labelTenSP";
            labelTenSP.Size = new Size(67, 25);
            labelTenSP.TabIndex = 40;
            labelTenSP.Text = "Tên SP:";
            // 
            // dateTimeNgayTao
            // 
            dateTimeNgayTao.Location = new Point(535, 24);
            dateTimeNgayTao.Name = "dateTimeNgayTao";
            dateTimeNgayTao.Size = new Size(268, 31);
            dateTimeNgayTao.TabIndex = 38;
            // 
            // labelNgayTao
            // 
            labelNgayTao.AutoSize = true;
            labelNgayTao.Location = new Point(424, 27);
            labelNgayTao.Name = "labelNgayTao";
            labelNgayTao.Size = new Size(89, 25);
            labelNgayTao.TabIndex = 37;
            labelNgayTao.Text = "Ngày tạo:";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(535, 90);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(194, 31);
            txtTongTien.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(424, 96);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 35;
            label1.Text = "Tổng tiền:";
            // 
            // txtMaDH
            // 
            txtMaDH.Location = new Point(179, 90);
            txtMaDH.Name = "txtMaDH";
            txtMaDH.Size = new Size(181, 31);
            txtMaDH.TabIndex = 34;
            // 
            // label_MaDHB
            // 
            label_MaDHB.AutoSize = true;
            label_MaDHB.Location = new Point(26, 96);
            label_MaDHB.Name = "label_MaDHB";
            label_MaDHB.Size = new Size(125, 25);
            label_MaDHB.TabIndex = 33;
            label_MaDHB.Text = "Mã Đơn hàng:";
            // 
            // txtSDTNcc
            // 
            txtSDTNcc.Location = new Point(179, 23);
            txtSDTNcc.Name = "txtSDTNcc";
            txtSDTNcc.Size = new Size(181, 31);
            txtSDTNcc.TabIndex = 32;
            // 
            // label_SDTNCC
            // 
            label_SDTNCC.AutoSize = true;
            label_SDTNCC.Location = new Point(28, 29);
            label_SDTNCC.Name = "label_SDTNCC";
            label_SDTNCC.Size = new Size(88, 25);
            label_SDTNCC.TabIndex = 31;
            label_SDTNCC.Text = "SĐT NCC:";
            // 
            // lbGiaNhap
            // 
            lbGiaNhap.AutoSize = true;
            lbGiaNhap.Location = new Point(831, 90);
            lbGiaNhap.Name = "lbGiaNhap";
            lbGiaNhap.Size = new Size(86, 25);
            lbGiaNhap.TabIndex = 52;
            lbGiaNhap.Text = "Giá nhập:";
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Location = new Point(942, 87);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(194, 31);
            txtGiaNhap.TabIndex = 53;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(179, 163);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(194, 31);
            txtTenSP.TabIndex = 54;
            // 
            // frmNhapSP
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1231, 660);
            Controls.Add(txtTenSP);
            Controls.Add(txtGiaNhap);
            Controls.Add(lbGiaNhap);
            Controls.Add(btnSua);
            Controls.Add(btnHuyDH);
            Controls.Add(dataDHN);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_ThemSP);
            Controls.Add(dataDHNCT);
            Controls.Add(btnThemDonHang);
            Controls.Add(labelSL);
            Controls.Add(soLuong);
            Controls.Add(txtMaSP);
            Controls.Add(labelMaSP);
            Controls.Add(labelTenSP);
            Controls.Add(dateTimeNgayTao);
            Controls.Add(labelNgayTao);
            Controls.Add(txtTongTien);
            Controls.Add(label1);
            Controls.Add(txtMaDH);
            Controls.Add(label_MaDHB);
            Controls.Add(txtSDTNcc);
            Controls.Add(label_SDTNCC);
            Name = "frmNhapSP";
            Text = "frmNhapSP";
            Load += frmNhapSP_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataDHN).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataDHNCT).EndInit();
            ((System.ComponentModel.ISupportInitialize)soLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSua;
        private Button btnHuyDH;
        private DataGridView dataDHN;
        private Button btn_Xoa;
        private Button btn_ThemSP;
        private DataGridView dataDHNCT;
        private Button btnThemDonHang;
        private Label labelSL;
        private NumericUpDown soLuong;
        private TextBox txtMaSP;
        private Label labelMaSP;
        private Label labelTenSP;
        private DateTimePicker dateTimeNgayTao;
        private Label labelNgayTao;
        private TextBox txtTongTien;
        private Label label1;
        private TextBox txtMaDH;
        private Label label_MaDHB;
        private TextBox txtSDTNcc;
        private Label label_SDTNCC;
        private Label lbGiaNhap;
        private TextBox txtGiaNhap;
        private TextBox txtTenSP;
    }
}