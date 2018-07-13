using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.BusinessLayer.DTO
{
    public class Ticket : BaseObject
    {
        private double _price;
        private string _flightNumber;

        public double Price
        {
            get { return _price; }
            set { if (value > 0) _price = value; }
        }

        public string FlightNumber
        {
            get { return _flightNumber; }
            set { if (value != null) _flightNumber = value; }
        }
    }
}
