using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AirplaneHotelBooking.DTO;
using System.Data;
using System.Data.SqlClient;

namespace AirplaneHotelBooking.DAO
{
    class ChuyenBayDAO:DataProvider
    {
        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            ChuyenBayDTO itemCB = new ChuyenBayDTO();
            itemCB.MaCB = Convert.ToInt32(dt.Rows[i]["MaCB"].ToString());
            itemCB.DiaDiemDi = Convert.ToInt32(dt.Rows[i]["DiaDiemDi"].ToString());
            itemCB.DiaDiemDen = Convert.ToInt32(dt.Rows[i]["DiaDiemDen"].ToString());
            itemCB.GioBay = DateTime.Parse(dt.Rows[i]["GioBay"].ToString());
            try
            {
                itemCB.NgayBay = (DateTime)(dt.Rows[i]["NgayBay"]);
            }
            catch (Exception ex)
            { }
            itemCB.HangMayBay = dt.Rows[i]["HangMayBay"].ToString();
            itemCB.ThongTinDVu = dt.Rows[i]["ThongTinDVu"].ToString();
            try
            {
                itemCB.NoiDi = dt.Rows[i]["NoiDi"].ToString();
            }
            catch (Exception ex)
            { }
            try
            {
                itemCB.NoiDen = dt.Rows[i]["NoiDen"].ToString();
            }
            catch (Exception ex)
            { }

            return itemCB;
        }

        public int getTongSoRecord()
        {
            connect();
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_TongSoLuongChuyenBay";

            paramater = new SqlParameter("Count", SqlDbType.Int, 4);
            paramater.Direction = ParameterDirection.Output;
            command.Parameters.Add(paramater);

            command.ExecuteNonQuery();
            int result = (int)command.Parameters["Count"].Value;
            disconnect();
            return result;
        }

        public List<ChuyenBayDTO> getDanhSachChuyenBay(int iPage, int numberItem)
        {
            connect();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet dataset = new DataSet();
            List<ChuyenBayDTO> ds = new List<ChuyenBayDTO>();

            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_DanhSachChuyenBayPhanTrang";

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
                ChuyenBayDTO ChuyenBayDTO = new DTO.ChuyenBayDTO();
                ChuyenBayDTO = (ChuyenBayDTO)GetDataFromDataRow(dataTable, i);
                ds.Add(ChuyenBayDTO);
            }
            disconnect();
            return ds;

        }

        public List<ChuyenBayDTO> getDanhSachChuyenBay_DDDL(int iPage, int numberItem)
        {
            connect();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet dataset = new DataSet();
            List<ChuyenBayDTO> ds = new List<ChuyenBayDTO>();

            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_DanhSachChuyenBayPhanTrang";

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
                ChuyenBayDTO ChuyenBayDTO = new DTO.ChuyenBayDTO();
                ChuyenBayDTO = (ChuyenBayDTO)GetDataFromDataRow(dataTable, i);
                ds.Add(ChuyenBayDTO);
            }
            disconnect();
            return ds;

        }

        public List<ChuyenBayDTO> TimKiemChuyenBay(string NoiDen, int MaCB, DateTime NgayBay)
        {
            return null;
        }
        public List<ChuyenBayDTO> SapXepChuyenBay()
        {

            return null;
        }

        public List<ChuyenBayDTO> getDanhSachChuyenBay(int MaDDDL)
        {
            connect();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet dataset = new DataSet();
            List<ChuyenBayDTO> ds = new List<ChuyenBayDTO>();

            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_DSChuyenBay_DiaDiemDuLich";

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
                ChuyenBayDTO ChuyenBayDTO = new ChuyenBayDTO();
                ChuyenBayDTO = (ChuyenBayDTO)GetDataFromDataRow(dataTable, i);                
                ds.Add(ChuyenBayDTO);
            }
            disconnect();
            return ds;

        }
    }
}
