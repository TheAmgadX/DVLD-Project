using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Data_Layer
{
    public class CountriesDataLayer
    {
        static public DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string Query = "Select * from Countries";

            SqlCommand command = new SqlCommand(Query, connection);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }

            catch { }
            finally { connection.Close(); }


            return dt;
        }

        static public string GetCountryName(int CountryId)
        {
            string CountryName = "";

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string Query = "Select CountryName from Countries where CountryId = @CountryId";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CountryId", CountryId);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    CountryName = reader["CountryName"].ToString();
                }

                reader.Close();
            }

            catch { }
            finally { connection.Close(); }


            return CountryName;
        }
    }
}
