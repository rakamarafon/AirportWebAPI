using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.DataAccessLayer.Model
{
    public class FlightModel : BaseModelObject
    {
        public string Number { get; set; }
        public int DeparturePoint { get; set; }
        public string DepartureTime { get; set; }
        public int DestinationPoint { get; set; }
        public string DestinationTime { get; set; }
        public List<int> Tickets { get; set; }
    }
}
