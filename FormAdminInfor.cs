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
    public partial class FormAdminInfor : Form
    {
        private string ketnoi;
        private string maNhanVien;
        private string taiKhoan;

        public FormAdminInfor(string maNhanVien, string taiKhoan)
        {
            InitializeComponent();
            this.maNhanVien = maNhanVien;
            this.taiKhoan = taiKhoan;
            ketnoi = ConfigurationManager.ConnectionStrings["qltv"].ConnectionString;
            LoadDataNhanVien();
            DisableEditing();
        }

        private void LoadDataNhanVien()
        {
            using (SqlConnection cnn = new SqlConnection(ketnoi))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblNhanVien WHERE sMaNV = @MaNV", cnn))
                {
                    cmd.Parameters.AddWithValue("@MaNV", maNhanVien);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtMaNV.Text = reader["sMaNV"].ToString();
                            txtTenNV.Text = reader["sTenNV"].ToString();
                            txtEmail.Text = reader["sEmail"].ToString();
                            txtDiachi.Text = reader["sDiachi"].ToString();
                            txtSdt.Text = reader["sSdt"].ToString();
                            dNgaysinh.Value = Convert.ToDateTime(reader["dNgaysinh"]);
                            dNgayvaolam.Value = Convert.ToDateTime(reader["dNgayvaolam"]);
                            string gioiTinh = reader["sGioitinh"].ToString();
                            if (gioiTinh == "Nam") rdoNam.Checked = true;
                            else rdoNu.Checked = true;
                        }
                    }
                }
            }
        }

        private void EnableEditing()
        {
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = true;
            txtEmail.Enabled = true;
            txtDiachi.Enabled = true;
            txtSdt.Enabled = true;
            dNgaysinh.Enabled = true;
            dNgayvaolam.Enabled = false;
            rdoNam.Enabled = true;
            rdoNu.Enabled = true;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void DisableEditing()
        {
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtEmail.Enabled = false;
            txtDiachi.Enabled = false;
            txtSdt.Enabled = false;
            dNgaysinh.Enabled = false;
            dNgayvaolam.Enabled = false;
            rdoNam.Enabled = false;
            rdoNu.Enabled = false;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void FormAdminInfor_Load(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            EnableEditing();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            // Kiểm tra xem có lỗi nào không
            bool hasErrors =
                !string.IsNullOrEmpty(errorProvider3.GetError(txtTenNV)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(txtEmail)) ||
                !string.IsNullOrEmpty(errorProvider2.GetError(txtSdt));

            if (hasErrors)
            {
                MessageBox.Show("Vui lòng kiểm tra lại các thông tin!", "Lỗi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection cnn = new SqlConnection(ketnoi))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE tblNhanVien SET sTenNV = @TenNV, sEmail = @Email, sDiachi = @Diachi, sSdt = @Sdt, dNgaysinh = @Ngaysinh, sGioitinh = @GioiTinh WHERE sMaNV = @MaNV", cnn))
                {
                    cmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Diachi", txtDiachi.Text);
                    cmd.Parameters.AddWithValue("@Sdt", txtSdt.Text);
                    cmd.Parameters.AddWithValue("@Ngaysinh", dNgaysinh.Value);
                    cmd.Parameters.AddWithValue("@GioiTinh", rdoNam.Checked ? "Nam" : "Nữ");
                    cmd.Parameters.AddWithValue("@MaNV", maNhanVien);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Thông tin đã cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cập nhật tên nhân viên trên FormIndex
            FormIndex formIndex = (FormIndex)this.Owner;
            if (formIndex != null)
            {
                formIndex.UpdateTenNhanVien(txtTenNV.Text);
            }

            DisableEditing();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Tắt chế độ chỉnh sửa
            DisableEditing();

            // Xóa toàn bộ lỗi của ErrorProvider
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();

            // Load lại dữ liệu từ database để hoàn tác thay đổi
            LoadDataNhanVien();
        }

        private void txtTenNV_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNV.Text))
                errorProvider3.SetError(txtTenNV, "Tên nhân viên không được để trống!");
            else
                errorProvider3.SetError(txtTenNV, "");
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.EndsWith("@gmail.com"))
                errorProvider1.SetError(txtEmail, "Email phải có đuôi @gmail.com!");
            else
                errorProvider1.SetError(txtEmail, "");
        }

        private void txtSdt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSdt.Text) || txtSdt.Text.Length != 10 || !txtSdt.Text.All(char.IsDigit))
                errorProvider2.SetError(txtSdt, "Số điện thoại phải có 10 chữ số!");
            else
                errorProvider2.SetError(txtSdt, "");
        }
    }
}
