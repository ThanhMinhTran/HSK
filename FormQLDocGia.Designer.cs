
namespace QuanLyThuVien
{
    partial class FormQLDocGia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLDocGia));
            this.btnHome = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dsDocgia = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dNgayhethan = new System.Windows.Forms.DateTimePicker();
            this.dNgaylapthe = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.cboLoaidocgia = new System.Windows.Forms.ComboBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTendocgia = new System.Windows.Forms.TextBox();
            this.txtMadocgia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoLoai = new System.Windows.Forms.RadioButton();
            this.rdoTenSach = new System.Windows.Forms.RadioButton();
            this.rdoMaSach = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnReport = new System.Windows.Forms.Button();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDocgia)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHome.Location = new System.Drawing.Point(7, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(104, 98);
            this.btnHome.TabIndex = 23;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dsDocgia);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox5.Location = new System.Drawing.Point(42, 691);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1276, 328);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách Độc giả";
            // 
            // dsDocgia
            // 
            this.dsDocgia.AllowUserToOrderColumns = true;
            this.dsDocgia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dsDocgia.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dsDocgia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dsDocgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsDocgia.Location = new System.Drawing.Point(7, 31);
            this.dsDocgia.Name = "dsDocgia";
            this.dsDocgia.RowHeadersWidth = 82;
            this.dsDocgia.RowTemplate.Height = 33;
            this.dsDocgia.Size = new System.Drawing.Size(1263, 291);
            this.dsDocgia.TabIndex = 0;
            this.dsDocgia.SelectionChanged += new System.EventHandler(this.dsDocgia_SelectionChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dNgayhethan);
            this.groupBox4.Controls.Add(this.dNgaylapthe);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.dNgaysinh);
            this.groupBox4.Controls.Add(this.rdoNu);
            this.groupBox4.Controls.Add(this.rdoNam);
            this.groupBox4.Controls.Add(this.cboLoaidocgia);
            this.groupBox4.Controls.Add(this.txtDongia);
            this.groupBox4.Controls.Add(this.txtSdt);
            this.groupBox4.Controls.Add(this.txtDiachi);
            this.groupBox4.Controls.Add(this.txtEmail);
            this.groupBox4.Controls.Add(this.txtTendocgia);
            this.groupBox4.Controls.Add(this.txtMadocgia);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox4.Location = new System.Drawing.Point(49, 227);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1263, 345);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin Độc giả";
            // 
            // dNgayhethan
            // 
            this.dNgayhethan.CustomFormat = "dd/MM/yyyy";
            this.dNgayhethan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dNgayhethan.Location = new System.Drawing.Point(884, 289);
            this.dNgayhethan.Name = "dNgayhethan";
            this.dNgayhethan.Size = new System.Drawing.Size(267, 35);
            this.dNgayhethan.TabIndex = 26;
            this.dNgayhethan.ValueChanged += new System.EventHandler(this.dNgayhethan_ValueChanged);
            this.dNgayhethan.Validating += new System.ComponentModel.CancelEventHandler(this.dNgayhethan_Validating);
            // 
            // dNgaylapthe
            // 
            this.dNgaylapthe.CustomFormat = "dd/MM/yyyy";
            this.dNgaylapthe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dNgaylapthe.Location = new System.Drawing.Point(884, 240);
            this.dNgaylapthe.Name = "dNgaylapthe";
            this.dNgaylapthe.Size = new System.Drawing.Size(267, 35);
            this.dNgaylapthe.TabIndex = 25;
            this.dNgaylapthe.Validating += new System.ComponentModel.CancelEventHandler(this.dNgaylapthe_Validating);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(708, 276);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 48);
            this.label11.TabIndex = 24;
            this.label11.Text = "Ngày hết hạn :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dNgaysinh
            // 
            this.dNgaysinh.CustomFormat = "dd/MM/yyyy";
            this.dNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dNgaysinh.Location = new System.Drawing.Point(883, 191);
            this.dNgaysinh.Name = "dNgaysinh";
            this.dNgaysinh.Size = new System.Drawing.Size(268, 35);
            this.dNgaysinh.TabIndex = 23;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(289, 193);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(73, 31);
            this.rdoNu.TabIndex = 22;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(184, 193);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(89, 31);
            this.rdoNam.TabIndex = 21;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // cboLoaidocgia
            // 
            this.cboLoaidocgia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaidocgia.FormattingEnabled = true;
            this.cboLoaidocgia.Location = new System.Drawing.Point(884, 142);
            this.cboLoaidocgia.Name = "cboLoaidocgia";
            this.cboLoaidocgia.Size = new System.Drawing.Size(345, 35);
            this.cboLoaidocgia.TabIndex = 20;
            // 
            // txtDongia
            // 
            this.txtDongia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDongia.Location = new System.Drawing.Point(883, 93);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(345, 35);
            this.txtDongia.TabIndex = 16;
            // 
            // txtSdt
            // 
            this.txtSdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSdt.Location = new System.Drawing.Point(883, 44);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(345, 35);
            this.txtSdt.TabIndex = 15;
            this.txtSdt.Validating += new System.ComponentModel.CancelEventHandler(this.txtSdt_Validating);
            // 
            // txtDiachi
            // 
            this.txtDiachi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiachi.Location = new System.Drawing.Point(184, 240);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(345, 35);
            this.txtDiachi.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(184, 147);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(345, 35);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtTendocgia
            // 
            this.txtTendocgia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTendocgia.Location = new System.Drawing.Point(184, 97);
            this.txtTendocgia.Name = "txtTendocgia";
            this.txtTendocgia.Size = new System.Drawing.Size(345, 35);
            this.txtTendocgia.TabIndex = 11;
            this.txtTendocgia.Validating += new System.ComponentModel.CancelEventHandler(this.txtTendocgia_Validating);
            // 
            // txtMadocgia
            // 
            this.txtMadocgia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMadocgia.Location = new System.Drawing.Point(184, 47);
            this.txtMadocgia.Multiline = true;
            this.txtMadocgia.Name = "txtMadocgia";
            this.txtMadocgia.Size = new System.Drawing.Size(345, 31);
            this.txtMadocgia.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(708, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 48);
            this.label10.TabIndex = 9;
            this.label10.Text = "Ngày lập thẻ :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(708, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 48);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ngày sinh :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(708, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 48);
            this.label8.TabIndex = 7;
            this.label8.Text = "Loại độc giả :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(708, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 48);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mk :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(708, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 48);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số điện thoại :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(37, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 48);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(37, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(37, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(37, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên độc giả :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã dộc giả :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(167, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1058, 141);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm Độc giả";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTimkiem);
            this.groupBox3.Location = new System.Drawing.Point(591, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 93);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập thông tin cần Tìm kiếm";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimkiem.Location = new System.Drawing.Point(17, 34);
            this.txtTimkiem.Multiline = true;
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(401, 41);
            this.txtTimkiem.TabIndex = 0;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoLoai);
            this.groupBox2.Controls.Add(this.rdoTenSach);
            this.groupBox2.Controls.Add(this.rdoMaSach);
            this.groupBox2.Location = new System.Drawing.Point(17, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 92);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm theo";
            // 
            // rdoLoai
            // 
            this.rdoLoai.AutoSize = true;
            this.rdoLoai.Location = new System.Drawing.Point(394, 44);
            this.rdoLoai.Name = "rdoLoai";
            this.rdoLoai.Size = new System.Drawing.Size(162, 31);
            this.rdoLoai.TabIndex = 2;
            this.rdoLoai.TabStop = true;
            this.rdoLoai.Text = "Loại độc giả";
            this.rdoLoai.UseVisualStyleBackColor = true;
            this.rdoLoai.CheckedChanged += new System.EventHandler(this.rdoLoai_CheckedChanged);
            // 
            // rdoTenSach
            // 
            this.rdoTenSach.AutoSize = true;
            this.rdoTenSach.Location = new System.Drawing.Point(205, 44);
            this.rdoTenSach.Name = "rdoTenSach";
            this.rdoTenSach.Size = new System.Drawing.Size(155, 31);
            this.rdoTenSach.TabIndex = 1;
            this.rdoTenSach.TabStop = true;
            this.rdoTenSach.Text = "Tên độc giả";
            this.rdoTenSach.UseVisualStyleBackColor = true;
            this.rdoTenSach.CheckedChanged += new System.EventHandler(this.rdoTenSach_CheckedChanged);
            // 
            // rdoMaSach
            // 
            this.rdoMaSach.AutoSize = true;
            this.rdoMaSach.Location = new System.Drawing.Point(16, 44);
            this.rdoMaSach.Name = "rdoMaSach";
            this.rdoMaSach.Size = new System.Drawing.Size(150, 31);
            this.rdoMaSach.TabIndex = 0;
            this.rdoMaSach.TabStop = true;
            this.rdoMaSach.Text = "Mã độc giả";
            this.rdoMaSach.UseVisualStyleBackColor = true;
            this.rdoMaSach.CheckedChanged += new System.EventHandler(this.rdoMaSach_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 350;
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkRate = 350;
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.BlinkRate = 350;
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.BlinkRate = 350;
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.BlinkRate = 350;
            this.errorProvider5.ContainerControl = this;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Hủy.jpg");
            this.imageList2.Images.SetKeyName(1, "Lưu.png");
            this.imageList2.Images.SetKeyName(2, "Sửa.jpg");
            this.imageList2.Images.SetKeyName(3, "Thêm.png");
            this.imageList2.Images.SetKeyName(4, "Xóa.png");
            this.imageList2.Images.SetKeyName(5, "in.jpg");
            this.imageList2.Images.SetKeyName(6, "gia hạn.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Logo.png");
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReport.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReport.ImageKey = "in.jpg";
            this.btnReport.ImageList = this.imageList2;
            this.btnReport.Location = new System.Drawing.Point(1149, 603);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(164, 73);
            this.btnReport.TabIndex = 32;
            this.btnReport.Text = "   Xuất";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGiaHan.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGiaHan.ImageKey = "gia hạn.png";
            this.btnGiaHan.ImageList = this.imageList2;
            this.btnGiaHan.Location = new System.Drawing.Point(597, 603);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(164, 73);
            this.btnGiaHan.TabIndex = 31;
            this.btnGiaHan.Text = "Gia Hạn";
            this.btnGiaHan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGiaHan.UseVisualStyleBackColor = false;
            this.btnGiaHan.Click += new System.EventHandler(this.btnGiaHan_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.ImageKey = "Logo.png";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(7, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 122);
            this.button1.TabIndex = 30;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel.ImageKey = "Hủy.jpg";
            this.btnCancel.ImageList = this.imageList2;
            this.btnCancel.Location = new System.Drawing.Point(965, 603);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 73);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "   Hủy";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.ImageKey = "Lưu.png";
            this.btnSave.ImageList = this.imageList2;
            this.btnSave.Location = new System.Drawing.Point(781, 603);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 73);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "   Lưu";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.ImageKey = "Xóa.png";
            this.btnDelete.ImageList = this.imageList2;
            this.btnDelete.Location = new System.Drawing.Point(413, 603);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 73);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "   Xóa";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEdit.ImageKey = "Sửa.jpg";
            this.btnEdit.ImageList = this.imageList2;
            this.btnEdit.Location = new System.Drawing.Point(229, 603);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(164, 73);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Text = "   Sửa";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.ImageKey = "Thêm.png";
            this.btnAdd.ImageList = this.imageList2;
            this.btnAdd.Location = new System.Drawing.Point(45, 603);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 73);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "  Thêm";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormQLDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1358, 1036);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnGiaHan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormQLDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Độc Giả";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsDocgia)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dsDocgia;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dNgaysinh;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.ComboBox cboLoaidocgia;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTendocgia;
        private System.Windows.Forms.TextBox txtMadocgia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoTenSach;
        private System.Windows.Forms.RadioButton rdoMaSach;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dNgayhethan;
        private System.Windows.Forms.DateTimePicker dNgaylapthe;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.RadioButton rdoLoai;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.Button btnReport;
    }
}