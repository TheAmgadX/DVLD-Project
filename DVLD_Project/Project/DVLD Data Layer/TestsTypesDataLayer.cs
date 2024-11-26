using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Data_Layer
{
    public class TestsTypesDataLayer
    {
        static public bool Find(int Id, ref string Title, ref decimal Fees, ref string Description)
        {
            bool Found = false;

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string query = @"select * from TestsTypes where TypeId = @Id";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@Id", Id);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Title = (string)reader["Title"];
                    Fees = (decimal)reader["Fees"];
                    Description = (string)reader["Description"];
                }

                reader.Close();
                Found = true;
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return Found;
        }

        static public DataTable GetAllTestsTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string query = @"select * from TestsTypes";

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
            catch (Exception ex) { }
            finally { connection.Close(); }

            return dt;
        }

        static public bool Update(int Id, string Title, decimal Fees, string Description)
        {
            bool Updated = false;

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string query = @"Update TestsTypes 
                 Set Title = @Title, Fees = @Fees , Description = @Description
                 Where TypeId = @Id";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@Title", Title);
            cmd.Parameters.AddWithValue("@Fees", Fees);
            cmd.Parameters.AddWithValue("@Description", Description);

            try
            {
                connection.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    Updated = true;
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return Updated;
        }
    }
}
