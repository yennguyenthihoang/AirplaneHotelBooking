using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirplaneHotelBooking.DTO
{
    public class KhachSanDTO
    {
        private int _MaKS;

        public int MaKS
        {
            get { return _MaKS; }
            set { _MaKS = value; }
        }

        private string _TenKS;

        public string TenKS
        {
            get { return _TenKS; }
            set { _TenKS = value; }
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
        private string _ThongTinDVu;

        public string ThongTinDVu
        {
            get { return _ThongTinDVu; }
            set { _ThongTinDVu = value; }
        }



        private int _MaDDDL;

        public int MaDDDL
        {
            get { return _MaDDDL; }
            set { _MaDDDL = value; }
        }
        private DateTime _NgayCapNhap;

        public DateTime NgayCapNhap
        {
            get { return _NgayCapNhap; }
            set { _NgayCapNhap = value; }
        }
        private bool _Valid;
            
            
    }
}
