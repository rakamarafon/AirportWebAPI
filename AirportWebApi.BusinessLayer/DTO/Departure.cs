using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.BusinessLayer.DTO
{
    public class Departure
    {
        private string _flightNumber;
        private string _departureTime;
        private Crew _crew;
        private Aircraft _aircraft;

        public string FlightNumber
        {
            get { return _flightNumber; }
            set { if (value != null) _flightNumber = value; }
        }

        public string DepartureTime
        {
            get { return _departureTime; }
            set { if (value != null) _departureTime = value; }
        }

        public Crew CrewMember
        {
            get { return _crew; }
            set { if (value != null) _crew = value; }
        }

        public Aircraft AircraftMember
        {
            get { return _aircraft; }
            set { if (value != null) _aircraft = value; }
        }
    }
}
