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
    public partial class frmDonHang : Form
    {
        string sCon = "Data Source=LAPTOP-INU6NAIB;Initial Catalog=Nhom48K21106;Integrated Security=True;Trust Server Certificate=True";
        public frmDonHang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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
            OpenChildForm(new BanHang());
        }

        private void frmDonHang_Load(object sender, EventArgs e)
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

            string sQuerry = "select * from donHangBan";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "donHangBan");
            dataGridViewDonHangBan.DataSource = ds.Tables["donHangBan"];


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

            string sSDT = txtSDTKhachHang.Text;
            string sMaDHB = txtMaDH.Text;
            string sQuery = "update donHangBan set SDT = @SDT where maDHB = @maDHB";

            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@maDHB", sMaDHB);
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



            string sQuerry = "select * from donHangBan";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "donHangBan");

            dataGridViewDonHangBan.DataSource = ds.Tables["donHangBan"];

            con.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridViewDonHangBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu dòng được chọn hợp lệ
            if (e.RowIndex >= 0 && dataGridViewDonHangBan.Rows[e.RowIndex].Cells["maDHB"].Value != null)
            {
                // Lấy thông tin sản phẩm từ dòng được chọn
                txtSDTKhachHang.Text = dataGridViewDonHangBan.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
                txtMaDH.Text = dataGridViewDonHangBan.Rows[e.RowIndex].Cells["maDHB"].Value.ToString();
                txtTongTien.Text = dataGridViewDonHangBan.Rows[e.RowIndex].Cells["tongTien"].Value.ToString();
                dateTimeNgayTao.Value = Convert.ToDateTime(dataGridViewDonHangBan.Rows[e.RowIndex].Cells["ngayTao"].Value);

                string selectedMaDH = txtMaDH.Text;

                // Kết nối cơ sở dữ liệu
                using (SqlConnection con = new SqlConnection(sCon))
                {
                    try
                    {
                        con.Open();

                        // Truy vấn các mã giá liên quan đến sản phẩm
                        string sQuery = "select maSP, tenSP, giaBan, soLuong, thanhTien from v_donHangBanCT WHERE maDHB = @maDHB";
                        SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
                        adapter.SelectCommand.Parameters.AddWithValue("@maDHB", selectedMaDH);

                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "v_donHangBanCT");

                        // Hiển thị dữ liệu trong dataGridView2
                        if (ds.Tables["v_donHangBanCT"].Rows.Count > 0)
                        {
                            dataGridViewDHCT.DataSource = ds.Tables["v_donHangBanCT"];

                            // Hiển thị thông tin giá thành vào các TextBox
                            DataRow row = ds.Tables["v_donHangBanCT"].Rows[0];
                            txtMaSP.Text = row["maSP"].ToString();
                            cboTenSP.Text = row["tenSP"].ToString();
                            soLuong.Text = row["soLuong"].ToString();
                        }
                        else
                        {
                            // Không tìm thấy giá thành nào
                            dataGridViewDHCT.DataSource = null;
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

        private void dataGridViewDHCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.Text = dataGridViewDHCT.Rows[e.RowIndex].Cells["maSP"].Value.ToString();
            cboTenSP.Text = dataGridViewDHCT.Rows[e.RowIndex].Cells["tenSP"].Value.ToString();
            soLuong.Text = dataGridViewDHCT.Rows[e.RowIndex].Cells["soLuong"].Value.ToString();
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
                string sMaDHB = txtMaDH.Text;

                string sQuery = "delete donHangBan where maDHB = @maDHB";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@maDHB", sMaDHB);


                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xoá thành công!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Xảy ra lỗi trong quá trình xoá");
                }


                string sQuerry = "select * from donHangBan";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "donHangBan");

                dataGridViewDonHangBan.DataSource = ds.Tables["donHangBan"];
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


            string sMaDHB = txtMaDH.Text;
            string sTenSP = cboTenSP.Text;
            string sSoLuong = soLuong.Text;

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




            // Bước 2: lấy dl về
            string sQuerry = "select maSP, tenSP, giaBan, soLuong, thanhTien from v_donHangBanCT WHERE maDHB = @maDHB";
            SqlCommand cmdFetch = new SqlCommand(sQuerry, con);
            cmdFetch.Parameters.AddWithValue("@maDHB", sMaDHB);

            SqlDataAdapter adapter = new SqlDataAdapter(cmdFetch);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "v_donHangBanCT");

            dataGridViewDHCT.DataSource = ds.Tables["v_donHangBanCT"];

            string sQuerry2 = "select * from donHangBan";
            SqlDataAdapter adapter2 = new SqlDataAdapter(sQuerry2, con);

            DataSet ds2 = new DataSet();

            adapter2.Fill(ds2, "donHangBan");

            dataGridViewDonHangBan.DataSource = ds2.Tables["donHangBan"];



            string tongTien = ds2.Tables["donHangBan"].Rows.Cast<DataRow>()
                         .Where(row => row["maDHB"].ToString() == sMaDHB)
                         .Sum(row => Convert.ToDecimal(row["tongTien"]))
                         .ToString();

            txtTongTien.Text = tongTien;

            if (dataGridViewDonHangBan.Rows.Count > 0)
            {
                dataGridViewDonHangBan.ClearSelection();
                foreach (DataGridViewRow row in dataGridViewDonHangBan.Rows)
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
                string sMaDHB = txtMaDH.Text;
                string sMaSP = txtMaSP.Text;

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


                // Bước 2: lấy dl về
                string sQuerry = "select maSP, tenSP, giaBan, soLuong, thanhTien from v_donHangBanCT WHERE maDHB = @maDHB";
                SqlCommand cmdFetch = new SqlCommand(sQuerry, con);
                cmdFetch.Parameters.AddWithValue("@maDHB", sMaDHB);

                SqlDataAdapter adapter = new SqlDataAdapter(cmdFetch);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "v_donHangBanCT");

                dataGridViewDHCT.DataSource = ds.Tables["v_donHangBanCT"];



                string sQuerry2 = "select * from donHangBan";
                SqlDataAdapter adapter2 = new SqlDataAdapter(sQuerry2, con);

                DataSet ds2 = new DataSet();

                adapter2.Fill(ds2, "donHangBan");

                dataGridViewDonHangBan.DataSource = ds2.Tables["donHangBan"];



                string tongTien = ds2.Tables["donHangBan"].Rows.Cast<DataRow>()
                             .Where(row => row["maDHB"].ToString() == sMaDHB)
                             .Sum(row => Convert.ToDecimal(row["tongTien"]))
                             .ToString();

                txtTongTien.Text = tongTien;

                if (dataGridViewDonHangBan.Rows.Count > 0)
                {
                    dataGridViewDonHangBan.ClearSelection();
                    foreach (DataGridViewRow row in dataGridViewDonHangBan.Rows)
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
    }
}
