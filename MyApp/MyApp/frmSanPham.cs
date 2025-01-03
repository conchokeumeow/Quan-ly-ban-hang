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

    public partial class frmSanPham : Form
    {
        string sCon = "Data Source=LAPTOP-INU6NAIB;Initial Catalog=Nhom48K21106;Integrated Security=True;Trust Server Certificate=True";

        public frmSanPham()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //bước 1
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối tới DB");
            }

            //gán dl
            string sMaSP = txtMaSP.Text;
            string sTenSP = txtTenSP.Text;
            string sSoLuongSP = txtSL.Text;
            string sGiaBan = txtGB.Text;
            string sGiaNhap = txtGN.Text;
            string sHSD = dateTimeHSD.Value.ToString("yyyy-MM-dd");

            string sQuery = "exec kiemTraVaChenSanPham @TenSP, @soLuongSP, @giaNhap, @giaBan, @HSD, @ret output";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            cmd.Parameters.AddWithValue("@TenSP", sTenSP);
            cmd.Parameters.AddWithValue("@soLuongSP", sSoLuongSP);
            cmd.Parameters.AddWithValue("@giaNhap", sGiaNhap);
            cmd.Parameters.AddWithValue("@giaBan", sGiaBan);
            cmd.Parameters.AddWithValue("@HSD", sHSD);


            SqlParameter retParam = new SqlParameter("@ret", SqlDbType.Int);
            retParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(retParam);

            try
            {
                cmd.ExecuteNonQuery();

                // Lấy giá trị @ret
                int retValue = Convert.ToInt32(retParam.Value);
                if (retValue == 1)
                {
                    MessageBox.Show("Thêm mới thành công!");
                }
                else if (retValue == 0)
                {
                    MessageBox.Show("Lỗi trong quá trình thêm mới");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới: " + ex.Message);
            }
            // Bước 2: lấy dl về
            string sQuerry = "select * from sanPham";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "sanPham");

            dataSanPham.DataSource = ds.Tables["sanPham"];

            con.Close();

        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            // Bước 1
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối tới DB");
            }

            // Bước 2: lấy dl về
            string sQuerry = "select * from sanPham";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "sanPham");

            dataSanPham.DataSource = ds.Tables["sanPham"];

            con.Close();
        }

        private void dataSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.Text = dataSanPham.Rows[e.RowIndex].Cells["maSP"].Value.ToString();
            txtTenSP.Text = dataSanPham.Rows[e.RowIndex].Cells["tenSP"].Value.ToString();
            txtSL.Text = dataSanPham.Rows[e.RowIndex].Cells["soLuongSP"].Value.ToString();
            txtGB.Text = dataSanPham.Rows[e.RowIndex].Cells["giaBan"].Value.ToString();
            txtGN.Text = dataSanPham.Rows[e.RowIndex].Cells["giaNhap"].Value.ToString();
            dateTimeHSD.Value = Convert.ToDateTime(dataSanPham.Rows[e.RowIndex].Cells["HSD"].Value);

            txtMaSP.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Bước 1
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối tới DB");
            }

            // Bước 2: lấy giá trị
            string sMaSP = txtMaSP.Text;
            string sTenSP = txtTenSP.Text;
            string sSoLuongSP = txtSL.Text;
            string sGiaBan = txtGB.Text;
            string sGiaNhap = txtGN.Text;
            //string sHSD = dateTimeHSD.Value.ToString("yyyy-MM-dd");


            string sQuery = "UPDATE sanPham SET tenSP = @tenSP, soLuongSP = @soLuongSP, giaBan = @giaBan, giaNhap = @giaNhap WHERE maSP = @maSP";


            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaSP", sMaSP);
            cmd.Parameters.AddWithValue("@TenSP", sTenSP);
            cmd.Parameters.AddWithValue("@soLuongSP", sSoLuongSP);
            cmd.Parameters.AddWithValue("@giaNhap", sGiaNhap);
            cmd.Parameters.AddWithValue("@giaBan", sGiaBan);
            //cmd.Parameters.AddWithValue("@HSD", sHSD);



            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật");
            }

            // Bước 2: lấy dl về
            string sQuerry = "select * from sanPham";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "sanPham");

            dataSanPham.DataSource = ds.Tables["sanPham"];

            con.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Chắc chưa má?", "Thông báo", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            {
                // Bước 1
                SqlConnection con = new SqlConnection(sCon);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");

                }
                //Bước 2
                //Lấy giá trị
                string sMaSP = txtMaSP.Text;

                string sQuery = "delete sanPham  where maSP = @maSP";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@maSP", sMaSP);


                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xoá thành công!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Xảy ra lỗi trong quá trình xoá");
                }

                // Bước 2: lấy dl về
                string sQuerry = "select * from sanPham";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "sanPham");

                dataSanPham.DataSource = ds.Tables["sanPham"];

                con.Close();
            }
        }
    }
}
