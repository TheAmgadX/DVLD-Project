using DVLD_Data_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business_Layer
{
    public class ApplicationsTypes
    {
        private bool _Update()
        {
            return ApplicationsTypesDataLayer.Update(Id, Title, Fees);
        }

        public int Id  { get; set; }
        public string Title { get; set; }
        public decimal Fees { get; set; }

        public ApplicationsTypes()
        {
            Id = -1;
            Title = "";
            Fees = 0;
        }
        ApplicationsTypes(int Id, string Title, decimal Fees)
        {
            this.Id = Id;
            this.Title = Title;
            this.Fees = Fees;
        }

        static public DataTable GetAllApplicationsTypes()
        {
            return ApplicationsTypesDataLayer.GetAllApplicationsTypes();
        }

        static public ApplicationsTypes Find(int Id)
        {
            string Title = "";
            decimal fees = 0;

            if (ApplicationsTypesDataLayer.Find(Id, ref Title, ref fees))
            {
                return new ApplicationsTypes(Id, Title, fees);
            }

            return null;
        }

        public bool Save()
        {
            return _Update();
        }

    }
}
