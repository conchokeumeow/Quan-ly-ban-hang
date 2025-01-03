namespace MyApp
{
    partial class BanHang
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
            label_SDTKhachHang = new Label();
            txtSDTKhachHang = new TextBox();
            label_MaDHB = new Label();
            txtMaDH = new TextBox();
            label1 = new Label();
            txtTongTien = new TextBox();
            dateTimeNgayTao = new DateTimePicker();
            labelNgayTao = new Label();
            labelTenSP = new Label();
            cboTenSP = new ComboBox();
            txtMaSP = new TextBox();
            labelMaSP = new Label();
            labelSL = new Label();
            soLuong = new NumericUpDown();
            btnThemDonHang = new Button();
            dataDHBCT = new DataGridView();
            btn_ThemSP = new Button();
            btn_Xoa = new Button();
            dataDHB = new DataGridView();
            btnHuyDH = new Button();
            btnSua = new Button();
            ((System.ComponentModel.ISupportInitialize)soLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataDHBCT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataDHB).BeginInit();
            SuspendLayout();
            // 
            // label_SDTKhachHang
            // 
            label_SDTKhachHang.AutoSize = true;
            label_SDTKhachHang.Location = new Point(29, 36);
            label_SDTKhachHang.Name = "label_SDTKhachHang";
            label_SDTKhachHang.Size = new Size(145, 25);
            label_SDTKhachHang.TabIndex = 0;
            label_SDTKhachHang.Text = "SĐT Khách hàng:";
            // 
            // txtSDTKhachHang
            // 
            txtSDTKhachHang.Location = new Point(180, 30);
            txtSDTKhachHang.Name = "txtSDTKhachHang";
            txtSDTKhachHang.Size = new Size(181, 31);
            txtSDTKhachHang.TabIndex = 1;
            // 
            // label_MaDHB
            // 
            label_MaDHB.AutoSize = true;
            label_MaDHB.Location = new Point(27, 103);
            label_MaDHB.Name = "label_MaDHB";
            label_MaDHB.Size = new Size(125, 25);
            label_MaDHB.TabIndex = 2;
            label_MaDHB.Text = "Mã Đơn hàng:";
            // 
            // txtMaDH
            // 
            txtMaDH.Location = new Point(180, 97);
            txtMaDH.Name = "txtMaDH";
            txtMaDH.Size = new Size(181, 31);
            txtMaDH.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(425, 103);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 4;
            label1.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(536, 97);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(194, 31);
            txtTongTien.TabIndex = 5;
            // 
            // dateTimeNgayTao
            // 
            dateTimeNgayTao.Location = new Point(536, 31);
            dateTimeNgayTao.Name = "dateTimeNgayTao";
            dateTimeNgayTao.Size = new Size(268, 31);
            dateTimeNgayTao.TabIndex = 8;
            // 
            // labelNgayTao
            // 
            labelNgayTao.AutoSize = true;
            labelNgayTao.Location = new Point(425, 34);
            labelNgayTao.Name = "labelNgayTao";
            labelNgayTao.Size = new Size(89, 25);
            labelNgayTao.TabIndex = 7;
            labelNgayTao.Text = "Ngày tạo:";
            // 
            // labelTenSP
            // 
            labelTenSP.AutoSize = true;
            labelTenSP.Location = new Point(29, 176);
            labelTenSP.Name = "labelTenSP";
            labelTenSP.Size = new Size(67, 25);
            labelTenSP.TabIndex = 13;
            labelTenSP.Text = "Tên SP:";
            // 
            // cboTenSP
            // 
            cboTenSP.FormattingEnabled = true;
            cboTenSP.Location = new Point(180, 168);
            cboTenSP.Name = "cboTenSP";
            cboTenSP.Size = new Size(181, 33);
            cboTenSP.TabIndex = 12;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(536, 170);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(194, 31);
            txtMaSP.TabIndex = 15;
            // 
            // labelMaSP
            // 
            labelMaSP.AutoSize = true;
            labelMaSP.Location = new Point(425, 176);
            labelMaSP.Name = "labelMaSP";
            labelMaSP.Size = new Size(66, 25);
            labelMaSP.TabIndex = 14;
            labelMaSP.Text = "Mã SP:";
            labelMaSP.Click += labelMaSP_Click;
            // 
            // labelSL
            // 
            labelSL.AutoSize = true;
            labelSL.Location = new Point(832, 173);
            labelSL.Name = "labelSL";
            labelSL.Size = new Size(89, 25);
            labelSL.TabIndex = 22;
            labelSL.Text = "Số lượng:";
            // 
            // soLuong
            // 
            soLuong.Location = new Point(943, 169);
            soLuong.Name = "soLuong";
            soLuong.Size = new Size(53, 31);
            soLuong.TabIndex = 21;
            // 
            // btnThemDonHang
            // 
            btnThemDonHang.Location = new Point(867, 26);
            btnThemDonHang.Name = "btnThemDonHang";
            btnThemDonHang.Size = new Size(129, 44);
            btnThemDonHang.TabIndex = 23;
            btnThemDonHang.Text = "Thêm ĐH";
            btnThemDonHang.UseVisualStyleBackColor = true;
            btnThemDonHang.Click += btnThemDonHang_Click;
            // 
            // dataDHBCT
            // 
            dataDHBCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataDHBCT.Location = new Point(444, 342);
            dataDHBCT.Name = "dataDHBCT";
            dataDHBCT.RowHeadersWidth = 62;
            dataDHBCT.Size = new Size(761, 306);
            dataDHBCT.TabIndex = 24;
            dataDHBCT.CellClick += dataDHBCT_CellClick;
            // 
            // btn_ThemSP
            // 
            btn_ThemSP.Location = new Point(62, 235);
            btn_ThemSP.Name = "btn_ThemSP";
            btn_ThemSP.Size = new Size(129, 44);
            btn_ThemSP.TabIndex = 25;
            btn_ThemSP.Text = "Thêm mới";
            btn_ThemSP.UseVisualStyleBackColor = true;
            btn_ThemSP.Click += btn_ThemSP_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.BackColor = Color.Red;
            btn_Xoa.ForeColor = SystemColors.ButtonHighlight;
            btn_Xoa.Location = new Point(494, 235);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(129, 44);
            btn_Xoa.TabIndex = 27;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = false;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // dataDHB
            // 
            dataDHB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataDHB.Location = new Point(29, 342);
            dataDHB.Name = "dataDHB";
            dataDHB.RowHeadersWidth = 62;
            dataDHB.Size = new Size(378, 306);
            dataDHB.TabIndex = 28;
            // 
            // btnHuyDH
            // 
            btnHuyDH.BackColor = Color.Red;
            btnHuyDH.ForeColor = SystemColors.ButtonHighlight;
            btnHuyDH.Location = new Point(1055, 26);
            btnHuyDH.Name = "btnHuyDH";
            btnHuyDH.Size = new Size(129, 44);
            btnHuyDH.TabIndex = 29;
            btnHuyDH.Text = "Hủy";
            btnHuyDH.UseVisualStyleBackColor = false;
            btnHuyDH.Click += btnHuyDH_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(278, 235);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(129, 44);
            btnSua.TabIndex = 30;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // BanHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1231, 660);
            Controls.Add(btnSua);
            Controls.Add(btnHuyDH);
            Controls.Add(dataDHB);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_ThemSP);
            Controls.Add(dataDHBCT);
            Controls.Add(btnThemDonHang);
            Controls.Add(labelSL);
            Controls.Add(soLuong);
            Controls.Add(txtMaSP);
            Controls.Add(labelMaSP);
            Controls.Add(labelTenSP);
            Controls.Add(cboTenSP);
            Controls.Add(dateTimeNgayTao);
            Controls.Add(labelNgayTao);
            Controls.Add(txtTongTien);
            Controls.Add(label1);
            Controls.Add(txtMaDH);
            Controls.Add(label_MaDHB);
            Controls.Add(txtSDTKhachHang);
            Controls.Add(label_SDTKhachHang);
            Name = "BanHang";
            Text = "BanHang";
            Load += BanHang_Load;
            ((System.ComponentModel.ISupportInitialize)soLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataDHBCT).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataDHB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_SDTKhachHang;
        private TextBox txtSDTKhachHang;
        private Label label_MaDHB;
        private TextBox txtMaDH;
        private Label label1;
        private TextBox txtTongTien;
        private DateTimePicker dateTimeNgayTao;
        private Label labelNgayTao;
        private Label labelTenSP;
        private ComboBox cboTenSP;
        private TextBox txtMaSP;
        private Label labelMaSP;
        private Label labelSL;
        private NumericUpDown soLuong;
        private Button btnThemDonHang;
        private DataGridView dataDHBCT;
        private Button btn_ThemSP;
        private Button btn_Xoa;
        private DataGridView dataDHB;
        private Button btnHuyDH;
        private Button btnSua;
    }
}