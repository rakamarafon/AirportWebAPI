using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.BusinessLayer.DTO
{
    public class FlightData : BaseObject
    {
        private int _cruisingSpeed;
        private int _maxAltitude;
        private int _flightRange;
        private int _carrying;

        public int CruisingSpeed
        {
            get { return _cruisingSpeed; }
            set { if (value > 0) _cruisingSpeed = value; }
        }

        public int MaxAltitude
        {
            get { return _maxAltitude; }
            set { if (value > 0) _maxAltitude = value; }
        }

        public int FlightRange
        {
            get { return _flightRange; }
            set { if (value > 0) _flightRange = value; }
        }

        public int Carrying
        {
            get { return _carrying; }
            set { if (value > 0) _carrying = value; }
        }
    }
}
