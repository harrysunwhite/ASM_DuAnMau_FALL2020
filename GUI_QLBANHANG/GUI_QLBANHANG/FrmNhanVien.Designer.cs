namespace GUI_QLBANHANG
{
    partial class FrmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbNhanvien = new System.Windows.Forms.RadioButton();
            this.rbQuantri = new System.Windows.Forms.RadioButton();
            this.rbNgung = new System.Windows.Forms.RadioButton();
            this.rbHoatDong = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTennv = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnDanhsach = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvNhanvien = new System.Windows.Forms.DataGridView();
            this.errorEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTenNV = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDiachi = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTenNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDiachi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.rbNgung);
            this.panel2.Controls.Add(this.rbHoatDong);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtDiachi);
            this.panel2.Controls.Add(this.txtTennv);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 166);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbNhanvien);
            this.panel4.Controls.Add(this.rbQuantri);
            this.panel4.Location = new System.Drawing.Point(157, 117);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel4.Size = new System.Drawing.Size(202, 44);
            this.panel4.TabIndex = 13;
            // 
            // rbNhanvien
            // 
            this.rbNhanvien.AutoSize = true;
            this.rbNhanvien.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNhanvien.Location = new System.Drawing.Point(6, 17);
            this.rbNhanvien.Name = "rbNhanvien";
            this.rbNhanvien.Size = new System.Drawing.Size(95, 24);
            this.rbNhanvien.TabIndex = 8;
            this.rbNhanvien.Text = "Nhân Viên\r\n";
            this.rbNhanvien.UseVisualStyleBackColor = true;
            // 
            // rbQuantri
            // 
            this.rbQuantri.AutoSize = true;
            this.rbQuantri.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbQuantri.Location = new System.Drawing.Point(122, 17);
            this.rbQuantri.Name = "rbQuantri";
            this.rbQuantri.Size = new System.Drawing.Size(77, 24);
            this.rbQuantri.TabIndex = 9;
            this.rbQuantri.Text = "Quản lý";
            this.rbQuantri.UseVisualStyleBackColor = true;
            // 
            // rbNgung
            // 
            this.rbNgung.AutoSize = true;
            this.rbNgung.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNgung.Location = new System.Drawing.Point(674, 126);
            this.rbNgung.Name = "rbNgung";
            this.rbNgung.Size = new System.Drawing.Size(151, 24);
            this.rbNgung.TabIndex = 12;
            this.rbNgung.Text = "Ngừng Hoạt Động";
            this.rbNgung.UseVisualStyleBackColor = true;
            // 
            // rbHoatDong
            // 
            this.rbHoatDong.AutoSize = true;
            this.rbHoatDong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHoatDong.Location = new System.Drawing.Point(546, 128);
            this.rbHoatDong.Name = "rbHoatDong";
            this.rbHoatDong.Size = new System.Drawing.Size(101, 24);
            this.rbHoatDong.TabIndex = 11;
            this.rbHoatDong.Text = "Hoạt Động";
            this.rbHoatDong.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(433, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tình Trạng:";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.Location = new System.Drawing.Point(520, 54);
            this.txtDiachi.Multiline = true;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(373, 61);
            this.txtDiachi.TabIndex = 6;
            this.txtDiachi.Validating += new System.ComponentModel.CancelEventHandler(this.txtDiachi_Validating);
            // 
            // txtTennv
            // 
            this.txtTennv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTennv.Location = new System.Drawing.Point(157, 87);
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.Size = new System.Drawing.Size(261, 27);
            this.txtTennv.TabIndex = 4;
            this.txtTennv.Validating += new System.ComponentModel.CancelEventHandler(this.txtTennv_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(157, 54);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(261, 27);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(433, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Địa Chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(46, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Quyền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(43, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Nhân Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(43, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHÂN VIÊN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnBoqua);
            this.panel1.Controls.Add(this.btnDanhsach);
            this.panel1.Controls.Add(this.btnTimkiem);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 411);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 130);
            this.panel1.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.LightGray;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(225, 34);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(193, 27);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.Text = "Nhập tên nhân viên";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(815, 81);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(87, 38);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(163, 80);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 38);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(302, 80);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 38);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(437, 80);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(87, 38);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Image = ((System.Drawing.Image)(resources.GetObject("btnBoqua.Image")));
            this.btnBoqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoqua.Location = new System.Drawing.Point(569, 81);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(87, 38);
            this.btnBoqua.TabIndex = 4;
            this.btnBoqua.Text = "&Bỏ Qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnDanhsach
            // 
            this.btnDanhsach.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhsach.Image")));
            this.btnDanhsach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhsach.Location = new System.Drawing.Point(693, 81);
            this.btnDanhsach.Name = "btnDanhsach";
            this.btnDanhsach.Size = new System.Drawing.Size(87, 38);
            this.btnDanhsach.TabIndex = 6;
            this.btnDanhsach.Text = "   &Danh Sách";
            this.btnDanhsach.UseVisualStyleBackColor = true;
            this.btnDanhsach.Click += new System.EventHandler(this.btnDanhsach_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.Image")));
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(437, 29);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(87, 38);
            this.btnTimkiem.TabIndex = 5;
            this.btnTimkiem.Text = "&Tim Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(30, 81);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 38);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvNhanvien
            // 
            this.dgvNhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanvien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNhanvien.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvNhanvien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNhanvien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanvien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanvien.Location = new System.Drawing.Point(0, 166);
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanvien.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNhanvien.Size = new System.Drawing.Size(934, 245);
            this.dgvNhanvien.TabIndex = 6;
            this.dgvNhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanvien_CellClick);
            // 
            // errorEmail
            // 
            this.errorEmail.ContainerControl = this;
            // 
            // errorTenNV
            // 
            this.errorTenNV.ContainerControl = this;
            // 
            // errorDiachi
            // 
            this.errorDiachi.ContainerControl = this;
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 541);
            this.ControlBox = false;
            this.Controls.Add(this.dgvNhanvien);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmNhanVien";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ NHÂN VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTenNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDiachi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbNhanvien;
        private System.Windows.Forms.RadioButton rbQuantri;
        private System.Windows.Forms.RadioButton rbNgung;
        private System.Windows.Forms.RadioButton rbHoatDong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTennv;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnDanhsach;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvNhanvien;
        private System.Windows.Forms.ErrorProvider errorEmail;
        private System.Windows.Forms.ErrorProvider errorTenNV;
        private System.Windows.Forms.ErrorProvider errorDiachi;
    }
}