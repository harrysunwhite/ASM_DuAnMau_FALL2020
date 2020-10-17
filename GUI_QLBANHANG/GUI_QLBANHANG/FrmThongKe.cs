using BUS_Qlbanhang;
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

namespace GUI_QLBANHANG
{
    public partial class FrmThongKe : Form
    {
        BUS_Hang busHang = new BUS_Hang();
        public FrmThongKe()
        {
            InitializeComponent();
        }
        private void LoadDanhSachTonKho()
        {
            dgvtonkho.DataSource = busHang.ThongKe();
            dgvtonkho.Columns[0].HeaderText = "Tên hàng";
            dgvtonkho.Columns[1].HeaderText = "Số Lượng";
        }
        private void LoadDanhSachNhap()
        {
            dgvsp.DataSource = busHang.ThongKeNhapKho();
            dgvsp.Columns[0].HeaderText = "Mã nhân viên";
            dgvsp.Columns[1].HeaderText = "Tên Nhân Viên";
            dgvsp.Columns[2].HeaderText = "Số lượng hàng nhập";
        }
        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            LoadDanhSachTonKho();
            LoadDanhSachNhap();
           
         }

        private void dgvsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
