namespace MyApp
{
    partial class frmSanPham
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
            labelMaSP = new Label();
            labelTenSP = new Label();
            labelSL = new Label();
            labelGB = new Label();
            labelGN = new Label();
            labelHSD = new Label();
            txtMaSP = new TextBox();
            txtTenSP = new TextBox();
            txtSL = new TextBox();
            txtGB = new TextBox();
            txtGN = new TextBox();
            dateTimeHSD = new DateTimePicker();
            dataSanPham = new DataGridView();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dataSanPham).BeginInit();
            SuspendLayout();
            // 
            // labelMaSP
            // 
            labelMaSP.AutoSize = true;
            labelMaSP.ForeColor = Color.Red;
            labelMaSP.Location = new Point(41, 53);
            labelMaSP.Name = "labelMaSP";
            labelMaSP.Size = new Size(120, 25);
            labelMaSP.TabIndex = 0;
            labelMaSP.Text = "Mã sản phẩm";
            // 
            // labelTenSP
            // 
            labelTenSP.AutoSize = true;
            labelTenSP.ForeColor = SystemColors.ActiveCaptionText;
            labelTenSP.Location = new Point(41, 117);
            labelTenSP.Name = "labelTenSP";
            labelTenSP.Size = new Size(121, 25);
            labelTenSP.TabIndex = 1;
            labelTenSP.Text = "Tên sản phẩm";
            // 
            // labelSL
            // 
            labelSL.AutoSize = true;
            labelSL.Location = new Point(41, 192);
            labelSL.Name = "labelSL";
            labelSL.Size = new Size(85, 25);
            labelSL.TabIndex = 2;
            labelSL.Text = "Số lượng";
            labelSL.Click += label3_Click;
            // 
            // labelGB
            // 
            labelGB.AutoSize = true;
            labelGB.Location = new Point(416, 53);
            labelGB.Name = "labelGB";
            labelGB.Size = new Size(72, 25);
            labelGB.TabIndex = 3;
            labelGB.Text = "Giá bán";
            labelGB.Click += label4_Click;
            // 
            // labelGN
            // 
            labelGN.AutoSize = true;
            labelGN.Location = new Point(416, 117);
            labelGN.Name = "labelGN";
            labelGN.Size = new Size(82, 25);
            labelGN.TabIndex = 4;
            labelGN.Text = "Giá nhập";
            // 
            // labelHSD
            // 
            labelHSD.AutoSize = true;
            labelHSD.Location = new Point(416, 192);
            labelHSD.Name = "labelHSD";
            labelHSD.Size = new Size(48, 25);
            labelHSD.TabIndex = 5;
            labelHSD.Text = "HSD";
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(167, 50);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(150, 31);
            txtMaSP.TabIndex = 6;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(168, 114);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(150, 31);
            txtTenSP.TabIndex = 7;
            txtTenSP.TextChanged += textBox2_TextChanged;
            // 
            // txtSL
            // 
            txtSL.Location = new Point(168, 186);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(150, 31);
            txtSL.TabIndex = 8;
            txtSL.TextChanged += textBox3_TextChanged;
            // 
            // txtGB
            // 
            txtGB.Location = new Point(501, 50);
            txtGB.Name = "txtGB";
            txtGB.Size = new Size(150, 31);
            txtGB.TabIndex = 9;
            // 
            // txtGN
            // 
            txtGN.Location = new Point(501, 114);
            txtGN.Name = "txtGN";
            txtGN.Size = new Size(150, 31);
            txtGN.TabIndex = 10;
            // 
            // dateTimeHSD
            // 
            dateTimeHSD.Location = new Point(501, 184);
            dateTimeHSD.Name = "dateTimeHSD";
            dateTimeHSD.Size = new Size(273, 31);
            dateTimeHSD.TabIndex = 11;
            dateTimeHSD.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dataSanPham
            // 
            dataSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataSanPham.Location = new Point(41, 345);
            dataSanPham.Name = "dataSanPham";
            dataSanPham.RowHeadersWidth = 62;
            dataSanPham.Size = new Size(814, 290);
            dataSanPham.TabIndex = 12;
            dataSanPham.CellClick += dataSanPham_CellClick;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(106, 264);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 34);
            btnLuu.TabIndex = 13;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(376, 264);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(641, 264);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(891, 647);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnLuu);
            Controls.Add(dataSanPham);
            Controls.Add(dateTimeHSD);
            Controls.Add(txtGN);
            Controls.Add(txtGB);
            Controls.Add(txtSL);
            Controls.Add(txtTenSP);
            Controls.Add(txtMaSP);
            Controls.Add(labelHSD);
            Controls.Add(labelGN);
            Controls.Add(labelGB);
            Controls.Add(labelSL);
            Controls.Add(labelTenSP);
            Controls.Add(labelMaSP);
            Name = "frmSanPham";
            Text = "frmSanPham";
            FormClosing += frmSanPham_FormClosing;
            Load += frmSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dataSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMaSP;
        private Label labelTenSP;
        private Label labelSL;
        private Label labelGB;
        private Label labelGN;
        private Label labelHSD;
        private TextBox txtMaSP;
        private TextBox txtTenSP;
        private TextBox txtSL;
        private TextBox txtGB;
        private TextBox txtGN;
        private DateTimePicker dateTimeHSD;
        private DataGridView dataSanPham;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
    }
}