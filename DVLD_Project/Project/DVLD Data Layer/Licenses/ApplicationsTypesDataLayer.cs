using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DVLD_Data_Layer
{
    public class ApplicationsTypesDataLayer
    {

        static public bool Find(int Id, ref string Title, ref decimal Fees)
        {
            bool Found = false;

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string query = @"select * from ApplicationTypes where TypeId = @Id";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@Id", Id);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    Title = (string)reader["TypeTitle"];
                    Fees = (decimal)reader["Fees"];
                }

                reader.Close();
                Found = true;
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return Found;
        }

        static public DataTable GetAllApplicationsTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string query = @"select * from ApplicationTypes";

            SqlCommand cmd = new SqlCommand(query, connection);


            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) {
                    dt.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return dt;
        }

        static public bool Update(int Id, string Title, decimal Fees)
        {
            bool Updated = false;

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string query = @"Update ApplicationTypes 
                 Set TypeTitle = @Title, Fees = @Fees 
                 Where TypeId = @Id";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@Title", Title);
            cmd.Parameters.AddWithValue("@Fees", Fees);

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
