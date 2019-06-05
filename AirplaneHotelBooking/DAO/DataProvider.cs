using System;
using System.Data.OleDb;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace AirplaneHotelBooking.DAO
{
    public class DataProvider
    {
        //protected static string _connectionString = @"Data Source=1.53.62.94;Initial Catalog=CSDLNC_IVIVU;user=sa;password=sa";
        //protected static string _connectionString = @"Data Source=1.53.62.94;Initial Catalog=CSDLNC_IVIVU;user=sa;password=sa";
        //protected static string _connectionString = @"Data Source=MINHDUONG-PC;Initial Catalog=CSDLNC_IVIVU;Integrated Security=True";
        //protected static string _connectionString = @"Data Source=MINHDUONG-PC;Initial Catalog=CSDLNC_IVIVU;Integrated Security=True";

        protected static string _connectionString = @"Data Source=localhost;Initial Catalog=CSDLNC_IVIVU;Integrated Security=True";
        //protected static string _connectionString = @"Data Source=MINHDUONG-PC;Initial Catalog=CSDLNC_IVIVU;Integrated Security=True";
        public SqlConnection connection;
        protected SqlDataAdapter adapter;
        protected SqlCommand command;
        protected SqlParameter paramater;

        public static string ConnectionString
        {
            get
            {
                return _connectionString;
            }
            set
            {
                _connectionString = value;
            }
        }

        public void connect()
        {
            connection = new SqlConnection(ConnectionString);
            connection.Open();
        }

        public void disconnect()
        {
            connection.Close();
        }

        public IDataReader executeQuery(string sqlString)
        {
            command = new SqlCommand(sqlString, connection);
            return command.ExecuteReader();
        }

        
        public void executeNonQuery(string sqlString)
        {
            command = new SqlCommand(sqlString, connection);
            command.ExecuteNonQuery();
        }

        public object executeScalar(string sqlString)
        {
            command = new SqlCommand(sqlString, connection);
            return command.ExecuteScalar();
        }

        protected ArrayList ConvertDataSetToArrayList(DataSet dataset)
        {
            ArrayList arr = new ArrayList();
            DataTable dt = dataset.Tables[0];
            int i, n = dt.Rows.Count;
            for (i = 0; i < n; i++)
            {
                object obj = GetDataFromDataRow(dt, i);
                arr.Add(obj);
            }
            return arr;
        }

        protected virtual object GetDataFromDataRow(DataTable dt, int i)
        {

            return null;
        }
    }
}