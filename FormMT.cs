using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.ComponentModel;

namespace QuanLyThuVien
{
    public partial class Form7 : Form
    {
        private string kn;
        private DataTable pm;
        private string tenNhanVien;
        private DataTable dtSachGoc;
        private bool isCreatingNewPhieu = false;
        private string tempNewMaPhieu;
        public enum Mode { None, LapPhieu, GiaHan, ThemChiTiet }
        private Mode currentMode = Mode.None;

        public Form7(string tenNV)
        {
            InitializeComponent();
            kn = ConfigurationManager.ConnectionStrings["qltv"].ConnectionString;
            InitializeControls();
            LoadDataTra();
            LoadData();
            LoadComboBoxes();
            InitializeControlsPT();
            InitializeListView();
            this.KeyPreview = true;
            this.tenNhanVien = tenNV;
        }

        /*-------------------------------------Mượn sách------------------------------------------------------*/
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(kn))
            {
                string query = "SELECT * FROM v_DSPM";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                pm = new DataTable();
                adapter.Fill(pm);
                dgvPhieuMuon.DataSource = pm;
                dgvPhieuMuon.Columns["Ngày mượn"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvPhieuMuon.Columns["Ngày hẹn trả"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void LoadComboBoxes()
        {
            using (SqlConnection connection = new SqlConnection(kn))
            {
                connection.Open();

                // Chỉ lấy mã phiếu có ít nhất một chi tiết chưa bị xóa
                string queryMaPhieu = @"
                SELECT DISTINCT p.sMaphieu 
                FROM tblPhieumuon p
                JOIN tblCTmuontra ct ON p.sMaphieu = ct.sMaphieu
                WHERE ct.isDeleted = 0";

                SqlDataAdapter adapterMaPhieu = new SqlDataAdapter(queryMaPhieu, connection);
                DataTable dtMaPhieu = new DataTable();
                adapterMaPhieu.Fill(dtMaPhieu);
                cboMaPhieu.DataSource = dtMaPhieu;
                cboMaPhieu.DisplayMember = "sMaphieu";
                cboMaPhieu.ValueMember = "sMaphieu";

                // Load sách còn trong kho
                string querySach = @"
                SELECT sMasach, sTensach, fDongia, iSNhap, sTentheloai, sNhaxuatban 
                FROM tblSach s 
                JOIN tblTheloai tl ON s.sMatheloai = tl.sMatheloai 
                WHERE isDeleted = 0";

                SqlDataAdapter adapterSach = new SqlDataAdapter(querySach, connection);
                dtSachGoc = new DataTable();
                adapterSach.Fill(dtSachGoc);
                cboMaSach.DataSource = dtSachGoc;
                cboMaSach.DisplayMember = "sTensach";
                cboMaSach.ValueMember = "sMasach";

                // Load danh sách độc giả còn hiệu lực
                string queryDocGia = "SELECT sMadocgia, sTendocgia FROM tblDocGia WHERE isDeleted = 0";
                SqlDataAdapter adapterDocGia = new SqlDataAdapter(queryDocGia, connection);
                DataTable dtDocGia = new DataTable();
                adapterDocGia.Fill(dtDocGia);
                cboMaDocGia.DataSource = dtDocGia;
                cboMaDocGia.DisplayMember = "sTendocgia";
                cboMaDocGia.ValueMember = "sMadocgia";
            }
        }


        private void InitializeControls()
        {
            DisableControls();
            btnLap.Enabled = true;
            btnGiaHan.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            dtpHanThe.Enabled = false;
            dtpNgayHenTra.Enabled = false; // Vô hiệu hóa dtpNgayHenTra

            // Reset các giá trị mặc định
            dtpNgayMuon.Value = DateTime.Now;
            dtpNgayHenTra.Value = DateTime.Now.AddMonths(1);
            dtpHanThe.Value = DateTime.Now.AddYears(1); // Đặt lại hạn thẻ cách ngày hiện tại 1 năm

            // Xóa dữ liệu trong các control
            ClearControls();

        }
        private void DisableControls()
        {
            cboMaPhieu.Enabled = false;
            cboMaSach.Enabled = false;
            cboMaDocGia.Enabled = false;
            txtSoLuong.Enabled = false;
            //txtGhiChu.Enabled = false;
            dtpNgayMuon.Enabled = false;
            dtpNgayHenTra.Enabled = false;
            dtpHanThe.Enabled = false;
            txtTenSach.Enabled = false;
            txtDonGia.Enabled = false;
            txtSoLuongSach.Enabled = false;
            txtMasach.Enabled = false;
            txtTheLoai.Enabled = false;
        }

        private void EnableControls()
        {
            cboMaPhieu.Enabled = true;
            cboMaSach.Enabled = true;
            cboMaDocGia.Enabled = true;
            txtSoLuong.Enabled = true;
            //txtGhiChu.Enabled = true;
            dtpNgayMuon.Enabled = true;
            dtpNgayHenTra.Enabled = true;
            dtpHanThe.Enabled = false;
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            // Reset các control về trạng thái ban đầu
            ClearControls();
            InitializeControls();

            // Bỏ chọn hàng trong DataGridView
            dgvPhieuMuon.ClearSelection();

            // Tiếp tục các thao tác khác
            EnableControls();
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnLap.Enabled = false;
            btnGiaHan.Enabled = false;

            // Đặt ngày mượn là ngày hiện tại
            dtpNgayMuon.Enabled = false;
            dtpNgayMuon.Value = DateTime.Now;

            // Đặt ngày hẹn trả là ngày hiện tại cộng thêm 1 tháng
            dtpNgayHenTra.Value = DateTime.Now.AddMonths(1);

            // Tạo mã phiếu mới nếu cần
            if (string.IsNullOrEmpty(tempNewMaPhieu))
            {
                tempNewMaPhieu = GenerateNewMaPhieu();
            }

            // Thêm mã phiếu mới vào DataTable
            DataTable dtMaPhieu = (DataTable)cboMaPhieu.DataSource;
            DataRow newRow = dtMaPhieu.NewRow();
            newRow["sMaphieu"] = tempNewMaPhieu;
            dtMaPhieu.Rows.Add(newRow);

            // Cập nhật DataSource của ComboBox
            cboMaPhieu.DataSource = null;
            cboMaPhieu.DataSource = dtMaPhieu;
            cboMaPhieu.DisplayMember = "sMaphieu";
            cboMaPhieu.ValueMember = "sMaphieu";

            // Chọn mã phiếu mới
            cboMaPhieu.SelectedValue = tempNewMaPhieu;
            cboMaDocGia.SelectedIndex = -1;
            cboMaSach.SelectedIndex = -1; // Đặt cboMaSach không chọn bất kỳ sách nào

            cboMaDocGia.Enabled = true;
            dtpHanThe.Enabled = false;

            // Đặt chế độ hiện tại là "Lập phiếu"
            currentMode = Mode.LapPhieu;
            UpdateButtonStates();
        }

        private string GenerateNewMaPhieu()
        {
            return Library.GenerateNewID("tblPhieumuon", "sMaphieu", "PM", 4);
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            if (dgvPhieuMuon.SelectedRows.Count > 0)
            {
                var selectedRow = dgvPhieuMuon.SelectedRows[0];
                string maPhieu = selectedRow.Cells["Mã phiếu"].Value.ToString();

                // Kích hoạt dtpNgayHenTra để người dùng có thể chỉnh sửa
                dtpNgayHenTra.Enabled = true;

                // Vô hiệu hóa nút "Gia hạn" và "Lập"
                btnGiaHan.Enabled = false;
                btnLap.Enabled = false;

                // Kích hoạt nút "Lưu" và "Hủy"
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;

                // Đặt chế độ hiện tại là "Gia hạn"
                currentMode = Mode.GiaHan;
            }
        }

        private bool KiemTraSoLuongSachTrongKho(string maSach, int soLuongMuon)
        {
            using (SqlConnection connection = new SqlConnection(kn))
            {
                connection.Open();
                string query = "SELECT iSNhap FROM tblSach WHERE sMasach = @MaSach";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaSach", maSach);
                int soLuongTrongKho = Convert.ToInt32(cmd.ExecuteScalar());

                // Kiểm tra số lượng sách trong kho
                if (soLuongTrongKho <= 3)
                {
                    MessageBox.Show("Số lượng sách trong kho đang tạm hết!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; // Không cho phép mượn
                }

                return true; // Cho phép mượn
            }
        }

        private void SaveNewPhieuMuon()
        {
            if (lvSachMuon.Items.Count == 0)
            {
                MessageBox.Show("Danh sách sách mượn trống, vui lòng thêm sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(kn))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string maPhieu = cboMaPhieu.SelectedValue.ToString();
                    string maDocGia = cboMaDocGia.SelectedValue.ToString();

                    // Kiểm tra xem mã phiếu đã tồn tại hay chưa
                    string checkQuery = "SELECT COUNT(*) FROM tblPhieumuon WHERE sMaphieu = @MaPhieu";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, connection, transaction);
                    checkCmd.Parameters.AddWithValue("@MaPhieu", maPhieu);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    // Nếu phiếu chưa tồn tại, thêm phiếu mới
                    if (count == 0)
                    {
                        string queryPhieuMuon = "INSERT INTO tblPhieumuon (sMaphieu, sMadocgia, dNgaymuon) VALUES (@MaPhieu, @MaDocGia, @NgayMuon)";
                        SqlCommand cmdPhieuMuon = new SqlCommand(queryPhieuMuon, connection, transaction);
                        cmdPhieuMuon.Parameters.AddWithValue("@MaPhieu", maPhieu);
                        cmdPhieuMuon.Parameters.AddWithValue("@MaDocGia", maDocGia);
                        cmdPhieuMuon.Parameters.AddWithValue("@NgayMuon", dtpNgayMuon.Value);
                        cmdPhieuMuon.ExecuteNonQuery();
                    }

                    // Thêm chi tiết mượn cho từng sách trong ListView
                    foreach (ListViewItem item in lvSachMuon.Items)
                    {
                        string maSach = item.SubItems[1].Text;
                        int soLuong = int.Parse(item.SubItems[3].Text);

                        string queryCTMuonTra = "INSERT INTO tblCTmuontra (sMaphieu, sMasach, dNgayhentra, iSlmuon) " +
                                                "VALUES (@MaPhieu, @MaSach, @NgayHenTra, @SoLuong)";
                        SqlCommand cmdCTMuonTra = new SqlCommand(queryCTMuonTra, connection, transaction);
                        cmdCTMuonTra.Parameters.AddWithValue("@MaPhieu", maPhieu);
                        cmdCTMuonTra.Parameters.AddWithValue("@MaSach", maSach);
                        cmdCTMuonTra.Parameters.AddWithValue("@NgayHenTra", dtpNgayHenTra.Value);
                        cmdCTMuonTra.Parameters.AddWithValue("@SoLuong", soLuong);
                        //cmdCTMuonTra.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);

                        cmdCTMuonTra.ExecuteNonQuery();
                    }

                    // Commit transaction
                    transaction.Commit();

                    // Thông báo thành công
                    MessageBox.Show("Lập phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Xóa danh sách sách đã thêm vào ListView
                    lvSachMuon.Items.Clear();

                    // Cập nhật lại DataGridView để hiển thị dữ liệu mới
                    LoadData();
                }
                catch (Exception ex)
                {
                    // Rollback transaction nếu có lỗi
                    transaction.Rollback();
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveGiaHanPhieuMuon()
        {
            using (SqlConnection connection = new SqlConnection(kn))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Cập nhật ngày hẹn trả trong bảng tblCTmuontra
                    string queryUpdateNgayHenTra = "UPDATE tblCTmuontra SET dNgayhentra = @NgayHenTra WHERE sMaphieu = @MaPhieu AND sMasach = @MaSach";
                    SqlCommand cmdUpdateNgayHenTra = new SqlCommand(queryUpdateNgayHenTra, connection, transaction);
                    cmdUpdateNgayHenTra.Parameters.AddWithValue("@NgayHenTra", dtpNgayHenTra.Value);
                    cmdUpdateNgayHenTra.Parameters.AddWithValue("@MaPhieu", cboMaPhieu.SelectedValue);
                    cmdUpdateNgayHenTra.Parameters.AddWithValue("@MaSach", cboMaSach.SelectedValue);

                    // Thực thi lệnh
                    cmdUpdateNgayHenTra.ExecuteNonQuery();

                    // Commit transaction
                    transaction.Commit();

                    // Hiển thị thông báo gia hạn thành công
                    MessageBox.Show("Gia hạn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Đặt lại trạng thái và tải lại dữ liệu
                    LoadData();
                    InitializeControls();
                    currentMode = Mode.None; // Thoát khỏi chế độ gia hạn sau khi thành công
                }
                catch (Exception ex)
                {
                    // Rollback transaction nếu có lỗi xảy ra
                    transaction.Rollback();
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void SaveChiTietMuonTra()
        {
            if (cboMaPhieu.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn mã phiếu trước khi lưu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lvSachMuon.Items.Count == 0)
            {
                MessageBox.Show("Danh sách sách mượn trống, vui lòng thêm sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maPhieu = cboMaPhieu.SelectedValue.ToString();

            using (SqlConnection connection = new SqlConnection(kn))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    foreach (ListViewItem item in lvSachMuon.Items)
                    {
                        string maSach = item.SubItems[1].Text;
                        int soLuong = int.Parse(item.SubItems[3].Text);

                        // Kiểm tra số lượng sách trong kho
                        if (!KiemTraSoLuongSachTrongKho(maSach, soLuong))
                        {
                            throw new Exception($"Sách '{item.SubItems[2].Text}' không đủ số lượng trong kho!");
                        }

                        // Thêm chi tiết mượn vào CSDL
                        string queryCTMuonTra = "INSERT INTO tblCTmuontra (sMaphieu, sMasach, dNgayhentra, iSlmuon) " +
                                                "VALUES (@MaPhieu, @MaSach, @NgayHenTra, @SoLuong)";
                        SqlCommand cmdCTMuonTra = new SqlCommand(queryCTMuonTra, connection, transaction);
                        cmdCTMuonTra.Parameters.AddWithValue("@MaPhieu", maPhieu);
                        cmdCTMuonTra.Parameters.AddWithValue("@MaSach", maSach);
                        cmdCTMuonTra.Parameters.AddWithValue("@NgayHenTra", dtpNgayHenTra.Value);
                        cmdCTMuonTra.Parameters.AddWithValue("@SoLuong", soLuong);
                        //cmdCTMuonTra.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);

                        cmdCTMuonTra.ExecuteNonQuery();
                    }

                    // Commit transaction
                    transaction.Commit();

                    // Xóa danh sách sau khi lưu thành công
                    lvSachMuon.Items.Clear();
                }
                catch (Exception ex)
                {
                    // Rollback nếu có lỗi
                    transaction.Rollback();
                    MessageBox.Show("Lỗi khi lưu chi tiết phiếu mượn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {          
            /// Kiểm tra dữ liệu hợp lệ
            txtSoLuong_Validating(txtSoLuong, new CancelEventArgs());
            cboMaDocGia_Validating(cboMaDocGia, new CancelEventArgs());
            dtpNgayHenTra_Validating(dtpNgayHenTra, new CancelEventArgs());
            dtpNgayMuon_Validating(dtpNgayMuon, new CancelEventArgs());
            bool hasErrors = !string.IsNullOrEmpty(errorProvider1.GetError(txtSoLuong)) ||
                             !string.IsNullOrEmpty(errorProvider2.GetError(cboMaDocGia)) ||
                             !string.IsNullOrEmpty(errorProvider3.GetError(dtpNgayMuon)) ||
                             !string.IsNullOrEmpty(errorProvider4.GetError(dtpNgayHenTra));
            if (hasErrors)
            {
                MessageBox.Show("Vui lòng kiểm tra lại các thông tin nhập vào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Xác định hành động cần thực hiện dựa trên currentMode
            switch (currentMode)
            {
                case Mode.LapPhieu:
                    SaveNewPhieuMuon();
                    break;
                case Mode.GiaHan:
                    SaveGiaHanPhieuMuon();
                    break;
                case Mode.ThemChiTiet:
                    SaveChiTietMuonTra();
                    break;
                default:
                    MessageBox.Show("Không xác định được chế độ hiện tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            // Đặt lại trạng thái và tải lại dữ liệu (chỉ khi không có lỗi)
            if (currentMode != Mode.GiaHan || !hasErrors)
            {
                LoadData();
                InitializeControls();
                currentMode = Mode.None; // Đặt lại chế độ
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearError();
            InitializeControls();
            isCreatingNewPhieu = false;
            tempNewMaPhieu = null;
            currentMode = Mode.None; // Đặt lại chế độ
            lvSachMuon.Items.Clear();
            UpdateButtonStates();
        }

        private void ClearControls()
        {
            // Xóa thông tin trong ComboBox mã độc giả
            cboMaDocGia.SelectedIndex = -1;

            // Xóa thông tin trong các TextBox của GroupBox "Sách được mượn"
            txtMasach.Clear();
            txtTenSach.Clear();
            txtDonGia.Clear();
            txtSoLuongSach.Clear();
            txtTheLoai.Clear();

            // Xóa thông tin trong các control khác
            cboMaSach.SelectedIndex = -1;
            txtSoLuong.Clear();
            //txtGhiChu.Clear();
            dtpNgayMuon.Value = DateTime.Now;
            dtpNgayHenTra.Value = DateTime.Now.AddDays(7); // Đặt lại ngày hẹn trả mặc định
            dtpHanThe.Value = DateTime.Now.AddYears(1); // Đặt lại hạn thẻ cách ngày hiện tại 1 năm
        }

        public void ClearError()
        {
            errorProvider1.SetError(txtSoLuong, "");
            errorProvider2.SetError(cboMaDocGia, "");
            errorProvider3.SetError(dtpNgayMuon, "");
            errorProvider4.SetError(dtpNgayHenTra, "");
        }

        private void dgvPhieuMuon_SelectionChanged(object sender, EventArgs e)
        {
            if (!isCreatingNewPhieu && dgvPhieuMuon.SelectedRows.Count > 0)
            {
                var selectedRow = dgvPhieuMuon.SelectedRows[0];

                // Hiển thị mã phiếu tương ứng trong ComboBox
                string maPhieu = selectedRow.Cells["Mã phiếu"].Value.ToString();
                cboMaPhieu.SelectedValue = maPhieu;

                // Hiển thị thông tin từ hàng được chọn
                string maSach = selectedRow.Cells["Mã sách"].Value.ToString();

                // Sử dụng DataTable gốc để hiển thị mã sách
                cboMaSach.DataSource = dtSachGoc; // Sử dụng DataTable gốc
                cboMaSach.DisplayMember = "sTensach";
                cboMaSach.ValueMember = "sMasach";
                cboMaSach.SelectedValue = maSach; // Hiển thị mã sách của hàng được chọn

                // Hiển thị thông tin khác
                cboMaDocGia.SelectedValue = selectedRow.Cells["Mã độc giả"].Value.ToString();
                txtSoLuong.Text = selectedRow.Cells["SL mượn"].Value.ToString();
                //txtGhiChu.Text = selectedRow.Cells["Ghi chú"].Value.ToString();
                dtpNgayMuon.Value = Convert.ToDateTime(selectedRow.Cells["Ngày mượn"].Value);
                dtpNgayHenTra.Value = Convert.ToDateTime(selectedRow.Cells["Ngày hẹn trả"].Value);

                // Lấy Hạn thẻ từ mã độc giả
                string maDocGia = selectedRow.Cells["Mã độc giả"].Value.ToString();
                LoadHanThe(maDocGia);

                // Vô hiệu hóa các control khi xem thông tin
                DisableControls();
                ClearError();
                btnLap.Enabled = true;
                btnGiaHan.Enabled = true;
                btnLuu.Enabled = false; // Vô hiệu hóa nút Lưu
                btnHuy.Enabled = false; // Vô hiệu hóa nút Hủy
                lvSachMuon.Items.Clear();
                btnThem.Enabled = false;
            }
            else
            {
                // Nếu không có hàng nào được chọn, xóa dữ liệu trong các control
                ClearControls();
            }

        }
        private void LoadHanThe(string maDocGia)
        {
            using (SqlConnection connection = new SqlConnection(kn))
            {
                connection.Open();
                string query = "SELECT dNgayhethan FROM tblDocGia WHERE sMadocgia = @MaDocGia";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaDocGia", maDocGia);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    dtpHanThe.Value = Convert.ToDateTime(result); // Hiển thị Hạn thẻ
                }
            }
        }

        private void cboMaDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaDocGia.SelectedValue != null)
            {
                string maDocGia = cboMaDocGia.SelectedValue.ToString();
                LoadHanThe(maDocGia);
            }
        }

        private DataTable SachChuaMuon(string maPhieu)
        {
            using (SqlConnection connection = new SqlConnection(kn))
            {
                connection.Open();
                string query = @"
            SELECT s.sMasach, s.sTensach, s.fDongia, s.iSNhap, tl.sTentheloai 
            FROM tblSach s
            JOIN tblTheloai tl ON s.sMatheloai = tl.sMatheloai
            WHERE s.isDeleted = 0 
            AND s.sMasach NOT IN (
                SELECT ct.sMasach 
                FROM tblCTmuontra ct 
                WHERE ct.sMaphieu = @MaPhieu 
            )";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dtSachChuaMuon = new DataTable();
                adapter.Fill(dtSachChuaMuon);
                return dtSachChuaMuon;
            }
        }
        private void cboMaPhieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaPhieu.SelectedValue != null)
            {
                string maPhieu = cboMaPhieu.SelectedValue.ToString();

                // Lọc sách chưa được mượn trong phiếu hiện tại
                DataTable dtSachChuaMuon = SachChuaMuon(maPhieu);

                // Cập nhật ComboBox cboMaSach
                cboMaSach.DataSource = dtSachChuaMuon;
                cboMaSach.DisplayMember = "sTensach";
                cboMaSach.ValueMember = "sMasach";

                // Đặt cboMaSach không chọn bất kỳ sách nào
                cboMaSach.SelectedIndex = -1;

                // Hiển thị thông tin phiếu mượn
                DataRow[] rows = pm.Select($"[Mã phiếu] = '{maPhieu}'");

                if (rows.Length > 0)
                {
                    DataRow selectedRow = rows[0];
                    cboMaDocGia.SelectedValue = selectedRow["Mã độc giả"].ToString();
                    dtpNgayMuon.Value = Convert.ToDateTime(selectedRow["Ngày mượn"]);

                    string maDocGia = selectedRow["Mã độc giả"].ToString();
                    LoadHanThe(maDocGia);

                    cboMaDocGia.Enabled = false;
                    dtpNgayMuon.Enabled = false;

                    // Cho phép chỉnh sửa các control khác
                    txtSoLuong.Enabled = true;
                    //txtGhiChu.Enabled = true;
                    dtpNgayHenTra.Enabled = true;

                    isCreatingNewPhieu = false; // Đặt lại trạng thái lập phiếu
                }
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // Đặt hạn thẻ cách ngày hiện tại 1 năm
            dtpHanThe.Value = DateTime.Now.AddYears(1);

            // Xóa dữ liệu trong các control
            ClearControls();

            // Khởi tạo lại các control về trạng thái ban đầu
            InitializeControls();

            // Đặt rdoTendocgia làm mặc định khi form được tải
            rdoTendocgia.Checked = true;
            rdoNHT.Checked = true;

            // Đặt cboMaSach không chọn bất kỳ sách nào
            cboMaSach.SelectedIndex = -1;

            // Thực hiện tìm kiếm mặc định (nếu cần)
            PerformSearch();
        }

        private void cboMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaSach.SelectedValue != null)
            {
                string maSach = cboMaSach.SelectedValue.ToString();

                // Lấy thông tin sách từ DataTable
                DataTable dtSach = (DataTable)cboMaSach.DataSource;
                DataRow[] rows = dtSach.Select($"sMasach = '{maSach}'");

                if (rows.Length > 0)
                {
                    DataRow selectedRow = rows[0];

                    // Hiển thị thông tin sách trong các TextBox
                    txtMasach.Text = selectedRow["sMasach"].ToString();
                    txtTenSach.Text = selectedRow["sTensach"].ToString();
                    txtDonGia.Text = selectedRow["fDongia"].ToString();
                    txtSoLuongSach.Text = selectedRow["iSNhap"].ToString();
                    txtTheLoai.Text = selectedRow["sTentheloai"].ToString();
                }
            }
            UpdateButtonStates();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Đặt lại trạng thái lập phiếu
            isCreatingNewPhieu = false;
            ClearError();
            ClearControls();

            // Tải lại dữ liệu từ cơ sở dữ liệu
            LoadData();
            LoadComboBoxes();
            txtTimkiem.Text = string.Empty;

            // Khởi tạo lại các control về trạng thái ban đầu
            InitializeControls();
            lvSachMuon.Items.Clear();
        }

        private void cboMaDocGia_Validating(object sender, CancelEventArgs e)
        {
            if (cboMaDocGia.SelectedIndex == -1)
            {
                errorProvider2.SetError(cboMaDocGia, "Vui lòng chọn độc giả!");
            }
            else
            {
                errorProvider2.SetError(cboMaDocGia, ""); // Xóa lỗi nếu hợp lệ
            }
        }

        private void txtSoLuong_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoLuong.Text))
                errorProvider1.SetError(txtSoLuong, "Số lượng không được để trống!");
            else
            {
                errorProvider1.SetError(txtSoLuong, "");
                if (!int.TryParse(txtSoLuong.Text, out int sl) || sl < 1 || sl > 2)
                    errorProvider1.SetError(txtSoLuong, "Số lượng tối đa có thể mượn là 2!");
                else errorProvider1.SetError(txtSoLuong, "");
            }

        }

        private void dtpNgayMuon_Validating(object sender, CancelEventArgs e)
        {
            DateTime today = DateTime.Now.Date;

            if (dtpNgayMuon.Value.Date != today)
            {
                errorProvider1.SetError(dtpNgayMuon, "Ngày mượn phải là ngày hiện tại.");
            }
            else
            {
                errorProvider1.SetError(dtpNgayMuon, ""); // Xóa lỗi nếu hợp lệ
            }
        }

        private void PerformSearch()
        {
            string search = txtTimkiem.Text.Trim();
            string query = "";

            if (rdoMaPhieu.Checked)
                query = "SELECT * FROM v_DSPM WHERE [Mã phiếu] Like @Keyword ";
            else if (rdoTendocgia.Checked)
                query = "SELECT * FROM v_DSPM WHERE [Tên độc giả] LIKE @Keyword ";
            else if (rdoTensach.Checked)
                query = "SELECT * FROM v_DSPM WHERE [Tên sách] LIKE @Keyword "; 

            if (string.IsNullOrEmpty(search))
            {
                query = "SELECT * FROM v_DSPM"; // Thêm điều kiện IsDeleted = 0
            }

            using (SqlConnection cnn = new SqlConnection(kn))
            {
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    if (!string.IsNullOrEmpty(search))
                    {
                        if (rdoMaPhieu.Checked)
                            cmd.Parameters.AddWithValue("@Keyword", search);
                        else
                            cmd.Parameters.AddWithValue("@Keyword", "%" + search + "%");
                    }

                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable searchResult = new DataTable();
                        ad.Fill(searchResult);
                        dgvPhieuMuon.DataSource = searchResult;
                        dgvPhieuMuon.Refresh(); // Cập nhật giao diện ngay lập tức
                    }
                }
            }
        }

        private void rdoMaPhieu_CheckedChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void rdoTendocgia_CheckedChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void rdoTensach_CheckedChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void dtpNgayHenTra_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngayMuon = dtpNgayMuon.Value.Date;
            DateTime ngayHenTra = dtpNgayHenTra.Value.Date;
            DateTime hanThe = dtpHanThe.Value.Date;

            if (ngayHenTra < ngayMuon.AddDays(7))
            {
                errorProvider4.SetError(dtpNgayHenTra, "Ngày hẹn trả phải cách ngày mượn ít nhất 1 tuần!");
            }
            else if (ngayHenTra > hanThe)
            {
                errorProvider4.SetError(dtpNgayHenTra, "Ngày hẹn trả không thể vượt quá hạn thẻ!");
            }
            else
            {
                errorProvider4.SetError(dtpNgayHenTra, "");
            }
        }

        private void InitializeListView()
        {
            lvSachMuon.View = View.Details;
            lvSachMuon.FullRowSelect = true;
            lvSachMuon.GridLines = true;

            // Thêm các cột vào ListView
            lvSachMuon.Columns.Add("STT", 70); // Cột số thứ tự
            lvSachMuon.Columns.Add("Mã sách", 110);
            lvSachMuon.Columns.Add("Tên sách", 250);
            lvSachMuon.Columns.Add("Số lượng", 120);
            lvSachMuon.Columns.Add("Thể loại", 150);
            lvSachMuon.Columns.Add("NXB", 150);
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboMaSach.SelectedValue != null && !string.IsNullOrEmpty(txtSoLuong.Text))
            {
                string maSach = cboMaSach.SelectedValue.ToString();
                int soLuong;

                // Kiểm tra số lượng nhập vào có hợp lệ không
                if (!int.TryParse(txtSoLuong.Text, out soLuong) || soLuong < 1 || soLuong > 2)
                {
                    MessageBox.Show("Số lượng mượn tối đa là 2!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lấy thông tin sách từ DataTable
                DataTable dtSach = (DataTable)cboMaSach.DataSource;
                DataRow[] rows = dtSach.Select($"sMasach = '{maSach}'");

                if (rows.Length > 0)
                {
                    DataRow selectedRow = rows[0];

                    // Kiểm tra số lượng tồn kho có đủ không
                    int soLuongTonKho = Convert.ToInt32(selectedRow["iSNhap"]);
                    if (soLuong > soLuongTonKho)
                    {
                        MessageBox.Show($"Số lượng tồn kho không đủ ({soLuongTonKho} cuốn).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string tenSach = selectedRow["sTensach"].ToString();
                    string theLoai = selectedRow["sTentheloai"].ToString();
                    //string nxb = dtSach.Columns.Contains("sNhaxuatban") ? selectedRow["sNhaxuatban"].ToString() : "N/A";
                    string nxb = dtSach.Columns.Contains("sNhaxuatban") ? selectedRow["sNhaxuatban"].ToString(): "Kim Đồng";

                    // Kiểm tra xem sách đã có trong ListView chưa
                    bool exists = false;
                    foreach (ListViewItem item in lvSachMuon.Items)
                    {
                        if (item.SubItems[1].Text == maSach) // Kiểm tra theo mã sách
                        {
                            exists = true;
                            break;
                        }
                    }

                    if (!exists)
                    {
                        int stt = lvSachMuon.Items.Count + 1;
                        ListViewItem item = new ListViewItem(stt.ToString());
                        item.SubItems.Add(maSach);
                        item.SubItems.Add(tenSach);
                        item.SubItems.Add(soLuong.ToString());
                        item.SubItems.Add(theLoai);
                        item.SubItems.Add(nxb);

                        lvSachMuon.Items.Add(item);
                    }
                    else
                    {
                        MessageBox.Show("Sách đã có trong danh sách mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách và nhập số lượng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (lvSachMuon.SelectedItems.Count > 0)
            {
                // Xóa từng mục đã chọn
                foreach (ListViewItem item in lvSachMuon.SelectedItems)
                {
                    lvSachMuon.Items.Remove(item);
                }

                // Cập nhật lại số thứ tự sau khi xóa
                for (int i = 0; i < lvSachMuon.Items.Count; i++)
                {
                    lvSachMuon.Items[i].SubItems[0].Text = (i + 1).ToString();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            UpdateButtonStates();   
        }

        private void UpdateButtonStates()
        {
            // Kích hoạt nút "Thêm" nếu đang lập phiếu và đã chọn mã sách
            btnThem.Enabled = (currentMode == Mode.LapPhieu || currentMode == Mode.ThemChiTiet) && cboMaSach.SelectedIndex != -1;

            // Kích hoạt nút "Xóa" nếu có sách được chọn trong ListView
            btnXoaSach.Enabled = lvSachMuon.SelectedItems.Count > 0;
        }

        private void lvSachMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtonStates(); // Cập nhật trạng thái nút "Xóa"
        }

        /*-------------------------------------Trả sách------------------------------------------------------*/

        private void btnResetLogo_Click_1(object sender, EventArgs e)
        {
            InitializeControlsPT();
            LoadDataTra();
            txtTimKiemTra.Text = string.Empty;
        }

        private void LoadDataTra()
        {
            using (SqlConnection connection = new SqlConnection(kn))
            {
                string query = "SELECT * FROM v_DSPMT";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                pm = new DataTable();
                adapter.Fill(pm);
                dgvPhieu.DataSource = pm;
                dgvPhieu.Columns["Ngày mượn"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvPhieu.Columns["Ngày hẹn trả"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void DisplayThongTinPhieuMuon()
        {
            /// Lấy hàng được chọn
            var selectedRow = dgvPhieu.SelectedRows[0];

            // Lấy thông tin từ hàng được chọn
            string maPhieu = selectedRow.Cells["Mã phiếu"].Value.ToString();
            string maDocGia = selectedRow.Cells["Mã độc giả"].Value.ToString();
            DateTime ngayMuon = Convert.ToDateTime(selectedRow.Cells["Ngày mượn"].Value);
            DateTime ngayHenTra = Convert.ToDateTime(selectedRow.Cells["Ngày hẹn trả"].Value);

            // Lấy tên độc giả từ bảng tblDocGia
            string tenDocGia = GetTenDocGia(maDocGia);

            // Hiển thị thông tin trong các control
            txtMaPhieuTra.Text = maPhieu;
            txtMaDocGia.Text = tenDocGia;
            dtpNM.Value = ngayMuon;
            dtpNHT.Value = ngayHenTra;
        }
        private string GetTenDocGia(string maDocGia)
        {
            using (SqlConnection connection = new SqlConnection(kn))
            {
                connection.Open();
                string query = "SELECT sTendocgia FROM tblDocGia WHERE sMadocgia = @MaDocGia";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaDocGia", maDocGia);
                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : "Không tìm thấy";
            }
        }

        private void dgvPhieuMuonTra_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvPhieu.SelectedRows.Count > 0)
            {
                // Hiển thị thông tin phiếu mượn
                DisplayThongTinPhieuMuon();

                // Cho phép nhập/chọn các control
                EnableControlsForTraSach();
            }
        }

        private void DisableControlsPT()
        {
            txtMaPhieuTra.Enabled = false;
            txtMaDocGia.Enabled = false;
            dtpNM.Enabled = false;
            dtpNHT.Enabled = false;
            btnTra.Enabled = false; // Vô hiệu hóa nút trả sách
        }

        private void EnableControlsForTraSach()
        {
            btnTra.Enabled = true; 
        }

        private void InitializeControlsPT()
        {
            txtMaPhieuTra.Clear();
            txtMaDocGia.Clear();
            dtpNM.Value = DateTime.Now;
            dtpNHT.Value = DateTime.Now;

            // Vô hiệu hóa các control
            DisableControlsPT();
        }

        private void PerformSearchTra()
        {
            string search = txtTimKiemTra.Text.Trim();
            string query = "";

            // Xác định tiêu chí tìm kiếm dựa trên RadioButton được chọn
            if (rdoMaPhieuTra.Checked)
            {
                query = "SELECT * FROM v_DSPMT WHERE [Mã phiếu] = @Keyword";
            }
            else if (rdoTDG.Checked)
            {
                query = "SELECT * FROM v_DSPMT WHERE [Tên độc giả] LIKE @Keyword";
            }
            else if (rdoNHT.Checked)
            {
                query = "SELECT * FROM v_DSPMT WHERE FORMAT([Ngày hẹn trả], 'dd/MM') LIKE @Keyword";
            }

            // Nếu không có từ khóa tìm kiếm, lấy tất cả dữ liệu
            if (string.IsNullOrEmpty(search))
            {
                query = "SELECT * FROM v_DSPMT";
            }

            using (SqlConnection cnn = new SqlConnection(kn))
            {
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    if (!string.IsNullOrEmpty(search))
                    {
                        // Thêm tham số tìm kiếm
                        if (rdoMaPhieuTra.Checked)
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
                        dgvPhieu.DataSource = searchResult;
                        dgvPhieu.Refresh(); // Cập nhật giao diện ngay lập tức
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

        private void Form7_KeyDown(object sender, KeyEventArgs e)
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

        private void btnTra_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dgvPhieu.SelectedRows.Count > 0)
            {
                // Lấy mã phiếu từ hàng được chọn
                string maPhieu = dgvPhieu.SelectedRows[0].Cells["Mã phiếu"].Value.ToString();

                // Mở form chi tiết phiếu mượn và truyền mã phiếu
                FormCTmuontra formChiTiet = new FormCTmuontra(maPhieu,tenNhanVien);
                formChiTiet.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu mượn để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
