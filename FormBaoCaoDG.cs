using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace QuanLyThuVien
{
    public partial class FormBaoCaoDG : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["qltv"].ConnectionString;
        private DataTable dtDocGia; // Lưu dữ liệu độc giả
        private string tenNhanVien;
        public FormBaoCaoDG(string tenNV)
        {
            InitializeComponent();
            this.tenNhanVien = tenNV;
        }

        private void FormBaoCaoDG_Load(object sender, EventArgs e)
        {
            LoadLoaiDocGia(); // Load danh sách loại độc giả vào ComboBox
            LoadData();       // Lấy toàn bộ danh sách độc giả
            LoadReport(dtDocGia); // Hiển thị báo cáo ngay khi mở form
        }

        private void LoadLoaiDocGia()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT sMaloaidocgia, sTenloaidocgia FROM tblLoaidocgia";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboMadocgia.DataSource = dt;
                cboMadocgia.DisplayMember = "sTenloaidocgia";
                cboMadocgia.ValueMember = "sMaloaidocgia";
                cboMadocgia.SelectedIndex = -1; // Không chọn gì ban đầu
            }
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_GetAllDocGia", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dtDocGia = new DataTable();
                da.Fill(dtDocGia); // Lưu toàn bộ dữ liệu vào DataTable
            }
        }

        private void LoadReport(DataTable data)
        {

            CR_DG rpt = new CR_DG();
            rpt.SetDataSource(data); // Đưa dữ liệu vào báo cáo
            rpt.SetParameterValue("TenNhanVien", this.tenNhanVien);
            rdoNam.ReportSource = rpt;
            rdoNam.Refresh();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string tenDocGia = txtTendocgia.Text.Trim();
            string maLoaiDocGia = cboMadocgia.SelectedValue?.ToString();
            string gioiTinh = "";

            if (rdooNam.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (rdoNu.Checked)
            {
                gioiTinh = "Nữ";
            }

            DataView dv = new DataView(dtDocGia);
            string filter = "1 = 1"; // Luôn đúng để dễ dàng thêm điều kiện

            if (!string.IsNullOrEmpty(maLoaiDocGia))
            {
                filter += $" AND [Loại độc giả] = '{cboMadocgia.Text}'"; 
            }
            if (!string.IsNullOrEmpty(tenDocGia))
            {
                filter += $" AND [Tên độc giả] LIKE '%{tenDocGia}%'";
            }
            if (!string.IsNullOrEmpty(gioiTinh))
            {
                filter += $" AND [Giới tính] = '{gioiTinh}'";
            }

            dv.RowFilter = filter; 

            LoadReport(dv.ToTable()); 
        }
    }
}
