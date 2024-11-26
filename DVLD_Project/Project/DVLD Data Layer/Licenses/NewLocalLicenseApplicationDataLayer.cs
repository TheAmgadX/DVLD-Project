using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Data_Layer
{
    public class NewLocalLicenseApplicationDataLayer
    {
        /*
            Update Application
            Find Application 
                *with Id
	            *with National Number
	            *with Full Name
                *with Status 
                
            Cancel Application 
            delete Application
        */

        static public bool Find(int AppId, ref string ClassName, ref string NationalNum, ref string FullName,
            ref DateTime AppDate, ref int PassedTests, ref string Status)

        {
            bool found = false;

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string query = @"select * from LocalDrivingLicensesApplication where ApplicationId = @AppId";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@AppId", AppId);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    ClassName = (string)reader["Driving_Class"];
                    NationalNum = (string)reader["NationalNum"];
                    FullName = (string)reader["FullName"];
                    AppDate = (DateTime)reader["ApplicationDate"];
                    PassedTests = (int)reader["PassedTests"];
                    Status = (string)reader["Status"];

                    found = true;
                }

                reader.Close();
            }
            catch { Exception ex; }
            finally { connection.Close(); }

            return found;
        }

        static public bool ExistsMoreThanNewApplicationOfTheSameClass(string NationalNum, string ClassName)
        {
            bool Exist = false;

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string query = @"select Count(*) from LocalDrivingLicensesApplication where 
                            Driving_Class = @ClassName and
                            NationalNum = @NationalNum and Status = 'New'";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@NationalNum", NationalNum);
            cmd.Parameters.AddWithValue("@ClassName", ClassName);

            try
            {
                connection.Open();
                int count = (int) cmd.ExecuteScalar();

                if(count > 0)
                    Exist = true;
            
            }
            catch { Exception ex; }
            finally { connection.Close(); }

            return Exist;
        }
        static public DataTable SearchWithFilter(string Field, string Value)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string Query = "Select * from LocalDrivingLicensesApplication where " + Field + " Like '%" + Value
                + "%'";

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

        static public bool Update(int Id, string DrivingClass, string Status)
        {
            bool Updated = false;

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string query = @"update LocalDrivingLicensesApplication set
                    Driving_Class = @DrivingClass,
                    Status = @Status
                    where ApplicationId = @Id";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@DrivingClass", DrivingClass);
            cmd.Parameters.AddWithValue("@Status", Status);

            try
            {
                connection.Open();

                int AffectedRows = cmd.ExecuteNonQuery();

                if (AffectedRows > 0)
                    Updated = true;
                
            }
            catch { Exception ex; }
            finally { connection.Close(); }

            return Updated;
        }

        static public bool CancelApplication(int Id)
        {
            bool Cancelled = false;

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string query = @"update Applications set
                    Status = 'Cancelled'
                    where ApplicationId = @Id";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Id", Id);


            try
            {
                connection.Open();

                int AffectedRows = cmd.ExecuteNonQuery();

                if (AffectedRows > 0)
                    Cancelled = true;

            }
            catch { }
            finally { connection.Close(); }

            return Cancelled;
        }

        static public bool Delete(int Id)
        {
            bool Deleted = false;

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string query = @" delete from LocalLicenseApplications where ApplicationId = @Id;
                            delete from Applications 
                            where ApplicationId = @Id";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Id", Id);

            try
            {
                connection.Open();

                int AffectedRows = cmd.ExecuteNonQuery();

                if (AffectedRows > 0)
                    Deleted = true;

            }
            catch { Exception ex; }
            finally { connection.Close(); }

            return Deleted;
        }

        static public bool AddNewApplication(int Id, int classId, DateTime AppDate,
            string Status, int UserId)
        {
            bool Added = false;
            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);
               
            // Applications --> AppId, PersonId, TypeId, Date, Status, Fees, UserId, LastStatusDate.
            string query1 = @"INSERT INTO Applications 
                        VALUES (@Id, 1, @AppDate, @Status, 15, @UserId, @AppDate);
                        select SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query1, connection);


            // Add parameters to the command
            command.Parameters.AddWithValue("@Id", Id);
            command.Parameters.AddWithValue("@AppDate", AppDate);
            command.Parameters.AddWithValue("@UserId", UserId);
            command.Parameters.AddWithValue("@Status", Status);

            object ApplicationId = null;

            try
            {
                connection.Open();
                
                ApplicationId = command.ExecuteScalar();

                if(ApplicationId != null)
                    Added = true;
                
            }
            catch { }
            finally { connection.Close(); }

            string query2 = @"insert into LocalLicenseApplications 
                            values(@ApplicationId, @classId)";

            SqlCommand command2 = new SqlCommand(query2, connection);
            command2.Parameters.AddWithValue("@ApplicationId", ApplicationId);
            command2.Parameters.AddWithValue("@classId", classId);

            try
            {
                connection.Open();

                int i = command2.ExecuteNonQuery();

                // if not inserted the Added will be false if inserted Added already true
                if (i == 0)
                    Added = false; 

            }
            catch { }
            finally { connection.Close(); }

            return Added;
        }

        static public DataTable GetAllApplications()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(DataConnectionSettings.ConnectionString);

            string query = @"select * from LocalDrivingLicensesApplication";

            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                    dt.Load(reader);

                reader.Close();
            }
            catch { }
            finally { conn.Close(); }

            return dt;
        }

    }
}
