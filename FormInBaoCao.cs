using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;



namespace QuanLyThuVien
{
    public partial class FormInBaoCao : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["qltv"].ConnectionString;
        private string loaiBaoCao;
        private string maTheLoai;
        private string maPhieu;
        private string maPhieuThu;
        private int? thang;
        private int? nam;
        private string tenNhanVien;

        public FormInBaoCao(string loaiBaoCao, string tenNhanVien, string maTheLoai = null, string maPhieu = null, string maPhieuThu = null, int? thang = null, int? nam = null)
        {
            InitializeComponent();
            this.loaiBaoCao = loaiBaoCao;
            this.tenNhanVien = tenNhanVien;
            this.maTheLoai = maTheLoai;
            this.maPhieu = maPhieu;
            this.maPhieuThu = maPhieuThu;
            this.thang = thang;
            this.nam = nam;
        }

        private void FormInBaoCao_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text; 

                switch (loaiBaoCao)
                {
                    case "CR_TL_MONTH":  // Thống kê sách mượn theo thể loại & tháng/năm
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "sp_ThongKeSachMuon";
                        cmd.Parameters.AddWithValue("@MaTheLoai", maTheLoai ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Thang", thang ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Nam", nam ?? (object)DBNull.Value);
                        break;

                    case "CR_PM_DG":  // Báo cáo chi tiết phiếu mượn theo mã phiếu
                        cmd.CommandText = @"
                            SELECT ct.sMaphieu, dg.sTendocgia, s.sTensach, tl.sTentheloai, s.sNhaxuatban, 
                                   ct.iSlmuon, ct.dNgayhentra      
                            FROM tblCTmuontra ct 
                            JOIN tblPhieumuon pm ON pm.sMaphieu = ct.sMaphieu
                            JOIN tblDocGia dg ON pm.sMadocgia = dg.sMadocgia
                            JOIN tblSach s ON ct.sMasach = s.sMasach
                            JOIN tblTheloai tl On s.sMatheloai = tl.sMatheloai 
                            WHERE ct.sTinhtrangtra IS NULL AND ct.sMaphieu = @MaPhieu";
                        cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);
                        break;

                    case "CR_DG_QH":  // Báo cáo độc giả trả sách trễ hạn
                        cmd.CommandText = @"
                            SELECT ct.sMaphieu, dg.sTendocgia, s.sTensach, ct.dNgayhentra, ct.dNgaytra, 
                                   ct.iSlmuon, ct.sTinhtrangtra, ct.sGhichu
                            FROM tblCTmuontra ct 
                            JOIN tblPhieumuon pm ON pm.sMaphieu = ct.sMaphieu
                            JOIN tblDocGia dg ON pm.sMadocgia = dg.sMadocgia
                            JOIN tblSach s ON ct.sMasach = s.sMasach
                            WHERE ct.sTinhtrangtra IS NOT NULL AND ct.dNgaytra > ct.dNgayhentra";
                        break;

                    case "CR_RC_DG":  // Báo cáo phiếu thu theo mã phiếu thu
                        cmd.CommandText = @"
                            SELECT pt.sMaphieuthu AS [Mã phiếu thu], 
                                   dg.sTendocgia AS [Tên độc giả],
                                   ISNULL(pt.fConlai, 0) + ISNULL(pt.fSotienthu, 0) AS [Tổng nợ], 
                                   pt.fSotienthu AS [Số tiền thu], 
                                   pt.fConlai AS [Còn lại], 
                                   pt.dNgaythu AS [Ngày thu] 
                            FROM tblPhieuThu pt
                            JOIN tblDocGia dg ON pt.sMadocgia = dg.sMadocgia
                            WHERE pt.sMaphieuthu = @MaPhieuThu";
                        cmd.Parameters.AddWithValue("@MaPhieuThu", maPhieuThu);
                        break;

                    default:
                        MessageBox.Show("Loại báo cáo không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            ReportDocument rpt = new ReportDocument();
            string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{loaiBaoCao}.rpt");
            rpt.Load(reportPath);
            rpt.SetDataSource(dt);
            rpt.SetParameterValue("TenNhanVien", this.tenNhanVien);

            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
