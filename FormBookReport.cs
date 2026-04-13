using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.ComponentModel;


namespace QuanLyThuVien
{
    public partial class FormBookReport : Form
    {
        private string kn;
        private DataTable pm;
        private DataTable pt;
        private string tenNhanVien;
        public FormBookReport(string tenNV)
        {
            InitializeComponent();
            kn = ConfigurationManager.ConnectionStrings["qltv"].ConnectionString;
            LoadDataTreHan();
            this.tenNhanVien = tenNV;
        }

        private void LoadData(int? thang = null, int? nam = null)
        {
            using (SqlConnection connection = new SqlConnection(kn))
            {
                string query = @"
            SELECT 
                s.sMatheloai AS [Mã thể loại],
                sTentheloai AS [Tên thể loại], 
                SUM(iSlmuon) AS [Số lượng mượn],
                CAST(SUM(iSlmuon) * 100.0 / SUM(SUM(iSlmuon)) OVER () AS DECIMAL(5, 2)) AS [Tỉ lệ (%)]
            FROM 
                tblCTmuontra pm
                JOIN tblPhieumuon ct ON pm.sMaphieu = ct.sMaphieu
                JOIN tblSach s ON pm.sMasach = s.sMasach
                JOIN tblTheloai tl ON tl.sMatheloai = s.sMatheloai
            WHERE 
                (@Thang IS NULL OR MONTH(ct.dNgaymuon) = @Thang)
                AND (@Nam IS NULL OR YEAR(ct.dNgaymuon) = @Nam)
            GROUP BY 
                s.sMatheloai, 
                sTentheloai
            ORDER BY 
                SUM(iSlmuon) DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Thang", thang ?? (object)DBNull.Value);
                adapter.SelectCommand.Parameters.AddWithValue("@Nam", nam ?? (object)DBNull.Value);

                pm = new DataTable();
                adapter.Fill(pm);
                dgvTKS_TL.DataSource = pm;
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // Thêm các tháng vào ComboBox
            for (int i = 1; i <= 12; i++)
            {
                cboThang.Items.Add(i);
            }

            // Thêm các năm vào ComboBox (từ 3 năm trước đến 3 năm sau hiện tại)
            int currentYear = DateTime.Now.Year;
            for (int i = currentYear - 3; i <= currentYear + 3; i++)
            {
                cboNam.Items.Add(i);
            }

            // Không chọn giá trị mặc định cho ComboBox tháng và năm
            cboThang.SelectedIndex = -1;
            cboNam.SelectedIndex = -1;

            // Load dữ liệu mặc định (tất cả dữ liệu)
            LoadData();
        }

        private void cboThang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Lấy giá trị tháng và năm từ ComboBox
            int? thang = cboThang.SelectedItem as int?;
            int? nam = cboNam.SelectedItem as int?;

            // Gọi phương thức LoadData để cập nhật dữ liệu
            LoadData(thang, nam);
        }

        private void cboNam_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Lấy giá trị tháng và năm từ ComboBox
            int? thang = cboThang.SelectedItem as int?;
            int? nam = cboNam.SelectedItem as int?;

            // Gọi phương thức LoadData để cập nhật dữ liệu
            LoadData(thang, nam);
        }

        private void LoadChiTietSachMuon(string maTheLoai, int? thang = null, int? nam = null)
        {
            using (SqlConnection connection = new SqlConnection(kn))
            {
                string query = @"
            SELECT 
                s.sMasach AS [Mã sách],
                s.sTensach AS [Tên sách],
                SUM(pm.iSlmuon) AS [SL mượn],
                FORMAT(ct.dNgaymuon, 'MM/yyyy') AS [Thời gian mượn]
            FROM 
                tblCTmuontra pm
                JOIN tblPhieumuon ct ON pm.sMaphieu = ct.sMaphieu
                JOIN tblSach s ON pm.sMasach = s.sMasach
                JOIN tblTheloai tl ON tl.sMatheloai = s.sMatheloai
            WHERE 
                tl.sMatheloai = @MaTheLoai
                AND (@Thang IS NULL OR MONTH(ct.dNgaymuon) = @Thang)
                AND (@Nam IS NULL OR YEAR(ct.dNgaymuon) = @Nam)
            GROUP BY 
                s.sMasach, 
                s.sTensach,
                FORMAT(ct.dNgaymuon, 'MM/yyyy')";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@MaTheLoai", maTheLoai);
                adapter.SelectCommand.Parameters.AddWithValue("@Thang", thang ?? (object)DBNull.Value);
                adapter.SelectCommand.Parameters.AddWithValue("@Nam", nam ?? (object)DBNull.Value);

                DataTable dtChiTiet = new DataTable();
                adapter.Fill(dtChiTiet);

                // Hiển thị dữ liệu trong dgvCT
                dgvCT.DataSource = dtChiTiet;
            }
        }

        private void dgvTKS_TL_SelectionChanged_1(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dgvTKS_TL.SelectedRows.Count > 0)
            {
                // Lấy mã thể loại từ hàng được chọn
                var selectedRow = dgvTKS_TL.SelectedRows[0];
                string maTheLoai = selectedRow.Cells["Mã thể loại"].Value.ToString();

                // Lấy giá trị tháng và năm từ ComboBox
                int? thang = cboThang.SelectedItem as int?;
                int? nam = cboNam.SelectedItem as int?;

                // Gọi phương thức để hiển thị chi tiết sách đã mượn
                LoadChiTietSachMuon(maTheLoai, thang, nam);
            }
        }

        private void LoadDataTreHan()
        {
            using (SqlConnection connection = new SqlConnection(kn))
            {
                string query = @"
            SELECT 
                s.sMasach AS [Mã sách],
                sTensach AS [Tên sách], 
                sTentheloai AS [Tên thể loại],
                dNgaytra as [Ngày trả],
                DATEDIFF(day, dNgayhentra, dNgaytra) as [Số ngày trễ hẹn]
            FROM 
                tblCTmuontra pt
                JOIN tblSach s ON pt.sMasach = s.sMasach
                JOIN tblTheloai tl ON tl.sMatheloai = s.sMatheloai
            WHERE 
                dNgaytra > dNgayhentra
            ORDER BY 
                dNgaytra ASC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                pt = new DataTable();
                adapter.Fill(pt);
                dgvSachtrehan.DataSource = pt;
                dgvSachtrehan.Columns["Ngày trả"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvTKS_TL.SelectedRows.Count > 0)
            {
                string maTheLoai = dgvTKS_TL.SelectedRows[0].Cells["Mã thể loại"].Value.ToString();
                int? thang = cboThang.SelectedItem as int?;
                int? nam = cboNam.SelectedItem as int?;

                FormInBaoCao reportForm = new FormInBaoCao("CR_TL_MONTH", this.tenNhanVien, maTheLoai, null, null, thang, nam);
                reportForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một thể loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

