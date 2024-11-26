using System;
using System.Data;
using System.Net;
using System.Security.Policy;
using DVLD_Business_Layer;

namespace Testing_Console_App
{
    internal class Testing
    {
        class Test
        {
            static public void PrintPerson(Person person)
            {
                Console.WriteLine(new string('-', 40)); // Separator line for readability
                Console.WriteLine($"ID: {person.Id}");
                Console.WriteLine($"National Number: {person.NationalNum}");
                Console.WriteLine($"First Name: {person.FirstName}");
                Console.WriteLine($"Second Name: {person.SecondName}");
                Console.WriteLine($"Third Name: {person.ThirdName}");
                Console.WriteLine($"Last Name: {person.LastName}");
                Console.WriteLine($"Birth Date: {person.BirthDate.ToShortDateString()}");
                Console.WriteLine($"Address: {person.Address}");
                Console.WriteLine($"Email: {person.Email}");
                Console.WriteLine($"Phone: {person.Phone}");
                Console.WriteLine($"Country ID: {person.CountryId}");
                Console.WriteLine($"Image Path: {person.ImagePath}");
                Console.WriteLine($"Gender: {person.Gender}");
                Console.WriteLine(new string('-', 40)); // Separator line for readability
            }
            static public void TestFindById(int id)
            {
                Person person = Person.Find(id);

                if (person != null)
                {
                    PrintPerson(person);
                }
                else
                {
                    Console.WriteLine($"Id: {id} Not Found!");
                }
            }
            static public void TestFindByNationalNumber(string NationalNum)
            {
                Person person = Person.Find(NationalNum);

                if (person != null)
                {
                    PrintPerson(person);
                }
                else
                {
                    Console.WriteLine($"National Number: {NationalNum} Not Found!");
                }
            }
            static public void AddNewPerson()
            {
                Person person = new Person();
                person.NationalNum = "N6";
                person.FirstName = "Omar";
                person.SecondName = "Amjad";
                person.ThirdName = "Deyaa";
                person.LastName = "Hamdy";
                person.BirthDate = DateTime.Now; 
                person.Address = "Los Angelos - California";
                person.Email = "LailaAmjad@gmail.com";
                person.Phone = "+105950595";
                person.CountryId = 185;
                person.ImagePath = null;
                person.Gender = "M";

                if (person.Save())
                {
                    Console.WriteLine("Laila Saved Successfully");
                }
                else
                {
                    Console.WriteLine("Saving Failed");
                }
            }
            static public void Update()
            {
                Person person = Person.Find("N4");
                person.NationalNum = "N4";
                person.FirstName = "Laila";
                person.SecondName = "Amjad";
                person.ThirdName = "Deyaa";
                person.LastName = "Emara";
                person.BirthDate = DateTime.Now;
                person.Address = "Los Angelos - California";
                person.Email = "LailaAmjad@gmail.com";
                person.Phone = "+105950595";
                person.CountryId = 185;
                person.ImagePath = null;
                person.Gender = "F";

                if (person.Save())
                {
                    Console.WriteLine("Laila Updated Successfully");
                }
                else
                {
                    Console.WriteLine("Updating Failed");
                }
            }
            static public void PrintAllPeople()
            {
                DataTable dt = Person.GetAllPeople();

                if (dt.Rows.Count == 0)
                {
                    Console.WriteLine("Table Is Empty!");
                }

                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine();
                    Console.WriteLine(new string('-', 40));

                    Console.WriteLine($"Id: {row["PersonId"]}");
                    Console.WriteLine($"NationalNum: {row["NationalNum"]}");
                    Console.WriteLine($"FirstName: {row["FirstName"]}");
                    Console.WriteLine($"SecondName: {row["SecondName"]}");
                    Console.WriteLine($"ThirdName: {row["ThirdName"]}");
                    Console.WriteLine($"LastName: {row["LastName"]}");
                    Console.WriteLine($"BirthDate: {row["BirthDate"]}");
                    Console.WriteLine($"Address: {row["Address"]}");
                    Console.WriteLine($"Email: {row["Email"]}");
                    Console.WriteLine($"Phone: {row["Phone"]}");
                    Console.WriteLine($"CountryId: {row["CountryId"]}");
                    Console.WriteLine($"ImagePath: {row["ImagePath"]}");
                    Console.WriteLine($"Gender: {row["Gender"]}");

                    Console.WriteLine(new string('-', 40));
                }
            }
            static public void TestDelete()
            {
                string NationalNum = "N6";

                if (Person.Delete(NationalNum))
                    Console.WriteLine($"National Number {NationalNum} Deleted Successfully!");
                else
                    Console.WriteLine("Deletion Failed");
            }
            static public void TestGetAllCountries()
            {
                DataTable dt = Country.GetAllCountries();

                if (dt.Rows.Count == 0)
                {
                    Console.WriteLine("Table Is Empty!");
                }

                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine();
                    Console.WriteLine(new string('-', 40));
                    Console.WriteLine(row["CountryId"].ToString() + " : " + row["CountryName"].ToString());
                    Console.WriteLine(new string('-', 40));
                }
            }

            static public void PrintUser(Users user)
            {
                Console.WriteLine(new string('-', 40)); // Separator line for readability
                Console.WriteLine($"ID: {user.UserId}");
                Console.WriteLine($"User Name: {user.UserName}");
                Console.WriteLine($"Person Id: {user.PersonId}");
                Console.WriteLine($"Password: {user.Password}");
                Console.WriteLine($"Is Active: {user.IsActive}");
                Console.WriteLine(new string('-', 40)); // Separator line for readability
            }
            static public void TestUserFindById(int id)
            {
                Users user = Users.Find(id);

                if (user != null)
                {
                    PrintUser(user);
                }
                else
                {
                    Console.WriteLine($"Id: {id} Not Found!");
                }
            }

            static public void TestUserFindByUserName(string username)
            {
                Users user = Users.Find(username);

                if (user != null)
                {
                    PrintUser(user);
                }
                else
                {
                    Console.WriteLine($"username: {username} Not Found!");
                }
            }

            static public void TestFindByUsernameandPassword(string username, string password)
            {
                Users user = Users.Find(username, password);

                if (user != null)
                {
                    PrintUser(user);
                }
                else
                {
                    Console.WriteLine($"username: {username} Not Found!");
                }
            }
        }

        static void Main(string[] args)
        {
            /*            Test.TestFindByNationalNumber("N1");
                        Test.TestFindByNationalNumber("N5");

                        Test.TestFindById(2);
                        Test.TestFindById(5);

                        Test.Update();*/

            /*            Test.TestDelete();
                        Test.PrintAllPeople();*/

            //Test.TestGetAllCountries();

            Test.TestFindByUsernameandPassword("TheAmjadx", "1234");

            Console.ReadKey();
        }
    }
}
