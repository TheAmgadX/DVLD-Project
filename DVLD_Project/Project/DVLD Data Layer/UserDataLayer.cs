using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Data_Layer
{
    public class UsersDataLayer
    {
        static public bool Find(int Id, ref int PersonId, ref string UserName, ref string Password,
            ref bool IsActive)
        {
            bool Found = false;

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string Query = @"Select * from Users where UserId = @Id";
            
            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@Id", Id);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    PersonId = (int)reader["PersonId"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];

                    IsActive = (bool)reader["IsActive"];

                    Found = true;
                }

                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return Found;
        }

        static public bool Find(ref int Id, ref int PersonId, string UserName, ref string Password,
        ref bool IsActive)
        {
            bool Found = false;

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string Query = @"Select * from Users where UserName = @UserName";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PersonId = (int)reader["PersonId"];
                    Id = (int)reader["UserId"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];

                    Found = true;
                }

                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return Found;
        }

        static public bool Find(ref int Id, ref int PersonId, string UserName, string Password,
            ref bool IsActive)
        {
            bool Found = false;

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string Query = @"Select * from Users where UserName = @UserName and Password = @Password";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Id = Convert.ToInt32(reader["UserId"]);
                    PersonId = (int)reader["PersonId"];
                    IsActive = (bool)reader["IsActive"];

                    Found = true;
                }

                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return Found;
        }

        static public bool Find(ref int Id, int PersonId, ref string UserName,ref string Password,
            ref bool IsActive)
        {
            bool Found = false;

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string Query = @"Select * from Users where PersonId = @PersonId";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@PersonId", PersonId);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Id = (int)reader["UserId"];
                    Password = (string)reader["Password"];
                    UserName = (string)reader["UserName"];
                    IsActive = (bool)reader["IsActive"];

                    Found = true;
                }

                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return Found;
        }
        static public DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string Query = "Select * from UsersWithFullName";

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

        static public bool AddNewUser(int PersonId, string Username, string Password, bool IsActive)
        {
            bool Added = false;

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);
            
            string Query = @"Insert into Users values (@PersonId, @Username, @Password, @IsActive)";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@PersonId", PersonId);
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();

                int rows = cmd.ExecuteNonQuery();

                if(rows > 0)
                    Added = true;

            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return Added;
        }

        static public bool UpdateUser(int Id, int PersonId, string Username, string Password, bool IsActive)
        {
            bool Updated = false;

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string Query = @"UPDATE Users 
                     SET PersonId = @PersonId, 
                         Username = @Username, 
                         Password = @Password, 
                         isActive = @IsActive 
                     WHERE UserId = @Id";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@PersonId", PersonId);
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    Updated = true;
            }
            catch (Exception ex)
            {
                // Handle the exception here if needed, like logging the error
            }
            finally
            {
                connection.Close();
            }

            return Updated;
        }

        static public DataTable SearchWithUserId(int UserId)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string Query = "Select * from UsersWithFullName where UserId = @UserId";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@UserId", UserId);

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

        static public DataTable SearchWithUsername(string Username)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string Query = "Select * from UsersWithFullName where UserName like '" + Username + "%'";

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

        static public DataTable SearchWithFullName(string FullName)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string Query = "Select * from UsersWithFullName where FullName like '%" + FullName + "%'";

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

        static public DataTable SearchWithIsActive(bool IsActive)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string Query = "Select * from UsersWithFullName where IsActive = @IsActive";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@IsActive", IsActive);

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

    }
}
