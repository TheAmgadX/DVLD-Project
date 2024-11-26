using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Data_Layer.Licenses
{
    public class LicenseClassesDataLayer
    {
        static public DataTable GetAllLicenseClasses()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string query = @"select * from LicensesClasses";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

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

        static public bool Search(int Id, ref string className, ref string description,
            ref int minAllowedAge, ref int validityLength, ref int fees)
        {
            bool Found = false;

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string query = @"select * from LicensesClasses where ClassId = @Id";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Id", Id);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    className = (string)reader["ClassName"];
                    description = (string)reader["ClassDescription"];
                    minAllowedAge = (int)reader["MinAllowedAge"];
                    validityLength = (int)reader["ValidityLength"];
                    fees = (int)reader["Fees"];

                    Found = true;
                }

                reader.Close();
            }
            catch { }
            finally { connection.Close(); }

            return Found;
        }

        static public bool Search(ref int Id, string className, ref string description,
            ref int minAllowedAge, ref int validityLength, ref int fees)
        {
            bool Found = false;

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string query = @"select * from LicensesClasses where ClassName = @className";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@className", className);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Id = (int)reader["ClassId"];

                    if (reader["ClassDescription"] == DBNull.Value)
                        description = null;
                    else
                        description = (string)reader["ClassDescription"];

                    minAllowedAge = (int)reader["MinAllowedAge"];
                    validityLength = (int)reader["ValidityLength"];
                    fees = (int)reader["Fees"];

                    Found = true;
                }

                reader.Close();
            }
            catch { }
            finally { connection.Close(); }

            return Found;
        }
    }
}
