﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.DataAccessLayer.Model
{
    public class FlightDataModel
    {
        public int Id { get; set; }
        public int CruisingSpeed { get; set; }
        public int MaxAltitude { get; set; }
        public int FlightRange { get; set; }
        public int Carrying { get; set; }
    }
}
