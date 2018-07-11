using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.DataAccessLayer.Model
{
    public class CrewModel : BaseModelObject
    {
        public PilotModel Pilot { get; set; }
        public List<StewardessesModel> Stewardesses { get; set; }
    }
}
