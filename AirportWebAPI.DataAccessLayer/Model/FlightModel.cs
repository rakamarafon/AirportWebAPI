using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.DataAccessLayer.Model
{
    public class FlightModel
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public PointModel DeparturePoint { get; set; }
        public string DepartureTime { get; set; }
        public PointModel DestinationPoint { get; set; }
        public string DestinationTime { get; set; }
        public List<TicketModel> Tickets { get; set; }
    }
}
