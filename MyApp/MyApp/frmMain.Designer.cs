namespace MyApp
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            panelLeft = new Panel();
            btnSP = new Button();
            picture1 = new PictureBox();
            btnNCC = new Button();
            btnKH = new Button();
            btnDHN = new Button();
            btnDHB = new Button();
            panelTop = new Panel();
            labelHome = new Label();
            panelBody = new Panel();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture1).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = SystemColors.ActiveCaption;
            panelLeft.Controls.Add(btnSP);
            panelLeft.Controls.Add(picture1);
            panelLeft.Controls.Add(btnNCC);
            panelLeft.Controls.Add(btnKH);
            panelLeft.Controls.Add(btnDHN);
            panelLeft.Controls.Add(btnDHB);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(242, 767);
            panelLeft.TabIndex = 0;
            panelLeft.Paint += panel1_Paint;
            // 
            // btnSP
            // 
            btnSP.Location = new Point(0, 515);
            btnSP.Name = "btnSP";
            btnSP.Size = new Size(242, 52);
            btnSP.TabIndex = 5;
            btnSP.Text = "Sản phẩm";
            btnSP.UseVisualStyleBackColor = true;
            btnSP.Click += btnSP_Click;
            // 
            // picture1
            // 
            picture1.Image = (Image)resources.GetObject("picture1.Image");
            picture1.Location = new Point(54, 12);
            picture1.Name = "picture1";
            picture1.Size = new Size(120, 87);
            picture1.SizeMode = PictureBoxSizeMode.StretchImage;
            picture1.TabIndex = 4;
            picture1.TabStop = false;
            picture1.Click += picture1_Click;
            // 
            // btnNCC
            // 
            btnNCC.Location = new Point(0, 422);
            btnNCC.Name = "btnNCC";
            btnNCC.Size = new Size(242, 52);
            btnNCC.TabIndex = 3;
            btnNCC.Text = "Nhà cung cấp";
            btnNCC.UseVisualStyleBackColor = true;
            btnNCC.Click += btnNCC_Click;
            // 
            // btnKH
            // 
            btnKH.Location = new Point(0, 332);
            btnKH.Name = "btnKH";
            btnKH.Size = new Size(242, 52);
            btnKH.TabIndex = 2;
            btnKH.Text = "Khách hàng";
            btnKH.UseVisualStyleBackColor = true;
            btnKH.Click += btnKH_Click;
            // 
            // btnDHN
            // 
            btnDHN.Location = new Point(0, 244);
            btnDHN.Name = "btnDHN";
            btnDHN.Size = new Size(242, 52);
            btnDHN.TabIndex = 1;
            btnDHN.Text = "Đơn hàng nhập";
            btnDHN.UseVisualStyleBackColor = true;
            btnDHN.Click += btnDHN_Click;
            // 
            // btnDHB
            // 
            btnDHB.Location = new Point(0, 153);
            btnDHB.Name = "btnDHB";
            btnDHB.Size = new Size(242, 52);
            btnDHB.TabIndex = 0;
            btnDHB.Text = "Đơn hàng bán";
            btnDHB.UseVisualStyleBackColor = true;
            btnDHB.Click += btnDHB_Click;
            // 
            // panelTop
            // 
            panelTop.BackColor = SystemColors.ActiveCaption;
            panelTop.Controls.Add(labelHome);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(242, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(849, 99);
            panelTop.TabIndex = 1;
            panelTop.Paint += panelTop_Paint;
            // 
            // labelHome
            // 
            labelHome.AutoSize = true;
            labelHome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHome.ForeColor = SystemColors.Control;
            labelHome.Location = new Point(37, 33);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(82, 32);
            labelHome.TabIndex = 0;
            labelHome.Text = "Home";
            // 
            // panelBody
            // 
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(242, 99);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(849, 668);
            panelBody.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 767);
            Controls.Add(panelBody);
            Controls.Add(panelTop);
            Controls.Add(panelLeft);
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture1).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Panel panelTop;
        private Button btnDHB;
        private Panel panelBody;
        private Button btnDHN;
        private PictureBox picture1;
        private Button btnNCC;
        private Button btnKH;
        private Button btnSP;
        private Label labelHome;
    }
}