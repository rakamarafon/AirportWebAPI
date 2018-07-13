using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.DataAccessLayer.Model
{
    public class AircraftModel : BaseModelObject
    {       
        public string Name { get; set; }
        public int AirType { get; set; }
        public string ReleaseDate { get; set; }
        public string LifeTime { get; set; }
    }
}
