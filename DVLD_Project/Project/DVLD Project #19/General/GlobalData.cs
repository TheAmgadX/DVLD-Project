using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Business_Layer;

namespace DVLD_Project__19
{
    public class GlobalData
    {
        static public Users CurrentUser { get; set; }

        // Write function to append username and password to a file
        public static void WriteUserToFile(string username, string password, bool rememberUsername)
        {
            string path = @"E:\Programming\Project 19\Project\DVLD Project #19\General\LoginHistory.txt"; // Ensure the path is correct

            // Correct the string formatting
            string line = $"{username}#//#{password}#//#" + (rememberUsername ? "1" : "0"); // Remove extra $ before password

            try
            {
                // Overwrite the file with the user information
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(line); // Write everything in one line
                }
                Console.WriteLine("User information written successfully."); // Debugging output
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }

        // Read function to retrieve users from the file
        // Read function to retrieve just the first user from the file
        public static (Users user, bool rememberUsername) ReadFirstUserFromFile()
        {
            string path = @"E:\Programming\Project 19\Project\DVLD Project #19\General\LoginHistory.txt"; // Ensure the path is correct
            Users foundUser = null;
            bool rememberUsername = false;

            try
            {
                if (File.Exists(path))
                {
                    string[] lines = File.ReadAllLines(path);

                    if (lines.Length > 0)
                    {
                        // Split the first line to extract the username, password, and rememberFlag
                        string[] parts = lines[0].Split(new string[] { "#//#" }, StringSplitOptions.None);

                        if (parts.Length == 3)
                        {
                            foundUser = new Users(parts[0], parts[1]); // Create a user from the username and password
                            rememberUsername = parts[2] == "1"; // Convert the rememberFlag into a boolean
                            Console.WriteLine($"User read successfully: {foundUser.UserName}, Remember: {rememberUsername}"); // Debugging output
                        }
                    }
                    else
                    {
                        Console.WriteLine("No lines found in the file."); // Debugging output
                    }
                }
                else
                {
                    Console.WriteLine("File does not exist."); // Debugging output
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading from file: {ex.Message}");
            }

            return (foundUser, rememberUsername);
        }

        public static void DeleteAllRecords()
        {
            string path = @"E:\\Programming\\Project 19\\Project\\DVLD Project #19\\General\\LoginHistory.txt"; // Path to your text file

            try
            {
                // Open the file in write mode, which will overwrite the file with nothing (clear it)
                using (StreamWriter sw = new StreamWriter(path))
                {
                    // Do nothing; this will just empty the file
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error clearing the file: {ex.Message}");
            }
        }

    }
}
