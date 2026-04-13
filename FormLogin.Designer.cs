
namespace QuanLyThuVien
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHienMatKhau = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.txtMk = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Logo thư viện.png");
            this.imageList1.Images.SetKeyName(1, "pngtree-cloud-library-logo-image_301705.jpg");
            this.imageList1.Images.SetKeyName(2, "11431.png");
            this.imageList1.Images.SetKeyName(3, "istockphoto-1261789745-1024x1024.jpg");
            this.imageList1.Images.SetKeyName(4, "pngtree-books-logo-png-image_4136008.jpg");
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(0, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(808, 105);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Nhập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.ImageKey = "Logo thư viện.png";
            this.label2.ImageList = this.imageList1;
            this.label2.Location = new System.Drawing.Point(309, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 145);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(219, 262);
            this.txtTaiKhoan.Multiline = true;
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(370, 34);
            this.txtTaiKhoan.TabIndex = 3;
            this.txtTaiKhoan.TabStop = false;
            this.txtTaiKhoan.Enter += new System.EventHandler(this.txtTaiKhoan_Enter);
            this.txtTaiKhoan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTaiKhoan_KeyDown);
            this.txtTaiKhoan.Leave += new System.EventHandler(this.txtTaiKhoan_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(219, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(370, 71);
            this.button1.TabIndex = 5;
            this.button1.Text = "Đăng nhập";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHienMatKhau
            // 
            this.btnHienMatKhau.BackColor = System.Drawing.SystemColors.Window;
            this.btnHienMatKhau.ImageList = this.imageList2;
            this.btnHienMatKhau.Location = new System.Drawing.Point(542, 313);
            this.btnHienMatKhau.Name = "btnHienMatKhau";
            this.btnHienMatKhau.Size = new System.Drawing.Size(47, 35);
            this.btnHienMatKhau.TabIndex = 6;
            this.btnHienMatKhau.UseVisualStyleBackColor = false;
            this.btnHienMatKhau.Click += new System.EventHandler(this.btnHienMatKhau_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "pw");
            this.imageList2.Images.SetKeyName(1, "hidepw");
            // 
            // txtMk
            // 
            this.txtMk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMk.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMk.Location = new System.Drawing.Point(219, 313);
            this.txtMk.Multiline = true;
            this.txtMk.Name = "txtMk";
            this.txtMk.Size = new System.Drawing.Size(370, 34);
            this.txtMk.TabIndex = 7;
            this.txtMk.TabStop = false;
            this.txtMk.Enter += new System.EventHandler(this.txtMk_Enter);
            this.txtMk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMk_KeyDown);
            this.txtMk.Leave += new System.EventHandler(this.txtMk_Leave_1);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(809, 464);
            this.Controls.Add(this.btnHienMatKhau);
            this.Controls.Add(this.txtMk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHienMatKhau;
        private System.Windows.Forms.TextBox txtMk;
        private System.Windows.Forms.ImageList imageList2;
    }
}