using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirplaneHotelBooking.DTO
{
    public class VeDTO
    {
        private int _MaVe;

        public int MaVe
        {
            get { return _MaVe; }
            set { _MaVe = value; }
        }
        private int _GiaVe;

        public int GiaVe
        {
            get { return _GiaVe; }
            set { _GiaVe = value; }
        }
        private int _MaCB;

        public int MaCB
        {
            get { return _MaCB; }
            set { _MaCB = value; }
        }
        private DateTime _NgayVe;

        public DateTime NgayVe
        {
            get { return _NgayVe; }
            set { _NgayVe = value; }
        }
        private DateTime _GioVe;

        public DateTime GioVe
        {
            get { return _GioVe; }
            set { _GioVe = value; }
        }
        private int _LoaiVe;

        public int LoaiVe
        {
            get { return _LoaiVe; }
            set { _LoaiVe = value; }
        }
    }
}
