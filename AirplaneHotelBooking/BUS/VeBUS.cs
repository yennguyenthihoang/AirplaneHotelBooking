using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AirplaneHotelBooking.DAO;
using AirplaneHotelBooking.DTO;

namespace AirplaneHotelBooking.BUS
{
    class VeBUS
    {
        public int getTongSoRecord()
        {
            VeDAO dao = new VeDAO();
            return dao.getTongSoRecord();
        }

        public List<VeDTO> getDanhSachVe(int iPage, int numberItem)
        {
            VeDAO dao = new VeDAO();
            return dao.getDanhSachVe(iPage, numberItem);
        }
    }
}
