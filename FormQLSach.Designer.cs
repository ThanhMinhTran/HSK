
namespace QuanLyThuVien
{
    partial class FormQLSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLSach));
            this.btnCancel = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dssach = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rdoCu = new System.Windows.Forms.RadioButton();
            this.rdoMoi = new System.Windows.Forms.RadioButton();
            this.cboMatheloai = new System.Windows.Forms.ComboBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.txtSl = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.txtTensach = new System.Windows.Forms.TextBox();
            this.txtMasach = new System.Windows.Forms.TextBox();
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
            this.rdoTheLoai = new System.Windows.Forms.RadioButton();
            this.rdoTenSach = new System.Windows.Forms.RadioButton();
            this.rdoMaSach = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnReport = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dssach)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.errorProvider1.SetIconAlignment(this.btnCancel, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.btnCancel.ImageKey = "Hủy.jpg";
            this.btnCancel.ImageList = this.imageList1;
            this.btnCancel.Location = new System.Drawing.Point(844, 557);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 73);
            this.btnCancel.TabIndex = 19;
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
            this.imageList1.Images.SetKeyName(3, "Xóa.png");
            this.imageList1.Images.SetKeyName(4, "Thêm.png");
            this.imageList1.Images.SetKeyName(5, "Logo.png");
            this.imageList1.Images.SetKeyName(6, "in.jpg");
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.errorProvider1.SetIconAlignment(this.btnSave, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.btnSave.ImageIndex = 1;
            this.btnSave.ImageList = this.imageList1;
            this.btnSave.Location = new System.Drawing.Point(686, 557);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 73);
            this.btnSave.TabIndex = 18;
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
            this.errorProvider1.SetIconAlignment(this.btnDelete, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.btnDelete.ImageIndex = 3;
            this.btnDelete.ImageList = this.imageList1;
            this.btnDelete.Location = new System.Drawing.Point(528, 557);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 73);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = " Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.errorProvider1.SetIconAlignment(this.btnEdit, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.btnEdit.ImageIndex = 2;
            this.btnEdit.ImageList = this.imageList1;
            this.btnEdit.Location = new System.Drawing.Point(370, 557);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(145, 73);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = " Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.errorProvider1.SetIconAlignment(this.btnAdd, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.btnAdd.ImageIndex = 4;
            this.btnAdd.ImageList = this.imageList1;
            this.btnAdd.Location = new System.Drawing.Point(212, 557);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 73);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = " Thêm";
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
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(154, 122);
            this.btnHome.TabIndex = 13;
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
            this.groupBox5.Controls.Add(this.dssach);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox5.Location = new System.Drawing.Point(46, 645);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1276, 328);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách Sách";
            // 
            // dssach
            // 
            this.dssach.AllowUserToOrderColumns = true;
            this.dssach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dssach.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dssach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dssach.Location = new System.Drawing.Point(7, 31);
            this.dssach.Name = "dssach";
            this.dssach.RowHeadersWidth = 82;
            this.dssach.RowTemplate.Height = 33;
            this.dssach.Size = new System.Drawing.Size(1263, 291);
            this.dssach.TabIndex = 0;
            this.dssach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dssach_CellContentClick);
            this.dssach.SelectionChanged += new System.EventHandler(this.dssach_SelectionChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.rdoCu);
            this.groupBox4.Controls.Add(this.rdoMoi);
            this.groupBox4.Controls.Add(this.cboMatheloai);
            this.groupBox4.Controls.Add(this.textBox11);
            this.groupBox4.Controls.Add(this.txtDongia);
            this.groupBox4.Controls.Add(this.txtSl);
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.txtNXB);
            this.groupBox4.Controls.Add(this.txtTensach);
            this.groupBox4.Controls.Add(this.txtMasach);
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
            this.groupBox4.Location = new System.Drawing.Point(170, 222);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(970, 309);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin Sách";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(675, 193);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 35);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker1_Validating);
            // 
            // rdoCu
            // 
            this.rdoCu.AutoSize = true;
            this.rdoCu.Location = new System.Drawing.Point(271, 193);
            this.rdoCu.Name = "rdoCu";
            this.rdoCu.Size = new System.Drawing.Size(71, 31);
            this.rdoCu.TabIndex = 22;
            this.rdoCu.TabStop = true;
            this.rdoCu.Text = "Cũ";
            this.rdoCu.UseVisualStyleBackColor = true;
            // 
            // rdoMoi
            // 
            this.rdoMoi.Location = new System.Drawing.Point(166, 193);
            this.rdoMoi.Name = "rdoMoi";
            this.rdoMoi.Size = new System.Drawing.Size(83, 31);
            this.rdoMoi.TabIndex = 21;
            this.rdoMoi.TabStop = true;
            this.rdoMoi.Text = "Mới";
            this.rdoMoi.UseVisualStyleBackColor = true;
            // 
            // cboMatheloai
            // 
            this.cboMatheloai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMatheloai.FormattingEnabled = true;
            this.cboMatheloai.Location = new System.Drawing.Point(676, 147);
            this.cboMatheloai.Name = "cboMatheloai";
            this.cboMatheloai.Size = new System.Drawing.Size(249, 35);
            this.cboMatheloai.TabIndex = 20;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox11.Location = new System.Drawing.Point(675, 243);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(250, 35);
            this.textBox11.TabIndex = 19;
            // 
            // txtDongia
            // 
            this.txtDongia.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDongia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDongia.Location = new System.Drawing.Point(675, 93);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(250, 35);
            this.txtDongia.TabIndex = 16;
            this.txtDongia.Validating += new System.ComponentModel.CancelEventHandler(this.txtDongia_Validating);
            // 
            // txtSl
            // 
            this.txtSl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSl.Location = new System.Drawing.Point(675, 43);
            this.txtSl.Name = "txtSl";
            this.txtSl.Size = new System.Drawing.Size(250, 35);
            this.txtSl.TabIndex = 15;
            this.txtSl.Validating += new System.ComponentModel.CancelEventHandler(this.txtSl_Validating);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(166, 247);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(250, 35);
            this.textBox6.TabIndex = 14;
            // 
            // txtNXB
            // 
            this.txtNXB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNXB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNXB.Location = new System.Drawing.Point(166, 147);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(250, 35);
            this.txtNXB.TabIndex = 12;
            // 
            // txtTensach
            // 
            this.txtTensach.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTensach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTensach.Location = new System.Drawing.Point(166, 97);
            this.txtTensach.Name = "txtTensach";
            this.txtTensach.Size = new System.Drawing.Size(250, 35);
            this.txtTensach.TabIndex = 11;
            this.txtTensach.Validating += new System.ComponentModel.CancelEventHandler(this.txtTensach_Validating);
            // 
            // txtMasach
            // 
            this.txtMasach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMasach.Location = new System.Drawing.Point(166, 47);
            this.txtMasach.Multiline = true;
            this.txtMasach.Name = "txtMasach";
            this.txtMasach.Size = new System.Drawing.Size(250, 31);
            this.txtMasach.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(528, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 48);
            this.label10.TabIndex = 9;
            this.label10.Text = "label10";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(528, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 48);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ngày nhập :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(528, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 48);
            this.label8.TabIndex = 7;
            this.label8.Text = "Thể loại :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(528, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 48);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đơn giá :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(528, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 48);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượng :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(37, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 48);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(37, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tình trạng :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(37, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "NXB :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(37, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sách :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(172, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 141);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm Sách";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTimkiem);
            this.groupBox3.Location = new System.Drawing.Point(528, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 93);
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
            this.txtTimkiem.Size = new System.Drawing.Size(355, 41);
            this.txtTimkiem.TabIndex = 0;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoTheLoai);
            this.groupBox2.Controls.Add(this.rdoTenSach);
            this.groupBox2.Controls.Add(this.rdoMaSach);
            this.groupBox2.Location = new System.Drawing.Point(17, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 92);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm theo";
            // 
            // rdoTheLoai
            // 
            this.rdoTheLoai.AutoSize = true;
            this.rdoTheLoai.Location = new System.Drawing.Point(346, 44);
            this.rdoTheLoai.Name = "rdoTheLoai";
            this.rdoTheLoai.Size = new System.Drawing.Size(121, 31);
            this.rdoTheLoai.TabIndex = 2;
            this.rdoTheLoai.TabStop = true;
            this.rdoTheLoai.Text = "Thể loại";
            this.rdoTheLoai.UseVisualStyleBackColor = true;
            this.rdoTheLoai.CheckedChanged += new System.EventHandler(this.rdoTheLoai_CheckedChanged);
            // 
            // rdoTenSach
            // 
            this.rdoTenSach.AutoSize = true;
            this.rdoTenSach.Location = new System.Drawing.Point(181, 44);
            this.rdoTenSach.Name = "rdoTenSach";
            this.rdoTenSach.Size = new System.Drawing.Size(129, 31);
            this.rdoTenSach.TabIndex = 1;
            this.rdoTenSach.TabStop = true;
            this.rdoTenSach.Text = "Tên sách";
            this.rdoTenSach.UseVisualStyleBackColor = true;
            this.rdoTenSach.CheckedChanged += new System.EventHandler(this.rdoTenSach_CheckedChanged);
            // 
            // rdoMaSach
            // 
            this.rdoMaSach.AutoSize = true;
            this.rdoMaSach.Location = new System.Drawing.Point(16, 44);
            this.rdoMaSach.Name = "rdoMaSach";
            this.rdoMaSach.Size = new System.Drawing.Size(124, 31);
            this.rdoMaSach.TabIndex = 0;
            this.rdoMaSach.TabStop = true;
            this.rdoMaSach.Text = "Mã sách";
            this.rdoMaSach.UseVisualStyleBackColor = true;
            this.rdoMaSach.CheckedChanged += new System.EventHandler(this.rdoMaSach_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 350;
            this.errorProvider1.ContainerControl = this;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReport.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.errorProvider1.SetIconAlignment(this.btnReport, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.btnReport.ImageKey = "in.jpg";
            this.btnReport.ImageList = this.imageList1;
            this.btnReport.Location = new System.Drawing.Point(1002, 557);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(145, 73);
            this.btnReport.TabIndex = 20;
            this.btnReport.Text = " Xuất";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
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
            this.errorProvider5.ContainerControl = this;
            // 
            // FormQLSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1358, 991);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormQLSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sách";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dssach)).EndInit();
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dssach;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboMatheloai;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox txtSl;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.TextBox txtTensach;
        private System.Windows.Forms.TextBox txtMasach;
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
        private System.Windows.Forms.RadioButton rdoTheLoai;
        private System.Windows.Forms.RadioButton rdoTenSach;
        private System.Windows.Forms.RadioButton rdoMaSach;
        private System.Windows.Forms.RadioButton rdoCu;
        private System.Windows.Forms.RadioButton rdoMoi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.Button btnReport;
    }
}