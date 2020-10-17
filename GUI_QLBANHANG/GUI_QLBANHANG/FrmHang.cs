using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Qlbanhang;
using BUS_Qlbanhang;

namespace GUI_QLBANHANG
{
    public partial class FrmHang : Form
    {
        BUS_Hang BusHang = new BUS_Hang();
        private string imagePath;
        public FrmHang()
        {
            InitializeComponent();
        }
        
        private void showerror()
        {
            int soluong;
            float DonGiaNhap;
            float DonGiaban;

            if (string.IsNullOrWhiteSpace(txtTenhang.Text)) errorTenHang.SetError(txtTenhang, "Không để trống tên hàng");
            if (!int.TryParse(txtSoluong.Text, out soluong)) errorSoLuong.SetError(txtSoluong, "Số lượng phải là số nguyên dương");
            else if (int.Parse(txtSoluong.Text) <= 0) errorSoLuong.SetError(txtSoluong, "SỐ lượng là số nguyên dương");
            if (!float.TryParse(txtDongianhap.Text, out DonGiaNhap)) errorGiaNhap.SetError(txtDongianhap, "Đơn giá nhập phải là một số");
            else if (float.Parse(txtDongianhap.Text) <= 0) errorGiaNhap.SetError(txtDongianhap, "Đơn giá nhập phải lớn hơn 0");
            if (!float.TryParse(txtDongiaban.Text, out DonGiaban)) errorGiaBan.SetError(txtDongiaban, "Đơn giá bán phải là một số");
            else if (float.Parse(txtDongiaban.Text) <= 0) errorGiaBan.SetError(txtDongiaban, "Đơn giá bán phải lớn hơn 0");
            string error = errorTenHang.GetError(txtTenhang) + "\n\r" + errorSoLuong.GetError(txtSoluong) + "\n\r" + errorGiaNhap.GetError(txtDongianhap) + "\n\r" + errorGiaBan.GetError(txtDongiaban);

            MessageBox.Show(error, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Information); 

        }
        private void loadFrm()
        {
            txtMahang.Text = null;
            txtTenhang.Text = null;
            txtSoluong.Text = null;
            txtDongianhap.Text = null;
            txtDongiaban.Text = null;
           
            pbImage.Image = null;
            txtGhichu.Text = null;

            txtTenhang.Enabled = false;
            txtSoluong.Enabled = false;
            txtDongianhap.Enabled = false;
            txtDongiaban.Enabled = false;
           
            txtGhichu.Enabled = false;
            btnOpenDialog.Enabled = false;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnDong.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            errorTenHang.SetError(txtTenhang, null);
            errorSoLuong.SetError(txtSoluong, null);
            errorGiaNhap.SetError(txtDongianhap, null);
            errorGiaBan.SetError(txtDongiaban, null);
            string startupPath = Environment.CurrentDirectory;
            string file = startupPath + @"\Shopping.png";
            pbImage.BackgroundImage = Image.FromFile(file);
            pbImage.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void LoadDanhSachHang(DataTable dt)
        {
            dgvhang.DataSource = dt;
            dgvhang.Columns[0].HeaderText = "Mã Sản Phẩm";
            dgvhang.Columns[1].HeaderText = "Tên Sản Phẩm";
            dgvhang.Columns[2].HeaderText = "Số Lượng";
            dgvhang.Columns[3].HeaderText = "Đơn Giá Nhập";
            dgvhang.Columns[4].HeaderText = "Đơn Giá Bán";

            dgvhang.Columns[5].Visible = false;
            dgvhang.Columns[6].HeaderText = "Ghi chú";
            dgvhang.Columns[7].HeaderText = "Mã nhân viên";
        }
        private void ChangeImage(ref string Path)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.InitialDirectory = "C:\\";
                openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog1.FileName;
                    FileInfo fi = new FileInfo(filePath);
                    Image img = Image.FromFile(filePath);
                    pbImage.BackgroundImage = Image.FromFile(filePath);
                    pbImage.BackgroundImageLayout = ImageLayout.Stretch;
                    Path = filePath;
                }
                else Path = "";


            }
            catch
            {

            }



        }

        private void btnOpenDialog_Click(object sender, EventArgs e)
        {
            ChangeImage(ref imagePath);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int soluong; 
            float DonGiaNhap; 
            float DonGiaban;

            if(!string.IsNullOrWhiteSpace(txtTenhang.Text)&& int.TryParse(txtSoluong.Text, out soluong)&& (int.Parse(txtSoluong.Text)>0 )&& (float.TryParse(txtDongianhap.Text, out DonGiaNhap)) && (float.Parse(txtDongianhap.Text)>0)&& (float.TryParse(txtDongiaban.Text, out DonGiaban)) && (float.Parse(txtDongiaban.Text) > 0))
            {

                Image img = pbImage.BackgroundImage;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

                DTO_Hang h = new DTO_Hang(txtTenhang.Text, int.Parse(txtSoluong.Text), float.Parse(txtDongianhap.Text),
                    float.Parse(txtDongiaban.Text), arr, txtGhichu.Text, FrmMain.mail);
                if (BusHang.InsertHang(h))
                {
                    MessageBox.Show("Thêm sản phẩm thành công");

                    loadFrm();
                    LoadDanhSachHang(BusHang.getHang());
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm không thành công");
                }
            }
            else
            {
                showerror();
            }    



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmHang_Load(object sender, EventArgs e)
        {
            loadFrm();
            LoadDanhSachHang(BusHang.getHang());
        }

        private void dgvhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvhang.Rows.Count > 1)
            {
                if (dgvhang.CurrentRow.Index < dgvhang.Rows.Count - 1)
                {



                    btnOpenDialog.Enabled = true;
                    btnLuu.Enabled = false;
                    txtTenhang.Enabled = true;
                    txtSoluong.Enabled = true;
                    txtDongianhap.Enabled = true;
                    txtDongiaban.Enabled = true;
                    txtGhichu.Enabled = true;
                    txtTenhang.Focus();
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    txtMahang.Text = dgvhang.CurrentRow.Cells["MaHang"].Value.ToString();
                    txtTenhang.Text = dgvhang.CurrentRow.Cells["TenHang"].Value.ToString();
                    txtSoluong.Text = dgvhang.CurrentRow.Cells["SoLuong"].Value.ToString();
                    txtDongianhap.Text = dgvhang.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
                    txtDongiaban.Text = dgvhang.CurrentRow.Cells["DonGiaBan"].Value.ToString();

                    MemoryStream mem = new MemoryStream(BusHang.gethinhHang(txtMahang.Text));
                    pbImage.BackgroundImage = Image.FromStream(mem);
                    pbImage.BackgroundImageLayout = ImageLayout.Stretch;

                    txtGhichu.Text = dgvhang.CurrentRow.Cells["GhiChu"].Value.ToString();
                    errorTenHang.SetError(txtTenhang, null);
                    errorSoLuong.SetError(txtSoluong, null);
                    errorGiaNhap.SetError(txtDongianhap, null);
                    errorGiaBan.SetError(txtDongiaban, null);
                }
            }
            else
            {
                MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnOpenDialog.Enabled = true;
            txtTenhang.Enabled = true;
            txtSoluong.Enabled = true;
            txtDongianhap.Enabled = true;
            txtDongiaban.Enabled = true;
            txtGhichu.Enabled = true;
            txtMahang.Text = null;
            txtTenhang.Text = null;
            txtSoluong.Text = null;
            txtDongianhap.Text = null;
            txtDongiaban.Text = null;
           
            pbImage.Image = null;
            txtGhichu.Text = null;
            txtTenhang.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int MaHang = int.Parse(txtMahang.Text);
            if (MessageBox.Show("Xác nhận xoá hàng hoá này", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                if (BusHang.DeleteHang(MaHang))
                {
                    MessageBox.Show("Xóa dữ liệu thành công");
                    loadFrm();
                    LoadDanhSachHang(BusHang.getHang());
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            else
            {
                
                loadFrm();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            loadFrm();
            LoadDanhSachHang(BusHang.getHang());
        }

        private void btnDanhsach_Click(object sender, EventArgs e)
        {
            LoadDanhSachHang(BusHang.getHang());
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int soluong;
            float DonGiaNhap;
            float DonGiaban;

            if (!string.IsNullOrWhiteSpace(txtTenhang.Text) && int.TryParse(txtSoluong.Text, out soluong) && (int.Parse(txtSoluong.Text) > 0) && (float.TryParse(txtDongianhap.Text, out DonGiaNhap)) && (float.Parse(txtDongianhap.Text) > 0) && (float.TryParse(txtDongiaban.Text, out DonGiaban)) && (float.Parse(txtDongiaban.Text) > 0))
            {
                Image img = pbImage.BackgroundImage;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

                DTO_Hang hang = new DTO_Hang(int.Parse(txtMahang.Text), txtTenhang.Text, int.Parse(txtSoluong.Text),
                           float.Parse(txtDongianhap.Text),
                           float.Parse(txtDongiaban.Text), arr, txtGhichu.Text);
                if (MessageBox.Show("Bạn có chắc muốn chỉnh sửa", "Confirm", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (BusHang.UpdateHang(hang))
                    {

                        MessageBox.Show("Sửa thành công");
                        loadFrm();
                        LoadDanhSachHang(BusHang.getHang());
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
            else
            {
                showerror();
            }    

                
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string tenHang = txttimKiem.Text;
            DataTable ds = BusHang.SearchHang(tenHang);
            if (ds.Rows.Count > 0)
            {
                LoadDanhSachHang(ds);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txttimKiem.Text = "Nhập tên sản phẩm";
           
            loadFrm();
        }

        private void txttimKiem_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void txtTenhang_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenhang.Text)) errorTenHang.SetError(txtTenhang, "Không để trống tên hàng");
            else errorTenHang.SetError(txtTenhang, null);
            
        }

        private void txtSoluong_Validating(object sender, CancelEventArgs e)
        {
            int soluong;
           
            if (!int.TryParse(txtSoluong.Text, out soluong)) errorSoLuong.SetError(txtSoluong, "Số lượng phải là số nguyên dương");
            else if (int.Parse(txtSoluong.Text) <= 0) errorSoLuong.SetError(txtSoluong, "SỐ lượng là số nguyên dương");
            else errorSoLuong.SetError(txtSoluong, null);
        }

        private void txtDongianhap_Validating(object sender, CancelEventArgs e)
        {
            float DonGiaNhap;
            if (!float.TryParse(txtDongianhap.Text, out DonGiaNhap)) errorGiaNhap.SetError(txtDongianhap, "Đơn giá nhập phải là một số");
            else if (float.Parse(txtDongianhap.Text) <= 0) errorGiaNhap.SetError(txtDongianhap, "Đơn giá nhập phải lớn hơn 0");
            else errorGiaNhap.SetError(txtDongianhap, null);
          
        }

        private void txtDongiaban_Validating(object sender, CancelEventArgs e)
        {
            float DonGiaBan;
            if (!float.TryParse(txtDongiaban.Text, out DonGiaBan)) errorGiaNhap.SetError(txtDongiaban, "Đơn giá bán phải là một số");
            else if (float.Parse(txtDongiaban.Text) <= 0) errorGiaBan.SetError(txtDongiaban, "Đơn giá bán phải lớn hơn 0");
            else errorGiaNhap.SetError(txtDongiaban, null);
        }

        private void txttimKiem_Enter(object sender, EventArgs e)
        {
            txttimKiem.Text = null;
        }
    }
}
