using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace QuanLyThuVien
{
    public partial class FormIndex : Form
    {
        private string ketnoi;
        private string maNhanVien;
        private string tenNhanVien;
        private string taiKhoan;

        public FormIndex(string maNV,string taiKhoan, string tenNV)
        {
            InitializeComponent();
            this.maNhanVien = maNV;
            this.taiKhoan = taiKhoan;
            ketnoi = ConfigurationManager.ConnectionStrings["qltv"].ConnectionString;

            LoadTenNhanVien(); // Gọi hàm lấy tên nhân viên từ CSDL
        }
        private void LoadTenNhanVien()
        {
            using (SqlConnection cnn = new SqlConnection(ketnoi))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT sTennv FROM tblNhanVien WHERE sMaNV = @MaNV", cnn))
                {
                    cmd.Parameters.AddWithValue("@MaNV", maNhanVien);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        tenNhanVien = result.ToString();
                        lblTen.Text = $"Welcome, {tenNhanVien}!";
                    }
                }
            }
        }

        public void UpdateTenNhanVien(string tenMoi)
        {
            this.tenNhanVien = tenMoi;
            lblTen.Text = $"Welcome, {tenNhanVien}!";
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLSach f2 = new FormQLSach(tenNhanVien);
            f2.Owner = this;
            f2.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formDangNhap = new FormLogin();
            formDangNhap.Show();
        }


        private void báoCáoPhiếuTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBookReport f2 = new FormBookReport(tenNhanVien);
            f2.Owner = this;
            f2.Show();
        }

        private void báoCáoThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserReport f2 = new FormUserReport(tenNhanVien);
            f2.Owner = this;
            f2.Show();
        }

        private void lịchSửPhiếuTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistoryReport f2 = new FormHistoryReport();
            f2.Owner = this;
            f2.Show();
        }

        private void quảnLýPhiếuThuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormReceipt f2 = new FormReceipt(tenNhanVien);
            f2.Owner = this;
            f2.Show();
        }

        private void FormIndex_Load(object sender, EventArgs e)
        {
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formDangNhap = new FormLogin();
            formDangNhap.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormChangePw f2 = new FormChangePw(taiKhoan);
            f2.Owner = this;
            f2.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminInfor f2 = new FormAdminInfor(maNhanVien,taiKhoan);
            f2.Owner = this;
            f2.Show();
        }

        private void quảnLýPhiếuThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLDocGia f2 = new FormQLDocGia(tenNhanVien);
            f2.Owner = this;
            f2.Show();
        }

        private void quảnLýPhiếuThuToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormReceipt f2 = new FormReceipt(tenNhanVien);
            f2.Owner = this;
            f2.Show();
        }

        private void quảnLýMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f2 = new Form7(tenNhanVien);
            f2.Owner = this;
            f2.Show();
        }

        private void lịchSửTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistoryReport f2 = new FormHistoryReport();
            f2.Owner = this;
            f2.Show();
        }

        private void thêmTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Danhsach f2 = new Danhsach ();
            f2.Owner = this;
            f2.Show();
        }
    }
}
