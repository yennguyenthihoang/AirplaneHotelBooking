using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirplaneHotelBooking.DTO
{
    public class DiaDiemDuLichDTO
    {
        private int _MaDDDL;

        public int MaDDDL
        {
            get { return _MaDDDL; }
            set { _MaDDDL = value; }
        }
        private string _TenDDDL;

        public string TenDDDL
        {
            get { return _TenDDDL; }
            set { _TenDDDL = value; }
        }
        private string _ThanhPho;

        public string ThanhPho
        {
            get { return _ThanhPho; }
            set { _ThanhPho = value; }
        }
        private string _HinhAnh;

        public string HinhAnh
        {
            get { return _HinhAnh; }
            set { _HinhAnh = value; }
        }
        private string _MoTa;

        public string MoTa
        {
            get { return _MoTa; }
            set { _MoTa = value; }
        }
        private bool _Valid;


        private DateTime _NgayCapNhat;

        public DateTime NgayCapNhat
        {
            get { return _NgayCapNhat; }
            set { _NgayCapNhat = value; }
        }

        private string _Vung;
        public string Vung
        {
            get { return _Vung; }
            set { _Vung = value; }
        }

        private string _QuocGia;

        public string QuocGia
        {
            get { return _QuocGia; }
            set { _QuocGia = value; }
        }

        private int _LoaiDDDL;
        public int LoaiDDDL
        {
            get { return _LoaiDDDL; }
            set { _LoaiDDDL = value; }
        }

    }
}
