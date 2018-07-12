using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.DataAccessLayer.Model
{
    public class DepartureModel : BaseModelObject
    {
        public string FlightNumber { get; set; }
        public string DepartureDate { get; set; }
        public int Crew { get; set; }
        public int Aircraft { get; set; }
    }
}
