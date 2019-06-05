using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AirplaneHotelBooking.DTO;
using System.Data;
using System.Data.SqlClient;

namespace AirplaneHotelBooking.DAO
{
    public class BinhLuanDAO:DataProvider
    {

        public List<BinhLuanDTO> getDanhSachBinhLuan(int MaDDDL)
        {
            connect();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet dataset = new DataSet();
            List<BinhLuanDTO> ds = new List<BinhLuanDTO>();

            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_DSBinhLuan_DiaDiemDuLich";

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
                BinhLuanDTO BinhLuanDTO = new BinhLuanDTO();
                BinhLuanDTO = (BinhLuanDTO)GetDataFromDataRow(dataTable, i);
                ds.Add(BinhLuanDTO);
            }
            disconnect();
            return ds;

        }

        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            BinhLuanDTO item = new BinhLuanDTO();
            item.MaBinhLuan = Convert.ToInt32(dt.Rows[i]["MaBinhLuan"].ToString());
            item.NoiDung = dt.Rows[i]["NoiDung"].ToString();
            return item;
        }
    }
}
