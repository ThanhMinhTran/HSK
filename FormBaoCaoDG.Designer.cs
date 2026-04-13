
namespace QuanLyThuVien
{
    partial class FormBaoCaoDG
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
            this.rdoNam = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cboMadocgia = new System.Windows.Forms.ComboBox();
            this.txtTendocgia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdooNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoNam
            // 
            this.rdoNam.ActiveViewIndex = -1;
            this.rdoNam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rdoNam.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdoNam.Location = new System.Drawing.Point(0, 72);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(2295, 1258);
            this.rdoNam.TabIndex = 0;
            // 
            // cboMadocgia
            // 
            this.cboMadocgia.FormattingEnabled = true;
            this.cboMadocgia.Location = new System.Drawing.Point(504, 13);
            this.cboMadocgia.Name = "cboMadocgia";
            this.cboMadocgia.Size = new System.Drawing.Size(142, 33);
            this.cboMadocgia.TabIndex = 1;
            // 
            // txtTendocgia
            // 
            this.txtTendocgia.Location = new System.Drawing.Point(154, 12);
            this.txtTendocgia.Name = "txtTendocgia";
            this.txtTendocgia.Size = new System.Drawing.Size(174, 31);
            this.txtTendocgia.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên độc giả";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(907, 0);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(119, 54);
            this.btnIn.TabIndex = 4;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(358, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Loại độc giả";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoNu);
            this.groupBox1.Controls.Add(this.rdooNam);
            this.groupBox1.Location = new System.Drawing.Point(661, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 65);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // rdooNam
            // 
            this.rdooNam.AutoSize = true;
            this.rdooNam.Location = new System.Drawing.Point(17, 30);
            this.rdooNam.Name = "rdooNam";
            this.rdooNam.Size = new System.Drawing.Size(87, 29);
            this.rdooNam.TabIndex = 0;
            this.rdooNam.TabStop = true;
            this.rdooNam.Text = "Nam";
            this.rdooNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(121, 30);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(70, 29);
            this.rdoNu.TabIndex = 1;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // FormBaoCaoDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2307, 1326);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTendocgia);
            this.Controls.Add(this.cboMadocgia);
            this.Controls.Add(this.rdoNam);
            this.Name = "FormBaoCaoDG";
            this.Text = "FormBaoCaoDG";
            this.Load += new System.EventHandler(this.FormBaoCaoDG_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rdoNam;
        private System.Windows.Forms.ComboBox cboMadocgia;
        private System.Windows.Forms.TextBox txtTendocgia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdooNam;
    }
}