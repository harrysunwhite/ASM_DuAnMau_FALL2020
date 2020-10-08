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
        private void LoadDanhSachNhap()
        {
           
        }
        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            dgvtonkho.DataSource = busHang.ThongKe();
            dgvsp.DataSource = busHang.ThongKeNhapKho();
        }
    }
}
