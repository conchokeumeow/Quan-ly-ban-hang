using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

using System.DirectoryServices.ActiveDirectory;
namespace MyApp
{
    public partial class frmKhachHang : Form
    {
        string sCon = "Data Source=LAPTOP-INU6NAIB;Initial Catalog=Nhom48K21106;Integrated Security=True;Trust Server Certificate=True";
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void labelMaKH_Click(object sender, EventArgs e)
        {

        }

        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            // MessageBox.Show("Bye cô", "Thông báo:");
        }

        private void buttonluu_click(object sender, EventArgs e)
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

            //bước 2 
            // chuẩn bị dl
            // kiểm tra tính hợp lệ

            // gán dữ liệu vào biến
            //string sMaKH = txtMaKH.Text;
            string sTenKH = txtTenKH.Text;
            string sSDT = txtSDT.Text;

            // string sNgay = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            // (cho checkbox) int iTrangThai = 0
            // if(rbRoi.Checked == true)
            // { iTrangThai = 1 }

            string sQuery = "exec kTraKH @SDT, @hoTen, @ret output";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            //cmd.Parameters.AddWithValue("@maKH", sMaKH);
            cmd.Parameters.AddWithValue("@hoTen", sTenKH);
            cmd.Parameters.AddWithValue("@SDT", sSDT);

            SqlParameter retParam = new SqlParameter("@ret", SqlDbType.Int);
            retParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(retParam);


            try
            {
                cmd.ExecuteNonQuery();
                int retValue = Convert.ToInt32(retParam.Value); // Lấy giá trị trả về của @ret

                if (retValue == 1) // Thành công
                {
                    MessageBox.Show("Thêm Khách hàng thành công!");

                    // Lấy mã đơn hàng mới thêm
                    string sQueryKH = "SELECT * from khachHang";
                    SqlCommand cmdKH = new SqlCommand(sQueryKH, con);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmdKH);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        txtMaKH.Text = dt.Rows[0]["maKH"].ToString(); // Hiển thị mã đơn hàng vào TextBox
                        dataGridView1.DataSource = dt;                      // Cập nhật DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã KH mới.");
                    }
                }
                else
                {
                    MessageBox.Show("Thêm mới không thành công. Kiểm tra thông tin nhập.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm KH: " + ex.Message);
            }
            finally
            {
                con.Close(); // Đóng kết nối
            }




        }

        private void frmKhachHang_Load(object sender, EventArgs e)
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
            string sQuerry = "select * from khachHang";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "khachHang");

            dataGridView1.DataSource = ds.Tables["khachHang"];

            con.Close();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dataGridView1.Rows[e.RowIndex].Cells["maKH"].Value.ToString();
            txtTenKH.Text = dataGridView1.Rows[e.RowIndex].Cells["hoTen"].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[e.RowIndex].Cells["SDT"].Value.ToString();

            txtMaKH.Enabled = false;
        }

        private void buttonSua_Click(object sender, EventArgs e)
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
            string sTenKH = txtTenKH.Text;
            string sSDT = txtSDT.Text;
            string sMaKH = txtMaKH.Text;


            string sQuery = "update khachHang set hoTen = @hoTen, SDT = @SDT where maKH = @maKH";

            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@maKH", sMaKH);
            cmd.Parameters.AddWithValue("@hoTen", sTenKH);
            cmd.Parameters.AddWithValue("@SDT", sSDT);

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
            string sQuerry = "select * from khachHang";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "khachHang");

            dataGridView1.DataSource = ds.Tables["khachHang"];

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
                string sMaKH = txtMaKH.Text;

                string sQuery = "delete khachHang  where maKH = @MaKH";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@MaKH", sMaKH);


                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xoá thành công!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Xảy ra lỗi trong quá trình xoá");
                }

                string sQuerry = "select * from khachHang";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "khachHang");

                dataGridView1.DataSource = ds.Tables["khachHang"];


                con.Close();
            }

        }


        private Form currentFormChild;


        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false; // Không phải form cấp cao
            childForm.FormBorderStyle = FormBorderStyle.None; // Bỏ viền form
            childForm.Dock = DockStyle.Fill; // Điền đầy form cha

            this.Controls.Add(childForm); // Thêm form con vào frmDonHang
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void noKhStripMenu_Click(object sender, EventArgs e)
        {
            // Ẩn MenuStrip của form cha
            this.menuStrip1.Visible = false;
            OpenChildForm(new frmNoKH());
        }
    }
}
