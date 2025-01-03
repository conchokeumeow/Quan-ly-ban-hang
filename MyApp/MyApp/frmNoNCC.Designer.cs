namespace MyApp
{
    partial class frmNoNCC
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
            checkBoxTraTien = new CheckBox();
            dateTimePickerTra = new DateTimePicker();
            lbNgayTra = new Label();
            cboMaDH = new ComboBox();
            txtTienNo = new TextBox();
            lbTienNo = new Label();
            dataGridViewNoKH = new DataGridView();
            btnUpdate = new Button();
            btnXoa = new Button();
            dateTimeNgayNo = new DateTimePicker();
            lbNgayNo = new Label();
            lbMaDH = new Label();
            txtSDT = new TextBox();
            lbSDT = new Label();
            btnThemNo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNoKH).BeginInit();
            SuspendLayout();
            // 
            // checkBoxTraTien
            // 
            checkBoxTraTien.AutoSize = true;
            checkBoxTraTien.Location = new Point(665, 154);
            checkBoxTraTien.Name = "checkBoxTraTien";
            checkBoxTraTien.Size = new Size(175, 29);
            checkBoxTraTien.TabIndex = 62;
            checkBoxTraTien.Text = "Trạng thái trả tiền";
            checkBoxTraTien.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerTra
            // 
            dateTimePickerTra.Location = new Point(842, 98);
            dateTimePickerTra.Name = "dateTimePickerTra";
            dateTimePickerTra.Size = new Size(300, 31);
            dateTimePickerTra.TabIndex = 61;
            // 
            // lbNgayTra
            // 
            lbNgayTra.AutoSize = true;
            lbNgayTra.Location = new Point(665, 98);
            lbNgayTra.Name = "lbNgayTra";
            lbNgayTra.Size = new Size(84, 25);
            lbNgayTra.TabIndex = 60;
            lbNgayTra.Text = "Ngày trả:";
            // 
            // cboMaDH
            // 
            cboMaDH.FormattingEnabled = true;
            cboMaDH.Location = new Point(270, 37);
            cboMaDH.Name = "cboMaDH";
            cboMaDH.Size = new Size(172, 33);
            cboMaDH.TabIndex = 59;
            // 
            // txtTienNo
            // 
            txtTienNo.Location = new Point(270, 151);
            txtTienNo.Name = "txtTienNo";
            txtTienNo.Size = new Size(172, 31);
            txtTienNo.TabIndex = 58;
            // 
            // lbTienNo
            // 
            lbTienNo.AutoSize = true;
            lbTienNo.Location = new Point(72, 154);
            lbTienNo.Name = "lbTienNo";
            lbTienNo.Size = new Size(74, 25);
            lbTienNo.TabIndex = 57;
            lbTienNo.Text = "Tiền nợ:";
            // 
            // dataGridViewNoKH
            // 
            dataGridViewNoKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNoKH.Location = new Point(186, 309);
            dataGridViewNoKH.Name = "dataGridViewNoKH";
            dataGridViewNoKH.RowHeadersWidth = 62;
            dataGridViewNoKH.Size = new Size(974, 433);
            dataGridViewNoKH.TabIndex = 56;
            dataGridViewNoKH.CellClick += dataGridViewNoKH_CellClick;
            dataGridViewNoKH.CellContentClick += dataGridViewNoKH_CellContentClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(270, 227);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(129, 48);
            btnUpdate.TabIndex = 55;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.LightCoral;
            btnXoa.Location = new Point(451, 227);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(129, 48);
            btnXoa.TabIndex = 54;
            btnXoa.Text = "Xóa ";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // dateTimeNgayNo
            // 
            dateTimeNgayNo.Location = new Point(842, 32);
            dateTimeNgayNo.Name = "dateTimeNgayNo";
            dateTimeNgayNo.Size = new Size(300, 31);
            dateTimeNgayNo.TabIndex = 53;
            // 
            // lbNgayNo
            // 
            lbNgayNo.AutoSize = true;
            lbNgayNo.Location = new Point(665, 41);
            lbNgayNo.Name = "lbNgayNo";
            lbNgayNo.Size = new Size(84, 25);
            lbNgayNo.TabIndex = 52;
            lbNgayNo.Text = "Ngày nợ:";
            // 
            // lbMaDH
            // 
            lbMaDH.AutoSize = true;
            lbMaDH.Location = new Point(72, 42);
            lbMaDH.Name = "lbMaDH";
            lbMaDH.Size = new Size(72, 25);
            lbMaDH.TabIndex = 51;
            lbMaDH.Text = "Mã ĐH:";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(270, 95);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(172, 31);
            txtSDT.TabIndex = 50;
            // 
            // lbSDT
            // 
            lbSDT.AutoSize = true;
            lbSDT.Location = new Point(72, 98);
            lbSDT.Name = "lbSDT";
            lbSDT.Size = new Size(47, 25);
            lbSDT.TabIndex = 49;
            lbSDT.Text = "SDT:";
            // 
            // btnThemNo
            // 
            btnThemNo.Location = new Point(72, 227);
            btnThemNo.Name = "btnThemNo";
            btnThemNo.Size = new Size(129, 48);
            btnThemNo.TabIndex = 48;
            btnThemNo.Text = "Thêm mới";
            btnThemNo.UseVisualStyleBackColor = true;
            btnThemNo.Click += btnThemNo_Click;
            // 
            // frmNoNCC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1232, 565);
            Controls.Add(checkBoxTraTien);
            Controls.Add(dateTimePickerTra);
            Controls.Add(lbNgayTra);
            Controls.Add(cboMaDH);
            Controls.Add(txtTienNo);
            Controls.Add(lbTienNo);
            Controls.Add(dataGridViewNoKH);
            Controls.Add(btnUpdate);
            Controls.Add(btnXoa);
            Controls.Add(dateTimeNgayNo);
            Controls.Add(lbNgayNo);
            Controls.Add(lbMaDH);
            Controls.Add(txtSDT);
            Controls.Add(lbSDT);
            Controls.Add(btnThemNo);
            Name = "frmNoNCC";
            Text = "frmNoNCC";
            Load += frmNoNCC_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewNoKH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxTraTien;
        private DateTimePicker dateTimePickerTra;
        private Label lbNgayTra;
        private ComboBox cboMaDH;
        private TextBox txtTienNo;
        private Label lbTienNo;
        private DataGridView dataGridViewNoKH;
        private Button btnUpdate;
        private Button btnXoa;
        private DateTimePicker dateTimeNgayNo;
        private Label lbNgayNo;
        private Label lbMaDH;
        private TextBox txtSDT;
        private Label lbSDT;
        private Button btnThemNo;
    }
}