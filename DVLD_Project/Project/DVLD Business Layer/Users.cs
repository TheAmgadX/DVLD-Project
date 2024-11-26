using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Data_Layer;

namespace DVLD_Business_Layer
{
    public class Users
    {
        private bool _AddNewUser()
        {
            return UsersDataLayer.AddNewUser(PersonId, UserName, Password, IsActive);
        }

        private bool _UpdateUser()
        {
            return UsersDataLayer.UpdateUser(UserId, PersonId, UserName, Password, IsActive);

        }

        public int UserId { get; set; }
        public int PersonId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public enum enMode { AddNew, Update }

        public enMode Mode;

        public Person person = new Person();

        public Users()
        {
            UserId = -1;
            PersonId = -1;
            UserName = "";
            Password = "";
            IsActive = false;
            Mode = enMode.AddNew;
        }

        // This constructor is used in Global Data Class Which Deal With Login History .txt File.
        public Users(string UserName, string Password)
        {
            this.UserName = UserName;
            this.Password = Password;
        }

        private Users(int UserId, int PersonId, string UserName, string Password, bool IsActive)
        {
            this.UserId = UserId;
            this.PersonId = PersonId;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;

            person = Person.Find(PersonId);

            Mode = enMode.Update;
        }
        static public Users Find(int userId)
        {
            int personId = -1;
            string userName = "";
            string password = "";
            bool isActive = false;


            if(UsersDataLayer.Find(userId, ref personId, ref userName, ref password, ref isActive))
            {
                return new Users(userId, personId, userName, password, isActive);
            }


            return null;
        }
        static public Users FindWithPersonId(int personId)
        {
            int userId = -1;
            string userName = "";
            string password = "";
            bool isActive = false;


            if (UsersDataLayer.Find(ref userId, personId, ref userName, ref password, ref isActive))
            {
                return new Users(userId, personId, userName, password, isActive);
            }


            return null;
        }
        static public Users Find(string userName)
        {
            int personId = -1;
            int userId = -1;
            string password = "";
            bool isActive = false;


            if (UsersDataLayer.Find(ref userId, ref personId, userName, ref password, ref isActive))
            {
                return new Users(userId, personId, userName, password, isActive);
            }


            return null;
        }
        static public Users Find(string userName, string password)
        {
            int personId = -1;
            int userId = -1;
            bool isActive = false;


            if (UsersDataLayer.Find(ref userId, ref personId, userName, password, ref isActive))
            {
                return new Users(userId, personId, userName, password, isActive);
            }

            return null;
        }
        static public DataTable GetAllUsers()
        {
            return UsersDataLayer.GetAllUsers();
        }

        static public DataTable SearchWithUserId(int UserId)
        {
            return UsersDataLayer.SearchWithUserId(UserId);
        }

        static public DataTable SearchWithUsername(string Username)
        {
            return UsersDataLayer.SearchWithUsername(Username);
        }

        static public DataTable SearchWithFullName(string FullName)
        {
            return UsersDataLayer.SearchWithFullName(FullName);
        }

        static public DataTable SearchWithIsActive(bool IsActive = true)
        {
            return UsersDataLayer.SearchWithIsActive(IsActive);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        // To Avoid Adding this Object Again.
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateUser();
            }

            return false;
        }
    }
}
