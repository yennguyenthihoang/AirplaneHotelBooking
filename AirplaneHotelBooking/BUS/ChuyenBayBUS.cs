using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AirplaneHotelBooking.DAO;
using AirplaneHotelBooking.DTO;
namespace AirplaneHotelBooking.BUS
{
    class ChuyenBayBUS
    {
        public int getTongSoRecord()
        {
            ChuyenBayDAO dao = new ChuyenBayDAO();
            return dao.getTongSoRecord();
        }

        public List<ChuyenBayDTO> getDanhSachChuyenBay(int iPage, int numberItem)
        {
            ChuyenBayDAO dao = new ChuyenBayDAO();
            return dao.getDanhSachChuyenBay(iPage, numberItem);
        }

        public List<ChuyenBayDTO> TimKiemChuyenBay(string NoiDen, int MaCB, DateTime NgayBay)
        {
            ChuyenBayDAO dao = new ChuyenBayDAO();
            return dao.TimKiemChuyenBay(NoiDen, MaCB, NgayBay);
        }

        public List<ChuyenBayDTO> SapXepChuyenBay()
        {
            ChuyenBayDAO dao = new ChuyenBayDAO();
            return dao.SapXepChuyenBay();
        }
    }
}
