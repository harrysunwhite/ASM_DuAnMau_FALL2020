using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Qlbanhang
{
   public class DTO_NhanVien
    {
        private string _tenNhanVien;
        private string _diaChi;
        private int _vaiTro;
        private string _emailNV;
        private string _matKhau;
        private int _tinhTrang;
        public string TenNhanVien
        {
            get
            {
                return _tenNhanVien;
            }
            set
            {
                _tenNhanVien = value;
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
        public int VaiTro
        {
            get
            {
                return _vaiTro;
            }
            set
            {
                _vaiTro = value;
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
        public string MatKhau
        {
            get
            {
                return _matKhau;
            }
            set
            {
                _matKhau = value;
            }
        }

        public int TinhTrang
        {
            get
            {
                return _tinhTrang;
            }
            set
            {
                _tinhTrang = value;
            }
        }
        public DTO_NhanVien(string email, string tenNv, string diaChi, int vaiTro, int tinhTrang, string matKhau)
        {
            this._tenNhanVien = tenNv;
            this._diaChi = diaChi;
            this._vaiTro = vaiTro;
            this._emailNV = email;
            this._tinhTrang = tinhTrang;
            this._matKhau = matKhau;
        }
        public DTO_NhanVien(string email, string tenNv,
            string diaChi, int vaiTro, int tinhTrang)
        {
            this._tenNhanVien = tenNv;
            this._diaChi = diaChi;
            this._vaiTro = vaiTro;
            this._emailNV = email;
            this._tinhTrang = tinhTrang;

        }
        public DTO_NhanVien()
        { }
    }
}

