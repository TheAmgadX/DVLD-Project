using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Data_Layer;

namespace DVLD_Business_Layer
{
    public class LocalLicenseApplication
    {
        /*
            Update
            Add New
            Delete
            Find
            Search
            Check Exist Another Application of the same class for same person 
            save
        */

        static private bool _CheckCurrentApplicationsForPerson(string NationalNum, string ClassName)
        {
            return NewLocalLicenseApplicationDataLayer.
                ExistsMoreThanNewApplicationOfTheSameClass(NationalNum, ClassName);
        }


        private bool _AddNewApplication()
        {
            if (_CheckCurrentApplicationsForPerson(NationalNum, ClassName)) return false;

            return NewLocalLicenseApplicationDataLayer.AddNewApplication(PersonId, ClassId,
                AppDate, Status, UserId);
        }

        private bool _Update()
        {
            return NewLocalLicenseApplicationDataLayer.Update(AppId, ClassName, Status);
        }


        public int AppId { get; set; }
        public int PersonId { get; set; }
        public int ClassId { get; set; }

        public string ClassName { get; set; }
        public DateTime AppDate { get; set; }
        public string Status { get; set; }
        public int UserId { get; set; }

        public string FullName { get; set; }
        
        public string NationalNum { get; set; }

        public int PassedTests { get; set; }

        enum enMode { New, Update };
        enMode Mode;

        public LocalLicenseApplication()
        {
            PersonId = -1;
            ClassId = -1;
            ClassName = string.Empty;
            AppDate = DateTime.MinValue;
            Status = string.Empty;
            UserId = -1;
            FullName = string.Empty;
            NationalNum = string.Empty;
            PassedTests = 0;

            Mode = enMode.New; // Default mode is 'New'
        }

        private LocalLicenseApplication(int id, int classId, int userId,
            DateTime appDate, string status)
        {
            PersonId = id;
            ClassId = classId;
            UserId = userId;
            AppDate = appDate;
            Status = status;
            Mode = enMode.Update; // Already Exist.
        }

        private LocalLicenseApplication(int appId, string className, string nationalId, string fullName,
            DateTime appDate, int passedTests, string status)
        {
            AppId = appId;
            ClassName = className;
            AppDate = appDate;
            Status = status;
            FullName = fullName;
            NationalNum = nationalId;
            PassedTests = passedTests;
            Mode = enMode.Update;
        }

        static public bool Delete(int AppId)
        {
            return NewLocalLicenseApplicationDataLayer.Delete(AppId);
        }

        static public DataTable Search(string Field, string Value)
        {
            return NewLocalLicenseApplicationDataLayer.SearchWithFilter(Field, Value);
        }
        
        static public LocalLicenseApplication Find(int Id)
        {
            string className = "";
            string nationalNum = "";
            string fullName = "";
            int passedTests = 0;
            DateTime appDate = DateTime.MinValue;
            string status = string.Empty;

            if (NewLocalLicenseApplicationDataLayer.Find(Id, ref className, ref nationalNum, ref fullName,
               ref appDate, ref passedTests , ref status))
            {
                return new LocalLicenseApplication(Id, className, nationalNum, fullName, 
                    appDate, passedTests ,status);
            }


            return new LocalLicenseApplication();
        }

        static public bool CancelApplication(int AppId)
        {
            return NewLocalLicenseApplicationDataLayer.CancelApplication(AppId);
        }
        static public DataTable GetAllApplications()
        {
            return NewLocalLicenseApplicationDataLayer.GetAllApplications();
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.New:
                    if(_AddNewApplication())
                    {
                        Mode = enMode.Update; // now it exists in the system.
                        return true;
                    }
                    break;
                case enMode.Update:
                    return _Update();
            }

            return false;
        }
    }
}
