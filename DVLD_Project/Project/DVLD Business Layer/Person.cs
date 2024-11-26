using System;
using System.Data;
using DVLD_Data_Layer; 

namespace DVLD_Business_Layer
{
    public class Person
    {
        // Private Methods...
        bool _AddNewPerson()
        {
            return PeopleDateLayer.AddNewPerson(NationalNum, FirstName, SecondName, ThirdName, LastName,
                BirthDate, Address, Email, Phone, CountryId, ImagePath, Gender);
        }
        
        bool _UpdatePerson()
        {
            return PeopleDateLayer.UpdatePerson(Id, NationalNum, FirstName, SecondName, ThirdName, LastName,
                BirthDate, Address, Email, Phone, CountryId, ImagePath, Gender);
        }

        // Atttibutes...
        public int Id { get; set; }
        public string NationalNum { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int CountryId { get; set; }
        public string ImagePath { get; set; }
        public string Gender { get; set; }

        public enum enMode { AddNew, Update }

        public enMode Mode;
        public Person()
        {
            Id = -1;
            NationalNum = "";
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            BirthDate = DateTime.Now;
            Phone = "";
            Email = "";
            Address = "";
            CountryId = -1;
            Gender = "";
            ImagePath = null;

            Mode = enMode.AddNew;
        }

        private Person(int id, string nationalNum, string firstName, string secondName, string thirdName,
            string lastName, DateTime birthDate, string address, string email,
            string phone, int countryId, string imagePath, string gender)
        {
            Id = id;
            NationalNum = nationalNum;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            BirthDate = birthDate;
            Address = address;
            Email = email;
            Phone = phone;
            CountryId = countryId;
            ImagePath = imagePath;
            Gender = gender;

            Mode = enMode.Update; // the mode will be update because if we used this constructor that means
            // that person saved in the database so any operations on that person will be updating or deleting.
        }

        // Methods
        static public Person Find(int Id)
        {
            string nationalNum = "";
            string firstName = "";
            string secondName = "";
            string thirdName = "";
            string lastName = "";
            DateTime birthDate = DateTime.Now;
            string address = "";
            string email = "";
            string phone = "";
            int countryId = -1;
            string imagePath = "";
            string gender = "";

            if (PeopleDateLayer.Find(Id, ref nationalNum, ref firstName, ref secondName, ref thirdName,
                ref lastName, ref birthDate, ref address, ref email, 
                ref phone, ref countryId, ref imagePath, ref gender))
            {
                return new Person(Id, nationalNum, firstName, secondName, thirdName,
                lastName, birthDate, address, email,
                phone, countryId, imagePath, gender);
            }

            return null;
        }
        static public Person Find(string NationalNumber)
        {
            int id = -1;
            string firstName = "";
            string secondName = "";
            string thirdName = "";
            string lastName = "";
            DateTime birthDate = DateTime.Now;
            string address = "";
            string email = "";
            string phone = "";
            int countryId = -1;
            string imagePath = "";
            string gender = "";

            if (PeopleDateLayer.Find(ref id, NationalNumber, ref firstName, ref secondName, ref thirdName,
                ref lastName, ref birthDate, ref address, ref email,
                ref phone, ref countryId, ref imagePath, ref gender))
            {
                return new Person(id, NationalNumber, firstName, secondName, thirdName,
                lastName, birthDate, address, email,
                phone, countryId, imagePath, gender);
            }

            return null;
        }
        static public DataTable GetAllPeople()
        {
            return PeopleDateLayer.GetAllPeople();
        }

        static public bool Delete(int Id)
        {
            return PeopleDateLayer.DeletePerson(Id);
        } 
        static public bool Delete(string NationalNumber)
        {
            return PeopleDateLayer.DeletePerson(NationalNumber);
        }
        static public DataTable SearchWithFilter(string Feild, string value)
        {
            return PeopleDateLayer.SearchWithFilter(Feild, value);
        }
        static public DataTable SearchWithId(int Id)
        {
            return PeopleDateLayer.SearchWithId(Id);
        }
        static public DataTable SearchWithNationalNum(string NationalNumber)
        {
            return PeopleDateLayer.SearchWithNationalNum(NationalNumber);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if(_AddNewPerson())
                    {
                        // To Avoid Adding this Object Again.
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdatePerson();
            }

            return false;
        }
    }

}
