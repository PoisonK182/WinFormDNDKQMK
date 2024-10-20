using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FORMDNDK
{
    class Modify
    {
        public Modify()
        {
        }
        SqlCommand? sqlCommand;
        SqlDataReader? dataReader;

        public List<TaiKhoan> TaiKhoans(string query)
        {
            List<TaiKhoan> TaiKhoans = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    TaiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1)));

                }
                sqlConnection.Close();
            }
            return TaiKhoans;
        }
        public void command(string query)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand (query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
}