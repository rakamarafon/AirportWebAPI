using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.DataAccessLayer.Model
{
    public class AirTypeModel
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int  SeatsNumber { get; set; }
        public FlightDataModel FlightData { get; set; }
    }
}
