using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AirplaneHotelBooking.DTO;
using System.Data.SqlClient;
using System.Data;

namespace AirplaneHotelBooking.DAO
{
    class KhachSanDAO:DataProvider
    {
        protected override object GetDataFromDataRow(System.Data.DataTable dt, int i)
        {
            KhachSanDTO item = new KhachSanDTO();
            item.MaKS = Convert.ToInt32(dt.Rows[i]["MaKS"].ToString());
            item.ThongTinDVu = dt.Rows[i]["ThongTinDichVu"].ToString();
            item.TenKS = dt.Rows[i]["TenKS"].ToString();
            item.SoNha = dt.Rows[i]["SoNha"].ToString();
            item.Duong = dt.Rows[i]["Duong"].ToString();
            item.MaDDDL = Convert.ToInt32(dt.Rows[i]["MaDDDL"].ToString());           
            return item;
        }

        public int getTongSoRecord()
        {
            connect();
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_TongSoLuongKhachSan";

            paramater = new SqlParameter("Count", SqlDbType.Int, 4);
            paramater.Direction = ParameterDirection.Output;
            command.Parameters.Add(paramater);

            command.ExecuteNonQuery();
            int result = (int)command.Parameters["Count"].Value;
            disconnect();
            return result;
        }

        public List<KhachSanDTO> getDanhSachKhachSan1(int MaDDDL)
        {
            connect();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet dataset = new DataSet();
            List<KhachSanDTO> ds = new List<KhachSanDTO>();

            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_DSKhachSan_DiaDiemDuLich";

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
                KhachSanDTO KhachSanDTO = new KhachSanDTO();
                KhachSanDTO = (KhachSanDTO)GetDataFromDataRow(dataTable, i);
                ds.Add(KhachSanDTO);
            }
            disconnect();
            return ds;
        }


        public List<KhachSanDTO> getDanhSachKhachSan(int iPage, int numberItem)
        {
            connect();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet dataset = new DataSet();
            List<KhachSanDTO> ds = new List<KhachSanDTO>();

            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_DanhSachKhachSanPhanTrang";

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
                KhachSanDTO KhachSanDTO = new DTO.KhachSanDTO();
                KhachSanDTO = (KhachSanDTO)GetDataFromDataRow(dataTable, i);
                ds.Add(KhachSanDTO);
            }
            disconnect();
            return ds;
        }

        public List<KhachSanDTO> TimKiemKhachSan(string TenKS, string TenDDDL, int iPage, int numberItem)
        {
            connect();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet dataset = new DataSet();
            List<KhachSanDTO> ds = new List<KhachSanDTO>();

            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_TimKiemKhachSan";

            paramater = new SqlParameter("Start", SqlDbType.Int, 4);
            paramater.Direction = ParameterDirection.Input;
            paramater.Value = (iPage - 1) * numberItem;
            command.Parameters.Add(paramater);

            paramater = new SqlParameter("End", SqlDbType.Int, 4);
            paramater.Direction = ParameterDirection.Input;
            paramater.Value = iPage * numberItem;
            command.Parameters.Add(paramater);

            paramater = new SqlParameter("TenKS", SqlDbType.NVarChar);
            paramater.Direction = ParameterDirection.Input;
            paramater.Value = TenKS;
            command.Parameters.Add(paramater);

            paramater = new SqlParameter("TenDDDL", SqlDbType.NVarChar);
            paramater.Direction = ParameterDirection.Input;
            if (TenDDDL == null)
                paramater.Value = "";
            else
                paramater.Value = TenDDDL;

            command.Parameters.Add(paramater);

            da.SelectCommand = command;
            da.Fill(dataset);

            DataTable dataTable = dataset.Tables[0];
            int n = dataTable.Rows.Count;
            for (int i = 0; i < n; i++)
            {
                KhachSanDTO KhachSanDTO = new DTO.KhachSanDTO();
                KhachSanDTO = (KhachSanDTO)GetDataFromDataRow(dataTable, i);
                ds.Add(KhachSanDTO);
            }
            disconnect();
            return ds;
        }

        public int getTongSeRecordKetQuaTimKiemKhachSan(string TenKS, string TenDDDL)
        {
            connect();
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_TimKiemKhachSan_TongSoRecord";

            paramater = new SqlParameter("TenKS", SqlDbType.NVarChar);
            paramater.Direction = ParameterDirection.Input;
            paramater.Value = TenKS;
            command.Parameters.Add(paramater);

            paramater = new SqlParameter("TenDDDL", SqlDbType.NVarChar);
            paramater.Direction = ParameterDirection.Input;
            if (TenDDDL == null)
                paramater.Value = "";
            else
                paramater.Value = TenDDDL;
            command.Parameters.Add(paramater);

            paramater = new SqlParameter("Count", SqlDbType.Int, 4);
            paramater.Direction = ParameterDirection.Output;
            command.Parameters.Add(paramater);

            command.ExecuteNonQuery();
            int result = (int)command.Parameters["Count"].Value;
            disconnect();
            return result;
        }

    }
}
