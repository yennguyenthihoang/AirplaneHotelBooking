using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AirplaneHotelBooking.DAO;
using AirplaneHotelBooking.DTO;

namespace AirplaneHotelBooking.BUS
{
    class KhachSanBUS
    {
        public int getTongSoRecord()
        {
            KhachSanDAO dao = new KhachSanDAO();
            return dao.getTongSoRecord();
        }

        public List<KhachSanDTO> getDanhSachKhachSan1(int MaDDDL)
        {
            KhachSanDAO dao = new KhachSanDAO();
            return dao.getDanhSachKhachSan1(MaDDDL);
        }

        public List<KhachSanDTO> getDanhSachKhachSan(int iPage, int numberItem)
        {
            KhachSanDAO dao = new KhachSanDAO();
            return dao.getDanhSachKhachSan(iPage, numberItem);
        }

        public List<KhachSanDTO> TimKiemKhachSan(string TenKS, string TenDDDL, int iPage, int numberItem)
        {
            KhachSanDAO dao = new KhachSanDAO();
            return dao.TimKiemKhachSan(TenKS, TenDDDL, iPage, numberItem);
        }

        public int getTongSeRecordKetQuaTimKiemKhachSan(string TenKS, string TenDDDL)
        {
            KhachSanDAO dao = new KhachSanDAO();
            return dao.getTongSeRecordKetQuaTimKiemKhachSan(TenKS, TenDDDL);
        }

        /*public List<VeDTO> getVeMayBay(int MaKS)
        {
            VeDAO veMBDAO = new VeDAO();
            return veMBDAO.getDanhSachVe_CB(MaKS);
        }*/


        public List<VeDTO> getVeMayBay(int iPage, int numberItem)
        {
            VeDAO veMBDAO = new VeDAO();
            return veMBDAO.getDanhSachVe_CB(iPage, numberItem);
        }
    }
}
