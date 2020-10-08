using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_Qlbanhang;
using DTO_Qlbanhang;

namespace BUS_Qlbanhang
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dalKhachHang = new DAL_KhachHang();
        public DataTable getKhach()
        {
            return dalKhachHang.getKhach();
        }
        public bool InsertKhach(DTO_KhachHang kh)
        {
            return dalKhachHang.ThemKhach(kh);
        }
        public bool UpdateKhach(DTO_KhachHang kh)
        {
            return dalKhachHang.UpdateKhach(kh);
        }
        public bool DeleteKhach(string SDT)
        {
            return dalKhachHang.DeleteKhach(SDT);
        }
        public DataTable SearchKhach(string SDT)
        {
            return dalKhachHang.SearchKhach(SDT);
        }
    }
}
