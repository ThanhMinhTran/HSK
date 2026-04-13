using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.ComponentModel;

namespace QuanLyThuVien
{
    public partial class FormReceipt : Form
    {
        private string kn;
        private string tenNhanVien;

        public FormReceipt(string tenNV)
        {
            InitializeComponent();
            kn = ConfigurationManager.ConnectionStrings["qltv"].ConnectionString;
            LoadDataDocGia();
            LoadDataPhieuThu();
            SetControlState(false);
            this.tenNhanVien = tenNV;
        }

        private void SetControlState(bool isEnabled)
        {
            txtMaPhieuThu.Enabled = false;
            cboDocGia.Enabled = isEnabled;
            txtTongNo.Enabled = false;
            txtSoTienThu.Enabled = isEnabled;
            txtConLai.Enabled = false;
            dtpNgayThu.Enabled = isEnabled;

            btnAdd.Enabled = !isEnabled;
            btnSave.Enabled = isEnabled;
            btnCancel.Enabled = isEnabled;
            btnPrint.Enabled = false;
            btnDelete.Enabled = false;
            btnHome.Enabled = true;
        }

        private void LoadDataDocGia()
        {
            Library.LoadComboBox(cboDocGia, "tblDocGia", "sMadocgia", "sTendocgia", true);
        }

        private void LoadDataPhieuThu()
        {
            Library.LoadDataToGridView(dgvPhieuThu, "Select * from v_DSPTHU");
            dgvPhieuThu.Columns["Ngày thu"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void cboDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDocGia.SelectedValue != null)
            {
                using (SqlConnection connection = new SqlConnection(kn))
                {
                    string query = "SELECT fTongno FROM tblDocGia WHERE sMadocgia = @madocgia";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@madocgia", cboDocGia.SelectedValue.ToString());

                    connection.Open();
                    object result = command.ExecuteScalar();
                    connection.Close();

                    if (result != null)
                    {
                        txtTongNo.Text = result.ToString();
                    }
                }
            }
        }

        private void txtSoTienThu_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTongNo.Text, out decimal tongNo) && decimal.TryParse(txtSoTienThu.Text, out decimal soTienThu))
            {
                txtConLai.Text = (tongNo - soTienThu).ToString();
            }
            else
            {
                txtConLai.Text = "";
            }
        }

        private string GenerateNewReceiptID()
        {
            return Library.GenerateNewID("tblPhieuthu", "sMaphieuthu", "MPT", 4);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetControlState(true);  // Bật nhập liệu
            ClearFields();  // Xóa dữ liệu cũ)
            txtMaPhieuThu.Text = GenerateNewReceiptID();
            dtpNgayThu.Value = DateTime.Now; // Mặc định ngày hiện tại
            dtpNgayThu.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(kn))
            {
                connection.Open();
                string query = @"INSERT INTO tblPhieuThu (sMaphieuthu, sMadocgia, fSotienthu, fConlai, dNgaythu, isDeleted) 
                                VALUES (@MaPhieu, @MaDocGia, @SoTienThu, @ConLai, @NgayThu, 0)";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MaPhieu", txtMaPhieuThu.Text);
                    cmd.Parameters.AddWithValue("@MaDocGia", cboDocGia.SelectedValue);
                    cmd.Parameters.AddWithValue("@SoTienThu", Convert.ToDecimal(txtSoTienThu.Text));
                    cmd.Parameters.AddWithValue("@ConLai", Convert.ToDecimal(txtTongNo.Text) - Convert.ToDecimal(txtSoTienThu.Text));
                    cmd.Parameters.AddWithValue("@NgayThu", dtpNgayThu.Value);
                    cmd.Parameters.AddWithValue("@TongNo", Convert.ToDecimal(txtTongNo.Text)); // Lưu tổng nợ vào bảng phiếu thu
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show(" Tạo phiếu thành công!", "Thành công",
             MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadDataPhieuThu();
            LoadDataDocGia(); // Cập nhật lại danh sách độc giả để tổng nợ hiển thị đúng
            SetControlState(false);
        }

        private void ClearFields()
        {
            txtMaPhieuThu.Text = "";
            cboDocGia.SelectedIndex = -1;
            txtTongNo.Text = "";
            txtSoTienThu.Text = "";
            txtConLai.Text = "";
            dtpNgayThu.Value = DateTime.Now;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetControlState(false);
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPhieuThu.SelectedRows.Count > 0)
            {
                string maPhieu = dgvPhieuThu.SelectedRows[0].Cells["Mã phiếu thu"].Value.ToString();

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu thu này?", "Xác nhận xóa",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(kn))
                    {
                        connection.Open();
                        string query = "UPDATE tblPhieuThu SET isDeleted = 1 WHERE sMaphieuthu = @MaPhieu";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Xóa thành công!");
                    LoadDataPhieuThu();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu thu để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvPhieuThu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhieuThu.SelectedRows.Count > 0)
            {
                txtMaPhieuThu.Text = dgvPhieuThu.SelectedRows[0].Cells["Mã phiếu thu"].Value.ToString();
                cboDocGia.Text = dgvPhieuThu.SelectedRows[0].Cells["Tên độc giả"].Value.ToString();
                txtSoTienThu.Text = dgvPhieuThu.SelectedRows[0].Cells["Số tiền thu"].Value.ToString();
                dtpNgayThu.Value = Convert.ToDateTime(dgvPhieuThu.SelectedRows[0].Cells["Ngày thu"].Value);
                txtTongNo.Text = "";
                txtConLai.Text = "";

                txtSoTienThu.Enabled = false;
                cboDocGia.Enabled = false;
                dtpNgayThu.Enabled = false;
                btnDelete.Enabled = true; // Kích hoạt nút Xóa khi chọn hàng
                btnAdd.Enabled = true;
                btnPrint.Enabled = true;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ClearFields();
            SetControlState(false);
        }

        private void PerformSearchTra()
        {
            string search = txtTimkiem.Text.Trim();
            string query = "";

            // Xác định tiêu chí tìm kiếm dựa trên RadioButton được chọn
            if (rdoTenDocGia.Checked)
            {
                query = "SELECT * FROM v_DSPTHU WHERE [Tên độc giả] LIKE @Keyword";
            }
            //else if (rdoTDG.Checked)
            //{
            //    query = "SELECT * FROM v_DSPMT WHERE [Tên độc giả] LIKE @Keyword";
            //}
            else if (rdoNgayThu.Checked)
            {
                query = "SELECT * FROM v_DSPTHU WHERE FORMAT([Ngày thu], 'dd/MM') LIKE @Keyword";
            }

            // Nếu không có từ khóa tìm kiếm, lấy tất cả dữ liệu
            if (string.IsNullOrEmpty(search))
            {
                query = "SELECT * FROM v_DSPTHU";
            }

            using (SqlConnection cnn = new SqlConnection(kn))
            {
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    if (!string.IsNullOrEmpty(search))
                    {
                        // Thêm tham số tìm kiếm
                        if (rdoNgayThu.Checked)
                        {
                            cmd.Parameters.AddWithValue("@Keyword", search);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Keyword", "%" + search + "%");
                        }
                    }

                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable searchResult = new DataTable();
                        ad.Fill(searchResult);
                        dgvPhieuThu.DataSource = searchResult;
                        dgvPhieuThu.Refresh(); // Cập nhật giao diện ngay lập tức
                    }
                }
            }
        }

        private void rdoTenDocGia_CheckedChanged(object sender, EventArgs e)
        {
            PerformSearchTra();
        }

        private void rdoNgayThu_CheckedChanged(object sender, EventArgs e)
        {
            PerformSearchTra();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            PerformSearchTra();
        }

        private void FormReceipt_Load(object sender, EventArgs e)
        {
            txtTimkiem.Text = "";
        }

        private void txtSoTienThu_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(txtSoTienThu, ""); // Xóa lỗi trước khi kiểm tra lại

            if (string.IsNullOrWhiteSpace(txtSoTienThu.Text))
            {
                errorProvider1.SetError(txtSoTienThu, "Vui lòng nhập số tiền thu!");
                e.Cancel = true; // Ngăn không cho rời khỏi ô nhập nếu có lỗi
                return;
            }

            if (!decimal.TryParse(txtSoTienThu.Text, out decimal soTienThu) || soTienThu <= 0)
            {
                errorProvider1.SetError(txtSoTienThu, "Số tiền thu phải là số và lớn hơn 0!");
                e.Cancel = true;
                return;
            }

            if (soTienThu < 50000)
            {
                errorProvider1.SetError(txtSoTienThu, "Số tiền thu phải ít nhất là 50,000!");
                e.Cancel = true;
                return;
            }

            if (decimal.TryParse(txtTongNo.Text, out decimal tongNo) && soTienThu > tongNo)
            {
                errorProvider1.SetError(txtSoTienThu, "Số tiền thu không được lớn hơn tổng nợ!");
                e.Cancel = true;
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FormInBaoCao reportForm = new FormInBaoCao("CR_RC_DG", this.tenNhanVien, null, null, txtMaPhieuThu.Text);
            reportForm.ShowDialog();
        }

        private void txtMaPhieuThu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
