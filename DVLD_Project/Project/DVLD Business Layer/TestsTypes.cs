using DVLD_Data_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business_Layer
{
    public class TestsTypes
    {
        private bool _Update()
        {
            return TestsTypesDataLayer.Update(Id, Title, Fees, Description);
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Fees { get; set; }
        public string Description { get; set; }

        public TestsTypes()
        {
            Id = -1;
            Title = "";
            Fees = 0;
            Description = "";
        }
        private TestsTypes(int Id, string Title, decimal Fees, string Description)
        {
            this.Id = Id;
            this.Title = Title;
            this.Fees = Fees;
            this.Description = Description;
        }

        static public DataTable GetAllTestsTypes()
        {
            return TestsTypesDataLayer.GetAllTestsTypes();
        }

        static public TestsTypes Find(int Id)
        {
            string Title = "";
            decimal fees = 0;
            string Description = "";

            if (TestsTypesDataLayer.Find(Id, ref Title, ref fees, ref Description))
            {
                return new TestsTypes(Id, Title, fees, Description);
            }

            return null;
        }

        public bool Save()
        {
            return _Update();
        }
    }
}
