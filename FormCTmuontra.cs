using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.ComponentModel;

namespace QuanLyThuVien
{
    public partial class FormCTmuontra : Form
    {
        private string kn = ConfigurationManager.ConnectionStrings["qltv"].ConnectionString;
        private string maPhieu;
        private string tenNhanVien;

        public FormCTmuontra(string maPhieu, string tenNV)
        {
            InitializeComponent();
            this.maPhieu = maPhieu;
            this.tenNhanVien = tenNV;
            LoadChiTietPhieu();
            LoadThongTinPhieuMuon();
            DisableAllControls();
        }

        private void LoadChiTietPhieu()
        {
            using (SqlConnection connection = new SqlConnection(kn))
            {
                string query = @"
                    SELECT s.sMasach AS [Mã sách], s.sTensach AS [Tên sách],tl.sTentheloai AS [Thể loại] , fDongia AS [Đơn giá], ct.iSlmuon AS [Số lượng],
                           ct.dNgayhentra AS [Ngày hẹn trả], ct.sGhichu AS [Ghi chú] 
                    FROM tblCTmuontra ct
                    JOIN tblSach s ON ct.sMasach = s.sMasach
                    JOIN tblTheloai tl On tl.sMatheloai = s.sMatheloai
                    WHERE ct.sMaphieu = @MaPhieu AND dNgaytra is NULL AND ct.isDeleted = 0";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@MaPhieu", maPhieu);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvPhieuCT.DataSource = dt;
                dgvPhieuCT.Columns["Ngày hẹn trả"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void LoadThongTinPhieuMuon()
        {
            using (SqlConnection connection = new SqlConnection(kn))
            {
                string query = @"
                    SELECT pm.sMaphieu AS [Mã phiếu], dg.sTendocgia AS [Tên độc giả], 
                           pm.dNgaymuon AS [Ngày mượn], MIN(ct.dNgayhentra) AS [Ngày hẹn trả] 
                    FROM tblPhieumuon pm
                    JOIN tblCTmuontra ct ON pm.sMaphieu = ct.sMaphieu
                    JOIN tblDocGia dg ON pm.sMadocgia = dg.sMadocgia
                    WHERE pm.sMaphieu = @MaPhieu
                    GROUP BY pm.sMaphieu, dg.sTendocgia, pm.dNgaymuon";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaPhieu", maPhieu);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtMaPhieu.Text = reader["Mã phiếu"].ToString();
                    txtTenDocGia.Text = reader["Tên độc giả"].ToString();
                    dtpNgayMuon.Value = Convert.ToDateTime(reader["Ngày mượn"]);
                    dtpNgayHenTra.Value = Convert.ToDateTime(reader["Ngày hẹn trả"]);
                }
                connection.Close();
            }

            // Vô hiệu hóa chỉnh sửa các ô thông tin phiếu mượn
            txtMaPhieu.Enabled = false;
            txtTenDocGia.Enabled = false;
            dtpNgayMuon.Enabled = false;
            dtpNgayHenTra.Enabled = false;
        }

        private void dgvPhieuCT_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhieuCT.SelectedRows.Count > 0)
            {
                var selectedRow = dgvPhieuCT.SelectedRows[0];
                txtTenSach.Text = selectedRow.Cells["Tên sách"].Value.ToString();
                txtSoLuong.Text = selectedRow.Cells["Số lượng"].Value.ToString();

                // Không cho phép chỉnh sửa
                txtTenSach.Enabled = false;
                txtSoLuong.Enabled = false;

                EnableTraSachControls();
            }
        }

        private void DisableAllControls()
        {
            // Vô hiệu hóa tất cả các ô nhập lúc mới vào form
            txtMaPhieu.Enabled = false;
            txtTenDocGia.Enabled = false;
            dtpNgayMuon.Enabled = false;
            dtpNgayHenTra.Enabled = false;
            txtTenSach.Enabled = false;
            txtSoLuong.Enabled = false;
            txtGhiChu.Enabled = false;
            cboTinhTrangTra.Enabled = false;
            dtpNgayTra.Enabled = false;

            // Thiết lập giá trị mặc định cho cboTinhTrangTra
            cboTinhTrangTra.Items.Clear();
            cboTinhTrangTra.Items.Add("Nguyên vẹn");
            cboTinhTrangTra.Items.Add("Hỏng");
            cboTinhTrangTra.Items.Add("Hỏng 1/2");
            cboTinhTrangTra.SelectedIndex = 0; // Mặc định chọn "Nguyên vẹn"

            // Mặc định Ngày trả là ngày hiện tại
            dtpNgayTra.Value = DateTime.Now;
        }

        private void EnableTraSachControls()
        {
            // Khi chọn sách, chỉ bật các ô liên quan đến trả sách
            txtGhiChu.Enabled = true;
            cboTinhTrangTra.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DisableAllControls();

            // Xóa dữ liệu nhập
            txtTenSach.Clear();
            txtSoLuong.Clear();
            txtGhiChu.Clear();
            cboTinhTrangTra.SelectedIndex = -1;

            // Giữ nguyên ngày trả là ngày hiện tại
            dtpNgayTra.Value = DateTime.Now;

            // Bỏ chọn hàng trong dgv
            dgvPhieuCT.ClearSelection();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisableAllControls();

            // Xóa dữ liệu nhập
            txtTenSach.Clear();
            txtSoLuong.Clear();
            txtGhiChu.Clear();
            cboTinhTrangTra.SelectedIndex = -1;

            // Giữ nguyên ngày trả là ngày hiện tại
            dtpNgayTra.Value = DateTime.Now;

            // Bỏ chọn hàng trong dgv
            dgvPhieuCT.ClearSelection();
        }

        private void PerformSearchTra()
        {
            string search = txtTimKiemTra.Text.Trim();
            string query = @"
        SELECT s.sMasach AS [Mã sách], s.sTensach AS [Tên sách], tl.sTentheloai AS [Thể loại], 
               fDongia AS [Đơn giá], ct.iSlmuon AS [Số lượng], ct.dNgayhentra AS [Ngày hẹn trả], ct.sGhichu AS [Ghi chú]
        FROM tblCTmuontra ct
        JOIN tblSach s ON ct.sMasach = s.sMasach
        JOIN tblTheloai tl ON tl.sMatheloai = s.sMatheloai
        WHERE ct.sMaphieu = @MaPhieu AND ct.isDeleted = 0 AND ct.dNgaytra is NULL";

            // Xác định điều kiện tìm kiếm
            if (!string.IsNullOrEmpty(search))
            {
                if (rdoTenSach.Checked)
                {
                    query += "AND s.sTensach LIKE @Keyword ";
                }
                else if (rdoNHT.Checked)
                {
                    query += "AND FORMAT(ct.dNgayhentra, 'dd/MM/yyyy') LIKE @Keyword ";
                }
                else if (rdoTheLoai.Checked)
                {
                    query += "AND tl.sTentheloai LIKE @Keyword ";
                }
            }

            using (SqlConnection cnn = new SqlConnection(kn))
            {
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);

                    if (!string.IsNullOrEmpty(search))
                    {
                        cmd.Parameters.AddWithValue("@Keyword", "%" + search + "%");
                    }

                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable searchResult = new DataTable();
                        ad.Fill(searchResult);
                        dgvPhieuCT.DataSource = searchResult;
                        dgvPhieuCT.Refresh(); // Cập nhật giao diện ngay lập tức
                    }
                }
            }
        }



        private void rdoMaPhieuTra_CheckedChanged(object sender, EventArgs e)
        {
            PerformSearchTra();
        }

        private void rdoTDG_CheckedChanged(object sender, EventArgs e)
        {
            PerformSearchTra();
        }

        private void rdoNHT_CheckedChanged(object sender, EventArgs e)
        {
            PerformSearchTra();
        }

        private void txtTimKiemTra_TextChanged(object sender, EventArgs e)
        {
            PerformSearchTra();
        }

        private void FormCTmuontra_KeyDown(object sender, KeyEventArgs e)
        {
            //Kiểm tra nếu phím được nhấn là Esc
            if (e.KeyCode == Keys.Escape)
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn thoát form không?",
                    "Xác nhận thoát",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Nếu người dùng chọn "Yes", đóng form
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            FormInBaoCao reportForm = new FormInBaoCao("CR_PM_DG", this.tenNhanVien, null, txtMaPhieu.Text);
            reportForm.ShowDialog();
        }

        private void FormCTmuontra_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvPhieuCT.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một cuốn sách để trả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin từ dòng được chọn
            var selectedRow = dgvPhieuCT.SelectedRows[0];
            string maSach = selectedRow.Cells["Mã sách"].Value.ToString();

            // Xác nhận từ người dùng
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn trả sách này?", "Xác nhận trả sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(kn))
                {
                    string query = @"
            UPDATE tblCTmuontra
            SET dNgaytra = @NgayTra, sTinhtrangtra = @TinhTrang, sGhichu = @GhiChu
            WHERE sMaphieu = @MaPhieu AND sMasach = @MaSach";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@NgayTra", dtpNgayTra.Value);
                        cmd.Parameters.AddWithValue("@TinhTrang", cboTinhTrangTra.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text.Trim());
                        cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);
                        cmd.Parameters.AddWithValue("@MaSach", maSach);

                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Trả sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadChiTietPhieu(); // Cập nhật lại danh sách sách
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
    
