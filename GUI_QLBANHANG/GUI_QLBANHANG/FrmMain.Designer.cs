namespace GUI_QLBANHANG
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hethongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangNhapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangxuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hosoNVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hanghoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanvienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongKeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongKeHangHoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huongDanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huongDanSDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbName = new System.Windows.Forms.Label();
            this.lbHK = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hethongToolStripMenuItem,
            this.danhMucToolStripMenuItem,
            this.thongKeToolStripMenuItem,
            this.huongDanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(967, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // hethongToolStripMenuItem
            // 
            this.hethongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangNhapToolStripMenuItem,
            this.dangxuatToolStripMenuItem,
            this.hosoNVToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.hethongToolStripMenuItem.Name = "hethongToolStripMenuItem";
            this.hethongToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.hethongToolStripMenuItem.Text = "Hệ Thống";
            // 
            // dangNhapToolStripMenuItem
            // 
            this.dangNhapToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dangNhapToolStripMenuItem.Image")));
            this.dangNhapToolStripMenuItem.Name = "dangNhapToolStripMenuItem";
            this.dangNhapToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.dangNhapToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.dangNhapToolStripMenuItem.Text = "Đăng Nhập";
            this.dangNhapToolStripMenuItem.Click += new System.EventHandler(this.dangNhapToolStripMenuItem_Click);
            // 
            // dangxuatToolStripMenuItem
            // 
            this.dangxuatToolStripMenuItem.Enabled = false;
            this.dangxuatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dangxuatToolStripMenuItem.Image")));
            this.dangxuatToolStripMenuItem.Name = "dangxuatToolStripMenuItem";
            this.dangxuatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.dangxuatToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.dangxuatToolStripMenuItem.Text = "Đăng Xuất ";
            this.dangxuatToolStripMenuItem.Click += new System.EventHandler(this.dangxuatToolStripMenuItem_Click);
            // 
            // hosoNVToolStripMenuItem
            // 
            this.hosoNVToolStripMenuItem.Enabled = false;
            this.hosoNVToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hosoNVToolStripMenuItem.Image")));
            this.hosoNVToolStripMenuItem.Name = "hosoNVToolStripMenuItem";
            this.hosoNVToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.hosoNVToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.hosoNVToolStripMenuItem.Text = "Hồ sơ nhân viên";
            this.hosoNVToolStripMenuItem.Click += new System.EventHandler(this.hosoNVToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoatToolStripMenuItem.Image")));
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // danhMucToolStripMenuItem
            // 
            this.danhMucToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hanghoaToolStripMenuItem,
            this.nhanvienToolStripMenuItem,
            this.khachHangToolStripMenuItem});
            this.danhMucToolStripMenuItem.Name = "danhMucToolStripMenuItem";
            this.danhMucToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.danhMucToolStripMenuItem.Text = "Danh Mục";
            this.danhMucToolStripMenuItem.Visible = false;
            // 
            // hanghoaToolStripMenuItem
            // 
            this.hanghoaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hanghoaToolStripMenuItem.Image")));
            this.hanghoaToolStripMenuItem.Name = "hanghoaToolStripMenuItem";
            this.hanghoaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.hanghoaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.hanghoaToolStripMenuItem.Text = "Hàng hóa";
            this.hanghoaToolStripMenuItem.Click += new System.EventHandler(this.hanghoaToolStripMenuItem_Click);
            // 
            // nhanvienToolStripMenuItem
            // 
            this.nhanvienToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nhanvienToolStripMenuItem.Image")));
            this.nhanvienToolStripMenuItem.Name = "nhanvienToolStripMenuItem";
            this.nhanvienToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.nhanvienToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.nhanvienToolStripMenuItem.Text = "Nhân viên";
            this.nhanvienToolStripMenuItem.Click += new System.EventHandler(this.nhanvienToolStripMenuItem_Click);
            // 
            // khachHangToolStripMenuItem
            // 
            this.khachHangToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("khachHangToolStripMenuItem.Image")));
            this.khachHangToolStripMenuItem.Name = "khachHangToolStripMenuItem";
            this.khachHangToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
            this.khachHangToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.khachHangToolStripMenuItem.Text = "Khách hàng";
            this.khachHangToolStripMenuItem.Click += new System.EventHandler(this.khachHangToolStripMenuItem_Click);
            // 
            // thongKeToolStripMenuItem
            // 
            this.thongKeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thongKeHangHoaToolStripMenuItem});
            this.thongKeToolStripMenuItem.Name = "thongKeToolStripMenuItem";
            this.thongKeToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.thongKeToolStripMenuItem.Text = "Thống kê";
            this.thongKeToolStripMenuItem.Visible = false;
            this.thongKeToolStripMenuItem.Click += new System.EventHandler(this.thongKeToolStripMenuItem_Click);
            // 
            // thongKeHangHoaToolStripMenuItem
            // 
            this.thongKeHangHoaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thongKeHangHoaToolStripMenuItem.Image")));
            this.thongKeHangHoaToolStripMenuItem.Name = "thongKeHangHoaToolStripMenuItem";
            this.thongKeHangHoaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.thongKeHangHoaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.thongKeHangHoaToolStripMenuItem.Text = "Thống kê hàng hóa";
            this.thongKeHangHoaToolStripMenuItem.Visible = false;
            this.thongKeHangHoaToolStripMenuItem.Click += new System.EventHandler(this.thongKeHangHoaToolStripMenuItem_Click);
            // 
            // huongDanToolStripMenuItem
            // 
            this.huongDanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.huongDanSDToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.huongDanToolStripMenuItem.Name = "huongDanToolStripMenuItem";
            this.huongDanToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.huongDanToolStripMenuItem.Text = "Hướng dẫn";
            // 
            // huongDanSDToolStripMenuItem
            // 
            this.huongDanSDToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("huongDanSDToolStripMenuItem.Image")));
            this.huongDanSDToolStripMenuItem.Name = "huongDanSDToolStripMenuItem";
            this.huongDanSDToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.huongDanSDToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.huongDanSDToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.aboutToolStripMenuItem.Text = "Giới thiệu phần mềm";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.CausesValidation = false;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Brown;
            this.lbName.Location = new System.Drawing.Point(150, 82);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(643, 50);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "QUẢN LÝ BÁN HÀNG - DỰ ÁN MẪU";
            // 
            // lbHK
            // 
            this.lbHK.AutoSize = true;
            this.lbHK.CausesValidation = false;
            this.lbHK.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHK.ForeColor = System.Drawing.Color.Brown;
            this.lbHK.Location = new System.Drawing.Point(269, 170);
            this.lbHK.Name = "lbHK";
            this.lbHK.Size = new System.Drawing.Size(342, 50);
            this.lbHK.TabIndex = 2;
            this.lbHK.Text = "HỌC KỲ FALL 2020";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(737, 7);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(0, 17);
            this.labelUser.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(967, 621);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.lbHK);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ BÁN HÀNG";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hethongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangNhapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangxuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hosoNVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hanghoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhanvienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongKeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongKeHangHoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huongDanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huongDanSDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbHK;
        private System.Windows.Forms.Label labelUser;
    }
}