using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MyApp
{
    public partial class DNhap : Form
    {
        string sCon = "Data Source=LAPTOP-INU6NAIB;Initial Catalog=Nhom48K21106;Integrated Security=True;Trust Server Certificate=True";

        public DNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_username_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            con.Open();
            //chưa phòng chống sql injection
            //var query = "SELECT * FROM taiKhoan WHERE tenDangNhap='" + txtTenDN.Text + "' AND matKhau='" + txtMK.Text + "'";



            // đã phòng sql injection
            var query = "select * from taiKhoan where tenDangNhap=@tenDangNhap and matKhau=@matKhau";
            var cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("tenDangNhap", txtTenDN.Text);
            cmd.Parameters.AddWithValue("matKhau", txtMK.Text);

            var dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                //C1:
                frmMain a = new frmMain();
                a.Show();
                this.Hide();
                //C2:
                //Form1 a = new Form1();
                //a.ShowDialog();
                //this.Show();
            }

            else
            {
                MessageBox.Show("Lỗi đăng nhập!", "Thông báo"); 
            }
            con.Close();
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            if (txtMK.PasswordChar == '*')
            {
                pictureOpen.BringToFront();
                txtMK.PasswordChar = '\0';
            }
        }

        private void pictureOpen_Click(object sender, EventArgs e)
        {
            if (txtMK.PasswordChar == '\0')
            {
                pictureClose.BringToFront();
                txtMK.PasswordChar = '*';
            }
        }
    }
}
