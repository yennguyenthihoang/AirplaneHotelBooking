using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AirplaneHotelBooking.DAO;
using AirplaneHotelBooking.DTO;
namespace AirplaneHotelBooking.DTO
{
    public class PhongDTO
    {
        private int _MaPhong;

        public int MaPhong
        {
            get { return _MaPhong; }
            set { _MaPhong = value; }
        }
        private string _TenPhong;

        public string TenPhong
        {
            get { return _TenPhong; }
            set { _TenPhong = value; }
        }
        private int _SoNguoiToiDa;

        public int SoNguoiToiDa
        {
            get { return _SoNguoiToiDa; }
            set { _SoNguoiToiDa = value; }
        }
        private int _Gia;

        public int Gia
        {
            get { return _Gia; }
            set { _Gia = value; }
        }
        private bool _TrangThai;

        public bool TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }
        private string _LoaiPhong;

        public string LoaiPhong
        {
            get { return _LoaiPhong; }
            set { _LoaiPhong = value; }
        }
        private string _KhuyenMai;

        public string KhuyenMai
        {
            get { return _KhuyenMai; }
            set { _KhuyenMai = value; }
        }
        private int _MaKS;

        public int MaKS
        {
            get { return _MaKS; }
            set { _MaKS = value; }
        }

    }
}
