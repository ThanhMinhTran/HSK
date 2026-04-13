
namespace QuanLyThuVien
{
    partial class FormReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReceipt));
            this.btnCancel = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuThu = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboDocGia = new System.Windows.Forms.ComboBox();
            this.dtpNgayThu = new System.Windows.Forms.DateTimePicker();
            this.txtConLai = new System.Windows.Forms.TextBox();
            this.txtSoTienThu = new System.Windows.Forms.TextBox();
            this.txtTongNo = new System.Windows.Forms.TextBox();
            this.txtMaPhieuThu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoNgayThu = new System.Windows.Forms.RadioButton();
            this.rdoTenDocGia = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuThu)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel.ImageKey = "Hủy.jpg";
            this.btnCancel.ImageList = this.imageList1;
            this.btnCancel.Location = new System.Drawing.Point(419, 305);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 47);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = " Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Hủy.jpg");
            this.imageList1.Images.SetKeyName(1, "Lưu.png");
            this.imageList1.Images.SetKeyName(2, "Sửa.jpg");
            this.imageList1.Images.SetKeyName(3, "Thêm.png");
            this.imageList1.Images.SetKeyName(4, "Xóa.png");
            this.imageList1.Images.SetKeyName(5, "in.jpg");
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.ImageIndex = 1;
            this.btnSave.ImageList = this.imageList1;
            this.btnSave.Location = new System.Drawing.Point(311, 305);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 47);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = " Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.ImageIndex = 4;
            this.btnDelete.ImageList = this.imageList1;
            this.btnDelete.Location = new System.Drawing.Point(202, 305);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 47);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = " Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrint.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPrint.ImageIndex = 5;
            this.btnPrint.ImageList = this.imageList1;
            this.btnPrint.Location = new System.Drawing.Point(528, 305);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(115, 47);
            this.btnPrint.TabIndex = 25;
            this.btnPrint.Text = "  Xuất";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.ImageIndex = 3;
            this.btnAdd.ImageList = this.imageList1;
            this.btnAdd.Location = new System.Drawing.Point(93, 305);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 47);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = " Lập";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHome.ImageKey = "Logo.png";
            this.btnHome.ImageList = this.imageList2;
            this.btnHome.Location = new System.Drawing.Point(16, 10);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(103, 78);
            this.btnHome.TabIndex = 23;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Logo.png");
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvPhieuThu);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox5.Location = new System.Drawing.Point(19, 362);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(703, 210);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách phiếu";
            // 
            // dgvPhieuThu
            // 
            this.dgvPhieuThu.AllowUserToOrderColumns = true;
            this.dgvPhieuThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPhieuThu.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPhieuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuThu.Location = new System.Drawing.Point(7, 20);
            this.dgvPhieuThu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPhieuThu.Name = "dgvPhieuThu";
            this.dgvPhieuThu.RowHeadersWidth = 82;
            this.dgvPhieuThu.RowTemplate.Height = 33;
            this.dgvPhieuThu.Size = new System.Drawing.Size(693, 186);
            this.dgvPhieuThu.TabIndex = 0;
            this.dgvPhieuThu.SelectionChanged += new System.EventHandler(this.dgvPhieuThu_SelectionChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cboDocGia);
            this.groupBox4.Controls.Add(this.dtpNgayThu);
            this.groupBox4.Controls.Add(this.txtConLai);
            this.groupBox4.Controls.Add(this.txtSoTienThu);
            this.groupBox4.Controls.Add(this.txtTongNo);
            this.groupBox4.Controls.Add(this.txtMaPhieuThu);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox4.Location = new System.Drawing.Point(27, 144);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(647, 137);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin phiếu ";
            // 
            // cboDocGia
            // 
            this.cboDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocGia.FormattingEnabled = true;
            this.cboDocGia.Location = new System.Drawing.Point(111, 60);
            this.cboDocGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboDocGia.Name = "cboDocGia";
            this.cboDocGia.Size = new System.Drawing.Size(190, 25);
            this.cboDocGia.TabIndex = 24;
            this.cboDocGia.SelectedIndexChanged += new System.EventHandler(this.cboDocGia_SelectedIndexChanged);
            // 
            // dtpNgayThu
            // 
            this.dtpNgayThu.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayThu.Location = new System.Drawing.Point(448, 95);
            this.dtpNgayThu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgayThu.Name = "dtpNgayThu";
            this.dtpNgayThu.Size = new System.Drawing.Size(168, 25);
            this.dtpNgayThu.TabIndex = 23;
            // 
            // txtConLai
            // 
            this.txtConLai.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtConLai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConLai.Location = new System.Drawing.Point(450, 60);
            this.txtConLai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConLai.Name = "txtConLai";
            this.txtConLai.Size = new System.Drawing.Size(167, 25);
            this.txtConLai.TabIndex = 16;
            // 
            // txtSoTienThu
            // 
            this.txtSoTienThu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSoTienThu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoTienThu.Location = new System.Drawing.Point(450, 28);
            this.txtSoTienThu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoTienThu.Name = "txtSoTienThu";
            this.txtSoTienThu.Size = new System.Drawing.Size(167, 25);
            this.txtSoTienThu.TabIndex = 15;
            this.txtSoTienThu.TextChanged += new System.EventHandler(this.txtSoTienThu_TextChanged);
            this.txtSoTienThu.Validating += new System.ComponentModel.CancelEventHandler(this.txtSoTienThu_Validating);
            // 
            // txtTongNo
            // 
            this.txtTongNo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTongNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongNo.Location = new System.Drawing.Point(111, 94);
            this.txtTongNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTongNo.Name = "txtTongNo";
            this.txtTongNo.Size = new System.Drawing.Size(189, 25);
            this.txtTongNo.TabIndex = 12;
            // 
            // txtMaPhieuThu
            // 
            this.txtMaPhieuThu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPhieuThu.Location = new System.Drawing.Point(111, 30);
            this.txtMaPhieuThu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaPhieuThu.Multiline = true;
            this.txtMaPhieuThu.Name = "txtMaPhieuThu";
            this.txtMaPhieuThu.Size = new System.Drawing.Size(189, 23);
            this.txtMaPhieuThu.TabIndex = 10;
            this.txtMaPhieuThu.TextChanged += new System.EventHandler(this.txtMaPhieuThu_TextChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(350, 88);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 31);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ngày thu :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(352, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 31);
            this.label7.TabIndex = 6;
            this.label7.Text = "Còn lại :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(352, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số tiền thu :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng nợ :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên độc giả :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(123, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(499, 90);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm phiếu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTimkiem);
            this.groupBox3.Location = new System.Drawing.Point(229, 19);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(263, 60);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập thông tin cần Tìm kiếm";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimkiem.Location = new System.Drawing.Point(11, 22);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimkiem.Multiline = true;
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(237, 27);
            this.txtTimkiem.TabIndex = 0;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoNgayThu);
            this.groupBox2.Controls.Add(this.rdoTenDocGia);
            this.groupBox2.Location = new System.Drawing.Point(11, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(214, 59);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm theo";
            // 
            // rdoNgayThu
            // 
            this.rdoNgayThu.AutoSize = true;
            this.rdoNgayThu.Location = new System.Drawing.Point(121, 28);
            this.rdoNgayThu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoNgayThu.Name = "rdoNgayThu";
            this.rdoNgayThu.Size = new System.Drawing.Size(83, 21);
            this.rdoNgayThu.TabIndex = 1;
            this.rdoNgayThu.TabStop = true;
            this.rdoNgayThu.Text = "Ngày thu";
            this.rdoNgayThu.UseVisualStyleBackColor = true;
            this.rdoNgayThu.CheckedChanged += new System.EventHandler(this.rdoNgayThu_CheckedChanged);
            // 
            // rdoTenDocGia
            // 
            this.rdoTenDocGia.AutoSize = true;
            this.rdoTenDocGia.Location = new System.Drawing.Point(11, 28);
            this.rdoTenDocGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoTenDocGia.Name = "rdoTenDocGia";
            this.rdoTenDocGia.Size = new System.Drawing.Size(99, 21);
            this.rdoTenDocGia.TabIndex = 0;
            this.rdoTenDocGia.TabStop = true;
            this.rdoTenDocGia.Text = "Tên độc giả";
            this.rdoTenDocGia.UseVisualStyleBackColor = true;
            this.rdoTenDocGia.CheckedChanged += new System.EventHandler(this.rdoTenDocGia_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 350;
            this.errorProvider1.ContainerControl = this;
            // 
            // FormReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(741, 584);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phiếu thu";
            this.Load += new System.EventHandler(this.FormReceipt_Load);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuThu)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvPhieuThu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpNgayThu;
        private System.Windows.Forms.TextBox txtConLai;
        private System.Windows.Forms.TextBox txtSoTienThu;
        private System.Windows.Forms.TextBox txtTongNo;
        private System.Windows.Forms.TextBox txtMaPhieuThu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoNgayThu;
        private System.Windows.Forms.RadioButton rdoTenDocGia;
        private System.Windows.Forms.ComboBox cboDocGia;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}