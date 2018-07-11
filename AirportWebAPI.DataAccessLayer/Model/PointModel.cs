using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.DataAccessLayer.Model
{
    public class PointModel
    {
        public int Id { get; set; }
        public int CountryCode { get; set; }
        public string CountryName { get; set; }
        public string CountryAbbreviation { get; set; }
        public int CityCode { get; set; }
        public string CityName { get; set; }
        public string CityAbbreviation { get; set; }
    }
}
