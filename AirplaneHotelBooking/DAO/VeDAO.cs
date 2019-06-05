using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AirplaneHotelBooking.DTO;
using System.Data;
using System.Data.SqlClient;

namespace AirplaneHotelBooking.DAO
{
    class VeDAO : DataProvider
    {
        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            VeDTO itemPhong = new VeDTO();
            itemPhong.MaVe = Convert.ToInt32(dt.Rows[i]["MaVe"].ToString());
            itemPhong.MaCB = Convert.ToInt32(dt.Rows[i]["MaCB"].ToString());
            itemPhong.GiaVe = Convert.ToInt32(dt.Rows[i]["GiaVe"].ToString());
            itemPhong.GioVe = DateTime.Parse(dt.Rows[i]["GioVe"].ToString());
            itemPhong.NgayVe = DateTime.Parse(dt.Rows[i]["NgayVe"].ToString());
            itemPhong.LoaiVe = Convert.ToInt32((dt.Rows[i]["LoaiVe"].ToString()));

            return itemPhong;
        }

        public int getTongSoRecord()
        {
            connect();
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_TongSoLuongVe";

            paramater = new SqlParameter("Count", SqlDbType.Int, 4);
            paramater.Direction = ParameterDirection.Output;
            command.Parameters.Add(paramater);

            command.ExecuteNonQuery();
            int result = (int)command.Parameters["Count"].Value;
            disconnect();
            return result;
        }

        public List<VeDTO> getDanhSachVe_CB(int iPage, int numberItem)
        {
            connect();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet dataset = new DataSet();
            List<VeDTO> ds = new List<VeDTO>();

            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_DanhSachVePhanTrang";

            paramater = new SqlParameter("Start", SqlDbType.Int, 4);
            paramater.Direction = ParameterDirection.Input;
            paramater.Value = (iPage - 1) * numberItem;
            command.Parameters.Add(paramater);

            paramater = new SqlParameter("End", SqlDbType.Int, 4);
            paramater.Direction = ParameterDirection.Input;
            paramater.Value = iPage * numberItem;
            command.Parameters.Add(paramater);

            da.SelectCommand = command;
            da.Fill(dataset);

            DataTable dataTable = dataset.Tables[0];
            int n = dataTable.Rows.Count;
            for (int i = 0; i < n; i++)
            {
                VeDTO VeDTO = new DTO.VeDTO();
                VeDTO = (VeDTO)GetDataFromDataRow(dataTable, i);
                ds.Add(VeDTO);
            }
            disconnect();
            return ds;

        }

        public List<VeDTO> getDanhSachVe(int iPage, int numberItem)
        {
            connect();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet dataset = new DataSet();
            List<VeDTO> ds = new List<VeDTO>();

            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_DanhSachVePhanTrang";

            paramater = new SqlParameter("Start", SqlDbType.Int, 4);
            paramater.Direction = ParameterDirection.Input;
            paramater.Value = (iPage - 1) * numberItem;
            command.Parameters.Add(paramater);

            paramater = new SqlParameter("End", SqlDbType.Int, 4);
            paramater.Direction = ParameterDirection.Input;
            paramater.Value = iPage * numberItem;
            command.Parameters.Add(paramater);

            da.SelectCommand = command;
            da.Fill(dataset);

            DataTable dataTable = dataset.Tables[0];
            int n = dataTable.Rows.Count;
            for (int i = 0; i < n; i++)
            {
                VeDTO VeDTO = new DTO.VeDTO();
                VeDTO = (VeDTO)GetDataFromDataRow(dataTable, i);
                ds.Add(VeDTO);
            }
            disconnect();
            return ds;
        }
    }
}
