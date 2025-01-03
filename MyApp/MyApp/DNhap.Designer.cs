namespace MyApp
{
    partial class DNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DNhap));
            label_xinchao = new Label();
            labelTK = new Label();
            txtTenDN = new TextBox();
            labelMK = new Label();
            txtMK = new TextBox();
            btnDN = new Button();
            pictureClose = new PictureBox();
            pictureOpen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureOpen).BeginInit();
            SuspendLayout();
            // 
            // label_xinchao
            // 
            label_xinchao.AutoSize = true;
            label_xinchao.BackColor = SystemColors.ButtonFace;
            label_xinchao.Font = new Font("Gabriola", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label_xinchao.ForeColor = SystemColors.ActiveCaption;
            label_xinchao.Location = new Point(271, 9);
            label_xinchao.Name = "label_xinchao";
            label_xinchao.Size = new Size(259, 133);
            label_xinchao.TabIndex = 0;
            label_xinchao.Text = "Welcome";
            label_xinchao.Click += label1_Click;
            // 
            // labelTK
            // 
            labelTK.AutoSize = true;
            labelTK.BackColor = SystemColors.Control;
            labelTK.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTK.ForeColor = SystemColors.ActiveCaption;
            labelTK.Location = new Point(238, 160);
            labelTK.Name = "labelTK";
            labelTK.Size = new Size(129, 29);
            labelTK.TabIndex = 1;
            labelTK.Text = "Username:";
            labelTK.Click += label_username_Click;
            // 
            // txtTenDN
            // 
            txtTenDN.BackColor = SystemColors.ButtonHighlight;
            txtTenDN.Location = new Point(389, 158);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(229, 31);
            txtTenDN.TabIndex = 2;
            txtTenDN.TextChanged += textBox1_TextChanged;
            // 
            // labelMK
            // 
            labelMK.AutoSize = true;
            labelMK.BackColor = SystemColors.Control;
            labelMK.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMK.ForeColor = SystemColors.ActiveCaption;
            labelMK.Location = new Point(238, 236);
            labelMK.Name = "labelMK";
            labelMK.Size = new Size(120, 29);
            labelMK.TabIndex = 3;
            labelMK.Text = "Password:";
            // 
            // txtMK
            // 
            txtMK.BackColor = SystemColors.ButtonHighlight;
            txtMK.Location = new Point(389, 236);
            txtMK.Name = "txtMK";
            txtMK.PasswordChar = '*';
            txtMK.Size = new Size(229, 31);
            txtMK.TabIndex = 4;
            // 
            // btnDN
            // 
            btnDN.BackColor = SystemColors.GradientInactiveCaption;
            btnDN.Location = new Point(340, 320);
            btnDN.Name = "btnDN";
            btnDN.Size = new Size(132, 59);
            btnDN.TabIndex = 5;
            btnDN.Text = "Đăng nhập";
            btnDN.UseVisualStyleBackColor = false;
            btnDN.Click += btnDN_Click;
            // 
            // pictureClose
            // 
            pictureClose.Image = (Image)resources.GetObject("pictureClose.Image");
            pictureClose.Location = new Point(639, 236);
            pictureClose.Name = "pictureClose";
            pictureClose.Size = new Size(37, 31);
            pictureClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureClose.TabIndex = 6;
            pictureClose.TabStop = false;
            pictureClose.Click += pictureClose_Click;
            // 
            // pictureOpen
            // 
            pictureOpen.Image = (Image)resources.GetObject("pictureOpen.Image");
            pictureOpen.Location = new Point(639, 236);
            pictureOpen.Name = "pictureOpen";
            pictureOpen.Size = new Size(37, 31);
            pictureOpen.SizeMode = PictureBoxSizeMode.Zoom;
            pictureOpen.TabIndex = 7;
            pictureOpen.TabStop = false;
            pictureOpen.Click += pictureOpen_Click;
            // 
            // DNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureClose);
            Controls.Add(btnDN);
            Controls.Add(txtMK);
            Controls.Add(labelMK);
            Controls.Add(txtTenDN);
            Controls.Add(labelTK);
            Controls.Add(label_xinchao);
            Controls.Add(pictureOpen);
            Name = "DNhap";
            Text = "frmDN";
            Load += DNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureOpen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_xinchao;
        private Label labelTK;
        private TextBox txtTenDN;
        private Label labelMK;
        private TextBox txtMK;
        private Button btnDN;
        private PictureBox pictureClose;
        private PictureBox pictureOpen;
    }
}