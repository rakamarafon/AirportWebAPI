using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.BusinessLayer.DTO
{
    public class Point
    {
        private int _id;
        private int _countryCode;
        private string _countryName;
        private string _countryAbbreviation;
        private int _cityCode;
        private string _cityName;
        private string _cityAbbreviation;

        public int Id
        {
            get { return _id; }
            set { if (value > 0) _id = value; }
        }

        public int CountryCode
        {
            get { return _countryCode; }
            set { if (value > 0) _countryCode = value; }
        }

        public string CountryName
        {
            get { return _countryName; }
            set { if (value != null) _countryName = value; }
        }
        public string CountryAbbreviation
        {
            get { return _countryAbbreviation; }
            set { if (value != null) _countryAbbreviation = value; }
        }

        public int CityCode
        {
            get { return _cityCode; }
            set { if (value > 0) _cityCode = value; }
        }

        public string CityName
        {
            get { return _cityName; }
            set { if (value != null) _cityName = value; }
        }
        public string CityAbbreviation
        {
            get { return _cityAbbreviation; }
            set { if (value != null) _cityAbbreviation = value; }
        }
    }
}
