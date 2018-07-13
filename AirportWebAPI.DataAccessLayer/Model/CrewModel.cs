using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.DataAccessLayer.Model
{
    public class CrewModel : BaseModelObject
    {
        public int Pilot { get; set; }
        public List<int> Stewardesses { get; set; }
    }
}
