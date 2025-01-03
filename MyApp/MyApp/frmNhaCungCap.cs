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
    public partial class frmNhaCungCap : Form
    {
        string sCon = "Data Source=LAPTOP-INU6NAIB;Initial Catalog=Nhom48K21106;Integrated Security=True;Trust Server Certificate=True";
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
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
            string sQuerry = "select * from nhaCungCap";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "nhaCungCap");

            dataGridView1.DataSource = ds.Tables["nhaCungCap"];

            con.Close();
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

            //bước 2 
            // chuẩn bị dl
            // kiểm tra tính hợp lệ

            // gán dữ liệu vào biến
            //string sMaKH = txtMaKH.Text;
            string sTenNCC = txtTenNCC.Text;
            string sSDT = txtSDT.Text;

            // string sNgay = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            // (cho checkbox) int iTrangThai = 0
            // if(rbRoi.Checked == true)
            // { iTrangThai = 1 }

            string sQuery = "exec kTraNCC @SDT, @hoTen, @ret output";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            //cmd.Parameters.AddWithValue("@maKH", sMaKH);
            cmd.Parameters.AddWithValue("@hoTen", sTenNCC);
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
                    MessageBox.Show("Thêm NCC thành công!");

                    // Lấy mã đơn hàng mới thêm
                    string sQueryNhaCC = "SELECT * from nhaCungCap";
                    SqlCommand cmdNCC = new SqlCommand(sQueryNhaCC, con);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmdNCC);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        txtMaNCC.Text = dt.Rows[0]["maNCC"].ToString(); // Hiển thị mã đơn hàng vào TextBox
                        dataGridView1.DataSource = dt;                      // Cập nhật DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã NCC mới.");
                    }
                }
                else
                {
                    MessageBox.Show("Thêm mới không thành công. Kiểm tra thông tin nhập.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm NCC: " + ex.Message);
            }
            finally
            {
                con.Close(); // Đóng kết nối
            }

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
            string sTenNCC = txtTenNCC.Text;
            string sSDT = txtSDT.Text;
            string sMaNCC = txtMaNCC.Text;


            string sQuery = "update nhaCungCap set tenNCC = @hoTen, SDT = @SDT where maNCC = @maNCC";

            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@maNCC", sMaNCC);
            cmd.Parameters.AddWithValue("@hoTen", sTenNCC);
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
            string sQuerry = "select * from nhaCungCap";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "nhaCungCap");

            dataGridView1.DataSource = ds.Tables["nhaCungCap"];

            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNCC.Text = dataGridView1.Rows[e.RowIndex].Cells["maNCC"].Value.ToString();
            txtTenNCC.Text = dataGridView1.Rows[e.RowIndex].Cells["tenNCC"].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[e.RowIndex].Cells["SDT"].Value.ToString();

            txtMaNCC.Enabled = false;
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
                string sMaNCC = txtMaNCC.Text;

                string sQuery = "delete nhaCungCap where maNCC = @maNCC";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@maNCC", sMaNCC);


                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xoá thành công!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Xảy ra lỗi trong quá trình xoá");
                }

                string sQuerry = "select * from nhaCungCap";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "nhaCungCap");

                dataGridView1.DataSource = ds.Tables["nhaCungCap"];


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

        private void noNCC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNoNCC());
        }
    }
}
