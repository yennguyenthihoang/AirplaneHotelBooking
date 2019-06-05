using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirplaneHotelBooking.DTO
{
    public class ThongTinTimKiemDTO
    {
        //----------Dia diem du lich----------
        private string _QuocGia;

        public string QuocGia
        {
            get { return _QuocGia; }
            set { _QuocGia = value; }
        }
        private string _Vung;

        public string Vung
        {
            get { return _Vung; }
            set { _Vung = value; }
        }
        private string _ThanhPho;

        public string ThanhPho
        {
            get { return _ThanhPho; }
            set { _ThanhPho = value; }
        }

        public void ResetData()
        {
            this.Vung = "";
            this.ThanhPho = "";
            this.QuocGia = "";
        }

        //----------Khach san------------
        private string _TenKS;
        public string TenKS
        {
            get { return _TenKS; }
            set { _TenKS = value; }
        }
        private string _TenDDDL;

        public string TenDDDL
        {
            get { return _TenDDDL; }
            set { _TenDDDL = value; }
        }

        public void ResetDataTKKhachSan()
        {
            this.TenDDDL = "";
            this.TenKS = "";
        }
    }
}
