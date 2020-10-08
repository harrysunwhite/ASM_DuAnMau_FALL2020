using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Qlbanhang;
using System.Data;
using DTO_Qlbanhang;

namespace BUS_Qlbanhang
{
    public class BUS_Hang
    {
        DAL_Hang dalHang = new DAL_Hang();
        public DataTable getHang()
        {
            return dalHang.getHang();
        }
        public bool InsertHang(DTO_Hang hang)
        {
            return dalHang.ThemHang(hang);
        }
        public bool UpdateHang(DTO_Hang hang)
        {
            return dalHang.UpdateHang(hang);
        }
        public bool DeleteHang(int maHang)
        {
            return dalHang.DeleteHang(maHang);
        }
        public DataTable SearchHang(string tenHang)
        {
            return dalHang.SearchHang(tenHang);
        }
        public DataTable ThongKe()
        {
            return dalHang.ThongKeTon();
        }

        public DataTable ThongKeNhapKho()
        {
            return dalHang.ThongKeNhapHang();
        }

        public byte[] gethinhHang(string id)
        {
            return dalHang.gethinhHang(id);
        }
    }
}
