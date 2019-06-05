using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirplaneHotelBooking.DTO
{
    class KhachHangDTO
    {
        private int _MaKH;

        public int MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }
        private string _MatKhau;

        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }
        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        private string _SoNha;

        public string SoNha
        {
            get { return _SoNha; }
            set { _SoNha = value; }
        }
        private string _Duong;

        public string Duong
        {
            get { return _Duong; }
            set { _Duong = value; }
        }
        private string _ThanhPho;

        public string ThanhPho
        {
            get { return _ThanhPho; }
            set { _ThanhPho = value; }
        }
        private string _DienThoai;

        public string DienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }
        private string _Passport;

        public string Passport
        {
            get { return _Passport; }
            set { _Passport = value; }
        }
        private string _Cmnd;

        public string Cmnd
        {
            get { return _Cmnd; }
            set { _Cmnd = value; }
        }
        private string _TenKH;

        public string TenKH
        {
            get { return _TenKH; }
            set { _TenKH = value; }
        }
    }
}
