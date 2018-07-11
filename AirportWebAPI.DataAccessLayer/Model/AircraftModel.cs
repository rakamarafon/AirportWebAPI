using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.DataAccessLayer.Model
{
    public class AircraftModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public AirTypeModel AirType { get; set; }
        public string ReleaseDate { get; set; }
        public string LifeTime { get; set; }
    }
}
