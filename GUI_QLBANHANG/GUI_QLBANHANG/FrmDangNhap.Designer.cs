namespace GUI_QLBANHANG
{
    partial class FrmDangNhap
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
            this.button3 = new System.Windows.Forms.Button();
            this.btnQuenmk = new System.Windows.Forms.Button();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkbSave = new System.Windows.Forms.CheckBox();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(42, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 28);
            this.button3.TabIndex = 17;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnQuenmk
            // 
            this.btnQuenmk.BackColor = System.Drawing.Color.Lavender;
            this.btnQuenmk.FlatAppearance.BorderSize = 0;
            this.btnQuenmk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuenmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuenmk.ForeColor = System.Drawing.Color.DimGray;
            this.btnQuenmk.Location = new System.Drawing.Point(169, 183);
            this.btnQuenmk.Name = "btnQuenmk";
            this.btnQuenmk.Size = new System.Drawing.Size(123, 23);
            this.btnQuenmk.TabIndex = 13;
            this.btnQuenmk.Text = "Quên Mật Khẩu?";
            this.btnQuenmk.UseVisualStyleBackColor = false;
            this.btnQuenmk.Click += new System.EventHandler(this.btnQuenmk_Click);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(18, 159);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(274, 20);
            this.txtmatkhau.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(15, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(15, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Email Đăng Nhập";
            // 
            // chkbSave
            // 
            this.chkbSave.AutoSize = true;
            this.chkbSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbSave.ForeColor = System.Drawing.Color.DimGray;
            this.chkbSave.Location = new System.Drawing.Point(18, 185);
            this.chkbSave.Name = "chkbSave";
            this.chkbSave.Size = new System.Drawing.Size(148, 21);
            this.chkbSave.TabIndex = 12;
            this.chkbSave.Text = "Ghi Nhớ Tài Khoản";
            this.chkbSave.UseVisualStyleBackColor = true;
            // 
            // btndangnhap
            // 
            this.btndangnhap.BackColor = System.Drawing.Color.Blue;
            this.btndangnhap.FlatAppearance.BorderSize = 0;
            this.btndangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.ForeColor = System.Drawing.Color.White;
            this.btndangnhap.Location = new System.Drawing.Point(42, 219);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(204, 28);
            this.btndangnhap.TabIndex = 16;
            this.btndangnhap.Text = "Đăng Nhập";
            this.btndangnhap.UseVisualStyleBackColor = false;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(18, 116);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(274, 20);
            this.txtemail.TabIndex = 10;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(42, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Đăng Nhập Hệ Thống";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(128, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FrmDangNhap
            // 
            this.AcceptButton = this.btndangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(307, 293);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnQuenmk);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkbSave);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label1);
            this.Name = "FrmDangNhap";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnQuenmk;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkbSave;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label1;
    }
}