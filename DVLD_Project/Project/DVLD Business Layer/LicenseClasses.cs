using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DVLD_Data_Layer;
using System.IO;
using DVLD_Data_Layer.Licenses;

namespace DVLD_Business_Layer
{
    public class LicenseClasses
    {
        public int Id { get; set; }
        public string ClassName { get; set; }

        public string Description { get; set; }

        public int MinAllowedAge { get; set; }

        public int ValidityLength { get; set; }

        public int Fees {  get; set; }

        public LicenseClasses()
        {
            Id = -1;
            ClassName = string.Empty;
            Description = string.Empty;
            MinAllowedAge = 0;
            ValidityLength = 0;
            Fees = 0;
        }

        // Constructor with parameters - initializes the properties with given values
        private LicenseClasses(int id, string className, string description,
            int minAllowedAge, int validityLength, int fees)
        {
            Id = id;
            ClassName = className;
            Description = description;
            MinAllowedAge = minAllowedAge;
            ValidityLength = validityLength;
            Fees = fees;
        }

        static public DataTable GetAllLicenseClasses()
        {
            return LicenseClassesDataLayer.GetAllLicenseClasses();
        }

        static public LicenseClasses SearchForClass(int Id)
        {
            string className = "";
            string description = "";
            int minAllowedAge = 0;
            int validityLength = 0;
            int fees = 0;

            if (LicenseClassesDataLayer.Search(Id, ref className, ref description, ref minAllowedAge,
                ref validityLength, ref fees))
            {
                return new LicenseClasses(Id, className, description, minAllowedAge, validityLength, fees);
            }

            return new LicenseClasses();
        }

        static public LicenseClasses SearchForClass(string className)
        {
            int Id = -1;
            string description = "";
            int minAllowedAge = 0;
            int validityLength = 0;
            int fees = 0;

            if (LicenseClassesDataLayer.Search(ref Id, className, ref description, ref minAllowedAge,
                ref validityLength, ref fees))
            {
                return new LicenseClasses(Id, className, description, minAllowedAge, validityLength, fees);
            }

            return new LicenseClasses();
        }
    }
}
