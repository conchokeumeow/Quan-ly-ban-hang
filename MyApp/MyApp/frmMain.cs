using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void quảnLýĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSanPham());
            labelHome.Text = btnSP.Text;
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang());
            labelHome.Text = btnKH.Text;
        }

        private void btnDHB_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDonHang());
            labelHome.Text = btnDHB.Text;
        }

        private void picture1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            labelHome.Text = "Home";
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhaCungCap());
            labelHome.Text = btnNCC.Text;
        }

        private void btnDHN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhapHang());
            labelHome.Text = btnDHN.Text;
        }
    }
}
