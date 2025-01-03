using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MyApp
{
    public partial class frmNhapSP : Form
    {
        string sCon = "Data Source=LAPTOP-INU6NAIB;Initial Catalog=Nhom48K21106;Integrated Security=True;Trust Server Certificate=True";
        public frmNhapSP()
        {
            InitializeComponent();
        }

        private void soLuong_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmNhapSP_Load(object sender, EventArgs e)
        {

        }

        private void frmNhapSP_Load_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối tới DB");
            }

            //string sMaDHB = txtMaDH.Text;
            string sQuerry = "select maDHN, tongTien from donHangNhap";


            SqlCommand cmd = new SqlCommand(sQuerry, con);
            //cmd.Parameters.AddWithValue("@maDHB", sMaDHB);
            SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "donHangNhap");
            dataDHN.DataSource = ds.Tables["donHangNhap"];


            con.Close();

            //LoadComboBoxData();
            //cboTenSP.SelectedIndexChanged += cboTenSP_SelectedIndexChanged;
        }

        private void btnThemDonHang_Click(object sender, EventArgs e)
        {
            // Tạo kết nối đến CSDL
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối tới CSDL: " + ex.Message);
                return; // Thoát nếu không kết nối được
            }

            // Gán dữ liệu đầu vào
            string sSDT = txtSDTNcc.Text;
            if (string.IsNullOrEmpty(sSDT))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng.");
                return;
            }

            // Gọi stored procedure kiểm tra và thêm đơn hàng
            string sQuery = "exec kiemTraDonHangNhap @SDT, @ret output";
            SqlCommand cmd = new SqlCommand(sQuery, con);
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
                    MessageBox.Show("Thêm đơn hàng thành công!");

                    // Lấy mã đơn hàng mới thêm
                    string sQueryMaDHN = "SELECT TOP 1 maDHN, tongTien FROM donHangNhap ORDER BY maDHN DESC";
                    SqlCommand cmdGetMaDHN = new SqlCommand(sQueryMaDHN, con);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmdGetMaDHN);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        txtMaDH.Text = dt.Rows[0]["maDHN"].ToString(); // Hiển thị mã đơn hàng vào TextBox
                        dataDHN.DataSource = dt;                      // Cập nhật DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã đơn hàng mới.");
                    }
                }
                else
                {
                    MessageBox.Show("Thêm mới không thành công. Kiểm tra thông tin nhập.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm đơn hàng: " + ex.Message);
            }
            finally
            {
                con.Close(); // Đóng kết nối
            }
        }

        private void btn_ThemSP_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối tới DB");
            }


            string sMaDHN = txtMaDH.Text;
            string sTenSP = txtTenSP.Text;
            string sGN = txtGiaNhap.Text;
            int sSoLuong = (int)soLuong.Value;

            string sQuery = "exec spDHNct @maDHN, @tenSP, @giaNhap, @soLuong, @ret output";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            cmd.Parameters.AddWithValue("@maDHN", sMaDHN);
            cmd.Parameters.AddWithValue("@tenSP", sTenSP);
            cmd.Parameters.AddWithValue("@giaNhap", sGN);
            cmd.Parameters.AddWithValue("@soLuong", sSoLuong);

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

            string sQuerry = "select maSP, tenSP, giaNhap, soLuong, thanhTien from view_donNhapCT WHERE maDHN = @maDHN";
            SqlCommand cmdFetch = new SqlCommand(sQuerry, con);
            cmdFetch.Parameters.AddWithValue("@maDHN", sMaDHN);

            SqlDataAdapter adapter = new SqlDataAdapter(cmdFetch);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "view_donNhapCT");

            dataDHNCT.DataSource = ds.Tables["view_donNhapCT"];

            string sQuerry2 = "SELECT TOP 1 maDHN, tongTien FROM donHangNhap ORDER BY maDHN DESC";
            SqlDataAdapter adapter2 = new SqlDataAdapter(sQuerry2, con);

            DataSet ds2 = new DataSet();

            adapter2.Fill(ds2, "donHangNhap");

            dataDHN.DataSource = ds2.Tables["donHangNhap"];



            string tongTien = ds2.Tables["donHangNhap"].Rows.Cast<DataRow>()
                         .Where(row => row["maDHN"].ToString() == sMaDHN)
                         .Sum(row => Convert.ToDecimal(row["tongTien"]))
                         .ToString();

            txtTongTien.Text = tongTien;

            if (dataDHN.Rows.Count > 0)
            {
                dataDHN.ClearSelection();
                foreach (DataGridViewRow row in dataDHN.Rows)
                {
                    if (row.Cells["maDHN"].Value.ToString() == sMaDHN)
                    {
                        row.Selected = true; // Đặt dòng được chọn
                        break;
                    }
                }
            }
        }

        private void btnHuyDH_Click(object sender, EventArgs e)
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
                string sMaDHN = txtMaDH.Text;

                string sQuery = "delete donHangNhap where maDHN = @maDHN";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@maDHN", sMaDHN);


                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xoá thành công!");


                    // Xóa dữ liệu DataGridView donHangCT
                    dataDHN.DataSource = null;

                    // Xóa dữ liệu TextBox
                    txtMaDH.Clear();
                    txtMaSP.Clear();
                    txtSDTNcc.Clear();
                    soLuong.Value = 0;
                    txtTongTien.Clear();
                    txtTenSP.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Xảy ra lỗi trong quá trình xoá");
                }


                string sQuerry = "select maDHN, tongTien from donHangNhap";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "donHangNhap");

                dataDHN.DataSource = ds.Tables["donHangNhap"];


                DataTable emptyTable = new DataTable(); // Tạo một bảng trống
                dataDHNCT.DataSource = emptyTable; //

                con.Close();
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

            int sSoLuong = (int)soLuong.Value;
            string sMaDHN = txtMaDH.Text;
            string sGN = txtGiaNhap.Text;
            string sTenSP = txtTenSP.Text;
            string sMaSP = txtMaSP.Text;
            string sQuery = "update donHangNhapCT set soLuong = @soLuong, giaNhap = @giaNhap where maDHN = @maDHN and maSP = @maSP";

            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@maDHN", sMaDHN);
            cmd.Parameters.AddWithValue("@soLuong", sSoLuong);
            cmd.Parameters.AddWithValue("@tenSP", sTenSP);
            cmd.Parameters.AddWithValue("@giaNhap", sGN);
            cmd.Parameters.AddWithValue("@maSP", sMaSP);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật");
            }



            string sQuerry = "select maSP, tenSP, giaNhap, soLuong, thanhTien from view_donNhapCT WHERE maDHN = @maDHN";
            SqlCommand cmdFetch = new SqlCommand(sQuerry, con);
            cmdFetch.Parameters.AddWithValue("@maDHN", sMaDHN);

            SqlDataAdapter adapter = new SqlDataAdapter(cmdFetch);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "view_donNhapCT");

            dataDHNCT.DataSource = ds.Tables["view_donNhapCT"];

            string sQuerry2 = "SELECT TOP 1 maDHN, tongTien FROM donHangNhap ORDER BY maDHn DESC";
            SqlDataAdapter adapter2 = new SqlDataAdapter(sQuerry2, con);

            DataSet ds2 = new DataSet();

            adapter2.Fill(ds2, "donHangNhap");

            dataDHN.DataSource = ds2.Tables["donHangNhap"];



            string tongTien = ds2.Tables["donHangNhap"].Rows.Cast<DataRow>()
                         .Where(row => row["maDHN"].ToString() == sMaDHN)
                         .Sum(row => Convert.ToDecimal(row["tongTien"]))
                         .ToString();

            txtTongTien.Text = tongTien;

            if (dataDHN.Rows.Count > 0)
            {
                dataDHN.ClearSelection();
                foreach (DataGridViewRow row in dataDHN.Rows)
                {
                    if (row.Cells["maDHN"].Value.ToString() == sMaDHN)
                    {
                        row.Selected = true; // Đặt dòng được chọn
                        break;
                    }
                }
            }
        }

        private void dataDHNCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.Text = dataDHNCT.Rows[e.RowIndex].Cells["maSP"].Value.ToString();
            txtTenSP.Text = dataDHNCT.Rows[e.RowIndex].Cells["tenSP"].Value.ToString();
            soLuong.Text = dataDHNCT.Rows[e.RowIndex].Cells["soLuong"].Value.ToString();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
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
                string sMaDHN = txtMaDH.Text;
                string sMaSP = txtMaSP.Text;

                string sQuery = "delete donHangNhapCT where maDHN = @maDHN and maSP = @maSP";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@maDHN", sMaDHN);
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


                string sQuerry = "select maSP, tenSP, giaNhap, soLuong, thanhTien from view_donNhapCT WHERE maDHN = @maDHN";
                SqlCommand cmdFetch = new SqlCommand(sQuerry, con);
                cmdFetch.Parameters.AddWithValue("@maDHN", sMaDHN);

                SqlDataAdapter adapter = new SqlDataAdapter(cmdFetch);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "view_donNhapCT");

                dataDHNCT.DataSource = ds.Tables["view_donNhapCT"];

                string sQuerry2 = "SELECT TOP 1 maDHN, tongTien FROM donHangNhap ORDER BY maDHN DESC";
                SqlDataAdapter adapter2 = new SqlDataAdapter(sQuerry2, con);

                DataSet ds2 = new DataSet();

                adapter2.Fill(ds2, "donHangNhap");

                dataDHN.DataSource = ds2.Tables["donHangNhap"];



                string tongTien = ds2.Tables["donHangNhap"].Rows.Cast<DataRow>()
                             .Where(row => row["maDHN"].ToString() == sMaDHN)
                             .Sum(row => Convert.ToDecimal(row["tongTien"]))
                             .ToString();

                txtTongTien.Text = tongTien;

                if (dataDHN.Rows.Count > 0)
                {
                    dataDHN.ClearSelection();
                    foreach (DataGridViewRow row in dataDHN.Rows)
                    {
                        if (row.Cells["maDHN"].Value.ToString() == sMaDHN)
                        {
                            row.Selected = true; // Đặt dòng được chọn
                            break;
                        }
                    }
                }
                con.Close();
            }
        }
    }
}
