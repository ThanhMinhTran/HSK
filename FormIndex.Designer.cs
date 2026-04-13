
namespace QuanLyThuVien
{
    partial class FormIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIndex));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐộcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhiếuThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhiếuThuToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMượnTrảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchSửTrảSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoThốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoPhiếuTrảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoThểLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.thêmTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(801, 58);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSáchToolStripMenuItem,
            this.quảnLýĐộcGiảToolStripMenuItem,
            this.quảnLýMượnTrảToolStripMenuItem,
            this.báoCáoThốngKêToolStripMenuItem,
            this.toolStripDropDownButton1,
            this.thêmTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 58);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(801, 41);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýSáchToolStripMenuItem
            // 
            this.quảnLýSáchToolStripMenuItem.Name = "quảnLýSáchToolStripMenuItem";
            this.quảnLýSáchToolStripMenuItem.Size = new System.Drawing.Size(56, 39);
            this.quảnLýSáchToolStripMenuItem.Text = "Sách";
            this.quảnLýSáchToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSáchToolStripMenuItem_Click);
            // 
            // quảnLýĐộcGiảToolStripMenuItem
            // 
            this.quảnLýĐộcGiảToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýPhiếuThuToolStripMenuItem,
            this.quảnLýPhiếuThuToolStripMenuItem2});
            this.quảnLýĐộcGiảToolStripMenuItem.Name = "quảnLýĐộcGiảToolStripMenuItem";
            this.quảnLýĐộcGiảToolStripMenuItem.Size = new System.Drawing.Size(78, 39);
            this.quảnLýĐộcGiảToolStripMenuItem.Text = "Độc Giả";
            // 
            // quảnLýPhiếuThuToolStripMenuItem
            // 
            this.quảnLýPhiếuThuToolStripMenuItem.Name = "quảnLýPhiếuThuToolStripMenuItem";
            this.quảnLýPhiếuThuToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.quảnLýPhiếuThuToolStripMenuItem.Text = "Quản Lý Độc Giả";
            this.quảnLýPhiếuThuToolStripMenuItem.Click += new System.EventHandler(this.quảnLýPhiếuThuToolStripMenuItem_Click);
            // 
            // quảnLýPhiếuThuToolStripMenuItem2
            // 
            this.quảnLýPhiếuThuToolStripMenuItem2.Name = "quảnLýPhiếuThuToolStripMenuItem2";
            this.quảnLýPhiếuThuToolStripMenuItem2.Size = new System.Drawing.Size(222, 26);
            this.quảnLýPhiếuThuToolStripMenuItem2.Text = "Quản Lý Phiếu Thu";
            this.quảnLýPhiếuThuToolStripMenuItem2.Click += new System.EventHandler(this.quảnLýPhiếuThuToolStripMenuItem2_Click);
            // 
            // quảnLýMượnTrảToolStripMenuItem
            // 
            this.quảnLýMượnTrảToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýMượnToolStripMenuItem,
            this.lịchSửTrảSáchToolStripMenuItem});
            this.quảnLýMượnTrảToolStripMenuItem.Name = "quảnLýMượnTrảToolStripMenuItem";
            this.quảnLýMượnTrảToolStripMenuItem.Size = new System.Drawing.Size(102, 39);
            this.quảnLýMượnTrảToolStripMenuItem.Text = "Mượn - Trả";
            // 
            // quảnLýMượnToolStripMenuItem
            // 
            this.quảnLýMượnToolStripMenuItem.Name = "quảnLýMượnToolStripMenuItem";
            this.quảnLýMượnToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.quảnLýMượnToolStripMenuItem.Text = "Quản lý mượn - trả";
            this.quảnLýMượnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýMượnToolStripMenuItem_Click);
            // 
            // lịchSửTrảSáchToolStripMenuItem
            // 
            this.lịchSửTrảSáchToolStripMenuItem.Name = "lịchSửTrảSáchToolStripMenuItem";
            this.lịchSửTrảSáchToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.lịchSửTrảSáchToolStripMenuItem.Text = "Lịch sử trả sách";
            this.lịchSửTrảSáchToolStripMenuItem.Click += new System.EventHandler(this.lịchSửTrảSáchToolStripMenuItem_Click);
            // 
            // báoCáoThốngKêToolStripMenuItem
            // 
            this.báoCáoThốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoPhiếuTrảToolStripMenuItem,
            this.báoCáoThểLoạiToolStripMenuItem});
            this.báoCáoThốngKêToolStripMenuItem.Name = "báoCáoThốngKêToolStripMenuItem";
            this.báoCáoThốngKêToolStripMenuItem.Size = new System.Drawing.Size(148, 39);
            this.báoCáoThốngKêToolStripMenuItem.Text = "Báo Cáo Thống Kê";
            // 
            // báoCáoPhiếuTrảToolStripMenuItem
            // 
            this.báoCáoPhiếuTrảToolStripMenuItem.Name = "báoCáoPhiếuTrảToolStripMenuItem";
            this.báoCáoPhiếuTrảToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.báoCáoPhiếuTrảToolStripMenuItem.Text = "Báo cáo Sách";
            this.báoCáoPhiếuTrảToolStripMenuItem.Click += new System.EventHandler(this.báoCáoPhiếuTrảToolStripMenuItem_Click);
            // 
            // báoCáoThểLoạiToolStripMenuItem
            // 
            this.báoCáoThểLoạiToolStripMenuItem.Name = "báoCáoThểLoạiToolStripMenuItem";
            this.báoCáoThểLoạiToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.báoCáoThểLoạiToolStripMenuItem.Text = "Báo cáo Độc Giả";
            this.báoCáoThểLoạiToolStripMenuItem.Click += new System.EventHandler(this.báoCáoThểLoạiToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem1});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(46, 36);
            this.toolStripDropDownButton1.Text = "Hệ thống";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Thông tin";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click_1);
            // 
            // đăngXuấtToolStripMenuItem1
            // 
            this.đăngXuấtToolStripMenuItem1.Name = "đăngXuấtToolStripMenuItem1";
            this.đăngXuấtToolStripMenuItem1.Size = new System.Drawing.Size(188, 26);
            this.đăngXuấtToolStripMenuItem1.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem1.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Salmon;
            this.label1.Font = new System.Drawing.Font("Calibri", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(-3, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(841, 58);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quản Lý Thư Viện";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTen
            // 
            this.lblTen.BackColor = System.Drawing.Color.Salmon;
            this.lblTen.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTen.Location = new System.Drawing.Point(562, 26);
            this.lblTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(239, 33);
            this.lblTen.TabIndex = 27;
            this.lblTen.Text = "Tên độc giả";
            this.lblTen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // thêmTàiKhoảnToolStripMenuItem
            // 
            this.thêmTàiKhoảnToolStripMenuItem.Name = "thêmTàiKhoảnToolStripMenuItem";
            this.thêmTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(134, 39);
            this.thêmTàiKhoảnToolStripMenuItem.Text = "Thêm Tài Khoản";
            this.thêmTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thêmTàiKhoảnToolStripMenuItem_Click);
            // 
            // FormIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(801, 504);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.FormIndex_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐộcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMượnTrảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoThốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoPhiếuTrảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoThểLoạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhiếuThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem1;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhiếuThuToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lịchSửTrảSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmTàiKhoảnToolStripMenuItem;
    }
}

