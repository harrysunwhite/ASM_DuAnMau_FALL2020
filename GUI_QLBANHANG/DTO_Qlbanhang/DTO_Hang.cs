using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Qlbanhang
{
    public class DTO_Hang
    {
        private int _maHang;
        private string _tenHang;
        private int _soLuong;
        private float _donGiaNhap;
        private float _donGiaBan;
        private byte[] _hinhAnh;
        private string _ghiChu;
        private string _Manv;
        private string _emailNv;
        public int MaHang
        {
            get
            {
                return _maHang;
            }
            set
            {
                _maHang = value;
            }
        }
        public string TenHang
        {
            get
            {
                return _tenHang;
            }
            set
            {
                _tenHang = value;
            }
        }
        public int SoLuong
        {
            get
            {
                return _soLuong;
            }
            set
            {
                _soLuong = value;
            }
        }
        public float DonGiaNhap
        {
            get
            {
                return _donGiaNhap;
            }
            set
            {
                _donGiaNhap = value;
            }
        }
        public float DonGiaBan
        {
            get
            {
                return _donGiaBan;
            }
            set
            {
                _donGiaBan = value;
            }
        }
        public byte[] HinhAnh
        {
            get
            {
                return _hinhAnh;
            }
            set
            {
                _hinhAnh = value;
            }
        }
        public string GhiChu
        {
            get
            {
                return _ghiChu;
            }
            set
            {
                _ghiChu = value;
            }
        }
        public string MaNV
        {
            get
            {
                return _Manv;
            }
            set
            {
                _Manv = value;
            }
        }
        public string EmailNV
        {
            get
            {
                return _emailNv;
            }
            set
            {
                _emailNv = value;
            }
        }
        
        
        public DTO_Hang(int maHang, string tenHang, int soLuong, float donGiaNhap, float donGiaBan,
                        byte[] hinhAnh, string ghiChu)
        {
            this.MaHang = maHang;
            this._tenHang = tenHang;
            this._soLuong = soLuong;
            this._donGiaNhap = donGiaNhap;
            this._donGiaBan = donGiaBan;
            this._hinhAnh = hinhAnh;
            this._ghiChu = ghiChu;
        }
        public DTO_Hang(string tenHang, int soLuong, float donGiaNhap, float donGiaBan,
                        byte[] hinhAnh, string ghiChu, string emailnv)
        {
            this._tenHang = tenHang;
            this._soLuong = soLuong;
            this._donGiaNhap = donGiaNhap;
            this._donGiaBan = donGiaBan;
            this._hinhAnh = hinhAnh;
            this._ghiChu = ghiChu;
            this.EmailNV = emailnv;
        }
        public DTO_Hang() { }
    }

}

