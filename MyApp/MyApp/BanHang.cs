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
    public partial class BanHang : Form
    {
        string sCon = "Data Source=LAPTOP-INU6NAIB;Initial Catalog=Nhom48K21106;Integrated Security=True;Trust Server Certificate=True";
        public BanHang()
        {
            InitializeComponent();
        }

        private void BanHang_Load(object sender, EventArgs e)
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
            string sQuerry = "select maDHB, tongTien from donHangBan";


            SqlCommand cmd = new SqlCommand(sQuerry, con);
            //cmd.Parameters.AddWithValue("@maDHB", sMaDHB);
            SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "donHangBan");
            dataDHB.DataSource = ds.Tables["donHangBan"];


            con.Close();

            LoadComboBoxData();
            cboTenSP.SelectedIndexChanged += cboTenSP_SelectedIndexChanged;
        }

        private void labelMaSP_Click(object sender, EventArgs e)
        {

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
            string sSDT = txtSDTKhachHang.Text;
            if (string.IsNullOrEmpty(sSDT))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng.");
                return;
            }

            // Gọi stored procedure kiểm tra và thêm đơn hàng
            string sQuery = "exec kiemTraDonHangBan @SDT, @ret output";
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
                    string sQueryMaDHB = "SELECT TOP 1 maDHB, tongTien FROM donHangBan ORDER BY maDHB DESC";
                    SqlCommand cmdGetMaDHB = new SqlCommand(sQueryMaDHB, con);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmdGetMaDHB);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        txtMaDH.Text = dt.Rows[0]["maDHB"].ToString(); // Hiển thị mã đơn hàng vào TextBox
                        dataDHB.DataSource = dt;                      // Cập nhật DataGridView
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

        //private void btn_Sua_Click(object sender, EventArgs e)
        //{
        //    // Bước 1
        //    SqlConnection con = new SqlConnection(sCon);
        //    try
        //    {
        //        con.Open();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi kết nối tới DB");
        //    }

        //    string sSoLuong = soLuong.Text;
        //    string sMaDHB = txtMaDH.Text;
        //    string sMaSP = txtMaSP.Text;
        //    string sQuery = "update donHangBanCT set soLuong = @soLuong where maDHB = @maDHB and maSP = @maSP";

        //    SqlCommand cmd = new SqlCommand(sQuery, con);
        //    cmd.Parameters.AddWithValue("@maDHB", sMaDHB);
        //    cmd.Parameters.AddWithValue("@maSP", sMaSP);
        //    cmd.Parameters.AddWithValue("@soLuong", sSoLuong);

        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Cập nhật thành công");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi cập nhật");
        //    }



        //    string sQuerry = "select maSP, tenSP, giaBan, soLuong, thanhTien from v_donHangBanCT WHERE maDHB = @maDHB";
        //    SqlCommand cmdFetch = new SqlCommand(sQuerry, con);
        //    cmdFetch.Parameters.AddWithValue("@maDHB", sMaDHB);

        //    SqlDataAdapter adapter = new SqlDataAdapter(cmdFetch);

        //    DataSet ds = new DataSet();

        //    adapter.Fill(ds, "v_donHangBanCT");

        //    dataDHBCT.DataSource = ds.Tables["v_donHangBanCT"];

        //    string sQuerry2 = "SELECT TOP 1 maDHB, tongTien FROM donHangBan ORDER BY maDHB DESC";
        //    SqlDataAdapter adapter2 = new SqlDataAdapter(sQuerry2, con);

        //    DataSet ds2 = new DataSet();

        //    adapter2.Fill(ds2, "donHangBan");

        //    dataDHB.DataSource = ds2.Tables["donHangBan"];



        //    string tongTien = ds2.Tables["donHangBan"].Rows.Cast<DataRow>()
        //                 .Where(row => row["maDHB"].ToString() == sMaDHB)
        //                 .Sum(row => Convert.ToDecimal(row["tongTien"]))
        //                 .ToString();

        //    txtTongTien.Text = tongTien;

        //    if (dataDHB.Rows.Count > 0)
        //    {
        //        dataDHB.ClearSelection();
        //        foreach (DataGridViewRow row in dataDHB.Rows)
        //        {
        //            if (row.Cells["maDHB"].Value.ToString() == sMaDHB)
        //            {
        //                row.Selected = true; // Đặt dòng được chọn
        //                break;
        //            }
        //        }
        //    }

        //}

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


            string sMaDHB = txtMaDH.Text;
            string sTenSP = cboTenSP.Text;
            int sSoLuong = (int)soLuong.Value;

            string sQuery = "exec themDHBCT @maDHB, @tenSP, @soLuong, @ret output";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            cmd.Parameters.AddWithValue("@maDHB", sMaDHB);
            cmd.Parameters.AddWithValue("@tenSP", sTenSP);
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

            string sQuerry = "select maSP, tenSP, giaBan, soLuong, thanhTien from v_donHangBanCT WHERE maDHB = @maDHB";
            SqlCommand cmdFetch = new SqlCommand(sQuerry, con);
            cmdFetch.Parameters.AddWithValue("@maDHB", sMaDHB);

            SqlDataAdapter adapter = new SqlDataAdapter(cmdFetch);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "v_donHangBanCT");

            dataDHBCT.DataSource = ds.Tables["v_donHangBanCT"];

            string sQuerry2 = "SELECT TOP 1 maDHB, tongTien FROM donHangBan ORDER BY maDHB DESC";
            SqlDataAdapter adapter2 = new SqlDataAdapter(sQuerry2, con);

            DataSet ds2 = new DataSet();

            adapter2.Fill(ds2, "donHangBan");

            dataDHB.DataSource = ds2.Tables["donHangBan"];



            string tongTien = ds2.Tables["donHangBan"].Rows.Cast<DataRow>()
                         .Where(row => row["maDHB"].ToString() == sMaDHB)
                         .Sum(row => Convert.ToDecimal(row["tongTien"]))
                         .ToString();

            txtTongTien.Text = tongTien;

            if (dataDHB.Rows.Count > 0)
            {
                dataDHB.ClearSelection();
                foreach (DataGridViewRow row in dataDHB.Rows)
                {
                    if (row.Cells["maDHB"].Value.ToString() == sMaDHB)
                    {
                        row.Selected = true; // Đặt dòng được chọn
                        break;
                    }
                }
            }
        }

        private void LoadComboBoxData()
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();

                    // Tải dữ liệu Tên sản phẩm
                    string sQuerySP = "SELECT tenSP, maSP FROM sanPham";
                    SqlDataAdapter adapterSP = new SqlDataAdapter(sQuerySP, con);
                    DataTable dtSP = new DataTable();
                    adapterSP.Fill(dtSP);
                    cboTenSP.DataSource = dtSP;
                    cboTenSP.DisplayMember = "tenSP";
                    cboTenSP.ValueMember = "maSP";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu ComboBox: " + ex.Message);
                }
            }
        }

        private void cboTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTenSP.SelectedValue != null)
            {
                txtMaSP.Text = cboTenSP.SelectedValue.ToString(); // Gán mã sản phẩm vào TextBox
            }
        }

        private void dataDHBCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.Text = dataDHBCT.Rows[e.RowIndex].Cells["maSP"].Value.ToString();
            cboTenSP.Text = dataDHBCT.Rows[e.RowIndex].Cells["tenSP"].Value.ToString();
            soLuong.Text = dataDHBCT.Rows[e.RowIndex].Cells["soLuong"].Value.ToString();
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
                string sMaDHB = txtMaDH.Text;
                string sMaSP = cboTenSP.SelectedValue.ToString();

                string sQuery = "delete donHangBanCT where maDHB = @maDHB and maSP = @maSP";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@maDHB", sMaDHB);
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


                string sQuerry = "select maSP, tenSP, giaBan, soLuong, thanhTien from v_donHangBanCT WHERE maDHB = @maDHB";
                SqlCommand cmdFetch = new SqlCommand(sQuerry, con);
                cmdFetch.Parameters.AddWithValue("@maDHB", sMaDHB);

                SqlDataAdapter adapter = new SqlDataAdapter(cmdFetch);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "v_donHangBanCT");

                dataDHBCT.DataSource = ds.Tables["v_donHangBanCT"];

                string sQuerry2 = "SELECT TOP 1 maDHB, tongTien FROM donHangBan ORDER BY maDHB DESC";
                SqlDataAdapter adapter2 = new SqlDataAdapter(sQuerry2, con);

                DataSet ds2 = new DataSet();

                adapter2.Fill(ds2, "donHangBan");

                dataDHB.DataSource = ds2.Tables["donHangBan"];



                string tongTien = ds2.Tables["donHangBan"].Rows.Cast<DataRow>()
                             .Where(row => row["maDHB"].ToString() == sMaDHB)
                             .Sum(row => Convert.ToDecimal(row["tongTien"]))
                             .ToString();

                txtTongTien.Text = tongTien;

                if (dataDHB.Rows.Count > 0)
                {
                    dataDHB.ClearSelection();
                    foreach (DataGridViewRow row in dataDHB.Rows)
                    {
                        if (row.Cells["maDHB"].Value.ToString() == sMaDHB)
                        {
                            row.Selected = true; // Đặt dòng được chọn
                            break;
                        }
                    }
                }
                con.Close();
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
                string sMaDHB = txtMaDH.Text;

                string sQuery = "delete donHangBan where maDHB = @maDHB";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@maDHB", sMaDHB);


                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xoá thành công!");


                    // Xóa dữ liệu DataGridView donHangCT
                    dataDHBCT.DataSource = null;

                    // Xóa dữ liệu TextBox
                    txtMaDH.Clear();
                    txtMaSP.Clear();
                    txtSDTKhachHang.Clear();
                    soLuong.Value = 0;
                    txtTongTien.Clear();
                    cboTenSP.SelectedIndex = -1;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Xảy ra lỗi trong quá trình xoá");
                }


                string sQuerry = "select maDHB, tongTien from donHangBan";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "donHangBan");

                dataDHB.DataSource = ds.Tables["donHangBan"];


                DataTable emptyTable = new DataTable(); // Tạo một bảng trống
                dataDHBCT.DataSource = emptyTable; //

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
            string sMaDHB = txtMaDH.Text;
            string sMaSP = txtMaSP.Text;
            string sQuery = "update donHangBanCT set soLuong = @soLuong where maDHB = @maDHB and maSP = @maSP";

            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@maDHB", sMaDHB);
            cmd.Parameters.AddWithValue("@maSP", sMaSP);
            cmd.Parameters.AddWithValue("@soLuong", sSoLuong);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật");
            }



            string sQuerry = "select maSP, tenSP, giaBan, soLuong, thanhTien from v_donHangBanCT WHERE maDHB = @maDHB";
            SqlCommand cmdFetch = new SqlCommand(sQuerry, con);
            cmdFetch.Parameters.AddWithValue("@maDHB", sMaDHB);

            SqlDataAdapter adapter = new SqlDataAdapter(cmdFetch);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "v_donHangBanCT");

            dataDHBCT.DataSource = ds.Tables["v_donHangBanCT"];

            string sQuerry2 = "SELECT TOP 1 maDHB, tongTien FROM donHangBan ORDER BY maDHB DESC";
            SqlDataAdapter adapter2 = new SqlDataAdapter(sQuerry2, con);

            DataSet ds2 = new DataSet();

            adapter2.Fill(ds2, "donHangBan");

            dataDHB.DataSource = ds2.Tables["donHangBan"];



            string tongTien = ds2.Tables["donHangBan"].Rows.Cast<DataRow>()
                         .Where(row => row["maDHB"].ToString() == sMaDHB)
                         .Sum(row => Convert.ToDecimal(row["tongTien"]))
                         .ToString();

            txtTongTien.Text = tongTien;

            if (dataDHB.Rows.Count > 0)
            {
                dataDHB.ClearSelection();
                foreach (DataGridViewRow row in dataDHB.Rows)
                {
                    if (row.Cells["maDHB"].Value.ToString() == sMaDHB)
                    {
                        row.Selected = true; // Đặt dòng được chọn
                        break;
                    }
                }
            }
        }
    }
}
