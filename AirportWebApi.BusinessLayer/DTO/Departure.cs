using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.BusinessLayer.DTO
{
    public class Departure
    {
        private string _flightNumber;
        private string _departureTime;
        private int _crew;
        private int _aircraft;

        public string FlightNumber
        {
            get { return _flightNumber; }
            set { if (value != null) _flightNumber = value; }
        }

        public string DepartureDate
        {
            get { return _departureTime; }
            set { if (value != null) _departureTime = value; }
        }

        public int CrewMember
        {
            get { return _crew; }
            set { if (value > 0) _crew = value; }
        }

        public int AircraftMember
        {
            get { return _aircraft; }
            set { if (value > 0) _aircraft = value; }
        }
    }
}
