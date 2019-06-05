using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AirplaneHotelBooking.DTO;
using System.Data;
using System.Data.SqlClient;

namespace AirplaneHotelBooking.DAO
{
    class PhongDAO:DataProvider
    {

        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            PhongDTO itemPhong = new PhongDTO();
            itemPhong.MaPhong = Convert.ToInt32(dt.Rows[i]["MaPhong"].ToString());
            itemPhong.TenPhong = dt.Rows[i]["TenPhong"].ToString();
            itemPhong.MaKS = Convert.ToInt32(dt.Rows[i]["MaKS"].ToString());
            itemPhong.Gia = Convert.ToInt32(dt.Rows[i]["Gia"].ToString());
            itemPhong.SoNguoiToiDa = Convert.ToInt32(dt.Rows[i]["SoNguoiToiDa"].ToString());
            itemPhong.TrangThai = Convert.ToBoolean(dt.Rows[i]["TrangThai"].ToString());
            itemPhong.KhuyenMai = dt.Rows[i]["KhuyenMai"].ToString();
            itemPhong.LoaiPhong = dt.Rows[i]["LoaiPhong"].ToString();
            
            return itemPhong;
        }

        public int getTongSoRecord()
        {
            connect();
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_TongSoLuongPhong";

            paramater = new SqlParameter("Count", SqlDbType.Int, 4);
            paramater.Direction = ParameterDirection.Output;
            command.Parameters.Add(paramater);

            command.ExecuteNonQuery();
            int result = (int)command.Parameters["Count"].Value;
            disconnect();
            return result;
        }

        public List<PhongDTO> getDanhSachPhong_DDDL(int iPage, int numberItem)
        {
            connect();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet dataset = new DataSet();
            List<PhongDTO> ds = new List<PhongDTO>();

            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_DanhSachPhongPhanTrang";

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
                PhongDTO PhongDTO = new DTO.PhongDTO();
                PhongDTO = (PhongDTO)GetDataFromDataRow(dataTable, i);
                ds.Add(PhongDTO);
            }
            disconnect();
            return ds;

        }

        public List<PhongDTO> getDanhSachPhong(int iPage, int numberItem)
        {
            connect();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet dataset = new DataSet();
            List<PhongDTO> ds = new List<PhongDTO>();

            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_DanhSachPhongPhanTrang";

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
                PhongDTO PhongDTO = new DTO.PhongDTO();
                PhongDTO = (PhongDTO)GetDataFromDataRow(dataTable, i);
                ds.Add(PhongDTO);
            }
            disconnect();
            return ds;
        }

        public List<PhongDTO> TimKiemPhong(double Giatu, double Giaden, int MaPhong, bool KhuyenMai, bool DaDuocDat)
        {
            return null;
        }
    }
}
