using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Qlbanhang
{
    public class DTO_KhachHang
    {
        private string _soDienThoai;
        private string _tenKhach;
        private string _diaChi;
        private string _phai;
        private string _emailNV;
      

        public string SoDienThoai
        {
            get
            {
                return _soDienThoai;
            }
            set
            {
                _soDienThoai = value;
            }
        }
        public string TenKhach
        {
            get
            {
                return _tenKhach;
            }
            set
            {
                _tenKhach = value;
            }
        }
        public string DiaChi
        {
            get
            {
                return _diaChi;
            }
            set
            {
                _diaChi = value;
            }
        }
        public string Phai
        {
            get
            {
                return _phai;
            }
            set
            {
                _phai = value;
            }
        }
        public string EmailNV
        {
            get
            {
                return _emailNV;
            }
            set
            {
                _emailNV = value;
            }
        }
        public DTO_KhachHang(string dienThoai, string tenKhach, string diaChi, string phai, string email= null)
        {
            this._soDienThoai = dienThoai;
            this._tenKhach = tenKhach;
            this._diaChi = diaChi;
            this._phai = phai;
            this._emailNV = email;
        }
        public DTO_KhachHang()
        { }
    }
}
