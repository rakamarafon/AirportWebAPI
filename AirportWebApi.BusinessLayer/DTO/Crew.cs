using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.BusinessLayer.DTO
{
    public class Crew
    {
        private int _pilot;
        private List<int> _stewardesses;

        public int Pilot
        {
            get { return _pilot; }
            set { if (value > 0) _pilot = value; }
        }

        public List<int> Stewardesses
        {
            get { return _stewardesses; }
            set { if (value.Count >= 0) _stewardesses = value; }
        }
    }
}
