using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirplaneHotelBooking.DTO
{
    public class BinhLuanDTO
    {
        private int _MaBinhLuan;

        public int MaBinhLuan
        {
            get { return _MaBinhLuan; }
            set { _MaBinhLuan = value; }
        }
        private string _NoiDung;

        public string NoiDung
        {
            get { return _NoiDung; }
            set { _NoiDung = value; }
        }
        private int _MaDDDL;

        public int MaDDDL
        {
            get { return _MaDDDL; }
            set { _MaDDDL = value; }
        }
        private bool _Valid;

        public bool Valid
        {
            get { return _Valid; }
            set { _Valid = value; }
        }
    }
}
