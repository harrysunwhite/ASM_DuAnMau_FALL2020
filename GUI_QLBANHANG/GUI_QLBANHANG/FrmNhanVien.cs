﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Qlbanhang;
using DTO_Qlbanhang;

namespace GUI_QLBANHANG
{
    public partial class FrmNhanVien : Form
    {
        BUS_NhanVien busNV = new BUS_NhanVien();
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private  void LoadGridView(DataGridView dgvNhanvien)
        {
            if (dgvNhanvien.Rows.Count > 1)
            {
                if(dgvNhanvien.CurrentRow.Index < dgvNhanvien.Rows.Count - 1)
                {
                    btnLuu.Enabled = false;
                    txtTennv.Enabled = true;
                    txtDiachi.Enabled = true;
                    rbQuantri.Enabled = true;
                    rbNhanvien.Enabled = true;
                    rbHoatDong.Enabled = true;
                    rbNgung.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    //show data from selected row to controls
                    txtEmail.Text = dgvNhanvien.CurrentRow.Cells[0].Value.ToString();
                    txtTennv.Text = dgvNhanvien.CurrentRow.Cells[1].Value.ToString();
                    txtDiachi.Text = dgvNhanvien.CurrentRow.Cells[2].Value.ToString();
                    if (string.Compare(dgvNhanvien.CurrentRow.Cells[3].Value.ToString(),"Quản lý",true)==0)
                        rbQuantri.Checked = true;
                    else
                        rbNhanvien.Checked = true;
                    if (string.Compare(dgvNhanvien.CurrentRow.Cells[4].Value.ToString(),"Hoạt động", true) == 0)
                        rbHoatDong.Checked = true;
                    else
                        rbNgung.Checked = true;
                }    
                
            }
            else
            {
                MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        public bool IsValid(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void loadFrm()
        {
            txtSearch.Text = "Nhập tên nhân viên";

            txtTennv.Text = null;
            txtEmail.Text = null;
            txtDiachi.Text = null;
           
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnDong.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtEmail.Enabled = false;
            txtTennv.Enabled = false;
            txtDiachi.Enabled = false;
            rbNhanvien.Enabled = false;
            rbQuantri.Enabled = false;
            rbHoatDong.Enabled = false;
        }

        private void LoadDanhSach(DataTable dt)
        {
            dgvNhanvien.DataSource = dt;
            dgvNhanvien.Columns[0].HeaderText = "Email";
            dgvNhanvien.Columns[1].HeaderText = "Tên Nhân Viên";
            dgvNhanvien.Columns[2].HeaderText = "Địa chỉ";
            dgvNhanvien.Columns[3].HeaderText = "Vai Trò";
            dgvNhanvien.Columns[4].HeaderText = "Tình Trạng";
        }

        

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadDanhSach(busNV.getNhanVien());
            loadFrm();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtEmail.Focus();
            txtEmail.Text = null;
            txtTennv.Text = null;
            txtDiachi.Text = null;
            txtTennv.Enabled = true;
            txtEmail.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            rbNhanvien.Checked = false;
            rbNgung.Checked = false;
            rbQuantri.Checked = false;
            rbHoatDong.Checked = false;
            txtDiachi.Enabled = true;
            rbNhanvien.Enabled = true;
            rbQuantri.Enabled = true;
            rbNgung.Enabled = true;
            rbHoatDong.Enabled = true;
           
           
        }

        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            int role = 0;

            if (rbQuantri.Checked)
                role = 1;
            int tinhtrang = 0;
            if (rbHoatDong.Checked)
                tinhtrang = 1;
            DTO_NhanVien nv = new DTO_NhanVien(txtEmail.Text, txtTennv.Text, txtDiachi.Text, role, tinhtrang);
            if (busNV.ThemNhanVien(nv))
            {
                MessageBox.Show("Thêm thành công");

                try
                {
                    busNV.SendMailNewNV(txtEmail.Text);
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message);
                }
                loadFrm();
                LoadDanhSach(busNV.getNhanVien());

            }


            else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text;
            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                if (busNV.DeleteNhanVien(email))
                {
                    MessageBox.Show("Xóa dữ liệu thành công");
                    loadFrm();
                    LoadDanhSach(busNV.getNhanVien()); 
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
           
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadGridView(dgvNhanvien);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int role = 0;
            if (rbQuantri.Checked)
                role = 1;
            int tinhtrang = 0;
            if (rbHoatDong.Checked)
                tinhtrang = 1;
            DTO_NhanVien nv = new DTO_NhanVien(txtEmail.Text, txtTennv.Text, txtDiachi.Text, role, tinhtrang);
            if (MessageBox.Show("Xác nhận cập nhật thông tin nhân viên", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
               
                if (busNV.UpdateNhanVien(nv))
                {
                    MessageBox.Show("Sửa thành công");
                    loadFrm();
                    LoadDanhSach(busNV.getNhanVien());
                }
                else
                {
                    MessageBox.Show("Sửa ko thành công");
                }
            }
            else
            {
                loadFrm();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string TenNV = txtSearch.Text;
            DataTable ds = busNV.SearchNhanVien(TenNV);
            if (ds.Rows.Count > 0)
            {
                LoadDanhSach(ds);
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên có tên: "+ TenNV, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtSearch.Text = "Nhập tên nhân viên";
            
            loadFrm();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            loadFrm();
            LoadDanhSach(busNV.getNhanVien());
        }

        private void btnDanhsach_Click(object sender, EventArgs e)
        {
            LoadDanhSach(busNV.getNhanVien());
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNhanvien_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            LoadGridView(dgvNhanvien);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Text = null;
        }

      
    }
}
