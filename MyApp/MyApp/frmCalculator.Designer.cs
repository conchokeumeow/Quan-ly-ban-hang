namespace MyApp
{
    partial class frmCalculator
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
            txtSo1 = new TextBox();
            txtSo2 = new TextBox();
            txtKQ = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            SuspendLayout();
            // 
            // txtSo1
            // 
            txtSo1.Location = new Point(117, 87);
            txtSo1.Name = "txtSo1";
            txtSo1.Size = new Size(150, 31);
            txtSo1.TabIndex = 0;
            // 
            // txtSo2
            // 
            txtSo2.Location = new Point(512, 87);
            txtSo2.Name = "txtSo2";
            txtSo2.Size = new Size(150, 31);
            txtSo2.TabIndex = 1;
            txtSo2.TextChanged += textBox2_TextChanged;
            // 
            // txtKQ
            // 
            txtKQ.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKQ.ForeColor = Color.Red;
            txtKQ.Location = new Point(317, 183);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(150, 45);
            txtKQ.TabIndex = 2;
            txtKQ.TextChanged += textBox3_TextChanged;
            // 
            // btnCong
            // 
            btnCong.Location = new Point(114, 271);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(112, 34);
            btnCong.TabIndex = 3;
            btnCong.Text = "Cộng";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // btnTru
            // 
            btnTru.Location = new Point(335, 271);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(112, 34);
            btnTru.TabIndex = 4;
            btnTru.Text = "Trừ";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += button2_Click;
            // 
            // btnNhan
            // 
            btnNhan.Location = new Point(506, 276);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(112, 34);
            btnNhan.TabIndex = 5;
            btnNhan.Text = "Nhân";
            btnNhan.UseVisualStyleBackColor = true;
            // 
            // frmCalculator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNhan);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(txtKQ);
            Controls.Add(txtSo2);
            Controls.Add(txtSo1);
            Name = "frmCalculator";
            Text = "frmCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSo1;
        private TextBox txtSo2;
        private TextBox txtKQ;
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
    }
}