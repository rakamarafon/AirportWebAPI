using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.DataAccessLayer.Model
{
    public class CrewModel
    {
        public int Id { get; set; }
        public PilotModel Pilot { get; set; }
        public List<StewardessesModel> Stewardesses { get; set; }
    }
}
