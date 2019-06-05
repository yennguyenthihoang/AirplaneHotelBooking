using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AirplaneHotelBooking.DTO;
using System.Data;
using System.Data.SqlClient;

namespace AirplaneHotelBooking.DAO
{
    class DiaDiemDuLichDAO:DataProvider
    {

        protected override object GetDataFromDataRow(DataTable dt, int i)
        {
            DiaDiemDuLichDTO itemDDDL = new DiaDiemDuLichDTO();
            itemDDDL.MaDDDL = Convert.ToInt32(dt.Rows[i]["MaDDDL"].ToString());
            itemDDDL.TenDDDL = dt.Rows[i]["TenDDDL"].ToString();
            itemDDDL.MoTa = dt.Rows[i]["MoTa"].ToString();
            itemDDDL.HinhAnh = dt.Rows[i]["HinhAnh"].ToString();
            itemDDDL.ThanhPho = dt.Rows[i]["ThanhPho"].ToString();
            itemDDDL.Vung = dt.Rows[i]["Vung"].ToString();
            itemDDDL.QuocGia = dt.Rows[i]["QuocGia"].ToString();
            itemDDDL.LoaiDDDL = Convert.ToInt32(dt.Rows[i]["LoaiDDDL"].ToString());
            try
            {
                itemDDDL.NgayCapNhat=(DateTime)dt.Rows[i]["NgayCapNhap"];
            }
            catch (Exception ex)
            {
                
            }

    
            return itemDDDL;
        }

        public int getTongSoRecord()
        {
            connect();
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_TongSoLuongDiaDiemDuDich";

            paramater = new SqlParameter("Count", SqlDbType.Int, 4);
            paramater.Direction = ParameterDirection.Output;
            command.Parameters.Add(paramater);

            command.ExecuteNonQuery();
            int result = (int)command.Parameters["Count"].Value;
            disconnect();
            return result;
        }

        public List<DiaDiemDuLichDTO> getDanhSachDiaDiemDuLich(int iPage, int numberItem)
        {
            connect();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet dataset = new DataSet();
            List<DiaDiemDuLichDTO> ds = new List<DiaDiemDuLichDTO>();

            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_DanhSachDiaDiemDuLichPhanTrang";

            paramater = new SqlParameter("Start", SqlDbType.Int, 4);
            paramater.Direction = ParameterDirection.Input;
            paramater.Value=(iPage-1)*numberItem;
            command.Parameters.Add(paramater);

            paramater = new SqlParameter("End", SqlDbType.Int, 4);
            paramater.Direction = ParameterDirection.Input;
            paramater.Value = iPage*numberItem;
            command.Parameters.Add(paramater);
            
            da.SelectCommand = command;
            da.Fill(dataset);

            DataTable dataTable = dataset.Tables[0];
            int n = dataTable.Rows.Count;
            for (int i = 0; i < n; i++)
            {
                DiaDiemDuLichDTO DiaDiemDuLichDTO = new DTO.DiaDiemDuLichDTO();
                DiaDiemDuLichDTO = (DiaDiemDuLichDTO)GetDataFromDataRow(dataTable, i);
                ds.Add(DiaDiemDuLichDTO);
            }
            disconnect();
            return ds;

        }

        public List<DiaDiemDuLichDTO> TimKiemDiaDiemDuLich(string QuocGia, string Vung, string ThanhPho, int iPage, int numberItem)
        {
            connect();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet dataset = new DataSet();
            List<DiaDiemDuLichDTO> ds = new List<DiaDiemDuLichDTO>();

            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_TimKiemDiaDiemDuLich";

            paramater = new SqlParameter("Start", SqlDbType.Int, 4);
            paramater.Direction = ParameterDirection.Input;
            paramater.Value = (iPage - 1) * numberItem;
            command.Parameters.Add(paramater);

            paramater = new SqlParameter("End", SqlDbType.Int, 4);
            paramater.Direction = ParameterDirection.Input;
            paramater.Value = iPage * numberItem;
            command.Parameters.Add(paramater);

            paramater = new SqlParameter("QuocGia", SqlDbType.NVarChar);
            paramater.Direction = ParameterDirection.Input;
            paramater.Value = QuocGia;
            command.Parameters.Add(paramater);

            paramater = new SqlParameter("Vung", SqlDbType.NVarChar);
            paramater.Direction = ParameterDirection.Input;
            if (Vung == null)
                paramater.Value = "";
            else
                paramater.Value = Vung;

            command.Parameters.Add(paramater);

            paramater = new SqlParameter("ThanhPho", SqlDbType.NVarChar);
            paramater.Direction = ParameterDirection.Input;
            paramater.Value = ThanhPho;
            command.Parameters.Add(paramater);

            da.SelectCommand = command;
            da.Fill(dataset);

            DataTable dataTable = dataset.Tables[0];
            int n = dataTable.Rows.Count;
            for (int i = 0; i < n; i++)
            {
                DiaDiemDuLichDTO DiaDiemDuLichDTO = new DTO.DiaDiemDuLichDTO();
                DiaDiemDuLichDTO = (DiaDiemDuLichDTO)GetDataFromDataRow(dataTable, i);
                ds.Add(DiaDiemDuLichDTO);
            }
            disconnect();
            return ds;
            
        }

        public int getTongSeRecordKetQuaTimKiemDDDL(string QuocGia, string Vung, string ThanhPho)
        {
            connect();
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_TimKiemDiaDiemDuLich_TongSoRecord";

            paramater = new SqlParameter("QuocGia", SqlDbType.NVarChar);
            paramater.Direction = ParameterDirection.Input;
            paramater.Value = QuocGia;
            command.Parameters.Add(paramater);

            paramater = new SqlParameter("Vung", SqlDbType.NVarChar);
            paramater.Direction = ParameterDirection.Input;
            if(Vung==null)
                paramater.Value = "";
            else
                paramater.Value = Vung;
            command.Parameters.Add(paramater);

            paramater = new SqlParameter("ThanhPho", SqlDbType.NVarChar);
            paramater.Direction = ParameterDirection.Input;
            paramater.Value = ThanhPho;
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
