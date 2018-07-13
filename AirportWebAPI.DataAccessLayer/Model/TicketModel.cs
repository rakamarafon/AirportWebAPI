using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.DataAccessLayer.Model
{
    public class TicketModel : BaseModelObject
    {
        public double Price { get; set; }
        public string FlightNumber { get; set; }
    }
}
