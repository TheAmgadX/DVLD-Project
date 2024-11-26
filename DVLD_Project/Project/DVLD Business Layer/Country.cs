using System;
using System.Data;
using DVLD_Data_Layer;

namespace DVLD_Business_Layer
{
    public class Country
    {
        static public DataTable GetAllCountries()
        {
            return CountriesDataLayer.GetAllCountries();
        }

        static public string GetCountryName(int Id)
        {
            return CountriesDataLayer.GetCountryName(Id);
        }

    }
}
