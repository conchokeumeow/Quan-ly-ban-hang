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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MyApp
{
    public partial class frmNoKH : Form
    {
        string sCon = "Data Source=LAPTOP-INU6NAIB;Initial Catalog=Nhom48K21106;Integrated Security=True;Trust Server Certificate=True";
        public frmNoKH()
        {
            InitializeComponent();
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmNoKH_Load(object sender, EventArgs e)
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
            string sQuerry = "select * from ViewNoKhachHang";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "ViewNoKhachHang");

            dataGridViewNoKH.DataSource = ds.Tables["ViewNoKhachHang"];

            con.Close();
            LoadComboBoxDH();
            cboMaDH.SelectedIndexChanged += cboMaDH_SelectedIndexChanged;
            cboMaDH.SelectedIndexChanged += cboMaDH_SelectedIndexChangedDate;
        }

        private void LoadComboBoxDH()
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();

                    // Tải dữ liệu Tên sản phẩm
                    string sQuerySP = "SELECT maDHB, SDT, ngayTao FROM donHangBan";
                    SqlDataAdapter adapterSP = new SqlDataAdapter(sQuerySP, con);
                    DataTable dtSP = new DataTable();
                    adapterSP.Fill(dtSP);
                    cboMaDH.DataSource = dtSP;
                    cboMaDH.DisplayMember = "maDHB";
                    cboMaDH.ValueMember = "maDHB";
                    cboMaDH.Tag = dtSP;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu ComboBox: " + ex.Message);
                }
            }
        }

        private void cboMaDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = cboMaDH.Tag as DataTable;
            if (dt != null && cboMaDH.SelectedValue != null)
            {
                DataRow[] selectedRows = dt.Select($"maDHB = '{cboMaDH.SelectedValue}'");
                if (selectedRows.Length > 0)
                {
                    txtSDT.Text = selectedRows[0]["SDT"].ToString(); // Gán SDT vào TextBox
                }
                else
                {
                    txtSDT.Text = ""; // Nếu không tìm thấy, xóa TextBox
                }
            }
        }

        private void cboMaDH_SelectedIndexChangedDate(object sender, EventArgs e)
        {
            DataTable dt = cboMaDH.Tag as DataTable;
            if (dt != null && cboMaDH.SelectedValue != null)
            {
                DataRow[] selectedRows = dt.Select($"maDHB = '{cboMaDH.SelectedValue}'");
                if (selectedRows.Length > 0)
                {
                    // Lấy ngày nợ tiền từ cột `ngayNoTien`
                    if (DateTime.TryParse(selectedRows[0]["ngayTao"].ToString(), out DateTime ngayNo))
                    {
                        dateTimeNgayNo.Value = ngayNo; // Gán giá trị vào DateTimePicker
                    }
                }
            }
        }

        private void btnThemNo_Click(object sender, EventArgs e)
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
            string sMaDHB = cboMaDH.Text;
            //string sSDT = txtSDT.Text;
            string sTienNo = txtTienNo.Text;
            string sNgayNo = dateTimeNgayNo.Value.ToString("yyyy-MM-dd");


            // string sNgay = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            // (cho checkbox) int iTrangThai = 0
            // if(rbRoi.Checked == true)
            // { iTrangThai = 1 }

            string sQuery = "exec spNPTKH @maDHB, @tienNo, @ngayNoTien, @ret output";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            //cmd.Parameters.AddWithValue("@maKH", sMaKH);
            cmd.Parameters.AddWithValue("@maDHB", sMaDHB);
            cmd.Parameters.AddWithValue("@tienNo", sTienNo);
            cmd.Parameters.AddWithValue("@ngayNoTien", sNgayNo);


            SqlParameter retParam = new SqlParameter("@ret", SqlDbType.Int);
            retParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(retParam);


            try
            {
                cmd.ExecuteNonQuery();
                int retValue = Convert.ToInt32(retParam.Value); // Lấy giá trị trả về của @ret

                if (retValue == 1) // Thành công
                {
                    MessageBox.Show("Thêm Nợ KH thành công!");

                    string sQueryLastDHB = "SELECT TOP 1 maDHB FROM noPhaiTraKH ORDER BY maNPTKH DESC";
                    SqlCommand cmdLastDHB = new SqlCommand(sQueryLastDHB, con);
                    string lastMaDHB = cmdLastDHB.ExecuteScalar()?.ToString();

                    // Cập nhật lại ComboBox và chọn mã đơn hàng vừa thêm
                    LoadComboBoxDH();
                    if (!string.IsNullOrEmpty(lastMaDHB))
                    {
                        cboMaDH.SelectedValue = lastMaDHB;
                    }

                    // Lấy mã đơn hàng mới thêm
                    string sQueryNoKH = "SELECT * from ViewNoKhachHang";
                    SqlCommand cmdNoKH = new SqlCommand(sQueryNoKH, con);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmdNoKH);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridViewNoKH.DataSource = dt;                      // Cập nhật DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã nợ mới.");
                    }
                }
                else
                {
                    MessageBox.Show("Thêm mới không thành công. Kiểm tra thông tin nhập.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
            finally
            {
                con.Close(); // Đóng kết nối
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem checkbox đã được chọn chưa
            bool isPaid = checkBoxTraTien.Checked;  // Giả sử bạn có checkbox chkTrangThaiTraTien

            // Lấy maNPTKH từ DataGridView hoặc một điều kiện khác (ví dụ: maDHB)
            string maDHB = cboMaDH.Text; // Lấy maNPTKH từ đâu đó, ví dụ từ DataGridView
            string sNgayTra = dateTimePickerTra.Value.ToString("yyyy-MM-dd");


            if (string.IsNullOrEmpty(maDHB))
            {
                MessageBox.Show("Vui lòng chọn mã nợ để cập nhật.");
                return;
            }

            // Xử lý trạng thái trả tiền
            int trangThai = isPaid ? 1 : 0;  // Nếu checkbox được chọn, trangThai = 1, ngược lại là 0

            // Truy vấn SQL để cập nhật trangThaiTraTien
            string sQueryUpdate = "UPDATE noPhaiTraKH SET trangThaiTraTien = @trangThaiTraTien, ngayTraTien = @ngayTraTien WHERE maDHB = @maDHB";

            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sQueryUpdate, con);
                    cmd.Parameters.AddWithValue("@trangThaiTraTien", trangThai);
                    cmd.Parameters.AddWithValue("@maDHB", maDHB);
                    cmd.Parameters.AddWithValue("@ngayTraTien", sNgayTra);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật tiền nợ thành công.");
                        // Cập nhật lại DataGridView sau khi cập nhật
                        string sQueryNoKH = "SELECT * from ViewNoKhachHang";
                        SqlDataAdapter adapter = new SqlDataAdapter(sQueryNoKH, con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewNoKH.DataSource = dt; // Cập nhật lại DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin nợ.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
                }
            }
        }

        private void dataGridViewNoKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cboMaDH.Text = dataGridViewNoKH.Rows[e.RowIndex].Cells["maDHB"].Value.ToString();
            txtSDT.Text = dataGridViewNoKH.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
            txtTienNo.Text = dataGridViewNoKH.Rows[e.RowIndex].Cells["tienNo"].Value.ToString();
            // Kiểm tra cột trangThaiTraTien và cập nhật checkbox
            string trangThaiTraTien = dataGridViewNoKH.Rows[e.RowIndex].Cells["trangThaiTraTien"].Value.ToString();
            checkBoxTraTien.Checked = trangThaiTraTien == "Đã trả";  // Nếu là 'Đã trả' thì checkbox được chọn
            dateTimeNgayNo.Value = Convert.ToDateTime(dataGridViewNoKH.Rows[e.RowIndex].Cells["ngayNoTien"].Value);
            // Kiểm tra nếu cột 'ngayTraTien' là null
            if (dataGridViewNoKH.Rows[e.RowIndex].Cells["ngayTraTien"].Value != DBNull.Value)
            {
                // Nếu có ngày trả, gán giá trị vào DateTimePicker
                dateTimePickerTra.Value = Convert.ToDateTime(dataGridViewNoKH.Rows[e.RowIndex].Cells["ngayTraTien"].Value);
            }
            else
            {
                // Nếu 'ngayTraTien' là null, đặt DateTimePicker trống
                dateTimePickerTra.Value = DateTime.Now; // Hoặc có thể sử dụng DateTime.Now nếu cần
            }
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
                string sMaDHB = cboMaDH.Text;

                string sQuery = "delete noPhaiTraKH where maDHB = @maDHB";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@maDHB", sMaDHB);


                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xoá thành công!");
                    cboMaDH.SelectedIndex = 0;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Xảy ra lỗi trong quá trình xoá");
                }

                string sQuerry = "select * from ViewNoKhachHang";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuerry, con);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "ViewNoKhachHang");

                dataGridViewNoKH.DataSource = ds.Tables["ViewNoKhachHang"];


                con.Close();
            }
        }
    }
}