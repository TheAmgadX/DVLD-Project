using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_Data_Layer
{
    public class PeopleDateLayer
    {

        static public bool Find(int Id, ref string nationalNum, ref string firstName, ref string secondName,
            ref string thirdName, ref string lastName, ref DateTime birthDate, ref string address,
            ref string email, ref string phone, ref int countryId, ref string imagePath, ref string gender)
        {
            bool Found = false;

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string Query = @"Select * from People where PersonId = @Id";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@Id", Id);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) {
                    nationalNum = reader["NationalNum"].ToString();
                    firstName = reader["FirstName"].ToString();
                    secondName = reader["SecondName"].ToString();
                    thirdName = reader["ThirdName"].ToString();
                    lastName = reader["LastName"].ToString();
                    birthDate = (DateTime)reader["BirthDate"];
                    address = reader["Address"].ToString();
                    email = reader["Email"].ToString();
                    phone = reader["Phone"].ToString();
                    countryId = (int)reader["CountryId"];
                    gender = (string)reader["Gender"];

                    if (reader["ImagePath"] == null)
                    {
                        imagePath = null;
                    }
                    else
                    {
                        imagePath = reader["ImagePath"].ToString();
                    }


                    Found = true;
                    reader.Close();
                }

            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return Found;
        }

        static public bool Find(ref int Id, string nationalNum, ref string firstName, ref string secondName,
            ref string thirdName, ref string lastName, ref DateTime birthDate, ref string address,
            ref string email, ref string phone, ref int countryId, ref string imagePath, ref string gender)
        {
            bool Found = false;

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string Query = @"Select * from People where NationalNum = @NationalNum";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@NationalNum", nationalNum);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Id = (int)reader["PersonId"];
                    firstName = reader["FirstName"].ToString();
                    secondName = reader["SecondName"].ToString();
                    thirdName = reader["ThirdName"].ToString();
                    lastName = reader["LastName"].ToString();
                    birthDate = (DateTime)reader["BirthDate"];
                    address = reader["Address"].ToString();
                    email = reader["Email"].ToString();
                    phone = reader["Phone"].ToString();
                    countryId = (int)reader["CountryId"];
                    gender = (string)reader["Gender"];

                    if (reader["ImagePath"] == null)
                    {
                        imagePath = null;
                    }
                    else
                    {
                        imagePath = reader["ImagePath"].ToString();
                    }


                    Found = true;
                    reader.Close();
                }

            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return Found;
        }

        static public bool AddNewPerson(string nationalNum, string firstName, string secondName,
            string thirdName, string lastName, DateTime birthDate, string address,
            string email, string phone, int countryId, string imagePath, string gender)
        {
            bool Added = false;

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string Query = @"INSERT INTO People (NationalNum, FirstName, SecondName, ThirdName,
                            LastName, BirthDate, Address, Email, Phone, CountryId, ImagePath, Gender)
                            VALUES (@nationalNum, @firstName, @secondName, @thirdName,
                            @lastName, @birthDate, @address, @email, @phone, @countryId, @imagePath, @gender)";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@nationalNum", nationalNum);
            command.Parameters.AddWithValue("@firstName", firstName);
            command.Parameters.AddWithValue("@secondName", secondName);
            command.Parameters.AddWithValue("@thirdName", thirdName);
            command.Parameters.AddWithValue("@lastName", lastName);
            command.Parameters.AddWithValue("@birthDate", birthDate);
            command.Parameters.AddWithValue("@address", address);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@countryId", countryId);
            command.Parameters.AddWithValue("@gender", gender);


            if (imagePath == null)
                command.Parameters.AddWithValue("@imagePath", DBNull.Value);
            else
                command.Parameters.AddWithValue("@imagePath", imagePath);


            try
            {
                connection.Open();

                int rows = command.ExecuteNonQuery();

                if (rows > 0)
                    Added = true;

            }
            catch { }
            finally { connection.Close(); }

            return Added;
        }

        static public bool UpdatePerson(int Id, string nationalNum, string firstName, string secondName,
            string thirdName, string lastName, DateTime birthDate, string address,
            string email, string phone, int countryId, string imagePath, string gender)
        {
            bool Updated = false;

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string Query = @"UPDATE People
                   SET  NationalNum = @nationalNum,
                        FirstName = @firstName, SecondName = @secondName,
                        ThirdName = @thirdName, LastName = @lastName,
                        BirthDate = @birthDate, Address = @address,
                        Email = @email, Phone = @phone,
                        CountryId = @countryId, ImagePath = @imagePath, Gender = @gender
                        WHERE PersonId = @Id";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@nationalNum", nationalNum);
            command.Parameters.AddWithValue("@firstName", firstName);
            command.Parameters.AddWithValue("@secondName", secondName);
            command.Parameters.AddWithValue("@thirdName", thirdName);
            command.Parameters.AddWithValue("@lastName", lastName);
            command.Parameters.AddWithValue("@birthDate", birthDate);
            command.Parameters.AddWithValue("@address", address);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@countryId", countryId);
            command.Parameters.AddWithValue("@gender", gender);
            command.Parameters.AddWithValue("@Id", Id);

            if (imagePath == null)
                command.Parameters.AddWithValue("@imagePath", DBNull.Value);
            else
                command.Parameters.AddWithValue("@imagePath", imagePath);

            try
            {
                connection.Open();

                int UpdatedRows = command.ExecuteNonQuery();

                if (UpdatedRows > 0)
                    Updated = true;

            }
            catch { }
            finally { connection.Close(); }

            return Updated;
        }

        static public DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string Query = "Select * from AllPeopleWithCountryName";

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

        static public bool DeletePerson(int Id)
        {
            bool Deleted = false;

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string Query = "Delete from People where PersonId = @Id";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Id", Id);

            try
            {
                connection.Open();
                int rows = command.ExecuteNonQuery();

                if (rows > 0)
                    Deleted = true;
            }

            catch { }
            finally { connection.Close(); }

            return Deleted;
        }
        static public bool DeletePerson(string NationalNum)
        {
            bool Deleted = false;

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string Query = "Delete from People where NationalNum = @NationalNum";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@NationalNum", NationalNum);

            try
            {
                connection.Open();
                int rows = command.ExecuteNonQuery();

                if (rows > 0)
                    Deleted = true;
            }

            catch { }
            finally { connection.Close(); }

            return Deleted;
        }

        static public DataTable SearchWithFilter(string Field, string Value)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string Query = "Select * from AllPeopleWithCountryName where " + Field + " Like '%" + Value 
                + "%'";

            SqlCommand command = new SqlCommand(Query, connection);
            //command.Parameters.AddWithValue("@Value", Value);

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
        static public DataTable SearchWithId(int Id)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string Query = "Select * from AllPeopleWithCountryName where PersonId = @Id";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Id", Id);

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
        static public DataTable SearchWithNationalNum(string NationalNum)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string Query = "Select * from AllPeopleWithCountryName where NationalNum = @NationalNum";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@NationalNum", NationalNum);

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
