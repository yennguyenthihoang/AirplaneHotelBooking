using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirplaneHotelBooking.DTO
{
    public class TourDuLichDTO
    {
        private int _MaTour;

        public int MaTour
        {
            get { return _MaTour; }
            set { _MaTour = value; }
        }
        private string _TenTour;

        public string TenTour
        {
            get { return _TenTour; }
            set { _TenTour = value; }
        }
        private Double _GiaTour;

        public Double GiaTour
        {
            get { return _GiaTour; }
            set { _GiaTour = value; }
        }
        private string _LichTrinh;

        public string LichTrinh
        {
            get { return _LichTrinh; }
            set { _LichTrinh = value; }
        }
        private DateTime _ThoiGian;

        public DateTime ThoiGian
        {
            get { return _ThoiGian; }
            set { _ThoiGian = value; }
        }
        private int _MaDDDL;

        public int MaDDDL
        {
            get { return _MaDDDL; }
            set { _MaDDDL = value; }
        }
    }
}
