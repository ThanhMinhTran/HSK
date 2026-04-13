using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace QuanLyThuVien
{
    public partial class FormBaoCao : Form
    {
        private string tenNhanVien;
        private string ketnoi = ConfigurationManager.ConnectionStrings["qltv"].ConnectionString;

        public FormBaoCao(string tenNV)
        {
            InitializeComponent();
            this.tenNhanVien = tenNV;
        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(ketnoi))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM v_DSS", cnn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            // Load Crystal Report
                            CR_DSSACH_TL rpt = new CR_DSSACH_TL();
                            
                            // Đưa dữ liệu vào Crystal Report
                            rpt.SetDataSource(dt);
                            rpt.SetParameterValue("TenNhanVien", this.tenNhanVien);
                            crystalReportViewer1.ReportSource = rpt;
                            crystalReportViewer1.Refresh();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
