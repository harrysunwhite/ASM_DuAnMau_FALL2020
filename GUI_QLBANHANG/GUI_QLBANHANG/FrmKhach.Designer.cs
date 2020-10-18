namespace GUI_QLBANHANG
{
    partial class FrmKhach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhach));
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbnu = new System.Windows.Forms.RadioButton();
            this.rbnam = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTenkhach = new System.Windows.Forms.TextBox();
            this.txtDienthoai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttimKiem = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvkhach = new System.Windows.Forms.DataGridView();
            this.errorDT = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorHoTen = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDiaChi = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnDanhsach = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHoTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDiaChi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbnu);
            this.panel2.Controls.Add(this.rbnam);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtDiachi);
            this.panel2.Controls.Add(this.txtTenkhach);
            this.panel2.Controls.Add(this.txtDienthoai);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 144);
            this.panel2.TabIndex = 4;
            // 
            // rbnu
            // 
            this.rbnu.AutoSize = true;
            this.rbnu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnu.Location = new System.Drawing.Point(631, 89);
            this.rbnu.Name = "rbnu";
            this.rbnu.Size = new System.Drawing.Size(47, 24);
            this.rbnu.TabIndex = 15;
            this.rbnu.TabStop = true;
            this.rbnu.Text = "Nữ";
            this.rbnu.UseVisualStyleBackColor = true;
            // 
            // rbnam
            // 
            this.rbnam.AutoSize = true;
            this.rbnam.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnam.Location = new System.Drawing.Point(531, 85);
            this.rbnam.Name = "rbnam";
            this.rbnam.Size = new System.Drawing.Size(59, 24);
            this.rbnam.TabIndex = 14;
            this.rbnam.TabStop = true;
            this.rbnam.Text = "Nam";
            this.rbnam.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(406, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Giới Tính:";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.Location = new System.Drawing.Point(531, 52);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(351, 27);
            this.txtDiachi.TabIndex = 6;
            this.txtDiachi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiachi.TextChanged += new System.EventHandler(this.txtDiachi_TextChanged);
            this.txtDiachi.Validating += new System.ComponentModel.CancelEventHandler(this.txtDiachi_Validating);
            // 
            // txtTenkhach
            // 
            this.txtTenkhach.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenkhach.Location = new System.Drawing.Point(130, 86);
            this.txtTenkhach.Name = "txtTenkhach";
            this.txtTenkhach.Size = new System.Drawing.Size(253, 27);
            this.txtTenkhach.TabIndex = 4;
            this.txtTenkhach.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenkhach_Validating);
            // 
            // txtDienthoai
            // 
            this.txtDienthoai.Enabled = false;
            this.txtDienthoai.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienthoai.Location = new System.Drawing.Point(130, 52);
            this.txtDienthoai.Name = "txtDienthoai";
            this.txtDienthoai.Size = new System.Drawing.Size(253, 27);
            this.txtDienthoai.TabIndex = 2;
            this.txtDienthoai.Validating += new System.ComponentModel.CancelEventHandler(this.txtDienthoai_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(406, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(38, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ và Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(38, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điện Thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHÁCH HÀNG";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnBoqua);
            this.panel1.Controls.Add(this.btnDanhsach);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txttimKiem);
            this.panel1.Controls.Add(this.btnTimkiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 430);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 111);
            this.panel1.TabIndex = 5;
            // 
            // txttimKiem
            // 
            this.txttimKiem.BackColor = System.Drawing.Color.LightGray;
            this.txttimKiem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimKiem.Location = new System.Drawing.Point(270, 22);
            this.txttimKiem.Name = "txttimKiem";
            this.txttimKiem.Size = new System.Drawing.Size(193, 27);
            this.txttimKiem.TabIndex = 17;
            this.txttimKiem.Text = "Nhập số điện thoại khách hàng";
            this.txttimKiem.Enter += new System.EventHandler(this.txttimKiem_Enter);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(498, 17);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(87, 38);
            this.btnTimkiem.TabIndex = 14;
            this.btnTimkiem.Text = "&Tim Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvkhach);
            this.panel3.Location = new System.Drawing.Point(0, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(951, 251);
            this.panel3.TabIndex = 6;
            // 
            // dgvkhach
            // 
            this.dgvkhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvkhach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvkhach.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvkhach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvkhach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvkhach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvkhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvkhach.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvkhach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvkhach.Location = new System.Drawing.Point(0, 0);
            this.dgvkhach.Name = "dgvkhach";
            this.dgvkhach.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvkhach.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvkhach.Size = new System.Drawing.Size(951, 251);
            this.dgvkhach.TabIndex = 2;
            this.dgvkhach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkhach_CellClick);
            this.dgvkhach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkhach_CellContentClick);
            // 
            // errorDT
            // 
            this.errorDT.ContainerControl = this;
            // 
            // errorHoTen
            // 
            this.errorHoTen.ContainerControl = this;
            // 
            // errorDiaChi
            // 
            this.errorDiaChi.ContainerControl = this;
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(820, 61);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(87, 38);
            this.btnDong.TabIndex = 24;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(176, 61);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 38);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(308, 61);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 38);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(441, 61);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(87, 38);
            this.btnLuu.TabIndex = 21;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Image = ((System.Drawing.Image)(resources.GetObject("btnBoqua.Image")));
            this.btnBoqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoqua.Location = new System.Drawing.Point(571, 61);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(87, 38);
            this.btnBoqua.TabIndex = 22;
            this.btnBoqua.Text = "&Bỏ Qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnDanhsach
            // 
            this.btnDanhsach.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhsach.Image")));
            this.btnDanhsach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhsach.Location = new System.Drawing.Point(697, 61);
            this.btnDanhsach.Name = "btnDanhsach";
            this.btnDanhsach.Size = new System.Drawing.Size(87, 38);
            this.btnDanhsach.TabIndex = 23;
            this.btnDanhsach.Text = "   &Danh Sách";
            this.btnDanhsach.UseVisualStyleBackColor = true;
            this.btnDanhsach.Click += new System.EventHandler(this.btnDanhsach_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(42, 61);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 38);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FrmKhach
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(934, 541);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmKhach";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmKhach_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHoTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDiaChi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbnu;
        private System.Windows.Forms.RadioButton rbnam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTenkhach;
        private System.Windows.Forms.TextBox txtDienthoai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvkhach;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnDanhsach;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txttimKiem;
        private System.Windows.Forms.ErrorProvider errorDT;
        private System.Windows.Forms.ErrorProvider errorHoTen;
        private System.Windows.Forms.ErrorProvider errorDiaChi;
    }
}