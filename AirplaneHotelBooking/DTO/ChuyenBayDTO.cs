using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirplaneHotelBooking.DTO
{
    public class ChuyenBayDTO
    {
        private int _MaCB;



        public int MaCB
        {
            get { return _MaCB; }
            set { _MaCB = value; }
        }
        private string _NoiDi;

        public string NoiDi
        {
            get { return _NoiDi; }
            set { _NoiDi = value; }
        }
        private string _NoiDen;

        public string NoiDen
        {
            get { return _NoiDen; }
            set { _NoiDen = value; }
        }
        private int _DiaDiemDi;

        public int DiaDiemDi
        {
            get { return _DiaDiemDi; }
            set { _DiaDiemDi = value; }
        }
        private int _DiaDiemDen;

        public int DiaDiemDen
        {
            get { return _DiaDiemDen; }
            set { _DiaDiemDen = value; }
        }
        private DateTime _GioBay;

        public DateTime GioBay
        {            
            set { _GioBay = value; }
        }

        public string GioDi
        {
            get { return _GioBay.ToShortTimeString(); }
        }

        private DateTime _NgayBay;

        public DateTime NgayBay
        {
            get { return _NgayBay; }
            set { _NgayBay = value; }
        }
        private string _HangMayBay;

        public string HangMayBay
        {
            get { return _HangMayBay; }
            set { _HangMayBay = value; }
        }
        private string _ThongTinDVu;

        public string ThongTinDVu
        {
            get { return _ThongTinDVu; }
            set { _ThongTinDVu = value; }
        }


    }
}
