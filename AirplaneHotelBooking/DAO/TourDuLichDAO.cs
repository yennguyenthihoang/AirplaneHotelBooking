using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AirplaneHotelBooking.DTO;
using System.Data.SqlClient;
using System.Data;

namespace AirplaneHotelBooking.DAO
{
    class TourDuLichDAO : DataProvider
    {
        public List<TourDuLichDTO> getDanhSachTourDuLich(int MaDDDL)
        {
            
            connect();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet dataset = new DataSet();
            List<TourDuLichDTO> ds = new List<TourDuLichDTO>();

            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_DSTourDuLich_DiaDiemDuLich";

            paramater = new SqlParameter("MaDDDL", SqlDbType.Int, 4);
            paramater.Direction = ParameterDirection.Input;
            paramater.Value = MaDDDL;
            command.Parameters.Add(paramater);

            da.SelectCommand = command;
            da.Fill(dataset);

            DataTable dataTable = dataset.Tables[0];
            int n = dataTable.Rows.Count;
            for (int i = 0; i < n; i++)
            {
                TourDuLichDTO TourDuLichDTO = new TourDuLichDTO();
                TourDuLichDTO = (TourDuLichDTO)GetDataFromDataRow(dataTable, i);
                ds.Add(TourDuLichDTO);
            }
            disconnect();
            return ds;
        }

        protected override object GetDataFromDataRow(System.Data.DataTable dt, int i)
        {
            TourDuLichDTO itemTour = new TourDuLichDTO();
            try
            {
                itemTour.MaTour = Convert.ToInt32(dt.Rows[i]["MaTour"].ToString());
                itemTour.TenTour = dt.Rows[i]["TenTour"].ToString();
                itemTour.GiaTour = Convert.ToDouble(dt.Rows[i]["GiaTour"].ToString());
                itemTour.LichTrinh = dt.Rows[i]["LichTrinh"].ToString();
                itemTour.MaDDDL = Convert.ToInt32(dt.Rows[i]["MaDDDL"].ToString());
                itemTour.ThoiGian = (DateTime)dt.Rows[i]["ThoiGian"];
            }
            catch (Exception ex)
            {
 
            }            
            return itemTour;
        }
    }
}
