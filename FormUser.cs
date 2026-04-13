using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    public partial class FormUser : Form
    {
        private string ketnoi;
        private string maDocGia;
        private string taiKhoan;

        public FormUser(string maDocGia, string taiKhoan)
        {
            InitializeComponent();
            this.maDocGia = maDocGia;
            this.taiKhoan = taiKhoan;
            ketnoi = ConfigurationManager.ConnectionStrings["qltv"].ConnectionString;
            LoadDataDocGia();
            LoadDataSACH();
            LoadTheLoai();
            rdoTenSach.Checked = true;
            DisableEditing();
        }

        private void LoadDataSACH()
        {
            Library.LoadDataToGridView(dssach, "Select * from v_DSS1");
        }

        private void LoadDataDocGia()
        {
            using (SqlConnection cnn = new SqlConnection(ketnoi))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblDocGia WHERE sMadocgia = @MaDocGia", cnn))
                {
                    cmd.Parameters.AddWithValue("@MaDocGia", maDocGia);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtMadocgia.Text = reader["sMadocgia"].ToString();
                            txtTendocgia.Text = reader["sTendocgia"].ToString();
                            txtEmail.Text = reader["sEmail"].ToString();
                            string gioiTinh = reader["sGioitinh"].ToString();
                            if (gioiTinh == "Nam") rdoNam.Checked = true;
                            else  rdoNu.Checked = true;
                            string maTheLoai = reader["sMaloaidocgia"].ToString();
                            txtTongno.Text = reader["fTongno"].ToString();
                            cboLoaidocgia.SelectedValue = maTheLoai;
                            txtDiachi.Text = reader["sDiachi"].ToString();
                            txtSdt.Text = reader["sSdt"].ToString();
                            dNgaysinh.Value = Convert.ToDateTime(reader["dNgaysinh"]);
                            dNgaylapthe.Value = Convert.ToDateTime(reader["dNgaylapthe"]);
                            dNgayhethan.Value = Convert.ToDateTime(reader["dNgayhethan"]);

                            // Lấy tên độc giả
                            string tenDocGia = reader["sTendocgia"].ToString();

                            // Hiển thị lời chào
                            lblTen.Text = $"Welcome, {tenDocGia}!";
                        }
                    }
                }
            }
        }

        private void LoadTheLoai()
        {
            Library.LoadComboBox(cboLoaidocgia, "tblLoaidocgia", "sMaloaidocgia", "sTenloaidocgia");
        }

        private void PerformSearch()
        {
            string search = txtTimkiem.Text.Trim();
            string query = "SELECT * FROM v_DSS1";

            if (!string.IsNullOrEmpty(search))
            {
                if (rdoMaSach.Checked)
                    query = "SELECT * FROM v_DSS1 WHERE [Mã sách] = @Keyword";
                else if (rdoTenSach.Checked)
                    query = "SELECT * FROM v_DSS1 WHERE [Tên sách] LIKE @Keyword";
                else if (rdoTheLoai.Checked)
                    query = "SELECT * FROM v_DSS1 WHERE [Thể loại] LIKE @Keyword";
            }

            using (SqlConnection cnn = new SqlConnection(ketnoi))
            {
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    if (!string.IsNullOrEmpty(search))
                    {
                        if (rdoMaSach.Checked)
                            cmd.Parameters.AddWithValue("@Keyword", search);
                        else
                            cmd.Parameters.AddWithValue("@Keyword", "%" + search + "%");
                    }

                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable searchResult = new DataTable();
                        ad.Fill(searchResult);
                        dssach.DataSource = searchResult;
                        dssach.Refresh(); // Cập nhật giao diện ngay lập tức
                    }
                }
            }
        }

        private void rdoMaSach_CheckedChanged(object sender, EventArgs e)
        {
            click_to_find(sender, e);
        }

        private void rdoTenSach_CheckedChanged(object sender, EventArgs e)
        {
            click_to_find(sender, e);
        }

        private void rdoTheLoai_CheckedChanged(object sender, EventArgs e)
        {
            click_to_find(sender, e);
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            click_to_find(sender, e);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formDangNhap = new FormLogin();
            formDangNhap.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChangePw f2 = new FormChangePw(taiKhoan);
            f2.Owner = this;
            f2.Show();
        }

        private void DisableEditing()
        {
            txtMadocgia.Enabled = false;
            txtTendocgia.Enabled = false;
            txtEmail.Enabled = false;
            rdoNam.Enabled = false;
            rdoNu.Enabled = false;
            cboLoaidocgia.Enabled = false;
            txtDiachi.Enabled = false;
            txtSdt.Enabled = false;
            txtTongno.Enabled = false;
            dNgaysinh.Enabled = false;
            dNgaylapthe.Enabled = false;
            dNgayhethan.Enabled = false;

            // Đổi trạng thái nút
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Gọi các phương thức kiểm tra dữ liệu hợp lệ
            txtTendocgia_Validating(txtTendocgia, new CancelEventArgs());
            txtEmail_Validating(txtEmail, new CancelEventArgs());
            txtSdt_Validating(txtSdt, new CancelEventArgs());

            // Kiểm tra xem có lỗi nào không
            bool hasErrors =
                !string.IsNullOrEmpty(errorProvider1.GetError(txtEmail)) ||
                !string.IsNullOrEmpty(errorProvider2.GetError(txtSdt)) ||
                !string.IsNullOrEmpty(errorProvider3.GetError(txtTendocgia));

            if (hasErrors)
            {
                MessageBox.Show("Vui lòng kiểm tra lại các thông tin nhập vào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn lưu thay đổi không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
                string maLoaiDocGia = cboLoaidocgia.SelectedValue.ToString();

                using (SqlConnection cnn = new SqlConnection(ketnoi))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE tblDocGia SET sTendocgia = @TenDocGia, sEmail = @Email, sGioitinh = @GioiTinh, sMaloaidocgia = @MaLoaiDocGia, sDiachi = @DiaChi, sSdt = @SoDienThoai, dNgaysinh = @NgaySinh WHERE sMadocgia = @MaDocGia", cnn))
                    {
                        cmd.Parameters.AddWithValue("@TenDocGia", txtTendocgia.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                        cmd.Parameters.AddWithValue("@MaLoaiDocGia", maLoaiDocGia);
                        cmd.Parameters.AddWithValue("@DiaChi", txtDiachi.Text);
                        cmd.Parameters.AddWithValue("@SoDienThoai", txtSdt.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", dNgaysinh.Value);
                        cmd.Parameters.AddWithValue("@MaDocGia", maDocGia);

                        cmd.ExecuteNonQuery();
                    }
                }

                // Tắt chế độ chỉnh sửa
                DisableEditing();

                // Cập nhật Label chào mừng
                

                MessageBox.Show("Thông tin đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblTen.Text = $"Welcome, {txtTendocgia.Text}!";
            }
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Tắt chế độ chỉnh sửa
            DisableEditing();

            // Load lại thông tin độc giả để hủy bỏ các thay đổi
            LoadDataDocGia();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtTendocgia.Enabled = true;
            txtEmail.Enabled = true;
            rdoNam.Enabled = true;
            rdoNu.Enabled = true;
            txtDiachi.Enabled = true;
            txtSdt.Enabled = true;
            txtTongno.Enabled = false;
            dNgaysinh.Enabled = true;

            // Đổi trạng thái nút
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void ShowData(string filter = "")
        {
            string querySelect = "SELECT * FROM v_DSS1"; // Truy vấn cơ bản từ bảng v_DSS1

            using (SqlConnection sqlConnetion = new SqlConnection(ketnoi))
            {
                using (SqlCommand sqlCommand = sqlConnetion.CreateCommand())
                {
                    sqlCommand.CommandText = querySelect;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Gán dữ liệu vào DataView
                        DataView dv_dgv = dataTable.DefaultView;

                        // Áp dụng bộ lọc nếu có
                        if (!string.IsNullOrEmpty(filter))
                        {
                            dv_dgv.RowFilter = filter;
                        }

                        dssach.DataSource = dv_dgv; // Gán DataView vào DataGridView
                    }
                }
            }
        }

        private void click_to_find(object sender, EventArgs e)
        {
            string filter = "1 = 1"; // Điều kiện mặc định

            // Nếu có từ khóa tìm kiếm, tạo bộ lọc dựa trên RadioButton được chọn
            if (!string.IsNullOrEmpty(txtTimkiem.Text.Trim()))
            {
                if (rdoMaSach.Checked) // Tìm theo mã sách
                    filter += string.Format(" AND [Mã sách] = '{0}'", txtTimkiem.Text);
                else if (rdoTenSach.Checked) // Tìm theo tên sách
                    filter += string.Format(" AND [Tên sách] LIKE '%{0}%'", txtTimkiem.Text);
                else if (rdoTheLoai.Checked) // Tìm theo thể loại
                    filter += string.Format(" AND [Thể loại] LIKE '%{0}%'", txtTimkiem.Text);
            }

            // Gọi phương thức ShowData với bộ lọc đã tạo
            ShowData(filter);
        }



        private void txtTendocgia_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTendocgia.Text))
                errorProvider3.SetError(txtTendocgia, "Tên độc giả không được để trống");
            else errorProvider3.SetError(txtTendocgia, "");
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
                errorProvider1.SetError(txtEmail, "Email không được để trống!");
            else
            {
                if (!txtEmail.Text.EndsWith("@gmail.com"))
                    errorProvider1.SetError(txtEmail, "Email phải có đuôi @gmail.com!");
                else
                    errorProvider1.SetError(txtEmail, "");
            }
        }

        private void txtSdt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSdt.Text))
                errorProvider2.SetError(txtSdt, "Số điện thoại không được để trống!");
            else
            {
                if (txtSdt.Text.Length != 10 || !txtSdt.Text.All(char.IsDigit))
                    errorProvider2.SetError(txtSdt, "Số điện thoại phải có 10 chữ số và không chứa ký tự không phải số!");
                else errorProvider2.SetError(txtSdt, "");
            }
        }

        private void FormUser_Load(object sender, EventArgs e)
        {

        }
    }
}
