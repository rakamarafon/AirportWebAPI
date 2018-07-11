using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.BusinessLayer.DTO
{
    public class AirType
    {
        private string _model;
        private int _seatsNumber;
        private FlightData _flightData;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int SeatsNumber
        {
            get { return _seatsNumber; }
            set { if (value > 0) _seatsNumber = value; }
        }

        public FlightData FlightData
        {
            get { return _flightData; }
            set { if (value != null) _flightData = value; }
        }
    }
}
