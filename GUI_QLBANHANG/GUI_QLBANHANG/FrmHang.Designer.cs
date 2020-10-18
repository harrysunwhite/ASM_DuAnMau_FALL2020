namespace GUI_QLBANHANG
{
    partial class FrmHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnOpenDialog = new System.Windows.Forms.Button();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDongiaban = new System.Windows.Forms.TextBox();
            this.txtDongianhap = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtTenhang = new System.Windows.Forms.TextBox();
            this.txtMahang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttimKiem = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnDanhsach = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvhang = new System.Windows.Forms.DataGridView();
            this.errorTenHang = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSoLuong = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorGiaNhap = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorGiaBan = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTenHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGiaNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGiaBan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbImage);
            this.panel2.Controls.Add(this.btnOpenDialog);
            this.panel2.Controls.Add(this.txtGhichu);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtDongiaban);
            this.panel2.Controls.Add(this.txtDongianhap);
            this.panel2.Controls.Add(this.txtSoluong);
            this.panel2.Controls.Add(this.txtTenhang);
            this.panel2.Controls.Add(this.txtMahang);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 201);
            this.panel2.TabIndex = 1;
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImage = global::GUI_QLBANHANG.Properties.Resources.full_products_round_icon_1320165923168064523;
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage.Location = new System.Drawing.Point(685, 44);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(130, 146);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 15;
            this.pbImage.TabStop = false;
            // 
            // btnOpenDialog
            // 
            this.btnOpenDialog.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenDialog.Image")));
            this.btnOpenDialog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenDialog.Location = new System.Drawing.Point(824, 44);
            this.btnOpenDialog.Name = "btnOpenDialog";
            this.btnOpenDialog.Size = new System.Drawing.Size(73, 23);
            this.btnOpenDialog.TabIndex = 15;
            this.btnOpenDialog.Text = "Browser";
            this.btnOpenDialog.UseVisualStyleBackColor = true;
            this.btnOpenDialog.Click += new System.EventHandler(this.btnOpenDialog_Click);
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(395, 52);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(284, 138);
            this.txtGhichu.TabIndex = 14;
            this.txtGhichu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(337, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ghi Chú:";
            // 
            // txtDongiaban
            // 
            this.txtDongiaban.Location = new System.Drawing.Point(111, 164);
            this.txtDongiaban.Name = "txtDongiaban";
            this.txtDongiaban.Size = new System.Drawing.Size(191, 20);
            this.txtDongiaban.TabIndex = 10;
            this.txtDongiaban.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDongiaban.Validating += new System.ComponentModel.CancelEventHandler(this.txtDongiaban_Validating);
            // 
            // txtDongianhap
            // 
            this.txtDongianhap.Location = new System.Drawing.Point(111, 134);
            this.txtDongianhap.Name = "txtDongianhap";
            this.txtDongianhap.Size = new System.Drawing.Size(191, 20);
            this.txtDongianhap.TabIndex = 8;
            this.txtDongianhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDongianhap.Validating += new System.ComponentModel.CancelEventHandler(this.txtDongianhap_Validating);
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(111, 104);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(191, 20);
            this.txtSoluong.TabIndex = 6;
            this.txtSoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoluong.Validating += new System.ComponentModel.CancelEventHandler(this.txtSoluong_Validating);
            // 
            // txtTenhang
            // 
            this.txtTenhang.Location = new System.Drawing.Point(111, 74);
            this.txtTenhang.Name = "txtTenhang";
            this.txtTenhang.Size = new System.Drawing.Size(191, 20);
            this.txtTenhang.TabIndex = 4;
            this.txtTenhang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTenhang.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenhang_Validating);
            // 
            // txtMahang
            // 
            this.txtMahang.Enabled = false;
            this.txtMahang.Location = new System.Drawing.Point(111, 44);
            this.txtMahang.Name = "txtMahang";
            this.txtMahang.ReadOnly = true;
            this.txtMahang.Size = new System.Drawing.Size(191, 20);
            this.txtMahang.TabIndex = 2;
            this.txtMahang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(19, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số Lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(19, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Đơn Giá Nhập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(19, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Đơn Giá Bán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(19, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(19, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(353, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHO HÀNG";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txttimKiem);
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnBoqua);
            this.panel1.Controls.Add(this.btnDanhsach);
            this.panel1.Controls.Add(this.btnTimkiem);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 429);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 112);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txttimKiem
            // 
            this.txttimKiem.BackColor = System.Drawing.Color.LightGray;
            this.txttimKiem.Location = new System.Drawing.Point(231, 28);
            this.txttimKiem.Name = "txttimKiem";
            this.txttimKiem.Size = new System.Drawing.Size(193, 20);
            this.txttimKiem.TabIndex = 8;
            this.txttimKiem.Text = "Nhập tên hàng";
            this.txttimKiem.Enter += new System.EventHandler(this.txttimKiem_Enter);
            // 
            // btnDong
            // 
            this.btnDong.Image = global::GUI_QLBANHANG.Properties.Resources.Close_icon;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(824, 62);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(87, 38);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::GUI_QLBANHANG.Properties.Resources.Actions_edit_delete_icon;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(149, 62);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 38);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::GUI_QLBANHANG.Properties.Resources.edit;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(277, 62);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 38);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::GUI_QLBANHANG.Properties.Resources.Save_icon;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(416, 62);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(87, 38);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Image = global::GUI_QLBANHANG.Properties.Resources.Cancel;
            this.btnBoqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoqua.Location = new System.Drawing.Point(549, 62);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(87, 38);
            this.btnBoqua.TabIndex = 4;
            this.btnBoqua.Text = "&Bỏ Qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnDanhsach
            // 
            this.btnDanhsach.Image = global::GUI_QLBANHANG.Properties.Resources.Data_List_icon;
            this.btnDanhsach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhsach.Location = new System.Drawing.Point(685, 62);
            this.btnDanhsach.Name = "btnDanhsach";
            this.btnDanhsach.Size = new System.Drawing.Size(87, 38);
            this.btnDanhsach.TabIndex = 6;
            this.btnDanhsach.Text = "   Danh Sách";
            this.btnDanhsach.UseVisualStyleBackColor = true;
            this.btnDanhsach.Click += new System.EventHandler(this.btnDanhsach_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(443, 18);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(87, 38);
            this.btnTimkiem.TabIndex = 5;
            this.btnTimkiem.Text = "&Tim Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::GUI_QLBANHANG.Properties.Resources.add_icon;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(19, 62);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 38);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvhang
            // 
            this.dgvhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvhang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvhang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvhang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvhang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvhang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvhang.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvhang.Location = new System.Drawing.Point(0, 201);
            this.dgvhang.Name = "dgvhang";
            this.dgvhang.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvhang.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvhang.Size = new System.Drawing.Size(934, 228);
            this.dgvhang.TabIndex = 3;
            this.dgvhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhang_CellClick);
            // 
            // errorTenHang
            // 
            this.errorTenHang.ContainerControl = this;
            // 
            // errorSoLuong
            // 
            this.errorSoLuong.ContainerControl = this;
            // 
            // errorGiaNhap
            // 
            this.errorGiaNhap.ContainerControl = this;
            // 
            // errorGiaBan
            // 
            this.errorGiaBan.ContainerControl = this;
            // 
            // FrmHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(934, 541);
            this.ControlBox = false;
            this.Controls.Add(this.dgvhang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmHang";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ HÀNG HOÁ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHang_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTenHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGiaNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGiaBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnOpenDialog;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDongiaban;
        private System.Windows.Forms.TextBox txtDongianhap;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtTenhang;
        private System.Windows.Forms.TextBox txtMahang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txttimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvhang;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnDanhsach;
        private System.Windows.Forms.ErrorProvider errorTenHang;
        private System.Windows.Forms.ErrorProvider errorSoLuong;
        private System.Windows.Forms.ErrorProvider errorGiaNhap;
        private System.Windows.Forms.ErrorProvider errorGiaBan;
    }
}