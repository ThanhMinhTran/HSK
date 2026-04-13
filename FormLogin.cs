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
using System.Text.RegularExpressions;

namespace QuanLyThuVien
{
    public partial class FormLogin : Form
    {
        private bool isPasswordVisible = false;
        private string taiKhoan;
        public FormLogin()
        {
            InitializeComponent();
            txtTaiKhoan.Text = "Nhập tài khoản";
            txtTaiKhoan.ForeColor = Color.Gray;
            txtMk.Text = "Nhập mật khẩu";
            txtMk.ForeColor = Color.Gray;

            btnHienMatKhau.ImageIndex = 1;
        }

        private void txtTaiKhoan_Enter(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "Nhập tài khoản")
            {
                txtTaiKhoan.Text = "";
                txtTaiKhoan.ForeColor = Color.Black;
            }
        }

        

        private void txtMk_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMk.Text))
            {
                txtMk.Text = "Nhập mật khẩu";
                txtMk.ForeColor = Color.Gray;
                txtMk.PasswordChar = '\0'; // Hiển thị văn bản bình thường
            }
        }

        private void txtTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text))
            {
                txtTaiKhoan.Text = "Nhập tài khoản";
                txtTaiKhoan.ForeColor = Color.Gray;
            }
        }

        private void btnHienMatKhau_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                txtMk.PasswordChar = '\0'; // Hiển thị mật khẩu
                btnHienMatKhau.ImageIndex = 0; // Biểu tượng mắt mở
            }
            else
            {
                txtMk.PasswordChar = '*'; // Ẩn mật khẩu
                btnHienMatKhau.ImageIndex = 1; // Biểu tượng mắt nhắm
            }
        }

        private void txtMk_Enter(object sender, EventArgs e)
        {
            if (txtMk.Text == "Nhập mật khẩu")
            {
                txtMk.Text = ""; // Xóa placeholder
                txtMk.ForeColor = Color.Black;
                txtMk.PasswordChar = '*'; // Kích hoạt ẩn mật khẩu
            }
        }

        private void txtMk_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMk.Text))
            {
                txtMk.Text = "Nhập mật khẩu";
                txtMk.ForeColor = Color.Gray;
                txtMk.PasswordChar = '\0'; // Hiển thị lại placeholder
            }
        }

        private bool KiemTraMatKhau(string password)
        {
            // Regex kiểm tra mật khẩu
            string pattern = @"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,8}$";
            return Regex.IsMatch(password, pattern);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMk.Text;

            if (tenTaiKhoan == "Nhập tài khoản" || matKhau == "Nhập mật khẩu")
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra độ mạnh của mật khẩu
            if (!KiemTraMatKhau(matKhau))
            {
                MessageBox.Show("Mật khẩu phải có từ 6-8 ký tự, ít nhất một chữ hoa, một chữ số và một ký tự đặc biệt!",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ketnoi = ConfigurationManager.ConnectionStrings["qltv"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(ketnoi))
            {
                try
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(@"
                SELECT sManv, sMadocgia 
                FROM tblTaiKhoan
                WHERE sTentk = @TenTaiKhoan
                AND sMatkhau = @MatKhau
                AND isDeleted = 0", cnn))
                    {
                        cmd.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                        cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string maNhanVien = reader["sManv"]?.ToString();
                                string maDocGia = reader["sMadocgia"]?.ToString();

                                taiKhoan = tenTaiKhoan; // Lưu tài khoản đăng nhập

                                if (!string.IsNullOrEmpty(maNhanVien))
                                {
                                    FormIndex formNV = new FormIndex(maNhanVien, taiKhoan,tenTaiKhoan);
                                    formNV.Show();
                                    this.Hide();
                                }
                                else if (!string.IsNullOrEmpty(maDocGia))
                                {
                                    // Đăng nhập độc giả
                                    FormUser formDocGia = new FormUser(maDocGia, taiKhoan);
                                    formDocGia.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Tài khoản không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng, hoặc tài khoản đã bị xóa!",
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cnn.Close();
                }
            }
        }

        private void txtMk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick(); // Kích hoạt sự kiện Click của btnDangNhap
            }
        }

        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick(); // Kích hoạt sự kiện Click của btnDangNhap
            }
        }
    }
}
