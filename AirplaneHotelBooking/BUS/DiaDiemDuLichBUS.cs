using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AirplaneHotelBooking.DAO;
using AirplaneHotelBooking.DTO;

namespace AirplaneHotelBooking.BUS
{
    public class DiaDiemDuLichBUS
    {

        public int getTongSoRecord()
        {
            DiaDiemDuLichDAO dao = new DiaDiemDuLichDAO();
            return dao.getTongSoRecord();
            
        }

        public List<DiaDiemDuLichDTO> getDanhSachDiaDiemDuLich(int iPage, int numberItem)
        {
            DiaDiemDuLichDAO dao = new DiaDiemDuLichDAO();
            return dao.getDanhSachDiaDiemDuLich(iPage, numberItem);
        }

        public List<DiaDiemDuLichDTO> TimKiemDiaDiemDuLich(string QuocGia, string Vung, string ThanhPho, int iPage, int numberItem)
        {
            DiaDiemDuLichDAO dao = new DiaDiemDuLichDAO();
            return dao.TimKiemDiaDiemDuLich(QuocGia, Vung, ThanhPho,iPage,numberItem);
        }

        public List<BinhLuanDTO> getDanhSachBinhLuan(int MaDDDL)
        {
            BinhLuanDAO BinhLuanDAO = new BinhLuanDAO();
            return BinhLuanDAO.getDanhSachBinhLuan(MaDDDL);
        }

        public int getTongSeRecordKetQuaTimKiemDDDL(string QuocGia, string Vung, string ThanhPho)
        {
            DiaDiemDuLichDAO dao = new DiaDiemDuLichDAO();
            return dao.getTongSeRecordKetQuaTimKiemDDDL(QuocGia, Vung, ThanhPho);
        }

        public List<ChuyenBayDTO> getDanhSachChuyenBay(int MaDDDL)
        {
            ChuyenBayDAO cbDAO = new ChuyenBayDAO();
            return cbDAO.getDanhSachChuyenBay(MaDDDL);
        }

        public List<TourDuLichDTO> getDanhSachTourDuLich(int MaDDDL)
        {
            TourDuLichDAO tourDAO = new TourDuLichDAO();
            return tourDAO.getDanhSachTourDuLich(MaDDDL);
        }

        public List<KhachSanDTO> getDanhSachKhachSan1(int MaDDDL)
        {
            KhachSanDAO ksDAO = new KhachSanDAO();
            return ksDAO.getDanhSachKhachSan1(MaDDDL);
        }
    }
}
