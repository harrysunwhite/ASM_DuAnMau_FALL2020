using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Qlbanhang;
using BUS_Qlbanhang;

namespace GUI_QLBANHANG
{
    public partial class FrmKhach : Form
    {
        BUS_KhachHang BusKH = new BUS_KhachHang();
        public FrmKhach()
        {
            InitializeComponent();
            
        }

       private void showerror()
        {
            if (string.IsNullOrWhiteSpace(txtDienthoai.Text)) errorDT.SetError(txtDienthoai, "Không để trống số điẹn thoại!");
            else if (!BusKH.isvailphone(txtDienthoai.Text)) errorDT.SetError(txtDienthoai, "Số điện thoại không hợp lệ");
            if (string.IsNullOrWhiteSpace(txtTenkhach.Text)) errorHoTen.SetError(txtTenkhach, "Không để tróng tên khách hàng");
            if (string.IsNullOrWhiteSpace(txtDiachi.Text)) errorDiaChi.SetError(txtDiachi, "Không dể trống địa chỉ khách hàng");

            string error = errorDT.GetError(txtDienthoai) + "\n\r" + errorHoTen.GetError(txtTenkhach) + "\n\r" + errorDiaChi.GetError(txtDiachi);

            MessageBox.Show(error, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;

        }
        private void loadFrm()
        {
            txtDiachi.Text = null;
            txtDienthoai.Text = null;
            txtTenkhach.Text = null;
            rbnam.Checked = true;
            rbnu.Checked = false;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnDong.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtDiachi.Enabled = false;
            txtDienthoai.Enabled = false;
            txtTenkhach.Enabled = false;
            rbnu.Enabled = false;
            rbnam.Enabled = false;
            dgvkhach.Enabled = true; 
            txtDienthoai.Focus();
            errorHoTen.SetError(txtTenkhach, null);
            errorDT.SetError(txtDienthoai, null);
            errorDiaChi.SetError(txtDiachi, null);
        }

        private void LoadDanhSach(DataTable dt)
        {
            dgvkhach.DataSource = dt;
            dgvkhach.Columns[0].HeaderText = "Điện Thoại";
            dgvkhach.Columns[1].HeaderText = "Họ và Tên";
            dgvkhach.Columns[2].HeaderText = "Địa Chỉ";
            dgvkhach.Columns[3].HeaderText = "Giới Tính";
            dgvkhach.Columns[4].HeaderText = "Nhân viên Giới thiệu";
        }

        private void FrmKhach_Load(object sender, EventArgs e)
        {
            loadFrm();
            LoadDanhSach(BusKH.getKhach());
        }

        private void LoadGridView(DataGridView dgvKhach)
        {

            if (dgvkhach.Rows.Count > 1)
            {
                if(dgvKhach.CurrentRow.Index < dgvKhach.Rows.Count - 1)
                {
                    
                    txtDienthoai.Text = dgvkhach.CurrentRow.Cells[0].Value.ToString();
                    txtTenkhach.Text = dgvkhach.CurrentRow.Cells[1].Value.ToString();
                    txtDiachi.Text = dgvkhach.CurrentRow.Cells[2].Value.ToString();
                    string phai = dgvkhach.CurrentRow.Cells[3].Value.ToString();
                    if (phai == "Nam")
                        rbnam.Checked = true;
                    else
                        rbnu.Checked = true;
                }                    
                
            }
            else
            {
                MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
}

       

     
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtDienthoai.Text)&&BusKH.isvailphone(txtDienthoai.Text)&&!string.IsNullOrWhiteSpace(txtTenkhach.Text)&&string.IsNullOrWhiteSpace(txtDiachi.Text))
            {
                string userMail = FrmMain.mail;
                string phai = "Nữ";
                if (rbnam.Checked == true)
                    phai = "Nam";
                DTO_KhachHang kh = new DTO_KhachHang(txtDienthoai.Text, txtTenkhach.Text,
                        txtDiachi.Text, phai, userMail);
                if (BusKH.InsertKhach(kh))
                {
                    MessageBox.Show("Thêm thành công");
                    loadFrm();
                    LoadDanhSach(BusKH.getKhach());
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }    
            else
            {
                showerror();
            }    
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            btnDong.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtDiachi.Text = null;
            txtDienthoai.Text = null;
            txtTenkhach.Text = null;
            rbnam.Checked = true;
            rbnu.Checked = false;
            txtDiachi.Enabled = true;
            txtDienthoai.Enabled = true;
            txtTenkhach.Enabled = true;
            rbnu.Enabled = true;
            rbnam.Enabled = true;
            dgvkhach.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string SDT = txtDienthoai.Text;
            if (MessageBox.Show("Bạn thật sự muốn xoá dữ liệu khách hàng", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                if (BusKH.DeleteKhach(SDT))
                {
                    MessageBox.Show("Xóa dữ liệu khách hàng thành công");
                    loadFrm();
                    LoadDanhSach(BusKH.getKhach());
                }
                else
                {
                    MessageBox.Show("Xóa dữ liệu khách hàng không thành công");
                }
            }
            else
            {
               
                loadFrm();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string SDT = txttimKiem.Text;
            DataTable ds = BusKH.SearchKhach(SDT);
            if (ds.Rows.Count > 0)
            {
               
                    LoadDanhSach(ds);
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng nào có số điện thoại này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttimKiem.Focus();
            }
            txttimKiem.Text = "Nhập số điện thoại khach hàng";
         
            loadFrm();
        }
        

        private void dgvkhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnLuu.Enabled = false;
            txtDiachi.Enabled = true;
            txtDienthoai.Enabled = true;
            txtTenkhach.Enabled = true;
            rbnu.Enabled = true;
            rbnam.Enabled = true;
            txtDienthoai.Focus();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            LoadGridView(dgvkhach);
            errorHoTen.SetError(txtTenkhach, null);
            errorDT.SetError(txtDienthoai, null);
            errorDiaChi.SetError(txtDiachi, null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDienthoai.Text) && BusKH.isvailphone(txtDienthoai.Text) && !string.IsNullOrWhiteSpace(txtTenkhach.Text) && string.IsNullOrWhiteSpace(txtDiachi.Text))
            {
                string phai = "Nữ";
                if (rbnam.Checked == true) phai = "Nam";
                DTO_KhachHang kh = new DTO_KhachHang(txtDienthoai.Text, txtTenkhach.Text, txtDiachi.Text, phai);
                if (MessageBox.Show("Cập nhật thông tin khách hàng", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (BusKH.UpdateKhach(kh))
                    {
                        MessageBox.Show("Cập nhật khách hàng thành công");
                        loadFrm();
                        LoadDanhSach(BusKH.getKhach());
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật khách hàng thất bại");
                    }
                }
                else
                {

                    loadFrm();
                }
            }
            else
            {
                showerror();
            }    
                
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            loadFrm();
        }

        private void btnDanhsach_Click(object sender, EventArgs e)
        {
            LoadDanhSach(BusKH.getKhach());
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txttimKiem_MouseEnter(object sender, EventArgs e)
        {
            txttimKiem.Text = null;
        }

        private void txtDienthoai_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDienthoai.Text)) errorDT.SetError(txtDienthoai, "Không để trống số điẹn thoại!");
            else if (!BusKH.isvailphone(txtDienthoai.Text)) errorDT.SetError(txtDienthoai, "Số điện thoại không hợp lệ");
            else errorDT.SetError(txtDienthoai, null);

        }

        private void txtTenkhach_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenkhach.Text)) errorHoTen.SetError(txtTenkhach, "Không để tróng tên khách hàng");
            else errorHoTen.SetError(txtTenkhach, null);

        }

        private void txtDiachi_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtDiachi.Text)) errorDiaChi.SetError(txtDiachi, "Không dể trống địa chỉ khách hàng");
            else errorDiaChi.SetError(txtDiachi, null);
        }
    }
}
