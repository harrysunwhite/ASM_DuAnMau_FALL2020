﻿namespace GUI_QLBANHANG
{
    partial class FrmThongKe
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
            this.tcThongKe = new System.Windows.Forms.TabControl();
            this.tpsanpham = new System.Windows.Forms.TabPage();
            this.dgvsp = new System.Windows.Forms.DataGridView();
            this.tptonkho = new System.Windows.Forms.TabPage();
            this.dgvtonkho = new System.Windows.Forms.DataGridView();
            this.tcThongKe.SuspendLayout();
            this.tpsanpham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsp)).BeginInit();
            this.tptonkho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtonkho)).BeginInit();
            this.SuspendLayout();
            // 
            // tcThongKe
            // 
            this.tcThongKe.Controls.Add(this.tpsanpham);
            this.tcThongKe.Controls.Add(this.tptonkho);
            this.tcThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcThongKe.Location = new System.Drawing.Point(0, 0);
            this.tcThongKe.Name = "tcThongKe";
            this.tcThongKe.SelectedIndex = 0;
            this.tcThongKe.Size = new System.Drawing.Size(934, 541);
            this.tcThongKe.TabIndex = 1;
            // 
            // tpsanpham
            // 
            this.tpsanpham.CausesValidation = false;
            this.tpsanpham.Controls.Add(this.dgvsp);
            this.tpsanpham.Location = new System.Drawing.Point(4, 22);
            this.tpsanpham.Name = "tpsanpham";
            this.tpsanpham.Padding = new System.Windows.Forms.Padding(3);
            this.tpsanpham.Size = new System.Drawing.Size(926, 515);
            this.tpsanpham.TabIndex = 0;
            this.tpsanpham.Text = "Sản Phẩm Nhập Kho";
            this.tpsanpham.UseVisualStyleBackColor = true;
            // 
            // dgvsp
            // 
            this.dgvsp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsp.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvsp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvsp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvsp.Location = new System.Drawing.Point(3, 3);
            this.dgvsp.Name = "dgvsp";
            this.dgvsp.Size = new System.Drawing.Size(920, 509);
            this.dgvsp.TabIndex = 0;
            this.dgvsp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsp_CellContentClick);
            // 
            // tptonkho
            // 
            this.tptonkho.CausesValidation = false;
            this.tptonkho.Controls.Add(this.dgvtonkho);
            this.tptonkho.Location = new System.Drawing.Point(4, 22);
            this.tptonkho.Name = "tptonkho";
            this.tptonkho.Padding = new System.Windows.Forms.Padding(3);
            this.tptonkho.Size = new System.Drawing.Size(926, 515);
            this.tptonkho.TabIndex = 1;
            this.tptonkho.Text = "Tồn Kho";
            this.tptonkho.UseVisualStyleBackColor = true;
            // 
            // dgvtonkho
            // 
            this.dgvtonkho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtonkho.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvtonkho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvtonkho.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvtonkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtonkho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvtonkho.Location = new System.Drawing.Point(3, 3);
            this.dgvtonkho.Name = "dgvtonkho";
            this.dgvtonkho.Size = new System.Drawing.Size(920, 509);
            this.dgvtonkho.TabIndex = 0;
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 541);
            this.Controls.Add(this.tcThongKe);
            this.Name = "FrmThongKe";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo thống kê";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            this.tcThongKe.ResumeLayout(false);
            this.tpsanpham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsp)).EndInit();
            this.tptonkho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtonkho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcThongKe;
        private System.Windows.Forms.TabPage tpsanpham;
        private System.Windows.Forms.DataGridView dgvsp;
        private System.Windows.Forms.TabPage tptonkho;
        private System.Windows.Forms.DataGridView dgvtonkho;
    }
}