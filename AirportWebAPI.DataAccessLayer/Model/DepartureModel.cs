using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.DataAccessLayer.Model
{
    public class DepartureModel
    {
        public int id { get; set; }
        public string FlightNumber { get; set; }
        public string DepartureTime { get; set; }
        public CrewModel Crew { get; set; }
        public AircraftModel Aircraft { get; set; }
    }
}
