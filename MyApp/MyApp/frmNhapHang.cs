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
    public partial class frmNhapHang : Form
    {
        string sCon = "Data Source=LAPTOP-INU6NAIB;Initial Catalog=Nhom48K21106;Integrated Security=True;Trust Server Certificate=True";

        public frmNhapHang()
        {
            InitializeComponent();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
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

            string sQuerry = "SELECT * FROM donHangNhap;";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "donHangNhap");
            dataGridViewDonHangNhap.DataSource = ds.Tables["donHangNhap"];

            con.Close();

            LoadComboBoxData();
            cboTenSP.SelectedIndexChanged += cboTenSP_SelectedIndexChanged;
        }

        private void btnUpdateDH_Click(object sender, EventArgs e)
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

            string sSDT = txtSDT_NCC.Text;
            string sMaDHN = txtMaDH.Text;
            string sQuery = "update donHangNhap set SDT = @SDT where maDHN = @maDHN";

            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@maDHB", sMaDHN);
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



            string sQuerry = "SELECT * FROM donHangNhap";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "donHangNhap");

            dataGridViewDonHangNhap.DataSource = ds.Tables["donHangNhap"];

            con.Close();

        }

        private void dataGridViewDonHangNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu dòng được chọn hợp lệ
            if (e.RowIndex >= 0 && dataGridViewDonHangNhap.Rows[e.RowIndex].Cells["maDHN"].Value != null)
            {
                // Lấy thông tin sản phẩm từ dòng được chọn
                txtSDT_NCC.Text = dataGridViewDonHangNhap.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
                txtMaDH.Text = dataGridViewDonHangNhap.Rows[e.RowIndex].Cells["maDHN"].Value.ToString();
                txtTongTien.Text = dataGridViewDonHangNhap.Rows[e.RowIndex].Cells["tongTien"].Value.ToString();
                dateTimeNgayTao.Value = Convert.ToDateTime(dataGridViewDonHangNhap.Rows[e.RowIndex].Cells["ngayTao"].Value);

                string selectedMaDH = txtMaDH.Text;

                // Kết nối cơ sở dữ liệu
                using (SqlConnection con = new SqlConnection(sCon))
                {
                    try
                    {
                        con.Open();

                        // Truy vấn các mã giá liên quan đến sản phẩm
                        string sQuery = "select maSP, tenSP, giaNhap, soLuong, thanhTien from v_donHangNhapChiTiet WHERE maDHN = @maDHN";
                        SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
                        adapter.SelectCommand.Parameters.AddWithValue("@maDHN", selectedMaDH);

                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "v_donHangNhapChiTiet");

                        // Hiển thị dữ liệu trong dataGridView2
                        if (ds.Tables["v_donHangNhapChiTiet"].Rows.Count > 0)
                        {
                            dataGridViewDHNCT.DataSource = ds.Tables["v_donHangNhapChiTiet"];

                            // Hiển thị thông tin giá thành vào các TextBox
                            DataRow row = ds.Tables["v_donHangNhapChiTiet"].Rows[0];
                            txtMaSP.Text = row["maSP"].ToString();
                            cboTenSP.Text = row["tenSP"].ToString();
                            soLuong.Text = row["soLuong"].ToString();
                            txtGiaNhap.Text = row["giaNhap"].ToString();
                        }
                        else
                        {
                            dataGridViewDHNCT.DataSource = null;
                            txtMaSP.Text = string.Empty;
                            cboTenSP.Text = string.Empty;

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xảy ra lỗi trong quá trình tải dữ liệu: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng hợp lệ.");
            }
        }

        private void dataGridViewDHNCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.Text = dataGridViewDHNCT.Rows[e.RowIndex].Cells["maSP"].Value.ToString();
            cboTenSP.Text = dataGridViewDHNCT.Rows[e.RowIndex].Cells["tenSP"].Value.ToString();
            soLuong.Text = dataGridViewDHNCT.Rows[e.RowIndex].Cells["soLuong"].Value.ToString();
            txtGiaNhap.Text = dataGridViewDHNCT.Rows[e.RowIndex].Cells["giaNhap"].Value.ToString();
        }

        private void btnXoaDH_Click(object sender, EventArgs e)
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

                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Xảy ra lỗi trong quá trình xoá");
                }


                string sQuerry = "select * from donHangNhap";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "donHangNhap");

                dataGridViewDonHangNhap.DataSource = ds.Tables["donHangNhap"];

                con.Close();
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

        private void btnXoaSP_Click(object sender, EventArgs e)
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


                // Bước 2: lấy dl về
                string sQuerry = "select maSP, tenSP, giaNhap, soLuong, thanhTien from v_donHangNhapChiTiet WHERE maDHN = @maDHN";
                SqlCommand cmdFetch = new SqlCommand(sQuerry, con);
                cmdFetch.Parameters.AddWithValue("@maDHN", sMaDHN);

                SqlDataAdapter adapter = new SqlDataAdapter(cmdFetch);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "v_donHangNhapChiTiet");

                dataGridViewDHNCT.DataSource = ds.Tables["v_donHangNhapChiTiet"];



                string sQuerry2 = "select * from donHangNhap";
                SqlDataAdapter adapter2 = new SqlDataAdapter(sQuerry2, con);

                DataSet ds2 = new DataSet();

                adapter2.Fill(ds2, "donHangNhap");

                dataGridViewDonHangNhap.DataSource = ds2.Tables["donHangNhap"];



                string tongTien = ds2.Tables["donHangNhap"].Rows.Cast<DataRow>()
                             .Where(row => row["maDHN"].ToString() == sMaDHN)
                             .Sum(row => Convert.ToDecimal(row["tongTien"]))
                             .ToString();

                txtTongTien.Text = tongTien;

                if (dataGridViewDonHangNhap.Rows.Count > 0)
                {
                    dataGridViewDonHangNhap.ClearSelection();
                    foreach (DataGridViewRow row in dataGridViewDonHangNhap.Rows)
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

        private void btnThemDHCT_Click(object sender, EventArgs e)
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
            string sTenSP = cboTenSP.Text;
            string sSoLuong = soLuong.Text;
            string sGiaNhap = txtGiaNhap.Text;

            string sQuery = "exec spDHNct @maDHN, @tenSP, @giaNhap, @soLuong, @ret output";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            cmd.Parameters.AddWithValue("@maDHN", sMaDHN);
            cmd.Parameters.AddWithValue("@tenSP", sTenSP);
            cmd.Parameters.AddWithValue("@giaNhap", sGiaNhap);
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


            // Bước 2: lấy dl về
            string sQuerry = "select maSP, tenSP, giaNhap, soLuong, thanhTien from v_donHangNhapChiTiet WHERE maDHN = @maDHN";
            SqlCommand cmdFetch = new SqlCommand(sQuerry, con);
            cmdFetch.Parameters.AddWithValue("@maDHN", sMaDHN);

            SqlDataAdapter adapter = new SqlDataAdapter(cmdFetch);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "v_donHangNhapChiTiet");

            dataGridViewDHNCT.DataSource = ds.Tables["v_donHangNhapChiTiet"];



            string sQuerry2 = "select * from donHangNhap";
            SqlDataAdapter adapter2 = new SqlDataAdapter(sQuerry2, con);

            DataSet ds2 = new DataSet();

            adapter2.Fill(ds2, "donHangNhap");

            dataGridViewDonHangNhap.DataSource = ds2.Tables["donHangNhap"];



            string tongTien = ds2.Tables["donHangNhap"].Rows.Cast<DataRow>()
                         .Where(row => row["maDHN"].ToString() == sMaDHN)
                         .Sum(row => Convert.ToDecimal(row["tongTien"]))
                         .ToString();

            txtTongTien.Text = tongTien;

            if (dataGridViewDonHangNhap.Rows.Count > 0)
            {
                dataGridViewDonHangNhap.ClearSelection();
                foreach (DataGridViewRow row in dataGridViewDonHangNhap.Rows)
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

        private void btnThemDonHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhapSP());
        }
    }
}
