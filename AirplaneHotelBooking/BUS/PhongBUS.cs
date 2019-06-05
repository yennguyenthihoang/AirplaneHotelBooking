using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AirplaneHotelBooking.DAO;
using AirplaneHotelBooking.DTO;

namespace AirplaneHotelBooking.BUS
{
    class PhongBUS
    {
        public int getTongSoRecord()
        {
            PhongDAO dao = new PhongDAO();
            return dao.getTongSoRecord();
        }

        public List<PhongDTO> getDanhSachPhong(int iPage, int numberItem)
        {
            PhongDAO dao = new PhongDAO();
            return dao.getDanhSachPhong(iPage, numberItem);
        }

        public List<PhongDTO> TimKiemPhong(double Giatu, double Giaden, int MaPhong, bool KhuyenMai, bool DaDuocDat)
        {
            PhongDAO dao = new PhongDAO();
            return dao.TimKiemPhong(Giatu, Giaden, MaPhong, KhuyenMai, DaDuocDat);
        }
    }
}
