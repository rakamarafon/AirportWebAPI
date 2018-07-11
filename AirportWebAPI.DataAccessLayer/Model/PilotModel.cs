using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.DataAccessLayer.Model
{
    public class PilotModel : BaseModelObject
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string BirthDate { get; set; }
        public int Experience { get; set; }
    }
}
