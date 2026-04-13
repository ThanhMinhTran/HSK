using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.ComponentModel;

namespace QuanLyThuVien
{
    public partial class FormUserReport : Form
    {
        private string kn;
        private DataTable pm;
        private DataTable pt;
        private string tenNhanVien;

        public FormUserReport(string tenNV)
        {
            InitializeComponent();
            kn = ConfigurationManager.ConnectionStrings["qltv"].ConnectionString;
            LoadDataDocGia();
            LoadDataTreHan();
            this.tenNhanVien = tenNV;
        }

        private void LoadDataDocGia()
        {
            using (SqlConnection connection = new SqlConnection(kn))
            {
                string query = @"
            SELECT 
                dg.sMadocgia AS [Mã độc giả],
                sTendocgia AS [Tên độc giả], 
                sTenloaidocgia AS [Loại độc giả],
                count(sMasach) as [Số lần mượn],
                sum(iSlmuon) as [SL mượn]
                
            FROM 
                tblDocGia dg
                JOIN tblPhieumuon pt ON pt.sMadocgia = dg.sMadocgia
                JOIN tblCTmuontra ct ON ct.sMaphieu = pt.sMaphieu
                JOIN tblLoaidocgia l On l.sMaloaidocgia = dg.sMaloaidocgia
            Group by dg.sMadocgia,sTendocgia,sTenloaidocgia
            ORDER BY 
               count(sMasach) desc";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                pm = new DataTable();
                adapter.Fill(pm);
                dgvDocGia.DataSource = pm;
            }
        }

        private void LoadDataTreHan()
        {
            using (SqlConnection connection = new SqlConnection(kn))
            {
                string query = @"
            SELECT 
                dg.sMadocgia AS [Mã độc giả],
                sTendocgia AS [Tên độc giả], 
                sTensach as [Tên sách],
                ct.sTinhtrangtra as [Tình trạng],
                dNgaytra as [Ngày trả],
                DATEDIFF(day, dNgayhentra, dNgaytra) as [Trễ (ngày)]
            FROM 
                tblDocGia dg
                JOIN tblPhieumuon pt ON pt.sMadocgia = dg.sMadocgia
                JOIN tblCTmuontra ct ON ct.sMaphieu = pt.sMaphieu
                JOIN tblSach s On s.sMasach = ct.sMasach
            WHERE 
                dNgaytra > dNgayhentra
            ORDER BY 
               dNgaytra ASC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                pt = new DataTable();
                adapter.Fill(pt);
                dgvTreHan.DataSource = pt;
                dgvTreHan.Columns["Ngày trả"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void btnReport2_Click(object sender, EventArgs e)
        {
            FormInBaoCao reportForm = new FormInBaoCao("CR_DG_QH", this.tenNhanVien);
            reportForm.ShowDialog();
        }

        private void FormUserReport_Load(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
