using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.BusinessLayer.DTO
{
    public class Pilot : Employee
    {
        private int _experience;
        public int Experience
        {
            get { return _experience; }
            set { if (value >= 0) _experience = value; }
        }
    }
}
