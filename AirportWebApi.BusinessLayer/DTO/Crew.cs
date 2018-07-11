using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.BusinessLayer.DTO
{
    public class Crew
    {
        private Pilot _pilot;
        private List<Stewardesses> _stewardesses;

        public Pilot Pilot
        {
            get { return _pilot; }
            set { if (value != null) _pilot = value; }
        }

        public List<Stewardesses> Stewardesses
        {
            get { return _stewardesses; }
            set { if (value.Count >= 1) _stewardesses = value; }
        }
    }
}
