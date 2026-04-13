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
    public partial class FormQLDocGia : Form
    {
        private string kn;
        private string tenNhanVien;
        private bool isAdding = false;
        public FormQLDocGia(string tenNV)
        {
            InitializeComponent();
            kn = ConfigurationManager.ConnectionStrings["qltv"].ConnectionString;
            InitializeControls();
            this.KeyPreview = true;
            this.tenNhanVien = tenNV;
        }

        private void Loadata()
        {
            Library.LoadDataToGridView(dsDocgia, "Select * from v_DSDG");
            dsDocgia.Columns["Ngày sinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dsDocgia.Columns["Ngày lập thẻ"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dsDocgia.Columns["Ngày hết hạn"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        private void LoadLoaiDG()
        {
            Library.LoadComboBox(cboLoaidocgia, "tblLoaidocgia", "sMaloaidocgia", "sTenloaidocgia");
        }

        private void InitializeControls()
        {
            DisableTextBoxes();
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Enabled = true;
            btnGiaHan.Enabled = false; // Vô hiệu hóa nút "Gia hạn"
            dNgayhethan.Enabled = false;

            isAdding = false;
            LoadLoaiDG();

            cboLoaidocgia.SelectedIndex = 0;
        }

        private void DisableTextBoxes()
        {
            txtMadocgia.Enabled = false;
            txtTendocgia.Enabled = false;
            txtEmail.Enabled = false;
            txtSdt.Enabled = false;
            txtDiachi.Enabled = false;
            cboLoaidocgia.Enabled = false;
            rdoNam.Enabled = false;
            rdoNu.Enabled = false;
            dNgayhethan.Enabled = false;
            dNgaylapthe.Enabled = false;
            dNgaysinh.Enabled = false;
           
        }

        private void EnableTextBoxes()
        {
            txtMadocgia.Enabled = false; // Luôn vô hiệu hóa mã độc giả
            txtTendocgia.Enabled = true;
            txtSdt.Enabled = true;
            txtEmail.Enabled = true;
            txtDiachi.Enabled = true;
            cboLoaidocgia.Enabled = true;
            rdoNam.Enabled = true;
            rdoNu.Enabled = true;
            dNgaylapthe.Enabled = true;
            dNgaysinh.Enabled = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Loadata();
            InitializeControls();
            dNgayhethan.Value = dNgaylapthe.Value.AddMonths(3);
        }

        private void ClearTextBoxes()
        {
            txtMadocgia.Text = string.Empty; // Đảm bảo mã độc giả bị xóa khi Reset
            txtTendocgia.Text = string.Empty;
            txtSdt.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDiachi.Text = string.Empty;
            dNgaysinh.Value = DateTime.Now;
            dNgaylapthe.Value = DateTime.Now;
            dNgayhethan.Value = DateTime.Now;
            rdoNam.Checked = true;
            cboLoaidocgia.SelectedIndex = -1;
        }

        public void ClearError()
        {
            errorProvider1.SetError(txtMadocgia, "");
            errorProvider2.SetError(txtTendocgia, "");
            errorProvider3.SetError(txtEmail, "");
            errorProvider4.SetError(txtSdt, "");
            errorProvider5.SetError(dNgayhethan, "");
            errorProvider6.SetError(dNgaylapthe, "");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAdding = true;
            EnableTextBoxes();
            ClearTextBoxes();

            txtMadocgia.Text = GenerateNewMaDocGia(); // Tự động tạo mã độc giả
            txtMadocgia.Enabled = false; // Đảm bảo không thể chỉnh sửa

            cboLoaidocgia.SelectedIndex = 0;
            rdoNam.Checked = true;
            dNgaylapthe.Value = DateTime.Now;
            dNgayhethan.Enabled = true;
            dNgaylapthe.Enabled = false;
            dNgayhethan.Value = dNgaylapthe.Value.AddMonths(3);

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dsDocgia.SelectedRows.Count > 0)
            {
                isAdding = false;
                EnableTextBoxes();

                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                btnGiaHan.Enabled = false; // Vô hiệu hóa nút "Gia hạn"
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dsDocgia.SelectedRows.Count > 0)
            {
                var selectedRow = dsDocgia.SelectedRows[0];
                string maDG = selectedRow.Cells["Mã độc giả"].Value.ToString();

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa độc giả này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection cnn = new SqlConnection(kn))
                        {
                            cnn.Open();
                            using (SqlCommand cmd = cnn.CreateCommand())
                            {
                                cmd.CommandText = "UPDATE tblDocGia SET IsDeleted = 1 WHERE sMadocgia = @MaDG";
                                cmd.Parameters.AddWithValue("@MaDG", maDG);

                                int rowsAffected = cmd.ExecuteNonQuery(); // Số dòng bị ảnh hưởng bởi câu lệnh SQL

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Đã xóa độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Xóa độc giả thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }

                        Loadata(); // Tải lại dữ liệu sau khi xóa
                        InitializeControls();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa độc giả: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                ClearTextBoxes();
                dsDocgia.ClearSelection();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            ClearError();
            InitializeControls();
            isAdding = false;
            ClearTextBoxes(); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Gọi các phương thức Validating một cách thủ công
            txtTendocgia_Validating(txtTendocgia, new CancelEventArgs());
            txtEmail_Validating(txtEmail, new CancelEventArgs());
            txtSdt_Validating(txtSdt, new CancelEventArgs());
            dNgayhethan_Validating(dNgayhethan, new CancelEventArgs());

            // Kiểm tra xem có lỗi nào không
            bool hasErrors =
                !string.IsNullOrEmpty(errorProvider2.GetError(txtTendocgia)) ||
                !string.IsNullOrEmpty(errorProvider3.GetError(txtEmail)) ||
                !string.IsNullOrEmpty(errorProvider4.GetError(txtSdt)) ||
                !string.IsNullOrEmpty(errorProvider5.GetError(dNgayhethan));

            // Nếu có lỗi, không thực hiện lưu
            if (hasErrors)
            {
                MessageBox.Show("Vui lòng kiểm tra lại các thông tin nhập vào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection cnn = new SqlConnection(kn))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    if (isAdding)
                    {
                        cmd.CommandText = "Insert into tblDocgia (sMadocgia,sTendocgia,dNgaysinh,sGioitinh,sEmail,sDiachi,sSdt,sMaloaidocgia,fTongno,dNgaylapthe,dNgayhethan,isDeleted) Values(@madg,@tendg,@nsinh,@gtinh,@email,@diachi,@sdt,@loaidg,0,@nlt,@nhh,0)";
                        cmd.Parameters.AddWithValue("@nhh", dNgayhethan.Value); // Chỉ thêm ngày hết hạn khi thêm mới
                    }
                    else
                    {
                        cmd.CommandText = "Update tblDocgia Set sTendocgia = @tendg, dNgaysinh = @nsinh, sGioitinh = @gtinh, sEmail = @email, " +
                                          "sDiachi = @diachi, sSdt = @sdt, sMaloaidocgia = @loaidg, dNgaylapthe = @nlt, dNgayhethan = @nhh Where sMadocgia = @madg";
                        cmd.Parameters.AddWithValue("@nhh", dNgayhethan.Value); // Cập nhật ngày hết hạn khi sửa
                    }

                    cmd.Parameters.AddWithValue("@madg", txtMadocgia.Text);
                    cmd.Parameters.AddWithValue("@tendg", txtTendocgia.Text);
                    cmd.Parameters.AddWithValue("@nsinh", dNgaysinh.Value);
                    cmd.Parameters.AddWithValue("@gtinh", rdoNam.Checked ? "Nam" : "Nữ");
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@diachi", txtDiachi.Text);
                    cmd.Parameters.AddWithValue("@sdt", txtSdt.Text);
                    cmd.Parameters.AddWithValue("@loaidg", cboLoaidocgia.SelectedValue);
                    cmd.Parameters.AddWithValue("@nlt", dNgaylapthe.Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Độc giả đã được lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            InitializeControls(); // Khôi phục trạng thái ban đầu
            Loadata();
        }

        private void dsDocgia_SelectionChanged(object sender, EventArgs e)
        {
            if (dsDocgia.SelectedRows.Count > 0)
            {
                var selecterRow = dsDocgia.SelectedRows[0];
                txtMadocgia.Text = selecterRow.Cells["Mã độc giả"].Value.ToString();
                txtTendocgia.Text = selecterRow.Cells["Tên độc giả"].Value.ToString();
                txtEmail.Text = selecterRow.Cells["Email"].Value.ToString();
                txtDiachi.Text = selecterRow.Cells["Địa chỉ"].Value.ToString();
                rdoNam.Checked = selecterRow.Cells["Giới tính"].Value.ToString() == "Nam";
                rdoNu.Checked = selecterRow.Cells["Giới tính"].Value.ToString() == "Nữ";
                dNgaysinh.Value = Convert.ToDateTime(selecterRow.Cells["Ngày sinh"].Value);
                txtSdt.Text = selecterRow.Cells["Số điện thoại"].Value.ToString();
                cboLoaidocgia.Text = selecterRow.Cells["Loại độc giả"].Value.ToString();
                dNgaylapthe.Value = Convert.ToDateTime(selecterRow.Cells["Ngày lập thẻ"].Value);
                dNgayhethan.Value = Convert.ToDateTime(selecterRow.Cells["Ngày hết hạn"].Value);

                DisableTextBoxes();
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnGiaHan.Enabled = true; // Kích hoạt nút "Gia hạn"
                btnEdit.Enabled = true;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                ClearError();
            }
        }

        private string GenerateNewMaDocGia()
        {
            return Library.GenerateNewID("tblDocgia", "sMadocgia", "DG", 4);
        }


        private void txtTendocgia_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTendocgia.Text))
                errorProvider2.SetError(txtTendocgia, "Tên độc giả không được để trống");
            else errorProvider2.SetError(txtTendocgia, "");
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
                errorProvider3.SetError(txtEmail, "Email không được để trống!");
            else
            {
                if (!txtEmail.Text.EndsWith("@gmail.com"))
                    errorProvider3.SetError(txtEmail, "Email phải có đuôi @gmail.com!");
                else
                    errorProvider3.SetError(txtEmail, "");
            } 
        }

        private void txtSdt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSdt.Text))
                errorProvider4.SetError(txtSdt, "Số điện thoại không được để trống!");
            else
            {
                if (txtSdt.Text.Length != 10 || !txtSdt.Text.All(char.IsDigit))
                    errorProvider4.SetError(txtSdt, "Số điện thoại phải có 10 chữ số và không chứa ký tự không phải số!");
                else errorProvider4.SetError(txtSdt, "");
            }
        }

        private void dNgayhethan_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngayHienTai = DateTime.Now.Date; 

            if (dNgayhethan.Value < dNgaylapthe.Value.AddMonths(3))
            {
                errorProvider5.SetError(dNgayhethan, "Ngày hết hạn phải lớn hơn ngày lập thẻ ít nhất 3 tháng!");
            }
            else if (dNgayhethan.Value <= ngayHienTai)
            {
                errorProvider5.SetError(dNgayhethan, "Ngày hết hạn phải lớn hơn ngày hiện tại!");
            }
            else
            {
                errorProvider5.SetError(dNgayhethan, "");
            }
        }

        private void performSearch()
        {
            string search = txtTimkiem.Text.Trim();
            string querry = "";

            if (rdoMaSach.Checked)
                querry = "Select * from v_DSDG Where [Mã độc giả] = @keyword";
            else if (rdoTenSach.Checked)
                querry = "Select * from v_DSDG Where [Tên độc giả] Like @keyword";
            else if (rdoLoai.Checked)
                querry = "Select sMadocgia as [Mã độc giả], sTendocgia as [Tên độc giả], dNgaysinh as [Ngày sinh], sGioitinh as [Giới tính], " +
                    "sEmail as [Email], sDiachi as [Địa chỉ], sSdt as [Số điện thoại], d.sMaloaidocgia as [Mã loại độc giả], dNgaylapthe as [Ngày lập thẻ]," +
                    "dNgayhethan as [Ngày hết hạn] From tblDocgia d Join tblLoaidocgia m On d.sMaloaidocgia = m.sMaloaidocgia Where " +
                    "sTenloaidocgia Like @keyword AND isDeleted = 0";

            if (string.IsNullOrEmpty(txtTimkiem.Text))
                querry = "Select * from v_DSDG";
            using (SqlConnection cnn = new SqlConnection(kn))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = querry;
                    if (!string.IsNullOrEmpty(search))
                    {
                        if (rdoMaSach.Checked)
                            cmd.Parameters.AddWithValue("@keyword", search);
                        else cmd.Parameters.AddWithValue("@keyword", "%" + search + "%");
                    }
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dsDocgia.DataSource = tb;
                    }
                }
            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            performSearch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Load lại dữ liệu từ cơ sở dữ liệu
            Loadata();

            // Khôi phục trạng thái ban đầu của các control
            InitializeControls();

            ClearError();
            txtTimkiem.Text = string.Empty;
            // Xóa các giá trị trong các textbox và datetimepicker
            ClearTextBoxes();
        }

        private void rdoLoai_CheckedChanged(object sender, EventArgs e)
        {
            performSearch();
        }

        private void rdoMaSach_CheckedChanged(object sender, EventArgs e)
        {
            performSearch();
        }

        private void rdoTenSach_CheckedChanged(object sender, EventArgs e)
        {
            performSearch();
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            if (dsDocgia.SelectedRows.Count > 0)
            {
               

                // Cho phép chỉnh sửa ngày hết hạn
                dNgayhethan.Enabled = true;

                // Vô hiệu hóa nút "Gia hạn"
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                btnGiaHan.Enabled = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một độc giả để gia hạn thẻ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dNgayhethan_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra nếu phím được nhấn là Esc
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

        private void dNgaylapthe_Validating(object sender, CancelEventArgs e)
        {

            DateTime today = DateTime.Now.Date;

            if (dNgaylapthe.Value.Date > today)
            {
                errorProvider6.SetError(dNgaylapthe, "Ngày lập thẻ không hợp lệ!.");
            }
            else
            {
                errorProvider6.SetError(dNgaylapthe, ""); // Xóa lỗi nếu hợp lệ
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FormBaoCaoDG reportForm = new FormBaoCaoDG(tenNhanVien);
            reportForm.ShowDialog(); // Mở form báo cáo
        }
    }
}
